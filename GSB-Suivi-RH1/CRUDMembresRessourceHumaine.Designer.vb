<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CRUDMembresRessourceHumaine
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(CRUDMembresRessourceHumaine))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.textBoxPrenom = New System.Windows.Forms.TextBox()
        Me.textBoxEmail = New System.Windows.Forms.TextBox()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.textBoxUsername = New System.Windows.Forms.TextBox()
        Me.btnNew = New System.Windows.Forms.Button()
        Me.textBoxPassword = New System.Windows.Forms.TextBox()
        Me.textBoxRepeatPassword = New System.Windows.Forms.TextBox()
        Me.labelRepeatPassword = New System.Windows.Forms.Label()
        Me.labelPassword = New System.Windows.Forms.Label()
        Me.labelUsername = New System.Windows.Forms.Label()
        Me.labelEmail = New System.Windows.Forms.Label()
        Me.labelPrenom = New System.Windows.Forms.Label()
        Me.labelIdentifRender = New System.Windows.Forms.Label()
        Me.lebelIdentifRender = New System.Windows.Forms.Label()
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
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.textBoxPrenom)
        Me.GroupBox1.Controls.Add(Me.textBoxEmail)
        Me.GroupBox1.Controls.Add(Me.btnDelete)
        Me.GroupBox1.Controls.Add(Me.btnSave)
        Me.GroupBox1.Controls.Add(Me.textBoxUsername)
        Me.GroupBox1.Controls.Add(Me.btnNew)
        Me.GroupBox1.Controls.Add(Me.textBoxPassword)
        Me.GroupBox1.Controls.Add(Me.textBoxRepeatPassword)
        Me.GroupBox1.Controls.Add(Me.labelRepeatPassword)
        Me.GroupBox1.Controls.Add(Me.labelPassword)
        Me.GroupBox1.Controls.Add(Me.labelUsername)
        Me.GroupBox1.Controls.Add(Me.labelEmail)
        Me.GroupBox1.Controls.Add(Me.labelPrenom)
        Me.GroupBox1.Controls.Add(Me.labelIdentifRender)
        Me.GroupBox1.Controls.Add(Me.lebelIdentifRender)
        Me.GroupBox1.Controls.Add(Me.labelIdentif)
        Me.GroupBox1.Controls.Add(Me.labelNom)
        Me.GroupBox1.Controls.Add(Me.textBoxNom)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(847, 195)
        Me.GroupBox1.TabIndex = 27
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Details"
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(753, 17)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(88, 23)
        Me.btnReset.TabIndex = 29
        Me.btnReset.Text = "Réinitialiser"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'textBoxPrenom
        '
        Me.textBoxPrenom.Location = New System.Drawing.Point(142, 66)
        Me.textBoxPrenom.Name = "textBoxPrenom"
        Me.textBoxPrenom.Size = New System.Drawing.Size(163, 20)
        Me.textBoxPrenom.TabIndex = 15
        '
        'textBoxEmail
        '
        Me.textBoxEmail.Location = New System.Drawing.Point(142, 89)
        Me.textBoxEmail.Name = "textBoxEmail"
        Me.textBoxEmail.Size = New System.Drawing.Size(163, 20)
        Me.textBoxEmail.TabIndex = 14
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(753, 106)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(88, 23)
        Me.btnDelete.TabIndex = 31
        Me.btnDelete.Text = "Supprimer"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(753, 77)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(88, 23)
        Me.btnSave.TabIndex = 30
        Me.btnSave.Text = "Sauvegarder"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'textBoxUsername
        '
        Me.textBoxUsername.Location = New System.Drawing.Point(142, 113)
        Me.textBoxUsername.Name = "textBoxUsername"
        Me.textBoxUsername.Size = New System.Drawing.Size(163, 20)
        Me.textBoxUsername.TabIndex = 13
        '
        'btnNew
        '
        Me.btnNew.Location = New System.Drawing.Point(753, 46)
        Me.btnNew.Name = "btnNew"
        Me.btnNew.Size = New System.Drawing.Size(88, 23)
        Me.btnNew.TabIndex = 29
        Me.btnNew.Text = "Nouveau"
        Me.btnNew.UseVisualStyleBackColor = True
        '
        'textBoxPassword
        '
        Me.textBoxPassword.Location = New System.Drawing.Point(142, 138)
        Me.textBoxPassword.Name = "textBoxPassword"
        Me.textBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxPassword.Size = New System.Drawing.Size(163, 20)
        Me.textBoxPassword.TabIndex = 12
        '
        'textBoxRepeatPassword
        '
        Me.textBoxRepeatPassword.Location = New System.Drawing.Point(142, 161)
        Me.textBoxRepeatPassword.Name = "textBoxRepeatPassword"
        Me.textBoxRepeatPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.textBoxRepeatPassword.Size = New System.Drawing.Size(163, 20)
        Me.textBoxRepeatPassword.TabIndex = 11
        '
        'labelRepeatPassword
        '
        Me.labelRepeatPassword.AutoSize = True
        Me.labelRepeatPassword.Location = New System.Drawing.Point(6, 164)
        Me.labelRepeatPassword.Name = "labelRepeatPassword"
        Me.labelRepeatPassword.Size = New System.Drawing.Size(130, 13)
        Me.labelRepeatPassword.TabIndex = 10
        Me.labelRepeatPassword.Text = "Retaper le Mot de Passe :"
        '
        'labelPassword
        '
        Me.labelPassword.AutoSize = True
        Me.labelPassword.Location = New System.Drawing.Point(6, 141)
        Me.labelPassword.Name = "labelPassword"
        Me.labelPassword.Size = New System.Drawing.Size(78, 13)
        Me.labelPassword.TabIndex = 9
        Me.labelPassword.Text = "Mot de Passe :"
        '
        'labelUsername
        '
        Me.labelUsername.AutoSize = True
        Me.labelUsername.Location = New System.Drawing.Point(6, 116)
        Me.labelUsername.Name = "labelUsername"
        Me.labelUsername.Size = New System.Drawing.Size(92, 13)
        Me.labelUsername.TabIndex = 8
        Me.labelUsername.Text = "Nom d'Utilisateur :"
        '
        'labelEmail
        '
        Me.labelEmail.AutoSize = True
        Me.labelEmail.Location = New System.Drawing.Point(6, 92)
        Me.labelEmail.Name = "labelEmail"
        Me.labelEmail.Size = New System.Drawing.Size(38, 13)
        Me.labelEmail.TabIndex = 7
        Me.labelEmail.Text = "Email :"
        '
        'labelPrenom
        '
        Me.labelPrenom.AutoSize = True
        Me.labelPrenom.Location = New System.Drawing.Point(6, 69)
        Me.labelPrenom.Name = "labelPrenom"
        Me.labelPrenom.Size = New System.Drawing.Size(49, 13)
        Me.labelPrenom.TabIndex = 6
        Me.labelPrenom.Text = "Prénom :"
        '
        'labelIdentifRender
        '
        Me.labelIdentifRender.AutoSize = True
        Me.labelIdentifRender.Location = New System.Drawing.Point(139, 20)
        Me.labelIdentifRender.Name = "labelIdentifRender"
        Me.labelIdentifRender.Size = New System.Drawing.Size(39, 13)
        Me.labelIdentifRender.TabIndex = 5
        Me.labelIdentifRender.Text = "Label1"
        '
        'lebelIdentifRender
        '
        Me.lebelIdentifRender.AutoSize = True
        Me.lebelIdentifRender.Location = New System.Drawing.Point(67, 20)
        Me.lebelIdentifRender.Name = "lebelIdentifRender"
        Me.lebelIdentifRender.Size = New System.Drawing.Size(0, 13)
        Me.lebelIdentifRender.TabIndex = 4
        '
        'labelIdentif
        '
        Me.labelIdentif.AutoSize = True
        Me.labelIdentif.Location = New System.Drawing.Point(6, 20)
        Me.labelIdentif.Name = "labelIdentif"
        Me.labelIdentif.Size = New System.Drawing.Size(24, 13)
        Me.labelIdentif.TabIndex = 3
        Me.labelIdentif.Text = "ID :"
        '
        'labelNom
        '
        Me.labelNom.AutoSize = True
        Me.labelNom.Location = New System.Drawing.Point(6, 45)
        Me.labelNom.Name = "labelNom"
        Me.labelNom.Size = New System.Drawing.Size(35, 13)
        Me.labelNom.TabIndex = 2
        Me.labelNom.Text = "Nom :"
        '
        'textBoxNom
        '
        Me.textBoxNom.Location = New System.Drawing.Point(142, 42)
        Me.textBoxNom.Name = "textBoxNom"
        Me.textBoxNom.Size = New System.Drawing.Size(163, 20)
        Me.textBoxNom.TabIndex = 1
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 213)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(847, 342)
        Me.DataGridView1.TabIndex = 28
        '
        'CRUDMembresRessourceHumaine
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
        Me.Name = "CRUDMembresRessourceHumaine"
        Me.Text = "Gestion des Membres Ressources Humaines"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents labelIdentifRender As Label
    Friend WithEvents lebelIdentifRender As Label
    Friend WithEvents labelIdentif As Label
    Friend WithEvents labelNom As Label
    Friend WithEvents textBoxNom As TextBox
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnDelete As Button
    Friend WithEvents btnSave As Button
    Friend WithEvents btnNew As Button
    Friend WithEvents labelRepeatPassword As Label
    Friend WithEvents labelPassword As Label
    Friend WithEvents labelUsername As Label
    Friend WithEvents labelEmail As Label
    Friend WithEvents labelPrenom As Label
    Friend WithEvents textBoxPrenom As TextBox
    Friend WithEvents textBoxEmail As TextBox
    Friend WithEvents textBoxUsername As TextBox
    Friend WithEvents textBoxPassword As TextBox
    Friend WithEvents textBoxRepeatPassword As TextBox
    Friend WithEvents btnReset As Button
End Class
