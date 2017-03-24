<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.AssemblePcDataSet = New Cursach.AssemblePcDataSet()
        Me.PCBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.PCTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.PCTableAdapter()
        Me.TableAdapterManager = New Cursach.AssemblePcDataSetTableAdapters.TableAdapterManager()
        Me.DriveTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.DriveTableAdapter()
        Me.GraphyCardTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.GraphyCardTableAdapter()
        Me.MotherBoardTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.MotherBoardTableAdapter()
        Me.PBTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.PBTableAdapter()
        Me.ProcessorTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.ProcessorTableAdapter()
        Me.RAMTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.RAMTableAdapter()
        Me.PCBindingNavigator = New System.Windows.Forms.BindingNavigator(Me.components)
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
        Me.PCBindingNavigatorSaveItem = New System.Windows.Forms.ToolStripButton()
        Me.PCDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn1 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn2 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn3 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn4 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn5 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn6 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn7 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn8 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn9 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.PBDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn10 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn11 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn12 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn13 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn14 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PBBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.RAMDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn15 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn18 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn16 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn17 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RAMBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ProcessorDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn19 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn22 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn20 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn21 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn23 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn24 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ProcessorBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage4 = New System.Windows.Forms.TabPage()
        Me.MotherBoardDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn25 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn27 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn26 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn28 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn29 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn30 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn31 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MotherBoardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage5 = New System.Windows.Forms.TabPage()
        Me.GraphyCardDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn32 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn33 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn34 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn35 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn36 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn37 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GraphyCardBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.TabPage6 = New System.Windows.Forms.TabPage()
        Me.DriveDataGridView = New System.Windows.Forms.DataGridView()
        Me.DataGridViewTextBoxColumn38 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn39 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn40 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn41 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DataGridViewTextBoxColumn42 = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DriveBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        CType(Me.AssemblePcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PCBindingNavigator, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.PCBindingNavigator.SuspendLayout()
        CType(Me.PCDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.PBDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PBBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.RAMDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RAMBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.ProcessorDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.ProcessorBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage4.SuspendLayout()
        CType(Me.MotherBoardDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.MotherBoardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage5.SuspendLayout()
        CType(Me.GraphyCardDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraphyCardBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage6.SuspendLayout()
        CType(Me.DriveDataGridView, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DriveBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AssemblePcDataSet
        '
        Me.AssemblePcDataSet.DataSetName = "AssemblePcDataSet"
        Me.AssemblePcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'PCBindingSource
        '
        Me.PCBindingSource.DataMember = "PC"
        Me.PCBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'PCTableAdapter
        '
        Me.PCTableAdapter.ClearBeforeFill = True
        '
        'TableAdapterManager
        '
        Me.TableAdapterManager.BackupDataSetBeforeUpdate = False
        Me.TableAdapterManager.ClientTableAdapter = Nothing
        Me.TableAdapterManager.DriveTableAdapter = Me.DriveTableAdapter
        Me.TableAdapterManager.GraphyCardTableAdapter = Me.GraphyCardTableAdapter
        Me.TableAdapterManager.MotherBoardTableAdapter = Me.MotherBoardTableAdapter
        Me.TableAdapterManager.PBTableAdapter = Me.PBTableAdapter
        Me.TableAdapterManager.PCOrderTableAdapter = Nothing
        Me.TableAdapterManager.PCTableAdapter = Me.PCTableAdapter
        Me.TableAdapterManager.ProcessorTableAdapter = Me.ProcessorTableAdapter
        Me.TableAdapterManager.RAMTableAdapter = Me.RAMTableAdapter
        Me.TableAdapterManager.UpdateOrder = Cursach.AssemblePcDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
        '
        'DriveTableAdapter
        '
        Me.DriveTableAdapter.ClearBeforeFill = True
        '
        'GraphyCardTableAdapter
        '
        Me.GraphyCardTableAdapter.ClearBeforeFill = True
        '
        'MotherBoardTableAdapter
        '
        Me.MotherBoardTableAdapter.ClearBeforeFill = True
        '
        'PBTableAdapter
        '
        Me.PBTableAdapter.ClearBeforeFill = True
        '
        'ProcessorTableAdapter
        '
        Me.ProcessorTableAdapter.ClearBeforeFill = True
        '
        'RAMTableAdapter
        '
        Me.RAMTableAdapter.ClearBeforeFill = True
        '
        'PCBindingNavigator
        '
        Me.PCBindingNavigator.AddNewItem = Me.BindingNavigatorAddNewItem
        Me.PCBindingNavigator.BindingSource = Me.PCBindingSource
        Me.PCBindingNavigator.CountItem = Me.BindingNavigatorCountItem
        Me.PCBindingNavigator.DeleteItem = Me.BindingNavigatorDeleteItem
        Me.PCBindingNavigator.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.BindingNavigatorMoveFirstItem, Me.BindingNavigatorMovePreviousItem, Me.BindingNavigatorSeparator, Me.BindingNavigatorPositionItem, Me.BindingNavigatorCountItem, Me.BindingNavigatorSeparator1, Me.BindingNavigatorMoveNextItem, Me.BindingNavigatorMoveLastItem, Me.BindingNavigatorSeparator2, Me.BindingNavigatorAddNewItem, Me.BindingNavigatorDeleteItem, Me.PCBindingNavigatorSaveItem})
        Me.PCBindingNavigator.Location = New System.Drawing.Point(0, 0)
        Me.PCBindingNavigator.MoveFirstItem = Me.BindingNavigatorMoveFirstItem
        Me.PCBindingNavigator.MoveLastItem = Me.BindingNavigatorMoveLastItem
        Me.PCBindingNavigator.MoveNextItem = Me.BindingNavigatorMoveNextItem
        Me.PCBindingNavigator.MovePreviousItem = Me.BindingNavigatorMovePreviousItem
        Me.PCBindingNavigator.Name = "PCBindingNavigator"
        Me.PCBindingNavigator.PositionItem = Me.BindingNavigatorPositionItem
        Me.PCBindingNavigator.Size = New System.Drawing.Size(977, 25)
        Me.PCBindingNavigator.TabIndex = 0
        Me.PCBindingNavigator.Text = "BindingNavigator1"
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
        'PCBindingNavigatorSaveItem
        '
        Me.PCBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image
        Me.PCBindingNavigatorSaveItem.Image = CType(resources.GetObject("PCBindingNavigatorSaveItem.Image"), System.Drawing.Image)
        Me.PCBindingNavigatorSaveItem.Name = "PCBindingNavigatorSaveItem"
        Me.PCBindingNavigatorSaveItem.Size = New System.Drawing.Size(23, 22)
        Me.PCBindingNavigatorSaveItem.Text = "Сохранить данные"
        '
        'PCDataGridView
        '
        Me.PCDataGridView.AutoGenerateColumns = False
        Me.PCDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PCDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn1, Me.DataGridViewTextBoxColumn2, Me.DataGridViewTextBoxColumn3, Me.DataGridViewTextBoxColumn4, Me.DataGridViewTextBoxColumn5, Me.DataGridViewTextBoxColumn6, Me.DataGridViewTextBoxColumn7, Me.DataGridViewTextBoxColumn8, Me.DataGridViewTextBoxColumn9})
        Me.PCDataGridView.DataSource = Me.PCBindingSource
        Me.PCDataGridView.Location = New System.Drawing.Point(12, 28)
        Me.PCDataGridView.Name = "PCDataGridView"
        Me.PCDataGridView.Size = New System.Drawing.Size(953, 220)
        Me.PCDataGridView.TabIndex = 1
        '
        'DataGridViewTextBoxColumn1
        '
        Me.DataGridViewTextBoxColumn1.DataPropertyName = "PCID"
        Me.DataGridViewTextBoxColumn1.HeaderText = "ID Компьютера"
        Me.DataGridViewTextBoxColumn1.Name = "DataGridViewTextBoxColumn1"
        Me.DataGridViewTextBoxColumn1.ReadOnly = True
        '
        'DataGridViewTextBoxColumn2
        '
        Me.DataGridViewTextBoxColumn2.DataPropertyName = "AssembleDate"
        Me.DataGridViewTextBoxColumn2.HeaderText = "Дата сборки"
        Me.DataGridViewTextBoxColumn2.Name = "DataGridViewTextBoxColumn2"
        '
        'DataGridViewTextBoxColumn3
        '
        Me.DataGridViewTextBoxColumn3.DataPropertyName = "Name"
        Me.DataGridViewTextBoxColumn3.HeaderText = "Название"
        Me.DataGridViewTextBoxColumn3.Name = "DataGridViewTextBoxColumn3"
        '
        'DataGridViewTextBoxColumn4
        '
        Me.DataGridViewTextBoxColumn4.DataPropertyName = "PBID"
        Me.DataGridViewTextBoxColumn4.HeaderText = "Блок питания"
        Me.DataGridViewTextBoxColumn4.Name = "DataGridViewTextBoxColumn4"
        '
        'DataGridViewTextBoxColumn5
        '
        Me.DataGridViewTextBoxColumn5.DataPropertyName = "RAMID"
        Me.DataGridViewTextBoxColumn5.HeaderText = "ОЗУ"
        Me.DataGridViewTextBoxColumn5.Name = "DataGridViewTextBoxColumn5"
        '
        'DataGridViewTextBoxColumn6
        '
        Me.DataGridViewTextBoxColumn6.DataPropertyName = "ProcID"
        Me.DataGridViewTextBoxColumn6.HeaderText = "Процессор"
        Me.DataGridViewTextBoxColumn6.Name = "DataGridViewTextBoxColumn6"
        '
        'DataGridViewTextBoxColumn7
        '
        Me.DataGridViewTextBoxColumn7.DataPropertyName = "MBID"
        Me.DataGridViewTextBoxColumn7.HeaderText = "Материнская плата"
        Me.DataGridViewTextBoxColumn7.Name = "DataGridViewTextBoxColumn7"
        '
        'DataGridViewTextBoxColumn8
        '
        Me.DataGridViewTextBoxColumn8.DataPropertyName = "GPID"
        Me.DataGridViewTextBoxColumn8.HeaderText = "Видео карта"
        Me.DataGridViewTextBoxColumn8.Name = "DataGridViewTextBoxColumn8"
        '
        'DataGridViewTextBoxColumn9
        '
        Me.DataGridViewTextBoxColumn9.DataPropertyName = "DriveID"
        Me.DataGridViewTextBoxColumn9.HeaderText = "Жесткий диск"
        Me.DataGridViewTextBoxColumn9.Name = "DataGridViewTextBoxColumn9"
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Controls.Add(Me.TabPage4)
        Me.TabControl1.Controls.Add(Me.TabPage5)
        Me.TabControl1.Controls.Add(Me.TabPage6)
        Me.TabControl1.Location = New System.Drawing.Point(12, 254)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(965, 242)
        Me.TabControl1.TabIndex = 2
        '
        'TabPage1
        '
        Me.TabPage1.AutoScroll = True
        Me.TabPage1.Controls.Add(Me.PBDataGridView)
        Me.TabPage1.Location = New System.Drawing.Point(4, 22)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(957, 216)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Блоки питания"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'PBDataGridView
        '
        Me.PBDataGridView.AutoGenerateColumns = False
        Me.PBDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.PBDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn10, Me.DataGridViewTextBoxColumn11, Me.DataGridViewTextBoxColumn12, Me.DataGridViewTextBoxColumn13, Me.DataGridViewTextBoxColumn14})
        Me.PBDataGridView.DataSource = Me.PBBindingSource
        Me.PBDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.PBDataGridView.Name = "PBDataGridView"
        Me.PBDataGridView.Size = New System.Drawing.Size(946, 210)
        Me.PBDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn10
        '
        Me.DataGridViewTextBoxColumn10.DataPropertyName = "PBID"
        Me.DataGridViewTextBoxColumn10.HeaderText = "ID Блока питания"
        Me.DataGridViewTextBoxColumn10.Name = "DataGridViewTextBoxColumn10"
        Me.DataGridViewTextBoxColumn10.ReadOnly = True
        '
        'DataGridViewTextBoxColumn11
        '
        Me.DataGridViewTextBoxColumn11.DataPropertyName = "Producer"
        Me.DataGridViewTextBoxColumn11.HeaderText = "Производитель"
        Me.DataGridViewTextBoxColumn11.Name = "DataGridViewTextBoxColumn11"
        '
        'DataGridViewTextBoxColumn12
        '
        Me.DataGridViewTextBoxColumn12.DataPropertyName = "KPD"
        Me.DataGridViewTextBoxColumn12.HeaderText = "КПД"
        Me.DataGridViewTextBoxColumn12.Name = "DataGridViewTextBoxColumn12"
        '
        'DataGridViewTextBoxColumn13
        '
        Me.DataGridViewTextBoxColumn13.DataPropertyName = "Sercif"
        Me.DataGridViewTextBoxColumn13.HeaderText = "Сертификат"
        Me.DataGridViewTextBoxColumn13.Name = "DataGridViewTextBoxColumn13"
        '
        'DataGridViewTextBoxColumn14
        '
        Me.DataGridViewTextBoxColumn14.DataPropertyName = "Power"
        Me.DataGridViewTextBoxColumn14.HeaderText = "Мощьность"
        Me.DataGridViewTextBoxColumn14.Name = "DataGridViewTextBoxColumn14"
        '
        'PBBindingSource
        '
        Me.PBBindingSource.DataMember = "PB"
        Me.PBBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'TabPage2
        '
        Me.TabPage2.AutoScroll = True
        Me.TabPage2.Controls.Add(Me.RAMDataGridView)
        Me.TabPage2.Location = New System.Drawing.Point(4, 22)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(957, 216)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "ОЗУ"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'RAMDataGridView
        '
        Me.RAMDataGridView.AutoGenerateColumns = False
        Me.RAMDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.RAMDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn15, Me.DataGridViewTextBoxColumn18, Me.DataGridViewTextBoxColumn16, Me.DataGridViewTextBoxColumn17})
        Me.RAMDataGridView.DataSource = Me.RAMBindingSource
        Me.RAMDataGridView.Location = New System.Drawing.Point(0, 3)
        Me.RAMDataGridView.Name = "RAMDataGridView"
        Me.RAMDataGridView.Size = New System.Drawing.Size(949, 213)
        Me.RAMDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn15
        '
        Me.DataGridViewTextBoxColumn15.DataPropertyName = "RAMID"
        Me.DataGridViewTextBoxColumn15.HeaderText = "ID ОЗУ"
        Me.DataGridViewTextBoxColumn15.Name = "DataGridViewTextBoxColumn15"
        Me.DataGridViewTextBoxColumn15.ReadOnly = True
        '
        'DataGridViewTextBoxColumn18
        '
        Me.DataGridViewTextBoxColumn18.DataPropertyName = "Producer"
        Me.DataGridViewTextBoxColumn18.HeaderText = "Производитель"
        Me.DataGridViewTextBoxColumn18.Name = "DataGridViewTextBoxColumn18"
        '
        'DataGridViewTextBoxColumn16
        '
        Me.DataGridViewTextBoxColumn16.DataPropertyName = "V"
        Me.DataGridViewTextBoxColumn16.HeaderText = "Объем"
        Me.DataGridViewTextBoxColumn16.Name = "DataGridViewTextBoxColumn16"
        '
        'DataGridViewTextBoxColumn17
        '
        Me.DataGridViewTextBoxColumn17.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn17.HeaderText = "Тип"
        Me.DataGridViewTextBoxColumn17.Name = "DataGridViewTextBoxColumn17"
        '
        'RAMBindingSource
        '
        Me.RAMBindingSource.DataMember = "RAM"
        Me.RAMBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'TabPage3
        '
        Me.TabPage3.AutoScroll = True
        Me.TabPage3.Controls.Add(Me.ProcessorDataGridView)
        Me.TabPage3.Location = New System.Drawing.Point(4, 22)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Size = New System.Drawing.Size(957, 216)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Процессоры"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ProcessorDataGridView
        '
        Me.ProcessorDataGridView.AutoGenerateColumns = False
        Me.ProcessorDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ProcessorDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn19, Me.DataGridViewTextBoxColumn22, Me.DataGridViewTextBoxColumn20, Me.DataGridViewTextBoxColumn21, Me.DataGridViewTextBoxColumn23, Me.DataGridViewTextBoxColumn24})
        Me.ProcessorDataGridView.DataSource = Me.ProcessorBindingSource
        Me.ProcessorDataGridView.Location = New System.Drawing.Point(3, 0)
        Me.ProcessorDataGridView.Name = "ProcessorDataGridView"
        Me.ProcessorDataGridView.Size = New System.Drawing.Size(946, 213)
        Me.ProcessorDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn19
        '
        Me.DataGridViewTextBoxColumn19.DataPropertyName = "ProcID"
        Me.DataGridViewTextBoxColumn19.HeaderText = "ID Процессора"
        Me.DataGridViewTextBoxColumn19.Name = "DataGridViewTextBoxColumn19"
        Me.DataGridViewTextBoxColumn19.ReadOnly = True
        '
        'DataGridViewTextBoxColumn22
        '
        Me.DataGridViewTextBoxColumn22.DataPropertyName = "Producer"
        Me.DataGridViewTextBoxColumn22.HeaderText = "Производитель"
        Me.DataGridViewTextBoxColumn22.Name = "DataGridViewTextBoxColumn22"
        '
        'DataGridViewTextBoxColumn20
        '
        Me.DataGridViewTextBoxColumn20.DataPropertyName = "Model"
        Me.DataGridViewTextBoxColumn20.HeaderText = "Модель"
        Me.DataGridViewTextBoxColumn20.Name = "DataGridViewTextBoxColumn20"
        '
        'DataGridViewTextBoxColumn21
        '
        Me.DataGridViewTextBoxColumn21.DataPropertyName = "Freq"
        Me.DataGridViewTextBoxColumn21.HeaderText = "Частота"
        Me.DataGridViewTextBoxColumn21.Name = "DataGridViewTextBoxColumn21"
        '
        'DataGridViewTextBoxColumn23
        '
        Me.DataGridViewTextBoxColumn23.DataPropertyName = "Core"
        Me.DataGridViewTextBoxColumn23.HeaderText = "Кол-во ядер"
        Me.DataGridViewTextBoxColumn23.Name = "DataGridViewTextBoxColumn23"
        '
        'DataGridViewTextBoxColumn24
        '
        Me.DataGridViewTextBoxColumn24.DataPropertyName = "Socket"
        Me.DataGridViewTextBoxColumn24.HeaderText = "Сокет"
        Me.DataGridViewTextBoxColumn24.Name = "DataGridViewTextBoxColumn24"
        '
        'ProcessorBindingSource
        '
        Me.ProcessorBindingSource.DataMember = "Processor"
        Me.ProcessorBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'TabPage4
        '
        Me.TabPage4.AutoScroll = True
        Me.TabPage4.Controls.Add(Me.MotherBoardDataGridView)
        Me.TabPage4.Location = New System.Drawing.Point(4, 22)
        Me.TabPage4.Name = "TabPage4"
        Me.TabPage4.Size = New System.Drawing.Size(957, 216)
        Me.TabPage4.TabIndex = 3
        Me.TabPage4.Text = "Материнские платы"
        Me.TabPage4.UseVisualStyleBackColor = True
        '
        'MotherBoardDataGridView
        '
        Me.MotherBoardDataGridView.AutoGenerateColumns = False
        Me.MotherBoardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.MotherBoardDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn25, Me.DataGridViewTextBoxColumn27, Me.DataGridViewTextBoxColumn26, Me.DataGridViewTextBoxColumn28, Me.DataGridViewTextBoxColumn29, Me.DataGridViewTextBoxColumn30, Me.DataGridViewTextBoxColumn31})
        Me.MotherBoardDataGridView.DataSource = Me.MotherBoardBindingSource
        Me.MotherBoardDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.MotherBoardDataGridView.Name = "MotherBoardDataGridView"
        Me.MotherBoardDataGridView.Size = New System.Drawing.Size(946, 210)
        Me.MotherBoardDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn25
        '
        Me.DataGridViewTextBoxColumn25.DataPropertyName = "MBID"
        Me.DataGridViewTextBoxColumn25.HeaderText = "ID Материнской платы"
        Me.DataGridViewTextBoxColumn25.Name = "DataGridViewTextBoxColumn25"
        Me.DataGridViewTextBoxColumn25.ReadOnly = True
        '
        'DataGridViewTextBoxColumn27
        '
        Me.DataGridViewTextBoxColumn27.DataPropertyName = "Producer"
        Me.DataGridViewTextBoxColumn27.HeaderText = "Производитель"
        Me.DataGridViewTextBoxColumn27.Name = "DataGridViewTextBoxColumn27"
        '
        'DataGridViewTextBoxColumn26
        '
        Me.DataGridViewTextBoxColumn26.DataPropertyName = "CellsForRAM"
        Me.DataGridViewTextBoxColumn26.HeaderText = "Кол-во ячеек для ОЗУ"
        Me.DataGridViewTextBoxColumn26.Name = "DataGridViewTextBoxColumn26"
        '
        'DataGridViewTextBoxColumn28
        '
        Me.DataGridViewTextBoxColumn28.DataPropertyName = "ChipSet"
        Me.DataGridViewTextBoxColumn28.HeaderText = "Чипсет"
        Me.DataGridViewTextBoxColumn28.Name = "DataGridViewTextBoxColumn28"
        '
        'DataGridViewTextBoxColumn29
        '
        Me.DataGridViewTextBoxColumn29.DataPropertyName = "TypeRAM"
        Me.DataGridViewTextBoxColumn29.HeaderText = "Тип ОЗУ"
        Me.DataGridViewTextBoxColumn29.Name = "DataGridViewTextBoxColumn29"
        '
        'DataGridViewTextBoxColumn30
        '
        Me.DataGridViewTextBoxColumn30.DataPropertyName = "PCIEx"
        Me.DataGridViewTextBoxColumn30.HeaderText = "Кол-во PCIEx разъемов"
        Me.DataGridViewTextBoxColumn30.Name = "DataGridViewTextBoxColumn30"
        '
        'DataGridViewTextBoxColumn31
        '
        Me.DataGridViewTextBoxColumn31.DataPropertyName = "Socket"
        Me.DataGridViewTextBoxColumn31.HeaderText = "Сокет для процессора"
        Me.DataGridViewTextBoxColumn31.Name = "DataGridViewTextBoxColumn31"
        '
        'MotherBoardBindingSource
        '
        Me.MotherBoardBindingSource.DataMember = "MotherBoard"
        Me.MotherBoardBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'TabPage5
        '
        Me.TabPage5.AutoScroll = True
        Me.TabPage5.Controls.Add(Me.GraphyCardDataGridView)
        Me.TabPage5.Location = New System.Drawing.Point(4, 22)
        Me.TabPage5.Name = "TabPage5"
        Me.TabPage5.Size = New System.Drawing.Size(957, 216)
        Me.TabPage5.TabIndex = 4
        Me.TabPage5.Text = "Видео карты"
        Me.TabPage5.UseVisualStyleBackColor = True
        '
        'GraphyCardDataGridView
        '
        Me.GraphyCardDataGridView.AutoGenerateColumns = False
        Me.GraphyCardDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GraphyCardDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn32, Me.DataGridViewTextBoxColumn33, Me.DataGridViewTextBoxColumn34, Me.DataGridViewTextBoxColumn35, Me.DataGridViewTextBoxColumn36, Me.DataGridViewTextBoxColumn37})
        Me.GraphyCardDataGridView.DataSource = Me.GraphyCardBindingSource
        Me.GraphyCardDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.GraphyCardDataGridView.Name = "GraphyCardDataGridView"
        Me.GraphyCardDataGridView.Size = New System.Drawing.Size(946, 210)
        Me.GraphyCardDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn32
        '
        Me.DataGridViewTextBoxColumn32.DataPropertyName = "GPID"
        Me.DataGridViewTextBoxColumn32.HeaderText = "ID Видеокарты"
        Me.DataGridViewTextBoxColumn32.Name = "DataGridViewTextBoxColumn32"
        Me.DataGridViewTextBoxColumn32.ReadOnly = True
        '
        'DataGridViewTextBoxColumn33
        '
        Me.DataGridViewTextBoxColumn33.DataPropertyName = "Producer"
        Me.DataGridViewTextBoxColumn33.HeaderText = "Производитель"
        Me.DataGridViewTextBoxColumn33.Name = "DataGridViewTextBoxColumn33"
        '
        'DataGridViewTextBoxColumn34
        '
        Me.DataGridViewTextBoxColumn34.DataPropertyName = "Memory"
        Me.DataGridViewTextBoxColumn34.HeaderText = "Кол-во памяти"
        Me.DataGridViewTextBoxColumn34.Name = "DataGridViewTextBoxColumn34"
        '
        'DataGridViewTextBoxColumn35
        '
        Me.DataGridViewTextBoxColumn35.DataPropertyName = "TypeOfMemory"
        Me.DataGridViewTextBoxColumn35.HeaderText = "Тип памяти"
        Me.DataGridViewTextBoxColumn35.Name = "DataGridViewTextBoxColumn35"
        '
        'DataGridViewTextBoxColumn36
        '
        Me.DataGridViewTextBoxColumn36.DataPropertyName = "Bus"
        Me.DataGridViewTextBoxColumn36.HeaderText = "Шина"
        Me.DataGridViewTextBoxColumn36.Name = "DataGridViewTextBoxColumn36"
        '
        'DataGridViewTextBoxColumn37
        '
        Me.DataGridViewTextBoxColumn37.DataPropertyName = "GPU"
        Me.DataGridViewTextBoxColumn37.HeaderText = "Графический процессор"
        Me.DataGridViewTextBoxColumn37.Name = "DataGridViewTextBoxColumn37"
        '
        'GraphyCardBindingSource
        '
        Me.GraphyCardBindingSource.DataMember = "GraphyCard"
        Me.GraphyCardBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'TabPage6
        '
        Me.TabPage6.AutoScroll = True
        Me.TabPage6.Controls.Add(Me.DriveDataGridView)
        Me.TabPage6.Location = New System.Drawing.Point(4, 22)
        Me.TabPage6.Name = "TabPage6"
        Me.TabPage6.Size = New System.Drawing.Size(957, 216)
        Me.TabPage6.TabIndex = 5
        Me.TabPage6.Text = "Жесткие диски"
        Me.TabPage6.UseVisualStyleBackColor = True
        '
        'DriveDataGridView
        '
        Me.DriveDataGridView.AutoGenerateColumns = False
        Me.DriveDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DriveDataGridView.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.DataGridViewTextBoxColumn38, Me.DataGridViewTextBoxColumn39, Me.DataGridViewTextBoxColumn40, Me.DataGridViewTextBoxColumn41, Me.DataGridViewTextBoxColumn42})
        Me.DriveDataGridView.DataSource = Me.DriveBindingSource
        Me.DriveDataGridView.Location = New System.Drawing.Point(3, 3)
        Me.DriveDataGridView.Name = "DriveDataGridView"
        Me.DriveDataGridView.Size = New System.Drawing.Size(946, 210)
        Me.DriveDataGridView.TabIndex = 0
        '
        'DataGridViewTextBoxColumn38
        '
        Me.DataGridViewTextBoxColumn38.DataPropertyName = "DriveID"
        Me.DataGridViewTextBoxColumn38.HeaderText = "ID Жесткого диска"
        Me.DataGridViewTextBoxColumn38.Name = "DataGridViewTextBoxColumn38"
        Me.DataGridViewTextBoxColumn38.ReadOnly = True
        '
        'DataGridViewTextBoxColumn39
        '
        Me.DataGridViewTextBoxColumn39.DataPropertyName = "Producer"
        Me.DataGridViewTextBoxColumn39.HeaderText = "Производитель"
        Me.DataGridViewTextBoxColumn39.Name = "DataGridViewTextBoxColumn39"
        '
        'DataGridViewTextBoxColumn40
        '
        Me.DataGridViewTextBoxColumn40.DataPropertyName = "V"
        Me.DataGridViewTextBoxColumn40.HeaderText = "Объем"
        Me.DataGridViewTextBoxColumn40.Name = "DataGridViewTextBoxColumn40"
        '
        'DataGridViewTextBoxColumn41
        '
        Me.DataGridViewTextBoxColumn41.DataPropertyName = "Speed"
        Me.DataGridViewTextBoxColumn41.HeaderText = "Скорость"
        Me.DataGridViewTextBoxColumn41.Name = "DataGridViewTextBoxColumn41"
        '
        'DataGridViewTextBoxColumn42
        '
        Me.DataGridViewTextBoxColumn42.DataPropertyName = "Type"
        Me.DataGridViewTextBoxColumn42.HeaderText = "Тип"
        Me.DataGridViewTextBoxColumn42.Name = "DataGridViewTextBoxColumn42"
        '
        'DriveBindingSource
        '
        Me.DriveBindingSource.DataMember = "Drive"
        Me.DriveBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'Button4
        '
        Me.Button4.Location = New System.Drawing.Point(265, 520)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(93, 23)
        Me.Button4.TabIndex = 19
        Me.Button4.Text = "Искать"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(16, 525)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(42, 13)
        Me.Label5.TabIndex = 18
        Me.Label5.Text = "Поиск:"
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(65, 522)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(194, 20)
        Me.TextBox3.TabIndex = 17
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(977, 554)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.TabControl1)
        Me.Controls.Add(Me.PCDataGridView)
        Me.Controls.Add(Me.PCBindingNavigator)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form2"
        Me.Text = "Добавить компьютер"
        CType(Me.AssemblePcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PCBindingNavigator, System.ComponentModel.ISupportInitialize).EndInit()
        Me.PCBindingNavigator.ResumeLayout(False)
        Me.PCBindingNavigator.PerformLayout()
        CType(Me.PCDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        CType(Me.PBDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PBBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        CType(Me.RAMDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RAMBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        CType(Me.ProcessorDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.ProcessorBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage4.ResumeLayout(False)
        CType(Me.MotherBoardDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.MotherBoardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage5.ResumeLayout(False)
        CType(Me.GraphyCardDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraphyCardBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage6.ResumeLayout(False)
        CType(Me.DriveDataGridView, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DriveBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents AssemblePcDataSet As AssemblePcDataSet
    Friend WithEvents PCBindingSource As BindingSource
    Friend WithEvents PCTableAdapter As AssemblePcDataSetTableAdapters.PCTableAdapter
    Friend WithEvents TableAdapterManager As AssemblePcDataSetTableAdapters.TableAdapterManager
    Friend WithEvents PCBindingNavigator As BindingNavigator
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
    Friend WithEvents PCBindingNavigatorSaveItem As ToolStripButton
    Friend WithEvents PCDataGridView As DataGridView
    Friend WithEvents PBTableAdapter As AssemblePcDataSetTableAdapters.PBTableAdapter
    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents TabPage4 As TabPage
    Friend WithEvents TabPage5 As TabPage
    Friend WithEvents TabPage6 As TabPage
    Friend WithEvents PBBindingSource As BindingSource
    Friend WithEvents RAMTableAdapter As AssemblePcDataSetTableAdapters.RAMTableAdapter
    Friend WithEvents PBDataGridView As DataGridView
    Friend WithEvents RAMBindingSource As BindingSource
    Friend WithEvents ProcessorTableAdapter As AssemblePcDataSetTableAdapters.ProcessorTableAdapter
    Friend WithEvents RAMDataGridView As DataGridView
    Friend WithEvents ProcessorBindingSource As BindingSource
    Friend WithEvents MotherBoardTableAdapter As AssemblePcDataSetTableAdapters.MotherBoardTableAdapter
    Friend WithEvents ProcessorDataGridView As DataGridView
    Friend WithEvents MotherBoardBindingSource As BindingSource
    Friend WithEvents GraphyCardTableAdapter As AssemblePcDataSetTableAdapters.GraphyCardTableAdapter
    Friend WithEvents MotherBoardDataGridView As DataGridView
    Friend WithEvents GraphyCardBindingSource As BindingSource
    Friend WithEvents DriveTableAdapter As AssemblePcDataSetTableAdapters.DriveTableAdapter
    Friend WithEvents GraphyCardDataGridView As DataGridView
    Friend WithEvents DriveBindingSource As BindingSource
    Friend WithEvents DriveDataGridView As DataGridView
    Friend WithEvents DataGridViewTextBoxColumn10 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn11 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn12 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn13 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn14 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn15 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn18 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn16 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn17 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn19 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn22 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn20 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn21 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn23 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn24 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn25 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn27 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn26 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn28 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn29 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn30 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn31 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn32 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn33 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn34 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn35 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn36 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn37 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn38 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn39 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn40 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn41 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn42 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn1 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn2 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn3 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn4 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn5 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn6 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn7 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn8 As DataGridViewTextBoxColumn
    Friend WithEvents DataGridViewTextBoxColumn9 As DataGridViewTextBoxColumn
    Friend WithEvents Button4 As Button
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBox3 As TextBox
End Class
