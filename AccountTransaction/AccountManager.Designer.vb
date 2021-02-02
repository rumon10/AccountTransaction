<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AccountManager
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.listBoxAccount = New System.Windows.Forms.ListBox()
        Me.listboxTransactionHistory = New System.Windows.Forms.ListBox()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(4, 4)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.listBoxAccount)
        Me.SplitContainer1.Panel1MinSize = 50
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.listboxTransactionHistory)
        Me.SplitContainer1.Size = New System.Drawing.Size(609, 224)
        Me.SplitContainer1.SplitterDistance = 306
        Me.SplitContainer1.TabIndex = 0
        '
        'listBoxAccount
        '
        Me.listBoxAccount.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listBoxAccount.FormattingEnabled = True
        Me.listBoxAccount.ItemHeight = 16
        Me.listBoxAccount.Location = New System.Drawing.Point(0, 0)
        Me.listBoxAccount.Name = "listBoxAccount"
        Me.listBoxAccount.Size = New System.Drawing.Size(306, 224)
        Me.listBoxAccount.TabIndex = 0
        '
        'listboxTransactionHistory
        '
        Me.listboxTransactionHistory.Dock = System.Windows.Forms.DockStyle.Fill
        Me.listboxTransactionHistory.FormattingEnabled = True
        Me.listboxTransactionHistory.ItemHeight = 16
        Me.listboxTransactionHistory.Location = New System.Drawing.Point(0, 0)
        Me.listboxTransactionHistory.Name = "listboxTransactionHistory"
        Me.listboxTransactionHistory.Size = New System.Drawing.Size(299, 224)
        Me.listboxTransactionHistory.TabIndex = 0
        '
        'AccountManager
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(96.0!, 96.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi
        Me.ClientSize = New System.Drawing.Size(617, 232)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "AccountManager"
        Me.Padding = New System.Windows.Forms.Padding(4)
        Me.Text = "Account Manager"
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents SplitContainer1 As System.Windows.Forms.SplitContainer
    Friend WithEvents listBoxAccount As System.Windows.Forms.ListBox
    Friend WithEvents listboxTransactionHistory As System.Windows.Forms.ListBox

End Class
