Public Class Connexion

    Private Sub btnLogin_Click(sender As Object, e As EventArgs) Handles btnLogin.Click
        Dim username As String = Me.TextBoxUsername.Text
        Dim password As String = Me.TextBoxPassword.Text

        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * FROM MembreRessourceHumaine WHERE nomUtilisateur='" & username & "' AND motDePasse='" & password & "' LIMIT 1;")
        If Not (reader.HasRows) Then
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorect.")
        Else
            Dim CRUDFormationInstance As CRUDFormation = New CRUDFormation()
            CRUDFormationInstance.Show()
            Me.Close()
        End If
    End Sub

End Class