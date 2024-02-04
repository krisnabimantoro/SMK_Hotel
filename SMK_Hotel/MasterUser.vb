Imports System.Data.SqlClient
Public Class MasterUser
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Dim index As String
    Private Sub MasterUser_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.Job' table. You can move, or remove it, as needed.
        Me.JobTableAdapter.Fill(Me.SMK_HotelDataSet.Job)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.Employee' table. You can move, or remove it, as needed.
        Me.EmployeeTableAdapter.Fill(Me.SMK_HotelDataSet.Employee)
        CenterToScreen()
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"
        Me.cbjob.Text = ("")
    End Sub
    Private Sub btnmasteruser_Click(sender As Object, e As EventArgs) Handles btnmasteruser.Click

    End Sub

    Private Sub btncheckout_Click(sender As Object, e As EventArgs) Handles btncheckout.Click
        CheckOut.Show()
        Me.Hide()

    End Sub

    Private Sub btncheckin_Click(sender As Object, e As EventArgs) Handles btncheckin.Click
        CheckIn.Show()
        Me.Hide()

    End Sub

    Private Sub btnreservation_Click(sender As Object, e As EventArgs) Handles btnreservation.Click
        Reservation.Show()
        Me.Hide()
    End Sub

    Private Sub btnmasterroom_Click(sender As Object, e As EventArgs) Handles btnmasterroom.Click
        MasterRoom.Show()
        Me.Hide()
    End Sub

    Private Sub btntransaction_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        Display_RoomService_and_FoodBeverage.Show()
        Me.Close()
    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click

        theConnection.Open()

        theCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Me.tbusername.Text
        theCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = Me.tbpassword.Text
        theCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = Me.tbname.Text
        theCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Me.tbemail.Text
        theCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Me.tbaddress.Text
        theCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = Me.dateofbirth.Value.Date
        theCommand.Parameters.Add("@JobID", SqlDbType.Int).Value = Me.cbjob.SelectedValue

        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = "INSERT INTO Employee  (Username, Password, Name, Email, Address, DateOfBirth, JobID) VALUES (@Username, @Password, @Name, @Email, @Address, @DateOfBirth, @JobID)"
            theDataReader = theCommand.ExecuteReader
            Me.EmployeeTableAdapter.Fill(Me.SMK_HotelDataSet.Employee)

            clear()
            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()


        End Using
    End Sub
    Private Sub clear()
        Me.tbusername.Clear()
        Me.tbpassword.Clear()
        Me.tbconfirmpassword.Clear()
        Me.tbname.Clear()
        Me.tbemail.Clear()
        Me.tbaddress.Clear()
        Me.dateofbirth.SendToBack()
        Me.cbjob.Text = ("")
    End Sub
    Private Sub dgvmasteruser_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmasteruser.CellContentClick

        On Error Resume Next

        id.Text = dgvmasteruser.Rows(e.RowIndex).Cells(0).Value
        tbusername.Text = dgvmasteruser.Rows(e.RowIndex).Cells(1).Value
        tbpassword.Text = dgvmasteruser.Rows(e.RowIndex).Cells(2).Value
        tbconfirmpassword.Text = dgvmasteruser.Rows(e.RowIndex).Cells(2).Value
        tbname.Text = dgvmasteruser.Rows(e.RowIndex).Cells(3).Value
        tbemail.Text = dgvmasteruser.Rows(e.RowIndex).Cells(4).Value
        tbaddress.Text = dgvmasteruser.Rows(e.RowIndex).Cells(5).Value
        dateofbirth.Value = dgvmasteruser.Rows(e.RowIndex).Cells(6).Value
        cbjob.Text = dgvmasteruser.Rows(e.RowIndex).Cells(7).Value

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        theConnection.Open()

        theCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Me.tbusername.Text
        theCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = Me.tbpassword.Text
        theCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = Me.tbname.Text
        theCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Me.tbemail.Text
        theCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Me.tbaddress.Text
        theCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = Me.dateofbirth.Value.Date
        theCommand.Parameters.Add("@JobID", SqlDbType.Int).Value = Me.cbjob.SelectedValue
        theCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Me.id.Text

        Using theDataReader
            'Setup
            theCommand.Connection = theConnection
            theCommand.CommandText = "Update Employee SET Username = @Username, Password = @Password, Name = @Name, Email = @Email, DateOfBirth = @DateOfBirth, JobID = @JobID, Address = @Address WHERE ID = @ID"

            If theCommand.ExecuteNonQuery = 1 Then
                Me.EmployeeTableAdapter.Fill(Me.SMK_HotelDataSet.Employee)
                MessageBox.Show("Data Updated")
                clear()
            Else
                MessageBox.Show("Data Not Updated")

            End If
            theConnection.Close()
        End Using
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        theConnection.Open()
        theCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Me.tbusername.Text
        theCommand.Parameters.Add("@Password", SqlDbType.VarChar).Value = Me.tbpassword.Text
        theCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = Me.tbname.Text
        theCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Me.tbemail.Text
        theCommand.Parameters.Add("@Address", SqlDbType.VarChar).Value = Me.tbaddress.Text
        theCommand.Parameters.Add("@DateOfBirth", SqlDbType.Date).Value = Me.dateofbirth.Value.Date
        theCommand.Parameters.Add("@JobID", SqlDbType.Int).Value = Me.cbjob.Text
        theCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Me.id.Text

        theCommand.Connection = theConnection
        theCommand.CommandText = "DELETE FROM Employee WHERE ID = @ID"
        index = MsgBox("Delete?", vbQuestion + vbYesNoCancel, "Delete")

        If index = vbYes Then
            Me.EmployeeTableAdapter.Fill(Me.SMK_HotelDataSet.Employee)

            MessageBox.Show("Data Deleted")
            clear()
        ElseIf index = vbNo Then

            MessageBox.Show("Data Not Deleted")

        End If


        theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()


    End Sub



    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        tbusername.Text = ""
        tbpassword.Text = ""
        tbname.Text = ""
        tbemail.Text = ""
        tbconfirmpassword.Text = ""
        tbaddress.Text = ""
        cbjob.Text = ""
        dateofbirth.Text = ""
    End Sub
End Class
