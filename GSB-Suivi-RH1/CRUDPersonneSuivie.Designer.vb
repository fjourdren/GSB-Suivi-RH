<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUDPersonneSuivie
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDPersonneSuivie))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnLiaisonEntreprises = New System.Windows.Forms.Button()
        Me.btnLiaisonReseaux = New System.Windows.Forms.Button()
        Me.btnLiaisonFormations = New System.Windows.Forms.Button()
        Me.btnLiaisonCompetences = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.labelResponsable = New System.Windows.Forms.Label()
        Me.labelRegion = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.comboBoxResponsable = New System.Windows.Forms.ComboBox()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.textBoxNote = New System.Windows.Forms.RichTextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.comboBoxRegion = New System.Windows.Forms.ComboBox()
        Me.textBoxTransport = New System.Windows.Forms.RichTextBox()
        Me.labelNote = New System.Windows.Forms.Label()
        Me.dateTimeDateDeNaissance = New System.Windows.Forms.DateTimePicker()
        Me.textBoxEmail = New System.Windows.Forms.TextBox()
        Me.textBoxPrenom = New System.Windows.Forms.TextBox()
        Me.labelTransport = New System.Windows.Forms.Label()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.labelDateDeNaissance = New System.Windows.Forms.Label()
        Me.labelPrenom = New System.Windows.Forms.Label()
        Me.labelIdentifRender = New System.Windows.Forms.Label()
        Me.labelIdentif = New System.Windows.Forms.Label()
        Me.labelNom = New System.Windows.Forms.Label()
        Me.textBoxNom = New System.Windows.Forms.TextBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnLiaisonEntreprises)
        Me.GroupBox1.Controls.Add(Me.btnLiaisonReseaux)
        Me.GroupBox1.Controls.Add(Me.btnLiaisonFormations)
        Me.GroupBox1.Controls.Add(Me.btnLiaisonCompetences)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.labelResponsable)
        Me.GroupBox1.Controls.Add(Me.labelRegion)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.comboBoxResponsable)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.textBoxNote)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.comboBoxRegion)
        Me.GroupBox1.Controls.Add(Me.textBoxTransport)
        Me.GroupBox1.Controls.Add(Me.labelNote)
        Me.GroupBox1.Controls.Add(Me.dateTimeDateDeNaissance)
        Me.GroupBox1.Controls.Add(Me.textBoxEmail)
        Me.GroupBox1.Controls.Add(Me.textBoxPrenom)
        Me.GroupBox1.Controls.Add(Me.labelTransport)
        Me.GroupBox1.Controls.Add(Me.labelEmail)
        Me.GroupBox1.Controls.Add(Me.labelDateDeNaissance)
        Me.GroupBox1.Controls.Add(Me.labelPrenom)
        Me.GroupBox1.Controls.Add(Me.labelIdentifRender)
        Me.GroupBox1.Controls.Add(Me.labelIdentif)
        Me.GroupBox1.Controls.Add(Me.labelNom)
        Me.GroupBox1.Controls.Add(Me.textBoxNom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 195)
        Me.GroupBox1.TabIndex = 22
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'btnLiaisonEntreprises
        '
        Me.btnLiaisonEntreprises.Location = New System.Drawing.Point(621, 136)
        Me.btnLiaisonEntreprises.Name = "btnLiaisonEntreprises"
        Me.btnLiaisonEntreprises.Size = New System.Drawing.Size(88, 23)
        Me.btnLiaisonEntreprises.TabIndex = 31
        Me.btnLiaisonEntreprises.Text = "Entreprises"
        Me.btnLiaisonEntreprises.UseVisualStyleBackColor = True
        '
        'btnLiaisonReseaux
        '
        Me.btnLiaisonReseaux.Location = New System.Drawing.Point(527, 136)
        Me.btnLiaisonReseaux.Name = "btnLiaisonReseaux"
        Me.btnLiaisonReseaux.Size = New System.Drawing.Size(88, 23)
        Me.btnLiaisonReseaux.TabIndex = 30
        Me.btnLiaisonReseaux.Text = "Réseaux"
        Me.btnLiaisonReseaux.UseVisualStyleBackColor = True
        '
        'btnLiaisonFormations
        '
        Me.btnLiaisonFormations.Location = New System.Drawing.Point(433, 136)
        Me.btnLiaisonFormations.Name = "btnLiaisonFormations"
        Me.btnLiaisonFormations.Size = New System.Drawing.Size(88, 23)
        Me.btnLiaisonFormations.TabIndex = 29
        Me.btnLiaisonFormations.Text = "Formations"
        Me.btnLiaisonFormations.UseVisualStyleBackColor = True
        '
        'btnLiaisonCompetences
        '
        Me.btnLiaisonCompetences.Location = New System.Drawing.Point(339, 136)
        Me.btnLiaisonCompetences.Name = "btnLiaisonCompetences"
        Me.btnLiaisonCompetences.Size = New System.Drawing.Size(88, 23)
        Me.btnLiaisonCompetences.TabIndex = 28
        Me.btnLiaisonCompetences.Text = "Compétences"
        Me.btnLiaisonCompetences.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(753, 12)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 23)
        Me.btnReset.TabIndex = 27
        Me.btnReset.Text = "Réinitialiser"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'labelResponsable
        '
        Me.labelResponsable.AutoSize = True
        Me.labelResponsable.Location = New System.Drawing.Point(340, 106)
        Me.labelResponsable.Name = "labelResponsable"
        Me.labelResponsable.Size = New System.Drawing.Size(75, 13)
        Me.labelResponsable.TabIndex = 25
        Me.labelResponsable.Text = "Responsable :"
        '
        'labelRegion
        '
        Me.labelRegion.AutoSize = True
        Me.labelRegion.Location = New System.Drawing.Point(340, 79)
        Me.labelRegion.Name = "labelRegion"
        Me.labelRegion.Size = New System.Drawing.Size(47, 13)
        Me.labelRegion.TabIndex = 24
        Me.labelRegion.Text = "Région :"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(753, 101)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 23)
        Me.btnDelete.TabIndex = 26
        Me.btnDelete.Text = "Supprimer"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'comboBoxResponsable
        '
        Me.comboBoxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxResponsable.FormattingEnabled = True
        Me.comboBoxResponsable.Location = New System.Drawing.Point(452, 103)
        Me.comboBoxResponsable.Name = "comboBoxResponsable"
        Me.comboBoxResponsable.Size = New System.Drawing.Size(163, 21)
        Me.comboBoxResponsable.TabIndex = 23
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(753, 72)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 23)
        Me.btnSave.TabIndex = 25
        Me.btnSave.Text = "Sauvegarder"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'textBoxNote
        '
        Me.textBoxNote.Location = New System.Drawing.Point(452, 13)
        Me.textBoxNote.Name = "textBoxNote"
        Me.textBoxNote.Size = New System.Drawing.Size(163, 57)
        Me.textBoxNote.TabIndex = 22
        Me.textBoxNote.Text = ""
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(753, 41)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 23)
        Me.btnNew.TabIndex = 24
        Me.btnNew.Text = "Nouveau"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'comboBoxRegion
        '
        Me.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxRegion.FormattingEnabled = True
        Me.comboBoxRegion.Location = New System.Drawing.Point(452, 76)
        Me.comboBoxRegion.Name = "comboBoxRegion"
        Me.comboBoxRegion.Size = New System.Drawing.Size(163, 21)
        Me.comboBoxRegion.TabIndex = 21
        '
        'textBoxTransport
        '
        Me.textBoxTransport.Location = New System.Drawing.Point(121, 136)
        Me.textBoxTransport.Name = "textBoxTransport"
        Me.textBoxTransport.Size = New System.Drawing.Size(163, 53)
        Me.textBoxTransport.TabIndex = 20
        Me.textBoxTransport.Text = ""
        '
        'labelNote
        '
        Me.labelNote.AutoSize = True
        Me.labelNote.Location = New System.Drawing.Point(340, 16)
        Me.labelNote.Name = "labelNote"
        Me.labelNote.Size = New System.Drawing.Size(106, 13)
        Me.labelNote.TabIndex = 17
        Me.labelNote.Text = "Note Suplémentaire :"
        '
        'dateTimeDateDeNaissance
        '
        Me.dateTimeDateDeNaissance.CustomFormat = ""
        Me.dateTimeDateDeNaissance.Location = New System.Drawing.Point(121, 107)
        Me.dateTimeDateDeNaissance.Name = "dateTimeDateDeNaissance"
        Me.dateTimeDateDeNaissance.Size = New System.Drawing.Size(163, 20)
        Me.dateTimeDateDeNaissance.TabIndex = 16
        Me.dateTimeDateDeNaissance.Value = New Date(2018, 5, 28, 0, 0, 0, 0)
        '
        'textBoxEmail
        '
        Me.textBoxEmail.Location = New System.Drawing.Point(121, 81)
        Me.textBoxEmail.Name = "textBoxEmail"
        Me.textBoxEmail.Size = New System.Drawing.Size(163, 20)
        Me.textBoxEmail.TabIndex = 13
        '
        'textBoxPrenom
        '
        Me.textBoxPrenom.Location = New System.Drawing.Point(121, 58)
        Me.textBoxPrenom.Name = "textBoxPrenom"
        Me.textBoxPrenom.Size = New System.Drawing.Size(163, 20)
        Me.textBoxPrenom.TabIndex = 12
        '
        'labelTransport
        '
        Me.labelTransport.AutoSize = True
        Me.labelTransport.Location = New System.Drawing.Point(6, 136)
        Me.labelTransport.Name = "labelTransport"
        Me.labelTransport.Size = New System.Drawing.Size(58, 13)
        Me.labelTransport.TabIndex = 11
        Me.labelTransport.Text = "Transport :"
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Location = New System.Drawing.Point(6, 84)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(38, 13)
        Me.labelEmail.TabIndex = 10
        Me.labelEmail.Text = "Email :"
        '
        'labelDateDeNaissance
        '
        Me.labelDateDeNaissance.AutoSize = True
        Me.labelDateDeNaissance.Location = New System.Drawing.Point(6, 113)
        Me.labelDateDeNaissance.Name = "labelDateDeNaissance"
        Me.labelDateDeNaissance.Size = New System.Drawing.Size(104, 13)
        Me.labelDateDeNaissance.TabIndex = 9
        Me.labelDateDeNaissance.Text = "Date de Naissance :"
        '
        'labelPrenom
        '
        Me.labelPrenom.AutoSize = True
        Me.labelPrenom.Location = New System.Drawing.Point(6, 61)
        Me.labelPrenom.Name = "labelPrenom"
        Me.labelPrenom.Size = New System.Drawing.Size(49, 13)
        Me.labelPrenom.TabIndex = 6
        Me.labelPrenom.Text = "Prénom :"
        '
        'labelIdentifRender
        '
        Me.labelIdentifRender.AutoSize = True
        Me.labelIdentifRender.Location = New System.Drawing.Point(118, 16)
        Me.labelIdentifRender.Name = "labelIdentifRender"
        Me.labelIdentifRender.Size = New System.Drawing.Size(39, 13)
        Me.labelIdentifRender.TabIndex = 5
        Me.labelIdentifRender.Text = "Label1"
        '
        'labelIdentif
        '
        Me.labelIdentif.AutoSize = True
        Me.labelIdentif.Location = New System.Drawing.Point(6, 16)
        Me.labelIdentif.Name = "labelIdentif"
        Me.labelIdentif.Size = New System.Drawing.Size(24, 13)
        Me.labelIdentif.TabIndex = 3
        Me.labelIdentif.Text = "ID :"
        '
        'labelNom
        '
        Me.labelNom.AutoSize = True
        Me.labelNom.Location = New System.Drawing.Point(6, 38)
        Me.labelNom.Name = "labelNom"
        Me.labelNom.Size = New System.Drawing.Size(35, 13)
        Me.labelNom.TabIndex = 2
        Me.labelNom.Text = "Nom :"
        '
        'textBoxNom
        '
        Me.textBoxNom.Location = New System.Drawing.Point(121, 35)
        Me.textBoxNom.Name = "textBoxNom"
        Me.textBoxNom.Size = New System.Drawing.Size(163, 20)
        Me.textBoxNom.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 213)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(847, 342)
        Me.DataGridView1.TabIndex = 23
        '
        'CRUDPersonneSuivie
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(871, 568)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(887, 607)
        Me.MinimumSize = New System.Drawing.Size(887, 607)
        Me.Name = "CRUDPersonneSuivie"
        Me.Text = "Gestion des Personnes Suivies"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelIdentifRender As Label
    Friend WithEvents labelIdentif As Label
    Friend WithEvents labelNom As Label
    Friend WithEvents textBoxNom As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents textBoxEmail As TextBox
    Friend WithEvents textBoxPrenom As TextBox
    Friend WithEvents labelTransport As Label
    Friend WithEvents labelEmail As Label
    Friend WithEvents labelDateDeNaissance As Label
    Friend WithEvents labelPrenom As Label
    Friend WithEvents dateTimeDateDeNaissance As DateTimePicker
    Friend WithEvents labelNote As Label
    Friend WithEvents textBoxTransport As RichTextBox
    Friend WithEvents comboBoxRegion As ComboBox
    Friend WithEvents textBoxNote As RichTextBox
    Friend WithEvents labelResponsable As Label
    Friend WithEvents labelRegion As Label
    Friend WithEvents comboBoxResponsable As ComboBox
    Friend WithEvents btnReset As Button
    Friend WithEvents btnLiaisonCompetences As Button
    Friend WithEvents btnLiaisonFormations As Button
    Friend WithEvents btnLiaisonReseaux As Button
    Friend WithEvents btnLiaisonEntreprises As Button
End Class
