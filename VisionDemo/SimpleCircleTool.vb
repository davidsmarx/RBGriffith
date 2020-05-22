Public Class SimpleCircleTool

    Inherits ToolBase

    Private m_bVisible As Boolean = False
    Private m_dMaxFitDistance As Double = -1
    Private m_iPolarity As Integer = EdgePolarity.Positive
    Private m_CircleCenter As New PointF With {.X = -1, .Y = -1}
    Private m_dCircleRadius As Double = -1

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
        tlCircle.Title = ""
        tlCircle.ToolColor = ToolColor.DarkGreen

    End Sub

    Public Shadows Property Visible() As Boolean
        Get
            Return m_bVisible
        End Get

        Set(ByVal Visible As Boolean)
            If Visible = True Then
                tlCircle.DrawTool(objImageDisplayWindow)
                m_bVisible = True
            Else
                tlCircle.EraseTool(objImageDisplayWindow)
                m_bVisible = False
            End If
        End Set
    End Property

    Public Shadows Sub SetSize(ByVal RadiusInner As Integer, ByVal RadiusOuter As Integer)

        If RadiusInner + 20 < RadiusOuter Then
            tlCircle.EraseTool(objImageDisplayWindow)
            tlCircle.Radius0 = RadiusInner
            tlCircle.Radius1 = RadiusOuter
            tlCircle.DrawTool(objImageDisplayWindow)
        End If

    End Sub

    Public Shadows Sub GetSize(ByRef RadiusInner As Integer, ByRef RadiusOuter As Integer)

        RadiusInner = tlCircle.Radius0
        RadiusOuter = tlCircle.Radius1

    End Sub

    Public Shadows Sub SetPosition(ByVal X As Integer, ByVal Y As Integer)

        Dim Center As Point
        Center.X = X
        Center.Y = Y

        tlCircle.EraseTool(objImageDisplayWindow)
        tlCircle.ToolCenter = Center
        tlCircle.DrawTool(objImageDisplayWindow)

    End Sub

    Public Shadows Sub GetPosition(ByRef X As Integer, ByRef Y As Integer)

        Dim CenterPoint As System.Drawing.Point

        CenterPoint = tlCircle.ToolCenter
        X = CenterPoint.X
        Y = CenterPoint.Y

    End Sub

    Public Property MaxFitDistance() As Double
        Get
            Return m_dMaxFitDistance
        End Get
        Set(ByVal dMaxFitDistance As Double)
            If dMaxFitDistance >= 1 And dMaxFitDistance <= 100 Then
                m_dMaxFitDistance = dMaxFitDistance
            Else
                m_dMaxFitDistance = 10
            End If
            'DGDG tlCircle.CircleFitPixelMaxDistance = m_dMaxFitDistance
        End Set
    End Property

    Public Sub Execute()

        Dim I As Integer = 0
        Dim sTemp As String = ""
        Dim EdgePoints As List(Of System.Drawing.PointF)

        '----- Get edges
        tlCircle.Execute(objImagingCameraSelected.CameraImage, objImageDisplayWindow)
        tlCircle.DrawResultEdges(objImageDisplayWindow, tlCircle.ToolColor)
        'tlSimpleCircle.DrawResulyCircleEquation(objImageDisplayWindow, tlSimpleCircle.ToolColor)

        '------ Get results
        m_CircleCenter = tlCircle.ResultPosition
        m_dCircleRadius = tlCircle.ResultRadius

        '----- Get the 8 points that form the edges, but do nothing for now as 
        '      8 points does not really mean anything
        EdgePoints = tlCircle.ResultEdges

        '----- Display XHair
        DrawXHair(m_CircleCenter.X, m_CircleCenter.Y, 12, Pens.Blue)

        For I = 0 To EdgePoints.Count - 1
            sTemp = sTemp & Format(EdgePoints(I).X, "0.00") & ",  " & Format(EdgePoints(I).Y, "0.00") & vbCrLf
            DrawXHair(EdgePoints(I).X, EdgePoints(I).Y, 10, Pens.Cyan)
        Next I
        MsgBox(sTemp)

    End Sub

    Public Property Polarity() As Integer
        Get
            Return m_iPolarity
        End Get
        Set(ByVal iPolarity As Integer)
            m_iPolarity = iPolarity
            tlCircle.Polarity = iPolarity
        End Set
    End Property

End Class
