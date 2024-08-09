Module Module1

    Sub Main()

        Console.Write("Por favor, ingresa un número entero: ")
        Dim numero As Integer = Integer.Parse(Console.ReadLine())


        For i As Integer = 1 To 5
            Dim siguienteNumero As Integer = numero + i


            Dim tipo As String
            If siguienteNumero Mod 2 = 0 Then
                tipo = "par"
            Else
                tipo = "impar"
            End If


            Console.WriteLine(siguienteNumero & " es " & tipo)
        Next


        Console.WriteLine("Presiona cualquier tecla para salir")
        Console.ReadKey()
    End Sub

End Module
