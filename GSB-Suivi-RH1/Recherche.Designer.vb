<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Recherche
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Recherche))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.comboBoxRegion = New System.Windows.Forms.ComboBox()
        Me.comboBoxResponsable = New System.Windows.Forms.ComboBox()
        Me.comboBoxEntreprise = New System.Windows.Forms.ComboBox()
        Me.comboBoxFormation = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.comboBoxCompetence = New System.Windows.Forms.ComboBox()
        Me.label1 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.btnReset)
        Me.GroupBox1.Controls.Add(Me.comboBoxRegion)
        Me.GroupBox1.Controls.Add(Me.comboBoxResponsable)
        Me.GroupBox1.Controls.Add(Me.comboBoxEntreprise)
        Me.GroupBox1.Controls.Add(Me.comboBoxFormation)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.comboBoxCompetence)
        Me.GroupBox1.Controls.Add(Me.label1)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 130)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Recherche"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(216, 100)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Recherche"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.Location = New System.Drawing.Point(351, 76)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(75, 23)
        Me.btnReset.TabIndex = 32
        Me.btnReset.Text = "Réinitialiser"
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'comboBoxRegion
        '
        Me.comboBoxRegion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxRegion.FormattingEnabled = True
        Me.comboBoxRegion.Location = New System.Drawing.Point(351, 19)
        Me.comboBoxRegion.Name = "comboBoxRegion"
        Me.comboBoxRegion.Size = New System.Drawing.Size(139, 21)
        Me.comboBoxRegion.TabIndex = 31
        '
        'comboBoxResponsable
        '
        Me.comboBoxResponsable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxResponsable.FormattingEnabled = True
        Me.comboBoxResponsable.Location = New System.Drawing.Point(351, 46)
        Me.comboBoxResponsable.Name = "comboBoxResponsable"
        Me.comboBoxResponsable.Size = New System.Drawing.Size(139, 21)
        Me.comboBoxResponsable.TabIndex = 30
        '
        'comboBoxEntreprise
        '
        Me.comboBoxEntreprise.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxEntreprise.FormattingEnabled = True
        Me.comboBoxEntreprise.Location = New System.Drawing.Point(89, 73)
        Me.comboBoxEntreprise.Name = "comboBoxEntreprise"
        Me.comboBoxEntreprise.Size = New System.Drawing.Size(139, 21)
        Me.comboBoxEntreprise.TabIndex = 29
        '
        'comboBoxFormation
        '
        Me.comboBoxFormation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxFormation.FormattingEnabled = True
        Me.comboBoxFormation.Location = New System.Drawing.Point(89, 46)
        Me.comboBoxFormation.Name = "comboBoxFormation"
        Me.comboBoxFormation.Size = New System.Drawing.Size(139, 21)
        Me.comboBoxFormation.TabIndex = 28
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 49)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 13)
        Me.Label5.TabIndex = 27
        Me.Label5.Text = "Formation :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(10, 76)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(60, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Entreprise :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(270, 49)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(75, 13)
        Me.Label3.TabIndex = 25
        Me.Label3.Text = "Responsable :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(270, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(47, 13)
        Me.Label2.TabIndex = 24
        Me.Label2.Text = "Région :"
        '
        'comboBoxCompetence
        '
        Me.comboBoxCompetence.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.comboBoxCompetence.FormattingEnabled = True
        Me.comboBoxCompetence.Location = New System.Drawing.Point(89, 19)
        Me.comboBoxCompetence.Name = "comboBoxCompetence"
        Me.comboBoxCompetence.Size = New System.Drawing.Size(139, 21)
        Me.comboBoxCompetence.TabIndex = 22
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Location = New System.Drawing.Point(10, 22)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(73, 13)
        Me.label1.TabIndex = 0
        Me.label1.Text = "Compétence :"
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 149)
        Me.DataGridView1.MultiSelect = False
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.ReadOnly = True
        Me.DataGridView1.Size = New System.Drawing.Size(508, 283)
        Me.DataGridView1.TabIndex = 32
        '
        'Recherche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 444)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(545, 483)
        Me.MinimumSize = New System.Drawing.Size(545, 483)
        Me.Name = "Recherche"
        Me.Text = "Recherche"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents label1 As Label
    Friend WithEvents comboBoxCompetence As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents comboBoxRegion As ComboBox
    Friend WithEvents comboBoxResponsable As ComboBox
    Friend WithEvents comboBoxEntreprise As ComboBox
    Friend WithEvents comboBoxFormation As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btnReset As Button
    Friend WithEvents Button1 As Button
End Class
