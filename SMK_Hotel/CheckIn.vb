Imports System.Data.SqlClient
Public Class CheckIn
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Dim Gender As String
    Private Sub CheckIn_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRoom' table. You can move, or remove it, as needed.
        Me.ReservationRoomTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRoom)
        theConnection.ConnectionString = "SERVER = KRISNA-BIMANTOR\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"
        FilterData("")
    End Sub

    Private Sub btncheckin_Click(sender As Object, e As EventArgs) Handles btncheckin.Click
        theConnection.Open()
        If rbmale.Checked = True Then
            Gender = rbmale.Text
        ElseIf rbfemale.Checked = True Then
            Gender = rbfemale.Text
        End If
        theCommand.Parameters.Add("@PhoneNumber", SqlDbType.VarChar).Value = Me.tbphonenumber.Text
        theCommand.Parameters.Add("@Name", SqlDbType.VarChar).Value = Me.tbname.Text
        theCommand.Parameters.Add("@Email", SqlDbType.VarChar).Value = Me.tbemail.Text
        theCommand.Parameters.Add("@Gender", SqlDbType.Char).Value = Gender
        theCommand.Parameters.Add("@Age", SqlDbType.Int).Value = Me.tbage.Text
        theCommand.Parameters.Add("@NIK", SqlDbType.VarChar).Value = Me.tbnik.Text

        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = "INSERT INTO Customer (PhoneNumber, Name, Email, Gender, Age, NIK) VALUES (@PhoneNumber, @Name, @Email, @Gender, @Age, @NIK)"
            theDataReader = theCommand.ExecuteReader()
            Me.ReservationRoomTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRoom)
            theCommand.Parameters.Clear()
            theCommand.Dispose()
            theConnection.Close()

            Me.tbphonenumber.Clear()
            Me.tbname.Clear()
            Me.tbemail.Clear()
            Me.tbage.Clear()
            Me.tbnik.Clear()


        End Using
    End Sub
    Private Sub FilterData(valueToSearch As String)
        Dim searchQuery As String = "SELECT * FROM ReservationRoom WHERE ReservationID like'%" & valueToSearch & "%'"
        Dim command As New SqlCommand(searchQuery, theConnection)
        Dim Adapter As New SqlDataAdapter(command)
        Dim table As New DataTable()
        Adapter.Fill(table)
        dgvroomdetail.DataSource = table
        theConnection.Close()
    End Sub

    Private Sub btnsearch_Click(sender As Object, e As EventArgs) Handles btnsearch.Click
        FilterData(tbbookingcode.Text)
    End Sub
End Class