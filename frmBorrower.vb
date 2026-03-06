

Imports MySql.Data.MySqlClient


Public Class frmBorrower
    'Create connection variable/object named "MyConnection"
    Dim MyConnection As Common.DbConnection
    'Create a Data Adapter variable/object
    '---A Data Adapter is the go-between for the connection object (MyConnection)
    'and the Dataset (borrowerDA)
    Dim borrowerDA As New MySqlDataAdapter
    'Create a Dataset variable/object
    '---A Data Set is a place holder for the table in your database
    '---There should be one data set for each table in your database
    Dim borrowerDS As New DataSet()
    'Declare the connection string and query variables/objects
    Dim MyConnectionString As String
    Dim borrowerSQLQuery As String
    'We will use this later in the update and delete modules
    Dim row As Integer

    Private Sub btn_Add_Click(sender As Object, e As EventArgs) Handles btn_Add.Click

        'declare a data table variable (borrDataTable) that will serve as a virtual table
        'where the tuples of the BORROWER table will be loaded
        Dim borrDataTable As DataTable = borrowerDS.Tables("borrower")
        Dim newRow As DataRow
        Try
            'a new empty row will be created where the data in the textboxes will be stored
            'check the names of your textbox controls
            newRow = borrDataTable.NewRow()
            newRow("BorrNo") = CInt(txt_borrNo.Text)
            newRow("BorrName") = txt_borrName.Text
            newRow("BorrGradelevel") = cb_gradeLevel.Text
            'add the new record to the BORROWER table via the borrDataTable (virtual table)
            borrDataTable.Rows.Add(newRow)
            'update the borrower table with the inserted new record
            borrowerDA.Update(borrowerDS, "borrower")
            'output a pop-up message (informative) on screen
            MsgBox("The record was successfully saved. (" + txt_borrName.Text + ", " + txt_borrNo.Text + ", " + cb_gradeLevel.Text + ")", MsgBoxStyle.Information, "BORROWER INFORMATION")
            'clear the textboxes and the combobox

            'MessageBox.Show("Finished adding" + txt_borrName.Text + " " + txt_borrNo.Text + " " + cb_gradeLevel.Text)'
            clear()
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try

        btn_delete.Enabled = True
        btn_update.Enabled = True
    End Sub

    Private Sub btn_clear_Click(sender As Object, e As EventArgs) Handles btn_clear.Click
        clear()
    End Sub

    Private Sub btn_close_Click(sender As Object, e As EventArgs) Handles btn_close.Click
        frmMainMenu.Enabled = True
        MyConnection.Close()
        Me.Close()
    End Sub

    Private Sub clear()
        txt_borrName.Clear()
        cb_gradeLevel.Text = ""
        txt_borrNo.Clear()
        txt_borrName.Focus()

        btn_delete.Enabled = False
        btn_update.Enabled = False
    End Sub

    Private Sub frmBorrower_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        MyConnectionString = "datasource=localhost;username=root;password=;database=library_"
        'Note that we have already discussed SQL in our previous lecture
        'This query is assigned to the borrSQLQuery variable and will be used in your DataGridView control/object
        borrowerSQLQuery = "SELECT * FROM borrower ORDER BY BorrName"
        'Create a connection to your database using the connection string specified in the first statement above
        MyConnection = New MySqlConnection(MyConnectionString)
        'Disable the MainMenu form so it cannot be clicked when another form is loaded
        frmMainMenu.Enabled = False
        'Also, disable the Edit/Update and Delete buttons (use the object names that you have in your form)
        btn_update.Enabled = False
        btn_delete.Enabled = False

        Try
            'Open the connection to the database
            MyConnection.Open()
            'Create a new SQL command based on the SQL query above and place in or assign to the data adapter
            borrowerDA.SelectCommand = New MySqlCommand(borrowerSQLQuery, MyConnection)
            'Create the command builder for adding a record to/updating the BORROWER table
            Dim cb1 As MySqlCommandBuilder = New MySqlCommandBuilder(borrowerDA)
            'Populate the dataset "borrDataSet" (virtual table) with data from the database table (BORROWER—see phpmyadmin)
            borrowerDA.Fill(borrowerDS, "borrower")
            'Show the borrower records in the datagridview control
            'The source of the data is colDataSet which was populated with records from the previous command
            dgv_borrower.DataSource = borrowerDS
            dgv_borrower.DataMember = "borrower"
            'resize the columns based on the text
            dgv_borrower.AutoResizeColumns()
            'set the headers of the columns
            'modify this based on the number of attributes you have in the BORROWER table; attribute 1 starts at column 0
            dgv_borrower.Columns(0).HeaderText = "BorrNo"
            dgv_borrower.Columns(1).HeaderText = "BorrName"
            dgv_borrower.Columns(2).HeaderText = "BorrGradelevel"
        Catch ex As Common.DbException
            'In case of an error, output the standard error message
            MsgBox(ex.ToString)
        Finally
            'close the connection to the database
            MyConnection.Close()
        End Try
    End Sub

    Private Sub dgv_borrower_MouseUp(sender As Object, e As MouseEventArgs) Handles dgv_borrower.MouseUp
        'transfer the content of the row that was clicked on the datagridview control to the textboxes
        txt_borrNo.Text = dgv_borrower.CurrentRow.Cells(0).Value.ToString
        txt_borrName.Text = dgv_borrower.CurrentRow.Cells(1).Value.ToString
        cb_gradeLevel.Text = dgv_borrower.CurrentRow.Cells(2).Value.ToString
        'the row number/index of the tuple is taken note of (to be used when updating or deleting that tuple)
        row = dgv_borrower.CurrentRow.Index
        'the Add button is disabled and the Update and Delete buttons are enabled
        'the record that was chosen can either be edited or deleted (not added as a new record)
        btn_Add.Enabled = True
        btn_delete.Enabled = True
        btn_update.Enabled = True
    End Sub

    Private Sub btn_update_Click(sender As Object, e As EventArgs) Handles btn_update.Click
        'Declare dt as a temporary holder/table for the BORROWER table
        'Take note that we used the variable borrDataTable in the “Add Records” module
        Dim dt As DataTable = borrowerDS.Tables("borrower")
        'try to execute the following codes
        Try
            'Using the row index of "row" from the dgvBorrower_MouseUp event, update the tuple indicated by
            '"row" in the temporary table (dt) with data from the textboxes/combo box
            'The names in red and enclosed in double quotes are your attributes in phpMyAdmin
            'Take note of the spelling of your attributes because the name is case sensitive
            dt.Rows(row)("BorrNo") = txt_borrNo.Text
            dt.Rows(row)("BorrName") = txt_borrName.Text
            dt.Rows(row)("BorrGradelevel") = cb_gradeLevel.Text
            'save permanently in the department table (in your database)
            borrowerDA.Update(borrowerDS, "borrower")
            'output an informative message to the user
            MsgBox("The changes in the record were successfully saved.", MsgBoxStyle.Information, "BORROWER INFORMATION")
            'Blank out the text boxes/combo box for new input/s
            txt_borrNo.Clear()
            txt_borrName.Clear()
            cb_gradeLevel.Text = ""
            txt_borrNo.Focus()
            'enable the Add button
            btn_Add.Enabled = True
            'disable (cannot be clicked) the Delete and Update buttons
            btn_delete.Enabled = False
            btn_update.Enabled = False
            'if an error occurs, output an error message to the user ("catch" the error)
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click
        'create a temporary table (dt) that will hold the rows from the borrower table
        Dim dt As DataTable = borrowerDS.Tables("borrower")
        Try
            'delete the record that is indicated by the "row" which was taken note of in dgvBorrower_MouseUp
            dt.Rows(row).Delete()
            'update the employee table with one less tuple
            borrowerDA.Update(borrowerDS, "borrower")
            'output an informational message to the user
            MsgBox("The record was successfully deleted.", MsgBoxStyle.Information, "DEPARTMENT INFORMATION")
            'Blank out the text boxes/combo box for new input/s
            txt_borrNo.Clear()
            txt_borrName.Clear()
            cb_gradeLevel.Text = ""
            'set the cursor on the first textbox
            txt_borrNo.Focus()
            btn_Add.Enabled = True
            btn_delete.Enabled = False
            btn_update.Enabled = False
        Catch ex As MySqlException
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class

