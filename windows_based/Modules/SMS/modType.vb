Module modType
    Public Structure ModemInfo
        Dim Manufacture As String
        Dim Model As String
        Dim SerialNumber As String
    End Structure
    Public Enum FormatString
        None = 0
        CurrencyFormat = 1
        NumericWithSeparator = 2
        DateTimeFormat = 3
        DateFormat = 4
    End Enum

End Module
