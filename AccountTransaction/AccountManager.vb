Public Class AccountManager
    Dim _savingAccount1 As Account = New Account()
    Dim _savingAccount2 As Account = New Account()
    Dim _savingAccountList As New List(Of Account)
    Private Sub AccountManager_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        _savingAccount1.ID = "00012"
        _savingAccount1.Owner = "Johnson. Bob"
        _savingAccount1.CashBalance = 2500.0
        _savingAccount1.InterestRate = 5
        _savingAccount1.TransHistory = _savingAccount1.TransHistory
        listBoxAccount.Items.Add(_savingAccount1.ID + "," + _savingAccount1.Owner + "," + _savingAccount1.CashBalance.ToString())

        _savingAccount1.TransHistory.Items.Add(Date.ParseExact("20210115", "yyyyMMdd", Nothing), New Transaction(350.0, Date.ParseExact("20210115", "yyyyMMdd", Nothing), TransactionType.Withdrawal))
        _savingAccount1.TransHistory.Items.Add(Date.ParseExact("20210116", "yyyyMMdd", Nothing), New Transaction(350.0, Date.ParseExact("20210116", "yyyyMMdd", Nothing), TransactionType.Withdrawal))
        _savingAccount1.TransHistory.Items.Add(Date.ParseExact("20210117", "yyyyMMdd", Nothing), New Transaction(425.0, Date.ParseExact("20210117", "yyyyMMdd", Nothing), TransactionType.Deposit))
        _savingAccountList.Add(_savingAccount1)

        _savingAccount2.ID = "00304"
        _savingAccount2.Owner = "Chono Hatv"
        _savingAccount2.CashBalance = 1500.0
        _savingAccount2.InterestRate = 5
        _savingAccount2.TransHistory = _savingAccount2.TransHistory
        listBoxAccount.Items.Add(_savingAccount2.ID + "," + _savingAccount2.Owner + "," + _savingAccount2.CashBalance.ToString())

        _savingAccount2.TransHistory.Items.Add(Date.ParseExact("20210111", "yyyyMMdd", Nothing), New Transaction(500.0, Date.ParseExact("20210111", "yyyyMMdd", Nothing), TransactionType.Deposit))
        _savingAccount2.TransHistory.Items.Add(Date.ParseExact("20210112", "yyyyMMdd", Nothing), New Transaction(250.0, Date.ParseExact("20210112", "yyyyMMdd", Nothing), TransactionType.Withdrawal))
        _savingAccount2.TransHistory.Items.Add(Date.ParseExact("20210115", "yyyyMMdd", Nothing), New Transaction(425.0, Date.ParseExact("20210115", "yyyyMMdd", Nothing), TransactionType.Deposit))
        _savingAccountList.Add(_savingAccount2)
        listBoxAccount.SelectedIndex = 0
        Me.displayTranshistory(0)
    End Sub
    Private Sub displayTranshistory(ByVal inx As Integer)
        listboxTransactionHistory.Items.Clear()
        Dim _account As Account = _savingAccountList.Item(inx)
        Dim i As Integer = 0
        For i = 0 To _account.TransHistory.Items.Count - 1
            listboxTransactionHistory.Items.Add(_account.TransHistory.Items.Values(i).TransactionDate.ToString("MM/dd/yyyy") + "," + _account.TransHistory.Items.Values(i).TransType.ToString() + "," + _account.TransHistory.Items.Values(i).TransactionAmount.ToString())
        Next
    End Sub

    Private Sub listBoxAccount_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles listBoxAccount.SelectedIndexChanged
        Me.displayTranshistory(listBoxAccount.SelectedIndex)
    End Sub
End Class
