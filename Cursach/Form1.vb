Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.Client". При необходимости она может быть перемещена или удалена.
        Me.ClientTableAdapter.Fill(Me.AssemblePcDataSet.Client)
        'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.view_PCorder". При необходимости она может быть перемещена или удалена.
        Me.View_PCorderTableAdapter.Fill(Me.AssemblePcDataSet.view_PCorder)
        View_PCtryBindingNavigator.BindingSource = ClientBindingSource

        ComboBox1.Items.Add("Фамилия")
        ComboBox1.Items.Add("Имя")
        ComboBox1.Items.Add("Телефон")
    End Sub

    Private Sub TabControl1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles TabControl1.SelectedIndexChanged
        If TabControl1.SelectedTab.Text = "Заказы" Then
            'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.view_PCorder". При необходимости она может быть перемещена или удалена.
            Me.View_PCorderTableAdapter.Fill(Me.AssemblePcDataSet.view_PCorder)

            ListBox1.Items.Clear()
            ListBox1.Items.Add("Дата заказа")
            ListBox1.Items.Add("Имя")
            ListBox1.Items.Add("Фамилия")
            ListBox1.Items.Add("Название ПК")

            View_PCtryBindingNavigator.BindingSource = View_PCorderBindingSource

            BindingNavigatorAddNewItem.Enabled = False
            BindingNavigatorDeleteItem.Enabled = False
            View_PCtryBindingNavigatorSaveItem.Enabled = False

            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Дата заказа")
            ComboBox1.Items.Add("Имя")
            ComboBox1.Items.Add("Фамилия")
            ComboBox1.Items.Add("Название ПК")
        End If
        If TabControl1.SelectedTab.Text = "Клиенты" Then
            'TODO: данная строка кода позволяет загрузить данные в таблицу "AssemblePcDataSet.Client". При необходимости она может быть перемещена или удалена.
            Me.ClientTableAdapter.Fill(Me.AssemblePcDataSet.Client)

            ListBox1.Items.Clear()
            ListBox1.Items.Add("Фамилия")
            ListBox1.Items.Add("Имя")
            ListBox1.Items.Add("Телефон")

            View_PCtryBindingNavigator.BindingSource = ClientBindingSource

            BindingNavigatorAddNewItem.Enabled = True
            BindingNavigatorDeleteItem.Enabled = True
            View_PCtryBindingNavigatorSaveItem.Enabled = True

            ComboBox1.Items.Clear()
            ComboBox1.Items.Add("Фамилия")
            ComboBox1.Items.Add("Имя")
            ComboBox1.Items.Add("Телефон")
        End If
    End Sub

    Private Sub View_PCtryBindingNavigatorSaveItem_Click(sender As Object, e As EventArgs) Handles View_PCtryBindingNavigatorSaveItem.Click
        Me.Validate()
        If TabControl1.SelectedTab.Text = "Заказы" Then
            View_PCorderBindingSource.EndEdit()
        End If
        If TabControl1.SelectedTab.Text = "Клиенты" Then
            ClientBindingSource.EndEdit()
        End If

        Try
            Me.TableAdapterManager.UpdateAll(Me.AssemblePcDataSet)
        Catch ex As System.Data.SqlClient.SqlException
            MessageBox.Show("Ошибка")
        End Try
    End Sub

    Private Sub ListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ListBox1.SelectedIndexChanged
        Button1.Enabled = True
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If TabControl1.SelectedTab.Text = "Клиенты" Then
            Dim col As DataGridViewColumn
            Select Case ListBox1.SelectedIndex
                Case 0
                    col = DataGridViewTextBoxColumn36
                Case 1
                    col = DataGridViewTextBoxColumn35
                Case 2
                    col = DataGridViewTextBoxColumn34
            End Select

            If RadioButton1.Checked Then
                ClientDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending)
            Else
                ClientDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending)
            End If
        End If
        If TabControl1.SelectedTab.Text = "Заказы" Then
            Dim col As DataGridViewColumn
            Select Case ListBox1.SelectedIndex
                Case 0
                    col = DataGridViewTextBoxColumn29
                Case 1
                    col = DataGridViewTextBoxColumn30
                Case 2
                    col = DataGridViewTextBoxColumn31
                Case 3
                    col = DataGridViewTextBoxColumn32
            End Select

            If RadioButton1.Checked Then
                View_PCorderDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Ascending)
            Else
                View_PCorderDataGridView.Sort(col, System.ComponentModel.ListSortDirection.Descending)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If TextBox1.Text = "" Or ComboBox1.Text = "" Then
            MessageBox.Show("Введите значения в поля Столбец или Значение")
            Return
        End If
        If TabControl1.SelectedTab.Text = "Клиенты" Then
            Dim a As String
            Select Case ComboBox1.SelectedItem.ToString()
                Case "Фамилия"
                    a = "Surname"
                Case "Имя"
                    a = "Name"
                Case "Телефон"
                    a = "tel"
            End Select
            ClientBindingSource.Filter = a + "='" + TextBox1.Text + "'"
        End If
        If TabControl1.SelectedTab.Text = "Заказы" Then
            View_PCorderBindingSource.Filter = ComboBox1.Text + "='" + TextBox1.Text + "'"
        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        View_PCorderBindingSource.Filter = ""
        ClientBindingSource.Filter = ""
        TextBox1.Text = ""
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        Dim sb As BindingSource = ClientBindingSource
        Dim a As String
        Select Case TabControl1.SelectedTab.Text
            Case "Клиенты"
                sb = ClientBindingSource
                a = "Surname"
            Case "Заказы"
                sb = View_PCorderBindingSource
                a = "Фамилия"
        End Select
        sb.Filter = $"[{a}] Like '*{TextBox2.Text}*'"
    End Sub

    Private Sub ДобавитьКомпьютерToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьКомпьютерToolStripMenuItem.Click
        Try
            Dim f2 = New Form2()
            f2.ShowDialog()
        Catch ex As Exception
            MessageBox.Show("Ошибка!")
        End Try
    End Sub

    Private Sub ДобавитьЗаказToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ДобавитьЗаказToolStripMenuItem.Click
        Dim f3 = New Form3()
        f3.ShowDialog()
    End Sub

    Private Sub Form1_HelpButtonClicked(sender As Object, e As System.ComponentModel.CancelEventArgs)
    End Sub

    Private Sub СправкаToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles СправкаToolStripMenuItem.Click
        Process.Start("Help.chm")
    End Sub

    Private Sub ОтчетПоКлиентамToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОтчетПоКлиентамToolStripMenuItem.Click
        Form4.Show()
    End Sub

    Private Sub ОтчетПоКомпьютерамToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ОтчетПоКомпьютерамToolStripMenuItem.Click
        Form5.Show()
    End Sub
End Class
