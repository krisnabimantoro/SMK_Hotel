<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckinReport
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnexportexcel = New System.Windows.Forms.Button()
        Me.dgvckinreport = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnreportckout = New System.Windows.Forms.Button()
        Me.btnreportckin = New System.Windows.Forms.Button()
        Me.btntransactioncustomer = New System.Windows.Forms.Button()
        Me.btnreportres = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgvckinreport, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexportexcel
        '
        Me.btnexportexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexportexcel.Location = New System.Drawing.Point(144, 319)
        Me.btnexportexcel.Name = "btnexportexcel"
        Me.btnexportexcel.Size = New System.Drawing.Size(112, 34)
        Me.btnexportexcel.TabIndex = 94
        Me.btnexportexcel.Text = "Export Excel"
        Me.btnexportexcel.UseVisualStyleBackColor = True
        '
        'dgvckinreport
        '
        Me.dgvckinreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvckinreport.Location = New System.Drawing.Point(144, 145)
        Me.dgvckinreport.Name = "dgvckinreport"
        Me.dgvckinreport.Size = New System.Drawing.Size(720, 168)
        Me.dgvckinreport.TabIndex = 93
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(141, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 17)
        Me.Label3.TabIndex = 90
        Me.Label3.Text = "Check-In Report"
        '
        'btnreportckout
        '
        Me.btnreportckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportckout.Location = New System.Drawing.Point(12, 145)
        Me.btnreportckout.Name = "btnreportckout"
        Me.btnreportckout.Size = New System.Drawing.Size(98, 36)
        Me.btnreportckout.TabIndex = 89
        Me.btnreportckout.Text = "Check-Out   Report"
        Me.btnreportckout.UseVisualStyleBackColor = True
        '
        'btnreportckin
        '
        Me.btnreportckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportckin.Location = New System.Drawing.Point(12, 103)
        Me.btnreportckin.Name = "btnreportckin"
        Me.btnreportckin.Size = New System.Drawing.Size(98, 36)
        Me.btnreportckin.TabIndex = 88
        Me.btnreportckin.Text = "Check-In   Report"
        Me.btnreportckin.UseVisualStyleBackColor = True
        '
        'btntransactioncustomer
        '
        Me.btntransactioncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransactioncustomer.Location = New System.Drawing.Point(12, 187)
        Me.btntransactioncustomer.Name = "btntransactioncustomer"
        Me.btntransactioncustomer.Size = New System.Drawing.Size(98, 36)
        Me.btntransactioncustomer.TabIndex = 87
        Me.btntransactioncustomer.Text = "Transaction Customer Report"
        Me.btntransactioncustomer.UseVisualStyleBackColor = True
        '
        'btnreportres
        '
        Me.btnreportres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportres.Location = New System.Drawing.Point(12, 61)
        Me.btnreportres.Name = "btnreportres"
        Me.btnreportres.Size = New System.Drawing.Size(98, 36)
        Me.btnreportres.TabIndex = 86
        Me.btnreportres.Text = "Reservation Report"
        Me.btnreportres.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 15)
        Me.Label2.TabIndex = 85
        Me.Label2.Text = "Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 84
        Me.Label1.Text = "SMK Hotel"
        '
        'CheckinReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btnexportexcel)
        Me.Controls.Add(Me.dgvckinreport)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreportckout)
        Me.Controls.Add(Me.btnreportckin)
        Me.Controls.Add(Me.btntransactioncustomer)
        Me.Controls.Add(Me.btnreportres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CheckinReport"
        Me.Text = "CheckinReport"
        CType(Me.dgvckinreport, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnexportexcel As Button
    Friend WithEvents dgvckinreport As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnreportckout As Button
    Friend WithEvents btnreportckin As Button
    Friend WithEvents btntransactioncustomer As Button
    Friend WithEvents btnreportres As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
