Public Class frmSavings

    Private Sub TblSavingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblSavingsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSavingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BudgetDataSet)

    End Sub

    Private Sub frmSavings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetDataSet.tblSavings' table. You can move, or remove it, as needed.
        Me.TblSavingsTableAdapter.Fill(Me.BudgetDataSet.tblSavings)

    End Sub

    Private Sub txtTransaction_TextChanged(sender As Object, e As EventArgs) Handles txtTransaction.TextChanged

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
                BudgetDataSet.tblSavings.FindBy_Transaction__(intTransaction)
            row.Delete()
            Try
                TblSavingsTableAdapter.Update(BudgetDataSet.tblSavings)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class