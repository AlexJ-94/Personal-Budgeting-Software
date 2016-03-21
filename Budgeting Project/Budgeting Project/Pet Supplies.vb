Public Class frmPetSupplies

    Private Sub TblPetSuppliesBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblPetSuppliesBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblPetSuppliesBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BudgetDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetDataSet.tblPetSupplies' table. You can move, or remove it, as needed.
        Me.TblPetSuppliesTableAdapter.Fill(Me.BudgetDataSet.tblPetSupplies)

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
                BudgetDataSet.tblPetSupplies.FindBy_Transaction__(intTransaction)
            row.Delete()
            Try
                TblPetSuppliesTableAdapter.Update(BudgetDataSet.tblPetSupplies)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub
End Class