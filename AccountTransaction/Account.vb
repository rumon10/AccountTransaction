Public Class Account
    Inherits SavingsAccount
    Public Sub New()
        _Id = String.Empty
        _owner = String.Empty
        _cashBalance = 0
        Me.InterestRate = 0
        Me.TransHistory = New TransactionHistory()
    End Sub
    Private _Id As String
    Property ID As String
        Get
            Return _Id
        End Get
        Set(ByVal value As String)
            _Id = value
        End Set
    End Property
    Private _owner As String
    Property Owner As String
        Get
            Return _owner
        End Get
        Set(ByVal value As String)
            _owner = value
        End Set
    End Property
    Private _cashBalance As Double
    Property CashBalance As Double
        Get
            Return _cashBalance
        End Get
        Set(ByVal value As Double)
            _cashBalance = value
        End Set
    End Property
    Public Function ToString() As Account
        Return Me
    End Function
    Public Function Equals(ByVal __id As String) As Boolean
        Return __id.Equals(Me._Id)
    End Function
End Class
