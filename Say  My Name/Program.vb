Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello operator, what is your name?")
        Dim UsrName As String = Console.ReadLine()
        Console.WriteLine($"Welcome, {UsrName}!")
    End Sub
End Module
