﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FoodBeverage
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.btntransaction = New System.Windows.Forms.Button()
        Me.btninputitem = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btntransaction
        '
        Me.btntransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btntransaction.Location = New System.Drawing.Point(12, 103)
        Me.btntransaction.Name = "btntransaction"
        Me.btntransaction.Size = New System.Drawing.Size(98, 36)
        Me.btntransaction.TabIndex = 57
        Me.btntransaction.Text = "Transaction"
        Me.btntransaction.UseVisualStyleBackColor = True
        '
        'btninputitem
        '
        Me.btninputitem.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btninputitem.Location = New System.Drawing.Point(12, 61)
        Me.btninputitem.Name = "btninputitem"
        Me.btninputitem.Size = New System.Drawing.Size(98, 36)
        Me.btninputitem.TabIndex = 56
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
        Me.Label2.TabIndex = 55
        Me.Label2.Text = "Food Beverage"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 20)
        Me.Label1.TabIndex = 54
        Me.Label1.Text = "SMK Hotel"
        '
        'FoodBeverage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SkyBlue
        Me.ClientSize = New System.Drawing.Size(924, 519)
        Me.Controls.Add(Me.btntransaction)
        Me.Controls.Add(Me.btninputitem)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "FoodBeverage"
        Me.Text = "FoodBeverage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btntransaction As Button
    Friend WithEvents btninputitem As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
End Class
