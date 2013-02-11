Public Class Graphe_Fenetre
    Public Sub ExecuterDot()
        If System.IO.File.Exists(Environ("TMP") & "\RDP.jpg") Then
            System.IO.File.Delete(Environ("TMP") & "\RDP.jpg")
        End If
        Dim file As System.IO.FileStream
        file = System.IO.File.Create(Environ("TMP") & "\RDP.jpg")
        file.Close()
        Dim commande As String = Environ("ProgramFiles(x86)") & "\Graphviz 2.28\bin\dot.exe"
        Dim argument As String = Environ("TMP") & "\RDP.dot -Tjpg -o " & Environ("TMP") & "\RDP.jpg"
        Dim graphvizDot As Process = Process.Start(commande, argument)
        graphvizDot.WaitForExit()
    End Sub
    Public Sub ActualiserGraphe()
        PictureBox1.SizeMode = PictureBoxSizeMode.CenterImage
        PictureBox1.Image = Image.FromFile(Environ("TMP") & "\RDP.jpg")
    End Sub
End Class