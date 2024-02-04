Imports System.Data.SqlClient

Public Class InputItem
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Dim index As String

    Private Sub InputItem_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet1.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter1.Fill(Me.SMK_HotelDataSet1.Item)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.SMK_HotelDataSet.Item)
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick
        On Error Resume Next

        ID.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value
        tbitem.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value
        tbprice.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value
        nudqty.Value = DataGridView1.Rows(e.RowIndex).Cells(3).Value

    End Sub

    Private Sub btninsert_Click(sender As Object, e As EventArgs) Handles btninsert.Click
        theConnection.Open()
        theCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = Me.tbitem.Text
        theCommand.Parameters.Add("@Price", SqlDbType.Int).Value = Me.tbprice.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.VarChar).Value = Me.nudqty.Value

        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = "Insert into Item (Name,Price,Qty) values (@Name,@Price,@Qty)"
            theDataReader = theCommand.ExecuteReader
            Me.ItemTableAdapter1.Fill(Me.SMK_HotelDataSet1.Item)

            clear()
            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()


        End Using
    End Sub
    Private Sub clear()
        tbitem.Text = ""
        tbprice.Text = ""
        nudqty.Value = "0"
    End Sub
    Private Sub btnupdate_Click(sender As Object, e As EventArgs) Handles btnupdate.Click
        theConnection.Open()

        theCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = Me.tbitem.Text
        theCommand.Parameters.Add("@Price", SqlDbType.Int).Value = Me.tbprice.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.VarChar).Value = Me.nudqty.Value

        theCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Me.ID.Text

        Using theDataReader
            'Setup
            theCommand.Connection = theConnection
            theCommand.CommandText = "UPDATE Item SET Name = @Name, Price = @Price, Qty =  @Qty  WHERE ID = @ID "

            If theCommand.ExecuteNonQuery = 1 Then
                Me.ItemTableAdapter1.Fill(Me.SMK_HotelDataSet1.Item)
                MessageBox.Show("Data Updated")

            Else
                MessageBox.Show("Data Not Updated")

            End If
            clear()
            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()

        End Using
    End Sub

    Private Sub btndelete_Click(sender As Object, e As EventArgs) Handles btndelete.Click

        theConnection.Open()


        theCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = Me.tbitem.Text
        theCommand.Parameters.Add("@Price", SqlDbType.Int).Value = Me.tbprice.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.VarChar).Value = Me.nudqty.Value

        theCommand.Parameters.Add("@ID", SqlDbType.Int).Value = Me.ID.Text

        theCommand.Connection = theConnection
        theCommand.CommandText = "DELETE FROM Item WHERE ID = @ID"


        index = MsgBox("Delete?", vbQuestion + vbYesNoCancel, "Delete")
        If theCommand.ExecuteNonQuery() = 1 Then
            If Index = vbYes Then
                Me.ItemTableAdapter1.Fill(Me.SMK_HotelDataSet1.Item)

                MessageBox.Show("Data Deleted")
                clear()
            ElseIf Index = vbNo Then

                MessageBox.Show("Data Not Deleted")



            End If
            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()
        End If
    End Sub

    Private Sub btnreqadditem_Click(sender As Object, e As EventArgs) Handles btnreqadditem.Click
        Request_Additional_Item.Show()
        Me.Close()

    End Sub
End Class