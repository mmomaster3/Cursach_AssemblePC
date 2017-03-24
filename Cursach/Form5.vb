Public Class Form5
    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.view_PCtry". При необходимости она может быть перемещена или удалена.
        Me.view_PCtryTableAdapter.Fill(Me.AssemblePcDataSet.view_PCtry)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.view_PCorder". При необходимости она может быть перемещена или удалена.
        Me.view_PCorderTableAdapter.Fill(Me.AssemblePcDataSet.view_PCorder)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class