<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmBorrower
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
        Me.lbl_header = New System.Windows.Forms.Label()
        Me.lbl_borrNo = New System.Windows.Forms.Label()
        Me.txt_borrNo = New System.Windows.Forms.TextBox()
        Me.lbl_borrName = New System.Windows.Forms.Label()
        Me.txt_borrName = New System.Windows.Forms.TextBox()
        Me.lbl_borrGradeLevel = New System.Windows.Forms.Label()
        Me.cb_gradeLevel = New System.Windows.Forms.ComboBox()
        Me.btn_Add = New System.Windows.Forms.Button()
        Me.btn_update = New System.Windows.Forms.Button()
        Me.btn_delete = New System.Windows.Forms.Button()
        Me.btn_clear = New System.Windows.Forms.Button()
        Me.btn_close = New System.Windows.Forms.Button()
        Me.dgv_borrower = New System.Windows.Forms.DataGridView()
        CType(Me.dgv_borrower, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lbl_header
        '
        Me.lbl_header.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbl_header.Location = New System.Drawing.Point(18, 9)
        Me.lbl_header.Name = "lbl_header"
        Me.lbl_header.Size = New System.Drawing.Size(1431, 49)
        Me.lbl_header.TabIndex = 0
        Me.lbl_header.Text = "Maintainance of Borower Records"
        Me.lbl_header.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'lbl_borrNo
        '
        Me.lbl_borrNo.AutoSize = True
        Me.lbl_borrNo.Location = New System.Drawing.Point(33, 86)
        Me.lbl_borrNo.Name = "lbl_borrNo"
        Me.lbl_borrNo.Size = New System.Drawing.Size(160, 25)
        Me.lbl_borrNo.TabIndex = 1
        Me.lbl_borrNo.Text = "Borrow Number"
        '
        'txt_borrNo
        '
        Me.txt_borrNo.Location = New System.Drawing.Point(199, 83)
        Me.txt_borrNo.Name = "txt_borrNo"
        Me.txt_borrNo.Size = New System.Drawing.Size(100, 31)
        Me.txt_borrNo.TabIndex = 2
        '
        'lbl_borrName
        '
        Me.lbl_borrName.AutoSize = True
        Me.lbl_borrName.Location = New System.Drawing.Point(355, 86)
        Me.lbl_borrName.Name = "lbl_borrName"
        Me.lbl_borrName.Size = New System.Drawing.Size(160, 25)
        Me.lbl_borrName.TabIndex = 3
        Me.lbl_borrName.Text = "Borrower Name"
        '
        'txt_borrName
        '
        Me.txt_borrName.Location = New System.Drawing.Point(521, 83)
        Me.txt_borrName.Name = "txt_borrName"
        Me.txt_borrName.Size = New System.Drawing.Size(286, 31)
        Me.txt_borrName.TabIndex = 4
        '
        'lbl_borrGradeLevel
        '
        Me.lbl_borrGradeLevel.AutoSize = True
        Me.lbl_borrGradeLevel.Location = New System.Drawing.Point(859, 86)
        Me.lbl_borrGradeLevel.Name = "lbl_borrGradeLevel"
        Me.lbl_borrGradeLevel.Size = New System.Drawing.Size(129, 25)
        Me.lbl_borrGradeLevel.TabIndex = 5
        Me.lbl_borrGradeLevel.Text = "Grade Level"
        '
        'cb_gradeLevel
        '
        Me.cb_gradeLevel.FormattingEnabled = True
        Me.cb_gradeLevel.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8", "9", "10", "11", "12"})
        Me.cb_gradeLevel.Location = New System.Drawing.Point(994, 81)
        Me.cb_gradeLevel.Name = "cb_gradeLevel"
        Me.cb_gradeLevel.Size = New System.Drawing.Size(217, 33)
        Me.cb_gradeLevel.TabIndex = 6
        '
        'btn_Add
        '
        Me.btn_Add.Location = New System.Drawing.Point(24, 539)
        Me.btn_Add.Name = "btn_Add"
        Me.btn_Add.Size = New System.Drawing.Size(139, 53)
        Me.btn_Add.TabIndex = 7
        Me.btn_Add.Text = "&Add"
        Me.btn_Add.UseVisualStyleBackColor = True
        '
        'btn_update
        '
        Me.btn_update.Location = New System.Drawing.Point(185, 539)
        Me.btn_update.Name = "btn_update"
        Me.btn_update.Size = New System.Drawing.Size(139, 53)
        Me.btn_update.TabIndex = 8
        Me.btn_update.Text = "&Update"
        Me.btn_update.UseVisualStyleBackColor = True
        '
        'btn_delete
        '
        Me.btn_delete.Location = New System.Drawing.Point(346, 539)
        Me.btn_delete.Name = "btn_delete"
        Me.btn_delete.Size = New System.Drawing.Size(139, 53)
        Me.btn_delete.TabIndex = 9
        Me.btn_delete.Text = "&Delete"
        Me.btn_delete.UseVisualStyleBackColor = True
        '
        'btn_clear
        '
        Me.btn_clear.Location = New System.Drawing.Point(1135, 539)
        Me.btn_clear.Name = "btn_clear"
        Me.btn_clear.Size = New System.Drawing.Size(139, 53)
        Me.btn_clear.TabIndex = 10
        Me.btn_clear.Text = "Clear"
        Me.btn_clear.UseVisualStyleBackColor = True
        '
        'btn_close
        '
        Me.btn_close.Location = New System.Drawing.Point(1294, 539)
        Me.btn_close.Name = "btn_close"
        Me.btn_close.Size = New System.Drawing.Size(139, 53)
        Me.btn_close.TabIndex = 11
        Me.btn_close.Text = "Close"
        Me.btn_close.UseVisualStyleBackColor = True
        '
        'dgv_borrower
        '
        Me.dgv_borrower.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dgv_borrower.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_borrower.Location = New System.Drawing.Point(24, 132)
        Me.dgv_borrower.Name = "dgv_borrower"
        Me.dgv_borrower.Size = New System.Drawing.Size(1409, 376)
        Me.dgv_borrower.TabIndex = 12
        '
        'frmBorrower
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1461, 633)
        Me.Controls.Add(Me.dgv_borrower)
        Me.Controls.Add(Me.btn_close)
        Me.Controls.Add(Me.btn_clear)
        Me.Controls.Add(Me.btn_delete)
        Me.Controls.Add(Me.btn_update)
        Me.Controls.Add(Me.btn_Add)
        Me.Controls.Add(Me.cb_gradeLevel)
        Me.Controls.Add(Me.lbl_borrGradeLevel)
        Me.Controls.Add(Me.txt_borrName)
        Me.Controls.Add(Me.lbl_borrName)
        Me.Controls.Add(Me.txt_borrNo)
        Me.Controls.Add(Me.lbl_borrNo)
        Me.Controls.Add(Me.lbl_header)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "frmBorrower"
        Me.Text = "Borrower Maintanance"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.dgv_borrower, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lbl_header As Label
    Friend WithEvents lbl_borrNo As Label
    Friend WithEvents txt_borrNo As TextBox
    Friend WithEvents lbl_borrName As Label
    Friend WithEvents txt_borrName As TextBox
    Friend WithEvents lbl_borrGradeLevel As Label
    Friend WithEvents cb_gradeLevel As ComboBox
    Friend WithEvents btn_Add As Button
    Friend WithEvents btn_update As Button
    Friend WithEvents btn_delete As Button
    Friend WithEvents btn_clear As Button
    Friend WithEvents btn_close As Button
    Friend WithEvents dgv_borrower As DataGridView
End Class
