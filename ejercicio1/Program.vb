Imports System

Module Program
    Sub Main(args As String())
    'Una agencia de turismo registra los siguientes datos de los pasajeros: DNI, Apellido y Nombre, Destino (1-Nacionales, 2-Extranjeros), Precio del viaje, Forma de pago (1-Efectivo, 2-Tarjeta).

    'Escribir en aplicación consola de Visual Basic, el código para obtener la siguiente información:

    'a. Datos de los pasajeros que viajaron a destinos extranjeros y pagaron con tarjeta.

    'b. Total de importe facturado en concepto de viajes al extranjero y porcentaje de esta recaudación con respecto al total de importes recaudados por la agencia.

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

