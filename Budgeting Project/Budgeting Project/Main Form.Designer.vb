<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnAddRecord = New System.Windows.Forms.Button()
        Me.txtTransactionAmount = New System.Windows.Forms.TextBox()
        Me.lblTransactionAmount = New System.Windows.Forms.Label()
        Me.txtSortCode = New System.Windows.Forms.TextBox()
        Me.lblSortCode = New System.Windows.Forms.Label()
        Me.txtTransactionName = New System.Windows.Forms.TextBox()
        Me.txtDate = New System.Windows.Forms.TextBox()
        Me.lblTransactionName = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnSavings = New System.Windows.Forms.Button()
        Me.btnSchoolLoans = New System.Windows.Forms.Button()
        Me.btnPetSupplies = New System.Windows.Forms.Button()
        Me.btnInsurance = New System.Windows.Forms.Button()
        Me.btnGas = New System.Windows.Forms.Button()
        Me.btnMisc = New System.Windows.Forms.Button()
        Me.btnCellPhone = New System.Windows.Forms.Button()
        Me.btnTithesOfferings = New System.Windows.Forms.Button()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.BudgetDataSet = New Budgeting_Project.BudgetDataSet()
        Me.TblCellPhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCellPhoneTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblCellPhoneTableAdapter()
        Me.TableAdapterManager = New Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager()
        Me.TblGasBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblGasTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblGasTableAdapter()
        Me.TblInsuranceBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblInsuranceTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblInsuranceTableAdapter()
        Me.TblMiscellaneousBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblMiscellaneousTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblMiscellaneousTableAdapter()
        Me.TblPetSuppliesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPetSuppliesTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblPetSuppliesTableAdapter()
        Me.TblSavingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSavingsTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblSavingsTableAdapter()
        Me.TblSchoolLoansBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblSchoolLoansTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblSchoolLoansTableAdapter()
        Me.TblTithesOfferingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTithesOfferingsTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblTithesOfferingsTableAdapter()
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCellPhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblGasBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblInsuranceBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblMiscellaneousBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPetSuppliesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSavingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblSchoolLoansBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTithesOfferingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(613, 157)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(61, 35)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnAddRecord
        '
        Me.btnAddRecord.Location = New System.Drawing.Point(497, 26)
        Me.btnAddRecord.Name = "btnAddRecord"
        Me.btnAddRecord.Size = New System.Drawing.Size(61, 35)
        Me.btnAddRecord.TabIndex = 4
        Me.btnAddRecord.Text = "Add Record"
        Me.btnAddRecord.UseVisualStyleBackColor = True
        '
        'txtTransactionAmount
        '
        Me.txtTransactionAmount.Location = New System.Drawing.Point(364, 40)
        Me.txtTransactionAmount.Name = "txtTransactionAmount"
        Me.txtTransactionAmount.Size = New System.Drawing.Size(100, 20)
        Me.txtTransactionAmount.TabIndex = 3
        '
        'lblTransactionAmount
        '
        Me.lblTransactionAmount.AutoSize = True
        Me.lblTransactionAmount.Location = New System.Drawing.Point(362, 10)
        Me.lblTransactionAmount.Name = "lblTransactionAmount"
        Me.lblTransactionAmount.Size = New System.Drawing.Size(102, 13)
        Me.lblTransactionAmount.TabIndex = 71
        Me.lblTransactionAmount.Text = "Transaction Amount"
        '
        'txtSortCode
        '
        Me.txtSortCode.Location = New System.Drawing.Point(293, 40)
        Me.txtSortCode.Name = "txtSortCode"
        Me.txtSortCode.Size = New System.Drawing.Size(51, 20)
        Me.txtSortCode.TabIndex = 2
        '
        'lblSortCode
        '
        Me.lblSortCode.AutoSize = True
        Me.lblSortCode.Location = New System.Drawing.Point(290, 10)
        Me.lblSortCode.Name = "lblSortCode"
        Me.lblSortCode.Size = New System.Drawing.Size(54, 13)
        Me.lblSortCode.TabIndex = 70
        Me.lblSortCode.Text = "Sort Code"
        '
        'txtTransactionName
        '
        Me.txtTransactionName.Location = New System.Drawing.Point(103, 40)
        Me.txtTransactionName.Name = "txtTransactionName"
        Me.txtTransactionName.Size = New System.Drawing.Size(160, 20)
        Me.txtTransactionName.TabIndex = 1
        '
        'txtDate
        '
        Me.txtDate.Location = New System.Drawing.Point(15, 40)
        Me.txtDate.Name = "txtDate"
        Me.txtDate.Size = New System.Drawing.Size(64, 20)
        Me.txtDate.TabIndex = 0
        '
        'lblTransactionName
        '
        Me.lblTransactionName.AutoSize = True
        Me.lblTransactionName.Location = New System.Drawing.Point(100, 10)
        Me.lblTransactionName.Name = "lblTransactionName"
        Me.lblTransactionName.Size = New System.Drawing.Size(94, 13)
        Me.lblTransactionName.TabIndex = 69
        Me.lblTransactionName.Text = "Transaction Name"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(14, 97)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(68, 13)
        Me.Label10.TabIndex = 72
        Me.Label10.Text = "Key for Code"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(171, 138)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(13, 13)
        Me.Label9.TabIndex = 78
        Me.Label9.Text = "3"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(240, 138)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(13, 13)
        Me.Label8.TabIndex = 80
        Me.Label8.Text = "4"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(306, 138)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(13, 13)
        Me.Label7.TabIndex = 82
        Me.Label7.Text = "5"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(372, 138)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(13, 13)
        Me.Label6.TabIndex = 84
        Me.Label6.Text = "6"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(439, 138)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(13, 13)
        Me.Label5.TabIndex = 86
        Me.Label5.Text = "7"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(508, 138)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(13, 13)
        Me.Label4.TabIndex = 88
        Me.Label4.Text = "8"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(105, 138)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(13, 13)
        Me.Label3.TabIndex = 76
        Me.Label3.Text = "2"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(39, 138)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(13, 13)
        Me.Label2.TabIndex = 74
        Me.Label2.Text = "1"
        '
        'btnSavings
        '
        Me.btnSavings.Location = New System.Drawing.Point(483, 154)
        Me.btnSavings.Name = "btnSavings"
        Me.btnSavings.Size = New System.Drawing.Size(61, 38)
        Me.btnSavings.TabIndex = 13
        Me.btnSavings.Text = "Savings"
        Me.btnSavings.UseVisualStyleBackColor = True
        '
        'btnSchoolLoans
        '
        Me.btnSchoolLoans.Location = New System.Drawing.Point(416, 154)
        Me.btnSchoolLoans.Name = "btnSchoolLoans"
        Me.btnSchoolLoans.Size = New System.Drawing.Size(61, 38)
        Me.btnSchoolLoans.TabIndex = 12
        Me.btnSchoolLoans.Text = "School Loans"
        Me.btnSchoolLoans.UseVisualStyleBackColor = True
        '
        'btnPetSupplies
        '
        Me.btnPetSupplies.Location = New System.Drawing.Point(349, 154)
        Me.btnPetSupplies.Name = "btnPetSupplies"
        Me.btnPetSupplies.Size = New System.Drawing.Size(61, 38)
        Me.btnPetSupplies.TabIndex = 11
        Me.btnPetSupplies.Text = "Pet Supplies"
        Me.btnPetSupplies.UseVisualStyleBackColor = True
        '
        'btnInsurance
        '
        Me.btnInsurance.Location = New System.Drawing.Point(282, 154)
        Me.btnInsurance.Name = "btnInsurance"
        Me.btnInsurance.Size = New System.Drawing.Size(61, 38)
        Me.btnInsurance.TabIndex = 10
        Me.btnInsurance.Text = "Insurance"
        Me.btnInsurance.UseVisualStyleBackColor = True
        '
        'btnGas
        '
        Me.btnGas.Location = New System.Drawing.Point(215, 154)
        Me.btnGas.Name = "btnGas"
        Me.btnGas.Size = New System.Drawing.Size(61, 38)
        Me.btnGas.TabIndex = 9
        Me.btnGas.Text = "Gas"
        Me.btnGas.UseVisualStyleBackColor = True
        '
        'btnMisc
        '
        Me.btnMisc.Location = New System.Drawing.Point(148, 154)
        Me.btnMisc.Name = "btnMisc"
        Me.btnMisc.Size = New System.Drawing.Size(61, 38)
        Me.btnMisc.TabIndex = 8
        Me.btnMisc.Text = "Miscellaneous"
        Me.btnMisc.UseVisualStyleBackColor = True
        '
        'btnCellPhone
        '
        Me.btnCellPhone.Location = New System.Drawing.Point(81, 154)
        Me.btnCellPhone.Name = "btnCellPhone"
        Me.btnCellPhone.Size = New System.Drawing.Size(61, 38)
        Me.btnCellPhone.TabIndex = 7
        Me.btnCellPhone.Text = "Cell Phone"
        Me.btnCellPhone.UseVisualStyleBackColor = True
        '
        'btnTithesOfferings
        '
        Me.btnTithesOfferings.Location = New System.Drawing.Point(15, 154)
        Me.btnTithesOfferings.Name = "btnTithesOfferings"
        Me.btnTithesOfferings.Size = New System.Drawing.Size(61, 38)
        Me.btnTithesOfferings.TabIndex = 6
        Me.btnTithesOfferings.Text = "Tithes/ & Offerings"
        Me.btnTithesOfferings.UseVisualStyleBackColor = True
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Location = New System.Drawing.Point(12, 9)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(30, 13)
        Me.lblDate.TabIndex = 68
        Me.lblDate.Text = "Date"
        '
        'BudgetDataSet
        '
        Me.BudgetDataSet.DataSetName = "BudgetDataSet"
        Me.BudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TblCellPhoneBindingSource
        '
        Me.TblCellPhoneBindingSource.DataMember = "tblCellPhone"
        Me.TblCellPhoneBindingSource.DataSource = Me.BudgetDataSet
        '
        'TblCellPhoneTableAdapter
        '
        Me.TblCellPhoneTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCellPhoneTableAdapter = Me.TblCellPhoneTableAdapter
        Me.TableAdapterManager.tblGasTableAdapter = Me.TblGasTableAdapter
        Me.TableAdapterManager.tblInsuranceTableAdapter = Me.TblInsuranceTableAdapter
        Me.TableAdapterManager.tblMiscellaneousTableAdapter = Me.TblMiscellaneousTableAdapter
        Me.TableAdapterManager.tblPetSuppliesTableAdapter = Me.TblPetSuppliesTableAdapter
        Me.TableAdapterManager.tblSavingsTableAdapter = Me.TblSavingsTableAdapter
        Me.TableAdapterManager.tblSchoolLoansTableAdapter = Me.TblSchoolLoansTableAdapter
        Me.TableAdapterManager.tblTithesOfferingsTableAdapter = Me.TblTithesOfferingsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblGasBindingSource
        '
        Me.TblGasBindingSource.DataMember = "tblGas"
        Me.TblGasBindingSource.DataSource = Me.BudgetDataSet
        '
        'TblGasTableAdapter
        '
        Me.TblGasTableAdapter.ClearBeforeFill = True
        '
        'TblInsuranceBindingSource
        '
        Me.TblInsuranceBindingSource.DataMember = "tblInsurance"
        Me.TblInsuranceBindingSource.DataSource = Me.BudgetDataSet
        '
        'TblInsuranceTableAdapter
        '
        Me.TblInsuranceTableAdapter.ClearBeforeFill = True
        '
        'TblMiscellaneousBindingSource
        '
        Me.TblMiscellaneousBindingSource.DataMember = "tblMiscellaneous"
        Me.TblMiscellaneousBindingSource.DataSource = Me.BudgetDataSet
        '
        'TblMiscellaneousTableAdapter
        '
        Me.TblMiscellaneousTableAdapter.ClearBeforeFill = True
        '
        'TblPetSuppliesBindingSource
        '
        Me.TblPetSuppliesBindingSource.DataMember = "tblPetSupplies"
        Me.TblPetSuppliesBindingSource.DataSource = Me.BudgetDataSet
        '
        'TblPetSuppliesTableAdapter
        '
        Me.TblPetSuppliesTableAdapter.ClearBeforeFill = True
        '
        'TblSavingsBindingSource
        '
        Me.TblSavingsBindingSource.DataMember = "tblSavings"
        Me.TblSavingsBindingSource.DataSource = Me.BudgetDataSet
        '
        'TblSavingsTableAdapter
        '
        Me.TblSavingsTableAdapter.ClearBeforeFill = True
        '
        'TblSchoolLoansBindingSource
        '
        Me.TblSchoolLoansBindingSource.DataMember = "tblSchoolLoans"
        Me.TblSchoolLoansBindingSource.DataSource = Me.BudgetDataSet
        '
        'TblSchoolLoansTableAdapter
        '
        Me.TblSchoolLoansTableAdapter.ClearBeforeFill = True
        '
        'TblTithesOfferingsBindingSource
        '
        Me.TblTithesOfferingsBindingSource.DataMember = "tblTithesOfferings"
        Me.TblTithesOfferingsBindingSource.DataSource = Me.BudgetDataSet
        '
        'TblTithesOfferingsTableAdapter
        '
        Me.TblTithesOfferingsTableAdapter.ClearBeforeFill = True
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(694, 210)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnAddRecord)
        Me.Controls.Add(Me.txtTransactionAmount)
        Me.Controls.Add(Me.lblTransactionAmount)
        Me.Controls.Add(Me.txtSortCode)
        Me.Controls.Add(Me.lblSortCode)
        Me.Controls.Add(Me.txtTransactionName)
        Me.Controls.Add(Me.txtDate)
        Me.Controls.Add(Me.lblTransactionName)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btnSavings)
        Me.Controls.Add(Me.btnSchoolLoans)
        Me.Controls.Add(Me.btnPetSupplies)
        Me.Controls.Add(Me.btnInsurance)
        Me.Controls.Add(Me.btnGas)
        Me.Controls.Add(Me.btnMisc)
        Me.Controls.Add(Me.btnCellPhone)
        Me.Controls.Add(Me.btnTithesOfferings)
        Me.Controls.Add(Me.lblDate)
        Me.Name = "frmMain"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Budgeting Program"
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCellPhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblGasBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblInsuranceBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblMiscellaneousBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPetSuppliesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSavingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblSchoolLoansBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTithesOfferingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents btnAddRecord As System.Windows.Forms.Button
    Friend WithEvents txtTransactionAmount As System.Windows.Forms.TextBox
    Friend WithEvents lblTransactionAmount As System.Windows.Forms.Label
    Friend WithEvents txtSortCode As System.Windows.Forms.TextBox
    Friend WithEvents lblSortCode As System.Windows.Forms.Label
    Friend WithEvents txtTransactionName As System.Windows.Forms.TextBox
    Friend WithEvents txtDate As System.Windows.Forms.TextBox
    Friend WithEvents lblTransactionName As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnSavings As System.Windows.Forms.Button
    Friend WithEvents btnSchoolLoans As System.Windows.Forms.Button
    Friend WithEvents btnPetSupplies As System.Windows.Forms.Button
    Friend WithEvents btnInsurance As System.Windows.Forms.Button
    Friend WithEvents btnGas As System.Windows.Forms.Button
    Friend WithEvents btnMisc As System.Windows.Forms.Button
    Friend WithEvents btnCellPhone As System.Windows.Forms.Button
    Friend WithEvents btnTithesOfferings As System.Windows.Forms.Button
    Friend WithEvents lblDate As System.Windows.Forms.Label
    Friend WithEvents BudgetDataSet As Budgeting_Project.BudgetDataSet
    Friend WithEvents TblCellPhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCellPhoneTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblCellPhoneTableAdapter
    Friend WithEvents TableAdapterManager As Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblGasTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblGasTableAdapter
    Friend WithEvents TblGasBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblInsuranceTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblInsuranceTableAdapter
    Friend WithEvents TblInsuranceBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblMiscellaneousTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblMiscellaneousTableAdapter
    Friend WithEvents TblMiscellaneousBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPetSuppliesTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblPetSuppliesTableAdapter
    Friend WithEvents TblPetSuppliesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSavingsTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblSavingsTableAdapter
    Friend WithEvents TblSavingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblSchoolLoansTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblSchoolLoansTableAdapter
    Friend WithEvents TblSchoolLoansBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTithesOfferingsTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblTithesOfferingsTableAdapter
    Friend WithEvents TblTithesOfferingsBindingSource As System.Windows.Forms.BindingSource

End Class
