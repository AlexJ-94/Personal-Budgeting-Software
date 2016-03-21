<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmPetSupplies
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmPetSupplies))
        Me.BudgetDataSet = New Budgeting_Project.BudgetDataSet()
        Me.TblPetSuppliesBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblPetSuppliesTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblPetSuppliesTableAdapter()
        Me.TableAdapterManager = New Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager()
        Me.TblPetSuppliesBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.TblPetSuppliesBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblPetSuppliesDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.txtTransaction = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPetSuppliesBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblPetSuppliesBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblPetSuppliesBindingNavigator.SuspendLayout()
        CType(Me.TblPetSuppliesDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BudgetDataSet
        '
        Me.BudgetDataSet.DataSetName = "BudgetDataSet"
        Me.BudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCellPhoneTableAdapter = Nothing
        Me.TableAdapterManager.tblGasTableAdapter = Nothing
        Me.TableAdapterManager.tblInsuranceTableAdapter = Nothing
        Me.TableAdapterManager.tblMiscellaneousTableAdapter = Nothing
        Me.TableAdapterManager.tblPetSuppliesTableAdapter = Me.TblPetSuppliesTableAdapter
        Me.TableAdapterManager.tblSavingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSchoolLoansTableAdapter = Nothing
        Me.TableAdapterManager.tblTithesOfferingsTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblPetSuppliesBindingNavigator
        '
        Me.TblPetSuppliesBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblPetSuppliesBindingNavigator.BindingSource = Me.TblPetSuppliesBindingSource
        Me.TblPetSuppliesBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblPetSuppliesBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblPetSuppliesBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblPetSuppliesBindingNavigatorSaveItem})
        Me.TblPetSuppliesBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblPetSuppliesBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblPetSuppliesBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblPetSuppliesBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblPetSuppliesBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblPetSuppliesBindingNavigator.Name = "TblPetSuppliesBindingNavigator"
        Me.TblPetSuppliesBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblPetSuppliesBindingNavigator.Size = New System.Drawing.Size(571, 25)
        Me.TblPetSuppliesBindingNavigator.TabIndex = 0
        Me.TblPetSuppliesBindingNavigator.Text = "BindingNavigator1"
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
        'TblPetSuppliesBindingNavigatorSaveItem
        '
        Me.TblPetSuppliesBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblPetSuppliesBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblPetSuppliesBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblPetSuppliesBindingNavigatorSaveItem.Name = "TblPetSuppliesBindingNavigatorSaveItem"
        Me.TblPetSuppliesBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblPetSuppliesBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblPetSuppliesDataGridView
        '
        Me.TblPetSuppliesDataGridView.AutoGenerateColumns = False
        Me.TblPetSuppliesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblPetSuppliesDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblPetSuppliesDataGridView.DataSource = Me.TblPetSuppliesBindingSource
        Me.TblPetSuppliesDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.TblPetSuppliesDataGridView.Name = "TblPetSuppliesDataGridView"
        Me.TblPetSuppliesDataGridView.Size = New System.Drawing.Size(545, 407)
        Me.TblPetSuppliesDataGridView.TabIndex = 1
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
        'txtTransaction
        '
        Me.txtTransaction.Location = New System.Drawing.Point(97, 455)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.Size = New System.Drawing.Size(100, 20)
        Me.txtTransaction.TabIndex = 98
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(18, 458)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 97
        Me.Label1.Text = "Transaction #"
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(220, 445)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(61, 38)
        Me.btnDelete.TabIndex = 96
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.Location = New System.Drawing.Point(496, 445)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(61, 38)
        Me.btnOK.TabIndex = 95
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmPetSupplies
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(571, 492)
        Me.Controls.Add(Me.txtTransaction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TblPetSuppliesDataGridView)
        Me.Controls.Add(Me.TblPetSuppliesBindingNavigator)
        Me.Name = "frmPetSupplies"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Pet Supplies"
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPetSuppliesBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblPetSuppliesBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblPetSuppliesBindingNavigator.ResumeLayout(False)
        Me.TblPetSuppliesBindingNavigator.PerformLayout()
        CType(Me.TblPetSuppliesDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BudgetDataSet As Budgeting_Project.BudgetDataSet
    Friend WithEvents TblPetSuppliesBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblPetSuppliesTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblPetSuppliesTableAdapter
    Friend WithEvents TableAdapterManager As Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblPetSuppliesBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblPetSuppliesBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblPetSuppliesDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txtTransaction As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents btnOK As System.Windows.Forms.Button
End Class
