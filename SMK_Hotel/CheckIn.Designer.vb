<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class CheckIn
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.tbbookingcode = New System.Windows.Forms.TextBox()
        Me.btnsearch = New System.Windows.Forms.Button()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dgvroomdetail = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rbfemale = New System.Windows.Forms.RadioButton()
        Me.rbmale = New System.Windows.Forms.RadioButton()
        Me.tbage = New System.Windows.Forms.TextBox()
        Me.tbnik = New System.Windows.Forms.TextBox()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tbphonenumber = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnreservation = New System.Windows.Forms.Button()
        Me.btnmasterroom = New System.Windows.Forms.Button()
        Me.btnmasteruser = New System.Windows.Forms.Button()
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.ReservationRoomBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationRoomTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationRoomTableAdapter()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReservationIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.StartDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DurationNightsDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RoomPriceDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckInDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CheckOutDateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgvroomdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationRoomBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(134, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 16
        Me.Label3.Text = "Check In"
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
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(134, 110)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(74, 13)
        Me.Label4.TabIndex = 17
        Me.Label4.Text = "Booking Code"
        '
        'tbbookingcode
        '
        Me.tbbookingcode.Location = New System.Drawing.Point(243, 107)
        Me.tbbookingcode.Name = "tbbookingcode"
        Me.tbbookingcode.Size = New System.Drawing.Size(227, 20)
        Me.tbbookingcode.TabIndex = 18
        '
        'btnsearch
        '
        Me.btnsearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnsearch.Location = New System.Drawing.Point(499, 104)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(76, 24)
        Me.btnsearch.TabIndex = 27
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btncheckin
        '
        Me.btncheckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckin.Location = New System.Drawing.Point(744, 371)
        Me.btncheckin.Name = "btncheckin"
        Me.btncheckin.Size = New System.Drawing.Size(88, 27)
        Me.btncheckin.TabIndex = 28
        Me.btncheckin.Text = "Check In"
        Me.btncheckin.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgvroomdetail)
        Me.GroupBox1.Location = New System.Drawing.Point(137, 150)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(333, 215)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Room Details"
        '
        'dgvroomdetail
        '
        Me.dgvroomdetail.AutoGenerateColumns = False
        Me.dgvroomdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvroomdetail.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.ReservationIDDataGridViewTextBoxColumn, Me.RoomIDDataGridViewTextBoxColumn, Me.StartDateTimeDataGridViewTextBoxColumn, Me.DurationNightsDataGridViewTextBoxColumn, Me.RoomPriceDataGridViewTextBoxColumn, Me.CheckInDateTimeDataGridViewTextBoxColumn, Me.CheckOutDateTimeDataGridViewTextBoxColumn})
        Me.dgvroomdetail.DataSource = Me.ReservationRoomBindingSource
        Me.dgvroomdetail.Location = New System.Drawing.Point(0, 31)
        Me.dgvroomdetail.Name = "dgvroomdetail"
        Me.dgvroomdetail.Size = New System.Drawing.Size(333, 184)
        Me.dgvroomdetail.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rbfemale)
        Me.GroupBox2.Controls.Add(Me.rbmale)
        Me.GroupBox2.Controls.Add(Me.tbage)
        Me.GroupBox2.Controls.Add(Me.tbnik)
        Me.GroupBox2.Controls.Add(Me.tbemail)
        Me.GroupBox2.Controls.Add(Me.tbname)
        Me.GroupBox2.Controls.Add(Me.tbphonenumber)
        Me.GroupBox2.Controls.Add(Me.Label10)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(499, 150)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(333, 215)
        Me.GroupBox2.TabIndex = 30
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Customer"
        '
        'rbfemale
        '
        Me.rbfemale.AutoSize = True
        Me.rbfemale.Location = New System.Drawing.Point(193, 116)
        Me.rbfemale.Name = "rbfemale"
        Me.rbfemale.Size = New System.Drawing.Size(59, 17)
        Me.rbfemale.TabIndex = 12
        Me.rbfemale.TabStop = True
        Me.rbfemale.Text = "Female"
        Me.rbfemale.UseVisualStyleBackColor = True
        '
        'rbmale
        '
        Me.rbmale.AutoSize = True
        Me.rbmale.Location = New System.Drawing.Point(114, 116)
        Me.rbmale.Name = "rbmale"
        Me.rbmale.Size = New System.Drawing.Size(48, 17)
        Me.rbmale.TabIndex = 11
        Me.rbmale.TabStop = True
        Me.rbmale.Text = "Male"
        Me.rbmale.UseVisualStyleBackColor = True
        '
        'tbage
        '
        Me.tbage.Location = New System.Drawing.Point(114, 149)
        Me.tbage.Name = "tbage"
        Me.tbage.Size = New System.Drawing.Size(204, 20)
        Me.tbage.TabIndex = 10
        '
        'tbnik
        '
        Me.tbnik.Location = New System.Drawing.Point(114, 175)
        Me.tbnik.Name = "tbnik"
        Me.tbnik.Size = New System.Drawing.Size(204, 20)
        Me.tbnik.TabIndex = 9
        '
        'tbemail
        '
        Me.tbemail.Location = New System.Drawing.Point(114, 81)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(195, 20)
        Me.tbemail.TabIndex = 8
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(114, 54)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(195, 20)
        Me.tbname.TabIndex = 7
        '
        'tbphonenumber
        '
        Me.tbphonenumber.Location = New System.Drawing.Point(114, 28)
        Me.tbphonenumber.Name = "tbphonenumber"
        Me.tbphonenumber.Size = New System.Drawing.Size(195, 20)
        Me.tbphonenumber.TabIndex = 6
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(17, 178)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(25, 13)
        Me.Label10.TabIndex = 5
        Me.Label10.Text = "NIK"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(17, 149)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(26, 13)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Age"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(17, 118)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(42, 13)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "Gender"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(17, 90)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(32, 13)
        Me.Label7.TabIndex = 2
        Me.Label7.Text = "Email"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(17, 58)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(35, 13)
        Me.Label6.TabIndex = 1
        Me.Label6.Text = "Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(17, 31)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(78, 13)
        Me.Label5.TabIndex = 0
        Me.Label5.Text = "Phone Number"
        '
        'btntransaction
        '
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Location = New System.Drawing.Point(12, 271)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(98, 36)
        Me.btntransaction.TabIndex = 36
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.UseVisualStyleBackColor = True
        '
        'btncheckout
        '
        Me.btncheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncheckout.Location = New System.Drawing.Point(12, 229)
        Me.btncheckout.Name = "btncheckout"
        Me.btncheckout.Size = New System.Drawing.Size(98, 36)
        Me.btncheckout.TabIndex = 35
        Me.btncheckout.Text = "Check Out"
        Me.btncheckout.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Location = New System.Drawing.Point(12, 187)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(98, 36)
        Me.Button1.TabIndex = 34
        Me.Button1.Text = "Check-In"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'btnreservation
        '
        Me.btnreservation.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreservation.Location = New System.Drawing.Point(12, 145)
        Me.btnreservation.Name = "btnreservation"
        Me.btnreservation.Size = New System.Drawing.Size(98, 36)
        Me.btnreservation.TabIndex = 33
        Me.btnreservation.Text = "Reservation"
        Me.btnreservation.UseVisualStyleBackColor = True
        '
        'btnmasterroom
        '
        Me.btnmasterroom.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasterroom.Location = New System.Drawing.Point(12, 103)
        Me.btnmasterroom.Name = "btnmasterroom"
        Me.btnmasterroom.Size = New System.Drawing.Size(98, 36)
        Me.btnmasterroom.TabIndex = 32
        Me.btnmasterroom.Text = "Master Room"
        Me.btnmasterroom.UseVisualStyleBackColor = True
        '
        'btnmasteruser
        '
        Me.btnmasteruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasteruser.Location = New System.Drawing.Point(12, 61)
        Me.btnmasteruser.Name = "btnmasteruser"
        Me.btnmasteruser.Size = New System.Drawing.Size(98, 36)
        Me.btnmasteruser.TabIndex = 31
        Me.btnmasteruser.Text = "Master User"
        Me.btnmasteruser.UseVisualStyleBackColor = True
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
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'ReservationIDDataGridViewTextBoxColumn
        '
        Me.ReservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID"
        Me.ReservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID"
        Me.ReservationIDDataGridViewTextBoxColumn.Name = "ReservationIDDataGridViewTextBoxColumn"
        '
        'RoomIDDataGridViewTextBoxColumn
        '
        Me.RoomIDDataGridViewTextBoxColumn.DataPropertyName = "RoomID"
        Me.RoomIDDataGridViewTextBoxColumn.HeaderText = "RoomID"
        Me.RoomIDDataGridViewTextBoxColumn.Name = "RoomIDDataGridViewTextBoxColumn"
        '
        'StartDateTimeDataGridViewTextBoxColumn
        '
        Me.StartDateTimeDataGridViewTextBoxColumn.DataPropertyName = "StartDateTime"
        Me.StartDateTimeDataGridViewTextBoxColumn.HeaderText = "StartDateTime"
        Me.StartDateTimeDataGridViewTextBoxColumn.Name = "StartDateTimeDataGridViewTextBoxColumn"
        '
        'DurationNightsDataGridViewTextBoxColumn
        '
        Me.DurationNightsDataGridViewTextBoxColumn.DataPropertyName = "DurationNights"
        Me.DurationNightsDataGridViewTextBoxColumn.HeaderText = "DurationNights"
        Me.DurationNightsDataGridViewTextBoxColumn.Name = "DurationNightsDataGridViewTextBoxColumn"
        '
        'RoomPriceDataGridViewTextBoxColumn
        '
        Me.RoomPriceDataGridViewTextBoxColumn.DataPropertyName = "RoomPrice"
        Me.RoomPriceDataGridViewTextBoxColumn.HeaderText = "RoomPrice"
        Me.RoomPriceDataGridViewTextBoxColumn.Name = "RoomPriceDataGridViewTextBoxColumn"
        '
        'CheckInDateTimeDataGridViewTextBoxColumn
        '
        Me.CheckInDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckInDateTime"
        Me.CheckInDateTimeDataGridViewTextBoxColumn.HeaderText = "CheckInDateTime"
        Me.CheckInDateTimeDataGridViewTextBoxColumn.Name = "CheckInDateTimeDataGridViewTextBoxColumn"
        '
        'CheckOutDateTimeDataGridViewTextBoxColumn
        '
        Me.CheckOutDateTimeDataGridViewTextBoxColumn.DataPropertyName = "CheckOutDateTime"
        Me.CheckOutDateTimeDataGridViewTextBoxColumn.HeaderText = "CheckOutDateTime"
        Me.CheckOutDateTimeDataGridViewTextBoxColumn.Name = "CheckOutDateTimeDataGridViewTextBoxColumn"
        '
        'CheckIn
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnreservation)
        Me.Controls.Add(Me.btnmasterroom)
        Me.Controls.Add(Me.btnmasteruser)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.btncheckin)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.tbbookingcode)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "CheckIn"
        Me.Text = "CheckIn"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgvroomdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationRoomBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label3 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents tbbookingcode As TextBox
    Friend WithEvents btnsearch As Button
    Friend WithEvents btncheckin As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents dgvroomdetail As DataGridView
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents rbfemale As RadioButton
    Friend WithEvents rbmale As RadioButton
    Friend WithEvents tbage As TextBox
    Friend WithEvents tbnik As TextBox
    Friend WithEvents tbemail As TextBox
    Friend WithEvents tbname As TextBox
    Friend WithEvents tbphonenumber As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents btntransaction As Button
    Friend WithEvents btncheckout As Button
    Friend WithEvents Button1 As Button
    Friend WithEvents btnreservation As Button
    Friend WithEvents btnmasterroom As Button
    Friend WithEvents btnmasteruser As Button
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents ReservationRoomBindingSource As BindingSource
    Friend WithEvents ReservationRoomTableAdapter As SMK_HotelDataSetTableAdapters.ReservationRoomTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents StartDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DurationNightsDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents RoomPriceDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckInDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CheckOutDateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
End Class
