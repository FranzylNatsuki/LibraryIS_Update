<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrowTrans
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
        Me.txt_upperlabel = New System.Windows.Forms.Label()
        Me.txt_trans = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cb_gradelevel = New System.Windows.Forms.ComboBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_borrname = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_borrno = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.dgv_borrList = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_author = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_title = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_bookno = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.dgv_bookList = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.dtp_returned = New System.Windows.Forms.DateTimePicker()
        Me.dtp_borrowed = New System.Windows.Forms.DateTimePicker()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.dgv_transactions = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_borrList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgv_bookList, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dgv_transactions, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txt_upperlabel
        '
        Me.txt_upperlabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_upperlabel.Location = New System.Drawing.Point(12, 9)
        Me.txt_upperlabel.Name = "txt_upperlabel"
        Me.txt_upperlabel.Size = New System.Drawing.Size(1041, 23)
        Me.txt_upperlabel.TabIndex = 0
        Me.txt_upperlabel.Text = "BORROWING OF BOOKS"
        Me.txt_upperlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txt_trans
        '
        Me.txt_trans.Location = New System.Drawing.Point(126, 74)
        Me.txt_trans.Name = "txt_trans"
        Me.txt_trans.Size = New System.Drawing.Size(261, 20)
        Me.txt_trans.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(37, 77)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(83, 13)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "Transaction No:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cb_gradelevel)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_borrname)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.txt_borrno)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Location = New System.Drawing.Point(40, 123)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(347, 109)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Borrower"
        '
        'cb_gradelevel
        '
        Me.cb_gradelevel.FormattingEnabled = True
        Me.cb_gradelevel.Location = New System.Drawing.Point(80, 78)
        Me.cb_gradelevel.Name = "cb_gradelevel"
        Me.cb_gradelevel.Size = New System.Drawing.Size(261, 21)
        Me.cb_gradelevel.TabIndex = 8
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(11, 78)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(68, 13)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Grade Level:"
        '
        'txt_borrname
        '
        Me.txt_borrname.Location = New System.Drawing.Point(80, 50)
        Me.txt_borrname.Name = "txt_borrname"
        Me.txt_borrname.Size = New System.Drawing.Size(261, 20)
        Me.txt_borrname.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(11, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Name:"
        '
        'txt_borrno
        '
        Me.txt_borrno.Location = New System.Drawing.Point(80, 24)
        Me.txt_borrno.Name = "txt_borrno"
        Me.txt_borrno.Size = New System.Drawing.Size(261, 20)
        Me.txt_borrno.TabIndex = 4
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(11, 27)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Borrower No:"
        '
        'dgv_borrList
        '
        Me.dgv_borrList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_borrList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_borrList.Location = New System.Drawing.Point(457, 91)
        Me.dgv_borrList.Name = "dgv_borrList"
        Me.dgv_borrList.Size = New System.Drawing.Size(548, 141)
        Me.dgv_borrList.TabIndex = 4
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(454, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 13)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Borrower List"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_author)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_title)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txt_bookno)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Location = New System.Drawing.Point(40, 275)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(347, 129)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Book to borrow"
        '
        'txt_author
        '
        Me.txt_author.Location = New System.Drawing.Point(80, 80)
        Me.txt_author.Name = "txt_author"
        Me.txt_author.Size = New System.Drawing.Size(261, 20)
        Me.txt_author.TabIndex = 7
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(11, 83)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(41, 13)
        Me.Label7.TabIndex = 8
        Me.Label7.Text = "Author:"
        '
        'txt_title
        '
        Me.txt_title.Location = New System.Drawing.Point(80, 50)
        Me.txt_title.Name = "txt_title"
        Me.txt_title.Size = New System.Drawing.Size(261, 20)
        Me.txt_title.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(11, 53)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(30, 13)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Title:"
        '
        'txt_bookno
        '
        Me.txt_bookno.Location = New System.Drawing.Point(80, 24)
        Me.txt_bookno.Name = "txt_bookno"
        Me.txt_bookno.Size = New System.Drawing.Size(261, 20)
        Me.txt_bookno.TabIndex = 4
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(11, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(52, 13)
        Me.Label6.TabIndex = 4
        Me.Label6.Text = "Book No:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(454, 246)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(51, 13)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "Book List"
        '
        'dgv_bookList
        '
        Me.dgv_bookList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_bookList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_bookList.Location = New System.Drawing.Point(457, 263)
        Me.dgv_bookList.Name = "dgv_bookList"
        Me.dgv_bookList.Size = New System.Drawing.Size(548, 141)
        Me.dgv_bookList.TabIndex = 8
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.dtp_returned)
        Me.GroupBox3.Controls.Add(Me.dtp_borrowed)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Location = New System.Drawing.Point(40, 437)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(347, 129)
        Me.GroupBox3.TabIndex = 9
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Transaction"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(11, 70)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(80, 13)
        Me.Label10.TabIndex = 12
        Me.Label10.Text = "Date Returned:"
        '
        'dtp_returned
        '
        Me.dtp_returned.Location = New System.Drawing.Point(98, 64)
        Me.dtp_returned.Name = "dtp_returned"
        Me.dtp_returned.Size = New System.Drawing.Size(243, 20)
        Me.dtp_returned.TabIndex = 11
        '
        'dtp_borrowed
        '
        Me.dtp_borrowed.Location = New System.Drawing.Point(98, 21)
        Me.dtp_borrowed.Name = "dtp_borrowed"
        Me.dtp_borrowed.Size = New System.Drawing.Size(243, 20)
        Me.dtp_borrowed.TabIndex = 10
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(11, 27)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 4
        Me.Label12.Text = "Date Borrowed:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(454, 437)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(51, 13)
        Me.Label11.TabIndex = 11
        Me.Label11.Text = "Book List"
        '
        'dgv_transactions
        '
        Me.dgv_transactions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_transactions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_transactions.Location = New System.Drawing.Point(457, 454)
        Me.dgv_transactions.Name = "dgv_transactions"
        Me.dgv_transactions.Size = New System.Drawing.Size(548, 235)
        Me.dgv_transactions.TabIndex = 10
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(40, 616)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 73)
        Me.Button1.TabIndex = 12
        Me.Button1.Text = "Add"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(160, 616)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(104, 73)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "Clear"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Location = New System.Drawing.Point(283, 616)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(104, 73)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "Close"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'frmBorrowTrans
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1065, 763)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.dgv_transactions)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.dgv_bookList)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgv_borrList)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_trans)
        Me.Controls.Add(Me.txt_upperlabel)
        Me.Name = "frmBorrowTrans"
        Me.Text = "frmBorrowTrans"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.dgv_borrList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dgv_bookList, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dgv_transactions, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txt_upperlabel As Label
    Friend WithEvents txt_trans As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txt_borrname As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txt_borrno As TextBox
    Friend WithEvents dgv_borrList As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txt_title As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents txt_bookno As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents cb_gradelevel As ComboBox
    Friend WithEvents Label8 As Label
    Friend WithEvents txt_author As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents dgv_bookList As DataGridView
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Label10 As Label
    Friend WithEvents dtp_returned As DateTimePicker
    Friend WithEvents dtp_borrowed As DateTimePicker
    Friend WithEvents Label12 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents dgv_transactions As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
End Class
