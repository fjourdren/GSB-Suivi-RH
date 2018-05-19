<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class LiaisonPersonneEntreprises
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(LiaisonPersonneEntreprises))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.labelEmailRender = New System.Windows.Forms.Label()
        Me.labelPrenomRender = New System.Windows.Forms.Label()
        Me.labelNomRender = New System.Windows.Forms.Label()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.labelPrenom = New System.Windows.Forms.Label()
        Me.labelNom = New System.Windows.Forms.Label()
        Me.labelIdentifRender = New System.Windows.Forms.Label()
        Me.labelIdentif = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.labelRegion = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.comboBoxEntreprise = New System.Windows.Forms.ComboBox()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.DateTimeDateDeb = New System.Windows.Forms.DateTimePicker()
        Me.DateTimeDateFin = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.labelEmailRender)
        Me.GroupBox1.Controls.Add(Me.labelPrenomRender)
        Me.GroupBox1.Controls.Add(Me.labelNomRender)
        Me.GroupBox1.Controls.Add(Me.labelEmail)
        Me.GroupBox1.Controls.Add(Me.labelPrenom)
        Me.GroupBox1.Controls.Add(Me.labelNom)
        Me.GroupBox1.Controls.Add(Me.labelIdentifRender)
        Me.GroupBox1.Controls.Add(Me.labelIdentif)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(385, 103)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details Personne Suivie"
        '
        'labelEmailRender
        '
        Me.labelEmailRender.AutoSize = True
        Me.labelEmailRender.Location = New System.Drawing.Point(118, 55)
        Me.labelEmailRender.Name = "labelEmailRender"
        Me.labelEmailRender.Size = New System.Drawing.Size(39, 13)
        Me.labelEmailRender.TabIndex = 16
        Me.labelEmailRender.Text = "Label1"
        '
        'labelPrenomRender
        '
        Me.labelPrenomRender.AutoSize = True
        Me.labelPrenomRender.Location = New System.Drawing.Point(118, 42)
        Me.labelPrenomRender.Name = "labelPrenomRender"
        Me.labelPrenomRender.Size = New System.Drawing.Size(39, 13)
        Me.labelPrenomRender.TabIndex = 15
        Me.labelPrenomRender.Text = "Label1"
        '
        'labelNomRender
        '
        Me.labelNomRender.AutoSize = True
        Me.labelNomRender.Location = New System.Drawing.Point(118, 29)
        Me.labelNomRender.Name = "labelNomRender"
        Me.labelNomRender.Size = New System.Drawing.Size(39, 13)
        Me.labelNomRender.TabIndex = 14
        Me.labelNomRender.Text = "Label1"
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Location = New System.Drawing.Point(6, 55)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(38, 13)
        Me.labelEmail.TabIndex = 13
        Me.labelEmail.Text = "Email :"
        '
        'labelPrenom
        '
        Me.labelPrenom.AutoSize = True
        Me.labelPrenom.Location = New System.Drawing.Point(6, 42)
        Me.labelPrenom.Name = "labelPrenom"
        Me.labelPrenom.Size = New System.Drawing.Size(49, 13)
        Me.labelPrenom.TabIndex = 12
        Me.labelPrenom.Text = "Prénom :"
        '
        'labelNom
        '
        Me.labelNom.AutoSize = True
        Me.labelNom.Location = New System.Drawing.Point(6, 29)
        Me.labelNom.Name = "labelNom"
        Me.labelNom.Size = New System.Drawing.Size(35, 13)
        Me.labelNom.TabIndex = 11
        Me.labelNom.Text = "Nom :"
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
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 121)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(776, 317)
        Me.DataGridView1.TabIndex = 41
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.DateTimeDateFin)
        Me.GroupBox2.Controls.Add(Me.DateTimeDateDeb)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.Label1)
        Me.GroupBox2.Controls.Add(Me.labelRegion)
        Me.GroupBox2.Controls.Add(Me.btnDelete)
        Me.GroupBox2.Controls.Add(Me.comboBoxEntreprise)
        Me.GroupBox2.Controls.Add(Me.btnAdd)
        Me.GroupBox2.Location = New System.Drawing.Point(403, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(385, 103)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Entreprise"
        '
        'labelRegion
        '
        Me.labelRegion.AutoSize = True
        Me.labelRegion.Location = New System.Drawing.Point(6, 18)
        Me.labelRegion.Name = "labelRegion"
        Me.labelRegion.Size = New System.Drawing.Size(60, 13)
        Me.labelRegion.TabIndex = 24
        Me.labelRegion.Text = "Entreprise :"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(291, 42)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 23)
        Me.btnDelete.TabIndex = 28
        Me.btnDelete.Text = "Supprimer"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'comboBoxEntreprise
        '
        Me.comboBoxEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxEntreprise.FormattingEnabled = True
        Me.comboBoxEntreprise.Location = New System.Drawing.Point(122, 13)
        Me.comboBoxEntreprise.Name = "comboBoxEntreprise"
        Me.comboBoxEntreprise.Size = New System.Drawing.Size(163, 21)
        Me.comboBoxEntreprise.TabIndex = 21
        '
        'btnAdd
        '
        Me.btnAdd.Location = New System.Drawing.Point(291, 13)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(88, 23)
        Me.btnAdd.TabIndex = 27
        Me.btnAdd.Text = "Ajouter"
        Me.btnAdd.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 13)
        Me.Label1.TabIndex = 32
        Me.Label1.Text = "Date début :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(50, 13)
        Me.Label2.TabIndex = 34
        Me.Label2.Text = "Date fin :"
        '
        'DateTimeDateDeb
        '
        Me.DateTimeDateDeb.CustomFormat = ""
        Me.DateTimeDateDeb.Location = New System.Drawing.Point(122, 40)
        Me.DateTimeDateDeb.Name = "DateTimeDateDeb"
        Me.DateTimeDateDeb.Size = New System.Drawing.Size(163, 20)
        Me.DateTimeDateDeb.TabIndex = 35
        '
        'DateTimeDateFin
        '
        Me.DateTimeDateFin.CustomFormat = ""
        Me.DateTimeDateFin.Location = New System.Drawing.Point(122, 66)
        Me.DateTimeDateFin.Name = "DateTimeDateFin"
        Me.DateTimeDateFin.Size = New System.Drawing.Size(163, 20)
        Me.DateTimeDateFin.TabIndex = 36
        '
        'LiaisonPersonneEntreprises
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(816, 489)
        Me.MinimumSize = New System.Drawing.Size(816, 489)
        Me.Name = "LiaisonPersonneEntreprises"
        Me.Text = "Gestion des entreprises de"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelEmailRender As Label
    Friend WithEvents labelPrenomRender As Label
    Friend WithEvents labelNomRender As Label
    Friend WithEvents labelEmail As Label
    Friend WithEvents labelPrenom As Label
    Friend WithEvents labelNom As Label
    Friend WithEvents labelIdentifRender As Label
    Friend WithEvents labelIdentif As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents labelRegion As Label
    Friend WithEvents btnDelete As Button
    Friend WithEvents comboBoxEntreprise As ComboBox
    Friend WithEvents btnAdd As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents DateTimeDateFin As DateTimePicker
    Friend WithEvents DateTimeDateDeb As DateTimePicker
End Class
