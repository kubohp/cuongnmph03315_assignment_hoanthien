<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class typeproducts
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
        Me.type_id = New System.Windows.Forms.Label()
        Me.name_type = New System.Windows.Forms.Label()
        Me.btok_Click = New System.Windows.Forms.Button()
        Me.btcancel_Click = New System.Windows.Forms.Button()
        Me.type_id_box = New System.Windows.Forms.TextBox()
        Me.name_type_box = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'type_id
        '
        Me.type_id.AutoSize = True
        Me.type_id.Location = New System.Drawing.Point(23, 53)
        Me.type_id.Name = "type_id"
        Me.type_id.Size = New System.Drawing.Size(45, 13)
        Me.type_id.TabIndex = 0
        Me.type_id.Text = "Type ID"
        '
        'name_type
        '
        Me.name_type.AutoSize = True
        Me.name_type.Location = New System.Drawing.Point(23, 106)
        Me.name_type.Name = "name_type"
        Me.name_type.Size = New System.Drawing.Size(62, 13)
        Me.name_type.TabIndex = 0
        Me.name_type.Text = "Name Type"
        '
        'btok_Click
        '
        Me.btok_Click.Location = New System.Drawing.Point(50, 158)
        Me.btok_Click.Name = "btok_Click"
        Me.btok_Click.Size = New System.Drawing.Size(89, 29)
        Me.btok_Click.TabIndex = 3
        Me.btok_Click.Text = "&OK"
        Me.btok_Click.UseVisualStyleBackColor = True
        '
        'btcancel_Click
        '
        Me.btcancel_Click.Location = New System.Drawing.Point(181, 158)
        Me.btcancel_Click.Name = "btcancel_Click"
        Me.btcancel_Click.Size = New System.Drawing.Size(77, 29)
        Me.btcancel_Click.TabIndex = 3
        Me.btcancel_Click.Text = "&Cancel"
        Me.btcancel_Click.UseVisualStyleBackColor = True
        '
        'type_id_box
        '
        Me.type_id_box.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.type_id_box.Location = New System.Drawing.Point(120, 46)
        Me.type_id_box.Name = "type_id_box"
        Me.type_id_box.Size = New System.Drawing.Size(160, 20)
        Me.type_id_box.TabIndex = 4
        '
        'name_type_box
        '
        Me.name_type_box.Location = New System.Drawing.Point(120, 103)
        Me.name_type_box.Name = "name_type_box"
        Me.name_type_box.Size = New System.Drawing.Size(160, 20)
        Me.name_type_box.TabIndex = 4
        '
        'typeproducts
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(295, 225)
        Me.Controls.Add(Me.name_type_box)
        Me.Controls.Add(Me.type_id_box)
        Me.Controls.Add(Me.btcancel_Click)
        Me.Controls.Add(Me.btok_Click)
        Me.Controls.Add(Me.name_type)
        Me.Controls.Add(Me.type_id)
        Me.Name = "typeproducts"
        Me.Text = "Type Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents type_id As Label
    Friend WithEvents name_type As Label
    Friend WithEvents btok_Click As Button
    Friend WithEvents btcancel_Click As Button
    Friend WithEvents type_id_box As TextBox
    Friend WithEvents name_type_box As TextBox
End Class
