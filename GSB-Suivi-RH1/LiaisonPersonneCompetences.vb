Public Class LiaisonPersonneCompetences

    Dim identif As Integer
    Dim nom As String
    Dim prenom As String
    Dim email As String

    Public Sub New(ByVal identif As Integer)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()

        'va chercher la personne dans la base de donnée
        Me.identif = identif

        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT nom, prenom, email 
                                                                           FROM Personne 
                                                                           WHERE identif = " & Me.identif & " 
                                                                           LIMIT 1;")
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

        ' load competence combo box
        Me.loadComboBoxCompetence()

        ' load datagrid des compétence de la personne
        Me.loadDataGrid()
    End Sub

    Private Sub LiaisonPersonneCompetences_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " " & Me.prenom & " " & Me.nom
    End Sub




    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not (Me.comboBoxCompetence.SelectedIndex = -1) And Not (Me.hasCompetence(Me.comboBoxCompetence.SelectedIndex)) Then
            General.BDD.nonQuery("INSERT INTO personne_competence(identif_Personne, identif_Competence) 
                               VALUES (" & Me.identif & ", " & Me.comboBoxCompetence.SelectedIndex & ");")
        End If

        Me.loadDataGrid()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        General.BDD.nonQuery("DELETE FROM personne_competence 
                           WHERE identif_Competence = " & Me.comboBoxCompetence.SelectedValue & "
                           AND identif_Personne = " & Me.identif & ";")

        Me.loadDataGrid()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
        'focus compétence dans la combobox
        Dim identif_competence = Me.DataGridView1.Rows(0).Cells(0).Value
        If identif_competence Then
            Me.comboBoxCompetence.SelectedValue = identif_competence
        Else
            Me.comboBoxCompetence.SelectedValue = -1
        End If
    End Sub

    Private Sub loadComboBoxCompetence()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * 
                                                                           FROM competence
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
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT competence.* 
                                                                           FROM personne_competence, competence
                                                                           WHERE personne_competence.identif_Competence = competence.identif 
                                                                           AND personne_competence.identif_Personne = " & Me.identif & ";")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub



    'vérifie si la personne a déjà la compétence en passant par un select avant une insertion (évite de planter le programme)
    Private Function hasCompetence(ByVal identif_competence As Integer) As Boolean
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * 
                                                                           FROM personne_competence 
                                                                           WHERE identif_Personne = " & Me.identif & "
                                                                           AND identif_Competence = " & identif_competence & "
                                                                           LIMIT 1;")
        If reader.HasRows Then
            While reader.Read()
                Return True
            End While
        End If

        Return False
    End Function

End Class