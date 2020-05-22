Imports System.Drawing

Public Class PatternMatchTool

    Inherits ToolBase
    Public Function ResultPositionX(ByVal iTargetNum As Integer) As Double

        Dim dPositionX As Double

        dPositionX = tlPatternMatchFinder.ResultXPositions(iTargetNum)
        Return dPositionX

    End Function
    Public Function ResultPositionY(ByVal iTargetNum As Integer) As Double

        Dim dPositionY As Double

        dPositionY = tlPatternMatchFinder.ResultYPositions(iTargetNum)
        Return dPositionY

    End Function
    Public Function ResultScore(ByVal iTargetNum As Integer) As Double

        Dim dScore As Double

        dScore = tlPatternMatchFinder.ResultScores(iTargetNum)
        Return dScore

    End Function

    Public Sub EraseResults()
        tlPatternMatchFinder.EraseResults(objImageDisplayWindow)
    End Sub
    Public ReadOnly Property NumMatchesFound() As Integer
        Get
            Return tlPatternMatchFinder.NumberOfResult
        End Get

    End Property

    Public Sub MatchThreshold(ByVal iThreshold As Integer)

        tlPatternMatchFinder.CertaintyThreshold = iThreshold

    End Sub
    Public Sub NumTargetToFind(ByVal iTargets As Integer)

        tlPatternMatchFinder.NumberOfTarget = iTargets

    End Sub

    Public Sub SearchModel()
        tlPatternMatchFinder.EraseResults(objImageDisplayWindow)
        tlPatternMatchFinder.Search(objImagingCameraSelected.CameraImage)
        tlPatternMatchFinder.DrawResultPositions(objImageDisplayWindow, ToolColor.Green)
        tlPatternMatchFinder.DrawResultScores(objImageDisplayWindow, ToolColor.Green)
    End Sub

    Public Sub LoadModel(ByVal sFileName As String)

        tlPatternMatchFinder.LoadTool(sFileName)

    End Sub

    Public Sub TrainModel()

        tlPatternMatchFinder.TrainModel(objImagingCameraSelected.CameraImage)

    End Sub

    Public Sub SaveModel(ByVal sFileName As String)
        'Note - only the file name is required, the path is hard coded

        Dim sPathName As String = "c:\VisionDemo\VisionDemo\Images\"

        'tlGeometricModelFinder.SaveModelBmpImage(sPathName & sFileName & ".bmp")
        tlPatternMatchFinder.SaveTool(sPathName & sFileName & ".pat")

    End Sub

    Public Sub SaveBMPImage(ByVal sFileName As String)

        tlPatternMatchFinder.SaveModelBmpImage(sFileName)

    End Sub

    Public Sub SetOrigin(ByVal X As Integer, ByVal Y As Integer)

        Dim TempPoint As Point
        TempPoint.X = X
        TempPoint.Y = Y

        tlPatternMatchFinder.Origin = TempPoint
        tlPatternMatchFinder.DrawTool(objImageDisplayWindow)

    End Sub
    
    Public Sub New()

    End Sub
End Class
