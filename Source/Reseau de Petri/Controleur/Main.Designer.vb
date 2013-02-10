<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CB_sens = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.CB_trans = New System.Windows.Forms.ComboBox()
        Me.CB_place = New System.Windows.Forms.ComboBox()
        Me.TabaArc = New System.Windows.Forms.TabPage()
        Me.TB_mult = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.B_AddArc = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.ChB_Graph = New System.Windows.Forms.CheckBox()
        Me.ChB_Timer = New System.Windows.Forms.CheckBox()
        Me.TB_etapeMax = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.ChB_verbose = New System.Windows.Forms.CheckBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.B_Go = New System.Windows.Forms.Button()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TBK = New System.Windows.Forms.TrackBar()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.RTB_Console = New System.Windows.Forms.RichTextBox()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.TB_Trans_Nom = New System.Windows.Forms.TextBox()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.TV_Donnée = New System.Windows.Forms.TreeView()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPlaces = New System.Windows.Forms.TabPage()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TB_Place_Nombre = New System.Windows.Forms.TextBox()
        Me.TB_Place_Nom = New System.Windows.Forms.TextBox()
        Me.B_AddPlace = New System.Windows.Forms.Button()
        Me.TabTrans = New System.Windows.Forms.TabPage()
        Me.B_AddTrans = New System.Windows.Forms.Button()
        Me.SimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.NouvelleSimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ChargerSimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SauvegarderLaSimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.LancerLaSimulationToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.QuitterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonnéesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SauvegarderLesDonnéesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuDeroulant = New System.Windows.Forms.MenuStrip()
        Me.OFD_chargement = New System.Windows.Forms.OpenFileDialog()
        Me.SFD_enregistrement = New System.Windows.Forms.SaveFileDialog()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.TabaArc.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.TBK, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.TableLayoutPanel2.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.TabControl1.SuspendLayout()
        Me.TabPlaces.SuspendLayout()
        Me.TabTrans.SuspendLayout()
        Me.MenuDeroulant.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(7, 68)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(37, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "Nom"
        '
        'CB_sens
        '
        Me.CB_sens.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems
        Me.CB_sens.FormattingEnabled = True
        Me.CB_sens.Items.AddRange(New Object() {"P -> T", "T -> P"})
        Me.CB_sens.Location = New System.Drawing.Point(68, 103)
        Me.CB_sens.Margin = New System.Windows.Forms.Padding(3, 20, 3, 2)
        Me.CB_sens.Name = "CB_sens"
        Me.CB_sens.Size = New System.Drawing.Size(67, 24)
        Me.CB_sens.TabIndex = 9
        Me.CB_sens.Text = "P -> T"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(4, 108)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(40, 17)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "Sens"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(4, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(71, 17)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Transition"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(4, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(43, 17)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "Place"
        '
        'CB_trans
        '
        Me.CB_trans.FormattingEnabled = True
        Me.CB_trans.Location = New System.Drawing.Point(103, 57)
        Me.CB_trans.Margin = New System.Windows.Forms.Padding(3, 20, 3, 2)
        Me.CB_trans.Name = "CB_trans"
        Me.CB_trans.Size = New System.Drawing.Size(203, 24)
        Me.CB_trans.Sorted = True
        Me.CB_trans.TabIndex = 4
        '
        'CB_place
        '
        Me.CB_place.FormattingEnabled = True
        Me.CB_place.Location = New System.Drawing.Point(103, 10)
        Me.CB_place.Margin = New System.Windows.Forms.Padding(3, 10, 3, 2)
        Me.CB_place.Name = "CB_place"
        Me.CB_place.Size = New System.Drawing.Size(203, 24)
        Me.CB_place.Sorted = True
        Me.CB_place.TabIndex = 3
        '
        'TabaArc
        '
        Me.TabaArc.Controls.Add(Me.TB_mult)
        Me.TabaArc.Controls.Add(Me.Label9)
        Me.TabaArc.Controls.Add(Me.CB_sens)
        Me.TabaArc.Controls.Add(Me.Label3)
        Me.TabaArc.Controls.Add(Me.Label2)
        Me.TabaArc.Controls.Add(Me.Label1)
        Me.TabaArc.Controls.Add(Me.CB_trans)
        Me.TabaArc.Controls.Add(Me.CB_place)
        Me.TabaArc.Controls.Add(Me.B_AddArc)
        Me.TabaArc.Location = New System.Drawing.Point(4, 25)
        Me.TabaArc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabaArc.Name = "TabaArc"
        Me.TabaArc.Size = New System.Drawing.Size(315, 181)
        Me.TabaArc.TabIndex = 2
        Me.TabaArc.Text = "Arc"
        Me.TabaArc.UseVisualStyleBackColor = True
        '
        'TB_mult
        '
        Me.TB_mult.Location = New System.Drawing.Point(251, 106)
        Me.TB_mult.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_mult.Name = "TB_mult"
        Me.TB_mult.Size = New System.Drawing.Size(56, 22)
        Me.TB_mult.TabIndex = 11
        Me.TB_mult.Text = "1"
        Me.TB_mult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(161, 108)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 17)
        Me.Label9.TabIndex = 10
        Me.Label9.Text = "Multiplicité"
        '
        'B_AddArc
        '
        Me.B_AddArc.Location = New System.Drawing.Point(3, 146)
        Me.B_AddArc.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_AddArc.Name = "B_AddArc"
        Me.B_AddArc.Size = New System.Drawing.Size(303, 30)
        Me.B_AddArc.TabIndex = 2
        Me.B_AddArc.Text = "Ajouter une nouvelle donnée"
        Me.B_AddArc.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox3.Controls.Add(Me.ChB_Graph)
        Me.GroupBox3.Controls.Add(Me.ChB_Timer)
        Me.GroupBox3.Controls.Add(Me.TB_etapeMax)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.ChB_verbose)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.B_Go)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.TBK)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 399)
        Me.GroupBox3.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox3.Size = New System.Drawing.Size(637, 195)
        Me.GroupBox3.TabIndex = 3
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Paramêtres de simulation"
        '
        'ChB_Graph
        '
        Me.ChB_Graph.AutoSize = True
        Me.ChB_Graph.Location = New System.Drawing.Point(9, 114)
        Me.ChB_Graph.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChB_Graph.Name = "ChB_Graph"
        Me.ChB_Graph.Size = New System.Drawing.Size(341, 38)
        Me.ChB_Graph.TabIndex = 8
        Me.ChB_Graph.Text = "Afficher le graphe visuel (dans une autre fenetre)" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "[Nécessite Graphviz 8]"
        Me.ChB_Graph.UseVisualStyleBackColor = True
        '
        'ChB_Timer
        '
        Me.ChB_Timer.AutoSize = True
        Me.ChB_Timer.Location = New System.Drawing.Point(7, 26)
        Me.ChB_Timer.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChB_Timer.Name = "ChB_Timer"
        Me.ChB_Timer.Size = New System.Drawing.Size(66, 21)
        Me.ChB_Timer.TabIndex = 7
        Me.ChB_Timer.Text = "Timer"
        Me.ChB_Timer.UseVisualStyleBackColor = True
        '
        'TB_etapeMax
        '
        Me.TB_etapeMax.Location = New System.Drawing.Point(225, 166)
        Me.TB_etapeMax.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TB_etapeMax.Name = "TB_etapeMax"
        Me.TB_etapeMax.Size = New System.Drawing.Size(100, 22)
        Me.TB_etapeMax.TabIndex = 6
        Me.TB_etapeMax.Text = "1000"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(5, 171)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(156, 17)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "Etapes max simulation :"
        '
        'ChB_verbose
        '
        Me.ChB_verbose.AutoSize = True
        Me.ChB_verbose.Location = New System.Drawing.Point(9, 71)
        Me.ChB_verbose.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.ChB_verbose.Name = "ChB_verbose"
        Me.ChB_verbose.Size = New System.Drawing.Size(294, 38)
        Me.ChB_verbose.TabIndex = 4
        Me.ChB_verbose.Text = "Afficher les données de simulation " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(déconseillé pour les longues simulations)"
        Me.ChB_verbose.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.Label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label8.Location = New System.Drawing.Point(307, 30)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(128, 17)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "1500 millisecondes"
        Me.Label8.Visible = False
        '
        'B_Go
        '
        Me.B_Go.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.B_Go.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.B_Go.Location = New System.Drawing.Point(459, 15)
        Me.B_Go.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_Go.MaximumSize = New System.Drawing.Size(173, 174)
        Me.B_Go.Name = "B_Go"
        Me.B_Go.Size = New System.Drawing.Size(173, 174)
        Me.B_Go.TabIndex = 2
        Me.B_Go.Text = "Lancer la simulation"
        Me.B_Go.UseVisualStyleBackColor = False
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label7.Location = New System.Drawing.Point(79, 26)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(71, 34)
        Me.Label7.TabIndex = 1
        Me.Label7.Text = "Vitesse" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "simulation"
        Me.Label7.Visible = False
        '
        'TBK
        '
        Me.TBK.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TBK.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.TBK.Location = New System.Drawing.Point(151, 26)
        Me.TBK.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TBK.Maximum = 5000
        Me.TBK.Minimum = 1
        Me.TBK.Name = "TBK"
        Me.TBK.Size = New System.Drawing.Size(149, 56)
        Me.TBK.TabIndex = 0
        Me.TBK.Value = 1150
        Me.TBK.Visible = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox2.Controls.Add(Me.RTB_Console)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox2.Size = New System.Drawing.Size(637, 369)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Résultats  de la simulation"
        '
        'RTB_Console
        '
        Me.RTB_Console.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.RTB_Console.Location = New System.Drawing.Point(7, 21)
        Me.RTB_Console.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.RTB_Console.Name = "RTB_Console"
        Me.RTB_Console.Size = New System.Drawing.Size(624, 342)
        Me.RTB_Console.TabIndex = 0
        Me.RTB_Console.Text = ""
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel2.ColumnCount = 1
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox3, 0, 1)
        Me.TableLayoutPanel2.Controls.Add(Me.GroupBox2, 0, 0)
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(360, 0)
        Me.TableLayoutPanel2.Margin = New System.Windows.Forms.Padding(0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 2
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 215.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(659, 604)
        Me.TableLayoutPanel2.TabIndex = 0
        '
        'TB_Trans_Nom
        '
        Me.TB_Trans_Nom.Location = New System.Drawing.Point(107, 64)
        Me.TB_Trans_Nom.Margin = New System.Windows.Forms.Padding(3, 10, 3, 2)
        Me.TB_Trans_Nom.Name = "TB_Trans_Nom"
        Me.TB_Trans_Nom.Size = New System.Drawing.Size(203, 22)
        Me.TB_Trans_Nom.TabIndex = 6
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 360.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.GroupBox1, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.TableLayoutPanel2, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 33)
        Me.TableLayoutPanel1.Margin = New System.Windows.Forms.Padding(5, 5, 5, 5)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1019, 604)
        Me.TableLayoutPanel1.TabIndex = 10
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.TV_Donnée)
        Me.GroupBox1.Controls.Add(Me.TabControl1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 10)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(11, 10, 11, 10)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.GroupBox1.Size = New System.Drawing.Size(338, 584)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Conditions initiales"
        '
        'TV_Donnée
        '
        Me.TV_Donnée.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TV_Donnée.Location = New System.Drawing.Point(7, 238)
        Me.TV_Donnée.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TV_Donnée.Name = "TV_Donnée"
        Me.TV_Donnée.ShowNodeToolTips = True
        Me.TV_Donnée.Size = New System.Drawing.Size(322, 339)
        Me.TV_Donnée.TabIndex = 1
        '
        'TabControl1
        '
        Me.TabControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
                    Or System.Windows.Forms.AnchorStyles.Left) _
                    Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TabControl1.Controls.Add(Me.TabPlaces)
        Me.TabControl1.Controls.Add(Me.TabTrans)
        Me.TabControl1.Controls.Add(Me.TabaArc)
        Me.TabControl1.Location = New System.Drawing.Point(8, 22)
        Me.TabControl1.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabControl1.MaximumSize = New System.Drawing.Size(323, 210)
        Me.TabControl1.MinimumSize = New System.Drawing.Size(323, 210)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(323, 210)
        Me.TabControl1.TabIndex = 0
        '
        'TabPlaces
        '
        Me.TabPlaces.Controls.Add(Me.Label5)
        Me.TabPlaces.Controls.Add(Me.Label4)
        Me.TabPlaces.Controls.Add(Me.TB_Place_Nombre)
        Me.TabPlaces.Controls.Add(Me.TB_Place_Nom)
        Me.TabPlaces.Controls.Add(Me.B_AddPlace)
        Me.TabPlaces.Location = New System.Drawing.Point(4, 25)
        Me.TabPlaces.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPlaces.Name = "TabPlaces"
        Me.TabPlaces.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabPlaces.Size = New System.Drawing.Size(315, 181)
        Me.TabPlaces.TabIndex = 0
        Me.TabPlaces.Text = "Place"
        Me.TabPlaces.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(7, 80)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(130, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Nombre de jeton(s)"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(7, 14)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Nom"
        '
        'TB_Place_Nombre
        '
        Me.TB_Place_Nombre.Location = New System.Drawing.Point(209, 78)
        Me.TB_Place_Nombre.Margin = New System.Windows.Forms.Padding(3, 39, 3, 2)
        Me.TB_Place_Nombre.Name = "TB_Place_Nombre"
        Me.TB_Place_Nombre.Size = New System.Drawing.Size(100, 22)
        Me.TB_Place_Nombre.TabIndex = 4
        Me.TB_Place_Nombre.Text = "0"
        Me.TB_Place_Nombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'TB_Place_Nom
        '
        Me.TB_Place_Nom.Location = New System.Drawing.Point(107, 10)
        Me.TB_Place_Nom.Margin = New System.Windows.Forms.Padding(3, 10, 3, 2)
        Me.TB_Place_Nom.Name = "TB_Place_Nom"
        Me.TB_Place_Nom.Size = New System.Drawing.Size(203, 22)
        Me.TB_Place_Nom.TabIndex = 3
        '
        'B_AddPlace
        '
        Me.B_AddPlace.Location = New System.Drawing.Point(5, 143)
        Me.B_AddPlace.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_AddPlace.Name = "B_AddPlace"
        Me.B_AddPlace.Size = New System.Drawing.Size(303, 30)
        Me.B_AddPlace.TabIndex = 2
        Me.B_AddPlace.Text = "Ajouter une nouvelle donnée"
        Me.B_AddPlace.UseVisualStyleBackColor = True
        '
        'TabTrans
        '
        Me.TabTrans.Controls.Add(Me.Label6)
        Me.TabTrans.Controls.Add(Me.TB_Trans_Nom)
        Me.TabTrans.Controls.Add(Me.B_AddTrans)
        Me.TabTrans.Location = New System.Drawing.Point(4, 25)
        Me.TabTrans.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabTrans.Name = "TabTrans"
        Me.TabTrans.Padding = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.TabTrans.Size = New System.Drawing.Size(315, 181)
        Me.TabTrans.TabIndex = 1
        Me.TabTrans.Text = "Transition"
        Me.TabTrans.UseVisualStyleBackColor = True
        '
        'B_AddTrans
        '
        Me.B_AddTrans.Location = New System.Drawing.Point(5, 143)
        Me.B_AddTrans.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.B_AddTrans.Name = "B_AddTrans"
        Me.B_AddTrans.Size = New System.Drawing.Size(303, 30)
        Me.B_AddTrans.TabIndex = 1
        Me.B_AddTrans.Text = "Ajouter une nouvelle donnée"
        Me.B_AddTrans.UseVisualStyleBackColor = True
        '
        'SimulationToolStripMenuItem
        '
        Me.SimulationToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.NouvelleSimulationToolStripMenuItem, Me.ChargerSimulationToolStripMenuItem, Me.SauvegarderLaSimulationToolStripMenuItem, Me.ToolStripSeparator1, Me.LancerLaSimulationToolStripMenuItem, Me.ToolStripSeparator2, Me.QuitterToolStripMenuItem})
        Me.SimulationToolStripMenuItem.Name = "SimulationToolStripMenuItem"
        Me.SimulationToolStripMenuItem.Size = New System.Drawing.Size(92, 24)
        Me.SimulationToolStripMenuItem.Text = "Simulation"
        '
        'NouvelleSimulationToolStripMenuItem
        '
        Me.NouvelleSimulationToolStripMenuItem.Name = "NouvelleSimulationToolStripMenuItem"
        Me.NouvelleSimulationToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.NouvelleSimulationToolStripMenuItem.Text = "Nouvelle simulation"
        '
        'ChargerSimulationToolStripMenuItem
        '
        Me.ChargerSimulationToolStripMenuItem.Name = "ChargerSimulationToolStripMenuItem"
        Me.ChargerSimulationToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.ChargerSimulationToolStripMenuItem.Text = "Charger simulation ..."
        '
        'SauvegarderLaSimulationToolStripMenuItem
        '
        Me.SauvegarderLaSimulationToolStripMenuItem.Name = "SauvegarderLaSimulationToolStripMenuItem"
        Me.SauvegarderLaSimulationToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.SauvegarderLaSimulationToolStripMenuItem.Text = "Sauvegarder la simulation ..."
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(260, 6)
        '
        'LancerLaSimulationToolStripMenuItem
        '
        Me.LancerLaSimulationToolStripMenuItem.Name = "LancerLaSimulationToolStripMenuItem"
        Me.LancerLaSimulationToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.LancerLaSimulationToolStripMenuItem.Text = "Lancer la simulation"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(260, 6)
        '
        'QuitterToolStripMenuItem
        '
        Me.QuitterToolStripMenuItem.Name = "QuitterToolStripMenuItem"
        Me.QuitterToolStripMenuItem.Size = New System.Drawing.Size(263, 24)
        Me.QuitterToolStripMenuItem.Text = "Quitter"
        '
        'DonnéesToolStripMenuItem
        '
        Me.DonnéesToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SauvegarderLesDonnéesToolStripMenuItem})
        Me.DonnéesToolStripMenuItem.Name = "DonnéesToolStripMenuItem"
        Me.DonnéesToolStripMenuItem.Size = New System.Drawing.Size(79, 24)
        Me.DonnéesToolStripMenuItem.Text = "Données"
        '
        'SauvegarderLesDonnéesToolStripMenuItem
        '
        Me.SauvegarderLesDonnéesToolStripMenuItem.Name = "SauvegarderLesDonnéesToolStripMenuItem"
        Me.SauvegarderLesDonnéesToolStripMenuItem.Size = New System.Drawing.Size(243, 24)
        Me.SauvegarderLesDonnéesToolStripMenuItem.Text = "Sauvegarder les données"
        '
        'AideToolStripMenuItem
        '
        Me.AideToolStripMenuItem.Name = "AideToolStripMenuItem"
        Me.AideToolStripMenuItem.Size = New System.Drawing.Size(52, 24)
        Me.AideToolStripMenuItem.Text = "Aide"
        '
        'MenuDeroulant
        '
        Me.MenuDeroulant.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.MenuDeroulant.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SimulationToolStripMenuItem, Me.DonnéesToolStripMenuItem, Me.AideToolStripMenuItem})
        Me.MenuDeroulant.Location = New System.Drawing.Point(0, 0)
        Me.MenuDeroulant.Name = "MenuDeroulant"
        Me.MenuDeroulant.Padding = New System.Windows.Forms.Padding(7, 2, 0, 2)
        Me.MenuDeroulant.Size = New System.Drawing.Size(1019, 28)
        Me.MenuDeroulant.TabIndex = 9
        Me.MenuDeroulant.Text = "MenuStrip1"
        '
        'OFD_chargement
        '
        Me.OFD_chargement.DefaultExt = "srp"
        Me.OFD_chargement.Filter = "Fichier de simulation|*.srp|Tous les fichiers|*.*"
        Me.OFD_chargement.Title = "Charger un fichier de simulation"
        '
        'SFD_enregistrement
        '
        Me.SFD_enregistrement.Filter = "Fichier de simulation|*.srp|Tous les fichiers|*.*"
        '
        'Timer
        '
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ActiveBorder
        Me.ClientSize = New System.Drawing.Size(1019, 638)
        Me.Controls.Add(Me.MenuDeroulant)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 2, 3, 2)
        Me.Name = "Main"
        Me.Text = "Réseau de Petri - Fenètre principale"
        Me.TabaArc.ResumeLayout(False)
        Me.TabaArc.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.TBK, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.TableLayoutPanel2.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.TabControl1.ResumeLayout(False)
        Me.TabPlaces.ResumeLayout(False)
        Me.TabPlaces.PerformLayout()
        Me.TabTrans.ResumeLayout(False)
        Me.TabTrans.PerformLayout()
        Me.MenuDeroulant.ResumeLayout(False)
        Me.MenuDeroulant.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents CB_sens As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents CB_trans As System.Windows.Forms.ComboBox
    Friend WithEvents CB_place As System.Windows.Forms.ComboBox
    Friend WithEvents TabaArc As System.Windows.Forms.TabPage
    Friend WithEvents B_AddArc As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents B_Go As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TBK As System.Windows.Forms.TrackBar
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents RTB_Console As System.Windows.Forms.RichTextBox
    Friend WithEvents TableLayoutPanel2 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents TB_Trans_Nom As System.Windows.Forms.TextBox
    Friend WithEvents TableLayoutPanel1 As System.Windows.Forms.TableLayoutPanel
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents TV_Donnée As System.Windows.Forms.TreeView
    Friend WithEvents TabControl1 As System.Windows.Forms.TabControl
    Friend WithEvents TabPlaces As System.Windows.Forms.TabPage
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents TB_Place_Nombre As System.Windows.Forms.TextBox
    Friend WithEvents TB_Place_Nom As System.Windows.Forms.TextBox
    Friend WithEvents B_AddPlace As System.Windows.Forms.Button
    Friend WithEvents TabTrans As System.Windows.Forms.TabPage
    Friend WithEvents B_AddTrans As System.Windows.Forms.Button
    Friend WithEvents TB_mult As System.Windows.Forms.TextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents SimulationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DonnéesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents AideToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MenuDeroulant As System.Windows.Forms.MenuStrip
    Friend WithEvents NouvelleSimulationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ChargerSimulationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents QuitterToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents LancerLaSimulationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents ChB_verbose As System.Windows.Forms.CheckBox
    Friend WithEvents SauvegarderLaSimulationToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SauvegarderLesDonnéesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents OFD_chargement As System.Windows.Forms.OpenFileDialog
    Friend WithEvents SFD_enregistrement As System.Windows.Forms.SaveFileDialog
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents TB_etapeMax As System.Windows.Forms.TextBox
    Friend WithEvents ChB_Timer As System.Windows.Forms.CheckBox
    Friend WithEvents ChB_Graph As System.Windows.Forms.CheckBox
    Friend WithEvents Timer As System.Windows.Forms.Timer

End Class
