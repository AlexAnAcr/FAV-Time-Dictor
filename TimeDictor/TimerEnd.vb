Public Class TimerEnd
    Public timers_list(0) As String, timers_number(0) As Integer
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        If ListBox1.SelectedIndex > -1 Then
            If timers_list.Length > 1 Then
                timers_list(ListBox1.SelectedIndex) = timers_list(timers_list.Length - 1)
                timers_number(ListBox1.SelectedIndex) = timers_number(timers_number.Length - 1)
                Array.Resize(timers_list, timers_list.Length - 1)
                Array.Resize(timers_number, timers_number.Length - 1)
                ListBox1.Items.Clear()
                For Each i As String In timers_list
                    ListBox1.Items.Add(i)
                Next
            Else
                timers_list(0) = ""
                timers_number(0) = 0
                ListBox1.Items.Clear()
                Main.player_StopPause_sound(True, True)
                Me.Close()
            End If
        End If
    End Sub
    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Array.Resize(timers_list, 1)
        Array.Resize(timers_number, 1)
        timers_list(0) = ""
        timers_number(0) = 0
        ListBox1.Items.Clear()
        Main.player_StopPause_sound(True, True)
        Me.Close()
    End Sub
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If ListBox1.SelectedIndex > -1 Then
            If timers_list.Length > 1 Then
                If Main.timer_activ.Length > 1 Then
                    Main.timer_activ(timers_number(ListBox1.SelectedIndex)) = Main.timer_activ(Main.timer_activ.Length - 1)
                    Main.timer_interval(timers_number(ListBox1.SelectedIndex)) = Main.timer_interval(Main.timer_interval.Length - 1)
                    Main.timer_left(timers_number(ListBox1.SelectedIndex)) = Main.timer_left(Main.timer_left.Length - 1)
                    Main.timer_name(timers_number(ListBox1.SelectedIndex)) = Main.timer_name(Main.timer_name.Length - 1)
                    Main.timer_type(timers_number(ListBox1.SelectedIndex)) = Main.timer_type(Main.timer_type.Length - 1)
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
                Timer.Renovate_ListBox()
                timers_list(ListBox1.SelectedIndex) = timers_list(timers_list.Length - 1)
                timers_number(ListBox1.SelectedIndex) = timers_number(timers_number.Length - 1)
                Array.Resize(timers_list, timers_list.Length - 1)
                Array.Resize(timers_number, timers_number.Length - 1)
                ListBox1.Items.Clear()
                For Each i As String In timers_list
                    ListBox1.Items.Add(i)
                Next
            Else
                If Main.timer_activ.Length > 1 Then
                    Main.timer_activ(timers_number(ListBox1.SelectedIndex)) = Main.timer_activ(Main.timer_activ.Length - 1)
                    Main.timer_interval(timers_number(ListBox1.SelectedIndex)) = Main.timer_interval(Main.timer_interval.Length - 1)
                    Main.timer_left(timers_number(ListBox1.SelectedIndex)) = Main.timer_left(Main.timer_left.Length - 1)
                    Main.timer_name(timers_number(ListBox1.SelectedIndex)) = Main.timer_name(Main.timer_name.Length - 1)
                    Main.timer_type(timers_number(ListBox1.SelectedIndex)) = Main.timer_type(Main.timer_type.Length - 1)
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
                timers_list(0) = ""
                timers_number(0) = 0
                ListBox1.Items.Clear()
                Timer.Renovate_ListBox()
                Main.player_StopPause_sound(True, True)
                Me.Close()
            End If
        End If
    End Sub
End Class