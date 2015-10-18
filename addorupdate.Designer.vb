<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class addorupdate
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.idproductfield = New System.Windows.Forms.TextBox()
        Me.amountfield = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pricefield = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.nameproductfield = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.listclassify = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.descriptionfield = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btok = New System.Windows.Forms.Button()
        Me.btcancel = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(27, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(16, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Id"
        '
        'idproductfield
        '
        Me.idproductfield.Location = New System.Drawing.Point(102, 20)
        Me.idproductfield.Name = "idproductfield"
        Me.idproductfield.Size = New System.Drawing.Size(296, 20)
        Me.idproductfield.TabIndex = 1
        '
        'amountfield
        '
        Me.amountfield.Location = New System.Drawing.Point(102, 134)
        Me.amountfield.Name = "amountfield"
        Me.amountfield.Size = New System.Drawing.Size(296, 20)
        Me.amountfield.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 137)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(43, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Amount"
        '
        'pricefield
        '
        Me.pricefield.Location = New System.Drawing.Point(102, 95)
        Me.pricefield.Name = "pricefield"
        Me.pricefield.Size = New System.Drawing.Size(296, 20)
        Me.pricefield.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(27, 98)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Price"
        '
        'nameproductfield
        '
        Me.nameproductfield.Location = New System.Drawing.Point(102, 58)
        Me.nameproductfield.Name = "nameproductfield"
        Me.nameproductfield.Size = New System.Drawing.Size(296, 20)
        Me.nameproductfield.TabIndex = 7
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(27, 61)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 13)
        Me.Label4.TabIndex = 6
        Me.Label4.Text = "Name"
        '
        'listclassify
        '
        Me.listclassify.FormattingEnabled = True
        Me.listclassify.Location = New System.Drawing.Point(102, 172)
        Me.listclassify.Name = "listclassify"
        Me.listclassify.Size = New System.Drawing.Size(296, 21)
        Me.listclassify.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(24, 175)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(31, 13)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Type"
        '
        'descriptionfield
        '
        Me.descriptionfield.Location = New System.Drawing.Point(102, 212)
        Me.descriptionfield.Multiline = True
        Me.descriptionfield.Name = "descriptionfield"
        Me.descriptionfield.Size = New System.Drawing.Size(296, 69)
        Me.descriptionfield.TabIndex = 11
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(27, 215)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(60, 13)
        Me.Label6.TabIndex = 10
        Me.Label6.Text = "Description"
        '
        'btok
        '
        Me.btok.Location = New System.Drawing.Point(107, 301)
        Me.btok.Name = "btok"
        Me.btok.Size = New System.Drawing.Size(98, 43)
        Me.btok.TabIndex = 12
        Me.btok.Text = "&OK"
        Me.btok.UseVisualStyleBackColor = True
        '
        'btcancel
        '
        Me.btcancel.Location = New System.Drawing.Point(245, 301)
        Me.btcancel.Name = "btcancel"
        Me.btcancel.Size = New System.Drawing.Size(98, 43)
        Me.btcancel.TabIndex = 13
        Me.btcancel.Text = "&Cancel"
        Me.btcancel.UseVisualStyleBackColor = True
        '
        'addorupdate
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ClientSize = New System.Drawing.Size(431, 371)
        Me.Controls.Add(Me.btcancel)
        Me.Controls.Add(Me.btok)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.listclassify)
        Me.Controls.Add(Me.nameproductfield)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.pricefield)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.amountfield)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.idproductfield)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.descriptionfield)
        Me.Name = "addorupdate"
        Me.Text = "Products"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents idproductfield As TextBox
    Friend WithEvents amountfield As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents pricefield As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents nameproductfield As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents listclassify As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents descriptionfield As TextBox
    Friend WithEvents Label6 As Label
    Friend WithEvents btok As Button
    Friend WithEvents btcancel As Button
End Class
