Public Class addCustoms
    Private dbaccess As New DataBaseAccess
    Public isupdate As New Boolean

    Public Sub New(_isupdate As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isupdate = _isupdate
    End Sub

    Private Function InsertCustomsData() As Boolean
        Dim insertCustoms As String = "insert into customers (customer_id, customer_name, address, phone)"
        insertCustoms += String.Format("values('{0}', '{1}', '{2}', '{3}')", TextBox1.Text, TextBox2.Text, TextBox3.Text, TextBox4.Text)
        Return dbaccess.ExecuteNoneQuery(insertCustoms)
    End Function

    Private Function UpdateCustomsData() As Boolean
        Dim updateCustoms As String = String.Format("update customers set customer_name = '{0}', address = '{1}', phone = '{2}' where customer_id = '{3}'", Me.TextBox2.Text, Me.TextBox3.Text, Me.TextBox4.Text, Me.TextBox1.Text)
        Return dbaccess.ExecuteNoneQuery(updateCustoms)
    End Function

    ' validate form
    Private Function ValidationForm() As Boolean
        Return (String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(TextBox2.Text) OrElse String.IsNullOrEmpty(TextBox3.Text) OrElse String.IsNullOrEmpty(TextBox4.Text))
    End Function



    Private Sub btnok_Click(sender As Object, e As EventArgs) Handles btnok.Click
    If ValidationForm() Then
        MessageBox.Show("Require: One Of Your Fields Is Empty. Please Complete Your Fields !", "Requirement", MessageBoxButtons.OK)
    Else
        If isupdate Then
                If UpdateCustomsData() Then
                    MessageBox.Show("A Record Has Been Updated Successfully", "Confirm", MessageBoxButtons.OK)
                    Me.DialogResult = DialogResult.OK
                Else
                    MessageBox.Show("Error: Error When Updating Data Into Database !", "Error", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.No
            End If
        Else
                If InsertCustomsData() Then
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

    Private Sub btncancel_Click(sender As Object, e As EventArgs) Handles btncancel.Click
    Me.Close()
End Sub
End Class