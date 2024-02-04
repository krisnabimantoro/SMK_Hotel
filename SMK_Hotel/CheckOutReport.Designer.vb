<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOutReport
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
        Me.components = New System.ComponentModel.Container()
        Me.btnexportexcel = New System.Windows.Forms.Button()
        Me.dgv1 = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnreportckout = New System.Windows.Forms.Button()
        Me.btnreportckin = New System.Windows.Forms.Button()
        Me.btntransactioncustomer = New System.Windows.Forms.Button()
        Me.btnreportres = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SMK_HotelDataSet2 = New SMK_Hotel.SMK_HotelDataSet2()
        Me.ReservationCheckOutBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationCheckOutTableAdapter = New SMK_Hotel.SMK_HotelDataSet2TableAdapters.ReservationCheckOutTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationRoomIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBeveregeDetailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalChargeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationCheckOutBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexportexcel
        '
        Me.btnexportexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexportexcel.Location = New System.Drawing.Point(144, 319)
        Me.btnexportexcel.Name = "btnexportexcel"
        Me.btnexportexcel.Size = New System.Drawing.Size(112, 34)
        Me.btnexportexcel.TabIndex = 105
        Me.btnexportexcel.Text = "Export Excel"
        Me.btnexportexcel.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AutoGenerateColumns = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReservationRoomIDDataGridViewTextBoxColumn, Me.ItemIDDataGridViewTextBoxColumn, Me.FoodBeveregeDetailIDDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.TotalChargeDataGridViewTextBoxColumn})
        Me.dgv1.DataSource = Me.ReservationCheckOutBindingSource
        Me.dgv1.Location = New System.Drawing.Point(144, 145)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(720, 168)
        Me.dgv1.TabIndex = 104
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(141, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(122, 17)
        Me.Label3.TabIndex = 101
        Me.Label3.Text = "Check-Out Report"
        '
        'btnreportckout
        '
        Me.btnreportckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportckout.Location = New System.Drawing.Point(12, 145)
        Me.btnreportckout.Name = "btnreportckout"
        Me.btnreportckout.Size = New System.Drawing.Size(98, 36)
        Me.btnreportckout.TabIndex = 100
        Me.btnreportckout.Text = "Check-Out   Report"
        Me.btnreportckout.UseVisualStyleBackColor = True
        '
        'btnreportckin
        '
        Me.btnreportckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportckin.Location = New System.Drawing.Point(12, 103)
        Me.btnreportckin.Name = "btnreportckin"
        Me.btnreportckin.Size = New System.Drawing.Size(98, 36)
        Me.btnreportckin.TabIndex = 99
        Me.btnreportckin.Text = "Check-In   Report"
        Me.btnreportckin.UseVisualStyleBackColor = True
        '
        'btntransactioncustomer
        '
        Me.btntransactioncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransactioncustomer.Location = New System.Drawing.Point(12, 187)
        Me.btntransactioncustomer.Name = "btntransactioncustomer"
        Me.btntransactioncustomer.Size = New System.Drawing.Size(98, 36)
        Me.btntransactioncustomer.TabIndex = 98
        Me.btntransactioncustomer.Text = "Transaction Customer Report"
        Me.btntransactioncustomer.UseVisualStyleBackColor = True
        '
        'btnreportres
        '
        Me.btnreportres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportres.Location = New System.Drawing.Point(12, 61)
        Me.btnreportres.Name = "btnreportres"
        Me.btnreportres.Size = New System.Drawing.Size(98, 36)
        Me.btnreportres.TabIndex = 97
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
        Me.Label2.TabIndex = 96
        Me.Label2.Text = "Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 95
        Me.Label1.Text = "SMK Hotel"
        '
        'SMK_HotelDataSet2
        '
        Me.SMK_HotelDataSet2.DataSetName = "SMK_HotelDataSet2"
        Me.SMK_HotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationCheckOutBindingSource
        '
        Me.ReservationCheckOutBindingSource.DataMember = "ReservationCheckOut"
        Me.ReservationCheckOutBindingSource.DataSource = Me.SMK_HotelDataSet2
        '
        'ReservationCheckOutTableAdapter
        '
        Me.ReservationCheckOutTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'ReservationRoomIDDataGridViewTextBoxColumn
        '
        Me.ReservationRoomIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationRoomID"
        Me.ReservationRoomIDDataGridViewTextBoxColumn.HeaderText = "ReservationRoomID"
        Me.ReservationRoomIDDataGridViewTextBoxColumn.Name = "ReservationRoomIDDataGridViewTextBoxColumn"
        '
        'ItemIDDataGridViewTextBoxColumn
        '
        Me.ItemIDDataGridViewTextBoxColumn.DataPropertyName = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.HeaderText = "ItemID"
        Me.ItemIDDataGridViewTextBoxColumn.Name = "ItemIDDataGridViewTextBoxColumn"
        '
        'FoodBeveregeDetailIDDataGridViewTextBoxColumn
        '
        Me.FoodBeveregeDetailIDDataGridViewTextBoxColumn.DataPropertyName = "FoodBeveregeDetailID"
        Me.FoodBeveregeDetailIDDataGridViewTextBoxColumn.HeaderText = "FoodBeveregeDetailID"
        Me.FoodBeveregeDetailIDDataGridViewTextBoxColumn.Name = "FoodBeveregeDetailIDDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'TotalChargeDataGridViewTextBoxColumn
        '
        Me.TotalChargeDataGridViewTextBoxColumn.DataPropertyName = "TotalCharge"
        Me.TotalChargeDataGridViewTextBoxColumn.HeaderText = "TotalCharge"
        Me.TotalChargeDataGridViewTextBoxColumn.Name = "TotalChargeDataGridViewTextBoxColumn"
        '
        'CheckOutReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btnexportexcel)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreportckout)
        Me.Controls.Add(Me.btnreportckin)
        Me.Controls.Add(Me.btntransactioncustomer)
        Me.Controls.Add(Me.btnreportres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CheckOutReport"
        Me.Text = "CheckOutReport"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationCheckOutBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnexportexcel As Button
    Friend WithEvents dgv1 As DataGridView
    Friend WithEvents Label3 As Label
    Friend WithEvents btnreportckout As Button
    Friend WithEvents btnreportckin As Button
    Friend WithEvents btntransactioncustomer As Button
    Friend WithEvents btnreportres As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SMK_HotelDataSet2 As SMK_HotelDataSet2
    Friend WithEvents ReservationCheckOutBindingSource As BindingSource
    Friend WithEvents ReservationCheckOutTableAdapter As SMK_HotelDataSet2TableAdapters.ReservationCheckOutTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationRoomIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodBeveregeDetailIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalChargeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
