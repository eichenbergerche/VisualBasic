Imports System

Module Program
    Sub Mayor()
        aux = 0
        For i = 1 To 6
            If nota(i) > aux Then
                aux = nota(i)
            End If
        Next
        Console.WriteLine("La mayor nota es " & aux)
    End Sub
    Sub Menor()
        aux = 9999
        For i = 1 To 6
            If nota(i) < aux Then
                aux = nota(i)
                posicion = i
            End If
        Next
        Console.WriteLine("La menor nota es " & aux)
    End Sub

    Sub Promedio()
        For i = 1 To 6
            prome = (n1 + n2 + n3 + n4 + n5 + n6) / 6
        Next
        Console.WriteLine("El promedio de notas es " & prome)
    End Sub
End Module