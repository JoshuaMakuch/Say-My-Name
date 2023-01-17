'Joshua Makuch
'RCET0265
'Spring 2023
'Say My Name
'https://github.com/JoshuaMakuch/Say-My-Name

Imports System

Module Program
    Sub Main(args As String())
        Console.WriteLine("Hello operator, what is your name?")
        Dim UsrName As String = Console.ReadLine()
        Console.WriteLine($"Welcome, {UsrName}!")
    End Sub
End Module
