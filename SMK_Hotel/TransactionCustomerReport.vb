Public Class TransactionCustomerReport
    Private Sub TransactionCustomerReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet2.FoodBeverageDetail' table. You can move, or remove it, as needed.
        Me.FoodBeverageDetailTableAdapter1.Fill(Me.SMK_HotelDataSet2.FoodBeverageDetail)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.FoodBeverageDetail' table. You can move, or remove it, as needed.
        Me.FoodBeverageDetailTableAdapter.Fill(Me.SMK_HotelDataSet.FoodBeverageDetail)
        'TODO: This line of code loads data into the 'SMK_HotelDataSet.ReservationRequestItem' table. You can move, or remove it, as needed.
        Me.ReservationRequestItemTableAdapter.Fill(Me.SMK_HotelDataSet.ReservationRequestItem)

    End Sub

    Private Sub btnexportexcel_Click(sender As Object, e As EventArgs) Handles btnexportexcel.Click

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        For i = 0 To dgv1.RowCount - 2
            For j = 0 To dgv1.RowCount - 1
                For k As Integer = 1 To dgv1.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgv1.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgv1(j, i).Value.ToString
                Next
            Next
        Next
        xlWorkSheet.SaveAs("E:\Room Service Report.xls")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("file save in E:\Room Service Report.xls")
    End Sub
    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.ReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()

        End Try

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim xlApp As Microsoft.Office.Interop.Excel.Application
        Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
        Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
        Dim misValue As Object = System.Reflection.Missing.Value
        Dim i As Integer
        Dim j As Integer

        xlApp = New Microsoft.Office.Interop.Excel.Application
        xlWorkBook = xlApp.Workbooks.Add(misValue)
        xlWorkSheet = xlWorkBook.Sheets("Sheet1")

        For i = 0 To dgv2.RowCount - 2
            For j = 0 To dgv2.RowCount - 1
                For k As Integer = 1 To dgv2.Columns.Count
                    xlWorkSheet.Cells(1, k) = dgv2.Columns(k - 1).HeaderText
                    xlWorkSheet.Cells(i + 2, j + 1) = dgv2(j, i).Value.ToString
                Next
            Next
        Next
        xlWorkSheet.SaveAs("E:\Reservation Report.xls")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("file save in E:\lks.xls")
    End Sub


End Class