<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Statistiques
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Statistiques))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.avgAgeDisplay = New System.Windows.Forms.Label()
        Me.minAgeDisplay = New System.Windows.Forms.Label()
        Me.maxAgeDisplay = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.nameMostUseDisplay = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.countFormationsDisplay = New System.Windows.Forms.Label()
        Me.countCategoriesDisplay = New System.Windows.Forms.Label()
        Me.countEntreprisesDisplay = New System.Windows.Forms.Label()
        Me.countCompetencesDisplay = New System.Windows.Forms.Label()
        Me.countPersonnesDisplay = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.TopPersonnesAvecCompetences = New System.Windows.Forms.TableLayoutPanel()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.TopFormationsAvecPersonnes = New System.Windows.Forms.TableLayoutPanel()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.TopRegionsAvecPersonnes = New System.Windows.Forms.TableLayoutPanel()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label30 = New System.Windows.Forms.Label()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.GroupBox7 = New System.Windows.Forms.GroupBox()
        Me.TopEntreprisesAvecPersonnes = New System.Windows.Forms.TableLayoutPanel()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.TopMembresRessourceHumaineAvecPersonnes = New System.Windows.Forms.TableLayoutPanel()
        Me.Label35 = New System.Windows.Forms.Label()
        Me.Label36 = New System.Windows.Forms.Label()
        Me.Label37 = New System.Windows.Forms.Label()
        Me.Label38 = New System.Windows.Forms.Label()
        Me.Label39 = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox4.SuspendLayout()
        Me.TopPersonnesAvecCompetences.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.TopFormationsAvecPersonnes.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.TopRegionsAvecPersonnes.SuspendLayout()
        Me.GroupBox7.SuspendLayout()
        Me.TopEntreprisesAvecPersonnes.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        Me.TopMembresRessourceHumaineAvecPersonnes.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Age Moyen :"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(5, 29)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Age Minimal :"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(5, 42)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(73, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Age Maximal :"
        '
        'avgAgeDisplay
        '
        Me.avgAgeDisplay.AutoSize = True
        Me.avgAgeDisplay.Location = New System.Drawing.Point(79, 16)
        Me.avgAgeDisplay.Name = "avgAgeDisplay"
        Me.avgAgeDisplay.Size = New System.Drawing.Size(39, 13)
        Me.avgAgeDisplay.TabIndex = 3
        Me.avgAgeDisplay.Text = "Label4"
        '
        'minAgeDisplay
        '
        Me.minAgeDisplay.AutoSize = True
        Me.minAgeDisplay.Location = New System.Drawing.Point(79, 29)
        Me.minAgeDisplay.Name = "minAgeDisplay"
        Me.minAgeDisplay.Size = New System.Drawing.Size(39, 13)
        Me.minAgeDisplay.TabIndex = 4
        Me.minAgeDisplay.Text = "Label5"
        '
        'maxAgeDisplay
        '
        Me.maxAgeDisplay.AutoSize = True
        Me.maxAgeDisplay.Location = New System.Drawing.Point(79, 42)
        Me.maxAgeDisplay.Name = "maxAgeDisplay"
        Me.maxAgeDisplay.Size = New System.Drawing.Size(39, 13)
        Me.maxAgeDisplay.TabIndex = 5
        Me.maxAgeDisplay.Text = "Label6"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(6, 16)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(76, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Le plus utilisé :"
        '
        'nameMostUseDisplay
        '
        Me.nameMostUseDisplay.AutoSize = True
        Me.nameMostUseDisplay.Location = New System.Drawing.Point(114, 16)
        Me.nameMostUseDisplay.Name = "nameMostUseDisplay"
        Me.nameMostUseDisplay.Size = New System.Drawing.Size(45, 13)
        Me.nameMostUseDisplay.TabIndex = 17
        Me.nameMostUseDisplay.Text = "Label10"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.avgAgeDisplay)
        Me.GroupBox1.Controls.Add(Me.minAgeDisplay)
        Me.GroupBox1.Controls.Add(Me.maxAgeDisplay)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(213, 60)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Age Personnes"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.countFormationsDisplay)
        Me.GroupBox2.Controls.Add(Me.countCategoriesDisplay)
        Me.GroupBox2.Controls.Add(Me.countEntreprisesDisplay)
        Me.GroupBox2.Controls.Add(Me.countCompetencesDisplay)
        Me.GroupBox2.Controls.Add(Me.countPersonnesDisplay)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 116)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(213, 86)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Nombre d'éléments"
        '
        'countFormationsDisplay
        '
        Me.countFormationsDisplay.AutoSize = True
        Me.countFormationsDisplay.Location = New System.Drawing.Point(91, 68)
        Me.countFormationsDisplay.Name = "countFormationsDisplay"
        Me.countFormationsDisplay.Size = New System.Drawing.Size(39, 13)
        Me.countFormationsDisplay.TabIndex = 25
        Me.countFormationsDisplay.Text = "Label9"
        '
        'countCategoriesDisplay
        '
        Me.countCategoriesDisplay.AutoSize = True
        Me.countCategoriesDisplay.Location = New System.Drawing.Point(91, 55)
        Me.countCategoriesDisplay.Name = "countCategoriesDisplay"
        Me.countCategoriesDisplay.Size = New System.Drawing.Size(39, 13)
        Me.countCategoriesDisplay.TabIndex = 24
        Me.countCategoriesDisplay.Text = "Label9"
        '
        'countEntreprisesDisplay
        '
        Me.countEntreprisesDisplay.AutoSize = True
        Me.countEntreprisesDisplay.Location = New System.Drawing.Point(91, 42)
        Me.countEntreprisesDisplay.Name = "countEntreprisesDisplay"
        Me.countEntreprisesDisplay.Size = New System.Drawing.Size(39, 13)
        Me.countEntreprisesDisplay.TabIndex = 23
        Me.countEntreprisesDisplay.Text = "Label9"
        '
        'countCompetencesDisplay
        '
        Me.countCompetencesDisplay.AutoSize = True
        Me.countCompetencesDisplay.Location = New System.Drawing.Point(91, 29)
        Me.countCompetencesDisplay.Name = "countCompetencesDisplay"
        Me.countCompetencesDisplay.Size = New System.Drawing.Size(39, 13)
        Me.countCompetencesDisplay.TabIndex = 22
        Me.countCompetencesDisplay.Text = "Label9"
        '
        'countPersonnesDisplay
        '
        Me.countPersonnesDisplay.AutoSize = True
        Me.countPersonnesDisplay.Location = New System.Drawing.Point(91, 16)
        Me.countPersonnesDisplay.Name = "countPersonnesDisplay"
        Me.countPersonnesDisplay.Size = New System.Drawing.Size(39, 13)
        Me.countPersonnesDisplay.TabIndex = 21
        Me.countPersonnesDisplay.Text = "Label9"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(6, 68)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(64, 13)
        Me.Label8.TabIndex = 20
        Me.Label8.Text = "Formations :"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(6, 55)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 19
        Me.Label7.Text = "Catégories :"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 42)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(65, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Entreprises ;"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 29)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Compétences :"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 13)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Personnes :"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.nameMostUseDisplay)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 78)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(213, 32)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Prénoms Personnes :"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.TopPersonnesAvecCompetences)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 213)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(213, 123)
        Me.GroupBox4.TabIndex = 32
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Personnes avec le plus de compétences"
        '
        'TopPersonnesAvecCompetences
        '
        Me.TopPersonnesAvecCompetences.ColumnCount = 2
        Me.TopPersonnesAvecCompetences.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TopPersonnesAvecCompetences.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TopPersonnesAvecCompetences.Controls.Add(Me.Label14, 0, 4)
        Me.TopPersonnesAvecCompetences.Controls.Add(Me.Label10, 0, 0)
        Me.TopPersonnesAvecCompetences.Controls.Add(Me.Label11, 0, 1)
        Me.TopPersonnesAvecCompetences.Controls.Add(Me.Label12, 0, 2)
        Me.TopPersonnesAvecCompetences.Controls.Add(Me.Label13, 0, 3)
        Me.TopPersonnesAvecCompetences.Location = New System.Drawing.Point(6, 19)
        Me.TopPersonnesAvecCompetences.Name = "TopPersonnesAvecCompetences"
        Me.TopPersonnesAvecCompetences.RowCount = 5
        Me.TopPersonnesAvecCompetences.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopPersonnesAvecCompetences.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopPersonnesAvecCompetences.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopPersonnesAvecCompetences.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopPersonnesAvecCompetences.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopPersonnesAvecCompetences.Size = New System.Drawing.Size(200, 100)
        Me.TopPersonnesAvecCompetences.TabIndex = 20
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(3, 80)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(16, 13)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = "5."
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(16, 13)
        Me.Label10.TabIndex = 0
        Me.Label10.Text = "1."
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(3, 20)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(16, 13)
        Me.Label11.TabIndex = 1
        Me.Label11.Text = "2."
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(3, 40)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(16, 13)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "3."
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(3, 60)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(16, 13)
        Me.Label13.TabIndex = 3
        Me.Label13.Text = "4."
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.TopFormationsAvecPersonnes)
        Me.GroupBox5.Location = New System.Drawing.Point(12, 342)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(213, 123)
        Me.GroupBox5.TabIndex = 33
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Formations avec le plus de personnes"
        '
        'TopFormationsAvecPersonnes
        '
        Me.TopFormationsAvecPersonnes.ColumnCount = 2
        Me.TopFormationsAvecPersonnes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TopFormationsAvecPersonnes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TopFormationsAvecPersonnes.Controls.Add(Me.Label16, 0, 4)
        Me.TopFormationsAvecPersonnes.Controls.Add(Me.Label17, 0, 0)
        Me.TopFormationsAvecPersonnes.Controls.Add(Me.Label18, 0, 1)
        Me.TopFormationsAvecPersonnes.Controls.Add(Me.Label19, 0, 2)
        Me.TopFormationsAvecPersonnes.Controls.Add(Me.Label20, 0, 3)
        Me.TopFormationsAvecPersonnes.Location = New System.Drawing.Point(6, 17)
        Me.TopFormationsAvecPersonnes.Name = "TopFormationsAvecPersonnes"
        Me.TopFormationsAvecPersonnes.RowCount = 5
        Me.TopFormationsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopFormationsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopFormationsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopFormationsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopFormationsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopFormationsAvecPersonnes.Size = New System.Drawing.Size(200, 100)
        Me.TopFormationsAvecPersonnes.TabIndex = 22
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(3, 80)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(16, 13)
        Me.Label16.TabIndex = 20
        Me.Label16.Text = "5."
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(3, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(16, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "1."
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(3, 20)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(16, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "2."
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Location = New System.Drawing.Point(3, 40)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(16, 13)
        Me.Label19.TabIndex = 2
        Me.Label19.Text = "3."
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(3, 60)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(16, 13)
        Me.Label20.TabIndex = 3
        Me.Label20.Text = "4."
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.TopRegionsAvecPersonnes)
        Me.GroupBox6.Location = New System.Drawing.Point(231, 28)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(213, 123)
        Me.GroupBox6.TabIndex = 34
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Régions avec le plus de personnes"
        '
        'TopRegionsAvecPersonnes
        '
        Me.TopRegionsAvecPersonnes.ColumnCount = 2
        Me.TopRegionsAvecPersonnes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TopRegionsAvecPersonnes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TopRegionsAvecPersonnes.Controls.Add(Me.Label29, 0, 4)
        Me.TopRegionsAvecPersonnes.Controls.Add(Me.Label30, 0, 0)
        Me.TopRegionsAvecPersonnes.Controls.Add(Me.Label31, 0, 1)
        Me.TopRegionsAvecPersonnes.Controls.Add(Me.Label32, 0, 2)
        Me.TopRegionsAvecPersonnes.Controls.Add(Me.Label33, 0, 3)
        Me.TopRegionsAvecPersonnes.Location = New System.Drawing.Point(6, 19)
        Me.TopRegionsAvecPersonnes.Name = "TopRegionsAvecPersonnes"
        Me.TopRegionsAvecPersonnes.RowCount = 5
        Me.TopRegionsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopRegionsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopRegionsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopRegionsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopRegionsAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopRegionsAvecPersonnes.Size = New System.Drawing.Size(200, 100)
        Me.TopRegionsAvecPersonnes.TabIndex = 24
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Location = New System.Drawing.Point(3, 80)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(16, 13)
        Me.Label29.TabIndex = 20
        Me.Label29.Text = "5."
        '
        'Label30
        '
        Me.Label30.AutoSize = True
        Me.Label30.Location = New System.Drawing.Point(3, 0)
        Me.Label30.Name = "Label30"
        Me.Label30.Size = New System.Drawing.Size(16, 13)
        Me.Label30.TabIndex = 0
        Me.Label30.Text = "1."
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Location = New System.Drawing.Point(3, 20)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(16, 13)
        Me.Label31.TabIndex = 1
        Me.Label31.Text = "2."
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Location = New System.Drawing.Point(3, 40)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(16, 13)
        Me.Label32.TabIndex = 2
        Me.Label32.Text = "3."
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Location = New System.Drawing.Point(3, 60)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(16, 13)
        Me.Label33.TabIndex = 3
        Me.Label33.Text = "4."
        '
        'GroupBox7
        '
        Me.GroupBox7.Controls.Add(Me.TopEntreprisesAvecPersonnes)
        Me.GroupBox7.Location = New System.Drawing.Point(231, 162)
        Me.GroupBox7.Name = "GroupBox7"
        Me.GroupBox7.Size = New System.Drawing.Size(213, 123)
        Me.GroupBox7.TabIndex = 35
        Me.GroupBox7.TabStop = False
        Me.GroupBox7.Text = "Entreprises avec le plus de personnes"
        '
        'TopEntreprisesAvecPersonnes
        '
        Me.TopEntreprisesAvecPersonnes.ColumnCount = 2
        Me.TopEntreprisesAvecPersonnes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TopEntreprisesAvecPersonnes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TopEntreprisesAvecPersonnes.Controls.Add(Me.Label23, 0, 4)
        Me.TopEntreprisesAvecPersonnes.Controls.Add(Me.Label24, 0, 0)
        Me.TopEntreprisesAvecPersonnes.Controls.Add(Me.Label25, 0, 1)
        Me.TopEntreprisesAvecPersonnes.Controls.Add(Me.Label26, 0, 2)
        Me.TopEntreprisesAvecPersonnes.Controls.Add(Me.Label27, 0, 3)
        Me.TopEntreprisesAvecPersonnes.Location = New System.Drawing.Point(6, 17)
        Me.TopEntreprisesAvecPersonnes.Name = "TopEntreprisesAvecPersonnes"
        Me.TopEntreprisesAvecPersonnes.RowCount = 5
        Me.TopEntreprisesAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopEntreprisesAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopEntreprisesAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopEntreprisesAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopEntreprisesAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopEntreprisesAvecPersonnes.Size = New System.Drawing.Size(200, 100)
        Me.TopEntreprisesAvecPersonnes.TabIndex = 26
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(3, 80)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(16, 13)
        Me.Label23.TabIndex = 20
        Me.Label23.Text = "5."
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(3, 0)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(16, 13)
        Me.Label24.TabIndex = 0
        Me.Label24.Text = "1."
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(3, 20)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(16, 13)
        Me.Label25.TabIndex = 1
        Me.Label25.Text = "2."
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Location = New System.Drawing.Point(3, 40)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(16, 13)
        Me.Label26.TabIndex = 2
        Me.Label26.Text = "3."
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Location = New System.Drawing.Point(3, 60)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(16, 13)
        Me.Label27.TabIndex = 3
        Me.Label27.Text = "4."
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.TopMembresRessourceHumaineAvecPersonnes)
        Me.GroupBox8.Location = New System.Drawing.Point(231, 292)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(213, 142)
        Me.GroupBox8.TabIndex = 36
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Ressources Humaines avec le plus de Personnes"
        '
        'TopMembresRessourceHumaineAvecPersonnes
        '
        Me.TopMembresRessourceHumaineAvecPersonnes.ColumnCount = 2
        Me.TopMembresRessourceHumaineAvecPersonnes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 22.0!))
        Me.TopMembresRessourceHumaineAvecPersonnes.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 178.0!))
        Me.TopMembresRessourceHumaineAvecPersonnes.Controls.Add(Me.Label35, 0, 4)
        Me.TopMembresRessourceHumaineAvecPersonnes.Controls.Add(Me.Label36, 0, 0)
        Me.TopMembresRessourceHumaineAvecPersonnes.Controls.Add(Me.Label37, 0, 1)
        Me.TopMembresRessourceHumaineAvecPersonnes.Controls.Add(Me.Label38, 0, 2)
        Me.TopMembresRessourceHumaineAvecPersonnes.Controls.Add(Me.Label39, 0, 3)
        Me.TopMembresRessourceHumaineAvecPersonnes.Location = New System.Drawing.Point(6, 36)
        Me.TopMembresRessourceHumaineAvecPersonnes.Name = "TopMembresRessourceHumaineAvecPersonnes"
        Me.TopMembresRessourceHumaineAvecPersonnes.RowCount = 5
        Me.TopMembresRessourceHumaineAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopMembresRessourceHumaineAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopMembresRessourceHumaineAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopMembresRessourceHumaineAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopMembresRessourceHumaineAvecPersonnes.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20.0!))
        Me.TopMembresRessourceHumaineAvecPersonnes.Size = New System.Drawing.Size(200, 100)
        Me.TopMembresRessourceHumaineAvecPersonnes.TabIndex = 28
        '
        'Label35
        '
        Me.Label35.AutoSize = True
        Me.Label35.Location = New System.Drawing.Point(3, 80)
        Me.Label35.Name = "Label35"
        Me.Label35.Size = New System.Drawing.Size(16, 13)
        Me.Label35.TabIndex = 20
        Me.Label35.Text = "5."
        '
        'Label36
        '
        Me.Label36.AutoSize = True
        Me.Label36.Location = New System.Drawing.Point(3, 0)
        Me.Label36.Name = "Label36"
        Me.Label36.Size = New System.Drawing.Size(16, 13)
        Me.Label36.TabIndex = 0
        Me.Label36.Text = "1."
        '
        'Label37
        '
        Me.Label37.AutoSize = True
        Me.Label37.Location = New System.Drawing.Point(3, 20)
        Me.Label37.Name = "Label37"
        Me.Label37.Size = New System.Drawing.Size(16, 13)
        Me.Label37.TabIndex = 1
        Me.Label37.Text = "2."
        '
        'Label38
        '
        Me.Label38.AutoSize = True
        Me.Label38.Location = New System.Drawing.Point(3, 40)
        Me.Label38.Name = "Label38"
        Me.Label38.Size = New System.Drawing.Size(16, 13)
        Me.Label38.TabIndex = 2
        Me.Label38.Text = "3."
        '
        'Label39
        '
        Me.Label39.AutoSize = True
        Me.Label39.Location = New System.Drawing.Point(3, 60)
        Me.Label39.Name = "Label39"
        Me.Label39.Size = New System.Drawing.Size(16, 13)
        Me.Label39.TabIndex = 3
        Me.Label39.Text = "4."
        '
        'Statistiques
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(453, 472)
        Me.Controls.Add(Me.GroupBox8)
        Me.Controls.Add(Me.GroupBox7)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(469, 511)
        Me.MinimumSize = New System.Drawing.Size(469, 511)
        Me.Name = "Statistiques"
        Me.Text = "Statistiques"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.GroupBox4.ResumeLayout(False)
        Me.TopPersonnesAvecCompetences.ResumeLayout(False)
        Me.TopPersonnesAvecCompetences.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.TopFormationsAvecPersonnes.ResumeLayout(False)
        Me.TopFormationsAvecPersonnes.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.TopRegionsAvecPersonnes.ResumeLayout(False)
        Me.TopRegionsAvecPersonnes.PerformLayout()
        Me.GroupBox7.ResumeLayout(False)
        Me.TopEntreprisesAvecPersonnes.ResumeLayout(False)
        Me.TopEntreprisesAvecPersonnes.PerformLayout()
        Me.GroupBox8.ResumeLayout(False)
        Me.TopMembresRessourceHumaineAvecPersonnes.ResumeLayout(False)
        Me.TopMembresRessourceHumaineAvecPersonnes.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents avgAgeDisplay As Label
    Friend WithEvents minAgeDisplay As Label
    Friend WithEvents maxAgeDisplay As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents nameMostUseDisplay As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents countFormationsDisplay As Label
    Friend WithEvents countCategoriesDisplay As Label
    Friend WithEvents countEntreprisesDisplay As Label
    Friend WithEvents countCompetencesDisplay As Label
    Friend WithEvents countPersonnesDisplay As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents TopPersonnesAvecCompetences As TableLayoutPanel
    Friend WithEvents Label14 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents GroupBox5 As GroupBox
    Friend WithEvents TopFormationsAvecPersonnes As TableLayoutPanel
    Friend WithEvents Label16 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents Label18 As Label
    Friend WithEvents Label19 As Label
    Friend WithEvents Label20 As Label
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents TopRegionsAvecPersonnes As TableLayoutPanel
    Friend WithEvents Label29 As Label
    Friend WithEvents Label30 As Label
    Friend WithEvents Label31 As Label
    Friend WithEvents Label32 As Label
    Friend WithEvents Label33 As Label
    Friend WithEvents GroupBox7 As GroupBox
    Friend WithEvents TopEntreprisesAvecPersonnes As TableLayoutPanel
    Friend WithEvents Label23 As Label
    Friend WithEvents Label24 As Label
    Friend WithEvents Label25 As Label
    Friend WithEvents Label26 As Label
    Friend WithEvents Label27 As Label
    Friend WithEvents GroupBox8 As GroupBox
    Friend WithEvents TopMembresRessourceHumaineAvecPersonnes As TableLayoutPanel
    Friend WithEvents Label35 As Label
    Friend WithEvents Label36 As Label
    Friend WithEvents Label37 As Label
    Friend WithEvents Label38 As Label
    Friend WithEvents Label39 As Label
End Class
