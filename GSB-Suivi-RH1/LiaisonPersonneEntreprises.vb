Public Class LiaisonPersonneEntreprises
    Dim table As String = "Personne_Entreprise"

    Dim identif As Integer
    Dim nom As String
    Dim prenom As String
    Dim email As String

    Public Sub New(ByVal identif As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        ' va chercher la personne dans la base de donnée
        Me.identif = identif

        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT nom, prenom, email " &
                                                                           "FROM Personne " &
                                                                           "WHERE identif = " & Me.identif & ";")
        If reader.HasRows Then
            While reader.Read()
                Me.nom = reader.GetString(0)
                Me.prenom = reader.GetString(1)
                Me.email = reader.GetString(2)
            End While
        Else
            MessageBox.Show("La personne suivie n'existe pas")
            Me.Close()
        End If



        ' setup form
        Me.labelIdentifRender.Text = Me.identif
        Me.labelNomRender.Text = Me.nom
        Me.labelPrenomRender.Text = Me.prenom
        Me.labelEmailRender.Text = Me.email

        'setup date
        Me.DateTimeDateDeb.Text = Date.Now
        Me.DateTimeDateFin.Text = Date.Now

        ' load entreprises combo box
        Me.loadComboBoxEntreprises()

        ' load datagrid des entreprises de la personne
        Me.loadDataGrid()
    End Sub

    Private Sub LiaisonPersonneEntreprises_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " " & Me.prenom & " " & Me.nom
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Me.comboBoxEntreprise.SelectedValue <> -1 And Me.hasEntreprise(Me.comboBoxEntreprise.SelectedValue) = False Then
            Dim DateTimeDateDeb As String = Convert.ToDateTime(Me.DateTimeDateDeb.Value).ToString("dd/MM/yyyy")
            Dim DateTimeDateFin As String = Convert.ToDateTime(Me.DateTimeDateFin.Value).ToString("dd/MM/yyyy")
            General.BDD.nonQuery("INSERT INTO " & Me.table & "(identif_Personne, identif_Entreprise, dateDeb, dateFin) " &
                                  "VALUES (" & Me.identif & ", " &
                                  "" & Me.comboBoxEntreprise.SelectedValue & ", " &
                                    "'" & DateTimeDateDeb & "', " &
                                    "'" & DateTimeDateFin & "');")
            Me.loadDataGrid()
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        General.BDD.nonQuery("DELETE FROM " & Me.table & " " &
                              "WHERE identif_Entreprise = " & Me.comboBoxEntreprise.SelectedValue & " " &
                              "AND identif_Personne = " & Me.identif & ";")

        Me.loadDataGrid()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
        'focus entreprise dans la combobox
        Dim x As Integer = e.RowIndex

        If x >= 0 Then
            Try
                Me.comboBoxEntreprise.SelectedValue = Me.DataGridView1.Rows(x).Cells(0).Value
                Me.DateTimeDateDeb.Value = Me.DataGridView1.Rows(x).Cells(2).Value
                Me.DateTimeDateFin.Value = Me.DataGridView1.Rows(x).Cells(3).Value
            Catch ex As Exception
                MessageBox.Show("Erreur de chargement des données")
            End Try
        End If
    End Sub



    Private Sub loadComboBoxEntreprises()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom " &
                                                                           "FROM Entreprise " &
                                                                           "ORDER BY nom;")

        'ajoute les colonnes à la combobox
        Me.comboBoxEntreprise.DisplayMember = "Text"
        Me.comboBoxEntreprise.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            Dim id As Integer = Integer.Parse(reader.GetInt32(0))
            Dim nom As String = reader.GetString(1)
            tb.Rows.Add(nom, id)
        End While

        'applique les données à la combo
        Me.comboBoxEntreprise.DataSource = tb
    End Sub



    Private Sub loadDataGrid()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Entreprise.*, " & Me.table & ".datedeb, " & Me.table & ".datefin " &
                                                                           "FROM " & Me.table & ", Entreprise " &
                                                                           "WHERE " & Me.table & ".identif_Personne = " & Me.identif & " " &
                                                                           "AND " & Me.table & ".identif_Entreprise = Entreprise.identif " &
                                                                           "ORDER BY Entreprise.nom;")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub



    'vérifie si la personne a déjà le entreprise en passant par un select avant une insertion (évite de planter le programme)
    Private Function hasEntreprise(ByVal identif_Entreprise As Integer) As Boolean
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * " &
                                                                           "FROM " & Me.table & " " &
                                                                           "WHERE identif_Personne = " & Me.identif & " " &
                                                                           "AND identif_Entreprise = " & identif_Entreprise & ";")
        Return reader.HasRows

        Return False
    End Function
End Class