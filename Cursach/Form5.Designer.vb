<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form5
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.view_PCtryBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.AssemblePcDataSet = New Cursach.AssemblePcDataSet()
        Me.view_PCorderBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.view_PCorderTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.view_PCorderTableAdapter()
        Me.view_PCtryTableAdapter = New Cursach.AssemblePcDataSetTableAdapters.view_PCtryTableAdapter()
        CType(Me.view_PCtryBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AssemblePcDataSet, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.view_PCorderBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'view_PCtryBindingSource
        '
        Me.view_PCtryBindingSource.DataMember = "view_PCtry"
        Me.view_PCtryBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'AssemblePcDataSet
        '
        Me.AssemblePcDataSet.DataSetName = "AssemblePcDataSet"
        Me.AssemblePcDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'view_PCorderBindingSource
        '
        Me.view_PCorderBindingSource.DataMember = "view_PCorder"
        Me.view_PCorderBindingSource.DataSource = Me.AssemblePcDataSet
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "DataSet1"
        ReportDataSource1.Value = Me.view_PCtryBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "Cursach.Report2.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.Size = New System.Drawing.Size(708, 583)
        Me.ReportViewer1.TabIndex = 0
        '
        'view_PCorderTableAdapter
        '
        Me.view_PCorderTableAdapter.ClearBeforeFill = True
        '
        'view_PCtryTableAdapter
        '
        Me.view_PCtryTableAdapter.ClearBeforeFill = True
        '
        'Form5
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(708, 583)
        Me.Controls.Add(Me.ReportViewer1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.Name = "Form5"
        Me.Text = "Отчет по компьютерам:"
        CType(Me.view_PCtryBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AssemblePcDataSet, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.view_PCorderBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents view_PCorderBindingSource As BindingSource
    Friend WithEvents AssemblePcDataSet As AssemblePcDataSet
    Friend WithEvents view_PCorderTableAdapter As AssemblePcDataSetTableAdapters.view_PCorderTableAdapter
    Friend WithEvents view_PCtryBindingSource As BindingSource
    Friend WithEvents view_PCtryTableAdapter As AssemblePcDataSetTableAdapters.view_PCtryTableAdapter
End Class
