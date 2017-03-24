Public Class Form3
    Private Sub PCOrderBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PCOrderBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PCOrderBindingSource.EndEdit()
        Try
            Me.TableAdapterManager.UpdateAll(Me.AssemblePcDataSet)
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Вы выбрали не существующий элемент")
        End Try
    End Sub

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.PC". При необходимости она может быть перемещена или удалена.
        Me.PCTableAdapter.Fill(Me.AssemblePcDataSet.PC)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.Client". При необходимости она может быть перемещена или удалена.
        Me.ClientTableAdapter.Fill(Me.AssemblePcDataSet.Client)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.PCOrder". При необходимости она может быть перемещена или удалена.
        Me.PCOrderTableAdapter.Fill(Me.AssemblePcDataSet.PCOrder)

    End Sub
End Class