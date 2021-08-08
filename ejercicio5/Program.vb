Imports System

Module Program
    Sub Main(args As String())
        dim vector(6) as integer
        dim MAYOR, MENOR as integer
        dim a as integer
MAYOR=vector(0)
MENOR=vector(0)
for a=1 to 6
if vector(a)>MAYOR then MAYOR=vector(a)
if vector(a)<MENOR then MENOR=Vector(a)
next
msgbox "MAYOR: " & MAYOR & "|||||" & " MENOR: " & MENOR
    End Sub
End Module
