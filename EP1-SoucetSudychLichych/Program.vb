Imports System

Module Program
    Sub Main()

        Console.Write("Zadejte celkov� po�et ��sel")
        Dim totalNumbers As Integer = Integer.Parse(Console.ReadLine())

        Dim numbers(totalNumbers - 1) As Integer

        For i As Integer = 0 To totalNumbers - 1
            Console.Write("Zadejte ��slo" & (i + 1) & ": ")
        Next
        Console.WriteLine("Zadan� ��sla jsou: ")
        For Each num As Integer In numbers
            Console.WriteLine(num)
        Next
        Console.WriteLine("Stiskn�te libovolnou kl�vesu pro ukon�en�.")
        Console.ReadKey()
    End Sub
End Module
