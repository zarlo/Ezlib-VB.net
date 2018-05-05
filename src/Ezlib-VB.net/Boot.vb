Imports EzLib
Imports System.Windows.Forms

Module Boot

    Sub Main()

        Dim settings = New EzLibSettings With {.AntiDebug = False, .AntiSuspend = False, .AntiDump = False, .ProcessShield = True, .RealTimeInterval = 2}
        Dim _Initialize = New Initialize("JiThi7WwND", "1.0.0", settings)
        Application.Run(New Forms.AuthenticationForm(New Form()))


    End Sub

End Module
