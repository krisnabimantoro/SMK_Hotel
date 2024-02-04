Imports System.Data.SqlClient

Public Class MasterRoom
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Dim index As Integer
    Private Sub MasterRoom_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.RoomType' table. You can move, or remove it, as needed.
        Me.RoomTypeTableAdapter.Fill(Me.SMK_HotelDataSet.RoomType)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.SMK_HotelDataSet.Room)
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"
        cbroomtype.Text = ("")
    End Sub
    Private Sub btnmasteruser_Click(sender As Object, e As EventArgs) Handles btnmasteruser.Click
        MasterUser.Show()
        Me.Hide()
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

    End Sub

    Private Sub btntransaction_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        Display_RoomService_and_FoodBeverage.Show()
        Me.Close()
    End Sub
    Private Sub clear()
        tbroomnumber.Clear()
        tbdescription.Clear()
        tbroomfloor.Clear()
        cbroomtype.Text = ("")

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        theConnection.Open()
        theCommand.Parameters.Add("@RoomNumber", SqlDbType.VarChar).Value = Me.tbroomnumber.Text
        theCommand.Parameters.Add("@RoomTypeID", SqlDbType.Int).Value = Me.cbroomtype.SelectedValue
        theCommand.Parameters.Add("@RoomFloor", SqlDbType.VarChar).Value = Me.tbroomfloor.Text
        theCommand.Parameters.Add("@Description", SqlDbType.Text).Value = Me.tbdescription.Text

        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = "insert INTO Room (RoomTypeID, RoomNumber, RoomFloor, Description) values (@RoomTypeID, @RoomNumber, @RoomFloor, @Description)"
            theDataReader = theCommand.ExecuteReader()
            Me.RoomTableAdapter.Fill(Me.SMK_HotelDataSet.Room)
            Me.Show()
            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()

            clear()
        End Using
    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        theConnection.Open()

        theCommand.Parameters.Add("@Description", SqlDbType.Text).Value = Me.tbdescription.Text
        theCommand.Parameters.Add("@RoomFloor", SqlDbType.VarChar).Value = Me.tbroomfloor.Text
        theCommand.Parameters.Add("@RoomNumber", SqlDbType.VarChar).Value = Me.tbroomnumber.Text
        theCommand.Parameters.Add("@RoomTypeID", SqlDbType.Int).Value = Me.cbroomtype.SelectedValue
        theCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Me.ID.Text

        Using theDataReader
            'Setup
            theCommand.Connection = theConnection
            theCommand.CommandText = "UPDATE Room SET Description = @Description, RoomNumber = @RoomNumber, RoomFloor = @RoomFloor, RoomTypeID = @RoomTypeID WHERE ID = @ID "

            If theCommand.ExecuteNonQuery = 1 Then
                Me.RoomTableAdapter.Fill(Me.SMK_HotelDataSet.Room)
                MessageBox.Show("Data Updated")

            Else
                MessageBox.Show("Data Not Updated")

            End If

            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()
            clear()
        End Using
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        theConnection.Open()

        theCommand.Parameters.Add("@Description", SqlDbType.Text).Value = Me.tbdescription.Text
        theCommand.Parameters.Add("@RoomFloor", SqlDbType.VarChar).Value = Me.tbroomfloor.Text
        theCommand.Parameters.Add("@RoomNumber", SqlDbType.VarChar).Value = Me.tbroomnumber.Text
        theCommand.Parameters.Add("@RoomTypeID", SqlDbType.Int).Value = Me.cbroomtype.SelectedValue
        theCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Me.ID.Text

        theCommand.Connection = theConnection
        theCommand.CommandText = "DELETE FROM Room WHERE ID = @ID"


        index = MsgBox("Delete?", vbQuestion + vbYesNoCancel, "Delete")
        If theCommand.ExecuteNonQuery() = 1 Then
            If index = vbYes Then
                Me.RoomTableAdapter.Fill(Me.SMK_HotelDataSet.Room)

                MessageBox.Show("Data Deleted")
                clear()
            ElseIf index = vbNo Then

                MessageBox.Show("Data Not Deleted")

            End If
            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()
        End If
    End Sub

    Private Sub dgvmasterroom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvmasterroom.CellContentClick
        On Error Resume Next

        ID.Text = dgvmasterroom.Rows(e.RowIndex).Cells(0).Value
        cbroomtype.Text = dgvmasterroom.Rows(e.RowIndex).Cells(1).Value
        tbroomnumber.Text = dgvmasterroom.Rows(e.RowIndex).Cells(2).Value
        tbroomfloor.Text = dgvmasterroom.Rows(e.RowIndex).Cells(3).Value
        tbdescription.Text = dgvmasterroom.Rows(e.RowIndex).Cells(4).Value

    End Sub



    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
        tbdescription.Text = ""
        tbroomfloor.Text = ""
        tbroomnumber.Text = ""
        cbroomtype.Text = ""

    End Sub
End Class
