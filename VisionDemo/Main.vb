Imports System.Collections.Generic
Imports System.Drawing
Imports System.IO
Imports System.Text
Imports System.Windows.Forms
Imports System.IO.Directory
Imports ii
Imports ii.Tools
Imports ii.ImageProcessing.ImageProcessing

Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim I As Integer = 0
        Dim sTemp As String = ""
        Dim sFiles() As String = GetFiles("C:\VisionDemo\VisionDemo\Images")

        '----- Init Vision
        Call InitCamera()   'DGDG Make Camera object and move this function to that along with live(), Grab, etc.

        'DGDG Temp stuff for now
        '----- Load Images
        For I = 0 To sFiles.Count - 1
            sTemp = Path.GetFileName(sFiles(I))
            lstImages.Items.Add(sTemp)
        Next

        '----- This has to be done after the vision init stuff
        Me.Width = 1200
        Me.Height = 850

        '----- Load all the pertinent globals and status values
        SaveLoadRegistry(FILE_LOAD)

        '----- Use the values loaded in SaveLoadRegistry() to init the system
        '----- Units
        Select Case g_sUnits
            Case "Inch" : optInch.Checked = True : g_sUnitsFormat = "0.000###" : g_dUnitsFactor = 1          'Inch is default
            Case "MM" : optMM.Checked = True
            Case "Micro Inch" : optMicroInch.Checked = True
            Case "Micron" : optMicron.Checked = True
            Case "Pixel" : optPixel.Checked = True
        End Select
        lblUnits.Text = "Units: " & g_sUnits
        cboBinarizePolarity.Text = "White"

        '----- Other labels
        lblImageSize.Text = "Image Size: (" & Format(g_iImageSizeX, "0") & ", " & Format(g_iImageSizeY, "0") & ")"
        lblDisplayFactor.Text = "Display Factor: " & Format(DEFAULT_DISPLAY_ZOOM, "0.00")

        '----- Init higher level tools
        InitVisionTools()

        '----- Show live image
        cmdLive.PerformClick()

        '----- Open COM port for LED controller
        comLightController.Open()
        scrLightLevel.Value = 30

    End Sub

    Private Sub InitVisionTools()

        Dim iStartLocationX As Integer = g_iImageSizeX / 2
        Dim iStartLocationY As Integer = g_iImageSizeY / 2

        'tabTools.Controls.Remove(PatternMatchTool)
        'tabTools.Controls.Remove(GeometricModelFinder)
        tabTools.SelectTab("Video")

        '=============================================================
        '----- Init the higher level tools here
        '=============================================================

        '----- Init Blob Tool
        ToolBlob.ToolType = TOOL_BLOB
        ToolBlob.ToolBorderColor = ToolColor.Blue
        ToolBlob.SetPosition(iStartLocationX, iStartLocationY)

        '----- Init Patern Match Tool
        ToolPatternMatch.ToolType = TOOL_PATTERN_MATCH
        ToolPatternMatch.ToolBorderColor = ToolColor.Green
        ToolPatternMatch.Title = ""
        ToolPatternMatch.SetPosition(iStartLocationX, iStartLocationY)
        ToolPatternMatch.SetOrigin(iStartLocationX, iStartLocationY)

        '----- Init Geo Match tool
        'ToolGeometricModel.ToolType = TOOL_GEOMETRIC_MODEL_FINDER
        ToolGeometricModel.ToolBorderColor = ToolColor.Blue
        ToolGeometricModel.Title = ""
        ToolGeometricModel.SetPosition(iStartLocationX, iStartLocationY)

        '----- Micrometer Tool
        Dim XHair1Start As PointF, XHair2Start As PointF
        XHair1Start.X = iStartLocationX / 2 : XHair1Start.Y = iStartLocationY / 2
        XHair2Start.X = iStartLocationX * 1.5 : XHair2Start.Y = iStartLocationY * 1.5
        ToolMicrometer.SetPosition(XHair1Start, XHair2Start)

        '----- Simple Circle Tool
        ToolSimpleCircle.SetPosition(g_iImageSizeX / 2, g_iImageSizeY / 2)

        '----- Advanced Circle Tool
        ToolAdvancedCircle.SetPosition(g_iImageSizeX / 2, g_iImageSizeY / 2)

        '----- Init Simple Line Tool
        ToolSimpleLine.ToolType = TOOL_SIMPLE_LINE
        ToolSimpleLine.ToolBorderColor = ToolColor.DarkRed
        ToolSimpleLine.SetPosition(iStartLocationX, iStartLocationY)

        '----- Init Advanced Line Tool
        ToolAdvancedLine.ToolType = TOOL_ADVANCED_LINE
        ToolAdvancedLine.ToolBorderColor = ToolColor.DarkRed
        ToolAdvancedLine.Polarity = EdgePolarity.Positive
        ToolAdvancedLine.Orientation = ScanDirection.South
        ToolAdvancedLine.EdgeSelection = EdgeSelection.Edge1
        ToolAdvancedLine.ThresholdMode = ThresholdMode.Medium
        ToolAdvancedLine.AngleRange = 5
        ToolAdvancedLine.ToolBorderColor = ToolColor.Red
        ToolAdvancedLine.SetPosition(iStartLocationX, iStartLocationY)


        HideAllTools()

    End Sub

    Private Sub pnlImage_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlImage.MouseClick

        'This function could return the blob selected, but can't use Box values because 
        'they could be ambiguous.  Needs 
        Dim iBlobNum As Integer = -1
        Dim imagePoint As New Point

        If g_iActiveTool = TOOL_BLOB And chkClickOnBlobs.Checked = True Then

            '----- Calc Mouse value
            imagePoint.X = (e.X / DEFAULT_DISPLAY_ZOOM)
            imagePoint.Y = (e.Y / DEFAULT_DISPLAY_ZOOM)

            iBlobNum = ToolBlob.IsBlob(imagePoint.X, imagePoint.Y)

            'MsgBox("Blob: " & Format(iBlobNum, "0"))

            If iBlobNum >= 0 Then cboBlobs.Text = Format(iBlobNum + 1, "0")

        End If
    End Sub

    Private Sub pnlImage_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlImage.MouseDown

        Dim CenterBuffer As Integer = 35
        Dim LineBuffer As Integer = 15
        Dim Xhair1 As PointF, XHair2 As PointF
        Dim ImagePoint As New Point
        Dim ToolPosX As Integer = -1, ToolPosY As Integer = -1, ToolSizeX As Integer = -1, ToolSizeY As Integer = -1, RadInner As Integer, RadOuter As Integer

        '----- Calc Mouse value
        imagePoint.X = (e.X / DEFAULT_DISPLAY_ZOOM)
        imagePoint.Y = (e.Y / DEFAULT_DISPLAY_ZOOM)

        'Me.Text = "X: " & imagePoint.X & "  " & "Y: " & imagePoint.Y

        '---- Get Tool Status
        Select Case g_iActiveTool
            Case TOOL_SIMPLE_LINE
                ToolSimpleLine.GetPosition(ToolPosX, ToolPosY)
                ToolSimpleLine.GetSize(ToolSizeX, ToolSizeY)

            Case TOOL_ADVANCED_LINE
                ToolAdvancedLine.GetPosition(ToolPosX, ToolPosY)
                ToolAdvancedLine.GetSize(ToolSizeX, ToolSizeY)

            Case TOOL_BLOB
                ToolBlob.GetPosition(ToolPosX, ToolPosY)
                ToolBlob.GetSize(ToolSizeX, ToolSizeY)

            Case TOOL_MICROMETER
                ToolMicrometer.GetPosition(Xhair1, XHair2)

                '----- See if on tool here because it works different from the rectangluar ROIs
                If imagePoint.X < Xhair1.X + LineBuffer And imagePoint.X > Xhair1.X - LineBuffer And
                   imagePoint.Y < Xhair1.Y + LineBuffer And imagePoint.Y > Xhair1.Y - LineBuffer Then
                    g_iToolLocation = SelectTool.MicrometerLeft
                    Cursor = Cursors.SizeAll
                    'MsgBox("Left")
                ElseIf imagePoint.X < XHair2.X + LineBuffer And imagePoint.X > XHair2.X - LineBuffer And
                       imagePoint.Y < XHair2.Y + LineBuffer And imagePoint.Y > XHair2.Y - LineBuffer Then
                    g_iToolLocation = SelectTool.MicrometerRight
                    Cursor = Cursors.SizeAll
                    'MsgBox("Right")
                End If

                'Me.Text = ToolMicrometer.GetType.ToString
                Exit Sub

            Case TOOL_SIMPLE_CIRCLE
                Dim dX As Integer = -1, dY As Integer = -1
                Dim MouseRadius As Integer = -1

                ToolSimpleCircle.GetPosition(ToolPosX, ToolPosY)
                ToolSimpleCircle.GetSize(RadInner, RadOuter)

                dX = ToolPosX - ImagePoint.X
                dY = ToolPosY - ImagePoint.Y
                MouseRadius = Math.Sqrt(dX ^ 2 + dY ^ 2)

                '----- See if on tool here because it works different from the rectangluar ROIs
                If ImagePoint.X < ToolPosX + LineBuffer And ImagePoint.X > ToolPosX - LineBuffer And
                   ImagePoint.Y < ToolPosY + LineBuffer And ImagePoint.Y > ToolPosY - LineBuffer Then
                    g_iToolLocation = SelectTool.Center
                    Cursor = Cursors.SizeAll
                    'Me.Text = "Simple Circle - Center"
                ElseIf MouseRadius < RadInner + LineBuffer And MouseRadius > RadInner - LineBuffer Then
                    g_iToolLocation = SelectTool.CircleInner
                    Cursor = Cursors.SizeNS
                ElseIf MouseRadius < RadOuter + LineBuffer And MouseRadius > RadOuter - LineBuffer Then
                    g_iToolLocation = SelectTool.CircleOuter
                    Cursor = Cursors.SizeWE
                End If

                Exit Sub

            Case TOOL_ADVANCED_CIRCLE
                Dim dX As Integer = -1, dY As Integer = -1
                Dim MouseRadius As Integer = -1

                ToolAdvancedCircle.GetPosition(ToolPosX, ToolPosY)
                ToolAdvancedCircle.GetSize(RadInner, RadOuter)

                dX = ToolPosX - ImagePoint.X
                dY = ToolPosY - ImagePoint.Y
                MouseRadius = Math.Sqrt(dX ^ 2 + dY ^ 2)

                '----- See if on tool here because it works different from the rectangluar ROIs
                If ImagePoint.X < ToolPosX + LineBuffer And ImagePoint.X > ToolPosX - LineBuffer And
                   ImagePoint.Y < ToolPosY + LineBuffer And ImagePoint.Y > ToolPosY - LineBuffer Then
                    g_iToolLocation = SelectTool.Center
                    Cursor = Cursors.SizeAll
                    'Me.Text = "Simple Circle - Center"
                ElseIf MouseRadius < RadInner + LineBuffer And MouseRadius > RadInner - LineBuffer Then
                    g_iToolLocation = SelectTool.CircleInner
                    Cursor = Cursors.SizeNS
                ElseIf MouseRadius < RadOuter + LineBuffer And MouseRadius > RadOuter - LineBuffer Then
                    g_iToolLocation = SelectTool.CircleOuter
                    Cursor = Cursors.SizeWE
                End If

                Exit Sub

            Case TOOL_PATTERN_MATCH
                If chkOriginPattern.Checked = True Then
                    g_iToolLocation = SelectTool.Origin
                    Cursor = Cursors.Cross
                    Exit Sub
                End If

                ToolPatternMatch.GetPosition(ToolPosX, ToolPosY)
                ToolPatternMatch.GetSize(ToolSizeX, ToolSizeY)

                'Me.Text = ToolPatternMatch.GetType.ToString

            Case TOOL_GEOMETRIC_MODEL_FINDER
                If chkOriginGeometric.Checked = True Then
                    g_iToolLocation = SelectTool.Origin
                    Cursor = Cursors.Cross
                    Exit Sub
                End If

                ToolGeometricModel.GetPosition(ToolPosX, ToolPosY)
                ToolGeometricModel.GetSize(ToolSizeX, ToolSizeY)

                'Me.Text = ToolGeometricModel.GetType.ToString

        End Select

        '----- Select side or corner
        If imagePoint.X < ToolPosX - ToolSizeX / 2 + LineBuffer And imagePoint.X > ToolPosX - ToolSizeX / 2 - LineBuffer And
                imagePoint.Y < ToolPosY - ToolSizeY / 2 + LineBuffer And imagePoint.Y > ToolPosY - ToolSizeY / 2 - LineBuffer Then
            g_iToolLocation = SelectTool.UpperLeftCorner
            Cursor = Cursors.SizeNWSE
            'MsgBox("UL")

        ElseIf imagePoint.X < ToolPosX + ToolSizeX / 2 + LineBuffer And imagePoint.X > ToolPosX + ToolSizeX / 2 - LineBuffer And
            imagePoint.Y < ToolPosY - ToolSizeY / 2 + LineBuffer And imagePoint.Y > ToolPosY - ToolSizeY / 2 - LineBuffer Then
            g_iToolLocation = SelectTool.UpperRightCorner
            Cursor = Cursors.SizeNESW
            'MsgBox("UR")

        ElseIf imagePoint.X < ToolPosX - ToolSizeX / 2 + LineBuffer And imagePoint.X > ToolPosX - ToolSizeX / 2 - LineBuffer And
            imagePoint.Y < ToolPosY + ToolSizeY / 2 + LineBuffer And imagePoint.Y > ToolPosY + ToolSizeY / 2 - LineBuffer Then
            g_iToolLocation = SelectTool.LowerLeftCorner
            Cursor = Cursors.SizeNESW
            'MsgBox("LL")

        ElseIf imagePoint.X < ToolPosX + ToolSizeX / 2 + LineBuffer And imagePoint.X > ToolPosX + ToolSizeX / 2 - LineBuffer And
            imagePoint.Y < ToolPosY + ToolSizeY / 2 + LineBuffer And imagePoint.Y > ToolPosY + ToolSizeY / 2 - LineBuffer Then
            g_iToolLocation = SelectTool.LowerRightCorner
            Cursor = Cursors.SizeNWSE
            'MsgBox("LR")

        ElseIf imagePoint.X > ToolPosX - ToolSizeX / 2 - LineBuffer And imagePoint.X < ToolPosX - ToolSizeX / 2 + LineBuffer And
            imagePoint.Y < ToolPosY + ToolSizeY / 2 + LineBuffer And imagePoint.Y > ToolPosY - ToolSizeY / 2 - LineBuffer Then
            g_iToolLocation = SelectTool.LeftBoundary
            Cursor = Cursors.SizeWE
            'MsgBox("Left")

        ElseIf imagePoint.X > ToolPosX + ToolSizeX / 2 - LineBuffer And imagePoint.X < ToolPosX + ToolSizeX / 2 + LineBuffer And
            imagePoint.Y < ToolPosY + ToolSizeY / 2 + LineBuffer And imagePoint.Y > ToolPosY - ToolSizeY / 2 - LineBuffer Then
            g_iToolLocation = SelectTool.RightBoundary
            Cursor = Cursors.SizeWE
            'MsgBox("Right")

        ElseIf imagePoint.Y > ToolPosY - ToolSizeY / 2 - LineBuffer And imagePoint.Y < ToolPosY - ToolSizeY / 2 + LineBuffer And
            imagePoint.X < ToolPosX + ToolSizeX / 2 + LineBuffer And imagePoint.X > ToolPosX - ToolSizeX / 2 - LineBuffer Then
            g_iToolLocation = SelectTool.TopBoundary
            Cursor = Cursors.SizeNS
            'MsgBox("Top")

        ElseIf imagePoint.Y > ToolPosY + ToolSizeY / 2 - LineBuffer And imagePoint.Y < ToolPosY + ToolSizeY / 2 + LineBuffer And
            imagePoint.X < ToolPosX + ToolSizeX / 2 + LineBuffer And imagePoint.X > ToolPosX - ToolSizeX / 2 - LineBuffer Then
            g_iToolLocation = SelectTool.BottomBoundary
            Cursor = Cursors.SizeNS
            'MsgBox("Bottom")

        ElseIf imagePoint.X < ToolPosX + centerBuffer And imagePoint.X > ToolPosX - centerBuffer And imagePoint.Y < ToolPosY + centerBuffer And imagePoint.Y > ToolPosY - centerBuffer Then
            g_iToolLocation = SelectTool.Center
            Me.Cursor = Cursors.SizeAll
            'MsgBox("Center")

        Else
            g_iToolLocation = SelectTool.None

        End If
    End Sub
    Private Sub cmdImageLoad_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim sFilename As String = ""

        OpenFileDialog.DefaultExt = "*.bmp"
        OpenFileDialog.InitialDirectory = "C:\Source\iiDev\SimCameraImage1"
        OpenFileDialog.FileName = ""
        If OpenFileDialog.ShowDialog() = DialogResult.OK Then
            sFilename = OpenFileDialog.FileName
            objImagingCameraSelected.CameraImage.Load(sFilename)
            'MsgBox("File: " & sFilename)
        End If


    End Sub

   
    Private Sub pnlImage_MouseMove(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlImage.MouseMove

        Dim SizeX As Integer, SizeY As Integer, PosX As Integer, PosY As Integer, RadInner As Integer, RadOuter As Integer, TempRad As Integer
        Dim ptImagePoint As New Point       'User mouse location
        Dim XHair1 As PointF, XHair2 As PointF

        '----- Exit if no tool selected
        If g_iActiveTool = TOOL_NONE Or g_iToolLocation = SelectTool.None Then
            '    Me.Text = Format(e.X, "0") & "     " & Format(e.Y, "0")
            Exit Sub
        End If

        '----- Get mouse location and correct for zoom
        ptImagePoint.X = (e.X / DEFAULT_DISPLAY_ZOOM)
        ptImagePoint.Y = (e.Y / DEFAULT_DISPLAY_ZOOM)

        '---- Do nothing if mouse off the image panel
        If ptImagePoint.X < 1 Or ptImagePoint.Y < 1 Or
            ptImagePoint.X > pnlImage.Width / DEFAULT_DISPLAY_ZOOM - 1 Or
            ptImagePoint.Y > pnlImage.Height / DEFAULT_DISPLAY_ZOOM - 1 Then
            Exit Sub
        End If

        '----- See if Origin is moving first, and exit if so after moving the origin
        'If g_iToolLocation = SelectTool.Origin Then
        '    If g_iActiveTool = TOOL_PATTERN_MATCH Then ToolPatternMatch.SetOrigin(ptImagePoint.X, ptImagePoint.Y)
        '    If g_iActiveTool = TOOL_GEOMETRIC_MODEL_FINDER Then ToolGeometricModel.SetOrigin(ptImagePoint.X, ptImagePoint.Y)
        '    Exit Sub
        'End If

        '----- Get tool Status
        Select Case g_iActiveTool
            Case TOOL_SIMPLE_LINE
                ToolSimpleLine.GetPosition(PosX, PosY)
                ToolSimpleLine.GetSize(SizeX, SizeY)
            Case TOOL_ADVANCED_LINE
                ToolAdvancedLine.GetPosition(PosX, PosY)
                ToolAdvancedLine.GetSize(SizeX, SizeY)
            Case TOOL_MICROMETER
                ToolMicrometer.GetPosition(XHair1, XHair2)
            Case TOOL_BLOB
                ToolBlob.GetPosition(PosX, PosY)
                ToolBlob.GetSize(SizeX, SizeY)
            Case TOOL_SIMPLE_CIRCLE
                ToolSimpleCircle.GetPosition(PosX, PosY)
                ToolSimpleCircle.GetSize(RadInner, RadOuter)
                TempRad = Math.Sqrt((PosX - ptImagePoint.X) ^ 2 + (PosY - ptImagePoint.Y) ^ 2)
            Case TOOL_ADVANCED_CIRCLE
                ToolAdvancedCircle.GetPosition(PosX, PosY)
                ToolAdvancedCircle.GetSize(RadInner, RadOuter)
                TempRad = Math.Sqrt((PosX - ptImagePoint.X) ^ 2 + (PosY - ptImagePoint.Y) ^ 2)
            Case TOOL_PATTERN_MATCH
                ToolPatternMatch.GetPosition(PosX, PosY)
                ToolPatternMatch.GetSize(SizeX, SizeY)
                ToolPatternMatch.SetOrigin(PosX, PosY)
            Case TOOL_GEOMETRIC_MODEL_FINDER
                ToolGeometricModel.GetPosition(PosX, PosY)
                ToolGeometricModel.GetSize(SizeX, SizeY)
                ToolGeometricModel.SetOrigin(PosX, PosY)
        End Select

        '----- Move according to where mouse grabbed
        Select Case g_iToolLocation
            Case SelectTool.Center
                PosX = ptImagePoint.X
                PosY = ptImagePoint.Y
            Case SelectTool.LeftBoundary
                SizeX = (PosX - ptImagePoint.X) * 2
            Case SelectTool.RightBoundary
                SizeX = (ptImagePoint.X - PosX) * 2
            Case SelectTool.TopBoundary
                SizeY = (PosY - ptImagePoint.Y) * 2
            Case SelectTool.BottomBoundary
                SizeY = (ptImagePoint.Y - PosY) * 2
            Case SelectTool.UpperLeftCorner
                SizeX = (PosX - ptImagePoint.X) * 2
                SizeY = (PosY - ptImagePoint.Y) * 2
            Case SelectTool.LowerLeftCorner
                SizeX = (PosX - ptImagePoint.X) * 2
                SizeY = (ptImagePoint.Y - PosY) * 2
            Case SelectTool.UpperRightCorner
                SizeY = (PosY - ptImagePoint.Y) * 2
                SizeX = (ptImagePoint.X - PosX) * 2
            Case SelectTool.LowerRightCorner
                SizeY = (ptImagePoint.Y - PosY) * 2
                SizeX = (ptImagePoint.X - PosX) * 2
            Case SelectTool.MicrometerLeft
                XHair1.X = ptImagePoint.X : XHair1.Y = ptImagePoint.Y
            Case SelectTool.MicrometerRight
                XHair2.X = ptImagePoint.X : XHair2.Y = ptImagePoint.Y
            Case SelectTool.CircleInner
                RadInner = TempRad
            Case SelectTool.CircleOuter
                RadOuter = TempRad
        End Select

        '----- Assign to tool
        Select Case g_iActiveTool
            Case TOOL_SIMPLE_LINE
                ToolSimpleLine.SetPosition(PosX, PosY)
                ToolSimpleLine.SetSize(SizeX, SizeY)
            Case TOOL_ADVANCED_LINE
                ToolAdvancedLine.SetPosition(PosX, PosY)
                ToolAdvancedLine.SetSize(SizeX, SizeY)
            Case TOOL_BLOB
                ToolBlob.SetPosition(PosX, PosY)
                ToolBlob.SetSize(SizeX, SizeY)
            Case TOOL_MICROMETER
                ToolMicrometer.SetPosition(XHair1, XHair2)
            Case TOOL_SIMPLE_CIRCLE
                ToolSimpleCircle.SetPosition(PosX, PosY)
                ToolSimpleCircle.SetSize(RadInner, RadOuter)
            Case TOOL_ADVANCED_CIRCLE
                ToolAdvancedCircle.SetPosition(PosX, PosY)
                ToolAdvancedCircle.SetSize(RadInner, RadOuter)
            Case TOOL_PATTERN_MATCH
                ToolPatternMatch.SetPosition(PosX, PosY)
                ToolPatternMatch.SetSize(SizeX, SizeY)
            Case TOOL_GEOMETRIC_MODEL_FINDER
                ToolGeometricModel.SetPosition(PosX, PosY)
                ToolGeometricModel.SetSize(SizeX, SizeY)
        End Select

        ' Me.Text = "X: " & ptImagePoint.X & "   " & "Y: " & ptImagePoint.Y

    End Sub

    Private Sub pnlImage_MouseUp(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles pnlImage.MouseUp

        Dim dX As Double, dY As Double, dDistance As Double

        If g_iActiveTool = TOOL_MICROMETER Then
            lblMicrometerResults.Visible = True
            ToolMicrometer.Results(dX, dY, dDistance)
            lblMicrometerResults.Text = "X Distance: " & Format(dX * g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat) & vbCrLf & _
                                        "Y Distance: " & Format(dY * g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat) & vbCrLf & _
                                        "Distance:     " & Format(dDistance * g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat) & vbCrLf & _
                                        "Angle:           " & Format(Math.Atan(dY / dX) * RADIANS_TO_DEGREES, "0.00")

        End If
        Me.Cursor = Cursors.Default
        g_iToolLocation = SelectTool.None

    End Sub

    Private Sub lstImages_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstImages.DoubleClick

        Try
            objImagingCameraSelected.CameraImage.Load("c:\VisionDemo\VisionDemo\Images\" & lstImages.SelectedItem)
        Catch
            MsgBox("Error Loading Image: " & Err.Description)
        End Try

    End Sub

    Private Sub txtMetrologyLineSmoothness_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvancedLineSmoothness.TextChanged

        'If IsNumeric(txtMetrologyLineSmoothness.Text) And
        '    Val(txtMetrologyLineSmoothness.Text) >= 0 And
        '    Val(txtMetrologyLineSmoothness.Text) <= 100 Then
        '    tlMetrologyLine.EdgeFilterSmoothness = Val(txtMetrologyLineSmoothness.Text)
        'End If

        'MsgBox("Smoothness: " & tlMetrologyLine.EdgeFilterSmoothness)

    End Sub

    Private Sub txtAdvancedLineAngleRange_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtAdvancedLineAngleRange.TextChanged

        If IsNumeric(txtAdvancedLineAngleRange.Text) And
            Val(txtAdvancedLineAngleRange.Text) >= 0 And
            Val(txtAdvancedLineAngleRange.Text) <= 45 Then
            ToolAdvancedLine.AngleRange = Val(txtAdvancedLineAngleRange.Text)
        End If

        'MsgBox("Angle Range: " & tlMetrologyLine.EdgeAngleRange)

    End Sub

    Private Sub tabTools_SelectedIndexChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles tabTools.SelectedIndexChanged

        '----- Hide all Tools
        HideAllTools()

        Select Case tabTools.SelectedTab.Name

            Case "SimpleLineTool"
                g_iActiveTool = TOOL_SIMPLE_LINE
                ToolSimpleLine.Visible = True

            Case "AdvancedLineTool"
                g_iActiveTool = TOOL_ADVANCED_LINE
                ToolAdvancedLine.Visible = True

            Case "MicrometerTool"
                g_iActiveTool = TOOL_MICROMETER
                ToolMicrometer.Visible = True

            Case "BlobTool"
                g_iActiveTool = TOOL_BLOB
                ToolBlob.Visible = True

            Case "PatternMatchTool"
                g_iActiveTool = TOOL_PATTERN_MATCH
                ToolPatternMatch.Visible = True
                LoadPatternModelFiles()

            Case "GeometricModelFinder"
                g_iActiveTool = TOOL_GEOMETRIC_MODEL_FINDER
                ToolGeometricModel.Visible = True
                LoadGeometricModelFiles()

            Case "SimpleCircleTool"
                g_iActiveTool = TOOL_SIMPLE_CIRCLE
                ToolSimpleCircle.Visible = True

            Case "AdvancedCircleTool"
                g_iActiveTool = TOOL_ADVANCED_CIRCLE
                ToolAdvancedCircle.Visible = True

            Case "Video"
                g_iActiveTool = TOOL_NONE
                HideAllTools()

            Case "Units"
                lblUnitsPixelSize.Text = "Pixel Size (" & g_sUnits & "): " & Format(g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat)

            Case Else
                g_iActiveTool = TOOL_NONE
                HideAllTools()

        End Select

        'MsgBox("Tab name IC: " & tabTools.SelectedTab.Name)

    End Sub

    Private Sub HideAllTools()

        ToolPatternMatch.Visible = False
        ToolGeometricModel.Visible = False
        ToolBlob.Visible = False
        ToolMicrometer.Visible = False
        ToolSimpleLine.Visible = False
        ToolAdvancedLine.Visible = False
        ToolSimpleCircle.Visible = False
        ToolAdvancedCircle.Visible = False

    End Sub

    Private Function ConvertLineStandardFormToSlopeForm(ByVal dA As Double, ByVal dB As Double, ByVal dC As Double, ByVal iLineDir As Integer) As VLine
        'Converts the stdard line formula to slope intercept form

        'DGDG This may have to be modofied for Vertical lines
        Dim lnTemp As VLine
        lnTemp.M = -9999 : lnTemp.B = -9999

        'DGDG Check for direciton of line

        Select Case iLineDir
            Case HORIZONTAL
                lnTemp.M = -(dA / dB)
                lnTemp.B = -(dC / dB)
                lnTemp.Dir = HORIZONTAL
                Return lnTemp
            Case VERTICAL
                lnTemp.M = -(dB / dA)
                lnTemp.B = dC / dA
                lnTemp.Dir = VERTICAL
                Return lnTemp
            Case Else
                Return lnTemp
        End Select
    End Function

    Private Function D2DistanceLinePoint(ByVal linLine As VLineStandard, ByVal ptPoint As PointF) As Double

        Dim dDistance As Double = -9999

        'DGDG NOT TESTED

        '----- If both 0 return error
        If linLine.A = 0 And linLine.B = 0 Then Return dDistance

        Try
            dDistance = Math.Abs(linLine.A * ptPoint.X + linLine.B * ptPoint.Y + linLine.C) / Math.Sqrt((linLine.A) ^ 2 + (linLine.B) ^ 2)

            Return dDistance

        Catch
            MsgBox("Error in D2DistanceLinepoint", MsgBoxStyle.OkOnly, "Error")
            Return dDistance

        End Try

    End Function

    Private Sub optInch_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles optInch.Click, _
                                            optMM.Click, optMicroInch.Click, optMicron.Click, optPixel.Click, optPixel.Click

        Dim optButtonTemp As RadioButton = sender

        'MsgBox("Button: " & optButtonTemp.Name)

        Select Case optButtonTemp.Name
            Case "optInch"
                g_sUnits = "Inch"
                g_sUnitsFormat = "0.0####"
                g_dUnitsFactor = 1

            Case "optMM"
                g_sUnits = "MM"
                g_sUnitsFormat = "0.0##"
                g_dUnitsFactor = 25.4

            Case "optMicroInch"
                g_sUnits = "Micro Inch"
                g_sUnitsFormat = "0.0##"
                g_dUnitsFactor = 1 * 10 ^ 6

            Case "optMicron"
                g_sUnits = "Micron"
                g_sUnitsFormat = "0.0##"
                g_dUnitsFactor = 25400

            Case "optPixel"
                g_sUnits = "Pixel"
                g_sUnitsFormat = "0.0##"
                g_dUnitsFactor = 1 / g_dPixelSize

        End Select

        '----- Update staus box
        lblUnits.Text = "Units: " & g_sUnits
        lblUnitsPixelSize.Text = "Pixel Size (" & g_sUnits & "): " & Format(g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat)

    End Sub

    Private Sub InitCamera()

        Dim sDCFFile As String = "C:\DCF\GO-5101M.dcf"

        Cursor = Cursors.WaitCursor

        '----- Create imaging object and init imaging object.
        '----- Must do this first to create the imaging class library object.
        'DGDG 
        objImaging = New Imaging
 
        '----- Init class library object.
        objImaging.Init()

        '----- Init frame grabber board.
        objImagingBoard = objImaging.InitBoard(ImagingEnumeration.BoardProduct.RadientEvcl)

        '----- Init camera.  Must init both cameras even though only one camera is connected
        objImagingCamera0 = objImagingBoard.InitCamera(sDCFFile)
        objImagingCamera1 = objImagingBoard.InitCamera(sDCFFile)

        '----- Init GeniCam mode.
        objImagingCamera0.CameraInitGeniCam()

        '------ Set camera tap geometry.
        objImagingCamera0.CameraControlFeature("DeviceTapGeometry", "Geometry_1X3_1Y")

        '================== Uncomment when there is a second camera, maybe run off of registry value
        '----- Init GeniCam mode.
        'objImagingCamera1.CameraInitGeniCam()

        '------ Set camera tap geometry.
        'objImagingCamera1.CameraControlFeature("DeviceTapGeometry", "Geometry_1X3_1Y")
        '=================================================================================

        '----- Init display window.
        objImageDisplayWindow = objImagingBoard.InitImageDisplayWindow()

        '----- Set display zoom.
        objImageDisplayWindow.Zoom(DEFAULT_DISPLAY_ZOOM, DEFAULT_DISPLAY_ZOOM)

        '----- Select camera 0 camera image into image panel.
        objImageDisplayWindow.SelectDisplay(objImagingCamera0.CameraImage, pnlImage.Handle)

        '----- Select camera 0.
        objImagingCameraSelected = objImagingCamera0

        '----- Set display mode background.
        objImageDisplayWindow.BackgroundMode(ImagingEnumeration.BackgroundMode.Transparent)

        '----- Set image display panel to camera sizes.
        pnlImage.Width = objImagingCamera0.CameraSizeX * DEFAULT_DISPLAY_ZOOM
        pnlImage.Height = objImagingCamera0.CameraSizeY * DEFAULT_DISPLAY_ZOOM

        g_iImageSizeX = objImagingCamera0.CameraSizeX
        g_iImageSizeY = objImagingCamera0.CameraSizeY

        Cursor = Cursors.Default
        '========================================================================================

        'MsgBox("Init Done")

    End Sub

    Private Sub cmdGrab_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGrab.Click

        objImagingCameraSelected.GrabImage()

    End Sub

    Private Sub cmdStop_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdStop.Click

        objImagingCameraSelected.StopContinuousGrab()

        '----- Grab another image - Live video does not put video into buffer, so do it here
        objImagingCameraSelected.GrabImage()

    End Sub

    Private Sub cmdLive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLive.Click

        objImagingCameraSelected.ContinuousGrab()

    End Sub

    Private Sub cmdExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdExit.Click

        Dim iResponse As Integer = 0

        iResponse = MsgBox("Are you sure you want to exit", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "Exit")
        If iResponse = vbNo Then Exit Sub

        '----- Close Com port
        'DGDG Make COM LED CONTROLLER CLASS
        scrLightLevel.Value = 0
        comLightController.Close()

        Me.Close()
        End

    End Sub

    Private Sub frmMain_FormClosed(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosedEventArgs) Handles Me.FormClosed

        SaveLoadRegistry(FILE_SAVE)
        HideAllTools()

        If IsNothing(ToolMicrometer) = False Then ToolMicrometer.Dispose()

        '------ Dispose vision tools.
        If IsNothing(tlPatternMatchFinder) = False Then tlPatternMatchFinder.Dispose()
        If IsNothing(tlGeometricModelFinder) = False Then tlGeometricModelFinder.Dispose()
        If IsNothing(tlBlob) = False Then tlBlob.Dispose()
        If IsNothing(tlLine) = False Then tlLine.Dispose()
        If IsNothing(tlMetrologyLine) = False Then tlMetrologyLine.Dispose()
        If IsNothing(tlCircle) = False Then tlCircle.Dispose()
        If IsNothing(tlMetrologyCircle) = False Then tlMetrologyCircle.Dispose()

        '------ Dispose imaging objects.
        '----- Imaging objects must be disposed in the order below.
        If IsNothing(objImageDisplayWindow) = False Then objImageDisplayWindow.Dispose()
        If IsNothing(objImagingCamera0) = False Then objImagingCamera0.Dispose()
        'If IsNothing(objImagingCamera1) Then objImagingCamera1.Dispose()
        If IsNothing(objImagingBoard) = False Then objImagingBoard.Dispose()
        If IsNothing(objImaging) = False Then objImaging.Dispose()

    End Sub

    Private Sub cmdPos_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim dX As Double = -1, dY As Double = -1

        ToolSimpleLine.SetPosition(Convert.ToDouble(txtPosX.Text), Convert.ToDouble(txtPosY.Text))
        'Threading.Thread.Sleep(1000)
        ToolSimpleLine.GetPosition(dX, dY)
        MsgBox("X: " & Format(dX, "0") & "  " & "Y: " & Format(dY, "0"))


    End Sub

    Private Sub BlobRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBlobRun.Click

        'MsgBox("X: " & tlBlob.Roi.X & vbCrLf & _
        '"Y: " & tlBlob.Roi.Y & vbCrLf & _
        '"Width: " & tlBlob.Roi.Width & vbCrLf & _
        '"Height: " & tlBlob.Roi.Height & vbCrLf)

        Dim I As Integer = -1
        Dim sNumBlobs As Integer = -1

        '----- Clear and redraw
        ToolBlob.Visible = False
        ToolBlob.Visible = True

        '----- Set calcs
        ToolBlob.CalcCenterOfGravity = chkCG.Checked
        ToolBlob.CalcBox = chkBox.Checked
        ToolBlob.CalcConvexHull = chkHull.Checked

        '----- Set Filters
        If chkAreaIgnore.Checked = True Then
            ToolBlob.FilterMinArea = MIN_AREA
            ToolBlob.FilterMaxArea = MAX_AREA
        Else
            If IsNumeric(txtAreaMin.Text) And IsNumeric(txtAreaMax.Text) And _
                Val(txtAreaMin.Text) < Val(txtAreaMax.Text) Then
                ToolBlob.FilterMinArea = Val(txtAreaMin.Text)
                ToolBlob.FilterMaxArea = Val(txtAreaMax.Text)
            Else
                MsgBox("Filter values are not valid.  Reset filter values or check Ignore.", MsgBoxStyle.Information, "Filter Value Error")
                Exit Sub
            End If

        End If

        '----- Run Tool
        ToolBlob.Execute()
        'Threading.Thread.Sleep(100)

        '----- Results
        ToolBlob.CalcBlobResults()
        ToolBlob.CalcExtremeBlobs()
        sNumBlobs = ToolBlob.NumberOfBlobs

        If sNumBlobs > 0 Then
            lblBlobs.Visible = True
            lblBlobs.Text = "Blobs: " & Format(ToolBlob.BlobCount, "0")
            cboBlobs.Items.Clear()
            cboBlobs.Visible = True

            'MsgBox("Blobs: " & Format(sNumBlobs, "0"))

            For I = 1 To ToolBlob.BlobCount
                cboBlobs.Items.Add(Format(I, "0"))
            Next I
            cboBlobs.Text = cboBlobs.Items(0)
        End If

    End Sub

    Private Sub cmdCenterGeo_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdCenterGeo.Click

        Dim iX As Integer, iY As Integer

        ToolGeometricModel.GetPosition(iX, iY)
        ToolGeometricModel.SetOrigin(iX, iY)

    End Sub

    Private Sub cmdCenterPattern_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim iX As Integer, iY As Integer

        ToolPatternMatch.GetPosition(iX, iY)
        ToolPatternMatch.SetOrigin(iX, iY)

    End Sub


    Private Sub cmdXHair_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdXhair.Click

        Static Dim bStatus As Boolean = False
        Dim XHairPen As Pen = Pens.Red
        Dim p1 As New System.Drawing.Point
        Dim p2 As New System.Drawing.Point
        Dim X As Integer = 0, Y As Integer = 0

        If bStatus = True Then
            ToolBlob.EraseResults() 'DGDG move this to a ClearGraphics Funtion
            bStatus = False
            Exit Sub
        End If
        X = pnlImage.Width / 2
        Y = pnlImage.Height / 2

        p1.X = X - 50
        p1.Y = Y
        p2.X = X + 50
        p2.Y = Y

        pnlImage.CreateGraphics.DrawLine(XHairPen, p1, p2)

        p1.X = X
        p1.Y = Y - 50
        p2.X = X
        p2.Y = Y + 50

        pnlImage.CreateGraphics.DrawLine(XHairPen, p1, p2)

        bStatus = True

        Exit Sub

        'Dim XHairPen As Pen = Pens.Red
        'Dim p1 As New System.Drawing.Point
        'Dim p2 As New System.Drawing.Point

        'XHairPen.Color = Color.LightGreen
        p1.X = 0
        p1.Y = pnlImage.Height / 2
        p2.X = pnlImage.Width
        p2.Y = pnlImage.Height / 2
        pnlImage.CreateGraphics.DrawLine(XHairPen, p1, p2)

        p1.X = pnlImage.Width / 2
        p1.Y = 0
        p2.X = pnlImage.Width / 2
        p2.Y = pnlImage.Height
        pnlImage.CreateGraphics.DrawLine(XHairPen, p1, p2)

    End Sub

    Private Sub cmdLUTPositive_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLUTPositive.Click

        If objImagingCameraSelected.IsContinuousGrab Then
            objImagingCameraSelected.StopContinuousGrab()
            objImageDisplayWindow.PositiveDisplay()
            objImagingCameraSelected.ContinuousGrab()
        Else
            objImageDisplayWindow.PositiveDisplay()
        End If

    End Sub

    Private Sub cmdLUTNegative_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLUTNegative.Click

        If objImagingCameraSelected.IsContinuousGrab Then
            objImagingCameraSelected.StopContinuousGrab()
            objImageDisplayWindow.NegativeDisplay()
            objImagingCameraSelected.ContinuousGrab()
        Else
            objImageDisplayWindow.NegativeDisplay()
        End If

    End Sub

    Private Sub cmdLUTColor_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLUTColor.Click

        If objImagingCameraSelected.IsContinuousGrab Then
            objImagingCameraSelected.StopContinuousGrab()
            objImageDisplayWindow.PseudoColorDisplay()
            objImagingCameraSelected.ContinuousGrab()
        Else
            objImageDisplayWindow.PseudoColorDisplay()
        End If

    End Sub

    Private Sub cmdImageSave_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdImageSave.Click

        Dim sDirectory As String = "C:\VisionDemo\VisionDemo\Images\"
        Dim sExt As String = ".bmp"
        Dim sResponse As String = ""

        sResponse = InputBox("Enter Image File name: ", "Save Image", "")
        If sResponse = "" Then Exit Sub

        objImagingCameraSelected.CameraImage.SaveBmp(sDirectory & sResponse & sExt)

    End Sub

    Private Sub chkAutoThreshold_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles chkAutoThreshold.CheckedChanged

        If chkAutoThreshold.Checked = True Then
            lblBinarizeThreshold.Enabled = False
            numBinarizeThreshold.Enabled = False
        Else
            lblBinarizeThreshold.Enabled = True
            numBinarizeThreshold.Enabled = True
        End If
    End Sub

    Private Sub cmdBinarize_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdBinarize.Click

        Dim iThresholdCondition As Integer = 0

        If cboBinarizePolarity.Text = "White" Then
            iThresholdCondition = ThresholdCondition.Greater
        Else
            iThresholdCondition = ThresholdCondition.Less
        End If

        If chkAutoThreshold.Checked = True Then
            ToolBlob.AutoBinarize(iThresholdCondition)

        Else
            ToolBlob.Binarize(iThresholdCondition, numBinarizeThreshold.Value)

        End If

    End Sub

    Private Sub cboBlobs_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboBlobs.SelectedIndexChanged

        Dim iItem As Integer = Val(cboBlobs.Text)
        Dim lArea As Long = 0
        Dim Centroid As PointF

        lblBlobResults.Visible = True

        '----- Draw results
        ToolBlob.EraseResults()
        ToolBlob.DrawBlobCentroid(iItem - 1)
        ToolBlob.DrawBlobBox(iItem - 1)

        '----- Dispaly values
        lArea = ToolBlob.GetBlobArea(iItem - 1)
        Centroid = ToolBlob.GetBlobCentroid(iItem - 1)

        lblBlobResults.Text = "Blob Results: " & vbCrLf & _
                              "Area: " & Format(lArea * g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat) & vbCrLf & _
                              "Centroid: (" & Format(Centroid.X * g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat) & ", " & Format(Centroid.Y * g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat) & ")"

    End Sub

    Private Sub cmdDisplayAll_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdDisplayAll.Click

        Dim I As Integer = 0

        lblBlobResults.Visible = False

        If ToolBlob.BlobCount = 0 Then Exit Sub

        ToolBlob.EraseResults()

        For I = 0 To ToolBlob.BlobCount - 1
            ToolBlob.DrawBlobCentroid(I)
            ToolBlob.DrawBlobBox(I)
        Next

    End Sub

    Private Sub pnlImage_PaddingChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles pnlImage.PaddingChanged

    End Sub

    Private Sub pnlImage_Paint(ByVal sender As System.Object, ByVal e As System.Windows.Forms.PaintEventArgs) Handles pnlImage.Paint

    End Sub

    Private Sub chkPositionFilter_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles optBottom.CheckedChanged, optLeft.CheckedChanged, optTop.CheckedChanged, optRight.CheckedChanged, _
        optUR.CheckedChanged, optUL.CheckedChanged, optLR.CheckedChanged, optLL.CheckedChanged, optCenter.CheckedChanged, optBiggest.CheckedChanged, optSmallest.CheckedChanged

        Dim iBlobNum As Integer = -1
        Dim TempCheckBox As RadioButton

        '----- Ecit if no blobs
        If ToolBlob.BlobCount = 0 Then Exit Sub

        TempCheckBox = sender

        '----- Exit if box is unchecked
        If TempCheckBox.Checked = False Then Exit Sub

        Select Case TempCheckBox.Name
            Case "optUL" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.UL)
            Case "optUR" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.UR)
            Case "optLL" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.LL)
            Case "optLR" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.LR)
            Case "optCenter" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.Center)
            Case "optBottom" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.Bottom)
            Case "optTop" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.Top)
            Case "optRight" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.Right)
            Case "optLeft" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.Left)
            Case "optSmallest" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.Smallest)
            Case "optBiggest" : iBlobNum = ToolBlob.GetExtremeBlob(BlobPostion.Biggest)
        End Select

        '----- Assign to combo box to display
        cboBlobs.Text = Format(iBlobNum + 1, "0")

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        Dim Point1 As PointF, Point2 As PointF
        Point1.X = 4 : Point1.Y = -2
        Point2.X = 6 : Point2.Y = 5
        CalcLineFromTwoPoints(Point1, Point2)

    End Sub

    Private Sub cmdAdvancedLineRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdRunAdvancedLine.Click

        '----- Assign Tool properties
        Select Case cboAdvancedLinePolarity.Text
            Case "Positive" : ToolAdvancedLine.Polarity = EdgePolarity.Positive
            Case "Negative" : ToolAdvancedLine.Polarity = EdgePolarity.Negative
            Case "Any" : ToolAdvancedLine.Polarity = EdgePolarity.Any
        End Select

        If IsNumeric(cboAdvancedLineSelection.Text) Then
            ToolAdvancedLine.EdgeSelection = Val(cboAdvancedLineSelection.Text)
        ElseIf cboAdvancedLineSelection.Text = "Last" Then
            ToolAdvancedLine.EdgeSelection = EdgeSelection.Last
        ElseIf cboAdvancedLineSelection.Text = "Disable" Then
            ToolAdvancedLine.EdgeSelection = EdgeSelection.Disable
        End If

        Select Case cboAdvancedLineThresholdMode.Text
            Case "Disable" : ToolAdvancedLine.ThresholdMode = ThresholdMode.Disable
            Case "Low" : ToolAdvancedLine.ThresholdMode = ThresholdMode.Low
            Case "Medium" : ToolAdvancedLine.ThresholdMode = ThresholdMode.Medium
            Case "High" : ToolAdvancedLine.ThresholdMode = ThresholdMode.High
            Case "Very High" : ToolAdvancedLine.ThresholdMode = ThresholdMode.VeryHigh
        End Select

        '----- Other Edge Params
        ToolAdvancedLine.AngleRange = Val(txtAdvancedLineAngleRange.Text)
        ToolAdvancedLine.EdgeSmoothness = Val(txtAdvancedLineSmoothness.Text)
        ToolAdvancedLine.MaxLineFitDistance = Val(txtAdvancedLineMaxFitDist.Text)
        ToolAdvancedLine.EdgeExtractionScale = Val(txtAdvancedLineScale.Text)

        ToolAdvancedLine.Execute()

        lblResultsAdvancedLine.Text = Format(ToolAdvancedLine.LineResultA * g_dPixelSize, g_sUnitsFormat) & "x + " & _
                                    Format(ToolAdvancedLine.LineResultB * g_dPixelSize, g_sUnitsFormat) & "y + " & _
                                    Format(ToolAdvancedLine.LineResultC * g_dPixelSize, g_sUnitsFormat) & " = 0" & vbCrLf & _
                                    "Angle: " & Format(ToolAdvancedLine.LineWidthDeltaAngle, "0.0000")
        lblResultsAdvancedLine.Visible = True

    End Sub

    Private Sub cboSimpleLineOrientation_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboSimpleLineOrientation.SelectedIndexChanged

        '----- Assign Tool direction
        Select Case cboSimpleLineOrientation.Text
            Case "Vertical" : ToolSimpleLine.Orientation = Orientation.Vertical
            Case "Horizontal" : ToolSimpleLine.Orientation = Orientation.Horizontal
        End Select

    End Sub

    Private Sub cboAdvancedLineDirection_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cboAdvancedLineDirection.SelectedIndexChanged

        '----- Assign Tool direction
        Select Case cboAdvancedLineDirection.Text
            Case "South" : ToolAdvancedLine.Orientation = ScanDirection.South
            Case "East" : ToolAdvancedLine.Orientation = ScanDirection.East
            Case "North" : ToolAdvancedLine.Orientation = ScanDirection.North
            Case "West" : ToolAdvancedLine.Orientation = ScanDirection.West
        End Select

    End Sub

    Private Sub cmdSimpleLineRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpleLineRun.Click

        '----- Assign Tool properties
        Select Case cboSimpleLinePolarity.Text
            Case "Positive" : ToolSimpleLine.Polarity = EdgePolarity.Positive
            Case "Negative" : ToolSimpleLine.Polarity = EdgePolarity.Negative
            Case "Any" : ToolSimpleLine.Polarity = EdgePolarity.Any
        End Select

        ToolSimpleLine.Execute()

        lblSimpleLineResults.Text = Format(ToolSimpleLine.LineResultA * g_dPixelSize, g_sUnitsFormat) & "x + " & _
                                    Format(ToolSimpleLine.LineResultB * g_dPixelSize, g_sUnitsFormat) & "y + " & _
                                    Format(ToolSimpleLine.LineResultC * g_dPixelSize, g_sUnitsFormat) & " = 0" & vbCrLf & _
                                    "Angle: " & Format(ToolSimpleLine.LineWidthDeltaAngle, "0.0000")
        lblSimpleLineResults.Visible = True

    End Sub

    Private Sub cmdAdvancedLineWidth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdvancedLineWidth.Click

        '----- Assign Tool properties
        Select Case cboAdvancedLinePolarity.Text
            Case "Positive" : ToolAdvancedLine.Polarity = EdgePolarity.Positive
            Case "Negative" : ToolAdvancedLine.Polarity = EdgePolarity.Negative
            Case "Any" : ToolAdvancedLine.Polarity = EdgePolarity.Any
        End Select

        '----- Edge Number
        If IsNumeric(cboAdvancedLineSelection.Text) Then
            ToolAdvancedLine.EdgeSelection = Val(cboAdvancedLineSelection.Text)
        ElseIf cboAdvancedLineSelection.Text = "Last" Then
            ToolAdvancedLine.EdgeSelection = EdgeSelection.Last
        ElseIf cboAdvancedLineSelection.Text = "Disable" Then
            ToolAdvancedLine.EdgeSelection = EdgeSelection.Disable
        End If

        '----- Other Edge Params
        ToolAdvancedLine.AngleRange = Val(txtAdvancedLineAngleRange.Text)
        ToolAdvancedLine.EdgeSmoothness = Val(txtAdvancedLineSmoothness.Text)
        ToolAdvancedLine.MaxLineFitDistance = Val(txtAdvancedLineMaxFitDist.Text)
        ToolAdvancedLine.EdgeExtractionScale = Val(txtAdvancedLineScale.Text)

        '----- Threshold Mode
        Select Case cboAdvancedLineThresholdMode.Text
            Case "Disable" : ToolAdvancedLine.ThresholdMode = ThresholdMode.Disable
            Case "Low" : ToolAdvancedLine.ThresholdMode = ThresholdMode.Low
            Case "Medium" : ToolAdvancedLine.ThresholdMode = ThresholdMode.Medium
            Case "High" : ToolAdvancedLine.ThresholdMode = ThresholdMode.High
            Case "Very High" : ToolAdvancedLine.ThresholdMode = ThresholdMode.VeryHigh
        End Select

        '----- Run Tool
        ToolAdvancedLine.ExecuteLineWidth()

        '----- Display Results
        lblResultsAdvancedLine.Text = "Distance: " & Format(ToolAdvancedLine.LineWidthDistance * g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat) & vbCrLf & "Angle:       " & Format(ToolAdvancedLine.LineWidthDeltaAngle, "0.000000")
        lblResultsAdvancedLine.Visible = True

    End Sub

    Private Sub cmdSimpleLineWidth_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpleLineWidth.Click

        If cboSimpleLinePolarity.Text = "Any" Then
            MsgBox("Cannot measure Line Width with polarity set to Any.", MessageBoxIcon.Exclamation, "Edge Polarity Error")
            Exit Sub
        End If

        '----- Assign Tool properties
        Select Case cboSimpleLinePolarity.Text
            Case "Positive" : ToolSimpleLine.Polarity = EdgePolarity.Positive
            Case "Negative" : ToolSimpleLine.Polarity = EdgePolarity.Negative
            Case "Any" : ToolSimpleLine.Polarity = EdgePolarity.Any
        End Select

        ToolSimpleLine.ExecuteLineWidth()

        '----- Display Results
        lblSimpleLineResults.Text = "Distance: " & Format(ToolSimpleLine.LineWidthDistance * g_dPixelSize * g_dUnitsFactor, g_sUnitsFormat) & vbCrLf & "Angle:       " & Format(ToolSimpleLine.LineWidthDeltaAngle, "0.000000")
        lblSimpleLineResults.Visible = True

    End Sub

    Private Sub cmdTrainPatternMatchFinder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

        Dim sFileName As String = ""
        Dim sDirectory As String = "C:\VisionDemo\VisionDemo\Pattern Match Models\"
        sFileName = InputBox("Enter File Name: ", "Pattern Match FIle Name", "")
        If sFileName = "" Then Exit Sub

        ToolPatternMatch.TrainModel()
        ToolPatternMatch.SaveBMPImage(sDirectory & sFileName & ".bmp")

    End Sub

    Private Sub cmdSize_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSize.Click

        Dim iX As Integer = -1, iY As Integer = -1

        ToolSimpleCircle.SetSize(Val(txtX.Text), Val(txtY.Text))
        ToolSimpleLine.GetSize(iX, iY)
        MsgBox("X: " & Format(iX, "0") & "  " & "Y: " & Format(iY, "0"))

    End Sub

    Private Sub cmdSimpleCircleRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSimpleCircleRun.Click

        Dim ptCenter As PointF, dRadius As Double

        '----- Assign MaxFit Distance
        If IsNumeric(txtSimpleCircleMaxFitDistance.Text) Then
            ToolSimpleCircle.MaxFitDistance = Val(txtSimpleCircleMaxFitDistance.Text)
        Else
            ToolSimpleCircle.MaxFitDistance = 10
        End If

        '----- Assign line Polarity
        Select Case cboSimpleCirclePolarity.Text
            Case "Positive" : ToolSimpleCircle.Polarity = EdgePolarity.Positive
            Case "Negative" : ToolSimpleCircle.Polarity = EdgePolarity.Negative
            Case "Any" : ToolSimpleCircle.Polarity = EdgePolarity.Any
        End Select

        '----- Execute Tool
        ToolSimpleCircle.Execute()

        '----- Get and siaplay results
        ptCenter = ToolSimpleCircle.Center
        dRadius = ToolSimpleCircle.Radius
        lblSimpleCircleResults.Text = "Center - X: " & Format(ptCenter.X * g_dUnitsFactor, g_sUnitsFormat) & vbCrLf & _
                              "Center - Y: " & Format(ptCenter.Y * g_dUnitsFactor, g_sUnitsFormat) & vbCrLf & _
                              "Radius:      " & Format(dRadius * g_dUnitsFactor, g_sUnitsFormat)
        lblSimpleCircleResults.Visible = True

    End Sub

    
    Private Sub cmdAdvancedCirleRun_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdAdvancedCirleRun.Click

        ToolAdvancedCircle.EdgeAngleRange = Val(txtAdvancedCircleEdgeAngleRange.Text)
        ToolAdvancedCircle.Smoothness = Val(txtAdvancedCircleSmoothness.Text)
        ToolAdvancedCircle.EdgeExctractionScale = Val(txtAdvancedCircleEdgeExtractionScale.Text)
        ToolAdvancedCircle.MaxFitDistance = Val(txtAdvancedCircleMaxLineFitDistance.Text)

        Select Case cboAdvancedCircleThresholdMode.Text
            Case "Disable"
                ToolAdvancedCircle.ThresholdMode = ThresholdMode.Disable
            Case "Low"
                ToolAdvancedCircle.ThresholdMode = ThresholdMode.Low
            Case "Medium"
                ToolAdvancedCircle.ThresholdMode = ThresholdMode.Medium
            Case "High"
                ToolAdvancedCircle.ThresholdMode = ThresholdMode.High
            Case "Very High"
                ToolAdvancedCircle.ThresholdMode = ThresholdMode.VeryHigh
        End Select

        ToolAdvancedCircle.IsCircleFit = chkAdvancedCircleFit.Checked

        ToolAdvancedCircle.Execute()

    End Sub

    Private Sub cmdTrainGeometricModelFinder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTrainGeometricModelFinder.Click

        Dim sFileName As String = InputBox("Enter the model name: ", "Save Model", "")

        '------ Exit if cancelled or empty
        If sFileName = "" Then Exit Sub

        ToolGeometricModel.TrainModel()
        ToolGeometricModel.SaveModel(sFileName)

        LoadGeometricModelFiles()
        lblGeoModelName.Text = "Geometric Models" & vbCrLf & "Loaded: " & sFileName

    End Sub

    Public Sub LoadGeometricModelFiles()

        Dim I As Integer = 0
        Dim sTemp As String = ""
        Dim sFiles() As String = GetFiles("C:\VisionDemo\VisionDemo\Images\", "*.geo")

        lstGeoFiles.Items.Clear()

        '----- Load Images
        For I = 0 To sFiles.Count - 1
            sTemp = Path.GetFileNameWithoutExtension(sFiles(I))
            lstGeoFiles.Items.Add(sTemp)
        Next

    End Sub

    Public Sub LoadPatternModelFiles()

        Dim I As Integer = 0
        Dim sTemp As String = ""
        Dim sFiles() As String = GetFiles("C:\VisionDemo\VisionDemo\Images\", "*.pat")

        lstPatFiles.Items.Clear()

        '----- Load Images
        For I = 0 To sFiles.Count - 1
            sTemp = Path.GetFileNameWithoutExtension(sFiles(I))
            lstPatFiles.Items.Add(sTemp)
        Next

    End Sub
    Private Sub cmdLoadGeometricModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadGeometricModel.Click

        Dim sPathName As String = "C:\VisionDemo\VisionDemo\Images\"

        If lstGeoFiles.SelectedItem <> "" Then
            ToolGeometricModel.LoadModel(sPathName & lstGeoFiles.SelectedItem & ".geo")
            'MsgBox("File: " & lstGeoFiles.SelectedItem)
        End If

        lblGeoModelName.Text = "Geometric Models" & vbCrLf & "Loaded: " & lstGeoFiles.SelectedItem

    End Sub

    Private Sub cmdSetFullImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdGeoSetFullImage.Click

        ToolGeometricModel.SetSize(100, 100)
        ToolGeometricModel.SetPosition(g_iImageSizeX / 2, g_iImageSizeY / 2)
        ToolGeometricModel.SetSize(g_iImageSizeX - 20, g_iImageSizeY - 20)

    End Sub

    Private Sub cmdSearchGeometricModelFinder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchGeometricModelFinder.Click

        Dim I As Integer = 0
        Dim iNumFound As Integer = -1
        Dim dTempX As Double = -1, dTempY As Double = -1, dTempScore As Double = -1

        '----- Init
        lblGeoResults.Text = "Results: "
        ToolGeometricModel.EraseResults()
        lstGeoResults.Items.Clear()

        '----- Assign Values
        ToolGeometricModel.NumTargetToFind(Val(txtGeoMaxNum.Text))
        ToolGeometricModel.MatchThreshold(Val(txtGeoMatchThreshold.Text))

        '----- Search
        ToolGeometricModel.SearchModel()

        '----- Display Results
        iNumFound = ToolGeometricModel.NumMatchesFound
        lblGeoResults.Text = "Results: " & Format(iNumFound, "0")
        For I = 0 To iNumFound - 1
            dTempX = ToolGeometricModel.ResultPositionX(I)
            dTempY = ToolGeometricModel.ResultPositionY(I)
            dTempScore = ToolGeometricModel.ResultScore(I)
            lstGeoResults.Items.Add(Format(I + 1, "0") & " -  X: " & Format(dTempX, "0") & ", Y: " & Format(dTempY, "0") & " -- " & Format(dTempScore, "0.0"))
        Next I

    End Sub

    Private Sub lstGeoFiles_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstGeoFiles.DoubleClick
        cmdLoadGeometricModel.PerformClick()
    End Sub

    Private Sub cmdPatSetFullImage_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdPatSetFullImage.Click

        ToolPatternMatch.SetSize(100, 100)
        ToolPatternMatch.SetPosition(g_iImageSizeX / 2, g_iImageSizeY / 2)
        ToolPatternMatch.SetSize(g_iImageSizeX - 20, g_iImageSizeY - 20)

    End Sub

    Private Sub cmdTrainPatternModelFinder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdTrainPatternModelFinder.Click

        Dim sFileName As String = InputBox("Enter the model name: ", "Save Model", "")

        '------ Exit if cancelled or empty
        If sFileName = "" Then Exit Sub

        ToolPatternMatch.TrainModel()
        ToolPatternMatch.SaveModel(sFileName)

        LoadPatternModelFiles()
        lblPatModelName.Text = "Geometric Models" & vbCrLf & "Loaded: " & sFileName

    End Sub

    Private Sub cmdSearchPatternModelFinder_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdSearchPatternModelFinder.Click

        Dim I As Integer = 0
        Dim iNumFound As Integer = -1
        Dim dTempX As Double = -1, dTempY As Double = -1, dTempScore As Double = -1

        '----- Init
        lblPatResults.Text = "Results: "
        ToolPatternMatch.EraseResults()
        lstPatResults.Items.Clear()

        '----- Assign Values
        ToolPatternMatch.NumTargetToFind(Val(txtPatMaxNum.Text))
        ToolPatternMatch.MatchThreshold(Val(txtPatMatchThreshold.Text))

        '----- Search
        ToolPatternMatch.SearchModel()

        '----- Display Results
        iNumFound = ToolPatternMatch.NumMatchesFound
        lblPatResults.Text = "Results: " & Format(iNumFound, "0")
        For I = 0 To iNumFound - 1
            dTempX = ToolPatternMatch.ResultPositionX(I)
            dTempY = ToolPatternMatch.ResultPositionY(I)
            dTempScore = ToolPatternMatch.ResultScore(I)
            lstPatResults.Items.Add(Format(I + 1, "0") & " -  X: " & Format(dTempX, "0") & ", Y: " & Format(dTempY, "0") & " -- " & Format(dTempScore, "0.0"))
        Next I

    End Sub

    Private Sub cmdLoadPatternModel_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cmdLoadPatternModel.Click

        Dim sPathName As String = "C:\VisionDemo\VisionDemo\Images\"

        If lstPatFiles.SelectedItem <> "" Then
            ToolPatternMatch.LoadModel(sPathName & lstPatFiles.SelectedItem & ".pat")
            'MsgBox("File: " & lstPatFiles.SelectedItem)
        End If

        lblPatModelName.Text = "Geometric Models" & vbCrLf & "Loaded: " & lstPatFiles.SelectedItem

    End Sub

    Private Sub lstPatFiles_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles lstPatFiles.DoubleClick
        cmdLoadPatternModel.PerformClick()
    End Sub

    Private Sub scrLightLevel_Scroll(ByVal sender As System.Object, ByVal e As System.Windows.Forms.ScrollEventArgs) Handles scrLightLevel.Scroll

    End Sub

    Private Sub scrLightLevel_ValueChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles scrLightLevel.ValueChanged

        comLightController.Write("M:" & scrLightLevel.Value.ToString & ",0@")
        lblLightLevel.Text = "Light Level: " & scrLightLevel.Value.ToString

    End Sub
End Class

