Imports System.Data.SqlClient

Public Class LoginForm
    Dim theConnection As New SqlConnection
    Dim theCommand As New SqlCommand
    Dim theDataReader As SqlDataReader
    Private Sub LoginForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        theConnection.ConnectionString = "SERVER = .\SQLEXPRESS; DATABASE = SMK_Hotel; INTEGRATED SECURITY = TRUE"
        tbusername.Select()
        CenterToScreen()

    End Sub

    Private Sub btnlogin_Click(sender As Object, e As EventArgs) Handles btnlogin.Click
        theConnection.Open()
        theCommand.Parameters.Add("@Username", SqlDbType.VarChar).Value = Me.tbusername.Text
        theCommand.Parameters.Add("@Password", SqlDbType.NVarChar).Value = Me.tbpassword.Text

        Using theDataReader
            theCommand.Connection = theConnection
            theCommand.CommandText = "SELECT Username, Password, JobID FROM Employee WHERE Username = @Username AND Password = @Password"
            theDataReader = theCommand.ExecuteReader()

            If theDataReader.Read = True Then
                If theDataReader("JobID") = "1" Then
                    FrontOffice.Show()
                    Me.Hide()
                End If
                If theDataReader("JobID") = "2" Then
                    RoomService.Show()
                    Me.Hide()
                End If
                If theDataReader("JobID") = "3" Then
                    FoodBeverage.Show()
                    Me.Hide()
                End If
                If theDataReader("JobID") = "4" Then
                    Manager.Show()
                    Me.Hide()

                End If
            Else
                MsgBox("Please try again, your username or password is wrong ", 0, "Login")
                theCommand.Parameters.Clear()
                theCommand.Dispose()
                theConnection.Close()
            End If
        End Using
    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Me.Close()

    End Sub
End Class
