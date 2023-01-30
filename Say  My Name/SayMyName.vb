'Joshua Makuch
'RCET0265
'Spring 2023
'Say My Name
'https://github.com/JoshuaMakuch/Say-My-Name

Option Strict On 'Included Options
Option Explicit On

Imports System

Module SayMyName
    Sub Main(args As String())

        Dim userName As String 'Moved initialization of varible to appropriate spot and renamed

        Console.WriteLine("Hello operator, what is your name?")
        userName = Console.ReadLine()
        Console.WriteLine($"Welcome, {userName}!")

    End Sub
End Module
