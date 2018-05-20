Public Class MDI

    Private Sub DéconnexionToolStripMenuItem_Click_1(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Dim ConnexionInstance As Connexion = New Connexion()
        ConnexionInstance.Show()
        Me.Close()
    End Sub

    'menu
    Private Sub PersonnesSuiviesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles PersonnesSuiviesToolStripMenuItem.Click
        Dim CRUDPersonneSuivieInstance As New CRUDPersonneSuivie
        CRUDPersonneSuivieInstance.MdiParent = Me
        CRUDPersonneSuivieInstance.Show()
    End Sub

    Private Sub FormationToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles FormationToolStripMenuItem.Click
        Dim CRUDFormationInstance As New CRUDFormation
        CRUDFormationInstance.MdiParent = Me
        CRUDFormationInstance.Show()
    End Sub

    Private Sub RéseauxSociauxToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RéseauxSociauxToolStripMenuItem.Click
        Dim CRUDReseauInstance As New CRUDReseau
        CRUDReseauInstance.MdiParent = Me
        CRUDReseauInstance.Show()
    End Sub

    Private Sub CompétencesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles CompétencesToolStripMenuItem1.Click
        Dim CRUDCompetenceInstance As New CRUDCompetence
        CRUDCompetenceInstance.MdiParent = Me
        CRUDCompetenceInstance.Show()
    End Sub

    Private Sub CatégoriesDeCompétencesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CatégoriesDeCompétencesToolStripMenuItem.Click
        Dim CRUDCategorieInstance As New CRUDCategorie
        CRUDCategorieInstance.MdiParent = Me
        CRUDCategorieInstance.Show()
    End Sub

    Private Sub EntreprisesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles EntreprisesToolStripMenuItem.Click
        Dim CRUDEntrepriseInstance As New CRUDEntreprise
        CRUDEntrepriseInstance.MdiParent = Me
        CRUDEntrepriseInstance.Show()
    End Sub

    Private Sub RégionsToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RégionsToolStripMenuItem.Click
        Dim CRUDRegionInstance As New CRUDRegion
        CRUDRegionInstance.MdiParent = Me
        CRUDRegionInstance.Show()
    End Sub

    Private Sub MembresRessourceHumaineToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MembresRessourceHumaineToolStripMenuItem.Click
        Dim CRUDMembresRessourceHumaineInstance As New CRUDMembresRessourceHumaine
        CRUDMembresRessourceHumaineInstance.MdiParent = Me
        CRUDMembresRessourceHumaineInstance.Show()
    End Sub

    Private Sub StatistiqueToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles StatistiqueToolStripMenuItem.Click
        Dim Statistiques As New Statistiques
        Statistiques.MdiParent = Me
        Statistiques.Show()
    End Sub

    Private Sub RechercheToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles RechercheToolStripMenuItem.Click
        Dim RechercheInstance As New Recherche
        RechercheInstance.MdiParent = Me
        RechercheInstance.Show()
    End Sub
End Class