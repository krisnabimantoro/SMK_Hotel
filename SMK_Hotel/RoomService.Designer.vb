<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class RoomService
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
        Me.btnreqadditem = New System.Windows.Forms.Button()
        Me.btninputitem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnreqadditem
        '
        Me.btnreqadditem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnreqadditem.Location = New System.Drawing.Point(12, 103)
        Me.btnreqadditem.Name = "btnreqadditem"
        Me.btnreqadditem.Size = New System.Drawing.Size(98, 36)
        Me.btnreqadditem.TabIndex = 37
        Me.btnreqadditem.Text = "Request Additional Item"
        Me.btnreqadditem.UseVisualStyleBackColor = True
        '
        'btninputitem
        '
        Me.btninputitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninputitem.Location = New System.Drawing.Point(12, 61)
        Me.btninputitem.Name = "btninputitem"
        Me.btninputitem.Size = New System.Drawing.Size(98, 36)
        Me.btninputitem.TabIndex = 36
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
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Room Service"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "SMK Hotel"
        '
        'RoomService
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btnreqadditem)
        Me.Controls.Add(Me.btninputitem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "RoomService"
        Me.Text = "RoomService"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnreqadditem As Button
    Friend WithEvents btninputitem As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
