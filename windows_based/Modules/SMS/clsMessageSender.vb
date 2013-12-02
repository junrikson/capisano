Public Class clsMessageSender
    Public Function MessageSubmit(ByVal PhoneNumber As String, ByVal Message As String) As String
        On Error Resume Next
        Dim SC_ADR As String
        Dim TP_FO As String
        Dim TP_MR As String
        Dim TP_DA As String
        Dim TP_PID As String
        Dim TP_DCS As String
        Dim TP_VP As String
        Dim TP_UDL As String
        Dim TP_UD As String

        PhoneNumber = Trim(PhoneNumber)
        If Left(PhoneNumber, 1) = "+" Then
            PhoneNumber = Right(PhoneNumber, Len(PhoneNumber) - 1)
        End If

        SC_ADR = "00"
        TP_FO = "11"
        TP_MR = "00"

        TP_DA = DecToHex(Len(PhoneNumber))
        TP_DA = TP_DA & "91"
        TP_DA = TP_DA & PDUAddress(PhoneNumber)

        TP_PID = "00"
        TP_DCS = "00"
        TP_VP = "00"

        TP_UDL = DecToHex(Len(Message))
        TP_UD = PDUMessageText(Message)

        MessageSubmit = SC_ADR & TP_FO & TP_MR & TP_DA & TP_PID & TP_DCS & TP_VP & TP_UDL & TP_UD
    End Function
    'Encode PhoneNumber Ke PDUAddress
    Private Function PDUAddress(ByVal PhoneNumber As String) As String
        Dim Index As Integer

        PhoneNumber = Trim(PhoneNumber)
        PhoneNumber = IIf(Left(PhoneNumber, 1) = "+", Right(PhoneNumber, Len(PhoneNumber) - 1), PhoneNumber)

        If Len(PhoneNumber) Mod 2 <> 0 Then
            PhoneNumber = PhoneNumber + "F"
        End If

        PDUAddress = ""
        For Index = 1 To Len(PhoneNumber) Step 2
            PDUAddress = PDUAddress + Mid(PhoneNumber, Index + 1, 1) + Mid(PhoneNumber, Index, 1)
        Next

    End Function

    'Encode MessageText To PDUMessage
    Private Function PDUMessageText(ByVal Data As String) As String
        Dim nPos As Long
        Dim Binner As String
        Dim Remainder As Integer
        Dim Zero As String = ""

        Binner = ""
        For nPos = 1 To Len(Data)
            Binner = DecToBin(Asc(Mid(Data, nPos, 1))) & Binner
        Next

        Remainder = Len(Binner) Mod 8

        If Remainder > 0 Then
            Zero = ""
            For nPos = 1 To 8 - Remainder
                Zero = Zero & "0"
            Next
        End If

        Binner = Zero & Binner

        PDUMessageText = ""
        For nPos = 1 To Len(Binner) \ 8
            PDUMessageText = PDUMessageText & BinToHex(Mid(Binner, Len(Binner) + 1 - 8 * nPos, 8))
        Next
    End Function
End Class
