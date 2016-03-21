﻿Public Class frmSchoolLoans

    Private Sub TblSchoolLoansBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblSchoolLoansBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblSchoolLoansBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BudgetDataSet)

    End Sub

    Private Sub frmSchoolLoans_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetDataSet.tblSchoolLoans' table. You can move, or remove it, as needed.
        Me.TblSchoolLoansTableAdapter.Fill(Me.BudgetDataSet.tblSchoolLoans)

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
                BudgetDataSet.tblSchoolLoans.FindBy_Transaction__(intTransaction)
            row.Delete()
            Try
                TblSchoolLoansTableAdapter.Update(BudgetDataSet.tblSchoolLoans)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class