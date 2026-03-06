Public Class frmMainMenu
    Private Sub frmMainMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub BorrowerToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowerToolStripMenuItem.Click
        frmBorrower.Show()
        'Me.Close()'
    End Sub

    Private Sub BorrowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BorrowToolStripMenuItem.Click
        frmBorrowTrans.Show()
    End Sub
End Class
