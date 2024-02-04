<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckOut
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
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.nudqty = New System.Windows.Forms.NumericUpDown()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.dgvcheckout = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationRoomIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ItemIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.QtyDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TotalPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationRequestItemBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.cbitem = New System.Windows.Forms.ComboBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.cbroomnumber = New System.Windows.Forms.ComboBox()
        Me.btnsubmit = New System.Windows.Forms.Button()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.price = New System.Windows.Forms.Label()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.btnreservation = New System.Windows.Forms.Button()
        Me.btnmasterroom = New System.Windows.Forms.Button()
        Me.btnmasteruser = New System.Windows.Forms.Button()
        Me.ReservationRequestItemTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter()
        Me.GroupBox1.SuspendLayout()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvcheckout, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(134, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Check Out"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 14
        Me.Label2.Text = "Front Office"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "SMK Hotel"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.nudqty)
        Me.GroupBox1.Controls.Add(Me.btnadd)
        Me.GroupBox1.Controls.Add(Me.dgvcheckout)
        Me.GroupBox1.Controls.Add(Me.cbitem)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Location = New System.Drawing.Point(137, 153)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(656, 245)
        Me.GroupBox1.TabIndex = 17
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Items Detail"
        '
        'nudqty
        '
        Me.nudqty.Location = New System.Drawing.Point(94, 62)
        Me.nudqty.Name = "nudqty"
        Me.nudqty.Size = New System.Drawing.Size(259, 20)
        Me.nudqty.TabIndex = 28
        '
        'btnadd
        '
        Me.btnadd.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnadd.Location = New System.Drawing.Point(562, 50)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(88, 27)
        Me.btnadd.TabIndex = 27
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'dgvcheckout
        '
        Me.dgvcheckout.AutoGenerateColumns = False
        Me.dgvcheckout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvcheckout.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReservationRoomIDDataGridViewTextBoxColumn, Me.ItemIDDataGridViewTextBoxColumn, Me.QtyDataGridViewTextBoxColumn, Me.TotalPriceDataGridViewTextBoxColumn})
        Me.dgvcheckout.DataSource = Me.ReservationRequestItemBindingSource
        Me.dgvcheckout.Location = New System.Drawing.Point(6, 95)
        Me.dgvcheckout.Name = "dgvcheckout"
        Me.dgvcheckout.Size = New System.Drawing.Size(644, 144)
        Me.dgvcheckout.TabIndex = 22
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
        'ReservationRequestItemBindingSource
        '
        Me.ReservationRequestItemBindingSource.DataMember = "ReservationRequestItem"
        Me.ReservationRequestItemBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'cbitem
        '
        Me.cbitem.FormattingEnabled = True
        Me.cbitem.Location = New System.Drawing.Point(94, 30)
        Me.cbitem.Name = "cbitem"
        Me.cbitem.Size = New System.Drawing.Size(259, 21)
        Me.cbitem.TabIndex = 20
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(15, 64)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(23, 13)
        Me.Label6.TabIndex = 21
        Me.Label6.Text = "Qty"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(15, 33)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(27, 13)
        Me.Label5.TabIndex = 20
        Me.Label5.Text = "Item"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 13)
        Me.Label4.TabIndex = 18
        Me.Label4.Text = "Room Number"
        '
        'cbroomnumber
        '
        Me.cbroomnumber.FormattingEnabled = True
        Me.cbroomnumber.Location = New System.Drawing.Point(231, 107)
        Me.cbroomnumber.Name = "cbroomnumber"
        Me.cbroomnumber.Size = New System.Drawing.Size(259, 21)
        Me.cbroomnumber.TabIndex = 19
        '
        'btnsubmit
        '
        Me.btnsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsubmit.Location = New System.Drawing.Point(699, 413)
        Me.btnsubmit.Name = "btnsubmit"
        Me.btnsubmit.Size = New System.Drawing.Size(88, 27)
        Me.btnsubmit.TabIndex = 28
        Me.btnsubmit.Text = "Submit"
        Me.btnsubmit.UseVisualStyleBackColor = True
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(134, 413)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(91, 13)
        Me.Label8.TabIndex = 30
        Me.Label8.Text = "Total Charge : Rp"
        '
        'price
        '
        Me.price.AutoSize = True
        Me.price.Location = New System.Drawing.Point(228, 413)
        Me.price.Name = "price"
        Me.price.Size = New System.Drawing.Size(13, 13)
        Me.price.TabIndex = 31
        Me.price.Text = "0"
        '
        'btntransaction
        '
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Location = New System.Drawing.Point(12, 271)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(98, 36)
        Me.btntransaction.TabIndex = 37
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.UseVisualStyleBackColor = True
        '
        'btncheckout
        '
        Me.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckout.Location = New System.Drawing.Point(12, 229)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(98, 36)
        Me.btncheckout.TabIndex = 36
        Me.btncheckout.Text = "Check Out"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'btncheckin
        '
        Me.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckin.Location = New System.Drawing.Point(12, 187)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(98, 36)
        Me.btncheckin.TabIndex = 35
        Me.btncheckin.Text = "Check-In"
        Me.btncheckin.UseVisualStyleBackColor = True
        '
        'btnreservation
        '
        Me.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreservation.Location = New System.Drawing.Point(12, 145)
        Me.btnreservation.Name = "btnreservation"
        Me.btnreservation.Size = New System.Drawing.Size(98, 36)
        Me.btnreservation.TabIndex = 34
        Me.btnreservation.Text = "Reservation"
        Me.btnreservation.UseVisualStyleBackColor = True
        '
        'btnmasterroom
        '
        Me.btnmasterroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasterroom.Location = New System.Drawing.Point(12, 103)
        Me.btnmasterroom.Name = "btnmasterroom"
        Me.btnmasterroom.Size = New System.Drawing.Size(98, 36)
        Me.btnmasterroom.TabIndex = 33
        Me.btnmasterroom.Text = "Master Room"
        Me.btnmasterroom.UseVisualStyleBackColor = True
        '
        'btnmasteruser
        '
        Me.btnmasteruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasteruser.Location = New System.Drawing.Point(12, 61)
        Me.btnmasteruser.Name = "btnmasteruser"
        Me.btnmasteruser.Size = New System.Drawing.Size(98, 36)
        Me.btnmasteruser.TabIndex = 32
        Me.btnmasteruser.Text = "Master User"
        Me.btnmasteruser.UseVisualStyleBackColor = True
        '
        'ReservationRequestItemTableAdapter
        '
        Me.ReservationRequestItemTableAdapter.ClearBeforeFill = True
        '
        'CheckOut
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.btncheckin)
        Me.Controls.Add(Me.btnreservation)
        Me.Controls.Add(Me.btnmasterroom)
        Me.Controls.Add(Me.btnmasteruser)
        Me.Controls.Add(Me.price)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.btnsubmit)
        Me.Controls.Add(Me.cbroomnumber)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CheckOut"
        Me.Text = "CheckOut"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.nudqty, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvcheckout, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRequestItemBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents Label4 As Label
    Friend WithEvents dgvcheckout As DataGridView
    Friend WithEvents cbitem As ComboBox
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents cbroomnumber As ComboBox
    Friend WithEvents btnadd As Button
    Friend WithEvents btnsubmit As Button
    Friend WithEvents Label8 As Label
    Friend WithEvents price As Label
    Friend WithEvents btntransaction As Button
    Friend WithEvents btncheckout As Button
    Friend WithEvents btncheckin As Button
    Friend WithEvents btnreservation As Button
    Friend WithEvents btnmasterroom As Button
    Friend WithEvents btnmasteruser As Button
    Friend WithEvents nudqty As NumericUpDown
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents ReservationRequestItemBindingSource As BindingSource
    Friend WithEvents ReservationRequestItemTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRequestItemTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationRoomIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ItemIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents QtyDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents TotalPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
