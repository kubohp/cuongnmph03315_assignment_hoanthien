
Public Class typeproducts
    Private dbaccess As New DataBaseAccess
    Public isupdate As New Boolean

    Public Sub New(_isupdate As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isupdate = _isupdate
    End Sub


    Private Function InsertProductData() As Boolean
        Dim insert_types_product As String = "insert into types_product (type_id, type_name)"
        insert_types_product += String.Format("values('{0}', '{1}')", type_id_box.Text, name_type_box.Text)
        Return dbaccess.ExecuteNoneQuery(insert_types_product)
    End Function

    Private Function UpdateTypeProductData() As Boolean
        Dim updatetypeproduct As String = String.Format("update types_product set  type_name = '{1}' where type_id = '{0}'", Me.type_id_box.Text, Me.name_type_box.Text)
        Return dbaccess.ExecuteNoneQuery(updatetypeproduct)
    End Function

    ' validate form
    Private Function ValidationForm() As Boolean
        Return (String.IsNullOrEmpty(type_id_box.Text) OrElse String.IsNullOrEmpty(name_type_box.Text))
    End Function


    Private Sub btok_Click_Click(sender As Object, e As EventArgs) Handles btok_Click.Click
        If ValidationForm() Then
            MessageBox.Show("Require: One Of Your Fields Is Empty. Please Complete Your Fields !", "Requirement", MessageBoxButtons.OK)
        Else
            If isupdate Then
                If UpdateTypeProductData() Then
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

    Private Sub btcancel_Click_Click(sender As Object, e As EventArgs) Handles btcancel_Click.Click
        Me.Close()
    End Sub
End Class