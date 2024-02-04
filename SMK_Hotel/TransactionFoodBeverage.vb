Imports System.Data.SqlClient

Public Class TransactionFoodBeverage
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Dim theDataAdapter As New SqlDataAdapter(Sql, theConnection)
    Dim sql As String
    Dim ds As New DataSet
    Private Sub TransactionFoodBeverage_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.FoodBeverage' table. You can move, or remove it, as needed.
        Me.FoodBeverageTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverage)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.SMK_HotelDataSet.Room)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.FoodBeverageDetail' table. You can move, or remove it, as needed.
        Me.FoodBeverageDetailTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverageDetail)
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"
        ' tampil()

    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        theConnection.Open()

        theCommand.Parameters.Add("@RoomID", SqlDbType.Int).Value = Me.cbroomid.Text
        theCommand.Parameters.Add("@FoodBeverageID", SqlDbType.Int).Value = Me.cbfoodID.Text
        theCommand.Parameters.Add("@TotalPrice", SqlDbType.Int).Value = Me.tambah.Text
        theCommand.Parameters.Add("@Qty", SqlDbType.Int).Value = Me.simpanqty.Text



        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = ("insert INTO FoodBeverageDetail (FoodBeverageID, RoomID, TotalPrice) values (@FoodBeverageID, @RoomID, @TotalPrice)")
            theCommand.CommandText = ("Update  FoodBeverage  SET Qty=@Qty where ID=@FoodBeverageID")
            theCommand.ExecuteReader()
            'Me.FoodBeverageDetailTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverageDetail)
            MessageBox.Show("data telah terisi")



            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()
        End Using


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnadd.Click
        Me.hitung.Text = Me.cbprice.SelectedValue * Me.nudqty.Value

        Me.tambah.Text = Me.cbprice.SelectedValue * Me.nudqty.Value + Me.tambah.Text
        Me.simpanqty.Text = Me.cbqty.SelectedValue - Me.nudqty.Value
        Try
            With DataGridView1
                .Rows.Add(1)
                .Rows(DataGridView1.RowCount - 2).Cells(0).Value = cbroomnumber.Text
                .Rows(DataGridView1.RowCount - 2).Cells(1).Value = cbitem.Text
                .Rows(DataGridView1.RowCount - 2).Cells(2).Value = nudqty.Value
                .Rows(DataGridView1.RowCount - 2).Cells(3).Value = hitung.Text

            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub tbprice_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub cbitem_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbitem.SelectedIndexChanged

    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles tambah.Click

    End Sub

    Private Sub cbprice_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbprice.SelectedIndexChanged

    End Sub
End Class