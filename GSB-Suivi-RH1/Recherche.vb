Public Class Recherche

    Dim rechercheCollection As New Dictionary(Of String, String)
    Dim sql As String

    Private Sub Recherche_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'load combobox
        Me.loadComboBoxCompetence()
        Me.loadComboBoxFormation()
        Me.loadComboBoxEntreprise()
        Me.loadComboBoxResponsable()
        Me.loadComboBoxRegion()

        'load data grid
        Me.generateRechercheCollection()
        Me.rechercheSqlPourDataGrid()
    End Sub



    'load combo boxs
    Public Sub loadComboBoxCompetence()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, libelle " &
                                                                           "FROM Competence " &
                                                                           "ORDER BY libelle;")

        'ajoute les colonnes à la combobox
        Me.comboBoxCompetence.DisplayMember = "Text"
        Me.comboBoxCompetence.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            Dim id As Integer = Integer.Parse(reader.GetInt32(0))
            Dim libelle As String = reader.GetString(1)
            tb.Rows.Add(libelle, id)
        End While

        'applique les données à la combo
        Me.comboBoxCompetence.DataSource = tb
    End Sub

    Public Sub loadComboBoxFormation()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom " &
                                                                           "FROM Formation " &
                                                                           "ORDER BY nom;")

        'ajoute les colonnes à la combobox
        Me.comboBoxFormation.DisplayMember = "Text"
        Me.comboBoxFormation.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            Dim id As Integer = Integer.Parse(reader.GetInt32(0))
            Dim nom As String = reader.GetString(1)
            tb.Rows.Add(nom, id)
        End While

        'applique les données à la combo
        Me.comboBoxFormation.DataSource = tb
    End Sub

    Public Sub loadComboBoxEntreprise()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom  " &
                                                                           "FROM Entreprise " &
                                                                           "ORDER BY nom;")

        'ajoute les colonnes à la combobox
        Me.comboBoxEntreprise.DisplayMember = "Text"
        Me.comboBoxEntreprise.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            Dim id As Integer = Integer.Parse(reader.GetInt32(0))
            Dim nom As String = reader.GetString(1)
            tb.Rows.Add(nom, id)
        End While

        'applique les données à la combo
        Me.comboBoxEntreprise.DataSource = tb
    End Sub

    Public Sub loadComboBoxRegion()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom " &
                                                                           "FROM Region " &
                                                                           "ORDER BY nom;")

        'ajoute les colonnes à la combobox
        Me.comboBoxRegion.DisplayMember = "Text"
        Me.comboBoxRegion.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            Dim id As Integer = Integer.Parse(reader.GetInt32(0))
            Dim nom As String = reader.GetString(1)
            tb.Rows.Add(nom, id)
        End While

        'applique les données à la combo
        Me.comboBoxRegion.DataSource = tb
    End Sub

    Public Sub loadComboBoxResponsable()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom, prenom " &
                                                                           "FROM MembreRessourceHumaine " &
                                                                           "ORDER BY nom;")

        'ajoute les colonnes à la combobox
        Me.comboBoxResponsable.DisplayMember = "Text"
        Me.comboBoxResponsable.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            Dim id As Integer = Integer.Parse(reader.GetInt32(0))
            Dim nom As String = reader.GetString(1)
            tb.Rows.Add(nom, id)
        End While

        'applique les données à la combo
        Me.comboBoxResponsable.DataSource = tb
    End Sub



    'events
    Private Sub btnRecherche_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.recherche()
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        Me.clear()
    End Sub



    'utils
    Private Sub recherche()
        'load data grid
        Me.generateRechercheCollection()
        Me.rechercheSqlPourDataGrid()
    End Sub

    Private Sub generateRechercheCollection()
        Me.rechercheCollection = New Dictionary(Of String, String)

        If Me.comboBoxCompetence.SelectedValue <> -1 Then
            Me.rechercheCollection.Add("COMPETENCE", Me.comboBoxCompetence.SelectedValue)
        End If

        If Me.comboBoxEntreprise.SelectedValue <> -1 Then
            Me.rechercheCollection.Add("ENTREPRISE", Me.comboBoxEntreprise.SelectedValue)
        End If

        If Me.comboBoxFormation.SelectedValue <> -1 Then
            Me.rechercheCollection.Add("FORMATION", Me.comboBoxFormation.SelectedValue)
        End If

        If Me.comboBoxRegion.SelectedValue <> -1 Then
            Me.rechercheCollection.Add("REGION", Me.comboBoxRegion.SelectedValue)
        End If

        If Me.comboBoxResponsable.SelectedValue <> -1 Then
            Me.rechercheCollection.Add("RESPONSABLE", Me.comboBoxResponsable.SelectedValue)
        End If
    End Sub

    Private Sub rechercheSqlPourDataGrid()
        Me.sql = ""

        If Me.rechercheCollection.Count = 0 Then
            Me.sql = "SELECT identif, nom, prenom FROM Personne;"
        Else
            Me.sql = "SELECT Personne.identif, Personne.nom, Personne.prenom " &
                    "FROM Personne, Competence, Entreprise, Formation, Personne_Competence, Personne_Entreprise, Personne_Formation " &
                    "WHERE Personne.identif = Personne_Competence.identif_Personne " &
                    "AND Competence.identif = Personne_Competence.identif_Competence " &
                    "AND Personne.identif = Personne_Entreprise.identif_Personne " &
                    "AND Entreprise.identif = Personne_Entreprise.identif_Entreprise " &
                    "AND Personne.identif = Personne_Formation.identif_Personne " &
                    "AND Formation.identif = Personne_Formation.identif_Formation"



            For Each kvp As KeyValuePair(Of String, String) In Me.rechercheCollection
                Dim key As String = kvp.Key
                Dim value As String = kvp.Value

                Select Case key
                    Case "COMPETENCE"
                        Me.sql = Me.sql & " AND Competence.identif = " & Me.comboBoxCompetence.SelectedValue
                    Case "FORMATION"
                        Me.sql = Me.sql & " AND Formation.identif = " & Me.comboBoxFormation.SelectedValue
                    Case "ENTREPRISE"
                        Me.sql = Me.sql & " AND Entreprise.identif = " & Me.comboBoxEntreprise.SelectedValue
                    Case "REGION"
                        Me.sql = Me.sql & " AND Personne.identif_Region = " & Me.comboBoxRegion.SelectedValue
                    Case "RESPONSABLE"
                        Me.sql = Me.sql & " AND Personne.identif_MembreRessourceHumaine = " & Me.comboBoxResponsable.SelectedValue
                End Select
            Next

            Me.sql = Me.sql & " GROUP BY Personne.identif, Personne.nom, Personne.prenom;"
        End If



        'requete sql & affichage dans le datagrid
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query(Me.sql)

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub

    Private Sub clear()
        Me.rechercheCollection = New Dictionary(Of String, String)
        Me.sql = ""

        Me.comboBoxCompetence.SelectedValue = -1
        Me.comboBoxEntreprise.SelectedValue = -1
        Me.comboBoxFormation.SelectedValue = -1
        Me.comboBoxRegion.SelectedValue = -1
        Me.comboBoxResponsable.SelectedValue = -1

        Me.generateRechercheCollection()
        Me.rechercheSqlPourDataGrid()
    End Sub

End Class