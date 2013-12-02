Option Explicit On
Module modConversion

    'Konversi Decimal Ke Hexadecimal
    Public Function DecToHex(Data As Long) As String
        DecToHex = Hex(Data)
        If Len(DecToHex) = 1 Then
            DecToHex = "0" & DecToHex
        End If
    End Function

    'Konversi Decimal Ke Binary
    Public Function DecToBin(ByVal Data As Long) As String
        Dim BaseDec As Integer
        Dim Temp As Object
        Dim Remainder As Object
        Dim result As Object

        Temp = ""
        Remainder = ""
        BaseDec = 2

        Do
            Temp = Remainder & Temp
            result = Data \ BaseDec
            Remainder = Data Mod BaseDec
            Data = result
        Loop Until result <= 1

        DecToBin = result & Remainder & Temp
        DecToBin = Right("0000000" & DecToBin, 7)
    End Function

    'Konversi Binary Ke Hexadecimal
    Public Function BinToHex(ByVal Data As String) As String
        Dim Hex As String = ""
        Dim Pos As Integer

        Data = Right("00000000" & Data, 8)

        BinToHex = ""
        For Pos = 1 To 2
            Select Case Mid(Data, Len(Data) + 1 - 4 * Pos, 4)
                Case "0000" : Hex = "0"
                Case "0001" : Hex = "1"
                Case "0010" : Hex = "2"
                Case "0011" : Hex = "3"
                Case "0100" : Hex = "4"
                Case "0101" : Hex = "5"
                Case "0110" : Hex = "6"
                Case "0111" : Hex = "7"
                Case "1000" : Hex = "8"
                Case "1001" : Hex = "9"
                Case "1010" : Hex = "A"
                Case "1011" : Hex = "B"
                Case "1100" : Hex = "C"
                Case "1101" : Hex = "D"
                Case "1110" : Hex = "E"
                Case "1111" : Hex = "F"
            End Select
            BinToHex = Hex & BinToHex
        Next
    End Function

    'Konversi Hexadecimal Ke Binary
    Public Function HexToBin(ByVal Data As String) As String
        Dim Binary As String = ""
        Dim Pos As Integer

        HexToBin = ""
        For Pos = 1 To Len(Data)
            Select Case Mid(Data, Pos, 1)
                Case "0" : Binary = "0000"
                Case "1" : Binary = "0001"
                Case "2" : Binary = "0010"
                Case "3" : Binary = "0011"
                Case "4" : Binary = "0100"
                Case "5" : Binary = "0101"
                Case "6" : Binary = "0110"
                Case "7" : Binary = "0111"
                Case "8" : Binary = "1000"
                Case "9" : Binary = "1001"
                Case "A" : Binary = "1010"
                Case "B" : Binary = "1011"
                Case "C" : Binary = "1100"
                Case "D" : Binary = "1101"
                Case "E" : Binary = "1110"
                Case "F" : Binary = "1111"
            End Select
            HexToBin = HexToBin & Binary
        Next
    End Function

    'Konversi Hexadecimal Ke Decimal
    Public Function HexToDec(ByVal Data As String) As Long
        Dim Pos As Integer
        Dim Dec As Long

        If Len(Data) = 1 Then
            Data = "0" & Data
        End If

        HexToDec = 0
        For Pos = 1 To 2
            Select Case UCase(Mid(Data, Pos, 1))
                Case "A" : Dec = 10
                Case "B" : Dec = 11
                Case "C" : Dec = 12
                Case "D" : Dec = 13
                Case "E" : Dec = 14
                Case "F" : Dec = 15
                Case Else : Dec = CInt(Mid(Data, Pos, 1))
            End Select
            If Pos = 1 Then
                HexToDec = Dec * 16
            Else
                HexToDec = HexToDec + Dec
            End If
        Next
    End Function
End Module
