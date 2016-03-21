<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmCellPhone
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmCellPhone))
        Me.BudgetDataSet = New Budgeting_Project.BudgetDataSet()
        Me.TblCellPhoneBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblCellPhoneTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblCellPhoneTableAdapter()
        Me.TableAdapterManager = New Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager()
        Me.TblCellPhoneBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.TblCellPhoneBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblCellPhoneDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.txtTransaction = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCellPhoneBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblCellPhoneBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblCellPhoneBindingNavigator.SuspendLayout()
        CType(Me.TblCellPhoneDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
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
        Me.TableAdapterManager.tblGasTableAdapter = Nothing
        Me.TableAdapterManager.tblInsuranceTableAdapter = Nothing
        Me.TableAdapterManager.tblMiscellaneousTableAdapter = Nothing
        Me.TableAdapterManager.tblPetSuppliesTableAdapter = Nothing
        Me.TableAdapterManager.tblSavingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSchoolLoansTableAdapter = Nothing
        Me.TableAdapterManager.tblTithesOfferingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblCellPhoneBindingNavigator
        '
        Me.TblCellPhoneBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblCellPhoneBindingNavigator.BindingSource = Me.TblCellPhoneBindingSource
        Me.TblCellPhoneBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblCellPhoneBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblCellPhoneBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblCellPhoneBindingNavigatorSaveItem})
        Me.TblCellPhoneBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblCellPhoneBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblCellPhoneBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblCellPhoneBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblCellPhoneBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblCellPhoneBindingNavigator.Name = "TblCellPhoneBindingNavigator"
        Me.TblCellPhoneBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblCellPhoneBindingNavigator.Size = New System.Drawing.Size(573, 25)
        Me.TblCellPhoneBindingNavigator.TabIndex = 0
        Me.TblCellPhoneBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Add new"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Move first"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Move previous"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Position"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Current position"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator1"
        Me.BindingNavigatorSeparator1.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorMoveNextItem
        '
        Me.BindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveNextItem.Image = CType(resources.GetObject("BindingNavigatorMoveNextItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveNextItem.Name = "BindingNavigatorMoveNextItem"
        Me.BindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveNextItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveNextItem.Text = "Move next"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Move last"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'TblCellPhoneBindingNavigatorSaveItem
        '
        Me.TblCellPhoneBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblCellPhoneBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblCellPhoneBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblCellPhoneBindingNavigatorSaveItem.Name = "TblCellPhoneBindingNavigatorSaveItem"
        Me.TblCellPhoneBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblCellPhoneBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblCellPhoneDataGridView
        '
        Me.TblCellPhoneDataGridView.AutoGenerateColumns = False
        Me.TblCellPhoneDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblCellPhoneDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblCellPhoneDataGridView.DataSource = Me.TblCellPhoneBindingSource
        Me.TblCellPhoneDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.TblCellPhoneDataGridView.Name = "TblCellPhoneDataGridView"
        Me.TblCellPhoneDataGridView.Size = New System.Drawing.Size(545, 336)
        Me.TblCellPhoneDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "Transaction #"
        Me.DataGridViewTextBoxColumn1.HeaderText = "Transaction #"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "Date"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Date"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Name"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "Code"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Code"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "Amount"
        Me.DataGridViewTextBoxColumn5.HeaderText = "Amount"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(500, 374)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(61, 38)
        Me.btnOK.TabIndex = 89
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'txtTransaction
        '
        Me.txtTransaction.Location = New System.Drawing.Point(101, 384)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.Size = New System.Drawing.Size(100, 20)
        Me.txtTransaction.TabIndex = 94
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(22, 387)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 93
        Me.Label1.Text = "Transaction #"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(224, 374)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(61, 38)
        Me.btnDelete.TabIndex = 92
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'frmCellPhone
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(573, 423)
        Me.Controls.Add(Me.txtTransaction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TblCellPhoneDataGridView)
        Me.Controls.Add(Me.TblCellPhoneBindingNavigator)
        Me.Name = "frmCellPhone"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Cell Phone"
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCellPhoneBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblCellPhoneBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblCellPhoneBindingNavigator.ResumeLayout(False)
        Me.TblCellPhoneBindingNavigator.PerformLayout()
        CType(Me.TblCellPhoneDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BudgetDataSet As Budgeting_Project.BudgetDataSet
    Friend WithEvents TblCellPhoneBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblCellPhoneTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblCellPhoneTableAdapter
    Friend WithEvents TableAdapterManager As Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblCellPhoneBindingNavigator As System.Windows.Forms.BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As System.Windows.Forms.ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As System.Windows.Forms.ToolStripSeparator
    Friend WithEvents TblCellPhoneBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblCellPhoneDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents txtTransaction As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
End Class
