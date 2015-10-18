Public Class AddInvoice
    Private dbaccess As New DataBaseAccess
    Public isupdate As New Boolean

    Public Sub New(_isupdate As Boolean)

        ' This call is required by the designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        isupdate = _isupdate
    End Sub

    Private Function InsertInvoicesData() As Boolean
        Dim insertInvoice As String = "insert into invoices (invoice_id, initial_date, customer_id, total)"
        insertInvoice += String.Format("values('{0}', '{1}', '{2}', '{3}')", Me.TextBox1.Text, Me.DateTimePicker1.Text, Me.TextBox3.Text, Me.TextBox4.Text)
        Return dbaccess.ExecuteNoneQuery(insertInvoice)
    End Function

    Public Function UpdateInvoicesData() As Boolean
        Dim updateInvoices As String = String.Format("update invoices set initial_date = '{0}', customer_id = '{1}', total = '{2}' where invoice_id = '{3}'", Me.DateTimePicker1.Text, Me.TextBox3.Text, Me.TextBox4.Text, Me.TextBox1.Text)
        Return dbaccess.ExecuteNoneQuery(updateInvoices)
    End Function

    ' validate form
    Private Function ValidationForm() As Boolean
        Return (String.IsNullOrEmpty(TextBox1.Text) OrElse String.IsNullOrEmpty(DateTimePicker1.Text) OrElse String.IsNullOrEmpty(TextBox3.Text) OrElse String.IsNullOrEmpty(TextBox4.Text))
    End Function


    'dau gio muon lam gi
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If ValidationForm() Then
            MessageBox.Show("Require: One Of Your Fields Is Empty. Please Complete Your Fields !", "Requirement", MessageBoxButtons.OK)
        Else
            If InsertInvoicesData() Then
                MessageBox.Show("A Record Has Been Insert Successfully", "Confirm", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.OK
            ElseIf UpdateInvoicesData() Then

                MessageBox.Show("A Record Has Been Updated Successfully", "Confirm", MessageBoxButtons.OK)
                Me.DialogResult = DialogResult.OK
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class