<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_RoomService_and_FoodBeverage
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
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.btnreservation = New System.Windows.Forms.Button()
        Me.btnmasterroom = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnmasteruser = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.SMK_HotelDataSet1 = New SMK_Hotel.SMK_HotelDataSet1()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter = New SMK_Hotel.SMK_HotelDataSet1TableAdapters.ItemTableAdapter()
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.ReservationRoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRoomTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRoomTableAdapter()
        Me.ReservationRequestItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRequestItemTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ReservationRequestItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationRoomIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.FoodBeverageDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageDetailTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.FoodBeverageDetailTableAdapter()
        Me.IDDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBeverageIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SMK_HotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btntransaction
        '
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Location = New System.Drawing.Point(15, 276)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(98, 36)
        Me.btntransaction.TabIndex = 15
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.UseVisualStyleBackColor = True
        '
        'btncheckout
        '
        Me.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckout.Location = New System.Drawing.Point(15, 234)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(98, 36)
        Me.btncheckout.TabIndex = 14
        Me.btncheckout.Text = "Check Out"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'btncheckin
        '
        Me.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckin.Location = New System.Drawing.Point(15, 192)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(98, 36)
        Me.btncheckin.TabIndex = 13
        Me.btncheckin.Text = "Check-In"
        Me.btncheckin.UseVisualStyleBackColor = True
        '
        'btnreservation
        '
        Me.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreservation.Location = New System.Drawing.Point(15, 150)
        Me.btnreservation.Name = "btnreservation"
        Me.btnreservation.Size = New System.Drawing.Size(98, 36)
        Me.btnreservation.TabIndex = 12
        Me.btnreservation.Text = "Reservation"
        Me.btnreservation.UseVisualStyleBackColor = True
        '
        'btnmasterroom
        '
        Me.btnmasterroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasterroom.Location = New System.Drawing.Point(15, 108)
        Me.btnmasterroom.Name = "btnmasterroom"
        Me.btnmasterroom.Size = New System.Drawing.Size(98, 36)
        Me.btnmasterroom.TabIndex = 11
        Me.btnmasterroom.Text = "Master Room"
        Me.btnmasterroom.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "Front Office"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 9
        Me.Label1.Text = "SMK Hotel"
        '
        'btnmasteruser
        '
        Me.btnmasteruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasteruser.Location = New System.Drawing.Point(15, 66)
        Me.btnmasteruser.Name = "btnmasteruser"
        Me.btnmasteruser.Size = New System.Drawing.Size(98, 36)
        Me.btnmasteruser.TabIndex = 8
        Me.btnmasteruser.Text = "Master User"
        Me.btnmasteruser.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(150, 53)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 13)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Room Service"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(150, 225)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(80, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Food Beverage"
        '
        'SMK_HotelDataSet1
        '
        Me.SMK_HotelDataSet1.DataSetName = "SMK_HotelDataSet1"
        Me.SMK_HotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataMember = "Item"
        Me.ItemBindingSource.DataSource = Me.SMK_HotelDataSet1
        '
        'ItemTableAdapter
        '
        Me.ItemTableAdapter.ClearBeforeFill = True
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationRoomBindingSource
        '
        Me.ReservationRoomBindingSource.DataMember = "ReservationRoom"
        Me.ReservationRoomBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'ReservationRoomTableAdapter
        '
        Me.ReservationRoomTableAdapter.ClearBeforeFill = True
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReservationRoomIDDataGridViewTextBoxColumn, Me.ItemIDDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ReservationRequestItemBindingSource1
        Me.DataGridView1.Location = New System.Drawing.Point(153, 69)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(511, 143)
        Me.DataGridView1.TabIndex = 18
        '
        'ReservationRequestItemBindingSource1
        '
        Me.ReservationRequestItemBindingSource1.DataMember = "ReservationRequestItem"
        Me.ReservationRequestItemBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
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
        'DataGridView2
        '
        Me.DataGridView2.AutoGenerateColumns = False
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn1, Me.FoodBeverageIDDataGridViewTextBoxColumn, Me.RoomIDDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn1})
        Me.DataGridView2.DataSource = Me.FoodBeverageDetailBindingSource
        Me.DataGridView2.Location = New System.Drawing.Point(153, 254)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(506, 150)
        Me.DataGridView2.TabIndex = 19
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
        'IDDataGridViewTextBoxColumn1
        '
        Me.IDDataGridViewTextBoxColumn1.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn1.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn1.Name = "IDDataGridViewTextBoxColumn1"
        Me.IDDataGridViewTextBoxColumn1.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn1.Visible = False
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
        'Display_RoomService_and_FoodBeverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.btncheckin)
        Me.Controls.Add(Me.btnreservation)
        Me.Controls.Add(Me.btnmasterroom)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnmasteruser)
        Me.Name = "Display_RoomService_and_FoodBeverage"
        Me.Text = "Display_RoomService_and_FoodBeverage"
        CType(Me.SMK_HotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btntransaction As Button
    Friend WithEvents btncheckout As Button
    Friend WithEvents btncheckin As Button
    Friend WithEvents btnreservation As Button
    Friend WithEvents btnmasterroom As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnmasteruser As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents SMK_HotelDataSet1 As SMK_HotelDataSet1
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As SMK_HotelDataSet1TableAdapters.ItemTableAdapter
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents ReservationRoomBindingSource As BindingSource
    Friend WithEvents ReservationRoomTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRoomTableAdapter
    Friend WithEvents ReservationRequestItemBindingSource As BindingSource
    Friend WithEvents ReservationRequestItemTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationRoomIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationRequestItemBindingSource1 As BindingSource
    Friend WithEvents DataGridView2 As DataGridView
    Friend WithEvents FoodBeverageDetailBindingSource As BindingSource
    Friend WithEvents FoodBeverageDetailTableAdapter As SMK_HotelDataSetTableAdapters.FoodBeverageDetailTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents FoodBeverageIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
End Class
