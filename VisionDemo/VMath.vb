Imports System.Math

Module VMath
    Public Function CalcAverageLineFromTwoLines(ByVal Line1 As VLineStandard, ByVal Line2 As VLineStandard) As VLineStandard
        '----- Returns a line that is averaged from two mostly parallel lines

        Dim dM1 As Double, dB1 As Double
        Dim dM2 As Double, dB2 As Double
        Dim dAvgM As Double, dAvgB As Double
        Dim Point1 As PointF, Point2 As PointF
        Dim LineOut As VLineStandard

        '----- Calc slopes
        dM1 = -(Line1.A / Line1.B)
        dM2 = -(Line2.A / Line2.B)

        '----- Calc B for each line
        dB1 = -(Line1.C / Line1.B)
        dB2 = -(Line2.C / Line2.B)

        '----- Calc the average for the line
        dAvgM = (dM1 + dM2) / 2
        dAvgB = (dB1 + dB2) / 2

        '----- Calc 2 points on the new line
        Point1.X = 100 : Point1.Y = dAvgM * Point1.X + dAvgB
        Point2.X = g_iImageSizeX - 100 : Point2.Y = dAvgM * Point2.X + dAvgB

        LineOut = CalcLineFromTwoPoints(Point1, Point2)

        'MsgBox("A: " & Format(LineOut.A, "0.000000") & vbCrLf & _
        '       "B: " & Format(LineOut.B, "0.000000") & vbCrLf & _
        '       "C: " & Format(LineOut.C, "0.000000"))

    End Function

    Public Function CalcLineFromTwoPoints(ByVal Point1 As PointF, ByVal Point2 As PointF) As VLineStandard

        Dim dM As Double = -9999, dB As Double
        Dim LineOut As VLineStandard

        Try
            '----- Calculate the coefficients for a line in stadard form from two points

            LineOut.A = -9999 : LineOut.B = -9999 : LineOut.C = -9999

            '----- Solve for slope, which becomes LineOut.A
            dM = (Point2.Y - Point1.Y) / (Point2.X - Point1.X)
            LineOut.A = dM

            '----- Solve for b from Y = mx + b
            dB = Point1.Y - (dM * Point1.X)

            '----- Calc C
            LineOut.C = (Point1.Y - (dM * Point1.X))

            '----- Now Solve for LineOut.B
            LineOut.B = -((LineOut.A * Point1.X) + LineOut.C) / Point1.Y

            Return LineOut

        Catch

            MsgBox("Error in CalcLineFromTwoPoints(): " & Err.Description)
            Return LineOut

        End Try

        'MsgBox("A: " & Format(LineOut.A, "0.000000") & vbCrLf & _
        '       "B: " & Format(LineOut.B, "0.000000") & vbCrLf & _
        '       "C: " & Format(LineOut.C, "0.000000"))

    End Function

    Public Function Avg2Points(ByVal Point1 As PointF, ByVal Point2 As PointF, ByRef PointOut As PointF) As Integer
        PointOut.X = (Point1.X + Point2.X) / 2
        PointOut.Y = (Point1.Y + Point2.Y) / 2
        'PointOut.Z = (Point1.Z + Point2.Z) / 2
        Return 0


    End Function

    Public Function CalcStdDev(ByVal InputArray As List(Of Double)) As Double
        Dim n As Integer = InputArray.Count
        Dim Avg As Double = 0
        Dim Sum As Double = 0

        For i As Integer = 0 To n - 1
            Avg = Avg + InputArray(i)
        Next

        Avg = Avg / n

        For i As Integer = 0 To n - 1
            Sum = Sum + ((InputArray(i) - Avg) * (InputArray(i) - Avg))
        Next

        Return Math.Sqrt(Sum / n)


    End Function

    Public Function CalcDistBtwn2Pts(ByVal Point1 As PointF, ByVal Point2 As PointF) As Double
        Dim Dist As Double
        Dim Diffx As Double
        Dim Diffy As Double
        Dim Diffz As Double

        Diffx = Point2.X - Point1.X
        Diffy = Point2.Y - Point1.Y
        'Diffz = Point2.Z - Point1.Z

        Dist = Math.Sqrt((Diffx * Diffx) + (Diffy * Diffy) + (Diffz * Diffz))
        Return Dist


    End Function

    Public Function CalcDistBtwnPtAndLine(ByVal Point1 As PointF, ByVal Line1 As VLine) As Double
        Dim Dist As Double
        Dim IntPoint As PointF
        Dim PerpLine As VLine

        '----- Define slope of perp line
        Dim PerpSlope As Double = -1 / Line1.M

        PerpLine.M = PerpSlope
        PerpLine.B = Point1.Y - (PerpLine.M * Point1.X)

        IntPoint.X = (PerpLine.B - Line1.B) / (Line1.M - PerpLine.M)
        IntPoint.Y = Line1.M * IntPoint.X + Line1.B

        Dist = CalcDistBtwn2Pts(Point1, IntPoint)

        Return Dist

    End Function


    Public Function CalcDistBtwn2Lines(ByVal Line1 As VLine, ByVal Line2 As VLine) As Double

        Dim BegPoint1 As PointF
        Dim BegPoint2 As PointF
        Dim EndPoint1 As PointF
        Dim EndPoint2 As PointF
        Dim dist1 As Double
        Dim dist2 As Double
        Dim Avgdist As Double

        BegPoint1.X = 1
        BegPoint2.X = 1
        BegPoint1.Y = Line1.M + Line1.B
        BegPoint2.Y = Line2.M + Line2.B

        EndPoint1.X = 2000
        EndPoint2.X = 2000
        EndPoint1.Y = Line1.M * 2000 + Line1.B
        EndPoint2.Y = Line2.M * 2000 + Line2.B

        dist1 = CalcDistBtwn2Pts(BegPoint1, BegPoint2)
        dist2 = CalcDistBtwn2Pts(EndPoint1, EndPoint2)
        Avgdist = (dist1 + dist2) / 2
        Return Avgdist

    End Function

    Public Function CalcDistLinePoint(ByVal Line1 As VLineStandard, ByVal Point1 As PointF) As Double

        Dim dDistance As Double = 123

        dDistance = (Abs((Line1.A * Point1.X) + (Line1.B * Point1.Y) + Line1.C)) / (Sqrt(Line1.A ^ 2 + Line1.B ^ 2))

        Return dDistance

    End Function
    Public Function CalcDistBtwn2Lines(ByVal Line1 As VLineStandard, ByVal Line2 As VLineStandard) As Double

        'Calc the distance from line 1 to two points on line 2

        Dim BegPoint1 As PointF
        Dim BegPoint2 As PointF
        Dim EndPoint1 As PointF
        Dim EndPoint2 As PointF
        Dim dist1 As Double
        Dim dist2 As Double
        Dim Avgdist As Double

        BegPoint1.X = 1
        BegPoint2.X = 1
        BegPoint1.Y = (Line1.C - Line1.A) / Line1.B
        BegPoint2.Y = (Line2.C - Line2.A) / Line2.B

        EndPoint1.X = 2000
        EndPoint2.X = 2000
        EndPoint1.Y = (Line1.C - (Line1.A * 2000)) / Line1.B
        EndPoint2.Y = (Line2.C - (Line2.A * 2000)) / Line2.B

        dist1 = CalcDistBtwn2Pts(BegPoint1, BegPoint2)
        dist2 = CalcDistBtwn2Pts(EndPoint1, EndPoint2)
        Avgdist = (dist1 + dist2) / 2
        Return Avgdist

    End Function

    Public Function CalcAngleBtwn2Lines(ByVal Line1 As VLineStandard, ByVal Line2 As VLineStandard) As Double

        '----- Calculates the angle betwen two line and convets to degrees
        Dim M1 As Double
        Dim M2 As Double
        Dim Angle As Double

        M1 = (Line1.A * -1) / Line1.B
        M2 = (Line2.A * -1) / Line2.B

        Angle = Atan(Abs((M2 - M1) / (1 + M2 * M1)))
        Angle *= RADIANS_TO_DEGREES

        Return Angle

    End Function

End Module
