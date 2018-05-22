Public Class Connexion

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = Me.TextBoxUsername.Text
        Dim password As String = Me.TextBoxPassword.Text

        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * FROM MembreRessourceHumaine WHERE nomUtilisateur='" & username & "' AND motDePasse='" & password & "';")

        If Not (reader.HasRows) Then
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorect.")
        Else
            Dim MDIInstance As MDI = New MDI()
            MDIInstance.Show()
            Me.Close()
        End If
    End Sub

End Class