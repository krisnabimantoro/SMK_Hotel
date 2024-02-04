<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Request_Additional_Item
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
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.cbitem = New System.Windows.Forms.ComboBox()
        Me.nudqty = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvreqadd = New System.Windows.Forms.DataGridView()
        Me.btnreqadditem = New System.Windows.Forms.Button()
        Me.btninputitem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.tambah = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.RoomTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.RoomTableAdapter()
        Me.FoodBeverageDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageDetailTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.FoodBeverageDetailTableAdapter()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ItemTableAdapter()
        Me.ReservationRequestItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRequestItemTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter()
        Me.ReservationRoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRoomTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRoomTableAdapter()
        Me.ReservationRequestItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.btnadd = New System.Windows.Forms.Button()
        Me.hitung = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.cbprice = New System.Windows.Forms.ComboBox()
        Me.SMK_HotelDataSet1 = New SMK_Hotel.SMK_HotelDataSet1()
        Me.ItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter1 = New SMK_Hotel.SMK_HotelDataSet1TableAdapters.ItemTableAdapter()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.ReservationRoomBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRoomBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.NameItems = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.ItemBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRequestItemBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.ReservationRoomBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRequestItemBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreqadd, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRoomBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRoomBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRoomBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnsubmit
        '
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Location = New System.Drawing.Point(660, 412)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 49
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvreqadd)
        Me.GroupBox1.Controls.Add(Me.ComboBox3)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.ComboBox2)
        Me.GroupBox1.Controls.Add(Me.cbprice)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.cbitem)
        Me.GroupBox1.Controls.Add(Me.nudqty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.hitung)
        Me.GroupBox1.Controls.Add(Me.ComboBox4)
        Me.GroupBox1.Location = New System.Drawing.Point(146, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 285)
        Me.GroupBox1.TabIndex = 46
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request additional item"
        '
        'cbitem
        '
        Me.cbitem.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReservationRequestItemBindingSource, "ItemID", True))
        Me.cbitem.DataSource = Me.ItemBindingSource
        Me.cbitem.DisplayMember = "Name"
        Me.cbitem.FormattingEnabled = True
        Me.cbitem.Location = New System.Drawing.Point(67, 29)
        Me.cbitem.Name = "cbitem"
        Me.cbitem.Size = New System.Drawing.Size(203, 21)
        Me.cbitem.TabIndex = 43
        Me.cbitem.ValueMember = "Name"
        '
        'nudqty
        '
        Me.nudqty.Location = New System.Drawing.Point(67, 103)
        Me.nudqty.Name = "nudqty"
        Me.nudqty.Size = New System.Drawing.Size(203, 20)
        Me.nudqty.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 105)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(23, 13)
        Me.Label4.TabIndex = 2
        Me.Label4.Text = "Qty"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(13, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Item "
        '
        'dgvreqadd
        '
        Me.dgvreqadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreqadd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameItems, Me.Price, Me.Qty})
        Me.dgvreqadd.Location = New System.Drawing.Point(0, 156)
        Me.dgvreqadd.Name = "dgvreqadd"
        Me.dgvreqadd.Size = New System.Drawing.Size(580, 123)
        Me.dgvreqadd.TabIndex = 0
        '
        'btnreqadditem
        '
        Me.btnreqadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreqadditem.Location = New System.Drawing.Point(12, 103)
        Me.btnreqadditem.Name = "btnreqadditem"
        Me.btnreqadditem.Size = New System.Drawing.Size(98, 36)
        Me.btnreqadditem.TabIndex = 53
        Me.btnreqadditem.Text = "Request Additional Item"
        Me.btnreqadditem.UseVisualStyleBackColor = True
        '
        'btninputitem
        '
        Me.btninputitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninputitem.Location = New System.Drawing.Point(12, 61)
        Me.btninputitem.Name = "btninputitem"
        Me.btninputitem.Size = New System.Drawing.Size(98, 36)
        Me.btninputitem.TabIndex = 52
        Me.btninputitem.Text = "Input Item"
        Me.btninputitem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(84, 15)
        Me.Label2.TabIndex = 51
        Me.Label2.Text = "Room Service"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "SMK Hotel"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(152, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Room Number"
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReservationRoomBindingSource, "RoomID", True))
        Me.ComboBox1.DataSource = Me.RoomBindingSource
        Me.ComboBox1.DisplayMember = "RoomNumber"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(250, 70)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(166, 21)
        Me.ComboBox1.TabIndex = 54
        Me.ComboBox1.ValueMember = "RoomNumber"
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "Room"
        Me.RoomBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'tambah
        '
        Me.tambah.AutoSize = True
        Me.tambah.Location = New System.Drawing.Point(246, 417)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(13, 13)
        Me.tambah.TabIndex = 56
        Me.tambah.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(152, 417)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 55
        Me.Label8.Text = "Total Charge : Rp"
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
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
        'ItemBindingSource
        '
        Me.ItemBindingSource.DataMember = "Item"
        Me.ItemBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'ItemTableAdapter
        '
        Me.ItemTableAdapter.ClearBeforeFill = True
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
        'ReservationRoomBindingSource
        '
        Me.ReservationRoomBindingSource.DataMember = "ReservationRoom"
        Me.ReservationRoomBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'ReservationRoomTableAdapter
        '
        Me.ReservationRoomTableAdapter.ClearBeforeFill = True
        '
        'ReservationRequestItemBindingSource1
        '
        Me.ReservationRequestItemBindingSource1.DataMember = "ReservationRequestItem"
        Me.ReservationRequestItemBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Location = New System.Drawing.Point(499, 78)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 57
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'hitung
        '
        Me.hitung.AutoSize = True
        Me.hitung.Location = New System.Drawing.Point(262, 171)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(39, 13)
        Me.hitung.TabIndex = 58
        Me.hitung.Text = "Label6"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(12, 69)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 71
        Me.Label6.Text = "Price"
        '
        'cbprice
        '
        Me.cbprice.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReservationRequestItemBindingSource, "ItemID", True))
        Me.cbprice.DataSource = Me.ItemBindingSource
        Me.cbprice.DisplayMember = "Price"
        Me.cbprice.Enabled = False
        Me.cbprice.FormattingEnabled = True
        Me.cbprice.Location = New System.Drawing.Point(67, 66)
        Me.cbprice.Name = "cbprice"
        Me.cbprice.Size = New System.Drawing.Size(203, 21)
        Me.cbprice.TabIndex = 70
        Me.cbprice.ValueMember = "Price"
        '
        'SMK_HotelDataSet1
        '
        Me.SMK_HotelDataSet1.DataSetName = "SMK_HotelDataSet1"
        Me.SMK_HotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ItemBindingSource1
        '
        Me.ItemBindingSource1.DataMember = "Item"
        Me.ItemBindingSource1.DataSource = Me.SMK_HotelDataSet1
        '
        'ItemTableAdapter1
        '
        Me.ItemTableAdapter1.ClearBeforeFill = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RoomBindingSource, "ID", True))
        Me.ComboBox2.DataSource = Me.RoomBindingSource
        Me.ComboBox2.DisplayMember = "ID"
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Location = New System.Drawing.Point(265, 231)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox2.TabIndex = 57
        Me.ComboBox2.ValueMember = "ID"
        '
        'ReservationRoomBindingSource1
        '
        Me.ReservationRoomBindingSource1.DataMember = "ReservationRoom"
        Me.ReservationRoomBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'ReservationRoomBindingSource2
        '
        Me.ReservationRoomBindingSource2.DataMember = "ReservationRoom"
        Me.ReservationRoomBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'NameItems
        '
        Me.NameItems.HeaderText = "Name"
        Me.NameItems.Name = "NameItems"
        '
        'Price
        '
        Me.Price.HeaderText = "Price"
        Me.Price.Name = "Price"
        '
        'Qty
        '
        Me.Qty.HeaderText = "Qty"
        Me.Qty.Name = "Qty"
        '
        'ComboBox3
        '
        Me.ComboBox3.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReservationRequestItemBindingSource, "ItemID", True))
        Me.ComboBox3.DataSource = Me.ItemBindingSource
        Me.ComboBox3.DisplayMember = "ID"
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Location = New System.Drawing.Point(378, 231)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox3.TabIndex = 58
        Me.ComboBox3.ValueMember = "ID"
        '
        'ItemBindingSource2
        '
        Me.ItemBindingSource2.DataMember = "Item"
        Me.ItemBindingSource2.DataSource = Me.SMK_HotelDataSet1
        '
        'ReservationRequestItemBindingSource2
        '
        Me.ReservationRequestItemBindingSource2.DataMember = "ReservationRequestItem"
        Me.ReservationRequestItemBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'ComboBox4
        '
        Me.ComboBox4.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReservationRoomBindingSource, "ID", True))
        Me.ComboBox4.DataSource = Me.ReservationRoomBindingSource
        Me.ComboBox4.DisplayMember = "ID"
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Location = New System.Drawing.Point(399, 204)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox4.TabIndex = 59
        Me.ComboBox4.ValueMember = "ID"
        '
        'ReservationRoomBindingSource3
        '
        Me.ReservationRoomBindingSource3.DataMember = "ReservationRoom"
        Me.ReservationRoomBindingSource3.DataSource = Me.SMK_HotelDataSet
        '
        'ReservationRequestItemBindingSource3
        '
        Me.ReservationRequestItemBindingSource3.DataMember = "ReservationRequestItem"
        Me.ReservationRequestItemBindingSource3.DataSource = Me.SMK_HotelDataSet
        '
        'Request_Additional_Item
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnreqadditem)
        Me.Controls.Add(Me.btninputitem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Request_Additional_Item"
        Me.Text = "Request_Additional_Item"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreqadd, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRoomBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRoomBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRoomBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnsubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbitem As ComboBox
    Friend WithEvents nudqty As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvreqadd As DataGridView
    Friend WithEvents btnreqadditem As Button
    Friend WithEvents btninputitem As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents tambah As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As SMK_HotelDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents FoodBeverageDetailBindingSource As BindingSource
    Friend WithEvents FoodBeverageDetailTableAdapter As SMK_HotelDataSetTableAdapters.FoodBeverageDetailTableAdapter
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As SMK_HotelDataSetTableAdapters.ItemTableAdapter
    Friend WithEvents ReservationRequestItemBindingSource As BindingSource
    Friend WithEvents ReservationRequestItemTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter
    Friend WithEvents ReservationRoomBindingSource As BindingSource
    Friend WithEvents ReservationRoomTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRoomTableAdapter
    Friend WithEvents ReservationRequestItemBindingSource1 As BindingSource
    Friend WithEvents btnadd As Button
    Friend WithEvents hitung As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents cbprice As ComboBox
    Friend WithEvents SMK_HotelDataSet1 As SMK_HotelDataSet1
    Friend WithEvents ItemBindingSource1 As BindingSource
    Friend WithEvents ItemTableAdapter1 As SMK_HotelDataSet1TableAdapters.ItemTableAdapter
    Friend WithEvents ComboBox2 As ComboBox
    Friend WithEvents ReservationRoomBindingSource2 As BindingSource
    Friend WithEvents ReservationRoomBindingSource1 As BindingSource
    Friend WithEvents NameItems As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents ComboBox3 As ComboBox
    Friend WithEvents ReservationRequestItemBindingSource2 As BindingSource
    Friend WithEvents ItemBindingSource2 As BindingSource
    Friend WithEvents ComboBox4 As ComboBox
    Friend WithEvents ReservationRequestItemBindingSource3 As BindingSource
    Friend WithEvents ReservationRoomBindingSource3 As BindingSource
End Class
