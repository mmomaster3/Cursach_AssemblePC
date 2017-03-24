<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form3
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
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

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form3))
        Me.AssemblePcDataSet = New Cursach.AssemblePcDataSet()
        Me.PCOrderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PCOrderTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.PCOrderTableAdapter()
        Me.TableAdapterManager = New Cursach.AssemblePcDataSetTableAdapters.TableAdapterManager()
        Me.ClientTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.ClientTableAdapter()
        Me.PCTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.PCTableAdapter()
        Me.PCOrderBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PCOrderBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PCOrderDataGridView = New System.Windows.Forms.DataGridView()
        Me.ClientBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.ClientBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewComboBoxColumn()
        CType(Me.AssemblePcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCOrderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCOrderBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCOrderBindingNavigator.SuspendLayout()
        CType(Me.PCOrderDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssemblePcDataSet
        '
        Me.AssemblePcDataSet.DataSetName = "AssemblePcDataSet"
        Me.AssemblePcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCOrderBindingSource
        '
        Me.PCOrderBindingSource.DataMember = "PCOrder"
        Me.PCOrderBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'PCOrderTableAdapter
        '
        Me.PCOrderTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientTableAdapter = Me.ClientTableAdapter
        Me.TableAdapterManager.DriveTableAdapter = Nothing
        Me.TableAdapterManager.GraphyCardTableAdapter = Nothing
        Me.TableAdapterManager.MotherBoardTableAdapter = Nothing
        Me.TableAdapterManager.PBTableAdapter = Nothing
        Me.TableAdapterManager.PCOrderTableAdapter = Me.PCOrderTableAdapter
        Me.TableAdapterManager.PCTableAdapter = Me.PCTableAdapter
        Me.TableAdapterManager.ProcessorTableAdapter = Nothing
        Me.TableAdapterManager.RAMTableAdapter = Nothing
        Me.TableAdapterManager.UpdateOrder = Cursach.AssemblePcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'ClientTableAdapter
        '
        Me.ClientTableAdapter.ClearBeforeFill = True
        '
        'PCTableAdapter
        '
        Me.PCTableAdapter.ClearBeforeFill = True
        '
        'PCOrderBindingNavigator
        '
        Me.PCOrderBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PCOrderBindingNavigator.BindingSource = Me.PCOrderBindingSource
        Me.PCOrderBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PCOrderBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PCOrderBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PCOrderBindingNavigatorSaveItem})
        Me.PCOrderBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PCOrderBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PCOrderBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PCOrderBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PCOrderBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PCOrderBindingNavigator.Name = "PCOrderBindingNavigator"
        Me.PCOrderBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PCOrderBindingNavigator.Size = New System.Drawing.Size(363, 25)
        Me.PCOrderBindingNavigator.TabIndex = 0
        Me.PCOrderBindingNavigator.Text = "BindingNavigator1"
        '
        'BindingNavigatorAddNewItem
        '
        Me.BindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorAddNewItem.Image = CType(resources.GetObject("BindingNavigatorAddNewItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorAddNewItem.Name = "BindingNavigatorAddNewItem"
        Me.BindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorAddNewItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorAddNewItem.Text = "Добавить"
        '
        'BindingNavigatorCountItem
        '
        Me.BindingNavigatorCountItem.Name = "BindingNavigatorCountItem"
        Me.BindingNavigatorCountItem.Size = New System.Drawing.Size(43, 22)
        Me.BindingNavigatorCountItem.Text = "для {0}"
        Me.BindingNavigatorCountItem.ToolTipText = "Общее число элементов"
        '
        'BindingNavigatorDeleteItem
        '
        Me.BindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorDeleteItem.Image = CType(resources.GetObject("BindingNavigatorDeleteItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorDeleteItem.Name = "BindingNavigatorDeleteItem"
        Me.BindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorDeleteItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorDeleteItem.Text = "Удалить"
        '
        'BindingNavigatorMoveFirstItem
        '
        Me.BindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveFirstItem.Image = CType(resources.GetObject("BindingNavigatorMoveFirstItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveFirstItem.Name = "BindingNavigatorMoveFirstItem"
        Me.BindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveFirstItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveFirstItem.Text = "Переместить в начало"
        '
        'BindingNavigatorMovePreviousItem
        '
        Me.BindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMovePreviousItem.Image = CType(resources.GetObject("BindingNavigatorMovePreviousItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMovePreviousItem.Name = "BindingNavigatorMovePreviousItem"
        Me.BindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMovePreviousItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMovePreviousItem.Text = "Переместить назад"
        '
        'BindingNavigatorSeparator
        '
        Me.BindingNavigatorSeparator.Name = "BindingNavigatorSeparator"
        Me.BindingNavigatorSeparator.Size = New System.Drawing.Size(6, 25)
        '
        'BindingNavigatorPositionItem
        '
        Me.BindingNavigatorPositionItem.AccessibleName = "Положение"
        Me.BindingNavigatorPositionItem.AutoSize = False
        Me.BindingNavigatorPositionItem.Name = "BindingNavigatorPositionItem"
        Me.BindingNavigatorPositionItem.Size = New System.Drawing.Size(50, 23)
        Me.BindingNavigatorPositionItem.Text = "0"
        Me.BindingNavigatorPositionItem.ToolTipText = "Текущее положение"
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
        Me.BindingNavigatorMoveNextItem.Text = "Переместить вперед"
        '
        'BindingNavigatorMoveLastItem
        '
        Me.BindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.BindingNavigatorMoveLastItem.Image = CType(resources.GetObject("BindingNavigatorMoveLastItem.Image"), System.Drawing.Image)
        Me.BindingNavigatorMoveLastItem.Name = "BindingNavigatorMoveLastItem"
        Me.BindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = True
        Me.BindingNavigatorMoveLastItem.Size = New System.Drawing.Size(23, 22)
        Me.BindingNavigatorMoveLastItem.Text = "Переместить в конец"
        '
        'BindingNavigatorSeparator2
        '
        Me.BindingNavigatorSeparator2.Name = "BindingNavigatorSeparator2"
        Me.BindingNavigatorSeparator2.Size = New System.Drawing.Size(6, 25)
        '
        'PCOrderBindingNavigatorSaveItem
        '
        Me.PCOrderBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PCOrderBindingNavigatorSaveItem.Image = CType(resources.GetObject("PCOrderBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PCOrderBindingNavigatorSaveItem.Name = "PCOrderBindingNavigatorSaveItem"
        Me.PCOrderBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PCOrderBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'PCOrderDataGridView
        '
        Me.PCOrderDataGridView.AutoGenerateColumns = False
        Me.PCOrderDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PCOrderDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4})
        Me.PCOrderDataGridView.DataSource = Me.PCOrderBindingSource
        Me.PCOrderDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.PCOrderDataGridView.Name = "PCOrderDataGridView"
        Me.PCOrderDataGridView.Size = New System.Drawing.Size(348, 197)
        Me.PCOrderDataGridView.TabIndex = 1
        '
        'ClientBindingSource1
        '
        Me.ClientBindingSource1.DataMember = "Client"
        Me.ClientBindingSource1.DataSource = Me.AssemblePcDataSet
        '
        'ClientBindingSource
        '
        Me.ClientBindingSource.DataMember = "Client"
        Me.ClientBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'PCBindingSource
        '
        Me.PCBindingSource.DataMember = "PC"
        Me.PCBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "OrderDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Дата заказа"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "ClientID"
        Me.DataGridViewTextBoxColumn3.DataSource = Me.ClientBindingSource1
        Me.DataGridViewTextBoxColumn3.DisplayMember = "Surname"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Клиент"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        Me.DataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn3.ValueMember = "ClientID"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PCID"
        Me.DataGridViewTextBoxColumn4.DataSource = Me.PCBindingSource
        Me.DataGridViewTextBoxColumn4.DisplayMember = "Name"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Компьютер"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        Me.DataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic
        Me.DataGridViewTextBoxColumn4.ValueMember = "PCID"
        '
        'Form3
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(363, 230)
        Me.Controls.Add(Me.PCOrderDataGridView)
        Me.Controls.Add(Me.PCOrderBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form3"
        Me.Text = "Добавить заказ"
        CType(Me.AssemblePcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCOrderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCOrderBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCOrderBindingNavigator.ResumeLayout(False)
        Me.PCOrderBindingNavigator.PerformLayout()
        CType(Me.PCOrderDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ClientBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AssemblePcDataSet As AssemblePcDataSet
    Friend WithEvents PCOrderBindingSource As BindingSource
    Friend WithEvents PCOrderTableAdapter As AssemblePcDataSetTableAdapters.PCOrderTableAdapter
    Friend WithEvents TableAdapterManager As AssemblePcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PCOrderBindingNavigator As BindingNavigator
    Friend WithEvents BindingNavigatorAddNewItem As ToolStripButton
    Friend WithEvents BindingNavigatorCountItem As ToolStripLabel
    Friend WithEvents BindingNavigatorDeleteItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveFirstItem As ToolStripButton
    Friend WithEvents BindingNavigatorMovePreviousItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator As ToolStripSeparator
    Friend WithEvents BindingNavigatorPositionItem As ToolStripTextBox
    Friend WithEvents BindingNavigatorSeparator1 As ToolStripSeparator
    Friend WithEvents BindingNavigatorMoveNextItem As ToolStripButton
    Friend WithEvents BindingNavigatorMoveLastItem As ToolStripButton
    Friend WithEvents BindingNavigatorSeparator2 As ToolStripSeparator
    Friend WithEvents PCOrderBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents ClientTableAdapter As AssemblePcDataSetTableAdapters.ClientTableAdapter
    Friend WithEvents PCOrderDataGridView As DataGridView
    Friend WithEvents ClientBindingSource As BindingSource
    Friend WithEvents PCTableAdapter As AssemblePcDataSetTableAdapters.PCTableAdapter
    Friend WithEvents PCBindingSource As BindingSource
    Friend WithEvents ClientBindingSource1 As BindingSource
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewComboBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewComboBoxColumn
End Class
