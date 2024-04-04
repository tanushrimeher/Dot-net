Imports System

Module Module1
    Sub Main()
        Dim arr() As Integer = {10, 8, 15, 12, 6, 20, 1}
        Dim ranks(arr.Length - 1) As Integer

        Array.Sort(arr)

        For i As Integer = 0 To arr.Length - 1
            ranks(Array.IndexOf(arr, arr(i))) = i + 1
        Next

        Console.WriteLine("Input Array:")
        PrintArray(arr)
        Console.WriteLine("Output Array:")
        PrintArray(ranks)
    End Sub

    Sub PrintArray(arr() As Integer)
        For Each num As Integer In arr
            Console.Write(num & " ")
        Next
        Console.WriteLine()
    End Sub
End Module
