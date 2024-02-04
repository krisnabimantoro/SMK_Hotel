Public Class FrontOffice
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub FrontOffice_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        CenterToScreen()

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
        MasterRoom.Show()
        Me.Hide()
    End Sub

    Private Sub btntransaction_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        Display_RoomService_and_FoodBeverage.Show()
        Me.Close()
    End Sub
End Class