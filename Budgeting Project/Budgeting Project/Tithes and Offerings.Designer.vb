<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTithesOfferings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTithesOfferings))
        Me.BudgetDataSet = New Budgeting_Project.BudgetDataSet()
        Me.TblTithesOfferingsBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TblTithesOfferingsTableAdapter = New Budgeting_Project.BudgetDataSetTableAdapters.tblTithesOfferingsTableAdapter()
        Me.TableAdapterManager = New Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager()
        Me.TblTithesOfferingsBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
        Me.BindingNavigatorMoveFirstItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMovePreviousItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorPositionItem = New System.Windows.Forms.ToolStripTextBox()
        Me.BindingNavigatorCountItem = New System.Windows.Forms.ToolStripLabel()
        Me.BindingNavigatorSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorMoveNextItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorMoveLastItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.BindingNavigatorAddNewItem = New System.Windows.Forms.ToolStripButton()
        Me.BindingNavigatorDeleteItem = New System.Windows.Forms.ToolStripButton()
        Me.TblTithesOfferingsBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.TblTithesOfferingsDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.btnDelete = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtTransaction = New System.Windows.Forms.TextBox()
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTithesOfferingsBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.TblTithesOfferingsBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TblTithesOfferingsBindingNavigator.SuspendLayout()
        CType(Me.TblTithesOfferingsDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'BudgetDataSet
        '
        Me.BudgetDataSet.DataSetName = "BudgetDataSet"
        Me.BudgetDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
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
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.tblCellPhoneTableAdapter = Nothing
        Me.TableAdapterManager.tblGasTableAdapter = Nothing
        Me.TableAdapterManager.tblInsuranceTableAdapter = Nothing
        Me.TableAdapterManager.tblMiscellaneousTableAdapter = Nothing
        Me.TableAdapterManager.tblPetSuppliesTableAdapter = Nothing
        Me.TableAdapterManager.tblSavingsTableAdapter = Nothing
        Me.TableAdapterManager.tblSchoolLoansTableAdapter = Nothing
        Me.TableAdapterManager.tblTithesOfferingsTableAdapter = Me.TblTithesOfferingsTableAdapter
        Me.TableAdapterManager.UpdateOrder = Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'TblTithesOfferingsBindingNavigator
        '
        Me.TblTithesOfferingsBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.TblTithesOfferingsBindingNavigator.BindingSource = Me.TblTithesOfferingsBindingSource
        Me.TblTithesOfferingsBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.TblTithesOfferingsBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.TblTithesOfferingsBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.TblTithesOfferingsBindingNavigatorSaveItem})
        Me.TblTithesOfferingsBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.TblTithesOfferingsBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.TblTithesOfferingsBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.TblTithesOfferingsBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.TblTithesOfferingsBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.TblTithesOfferingsBindingNavigator.Name = "TblTithesOfferingsBindingNavigator"
        Me.TblTithesOfferingsBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.TblTithesOfferingsBindingNavigator.Size = New System.Drawing.Size(572, 25)
        Me.TblTithesOfferingsBindingNavigator.TabIndex = 0
        Me.TblTithesOfferingsBindingNavigator.Text = "BindingNavigator1"
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
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(35, 22)
        Me.BindingNavigatorCountItem.Text = "of {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Total number of items"
        '
        'BindingNavigatorSeparator1
        '
        Me.BindingNavigatorSeparator1.Name = "BindingNavigatorSeparator"
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
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
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
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Delete"
        '
        'TblTithesOfferingsBindingNavigatorSaveItem
        '
        Me.TblTithesOfferingsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.TblTithesOfferingsBindingNavigatorSaveItem.Image = CType(resources.GetObject("TblTithesOfferingsBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.TblTithesOfferingsBindingNavigatorSaveItem.Name = "TblTithesOfferingsBindingNavigatorSaveItem"
        Me.TblTithesOfferingsBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.TblTithesOfferingsBindingNavigatorSaveItem.Text = "Save Data"
        '
        'TblTithesOfferingsDataGridView
        '
        Me.TblTithesOfferingsDataGridView.AutoGenerateColumns = False
        Me.TblTithesOfferingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.TblTithesOfferingsDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5})
        Me.TblTithesOfferingsDataGridView.DataSource = Me.TblTithesOfferingsBindingSource
        Me.TblTithesOfferingsDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.TblTithesOfferingsDataGridView.Name = "TblTithesOfferingsDataGridView"
        Me.TblTithesOfferingsDataGridView.Size = New System.Drawing.Size(544, 345)
        Me.TblTithesOfferingsDataGridView.TabIndex = 1
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
        Me.btnOK.Location = New System.Drawing.Point(495, 381)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(61, 38)
        Me.btnOK.TabIndex = 88
        Me.btnOK.Text = "Ok"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'btnDelete
        '
        Me.btnDelete.Location = New System.Drawing.Point(214, 381)
        Me.btnDelete.Name = "btnDelete"
        Me.btnDelete.Size = New System.Drawing.Size(61, 38)
        Me.btnDelete.TabIndex = 89
        Me.btnDelete.Text = "Delete"
        Me.btnDelete.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 394)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(73, 13)
        Me.Label1.TabIndex = 90
        Me.Label1.Text = "Transaction #"
        '
        'txtTransaction
        '
        Me.txtTransaction.Location = New System.Drawing.Point(91, 391)
        Me.txtTransaction.Name = "txtTransaction"
        Me.txtTransaction.Size = New System.Drawing.Size(100, 20)
        Me.txtTransaction.TabIndex = 91
        '
        'frmTithesOfferings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(572, 426)
        Me.Controls.Add(Me.txtTransaction)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnDelete)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.TblTithesOfferingsDataGridView)
        Me.Controls.Add(Me.TblTithesOfferingsBindingNavigator)
        Me.Name = "frmTithesOfferings"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tithes/Offerings"
        CType(Me.BudgetDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTithesOfferingsBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.TblTithesOfferingsBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TblTithesOfferingsBindingNavigator.ResumeLayout(False)
        Me.TblTithesOfferingsBindingNavigator.PerformLayout()
        CType(Me.TblTithesOfferingsDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BudgetDataSet As Budgeting_Project.BudgetDataSet
    Friend WithEvents TblTithesOfferingsBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents TblTithesOfferingsTableAdapter As Budgeting_Project.BudgetDataSetTableAdapters.tblTithesOfferingsTableAdapter
    Friend WithEvents TableAdapterManager As Budgeting_Project.BudgetDataSetTableAdapters.TableAdapterManager
    Friend WithEvents TblTithesOfferingsBindingNavigator As System.Windows.Forms.BindingNavigator
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
    Friend WithEvents TblTithesOfferingsBindingNavigatorSaveItem As System.Windows.Forms.ToolStripButton
    Friend WithEvents TblTithesOfferingsDataGridView As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridViewTextBoxColumn1 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents btnOK As System.Windows.Forms.Button
    Friend WithEvents btnDelete As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtTransaction As System.Windows.Forms.TextBox
End Class
