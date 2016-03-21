Public Class frmCellPhone

    Private Sub TblCellPhoneBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblCellPhoneBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblCellPhoneBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BudgetDataSet)

    End Sub

    Private Sub frmCellPhone_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetDataSet.tblCellPhone' table. You can move, or remove it, as needed.
        Me.TblCellPhoneTableAdapter.Fill(Me.BudgetDataSet.tblCellPhone)

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub btnDelete_Click(sender As Object, e As EventArgs) Handles btnDelete.Click
        Dim dlgButton As DialogResult
        dlgButton =
            MessageBox.Show("Delete Transaction # " & txtTransaction.Text & "?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation)

        If dlgButton = Windows.Forms.DialogResult.Yes Then
            Dim row As DataRow
            Dim intTransaction As Integer
            Integer.TryParse(txtTransaction.Text, intTransaction)
            row =
                BudgetDataSet.tblCellPhone.FindBy_Transaction__(intTransaction)
            row.Delete()
            Try
                TblCellPhoneTableAdapter.Update(BudgetDataSet.tblCellPhone)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub txtTransaction_TextChanged(sender As Object, e As EventArgs) Handles txtTransaction.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class