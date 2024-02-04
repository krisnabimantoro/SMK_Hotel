<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MasterUser
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
        Me.dgvmasteruser = New System.Windows.Forms.DataGridView()
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.UsernameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PasswordDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateOfBirthDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.JobIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbconfirmpassword = New System.Windows.Forms.TextBox()
        Me.tbpassword = New System.Windows.Forms.TextBox()
        Me.tbusername = New System.Windows.Forms.TextBox()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.tbaddress = New System.Windows.Forms.TextBox()
        Me.dateofbirth = New System.Windows.Forms.DateTimePicker()
        Me.btninsert = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndelete = New System.Windows.Forms.Button()
        Me.btncancel = New System.Windows.Forms.Button()
        Me.cbjob = New System.Windows.Forms.ComboBox()
        Me.JobBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btncheckout = New System.Windows.Forms.Button()
        Me.btncheckin = New System.Windows.Forms.Button()
        Me.btnreservation = New System.Windows.Forms.Button()
        Me.btnmasterroom = New System.Windows.Forms.Button()
        Me.btnmasteruser = New System.Windows.Forms.Button()
        Me.EmployeeTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.EmployeeTableAdapter()
        Me.JobTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.JobTableAdapter()
        Me.id = New System.Windows.Forms.Label()
        CType(Me.dgvmasteruser, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!)
        Me.Label2.Location = New System.Drawing.Point(12, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(69, 15)
        Me.Label2.TabIndex = 7
        Me.Label2.Text = "Front Office"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 6
        Me.Label1.Text = "SMK Hotel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(130, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(85, 17)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Master User"
        '
        'dgvmasteruser
        '
        Me.dgvmasteruser.AutoGenerateColumns = False
        Me.dgvmasteruser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvmasteruser.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.UsernameDataGridViewTextBoxColumn, Me.PasswordDataGridViewTextBoxColumn, Me.NameDataGridViewTextBoxColumn, Me.EmailDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.DateOfBirthDataGridViewTextBoxColumn, Me.JobIDDataGridViewTextBoxColumn})
        Me.dgvmasteruser.DataSource = Me.EmployeeBindingSource
        Me.dgvmasteruser.Location = New System.Drawing.Point(133, 100)
        Me.dgvmasteruser.Name = "dgvmasteruser"
        Me.dgvmasteruser.Size = New System.Drawing.Size(753, 187)
        Me.dgvmasteruser.TabIndex = 10
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        Me.IDDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.IDDataGridViewTextBoxColumn.Visible = False
        '
        'UsernameDataGridViewTextBoxColumn
        '
        Me.UsernameDataGridViewTextBoxColumn.DataPropertyName = "Username"
        Me.UsernameDataGridViewTextBoxColumn.HeaderText = "Username"
        Me.UsernameDataGridViewTextBoxColumn.Name = "UsernameDataGridViewTextBoxColumn"
        '
        'PasswordDataGridViewTextBoxColumn
        '
        Me.PasswordDataGridViewTextBoxColumn.DataPropertyName = "Password"
        Me.PasswordDataGridViewTextBoxColumn.HeaderText = "Password"
        Me.PasswordDataGridViewTextBoxColumn.Name = "PasswordDataGridViewTextBoxColumn"
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'EmailDataGridViewTextBoxColumn
        '
        Me.EmailDataGridViewTextBoxColumn.DataPropertyName = "Email"
        Me.EmailDataGridViewTextBoxColumn.HeaderText = "Email"
        Me.EmailDataGridViewTextBoxColumn.Name = "EmailDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'DateOfBirthDataGridViewTextBoxColumn
        '
        Me.DateOfBirthDataGridViewTextBoxColumn.DataPropertyName = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.HeaderText = "DateOfBirth"
        Me.DateOfBirthDataGridViewTextBoxColumn.Name = "DateOfBirthDataGridViewTextBoxColumn"
        '
        'JobIDDataGridViewTextBoxColumn
        '
        Me.JobIDDataGridViewTextBoxColumn.DataPropertyName = "JobID"
        Me.JobIDDataGridViewTextBoxColumn.HeaderText = "JobID"
        Me.JobIDDataGridViewTextBoxColumn.Name = "JobIDDataGridViewTextBoxColumn"
        '
        'EmployeeBindingSource
        '
        Me.EmployeeBindingSource.DataMember = "Employee"
        Me.EmployeeBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(130, 311)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 13)
        Me.Label4.TabIndex = 11
        Me.Label4.Text = "Username"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(130, 352)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(53, 13)
        Me.Label5.TabIndex = 12
        Me.Label5.Text = "Password"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(130, 395)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(91, 13)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Confirm Password"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(130, 437)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(35, 13)
        Me.Label7.TabIndex = 14
        Me.Label7.Text = "Name"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(130, 479)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(32, 13)
        Me.Label8.TabIndex = 15
        Me.Label8.Text = "Email"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(130, 522)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 13)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Date Of Birth"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(130, 563)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(24, 13)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Job"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(130, 611)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(45, 13)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Address"
        '
        'tbconfirmpassword
        '
        Me.tbconfirmpassword.Location = New System.Drawing.Point(265, 392)
        Me.tbconfirmpassword.Name = "tbconfirmpassword"
        Me.tbconfirmpassword.Size = New System.Drawing.Size(297, 20)
        Me.tbconfirmpassword.TabIndex = 19
        '
        'tbpassword
        '
        Me.tbpassword.Location = New System.Drawing.Point(265, 349)
        Me.tbpassword.Name = "tbpassword"
        Me.tbpassword.Size = New System.Drawing.Size(297, 20)
        Me.tbpassword.TabIndex = 20
        '
        'tbusername
        '
        Me.tbusername.Location = New System.Drawing.Point(265, 308)
        Me.tbusername.Name = "tbusername"
        Me.tbusername.Size = New System.Drawing.Size(297, 20)
        Me.tbusername.TabIndex = 21
        '
        'tbname
        '
        Me.tbname.Location = New System.Drawing.Point(265, 434)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(297, 20)
        Me.tbname.TabIndex = 22
        '
        'tbemail
        '
        Me.tbemail.Location = New System.Drawing.Point(265, 476)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(297, 20)
        Me.tbemail.TabIndex = 23
        '
        'tbaddress
        '
        Me.tbaddress.Location = New System.Drawing.Point(265, 611)
        Me.tbaddress.Multiline = True
        Me.tbaddress.Name = "tbaddress"
        Me.tbaddress.Size = New System.Drawing.Size(297, 94)
        Me.tbaddress.TabIndex = 24
        '
        'dateofbirth
        '
        Me.dateofbirth.Location = New System.Drawing.Point(265, 516)
        Me.dateofbirth.Name = "dateofbirth"
        Me.dateofbirth.Size = New System.Drawing.Size(297, 20)
        Me.dateofbirth.TabIndex = 25
        '
        'btninsert
        '
        Me.btninsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninsert.Location = New System.Drawing.Point(705, 345)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(88, 27)
        Me.btninsert.TabIndex = 26
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnupdate.Location = New System.Drawing.Point(705, 395)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(88, 27)
        Me.btnupdate.TabIndex = 27
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btndelete.Location = New System.Drawing.Point(705, 446)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(88, 27)
        Me.btndelete.TabIndex = 28
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btncancel
        '
        Me.btncancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btncancel.Location = New System.Drawing.Point(705, 569)
        Me.btncancel.Name = "btncancel"
        Me.btncancel.Size = New System.Drawing.Size(88, 27)
        Me.btncancel.TabIndex = 30
        Me.btncancel.Text = "Cancel"
        Me.btncancel.UseVisualStyleBackColor = True
        '
        'cbjob
        '
        Me.cbjob.DataBindings.Add(New System.Windows.Forms.Binding("SelectedValue", Me.EmployeeBindingSource, "JobID", True))
        Me.cbjob.DataSource = Me.JobBindingSource
        Me.cbjob.DisplayMember = "Name"
        Me.cbjob.FormattingEnabled = True
        Me.cbjob.Location = New System.Drawing.Point(265, 560)
        Me.cbjob.Name = "cbjob"
        Me.cbjob.Size = New System.Drawing.Size(297, 21)
        Me.cbjob.TabIndex = 31
        Me.cbjob.ValueMember = "ID"
        '
        'JobBindingSource
        '
        Me.JobBindingSource.DataMember = "Job"
        Me.JobBindingSource.DataSource = Me.SMK_HotelDataSet
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
        Me.btnmasteruser.Enabled = False
        Me.btnmasteruser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnmasteruser.Location = New System.Drawing.Point(12, 61)
        Me.btnmasteruser.Name = "btnmasteruser"
        Me.btnmasteruser.Size = New System.Drawing.Size(98, 36)
        Me.btnmasteruser.TabIndex = 32
        Me.btnmasteruser.Text = "Master User"
        Me.btnmasteruser.UseVisualStyleBackColor = True
        '
        'EmployeeTableAdapter
        '
        Me.EmployeeTableAdapter.ClearBeforeFill = True
        '
        'JobTableAdapter
        '
        Me.JobTableAdapter.ClearBeforeFill = True
        '
        'id
        '
        Me.id.AutoSize = True
        Me.id.Location = New System.Drawing.Point(405, 145)
        Me.id.Name = "id"
        Me.id.Size = New System.Drawing.Size(45, 13)
        Me.id.TabIndex = 38
        Me.id.Text = "Label12"
        '
        'MasterUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(1059, 724)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.btncheckout)
        Me.Controls.Add(Me.btncheckin)
        Me.Controls.Add(Me.btnreservation)
        Me.Controls.Add(Me.btnmasterroom)
        Me.Controls.Add(Me.btnmasteruser)
        Me.Controls.Add(Me.cbjob)
        Me.Controls.Add(Me.btncancel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.dateofbirth)
        Me.Controls.Add(Me.tbaddress)
        Me.Controls.Add(Me.tbemail)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.tbusername)
        Me.Controls.Add(Me.tbpassword)
        Me.Controls.Add(Me.tbconfirmpassword)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.dgvmasteruser)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.id)
        Me.Name = "MasterUser"
        Me.Text = "MasterUser"
        CType(Me.dgvmasteruser, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmployeeBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.JobBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents dgvmasteruser As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents tbconfirmpassword As TextBox
    Friend WithEvents tbpassword As TextBox
    Friend WithEvents tbusername As TextBox
    Friend WithEvents tbname As TextBox
    Friend WithEvents tbemail As TextBox
    Friend WithEvents tbaddress As TextBox
    Friend WithEvents dateofbirth As DateTimePicker
    Friend WithEvents btninsert As Button
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndelete As Button
    Friend WithEvents btncancel As Button
    Friend WithEvents cbjob As ComboBox
    Friend WithEvents btntransaction As Button
    Friend WithEvents btncheckout As Button
    Friend WithEvents btncheckin As Button
    Friend WithEvents btnreservation As Button
    Friend WithEvents btnmasterroom As Button
    Friend WithEvents btnmasteruser As Button
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents EmployeeBindingSource As BindingSource
    Friend WithEvents EmployeeTableAdapter As SMK_HotelDataSetTableAdapters.EmployeeTableAdapter
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents UsernameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents PasswordDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents NameDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmailDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateOfBirthDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents JobBindingSource As BindingSource
    Friend WithEvents JobTableAdapter As SMK_HotelDataSetTableAdapters.JobTableAdapter
    Friend WithEvents id As Label
End Class
