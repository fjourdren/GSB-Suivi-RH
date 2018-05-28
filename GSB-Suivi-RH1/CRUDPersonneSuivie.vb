Public Class CRUDPersonneSuivie
    Dim table As String = "Personne"

    'events
    Private Sub CRUD_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
        Me.clear() 'clear form
        Me.loadComboBoxRegion()
        Me.loadComboBoxResponsable()
        Me.loadDataGrid()
    End Sub

    Private Sub DataGridView_CellContentClick(ByVal sender As Object, ByVal e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick, DataGridView1.CellContentDoubleClick, DataGridView1.CellClick
        Dim x As Integer = e.RowIndex

        Try
            If x >= 0 Then
                Me.labelIdentifRender.Text = Me.DataGridView1.Rows(x).Cells(0).Value
                Me.textBoxNom.Text = Me.DataGridView1.Rows(x).Cells(1).Value
                Me.textBoxPrenom.Text = Me.DataGridView1.Rows(x).Cells(2).Value
                Me.textBoxEmail.Text = Me.DataGridView1.Rows(x).Cells(3).Value
                Me.dateTimeDateDeNaissance.Value = Me.DataGridView1.Rows(x).Cells(4).Value

                If Not (TypeOf Me.DataGridView1.Rows(x).Cells(5).Value Is DBNull) Then
                    Me.textBoxTransport.Text = Me.DataGridView1.Rows(x).Cells(5).Value
                Else
                    Me.textBoxTransport.Text = ""
                End If

                If Not (TypeOf Me.DataGridView1.Rows(x).Cells(6).Value Is DBNull) Then
                    Me.textBoxNote.Text = Me.DataGridView1.Rows(x).Cells(6).Value
                Else
                    Me.textBoxNote.Text = ""
                End If



                Me.btnDelete.Enabled = True
                Me.btnSave.Enabled = True

                'show boutons qui nécessite une sélection par l'utilisteur
                Me.btnLiaisonCompetences.Enabled = True
                Me.btnLiaisonFormations.Enabled = True
                Me.btnLiaisonReseaux.Enabled = True
                Me.btnLiaisonEntreprises.Enabled = True


                'focus region
                Try
                    Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT region.identif FROM " & Me.table & ", region WHERE region.identif = " & Me.table & ".identif_Region " &
                                                                                                                                              "AND " & Me.table & ".identif='" & Me.DataGridView1.Rows(x).Cells(0).Value & "';")
                    If reader.HasRows Then
                        While reader.Read()
                            Dim id As Integer = reader.GetInt32(0)
                            Me.comboBoxRegion.SelectedValue = id
                        End While
                    Else
                        Me.comboBoxRegion.SelectedValue = -1
                    End If
                Catch ex As Exception

                End Try



                'focus responsable
                Try
                    Dim readerResponsable As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT MembreRessourceHumaine.identif " &
                                                                                                  "FROM " & Me.table & ", MembreRessourceHumaine " &
                                                                                                  "WHERE MembreRessourceHumaine.identif = " & Me.table & ".identif_MembreRessourceHumaine " &
                                                                                                  "AND " & Me.table & ".identif='" & Me.DataGridView1.Rows(x).Cells(0).Value & "';")
                    If readerResponsable.HasRows Then
                        While readerResponsable.Read()
                            Dim id As Integer = readerResponsable.GetInt32(0)
                            Me.comboBoxResponsable.SelectedValue = id
                        End While
                    Else
                        Me.comboBoxResponsable.SelectedValue = -1
                    End If
                Catch ex As Exception

                End Try
            End If
        Catch ex As Exception
            MessageBox.Show("Erreur de chargement des données")
            Me.clear()
        End Try
    End Sub



    'boutons
    Private Sub btnReset_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnReset.Click
        Me.clear() 'clear form
    End Sub

    Private Sub btnNew_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnNew.Click

        Dim identif_MembreRessourceHumaineValue As Object = Me.comboBoxResponsable.SelectedValue
        Dim identif_regionValue As Object = Me.comboBoxRegion.SelectedValue

        If identif_MembreRessourceHumaineValue = -1 Then
            identif_MembreRessourceHumaineValue = "NULL"
        End If

        If identif_regionValue = -1 Then
            identif_regionValue = "NULL"
        End If

        MessageBox.Show(Me.dateTimeDateDeNaissance.Value)

        General.BDD.nonQuery("INSERT INTO " & Me.table & "(nom, prenom, email, dateDeNaissance, transport, noteRessourceHumaine, identif_MembreRessourceHumaine, identif_Region) " &
                              "VALUES ('" & Me.textBoxNom.Text & "', " &
                                        "'" & Me.textBoxPrenom.Text & "', " &
                                        "'" & Me.textBoxEmail.Text & "'," &
                                        "'" & Me.dateTimeDateDeNaissance.Value & "', " &
                                        "'" & Me.textBoxTransport.Text & "', " &
                                        "'" & Me.textBoxNote.Text & "', " &
                                        "'" & identif_MembreRessourceHumaineValue & "', " &
                                        "'" & identif_regionValue & "');")
        Me.clear() 'clear form
        Me.loadDataGrid() 'refresh data grid
    End Sub

    Private Sub btnSave_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnSave.Click
        Dim identif As Integer = Me.labelIdentifRender.Text
        If identif > 0 Then

            Dim identif_MembreRessourceHumaineValue As Object = Me.comboBoxResponsable.SelectedValue
            Dim identif_regionValue As Object = Me.comboBoxRegion.SelectedValue

            If identif_MembreRessourceHumaineValue = -1 Then
                identif_MembreRessourceHumaineValue = "NULL"
            End If

            If identif_regionValue = -1 Then
                identif_regionValue = "NULL"
            End If

            Dim dateNaissance As String = Convert.ToDateTime(Me.dateTimeDateDeNaissance.Value).ToString("dd/MM/yyyy")
            General.BDD.nonQuery("UPDATE " & Me.table & " SET nom='" & Me.textBoxNom.Text & "', " &
                                                              "prenom='" & Me.textBoxPrenom.Text & "'," &
                                                              "email='" & Me.textBoxEmail.Text & "'," &
                                                              "dateDeNaissance='" & dateNaissance & "'," &
                                                              "transport='" & Me.textBoxTransport.Text & "'," &
                                                              "noteRessourceHumaine='" & Me.textBoxNote.Text & "'," &
                                                              "identif_MembreRessourceHumaine='" & identif_MembreRessourceHumaineValue & "'," &
                                                              "identif_Region='" & identif_regionValue & "'" &
                                  "WHERE identif='" & identif & "';")
            Me.clear() 'clear form
            Me.loadDataGrid() 'refresh data grid
        End If
    End Sub

    Private Sub btnDelete_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnDelete.Click
        Dim identif As Integer = Me.labelIdentifRender.Text
        If identif > 0 Then
            General.BDD.nonQuery("DELETE FROM " & Me.table & " WHERE identif = '" & identif & "';")
            Me.clear() 'clear form
            Me.loadDataGrid() 'refresh data grid
        End If
    End Sub

    Private Sub btnLiaisonCompetences_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLiaisonCompetences.Click
        Dim LiaisonPersonneCompetencesInstance As New LiaisonPersonneCompetences(Me.labelIdentifRender.Text)
        LiaisonPersonneCompetencesInstance.MdiParent = Me.MdiParent
        LiaisonPersonneCompetencesInstance.Show()
    End Sub

    Private Sub btnLiaisonFormations_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLiaisonFormations.Click
        Dim LiaisonPersonnePersonneInstance As New LiaisonPersonneFormations(Me.labelIdentifRender.Text)
        LiaisonPersonnePersonneInstance.MdiParent = Me.MdiParent
        LiaisonPersonnePersonneInstance.Show()
    End Sub

    Private Sub btnLiaisonReseaux_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLiaisonReseaux.Click
        Dim LiaisonPersonneReseauxInstance As New LiaisonPersonneReseaux(Me.labelIdentifRender.Text)
        LiaisonPersonneReseauxInstance.MdiParent = Me.MdiParent
        LiaisonPersonneReseauxInstance.Show()
    End Sub

    Private Sub btnLiaisonEntreprises_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnLiaisonEntreprises.Click
        Dim LiaisonPersonneEntreprisesInterface As New LiaisonPersonneEntreprises(Me.labelIdentifRender.Text)
        LiaisonPersonneEntreprisesInterface.MdiParent = Me.MdiParent
        LiaisonPersonneEntreprisesInterface.Show()
    End Sub



    'utils
    Private Sub loadComboBoxRegion()
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
            Dim id As Integer = reader.GetInt32(0)
            Dim nom As String = reader.GetString(1)
            tb.Rows.Add(nom, id)
        End While

        'applique les données à la combo
        Me.comboBoxRegion.DataSource = tb
    End Sub

    Private Sub loadComboBoxResponsable()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT nom, prenom, identif FROM MembreRessourceHumaine ORDER BY nom, prenom;")

        'ajoute les colonnes à la combobox
        Me.comboBoxResponsable.DisplayMember = "Text"
        Me.comboBoxResponsable.ValueMember = "Value"

        'créer la data table de la combobox
        Dim tb As New DataTable
        tb.Columns.Add("Text", GetType(String))
        tb.Columns.Add("Value", GetType(Integer))

        tb.Rows.Add("", -1)

        While reader.Read()
            Dim nomPrenom As String = reader.GetString(0) & " " & reader.GetString(1)
            Dim id As Integer = reader.GetInt32(2)
            tb.Rows.Add(nomPrenom, id)
        End While

        'applique les données à la combo
        Me.comboBoxResponsable.DataSource = tb
    End Sub

    Private Sub loadDataGrid()
        Dim reader As System.Data.Odbc.OdbcDataReader = General.BDD.query("SELECT identif, nom, prenom, email, dateDeNaissance, transport, noteRessourceHumaine " &
                                                                           "FROM " & Me.table & ";")

        Dim dataTable = New DataTable()
        dataTable.Load(reader)
        DataGridView1.AutoGenerateColumns = True
        DataGridView1.DataSource = dataTable
        DataGridView1.Refresh()
    End Sub



    Private Sub clear()
        Me.btnDelete.Enabled = False
        Me.btnSave.Enabled = False

        'désactive les boutons nécessitant un élément sélectionné
        Me.btnLiaisonCompetences.Enabled = False
        Me.btnLiaisonFormations.Enabled = False
        Me.btnLiaisonReseaux.Enabled = False
        Me.btnLiaisonEntreprises.Enabled = False

        'clear values
        Me.labelIdentifRender.Text = ""
        Me.textBoxNom.Text = ""
        Me.textBoxPrenom.Text = ""
        Me.textBoxEmail.Text = ""
        Me.dateTimeDateDeNaissance.Text = Date.Now
        Me.textBoxTransport.Text = ""
        Me.textBoxNote.Text = ""
        Me.comboBoxResponsable.SelectedValue = -1
        Me.comboBoxRegion.SelectedValue = -1
    End Sub

End Class