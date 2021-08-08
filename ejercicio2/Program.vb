Imports System

Module Program
    Sub Main(args As String())
    'Una farmacia desea emitir el ticket de compra, ingresando cantidad y precio del producto, además de un código de producto (P, F, L). Diseñe el algoritmo para calcular el valor de la compra, aplicando la bonificación de acuerdo al tipo de producto: P (Perfumería): 5%, F (Farmacia): 10%, L(Limpieza): 15%. Imprimir el importe a pagar, con la leyenda “% bonificado: XX”. 
    Dim producto As integer = 0
        
    Dim categoria As Char 
        While categoria.ToString.ToUpper <> "S"
            Console.WriteLine("Ingrese el precio del producto: ")
            producto = Console.ReadLine()
            Console.write("El precio del producto es: $" & producto)
            Console.WriteLine()
            Console.WriteLine("Elegir la categoria del producto")            
            Console.WriteLine(" (P) Perfumeria")
            Console.WriteLine(" (F) Farmacia")
            Console.WriteLine(" (L) Limpieaza")
            Console.WriteLine(" (S) Salir")
            console.write("Categoria: ")
            categoria = Console.ReadKey.KeyChar
            Console.WriteLine()
            Select Case categoria.ToString.ToUpper
                Case "P"
                Dim prod_perf As integer = producto - producto* 5/100
                    Console.WriteLine("El producto pertenece a Perfumeria y tiene un 5% off, el monto total a pagar es $" & prod_perf)
                    Console.WriteLine()
                Case "F"
                Dim prod_farm As integer = producto - producto* 10/100
                    Console.WriteLine("El producto pertenece a Farmacia y tiene un 10% off, el monto total a pagar es $" & prod_farm)
                    Console.WriteLine()
                Case "L"
                Dim prod_limp As integer = producto - producto* 15/100
                    Console.WriteLine("El producto pertenece a Limpieza y tiene un 15% off, el monto total a pagar es $" & prod_limp)
                    Console.WriteLine()
                Case "S"
                    Console.WriteLine("Gracias por elegirnos")
                Case Is <> "S"
                    Console.WriteLine("Elija una categoria por favor")
                    
            End Select
        End While

    End Sub
End Module
