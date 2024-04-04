Imports System.Collections.Generic

Module Module1
    Sub Main()
        Dim s As String = "abcabcbb"
        Console.WriteLine("Input: " & s)
        Dim length As Integer = LengthOfLongestSubstring(s)
        Console.WriteLine("Output: " & length)
    End Sub

    Function LengthOfLongestSubstring(ByVal s As String) As Integer
        Dim maxLength As Integer = 0
        Dim startIdx As Integer = 0
        Dim charIndex As New Dictionary(Of Char, Integer)()

        For i As Integer = 0 To s.Length - 1
            If charIndex.ContainsKey(s(i)) AndAlso charIndex(s(i)) >= startIdx Then
                startIdx = charIndex(s(i)) + 1
            End If
            charIndex(s(i)) = i
            maxLength = Math.Max(maxLength, i - startIdx + 1)
        Next

        Return maxLength
    End Function
End Module
