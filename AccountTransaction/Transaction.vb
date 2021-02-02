Public Class Transaction
    Public Sub New(ByVal __transAmount As Double, ByVal __transDate As Date, ByVal __transType As TransactionType)
        _transactionAmount = __transAmount
        _transactionDate = __transDate
        _transType = __transType
    End Sub
    Private _transactionDate As Date
    Property TransactionDate As Date
        Get
            Return _transactionDate
        End Get
        Set(ByVal value As Date)
            _transactionDate = value
        End Set
    End Property
    Private _transType As TransactionType
    Property TransType As TransactionType
        Get
            Return _transType
        End Get
        Set(ByVal value As TransactionType)
            _transType = value
        End Set
    End Property
    Private _transactionAmount As Double
    Property TransactionAmount As Double
        Get
            Return _transactionAmount
        End Get
        Set(ByVal value As Double)
            _transactionAmount = value
        End Set
    End Property
End Class
