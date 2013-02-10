Public Class Graphe_Fenetre
    Public Sub ExecuterDot()
        Shell(Environ("ProgramFiles(x86)") & "\Graphviz 2.28\bin\dot.exe ""D:\Git\RDP\Dot\reaction nucleaire.dot"" -Tpng -o ""D:\Git\RDP\Dot\reaction.png""")
    End Sub
End Class