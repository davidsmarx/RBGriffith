Public Class SimpleLineTool

    Inherits ToolBase

    Private m_dLineWidthDistance As Double
    Private m_dLineWidthDeltaAngle As Double

    Public Sub New()

        '----- Set some properties that are not brought to the user
        tlLine.Title = ""
        tlLine.ToolColor = ToolColor.Green

    End Sub

    Public Sub Execute()

        Dim Line As VLineStandard
        Dim Point1 As PointF, Point2 As PointF

        Try
            tlLine.EraseTool(objImageDisplayWindow)
            tlLine.DrawTool(objImageDisplayWindow)
            tlLine.Execute(objImagingCameraSelected.CameraImage, objImageDisplayWindow)

            '----- Check to se if all 0s, which means no edge found
            Line.A = tlLine.ResultLineA
            Line.B = tlLine.ResultLineB
            Line.C = tlLine.ResultLineC

            If Line.A + Line.B + Line.C = 0 Then Exit Sub

            'MsgBox("A: " & Format(Line.A, "0.000000") & vbCrLf & "B: " & Format(Line.B, "0.000000") & vbCrLf & "C: " & Format(Line.C, "0.000000"))

            '----- Set the end points on line 1
            If ToolSimpleLine.Orientation = HORIZONTAL Then

                '----- First and second points on line
                Point1.X = tlLine.Roi.X : Point1.Y = (-Line.C - Line.A * Point1.X) / Line.B
                Point2.X = tlLine.Roi.X + tlLine.Roi.Width : Point2.Y = (-Line.C - Line.A * Point2.X) / Line.B

            Else
                '----- First and second points on line
                Point1.Y = tlLine.Roi.Top : Point1.X = (-Line.C - Line.B * Point1.Y) / Line.A
                Point2.Y = tlLine.Roi.Top + tlLine.Roi.Height : Point2.X = (-Line.C - Line.B * Point2.Y) / Line.A

            End If

            '----- Draw Line
            DrawLine(Point1.X, Point1.Y, Point2.X, Point2.Y)

        Catch

            MsgBox("Error in ToolSimpleLine.Execute: " & Err.Description)

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
            tlLine.EraseTool(objImageDisplayWindow)
            tlLine.Execute(objImagingCameraSelected.CameraImage, objImageDisplayWindow)
            tlLine.DrawTool(objImageDisplayWindow)

            '----- Save Results
            Line1.A = tlLine.ResultLineA
            Line1.B = tlLine.ResultLineB
            Line1.C = tlLine.ResultLineC

            'MsgBox("A: " & Format(tlMetrologyLine.ResultLineA, "0.0000") & vbCrLf & _
            '       "B: " & Format(tlMetrologyLine.ResultLineB, "0.0000") & vbCrLf & _
            '       "C: " & Format(tlMetrologyLine.ResultLineC, "0.0000"))

            '----- sleep for 500 msec for display purposes only
            System.Threading.Thread.Sleep(iUserDelay)

            '----- Set polarity opposite
            Select Case tlLine.Polarity
                Case EdgePolarity.Negative : tlLine.Polarity = EdgePolarity.Positive
                Case EdgePolarity.Positive : tlLine.Polarity = EdgePolarity.Negative
            End Select

            '----- Get line 2
            tlLine.EraseTool(objImageDisplayWindow)
            tlLine.Execute(objImagingCameraSelected.CameraImage, objImageDisplayWindow)
            tlLine.DrawTool(objImageDisplayWindow)

            '----- Save Results
            Line2.A = tlLine.ResultLineA
            Line2.B = tlLine.ResultLineB
            Line2.C = tlLine.ResultLineC

            'MsgBox("A: " & Format(Line1.A, "0.0000") & ", B: " & Format(Line1.B, "0.0000") & ", C: " & Format(Line1.C, "0.0000") & vbCrLf & _
            '       "A: " & Format(Line2.A, "0.0000") & ", B: " & Format(Line2.B, "0.0000") & ", C: " & Format(Line2.C, "0.0000"))

            'MsgBox("1: " & Format(Line1.A, "0.000000") & ", " & Format(Line1.B, "0.000000") & ", " & Format(Line1.C, "0.000000") & vbCrLf & _
            '       "2: " & Format(Line2.A, "0.000000") & ", " & Format(Line2.B, "0.000000") & ", " & Format(Line2.C, "0.000000"))

            '----- sleep for 500 msec for display purposes only
            System.Threading.Thread.Sleep(iUserDelay)

            '----- Restore original edge olarity and draw the lines, if we can
            Select Case tlLine.Polarity
                Case EdgePolarity.Negative : tlLine.Polarity = EdgePolarity.Positive
                Case EdgePolarity.Positive : tlLine.Polarity = EdgePolarity.Negative
            End Select

            ToolSimpleLine.Visible = False
            ToolSimpleLine.Visible = True

            '----- Set the end points on line 1
            If ToolSimpleLine.Orientation = HORIZONTAL Then

                '----- First and second points on line 1
                Line1Point1.X = tlLine.Roi.X : Line1Point1.Y = (-Line1.C - Line1.A * Line1Point1.X) / Line1.B
                Line1Point2.X = tlLine.Roi.X + tlLine.Roi.Width : Line1Point2.Y = (-Line1.C - Line1.A * Line1Point2.X) / Line1.B

                '----- First and second points on line 2
                Line2Point1.X = tlLine.Roi.X : Line2Point1.Y = (-Line2.C - Line2.A * Line2Point1.X) / Line2.B
                Line2Point2.X = tlLine.Roi.X + tlLine.Roi.Width : Line2Point2.Y = (-Line2.C - Line2.A * Line2Point2.X) / Line2.B

                CalcAverageLineFromTwoLines(Line1, Line2)

            Else
                '----- First and second points on line 1
                Line1Point1.Y = tlLine.Roi.Top : Line1Point1.X = (-Line1.C - Line1.B * Line1Point1.Y) / Line1.A
                Line1Point2.Y = tlLine.Roi.Top + tlLine.Roi.Height : Line1Point2.X = (-Line1.C - Line1.B * Line1Point2.Y) / Line1.A

                '----- First and second points on line 2
                Line2Point1.Y = tlLine.Roi.Top : Line2Point1.X = (-Line2.C - Line2.B * Line2Point1.Y) / Line2.A
                Line2Point2.Y = tlLine.Roi.Top + tlLine.Roi.Height : Line2Point2.X = (-Line2.C - Line2.B * Line2Point2.Y) / Line2.A

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
            m_dLineWidthDeltaAngle = Angle

            'MsgBox("Line Width (pixel): " & Format((Dist1 + Dist2) / 2, "0.0000") & vbCrLf & "Angle (Deg): " & Format(Angle, "0.0000"))
        Catch
            MsgBox("Line Width Measurement was not successful.", MsgBoxStyle.Information, "Line Width measurement")

        End Try

    End Sub

    Public ReadOnly Property LineResultA() As Double
        Get
            Return tlLine.ResultLineA
        End Get
    End Property
    Public ReadOnly Property LineResultB() As Double
        Get
            Return tlLine.ResultLineB
        End Get
    End Property
    Public ReadOnly Property LineResultC() As Double
        Get
            Return tlLine.ResultLineC
        End Get
    End Property
    Public ReadOnly Property LineWidthDistance() As Double
        Get
            Return m_dLineWidthDistance
        End Get
    End Property
    Public ReadOnly Property LineWidthDeltaAngle() As Double
        Get
            Return m_dLineWidthDeltaAngle
        End Get
    End Property
    Public Property Polarity() As Integer
        Get
            Return tlLine.Polarity
        End Get
        Set(ByVal iPolarity As Integer)
            tlLine.Polarity = iPolarity
        End Set
    End Property

    Public Property Orientation() As Integer
        Get
            Return tlLine.Orientation
        End Get
        Set(ByVal iDirection As Integer)
            If iDirection = VERTICAL Or iDirection = HORIZONTAL Then
                ToolSimpleLine.Visible = False
                tlLine.Orientation = iDirection
                ToolSimpleLine.Visible = True
            End If

        End Set
    End Property


End Class
