Public Class TransactionHistory
    Private _items As Dictionary(Of Date, Transaction) = New Dictionary(Of Date, Transaction)
    Property Items As Dictionary(Of Date, Transaction)
        Get
            Return _items
        End Get
        Set(ByVal value As Dictionary(Of Date, Transaction))
            _items = value
        End Set
    End Property
End Class
