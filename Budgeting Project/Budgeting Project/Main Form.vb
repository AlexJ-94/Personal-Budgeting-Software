' Budgeting Project
' Allows the user to input data about finances
' into textboxes which then saves that date into
' SQL Server databases and displays the data as needed
' Alex Johnson 12/16/14
Public Class frmMain
    'Initiates global variables to act as counters for the primary key
    Dim intTithesOfferings, intCellPhone, intMiscellaneous, intGas, intInsurance, intPetSupplies, intSchoolLoans, intSavings As Integer

    Private Sub TblCellPhoneBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs)
        Me.Validate()
        Me.TblCellPhoneBindingSource.EndEdit()
        Me.TableAdapterManager.UpdateAll(Me.BudgetDataSet)

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BudgetDataSet.tblTithesOfferings' table. You can move, or remove it, as needed.
        Me.TblTithesOfferingsTableAdapter.Fill(Me.BudgetDataSet.tblTithesOfferings)
        'TODO: This line of code loads data into the 'BudgetDataSet.tblSchoolLoans' table. You can move, or remove it, as needed.
        Me.TblSchoolLoansTableAdapter.Fill(Me.BudgetDataSet.tblSchoolLoans)
        'TODO: This line of code loads data into the 'BudgetDataSet.tblSavings' table. You can move, or remove it, as needed.
        Me.TblSavingsTableAdapter.Fill(Me.BudgetDataSet.tblSavings)
        'TODO: This line of code loads data into the 'BudgetDataSet.tblPetSupplies' table. You can move, or remove it, as needed.
        Me.TblPetSuppliesTableAdapter.Fill(Me.BudgetDataSet.tblPetSupplies)
        'TODO: This line of code loads data into the 'BudgetDataSet.tblMiscellaneous' table. You can move, or remove it, as needed.
        Me.TblMiscellaneousTableAdapter.Fill(Me.BudgetDataSet.tblMiscellaneous)
        'TODO: This line of code loads data into the 'BudgetDataSet.tblInsurance' table. You can move, or remove it, as needed.
        Me.TblInsuranceTableAdapter.Fill(Me.BudgetDataSet.tblInsurance)
        'TODO: This line of code loads data into the 'BudgetDataSet.tblGas' table. You can move, or remove it, as needed.
        Me.TblGasTableAdapter.Fill(Me.BudgetDataSet.tblGas)
        'TODO: This line of code loads data into the 'BudgetDataSet.tblCellPhone' table. You can move, or remove it, as needed.
        Me.TblCellPhoneTableAdapter.Fill(Me.BudgetDataSet.tblCellPhone)

    End Sub

    Private Sub btnAddRecord_Click(sender As Object, e As EventArgs) Handles btnAddRecord.Click
        Dim dblTransactionAmount As Double
        Double.TryParse(txtTransactionAmount.Text, dblTransactionAmount)
        'Determines which table to put the data inl
        If txtSortCode.Text = "1" Then
            'Populates the table in the SQL Server database
            BudgetDataSet.tblTithesOfferings.AddtblTithesOfferingsRow(intTithesOfferings, txtDate.Text, txtTransactionName.Text, txtSortCode.Text, dblTransactionAmount)
            TblTithesOfferingsTableAdapter.Update(BudgetDataSet.tblTithesOfferings)
            'Acts as a counter to display a differente number in the primary key
            intTithesOfferings = intTithesOfferings + 1
        ElseIf txtSortCode.Text = "2" Then
            BudgetDataSet.tblCellPhone.AddtblCellPhoneRow(intCellPhone, txtDate.Text, txtTransactionName.Text, txtSortCode.Text, dblTransactionAmount)
            TblCellPhoneTableAdapter.Update(BudgetDataSet.tblCellPhone)
            intCellPhone = intCellPhone + 1
        ElseIf txtSortCode.Text = "3" Then
            BudgetDataSet.tblMiscellaneous.AddtblMiscellaneousRow(intMiscellaneous, txtDate.Text, txtTransactionName.Text, txtSortCode.Text, dblTransactionAmount)
            TblMiscellaneousTableAdapter.Update(BudgetDataSet.tblMiscellaneous)
            intMiscellaneous = intMiscellaneous + 1
        ElseIf txtSortCode.Text = "4" Then
            BudgetDataSet.tblGas.AddtblGasRow(intGas, txtDate.Text, txtTransactionName.Text, txtSortCode.Text, dblTransactionAmount)
            TblGasTableAdapter.Update(BudgetDataSet.tblGas)
            intGas = intGas + 1
        ElseIf txtSortCode.Text = "5" Then
            BudgetDataSet.tblInsurance.AddtblInsuranceRow(intInsurance, txtDate.Text, txtTransactionName.Text, txtSortCode.Text, dblTransactionAmount)
            TblInsuranceTableAdapter.Update(BudgetDataSet.tblInsurance)
            intInsurance = intInsurance + 1
        ElseIf txtSortCode.Text = "6" Then
            BudgetDataSet.tblPetSupplies.AddtblPetSuppliesRow(intPetSupplies, txtDate.Text, txtTransactionName.Text, txtSortCode.Text, dblTransactionAmount)
            TblPetSuppliesTableAdapter.Update(BudgetDataSet.tblPetSupplies)
            intPetSupplies = intPetSupplies + 1
        ElseIf txtSortCode.Text = "7" Then
            BudgetDataSet.tblSchoolLoans.AddtblSchoolLoansRow(intSchoolLoans, txtDate.Text, txtTransactionName.Text, txtSortCode.Text, dblTransactionAmount)
            TblSchoolLoansTableAdapter.Update(BudgetDataSet.tblSchoolLoans)
            intSchoolLoans = intSchoolLoans + 1
        ElseIf txtSortCode.Text = "8" Then
            BudgetDataSet.tblSavings.AddtblSavingsRow(intSavings, txtDate.Text, txtTransactionName.Text, txtSortCode.Text, dblTransactionAmount)
            TblSavingsTableAdapter.Update(BudgetDataSet.tblSavings)
            intSavings = intSavings + 1
        Else
            'Displays an error message if sort code is not valid
            MessageBox.Show("Please enter a valid sort code")
        End If
        'clears the contents of the text boxes
        txtDate.Clear()
        txtTransactionName.Clear()
        txtSortCode.Clear()
        txtTransactionAmount.Clear()
        dblTransactionAmount = 0
    End Sub
    'Display the differnt forms according to which buttons are clicked
    Private Sub btnTithesOfferings_Click(sender As Object, e As EventArgs) Handles btnTithesOfferings.Click
        frmTithesOfferings.Show()
    End Sub

    Private Sub btnCellPhone_Click(sender As Object, e As EventArgs) Handles btnCellPhone.Click
        frmCellPhone.Show()
    End Sub

    Private Sub btnGas_Click(sender As Object, e As EventArgs) Handles btnGas.Click
        frmGas.Show()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnMisc_Click(sender As Object, e As EventArgs) Handles btnMisc.Click
        frmMiscellaneous.Show()
    End Sub

    Private Sub btnInsurance_Click(sender As Object, e As EventArgs) Handles btnInsurance.Click
        frmInsurance.Show()
    End Sub

    Private Sub btnPetSupplies_Click(sender As Object, e As EventArgs) Handles btnPetSupplies.Click
        frmPetSupplies.Show()
    End Sub

    Private Sub btnSchoolLoans_Click(sender As Object, e As EventArgs) Handles btnSchoolLoans.Click
        frmSchoolLoans.Show()
    End Sub

    Private Sub btnSavings_Click(sender As Object, e As EventArgs) Handles btnSavings.Click
        frmSavings.Show()
    End Sub
End Class
