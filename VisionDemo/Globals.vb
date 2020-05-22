Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Drawing
Imports System.IO
Imports System.Windows.Forms
Imports ii
Imports ii.Tools


Module Globals

    '----- Frame Grabber

    Public objImagingBoard As ImagingBoard
    Public objImagingCamera0 As ImagingCamera
    Public objImagingCamera1 As ImagingCamera
    Public objImagingCameraSelected As ImagingCamera
    Public objImageDisplayWindow As ImagingDisplayWindow

    Public objImaging As New Imaging

    '----- Tools
    Public tlPatternMatchFinder As New PatternMatchFinderTool
    Public ToolPatternMatch As New PatternMatchTool

    Public tlGeometricModelFinder As New GeometricModelFinderTool
    Public ToolGeometricModel As New GeometricModelTool

    Public tlBlob As New BlobTool
    Public ToolBlob As New BlobCountTool

    Public tlLine As New LineTool
    Public ToolSimpleLine As New SimpleLineTool

    Public tlMetrologyLine As New MetrologyLineTool
    Public ToolAdvancedLine As New AdvancedLineTool

    Public tlCircle As New CircleTool
    Public ToolSimpleCircle As New SimpleCircleTool

    Public tlMetrologyCircle As New MetrologyCircleTool
    Public ToolAdvancedCircle As New AdvancedCircleTool

    Public ToolMicrometer As New MicrometerTool

    Public g_iActiveTool As Integer = TOOL_NONE
    Public g_iToolLocation As Integer = SelectTool.None

    Public g_sUnits As String = "Inch"
    Public g_sUnitsFormat As String = "0.000000"
    Public g_dUnitsFactor As Double = 1

    Public g_dPixelSize As Double = 1

    Public g_iImageSizeX As Double = 1
    Public g_iImageSizeY As Double = 1

End Module
