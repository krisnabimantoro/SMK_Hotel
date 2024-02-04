Imports System.Data.SqlClient

Public Class Reservation
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Private Sub Reservation_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.RoomType' table. You can move, or remove it, as needed.
        Me.RoomTypeTableAdapter.Fill(Me.SMK_HotelDataSet.RoomType)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRequestItem' table. You can move, or remove it, as needed.
        Me.ReservationRequestItemTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRequestItem)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet1.Item' table. You can move, or remove it, as needed.
        Me.ItemTableAdapter.Fill(Me.SMK_HotelDataSet1.Item)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRoom' table. You can move, or remove it, as needed.
        Me.ReservationRoomTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRoom)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.Room' table. You can move, or remove it, as needed.
        Me.RoomTableAdapter.Fill(Me.SMK_HotelDataSet.Room)
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"
        FilterData("")
        Timer1.Enabled = True
    End Sub
    Private Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * FROM Room WHERE RoomNumber like '%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, theConnection)
        Dim adapter As New SqlDataAdapter(command)
        Dim table As New DataTable
        adapter.Fill(table)
        dgvavailableroom.DataSource = table
        theConnection.Close()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            Dim table1 As DataGridView = dgvavailableroom
            Dim table2 As DataGridView = dgvselectedroom

            With table2
                .Rows.Add(1)
                .Rows(table2.RowCount - 2).Cells(0).Value = table1.Rows(table1.CurrentRow.Index).Cells(2).Value
                .Rows(table2.RowCount - 2).Cells(1).Value = table1.Rows(table1.CurrentRow.Index).Cells(3).Value
                .Rows(table2.RowCount - 2).Cells(2).Value = table1.Rows(table1.CurrentRow.Index).Cells(4).Value
                .Rows(table2.RowCount - 2).Cells(3).Value = cbroomprice.Text

            End With

        Catch ex As Exception
            MsgBox(ex.ToString)
        End Try


    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        FilterData(cbroomnumber.Text)

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

    Private Sub dgvavailableroom_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvavailableroom.CellContentClick

    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label14.Text = Format(Now, "dd/mm/yyyy")
    End Sub

    Private Sub btnsubmit_Click(sender As Object, e As EventArgs) Handles btnsubmit.Click
        'Dim CustID As String
        'Dim Code As Integer
        'Code = 1
        'theCommand = New SqlCommand("INSERT INTO Reservation(DateTime, EmployeeID, CustomerID, Code) VALUES('" & Format(DateTimePicker1.Value, "yyyy-MM-dd hh:mm:ss") & "', '" & Session.EmployeeID & "', '" & CustID & "', '" & Code & "') ", theConnection)
        'theCommand.ExecuteNonQuery()

    End Sub
End Class