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

                If Not (TypeOf Me.DataGridView1.Rows(x).Cells(1).Value Is DBNull) Then
                    Me.textBoxNom.Text = Me.DataGridView1.Rows(x).Cells(1).Value
                Else
                    Me.textBoxNom.Text = ""
                End If

                If Not (TypeOf Me.DataGridView1.Rows(x).Cells(2).Value Is DBNull) Then
                    Me.textBoxPrenom.Text = Me.DataGridView1.Rows(x).Cells(2).Value
                Else
                    Me.textBoxPrenom.Text = ""
                End If

                If Not (TypeOf Me.DataGridView1.Rows(x).Cells(3).Value Is DBNull) Then
                    Me.textBoxEmail.Text = Me.DataGridView1.Rows(x).Cells(3).Value
                Else
                    Me.textBoxEmail.Text = ""
                End If

                Me.textBoxUsername.Text = Me.DataGridView1.Rows(x).Cells(4).Value
                Me.textBoxPassword.Text = ""
                Me.textBoxRepeatPassword.Text = ""

                Me.btnDelete.Enabled = True
                Me.btnSave.Enabled = True
            Catch ex As Exception
                MessageBox.Show("Erreur de chargement des données")
                Me.clear()
            End Try
        End If
    End Sub


    'boutons
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.clear() 'clear form
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        If Not (String.IsNullOrEmpty(Me.textBoxPassword.Text)) And Me.textBoxPassword.Text = Me.textBoxRepeatPassword.Text Then
            General.BDD.nonQuery("INSERT INTO " & Me.table & "(nom, prenom, email, nomUtilisateur, motDePasse)" &
                              "VALUES ('" & Replace(Me.textBoxNom.Text, "'", "''") & "', " &
                                      "'" & Replace(Me.textBoxPrenom.Text, "'", "''") & "', " &
                                      "'" & Replace(Me.textBoxEmail.Text, "'", "''") & "', " &
                                      "'" & Replace(Me.textBoxUsername.Text, "'", "''") & "', " &
                                      "'" & Replace(Me.textBoxPassword.Text, "'", "''") & "');")
            Me.clear() 'clear form
            Me.loadDataGrid() 'refresh data grid
        Else
            MessageBox.Show("Les mots de passes ne sont pas identiques")
        End If
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Dim identif As Integer = Me.labelIdentifRender.Text
        If identif > 0 Then
            General.BDD.nonQuery("UPDATE " & Me.table & " SET nom='" & Replace(Me.textBoxNom.Text, "'", "''") & "', " &
                                                              "prenom='" & Replace(Me.textBoxPrenom.Text, "'", "''") & "', " &
                                                              "email='" & Replace(Me.textBoxEmail.Text, "'", "''") & "', " &
                                                              "nomUtilisateur='" & Replace(Me.textBoxUsername.Text, "'", "''") & "' " &
                                  "WHERE identif = '" & identif & "';")
            Me.loadDataGrid() 'refresh data grid


            'update password si les champs sont remplis
            If Not (String.IsNullOrEmpty(Me.textBoxPassword.Text)) Then
                If Me.textBoxPassword.Text = Me.textBoxRepeatPassword.Text Then
                    General.BDD.nonQuery("UPDATE " & Me.table & " SET motDePasse='" & Replace(Me.textBoxPassword.Text, "'", "''") & "' WHERE identif = '" & identif & "';")
                    Me.clear() 'clear form
                Else
                    MessageBox.Show("Les mots de passes ne sont pas identiques")
                End If
            End If
        End If
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim identif As Integer = Integer.Parse(Me.labelIdentifRender.Text)
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
        Me.btnDelete.Enabled = False
        Me.btnSave.Enabled = False

        Me.labelIdentifRender.Text = ""
        Me.textBoxNom.Text = ""
        Me.textBoxPrenom.Text = ""
        Me.textBoxEmail.Text = ""
        Me.textBoxUsername.Text = ""
        Me.textBoxPassword.Text = ""
        Me.textBoxRepeatPassword.Text = ""
    End Sub

End Class