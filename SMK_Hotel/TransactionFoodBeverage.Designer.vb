<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TransactionFoodBeverage
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
        Me.tambah = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.cbroomnumber = New System.Windows.Forms.ComboBox()
        Me.FoodBeverageDetailBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.RoomBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageDetailBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.RoomNumber = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Column2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.price = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.cbroomid = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.cbitem = New System.Windows.Forms.ComboBox()
        Me.FoodBeverageDetailBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbprice = New System.Windows.Forms.ComboBox()
        Me.nudqty = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbfoodID = New System.Windows.Forms.ComboBox()
        Me.FoodBeverageBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.hitung = New System.Windows.Forms.Label()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btninputitem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.FoodBeverageDetailTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.FoodBeverageDetailTableAdapter()
        Me.RoomTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.RoomTableAdapter()
        Me.FoodBeverageTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.FoodBeverageTableAdapter()
        Me.CustomerTableAdapter1 = New SMK_Hotel.SMK_HotelDataSetTableAdapters.CustomerTableAdapter()
        Me.FoodBeverageBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageDetailBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageDetailBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.RoomBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cbqty = New System.Windows.Forms.ComboBox()
        Me.FoodBeverageBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.FoodBeverageBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.simpanqty = New System.Windows.Forms.Label()
        Me.FoodBeverageBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        CType(Me.FoodBeverageDetailBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageDetailBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RoomBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'tambah
        '
        Me.tambah.AutoSize = True
        Me.tambah.Location = New System.Drawing.Point(231, 388)
        Me.tambah.Name = "tambah"
        Me.tambah.Size = New System.Drawing.Size(13, 13)
        Me.tambah.TabIndex = 62
        Me.tambah.Text = "0"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(137, 388)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 61
        Me.Label8.Text = "Total Charge : Rp"
        '
        'cbroomnumber
        '
        Me.cbroomnumber.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FoodBeverageDetailBindingSource4, "RoomID", True))
        Me.cbroomnumber.DataSource = Me.RoomBindingSource3
        Me.cbroomnumber.DisplayMember = "RoomNumber"
        Me.cbroomnumber.FormattingEnabled = True
        Me.cbroomnumber.Location = New System.Drawing.Point(244, 70)
        Me.cbroomnumber.Name = "cbroomnumber"
        Me.cbroomnumber.Size = New System.Drawing.Size(203, 21)
        Me.cbroomnumber.TabIndex = 60
        Me.cbroomnumber.ValueMember = "RoomNumber"
        '
        'FoodBeverageDetailBindingSource4
        '
        Me.FoodBeverageDetailBindingSource4.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource4.DataSource = Me.SMK_HotelDataSet
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'RoomBindingSource3
        '
        Me.RoomBindingSource3.DataMember = "Room"
        Me.RoomBindingSource3.DataSource = Me.SMK_HotelDataSet
        '
        'FoodBeverageDetailBindingSource1
        '
        Me.FoodBeverageDetailBindingSource1.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'RoomBindingSource
        '
        Me.RoomBindingSource.DataMember = "Room"
        Me.RoomBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(146, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 13)
        Me.Label5.TabIndex = 57
        Me.Label5.Text = "Room Number"
        '
        'btnsubmit
        '
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Location = New System.Drawing.Point(645, 383)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(75, 23)
        Me.btnsubmit.TabIndex = 59
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Controls.Add(Me.cbqty)
        Me.GroupBox1.Controls.Add(Me.cbroomid)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.cbitem)
        Me.GroupBox1.Controls.Add(Me.cbprice)
        Me.GroupBox1.Controls.Add(Me.nudqty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.cbfoodID)
        Me.GroupBox1.Controls.Add(Me.hitung)
        Me.GroupBox1.Controls.Add(Me.simpanqty)
        Me.GroupBox1.Location = New System.Drawing.Point(140, 103)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 274)
        Me.GroupBox1.TabIndex = 58
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Request additional item"
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.RoomNumber, Me.Column1, Me.Column2, Me.price})
        Me.DataGridView1.Location = New System.Drawing.Point(0, 151)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(580, 123)
        Me.DataGridView1.TabIndex = 0
        '
        'RoomNumber
        '
        Me.RoomNumber.HeaderText = "Room Number"
        Me.RoomNumber.Name = "RoomNumber"
        '
        'Column1
        '
        Me.Column1.HeaderText = "Food Beverage"
        Me.Column1.Name = "Column1"
        '
        'Column2
        '
        Me.Column2.HeaderText = "Qty"
        Me.Column2.Name = "Column2"
        '
        'price
        '
        Me.price.HeaderText = "Price"
        Me.price.Name = "price"
        '
        'cbroomid
        '
        Me.cbroomid.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.RoomBindingSource3, "ID", True))
        Me.cbroomid.DataSource = Me.RoomBindingSource3
        Me.cbroomid.DisplayMember = "ID"
        Me.cbroomid.FormattingEnabled = True
        Me.cbroomid.Location = New System.Drawing.Point(371, 171)
        Me.cbroomid.Name = "cbroomid"
        Me.cbroomid.Size = New System.Drawing.Size(113, 21)
        Me.cbroomid.TabIndex = 71
        Me.cbroomid.ValueMember = "ID"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(13, 63)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 69
        Me.Label6.Text = "Price"
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Location = New System.Drawing.Point(499, 60)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(75, 23)
        Me.btnadd.TabIndex = 67
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'cbitem
        '
        Me.cbitem.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FoodBeverageDetailBindingSource, "FoodBeverageID", True))
        Me.cbitem.DataSource = Me.FoodBeverageBindingSource
        Me.cbitem.DisplayMember = "FoodName"
        Me.cbitem.FormattingEnabled = True
        Me.cbitem.Location = New System.Drawing.Point(104, 29)
        Me.cbitem.Name = "cbitem"
        Me.cbitem.Size = New System.Drawing.Size(203, 21)
        Me.cbitem.TabIndex = 43
        Me.cbitem.ValueMember = "FoodName"
        '
        'FoodBeverageDetailBindingSource
        '
        Me.FoodBeverageDetailBindingSource.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'FoodBeverageBindingSource
        '
        Me.FoodBeverageBindingSource.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'cbprice
        '
        Me.cbprice.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FoodBeverageDetailBindingSource, "FoodBeverageID", True))
        Me.cbprice.DataSource = Me.FoodBeverageBindingSource
        Me.cbprice.DisplayMember = "Price"
        Me.cbprice.Enabled = False
        Me.cbprice.FormattingEnabled = True
        Me.cbprice.Location = New System.Drawing.Point(104, 60)
        Me.cbprice.Name = "cbprice"
        Me.cbprice.Size = New System.Drawing.Size(203, 21)
        Me.cbprice.TabIndex = 68
        Me.cbprice.ValueMember = "Price"
        '
        'nudqty
        '
        Me.nudqty.Location = New System.Drawing.Point(104, 97)
        Me.nudqty.Name = "nudqty"
        Me.nudqty.Size = New System.Drawing.Size(203, 20)
        Me.nudqty.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 99)
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
        Me.Label3.Size = New System.Drawing.Size(80, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Food Beverage"
        '
        'cbfoodID
        '
        Me.cbfoodID.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FoodBeverageBindingSource, "ID", True))
        Me.cbfoodID.DataSource = Me.FoodBeverageBindingSource3
        Me.cbfoodID.DisplayMember = "ID"
        Me.cbfoodID.FormattingEnabled = True
        Me.cbfoodID.Location = New System.Drawing.Point(381, 230)
        Me.cbfoodID.Name = "cbfoodID"
        Me.cbfoodID.Size = New System.Drawing.Size(121, 21)
        Me.cbfoodID.TabIndex = 67
        Me.cbfoodID.ValueMember = "ID"
        '
        'FoodBeverageBindingSource3
        '
        Me.FoodBeverageBindingSource3.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource3.DataSource = Me.SMK_HotelDataSet
        '
        'hitung
        '
        Me.hitung.AutoSize = True
        Me.hitung.Location = New System.Drawing.Point(306, 250)
        Me.hitung.Name = "hitung"
        Me.hitung.Size = New System.Drawing.Size(39, 13)
        Me.hitung.TabIndex = 70
        Me.hitung.Text = "Label7"
        '
        'btntransaction
        '
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Location = New System.Drawing.Point(12, 103)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(98, 36)
        Me.btntransaction.TabIndex = 66
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.UseVisualStyleBackColor = True
        '
        'btninputitem
        '
        Me.btninputitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninputitem.Location = New System.Drawing.Point(12, 61)
        Me.btninputitem.Name = "btninputitem"
        Me.btninputitem.Size = New System.Drawing.Size(98, 36)
        Me.btninputitem.TabIndex = 65
        Me.btninputitem.Text = "Input Menu"
        Me.btninputitem.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(90, 15)
        Me.Label2.TabIndex = 64
        Me.Label2.Text = "Food Beverage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 63
        Me.Label1.Text = "SMK Hotel"
        '
        'FoodBeverageDetailTableAdapter
        '
        Me.FoodBeverageDetailTableAdapter.ClearBeforeFill = True
        '
        'RoomTableAdapter
        '
        Me.RoomTableAdapter.ClearBeforeFill = True
        '
        'FoodBeverageTableAdapter
        '
        Me.FoodBeverageTableAdapter.ClearBeforeFill = True
        '
        'CustomerTableAdapter1
        '
        Me.CustomerTableAdapter1.ClearBeforeFill = True
        '
        'FoodBeverageBindingSource1
        '
        Me.FoodBeverageBindingSource1.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'FoodBeverageDetailBindingSource2
        '
        Me.FoodBeverageDetailBindingSource2.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'FoodBeverageDetailBindingSource3
        '
        Me.FoodBeverageDetailBindingSource3.DataMember = "FoodBeverageDetail"
        Me.FoodBeverageDetailBindingSource3.DataSource = Me.SMK_HotelDataSet
        '
        'FoodBeverageBindingSource2
        '
        Me.FoodBeverageBindingSource2.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'RoomBindingSource1
        '
        Me.RoomBindingSource1.DataMember = "Room"
        Me.RoomBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'RoomBindingSource2
        '
        Me.RoomBindingSource2.DataMember = "Room"
        Me.RoomBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'cbqty
        '
        Me.cbqty.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.FoodBeverageDetailBindingSource, "FoodBeverageID", True))
        Me.cbqty.DataSource = Me.FoodBeverageBindingSource
        Me.cbqty.DisplayMember = "Qty"
        Me.cbqty.FormattingEnabled = True
        Me.cbqty.Location = New System.Drawing.Point(381, 198)
        Me.cbqty.Name = "cbqty"
        Me.cbqty.Size = New System.Drawing.Size(121, 21)
        Me.cbqty.TabIndex = 67
        Me.cbqty.ValueMember = "Qty"
        '
        'FoodBeverageBindingSource4
        '
        Me.FoodBeverageBindingSource4.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource4.DataSource = Me.SMK_HotelDataSet
        '
        'FoodBeverageBindingSource5
        '
        Me.FoodBeverageBindingSource5.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource5.DataSource = Me.SMK_HotelDataSet
        '
        'simpanqty
        '
        Me.simpanqty.AutoSize = True
        Me.simpanqty.Location = New System.Drawing.Point(463, 233)
        Me.simpanqty.Name = "simpanqty"
        Me.simpanqty.Size = New System.Drawing.Size(39, 13)
        Me.simpanqty.TabIndex = 68
        Me.simpanqty.Text = "Label7"
        '
        'FoodBeverageBindingSource6
        '
        Me.FoodBeverageBindingSource6.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource6.DataSource = Me.SMK_HotelDataSet
        '
        'TransactionFoodBeverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.btninputitem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tambah)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.cbroomnumber)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "TransactionFoodBeverage"
        Me.Text = "TransactionFoodBeverage"
        CType(Me.FoodBeverageDetailBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageDetailBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RoomBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents tambah As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents cbroomnumber As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnsubmit As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbitem As ComboBox
    Friend WithEvents nudqty As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btntransaction As Button
    Friend WithEvents btninputitem As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents FoodBeverageDetailBindingSource As BindingSource
    Friend WithEvents FoodBeverageDetailTableAdapter As SMK_HotelDataSetTableAdapters.FoodBeverageDetailTableAdapter
    Friend WithEvents RoomBindingSource As BindingSource
    Friend WithEvents RoomTableAdapter As SMK_HotelDataSetTableAdapters.RoomTableAdapter
    Friend WithEvents FoodBeverageDetailBindingSource1 As BindingSource
    Friend WithEvents FoodBeverageBindingSource As BindingSource
    Friend WithEvents FoodBeverageTableAdapter As SMK_HotelDataSetTableAdapters.FoodBeverageTableAdapter
    Friend WithEvents btnadd As Button
    Friend WithEvents CustomerTableAdapter1 As SMK_HotelDataSetTableAdapters.CustomerTableAdapter
    Friend WithEvents RoomNumber As DataGridViewTextBoxColumn
    Friend WithEvents Column1 As DataGridViewTextBoxColumn
    Friend WithEvents Column2 As DataGridViewTextBoxColumn
    Friend WithEvents price As DataGridViewTextBoxColumn
    Friend WithEvents cbprice As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents hitung As Label
    Friend WithEvents FoodBeverageBindingSource1 As BindingSource
    Friend WithEvents FoodBeverageDetailBindingSource2 As BindingSource
    Friend WithEvents FoodBeverageBindingSource2 As BindingSource
    Friend WithEvents FoodBeverageDetailBindingSource3 As BindingSource
    Friend WithEvents FoodBeverageBindingSource3 As BindingSource
    Friend WithEvents RoomBindingSource2 As BindingSource
    Friend WithEvents RoomBindingSource1 As BindingSource
    Friend WithEvents RoomBindingSource3 As BindingSource
    Friend WithEvents FoodBeverageDetailBindingSource4 As BindingSource
    Friend WithEvents cbfoodID As ComboBox
    Friend WithEvents cbroomid As ComboBox
    Friend WithEvents cbqty As ComboBox
    Friend WithEvents FoodBeverageBindingSource5 As BindingSource
    Friend WithEvents FoodBeverageBindingSource4 As BindingSource
    Friend WithEvents simpanqty As Label
    Friend WithEvents FoodBeverageBindingSource6 As BindingSource
End Class
