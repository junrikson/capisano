Option Explicit On
Public Class MessageReceiver

    Private TPMessageTime As String
    Private TPMessagePhoneNumber As String
    Private TPMessageText As String
    Private TPName As String
    Private IndexPos As Long = 0
    Private data
    Private PArsingData()

    'Set Protocol Data Unit (PDU) Data


    Public WriteOnly Property Value()
        Set(ByVal xData)

            PArsingData = Split(xData, ":")

            IndexPos = Val(PArsingData(0))
            data = PArsingData(1)
            Dim Remainder As Long
            Dim nPos As Long

            Dim TPData As String

            Dim SCLength As Long
            Dim TPLength As Long

            'Length Of Service Center Address (SCA)
            SCLength = Val(HexToDec(Left(data, 2)) * 2) + 2

            'Length Of Trasport Protocol Data Unit (TPData)
            TPLength = Len(data) - SCLength

            'Trasport Protocol Data Unit (TPData)
            TPData = Right(data, TPLength)

            Remainder = HexToDec(Mid(TPData, 3, 2)) Mod 2

            'Get Message Phone Number
            '----------------------------------------------------------------------------------------
            TPMessagePhoneNumber = Mid(TPData, 7, Val(HexToDec(Mid(TPData, 3, 2))) + Remainder)
            '----------------------------------------------------------------------------------------

            'Get Message Time
            '----------------------------------------------------------------------------------------
            TPMessageTime = Mid(TPData, 7 + Len(TPMessagePhoneNumber) + 4, 14)
            '----------------------------------------------------------------------------------------

            'Get Message Text
            '----------------------------------------------------------------------------------------
            nPos = 7 + Len(TPMessagePhoneNumber) + 4 + Len(TPMessageTime) + 2
            TPMessageText = Mid(TPData, nPos, Len(TPData) - nPos + 1)
        End Set
    End Property

    '----------------------------------------------------------------------------------------



    'Decode TPMessageTime To MessageTime
    Public Function IndexOfMessage() As Long
        Return IndexPos
    End Function

    Public Function MessageTime() As Date
        MessageTime = DateSerial(Val(Mid(TPMessageTime, 2, 1) + Mid(TPMessageTime, 1, 1)), _
                        Val(Mid(TPMessageTime, 4, 1) + Mid(TPMessageTime, 3, 1)), _
                                 Val(Mid(TPMessageTime, 6, 1) + Mid(TPMessageTime, 5, 1))) + " " +
                      TimeSerial(Val(Mid(TPMessageTime, 8, 1) + Mid(TPMessageTime, 7, 1)), _
                                 Val(Mid(TPMessageTime, 10, 1) + Mid(TPMessageTime, 9, 1)), _
                                 Val(Mid(TPMessageTime, 12, 1) + Mid(TPMessageTime, 11, 1)))
        Return MessageTime
    End Function

    'Decode TPMessagePhoneNumber Ke MessagePhoneNumber
    Public Function MessagePhoneNumber() As String
        Dim Index As Integer

        TPMessagePhoneNumber = Trim(TPMessagePhoneNumber)

        MessagePhoneNumber = ""
        For Index = 1 To Len(TPMessagePhoneNumber) Step 2
            MessagePhoneNumber = MessagePhoneNumber + Mid(TPMessagePhoneNumber, Index + 1, 1) + Mid(TPMessagePhoneNumber, Index, 1)
        Next

        If InStr(MessagePhoneNumber, "F") <> 0 Then
            MessagePhoneNumber = "+" & Left(MessagePhoneNumber, Len(MessagePhoneNumber) - 1)
        Else
            MessagePhoneNumber = "+" & MessagePhoneNumber
        End If

    End Function

    'Decode TPMessageText To MessageText
    Public Function MessageText() As String
        Dim nPos As Long
        Dim Binner As String
        Dim Remainder As Integer

        Binner = ""
        For nPos = 1 To Len(TPMessageText) Step 2
            Binner = HexToBin(Mid(TPMessageText, nPos, 2)) & Binner
        Next

        Remainder = Len(Binner) Mod 7

        MessageText = ""
        For nPos = 1 To (Len(Binner) - Remainder) Step 7
            MessageText = Chr(HexToDec(BinToHex(Mid(Binner, nPos + Remainder, 7)))) & MessageText
        Next

    End Function

End Class
