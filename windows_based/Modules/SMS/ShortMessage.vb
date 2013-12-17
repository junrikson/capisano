Imports System.Collections.Generic
Imports System.Text

Public Class ShortMessage

#Region "Private Variables"
    Private m_index As String
    Private m_status As String
    Private m_sender As String
    Private m_alphabet As String
    Private m_sent As String
    Private m_message As String
#End Region

#Region "Public Properties"
    Public Property Index() As String
        Get
            Return m_index
        End Get
        Set(value As String)
            m_index = value
        End Set
    End Property
    Public Property Status() As String
        Get
            Return m_status
        End Get
        Set(value As String)
            m_status = value
        End Set
    End Property
    Public Property Sender() As String
        Get
            Return m_sender
        End Get
        Set(value As String)
            m_sender = value
        End Set
    End Property
    Public Property Alphabet() As String
        Get
            Return m_alphabet
        End Get
        Set(value As String)
            m_alphabet = value
        End Set
    End Property
    Public Property Sent() As String
        Get
            Return m_sent
        End Get
        Set(value As String)
            m_sent = value
        End Set
    End Property
    Public Property Message() As String
        Get
            Return m_message
        End Get
        Set(value As String)
            m_message = value
        End Set
    End Property
#End Region

End Class

Public Class ShortMessageCollection
    Inherits List(Of ShortMessage)
End Class