Imports ii
Imports ii.Tools

Public Class ToolBase

    Private m_iToolType As Integer
    Private m_lToolColor As Long
    Private m_bVisible As Boolean
    Private m_sTitle As String

    Private PresentTool As New ii.Tools.Tool

    Public Sub DrawLine(ByVal X1 As Integer, ByVal Y1 As Integer, ByVal X2 As Integer, ByVal Y2 As Integer)
        'Draws a line two pixels thick

        Dim LinePen As Pen = Pens.Magenta
        Dim pt1 As New System.Drawing.Point
        Dim pt2 As New System.Drawing.Point

        X1 = X1 * DEFAULT_DISPLAY_ZOOM
        Y1 = Y1 * DEFAULT_DISPLAY_ZOOM
        X2 = X2 * DEFAULT_DISPLAY_ZOOM
        Y2 = Y2 * DEFAULT_DISPLAY_ZOOM

        '----- First line end points
        pt1.X = X1 : pt1.Y = Y1
        pt2.X = X2 : pt2.Y = Y2
        frmMain.pnlImage.CreateGraphics.DrawLine(LinePen, pt1, pt2)

        If Math.Abs(pt1.X - pt2.X) > Math.Abs(pt1.Y - pt2.Y) Then
            pt1.Y += 1 : pt2.Y += 1
        Else
            pt1.X += 1 : pt2.X += 1
        End If
        frmMain.pnlImage.CreateGraphics.DrawLine(LinePen, pt1, pt2)

    End Sub

    Public Sub DrawXHair(ByVal X As Integer, ByVal Y As Integer)

        Dim XHairPen As Pen = Pens.Red
        Dim pt1 As New System.Drawing.Point
        Dim pt2 As New System.Drawing.Point
        Dim iSize As Integer = 20

        X = X * DEFAULT_DISPLAY_ZOOM
        Y = Y * DEFAULT_DISPLAY_ZOOM

        pt1.X = X - iSize
        pt1.Y = Y
        pt2.X = X + iSize
        pt2.Y = Y

        frmMain.pnlImage.CreateGraphics.DrawLine(XHairPen, pt1, pt2)

        pt1.X = X
        pt1.Y = Y - iSize
        pt2.X = X
        pt2.Y = Y + iSize

        frmMain.pnlImage.CreateGraphics.DrawLine(XHairPen, pt1, pt2)

    End Sub

    Public Sub DrawXHair(ByVal X As Integer, ByVal Y As Integer, ByVal iSize As Integer, ByVal XHairColor As Pen)

        'Dim XHairPen As Pen = Pens.Red
        Dim pt1 As New System.Drawing.Point
        Dim pt2 As New System.Drawing.Point
        'Dim iSize As Integer = 20

        If iSize < 5 Or iSize > 1000 Then iSize = 20

        X = X * DEFAULT_DISPLAY_ZOOM
        Y = Y * DEFAULT_DISPLAY_ZOOM

        pt1.X = X - iSize
        pt1.Y = Y
        pt2.X = X + iSize
        pt2.Y = Y

        frmMain.pnlImage.CreateGraphics.DrawLine(XHairColor, pt1, pt2)

        pt1.X = X
        pt1.Y = Y - iSize
        pt2.X = X
        pt2.Y = Y + iSize

        frmMain.pnlImage.CreateGraphics.DrawLine(XHairColor, pt1, pt2)

    End Sub


    Public Sub SetPresentTool()
        '----- Sets the present tool for all the functions

        Select Case ToolType
            Case TOOL_SIMPLE_LINE
                PresentTool = tlLine
            Case TOOL_ADVANCED_LINE
                PresentTool = tlMetrologyLine
                'Case TOOL_LINE_WIDTH
                '    PresentTool = tlMetrologyLine
            Case TOOL_BLOB
                PresentTool = tlBlob
            Case TOOL_PATTERN_MATCH
                PresentTool = tlPatternMatchFinder
            Case TOOL_GEOMETRIC_MODEL_FINDER
                PresentTool = tlGeometricModelFinder
                'Case TOOL_RING
                '    PresentTool = tlSimpleCircle
        End Select

        'frmMain.Text = "Type: " & PresentTool.GetType.ToString

    End Sub
    Public Sub GetPosition(ByRef X As Integer, ByRef Y As Integer)

        SetPresentTool()

        X = PresentTool.Roi.X + PresentTool.Roi.Width / 2
        Y = PresentTool.Roi.Y + PresentTool.Roi.Height / 2

    End Sub
    Public Sub SetPosition(ByVal X As Integer, ByVal Y As Integer)

        Dim recTemp As Rectangle

        '----- Need to assign a rectangle to the tool
        recTemp.X = X - (PresentTool.Roi.Width / 2)
        recTemp.Y = Y - (PresentTool.Roi.Height / 2)
        recTemp.Height = PresentTool.Roi.Height
        recTemp.Width = PresentTool.Roi.Width

        '----- Verify params
        If recTemp.X < 1 Then Exit Sub
        If recTemp.Y < 1 Then Exit Sub
        If recTemp.X + recTemp.Width > frmMain.pnlImage.Width / DEFAULT_DISPLAY_ZOOM - 1 Then Exit Sub
        If recTemp.Y + recTemp.Height > frmMain.pnlImage.Height / DEFAULT_DISPLAY_ZOOM - 1 Then Exit Sub

        SetPresentTool()
        PresentTool.EraseTool(objImageDisplayWindow)
        PresentTool.Roi = recTemp
        PresentTool.DrawTool(objImageDisplayWindow)

    End Sub

    Public Sub SetSize(ByVal X As Integer, ByVal Y As Integer)

        Dim recTemp As Rectangle

        If X < TOOL_MIN_WIDTH Then Exit Sub
        If Y < TOOL_MIN_HEIGHT Then Exit Sub

        recTemp.X = PresentTool.Roi.X + PresentTool.Roi.Width / 2 - X / 2
        recTemp.Y = PresentTool.Roi.Y + PresentTool.Roi.Height / 2 - Y / 2


        recTemp.Width = X
        recTemp.Height = Y

        '----- Verify params
        If recTemp.X < 10 Then Exit Sub
        If recTemp.Y < 10 Then Exit Sub
        If recTemp.X + recTemp.Width / 2 > frmMain.pnlImage.Width / DEFAULT_DISPLAY_ZOOM - 1 Then Exit Sub
        If recTemp.Y + recTemp.Height / 2 > frmMain.pnlImage.Height / DEFAULT_DISPLAY_ZOOM - 1 Then Exit Sub

        'frmMain.Text = recTemp.X.ToString & " " & recTemp.Y.ToString & " " & recTemp.Width.ToString & " " & recTemp.Height.ToString

        SetPresentTool()
        PresentTool.EraseTool(objImageDisplayWindow)
        PresentTool.Roi = recTemp
        PresentTool.DrawTool(objImageDisplayWindow)

    End Sub

    Public Sub GetSize(ByRef X As Integer, ByRef Y As Integer)

        SetPresentTool()

        X = PresentTool.Roi.Width
        Y = PresentTool.Roi.Height

    End Sub

    Public Property ToolBorderColor() As Long
        Get
            Return m_lToolColor
        End Get
        Set(ByVal lColor As Long)

            SetPresentTool()

            PresentTool.ToolColor = lColor
            m_lToolColor = lColor

        End Set
    End Property

    Public Property ToolType() As Integer
        Get
            Return m_iToolType
        End Get
        Set(ByVal ToolType As Integer)
            m_iToolType = ToolType
        End Set
    End Property

    Public Property Visible() As Boolean

        Get
            Return m_bVisible
        End Get
        Set(ByVal Visible As Boolean)
            If Visible Then

                SetPresentTool()

                PresentTool.ToolColor = m_lToolColor
                PresentTool.DrawTool(objImageDisplayWindow)
                m_bVisible = True
            Else
                PresentTool.EraseTool(objImageDisplayWindow)
                m_bVisible = False
            End If
        End Set

    End Property

    Public Property Title() As String
        Get
            Return m_sTitle
        End Get
        Set(ByVal sTitle As String)

            SetPresentTool()

            PresentTool.Title = sTitle

        End Set
    End Property

End Class
