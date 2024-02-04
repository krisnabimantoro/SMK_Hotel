Public Class Display_RoomService_and_FoodBeverage
    Private Sub Display_RoomService_and_FoodBeverage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.FoodBeverageDetail' table. You can move, or remove it, as needed.
        Me.FoodBeverageDetailTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverageDetail)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRequestItem' table. You can move, or remove it, as needed.
        Me.ReservationRequestItemTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRequestItem)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRoom' table. You can move, or remove it, as needed.
        Me.ReservationRoomTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRoom)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet1.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.SMK_HotelDataSet1.Item)

    End Sub
End Class