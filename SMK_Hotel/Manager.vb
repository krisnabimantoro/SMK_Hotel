Public Class Manager
    Private Sub Manager_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnreportres_Click(sender As Object, e As EventArgs) Handles btnreportres.Click
        ReservationReport.Show()
        Me.Close()
    End Sub

    Private Sub btnreportckin_Click(sender As Object, e As EventArgs) Handles btnreportckin.Click
        CheckIn.Show()
        Me.Close()
    End Sub

    Private Sub btntransactioncustomer_Click(sender As Object, e As EventArgs) Handles btntransactioncustomer.Click
        TransactionCustomerReport.Show()
        Me.Close()
    End Sub

    Private Sub btnreportckout_Click(sender As Object, e As EventArgs) Handles btnreportckout.Click
        CheckOutReport.Show()
        Me.Close()
    End Sub
End Class