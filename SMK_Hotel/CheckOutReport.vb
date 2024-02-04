Public Class CheckOutReport
    Private Sub CheckOutReport_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'SMK_HotelDataSet2.ReservationCheckOut' table. You can move, or remove it, as needed.
        Me.ReservationCheckOutTableAdapter.Fill(Me.SMK_HotelDataSet2.ReservationCheckOut)

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
        xlWorkSheet.SaveAs("E:\Reservation Report.xls")
        xlWorkBook.Close()
        xlApp.Quit()

        releaseObject(xlApp)
        releaseObject(xlWorkBook)
        releaseObject(xlWorkSheet)
        MsgBox("file save in E:\lks.xls")
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

End Class