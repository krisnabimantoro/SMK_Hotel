<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionCustomerReport
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
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.ReservationRequestItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRequestItemTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationRoomIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.FoodBeverageDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageDetailTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.FoodBeverageDetailTableAdapter()
        Me.FoodBeverageDetailBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageDetailBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMK_HotelDataSet2 = New SMK_Hotel.SMK_HotelDataSet2()
        Me.FoodBeverageDetailBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageDetailTableAdapter1 = New SMK_Hotel.SMK_HotelDataSet2TableAdapters.FoodBeverageDetailTableAdapter()
        Me.dgv2 = New System.Windows.Forms.DataGridView()
        Me.FoodBeverageDetailBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBeverageIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnexportexcel
        '
        Me.btnexportexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexportexcel.Location = New System.Drawing.Point(144, 232)
        Me.btnexportexcel.Name = "btnexportexcel"
        Me.btnexportexcel.Size = New System.Drawing.Size(112, 34)
        Me.btnexportexcel.TabIndex = 117
        Me.btnexportexcel.Text = "Export Excel"
        Me.btnexportexcel.UseVisualStyleBackColor = True
        '
        'dgv1
        '
        Me.dgv1.AutoGenerateColumns = False
        Me.dgv1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReservationRoomIDDataGridViewTextBoxColumn, Me.ItemIDDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.dgv1.DataSource = Me.ReservationRequestItemBindingSource
        Me.dgv1.Location = New System.Drawing.Point(144, 71)
        Me.dgv1.Name = "dgv1"
        Me.dgv1.Size = New System.Drawing.Size(713, 134)
        Me.dgv1.TabIndex = 116
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(141, 51)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(143, 17)
        Me.Label3.TabIndex = 113
        Me.Label3.Text = "Room Service Report"
        '
        'btnreportckout
        '
        Me.btnreportckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportckout.Location = New System.Drawing.Point(12, 145)
        Me.btnreportckout.Name = "btnreportckout"
        Me.btnreportckout.Size = New System.Drawing.Size(98, 36)
        Me.btnreportckout.TabIndex = 112
        Me.btnreportckout.Text = "Check-Out   Report"
        Me.btnreportckout.UseVisualStyleBackColor = True
        '
        'btnreportckin
        '
        Me.btnreportckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportckin.Location = New System.Drawing.Point(12, 103)
        Me.btnreportckin.Name = "btnreportckin"
        Me.btnreportckin.Size = New System.Drawing.Size(98, 36)
        Me.btnreportckin.TabIndex = 111
        Me.btnreportckin.Text = "Check-In   Report"
        Me.btnreportckin.UseVisualStyleBackColor = True
        '
        'btntransactioncustomer
        '
        Me.btntransactioncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransactioncustomer.Location = New System.Drawing.Point(12, 187)
        Me.btntransactioncustomer.Name = "btntransactioncustomer"
        Me.btntransactioncustomer.Size = New System.Drawing.Size(98, 36)
        Me.btntransactioncustomer.TabIndex = 110
        Me.btntransactioncustomer.Text = "Transaction Customer Report"
        Me.btntransactioncustomer.UseVisualStyleBackColor = True
        '
        'btnreportres
        '
        Me.btnreportres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportres.Location = New System.Drawing.Point(12, 61)
        Me.btnreportres.Name = "btnreportres"
        Me.btnreportres.Size = New System.Drawing.Size(98, 36)
        Me.btnreportres.TabIndex = 109
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
        Me.Label2.TabIndex = 108
        Me.Label2.Text = "Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 107
        Me.Label1.Text = "SMK Hotel"
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationRequestItemBindingSource
        '
        Me.ReservationRequestItemBindingSource.DataMember = "ReservationRequestItem"
        Me.ReservationRequestItemBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'ReservationRequestItemTableAdapter
        '
        Me.ReservationRequestItemTableAdapter.ClearBeforeFill = True
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
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'TotalPriceDataGridViewTextBoxColumn
        '
        Me.TotalPriceDataGridViewTextBoxColumn.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.HeaderText = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn.Name = "TotalPriceDataGridViewTextBoxColumn"
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(144, 465)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(112, 34)
        Me.Button1.TabIndex = 120
        Me.Button1.Text = "Export Excel"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label4.Location = New System.Drawing.Point(141, 284)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(152, 17)
        Me.Label4.TabIndex = 118
        Me.Label4.Text = "Food Beverage Report"
        '
        'FoodBeverageDetailBindingSource
        '
        Me.FoodBeverageDetailBindingSource.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'FoodBeverageDetailTableAdapter
        '
        Me.FoodBeverageDetailTableAdapter.ClearBeforeFill = True
        '
        'FoodBeverageDetailBindingSource1
        '
        Me.FoodBeverageDetailBindingSource1.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'FoodBeverageDetailBindingSource2
        '
        Me.FoodBeverageDetailBindingSource2.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'SMK_HotelDataSet2
        '
        Me.SMK_HotelDataSet2.DataSetName = "SMK_HotelDataSet2"
        Me.SMK_HotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'FoodBeverageDetailBindingSource3
        '
        Me.FoodBeverageDetailBindingSource3.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource3.DataSource = Me.SMK_HotelDataSet2
        '
        'FoodBeverageDetailTableAdapter1
        '
        Me.FoodBeverageDetailTableAdapter1.ClearBeforeFill = True
        '
        'dgv2
        '
        Me.dgv2.AutoGenerateColumns = False
        Me.dgv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.FoodBeverageIDDataGridViewTextBoxColumn, Me.RoomIDDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn1})
        Me.dgv2.DataSource = Me.FoodBeverageDetailBindingSource4
        Me.dgv2.Location = New System.Drawing.Point(144, 309)
        Me.dgv2.Name = "dgv2"
        Me.dgv2.Size = New System.Drawing.Size(713, 132)
        Me.dgv2.TabIndex = 121
        '
        'FoodBeverageDetailBindingSource4
        '
        Me.FoodBeverageDetailBindingSource4.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource4.DataSource = Me.SMK_HotelDataSet2
        '
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        '
        'FoodBeverageIDDataGridViewTextBoxColumn
        '
        Me.FoodBeverageIDDataGridViewTextBoxColumn.DataPropertyName = "FoodBeverageID"
        Me.FoodBeverageIDDataGridViewTextBoxColumn.HeaderText = "FoodBeverageID"
        Me.FoodBeverageIDDataGridViewTextBoxColumn.Name = "FoodBeverageIDDataGridViewTextBoxColumn"
        '
        'RoomIDDataGridViewTextBoxColumn
        '
        Me.RoomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID"
        Me.RoomIDDataGridViewTextBoxColumn.HeaderText = "RoomID"
        Me.RoomIDDataGridViewTextBoxColumn.Name = "RoomIDDataGridViewTextBoxColumn"
        '
        'TotalPriceDataGridViewTextBoxColumn1
        '
        Me.TotalPriceDataGridViewTextBoxColumn1.DataPropertyName = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn1.HeaderText = "TotalPrice"
        Me.TotalPriceDataGridViewTextBoxColumn1.Name = "TotalPriceDataGridViewTextBoxColumn1"
        '
        'TransactionCustomerReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.dgv2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btnexportexcel)
        Me.Controls.Add(Me.dgv1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreportckout)
        Me.Controls.Add(Me.btnreportckin)
        Me.Controls.Add(Me.btntransactioncustomer)
        Me.Controls.Add(Me.btnreportres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "TransactionCustomerReport"
        Me.Text = "TransactionCustomerReport"
        CType(Me.dgv1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgv2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
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
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents ReservationRequestItemBindingSource As BindingSource
    Friend WithEvents ReservationRequestItemTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationRoomIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents FoodBeverageDetailBindingSource As BindingSource
    Friend WithEvents FoodBeverageDetailTableAdapter As SMK_HotelDataSetTableAdapters.FoodBeverageDetailTableAdapter
    Friend WithEvents FoodBeverageDetailBindingSource1 As BindingSource
    Friend WithEvents FoodBeverageDetailBindingSource2 As BindingSource
    Friend WithEvents SMK_HotelDataSet2 As SMK_HotelDataSet2
    Friend WithEvents FoodBeverageDetailBindingSource3 As BindingSource
    Friend WithEvents FoodBeverageDetailTableAdapter1 As SMK_HotelDataSet2TableAdapters.FoodBeverageDetailTableAdapter
    Friend WithEvents dgv2 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FoodBeverageIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FoodBeverageDetailBindingSource4 As BindingSource
End Class
