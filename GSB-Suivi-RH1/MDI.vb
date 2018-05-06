Public Class MDI

    Private Sub FormationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormationToolStripMenuItem.Click
        Dim CRUDFormationInstance As New CRUDFormation
        CRUDFormationInstance.MdiParent = Me
        CRUDFormationInstance.Show()
    End Sub

    Private Sub DéconnexionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Dim ConnexionInstance As Connexion = New Connexion()
        ConnexionInstance.Show()
        Me.Close()
    End Sub
End Class