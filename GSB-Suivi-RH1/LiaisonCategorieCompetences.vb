Public Class LiaisonCategorieCompetences
    Dim table As String = "Competence_Categorie"

    Dim identif As Integer
    Dim libelle As String

    Public Sub New(ByVal identif As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        'va chercher la catégorie dans la base de donnée
        Me.identif = identif

        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT libelle " &
                                                                           "FROM Categorie " &
                                                                           "WHERE identif = " & Me.identif & ";")
        If reader.HasRows Then
            While reader.Read()
                Me.libelle = reader.GetString(0)
            End While
        Else
            MessageBox.Show("La catégorie n'existe pas")
            Me.Close()
        End If



        ' setup form
        Me.labelIdentifRender.Text = Me.identif
        Me.labelLibelleRender.Text = Me.libelle

        ' load competence combo box
        Me.loadComboBoxCompetence()

        ' load datagrid des compétence de la catégorie
        Me.loadDataGrid()
    End Sub

    Private Sub LiaisonCategorieCompetences_Load(ByVal sender As Object, ByVal e As EventArgs)
        Me.Text = Me.Text & " " & Me.libelle
        MessageBox.Show(Me.Text)
    End Sub




    Private Sub btnAdd_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnAdd.Click
        If Me.comboBoxCompetence.SelectedValue <> -1 And Me.hasCompetence(Me.comboBoxCompetence.SelectedValue) = False Then
            General.BDD.nonQuery("INSERT INTO " & Me.table & "(identif_Categorie, identif_Competence) " &
                                  "VALUES (" & Me.identif & ", " & Me.comboBoxCompetence.SelectedValue & ");")
        End If

        Me.loadDataGrid()
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        General.BDD.nonQuery("DELETE FROM " & Me.table & " " &
                              "WHERE identif_Competence = " & Me.comboBoxCompetence.SelectedValue & " " &
                              "AND identif_Categorie = " & Me.identif & ";")

        Me.loadDataGrid()
    End Sub



    Private Sub DataGridView1_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
        'focus compétence dans la combobox
        Dim x As Integer = e.RowIndex

        If x >= 0 Then
            Try
                Me.comboBoxCompetence.SelectedValue = Me.DataGridView1.Rows(x).Cells(0).Value
            Catch ex As Exception
                MessageBox.Show("Erreur de chargement des données")
            End Try
        End If
    End Sub



    Private Sub loadComboBoxCompetence()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, libelle " &
                                                                           "FROM Competence " &
                                                                           "ORDER BY libelle;")

        'ajoute les colonnes à la combobox
        Me.comboBoxCompetence.DisplayMember = "Text"
        Me.comboBoxCompetence.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            Dim id As Integer = Integer.Parse(reader.GetInt32(0))
            Dim libelle As String = reader.GetString(1)
            tb.Rows.Add(libelle, id)
        End While

        'applique les données à la combo
        Me.comboBoxCompetence.DataSource = tb
    End Sub



    Private Sub loadDataGrid()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Competence.*  " &
                                                                            "FROM Competence_Categorie, Competence  " &
                                                                            "WHERE Competence_Categorie.identif_Competence = Competence.identif  " &
                                                                            "AND Competence_Categorie.identif_Categorie=" & Me.identif & ";")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub



    'vérifie si la categorie a déjà la compétence en passant par un select avant une insertion (évite de planter le programme)
    Private Function hasCompetence(ByVal identif_competence As Integer) As Boolean
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT *  " &
                                                                           "FROM " & Me.table & " " &
                                                                           "WHERE identif_Categorie = " & Me.identif & " " &
                                                                           "AND identif_Competence = " & identif_competence & ";")
        Return reader.HasRows 
    End Function

End Class