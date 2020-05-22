Public Class AdvancedLineTool

    Inherits ToolBase

    Private m_dLineWidthDistance As Double = 0
    Private m_dLineWidthAngle As Double = 0

    Public Sub New()

        '----- Set some properties that are not brought to the user
        tlMetrologyLine.Title = ""
        tlMetrologyLine.ToolColor = ToolColor.Red
        tlMetrologyLine.IsLineFit = True

    End Sub

    Public Sub Execute()

        Dim Line As VLineStandard
        Dim Point1 As PointF, Point2 As PointF

        Try
            tlMetrologyLine.EraseTool(objImageDisplayWindow)
            tlMetrologyLine.DrawTool(objImageDisplayWindow)
            tlMetrologyLine.Execute(objImagingCameraSelected.CameraImage)

            '----- Get the results and exit if all 0s, which means no edge found
            Line.A = tlMetrologyLine.ResultLineA
            Line.B = tlMetrologyLine.ResultLineB
            Line.C = tlMetrologyLine.ResultLineC

            If Line.A + Line.B + Line.C = 0 Then Exit Sub

            'MsgBox("A: " & Format(Line.A, "0.000000") & vbCrLf & "B: " & Format(Line.B, "0.000000") & vbCrLf & "C: " & Format(Line.C, "0.000000"))

            '----- Set the end points on line 1
            If ToolAdvancedLine.Orientation = ScanDirection.North Or ToolAdvancedLine.Orientation = ScanDirection.South Then

                '----- First and second points on line
                Point1.X = tlMetrologyLine.Roi.X : Point1.Y = (-Line.C - Line.A * Point1.X) / Line.B
                Point2.X = tlMetrologyLine.Roi.X + tlMetrologyLine.Roi.Width : Point2.Y = (-Line.C - Line.A * Point2.X) / Line.B

            Else
                '----- First and second points on line
                Point1.Y = tlMetrologyLine.Roi.Top : Point1.X = (-Line.C - Line.B * Point1.Y) / Line.A
                Point2.Y = tlMetrologyLine.Roi.Top + tlMetrologyLine.Roi.Height : Point2.X = (-Line.C - Line.B * Point2.Y) / Line.A

            End If

            '----- Draw Line
            DrawLine(Point1.X, Point1.Y, Point2.X, Point2.Y)

        Catch

            MsgBox("Error in ToolAdvancedLine.Execute: " & Err.Description)

        End Try

    End Sub

    Public Sub ExecuteLineWidth()

        '----- Measures the width of two edges as defined by the tool properties.
        '      Saves the results in .LineWidth and .Angle
        Dim Line1 As VLineStandard
        Dim Line2 As VLineStandard
        Dim Line1Point1 As PointF, Line1Point2 As PointF
        Dim Line2Point1 As PointF, Line2Point2 As PointF
        Dim Dist1 As Double = 0, Dist2 As Double = 0
        Dim Angle As Double = 0
        Dim iUserDelay As Integer = 100

        '----- Run Line Width Tool
        Try
            '----- Get line 1
            tlMetrologyLine.EraseTool(objImageDisplayWindow)
            tlMetrologyLine.Execute(objImagingCameraSelected.CameraImage)
            tlMetrologyLine.DrawTool(objImageDisplayWindow)

            '----- Save Results
            Line1.A = tlMetrologyLine.ResultLineA
            Line1.B = tlMetrologyLine.ResultLineB
            Line1.C = tlMetrologyLine.ResultLineC

            'MsgBox("A: " & Format(tlMetrologyLine.ResultLineA, "0.0000") & vbCrLf & _
            '       "B: " & Format(tlMetrologyLine.ResultLineB, "0.0000") & vbCrLf & _
            '       "C: " & Format(tlMetrologyLine.ResultLineC, "0.0000"))

            '----- sleep for 500 msec for display purposes only
            System.Threading.Thread.Sleep(iUserDelay)

            '----- Set direction 180 degrees away
            Select Case tlLine.Orientation
                Case ScanDirection.South : tlMetrologyLine.ToolAngle = ScanDirection.North
                Case ScanDirection.North : tlMetrologyLine.ToolAngle = ScanDirection.South
                Case ScanDirection.West : tlMetrologyLine.ToolAngle = ScanDirection.East
                Case ScanDirection.East : tlMetrologyLine.ToolAngle = ScanDirection.West
            End Select

            '----- Get line 2
            tlMetrologyLine.EraseTool(objImageDisplayWindow)
            tlMetrologyLine.Execute(objImagingCameraSelected.CameraImage)
            tlMetrologyLine.DrawTool(objImageDisplayWindow)

            '----- Save Results
            Line2.A = tlMetrologyLine.ResultLineA
            Line2.B = tlMetrologyLine.ResultLineB
            Line2.C = tlMetrologyLine.ResultLineC

            'MsgBox("A: " & Format(Line1.A, "0.0000") & ", B: " & Format(Line1.B, "0.0000") & ", C: " & Format(Line1.C, "0.0000") & vbCrLf & _
            '       "A: " & Format(Line2.A, "0.0000") & ", B: " & Format(Line2.B, "0.0000") & ", C: " & Format(Line2.C, "0.0000"))

            'MsgBox("1: " & Format(Line1.A, "0.000000") & ", " & Format(Line1.B, "0.000000") & ", " & Format(Line1.C, "0.000000") & vbCrLf & _
            '       "2: " & Format(Line2.A, "0.000000") & ", " & Format(Line2.B, "0.000000") & ", " & Format(Line2.C, "0.000000"))

            '----- sleep for 500 msec for display purposes only
            System.Threading.Thread.Sleep(iUserDelay)

            '----- Restore original direction and draw the lines, if we can
            Select Case tlLine.Orientation
                Case ScanDirection.South : tlMetrologyLine.ToolAngle = ScanDirection.North
                Case ScanDirection.North : tlMetrologyLine.ToolAngle = ScanDirection.South
                Case ScanDirection.West : tlMetrologyLine.ToolAngle = ScanDirection.East
                Case ScanDirection.East : tlMetrologyLine.ToolAngle = ScanDirection.West
            End Select

            ToolAdvancedLine.Visible = False
            ToolAdvancedLine.Visible = True

            '----- Set the end points on line 1
            If ToolAdvancedLine.Orientation = ScanDirection.South Or ToolAdvancedLine.Orientation = ScanDirection.North Then

                '----- First and second points on line 1
                Line1Point1.X = tlMetrologyLine.Roi.X : Line1Point1.Y = (-Line1.C - Line1.A * Line1Point1.X) / Line1.B
                Line1Point2.X = tlMetrologyLine.Roi.X + tlMetrologyLine.Roi.Width : Line1Point2.Y = (-Line1.C - Line1.A * Line1Point2.X) / Line1.B

                '----- First and second points on line 2
                Line2Point1.X = tlMetrologyLine.Roi.X : Line2Point1.Y = (-Line2.C - Line2.A * Line2Point1.X) / Line2.B
                Line2Point2.X = tlMetrologyLine.Roi.X + tlMetrologyLine.Roi.Width : Line2Point2.Y = (-Line2.C - Line2.A * Line2Point2.X) / Line2.B

                CalcAverageLineFromTwoLines(Line1, Line2)

            Else
                '----- First and second points on line 1
                Line1Point1.Y = tlMetrologyLine.Roi.Top : Line1Point1.X = (-Line1.C - Line1.B * Line1Point1.Y) / Line1.A
                Line1Point2.Y = tlMetrologyLine.Roi.Top + tlMetrologyLine.Roi.Height : Line1Point2.X = (-Line1.C - Line1.B * Line1Point2.Y) / Line1.A

                '----- First and second points on line 2
                Line2Point1.Y = tlMetrologyLine.Roi.Top : Line2Point1.X = (-Line2.C - Line2.B * Line2Point1.Y) / Line2.A
                Line2Point2.Y = tlMetrologyLine.Roi.Top + tlMetrologyLine.Roi.Height : Line2Point2.X = (-Line2.C - Line2.B * Line2Point2.Y) / Line2.A

                CalcAverageLineFromTwoLines(Line1, Line2)

            End If

            '----- Draw Lines
            DrawLine(Line1Point1.X, Line1Point1.Y, Line1Point2.X, Line1Point2.Y)
            DrawLine(Line2Point1.X, Line2Point1.Y, Line2Point2.X, Line2Point2.Y)

            '----- Assign results
            Dist1 = CalcDistLinePoint(Line1, Line2Point1)
            Dist2 = CalcDistLinePoint(Line1, Line2Point2)
            Angle = CalcAngleBtwn2Lines(Line1, Line2)
            m_dLineWidthDistance = (Dist1 + Dist2) / 2
            m_dLineWidthAngle = Angle

            'MsgBox("Line Width (pixel): " & Format((Dist1 + Dist2) / 2, "0.0000") & vbCrLf & "Angle (Deg): " & Format(Angle, "0.0000"))
        Catch
            MsgBox("Line Width Measurement was not successful.", MsgBoxStyle.Information, "Line Width measurement")

        End Try

    End Sub

    Public ReadOnly Property LineResultA() As Double
        Get
            Return tlMetrologyLine.ResultLineA
        End Get
    End Property
    Public ReadOnly Property LineResultB() As Double
        Get
            Return tlMetrologyLine.ResultLineB
        End Get
    End Property
    Public ReadOnly Property LineResultC() As Double
        Get
            Return tlMetrologyLine.ResultLineC
        End Get
    End Property
    Public ReadOnly Property LineResultAngle() As Double
        Get
            If IsNumeric(-tlMetrologyLine.ResultLineA) And IsNumeric(tlMetrologyLine.ResultLineB) Then
                Return Math.Atan(-tlMetrologyLine.ResultLineA / tlMetrologyLine.ResultLineB) * RADIANS_TO_DEGREES
            Else
                Return 0
            End If
        End Get
    End Property
    Public ReadOnly Property LineWidthDistance() As Double
        Get
            Return m_dLineWidthDistance
        End Get
    End Property
    Public ReadOnly Property LineWidthDeltaAngle() As Double
        Get
            Return m_dLineWidthAngle
        End Get
    End Property
    Public Property Polarity() As Integer
        Get
            Return tlMetrologyLine.Polarity
        End Get
        Set(ByVal iPolarity As Integer)
            tlMetrologyLine.Polarity = iPolarity
        End Set
    End Property
    Public Property Orientation() As Integer
        Get
            Return tlMetrologyLine.ToolAngle
        End Get
        Set(ByVal iDirection As Integer)
            If iDirection = ScanDirection.South Or iDirection = ScanDirection.North Or iDirection = ScanDirection.East Or iDirection = ScanDirection.West Then
                ToolAdvancedLine.Visible = False
                tlMetrologyLine.ToolAngle = iDirection
                ToolAdvancedLine.Visible = True
            End If

        End Set
    End Property
    Public Property EdgeSelection() As Integer
        Get
            Return tlMetrologyLine.EdgeSelection
        End Get
        Set(ByVal iEdgeSelection As Integer)
            tlMetrologyLine.EdgeSelection = iEdgeSelection
        End Set
    End Property
    Public Property ThresholdMode() As Integer
        Get
            Return tlMetrologyLine.ThresholdMode
        End Get
        Set(ByVal iThresholdMode As Integer)
            tlMetrologyLine.ThresholdMode = iThresholdMode
        End Set
    End Property
    Public Property EdgeSmoothness() As Double
        Get
            Return tlMetrologyLine.EdgeFilterSmoothness
        End Get
        Set(ByVal dSmoothness As Double)
            tlMetrologyLine.EdgeFilterSmoothness = dSmoothness
        End Set
    End Property
    Public Property AngleRange() As Integer
        Get
            Return tlMetrologyLine.EdgeAngleRange
        End Get
        Set(ByVal iAngleRange As Integer)
            tlMetrologyLine.EdgeAngleRange = iAngleRange
        End Set
    End Property
    Public Property MaxLineFitDistance() As Integer
        Get
            'DGDG Return tlMetrologyLine.LineFitPixelMaxDistance
            Return 0
        End Get
        Set(ByVal iLineMaxFitDistance As Integer)
            'DGDG tlMetrologyLine.LineFitPixelMaxDistance = iLineMaxFitDistance
        End Set
    End Property
    Public Property EdgeExtractionScale() As Double
        Get
            Return tlMetrologyLine.EdgeExtractionScale
        End Get
        Set(ByVal dScale As Double)
            tlMetrologyLine.EdgeExtractionScale = dScale
        End Set
    End Property
End Class
