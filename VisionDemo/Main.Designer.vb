<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.pnlImage = New System.Windows.Forms.Panel()
        Me.OpenFileDialog = New System.Windows.Forms.OpenFileDialog()
        Me.tabTools = New System.Windows.Forms.TabControl()
        Me.SimpleLineTool = New System.Windows.Forms.TabPage()
        Me.cmdSimpleLineWidth = New System.Windows.Forms.Button()
        Me.lblSimpleLineResults = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.cmdSimpleLineRun = New System.Windows.Forms.Button()
        Me.cboSimpleLinePolarity = New System.Windows.Forms.ComboBox()
        Me.cboSimpleLineOrientation = New System.Windows.Forms.ComboBox()
        Me.AdvancedLineTool = New System.Windows.Forms.TabPage()
        Me.cmdAdvancedLineWidth = New System.Windows.Forms.Button()
        Me.lblResultsAdvancedLine = New System.Windows.Forms.Label()
        Me.chkMetrologyLineFitCheckBox = New System.Windows.Forms.CheckBox()
        Me.cmdRunAdvancedLine = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtAdvancedLineMaxFitDist = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtAdvancedLineSmoothness = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtAdvancedLineScale = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtAdvancedLineAngleRange = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cboAdvancedLineThresholdMode = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cboAdvancedLineSelection = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cboAdvancedLinePolarity = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.cboAdvancedLineDirection = New System.Windows.Forms.ComboBox()
        Me.SimpleCircleTool = New System.Windows.Forms.TabPage()
        Me.cmdSimpleCircleRun = New System.Windows.Forms.Button()
        Me.lblSimpleCircleResults = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txtSimpleCircleMaxFitDistance = New System.Windows.Forms.TextBox()
        Me.cboSimpleCirclePolarity = New System.Windows.Forms.ComboBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.cmdPoss = New System.Windows.Forms.Button()
        Me.txtPosY = New System.Windows.Forms.TextBox()
        Me.txtPosX = New System.Windows.Forms.TextBox()
        Me.cmdSize = New System.Windows.Forms.Button()
        Me.txtY = New System.Windows.Forms.TextBox()
        Me.txtX = New System.Windows.Forms.TextBox()
        Me.AdvancedCircleTool = New System.Windows.Forms.TabPage()
        Me.cmdAdvancedCirleRun = New System.Windows.Forms.Button()
        Me.chkAdvancedCircleFit = New System.Windows.Forms.CheckBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.txtAdvancedCircleEdgeExtractionScale = New System.Windows.Forms.TextBox()
        Me.updnAdvancedCircleAngle = New System.Windows.Forms.NumericUpDown()
        Me.Label25 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtAdvancedCircleMaxLineFitDistance = New System.Windows.Forms.TextBox()
        Me.cboAdvancedCirclePolarity = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txtAdvancedCircleSmoothness = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtAdvancedCircleEdgeAngleRange = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cboAdvancedCircleThresholdMode = New System.Windows.Forms.ComboBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.cboAdvancedCircleEdgeSelection = New System.Windows.Forms.ComboBox()
        Me.BlobTool = New System.Windows.Forms.TabPage()
        Me.GroupBox12 = New System.Windows.Forms.GroupBox()
        Me.optBiggest = New System.Windows.Forms.RadioButton()
        Me.optSmallest = New System.Windows.Forms.RadioButton()
        Me.optCenter = New System.Windows.Forms.RadioButton()
        Me.optBottom = New System.Windows.Forms.RadioButton()
        Me.optTop = New System.Windows.Forms.RadioButton()
        Me.optRight = New System.Windows.Forms.RadioButton()
        Me.optLeft = New System.Windows.Forms.RadioButton()
        Me.optLR = New System.Windows.Forms.RadioButton()
        Me.optLL = New System.Windows.Forms.RadioButton()
        Me.optUR = New System.Windows.Forms.RadioButton()
        Me.optUL = New System.Windows.Forms.RadioButton()
        Me.chkClickOnBlobs = New System.Windows.Forms.CheckBox()
        Me.GroupBox10 = New System.Windows.Forms.GroupBox()
        Me.txtAreaMax = New System.Windows.Forms.TextBox()
        Me.txtAreaMin = New System.Windows.Forms.TextBox()
        Me.chkAreaIgnore = New System.Windows.Forms.CheckBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.lblBlobResults = New System.Windows.Forms.Label()
        Me.cmdDisplayAll = New System.Windows.Forms.Button()
        Me.cboBlobs = New System.Windows.Forms.ComboBox()
        Me.lblBlobs = New System.Windows.Forms.Label()
        Me.cmdBlobRun = New System.Windows.Forms.Button()
        Me.chkCG = New System.Windows.Forms.CheckBox()
        Me.chkHull = New System.Windows.Forms.CheckBox()
        Me.chkBox = New System.Windows.Forms.CheckBox()
        Me.GeometricModelFinder = New System.Windows.Forms.TabPage()
        Me.lblGeoResults = New System.Windows.Forms.Label()
        Me.lstGeoResults = New System.Windows.Forms.ListBox()
        Me.txtGeoMatchThreshold = New System.Windows.Forms.TextBox()
        Me.txtGeoMaxNum = New System.Windows.Forms.TextBox()
        Me.Label29 = New System.Windows.Forms.Label()
        Me.Label28 = New System.Windows.Forms.Label()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.cmdGeoSetFullImage = New System.Windows.Forms.Button()
        Me.lblGeoModelName = New System.Windows.Forms.Label()
        Me.cmdLoadGeometricModel = New System.Windows.Forms.Button()
        Me.lstGeoFiles = New System.Windows.Forms.ListBox()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.chkOriginGeometric = New System.Windows.Forms.CheckBox()
        Me.cmdCenterGeo = New System.Windows.Forms.Button()
        Me.cmdSearchGeometricModelFinder = New System.Windows.Forms.Button()
        Me.cmdTrainGeometricModelFinder = New System.Windows.Forms.Button()
        Me.PatternMatchTool = New System.Windows.Forms.TabPage()
        Me.lblPatResults = New System.Windows.Forms.Label()
        Me.lstPatResults = New System.Windows.Forms.ListBox()
        Me.txtPatMatchThreshold = New System.Windows.Forms.TextBox()
        Me.txtPatMaxNum = New System.Windows.Forms.TextBox()
        Me.Label31 = New System.Windows.Forms.Label()
        Me.Label32 = New System.Windows.Forms.Label()
        Me.Label33 = New System.Windows.Forms.Label()
        Me.cmdPatSetFullImage = New System.Windows.Forms.Button()
        Me.lblPatModelName = New System.Windows.Forms.Label()
        Me.cmdLoadPatternModel = New System.Windows.Forms.Button()
        Me.lstPatFiles = New System.Windows.Forms.ListBox()
        Me.GroupBox11 = New System.Windows.Forms.GroupBox()
        Me.chkOriginPattern = New System.Windows.Forms.CheckBox()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.cmdSearchPatternModelFinder = New System.Windows.Forms.Button()
        Me.cmdTrainPatternModelFinder = New System.Windows.Forms.Button()
        Me.MicrometerTool = New System.Windows.Forms.TabPage()
        Me.lblMicrometerResults = New System.Windows.Forms.Label()
        Me.Video = New System.Windows.Forms.TabPage()
        Me.groupBox7 = New System.Windows.Forms.GroupBox()
        Me.cmdBinarize = New System.Windows.Forms.Button()
        Me.cboBinarizePolarity = New System.Windows.Forms.ComboBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.numBinarizeThreshold = New System.Windows.Forms.NumericUpDown()
        Me.lblBinarizeThreshold = New System.Windows.Forms.Label()
        Me.chkAutoThreshold = New System.Windows.Forms.CheckBox()
        Me.displayGroupBox = New System.Windows.Forms.GroupBox()
        Me.cmdLUTColor = New System.Windows.Forms.Button()
        Me.cmdLUTNegative = New System.Windows.Forms.Button()
        Me.cmdLUTPositive = New System.Windows.Forms.Button()
        Me.GroupBox8 = New System.Windows.Forms.GroupBox()
        Me.numNegative = New System.Windows.Forms.NumericUpDown()
        Me.cmdNegative = New System.Windows.Forms.Button()
        Me.numPositive = New System.Windows.Forms.NumericUpDown()
        Me.cmdPositive = New System.Windows.Forms.Button()
        Me.cmdXhair = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox9 = New System.Windows.Forms.GroupBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.cmdGrab = New System.Windows.Forms.Button()
        Me.cmdStop = New System.Windows.Forms.Button()
        Me.cmdLive = New System.Windows.Forms.Button()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.cmdImageSave = New System.Windows.Forms.Button()
        Me.cmdImageLoad = New System.Windows.Forms.Button()
        Me.Units = New System.Windows.Forms.TabPage()
        Me.lblUnitsPixelSize = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.optPixel = New System.Windows.Forms.RadioButton()
        Me.optMM = New System.Windows.Forms.RadioButton()
        Me.optMicron = New System.Windows.Forms.RadioButton()
        Me.optMicroInch = New System.Windows.Forms.RadioButton()
        Me.optInch = New System.Windows.Forms.RadioButton()
        Me.ThicknessTool = New System.Windows.Forms.TabPage()
        Me.scrLightLevel = New System.Windows.Forms.HScrollBar()
        Me.lstImages = New System.Windows.Forms.ListBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblDisplayFactor = New System.Windows.Forms.Label()
        Me.lblImageSize = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.mnuMain = New System.Windows.Forms.MenuStrip()
        Me.mnuFile = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuTest = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripSeparator()
        Me.mnuExit = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuSystem = New System.Windows.Forms.ToolStripMenuItem()
        Me.mnuMotionControl = New System.Windows.Forms.ToolStripMenuItem()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.cmdExit = New System.Windows.Forms.Button()
        Me.lblLightLevel = New System.Windows.Forms.Label()
        Me.comLightController = New System.IO.Ports.SerialPort(Me.components)
        Me.tabTools.SuspendLayout()
        Me.SimpleLineTool.SuspendLayout()
        Me.AdvancedLineTool.SuspendLayout()
        Me.SimpleCircleTool.SuspendLayout()
        Me.AdvancedCircleTool.SuspendLayout()
        CType(Me.updnAdvancedCircleAngle, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.BlobTool.SuspendLayout()
        Me.GroupBox12.SuspendLayout()
        Me.GroupBox10.SuspendLayout()
        Me.GeometricModelFinder.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.PatternMatchTool.SuspendLayout()
        Me.GroupBox11.SuspendLayout()
        Me.MicrometerTool.SuspendLayout()
        Me.Video.SuspendLayout()
        Me.groupBox7.SuspendLayout()
        CType(Me.numBinarizeThreshold, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.displayGroupBox.SuspendLayout()
        Me.GroupBox8.SuspendLayout()
        CType(Me.numNegative, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numPositive, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox9.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.Units.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.ThicknessTool.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.mnuMain.SuspendLayout()
        Me.SuspendLayout()
        '
        'pnlImage
        '
        Me.pnlImage.Location = New System.Drawing.Point(31, 250)
        Me.pnlImage.Name = "pnlImage"
        Me.pnlImage.Size = New System.Drawing.Size(428, 246)
        Me.pnlImage.TabIndex = 0
        '
        'OpenFileDialog
        '
        Me.OpenFileDialog.FileName = "OpenFileDialog1"
        '
        'tabTools
        '
        Me.tabTools.Controls.Add(Me.SimpleLineTool)
        Me.tabTools.Controls.Add(Me.AdvancedLineTool)
        Me.tabTools.Controls.Add(Me.SimpleCircleTool)
        Me.tabTools.Controls.Add(Me.AdvancedCircleTool)
        Me.tabTools.Controls.Add(Me.BlobTool)
        Me.tabTools.Controls.Add(Me.GeometricModelFinder)
        Me.tabTools.Controls.Add(Me.PatternMatchTool)
        Me.tabTools.Controls.Add(Me.MicrometerTool)
        Me.tabTools.Controls.Add(Me.Video)
        Me.tabTools.Controls.Add(Me.Units)
        Me.tabTools.Controls.Add(Me.ThicknessTool)
        Me.tabTools.Location = New System.Drawing.Point(687, 26)
        Me.tabTools.Multiline = True
        Me.tabTools.Name = "tabTools"
        Me.tabTools.SelectedIndex = 0
        Me.tabTools.Size = New System.Drawing.Size(436, 450)
        Me.tabTools.TabIndex = 7
        '
        'SimpleLineTool
        '
        Me.SimpleLineTool.Controls.Add(Me.cmdSimpleLineWidth)
        Me.SimpleLineTool.Controls.Add(Me.lblSimpleLineResults)
        Me.SimpleLineTool.Controls.Add(Me.Label23)
        Me.SimpleLineTool.Controls.Add(Me.Label24)
        Me.SimpleLineTool.Controls.Add(Me.cmdSimpleLineRun)
        Me.SimpleLineTool.Controls.Add(Me.cboSimpleLinePolarity)
        Me.SimpleLineTool.Controls.Add(Me.cboSimpleLineOrientation)
        Me.SimpleLineTool.Location = New System.Drawing.Point(4, 58)
        Me.SimpleLineTool.Name = "SimpleLineTool"
        Me.SimpleLineTool.Padding = New System.Windows.Forms.Padding(3)
        Me.SimpleLineTool.Size = New System.Drawing.Size(428, 388)
        Me.SimpleLineTool.TabIndex = 0
        Me.SimpleLineTool.Text = "Simple Line Tool"
        Me.SimpleLineTool.UseVisualStyleBackColor = True
        '
        'cmdSimpleLineWidth
        '
        Me.cmdSimpleLineWidth.Location = New System.Drawing.Point(196, 276)
        Me.cmdSimpleLineWidth.Name = "cmdSimpleLineWidth"
        Me.cmdSimpleLineWidth.Size = New System.Drawing.Size(67, 20)
        Me.cmdSimpleLineWidth.TabIndex = 56
        Me.cmdSimpleLineWidth.Text = "Line Width"
        Me.cmdSimpleLineWidth.UseVisualStyleBackColor = True
        '
        'lblSimpleLineResults
        '
        Me.lblSimpleLineResults.AutoSize = True
        Me.lblSimpleLineResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleLineResults.ForeColor = System.Drawing.Color.Blue
        Me.lblSimpleLineResults.Location = New System.Drawing.Point(26, 124)
        Me.lblSimpleLineResults.Name = "lblSimpleLineResults"
        Me.lblSimpleLineResults.Size = New System.Drawing.Size(53, 16)
        Me.lblSimpleLineResults.TabIndex = 52
        Me.lblSimpleLineResults.Text = "Results"
        Me.lblSimpleLineResults.Visible = False
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Location = New System.Drawing.Point(106, 37)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(41, 13)
        Me.Label23.TabIndex = 29
        Me.Label23.Text = "Polarity"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Location = New System.Drawing.Point(75, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(72, 13)
        Me.Label24.TabIndex = 28
        Me.Label24.Text = "Line Direction"
        '
        'cmdSimpleLineRun
        '
        Me.cmdSimpleLineRun.Location = New System.Drawing.Point(196, 250)
        Me.cmdSimpleLineRun.Name = "cmdSimpleLineRun"
        Me.cmdSimpleLineRun.Size = New System.Drawing.Size(67, 20)
        Me.cmdSimpleLineRun.TabIndex = 8
        Me.cmdSimpleLineRun.Text = "Run"
        Me.cmdSimpleLineRun.UseVisualStyleBackColor = True
        '
        'cboSimpleLinePolarity
        '
        Me.cboSimpleLinePolarity.FormattingEnabled = True
        Me.cboSimpleLinePolarity.Items.AddRange(New Object() {"Any", "Positive", "Negative"})
        Me.cboSimpleLinePolarity.Location = New System.Drawing.Point(153, 34)
        Me.cboSimpleLinePolarity.Name = "cboSimpleLinePolarity"
        Me.cboSimpleLinePolarity.Size = New System.Drawing.Size(115, 21)
        Me.cboSimpleLinePolarity.TabIndex = 6
        Me.cboSimpleLinePolarity.Text = "Any"
        '
        'cboSimpleLineOrientation
        '
        Me.cboSimpleLineOrientation.FormattingEnabled = True
        Me.cboSimpleLineOrientation.Items.AddRange(New Object() {"Vertical", "Horizontal"})
        Me.cboSimpleLineOrientation.Location = New System.Drawing.Point(153, 65)
        Me.cboSimpleLineOrientation.Name = "cboSimpleLineOrientation"
        Me.cboSimpleLineOrientation.Size = New System.Drawing.Size(115, 21)
        Me.cboSimpleLineOrientation.TabIndex = 5
        Me.cboSimpleLineOrientation.Text = "Vertical"
        '
        'AdvancedLineTool
        '
        Me.AdvancedLineTool.Controls.Add(Me.cmdAdvancedLineWidth)
        Me.AdvancedLineTool.Controls.Add(Me.lblResultsAdvancedLine)
        Me.AdvancedLineTool.Controls.Add(Me.chkMetrologyLineFitCheckBox)
        Me.AdvancedLineTool.Controls.Add(Me.cmdRunAdvancedLine)
        Me.AdvancedLineTool.Controls.Add(Me.Label8)
        Me.AdvancedLineTool.Controls.Add(Me.txtAdvancedLineMaxFitDist)
        Me.AdvancedLineTool.Controls.Add(Me.Label7)
        Me.AdvancedLineTool.Controls.Add(Me.txtAdvancedLineSmoothness)
        Me.AdvancedLineTool.Controls.Add(Me.Label6)
        Me.AdvancedLineTool.Controls.Add(Me.txtAdvancedLineScale)
        Me.AdvancedLineTool.Controls.Add(Me.Label5)
        Me.AdvancedLineTool.Controls.Add(Me.txtAdvancedLineAngleRange)
        Me.AdvancedLineTool.Controls.Add(Me.Label4)
        Me.AdvancedLineTool.Controls.Add(Me.cboAdvancedLineThresholdMode)
        Me.AdvancedLineTool.Controls.Add(Me.Label3)
        Me.AdvancedLineTool.Controls.Add(Me.cboAdvancedLineSelection)
        Me.AdvancedLineTool.Controls.Add(Me.Label2)
        Me.AdvancedLineTool.Controls.Add(Me.cboAdvancedLinePolarity)
        Me.AdvancedLineTool.Controls.Add(Me.Label1)
        Me.AdvancedLineTool.Controls.Add(Me.cboAdvancedLineDirection)
        Me.AdvancedLineTool.Location = New System.Drawing.Point(4, 58)
        Me.AdvancedLineTool.Name = "AdvancedLineTool"
        Me.AdvancedLineTool.Padding = New System.Windows.Forms.Padding(3)
        Me.AdvancedLineTool.Size = New System.Drawing.Size(428, 388)
        Me.AdvancedLineTool.TabIndex = 1
        Me.AdvancedLineTool.Text = "Advanced Line Tool"
        Me.AdvancedLineTool.UseVisualStyleBackColor = True
        '
        'cmdAdvancedLineWidth
        '
        Me.cmdAdvancedLineWidth.Location = New System.Drawing.Point(201, 355)
        Me.cmdAdvancedLineWidth.Name = "cmdAdvancedLineWidth"
        Me.cmdAdvancedLineWidth.Size = New System.Drawing.Size(67, 20)
        Me.cmdAdvancedLineWidth.TabIndex = 54
        Me.cmdAdvancedLineWidth.Text = "Line Width"
        Me.cmdAdvancedLineWidth.UseVisualStyleBackColor = True
        '
        'lblResultsAdvancedLine
        '
        Me.lblResultsAdvancedLine.AutoSize = True
        Me.lblResultsAdvancedLine.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblResultsAdvancedLine.ForeColor = System.Drawing.Color.Blue
        Me.lblResultsAdvancedLine.Location = New System.Drawing.Point(21, 231)
        Me.lblResultsAdvancedLine.Name = "lblResultsAdvancedLine"
        Me.lblResultsAdvancedLine.Size = New System.Drawing.Size(53, 16)
        Me.lblResultsAdvancedLine.TabIndex = 37
        Me.lblResultsAdvancedLine.Text = "Results"
        Me.lblResultsAdvancedLine.Visible = False
        '
        'chkMetrologyLineFitCheckBox
        '
        Me.chkMetrologyLineFitCheckBox.AutoSize = True
        Me.chkMetrologyLineFitCheckBox.Checked = True
        Me.chkMetrologyLineFitCheckBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkMetrologyLineFitCheckBox.Location = New System.Drawing.Point(24, 332)
        Me.chkMetrologyLineFitCheckBox.Name = "chkMetrologyLineFitCheckBox"
        Me.chkMetrologyLineFitCheckBox.Size = New System.Drawing.Size(60, 17)
        Me.chkMetrologyLineFitCheckBox.TabIndex = 36
        Me.chkMetrologyLineFitCheckBox.Text = "Line Fit"
        Me.chkMetrologyLineFitCheckBox.UseVisualStyleBackColor = True
        Me.chkMetrologyLineFitCheckBox.Visible = False
        '
        'cmdRunAdvancedLine
        '
        Me.cmdRunAdvancedLine.Location = New System.Drawing.Point(201, 329)
        Me.cmdRunAdvancedLine.Name = "cmdRunAdvancedLine"
        Me.cmdRunAdvancedLine.Size = New System.Drawing.Size(67, 20)
        Me.cmdRunAdvancedLine.TabIndex = 35
        Me.cmdRunAdvancedLine.Text = "Run"
        Me.cmdRunAdvancedLine.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(44, 191)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(142, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Max Line Fit Dist (-1, 1 - 100)"
        '
        'txtAdvancedLineMaxFitDist
        '
        Me.txtAdvancedLineMaxFitDist.Location = New System.Drawing.Point(199, 188)
        Me.txtAdvancedLineMaxFitDist.Name = "txtAdvancedLineMaxFitDist"
        Me.txtAdvancedLineMaxFitDist.Size = New System.Drawing.Size(32, 20)
        Me.txtAdvancedLineMaxFitDist.TabIndex = 33
        Me.txtAdvancedLineMaxFitDist.Text = "0"
        Me.txtAdvancedLineMaxFitDist.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(79, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(107, 13)
        Me.Label7.TabIndex = 32
        Me.Label7.Text = "Smoothness (0 - 100)"
        '
        'txtAdvancedLineSmoothness
        '
        Me.txtAdvancedLineSmoothness.Location = New System.Drawing.Point(199, 131)
        Me.txtAdvancedLineSmoothness.Name = "txtAdvancedLineSmoothness"
        Me.txtAdvancedLineSmoothness.Size = New System.Drawing.Size(32, 20)
        Me.txtAdvancedLineSmoothness.TabIndex = 31
        Me.txtAdvancedLineSmoothness.Text = "50"
        Me.txtAdvancedLineSmoothness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(21, 352)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(111, 13)
        Me.Label6.TabIndex = 30
        Me.Label6.Text = "Edge Extraxtion Scale"
        Me.Label6.Visible = False
        '
        'txtAdvancedLineScale
        '
        Me.txtAdvancedLineScale.Location = New System.Drawing.Point(155, 352)
        Me.txtAdvancedLineScale.Name = "txtAdvancedLineScale"
        Me.txtAdvancedLineScale.Size = New System.Drawing.Size(32, 20)
        Me.txtAdvancedLineScale.TabIndex = 29
        Me.txtAdvancedLineScale.Text = "1"
        Me.txtAdvancedLineScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.txtAdvancedLineScale.Visible = False
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(53, 161)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(133, 13)
        Me.Label5.TabIndex = 28
        Me.Label5.Text = "Edge Angle Range (0 - 45)"
        '
        'txtAdvancedLineAngleRange
        '
        Me.txtAdvancedLineAngleRange.Location = New System.Drawing.Point(199, 161)
        Me.txtAdvancedLineAngleRange.Name = "txtAdvancedLineAngleRange"
        Me.txtAdvancedLineAngleRange.Size = New System.Drawing.Size(32, 20)
        Me.txtAdvancedLineAngleRange.TabIndex = 27
        Me.txtAdvancedLineAngleRange.Text = "5"
        Me.txtAdvancedLineAngleRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(51, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 13)
        Me.Label4.TabIndex = 26
        Me.Label4.Text = "Threshold Mode"
        '
        'cboAdvancedLineThresholdMode
        '
        Me.cboAdvancedLineThresholdMode.FormattingEnabled = True
        Me.cboAdvancedLineThresholdMode.Items.AddRange(New Object() {"Disable", "Low", "Medium", "High", "Very High"})
        Me.cboAdvancedLineThresholdMode.Location = New System.Drawing.Point(141, 95)
        Me.cboAdvancedLineThresholdMode.Name = "cboAdvancedLineThresholdMode"
        Me.cboAdvancedLineThresholdMode.Size = New System.Drawing.Size(90, 21)
        Me.cboAdvancedLineThresholdMode.TabIndex = 25
        Me.cboAdvancedLineThresholdMode.Text = "Medium"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(84, 73)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 13)
        Me.Label3.TabIndex = 24
        Me.Label3.Text = "Selection"
        '
        'cboAdvancedLineSelection
        '
        Me.cboAdvancedLineSelection.FormattingEnabled = True
        Me.cboAdvancedLineSelection.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "Last", "Disable"})
        Me.cboAdvancedLineSelection.Location = New System.Drawing.Point(141, 68)
        Me.cboAdvancedLineSelection.Name = "cboAdvancedLineSelection"
        Me.cboAdvancedLineSelection.Size = New System.Drawing.Size(90, 21)
        Me.cboAdvancedLineSelection.TabIndex = 23
        Me.cboAdvancedLineSelection.Text = "1"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(83, 44)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(49, 13)
        Me.Label2.TabIndex = 22
        Me.Label2.Text = "Direction"
        '
        'cboAdvancedLinePolarity
        '
        Me.cboAdvancedLinePolarity.FormattingEnabled = True
        Me.cboAdvancedLinePolarity.Items.AddRange(New Object() {"Positive", "Negative", "Any"})
        Me.cboAdvancedLinePolarity.Location = New System.Drawing.Point(141, 14)
        Me.cboAdvancedLinePolarity.Name = "cboAdvancedLinePolarity"
        Me.cboAdvancedLinePolarity.Size = New System.Drawing.Size(90, 21)
        Me.cboAdvancedLinePolarity.TabIndex = 21
        Me.cboAdvancedLinePolarity.Text = "Positive"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(91, 17)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(41, 13)
        Me.Label1.TabIndex = 20
        Me.Label1.Text = "Polarity"
        '
        'cboAdvancedLineDirection
        '
        Me.cboAdvancedLineDirection.FormattingEnabled = True
        Me.cboAdvancedLineDirection.Items.AddRange(New Object() {"South", "East", "North", "West"})
        Me.cboAdvancedLineDirection.Location = New System.Drawing.Point(141, 41)
        Me.cboAdvancedLineDirection.Name = "cboAdvancedLineDirection"
        Me.cboAdvancedLineDirection.Size = New System.Drawing.Size(90, 21)
        Me.cboAdvancedLineDirection.TabIndex = 19
        Me.cboAdvancedLineDirection.Text = "South"
        '
        'SimpleCircleTool
        '
        Me.SimpleCircleTool.Controls.Add(Me.cmdSimpleCircleRun)
        Me.SimpleCircleTool.Controls.Add(Me.lblSimpleCircleResults)
        Me.SimpleCircleTool.Controls.Add(Me.Label10)
        Me.SimpleCircleTool.Controls.Add(Me.txtSimpleCircleMaxFitDistance)
        Me.SimpleCircleTool.Controls.Add(Me.cboSimpleCirclePolarity)
        Me.SimpleCircleTool.Controls.Add(Me.Label21)
        Me.SimpleCircleTool.Controls.Add(Me.cmdPoss)
        Me.SimpleCircleTool.Controls.Add(Me.txtPosY)
        Me.SimpleCircleTool.Controls.Add(Me.txtPosX)
        Me.SimpleCircleTool.Controls.Add(Me.cmdSize)
        Me.SimpleCircleTool.Controls.Add(Me.txtY)
        Me.SimpleCircleTool.Controls.Add(Me.txtX)
        Me.SimpleCircleTool.Location = New System.Drawing.Point(4, 58)
        Me.SimpleCircleTool.Name = "SimpleCircleTool"
        Me.SimpleCircleTool.Size = New System.Drawing.Size(428, 388)
        Me.SimpleCircleTool.TabIndex = 2
        Me.SimpleCircleTool.Text = "Simple Circle Tool"
        Me.SimpleCircleTool.UseVisualStyleBackColor = True
        '
        'cmdSimpleCircleRun
        '
        Me.cmdSimpleCircleRun.Location = New System.Drawing.Point(201, 349)
        Me.cmdSimpleCircleRun.Name = "cmdSimpleCircleRun"
        Me.cmdSimpleCircleRun.Size = New System.Drawing.Size(67, 20)
        Me.cmdSimpleCircleRun.TabIndex = 73
        Me.cmdSimpleCircleRun.Text = "Run"
        Me.cmdSimpleCircleRun.UseVisualStyleBackColor = True
        '
        'lblSimpleCircleResults
        '
        Me.lblSimpleCircleResults.AutoSize = True
        Me.lblSimpleCircleResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSimpleCircleResults.ForeColor = System.Drawing.Color.Blue
        Me.lblSimpleCircleResults.Location = New System.Drawing.Point(24, 239)
        Me.lblSimpleCircleResults.Name = "lblSimpleCircleResults"
        Me.lblSimpleCircleResults.Size = New System.Drawing.Size(53, 16)
        Me.lblSimpleCircleResults.TabIndex = 72
        Me.lblSimpleCircleResults.Text = "Results"
        Me.lblSimpleCircleResults.Visible = False
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(81, 200)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(142, 13)
        Me.Label10.TabIndex = 71
        Me.Label10.Text = "Max Line Fit Dist (-1, 1 - 100)"
        '
        'txtSimpleCircleMaxFitDistance
        '
        Me.txtSimpleCircleMaxFitDistance.Location = New System.Drawing.Point(236, 197)
        Me.txtSimpleCircleMaxFitDistance.Name = "txtSimpleCircleMaxFitDistance"
        Me.txtSimpleCircleMaxFitDistance.Size = New System.Drawing.Size(32, 20)
        Me.txtSimpleCircleMaxFitDistance.TabIndex = 70
        Me.txtSimpleCircleMaxFitDistance.Text = "10"
        Me.txtSimpleCircleMaxFitDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboSimpleCirclePolarity
        '
        Me.cboSimpleCirclePolarity.FormattingEnabled = True
        Me.cboSimpleCirclePolarity.Items.AddRange(New Object() {"Positive", "Negative", "Any"})
        Me.cboSimpleCirclePolarity.Location = New System.Drawing.Point(178, 23)
        Me.cboSimpleCirclePolarity.Name = "cboSimpleCirclePolarity"
        Me.cboSimpleCirclePolarity.Size = New System.Drawing.Size(90, 21)
        Me.cboSimpleCirclePolarity.TabIndex = 60
        Me.cboSimpleCirclePolarity.Text = "Positive"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Location = New System.Drawing.Point(128, 26)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(41, 13)
        Me.Label21.TabIndex = 59
        Me.Label21.Text = "Polarity"
        '
        'cmdPoss
        '
        Me.cmdPoss.Location = New System.Drawing.Point(107, 349)
        Me.cmdPoss.Name = "cmdPoss"
        Me.cmdPoss.Size = New System.Drawing.Size(62, 20)
        Me.cmdPoss.TabIndex = 57
        Me.cmdPoss.Text = "Set Pos"
        Me.cmdPoss.UseVisualStyleBackColor = True
        Me.cmdPoss.Visible = False
        '
        'txtPosY
        '
        Me.txtPosY.Location = New System.Drawing.Point(59, 350)
        Me.txtPosY.Name = "txtPosY"
        Me.txtPosY.Size = New System.Drawing.Size(42, 20)
        Me.txtPosY.TabIndex = 56
        Me.txtPosY.Visible = False
        '
        'txtPosX
        '
        Me.txtPosX.Location = New System.Drawing.Point(11, 350)
        Me.txtPosX.Name = "txtPosX"
        Me.txtPosX.Size = New System.Drawing.Size(42, 20)
        Me.txtPosX.TabIndex = 55
        Me.txtPosX.Visible = False
        '
        'cmdSize
        '
        Me.cmdSize.Location = New System.Drawing.Point(107, 323)
        Me.cmdSize.Name = "cmdSize"
        Me.cmdSize.Size = New System.Drawing.Size(62, 20)
        Me.cmdSize.TabIndex = 54
        Me.cmdSize.Text = "Set Size"
        Me.cmdSize.UseVisualStyleBackColor = True
        Me.cmdSize.Visible = False
        '
        'txtY
        '
        Me.txtY.Location = New System.Drawing.Point(59, 324)
        Me.txtY.Name = "txtY"
        Me.txtY.Size = New System.Drawing.Size(42, 20)
        Me.txtY.TabIndex = 53
        Me.txtY.Visible = False
        '
        'txtX
        '
        Me.txtX.Location = New System.Drawing.Point(11, 324)
        Me.txtX.Name = "txtX"
        Me.txtX.Size = New System.Drawing.Size(42, 20)
        Me.txtX.TabIndex = 52
        Me.txtX.Visible = False
        '
        'AdvancedCircleTool
        '
        Me.AdvancedCircleTool.Controls.Add(Me.cmdAdvancedCirleRun)
        Me.AdvancedCircleTool.Controls.Add(Me.chkAdvancedCircleFit)
        Me.AdvancedCircleTool.Controls.Add(Me.Label26)
        Me.AdvancedCircleTool.Controls.Add(Me.txtAdvancedCircleEdgeExtractionScale)
        Me.AdvancedCircleTool.Controls.Add(Me.updnAdvancedCircleAngle)
        Me.AdvancedCircleTool.Controls.Add(Me.Label25)
        Me.AdvancedCircleTool.Controls.Add(Me.Label9)
        Me.AdvancedCircleTool.Controls.Add(Me.txtAdvancedCircleMaxLineFitDistance)
        Me.AdvancedCircleTool.Controls.Add(Me.cboAdvancedCirclePolarity)
        Me.AdvancedCircleTool.Controls.Add(Me.Label15)
        Me.AdvancedCircleTool.Controls.Add(Me.Label11)
        Me.AdvancedCircleTool.Controls.Add(Me.txtAdvancedCircleSmoothness)
        Me.AdvancedCircleTool.Controls.Add(Me.Label12)
        Me.AdvancedCircleTool.Controls.Add(Me.txtAdvancedCircleEdgeAngleRange)
        Me.AdvancedCircleTool.Controls.Add(Me.Label13)
        Me.AdvancedCircleTool.Controls.Add(Me.cboAdvancedCircleThresholdMode)
        Me.AdvancedCircleTool.Controls.Add(Me.Label14)
        Me.AdvancedCircleTool.Controls.Add(Me.cboAdvancedCircleEdgeSelection)
        Me.AdvancedCircleTool.Location = New System.Drawing.Point(4, 58)
        Me.AdvancedCircleTool.Name = "AdvancedCircleTool"
        Me.AdvancedCircleTool.Size = New System.Drawing.Size(428, 388)
        Me.AdvancedCircleTool.TabIndex = 10
        Me.AdvancedCircleTool.Text = "Advanced Circle Tool"
        Me.AdvancedCircleTool.UseVisualStyleBackColor = True
        '
        'cmdAdvancedCirleRun
        '
        Me.cmdAdvancedCirleRun.Location = New System.Drawing.Point(309, 323)
        Me.cmdAdvancedCirleRun.Name = "cmdAdvancedCirleRun"
        Me.cmdAdvancedCirleRun.Size = New System.Drawing.Size(67, 20)
        Me.cmdAdvancedCirleRun.TabIndex = 87
        Me.cmdAdvancedCirleRun.Text = "Run"
        Me.cmdAdvancedCirleRun.UseVisualStyleBackColor = True
        '
        'chkAdvancedCircleFit
        '
        Me.chkAdvancedCircleFit.AutoSize = True
        Me.chkAdvancedCircleFit.Checked = True
        Me.chkAdvancedCircleFit.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkAdvancedCircleFit.Location = New System.Drawing.Point(48, 96)
        Me.chkAdvancedCircleFit.Name = "chkAdvancedCircleFit"
        Me.chkAdvancedCircleFit.Size = New System.Drawing.Size(66, 17)
        Me.chkAdvancedCircleFit.TabIndex = 86
        Me.chkAdvancedCircleFit.Text = "Circle Fit"
        Me.chkAdvancedCircleFit.UseVisualStyleBackColor = True
        Me.chkAdvancedCircleFit.Visible = False
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Enabled = False
        Me.Label26.Location = New System.Drawing.Point(220, 164)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(112, 13)
        Me.Label26.TabIndex = 85
        Me.Label26.Text = "Edge Extraction Scale"
        '
        'txtAdvancedCircleEdgeExtractionScale
        '
        Me.txtAdvancedCircleEdgeExtractionScale.Enabled = False
        Me.txtAdvancedCircleEdgeExtractionScale.Location = New System.Drawing.Point(340, 161)
        Me.txtAdvancedCircleEdgeExtractionScale.Name = "txtAdvancedCircleEdgeExtractionScale"
        Me.txtAdvancedCircleEdgeExtractionScale.Size = New System.Drawing.Size(32, 20)
        Me.txtAdvancedCircleEdgeExtractionScale.TabIndex = 84
        Me.txtAdvancedCircleEdgeExtractionScale.Text = "1"
        Me.txtAdvancedCircleEdgeExtractionScale.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'updnAdvancedCircleAngle
        '
        Me.updnAdvancedCircleAngle.Location = New System.Drawing.Point(48, 47)
        Me.updnAdvancedCircleAngle.Maximum = New Decimal(New Integer() {359, 0, 0, 0})
        Me.updnAdvancedCircleAngle.Name = "updnAdvancedCircleAngle"
        Me.updnAdvancedCircleAngle.Size = New System.Drawing.Size(50, 20)
        Me.updnAdvancedCircleAngle.TabIndex = 83
        '
        'Label25
        '
        Me.Label25.AutoSize = True
        Me.Label25.Location = New System.Drawing.Point(45, 31)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(58, 13)
        Me.Label25.TabIndex = 82
        Me.Label25.Text = "Tool Angle"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(189, 244)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(142, 13)
        Me.Label9.TabIndex = 81
        Me.Label9.Text = "Max Line Fit Dist (-1, 1 - 100)"
        '
        'txtAdvancedCircleMaxLineFitDistance
        '
        Me.txtAdvancedCircleMaxLineFitDistance.Location = New System.Drawing.Point(344, 241)
        Me.txtAdvancedCircleMaxLineFitDistance.Name = "txtAdvancedCircleMaxLineFitDistance"
        Me.txtAdvancedCircleMaxLineFitDistance.Size = New System.Drawing.Size(32, 20)
        Me.txtAdvancedCircleMaxLineFitDistance.TabIndex = 80
        Me.txtAdvancedCircleMaxLineFitDistance.Text = "10"
        Me.txtAdvancedCircleMaxLineFitDistance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'cboAdvancedCirclePolarity
        '
        Me.cboAdvancedCirclePolarity.FormattingEnabled = True
        Me.cboAdvancedCirclePolarity.Items.AddRange(New Object() {"Positive", "Negative", "Any"})
        Me.cboAdvancedCirclePolarity.Location = New System.Drawing.Point(286, 31)
        Me.cboAdvancedCirclePolarity.Name = "cboAdvancedCirclePolarity"
        Me.cboAdvancedCirclePolarity.Size = New System.Drawing.Size(90, 21)
        Me.cboAdvancedCirclePolarity.TabIndex = 79
        Me.cboAdvancedCirclePolarity.Text = "Positive"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(236, 34)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(41, 13)
        Me.Label15.TabIndex = 78
        Me.Label15.Text = "Polarity"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Enabled = False
        Me.Label11.Location = New System.Drawing.Point(220, 138)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(107, 13)
        Me.Label11.TabIndex = 77
        Me.Label11.Text = "Smoothness (0 - 100)"
        '
        'txtAdvancedCircleSmoothness
        '
        Me.txtAdvancedCircleSmoothness.Enabled = False
        Me.txtAdvancedCircleSmoothness.Location = New System.Drawing.Point(340, 135)
        Me.txtAdvancedCircleSmoothness.Name = "txtAdvancedCircleSmoothness"
        Me.txtAdvancedCircleSmoothness.Size = New System.Drawing.Size(32, 20)
        Me.txtAdvancedCircleSmoothness.TabIndex = 76
        Me.txtAdvancedCircleSmoothness.Text = "50"
        Me.txtAdvancedCircleSmoothness.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Enabled = False
        Me.Label12.Location = New System.Drawing.Point(194, 201)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(133, 13)
        Me.Label12.TabIndex = 75
        Me.Label12.Text = "Edge Angle Range (0 - 45)"
        '
        'txtAdvancedCircleEdgeAngleRange
        '
        Me.txtAdvancedCircleEdgeAngleRange.Enabled = False
        Me.txtAdvancedCircleEdgeAngleRange.Location = New System.Drawing.Point(340, 201)
        Me.txtAdvancedCircleEdgeAngleRange.Name = "txtAdvancedCircleEdgeAngleRange"
        Me.txtAdvancedCircleEdgeAngleRange.Size = New System.Drawing.Size(32, 20)
        Me.txtAdvancedCircleEdgeAngleRange.TabIndex = 74
        Me.txtAdvancedCircleEdgeAngleRange.Text = "5"
        Me.txtAdvancedCircleEdgeAngleRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Enabled = False
        Me.Label13.Location = New System.Drawing.Point(192, 104)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(84, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Threshold Mode"
        '
        'cboAdvancedCircleThresholdMode
        '
        Me.cboAdvancedCircleThresholdMode.Enabled = False
        Me.cboAdvancedCircleThresholdMode.FormattingEnabled = True
        Me.cboAdvancedCircleThresholdMode.Items.AddRange(New Object() {"Disable", "Low", "Medium", "High", "Very High"})
        Me.cboAdvancedCircleThresholdMode.Location = New System.Drawing.Point(282, 99)
        Me.cboAdvancedCircleThresholdMode.Name = "cboAdvancedCircleThresholdMode"
        Me.cboAdvancedCircleThresholdMode.Size = New System.Drawing.Size(90, 21)
        Me.cboAdvancedCircleThresholdMode.TabIndex = 72
        Me.cboAdvancedCircleThresholdMode.Text = "Medium"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Enabled = False
        Me.Label14.Location = New System.Drawing.Point(225, 77)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(51, 13)
        Me.Label14.TabIndex = 71
        Me.Label14.Text = "Selection"
        '
        'cboAdvancedCircleEdgeSelection
        '
        Me.cboAdvancedCircleEdgeSelection.Enabled = False
        Me.cboAdvancedCircleEdgeSelection.FormattingEnabled = True
        Me.cboAdvancedCircleEdgeSelection.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "Last", "Disable"})
        Me.cboAdvancedCircleEdgeSelection.Location = New System.Drawing.Point(282, 72)
        Me.cboAdvancedCircleEdgeSelection.Name = "cboAdvancedCircleEdgeSelection"
        Me.cboAdvancedCircleEdgeSelection.Size = New System.Drawing.Size(90, 21)
        Me.cboAdvancedCircleEdgeSelection.TabIndex = 70
        Me.cboAdvancedCircleEdgeSelection.Text = "1"
        '
        'BlobTool
        '
        Me.BlobTool.Controls.Add(Me.GroupBox12)
        Me.BlobTool.Controls.Add(Me.chkClickOnBlobs)
        Me.BlobTool.Controls.Add(Me.GroupBox10)
        Me.BlobTool.Controls.Add(Me.lblBlobResults)
        Me.BlobTool.Controls.Add(Me.cmdDisplayAll)
        Me.BlobTool.Controls.Add(Me.cboBlobs)
        Me.BlobTool.Controls.Add(Me.lblBlobs)
        Me.BlobTool.Controls.Add(Me.cmdBlobRun)
        Me.BlobTool.Controls.Add(Me.chkCG)
        Me.BlobTool.Controls.Add(Me.chkHull)
        Me.BlobTool.Controls.Add(Me.chkBox)
        Me.BlobTool.Location = New System.Drawing.Point(4, 58)
        Me.BlobTool.Name = "BlobTool"
        Me.BlobTool.Size = New System.Drawing.Size(428, 388)
        Me.BlobTool.TabIndex = 5
        Me.BlobTool.Text = "Blob Tool"
        Me.BlobTool.UseVisualStyleBackColor = True
        '
        'GroupBox12
        '
        Me.GroupBox12.Controls.Add(Me.optBiggest)
        Me.GroupBox12.Controls.Add(Me.optSmallest)
        Me.GroupBox12.Controls.Add(Me.optCenter)
        Me.GroupBox12.Controls.Add(Me.optBottom)
        Me.GroupBox12.Controls.Add(Me.optTop)
        Me.GroupBox12.Controls.Add(Me.optRight)
        Me.GroupBox12.Controls.Add(Me.optLeft)
        Me.GroupBox12.Controls.Add(Me.optLR)
        Me.GroupBox12.Controls.Add(Me.optLL)
        Me.GroupBox12.Controls.Add(Me.optUR)
        Me.GroupBox12.Controls.Add(Me.optUL)
        Me.GroupBox12.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox12.Location = New System.Drawing.Point(16, 229)
        Me.GroupBox12.Name = "GroupBox12"
        Me.GroupBox12.Size = New System.Drawing.Size(260, 119)
        Me.GroupBox12.TabIndex = 45
        Me.GroupBox12.TabStop = False
        Me.GroupBox12.Text = "Postion Filter"
        '
        'optBiggest
        '
        Me.optBiggest.AutoSize = True
        Me.optBiggest.Location = New System.Drawing.Point(148, 89)
        Me.optBiggest.Name = "optBiggest"
        Me.optBiggest.Size = New System.Drawing.Size(72, 20)
        Me.optBiggest.TabIndex = 10
        Me.optBiggest.TabStop = True
        Me.optBiggest.Text = "Biggest"
        Me.optBiggest.UseVisualStyleBackColor = True
        '
        'optSmallest
        '
        Me.optSmallest.AutoSize = True
        Me.optSmallest.Location = New System.Drawing.Point(41, 89)
        Me.optSmallest.Name = "optSmallest"
        Me.optSmallest.Size = New System.Drawing.Size(78, 20)
        Me.optSmallest.TabIndex = 9
        Me.optSmallest.TabStop = True
        Me.optSmallest.Text = "Smallest"
        Me.optSmallest.UseVisualStyleBackColor = True
        '
        'optCenter
        '
        Me.optCenter.AutoSize = True
        Me.optCenter.Location = New System.Drawing.Point(96, 42)
        Me.optCenter.Name = "optCenter"
        Me.optCenter.Size = New System.Drawing.Size(65, 20)
        Me.optCenter.TabIndex = 8
        Me.optCenter.TabStop = True
        Me.optCenter.Text = "Center"
        Me.optCenter.UseVisualStyleBackColor = True
        '
        'optBottom
        '
        Me.optBottom.AutoSize = True
        Me.optBottom.Location = New System.Drawing.Point(96, 68)
        Me.optBottom.Name = "optBottom"
        Me.optBottom.Size = New System.Drawing.Size(68, 20)
        Me.optBottom.TabIndex = 7
        Me.optBottom.TabStop = True
        Me.optBottom.Text = "Bottom"
        Me.optBottom.UseVisualStyleBackColor = True
        '
        'optTop
        '
        Me.optTop.AutoSize = True
        Me.optTop.Location = New System.Drawing.Point(96, 21)
        Me.optTop.Name = "optTop"
        Me.optTop.Size = New System.Drawing.Size(51, 20)
        Me.optTop.TabIndex = 6
        Me.optTop.TabStop = True
        Me.optTop.Text = "Top"
        Me.optTop.UseVisualStyleBackColor = True
        '
        'optRight
        '
        Me.optRight.AutoSize = True
        Me.optRight.Location = New System.Drawing.Point(186, 44)
        Me.optRight.Name = "optRight"
        Me.optRight.Size = New System.Drawing.Size(57, 20)
        Me.optRight.TabIndex = 5
        Me.optRight.TabStop = True
        Me.optRight.Text = "Right"
        Me.optRight.UseVisualStyleBackColor = True
        '
        'optLeft
        '
        Me.optLeft.AutoSize = True
        Me.optLeft.Location = New System.Drawing.Point(12, 44)
        Me.optLeft.Name = "optLeft"
        Me.optLeft.Size = New System.Drawing.Size(47, 20)
        Me.optLeft.TabIndex = 4
        Me.optLeft.TabStop = True
        Me.optLeft.Text = "Left"
        Me.optLeft.UseVisualStyleBackColor = True
        '
        'optLR
        '
        Me.optLR.AutoSize = True
        Me.optLR.Location = New System.Drawing.Point(186, 68)
        Me.optLR.Name = "optLR"
        Me.optLR.Size = New System.Drawing.Size(43, 20)
        Me.optLR.TabIndex = 3
        Me.optLR.TabStop = True
        Me.optLR.Text = "LR"
        Me.optLR.UseVisualStyleBackColor = True
        '
        'optLL
        '
        Me.optLL.AutoSize = True
        Me.optLL.Location = New System.Drawing.Point(12, 68)
        Me.optLL.Name = "optLL"
        Me.optLL.Size = New System.Drawing.Size(40, 20)
        Me.optLL.TabIndex = 2
        Me.optLL.TabStop = True
        Me.optLL.Text = "LL"
        Me.optLL.UseVisualStyleBackColor = True
        '
        'optUR
        '
        Me.optUR.AutoSize = True
        Me.optUR.Location = New System.Drawing.Point(186, 21)
        Me.optUR.Name = "optUR"
        Me.optUR.Size = New System.Drawing.Size(46, 20)
        Me.optUR.TabIndex = 1
        Me.optUR.TabStop = True
        Me.optUR.Text = "UR"
        Me.optUR.UseVisualStyleBackColor = True
        '
        'optUL
        '
        Me.optUL.AutoSize = True
        Me.optUL.Location = New System.Drawing.Point(12, 21)
        Me.optUL.Name = "optUL"
        Me.optUL.Size = New System.Drawing.Size(43, 20)
        Me.optUL.TabIndex = 0
        Me.optUL.TabStop = True
        Me.optUL.Text = "UL"
        Me.optUL.UseVisualStyleBackColor = True
        '
        'chkClickOnBlobs
        '
        Me.chkClickOnBlobs.AutoSize = True
        Me.chkClickOnBlobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkClickOnBlobs.Location = New System.Drawing.Point(26, 354)
        Me.chkClickOnBlobs.Name = "chkClickOnBlobs"
        Me.chkClickOnBlobs.Size = New System.Drawing.Size(114, 20)
        Me.chkClickOnBlobs.TabIndex = 44
        Me.chkClickOnBlobs.Text = "Click On Blobs"
        Me.chkClickOnBlobs.UseVisualStyleBackColor = True
        '
        'GroupBox10
        '
        Me.GroupBox10.Controls.Add(Me.txtAreaMax)
        Me.GroupBox10.Controls.Add(Me.txtAreaMin)
        Me.GroupBox10.Controls.Add(Me.chkAreaIgnore)
        Me.GroupBox10.Controls.Add(Me.Label20)
        Me.GroupBox10.Controls.Add(Me.Label19)
        Me.GroupBox10.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox10.Location = New System.Drawing.Point(16, 101)
        Me.GroupBox10.Name = "GroupBox10"
        Me.GroupBox10.Size = New System.Drawing.Size(129, 111)
        Me.GroupBox10.TabIndex = 43
        Me.GroupBox10.TabStop = False
        Me.GroupBox10.Text = "Size Filters"
        '
        'txtAreaMax
        '
        Me.txtAreaMax.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaMax.Location = New System.Drawing.Point(50, 52)
        Me.txtAreaMax.Name = "txtAreaMax"
        Me.txtAreaMax.Size = New System.Drawing.Size(69, 22)
        Me.txtAreaMax.TabIndex = 4
        Me.txtAreaMax.Text = "1000000"
        '
        'txtAreaMin
        '
        Me.txtAreaMin.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtAreaMin.Location = New System.Drawing.Point(50, 22)
        Me.txtAreaMin.Name = "txtAreaMin"
        Me.txtAreaMin.Size = New System.Drawing.Size(69, 22)
        Me.txtAreaMin.TabIndex = 3
        Me.txtAreaMin.Text = "1000"
        '
        'chkAreaIgnore
        '
        Me.chkAreaIgnore.AutoSize = True
        Me.chkAreaIgnore.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.chkAreaIgnore.Location = New System.Drawing.Point(11, 80)
        Me.chkAreaIgnore.Name = "chkAreaIgnore"
        Me.chkAreaIgnore.Size = New System.Drawing.Size(65, 20)
        Me.chkAreaIgnore.TabIndex = 2
        Me.chkAreaIgnore.Text = "Ignore"
        Me.chkAreaIgnore.UseVisualStyleBackColor = True
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(7, 53)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(33, 16)
        Me.Label20.TabIndex = 1
        Me.Label20.Text = "Max"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(7, 25)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(29, 16)
        Me.Label19.TabIndex = 0
        Me.Label19.Text = "Min"
        '
        'lblBlobResults
        '
        Me.lblBlobResults.AutoSize = True
        Me.lblBlobResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlobResults.ForeColor = System.Drawing.Color.Blue
        Me.lblBlobResults.Location = New System.Drawing.Point(18, 16)
        Me.lblBlobResults.Name = "lblBlobResults"
        Me.lblBlobResults.Size = New System.Drawing.Size(53, 16)
        Me.lblBlobResults.TabIndex = 42
        Me.lblBlobResults.Text = "Results"
        Me.lblBlobResults.Visible = False
        '
        'cmdDisplayAll
        '
        Me.cmdDisplayAll.Location = New System.Drawing.Point(185, 192)
        Me.cmdDisplayAll.Name = "cmdDisplayAll"
        Me.cmdDisplayAll.Size = New System.Drawing.Size(67, 20)
        Me.cmdDisplayAll.TabIndex = 41
        Me.cmdDisplayAll.Text = "Display All"
        Me.cmdDisplayAll.UseVisualStyleBackColor = True
        '
        'cboBlobs
        '
        Me.cboBlobs.FormattingEnabled = True
        Me.cboBlobs.Location = New System.Drawing.Point(204, 37)
        Me.cboBlobs.Name = "cboBlobs"
        Me.cboBlobs.Size = New System.Drawing.Size(49, 21)
        Me.cboBlobs.TabIndex = 40
        '
        'lblBlobs
        '
        Me.lblBlobs.AutoSize = True
        Me.lblBlobs.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblBlobs.ForeColor = System.Drawing.Color.Blue
        Me.lblBlobs.Location = New System.Drawing.Point(207, 16)
        Me.lblBlobs.Name = "lblBlobs"
        Me.lblBlobs.Size = New System.Drawing.Size(46, 16)
        Me.lblBlobs.TabIndex = 39
        Me.lblBlobs.Text = "Blobs:"
        Me.lblBlobs.Visible = False
        '
        'cmdBlobRun
        '
        Me.cmdBlobRun.Location = New System.Drawing.Point(186, 166)
        Me.cmdBlobRun.Name = "cmdBlobRun"
        Me.cmdBlobRun.Size = New System.Drawing.Size(67, 20)
        Me.cmdBlobRun.TabIndex = 36
        Me.cmdBlobRun.Text = "Run"
        Me.cmdBlobRun.UseVisualStyleBackColor = True
        '
        'chkCG
        '
        Me.chkCG.AutoSize = True
        Me.chkCG.Checked = True
        Me.chkCG.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkCG.Location = New System.Drawing.Point(198, 71)
        Me.chkCG.Name = "chkCG"
        Me.chkCG.Size = New System.Drawing.Size(47, 17)
        Me.chkCG.TabIndex = 2
        Me.chkCG.Text = "C.G."
        Me.chkCG.UseVisualStyleBackColor = True
        Me.chkCG.Visible = False
        '
        'chkHull
        '
        Me.chkHull.AutoSize = True
        Me.chkHull.Checked = True
        Me.chkHull.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkHull.Location = New System.Drawing.Point(198, 48)
        Me.chkHull.Name = "chkHull"
        Me.chkHull.Size = New System.Drawing.Size(44, 17)
        Me.chkHull.TabIndex = 1
        Me.chkHull.Text = "Hull"
        Me.chkHull.UseVisualStyleBackColor = True
        Me.chkHull.Visible = False
        '
        'chkBox
        '
        Me.chkBox.AutoSize = True
        Me.chkBox.Checked = True
        Me.chkBox.CheckState = System.Windows.Forms.CheckState.Checked
        Me.chkBox.Location = New System.Drawing.Point(193, 29)
        Me.chkBox.Name = "chkBox"
        Me.chkBox.Size = New System.Drawing.Size(44, 17)
        Me.chkBox.TabIndex = 0
        Me.chkBox.Text = "Box"
        Me.chkBox.UseVisualStyleBackColor = True
        Me.chkBox.Visible = False
        '
        'GeometricModelFinder
        '
        Me.GeometricModelFinder.Controls.Add(Me.lblGeoResults)
        Me.GeometricModelFinder.Controls.Add(Me.lstGeoResults)
        Me.GeometricModelFinder.Controls.Add(Me.txtGeoMatchThreshold)
        Me.GeometricModelFinder.Controls.Add(Me.txtGeoMaxNum)
        Me.GeometricModelFinder.Controls.Add(Me.Label29)
        Me.GeometricModelFinder.Controls.Add(Me.Label28)
        Me.GeometricModelFinder.Controls.Add(Me.Label27)
        Me.GeometricModelFinder.Controls.Add(Me.cmdGeoSetFullImage)
        Me.GeometricModelFinder.Controls.Add(Me.lblGeoModelName)
        Me.GeometricModelFinder.Controls.Add(Me.cmdLoadGeometricModel)
        Me.GeometricModelFinder.Controls.Add(Me.lstGeoFiles)
        Me.GeometricModelFinder.Controls.Add(Me.GroupBox6)
        Me.GeometricModelFinder.Controls.Add(Me.cmdSearchGeometricModelFinder)
        Me.GeometricModelFinder.Controls.Add(Me.cmdTrainGeometricModelFinder)
        Me.GeometricModelFinder.Location = New System.Drawing.Point(4, 58)
        Me.GeometricModelFinder.Name = "GeometricModelFinder"
        Me.GeometricModelFinder.Size = New System.Drawing.Size(428, 388)
        Me.GeometricModelFinder.TabIndex = 4
        Me.GeometricModelFinder.Text = "Geomteric Model Finder"
        Me.GeometricModelFinder.UseVisualStyleBackColor = True
        '
        'lblGeoResults
        '
        Me.lblGeoResults.AutoSize = True
        Me.lblGeoResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeoResults.ForeColor = System.Drawing.Color.Blue
        Me.lblGeoResults.Location = New System.Drawing.Point(39, 241)
        Me.lblGeoResults.Name = "lblGeoResults"
        Me.lblGeoResults.Size = New System.Drawing.Size(59, 16)
        Me.lblGeoResults.TabIndex = 18
        Me.lblGeoResults.Text = "Results: "
        '
        'lstGeoResults
        '
        Me.lstGeoResults.FormattingEnabled = True
        Me.lstGeoResults.Location = New System.Drawing.Point(36, 264)
        Me.lstGeoResults.Name = "lstGeoResults"
        Me.lstGeoResults.Size = New System.Drawing.Size(188, 95)
        Me.lstGeoResults.TabIndex = 17
        '
        'txtGeoMatchThreshold
        '
        Me.txtGeoMatchThreshold.Location = New System.Drawing.Point(180, 102)
        Me.txtGeoMatchThreshold.Name = "txtGeoMatchThreshold"
        Me.txtGeoMatchThreshold.Size = New System.Drawing.Size(55, 20)
        Me.txtGeoMatchThreshold.TabIndex = 16
        Me.txtGeoMatchThreshold.Text = "70"
        '
        'txtGeoMaxNum
        '
        Me.txtGeoMaxNum.Location = New System.Drawing.Point(180, 74)
        Me.txtGeoMaxNum.Name = "txtGeoMaxNum"
        Me.txtGeoMaxNum.Size = New System.Drawing.Size(55, 20)
        Me.txtGeoMaxNum.TabIndex = 15
        Me.txtGeoMaxNum.Text = "100"
        '
        'Label29
        '
        Me.Label29.AutoSize = True
        Me.Label29.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label29.ForeColor = System.Drawing.Color.Blue
        Me.Label29.Location = New System.Drawing.Point(23, 102)
        Me.Label29.Name = "Label29"
        Me.Label29.Size = New System.Drawing.Size(134, 16)
        Me.Label29.TabIndex = 14
        Me.Label29.Text = "Match Threshold (%):"
        '
        'Label28
        '
        Me.Label28.AutoSize = True
        Me.Label28.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label28.ForeColor = System.Drawing.Color.Blue
        Me.Label28.Location = New System.Drawing.Point(23, 71)
        Me.Label28.Name = "Label28"
        Me.Label28.Size = New System.Drawing.Size(150, 16)
        Me.Label28.TabIndex = 13
        Me.Label28.Text = "Max Number of Objects:"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Blue
        Me.Label27.Location = New System.Drawing.Point(23, 28)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(147, 16)
        Me.Label27.TabIndex = 12
        Me.Label27.Text = "Set Tool To Full Image:"
        '
        'cmdGeoSetFullImage
        '
        Me.cmdGeoSetFullImage.Location = New System.Drawing.Point(173, 28)
        Me.cmdGeoSetFullImage.Name = "cmdGeoSetFullImage"
        Me.cmdGeoSetFullImage.Size = New System.Drawing.Size(51, 20)
        Me.cmdGeoSetFullImage.TabIndex = 11
        Me.cmdGeoSetFullImage.Text = "Set"
        Me.cmdGeoSetFullImage.UseVisualStyleBackColor = True
        '
        'lblGeoModelName
        '
        Me.lblGeoModelName.AutoSize = True
        Me.lblGeoModelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGeoModelName.ForeColor = System.Drawing.Color.Blue
        Me.lblGeoModelName.Location = New System.Drawing.Point(279, 19)
        Me.lblGeoModelName.Name = "lblGeoModelName"
        Me.lblGeoModelName.Size = New System.Drawing.Size(118, 16)
        Me.lblGeoModelName.TabIndex = 10
        Me.lblGeoModelName.Text = "Geometric Models"
        '
        'cmdLoadGeometricModel
        '
        Me.cmdLoadGeometricModel.Location = New System.Drawing.Point(310, 237)
        Me.cmdLoadGeometricModel.Name = "cmdLoadGeometricModel"
        Me.cmdLoadGeometricModel.Size = New System.Drawing.Size(67, 20)
        Me.cmdLoadGeometricModel.TabIndex = 9
        Me.cmdLoadGeometricModel.Text = "Load"
        Me.cmdLoadGeometricModel.UseVisualStyleBackColor = True
        '
        'lstGeoFiles
        '
        Me.lstGeoFiles.FormattingEnabled = True
        Me.lstGeoFiles.Location = New System.Drawing.Point(282, 58)
        Me.lstGeoFiles.Name = "lstGeoFiles"
        Me.lstGeoFiles.Size = New System.Drawing.Size(122, 173)
        Me.lstGeoFiles.TabIndex = 8
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.chkOriginGeometric)
        Me.GroupBox6.Controls.Add(Me.cmdCenterGeo)
        Me.GroupBox6.Location = New System.Drawing.Point(36, 145)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(121, 74)
        Me.GroupBox6.TabIndex = 7
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Origin"
        Me.GroupBox6.Visible = False
        '
        'chkOriginGeometric
        '
        Me.chkOriginGeometric.AutoSize = True
        Me.chkOriginGeometric.Location = New System.Drawing.Point(34, 19)
        Me.chkOriginGeometric.Name = "chkOriginGeometric"
        Me.chkOriginGeometric.Size = New System.Drawing.Size(53, 17)
        Me.chkOriginGeometric.TabIndex = 8
        Me.chkOriginGeometric.Text = "Move"
        Me.chkOriginGeometric.UseVisualStyleBackColor = True
        '
        'cmdCenterGeo
        '
        Me.cmdCenterGeo.Location = New System.Drawing.Point(11, 42)
        Me.cmdCenterGeo.Name = "cmdCenterGeo"
        Me.cmdCenterGeo.Size = New System.Drawing.Size(99, 22)
        Me.cmdCenterGeo.TabIndex = 7
        Me.cmdCenterGeo.Text = "Center On Tool"
        Me.cmdCenterGeo.UseVisualStyleBackColor = True
        '
        'cmdSearchGeometricModelFinder
        '
        Me.cmdSearchGeometricModelFinder.Location = New System.Drawing.Point(317, 339)
        Me.cmdSearchGeometricModelFinder.Name = "cmdSearchGeometricModelFinder"
        Me.cmdSearchGeometricModelFinder.Size = New System.Drawing.Size(67, 20)
        Me.cmdSearchGeometricModelFinder.TabIndex = 5
        Me.cmdSearchGeometricModelFinder.Text = "Search"
        Me.cmdSearchGeometricModelFinder.UseVisualStyleBackColor = True
        '
        'cmdTrainGeometricModelFinder
        '
        Me.cmdTrainGeometricModelFinder.Location = New System.Drawing.Point(317, 310)
        Me.cmdTrainGeometricModelFinder.Name = "cmdTrainGeometricModelFinder"
        Me.cmdTrainGeometricModelFinder.Size = New System.Drawing.Size(67, 20)
        Me.cmdTrainGeometricModelFinder.TabIndex = 4
        Me.cmdTrainGeometricModelFinder.Text = "Train"
        Me.cmdTrainGeometricModelFinder.UseVisualStyleBackColor = True
        '
        'PatternMatchTool
        '
        Me.PatternMatchTool.Controls.Add(Me.lblPatResults)
        Me.PatternMatchTool.Controls.Add(Me.lstPatResults)
        Me.PatternMatchTool.Controls.Add(Me.txtPatMatchThreshold)
        Me.PatternMatchTool.Controls.Add(Me.txtPatMaxNum)
        Me.PatternMatchTool.Controls.Add(Me.Label31)
        Me.PatternMatchTool.Controls.Add(Me.Label32)
        Me.PatternMatchTool.Controls.Add(Me.Label33)
        Me.PatternMatchTool.Controls.Add(Me.cmdPatSetFullImage)
        Me.PatternMatchTool.Controls.Add(Me.lblPatModelName)
        Me.PatternMatchTool.Controls.Add(Me.cmdLoadPatternModel)
        Me.PatternMatchTool.Controls.Add(Me.lstPatFiles)
        Me.PatternMatchTool.Controls.Add(Me.GroupBox11)
        Me.PatternMatchTool.Controls.Add(Me.cmdSearchPatternModelFinder)
        Me.PatternMatchTool.Controls.Add(Me.cmdTrainPatternModelFinder)
        Me.PatternMatchTool.Location = New System.Drawing.Point(4, 58)
        Me.PatternMatchTool.Name = "PatternMatchTool"
        Me.PatternMatchTool.Size = New System.Drawing.Size(428, 388)
        Me.PatternMatchTool.TabIndex = 3
        Me.PatternMatchTool.Text = "Pattern Match Tool"
        Me.PatternMatchTool.UseVisualStyleBackColor = True
        '
        'lblPatResults
        '
        Me.lblPatResults.AutoSize = True
        Me.lblPatResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatResults.ForeColor = System.Drawing.Color.Blue
        Me.lblPatResults.Location = New System.Drawing.Point(40, 246)
        Me.lblPatResults.Name = "lblPatResults"
        Me.lblPatResults.Size = New System.Drawing.Size(59, 16)
        Me.lblPatResults.TabIndex = 32
        Me.lblPatResults.Text = "Results: "
        '
        'lstPatResults
        '
        Me.lstPatResults.FormattingEnabled = True
        Me.lstPatResults.Location = New System.Drawing.Point(37, 269)
        Me.lstPatResults.Name = "lstPatResults"
        Me.lstPatResults.Size = New System.Drawing.Size(188, 95)
        Me.lstPatResults.TabIndex = 31
        '
        'txtPatMatchThreshold
        '
        Me.txtPatMatchThreshold.Location = New System.Drawing.Point(181, 107)
        Me.txtPatMatchThreshold.Name = "txtPatMatchThreshold"
        Me.txtPatMatchThreshold.Size = New System.Drawing.Size(55, 20)
        Me.txtPatMatchThreshold.TabIndex = 30
        Me.txtPatMatchThreshold.Text = "70"
        '
        'txtPatMaxNum
        '
        Me.txtPatMaxNum.Location = New System.Drawing.Point(181, 79)
        Me.txtPatMaxNum.Name = "txtPatMaxNum"
        Me.txtPatMaxNum.Size = New System.Drawing.Size(55, 20)
        Me.txtPatMaxNum.TabIndex = 29
        Me.txtPatMaxNum.Text = "100"
        '
        'Label31
        '
        Me.Label31.AutoSize = True
        Me.Label31.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label31.ForeColor = System.Drawing.Color.Blue
        Me.Label31.Location = New System.Drawing.Point(24, 107)
        Me.Label31.Name = "Label31"
        Me.Label31.Size = New System.Drawing.Size(134, 16)
        Me.Label31.TabIndex = 28
        Me.Label31.Text = "Match Threshold (%):"
        '
        'Label32
        '
        Me.Label32.AutoSize = True
        Me.Label32.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label32.ForeColor = System.Drawing.Color.Blue
        Me.Label32.Location = New System.Drawing.Point(24, 76)
        Me.Label32.Name = "Label32"
        Me.Label32.Size = New System.Drawing.Size(150, 16)
        Me.Label32.TabIndex = 27
        Me.Label32.Text = "Max Number of Objects:"
        '
        'Label33
        '
        Me.Label33.AutoSize = True
        Me.Label33.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label33.ForeColor = System.Drawing.Color.Blue
        Me.Label33.Location = New System.Drawing.Point(24, 33)
        Me.Label33.Name = "Label33"
        Me.Label33.Size = New System.Drawing.Size(147, 16)
        Me.Label33.TabIndex = 26
        Me.Label33.Text = "Set Tool To Full Image:"
        '
        'cmdPatSetFullImage
        '
        Me.cmdPatSetFullImage.Location = New System.Drawing.Point(174, 33)
        Me.cmdPatSetFullImage.Name = "cmdPatSetFullImage"
        Me.cmdPatSetFullImage.Size = New System.Drawing.Size(51, 20)
        Me.cmdPatSetFullImage.TabIndex = 25
        Me.cmdPatSetFullImage.Text = "Set"
        Me.cmdPatSetFullImage.UseVisualStyleBackColor = True
        '
        'lblPatModelName
        '
        Me.lblPatModelName.AutoSize = True
        Me.lblPatModelName.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPatModelName.ForeColor = System.Drawing.Color.Blue
        Me.lblPatModelName.Location = New System.Drawing.Point(280, 24)
        Me.lblPatModelName.Name = "lblPatModelName"
        Me.lblPatModelName.Size = New System.Drawing.Size(98, 16)
        Me.lblPatModelName.TabIndex = 24
        Me.lblPatModelName.Text = "Pattern Models"
        '
        'cmdLoadPatternModel
        '
        Me.cmdLoadPatternModel.Location = New System.Drawing.Point(311, 242)
        Me.cmdLoadPatternModel.Name = "cmdLoadPatternModel"
        Me.cmdLoadPatternModel.Size = New System.Drawing.Size(67, 20)
        Me.cmdLoadPatternModel.TabIndex = 23
        Me.cmdLoadPatternModel.Text = "Load"
        Me.cmdLoadPatternModel.UseVisualStyleBackColor = True
        '
        'lstPatFiles
        '
        Me.lstPatFiles.FormattingEnabled = True
        Me.lstPatFiles.Location = New System.Drawing.Point(283, 63)
        Me.lstPatFiles.Name = "lstPatFiles"
        Me.lstPatFiles.Size = New System.Drawing.Size(122, 173)
        Me.lstPatFiles.TabIndex = 22
        '
        'GroupBox11
        '
        Me.GroupBox11.Controls.Add(Me.chkOriginPattern)
        Me.GroupBox11.Controls.Add(Me.Button5)
        Me.GroupBox11.Location = New System.Drawing.Point(37, 150)
        Me.GroupBox11.Name = "GroupBox11"
        Me.GroupBox11.Size = New System.Drawing.Size(121, 74)
        Me.GroupBox11.TabIndex = 21
        Me.GroupBox11.TabStop = False
        Me.GroupBox11.Text = "Origin"
        Me.GroupBox11.Visible = False
        '
        'chkOriginPattern
        '
        Me.chkOriginPattern.AutoSize = True
        Me.chkOriginPattern.Location = New System.Drawing.Point(34, 19)
        Me.chkOriginPattern.Name = "chkOriginPattern"
        Me.chkOriginPattern.Size = New System.Drawing.Size(53, 17)
        Me.chkOriginPattern.TabIndex = 8
        Me.chkOriginPattern.Text = "Move"
        Me.chkOriginPattern.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Location = New System.Drawing.Point(11, 42)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(99, 22)
        Me.Button5.TabIndex = 7
        Me.Button5.Text = "Center On Tool"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'cmdSearchPatternModelFinder
        '
        Me.cmdSearchPatternModelFinder.Location = New System.Drawing.Point(318, 344)
        Me.cmdSearchPatternModelFinder.Name = "cmdSearchPatternModelFinder"
        Me.cmdSearchPatternModelFinder.Size = New System.Drawing.Size(67, 20)
        Me.cmdSearchPatternModelFinder.TabIndex = 20
        Me.cmdSearchPatternModelFinder.Text = "Search"
        Me.cmdSearchPatternModelFinder.UseVisualStyleBackColor = True
        '
        'cmdTrainPatternModelFinder
        '
        Me.cmdTrainPatternModelFinder.Location = New System.Drawing.Point(318, 315)
        Me.cmdTrainPatternModelFinder.Name = "cmdTrainPatternModelFinder"
        Me.cmdTrainPatternModelFinder.Size = New System.Drawing.Size(67, 20)
        Me.cmdTrainPatternModelFinder.TabIndex = 19
        Me.cmdTrainPatternModelFinder.Text = "Train"
        Me.cmdTrainPatternModelFinder.UseVisualStyleBackColor = True
        '
        'MicrometerTool
        '
        Me.MicrometerTool.Controls.Add(Me.lblMicrometerResults)
        Me.MicrometerTool.Location = New System.Drawing.Point(4, 58)
        Me.MicrometerTool.Name = "MicrometerTool"
        Me.MicrometerTool.Size = New System.Drawing.Size(428, 388)
        Me.MicrometerTool.TabIndex = 9
        Me.MicrometerTool.Text = "Micrometer Tool"
        Me.MicrometerTool.UseVisualStyleBackColor = True
        '
        'lblMicrometerResults
        '
        Me.lblMicrometerResults.AutoSize = True
        Me.lblMicrometerResults.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMicrometerResults.ForeColor = System.Drawing.Color.Blue
        Me.lblMicrometerResults.Location = New System.Drawing.Point(31, 33)
        Me.lblMicrometerResults.Name = "lblMicrometerResults"
        Me.lblMicrometerResults.Size = New System.Drawing.Size(53, 16)
        Me.lblMicrometerResults.TabIndex = 43
        Me.lblMicrometerResults.Text = "Results"
        Me.lblMicrometerResults.Visible = False
        '
        'Video
        '
        Me.Video.Controls.Add(Me.groupBox7)
        Me.Video.Controls.Add(Me.displayGroupBox)
        Me.Video.Controls.Add(Me.GroupBox8)
        Me.Video.Controls.Add(Me.cmdXhair)
        Me.Video.Controls.Add(Me.GroupBox3)
        Me.Video.Controls.Add(Me.GroupBox4)
        Me.Video.Location = New System.Drawing.Point(4, 58)
        Me.Video.Name = "Video"
        Me.Video.Size = New System.Drawing.Size(428, 388)
        Me.Video.TabIndex = 6
        Me.Video.Text = "Video"
        Me.Video.UseVisualStyleBackColor = True
        '
        'groupBox7
        '
        Me.groupBox7.Controls.Add(Me.cmdBinarize)
        Me.groupBox7.Controls.Add(Me.cboBinarizePolarity)
        Me.groupBox7.Controls.Add(Me.Label16)
        Me.groupBox7.Controls.Add(Me.numBinarizeThreshold)
        Me.groupBox7.Controls.Add(Me.lblBinarizeThreshold)
        Me.groupBox7.Controls.Add(Me.chkAutoThreshold)
        Me.groupBox7.Location = New System.Drawing.Point(23, 110)
        Me.groupBox7.Name = "groupBox7"
        Me.groupBox7.Size = New System.Drawing.Size(260, 98)
        Me.groupBox7.TabIndex = 49
        Me.groupBox7.TabStop = False
        Me.groupBox7.Text = "Image Binarization"
        '
        'cmdBinarize
        '
        Me.cmdBinarize.Location = New System.Drawing.Point(15, 59)
        Me.cmdBinarize.Name = "cmdBinarize"
        Me.cmdBinarize.Size = New System.Drawing.Size(66, 22)
        Me.cmdBinarize.TabIndex = 53
        Me.cmdBinarize.Text = "Binarize"
        Me.cmdBinarize.UseVisualStyleBackColor = True
        '
        'cboBinarizePolarity
        '
        Me.cboBinarizePolarity.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cboBinarizePolarity.FormattingEnabled = True
        Me.cboBinarizePolarity.Items.AddRange(New Object() {"White", "Black"})
        Me.cboBinarizePolarity.Location = New System.Drawing.Point(178, 56)
        Me.cboBinarizePolarity.Name = "cboBinarizePolarity"
        Me.cboBinarizePolarity.Size = New System.Drawing.Size(69, 21)
        Me.cboBinarizePolarity.TabIndex = 52
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(131, 59)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(41, 13)
        Me.Label16.TabIndex = 51
        Me.Label16.Text = "Polarity"
        Me.Label16.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'numBinarizeThreshold
        '
        Me.numBinarizeThreshold.Location = New System.Drawing.Point(194, 23)
        Me.numBinarizeThreshold.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numBinarizeThreshold.Name = "numBinarizeThreshold"
        Me.numBinarizeThreshold.Size = New System.Drawing.Size(51, 20)
        Me.numBinarizeThreshold.TabIndex = 50
        Me.numBinarizeThreshold.Value = New Decimal(New Integer() {126, 0, 0, 0})
        '
        'lblBinarizeThreshold
        '
        Me.lblBinarizeThreshold.AutoSize = True
        Me.lblBinarizeThreshold.Location = New System.Drawing.Point(138, 25)
        Me.lblBinarizeThreshold.Name = "lblBinarizeThreshold"
        Me.lblBinarizeThreshold.Size = New System.Drawing.Size(54, 13)
        Me.lblBinarizeThreshold.TabIndex = 49
        Me.lblBinarizeThreshold.Text = "Threshold"
        Me.lblBinarizeThreshold.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'chkAutoThreshold
        '
        Me.chkAutoThreshold.AutoSize = True
        Me.chkAutoThreshold.Location = New System.Drawing.Point(15, 25)
        Me.chkAutoThreshold.Name = "chkAutoThreshold"
        Me.chkAutoThreshold.Size = New System.Drawing.Size(98, 17)
        Me.chkAutoThreshold.TabIndex = 13
        Me.chkAutoThreshold.Text = "Auto Threshold"
        Me.chkAutoThreshold.UseVisualStyleBackColor = True
        '
        'displayGroupBox
        '
        Me.displayGroupBox.Controls.Add(Me.cmdLUTColor)
        Me.displayGroupBox.Controls.Add(Me.cmdLUTNegative)
        Me.displayGroupBox.Controls.Add(Me.cmdLUTPositive)
        Me.displayGroupBox.Location = New System.Drawing.Point(143, 252)
        Me.displayGroupBox.Name = "displayGroupBox"
        Me.displayGroupBox.Size = New System.Drawing.Size(140, 121)
        Me.displayGroupBox.TabIndex = 37
        Me.displayGroupBox.TabStop = False
        Me.displayGroupBox.Text = "Display Output LUT"
        '
        'cmdLUTColor
        '
        Me.cmdLUTColor.Location = New System.Drawing.Point(31, 84)
        Me.cmdLUTColor.Name = "cmdLUTColor"
        Me.cmdLUTColor.Size = New System.Drawing.Size(60, 22)
        Me.cmdLUTColor.TabIndex = 2
        Me.cmdLUTColor.Text = "Color"
        Me.cmdLUTColor.UseVisualStyleBackColor = True
        '
        'cmdLUTNegative
        '
        Me.cmdLUTNegative.Location = New System.Drawing.Point(31, 52)
        Me.cmdLUTNegative.Name = "cmdLUTNegative"
        Me.cmdLUTNegative.Size = New System.Drawing.Size(60, 22)
        Me.cmdLUTNegative.TabIndex = 1
        Me.cmdLUTNegative.Text = "Negative"
        Me.cmdLUTNegative.UseVisualStyleBackColor = True
        '
        'cmdLUTPositive
        '
        Me.cmdLUTPositive.Location = New System.Drawing.Point(31, 21)
        Me.cmdLUTPositive.Name = "cmdLUTPositive"
        Me.cmdLUTPositive.Size = New System.Drawing.Size(60, 22)
        Me.cmdLUTPositive.TabIndex = 0
        Me.cmdLUTPositive.Text = "Positive"
        Me.cmdLUTPositive.UseVisualStyleBackColor = True
        '
        'GroupBox8
        '
        Me.GroupBox8.Controls.Add(Me.numNegative)
        Me.GroupBox8.Controls.Add(Me.cmdNegative)
        Me.GroupBox8.Controls.Add(Me.numPositive)
        Me.GroupBox8.Controls.Add(Me.cmdPositive)
        Me.GroupBox8.Location = New System.Drawing.Point(143, 17)
        Me.GroupBox8.Name = "GroupBox8"
        Me.GroupBox8.Size = New System.Drawing.Size(140, 87)
        Me.GroupBox8.TabIndex = 12
        Me.GroupBox8.TabStop = False
        Me.GroupBox8.Text = "Binary Thresholds"
        '
        'numNegative
        '
        Me.numNegative.Location = New System.Drawing.Point(85, 56)
        Me.numNegative.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numNegative.Name = "numNegative"
        Me.numNegative.Size = New System.Drawing.Size(42, 20)
        Me.numNegative.TabIndex = 50
        Me.numNegative.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numNegative.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'cmdNegative
        '
        Me.cmdNegative.Location = New System.Drawing.Point(15, 56)
        Me.cmdNegative.Name = "cmdNegative"
        Me.cmdNegative.Size = New System.Drawing.Size(60, 22)
        Me.cmdNegative.TabIndex = 49
        Me.cmdNegative.Text = "Negative"
        Me.cmdNegative.UseVisualStyleBackColor = True
        '
        'numPositive
        '
        Me.numPositive.Location = New System.Drawing.Point(85, 19)
        Me.numPositive.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.numPositive.Name = "numPositive"
        Me.numPositive.Size = New System.Drawing.Size(42, 20)
        Me.numPositive.TabIndex = 48
        Me.numPositive.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        Me.numPositive.Value = New Decimal(New Integer() {255, 0, 0, 0})
        '
        'cmdPositive
        '
        Me.cmdPositive.Location = New System.Drawing.Point(15, 19)
        Me.cmdPositive.Name = "cmdPositive"
        Me.cmdPositive.Size = New System.Drawing.Size(60, 22)
        Me.cmdPositive.TabIndex = 3
        Me.cmdPositive.Text = "Positive"
        Me.cmdPositive.UseVisualStyleBackColor = True
        '
        'cmdXhair
        '
        Me.cmdXhair.Location = New System.Drawing.Point(38, 223)
        Me.cmdXhair.Name = "cmdXhair"
        Me.cmdXhair.Size = New System.Drawing.Size(60, 20)
        Me.cmdXhair.TabIndex = 11
        Me.cmdXhair.Text = "X Hair"
        Me.cmdXhair.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.GroupBox9)
        Me.GroupBox3.Controls.Add(Me.cmdGrab)
        Me.GroupBox3.Controls.Add(Me.cmdStop)
        Me.GroupBox3.Controls.Add(Me.cmdLive)
        Me.GroupBox3.Location = New System.Drawing.Point(23, 249)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(93, 124)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Video Control"
        '
        'GroupBox9
        '
        Me.GroupBox9.Controls.Add(Me.Button3)
        Me.GroupBox9.Controls.Add(Me.ComboBox1)
        Me.GroupBox9.Controls.Add(Me.Label17)
        Me.GroupBox9.Controls.Add(Me.NumericUpDown1)
        Me.GroupBox9.Controls.Add(Me.Label18)
        Me.GroupBox9.Controls.Add(Me.CheckBox1)
        Me.GroupBox9.Location = New System.Drawing.Point(88, 0)
        Me.GroupBox9.Name = "GroupBox9"
        Me.GroupBox9.Size = New System.Drawing.Size(171, 136)
        Me.GroupBox9.TabIndex = 49
        Me.GroupBox9.TabStop = False
        Me.GroupBox9.Text = "Image Binarization"
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(57, 99)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(66, 22)
        Me.Button3.TabIndex = 53
        Me.Button3.Text = "Binarize"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(82, 71)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(69, 21)
        Me.ComboBox1.TabIndex = 52
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Location = New System.Drawing.Point(15, 71)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(41, 13)
        Me.Label17.TabIndex = 51
        Me.Label17.Text = "Polarity"
        Me.Label17.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(57, 44)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {255, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(51, 20)
        Me.NumericUpDown1.TabIndex = 50
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Location = New System.Drawing.Point(1, 46)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(54, 13)
        Me.Label18.TabIndex = 49
        Me.Label18.Text = "Threshold"
        Me.Label18.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(10, 21)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(98, 17)
        Me.CheckBox1.TabIndex = 13
        Me.CheckBox1.Text = "Auto Threshold"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'cmdGrab
        '
        Me.cmdGrab.Location = New System.Drawing.Point(15, 87)
        Me.cmdGrab.Name = "cmdGrab"
        Me.cmdGrab.Size = New System.Drawing.Size(60, 22)
        Me.cmdGrab.TabIndex = 2
        Me.cmdGrab.Text = "Grab Image"
        Me.cmdGrab.UseVisualStyleBackColor = True
        '
        'cmdStop
        '
        Me.cmdStop.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.cmdStop.Location = New System.Drawing.Point(15, 55)
        Me.cmdStop.Name = "cmdStop"
        Me.cmdStop.Size = New System.Drawing.Size(60, 22)
        Me.cmdStop.TabIndex = 1
        Me.cmdStop.Text = "Stop Live"
        Me.cmdStop.UseVisualStyleBackColor = True
        '
        'cmdLive
        '
        Me.cmdLive.Location = New System.Drawing.Point(15, 24)
        Me.cmdLive.Name = "cmdLive"
        Me.cmdLive.Size = New System.Drawing.Size(60, 22)
        Me.cmdLive.TabIndex = 0
        Me.cmdLive.Text = "Live"
        Me.cmdLive.UseVisualStyleBackColor = True
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.cmdImageSave)
        Me.GroupBox4.Controls.Add(Me.cmdImageLoad)
        Me.GroupBox4.Location = New System.Drawing.Point(23, 15)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(94, 89)
        Me.GroupBox4.TabIndex = 7
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Image"
        '
        'cmdImageSave
        '
        Me.cmdImageSave.Location = New System.Drawing.Point(15, 53)
        Me.cmdImageSave.Name = "cmdImageSave"
        Me.cmdImageSave.Size = New System.Drawing.Size(60, 22)
        Me.cmdImageSave.TabIndex = 2
        Me.cmdImageSave.Text = "Save"
        Me.cmdImageSave.UseVisualStyleBackColor = True
        '
        'cmdImageLoad
        '
        Me.cmdImageLoad.Location = New System.Drawing.Point(15, 21)
        Me.cmdImageLoad.Name = "cmdImageLoad"
        Me.cmdImageLoad.Size = New System.Drawing.Size(60, 22)
        Me.cmdImageLoad.TabIndex = 1
        Me.cmdImageLoad.Text = "Load"
        Me.cmdImageLoad.UseVisualStyleBackColor = True
        '
        'Units
        '
        Me.Units.Controls.Add(Me.lblUnitsPixelSize)
        Me.Units.Controls.Add(Me.GroupBox1)
        Me.Units.Location = New System.Drawing.Point(4, 58)
        Me.Units.Name = "Units"
        Me.Units.Size = New System.Drawing.Size(428, 388)
        Me.Units.TabIndex = 7
        Me.Units.Text = "Units"
        Me.Units.UseVisualStyleBackColor = True
        '
        'lblUnitsPixelSize
        '
        Me.lblUnitsPixelSize.AutoSize = True
        Me.lblUnitsPixelSize.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnitsPixelSize.ForeColor = System.Drawing.Color.Blue
        Me.lblUnitsPixelSize.Location = New System.Drawing.Point(31, 207)
        Me.lblUnitsPixelSize.Name = "lblUnitsPixelSize"
        Me.lblUnitsPixelSize.Size = New System.Drawing.Size(72, 16)
        Me.lblUnitsPixelSize.TabIndex = 39
        Me.lblUnitsPixelSize.Text = "Pixel Size: "
        Me.lblUnitsPixelSize.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.optPixel)
        Me.GroupBox1.Controls.Add(Me.optMM)
        Me.GroupBox1.Controls.Add(Me.optMicron)
        Me.GroupBox1.Controls.Add(Me.optMicroInch)
        Me.GroupBox1.Controls.Add(Me.optInch)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 31)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(170, 149)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Units"
        '
        'optPixel
        '
        Me.optPixel.AutoSize = True
        Me.optPixel.Location = New System.Drawing.Point(23, 119)
        Me.optPixel.Name = "optPixel"
        Me.optPixel.Size = New System.Drawing.Size(47, 17)
        Me.optPixel.TabIndex = 4
        Me.optPixel.Text = "Pixel"
        Me.optPixel.UseVisualStyleBackColor = True
        '
        'optMM
        '
        Me.optMM.AutoSize = True
        Me.optMM.Location = New System.Drawing.Point(23, 47)
        Me.optMM.Name = "optMM"
        Me.optMM.Size = New System.Drawing.Size(68, 17)
        Me.optMM.TabIndex = 3
        Me.optMM.Text = "Millimeter"
        Me.optMM.UseVisualStyleBackColor = True
        '
        'optMicron
        '
        Me.optMicron.AutoSize = True
        Me.optMicron.Location = New System.Drawing.Point(23, 95)
        Me.optMicron.Name = "optMicron"
        Me.optMicron.Size = New System.Drawing.Size(57, 17)
        Me.optMicron.TabIndex = 2
        Me.optMicron.Text = "Micron"
        Me.optMicron.UseVisualStyleBackColor = True
        '
        'optMicroInch
        '
        Me.optMicroInch.AutoSize = True
        Me.optMicroInch.Location = New System.Drawing.Point(23, 71)
        Me.optMicroInch.Name = "optMicroInch"
        Me.optMicroInch.Size = New System.Drawing.Size(72, 17)
        Me.optMicroInch.TabIndex = 1
        Me.optMicroInch.Text = "MicroInch"
        Me.optMicroInch.UseVisualStyleBackColor = True
        '
        'optInch
        '
        Me.optInch.AutoSize = True
        Me.optInch.Checked = True
        Me.optInch.Location = New System.Drawing.Point(23, 23)
        Me.optInch.Name = "optInch"
        Me.optInch.Size = New System.Drawing.Size(46, 17)
        Me.optInch.TabIndex = 0
        Me.optInch.TabStop = True
        Me.optInch.Text = "Inch"
        Me.optInch.UseVisualStyleBackColor = True
        '
        'ThicknessTool
        '
        Me.ThicknessTool.Controls.Add(Me.lblLightLevel)
        Me.ThicknessTool.Controls.Add(Me.scrLightLevel)
        Me.ThicknessTool.Location = New System.Drawing.Point(4, 58)
        Me.ThicknessTool.Name = "ThicknessTool"
        Me.ThicknessTool.Size = New System.Drawing.Size(428, 388)
        Me.ThicknessTool.TabIndex = 11
        Me.ThicknessTool.Text = "Thickness Tool"
        Me.ThicknessTool.UseVisualStyleBackColor = True
        '
        'scrLightLevel
        '
        Me.scrLightLevel.LargeChange = 40
        Me.scrLightLevel.Location = New System.Drawing.Point(51, 329)
        Me.scrLightLevel.Maximum = 1023
        Me.scrLightLevel.Name = "scrLightLevel"
        Me.scrLightLevel.Size = New System.Drawing.Size(175, 16)
        Me.scrLightLevel.SmallChange = 10
        Me.scrLightLevel.TabIndex = 0
        '
        'lstImages
        '
        Me.lstImages.FormattingEnabled = True
        Me.lstImages.Location = New System.Drawing.Point(808, 535)
        Me.lstImages.Name = "lstImages"
        Me.lstImages.Size = New System.Drawing.Size(173, 212)
        Me.lstImages.TabIndex = 8
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblDisplayFactor)
        Me.GroupBox2.Controls.Add(Me.lblImageSize)
        Me.GroupBox2.Controls.Add(Me.Label22)
        Me.GroupBox2.Controls.Add(Me.lblUnits)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.Color.Blue
        Me.GroupBox2.Location = New System.Drawing.Point(171, 12)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(316, 176)
        Me.GroupBox2.TabIndex = 9
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Status"
        '
        'lblDisplayFactor
        '
        Me.lblDisplayFactor.AutoSize = True
        Me.lblDisplayFactor.Location = New System.Drawing.Point(15, 100)
        Me.lblDisplayFactor.Name = "lblDisplayFactor"
        Me.lblDisplayFactor.Size = New System.Drawing.Size(98, 16)
        Me.lblDisplayFactor.TabIndex = 3
        Me.lblDisplayFactor.Text = "Display Factor:"
        '
        'lblImageSize
        '
        Me.lblImageSize.AutoSize = True
        Me.lblImageSize.Location = New System.Drawing.Point(15, 72)
        Me.lblImageSize.Name = "lblImageSize"
        Me.lblImageSize.Size = New System.Drawing.Size(78, 16)
        Me.lblImageSize.TabIndex = 2
        Me.lblImageSize.Text = "Image Size:"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Location = New System.Drawing.Point(50, 45)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(61, 16)
        Me.Label22.TabIndex = 1
        Me.Label22.Text = "Degrees"
        '
        'lblUnits
        '
        Me.lblUnits.AutoSize = True
        Me.lblUnits.Location = New System.Drawing.Point(15, 29)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(41, 16)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Units:"
        '
        'mnuMain
        '
        Me.mnuMain.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuFile, Me.mnuSystem})
        Me.mnuMain.Location = New System.Drawing.Point(0, 0)
        Me.mnuMain.Name = "mnuMain"
        Me.mnuMain.Size = New System.Drawing.Size(1153, 24)
        Me.mnuMain.TabIndex = 10
        Me.mnuMain.Text = "MenuStrip1"
        '
        'mnuFile
        '
        Me.mnuFile.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuTest, Me.ToolStripMenuItem3, Me.mnuExit})
        Me.mnuFile.Name = "mnuFile"
        Me.mnuFile.Size = New System.Drawing.Size(37, 20)
        Me.mnuFile.Text = "File"
        '
        'mnuTest
        '
        Me.mnuTest.Name = "mnuTest"
        Me.mnuTest.Size = New System.Drawing.Size(94, 22)
        Me.mnuTest.Text = "Test"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(91, 6)
        '
        'mnuExit
        '
        Me.mnuExit.Name = "mnuExit"
        Me.mnuExit.Size = New System.Drawing.Size(94, 22)
        Me.mnuExit.Text = "Exit"
        '
        'mnuSystem
        '
        Me.mnuSystem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mnuMotionControl})
        Me.mnuSystem.Name = "mnuSystem"
        Me.mnuSystem.Size = New System.Drawing.Size(57, 20)
        Me.mnuSystem.Text = "System"
        '
        'mnuMotionControl
        '
        Me.mnuMotionControl.Name = "mnuMotionControl"
        Me.mnuMotionControl.Size = New System.Drawing.Size(156, 22)
        Me.mnuMotionControl.Text = "Motion Control"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(31, 56)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(103, 44)
        Me.Button1.TabIndex = 11
        Me.Button1.Text = "Test"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'cmdExit
        '
        Me.cmdExit.Location = New System.Drawing.Point(1008, 722)
        Me.cmdExit.Name = "cmdExit"
        Me.cmdExit.Size = New System.Drawing.Size(87, 25)
        Me.cmdExit.TabIndex = 12
        Me.cmdExit.Text = "Exit"
        Me.cmdExit.UseVisualStyleBackColor = True
        '
        'lblLightLevel
        '
        Me.lblLightLevel.AutoSize = True
        Me.lblLightLevel.Location = New System.Drawing.Point(50, 307)
        Me.lblLightLevel.Name = "lblLightLevel"
        Me.lblLightLevel.Size = New System.Drawing.Size(65, 13)
        Me.lblLightLevel.TabIndex = 1
        Me.lblLightLevel.Text = "Light Level: "
        '
        'comLightController
        '
        Me.comLightController.BaudRate = 57600
        Me.comLightController.PortName = "COM4"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1153, 780)
        Me.ControlBox = False
        Me.Controls.Add(Me.cmdExit)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.lstImages)
        Me.Controls.Add(Me.tabTools)
        Me.Controls.Add(Me.pnlImage)
        Me.Controls.Add(Me.mnuMain)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MainMenuStrip = Me.mnuMain
        Me.Name = "frmMain"
        Me.Text = "Randy's Vision Demo"
        Me.tabTools.ResumeLayout(False)
        Me.SimpleLineTool.ResumeLayout(False)
        Me.SimpleLineTool.PerformLayout()
        Me.AdvancedLineTool.ResumeLayout(False)
        Me.AdvancedLineTool.PerformLayout()
        Me.SimpleCircleTool.ResumeLayout(False)
        Me.SimpleCircleTool.PerformLayout()
        Me.AdvancedCircleTool.ResumeLayout(False)
        Me.AdvancedCircleTool.PerformLayout()
        CType(Me.updnAdvancedCircleAngle, System.ComponentModel.ISupportInitialize).EndInit()
        Me.BlobTool.ResumeLayout(False)
        Me.BlobTool.PerformLayout()
        Me.GroupBox12.ResumeLayout(False)
        Me.GroupBox12.PerformLayout()
        Me.GroupBox10.ResumeLayout(False)
        Me.GroupBox10.PerformLayout()
        Me.GeometricModelFinder.ResumeLayout(False)
        Me.GeometricModelFinder.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.PatternMatchTool.ResumeLayout(False)
        Me.PatternMatchTool.PerformLayout()
        Me.GroupBox11.ResumeLayout(False)
        Me.GroupBox11.PerformLayout()
        Me.MicrometerTool.ResumeLayout(False)
        Me.MicrometerTool.PerformLayout()
        Me.Video.ResumeLayout(False)
        Me.groupBox7.ResumeLayout(False)
        Me.groupBox7.PerformLayout()
        CType(Me.numBinarizeThreshold, System.ComponentModel.ISupportInitialize).EndInit()
        Me.displayGroupBox.ResumeLayout(False)
        Me.GroupBox8.ResumeLayout(False)
        CType(Me.numNegative, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numPositive, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox9.ResumeLayout(False)
        Me.GroupBox9.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.Units.ResumeLayout(False)
        Me.Units.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ThicknessTool.ResumeLayout(False)
        Me.ThicknessTool.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.mnuMain.ResumeLayout(False)
        Me.mnuMain.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents pnlImage As System.Windows.Forms.Panel
    Friend WithEvents OpenFileDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents tabTools As System.Windows.Forms.TabControl
    Friend WithEvents SimpleLineTool As System.Windows.Forms.TabPage
    Friend WithEvents AdvancedLineTool As System.Windows.Forms.TabPage
    Friend WithEvents SimpleCircleTool As System.Windows.Forms.TabPage
    Friend WithEvents cmdSimpleLineRun As System.Windows.Forms.Button
    Friend WithEvents cboSimpleLinePolarity As System.Windows.Forms.ComboBox
    Friend WithEvents cboSimpleLineOrientation As System.Windows.Forms.ComboBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txtAdvancedLineMaxFitDist As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txtAdvancedLineSmoothness As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtAdvancedLineScale As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txtAdvancedLineAngleRange As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents cboAdvancedLineThresholdMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cboAdvancedLineSelection As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cboAdvancedLinePolarity As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents cboAdvancedLineDirection As System.Windows.Forms.ComboBox
    Private WithEvents chkMetrologyLineFitCheckBox As System.Windows.Forms.CheckBox
    Private WithEvents cmdRunAdvancedLine As System.Windows.Forms.Button
    Friend WithEvents BlobTool As System.Windows.Forms.TabPage
    Friend WithEvents PatternMatchTool As System.Windows.Forms.TabPage
    Friend WithEvents GeometricModelFinder As System.Windows.Forms.TabPage
    Friend WithEvents lstImages As System.Windows.Forms.ListBox
    Friend WithEvents Video As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdGrab As System.Windows.Forms.Button
    Friend WithEvents cmdStop As System.Windows.Forms.Button
    Friend WithEvents cmdLive As System.Windows.Forms.Button
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents cmdImageSave As System.Windows.Forms.Button
    Friend WithEvents cmdImageLoad As System.Windows.Forms.Button
    Private WithEvents cmdSearchGeometricModelFinder As System.Windows.Forms.Button
    Private WithEvents cmdTrainGeometricModelFinder As System.Windows.Forms.Button
    Friend WithEvents lblResultsAdvancedLine As System.Windows.Forms.Label
    Friend WithEvents Units As System.Windows.Forms.TabPage
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents optMM As System.Windows.Forms.RadioButton
    Friend WithEvents optMicron As System.Windows.Forms.RadioButton
    Friend WithEvents optMicroInch As System.Windows.Forms.RadioButton
    Friend WithEvents optInch As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents optPixel As System.Windows.Forms.RadioButton
    Friend WithEvents mnuMain As System.Windows.Forms.MenuStrip
    Friend WithEvents mnuSystem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuMotionControl As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuFile As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents mnuExit As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents mnuTest As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents cmdExit As System.Windows.Forms.Button
    Private WithEvents cmdBlobRun As System.Windows.Forms.Button
    Friend WithEvents chkCG As System.Windows.Forms.CheckBox
    Friend WithEvents chkHull As System.Windows.Forms.CheckBox
    Friend WithEvents chkBox As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOriginGeometric As System.Windows.Forms.CheckBox
    Friend WithEvents cmdCenterGeo As System.Windows.Forms.Button
    Friend WithEvents lblBlobs As System.Windows.Forms.Label
    Friend WithEvents cmdXhair As System.Windows.Forms.Button
    Private WithEvents GroupBox8 As System.Windows.Forms.GroupBox
    Private WithEvents numNegative As System.Windows.Forms.NumericUpDown
    Private WithEvents cmdNegative As System.Windows.Forms.Button
    Private WithEvents numPositive As System.Windows.Forms.NumericUpDown
    Private WithEvents cmdPositive As System.Windows.Forms.Button
    Private WithEvents displayGroupBox As System.Windows.Forms.GroupBox
    Private WithEvents cmdLUTColor As System.Windows.Forms.Button
    Private WithEvents cmdLUTNegative As System.Windows.Forms.Button
    Private WithEvents cmdLUTPositive As System.Windows.Forms.Button
    Private WithEvents groupBox7 As System.Windows.Forms.GroupBox
    Private WithEvents cmdBinarize As System.Windows.Forms.Button
    Private WithEvents cboBinarizePolarity As System.Windows.Forms.ComboBox
    Private WithEvents Label16 As System.Windows.Forms.Label
    Private WithEvents numBinarizeThreshold As System.Windows.Forms.NumericUpDown
    Private WithEvents lblBinarizeThreshold As System.Windows.Forms.Label
    Private WithEvents chkAutoThreshold As System.Windows.Forms.CheckBox
    Private WithEvents GroupBox9 As System.Windows.Forms.GroupBox
    Private WithEvents Button3 As System.Windows.Forms.Button
    Private WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Private WithEvents Label17 As System.Windows.Forms.Label
    Private WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Private WithEvents Label18 As System.Windows.Forms.Label
    Private WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents cboBlobs As System.Windows.Forms.ComboBox
    Private WithEvents cmdDisplayAll As System.Windows.Forms.Button
    Friend WithEvents lblBlobResults As System.Windows.Forms.Label
    Friend WithEvents GroupBox10 As System.Windows.Forms.GroupBox
    Friend WithEvents txtAreaMax As System.Windows.Forms.TextBox
    Friend WithEvents txtAreaMin As System.Windows.Forms.TextBox
    Friend WithEvents chkAreaIgnore As System.Windows.Forms.CheckBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents chkClickOnBlobs As System.Windows.Forms.CheckBox
    Friend WithEvents GroupBox12 As System.Windows.Forms.GroupBox
    Friend WithEvents optCenter As System.Windows.Forms.RadioButton
    Friend WithEvents optBottom As System.Windows.Forms.RadioButton
    Friend WithEvents optTop As System.Windows.Forms.RadioButton
    Friend WithEvents optRight As System.Windows.Forms.RadioButton
    Friend WithEvents optLeft As System.Windows.Forms.RadioButton
    Friend WithEvents optLR As System.Windows.Forms.RadioButton
    Friend WithEvents optLL As System.Windows.Forms.RadioButton
    Friend WithEvents optUR As System.Windows.Forms.RadioButton
    Friend WithEvents optUL As System.Windows.Forms.RadioButton
    Friend WithEvents MicrometerTool As System.Windows.Forms.TabPage
    Friend WithEvents lblMicrometerResults As System.Windows.Forms.Label
    Friend WithEvents lblUnitsPixelSize As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lblSimpleLineResults As System.Windows.Forms.Label
    Private WithEvents cmdAdvancedLineWidth As System.Windows.Forms.Button
    Private WithEvents cmdSimpleLineWidth As System.Windows.Forms.Button
    Friend WithEvents optBiggest As System.Windows.Forms.RadioButton
    Friend WithEvents optSmallest As System.Windows.Forms.RadioButton
    Friend WithEvents lblDisplayFactor As System.Windows.Forms.Label
    Friend WithEvents lblImageSize As System.Windows.Forms.Label
    Friend WithEvents lblUnits As System.Windows.Forms.Label
    Private WithEvents cmdPoss As System.Windows.Forms.Button
    Friend WithEvents txtPosY As System.Windows.Forms.TextBox
    Friend WithEvents txtPosX As System.Windows.Forms.TextBox
    Private WithEvents cmdSize As System.Windows.Forms.Button
    Friend WithEvents txtY As System.Windows.Forms.TextBox
    Friend WithEvents txtX As System.Windows.Forms.TextBox
    Private WithEvents cmdSimpleCircleRun As System.Windows.Forms.Button
    Friend WithEvents lblSimpleCircleResults As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txtSimpleCircleMaxFitDistance As System.Windows.Forms.TextBox
    Friend WithEvents cboSimpleCirclePolarity As System.Windows.Forms.ComboBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents AdvancedCircleTool As System.Windows.Forms.TabPage
    Private WithEvents cmdAdvancedCirleRun As System.Windows.Forms.Button
    Private WithEvents chkAdvancedCircleFit As System.Windows.Forms.CheckBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txtAdvancedCircleEdgeExtractionScale As System.Windows.Forms.TextBox
    Private WithEvents updnAdvancedCircleAngle As System.Windows.Forms.NumericUpDown
    Private WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtAdvancedCircleMaxLineFitDistance As System.Windows.Forms.TextBox
    Friend WithEvents cboAdvancedCirclePolarity As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txtAdvancedCircleSmoothness As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtAdvancedCircleEdgeAngleRange As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents cboAdvancedCircleThresholdMode As System.Windows.Forms.ComboBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents cboAdvancedCircleEdgeSelection As System.Windows.Forms.ComboBox
    Friend WithEvents lstGeoFiles As System.Windows.Forms.ListBox
    Friend WithEvents lblGeoModelName As System.Windows.Forms.Label
    Private WithEvents cmdLoadGeometricModel As System.Windows.Forms.Button
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Private WithEvents cmdGeoSetFullImage As System.Windows.Forms.Button
    Friend WithEvents lstGeoResults As System.Windows.Forms.ListBox
    Friend WithEvents txtGeoMatchThreshold As System.Windows.Forms.TextBox
    Friend WithEvents txtGeoMaxNum As System.Windows.Forms.TextBox
    Friend WithEvents Label29 As System.Windows.Forms.Label
    Friend WithEvents Label28 As System.Windows.Forms.Label
    Friend WithEvents lblGeoResults As System.Windows.Forms.Label
    Friend WithEvents lblPatResults As System.Windows.Forms.Label
    Friend WithEvents lstPatResults As System.Windows.Forms.ListBox
    Friend WithEvents txtPatMatchThreshold As System.Windows.Forms.TextBox
    Friend WithEvents txtPatMaxNum As System.Windows.Forms.TextBox
    Friend WithEvents Label31 As System.Windows.Forms.Label
    Friend WithEvents Label32 As System.Windows.Forms.Label
    Friend WithEvents Label33 As System.Windows.Forms.Label
    Private WithEvents cmdPatSetFullImage As System.Windows.Forms.Button
    Friend WithEvents lblPatModelName As System.Windows.Forms.Label
    Private WithEvents cmdLoadPatternModel As System.Windows.Forms.Button
    Friend WithEvents lstPatFiles As System.Windows.Forms.ListBox
    Friend WithEvents GroupBox11 As System.Windows.Forms.GroupBox
    Friend WithEvents chkOriginPattern As System.Windows.Forms.CheckBox
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Private WithEvents cmdSearchPatternModelFinder As System.Windows.Forms.Button
    Private WithEvents cmdTrainPatternModelFinder As System.Windows.Forms.Button
    Friend WithEvents ThicknessTool As System.Windows.Forms.TabPage
    Friend WithEvents scrLightLevel As System.Windows.Forms.HScrollBar
    Friend WithEvents lblLightLevel As System.Windows.Forms.Label
    Friend WithEvents comLightController As System.IO.Ports.SerialPort

End Class
