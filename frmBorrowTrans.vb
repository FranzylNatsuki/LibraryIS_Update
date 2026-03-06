Imports MySql.Data.MySqlClient

Public Class frmBorrowTrans
    'Create connection variable/object named "MyConnection"
    Dim MyConnection As Common.DbConnection
    'Create a Data Adapter variable/object
    '---A Data Adapter is the go-between for the connection object (MyConnection)
    'and the Dataset (borrowerDA)
    Dim borrowerDA As New MySqlDataAdapter
    Dim bookDA As New MySqlDataAdapter
    Dim booktransDA As New MySqlDataAdapter
    'Create a Dataset variable/object
    '---A Data Set is a place holder for the table in your database
    '---There should be one data set for each table in your database
    Dim borrowerDS As New DataSet()
    Dim bookDS As New DataSet()
    Dim booktransDS As New DataSet()
    'Declare the connection string and query variables/objects
    Dim MyConnectionString As String
    Dim borrowerSQLQuery As String
    Dim bookSQLQuery As String
    Dim booktransSQLQuery As String
    'We will use this later in the update and delete modules
    Dim row As Integer

    Private Sub frmBorrowTrans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnectionString = "datasource=localhost;username=root;password=;database=library_"
        'Note that we have already discussed SQL in our previous lecture
        'This query is assigned to the borrSQLQuery variable and will be used in your DataGridView control/object
        borrowerSQLQuery = "SELECT * FROM borrower ORDER BY BorrName"
        bookSQLQuery = "SELECT * FROM book ORDER BY BookTitle"
        booktransSQLQuery = "SELECT * FROM borrowtrans"
        'Create a connection to your database using the connection string specified in the first statement above
        MyConnection = New MySqlConnection(MyConnectionString)
        'Disable the MainMenu form so it cannot be clicked when another form is loaded
        frmMainMenu.Enabled = False
        'Also, disable the Edit/Update and Delete buttons (use the object names that you have in your form)
        'btn_update.Enabled = False
        'btn_delete.Enabled = False

        Try
            'Open the connection to the database
            MyConnection.Open()
            'Create a new SQL command based on the SQL query above and place in or assign to the data adapter
            borrowerDA.SelectCommand = New MySqlCommand(borrowerSQLQuery, MyConnection)
            bookDA.SelectCommand = New MySqlCommand(bookSQLQuery, MyConnection)
            booktransDA.SelectCommand = New MySqlCommand(booktransSQLQuery, MyConnection)
            'Create the command builder for adding a record to/updating the BORROWER table
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(booktransDA)
            'Populate the dataset "borrDataSet" (virtual table) with data from the database table (BORROWER—see phpmyadmin)
            borrowerDA.Fill(borrowerDS, "borrower")
            bookDA.Fill(bookDS, "book")
            booktransDA.Fill(booktransDS, "borrowtrans")
            'Show the borrower records in the datagridview control
            'The source of the data is colDataSet which was populated with records from the previous command
            dgv_borrList.DataSource = borrowerDS
            dgv_borrList.DataMember = "borrower"
            dgv_borrList.AutoResizeColumns()
            'set the headers of the columns
            'modify this based on the number of attributes you have in the BORROWER table; attribute 1 starts at column 0
            dgv_borrList.Columns(0).HeaderText = "BorrNo"
            dgv_borrList.Columns(1).HeaderText = "BorrName"
            dgv_borrList.Columns(2).HeaderText = "BorrGradelevel"

            dgv_bookList.DataSource = bookDS
            dgv_bookList.DataMember = "book"
            dgv_bookList.AutoResizeColumns()
            'set the headers of the columns
            'modify this based on the number of attributes you have in the BORROWER table; attribute 1 starts at column 0
            dgv_bookList.Columns(0).HeaderText = "BookNo"
            dgv_bookList.Columns(1).HeaderText = "BookTitle"
            dgv_bookList.Columns(2).HeaderText = "Book Author"
            dgv_bookList.Columns(3).HeaderText = "BookCopyRight"

            dgv_transactions.DataSource = booktransDS
            dgv_transactions.DataMember = "borrowtrans"
            dgv_transactions.AutoResizeColumns()
            'set the headers of the columns
            'modify this based on the number of attributes you have in the BORROWER table; attribute 1 starts at column 0
            dgv_transactions.Columns(0).HeaderText = "TransNo"
            dgv_transactions.Columns(1).HeaderText = "BookNo"
            dgv_transactions.Columns(2).HeaderText = "BorrNo"
            dgv_transactions.Columns(3).HeaderText = "BorrowDate"
            dgv_transactions.Columns(4).HeaderText = "ReturnDate"

        Catch ex As Common.DbException
            'In case of an error, output the standard error message
            MsgBox(ex.ToString)
        Finally
            'close the connection to the database
            MyConnection.Close()
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'declare a data table variable (borrDataTable) that will serve as a virtual table
        'where the tuples of the BORROWER table will be loaded
        Dim booktransDataTable As DataTable = booktransDS.Tables("borrowtrans")
        Dim newRow As DataRow
        Try
            'a new empty row will be created where the data in the textboxes will be stored
            'check the names of your textbox controls
            newRow = booktransDataTable.NewRow()
            newRow("TransNo") = CInt(txt_trans.Text)
            newRow("BookNo") = CInt(txt_bookno.Text)
            newRow("BorrNo") = CInt(txt_borrno.Text)
            newRow("BorrowDate") = dtp_borrowed.Value
            newRow("ReturnDate") = dtp_returned.Value
            'add the new record to the BORROWER table via the borrDataTable (virtual table)
            booktransDataTable.Rows.Add(newRow)
            'update the borrower table with the inserted new record
            booktransDA.Update(booktransDS, "borrowtrans")
            'output a pop-up message (informative) on screen

        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        frmMainMenu.Enabled = True
        MyConnection.Close()
        Me.Close()
    End Sub

    Private Sub dgv_borrList_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_borrList.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_borrno.Text = dgv_borrList.CurrentRow.Cells(0).Value.ToString
        txt_borrname.Text = dgv_borrList.CurrentRow.Cells(1).Value.ToString
        cb_gradelevel.Text = dgv_borrList.CurrentRow.Cells(2).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        row = dgv_borrList.CurrentRow.Index
    End Sub

    Private Sub dgv_bookList_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_bookList.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_bookno.Text = dgv_bookList.CurrentRow.Cells(0).Value.ToString
        txt_title.Text = dgv_bookList.CurrentRow.Cells(1).Value.ToString
        txt_author.Text = dgv_bookList.CurrentRow.Cells(2).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        row = dgv_bookList.CurrentRow.Index
    End Sub
End Class