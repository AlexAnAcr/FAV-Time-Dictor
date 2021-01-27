Public Class Timer
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        AddTimer.ComboBox1.SelectedIndex = 0
        AddTimer.TextBox1.Text = 0
        AddTimer.TextBox2.Text = 0
        AddTimer.TextBox3.Text = 0
        AddTimer.TextBox4.Text = ""
        AddTimer.Label2.Text = "Интервал:"
        AddTimer.ShowDialog()
    End Sub
    Public Sub Renovate_ListBox()
        ListBox1.Items.Clear()
        For i As Integer = 0 To Main.timer_activ.Length - 1
            Dim result As String = "Таймер: "
            If Main.timer_activ(i) = True Then
                result += "активен, "
            Else
                result += "неактивен, "
            End If
            result += "Имя: " & Main.timer_name(i) & ", "
            If Main.timer_type(i) = 0 Then
                Dim left As Integer = Main.timer_interval(i)
                Dim hours_left As Integer = Int((left / 60) / 60)
                left -= hours_left * 3600
                Dim minutes_left As Integer = Int(left / 60)
                left -= minutes_left * 60
                result += "Тип: промежуточный, Интервал: " & hours_left & " ч. " & minutes_left & " м. " & left & " с. "
            Else
                result += "Тип: конечный, Время: " + Main.timer_interval(i)
            End If
            ListBox1.Items.Add(result)
        Next
        Label3.Text = "0 ч. 0 м. 0 с. "
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
    End Sub
    Private Sub Timer_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Main.timer_showed = False
    End Sub
    Private Sub Timer_Shown(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Shown
        Renovate_ListBox()
        Button2.Enabled = False
        Button3.Enabled = False
        Button4.Enabled = False
        Button5.Enabled = False
        Main.timer_showed = True
        If Main.Button1.Text = "Активировать" Then
            PictureBox1.Visible = True
        Else
            PictureBox1.Visible = False
        End If
    End Sub
    Private Sub ListBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListBox1.SelectedIndexChanged
        If ListBox1.SelectedIndex > -1 Then
            If Main.timer_activ(ListBox1.SelectedIndex) = False Then
                Button2.Enabled = False
                Button3.Enabled = True
            Else
                Button2.Enabled = True
                Button3.Enabled = False
            End If
            If Main.timer_type(ListBox1.SelectedIndex) = 0 Then
                If Main.timer_left(ListBox1.SelectedIndex) = Main.timer_interval(ListBox1.SelectedIndex) Then
                    Button4.Enabled = False
                Else
                    Button4.Enabled = True
                End If
                Dim left As Integer = Main.timer_left(ListBox1.SelectedIndex)
                Dim hours_left As Integer = Int((left / 60) / 60)
                left -= hours_left * 3600
                Dim minutes_left As Integer = Int(left / 60)
                left -= minutes_left * 60
                Label3.Text = hours_left & " ч. " & minutes_left & " м. " & left & " с. "
            Else
                Button4.Enabled = False
                Label3.Text = Main.timer_interval(ListBox1.SelectedIndex).Split(":")(0) & " ч. " & Main.timer_interval(ListBox1.SelectedIndex).Split(":")(1) & " м. "
            End If
            Button5.Enabled = True
        Else
            Button2.Enabled = False
            Button3.Enabled = False
            Button4.Enabled = False
            Button5.Enabled = False
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Dim tolaunch As Boolean = True
        For Each i As String In TimerEnd.timers_list
            If i = Main.timer_name(ListBox1.SelectedIndex) Then
                tolaunch = False
            End If
        Next
        If tolaunch = True Then
            Main.timer_activ(ListBox1.SelectedIndex) = True
            Button2.Enabled = True
            Button3.Enabled = False
            Dim result As String = "Таймер: "
            If Main.timer_activ(ListBox1.SelectedIndex) = True Then
                result += "активен, "
            Else
                result += "неактивен, "
            End If
            result += "Имя: " & Main.timer_name(ListBox1.SelectedIndex) & ", "
            If Main.timer_type(ListBox1.SelectedIndex) = 0 Then
                Dim left As Integer = Main.timer_interval(ListBox1.SelectedIndex)
                Dim hours_left As Integer = Int((left / 60) / 60)
                left -= hours_left * 3600
                Dim minutes_left As Integer = Int(left / 60)
                left -= minutes_left * 60
                result += "Тип: промежуточный, Интервал: " & hours_left & " ч. " & minutes_left & " м. " & left & " с. "
            Else
                result += "Тип: конечный, Время: " + Main.timer_interval(ListBox1.SelectedIndex)
            End If
            ListBox1.Items.Item(ListBox1.SelectedIndex) = result
        Else
            MsgBox("Этот таймер ещё не получил ответ!", , "Ошибка")
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Main.timer_activ(ListBox1.SelectedIndex) = False
        Button2.Enabled = False
        Button3.Enabled = True
        Dim result As String = "Таймер: "
        If Main.timer_activ(ListBox1.SelectedIndex) = True Then
            result += "активен, "
        Else
            result += "неактивен, "
        End If
        result += "Имя: " & Main.timer_name(ListBox1.SelectedIndex) & ", "
        If Main.timer_type(ListBox1.SelectedIndex) = 0 Then
            Dim left As Integer = Main.timer_interval(ListBox1.SelectedIndex)
            Dim hours_left As Integer = Int((left / 60) / 60)
            left -= hours_left * 3600
            Dim minutes_left As Integer = Int(left / 60)
            left -= minutes_left * 60
            result += "Тип: промежуточный, Интервал: " & hours_left & " ч. " & minutes_left & " м. " & left & " с. "
        Else
            result += "Тип: конечный, Время: " + Main.timer_interval(ListBox1.SelectedIndex)
        End If
        ListBox1.Items.Item(ListBox1.SelectedIndex) = result
    End Sub
    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Main.timer_left(ListBox1.SelectedIndex) = Main.timer_interval(Main.timer_interval.Length - 1)
        Dim left As Integer = Main.timer_left(ListBox1.SelectedIndex)
        Dim hours_left As Integer = Int((left / 60) / 60)
        left -= hours_left * 3600
        Dim minutes_left As Integer = Int(left / 60)
        left -= minutes_left * 60
        Label3.Text = hours_left & " ч. " & minutes_left & " м. " & left & " с. "
        If Main.timer_left(ListBox1.SelectedIndex) = Main.timer_interval(ListBox1.SelectedIndex) Then
            Button4.Enabled = False
        Else
            Button4.Enabled = True
        End If
    End Sub
    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Dim todelete As Boolean = True
        For Each i As String In TimerEnd.timers_list
            If i = Main.timer_name(ListBox1.SelectedIndex) Then
                todelete = False
            End If
        Next
        If todelete = True Then
            If Main.timer_activ(ListBox1.SelectedIndex) = True Then
                Dim result As MsgBoxResult = MsgBox("Вы действительно хотите удалить этот таймер?" & Chr(10) & "Этот таймер активен.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Оповещение")
                If result = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            If Main.timer_activ.Length > 1 Then
                Main.timer_activ(ListBox1.SelectedIndex) = Main.timer_activ(Main.timer_activ.Length - 1)
                Main.timer_interval(ListBox1.SelectedIndex) = Main.timer_interval(Main.timer_interval.Length - 1)
                Main.timer_left(ListBox1.SelectedIndex) = Main.timer_left(Main.timer_left.Length - 1)
                Main.timer_name(ListBox1.SelectedIndex) = Main.timer_name(Main.timer_name.Length - 1)
                Main.timer_type(ListBox1.SelectedIndex) = Main.timer_type(Main.timer_type.Length - 1)
                Array.Resize(Main.timer_activ, Main.timer_activ.Length - 1)
                Array.Resize(Main.timer_interval, Main.timer_interval.Length - 1)
                Array.Resize(Main.timer_left, Main.timer_left.Length - 1)
                Array.Resize(Main.timer_name, Main.timer_name.Length - 1)
                Array.Resize(Main.timer_type, Main.timer_type.Length - 1)
            Else
                Array.Resize(Main.timer_activ, 0)
                Array.Resize(Main.timer_interval, 0)
                Array.Resize(Main.timer_left, 0)
                Array.Resize(Main.timer_name, 0)
                Array.Resize(Main.timer_type, 0)
            End If
            Renovate_ListBox()
        Else
            MsgBox("Этот таймер ещё не получил ответ!", , "Ошибка")
        End If
    End Sub
    Private Sub PictureBox1_MouseDown(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles PictureBox1.MouseDown
        MsgBox("Таймеры не будут работать пока диктор времени не активирован!", , "Информация")
    End Sub
    Private Sub ContextMenuTimer_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuTimer.Opening
        If ListBox1.SelectedIndex > -1 Then
            ContextMenuTimer.Items.Item(0).Enabled = True
            ContextMenuTimer.Items.Item(1).Enabled = True
        Else
            ContextMenuTimer.Items.Item(0).Enabled = False
            ContextMenuTimer.Items.Item(1).Enabled = False
        End If
    End Sub
    Private Sub ИзменитьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ИзменитьToolStripMenuItem.Click
        Dim todelete As Boolean = True
        For Each i As String In TimerEnd.timers_list
            If i = Main.timer_name(ListBox1.SelectedIndex) Then
                todelete = False
            End If
        Next
        If todelete = True Then
            If Main.timer_activ(ListBox1.SelectedIndex) = True Then
                Dim result As MsgBoxResult = MsgBox("Вы действительно хотите изменить этот таймер?" & Chr(10) & "Этот таймер активен.", MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Оповещение")
                If result = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            MsgBox("Во время пересоздания таймера старый удаляется. После завершения редактирования нажмите кнопку 'Добавить таймер', иначе таймер не будет сохранён.", MsgBoxStyle.OkOnly, "Оповещение")
            If Main.timer_type(ListBox1.SelectedIndex) = 0 Then
                Dim interval As Integer = Main.timer_interval(ListBox1.SelectedIndex)
                Dim hours_interval As Integer = Int((interval / 60) / 60)
                interval -= hours_interval * 3600
                Dim minutes_interval As Integer = Int(interval / 60)
                interval -= minutes_interval * 60
                AddTimer.ComboBox1.SelectedIndex = 0
                AddTimer.TextBox1.Text = interval
                AddTimer.TextBox2.Text = minutes_interval
                AddTimer.TextBox3.Text = hours_interval
                AddTimer.TextBox4.Text = Main.timer_name(ListBox1.SelectedIndex)
                AddTimer.Label2.Text = "Интервал:"
            Else
                AddTimer.ComboBox1.SelectedIndex = 1
                AddTimer.TextBox1.Text = 0
                AddTimer.TextBox2.Text = Main.timer_interval(ListBox1.SelectedIndex).Split(":")(1)
                AddTimer.TextBox3.Text = Main.timer_interval(ListBox1.SelectedIndex).Split(":")(0)
                AddTimer.TextBox4.Text = Main.timer_name(ListBox1.SelectedIndex)
                AddTimer.Label2.Text = "Конечное время:"
            End If
            If Main.timer_activ.Length > 1 Then
                Main.timer_activ(ListBox1.SelectedIndex) = Main.timer_activ(Main.timer_activ.Length - 1)
                Main.timer_interval(ListBox1.SelectedIndex) = Main.timer_interval(Main.timer_interval.Length - 1)
                Main.timer_left(ListBox1.SelectedIndex) = Main.timer_left(Main.timer_left.Length - 1)
                Main.timer_name(ListBox1.SelectedIndex) = Main.timer_name(Main.timer_name.Length - 1)
                Main.timer_type(ListBox1.SelectedIndex) = Main.timer_type(Main.timer_type.Length - 1)
                Array.Resize(Main.timer_activ, Main.timer_activ.Length - 1)
                Array.Resize(Main.timer_interval, Main.timer_interval.Length - 1)
                Array.Resize(Main.timer_left, Main.timer_left.Length - 1)
                Array.Resize(Main.timer_name, Main.timer_name.Length - 1)
                Array.Resize(Main.timer_type, Main.timer_type.Length - 1)
            Else
                Array.Resize(Main.timer_activ, 0)
                Array.Resize(Main.timer_interval, 0)
                Array.Resize(Main.timer_left, 0)
                Array.Resize(Main.timer_name, 0)
                Array.Resize(Main.timer_type, 0)
            End If
            Renovate_ListBox()
            AddTimer.ShowDialog()
        Else
            MsgBox("Этот таймер ещё не получил ответ!", , "Ошибка")
        End If
    End Sub
    Private Sub ДублироватьТаймерToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДублироватьТаймерToolStripMenuItem.Click
        If Main.timer_type(ListBox1.SelectedIndex) = 0 Then
            Dim interval As Integer = Main.timer_interval(ListBox1.SelectedIndex)
            Dim hours_interval As Integer = Int((interval / 60) / 60)
            interval -= hours_interval * 3600
            Dim minutes_interval As Integer = Int(interval / 60)
            interval -= minutes_interval * 60
            AddTimer.ComboBox1.SelectedIndex = 0
            AddTimer.TextBox1.Text = interval
            AddTimer.TextBox2.Text = minutes_interval
            AddTimer.TextBox3.Text = hours_interval
            AddTimer.TextBox4.Text = Main.timer_name(ListBox1.SelectedIndex)
            AddTimer.Label2.Text = "Интервал:"
        Else
            AddTimer.ComboBox1.SelectedIndex = 1
            AddTimer.TextBox1.Text = 0
            AddTimer.TextBox2.Text = Main.timer_interval(ListBox1.SelectedIndex).Split(":")(1)
            AddTimer.TextBox3.Text = Main.timer_interval(ListBox1.SelectedIndex).Split(":")(0)
            AddTimer.TextBox4.Text = Main.timer_name(ListBox1.SelectedIndex)
            AddTimer.Label2.Text = "Конечное время:"
        End If
        AddTimer.ShowDialog()
    End Sub
End Class
