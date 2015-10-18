Public Class addorupdate
    Private dbaccess As New DataBaseAccess
    Public isupdate As New Boolean

    Public Sub New(_isupdate As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isupdate = _isupdate
    End Sub

    Public Sub LoadTypesProductData()
        Dim querytable As String = "select type_id, type_name from dbo.types_product"
        Dim datatable As DataTable = dbaccess.GetDataTable(querytable)
        Me.listclassify.DataSource = datatable
        Me.listclassify.ValueMember = "type_id"
        Me.listclassify.DisplayMember = "type_name"
        'vl ao
    End Sub

    Private Function InsertProductData() As Boolean
        Dim insertproduct As String = "insert into products (product_id, product_name, amount, description, price,  type_id)"
        insertproduct += String.Format("values('{0}', '{1}', '{2}', '{3}', '{4}', '{5}')", idproductfield.Text, nameproductfield.Text, amountfield.Text, descriptionfield.Text, pricefield.Text, Me.listclassify.SelectedValue)
        Return dbaccess.ExecuteNoneQuery(insertproduct)
    End Function

    Private Function UpdateProductData() As Boolean
        Dim updateproduct As String = String.Format("update products set product_name = '{0}', amount = '{1}', description = '{2}', price = '{3}' where product_id = '{4}'", Me.nameproductfield.Text, Me.amountfield.Text, Me.descriptionfield.Text, Me.pricefield.Text, Me.idproductfield.Text)
        Return dbaccess.ExecuteNoneQuery(updateproduct)
    End Function

    ' validate form
    Private Function ValidationForm() As Boolean
        Return (String.IsNullOrEmpty(idproductfield.Text) OrElse String.IsNullOrEmpty(nameproductfield.Text) OrElse String.IsNullOrEmpty(amountfield.Text) OrElse String.IsNullOrEmpty(descriptionfield.Text) OrElse String.IsNullOrEmpty(pricefield.Text))
    End Function

    Private Sub btok_Click(sender As Object, e As EventArgs) Handles btok.Click
        If ValidationForm() Then
            MessageBox.Show("Require: One Of Your Fields Is Empty. Please Complete Your Fields !", "Requirement", MessageBoxButtons.OK)
        Else
            If isupdate Then
                If UpdateProductData() Then
                    MessageBox.Show("A Record Has Been Updated Successfully", "Confirm", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("Error: Error When Updating Data Into Database !", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.No
                End If
            Else
                If InsertProductData() Then
                    MessageBox.Show("A Record Has Been Added Successfully", "Confirm", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("Error When Inserting Data Into Database !", "Error", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.No
                End If
            End If
            Me.Close()
        End If
    End Sub

    Private Sub btcancel_Click(sender As Object, e As EventArgs) Handles btcancel.Click
        Me.Close()
    End Sub
End Class