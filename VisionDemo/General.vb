Imports Microsoft.Win32

Module General

    Public Sub SaveLoadRegistry(ByVal iAction As Integer)

        Dim sTemp As String = ""

        Select Case iAction
            Case FILE_SAVE
                Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Vision Demo", "Units", g_sUnits)
                Registry.SetValue("HKEY_CURRENT_USER\SOFTWARE\Vision Demo", "Pixel Size", Format(g_dPixelSize, "0.00000"))

            Case FILE_LOAD
                g_sUnits = Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Vision Demo", "Units", "Inch")
                g_dPixelSize = Convert.ToDouble(Registry.GetValue("HKEY_CURRENT_USER\SOFTWARE\Vision Demo", "Pixel Size", "1"))

        End Select
    End Sub
End Module
