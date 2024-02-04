<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class InputMenu
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
        Me.btninputitem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.tbprice = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.cbitem = New System.Windows.Forms.ComboBox()
        Me.FoodBeverageBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.nudqty = New System.Windows.Forms.NumericUpDown()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgvinputmenu = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodNameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FoodBeverageBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.id = New System.Windows.Forms.Label()
        Me.FoodBeverageTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.FoodBeverageTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.FoodBeverageBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvinputmenu, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.FoodBeverageBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btntransaction
        '
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Location = New System.Drawing.Point(12, 103)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(98, 36)
        Me.btntransaction.TabIndex = 61
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.UseVisualStyleBackColor = True
        '
        'btninputitem
        '
        Me.btninputitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninputitem.Location = New System.Drawing.Point(12, 61)
        Me.btninputitem.Name = "btninputitem"
        Me.btninputitem.Size = New System.Drawing.Size(98, 36)
        Me.btninputitem.TabIndex = 60
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
        Me.Label2.TabIndex = 59
        Me.Label2.Text = "Food Beverage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 58
        Me.Label1.Text = "SMK Hotel"
        '
        'btnupdate
        '
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Location = New System.Drawing.Point(642, 372)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 23)
        Me.btnupdate.TabIndex = 64
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Location = New System.Drawing.Point(642, 343)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 23)
        Me.btninsert.TabIndex = 63
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Location = New System.Drawing.Point(642, 403)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 23)
        Me.btndelete.TabIndex = 65
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.tbprice)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.cbitem)
        Me.GroupBox1.Controls.Add(Me.nudqty)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.dgvinputmenu)
        Me.GroupBox1.Controls.Add(Me.id)
        Me.GroupBox1.Location = New System.Drawing.Point(137, 75)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(580, 262)
        Me.GroupBox1.TabIndex = 62
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Input Menu"
        '
        'tbprice
        '
        Me.tbprice.Location = New System.Drawing.Point(67, 62)
        Me.tbprice.Name = "tbprice"
        Me.tbprice.Size = New System.Drawing.Size(203, 20)
        Me.tbprice.TabIndex = 45
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(13, 65)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 44
        Me.Label5.Text = "Price"
        '
        'cbitem
        '
        Me.cbitem.DataSource = Me.FoodBeverageBindingSource1
        Me.cbitem.DisplayMember = "FoodName"
        Me.cbitem.FormattingEnabled = True
        Me.cbitem.Location = New System.Drawing.Point(67, 29)
        Me.cbitem.Name = "cbitem"
        Me.cbitem.Size = New System.Drawing.Size(203, 21)
        Me.cbitem.TabIndex = 43
        Me.cbitem.ValueMember = "FoodName"
        '
        'FoodBeverageBindingSource1
        '
        Me.FoodBeverageBindingSource1.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'nudqty
        '
        Me.nudqty.Location = New System.Drawing.Point(67, 97)
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
        Me.Label3.Size = New System.Drawing.Size(30, 13)
        Me.Label3.TabIndex = 1
        Me.Label3.Text = "Item "
        '
        'dgvinputmenu
        '
        Me.dgvinputmenu.AutoGenerateColumns = False
        Me.dgvinputmenu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvinputmenu.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.FoodNameDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.PriceDataGridViewTextBoxColumn})
        Me.dgvinputmenu.DataSource = Me.FoodBeverageBindingSource
        Me.dgvinputmenu.Location = New System.Drawing.Point(0, 145)
        Me.dgvinputmenu.Name = "dgvinputmenu"
        Me.dgvinputmenu.Size = New System.Drawing.Size(580, 117)
        Me.dgvinputmenu.TabIndex = 0
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'FoodNameDataGridViewTextBoxColumn
        '
        Me.FoodNameDataGridViewTextBoxColumn.DataPropertyName = "FoodName"
        Me.FoodNameDataGridViewTextBoxColumn.HeaderText = "FoodName"
        Me.FoodNameDataGridViewTextBoxColumn.Name = "FoodNameDataGridViewTextBoxColumn"
        '
        'QtyDataGridViewTextBoxColumn
        '
        Me.QtyDataGridViewTextBoxColumn.DataPropertyName = "Qty"
        Me.QtyDataGridViewTextBoxColumn.HeaderText = "Qty"
        Me.QtyDataGridViewTextBoxColumn.Name = "QtyDataGridViewTextBoxColumn"
        '
        'PriceDataGridViewTextBoxColumn
        '
        Me.PriceDataGridViewTextBoxColumn.DataPropertyName = "Price"
        Me.PriceDataGridViewTextBoxColumn.HeaderText = "Price"
        Me.PriceDataGridViewTextBoxColumn.Name = "PriceDataGridViewTextBoxColumn"
        '
        'FoodBeverageBindingSource
        '
        Me.FoodBeverageBindingSource.DataMember = "FoodBeverage"
        Me.FoodBeverageBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(335, 184)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(39, 13)
        Me.id.TabIndex = 46
        Me.id.Text = "Label6"
        '
        'FoodBeverageTableAdapter
        '
        Me.FoodBeverageTableAdapter.ClearBeforeFill = True
        '
        'InputMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.btninputitem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "InputMenu"
        Me.Text = "menu"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.FoodBeverageBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvinputmenu, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.FoodBeverageBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btntransaction As Button
    Friend WithEvents btninputitem As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents btnupdate As Button
    Friend WithEvents btninsert As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents cbitem As ComboBox
    Friend WithEvents nudqty As NumericUpDown
    Friend WithEvents Label4 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvinputmenu As DataGridView
    Friend WithEvents tbprice As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents FoodBeverageBindingSource As BindingSource
    Friend WithEvents FoodBeverageTableAdapter As SMK_HotelDataSetTableAdapters.FoodBeverageTableAdapter
    Friend WithEvents FoodBeverageBindingSource1 As BindingSource
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents FoodNameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents id As Label
End Class
