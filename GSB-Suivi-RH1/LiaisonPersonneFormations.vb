Public Class LiaisonPersonneFormations
    Dim table As String = "Personne_Formation"

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

        ' load formation combo box
        Me.loadComboBoxFormation()

        ' load datagrid des formation de la personne
        Me.loadDataGrid()
    End Sub

    Private Sub LiaisonPersonneFormations_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " " & Me.prenom & " " & Me.nom
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not (Me.comboBoxFormation.SelectedValue = -1) And Not (Me.hasFormation(Me.comboBoxFormation.SelectedValue)) Then
            Dim annee As String = Me.textBoxAnnee.Text
            If String.IsNullOrEmpty(annee) Then
                General.BDD.nonQuery("INSERT INTO " & Me.table & "(identif_Personne, identif_Formation) 
                                      VALUES (" & Me.identif & ", " & Me.comboBoxFormation.SelectedValue & ");")
                Me.loadDataGrid()
            Else
                If Utils.yearIsValid(annee) Then
                    General.BDD.nonQuery("INSERT INTO " & Me.table & "(identif_Personne, identif_Formation, annee) 
                                      VALUES (" & Me.identif & ", " & Me.comboBoxFormation.SelectedValue & ", " & annee & ");")
                    Me.loadDataGrid()
                Else
                    MessageBox.Show("Année non valide")
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        General.BDD.nonQuery("DELETE FROM " & Me.table & " 
                              WHERE identif_Formation = " & Me.comboBoxFormation.SelectedValue & "
                              AND identif_Personne = " & Me.identif & ";")

        Me.loadDataGrid()
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
        'focus formation dans la combobox
        Dim x As Integer = e.RowIndex

        If x >= 0 Then
            Try
                Me.comboBoxFormation.SelectedValue = Me.DataGridView1.Rows(x).Cells(0).Value

                Dim annee As String = ""
                If TypeOf Me.DataGridView1.Rows(x).Cells(2).Value IsNot DBNull Then
                    annee = Me.DataGridView1.Rows(x).Cells(2).Value
                End If
                Me.textBoxAnnee.Text = annee

            Catch ex As Exception
                MessageBox.Show("Erreur de chargement des données")
            End Try
        End If
    End Sub



    Private Sub loadComboBoxFormation()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom 
                                                                           FROM Formation
                                                                           ORDER BY nom;")

        'ajoute les colonnes à la combobox
        Me.comboBoxFormation.DisplayMember = "Text"
        Me.comboBoxFormation.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            tb.Rows.Add(reader.GetString(1), reader.GetInt32(0))
        End While

        'applique les données à la combo
        Me.comboBoxFormation.DataSource = tb
    End Sub



    Private Sub loadDataGrid()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Formation.*, " & Me.table & ".annee
                                                                           FROM " & Me.table & ", Formation
                                                                           WHERE " & Me.table & ".identif_Personne = " & Me.identif & "
                                                                           AND " & Me.table & ".identif_Formation = Formation.identif
                                                                           ORDER BY annee DESC;")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub



    'vérifie si la personne a déjà la formation en passant par un select avant une insertion (évite de planter le programme)
    Private Function hasFormation(ByVal identif_formation As Integer) As Boolean
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * 
                                                                           FROM " & Me.table & " 
                                                                           WHERE identif_Personne = " & Me.identif & "
                                                                           AND identif_Formation = " & identif_formation & "
                                                                           LIMIT 1;")
        If reader.HasRows Then
            While reader.Read()
                Return True
            End While
        End If

        Return False
    End Function

End Class