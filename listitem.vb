Public Class listitems


    Private dbaccess As New DataBaseAccess
    Private isloading As Boolean = False

    Private Sub LoadTypesProductData()
        Dim querytable As String = "select type_id, type_name from dbo.types_product"
        Dim datatable As DataTable = dbaccess.GetDataTable(querytable)
        Me.listclassify.DataSource = datatable
        Me.listclassify.ValueMember = "type_id"
        Me.listclassify.DisplayMember = "type_name"

    End Sub

    Private Sub LoadProductsData(id_type As String)
        Dim query_products As String = String.Format("select product_id, product_name, amount, description, price from products where type_id = '{0}'", id_type)
        Dim datatable As DataTable = dbaccess.GetDataTable(query_products)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Product Id"
            .Columns(1).HeaderText = "Product Name"
            .Columns(2).HeaderText = "Amount"
            .Columns(3).HeaderText = "Description"
            .Columns(4).HeaderText = "Price"
        End With
    End Sub


    Private Sub ChooseIdType_SelectedIndexChanged(sender As Object, e As EventArgs) Handles listclassify.SelectedIndexChanged
        If Not isloading Then
            LoadProductsData(Me.listclassify.SelectedValue)
        End If
    End Sub

    'Search Products
    Private Sub FindProductsData(id_type As String, type_value As String)
        Dim query_products As String = String.Format("select product_id, product_name, amount, description, price from products where type_id = '{0}'", id_type)
        If Me.listsearch.SelectedIndex = 0 Then
            query_products += String.Format("and product_id like'{0}%'", type_value)
        ElseIf Me.listsearch.SelectedIndex = 1 Then
            query_products += String.Format("and product_name like'{0}%'", type_value)
        End If
        Dim datatable As DataTable = dbaccess.GetDataTable(query_products)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Product Id"
            .Columns(1).HeaderText = "Product Name"
            .Columns(2).HeaderText = "Amount"
            .Columns(3).HeaderText = "Description"
            .Columns(4).HeaderText = "Price"
        End With
    End Sub


    'Search Customer
    Function SearchCustomer(name As String)
        Dim query_products As String = String.Format("SELECT customer_id, customer_name, address, phone from customers where customer_name like'{0}%'", name)
        Dim datatable As DataTable = dbaccess.GetDataTable(query_products)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Id Customer"
            .Columns(1).HeaderText = "Name Customer"
            .Columns(2).HeaderText = "Address"
            .Columns(3).HeaderText = "Phone"
        End With
    End Function
    Function SearchCustomer1(name As String)
        Dim query_products As String = String.Format("SELECT customer_id, customer_name, address, phone from customers where customer_id like'{0}%'", name)
        Dim datatable As DataTable = dbaccess.GetDataTable(query_products)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Id Customer"
            .Columns(1).HeaderText = "Name Customer"
            .Columns(2).HeaderText = "Address"
            .Columns(3).HeaderText = "Phone"
        End With
    End Function
    'Seach Type Products
    Function SearchTypesProduct(Name As String)
        Dim query_products As String = String.Format("SELECT type_id, type_name from types_product where type_id like '{0}%'", Name)
        Dim datatable As DataTable = dbaccess.GetDataTable(query_products)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Id"
            .Columns(1).HeaderText = "Type Product"
        End With
    End Function
    'Seach Type Products
    Function SearchInvoice(Name As String)
        Dim query_products As String = String.Format("select invoice_id, initial_date, customer_id, total from invoices where invoice_id like '{0}%'", Name)
        Dim datatable As DataTable = dbaccess.GetDataTable(query_products)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "invoice_id"
            .Columns(1).HeaderText = "initial_date"
            .Columns(1).HeaderText = "customer_id"
            .Columns(1).HeaderText = "total"
        End With
    End Function
    Function SearchInvoice1(Name As String)
        Dim query_products As String = String.Format("select invoice_id, initial_date, customer_id, total from invoices where customer_id like '{0}%'", Name)
        Dim datatable As DataTable = dbaccess.GetDataTable(query_products)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "invoice_id"
            .Columns(1).HeaderText = "initial_date"
            .Columns(1).HeaderText = "customer_id"
            .Columns(1).HeaderText = "total"
        End With
    End Function


    'Ham check tim kiem
    Private Sub searchfield_TextChanged(sender As Object, e As EventArgs) Handles searchfield.TextChanged
        FindProductsData(Me.listclassify.SelectedValue, Me.searchfield.Text)


        If Me.rbtCustomers.Checked Then
            SearchCustomer(Me.searchfield.Text)
            'SearchCustomer1(Me.searchfield.Text)
        ElseIf rbtType_ProductS.Checked Then
            SearchTypesProduct(Me.searchfield.Text)
        ElseIf rbtInvoices.Checked Then
            SearchInvoice(Me.searchfield.Text)
            SearchInvoice1(Me.searchfield.Text)

        End If

    End Sub

    Private Sub ListItems_Load(sender As Object, e As EventArgs) Handles MyClass.Load
        isloading = True
        LoadTypesProductData()
        LoadProductsData(Me.listclassify.SelectedValue)
        isloading = False
    End Sub

    Private Sub btinsert_Click(sender As Object, e As EventArgs) Handles btinsert.Click

        Dim form_insert_item As New addorupdate(False)
        form_insert_item.Text = "Insert A New Item"
        form_insert_item.LoadTypesProductData()
        form_insert_item.ShowDialog()
        If form_insert_item.DialogResult = DialogResult.OK Then
            LoadProductsData(form_insert_item.listclassify.SelectedValue)
        End If

    End Sub

    Private Sub btupdate_Click(sender As Object, e As EventArgs) Handles btupdate.Click
        Dim form_insert_item As New addorupdate(True)
        form_insert_item.Text = "Update An Item"
        form_insert_item.idproductfield.ReadOnly = True
        form_insert_item.LoadTypesProductData()
        form_insert_item.listclassify.SelectedValue = Me.listclassify.SelectedValue
        form_insert_item.listclassify.SelectedText = Me.listclassify.SelectedText
        form_insert_item.listclassify.Enabled = False
        With Me.listviewproduct
            form_insert_item.idproductfield.Text = .Rows(.CurrentCell.RowIndex).Cells("product_id").Value
            form_insert_item.nameproductfield.Text = .Rows(.CurrentCell.RowIndex).Cells("product_name").Value
            form_insert_item.amountfield.Text = .Rows(.CurrentCell.RowIndex).Cells("amount").Value
            form_insert_item.descriptionfield.Text = .Rows(.CurrentCell.RowIndex).Cells("description").Value
            form_insert_item.pricefield.Text = .Rows(.CurrentCell.RowIndex).Cells("price").Value
        End With
        form_insert_item.ShowDialog()
        If form_insert_item.DialogResult = DialogResult.OK Then
            LoadProductsData(Me.listclassify.SelectedValue)
        End If
    End Sub
    Private Sub updateType_Click(sender As Object, e As EventArgs) Handles updateType.Click
        Dim form_insert_item As New typeproducts(True)
        form_insert_item.Text = "Update An Item"
        form_insert_item.type_id_box.ReadOnly = True

        With Me.listviewproduct
            form_insert_item.type_id_box.Text = .Rows(.CurrentCell.RowIndex).Cells("type_id").Value
            form_insert_item.name_type_box.Text = .Rows(.CurrentCell.RowIndex).Cells("type_name").Value

        End With
        form_insert_item.ShowDialog()
        If form_insert_item.DialogResult = DialogResult.OK Then
            LoadTypesProductDataOnGridView()
        End If
    End Sub
    Private Sub updateInvoice_Click(sender As Object, e As EventArgs) Handles updateInvoice.Click
        Dim form_insert_item As New AddInvoice(True)
        form_insert_item.Text = "Update An Item"
        form_insert_item.TextBox1.ReadOnly = True
        With Me.listviewproduct
            form_insert_item.TextBox1.Text = .Rows(.CurrentCell.RowIndex).Cells("invoice_id").Value
            form_insert_item.DateTimePicker1.Text = .Rows(.CurrentCell.RowIndex).Cells("initial_date").Value
            form_insert_item.TextBox3.Text = .Rows(.CurrentCell.RowIndex).Cells("customer_id").Value
            form_insert_item.TextBox4.Text = .Rows(.CurrentCell.RowIndex).Cells("total").Value
        End With
        form_insert_item.ShowDialog()
        If form_insert_item.DialogResult = DialogResult.OK Then
            LoadInvoiceOnGridView()
        End If
    End Sub
    Private Sub updateCustomer_Click(sender As Object, e As EventArgs) Handles updateCustomer.Click
        Dim form_insert_item As New addCustoms(True)
        form_insert_item.Text = "Update An Item"
        form_insert_item.TextBox1.ReadOnly = True

        With Me.listviewproduct
            form_insert_item.TextBox1.Text = .Rows(.CurrentCell.RowIndex).Cells("customer_id").Value
            form_insert_item.TextBox2.Text = .Rows(.CurrentCell.RowIndex).Cells("customer_name").Value
            form_insert_item.TextBox3.Text = .Rows(.CurrentCell.RowIndex).Cells("address").Value
            form_insert_item.TextBox4.Text = .Rows(.CurrentCell.RowIndex).Cells("phone").Value

        End With
        form_insert_item.ShowDialog()
        If form_insert_item.DialogResult = DialogResult.OK Then
            LoadCustomersOnGridView()
        End If
    End Sub


    Public Function DeleteProductData()
        Dim id_product As String = Me.listviewproduct.Rows(Me.listviewproduct.CurrentCell.RowIndex).Cells("product_id").Value
        Dim deleteproduct As String = String.Format("delete from products where product_id = '{0}'", id_product)

        If dbaccess.ExecuteNoneQuery(deleteproduct) Then
            MessageBox.Show("A Record Has Been Delete Successfully", "Confirm", MessageBoxButtons.OK)
            LoadProductsData(Me.listclassify.SelectedValue)
        Else
            MessageBox.Show("Error When Deleting Data From Database !", "Error", MessageBoxButtons.OK)
        End If
    End Function


    'Ham goi loai san pham
    Function LoadTypesProductDataOnGridView()

        Dim querytable As String = "select type_id, type_name from dbo.types_product"
        Dim datatable As DataTable = dbaccess.GetDataTable(querytable)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Types Product Id"
            .Columns(1).HeaderText = "Types Name"
        End With
    End Function
    'Ham goi khach hang bang radio button
    Function LoadInvoiceOnGridView()

        Dim querytable As String = "select invoice_id, initial_date, customer_id, total from dbo.invoices"
        Dim datatable As DataTable = dbaccess.GetDataTable(querytable)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Invoice Id"
            .Columns(1).HeaderText = "Invoice Date"
            .Columns(2).HeaderText = "Customer Id"
            .Columns(3).HeaderText = "Total"
        End With
    End Function
    'Ham goi khach hang bang radio button
    Function LoadCustomersOnGridView()

        Dim querytable As String = "select customer_id , customer_name , address , phone from dbo.customers"
        Dim datatable As DataTable = dbaccess.GetDataTable(querytable)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Customer Id"
            .Columns(1).HeaderText = "Customer Name"
            .Columns(2).HeaderText = "Address"
            .Columns(3).HeaderText = "Phone"
        End With
    End Function
    Function CallBackProductsData()
        Dim querytable As String = "select product_id, product_name, amount, description, price from products "
        Dim datatable As DataTable = dbaccess.GetDataTable(querytable)
        Me.listviewproduct.DataSource = datatable
        With Me.listviewproduct
            .Columns(0).HeaderText = "Product Id"
            .Columns(1).HeaderText = "Product Name"
            .Columns(2).HeaderText = "Amount"
            .Columns(3).HeaderText = "Description"
            .Columns(4).HeaderText = "Price"
        End With
    End Function

    Function DeleteInvoices()
        Dim invoice_id As String = Me.listviewproduct.Rows(Me.listviewproduct.CurrentCell.RowIndex).Cells("invoice_id").Value
        Dim deleteInvoice As String = String.Format("delete from invoices where invoice_id = '{0}'", invoice_id)
        If dbaccess.ExecuteNoneQuery(deleteInvoice) Then
            MessageBox.Show("A Record Has Been Delete Successfully", "Confirm", MessageBoxButtons.OK)
            LoadInvoiceOnGridView()
        End If
    End Function
    Function DeleteCustomer()
        Dim customer_id As String = Me.listviewproduct.Rows(Me.listviewproduct.CurrentCell.RowIndex).Cells("customer_id").Value
        Dim delCustomer As String = String.Format("delete from customers where customer_id = '{0}'", customer_id)
        If dbaccess.ExecuteNoneQuery(delCustomer) Then
            MessageBox.Show("A Record Has Been Delete Successfully", "Confirm", MessageBoxButtons.OK)
            LoadCustomersOnGridView()
        Else
            MessageBox.Show("Error When Deleting Data From Database !", "Error", MessageBoxButtons.OK)
        End If
    End Function
    Function DeleteTypeProducts()
        Dim type_id As String = Me.listviewproduct.Rows(Me.listviewproduct.CurrentCell.RowIndex).Cells("type_id").Value
        Dim deletetype As String = String.Format("delete from types_product where type_id = '{0}'", type_id)

        If dbaccess.ExecuteNoneQuery(deletetype) Then
            MessageBox.Show("A Record Has Been Delete Successfully", "Confirm", MessageBoxButtons.OK)


        Else
            MessageBox.Show("Error When Deleting Data From Database !", "Error", MessageBoxButtons.OK)
        End If
    End Function
    Private Sub btdelete_Click(sender As Object, e As EventArgs) Handles btdelete.Click
        'DeleteProductData()
        If rbtInvoices.Checked Then
            DeleteInvoices()
        ElseIf rbtType_ProductS.Checked Then
            DeleteTypeProducts()
        ElseIf rbtCustomers.Checked Then
            DeleteCustomer()
        ElseIf rbtProducts.Checked Then
            DeleteProductData()
        End If
    End Sub
    ' Su kien click vao radio button products
    Private Sub rbtProducts_CheckedChanged(sender As Object, e As EventArgs) Handles rbtProducts.CheckedChanged
        CallBackProductsData()
    End Sub
    ' Su kien click vao radio button type products
    Private Sub rbtType_ProductS_CheckedChanged(sender As Object, e As EventArgs) Handles rbtType_ProductS.CheckedChanged
        LoadTypesProductDataOnGridView()

    End Sub

    Private Sub rbtCustomers_CheckedChanged(sender As Object, e As EventArgs) Handles rbtCustomers.CheckedChanged
        LoadCustomersOnGridView()
    End Sub

    Private Sub rbtInvoices_CheckedChanged(sender As Object, e As EventArgs) Handles rbtInvoices.CheckedChanged
        LoadInvoiceOnGridView()
    End Sub


    Private Sub AddTypeProduct_Click(sender As Object, e As EventArgs) Handles AddTypeProduct.Click
        Dim form_insert_item As New typeproducts(False)
        form_insert_item.Text = "Insert A New Item"
        form_insert_item.ShowDialog()
        If form_insert_item.DialogResult = DialogResult.OK Then
            LoadTypesProductDataOnGridView()
        End If
    End Sub

    Private Sub AddCustomer_Click(sender As Object, e As EventArgs) Handles AddCustomer.Click
        Dim form_insert_item As New addCustoms(False)
        form_insert_item.Text = "Insert A New Item"
        form_insert_item.ShowDialog()
        If form_insert_item.DialogResult = DialogResult.OK Then
            LoadCustomersOnGridView()
        End If
    End Sub

    Private Sub AddInvoice_Click(sender As Object, e As EventArgs) Handles AddInvoice.Click
        Dim form_insert_item As New AddInvoice(False)
        form_insert_item.Text = "Insert A New Item"
        form_insert_item.ShowDialog()
        If form_insert_item.DialogResult = DialogResult.OK Then
            LoadInvoiceOnGridView()
        End If
    End Sub
End Class
