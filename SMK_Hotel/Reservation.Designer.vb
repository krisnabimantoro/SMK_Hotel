<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reservation
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.btnreservation = New System.Windows.Forms.Button()
        Me.btnmasterroom = New System.Windows.Forms.Button()
        Me.btnmasteruser = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbroomnumber = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbnumberofnifgts = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvavailableroom = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dgvselectedroom = New System.Windows.Forms.DataGridView()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.cbitem = New System.Windows.Forms.ComboBox()
        Me.nudqty = New System.Windows.Forms.NumericUpDown()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dgvreqadd = New System.Windows.Forms.DataGridView()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tbphonenumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.tambah = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.RoomTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomNumberDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomFloorDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DescriptionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationRoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRoomTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRoomTableAdapter()
        Me.SMK_HotelDataSet1 = New SMK_Hotel.SMK_HotelDataSet1()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter = New SMK_Hotel.SMK_HotelDataSet1TableAdapters.ItemTableAdapter()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbprice = New System.Windows.Forms.ComboBox()
        Me.hitung = New System.Windows.Forms.Label()
        Me.ItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRequestItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRequestItemTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter()
        Me.NameItem = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Qty = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomTypeTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.RoomTypeTableAdapter()
        Me.RoomNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomFloor = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Description = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbroomprice = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.RoomPrice = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomTypeBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.RoomTypeBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvavailableroom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dgvselectedroom, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreqadd, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTypeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTypeBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomTypeBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(134, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(84, 17)
        Me.Label3.TabIndex = 12
        Me.Label3.Text = "Reservation"
        '
        'btntransaction
        '
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Location = New System.Drawing.Point(12, 271)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(98, 36)
        Me.btntransaction.TabIndex = 18
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.UseVisualStyleBackColor = True
        '
        'btncheckout
        '
        Me.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckout.Location = New System.Drawing.Point(12, 229)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(98, 36)
        Me.btncheckout.TabIndex = 17
        Me.btncheckout.Text = "Check Out"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'btncheckin
        '
        Me.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckin.Location = New System.Drawing.Point(12, 187)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(98, 36)
        Me.btncheckin.TabIndex = 16
        Me.btncheckin.Text = "Check-In"
        Me.btncheckin.UseVisualStyleBackColor = True
        '
        'btnreservation
        '
        Me.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreservation.Location = New System.Drawing.Point(12, 145)
        Me.btnreservation.Name = "btnreservation"
        Me.btnreservation.Size = New System.Drawing.Size(98, 36)
        Me.btnreservation.TabIndex = 15
        Me.btnreservation.Text = "Reservation"
        Me.btnreservation.UseVisualStyleBackColor = True
        '
        'btnmasterroom
        '
        Me.btnmasterroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasterroom.Location = New System.Drawing.Point(12, 103)
        Me.btnmasterroom.Name = "btnmasterroom"
        Me.btnmasterroom.Size = New System.Drawing.Size(98, 36)
        Me.btnmasterroom.TabIndex = 14
        Me.btnmasterroom.Text = "Master Room"
        Me.btnmasterroom.UseVisualStyleBackColor = True
        '
        'btnmasteruser
        '
        Me.btnmasteruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasteruser.Location = New System.Drawing.Point(12, 61)
        Me.btnmasteruser.Name = "btnmasteruser"
        Me.btnmasteruser.Size = New System.Drawing.Size(98, 36)
        Me.btnmasteruser.TabIndex = 13
        Me.btnmasteruser.Text = "Master User"
        Me.btnmasteruser.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(137, 130)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 20
        Me.Label4.Text = "Room Number"
        '
        'cbroomnumber
        '
        Me.cbroomnumber.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReservationRoomBindingSource, "RoomID", True))
        Me.cbroomnumber.DataSource = Me.RoomBindingSource
        Me.cbroomnumber.DisplayMember = "RoomNumber"
        Me.cbroomnumber.FormattingEnabled = True
        Me.cbroomnumber.Location = New System.Drawing.Point(231, 127)
        Me.cbroomnumber.Name = "cbroomnumber"
        Me.cbroomnumber.Size = New System.Drawing.Size(218, 21)
        Me.cbroomnumber.TabIndex = 21
        Me.cbroomnumber.ValueMember = "RoomNumber"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(137, 103)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(55, 13)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Start Date"
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(231, 96)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(218, 20)
        Me.DateTimePicker1.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(587, 103)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 24
        Me.Label6.Text = "Number Of Nights"
        '
        'tbnumberofnifgts
        '
        Me.tbnumberofnifgts.Location = New System.Drawing.Point(690, 102)
        Me.tbnumberofnifgts.Name = "tbnumberofnifgts"
        Me.tbnumberofnifgts.Size = New System.Drawing.Size(154, 20)
        Me.tbnumberofnifgts.TabIndex = 25
        '
        'btnsearch
        '
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Location = New System.Drawing.Point(470, 124)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(76, 24)
        Me.btnsearch.TabIndex = 28
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvavailableroom)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 154)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(352, 153)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Available Room"
        '
        'dgvavailableroom
        '
        Me.dgvavailableroom.AutoGenerateColumns = False
        Me.dgvavailableroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvavailableroom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.RoomTypeIDDataGridViewTextBoxColumn, Me.RoomNumberDataGridViewTextBoxColumn, Me.RoomFloorDataGridViewTextBoxColumn, Me.DescriptionDataGridViewTextBoxColumn})
        Me.dgvavailableroom.DataSource = Me.RoomBindingSource
        Me.dgvavailableroom.Location = New System.Drawing.Point(0, 19)
        Me.dgvavailableroom.Name = "dgvavailableroom"
        Me.dgvavailableroom.Size = New System.Drawing.Size(352, 134)
        Me.dgvavailableroom.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgvselectedroom)
        Me.GroupBox2.Location = New System.Drawing.Point(590, 154)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(352, 153)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Selected Room"
        '
        'dgvselectedroom
        '
        Me.dgvselectedroom.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvselectedroom.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNumber, Me.RoomFloor, Me.Description, Me.RoomPrice})
        Me.dgvselectedroom.Location = New System.Drawing.Point(0, 19)
        Me.dgvselectedroom.Name = "dgvselectedroom"
        Me.dgvselectedroom.Size = New System.Drawing.Size(352, 134)
        Me.dgvselectedroom.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(519, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(48, 40)
        Me.Button1.TabIndex = 31
        Me.Button1.Text = ">>"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Location = New System.Drawing.Point(519, 233)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(48, 40)
        Me.Button2.TabIndex = 32
        Me.Button2.Text = "<<"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Label13)
        Me.GroupBox3.Controls.Add(Me.cbprice)
        Me.GroupBox3.Controls.Add(Me.cbitem)
        Me.GroupBox3.Controls.Add(Me.nudqty)
        Me.GroupBox3.Controls.Add(Me.btnadd)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Controls.Add(Me.dgvreqadd)
        Me.GroupBox3.Controls.Add(Me.hitung)
        Me.GroupBox3.Location = New System.Drawing.Point(590, 322)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(352, 277)
        Me.GroupBox3.TabIndex = 30
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Request Additional Items"
        '
        'cbitem
        '
        Me.cbitem.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReservationRequestItemBindingSource, "ItemID", True))
        Me.cbitem.DataSource = Me.ItemBindingSource1
        Me.cbitem.DisplayMember = "Name"
        Me.cbitem.FormattingEnabled = True
        Me.cbitem.Location = New System.Drawing.Point(67, 27)
        Me.cbitem.Name = "cbitem"
        Me.cbitem.Size = New System.Drawing.Size(187, 21)
        Me.cbitem.TabIndex = 33
        Me.cbitem.ValueMember = "Name"
        '
        'nudqty
        '
        Me.nudqty.Location = New System.Drawing.Point(67, 104)
        Me.nudqty.Name = "nudqty"
        Me.nudqty.Size = New System.Drawing.Size(187, 20)
        Me.nudqty.TabIndex = 35
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Location = New System.Drawing.Point(270, 126)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(76, 24)
        Me.btnadd.TabIndex = 33
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(13, 106)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(23, 13)
        Me.Label8.TabIndex = 34
        Me.Label8.Text = "Qty"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(13, 30)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(27, 13)
        Me.Label7.TabIndex = 33
        Me.Label7.Text = "Item"
        '
        'dgvreqadd
        '
        Me.dgvreqadd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreqadd.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameItem, Me.Price, Me.Qty})
        Me.dgvreqadd.Location = New System.Drawing.Point(0, 156)
        Me.dgvreqadd.Name = "dgvreqadd"
        Me.dgvreqadd.Size = New System.Drawing.Size(352, 121)
        Me.dgvreqadd.TabIndex = 0
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.tbname)
        Me.GroupBox4.Controls.Add(Me.tbphonenumber)
        Me.GroupBox4.Controls.Add(Me.Label10)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Location = New System.Drawing.Point(140, 322)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(352, 223)
        Me.GroupBox4.TabIndex = 33
        Me.GroupBox4.TabStop = False
        Me.GroupBox4.Text = "Customer Data"
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(121, 69)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(188, 20)
        Me.tbname.TabIndex = 38
        '
        'tbphonenumber
        '
        Me.tbphonenumber.Location = New System.Drawing.Point(121, 32)
        Me.tbphonenumber.Name = "tbphonenumber"
        Me.tbphonenumber.Size = New System.Drawing.Size(188, 20)
        Me.tbphonenumber.TabIndex = 34
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 72)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(35, 13)
        Me.Label10.TabIndex = 37
        Me.Label10.Text = "Name"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 35)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(78, 13)
        Me.Label9.TabIndex = 36
        Me.Label9.Text = "Phone Number"
        '
        'btnsubmit
        '
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Location = New System.Drawing.Point(853, 649)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(89, 35)
        Me.btnsubmit.TabIndex = 36
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'tambah
        '
        Me.tambah.AutoSize = True
        Me.tambah.Location = New System.Drawing.Point(891, 618)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(13, 13)
        Me.tambah.TabIndex = 38
        Me.tambah.Text = "0"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(801, 618)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(81, 13)
        Me.Label12.TabIndex = 37
        Me.Label12.Text = "Total Price : Rp"
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "Room"
        Me.RoomBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'RoomTypeIDDataGridViewTextBoxColumn
        '
        Me.RoomTypeIDDataGridViewTextBoxColumn.DataPropertyName = "RoomTypeID"
        Me.RoomTypeIDDataGridViewTextBoxColumn.HeaderText = "RoomTypeID"
        Me.RoomTypeIDDataGridViewTextBoxColumn.Name = "RoomTypeIDDataGridViewTextBoxColumn"
        Me.RoomTypeIDDataGridViewTextBoxColumn.Visible = False
        '
        'RoomNumberDataGridViewTextBoxColumn
        '
        Me.RoomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber"
        Me.RoomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber"
        Me.RoomNumberDataGridViewTextBoxColumn.Name = "RoomNumberDataGridViewTextBoxColumn"
        '
        'RoomFloorDataGridViewTextBoxColumn
        '
        Me.RoomFloorDataGridViewTextBoxColumn.DataPropertyName = "RoomFloor"
        Me.RoomFloorDataGridViewTextBoxColumn.HeaderText = "RoomFloor"
        Me.RoomFloorDataGridViewTextBoxColumn.Name = "RoomFloorDataGridViewTextBoxColumn"
        '
        'DescriptionDataGridViewTextBoxColumn
        '
        Me.DescriptionDataGridViewTextBoxColumn.DataPropertyName = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.HeaderText = "Description"
        Me.DescriptionDataGridViewTextBoxColumn.Name = "DescriptionDataGridViewTextBoxColumn"
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
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(12, 67)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(31, 13)
        Me.Label13.TabIndex = 73
        Me.Label13.Text = "Price"
        '
        'cbprice
        '
        Me.cbprice.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.ReservationRequestItemBindingSource, "ItemID", True))
        Me.cbprice.DataSource = Me.ItemBindingSource1
        Me.cbprice.DisplayMember = "Price"
        Me.cbprice.Enabled = False
        Me.cbprice.FormattingEnabled = True
        Me.cbprice.Location = New System.Drawing.Point(67, 64)
        Me.cbprice.Name = "cbprice"
        Me.cbprice.Size = New System.Drawing.Size(187, 21)
        Me.cbprice.TabIndex = 72
        Me.cbprice.ValueMember = "Price"
        '
        'hitung
        '
        Me.hitung.AutoSize = True
        Me.hitung.Location = New System.Drawing.Point(149, 221)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(45, 13)
        Me.hitung.TabIndex = 74
        Me.hitung.Text = "Label11"
        '
        'ItemBindingSource1
        '
        Me.ItemBindingSource1.DataMember = "Item"
        Me.ItemBindingSource1.DataSource = Me.SMK_HotelDataSet1
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
        'NameItem
        '
        Me.NameItem.HeaderText = "Name"
        Me.NameItem.Name = "NameItem"
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
        'RoomTypeBindingSource
        '
        Me.RoomTypeBindingSource.DataMember = "RoomType"
        Me.RoomTypeBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'RoomTypeTableAdapter
        '
        Me.RoomTypeTableAdapter.ClearBeforeFill = True
        '
        'RoomNumber
        '
        Me.RoomNumber.HeaderText = "Room Number"
        Me.RoomNumber.Name = "RoomNumber"
        '
        'RoomFloor
        '
        Me.RoomFloor.HeaderText = "Room Floor"
        Me.RoomFloor.Name = "RoomFloor"
        '
        'Description
        '
        Me.Description.HeaderText = "Description"
        Me.Description.Name = "Description"
        '
        'cbroomprice
        '
        Me.cbroomprice.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RoomTypeBindingSource2, "ID", True))
        Me.cbroomprice.DataSource = Me.RoomTypeBindingSource2
        Me.cbroomprice.DisplayMember = "RoomPrice"
        Me.cbroomprice.FormattingEnabled = True
        Me.cbroomprice.Location = New System.Drawing.Point(690, 127)
        Me.cbroomprice.Name = "cbroomprice"
        Me.cbroomprice.Size = New System.Drawing.Size(154, 21)
        Me.cbroomprice.TabIndex = 39
        Me.cbroomprice.ValueMember = "RoomPrice"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(587, 130)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(62, 13)
        Me.Label11.TabIndex = 40
        Me.Label11.Text = "Room Price"
        '
        'RoomPrice
        '
        Me.RoomPrice.HeaderText = "Room Price"
        Me.RoomPrice.Name = "RoomPrice"
        '
        'RoomTypeBindingSource1
        '
        Me.RoomTypeBindingSource1.DataMember = "RoomType"
        Me.RoomTypeBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'ComboBox1
        '
        Me.ComboBox1.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RoomTypeBindingSource2, "ID", True))
        Me.ComboBox1.DataSource = Me.RoomBindingSource
        Me.ComboBox1.DisplayMember = "RoomTypeID"
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Location = New System.Drawing.Point(397, 53)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(121, 21)
        Me.ComboBox1.TabIndex = 41
        Me.ComboBox1.ValueMember = "RoomTypeID"
        '
        'RoomTypeBindingSource2
        '
        Me.RoomTypeBindingSource2.DataMember = "RoomType"
        Me.RoomTypeBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(837, 38)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(45, 13)
        Me.Label14.TabIndex = 42
        Me.Label14.Text = "Label14"
        '
        'Timer1
        '
        '
        'Reservation
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1059, 749)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cbroomprice)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.tbnumberofnifgts)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cbroomnumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.btncheckin)
        Me.Controls.Add(Me.btnreservation)
        Me.Controls.Add(Me.btnmasterroom)
        Me.Controls.Add(Me.btnmasteruser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Reservation"
        Me.Text = "Reservation"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvavailableroom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dgvselectedroom, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreqadd, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTypeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTypeBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomTypeBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btntransaction As Button
    Friend WithEvents btncheckout As Button
    Friend WithEvents btncheckin As Button
    Friend WithEvents btnreservation As Button
    Friend WithEvents btnmasterroom As Button
    Friend WithEvents btnmasteruser As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents cbroomnumber As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label6 As Label
    Friend WithEvents tbnumberofnifgts As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvavailableroom As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dgvselectedroom As DataGridView
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents cbitem As ComboBox
    Friend WithEvents nudqty As NumericUpDown
    Friend WithEvents btnadd As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents dgvreqadd As DataGridView
    Friend WithEvents GroupBox4 As GroupBox
    Friend WithEvents tbname As TextBox
    Friend WithEvents tbphonenumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents tambah As Label
    Friend WithEvents Label12 As Label
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As SMK_HotelDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomNumberDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomFloorDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DescriptionDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationRoomBindingSource As BindingSource
    Friend WithEvents ReservationRoomTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRoomTableAdapter
    Friend WithEvents SMK_HotelDataSet1 As SMK_HotelDataSet1
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As SMK_HotelDataSet1TableAdapters.ItemTableAdapter
    Friend WithEvents Label13 As Label
    Friend WithEvents cbprice As ComboBox
    Friend WithEvents hitung As Label
    Friend WithEvents ItemBindingSource1 As BindingSource
    Friend WithEvents ReservationRequestItemBindingSource As BindingSource
    Friend WithEvents ReservationRequestItemTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter
    Friend WithEvents NameItem As DataGridViewTextBoxColumn
    Friend WithEvents Price As DataGridViewTextBoxColumn
    Friend WithEvents Qty As DataGridViewTextBoxColumn
    Friend WithEvents RoomTypeBindingSource As BindingSource
    Friend WithEvents RoomTypeTableAdapter As SMK_HotelDataSetTableAdapters.RoomTypeTableAdapter
    Friend WithEvents RoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents RoomFloor As DataGridViewTextBoxColumn
    Friend WithEvents Description As DataGridViewTextBoxColumn
    Friend WithEvents RoomPrice As DataGridViewTextBoxColumn
    Friend WithEvents cbroomprice As ComboBox
    Friend WithEvents RoomTypeBindingSource1 As BindingSource
    Friend WithEvents Label11 As Label
    Friend WithEvents ComboBox1 As ComboBox
    Friend WithEvents RoomTypeBindingSource2 As BindingSource
    Friend WithEvents Label14 As Label
    Friend WithEvents Timer1 As Timer
End Class
