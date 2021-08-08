Imports System

Module Program
    Sub Main(args As String())
    'Con el objeto de conseguir fondos para su viaje de egresados, los alumnos de 5to. Año organizaron un baile de beneficencia. El precio de las entradas es de $250 para los varones y de $200 para las mujeres. Si la venta es Anticipada (A) se realiza un descuento del 20% al valor de la entrada.Desarrolle un algoritmo que solicite por teclado el sexo del alumno y el tipo de venta e informe por pantalla el sexo y el importe a pagar. Además deberá mostrar la cantidad de varones y mujeres que compraron entradas y la recaudación total. 
        Dim entrada_varon As Integer = 250
        Dim entrada_mujer As Integer = 200
        Dim varones As integer = 0
        Dim mujeres As integer = 0
        Dim alumno As integer
        Dim cant_entr_varones As integer = 0
        Dim cant_entr_mujeres As integer = 0
        Dim total_recaudacion As integer = 0
        Console.WriteLine("Sexo Alumno: ")
        Console.WriteLine("(V) Varon - (M) Mujer - (0) Salir")
        alumno = Console.ReadLine()
        While alumno <> 0
            If alumno = "v" Then
                varones += 1
                    Console.WriteLine(varones)
            End If
            If alumno = "m" Then
                mujeres += 1  
                Console.WriteLine(mujeres)
            End If
        End While
    End Sub
End Module
