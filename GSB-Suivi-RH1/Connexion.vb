Public Class Connexion

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = Me.TextBoxUsername.Text
        Dim password As String = Me.TextBoxPassword.Text

        General.BDD.query("SELECT * FROM MembreRessourceHumaine WHERE nomUtilisateur='" & username & "' AND motDePasse='" & password & "';")
    End Sub

End Class