Public Class AddTimer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedIndex = 0 Then
            TextBox1.Enabled = True
            Label2.Text = "Интервал:"
        Else
            TextBox1.Enabled = False
            Label2.Text = "Конечное время:"
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(ByVal sender As System.Object, ByVal e As System.Windows.Forms.LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        If ComboBox1.SelectedIndex = 0 Then
            MsgBox("Этот тип таймара позволяет пользователю установить интервал до срабатывания таймера.", , "Информация")
        Else
            MsgBox("Этот тип таймара позволяет пользователю установить время, в которое таймер сработает (равноценно будильнику).", , "Информация")
        End If
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If TextBox4.Text = "" Then Error 1
            Dim name_is_double As Boolean = False
            For i As Integer = 0 To Main.timer_name.Length - 1
                If Main.timer_name(i) = TextBox4.Text Then
                    name_is_double = True
                    Exit For
                End If
            Next
            If name_is_double = True Then Error 1
            If ComboBox1.SelectedIndex = 0 Then
                Dim time As UShort = CType(TextBox3.Text, UShort) + CType(TextBox2.Text, UShort) + CType(TextBox1.Text, UShort)
                If CType(TextBox2.Text, UShort) >= 60 Then Error 1
                If CType(TextBox1.Text, UShort) >= 60 Then Error 1
                If time = 0 Then Error 1
            Else
                Dim time As UShort = CType(TextBox3.Text, UShort) + CType(TextBox2.Text, UShort)
                If CType(TextBox2.Text, UShort) >= 60 Then Error 1
                If CType(TextBox3.Text, UShort) >= 24 Then Error 1
            End If
            Array.Resize(Main.timer_activ, Main.timer_activ.Length + 1)
            Array.Resize(Main.timer_interval, Main.timer_interval.Length + 1)
            Array.Resize(Main.timer_left, Main.timer_left.Length + 1)
            Array.Resize(Main.timer_name, Main.timer_name.Length + 1)
            Array.Resize(Main.timer_type, Main.timer_type.Length + 1)
            Main.timer_activ(Main.timer_activ.Length - 1) = False
            If ComboBox1.SelectedIndex = 0 Then
                Main.timer_interval(Main.timer_interval.Length - 1) = (CType(TextBox3.Text, UShort) * 3600) + (CType(TextBox2.Text, UShort) * 60) + CType(TextBox1.Text, UShort)
                Main.timer_left(Main.timer_left.Length - 1) = Main.timer_interval(Main.timer_interval.Length - 1)
            Else
                Main.timer_interval(Main.timer_interval.Length - 1) = CType(TextBox3.Text, UShort) & ":" & CType(TextBox2.Text, UShort)
                Main.timer_left(Main.timer_left.Length - 1) = 0
            End If
            Main.timer_name(Main.timer_name.Length - 1) = TextBox4.Text
            Main.timer_type(Main.timer_type.Length - 1) = ComboBox1.SelectedIndex
            Timer.Renovate_ListBox()
            Me.Close()
        Catch
            MsgBox("Неправильно заданы параметры таймера!", , "Ошибка")
        End Try
    End Sub
End Class
