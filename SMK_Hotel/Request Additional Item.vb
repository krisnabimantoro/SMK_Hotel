Imports System.Data.SqlClient

Public Class Request_Additional_Item
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Private Sub btnreqadditem_Click(sender As Object, e As EventArgs) Handles btnreqadditem.Click

    End Sub

    Private Sub btninputitem_Click(sender As Object, e As EventArgs) Handles btninputitem.Click
        InputItem.Show()
        Me.Hide()
    End Sub

    Private Sub Request_Additional_Item_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet1.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter1.Fill(Me.SMK_HotelDataSet1.Item)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRoom' table. You can move, or remove it, as needed.
        Me.ReservationRoomTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRoom)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRequestItem' table. You can move, or remove it, as needed.
        Me.ReservationRequestItemTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRequestItem)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.SMK_HotelDataSet.Item)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.FoodBeverageDetail' table. You can move, or remove it, as needed.
        Me.FoodBeverageDetailTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverageDetail)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.SMK_HotelDataSet.Room)
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        theConnection.Open()
        theCommand.Parameters.Add("@ReservationRoomID", SqlDbType.Int).Value = Me.ComboBox4.Text
        theCommand.Parameters.Add("@ItemID", SqlDbType.Int).Value = Me.ComboBox3.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.Int).Value = Me.nudqty.Value
        theCommand.Parameters.Add("@TotalPrice", SqlDbType.Int).Value = Me.tambah.Text

        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = ("insert INTO ReservationRequestItem (ReservationRoomID, ItemID, Qty, TotalPrice) values (@ReservationRoomID, @ItemID, @Qty, @TotalPrice)")
            ' theCommand.CommandText = ("Update  FoodBeverage  SET Qty=@Qty where ID=@FoodBeverageID")
            theCommand.ExecuteReader()
            'Me.FoodBeverageDetailTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverageDetail)
            MessageBox.Show("data telah terisi")



            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()
        End Using



    End Sub

    Private Sub btnadd_Click(sender As Object, e As EventArgs) Handles btnadd.Click

        Me.hitung.Text = Me.cbprice.SelectedValue * Me.nudqty.Value
        Me.tambah.Text = Me.cbprice.SelectedValue * Me.nudqty.Value + Me.tambah.Text
        Try
            With dgvreqadd
                .Rows.Add(1)

                .Rows(dgvreqadd.RowCount - 2).Cells(0).Value = cbitem.Text
                .Rows(dgvreqadd.RowCount - 2).Cells(1).Value = hitung.Text
                .Rows(dgvreqadd.RowCount - 2).Cells(2).Value = nudqty.Value


            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try
    End Sub
End Class