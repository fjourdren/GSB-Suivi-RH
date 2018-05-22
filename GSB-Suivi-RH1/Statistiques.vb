Public Class Statistiques

    Private Sub Statistiques_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.avgAgeDisplay.Text = Me.averageAgeString()
        Me.minAgeDisplay.Text = Me.minAgeString()
        Me.maxAgeDisplay.Text = Me.maxAgeString()

        Me.nameMostUseDisplay.Text = Me.nameMostUseString()

        Me.countPersonnesDisplay.Text = Me.nbPersonnesString()
        Me.countCompetencesDisplay.Text = Me.nbCompetencesString()
        Me.countEntreprisesDisplay.Text = Me.nbEntreprisesString()
        Me.countCategoriesDisplay.Text = Me.nbCategoriesString()
        Me.countFormationsDisplay.Text = Me.nbFormationsString()

        Me.remplirTopPersonnesAvecCompetences()
        Me.remplirTopFormationsAvecPersonnes()
        Me.remplirTopRegionsAvecPersonnes()
        Me.remplirTopEntreprisesAvecPersonnes()
        Me.remplirTopMembresRessourceHumaineAvecPersonnes()
    End Sub

    'get statistics values
    'age
    Private Function averageAge() As Integer
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT FLOOR(avg(TO_DATE(dateDeNaissance, 'DD/MM/YYYY') - TO_DATE(SYSDATE, 'DD/MM/YYYY'))/365) FROM Personne;")

        While reader.Read()
            Return reader.GetInt32(0)
        End While

        Return -1
    End Function

    Private Function averageAgeString() As String
        Dim avgAge As Integer = Me.averageAge()
        If avgAge = -1 Then
            Return "Erreur de donnée"
        End If

        Return avgAge & " ans"
    End Function



    Private Function minAge() As Integer
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT FLOOR(min(TO_DATE(dateDeNaissance, 'DD/MM/YYYY') - TO_DATE(SYSDATE, 'DD/MM/YYYY'))/365) FROM Personne;")

        While reader.Read()
            Return reader.GetInt32(0)
        End While

        Return -1
    End Function

    Private Function minAgeString() As String
        Dim minAge As Integer = Me.minAge()
        If minAge = -1 Then
            Return "Erreur de donnée"
        End If

        Return minAge & " ans"
    End Function



    Private Function maxAge() As Integer
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT FLOOR(max(TO_DATE(dateDeNaissance, 'DD/MM/YYYY') - TO_DATE(SYSDATE, 'DD/MM/YYYY'))/365) FROM Personne;")

        While reader.Read()
            Return reader.GetInt32(0)
        End While

        Return -1
    End Function

    Private Function maxAgeString() As String
        Dim maxAge As Integer = Me.maxAge()
        If maxAge = -1 Then
            Return "Erreur de donnée"
        End If

        Return maxAge & " ans"
    End Function



    'name
    Private Function nameMostUseString() As String
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT prenom, count(prenom) As nbUtiliser " &
                                                                           "FROM Personne " &
                                                                           "WHERE ROWNUM=1 " &
                                                                           "GROUP BY prenom " &
                                                                           "ORDER BY count(prenom) DESC;")
        If reader.HasRows Then
            While reader.Read()
                Return reader.GetString(0) & " (" & reader.GetInt32(1) & ")"
            End While
        End If

        Return "Erreur de donnée"
    End Function



    'nb element
    Private Function nbPersonnes() As Integer
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT count(identif) As nbPersonne FROM Personne;")

        While reader.Read()
            Return reader.GetInt32(0)
        End While

        Return -1
    End Function

    Private Function nbPersonnesString() As String
        Dim nb As Integer = Me.nbPersonnes()
        If nb = -1 Then
            Return "Erreur de donnée"
        End If

        Return nb
    End Function



    Private Function nbCompetences() As Integer
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT count(identif) As nbCompetence FROM Competence;")

        While reader.Read()
            Return reader.GetInt32(0)
        End While

        Return -1
    End Function

    Private Function nbCompetencesString() As String
        Dim nb As Integer = Me.nbCompetences()
        If nb = -1 Then
            Return "Erreur de donnée"
        End If

        Return nb
    End Function



    Private Function nbEntreprises() As Integer
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT count(identif) As nbEntreprise FROM Entreprise;")

        While reader.Read()
            Return reader.GetInt32(0)
        End While

        Return -1
    End Function

    Private Function nbEntreprisesString() As String
        Dim nb As Integer = Me.nbEntreprises()
        If nb = -1 Then
            Return "Erreur de donnée"
        End If

        Return nb
    End Function



    Private Function nbCategories() As Integer
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT count(identif) As nbCategorie FROM Categorie;")

        While reader.Read()
            Return reader.GetInt32(0)
        End While

        Return -1
    End Function

    Private Function nbCategoriesString() As String
        Dim nb As Integer = Me.nbCategories()
        If nb = -1 Then
            Return "Erreur de donnée"
        End If

        Return nb
    End Function



    Private Function nbFormations() As Integer
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT count(identif) As nbFormation FROM Formation;")

        While reader.Read()
            Return reader.GetInt32(0)
        End While

        Return -1
    End Function

    Private Function nbFormationsString() As String
        Dim nb As Integer = Me.nbFormations()
        If nb = -1 Then
            Return "Erreur de donnée"
        End If

        Return nb
    End Function


    'tops
    Public Sub remplirTopPersonnesAvecCompetences()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Personne.identif, Personne.nom, Personne.prenom, count(Personne_Competence.identif_Competence) As nbCompetence " &
                                                                           "FROM Personne, Personne_Competence " &
                                                                           "WHERE Personne_Competence.identif_Personne=Personne.identif " &
                                                                           "AND ROWNUM <= 5 " &
                                                                           "GROUP BY Personne.identif, Personne.nom, Personne.prenom " &
                                                                           "ORDER BY count(Personne_Competence.identif_Competence) DESC;")
        While reader.Read()
            Dim lab As Label = New Label()
            lab.Text = reader.GetString(1) & " " & reader.GetString(2) & " (" & reader.GetInt32(3) & ")"

            Me.TopPersonnesAvecCompetences.Controls.Add(lab)
        End While
    End Sub


    Public Sub remplirTopFormationsAvecPersonnes()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Formation.identif, Formation.nom, count(Personne_Formation.identif_Personne) As nbPeronne " &
                                                                           "FROM Formation, Personne_Formation " &
                                                                           "WHERE Personne_Formation.identif_Formation=Formation.identif " &
                                                                           "AND ROWNUM <= 5 " &
                                                                           "GROUP BY Formation.identif, Formation.nom " &
                                                                           "ORDER BY count(Personne_Formation.identif_Personne) DESC;")
        While reader.Read()
            Dim lab As Label = New Label()
            lab.Text = reader.GetString(1) & " (" & reader.GetInt32(2) & ")"

            Me.TopFormationsAvecPersonnes.Controls.Add(lab)
        End While
    End Sub


    Public Sub remplirTopRegionsAvecPersonnes()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Region.identif, Region.nom, count(Personne.identif) as nbPersonne " &
                                                                           "FROM Region, Personne " &
                                                                           "WHERE Personne.identif_Region=Region.identif " &
                                                                           "AND ROWNUM <= 5 " &
                                                                           "GROUP BY Region.identif, Region.nom " &
                                                                           "ORDER BY count(Personne.identif) DESC;")
        While reader.Read()
            Dim lab As Label = New Label()
            lab.Text = reader.GetString(1) & " (" & reader.GetInt32(2) & ")"

            Me.TopRegionsAvecPersonnes.Controls.Add(lab)
        End While
    End Sub


    Public Sub remplirTopEntreprisesAvecPersonnes()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT Entreprise.identif, Entreprise.nom, count(Personne_Entreprise.identif_Personne) As nbPeronne " &
                                                                           "FROM Entreprise, Personne_Entreprise " &
                                                                           "WHERE Personne_Entreprise.identif_Entreprise=Entreprise.identif " &
                                                                           "AND ROWNUM <= 5 " &
                                                                           "GROUP BY Entreprise.identif, Entreprise.nom " &
                                                                           "ORDER BY count(Personne_Entreprise.identif_Personne) DESC;")
        While reader.Read()
            Dim lab As Label = New Label()
            lab.Text = reader.GetString(1) & " (" & reader.GetInt32(2) & ")"

            Me.TopEntreprisesAvecPersonnes.Controls.Add(lab)
        End While
    End Sub


    Public Sub remplirTopMembresRessourceHumaineAvecPersonnes()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT MembreRessourceHumaine.identif, MembreRessourceHumaine.nom, MembreRessourceHumaine.prenom, count(Personne.identif) as nbPersonne " &
                                                                           "FROM MembreRessourceHumaine, Personne " &
                                                                           "WHERE Personne.identif_MembreRessourceHumaine=MembreRessourceHumaine.identif " &
                                                                           "AND ROWNUM <= 5 " &
                                                                           "GROUP BY MembreRessourceHumaine.identif, MembreRessourceHumaine.nom, MembreRessourceHumaine.prenom " &
                                                                           "ORDER BY count(Personne.identif) DESC;")
        While reader.Read()
            Dim lab As Label = New Label()
            lab.Text = reader.GetString(1) & " " & reader.GetString(2) & " (" & reader.GetInt32(3) & ")"

            Me.TopMembresRessourceHumaineAvecPersonnes.Controls.Add(lab)
        End While
    End Sub

End Class