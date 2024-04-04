Public Class Solution
    Public Function LengthOfLongestSubstring(ByVal s As String) As Integer
        Dim maxLength As Integer = 0
        Dim startIdx As Integer = 0
        Dim charIndexMap As New Dictionary(Of Char, Integer)()

        For i As Integer = 0 To s.Length - 1
            Dim currentChar As Char = s(i)

            If charIndexMap.ContainsKey(currentChar) AndAlso charIndexMap(currentChar) >= startIdx Then
                startIdx = charIndexMap(currentChar) + 1
            End If

            charIndexMap(currentChar) = i
            maxLength = Math.Max(maxLength, i - startIdx + 1)
        Next

        Return maxLength
    End Function
End Class

Module Module1
    Sub Main()
        Dim solution As New Solution()
        
        Dim input1 As String = "abcabcbb"
        Dim input2 As String = "bbbbb"
        Dim input3 As String = "pwwkew"

        Console.WriteLine("Example 1: " & solution.LengthOfLongestSubstring(input1))
        Console.WriteLine("Example 2: " & solution.LengthOfLongestSubstring(input2))
        Console.WriteLine("Example 3: " & solution.LengthOfLongestSubstring(input3))
    End Sub
End Module

