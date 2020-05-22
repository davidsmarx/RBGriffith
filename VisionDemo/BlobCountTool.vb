Imports ii
Imports ii.Tools

Public Class BlobCountTool

    Inherits ToolBase

    Private m_iMinArea As Integer = MIN_AREA
    Private m_iBlobCount As Integer = 0

    Private m_lFilterMinArea As Long = MIN_AREA, m_lFilterMaxArea As Long = MAX_AREA

    Private m_iBlobTop As Integer = -1, m_iBlobBottom As Integer = -1, m_iBlobLeft As Integer = -1, m_iBlobRight As Integer = -1
    Private m_iBlobUL As Integer = -1, m_iBlobUR As Integer = -1, m_iBlobLL As Integer = -1, m_iBlobLR As Integer = -1, m_iBlobCenter = -1
    Private m_iBlobSmallest As Integer = -1, m_iBlobBiggest As Integer = -1

    Private CentroidX(1) As Double, CentroidY(1) As Double, Areas(1) As Double
    Private BoxMinX(1) As Integer
    Private BoxMinY(1) As Integer
    Private BoxMaxX(1) As Double
    Private BoxMaxY(1) As Double

    Public Sub New()

        tlBlob.Title = ""

        '----- Set some properties that are not brought to the user
        tlBlob.Title = ""
        tlBlob.ToolColor = ToolColor.LightBlue
        tlBlob.DrawTool(objImageDisplayWindow)

    End Sub
    Public Sub AutoBinarize(ByVal iAction As Integer)
        objImagingCameraSelected.CameraImage.AutoBinarize(iAction)
    End Sub

    Public Sub Binarize(ByVal iAction As Integer, ByVal iThreshold As Integer)

        If iThreshold < 0 Or iThreshold > 255 Then Exit Sub
        objImagingCameraSelected.CameraImage.Binarize(iAction, Convert.ToDouble(iThreshold), 0)

    End Sub

    Public Sub Execute()
        tlBlob.Execute(objImagingCameraSelected.CameraImage)
    End Sub
    Public Sub DrawResultCenterOfGravity()
        'tlBlob.Dra()
        '  _blobTool.DrawResultCenterOfGravity(_imageDisplayWindow, _blobTool.ToolColor);
    End Sub
    Public Sub DrawResultBoxes()
        '        _blobTool.DrawResultCenterOfGravity(_imageDisplayWindow, _blobTool.ToolColor);

    End Sub
    Public Sub DrawResultConvexHullContours()
        '        _blobTool.DrawResultConvexHullContours(_imageDisplayWindow, ImagingEnumeration.Color.Cyan);
    End Sub
    Public Sub EraseResults()
        tlBlob.EraseResults(objImageDisplayWindow)
    End Sub
    Public Sub Dispose()
        tlBlob.Dispose()
    End Sub
    Protected Overrides Sub Finalize()
        MyBase.Finalize()
    End Sub
    Public Function NumberOfBlobs() As Integer
        Return tlBlob.NumberOfBlobs()
    End Function
    Public Property CalcCenterOfGravity() As Boolean
        Get
            Return tlBlob.CalcCenterOfGravity
        End Get
        Set(ByVal bAction As Boolean)
            tlBlob.CalcCenterOfGravity = bAction
        End Set
    End Property
    Public Property CalcBox() As Boolean
        Get
            Return tlBlob.CalcBox
        End Get
        Set(ByVal bAction As Boolean)
            tlBlob.CalcBox = bAction
        End Set
    End Property
    Public Property CalcConvexHull() As Boolean
        Get
            Return tlBlob.CalcConvexHull
        End Get
        Set(ByVal bAction As Boolean)
            tlBlob.CalcConvexHull = bAction
        End Set
    End Property

    Public ReadOnly Property BlobCount() As Integer
        Get
            Return m_iBlobCount
        End Get
    End Property
    Public Sub CalcBlobResults()

        Dim I As Integer = 0, iValidCounter As Integer = 0
        Dim RawCentroids As List(Of PointF)
        Dim BlobAreas As List(Of Double)
        Dim iPosX As Integer = -1, iPosY As Integer = -1
        Dim iSizeX As Integer = -1, iSizeY As Integer = -1
        Dim sTempArea As String = "", sTempCentroids As String = ""
        Dim sTempBox As String = ""

        '----- Get Centroids that are referenced from the UL corner of the tool, and areas
        RawCentroids = tlBlob.ResultsCenterOfGravity
        BlobAreas = tlBlob.ResultsArea

        ReDim CentroidX(0 To RawCentroids.Count - 1)
        ReDim CentroidY(0 To RawCentroids.Count - 1)
        ReDim Areas(0 To RawCentroids.Count - 1)
        ReDim BoxMinX(0 To RawCentroids.Count - 1)
        ReDim BoxMinY(0 To RawCentroids.Count - 1)
        ReDim BoxMaxX(0 To RawCentroids.Count - 1)
        ReDim BoxMaxY(0 To RawCentroids.Count - 1)

        '----- Adjust CG to screen coordinates
        GetPosition(iPosX, iPosY)
        GetSize(iSizeX, iSizeY)

        '----- Assign to tool level arrays for future recall
        '      If > than min area
        For I = 0 To BlobAreas.Count - 1
            If BlobAreas(I) >= m_lFilterMinArea And BlobAreas(I) <= m_lFilterMaxArea Then

                '----- Assign centroid and convert to FOV pixels from values that refernce the UL corner of the tool
                CentroidX(iValidCounter) = (iPosX - (iSizeX / 2) + RawCentroids(I).X)
                CentroidY(iValidCounter) = (iPosY - (iSizeY / 2) + RawCentroids(I).Y)

                '----- Assign areas
                Areas(iValidCounter) = BlobAreas(I)

                '----- Assign corners and convert to FOV pixels from values that refernce the UL corner of the tool
                BoxMinX(iValidCounter) = (iPosX - (iSizeX / 2) + tlBlob.ResultsBoxMinX(I))
                BoxMinY(iValidCounter) = (iPosY - (iSizeY / 2) + tlBlob.ResultsBoxMinY(I))
                BoxMaxX(iValidCounter) = (iPosX - (iSizeX / 2) + tlBlob.ResultsBoxMaxX(I))
                BoxMaxY(iValidCounter) = (iPosY - (iSizeY / 2) + tlBlob.ResultsBoxMaxY(I))

                '----- Assign to string for testing
                sTempArea = sTempArea & Format(Areas(iValidCounter), "0") & vbCrLf
                sTempCentroids = sTempCentroids & Format(CentroidX(iValidCounter), "0") & ", " & Format(CentroidY(iValidCounter), "0") & vbCrLf
                sTempBox = sTempBox & Format(BoxMinX(iValidCounter), "0") & ", " & Format(BoxMinY(iValidCounter), "0") & ", " & Format(BoxMaxX(iValidCounter), "0") & ", " & Format(BoxMaxY(iValidCounter), "0") & vbCrLf

                iValidCounter += 1

            End If
        Next I

        m_iBlobCount = iValidCounter

        'If RawCentroids.Count > 0 Then MsgBox("CG List Count: " & Format(RawCentroids.Count))
        'MsgBox(sTempArea, , "Area")
        'MsgBox(sTempCentroids, , "Centroids")
        'MsgBox(sTempBox, , "Box")

        '----- Display all the blobs found
        'For I = 0 To iValidCounter
        '    DrawXHair(CentroidX(I), CentroidY(I))

        '    DrawLine(BoxMinX(I), BoxMinY(I), BoxMaxX(I), BoxMinY(I)) 'Top
        '    DrawLine(BoxMaxX(I), BoxMinY(I), BoxMaxX(I), BoxMaxY(I)) 'Right
        '    DrawLine(BoxMinX(I), BoxMinY(I), BoxMinX(I), BoxMaxY(I)) 'Left
        '    DrawLine(BoxMinX(I), BoxMaxY(I), BoxMaxX(I), BoxMaxY(I)) 'Bottom

        'Next I

    End Sub
    Public Function DrawBlobCentroid(ByVal iItem) As Integer

        If m_iBlobCount >= iItem Then
            DrawXHair(CentroidX(iItem), CentroidY(iItem))
            Return NO_ERROR
        Else
            Return INVALID_PARAMETER
        End If

    End Function

    Public Function DrawBlobBox(ByVal iItem) As Integer

        If m_iBlobCount >= iItem Then
            DrawLine(BoxMinX(iItem), BoxMinY(iItem), BoxMaxX(iItem), BoxMinY(iItem)) 'Top
            DrawLine(BoxMaxX(iItem), BoxMinY(iItem), BoxMaxX(iItem), BoxMaxY(iItem)) 'Right
            DrawLine(BoxMinX(iItem), BoxMinY(iItem), BoxMinX(iItem), BoxMaxY(iItem)) 'Left
            DrawLine(BoxMinX(iItem), BoxMaxY(iItem), BoxMaxX(iItem), BoxMaxY(iItem))  'Bottom

            Return NO_ERROR
        Else
            Return INVALID_PARAMETER
        End If

    End Function
    Public Function GetBlobArea(ByVal iItem As Integer) As Long

        If m_iBlobCount >= iItem Then
            Return Areas(iItem)
        Else
            Return INVALID_PARAMETER
        End If

    End Function

    Public Function GetBlobCentroid(ByVal iItem As Integer) As Point

        Dim ptPoint As Point

        ptPoint.X = INVALID_PARAMETER
        ptPoint.Y = INVALID_PARAMETER

        If m_iBlobCount >= iItem Then

            ptPoint.X = CentroidX(iItem)
            ptPoint.Y = CentroidY(iItem)
            Return ptPoint
        Else
            Return ptPoint
        End If

    End Function

    Public Function GetBlobBoxUL(ByVal iItem As Integer) As PointF

        Dim ptPointUL As PointF

        ptPointUL.X = INVALID_PARAMETER
        ptPointUL.Y = INVALID_PARAMETER

        If m_iBlobCount >= iItem Then

            ptPointUL.X = BoxMinX(iItem)
            ptPointUL.Y = BoxMinY(iItem)
            Return ptPointUL
        Else
            Return ptPointUL
        End If

    End Function
    Public Function GetBlobBoxLR(ByVal iItem As Integer) As PointF

        Dim ptPointLR As PointF

        ptPointLR.X = INVALID_PARAMETER
        ptPointLR.Y = INVALID_PARAMETER

        If m_iBlobCount >= iItem Then

            ptPointLR.X = BoxMaxX(iItem)
            ptPointLR.Y = BoxMaxY(iItem)
            Return ptPointLR
        Else
            Return ptPointLR
        End If

    End Function

    Public Property FilterMaxArea() As Long
        Get
            Return m_lFilterMaxArea
        End Get
        Set(ByVal lMaxArea As Long)
            m_lFilterMaxArea = lMaxArea
        End Set
    End Property

    Public Property FilterMinArea() As Long
        Get
            Return m_lFilterMinArea
        End Get
        Set(ByVal lMinArea As Long)
            m_lFilterMaxArea = lMinArea
        End Set
    End Property

    Public Function IsBlob(ByVal Xpixel As Integer, ByVal Ypixel As Integer) As Integer
        'Determines if a blobe is located when a mouse is clicked on an image pixel

        Dim I As Integer = INVALID_PARAMETER

        '----- Verify some blobs
        If m_iBlobCount = 0 Then Return INVALID_PARAMETER

        For I = 0 To m_iBlobCount - 1
            If Xpixel >= BoxMinX(I) And Xpixel <= BoxMaxX(I) And _
               Ypixel >= BoxMinY(I) And Ypixel <= BoxMaxY(I) Then
                Return I
            End If
        Next I

        Return INVALID_PARAMETER

    End Function

    Public Function GetExtremeBlob(ByVal iBlobPosition) As Integer

        Select Case iBlobPosition
            Case BlobPostion.Bottom : Return m_iBlobBottom
            Case BlobPostion.Center : Return m_iBlobCenter
            Case BlobPostion.Left : Return m_iBlobLeft
            Case BlobPostion.LL : Return m_iBlobLL
            Case BlobPostion.LR : Return m_iBlobLR
            Case BlobPostion.Right : Return m_iBlobRight
            Case BlobPostion.Top : Return m_iBlobTop
            Case BlobPostion.UL : Return m_iBlobUL
            Case BlobPostion.UR : Return m_iBlobUR
            Case BlobPostion.Smallest : Return m_iBlobSmallest
            Case BlobPostion.Biggest : Return m_iBlobBiggest
        End Select

        Return INVALID_PARAMETER

    End Function
    Public Sub CalcExtremeBlobs()
        'Caclulate the blobs closest to each corner

        'DGDG - NOT WORKING

        Dim I As Integer = 0
        Dim dDistUL As Double = 1000000, dDistUR As Double = 1000000, dDistLL As Double = 1000000, dDistLR As Double = 1000000, dDistCent As Double = 1000000
        Dim dDistTop As Double = 1000000, dDistBottom As Double = 0, dDistLeft As Double = 1000000, dDistRight As Double = 0
        Dim dTempDistUL As Double = 0, dTempDistUR As Double = 0, dTempDistLL As Double = 0, dTempDistLR As Double = 0, dTempDistCent As Double = 0
        Dim lTempAreaSMallest As Long = 1000000, lTempAreaBiggest As Long = 0
        Dim iPosX As Integer = 0, iPosY As Integer = 0

        '------ Init
        m_iBlobUL = -1 : m_iBlobLL = -1 : m_iBlobUR = -1 : m_iBlobLR = -1
        m_iBlobCenter = -1
        m_iBlobTop = -1 : m_iBlobBottom = -1 : m_iBlobLeft = -1 : m_iBlobRight = -1

        '----- Get Window Position
        GetPosition(iPosX, iPosY)

        '----- Exit if no blobs
        If m_iBlobCount = 0 Then Exit Sub

        For I = 0 To m_iBlobCount - 1

            '----- Calc the distance to each corner
            dTempDistUL = Math.Sqrt((0 - CentroidX(I)) ^ 2 + (0 - CentroidY(I)) ^ 2)
            dTempDistUR = Math.Sqrt((g_iImageSizeX - CentroidX(I)) ^ 2 + (0 - CentroidY(I)) ^ 2)
            dTempDistLL = Math.Sqrt((0 - CentroidX(I)) ^ 2 + (g_iImageSizeY - CentroidY(I)) ^ 2)
            dTempDistLR = Math.Sqrt((g_iImageSizeX - CentroidX(I)) ^ 2 + (g_iImageSizeY - CentroidY(I)) ^ 2)
            dTempDistCent = Math.Sqrt((g_iImageSizeX / 2 - CentroidX(I)) ^ 2 + (g_iImageSizeY / 2 - CentroidY(I)) ^ 2)

            '----- Assign distance if shorter to corners
            If dTempDistUL < dDistUL Then
                dDistUL = dTempDistUL
                m_iBlobUL = I
            End If

            If dTempDistUR < dDistUR Then
                dDistUR = dTempDistUR
                m_iBlobUR = I
            End If

            If dTempDistLL < dDistLL Then
                dDistLL = dTempDistLL
                m_iBlobLL = I
            End If

            If dTempDistLR < dDistLR Then
                dDistLR = dTempDistLR
                m_iBlobLR = I
            End If

            If dTempDistCent < dDistCent Then
                dDistCent = dTempDistCent
                m_iBlobCenter = I
            End If

            '----- Assign dist to middle of extremes if shorter
            If CentroidY(I) < dDistTop Then
                dDistTop = CentroidY(I)
                m_iBlobTop = I
            End If

            If CentroidY(I) > dDistBottom Then
                dDistBottom = CentroidY(I)
                m_iBlobBottom = I
            End If

            If CentroidX(I) < dDistLeft Then
                dDistLeft = CentroidX(I)
                m_iBlobLeft = I
            End If

            If CentroidX(I) > dDistRight Then
                dDistRight = CentroidX(I)
                m_iBlobRight = I
            End If

            If Areas(I) < lTempAreaSMallest Then
                lTempAreaSMallest = Areas(I)
                m_iBlobSmallest = I
            End If

            If Areas(I) > lTempAreaBiggest Then
                lTempAreaBiggest = Areas(I)
                m_iBlobBiggest = I
            End If

        Next I


        '----- Test calcs & +1 so the numbers are the same as the combo box on the Blob Tool tab 
        'MsgBox("UL: " & Format(m_iBlobUL + 1) & vbCrLf & _
        '       "LL: " & Format(m_iBlobLL + 1) & vbCrLf & _
        '       "UR: " & Format(m_iBlobUR + 1) & vbCrLf & _
        '      "LR: " & Format(m_iBlobLR + 1) & vbCrLf & _
        '      "C: " & Format(m_iBlobCenter + 1, "0") & vbCrLf & _
        '      "T : " & Format(m_iBlobTop + 1, "0") & vbCrLf & _
        '      "B: " & Format(m_iBlobBottom + 1, "0") & vbCrLf & _
        '      "L: " & Format(m_iBlobLeft + 1, "0") & vbCrLf & _
        '      "R: " & Format(m_iBlobRight + 1, "0"))
    End Sub

End Class
