<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MDI
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MDI))
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.PersonnesSuiviesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FormationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RéseauxSociauxToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompétencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CompétencesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.CétégoriesDeCompétencesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EntreprisesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RégionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DéconnexionToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MembresRessourceHumaineToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.PersonnesSuiviesToolStripMenuItem, Me.FormationToolStripMenuItem, Me.RéseauxSociauxToolStripMenuItem, Me.CompétencesToolStripMenuItem, Me.EntreprisesToolStripMenuItem, Me.RégionsToolStripMenuItem, Me.DéconnexionToolStripMenuItem, Me.MembresRessourceHumaineToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(800, 24)
        Me.MenuStrip1.TabIndex = 8
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'PersonnesSuiviesToolStripMenuItem
        '
        Me.PersonnesSuiviesToolStripMenuItem.Name = "PersonnesSuiviesToolStripMenuItem"
        Me.PersonnesSuiviesToolStripMenuItem.Size = New System.Drawing.Size(111, 20)
        Me.PersonnesSuiviesToolStripMenuItem.Text = "Personnes suivies"
        '
        'FormationToolStripMenuItem
        '
        Me.FormationToolStripMenuItem.Name = "FormationToolStripMenuItem"
        Me.FormationToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.FormationToolStripMenuItem.Text = "Formations"
        '
        'RéseauxSociauxToolStripMenuItem
        '
        Me.RéseauxSociauxToolStripMenuItem.Name = "RéseauxSociauxToolStripMenuItem"
        Me.RéseauxSociauxToolStripMenuItem.Size = New System.Drawing.Size(104, 20)
        Me.RéseauxSociauxToolStripMenuItem.Text = "Réseaux Sociaux"
        '
        'CompétencesToolStripMenuItem
        '
        Me.CompétencesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CompétencesToolStripMenuItem1, Me.CétégoriesDeCompétencesToolStripMenuItem})
        Me.CompétencesToolStripMenuItem.Name = "CompétencesToolStripMenuItem"
        Me.CompétencesToolStripMenuItem.Size = New System.Drawing.Size(92, 20)
        Me.CompétencesToolStripMenuItem.Text = "Compétences"
        '
        'CompétencesToolStripMenuItem1
        '
        Me.CompétencesToolStripMenuItem1.Name = "CompétencesToolStripMenuItem1"
        Me.CompétencesToolStripMenuItem1.Size = New System.Drawing.Size(222, 22)
        Me.CompétencesToolStripMenuItem1.Text = "Compétences"
        '
        'CétégoriesDeCompétencesToolStripMenuItem
        '
        Me.CétégoriesDeCompétencesToolStripMenuItem.Name = "CétégoriesDeCompétencesToolStripMenuItem"
        Me.CétégoriesDeCompétencesToolStripMenuItem.Size = New System.Drawing.Size(222, 22)
        Me.CétégoriesDeCompétencesToolStripMenuItem.Text = "Cétégories de Compétences"
        '
        'EntreprisesToolStripMenuItem
        '
        Me.EntreprisesToolStripMenuItem.Name = "EntreprisesToolStripMenuItem"
        Me.EntreprisesToolStripMenuItem.Size = New System.Drawing.Size(76, 20)
        Me.EntreprisesToolStripMenuItem.Text = "Entreprises"
        '
        'RégionsToolStripMenuItem
        '
        Me.RégionsToolStripMenuItem.Name = "RégionsToolStripMenuItem"
        Me.RégionsToolStripMenuItem.Size = New System.Drawing.Size(61, 20)
        Me.RégionsToolStripMenuItem.Text = "Régions"
        '
        'DéconnexionToolStripMenuItem
        '
        Me.DéconnexionToolStripMenuItem.Alignment = System.Windows.Forms.ToolStripItemAlignment.Right
        Me.DéconnexionToolStripMenuItem.Name = "DéconnexionToolStripMenuItem"
        Me.DéconnexionToolStripMenuItem.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.DéconnexionToolStripMenuItem.Size = New System.Drawing.Size(88, 20)
        Me.DéconnexionToolStripMenuItem.Text = "Déconnexion"
        '
        'MembresRessourceHumaineToolStripMenuItem
        '
        Me.MembresRessourceHumaineToolStripMenuItem.Name = "MembresRessourceHumaineToolStripMenuItem"
        Me.MembresRessourceHumaineToolStripMenuItem.Size = New System.Drawing.Size(187, 20)
        Me.MembresRessourceHumaineToolStripMenuItem.Text = "Membres Ressources Humaines"
        '
        'MDI
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "MDI"
        Me.Text = "GSB Profilage Réseaux Sociaux"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents PersonnesSuiviesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents FormationToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RéseauxSociauxToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompétencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CompétencesToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents CétégoriesDeCompétencesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EntreprisesToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RégionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DéconnexionToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MembresRessourceHumaineToolStripMenuItem As ToolStripMenuItem
End Class
