Imports System.Data.SqlClient
Public Class CheckOut
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Private Sub CheckOut_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRequestItem' table. You can move, or remove it, as needed.
        Me.ReservationRequestItemTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRequestItem)
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"
    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        theConnection.Open()
        theCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = Me.cbitem.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.Int).Value = Me.nudqty.Value
        theCommand.Parameters.Add("@TotalPrice", SqlDbType.Int).Value = Me.price.Text

        theCommand.Connection = theConnection
        theCommand.CommandText = "Insert INTO ReservationRequestItem ( ReservationRoomID,ItemID, Qty, TotalPrice ) Values (@ReservationRoomID, @ItemID, @Qty, @TotalPrice)"
    End Sub

    Private Sub btnmasteruser_Click(sender As Object, e As EventArgs) Handles btnmasteruser.Click

    End Sub
End Class