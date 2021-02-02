Public Class SavingsAccount
    Private _interestRate As Double
    Property InterestRate As Double
        Get
            Return _interestRate
        End Get
        Set(ByVal value As Double)
            _interestRate = value
        End Set
    End Property
    Private _transHistory As New TransactionHistory()
    Property TransHistory As TransactionHistory
        Get
            Return _transHistory
        End Get
        Set(ByVal value As TransactionHistory)
            _transHistory = value
        End Set
    End Property
End Class
