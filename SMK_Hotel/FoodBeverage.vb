Imports System.Data.SqlClient
Public Class FoodBeverage

    Private Sub btninputitem_Click(sender As Object, e As EventArgs) Handles btninputitem.Click
        InputMenu.Show()
        Me.Hide()
    End Sub

    Private Sub btntransaction_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        TransactionFoodBeverage.Show()
        Me.Hide()

    End Sub
End Class