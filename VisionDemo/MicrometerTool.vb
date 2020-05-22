Public Class MicrometerTool

    Inherits ToolBase

    Private m_bVisible As Boolean = False
    Private m_Xhair1 As PointF, m_XHair2 As PointF

    Public Sub New()

        m_Xhair1.X = 100 : m_Xhair1.Y = 100
        m_XHair2.X = 500 : m_XHair2.Y = 500

    End Sub
    Public Sub Results(ByRef dX As Double, ByRef dY As Double, ByRef dDistance As Double)

        dX = Math.Abs(m_Xhair1.X - m_XHair2.X)
        dY = Math.Abs(m_Xhair1.Y - m_XHair2.Y)
        dDistance = Distance

    End Sub
    Public ReadOnly Property Distance() As Double
        Get

            Dim dX As Double = 0, dY As Double = 0, dDistance As Double = 0

            dX = m_Xhair1.X - m_XHair2.X
            dY = m_Xhair1.Y - m_XHair2.Y

            dDistance = Math.Sqrt((dX ^ 2) + (dY ^ 2))
            Return dDistance

        End Get

    End Property

    Public Shadows Property Visible() As Boolean

        Get
            Return m_bVisible
        End Get
        Set(ByVal bVisible As Boolean)

            If bVisible Then
                DrawXHair(m_Xhair1.X, m_Xhair1.Y)
                DrawXHair(m_XHair2.X, m_XHair2.Y)
                DrawLine(m_Xhair1.X, m_Xhair1.Y, m_XHair2.X, m_XHair2.Y)
            Else
                ToolBlob.EraseResults()
            End If

            m_bVisible = bVisible

        End Set

    End Property

    Public Shadows Sub SetPosition(ByVal Xhair1 As PointF, ByVal XHair2 As PointF)

        '----- Assign XHairs and draw
        Visible = False
        m_Xhair1.X = Xhair1.X : m_Xhair1.Y = Xhair1.Y
        m_XHair2.X = XHair2.X : m_XHair2.Y = XHair2.Y
        Visible = True

    End Sub

    Public Shadows Sub GetPosition(ByRef Xhair1 As PointF, ByRef XHair2 As PointF)

        '----- Assign XHairs and draw
        Xhair1.X = m_Xhair1.X : Xhair1.Y = m_Xhair1.Y
        XHair2.X = m_XHair2.X : XHair2.Y = m_XHair2.Y

    End Sub

    Public Sub Dispose()
        ToolMicrometer = Nothing
    End Sub

End Class
