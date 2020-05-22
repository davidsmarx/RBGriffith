Module Macros

    'Public Const DEFAULT_IMAGE_SIZE_X = 2460            '1920
    'Public Const DEFAULT_IMAGE_SIZE_Y = 2048            '1200
    Public Const DEFAULT_DISPLAY_ZOOM = 0.25

    '----- Vision
    Public Enum BoardProduct
        BoardDefault = 0
        Host = 1
        Gige = 2
        Morphis = 3
        Radient = 4
        RadientCxp = 5
        RadientEvcl = 6
    End Enum

    Public Enum ToolColor
        Black = 1073741824
        DarkRed = 1073741952
        Red = 1073742079
        DarkGreen = 1073774592
        DarkYellow = 1073774720
        Green = 1073807104
        Yellow = 1073807359
        DarkBlue = 1082130432
        DarkMagenta = 1082130560
        DarkCyan = 1082163200
        Gray = 1082163328
        LightGray = 1084530848
        BrightGray = 1086374080
        LightGreen = 1086381248
        LightBlue = 1089522342
        LightWhite = 1089534975
        Blue = 1090453504
        Magenta = 1090453759
        Cyan = 1090518784
        White = 1090519039
    End Enum

    Public Enum SelectTool
        None = 0
        TopBoundary = 1
        BottomBoundary = 2
        LeftBoundary = 3
        RightBoundary = 4
        UpperLeftCorner = 5
        UpperRightCorner = 6
        LowerLeftCorner = 7
        LowerRightCorner = 8
        Center = 9
        Origin = 10
        MicrometerLeft = 11
        MicrometerRight = 12
        CircleInner = 13
        CircleOuter = 14
    End Enum
    Public Enum ThresholdCondition
        InRange = 1
        OutRange = 2
        Equal = 3
        Greater = 5
        Less = 6
        GreaterOrEqual = 7
        LessOrEqual = 8
    End Enum

    Public Enum ScanDirection
        South = 270
        SouthEast = 45
        East = 0
        NorthEast = 135
        North = 90
        NorthWest = 225
        West = 180
        SouthWest = 315
    End Enum

    Enum EdgePolarity
        Any = 0
        Negative = 1
        Positive = 2
    End Enum

    Public Enum EdgeSelection
        Disable = -9999
        Edge1 = 1
        Edge2 = 2
        Edge3 = 3
        Edge4 = 4
        Edge5 = 5
        Edge6 = 6
        Edge7 = 7
        Edge8 = 8
        Edge9 = 9
        Edge10 = 10
        Edge11 = 11
        Edge12 = 12
        Edge13 = 13
        Edge14 = 14
        Edge15 = 15
        Edge16 = 16
        Edge17 = 17
        Edge18 = 18
        Edge19 = 19
        Edge20 = 20
        Last = 536870912
    End Enum

    Public Enum ThresholdMode
        Disable = -9999
        Low = 1
        Medium = 2
        High = 3
        VeryHigh = 4
        UserDefined = 21
    End Enum

    Public Enum BlobPostion
        UL = 1
        UR = 2
        LL = 3
        LR = 4
        Left = 5
        Right = 6
        Top = 7
        Bottom = 8
        Center = 9
        Smallest = 10
        Biggest = 11
    End Enum
    Public Const TOOL_MIN_WIDTH = 50
    Public Const TOOL_MIN_HEIGHT = 50
    Public Const TOOL_NONE = 0

    '----- These are Steve's tools
    Public Const TOOL_SIMPLE_LINE = 1
    Public Const TOOL_ADVANCED_LINE = 2
    Public Const TOOL_PATTERN_MATCH = 3
    Public Const TOOL_GEOMETRIC_MODEL_FINDER = 4
    Public Const TOOL_BLOB = 5
    'Public Const TOOL_LINE_WIDTH = 6
    Public Const TOOL_MICROMETER = 7
    Public Const TOOL_SIMPLE_CIRCLE = 8
    Public Const TOOL_ADVANCED_CIRCLE = 9

    '----- High level stuff
    Public Const HORIZONTAL = 0
    Public Const VERTICAL = 1

    Public Const FILE_SAVE = 0
    Public Const FILE_LOAD = 1

    Public Const NO_ERROR = 0
    Public Const INVALID_PARAMETER = -1


    Public Const MIN_AREA = 10
    Public Const MAX_AREA = 1920 * 1200 + 1

    Public Const RADIANS_TO_DEGREES = 180 / Math.PI

End Module
