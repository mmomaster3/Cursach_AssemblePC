Public Class Form2
    Private Sub PCBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles PCBindingNavigatorSaveItem.Click
        Me.Validate()
        Me.PCBindingSource.EndEdit()
        Try
            Me.TableAdapterManager.UpdateAll(Me.AssemblePcDataSet)
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Вы выбрали не существующий элемент")
        End Try

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.Drive". При необходимости она может быть перемещена или удалена.
        Me.DriveTableAdapter.Fill(Me.AssemblePcDataSet.Drive)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.GraphyCard". При необходимости она может быть перемещена или удалена.
        Me.GraphyCardTableAdapter.Fill(Me.AssemblePcDataSet.GraphyCard)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.MotherBoard". При необходимости она может быть перемещена или удалена.
        Me.MotherBoardTableAdapter.Fill(Me.AssemblePcDataSet.MotherBoard)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.Processor". При необходимости она может быть перемещена или удалена.
        Me.ProcessorTableAdapter.Fill(Me.AssemblePcDataSet.Processor)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.RAM". При необходимости она может быть перемещена или удалена.
        Me.RAMTableAdapter.Fill(Me.AssemblePcDataSet.RAM)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.PB". При необходимости она может быть перемещена или удалена.
        Me.PBTableAdapter.Fill(Me.AssemblePcDataSet.PB)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.PC". При необходимости она может быть перемещена или удалена.
        Me.PCTableAdapter.Fill(Me.AssemblePcDataSet.PC)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim dgv As DataGridView
        Select Case TabControl1.SelectedIndex
            Case 0
                dgv = PBDataGridView
            Case 1
                dgv = RAMDataGridView
            Case 2
                dgv = ProcessorDataGridView
            Case 3
                dgv = MotherBoardDataGridView
            Case 4
                dgv = GraphyCardDataGridView
            Case 5
                dgv = DriveDataGridView
        End Select

        For i = 0 To dgv.ColumnCount - 1
            For j = 0 To dgv.RowCount - 1
                dgv.Item(i, j).Style.BackColor = Color.White
                dgv.Item(i, j).Style.ForeColor = Color.Black
            Next j
        Next i


        For i = 0 To dgv.ColumnCount - 1
            For j = 0 To dgv.RowCount - 1
                If InStr(dgv.Item(i, j).Value, TextBox3.Text) Then
                    dgv.Item(i, j).Style.BackColor = Color.AliceBlue
                    dgv.Item(i, j).Style.ForeColor = Color.Blue
                End If
            Next j
        Next i

        If TextBox3.Text = "" Then
            For i = 0 To dgv.ColumnCount - 1
                For j = 0 To dgv.RowCount - 1
                    dgv.Item(i, j).Style.BackColor = Color.White
                    dgv.Item(i, j).Style.ForeColor = Color.Black
                Next j
            Next i
        End If
    End Sub
End Class