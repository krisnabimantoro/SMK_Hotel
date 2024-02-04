<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ReservationReport
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
        Me.btnreportckout = New System.Windows.Forms.Button()
        Me.btnreportckin = New System.Windows.Forms.Button()
        Me.btntransactioncustomer = New System.Windows.Forms.Button()
        Me.btnreportres = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnexportexcel = New System.Windows.Forms.Button()
        Me.SMK_HotelDataSet = New SMK_Hotel.SMK_HotelDataSet()
        Me.ReservationBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableAdapter = New SMK_Hotel.SMK_HotelDataSetTableAdapters.ReservationTableAdapter()
        Me.ReservationBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.SMK_HotelDataSet2 = New SMK_Hotel.SMK_HotelDataSet2()
        Me.ReservationBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReservationTableAdapter1 = New SMK_Hotel.SMK_HotelDataSet2TableAdapters.ReservationTableAdapter()
        Me.dgvreservationreport = New System.Windows.Forms.DataGridView()
        Me.ReservationBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.IDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DateTimeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmployeeIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CodeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SMK_HotelDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgvreservationreport, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ReservationBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnreportckout
        '
        Me.btnreportckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportckout.Location = New System.Drawing.Point(12, 145)
        Me.btnreportckout.Name = "btnreportckout"
        Me.btnreportckout.Size = New System.Drawing.Size(98, 36)
        Me.btnreportckout.TabIndex = 78
        Me.btnreportckout.Text = "Check-Out   Report"
        Me.btnreportckout.UseVisualStyleBackColor = True
        '
        'btnreportckin
        '
        Me.btnreportckin.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportckin.Location = New System.Drawing.Point(12, 103)
        Me.btnreportckin.Name = "btnreportckin"
        Me.btnreportckin.Size = New System.Drawing.Size(98, 36)
        Me.btnreportckin.TabIndex = 77
        Me.btnreportckin.Text = "Check-In   Report"
        Me.btnreportckin.UseVisualStyleBackColor = True
        '
        'btntransactioncustomer
        '
        Me.btntransactioncustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransactioncustomer.Location = New System.Drawing.Point(12, 187)
        Me.btntransactioncustomer.Name = "btntransactioncustomer"
        Me.btntransactioncustomer.Size = New System.Drawing.Size(98, 36)
        Me.btntransactioncustomer.TabIndex = 76
        Me.btntransactioncustomer.Text = "Transaction Customer Report"
        Me.btntransactioncustomer.UseVisualStyleBackColor = True
        '
        'btnreportres
        '
        Me.btnreportres.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreportres.Location = New System.Drawing.Point(12, 61)
        Me.btnreportres.Name = "btnreportres"
        Me.btnreportres.Size = New System.Drawing.Size(98, 36)
        Me.btnreportres.TabIndex = 75
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
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "Employee"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 73
        Me.Label1.Text = "SMK Hotel"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(141, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(131, 17)
        Me.Label3.TabIndex = 79
        Me.Label3.Text = "Reservation Report"
        '
        'btnexportexcel
        '
        Me.btnexportexcel.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnexportexcel.Location = New System.Drawing.Point(144, 319)
        Me.btnexportexcel.Name = "btnexportexcel"
        Me.btnexportexcel.Size = New System.Drawing.Size(112, 34)
        Me.btnexportexcel.TabIndex = 83
        Me.btnexportexcel.Text = "Export Excel"
        Me.btnexportexcel.UseVisualStyleBackColor = True
        '
        'SMK_HotelDataSet
        '
        Me.SMK_HotelDataSet.DataSetName = "SMK_HotelDataSet"
        Me.SMK_HotelDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource
        '
        Me.ReservationBindingSource.DataMember = "Reservation"
        Me.ReservationBindingSource.DataSource = Me.SMK_HotelDataSet
        '
        'ReservationTableAdapter
        '
        Me.ReservationTableAdapter.ClearBeforeFill = True
        '
        'ReservationBindingSource1
        '
        Me.ReservationBindingSource1.DataMember = "Reservation"
        Me.ReservationBindingSource1.DataSource = Me.SMK_HotelDataSet
        '
        'ReservationBindingSource2
        '
        Me.ReservationBindingSource2.DataMember = "Reservation"
        Me.ReservationBindingSource2.DataSource = Me.SMK_HotelDataSet
        '
        'SMK_HotelDataSet2
        '
        Me.SMK_HotelDataSet2.DataSetName = "SMK_HotelDataSet2"
        Me.SMK_HotelDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReservationBindingSource3
        '
        Me.ReservationBindingSource3.DataMember = "Reservation"
        Me.ReservationBindingSource3.DataSource = Me.SMK_HotelDataSet2
        '
        'ReservationTableAdapter1
        '
        Me.ReservationTableAdapter1.ClearBeforeFill = True
        '
        'dgvreservationreport
        '
        Me.dgvreservationreport.AutoGenerateColumns = False
        Me.dgvreservationreport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvreservationreport.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.IDDataGridViewTextBoxColumn, Me.DateTimeDataGridViewTextBoxColumn, Me.EmployeeIDDataGridViewTextBoxColumn, Me.CustomerIDDataGridViewTextBoxColumn, Me.CodeDataGridViewTextBoxColumn})
        Me.dgvreservationreport.DataSource = Me.ReservationBindingSource4
        Me.dgvreservationreport.Location = New System.Drawing.Point(144, 115)
        Me.dgvreservationreport.Name = "dgvreservationreport"
        Me.dgvreservationreport.Size = New System.Drawing.Size(661, 150)
        Me.dgvreservationreport.TabIndex = 84
        '
        'ReservationBindingSource4
        '
        Me.ReservationBindingSource4.DataMember = "Reservation"
        Me.ReservationBindingSource4.DataSource = Me.SMK_HotelDataSet2
        '
        'IDDataGridViewTextBoxColumn
        '
        Me.IDDataGridViewTextBoxColumn.DataPropertyName = "ID"
        Me.IDDataGridViewTextBoxColumn.HeaderText = "ID"
        Me.IDDataGridViewTextBoxColumn.Name = "IDDataGridViewTextBoxColumn"
        Me.IDDataGridViewTextBoxColumn.ReadOnly = True
        '
        'DateTimeDataGridViewTextBoxColumn
        '
        Me.DateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime"
        Me.DateTimeDataGridViewTextBoxColumn.Name = "DateTimeDataGridViewTextBoxColumn"
        '
        'EmployeeIDDataGridViewTextBoxColumn
        '
        Me.EmployeeIDDataGridViewTextBoxColumn.DataPropertyName = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.HeaderText = "EmployeeID"
        Me.EmployeeIDDataGridViewTextBoxColumn.Name = "EmployeeIDDataGridViewTextBoxColumn"
        '
        'CustomerIDDataGridViewTextBoxColumn
        '
        Me.CustomerIDDataGridViewTextBoxColumn.DataPropertyName = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.HeaderText = "CustomerID"
        Me.CustomerIDDataGridViewTextBoxColumn.Name = "CustomerIDDataGridViewTextBoxColumn"
        '
        'CodeDataGridViewTextBoxColumn
        '
        Me.CodeDataGridViewTextBoxColumn.DataPropertyName = "Code"
        Me.CodeDataGridViewTextBoxColumn.HeaderText = "Code"
        Me.CodeDataGridViewTextBoxColumn.Name = "CodeDataGridViewTextBoxColumn"
        '
        'ReservationReport
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.dgvreservationreport)
        Me.Controls.Add(Me.btnexportexcel)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnreportckout)
        Me.Controls.Add(Me.btnreportckin)
        Me.Controls.Add(Me.btntransactioncustomer)
        Me.Controls.Add(Me.btnreportres)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "ReservationReport"
        Me.Text = "ReservationReport"
        CType(Me.SMK_HotelDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SMK_HotelDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgvreservationreport, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ReservationBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnreportckout As Button
    Friend WithEvents btnreportckin As Button
    Friend WithEvents btntransactioncustomer As Button
    Friend WithEvents btnreportres As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents btnexportexcel As Button
    Friend WithEvents SMK_HotelDataSet As SMK_HotelDataSet
    Friend WithEvents ReservationBindingSource As BindingSource
    Friend WithEvents ReservationTableAdapter As SMK_HotelDataSetTableAdapters.ReservationTableAdapter
    Friend WithEvents ReservationBindingSource1 As BindingSource
    Friend WithEvents ReservationBindingSource2 As BindingSource
    Friend WithEvents SMK_HotelDataSet2 As SMK_HotelDataSet2
    Friend WithEvents ReservationBindingSource3 As BindingSource
    Friend WithEvents ReservationTableAdapter1 As SMK_HotelDataSet2TableAdapters.ReservationTableAdapter
    Friend WithEvents dgvreservationreport As DataGridView
    Friend WithEvents IDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents DateTimeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents EmployeeIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CustomerIDDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents CodeDataGridViewTextBoxColumn As DataGridViewTextBoxColumn
    Friend WithEvents ReservationBindingSource4 As BindingSource
End Class
