Option Explicit On

Public Class MessageEvent

    'Return : Mengembalikan Daftar Message Pada Device
    Public Function MessageList(ByVal Data As String) As Collection

        Dim oMsgList As New Collection
        Dim nPos As Integer
        Dim Temp As String = ""
        Dim lEmpty As Boolean
        Dim IndexPos As Long

        Dim nStart As Long
        Dim nEnd As Long

        lEmpty = True
        While InStr(Data, "+CMGL:") <> 0
            lEmpty = False
            nPos = InStr(Data, "+CMGL:")
            Data = Right(Data, Len(Data) - nPos)

            nStart = InStr(Data, ":") + 1
            nEnd = InStr(Data, ",") - 1
            IndexPos = Mid(Data, nStart, nEnd - nStart + 1)

            nPos = InStr(Data, Chr(13) + Chr(10))
            Data = Mid(Data, nPos + 2, Len(Data) - nPos - 2)
            nPos = InStr(Data, Chr(13) + Chr(10))
            If nPos = 0 Then
                nPos = InStr(Data, Chr(13))
            End If
            If nPos = 0 Then
                nPos = InStr(Data, Chr(10))
            End If
            If nPos > 0 Then
                Temp = Left(Data, nPos - 1)
            End If
            oMsgList.Add(IndexPos.ToString.Trim & ":" & Temp.ToString.Trim)

        End While

        MessageList = oMsgList
    End Function


End Class
