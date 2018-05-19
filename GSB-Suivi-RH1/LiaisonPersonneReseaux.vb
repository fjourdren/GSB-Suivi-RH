Public Class LiaisonPersonneReseaux
    Dim table As String = "Personne_Reseau"

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

        ' load reseau combo box
        Me.loadComboBoxReseaux()

        ' load datagrid des reseaux de la personne
        Me.loadDataGrid()
    End Sub

    Private Sub LiaisonPersonneReseaux_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = Me.Text & " " & Me.prenom & " " & Me.nom
    End Sub



    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If Not (Me.comboBoxReseau.SelectedValue = -1) And Not (Me.hasReseau(Me.comboBoxReseau.SelectedValue)) Then
            Dim lien As String = Me.textBoxLien.Text
            If String.IsNullOrEmpty(lien) Then
                General.BDD.nonQuery("INSERT INTO " & Me.table & "(identif_Personne, identif_Reseau) 
                                      VALUES (" & Me.identif & ", " & Me.comboBoxReseau.SelectedValue & ");")
                Me.loadDataGrid()
            Else
                General.BDD.nonQuery("INSERT INTO " & Me.table & "(identif_Personne, identif_Reseau, lien) 
                                      VALUES (" & Me.identif & ", " & Me.comboBoxReseau.SelectedValue & ", '" & lien & "');")
                Me.loadDataGrid()
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        General.BDD.nonQuery("DELETE FROM " & Me.table & " 
                              WHERE identif_Reseau = " & Me.comboBoxReseau.SelectedValue & "
                              AND identif_Personne = " & Me.identif & ";")

        Me.loadDataGrid()
    End Sub

    'bouton d'ouverture du réseau social
    Private Sub btnOpenLien_Click(sender As Object, e As EventArgs) Handles btnOpenLien.Click
        Process.Start(Me.textBoxLien.Text)
    End Sub



    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
        'focus reseau dans la combobox
        Dim x As Integer = e.RowIndex

        If x >= 0 Then
            Try
                Me.comboBoxReseau.SelectedValue = Me.DataGridView1.Rows(x).Cells(0).Value

                Dim lien As String = ""
                If TypeOf Me.DataGridView1.Rows(x).Cells(2).Value IsNot DBNull Then
                    lien = Me.DataGridView1.Rows(x).Cells(2).Value
                End If
                Me.textBoxLien.Text = lien

            Catch ex As Exception
                MessageBox.Show("Erreur de chargement des données")
            End Try
        End If
    End Sub



    Private Sub loadComboBoxReseaux()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom 
                                                                           FROM Reseau
                                                                           ORDER BY nom;")

        'ajoute les colonnes à la combobox
        Me.comboBoxReseau.DisplayMember = "Text"
        Me.comboBoxReseau.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            tb.Rows.Add(reader.GetString(1), reader.GetInt32(0))
        End While

        'applique les données à la combo
        Me.comboBoxReseau.DataSource = tb
    End Sub



    Private Sub loadDataGrid()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Reseau.*, " & Me.table & ".lien
                                                                           FROM " & Me.table & ", Reseau
                                                                           WHERE " & Me.table & ".identif_Personne = " & Me.identif & "
                                                                           AND " & Me.table & ".identif_Reseau = Reseau.identif
                                                                           ORDER BY Reseau.nom;")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub



    'vérifie si la personne a déjà le reseau en passant par un select avant une insertion (évite de planter le programme)
    Private Function hasReseau(ByVal identif_reseau As Integer) As Boolean
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * 
                                                                           FROM " & Me.table & " 
                                                                           WHERE identif_Personne = " & Me.identif & "
                                                                           AND identif_Reseau = " & identif_reseau & "
                                                                           LIMIT 1;")
        If reader.HasRows Then
            While reader.Read()
                Return True
            End While
        End If

        Return False
    End Function

End Class