Public Class GeometricModelTool

    Inherits ToolBase

    Public Function ResultPositionX(ByVal iTargetNum As Integer) As Double

        Dim dPositionX As Double

        dPositionX = tlGeometricModelFinder.ResultXPositions(iTargetNum)
        Return dPositionX

    End Function
    Public Function ResultPositionY(ByVal iTargetNum As Integer) As Double

        Dim dPositionY As Double

        dPositionY = tlGeometricModelFinder.ResultYPositions(iTargetNum)
        Return dPositionY

    End Function
    Public Function ResultScore(ByVal iTargetNum As Integer) As Double

        Dim dScore As Double

        dScore = tlGeometricModelFinder.ResultScores(iTargetNum)
        Return dScore

    End Function

    Public Sub EraseResults()
        tlGeometricModelFinder.EraseResults(objImageDisplayWindow)
    End Sub
    Public ReadOnly Property NumMatchesFound() As Integer
        Get
            Return tlGeometricModelFinder.NumberOfResult
        End Get

    End Property

    Public Sub MatchThreshold(ByVal iThreshold As Integer)

        tlGeometricModelFinder.CertaintyThreshold = iThreshold

    End Sub
    Public Sub NumTargetToFind(ByVal iTargets As Integer)

        tlGeometricModelFinder.NumberOfTarget = iTargets

    End Sub

    Public Sub SearchModel()
        tlGeometricModelFinder.EraseResults(objImageDisplayWindow)
        tlGeometricModelFinder.Search(objImagingCameraSelected.CameraImage)
        tlGeometricModelFinder.DrawResultPositions(objImageDisplayWindow, ToolColor.Red)
        tlGeometricModelFinder.DrawResultScores(objImageDisplayWindow, ToolColor.Red)

        '_geometricModelFinderTool.EraseResults(_imageDisplayWindow);
        '   _geometricModelFinderTool.Search(_imagingCameraSelected.CameraImage);
        '   _geometricModelFinderTool.DrawResultPositions(_imageDisplayWindow, ImagingEnumeration.Color.DarkGreen);
        '   _geometricModelFinderTool.DrawResultScores(_imageDisplayWindow, ImagingEnumeration.Color.DarkGreen);
    End Sub
    Public Sub LoadModel(ByVal sFileName As String)

        tlGeometricModelFinder.LoadTool(sFileName)

    End Sub

    Public Sub TrainModel()

        tlGeometricModelFinder.TrainModel(objImagingCameraSelected.CameraImage)

    End Sub

    Public Sub SaveModel(ByVal sFileName As String)
        'Note - only the file name is required, the path is hard coded

        Dim sPathName As String = "c:\VisionDemo\VisionDemo\Images\"

        'tlGeometricModelFinder.SaveModelBmpImage(sPathName & sFileName & ".bmp")
        tlGeometricModelFinder.SaveTool(sPathName & sFileName & ".geo")

    End Sub

    Public Sub SetOrigin(ByVal X As Integer, ByVal Y As Integer)

        Dim TempPoint As Point
        TempPoint.X = X
        TempPoint.Y = Y

        tlGeometricModelFinder.Origin = TempPoint
        tlGeometricModelFinder.DrawTool(objImageDisplayWindow)

    End Sub

    Public Sub New()

        '----- Set some properties that are not brought to the user
        tlGeometricModelFinder.Title = ""
        tlGeometricModelFinder.ToolColor = ToolColor.Red

    End Sub

End Class
