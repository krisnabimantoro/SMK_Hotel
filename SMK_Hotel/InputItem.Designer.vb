<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputItem
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
        Me.btnreqadditem = New System.Windows.Forms.Button()
        Me.btninputitem = New System.Windows.Forms.Button()
        Me.ID = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.price = New System.Windows.Forms.Label()
        Me.tbprice = New System.Windows.Forms.TextBox()
        Me.nudqty = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMK_HotelDataSet1 = New SMK_Hotel.SMK_HotelDataSet1()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.ItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ItemTableAdapter()
        Me.ItemBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ItemTableAdapter1 = New SMK_Hotel.SMK_HotelDataSet1TableAdapters.ItemTableAdapter()
        Me.tbitem = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ItemBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnreqadditem
        '
        Me.btnreqadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreqadditem.Location = New System.Drawing.Point(12, 103)
        Me.btnreqadditem.Name = "btnreqadditem"
        Me.btnreqadditem.Size = New System.Drawing.Size(98, 36)
        Me.btnreqadditem.TabIndex = 41
        Me.btnreqadditem.Text = "Request Additional Item"
        Me.btnreqadditem.UseVisualStyleBackColor = True
        '
        'btninputitem
        '
        Me.btninputitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninputitem.Location = New System.Drawing.Point(12, 61)
        Me.btninputitem.Name = "btninputitem"
        Me.btninputitem.Size = New System.Drawing.Size(98, 36)
        Me.btninputitem.TabIndex = 40
        Me.btninputitem.Text = "Input Item"
        Me.btninputitem.UseVisualStyleBackColor = True
        '
        'ID
        '
        Me.ID.AutoSize = True
        Me.ID.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.ID.Location = New System.Drawing.Point(12, 38)
        Me.ID.Name = "ID"
        Me.ID.Size = New System.Drawing.Size(84, 15)
        Me.ID.TabIndex = 39
        Me.ID.Text = "Room Service"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "SMK Hotel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbitem)
        Me.GroupBox1.Controls.Add(Me.price)
        Me.GroupBox1.Controls.Add(Me.tbprice)
        Me.GroupBox1.Controls.Add(Me.nudqty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.DataGridView1)
        Me.GroupBox1.Location = New System.Drawing.Point(151, 61)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 288)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Item"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Location = New System.Drawing.Point(13, 103)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(31, 13)
        Me.price.TabIndex = 45
        Me.price.Text = "Price"
        '
        'tbprice
        '
        Me.tbprice.Location = New System.Drawing.Point(67, 100)
        Me.tbprice.Name = "tbprice"
        Me.tbprice.Size = New System.Drawing.Size(203, 20)
        Me.tbprice.TabIndex = 44
        '
        'nudqty
        '
        Me.nudqty.Location = New System.Drawing.Point(67, 63)
        Me.nudqty.Name = "nudqty"
        Me.nudqty.Size = New System.Drawing.Size(203, 20)
        Me.nudqty.TabIndex = 3
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(13, 65)
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
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.ItemBindingSource4
        Me.DataGridView1.Location = New System.Drawing.Point(0, 159)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(580, 123)
        Me.DataGridView1.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'ItemBindingSource4
        '
        Me.ItemBindingSource4.DataMember = "Item"
        Me.ItemBindingSource4.DataSource = Me.SMK_HotelDataSet1
        '
        'SMK_HotelDataSet1
        '
        Me.SMK_HotelDataSet1.DataSetName = "SMK_HotelDataSet1"
        Me.SMK_HotelDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'btninsert
        '
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Location = New System.Drawing.Point(666, 355)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 23)
        Me.btninsert.TabIndex = 43
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Location = New System.Drawing.Point(666, 384)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 44
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Location = New System.Drawing.Point(666, 415)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 45
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'ItemBindingSource1
        '
        Me.ItemBindingSource1.DataMember = "Item"
        Me.ItemBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'ItemBindingSource2
        '
        Me.ItemBindingSource2.DataMember = "Item"
        Me.ItemBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'ItemBindingSource3
        '
        Me.ItemBindingSource3.DataMember = "Item"
        Me.ItemBindingSource3.DataSource = Me.SMK_HotelDataSet
        '
        'ItemTableAdapter1
        '
        Me.ItemTableAdapter1.ClearBeforeFill = True
        '
        'tbitem
        '
        Me.tbitem.Location = New System.Drawing.Point(67, 29)
        Me.tbitem.Name = "tbitem"
        Me.tbitem.Size = New System.Drawing.Size(203, 20)
        Me.tbitem.TabIndex = 46
        '
        'InputItem
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btnreqadditem)
        Me.Controls.Add(Me.btninputitem)
        Me.Controls.Add(Me.ID)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InputItem"
        Me.Text = "InputItem"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ItemBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnreqadditem As Button
    Friend WithEvents btninputitem As Button
    Friend WithEvents ID As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label3 As Label
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents btninsert As Button
    Friend WithEvents nudqty As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents ItemBindingSource As BindingSource
    Friend WithEvents ItemTableAdapter As SMK_HotelDataSetTableAdapters.ItemTableAdapter
    Friend WithEvents price As Label
    Friend WithEvents tbprice As TextBox
    Friend WithEvents ItemBindingSource1 As BindingSource
    Friend WithEvents ItemBindingSource2 As BindingSource
    Friend WithEvents ItemBindingSource3 As BindingSource
    Friend WithEvents SMK_HotelDataSet1 As SMK_HotelDataSet1
    Friend WithEvents ItemBindingSource4 As BindingSource
    Friend WithEvents ItemTableAdapter1 As SMK_HotelDataSet1TableAdapters.ItemTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents tbitem As TextBox
End Class
