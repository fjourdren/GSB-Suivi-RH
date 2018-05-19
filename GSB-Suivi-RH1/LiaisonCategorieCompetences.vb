Public Class LiaisonCategorieCompetences
    Dim table As String = "Competence_Categorie"

    Dim identif As Integer
    Dim libelle As String

    Public Sub New(ByVal identif As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        'va chercher la catégorie dans la base de donnée
        Me.identif = identif

        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT libelle 
                                                                           FROM Categorie  
                                                                           WHERE identif = " & Me.identif & " 
                                                                           LIMIT 1;")
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

    Private Sub LiaisonCategorieCompetences_Load(sender As Object, e As EventArgs)
        MessageBox.Show("test")
        Me.Text = Me.Text & " " & Me.libelle
        MessageBox.Show(Me.Text)
    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not (Me.comboBoxCompetence.SelectedIndex = -1) And Not (Me.hasCompetence(Me.comboBoxCompetence.SelectedIndex)) Then
            General.BDD.nonQuery("INSERT INTO " & Me.table & "(identif_Categorie, identif_Competence) 
                                  VALUES (" & Me.identif & ", " & Me.comboBoxCompetence.SelectedIndex & ");")
        End If

        Me.loadDataGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        General.BDD.nonQuery("DELETE FROM " & Me.table & " 
                              WHERE identif_Competence = " & Me.comboBoxCompetence.SelectedValue & "
                              AND identif_Categorie = " & Me.identif & ";")

        Me.loadDataGrid()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
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
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * 
                                                                           FROM Competence
                                                                           ORDER BY libelle;")

        'ajoute les colonnes à la combobox
        Me.comboBoxCompetence.DisplayMember = "Text"
        Me.comboBoxCompetence.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            tb.Rows.Add(reader.GetString(1), reader.GetInt32(0))
        End While

        'applique les données à la combo
        Me.comboBoxCompetence.DataSource = tb
    End Sub



    Private Sub loadDataGrid()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Competence.* 
                                                                           FROM " & Me.table & ", Competence
                                                                           WHERE " & Me.table & ".identif_Competence = Competence.identif 
                                                                           AND " & Me.table & ".identif_Categorie = " & Me.identif & ";")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub



    'vérifie si la categorie a déjà la compétence en passant par un select avant une insertion (évite de planter le programme)
    Private Function hasCompetence(ByVal identif_competence As Integer) As Boolean
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * 
                                                                           FROM " & Me.table & " 
                                                                           WHERE identif_Categorie = " & Me.identif & "
                                                                           AND identif_Competence = " & identif_competence & "
                                                                           LIMIT 1;")
        If reader.HasRows Then
            While reader.Read()
                Return True
            End While
        End If

        Return False
    End Function

    Private Sub LiaisonCategorieCompetences_Load_1(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class