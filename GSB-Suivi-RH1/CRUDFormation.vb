Public Class CRUDFormation
    Private Sub CRUDFormation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT * FROM Formation;")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridViewFormation.AutoGenerateColumns = True
        DataGridViewFormation.DataSource = dataTable
        DataGridViewFormation.Refresh()
    End Sub

    Private Sub DéconnexionToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DéconnexionToolStripMenuItem.Click
        Dim ConnexionInstance As Connexion = New Connexion()
        ConnexionInstance.Show()
        Me.Close()
    End Sub
End Class