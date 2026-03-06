<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMainMenu
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
        Me.components = New System.ComponentModel.Container()
        Me.ContextMenuStrip1 = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.MenuStrip3 = New System.Windows.Forms.MenuStrip()
        Me.TransactionsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ReturnToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookDonationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MaintainanceToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BorrowerToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.BookToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.DonorToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip3.SuspendLayout()
        Me.SuspendLayout()
        '
        'ContextMenuStrip1
        '
        Me.ContextMenuStrip1.Name = "ContextMenuStrip1"
        Me.ContextMenuStrip1.Size = New System.Drawing.Size(61, 4)
        '
        'MenuStrip3
        '
        Me.MenuStrip3.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.TransactionsToolStripMenuItem, Me.MaintainanceToolStripMenuItem})
        Me.MenuStrip3.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip3.Name = "MenuStrip3"
        Me.MenuStrip3.Size = New System.Drawing.Size(1251, 24)
        Me.MenuStrip3.TabIndex = 3
        Me.MenuStrip3.Text = "MenuStrip3"
        '
        'TransactionsToolStripMenuItem
        '
        Me.TransactionsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowToolStripMenuItem, Me.ReturnToolStripMenuItem, Me.BookDonationsToolStripMenuItem})
        Me.TransactionsToolStripMenuItem.Name = "TransactionsToolStripMenuItem"
        Me.TransactionsToolStripMenuItem.Size = New System.Drawing.Size(85, 20)
        Me.TransactionsToolStripMenuItem.Text = "Transactions"
        '
        'BorrowToolStripMenuItem
        '
        Me.BorrowToolStripMenuItem.Name = "BorrowToolStripMenuItem"
        Me.BorrowToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BorrowToolStripMenuItem.Text = "Borrow"
        '
        'ReturnToolStripMenuItem
        '
        Me.ReturnToolStripMenuItem.Name = "ReturnToolStripMenuItem"
        Me.ReturnToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.ReturnToolStripMenuItem.Text = "Return"
        '
        'BookDonationsToolStripMenuItem
        '
        Me.BookDonationsToolStripMenuItem.Name = "BookDonationsToolStripMenuItem"
        Me.BookDonationsToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BookDonationsToolStripMenuItem.Text = "Book Donations"
        '
        'MaintainanceToolStripMenuItem
        '
        Me.MaintainanceToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BorrowerToolStripMenuItem, Me.BookToolStripMenuItem, Me.DonorToolStripMenuItem})
        Me.MaintainanceToolStripMenuItem.Name = "MaintainanceToolStripMenuItem"
        Me.MaintainanceToolStripMenuItem.Size = New System.Drawing.Size(91, 20)
        Me.MaintainanceToolStripMenuItem.Text = "Maintainance"
        '
        'BorrowerToolStripMenuItem
        '
        Me.BorrowerToolStripMenuItem.Name = "BorrowerToolStripMenuItem"
        Me.BorrowerToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BorrowerToolStripMenuItem.Text = "Borrower"
        '
        'BookToolStripMenuItem
        '
        Me.BookToolStripMenuItem.Name = "BookToolStripMenuItem"
        Me.BookToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.BookToolStripMenuItem.Text = "Book"
        '
        'DonorToolStripMenuItem
        '
        Me.DonorToolStripMenuItem.Name = "DonorToolStripMenuItem"
        Me.DonorToolStripMenuItem.Size = New System.Drawing.Size(180, 22)
        Me.DonorToolStripMenuItem.Text = "Donor"
        '
        'frmMainMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1251, 717)
        Me.Controls.Add(Me.MenuStrip3)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4, 5, 4, 5)
        Me.Name = "frmMainMenu"
        Me.Text = "Library Information System"
        Me.MenuStrip3.ResumeLayout(False)
        Me.MenuStrip3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ContextMenuStrip1 As ContextMenuStrip
    Friend WithEvents MenuStrip3 As MenuStrip
    Friend WithEvents TransactionsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ReturnToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookDonationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MaintainanceToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BorrowerToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents BookToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents DonorToolStripMenuItem As ToolStripMenuItem
End Class
