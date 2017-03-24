Public Class Form4
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.Client". При необходимости она может быть перемещена или удалена.
        Me.ClientTableAdapter.Fill(Me.AssemblePcDataSet.Client)

        Me.ReportViewer1.RefreshReport()
    End Sub
End Class