Public Class RoomService
    Private Sub RoomService_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btninputitem_Click(sender As Object, e As EventArgs) Handles btninputitem.Click
        InputItem.Show()
        Me.Close()
    End Sub

    Private Sub btnreqadditem_Click(sender As Object, e As EventArgs) Handles btnreqadditem.Click
        Request_Additional_Item.Show()
        Me.Close()
    End Sub
End Class