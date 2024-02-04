Imports System.Data.SqlClient

Public Class InputMenu
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Dim index As String
    Private Sub btntransaction_Click(sender As Object, e As EventArgs) Handles btntransaction.Click
        Request_Additional_Item.Show()
        Me.Hide()
    End Sub

    Private Sub InputMenu_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.FoodBeverage' table. You can move, or remove it, as needed.
        Me.FoodBeverageTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverage)
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        theConnection.Open()

        theCommand.Parameters.Add("@FoodName", SqlDbType.VarChar).Value = Me.cbitem.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.Int).Value = Me.nudqty.Value
        theCommand.Parameters.Add("@Price", SqlDbType.Int).Value = Me.tbprice.Text

        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = ("insert INTO FoodBeverage (FoodName, Qty, Price) values (@FoodName, @Qty, @Price)")
            theCommand.ExecuteReader()
            Me.FoodBeverageTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverage)

            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()
        End Using
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvinputmenu.CellContentClick
        On Error Resume Next
        id.Text = dgvinputmenu.Rows(e.RowIndex).Cells(0).Value
        cbitem.Text = dgvinputmenu.Rows(e.RowIndex).Cells(1).Value
        nudqty.Value = dgvinputmenu.Rows(e.RowIndex).Cells(2).Value
        tbprice.Text = dgvinputmenu.Rows(e.RowIndex).Cells(3).Value

    End Sub

    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        theConnection.Open()

        theCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Me.id.Text
        theCommand.Parameters.Add("@FoodName", SqlDbType.VarChar).Value = Me.cbitem.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.Int).Value = Me.nudqty.Value
        theCommand.Parameters.Add("@Price", SqlDbType.Int).Value = Me.tbprice.Text

        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = ("Update FoodBeverage SET FoodName=@FoodName, Qty=@Qty, Price=@Price Where ID=@ID")
            If theCommand.ExecuteNonQuery = 1 Then
                Me.FoodBeverageTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverage)
                MessageBox.Show("Data Updated")

            Else
                MessageBox.Show("Data Not Updated")

            End If
            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()
        End Using

    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click
        theConnection.Open()

        theCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Me.id.Text
        theCommand.Parameters.Add("@FoodName", SqlDbType.VarChar).Value = Me.cbitem.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.Int).Value = Me.nudqty.Value
        theCommand.Parameters.Add("@Price", SqlDbType.Int).Value = Me.tbprice.Text

        theCommand.Connection = theConnection
        theCommand.CommandText = "DELETE FROM FoodBeverage WHERE ID = @ID"

        index = MsgBox("Delete?", vbQuestion + vbYesNoCancel, "Delete")
        If index = vbYes Then
            Me.FoodBeverageTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverage)
            MessageBox.Show("Data deleted")

        ElseIf index = vbNo Then
            MessageBox.Show("Data Not Delete")
        End If
        theCommand.Parameters.Clear()
        theCommand.Dispose()
        theConnection.Close()
    End Sub
End Class