Public Class AdvancedCircleTool

    Inherits ToolBase

    Private m_bVisible As Boolean = False
    Private m_dMaxFitDistance As Double = -1
    Private m_iPolarity As Integer = EdgePolarity.Positive
    Private m_CircleCenter As New PointF With {.X = -1, .Y = -1}
    Private m_dCircleRadius As Double = -1

    Public Property IsCircleFit() As Boolean
        Get
            Return tlMetrologyCircle.IsCircleFit
        End Get
        Set(ByVal bCircleFit As Boolean)
            tlMetrologyCircle.IsCircleFit = bCircleFit
        End Set
    End Property

    Public Property ThresholdMode() As Integer
        Get
            Return tlMetrologyCircle.ThresholdMode
        End Get
        Set(ByVal iThresholdMode As Integer)
            tlMetrologyCircle.ThresholdMode = iThresholdMode
        End Set
    End Property

    Public Property MaxFitDistance() As Integer
        Get
            'DGDG Return tlMetrologyCircle.CircleFitPixelMaxDistance
            Return 0
        End Get
        Set(ByVal iMaxFitDistance As Integer)
            'DGDG tlMetrologyCircle.CircleFitPixelMaxDistance = iMaxFitDistance
        End Set
    End Property

    Public Property EdgeExctractionScale() As Double
        Get
            Return tlMetrologyCircle.EdgeExtractionScale
        End Get
        Set(ByVal dEdgeExtractionScale As Double)
            tlMetrologyCircle.EdgeExtractionScale = dEdgeExtractionScale
        End Set
    End Property

    Public Property Smoothness() As Double
        Get
            Return tlMetrologyCircle.EdgeFilterSmoothness
        End Get
        Set(ByVal dSmoothness As Double)
            tlMetrologyCircle.EdgeFilterSmoothness = dSmoothness
        End Set
    End Property

    Public Property EdgeAngleRange() As Double
        Get
            Return tlMetrologyCircle.EdgeAngleRange
        End Get
        Set(ByVal dEdgeAngleRange As Double)
            tlMetrologyCircle.EdgeAngleRange = dEdgeAngleRange
        End Set
    End Property

    Public ReadOnly Property Radius() As Double
        Get
            Return m_dCircleRadius
        End Get
    End Property

    Public ReadOnly Property Center() As PointF
        Get
            Return m_CircleCenter
        End Get
    End Property

    Public Sub New()

        '----- Set some properties that are not brought to the user
        tlMetrologyCircle.Title = ""
        tlMetrologyCircle.ToolColor = ToolColor.Green

    End Sub

    Public Shadows Property Visible() As Boolean
        Get
            Return m_bVisible
        End Get

        Set(ByVal Visible As Boolean)
            If Visible = True Then
                tlMetrologyCircle.DrawTool(objImageDisplayWindow)
                m_bVisible = True
            Else
                tlMetrologyCircle.EraseTool(objImageDisplayWindow)
                m_bVisible = False
            End If
        End Set
    End Property

    Public Shadows Sub SetSize(ByVal RadiusInner As Integer, ByVal RadiusOuter As Integer)

        If RadiusInner + 20 < RadiusOuter Then
            tlMetrologyCircle.EraseTool(objImageDisplayWindow)
            tlMetrologyCircle.Radius0 = RadiusInner
            tlMetrologyCircle.Radius1 = RadiusOuter
            tlMetrologyCircle.DrawTool(objImageDisplayWindow)
        End If

    End Sub

    Public Shadows Sub GetSize(ByRef RadiusInner As Integer, ByRef RadiusOuter As Integer)

        RadiusInner = tlMetrologyCircle.Radius0
        RadiusOuter = tlMetrologyCircle.Radius1

    End Sub

    Public Shadows Sub SetPosition(ByVal X As Integer, ByVal Y As Integer)

        Dim Center As Point
        Center.X = X
        Center.Y = Y

        tlMetrologyCircle.EraseTool(objImageDisplayWindow)
        tlMetrologyCircle.ToolCenter = Center
        tlMetrologyCircle.DrawTool(objImageDisplayWindow)

    End Sub

    Public Shadows Sub GetPosition(ByRef X As Integer, ByRef Y As Integer)

        Dim CenterPoint As System.Drawing.Point

        CenterPoint = tlMetrologyCircle.ToolCenter
        X = CenterPoint.X
        Y = CenterPoint.Y

    End Sub

    Public Sub Execute()

        Dim I As Integer = 0
        Dim sTemp As String = ""
        Dim EdgePoints As List(Of System.Drawing.PointF)

        '----- Get edges
        tlMetrologyCircle.EraseTool(objImageDisplayWindow)
        tlMetrologyCircle.Execute(objImagingCameraSelected.CameraImage)
        tlMetrologyCircle.DrawTool(objImageDisplayWindow)
        tlMetrologyCircle.DrawResultEdges(objImageDisplayWindow, tlMetrologyCircle.ToolColor)

        '------ Get results
        m_CircleCenter.X = tlMetrologyCircle.ResultPositionX
        m_CircleCenter.Y = tlMetrologyCircle.ResultPositionY
        m_dCircleRadius = tlMetrologyCircle.ResultRadius

        MsgBox("Center: " & Format(m_CircleCenter.X, "0.00") & ",  " & Format(m_CircleCenter.Y, "0.00") & vbCrLf & "Radius: " & Format(m_dCircleRadius, "0.00"))

        '----- Get the 8 points that form the edges, but do nothing for now as 
        '      8 points does not really mean anything
        EdgePoints = tlMetrologyCircle.ResultEdges

        MsgBox("Num: " & Format(EdgePoints.Count, "0"))

        '----- Display XHair
        DrawXHair(m_CircleCenter.X, m_CircleCenter.Y, 12, Pens.Blue)

        'For I = 0 To EdgePoints.Count - 1
        '    sTemp = sTemp & Format(EdgePoints(I).X, "0.00") & ",  " & Format(EdgePoints(I).Y, "0.00") & vbCrLf
        '    DrawXHair(EdgePoints(I).X, EdgePoints(I).Y, 10, Pens.Cyan)
        'Next I
        'MsgBox(sTemp)

    End Sub

    Public Property Polarity() As Integer
        Get
            Return m_iPolarity
        End Get
        Set(ByVal iPolarity As Integer)
            m_iPolarity = iPolarity
            tlMetrologyCircle.Polarity = iPolarity
        End Set
    End Property

End Class
