Public Class CRUDMembresRessourceHumaine

    Dim table As String = "MembreRessourceHumaine"

    'events
    Private Sub CRUD_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.labelIdentifRender.Text = ""
        Me.loadDataGrid()
    End Sub

    Private Sub DataGridView_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
        Dim x As Integer = e.RowIndex

        If x >= 0 Then
            Try
                Me.labelIdentifRender.Text = Me.DataGridView1.Rows(x).Cells(0).Value
                Me.textBoxNom.Text = Me.DataGridView1.Rows(x).Cells(1).Value
                Me.textBoxPrenom.Text = Me.DataGridView1.Rows(x).Cells(2).Value
                Me.textBoxEmail.Text = Me.DataGridView1.Rows(x).Cells(3).Value
                Me.textBoxUsername.Text = Me.DataGridView1.Rows(x).Cells(4).Value
                Me.textBoxPassword.Text = ""
                Me.textBoxRepeatPassword.Text = ""
            Catch ex As Exception
                MessageBox.Show("Erreur de chargement des données")
            End Try
        End If
    End Sub


    'boutons
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.clear() 'clear form
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Me.textBoxPassword.Text = Me.textBoxRepeatPassword.Text Then
            General.BDD.nonQuery("INSERT INTO " & Me.table & "(nom, prenom, email, nomUtilisateur, motDePasse) 
                              VALUES ('" & Me.textBoxNom.Text & "', 
                                      '" & Me.textBoxPrenom.Text & "', 
                                      '" & Me.textBoxEmail.Text & "', 
                                      '" & Me.textBoxUsername.Text & "',
                                      '" & Me.textBoxPassword.Text & "');")
            Me.clear() 'clear form
            Me.loadDataGrid() 'refresh data grid
        Else
            MessageBox.Show("Les mots de passes ne sont pas identiques")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim identif As Integer = Me.labelIdentifRender.Text
        If identif > 0 Then
            General.BDD.nonQuery("UPDATE " & Me.table & " SET nom='" & Me.textBoxNom.Text & "',
                                                              prenom='" & Me.textBoxPrenom.Text & "',
                                                              email='" & Me.textBoxEmail.Text & "',
                                                              nomUtilisateur='" & Me.textBoxUsername.Text & "' 
                                  WHERE identif = '" & identif & "';")
            Me.loadDataGrid() 'refresh data grid


            'update password si les champs sont remplis
            If Me.textBoxPassword.Text And Me.textBoxPassword.Text = Me.textBoxRepeatPassword.Text Then
                General.BDD.nonQuery("Update " & Me.table & " SET motDePasse='" & Me.textBoxPassword.Text & "' WHERE identif = '" & identif & "';")
            End If
            Me.clear() 'clear form
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim identif As Integer = Me.labelIdentifRender.Text
        If identif > 0 Then
            General.BDD.nonQuery("DELETE FROM " & Me.table & " WHERE identif = '" & identif & "';")
            Me.clear() 'clear form
            Me.loadDataGrid() 'refresh data grid
        End If
    End Sub


    'utils
    Private Sub loadDataGrid()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom, prenom, email, nomUtilisateur FROM " & Me.table & ";")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub

    Private Sub clear()
        Me.labelIdentifRender.Text = ""
        Me.textBoxNom.Text = ""
        Me.textBoxPrenom.Text = ""
        Me.textBoxEmail.Text = ""
        Me.textBoxUsername.Text = ""
        Me.textBoxPassword.Text = ""
        Me.textBoxRepeatPassword.Text = ""
    End Sub

End Class