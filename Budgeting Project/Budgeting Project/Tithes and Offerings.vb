﻿Public Class frmTithesOfferings

    Private Sub TblTithesOfferingsBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles TblTithesOfferingsBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.TblTithesOfferingsBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BudgetDataSet)

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetDataSet.tblTithesOfferings' table. You can move, or remove it, as needed.
        Me.TblTithesOfferingsTableAdapter.Fill(Me.BudgetDataSet.tblTithesOfferings)

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
                BudgetDataSet.tblTithesOfferings.FindBy_Transaction__(intTransaction)
            row.Delete()
            Try
                TblTithesOfferingsTableAdapter.Update(BudgetDataSet.tblTithesOfferings)
            Catch ex As Exception
                MessageBox.Show(ex.Message, "Delete Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            End Try
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        Me.Close()
    End Sub
End Class