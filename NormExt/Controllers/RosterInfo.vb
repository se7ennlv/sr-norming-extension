Public Class RosterInfo
    Private _shiftcode As String
    Private _datestring As String
    Private _empid As String
    Private _shiftgrp As String

    Sub New()

    End Sub

    Property ShiftCode As String
        Set(value As String)
            _shiftcode = value
        End Set
        Get
            Return _shiftcode
        End Get
    End Property

    Property DateString As String
        Set(value As String)
            _datestring = value
        End Set
        Get
            Return _datestring
        End Get
    End Property
    Property EmployeeID As String
        Set(value As String)
            _empid = value
        End Set
        Get
            Return _empid
        End Get
    End Property

    Property ShiftGroup As String
        Set(value As String)
            _shiftgrp = value
        End Set
        Get
            Return _shiftgrp
        End Get
    End Property

End Class
