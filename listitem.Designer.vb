<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listitems
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.searchfield = New System.Windows.Forms.TextBox()
        Me.listviewproduct = New System.Windows.Forms.DataGridView()
        Me.listsearch = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btinsert = New System.Windows.Forms.Button()
        Me.btdelete = New System.Windows.Forms.Button()
        Me.btupdate = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.listclassify = New System.Windows.Forms.ComboBox()
        Me.GroupBox = New System.Windows.Forms.GroupBox()
        Me.rbtProducts = New System.Windows.Forms.RadioButton()
        Me.rbtInvoices = New System.Windows.Forms.RadioButton()
        Me.rbtType_ProductS = New System.Windows.Forms.RadioButton()
        Me.AddInvoice = New System.Windows.Forms.Button()
        Me.AddCustomer = New System.Windows.Forms.Button()
        Me.AddTypeProduct = New System.Windows.Forms.Button()
        Me.SearchBox = New System.Windows.Forms.GroupBox()
        Me.updateInvoice = New System.Windows.Forms.Button()
        Me.updateType = New System.Windows.Forms.Button()
        Me.updateCustomer = New System.Windows.Forms.Button()
        Me.rbtCustomers = New System.Windows.Forms.RadioButton()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        CType(Me.listviewproduct, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox.SuspendLayout()
        Me.SearchBox.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label1.Location = New System.Drawing.Point(6, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 16)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Search"
        '
        'searchfield
        '
        Me.searchfield.Location = New System.Drawing.Point(63, 15)
        Me.searchfield.Name = "searchfield"
        Me.searchfield.Size = New System.Drawing.Size(567, 20)
        Me.searchfield.TabIndex = 1
        '
        'listviewproduct
        '
        Me.listviewproduct.BackgroundColor = System.Drawing.SystemColors.HighlightText
        Me.listviewproduct.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.listviewproduct.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None
        Me.listviewproduct.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.Padding = New System.Windows.Forms.Padding(1)
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listviewproduct.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.listviewproduct.ColumnHeadersHeight = 25
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Tahoma", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.listviewproduct.DefaultCellStyle = DataGridViewCellStyle2
        Me.listviewproduct.GridColor = System.Drawing.SystemColors.ControlLightLight
        Me.listviewproduct.Location = New System.Drawing.Point(18, 19)
        Me.listviewproduct.MultiSelect = False
        Me.listviewproduct.Name = "listviewproduct"
        Me.listviewproduct.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.listviewproduct.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.listviewproduct.RowHeadersVisible = False
        Me.listviewproduct.ShowCellToolTips = False
        Me.listviewproduct.Size = New System.Drawing.Size(493, 338)
        Me.listviewproduct.TabIndex = 2
        '
        'listsearch
        '
        Me.listsearch.FormattingEnabled = True
        Me.listsearch.Items.AddRange(New Object() {"Product Id", "Product Name"})
        Me.listsearch.Location = New System.Drawing.Point(111, 13)
        Me.listsearch.Name = "listsearch"
        Me.listsearch.Size = New System.Drawing.Size(121, 21)
        Me.listsearch.TabIndex = 3
        Me.listsearch.Text = "Selection"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label2.Location = New System.Drawing.Point(6, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(99, 16)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Filter Products :"
        '
        'btinsert
        '
        Me.btinsert.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btinsert.ForeColor = System.Drawing.Color.Red
        Me.btinsert.Location = New System.Drawing.Point(766, 113)
        Me.btinsert.Name = "btinsert"
        Me.btinsert.Size = New System.Drawing.Size(112, 36)
        Me.btinsert.TabIndex = 5
        Me.btinsert.Text = "Add &Product"
        Me.btinsert.UseVisualStyleBackColor = True
        '
        'btdelete
        '
        Me.btdelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btdelete.ForeColor = System.Drawing.Color.Red
        Me.btdelete.Location = New System.Drawing.Point(766, 174)
        Me.btdelete.Name = "btdelete"
        Me.btdelete.Size = New System.Drawing.Size(111, 36)
        Me.btdelete.TabIndex = 6
        Me.btdelete.Text = "&Delete"
        Me.btdelete.UseVisualStyleBackColor = True
        '
        'btupdate
        '
        Me.btupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.btupdate.ForeColor = System.Drawing.Color.Red
        Me.btupdate.Location = New System.Drawing.Point(905, 286)
        Me.btupdate.Name = "btupdate"
        Me.btupdate.Size = New System.Drawing.Size(115, 36)
        Me.btupdate.TabIndex = 7
        Me.btupdate.Text = "&Update"
        Me.btupdate.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.DodgerBlue
        Me.Label3.Location = New System.Drawing.Point(578, 70)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 15)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Classify By"
        '
        'listclassify
        '
        Me.listclassify.FormattingEnabled = True
        Me.listclassify.Location = New System.Drawing.Point(683, 70)
        Me.listclassify.Name = "listclassify"
        Me.listclassify.Size = New System.Drawing.Size(121, 21)
        Me.listclassify.TabIndex = 8
        '
        'GroupBox
        '
        Me.GroupBox.BackColor = System.Drawing.SystemColors.Control
        Me.GroupBox.Controls.Add(Me.listviewproduct)
        Me.GroupBox.Location = New System.Drawing.Point(31, 79)
        Me.GroupBox.Name = "GroupBox"
        Me.GroupBox.Size = New System.Drawing.Size(520, 373)
        Me.GroupBox.TabIndex = 10
        Me.GroupBox.TabStop = False
        '
        'rbtProducts
        '
        Me.rbtProducts.AutoSize = True
        Me.rbtProducts.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rbtProducts.ForeColor = System.Drawing.Color.DodgerBlue
        Me.rbtProducts.Location = New System.Drawing.Point(798, 286)
        Me.rbtProducts.Name = "rbtProducts"
        Me.rbtProducts.Size = New System.Drawing.Size(90, 24)
        Me.rbtProducts.TabIndex = 13
        Me.rbtProducts.Text = "Products"
        Me.rbtProducts.UseVisualStyleBackColor = True
        '
        'rbtInvoices
        '
        Me.rbtInvoices.AutoSize = True
        Me.rbtInvoices.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rbtInvoices.ForeColor = System.Drawing.Color.DodgerBlue
        Me.rbtInvoices.Location = New System.Drawing.Point(557, 371)
        Me.rbtInvoices.Name = "rbtInvoices"
        Me.rbtInvoices.Size = New System.Drawing.Size(85, 24)
        Me.rbtInvoices.TabIndex = 15
        Me.rbtInvoices.Text = "Invoices"
        Me.rbtInvoices.UseVisualStyleBackColor = True
        '
        'rbtType_ProductS
        '
        Me.rbtType_ProductS.AutoSize = True
        Me.rbtType_ProductS.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rbtType_ProductS.ForeColor = System.Drawing.Color.DodgerBlue
        Me.rbtType_ProductS.Location = New System.Drawing.Point(823, 371)
        Me.rbtType_ProductS.Name = "rbtType_ProductS"
        Me.rbtType_ProductS.Size = New System.Drawing.Size(65, 24)
        Me.rbtType_ProductS.TabIndex = 16
        Me.rbtType_ProductS.Text = "Type "
        Me.rbtType_ProductS.UseVisualStyleBackColor = True
        '
        'AddInvoice
        '
        Me.AddInvoice.ForeColor = System.Drawing.Color.Red
        Me.AddInvoice.Location = New System.Drawing.Point(581, 113)
        Me.AddInvoice.Name = "AddInvoice"
        Me.AddInvoice.Size = New System.Drawing.Size(112, 36)
        Me.AddInvoice.TabIndex = 8
        Me.AddInvoice.Text = "Add &Invoice"
        Me.AddInvoice.UseVisualStyleBackColor = True
        '
        'AddCustomer
        '
        Me.AddCustomer.ForeColor = System.Drawing.Color.Red
        Me.AddCustomer.Location = New System.Drawing.Point(581, 174)
        Me.AddCustomer.Name = "AddCustomer"
        Me.AddCustomer.Size = New System.Drawing.Size(112, 36)
        Me.AddCustomer.TabIndex = 8
        Me.AddCustomer.Text = "Add &Customer"
        Me.AddCustomer.UseVisualStyleBackColor = True
        '
        'AddTypeProduct
        '
        Me.AddTypeProduct.ForeColor = System.Drawing.Color.Red
        Me.AddTypeProduct.Location = New System.Drawing.Point(905, 113)
        Me.AddTypeProduct.Name = "AddTypeProduct"
        Me.AddTypeProduct.Size = New System.Drawing.Size(112, 36)
        Me.AddTypeProduct.TabIndex = 8
        Me.AddTypeProduct.Text = "Add &Type"
        Me.AddTypeProduct.UseVisualStyleBackColor = True
        '
        'SearchBox
        '
        Me.SearchBox.Controls.Add(Me.Label1)
        Me.SearchBox.Controls.Add(Me.searchfield)
        Me.SearchBox.Location = New System.Drawing.Point(31, 21)
        Me.SearchBox.Name = "SearchBox"
        Me.SearchBox.Size = New System.Drawing.Size(511, 43)
        Me.SearchBox.TabIndex = 18
        Me.SearchBox.TabStop = False
        '
        'updateInvoice
        '
        Me.updateInvoice.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.updateInvoice.ForeColor = System.Drawing.Color.Red
        Me.updateInvoice.Location = New System.Drawing.Point(677, 371)
        Me.updateInvoice.Name = "updateInvoice"
        Me.updateInvoice.Size = New System.Drawing.Size(115, 36)
        Me.updateInvoice.TabIndex = 7
        Me.updateInvoice.Text = "&Update"
        Me.updateInvoice.UseVisualStyleBackColor = True
        '
        'updateType
        '
        Me.updateType.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.updateType.ForeColor = System.Drawing.Color.Red
        Me.updateType.Location = New System.Drawing.Point(905, 359)
        Me.updateType.Name = "updateType"
        Me.updateType.Size = New System.Drawing.Size(115, 36)
        Me.updateType.TabIndex = 7
        Me.updateType.Text = "&Update"
        Me.updateType.UseVisualStyleBackColor = True
        '
        'updateCustomer
        '
        Me.updateCustomer.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.updateCustomer.ForeColor = System.Drawing.Color.Red
        Me.updateCustomer.Location = New System.Drawing.Point(677, 286)
        Me.updateCustomer.Name = "updateCustomer"
        Me.updateCustomer.Size = New System.Drawing.Size(115, 36)
        Me.updateCustomer.TabIndex = 7
        Me.updateCustomer.Text = "&Update"
        Me.updateCustomer.UseVisualStyleBackColor = True
        '
        'rbtCustomers
        '
        Me.rbtCustomers.AutoSize = True
        Me.rbtCustomers.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(163, Byte))
        Me.rbtCustomers.ForeColor = System.Drawing.Color.DodgerBlue
        Me.rbtCustomers.Location = New System.Drawing.Point(557, 291)
        Me.rbtCustomers.Name = "rbtCustomers"
        Me.rbtCustomers.Size = New System.Drawing.Size(104, 24)
        Me.rbtCustomers.TabIndex = 14
        Me.rbtCustomers.Text = "Customers"
        Me.rbtCustomers.UseVisualStyleBackColor = True
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.Label2)
        Me.GroupBox6.Controls.Add(Me.listsearch)
        Me.GroupBox6.Location = New System.Drawing.Point(722, 21)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(287, 43)
        Me.GroupBox6.TabIndex = 20
        Me.GroupBox6.TabStop = False
        '
        'listitems
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Menu
        Me.ClientSize = New System.Drawing.Size(1021, 477)
        Me.Controls.Add(Me.btdelete)
        Me.Controls.Add(Me.updateType)
        Me.Controls.Add(Me.listclassify)
        Me.Controls.Add(Me.rbtProducts)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.rbtType_ProductS)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.btupdate)
        Me.Controls.Add(Me.AddInvoice)
        Me.Controls.Add(Me.updateInvoice)
        Me.Controls.Add(Me.rbtInvoices)
        Me.Controls.Add(Me.SearchBox)
        Me.Controls.Add(Me.btinsert)
        Me.Controls.Add(Me.updateCustomer)
        Me.Controls.Add(Me.AddCustomer)
        Me.Controls.Add(Me.rbtCustomers)
        Me.Controls.Add(Me.AddTypeProduct)
        Me.Controls.Add(Me.GroupBox)
        Me.Name = "listitems"
        Me.Text = "Application : Manage"
        CType(Me.listviewproduct, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox.ResumeLayout(False)
        Me.SearchBox.ResumeLayout(False)
        Me.SearchBox.PerformLayout()
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents searchfield As TextBox
    Friend WithEvents listviewproduct As DataGridView
    Friend WithEvents listsearch As ComboBox
    Friend WithEvents Label2 As Label
    Friend WithEvents btinsert As Button
    Friend WithEvents btdelete As Button
    Friend WithEvents btupdate As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents listclassify As ComboBox
    Friend WithEvents GroupBox As GroupBox
    Friend WithEvents rbtProducts As RadioButton
    Friend WithEvents rbtInvoices As RadioButton
    Friend WithEvents rbtType_ProductS As RadioButton
    Friend WithEvents SearchBox As GroupBox
    Friend WithEvents GroupBox6 As GroupBox
    Friend WithEvents rbtCustomers As RadioButton
    Friend WithEvents AddTypeProduct As Button
    Friend WithEvents AddInvoice As Button
    Friend WithEvents AddCustomer As Button
    Friend WithEvents updateInvoice As Button
    Friend WithEvents updateType As Button
    Friend WithEvents updateCustomer As Button
End Class
