<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Connexion
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Connexion))
        Me.loginBox = New System.Windows.Forms.GroupBox()
        Me.btnLogin = New System.Windows.Forms.Button()
        Me.PasswordLabel = New System.Windows.Forms.Label()
        Me.TextBoxUsername = New System.Windows.Forms.TextBox()
        Me.TextBoxPassword = New System.Windows.Forms.TextBox()
        Me.UsernameLabel = New System.Windows.Forms.Label()
        Me.loginBox.SuspendLayout()
        Me.SuspendLayout()
        '
        'loginBox
        '
        Me.loginBox.Controls.Add(Me.btnLogin)
        Me.loginBox.Controls.Add(Me.PasswordLabel)
        Me.loginBox.Controls.Add(Me.TextBoxUsername)
        Me.loginBox.Controls.Add(Me.TextBoxPassword)
        Me.loginBox.Controls.Add(Me.UsernameLabel)
        Me.loginBox.Location = New System.Drawing.Point(12, 12)
        Me.loginBox.Name = "loginBox"
        Me.loginBox.Size = New System.Drawing.Size(267, 104)
        Me.loginBox.TabIndex = 0
        Me.loginBox.TabStop = False
        Me.loginBox.Text = "Connexion"
        '
        'btnLogin
        '
        Me.btnLogin.Location = New System.Drawing.Point(102, 72)
        Me.btnLogin.Name = "btnLogin"
        Me.btnLogin.Size = New System.Drawing.Size(75, 23)
        Me.btnLogin.TabIndex = 1
        Me.btnLogin.Text = "Connexion"
        Me.btnLogin.UseVisualStyleBackColor = True
        '
        'PasswordLabel
        '
        Me.PasswordLabel.AutoSize = True
        Me.PasswordLabel.Location = New System.Drawing.Point(6, 46)
        Me.PasswordLabel.Name = "PasswordLabel"
        Me.PasswordLabel.Size = New System.Drawing.Size(78, 13)
        Me.PasswordLabel.TabIndex = 5
        Me.PasswordLabel.Text = "Mot de Passe :"
        '
        'TextBoxUsername
        '
        Me.TextBoxUsername.Location = New System.Drawing.Point(102, 19)
        Me.TextBoxUsername.Name = "TextBoxUsername"
        Me.TextBoxUsername.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxUsername.TabIndex = 3
        '
        'TextBoxPassword
        '
        Me.TextBoxPassword.Location = New System.Drawing.Point(102, 46)
        Me.TextBoxPassword.Name = "TextBoxPassword"
        Me.TextBoxPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TextBoxPassword.Size = New System.Drawing.Size(159, 20)
        Me.TextBoxPassword.TabIndex = 2
        '
        'UsernameLabel
        '
        Me.UsernameLabel.AutoSize = True
        Me.UsernameLabel.Location = New System.Drawing.Point(6, 22)
        Me.UsernameLabel.Name = "UsernameLabel"
        Me.UsernameLabel.Size = New System.Drawing.Size(90, 13)
        Me.UsernameLabel.TabIndex = 4
        Me.UsernameLabel.Text = "Nom d'utilisateur :"
        '
        'Connexion
        '
        Me.AcceptButton = Me.btnLogin
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(295, 128)
        Me.Controls.Add(Me.loginBox)
        Me.Cursor = System.Windows.Forms.Cursors.Default
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Location = New System.Drawing.Point(305, 162)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(311, 167)
        Me.MinimumSize = New System.Drawing.Size(311, 167)
        Me.Name = "Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "GSB Profilage Réseaux Sociaux - Connexion"
        Me.loginBox.ResumeLayout(False)
        Me.loginBox.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents loginBox As GroupBox
    Friend WithEvents btnLogin As Button
    Friend WithEvents TextBoxPassword As TextBox
    Friend WithEvents TextBoxUsername As TextBox
    Friend WithEvents UsernameLabel As Label
    Friend WithEvents PasswordLabel As Label
End Class
