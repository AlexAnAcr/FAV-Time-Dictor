Imports System.ComponentModel
Public Class Main
    Dim end_program As Boolean = False
    Public WithEvents player_stand As New WMPLib.WindowsMediaPlayer, player_loop As New WMPLib.WindowsMediaPlayer
    Public timer_name(0) As String, timer_type(0) As Short, timer_interval(0) As String, timer_left(0) As Integer, timer_activ(0) As Boolean, timer_showed As Boolean = False, settings() As String
    Dim player_stand_play_list As New List(Of WMPLib.IWMPMedia)
#Region "rsp"
    Dim rsp_h As WMPLib.IWMPMedia, rsp_ha As WMPLib.IWMPMedia, rsp_hs As WMPLib.IWMPMedia, rsp_m As WMPLib.IWMPMedia, rsp_ma As WMPLib.IWMPMedia, rsp_ms As WMPLib.IWMPMedia, rsp_id As WMPLib.IWMPMedia, rsp_it As WMPLib.IWMPMedia, rsp_s As WMPLib.IWMPMedia, rsp_e As WMPLib.IWMPMedia, rsp_0 As WMPLib.IWMPMedia, rsp_1 As WMPLib.IWMPMedia, rsp_1a As WMPLib.IWMPMedia, rsp_2 As WMPLib.IWMPMedia, rsp_2a As WMPLib.IWMPMedia, rsp_3 As WMPLib.IWMPMedia, rsp_4 As WMPLib.IWMPMedia, rsp_5 As WMPLib.IWMPMedia, rsp_6 As WMPLib.IWMPMedia, rsp_7 As WMPLib.IWMPMedia, rsp_8 As WMPLib.IWMPMedia, rsp_9 As WMPLib.IWMPMedia, rsp_10 As WMPLib.IWMPMedia, rsp_11 As WMPLib.IWMPMedia, rsp_12 As WMPLib.IWMPMedia, rsp_13 As WMPLib.IWMPMedia, rsp_14 As WMPLib.IWMPMedia, rsp_15 As WMPLib.IWMPMedia, rsp_16 As WMPLib.IWMPMedia, rsp_17 As WMPLib.IWMPMedia, rsp_18 As WMPLib.IWMPMedia, rsp_19 As WMPLib.IWMPMedia, rsp_20 As WMPLib.IWMPMedia, rsp_30 As WMPLib.IWMPMedia, rsp_40 As WMPLib.IWMPMedia, rsp_50 As WMPLib.IWMPMedia
    Public msp_it As WMPLib.IWMPMedia, msp_e As WMPLib.IWMPMedia
#End Region
    Private Sub Main_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        If end_program = False Then
            e.Cancel = True
            end_program = True
            Me.Hide()
        End If
    End Sub
    Private Sub Main_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        ContextMenuNotify.Items(0).Enabled = False
        ComboBox1.SelectedIndex = 0
        ComboBox2.SelectedIndex = 0
        ComboBox3.SelectedIndex = 0
        ComboBox4.SelectedIndex = 0
        Try
            My.Computer.FileSystem.WriteAllText(Application.StartupPath & "/testing.tmp", "Test data.", False)
            My.Computer.FileSystem.DeleteFile(Application.StartupPath & "/testing.tmp")
        Catch
            NotifyIcon.Dispose()
            MsgBox("Диктор времени установлен некорректно!" & Chr(10) & "Возможная причина ошибки: Диктору времени для работы на данном компьютере необходимы права администратора (актуальна для Windows 7 и выше), проблемы совместимости с вашей версией или пакетом обновления Windows (вероятна для Windows 8 и выше)." & Chr(10) & "Совет: Попробуйте воспользоваться средствами исправления неполадок совместимости или предоставьте Диктору времени права администратора. Если вышеперечисленное не помогло, попробуйте переустановить программу.", , "Ошибка")
            end_program = True
            Me.Close()
        End Try
        Dim proc() As Process = Process.GetProcesses, my_way As String
        If My.Computer.FileSystem.FileExists(Application.StartupPath & "\td_instruction_19679879839.dat") = False Then
            my_way = Application.ExecutablePath
        Else
            my_way = Application.StartupPath & "\" & My.Computer.FileSystem.ReadAllText(Application.StartupPath & "\td_instruction_19679879839.dat", System.Text.Encoding.ASCII) & ".exe"
        End If
        If My.Computer.FileSystem.DirectoryExists(temp_way & "\temp_dir_0897595809067042") = False Then
            My.Computer.FileSystem.CreateDirectory(temp_way & "\temp_dir_0897595809067042")
            My.Computer.FileSystem.WriteAllText(temp_way & "\temp_dir_0897595809067042\td_j.tmp", my_way, False)
        Else
            If My.Computer.FileSystem.FileExists(temp_way & "\temp_dir_0897595809067042\td_j.tmp") = False Then
                My.Computer.FileSystem.WriteAllText(temp_way & "\temp_dir_0897595809067042\td_j.tmp", my_way, False)
            Else
                Dim td_j_dat As String = My.Computer.FileSystem.ReadAllText(temp_way & "\temp_dir_0897595809067042\td_j.tmp"), is_duble As Short = 0
                For Each i As Process In proc
                    Try
                        If i.MainModule.FileName.ToLower = my_way.ToLower Then
                            is_duble += 1
                        ElseIf i.MainModule.FileName.ToLower = td_j_dat.ToLower Then
                            is_duble = 2
                        End If
                        If is_duble = 2 Then
                            Exit For
                        End If
                    Catch
                    End Try
                Next
                If is_duble = 2 Then
                    NotifyIcon.Dispose()
                    MsgBox("Диктор времени уже запущен!" & Chr(10) & "Диктор времени находится в области уведомлений. Область уведомлений находится внизу справа (рядом с часами). Возможно, Диктор времени находится среди скрытых значков.", , "Ошибка")
                    end_program = True
                    Me.Close()
                Else
                    My.Computer.FileSystem.WriteAllText(temp_way & "\temp_dir_0897595809067042\td_j.tmp", my_way, False)
                End If
            End If
        End If
        temp_way &= "\temp_dir_0897595809067042"
        Dim way As String = Application.StartupPath & "/settings.dat"
        If My.Computer.FileSystem.FileExists(way) Then
            settings = IO.File.ReadAllLines(way)
        Else
            Array.Resize(settings, 6)
            settings(0) = "default"
            settings(1) = ""
            settings(2) = "default"
            settings(3) = ""
            settings(4) = "stop"
            settings(5) = "5"
            IO.File.WriteAllLines(way, settings)
        End If
        Array.Resize(timer_activ, 0)
        Array.Resize(timer_interval, 0)
        Array.Resize(timer_left, 0)
        Array.Resize(timer_name, 0)
        Array.Resize(timer_type, 0)
        Label8.Visible = True
        Button3.Visible = False
        ContextMenuNotify.Enabled = False
    End Sub
    Private Sub Main_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.UseWaitCursor = True
        back_work = True
        Start_copy.RunWorkerAsync()
        If settings(0) <> "default" Then
            If My.Computer.FileSystem.FileExists(settings(1)) Then
                msp_it = player_stand.newMedia(settings(1))
            Else
                settings(0) = "default"
                settings(1) = ""
            End If
        End If
        If settings(2) <> "default" Then
            If My.Computer.FileSystem.FileExists(settings(3)) Then
                msp_e = player_stand.newMedia(settings(3))
            Else
                settings(2) = "default"
                settings(3) = ""
            End If
        End If
    End Sub
    Dim temp_way As String = Environ("Temp"), back_work As Boolean = True
    Private Sub Start_copy_DoWork(sender As Object, e As System.ComponentModel.DoWorkEventArgs) Handles Start_copy.DoWork
        If back_work = True Then
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\h1.mp3", My.Resources.Resourses.hour, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\h2.mp3", My.Resources.Resourses.hour_a, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\h3.mp3", My.Resources.Resourses.hour_s, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\i1.mp3", My.Resources.Resourses.intro_dictor, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\i2.mp3", My.Resources.Resourses.intro_timer, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\m1.mp3", My.Resources.Resourses.minute, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\m2.mp3", My.Resources.Resourses.minute_a, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\m3.mp3", My.Resources.Resourses.minute_s, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\s1.mp3", My.Resources.Resourses.second_s, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\e1.mp3", My.Resources.Resourses.time_end, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\0n.mp3", My.Resources.Resourses._0, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\1n.mp3", My.Resources.Resourses._1, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\1an.mp3", My.Resources.Resourses._1_a, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\2n.mp3", My.Resources.Resourses._2, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\2an.mp3", My.Resources.Resourses._2_a, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\3n.mp3", My.Resources.Resourses._3, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\4n.mp3", My.Resources.Resourses._4, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\5n.mp3", My.Resources.Resourses._5, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\6n.mp3", My.Resources.Resourses._6, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\7n.mp3", My.Resources.Resourses._7, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\8n.mp3", My.Resources.Resourses._8, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\9n.mp3", My.Resources.Resourses._9, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\10n.mp3", My.Resources.Resourses._10, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\11n.mp3", My.Resources.Resourses._11, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\12n.mp3", My.Resources.Resourses._12, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\13n.mp3", My.Resources.Resourses._13, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\14n.mp3", My.Resources.Resourses._14, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\15n.mp3", My.Resources.Resourses._15, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\16n.mp3", My.Resources.Resourses._16, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\17n.mp3", My.Resources.Resourses._17, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\18n.mp3", My.Resources.Resourses._18, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\19n.mp3", My.Resources.Resourses._19, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\20n.mp3", My.Resources.Resourses._20, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\30n.mp3", My.Resources.Resourses._30, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\40n.mp3", My.Resources.Resourses._40, False)
            My.Computer.FileSystem.WriteAllBytes(temp_way & "\50n.mp3", My.Resources.Resourses._50, False)
            rsp_0 = player_stand.newMedia(temp_way & "\0n.mp3")
            rsp_1 = player_stand.newMedia(temp_way & "\0n.mp3")
            rsp_10 = player_stand.newMedia(temp_way & "\10n.mp3")
            rsp_11 = player_stand.newMedia(temp_way & "\11n.mp3")
            rsp_12 = player_stand.newMedia(temp_way & "\12n.mp3")
            rsp_13 = player_stand.newMedia(temp_way & "\13n.mp3")
            rsp_14 = player_stand.newMedia(temp_way & "\14n.mp3")
            rsp_15 = player_stand.newMedia(temp_way & "\15n.mp3")
            rsp_16 = player_stand.newMedia(temp_way & "\16n.mp3")
            rsp_17 = player_stand.newMedia(temp_way & "\17n.mp3")
            rsp_18 = player_stand.newMedia(temp_way & "\18n.mp3")
            rsp_19 = player_stand.newMedia(temp_way & "\19n.mp3")
            rsp_1a = player_stand.newMedia(temp_way & "\1an.mp3")
            rsp_2 = player_stand.newMedia(temp_way & "\2n.mp3")
            rsp_20 = player_stand.newMedia(temp_way & "\20n.mp3")
            rsp_2a = player_stand.newMedia(temp_way & "\2an.mp3")
            rsp_3 = player_stand.newMedia(temp_way & "\3n.mp3")
            rsp_30 = player_stand.newMedia(temp_way & "\30n.mp3")
            rsp_4 = player_stand.newMedia(temp_way & "\4n.mp3")
            rsp_40 = player_stand.newMedia(temp_way & "\40n.mp3")
            rsp_5 = player_stand.newMedia(temp_way & "\5n.mp3")
            rsp_50 = player_stand.newMedia(temp_way & "\50n.mp3")
            rsp_6 = player_stand.newMedia(temp_way & "\6n.mp3")
            rsp_7 = player_stand.newMedia(temp_way & "\7n.mp3")
            rsp_8 = player_stand.newMedia(temp_way & "\8n.mp3")
            rsp_9 = player_stand.newMedia(temp_way & "\9n.mp3")
            rsp_e = player_stand.newMedia(temp_way & "\e1.mp3")
            rsp_h = player_stand.newMedia(temp_way & "\h1.mp3")
            rsp_ha = player_stand.newMedia(temp_way & "\h2.mp3")
            rsp_hs = player_stand.newMedia(temp_way & "\h3.mp3")
            rsp_id = player_stand.newMedia(temp_way & "\i1.mp3")
            rsp_it = player_stand.newMedia(temp_way & "\i2.mp3")
            rsp_m = player_stand.newMedia(temp_way & "\m1.mp3")
            rsp_ma = player_stand.newMedia(temp_way & "\m2.mp3")
            rsp_ms = player_stand.newMedia(temp_way & "\m3.mp3")
            rsp_s = player_stand.newMedia(temp_way & "\s1.mp3")
        Else
            For Each i As String In My.Computer.FileSystem.GetFiles(temp_way)
                My.Computer.FileSystem.DeleteFile(i)
            Next
            My.Computer.FileSystem.DeleteDirectory(temp_way, FileIO.DeleteDirectoryOption.DeleteAllContents)
        End If
    End Sub
    Private Sub Start_copy_RunWorkerCompleted(sender As Object, e As RunWorkerCompletedEventArgs) Handles Start_copy.RunWorkerCompleted
        If back_work = True Then
            Button3.Visible = True
            Label8.Visible = False
            ContextMenuNotify.Enabled = True
            Me.UseWaitCursor = False
        Else
            end_program = True
            Me.Close()
        End If
    End Sub
    Private Sub ВыйтиToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ВыйтиToolStripMenuItem.Click
        Dim activ_timers As Integer = 0
        For Each i As String In timer_activ
            If i = True Then
                activ_timers += 1
            End If
        Next
        If activ_timers > 0 Then
            Dim result As MsgBoxResult = MsgBox("Вы действительно хотите выйти?" & Chr(10) & "Обнаружено активных таймеров: " & activ_timers, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Оповещение")
            If result = MsgBoxResult.No Then
                Exit Sub
            End If
        End If
        NotifyIcon.Dispose()
        Button3.Visible = False
        Label8.Visible = True
        Label8.Text = "Завершение работы..."
        Me.UseWaitCursor = True
        Me.Show()
        back_work = False
        Start_copy.RunWorkerAsync()
    End Sub
    Private Sub ОткрытьОкноНастроекToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ОткрытьОкноНастроекToolStripMenuItem.Click
        Me.Show()
        end_program = False
    End Sub
    Private Sub NotifyIcon_MouseClick(ByVal sender As Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles NotifyIcon.MouseClick
        ContextMenuNotify.Show(MousePosition.X - ContextMenuNotify.Width, MousePosition.Y - ContextMenuNotify.Height)
    End Sub
    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked Then
            ComboBox1.Enabled = True
        Else
            ComboBox1.Enabled = False
        End If
        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Then
            ContextMenuNotify.Items(0).Enabled = True
            Button1.Enabled = True
        Else
            ContextMenuNotify.Items(0).Enabled = False
            Button1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox2.CheckedChanged
        If CheckBox2.Checked Then
            ComboBox2.Enabled = True
        Else
            ComboBox2.Enabled = False
        End If
        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Then
            ContextMenuNotify.Items(0).Enabled = True
            Button1.Enabled = True
        Else
            ContextMenuNotify.Items(0).Enabled = False
            Button1.Enabled = False
        End If
    End Sub
    Private Sub CheckBox3_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox3.CheckedChanged
        If CheckBox3.Checked Then
            ComboBox3.Enabled = True
            CheckBox4.Enabled = False
        Else
            ComboBox3.Enabled = False
            CheckBox4.Enabled = True
        End If
        If CheckBox1.Checked Or CheckBox2.Checked Or CheckBox3.Checked Then
            ContextMenuNotify.Items(0).Enabled = True
            Button1.Enabled = True
        Else
            ContextMenuNotify.Items(0).Enabled = False
            Button1.Enabled = False
        End If
    End Sub
    Dim date_start As Date, mode As Short = 0, data(2) As Short
#Region "Activ/Deactiv buttons"
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If mode = 0 Then
            If ComboBox4.SelectedIndex = 1 Then
                Try
                    Dim time_dat(3) As UShort
                    time_dat(0) = TextBox1.Text
                    time_dat(1) = TextBox3.Text
                    time_dat(2) = TextBox2.Text
                    time_dat(3) = TextBox4.Text
                    If time_dat(0) > 23 Then Error 1
                    If time_dat(1) > 23 Then Error 1
                    If time_dat(2) > 59 Then Error 1
                    If time_dat(3) > 59 Then Error 1
                    If time_dat(0) = time_dat(1) And time_dat(2) = time_dat(3) Then Error 1
                Catch
                    MsgBox("Неправильно задано время начала дикции и(или) конца!", , "Ошибка")
                    Exit Sub
                End Try
            End If
            mode = 1
            ContextMenuNotify.Items(0).Text = "Деактивировать"
            Button1.Text = "Деактивировать"
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
            TextBox1.Enabled = False
            TextBox3.Enabled = False
            TextBox2.Enabled = False
            TextBox4.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            Button3.Enabled = False
            If ComboBox1.SelectedIndex = 0 Then
                data(0) = 1
            ElseIf ComboBox1.SelectedIndex = 1 Then
                data(0) = 2
            ElseIf ComboBox1.SelectedIndex = 2 Then
                data(0) = 5
            End If
            If ComboBox2.SelectedIndex = 0 Then
                data(1) = 1
            ElseIf ComboBox2.SelectedIndex = 1 Then
                data(1) = 2
            ElseIf ComboBox2.SelectedIndex = 2 Then
                data(1) = 5
            ElseIf ComboBox2.SelectedIndex = 3 Then
                data(1) = 10
            ElseIf ComboBox2.SelectedIndex = 4 Then
                data(1) = 20
            ElseIf ComboBox2.SelectedIndex = 5 Then
                data(1) = 30
            End If
            If ComboBox3.SelectedIndex = 0 Then
                data(2) = 10
            ElseIf ComboBox3.SelectedIndex = 1 Then
                data(2) = 20
            ElseIf ComboBox3.SelectedIndex = 2 Then
                data(2) = 30
            End If
            hour = -1
            minute = -1
            date_start = My.Computer.Clock.LocalTime
            player_stand.settings.volume = 100
            player_loop.settings.volume = 100
            Clock_Start.Start()
            Timer.PictureBox1.Visible = False
        Else
            Dim activ_timers As Integer = 0
            For Each i As String In timer_activ
                If i = True Then
                    activ_timers += 1
                End If
            Next
            If activ_timers > 0 Then
                Dim result As MsgBoxResult = MsgBox("Вы действительно хотите деактивировать Диктор времени?" & Chr(10) & "Обнаружено активных таймеров: " & activ_timers, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Оповещение")
                If result = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Clock_Start.Stop()
            Clock_Timer.Stop()
            player_StopPause_sound(False, True)
            mode = 0
            ContextMenuNotify.Items(0).Text = "Активировать"
            Button1.Text = "Активировать"
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            ComboBox4.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            Button3.Enabled = True
            If ComboBox4.SelectedIndex = 0 Then
                TextBox1.Enabled = False
                TextBox3.Enabled = False
                TextBox2.Enabled = False
                TextBox4.Enabled = False
            Else
                TextBox1.Enabled = True
                TextBox3.Enabled = True
                TextBox2.Enabled = True
                TextBox4.Enabled = True
            End If
            If CheckBox1.Checked Then
                ComboBox1.Enabled = True
            Else
                ComboBox1.Enabled = False
            End If
            If CheckBox2.Checked Then
                ComboBox2.Enabled = True
            Else
                ComboBox2.Enabled = False
            End If
            If CheckBox3.Checked Then
                ComboBox3.Enabled = True
                CheckBox4.Enabled = False
            Else
                ComboBox3.Enabled = False
                CheckBox4.Enabled = True
            End If
            Timer.PictureBox1.Visible = True
        End If
    End Sub
    Private Sub ДеактивироватьToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ДеактивироватьToolStripMenuItem.Click
        If mode = 0 Then
            If ComboBox4.SelectedIndex = 1 Then
                Try
                    Dim time_dat(3) As UShort
                    time_dat(0) = TextBox1.Text
                    time_dat(1) = TextBox3.Text
                    time_dat(2) = TextBox2.Text
                    time_dat(3) = TextBox4.Text
                    If time_dat(0) > 23 Then Error 1
                    If time_dat(1) > 23 Then Error 1
                    If time_dat(2) > 59 Then Error 1
                    If time_dat(3) > 59 Then Error 1
                    If time_dat(0) = time_dat(1) And time_dat(2) = time_dat(3) Then Error 1
                Catch
                    MsgBox("Неправильно задано время начала дикции и(или) конца!", , "Ошибка")
                    Exit Sub
                End Try
            End If
            mode = 1
            ContextMenuNotify.Items(0).Text = "Деактивировать"
            Button1.Text = "Деактивировать"
            CheckBox1.Enabled = False
            CheckBox2.Enabled = False
            CheckBox3.Enabled = False
            ComboBox1.Enabled = False
            ComboBox2.Enabled = False
            ComboBox3.Enabled = False
            ComboBox4.Enabled = False
            TextBox1.Enabled = False
            TextBox3.Enabled = False
            TextBox2.Enabled = False
            TextBox4.Enabled = False
            CheckBox4.Enabled = False
            CheckBox5.Enabled = False
            Button3.Enabled = False
            If ComboBox1.SelectedIndex = 0 Then
                data(0) = 1
            ElseIf ComboBox1.SelectedIndex = 1 Then
                data(0) = 2
            ElseIf ComboBox1.SelectedIndex = 2 Then
                data(0) = 5
            End If
            If ComboBox2.SelectedIndex = 0 Then
                data(1) = 1
            ElseIf ComboBox2.SelectedIndex = 1 Then
                data(1) = 2
            ElseIf ComboBox2.SelectedIndex = 2 Then
                data(1) = 5
            ElseIf ComboBox2.SelectedIndex = 3 Then
                data(1) = 10
            ElseIf ComboBox2.SelectedIndex = 4 Then
                data(1) = 20
            ElseIf ComboBox2.SelectedIndex = 5 Then
                data(1) = 30
            End If
            If ComboBox3.SelectedIndex = 0 Then
                data(2) = 10
            ElseIf ComboBox3.SelectedIndex = 1 Then
                data(2) = 20
            ElseIf ComboBox3.SelectedIndex = 2 Then
                data(2) = 30
            End If
            hour = -1
            minute = -1
            date_start = My.Computer.Clock.LocalTime
            Clock_Start.Start()
            Timer.PictureBox1.Visible = False
            player_stand.settings.volume = 100
            player_loop.settings.volume = 100
        Else
            Dim activ_timers As Integer = 0
            For Each i As String In timer_activ
                If i = True Then
                    activ_timers += 1
                End If
            Next
            If activ_timers > 0 Then
                Dim result As MsgBoxResult = MsgBox("Вы действительно хотите деактивировать Диктор времени?" & Chr(10) & "Обнаружено активных таймеров: " & activ_timers, MsgBoxStyle.YesNo Or MsgBoxStyle.DefaultButton2, "Оповещение")
                If result = MsgBoxResult.No Then
                    Exit Sub
                End If
            End If
            Clock_Start.Stop()
            Clock_Timer.Stop()
            player_StopPause_sound(False, True)
            mode = 0
            ContextMenuNotify.Items(0).Text = "Активировать"
            Button1.Text = "Активировать"
            CheckBox1.Enabled = True
            CheckBox2.Enabled = True
            CheckBox3.Enabled = True
            ComboBox4.Enabled = True
            CheckBox4.Enabled = True
            CheckBox5.Enabled = True
            Button3.Enabled = True
            If ComboBox4.SelectedIndex = 0 Then
                TextBox1.Enabled = False
                TextBox3.Enabled = False
                TextBox2.Enabled = False
                TextBox4.Enabled = False
            Else
                TextBox1.Enabled = True
                TextBox3.Enabled = True
                TextBox2.Enabled = True
                TextBox4.Enabled = True
            End If
            If CheckBox1.Checked Then
                ComboBox1.Enabled = True
            Else
                ComboBox1.Enabled = False
            End If
            If CheckBox2.Checked Then
                ComboBox2.Enabled = True
            Else
                ComboBox2.Enabled = False
            End If
            If CheckBox3.Checked Then
                ComboBox3.Enabled = True
                CheckBox4.Enabled = False
            Else
                ComboBox3.Enabled = False
                CheckBox4.Enabled = True
            End If
            Timer.PictureBox1.Visible = True
        End If
    End Sub
#End Region
    Dim loop_playing As Boolean = False, scenary As Short = 0, play_state_ps As Short = 0, from_pause As Boolean = False
    Public Sub player_loop_state_changed() Handles player_loop.PlayStateChange
        If (player_loop.status = "Остановлено" Or player_loop.status = "Завершено") And (loop_playing = True) Then
            If scenary = 0 Then
                player_loop.controls.play()
            ElseIf scenary = 1 Then
                player_loop.currentPlaylist.clear()
                If settings(2) = "default" Then
                    player_loop.currentPlaylist.insertItem(0, rsp_e)
                Else
                    player_loop.currentPlaylist.insertItem(0, msp_e)
                End If
                player_loop.controls.play()
                scenary = 0
            End If
        End If
    End Sub
    Public Sub player_stand_state_changed() Handles player_stand.PlayStateChange
        If (player_stand.playState = 1) Then
            Wait_timer_diction.Start()
        End If
    End Sub
    Private Sub Wait_timer_diction_Tick(sender As Object, e As EventArgs) Handles Wait_timer_diction.Tick
        Wait_timer_diction.Stop()
        If play_state_ps < player_stand_play_list.Count Then
            player_stand.controls.stop()
            player_stand.currentMedia = player_stand_play_list.Item(play_state_ps)
            player_stand.controls.play()
            play_state_ps += 1
        Else
            from_pause = False
            If TimerEnd.timers_list(0) <> "" Then
                If settings(4) = "stop" Then
                    player_Play_sound(True)
                ElseIf settings(4) = "mute" Then
                    player_Change_volume(True, 10)
                End If
            End If
        End If
    End Sub
    Public Sub player_Play_sound(loop_livel As Boolean)
        If loop_livel Then
            loop_playing = True
            player_loop.controls.play()
        Else
            If from_pause = True Then
                player_stand.controls.play()
            Else
                player_stand.currentMedia = player_stand_play_list.Item(0)
                player_stand.controls.play()
                play_state_ps = 1
            End If
        End If
    End Sub
    Public Sub player_StopPause_sound(loop_livel As Boolean, is_stop As Boolean)
        If is_stop Then
            If loop_livel Then
                loop_playing = False
                player_loop.controls.stop()
            Else
                player_stand.controls.stop()
                player_stand_play_list.Clear()
                play_state_ps = 0
                from_pause = False
            End If
        Else
            If loop_livel Then
                loop_playing = False
                player_loop.controls.pause()
            Else
                player_stand.controls.pause()
                from_pause = True
            End If
        End If
    End Sub
    Public Sub player_Change_volume(loop_livel As Boolean, volume_livel As UShort)
        If loop_livel Then
            player_loop.settings.volume = volume_livel * 10
        Else
            player_stand.settings.volume = volume_livel * 10
        End If
    End Sub
    Private Sub Clock_Start_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock_Start.Tick
        If date_start <> My.Computer.Clock.LocalTime Then
            Clock_Start.Stop()
            Clock_Timer.Start()
        End If
    End Sub
    Dim hour As Short = -1, minute As Short = -1
    Private Sub Clock_Timer_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Clock_Timer.Tick
        Dim time As Date = My.Computer.Clock.LocalTime
#Region "Timer action"
        For i As Integer = 0 To timer_activ.Length - 1
            If timer_activ(i) = True Then
                If timer_type(i) = 0 Then
                    If timer_left(i) = 1 Then
                        Timer.Label3.Text = "0 ч. 0 м. 0 с. "
                        timer_activ(i) = False
                        timer_left(i) = timer_interval(i)
                        If TimerEnd.timers_list(0) = "" Then
                            TimerEnd.timers_list(0) = timer_name(i)
                            TimerEnd.timers_number(0) = i
                        Else
                            Array.Resize(TimerEnd.timers_list, TimerEnd.timers_list.Length + 1)
                            Array.Resize(TimerEnd.timers_number, TimerEnd.timers_number.Length + 1)
                            TimerEnd.timers_list(TimerEnd.timers_number.Length - 1) = timer_name(i)
                            TimerEnd.timers_number(TimerEnd.timers_number.Length - 1) = i
                        End If
                        TimerEnd.ListBox1.Items.Add(timer_name(i))
                        Timer.Renovate_ListBox()
                        If loop_playing = False Then
                            If CheckBox5.Checked Then
                                player_loop.currentPlaylist.clear()
                                If settings(0) = "default" Then
                                    player_loop.currentPlaylist.insertItem(0, rsp_it)
                                Else
                                    player_loop.currentPlaylist.insertItem(0, msp_it)
                                End If
                                scenary = 1
                            Else
                                player_loop.currentPlaylist.clear()
                                If settings(2) = "default" Then
                                    player_loop.currentPlaylist.insertItem(0, rsp_e)
                                Else
                                    player_loop.currentPlaylist.insertItem(0, msp_e)
                                End If
                                scenary = 0
                            End If
                            player_Play_sound(True)
                        End If
                        TimerEnd.Show()
                    Else
                        timer_left(i) -= 1
                        If timer_showed = True Then
                            If Timer.ListBox1.SelectedIndex > -1 Then
                                If timer_type(Timer.ListBox1.SelectedIndex) = 0 Then
                                    Dim left As Integer = timer_left(Timer.ListBox1.SelectedIndex)
                                    Dim hours_left As Integer = Int((left / 60) / 60)
                                    left -= hours_left * 3600
                                    Dim minutes_left As Integer = Int(left / 60)
                                    left -= minutes_left * 60
                                    Timer.Label3.Text = hours_left & " ч. " & minutes_left & " м. " & left & " с. "
                                    If timer_left(Timer.ListBox1.SelectedIndex) = timer_interval(Timer.ListBox1.SelectedIndex) And timer_type(Timer.ListBox1.SelectedIndex) = 0 Then
                                        Timer.Button4.Enabled = False
                                    Else
                                        Timer.Button4.Enabled = True
                                    End If
                                End If
                            End If
                        End If
                    End If
                Else
                    If time.Hour = timer_interval(i).Split(":")(0) And time.Minute = timer_interval(i).Split(":")(1) Then
                        timer_activ(i) = False
                        If TimerEnd.timers_list(0) = "" Then
                            TimerEnd.timers_list(0) = timer_name(i)
                            TimerEnd.timers_number(0) = i
                        Else
                            Array.Resize(TimerEnd.timers_list, TimerEnd.timers_list.Length + 1)
                            Array.Resize(TimerEnd.timers_number, TimerEnd.timers_number.Length + 1)
                            TimerEnd.timers_list(TimerEnd.timers_number.Length - 1) = timer_name(i)
                            TimerEnd.timers_number(TimerEnd.timers_number.Length - 1) = i
                        End If
                        TimerEnd.ListBox1.Items.Add(timer_name(i))
                        Timer.Renovate_ListBox()
                        If loop_playing = False Then
                            If CheckBox5.Checked Then
                                player_loop.currentPlaylist.clear()
                                If settings(0) = "default" Then
                                    player_loop.currentPlaylist.insertItem(0, rsp_it)
                                Else
                                    player_loop.currentPlaylist.insertItem(0, msp_it)
                                End If
                                scenary = 1
                            Else
                                player_loop.currentPlaylist.clear()
                                If settings(2) = "default" Then
                                    player_loop.currentPlaylist.insertItem(0, rsp_e)
                                Else
                                    player_loop.currentPlaylist.insertItem(0, msp_e)
                                End If
                                scenary = 0
                            End If
                            player_Play_sound(True)
                        End If
                        TimerEnd.Show()
                    End If
                End If
            End If
        Next
#End Region
#Region "Diction"
        If settings(4) = "no time" And loop_playing = True Then
            Exit Sub
        End If
        If ComboBox4.SelectedIndex = 0 Then
            diction(time)
        Else
            Dim time_dat(3) As UShort
            time_dat(0) = TextBox1.Text 'Hour OF
            time_dat(1) = TextBox3.Text 'Hour TO
            time_dat(2) = TextBox2.Text 'Minute OF
            time_dat(3) = TextBox4.Text 'Minute TO
            If (time_dat(1) > time_dat(0)) Or (time_dat(0) = time_dat(1) And time_dat(3) > time_dat(2)) Then
                If ((time.Hour > time_dat(0)) Or (time.Hour = time_dat(0) And time.Minute >= time_dat(2))) And ((time.Hour < time_dat(1)) Or (time.Hour = time_dat(1) And time.Minute < time_dat(3))) Then
                    diction(time)
                End If
            ElseIf (time_dat(1) < time_dat(0)) Or (time_dat(0) = time_dat(1) And time_dat(3) < time_dat(2)) Then
                If ((time.Hour > time_dat(0)) Or (time.Hour = time_dat(0) And time.Minute >= time_dat(2))) Or ((time.Hour < time_dat(1)) Or (time.Hour = time_dat(1) And time.Minute < time_dat(3))) Then
                    diction(time)
                End If
            End If
        End If
#End Region
    End Sub
#Region "Diction function"
    Private Sub diction(time As Date)
        If CheckBox1.Checked And CheckBox2.Checked = False And CheckBox3.Checked = False Then
            If Math.IEEERemainder(time.Hour, data(0)) = 0 And hour <> time.Hour Then
                hour = time.Hour
                If settings(4) = "stop" And loop_playing = True Then
                    player_StopPause_sound(True, False)
                ElseIf settings(4) = "mute" And loop_playing = True Then
                    player_Change_volume(True, settings(5))
                End If
                player_stand_play_list.Clear()
                If CheckBox4.Checked = True Then
                    player_stand_play_list.Add(rsp_id)
                End If
                diction_atp_hour()
                player_Play_sound(False)
            End If
        End If
        If CheckBox2.Checked And CheckBox3.Checked = False Then
            If Math.IEEERemainder(time.Minute, data(1)) = 0 And minute <> time.Minute Then
                If settings(4) = "stop" And loop_playing = True Then
                    player_StopPause_sound(True, False)
                ElseIf settings(4) = "mute" And loop_playing = True Then
                    player_Change_volume(True, settings(5))
                End If
                player_stand_play_list.Clear()
                If CheckBox4.Checked = True Then
                    player_stand_play_list.Add(rsp_id)
                End If
                If CheckBox1.Checked And Math.IEEERemainder(time.Hour, data(0)) = 0 Then
                    hour = time.Hour
                    diction_atp_hour()
                End If
                minute = time.Minute
                diction_atp_minute()
                player_Play_sound(False)
            End If
        End If
        If CheckBox3.Checked Then
            If Math.IEEERemainder(time.Second, data(2)) = 0 Then
                If settings(4) = "stop" And loop_playing = True Then
                    player_StopPause_sound(True, False)
                ElseIf settings(4) = "mute" And loop_playing = True Then
                    player_Change_volume(True, settings(5))
                End If
                player_stand_play_list.Clear()
                If CheckBox1.Checked And Math.IEEERemainder(time.Hour, data(0)) = 0 Then
                    hour = time.Hour
                    diction_atp_hour()
                End If
                If CheckBox2.Checked And Math.IEEERemainder(time.Minute, data(1)) = 0 Then
                    minute = time.Minute
                    diction_atp_minute()
                End If
                Dim second As Short = time.Second
                diction_atp_seconds(second)
                player_Play_sound(False)
            End If
        End If
    End Sub
    Private Sub diction_atp_hour()
        If hour.ToString.Length = 1 Then
            If hour = 0 Then
                player_stand_play_list.Add(rsp_0)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 1 Then
                player_stand_play_list.Add(rsp_1)
                player_stand_play_list.Add(rsp_h)
            ElseIf hour = 2 Then
                player_stand_play_list.Add(rsp_2)
                player_stand_play_list.Add(rsp_ha)
            ElseIf hour = 3 Then
                player_stand_play_list.Add(rsp_3)
                player_stand_play_list.Add(rsp_ha)
            ElseIf hour = 4 Then
                player_stand_play_list.Add(rsp_4)
                player_stand_play_list.Add(rsp_ha)
            ElseIf hour = 5 Then
                player_stand_play_list.Add(rsp_5)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 6 Then
                player_stand_play_list.Add(rsp_6)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 7 Then
                player_stand_play_list.Add(rsp_7)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 8 Then
                player_stand_play_list.Add(rsp_8)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 9 Then
                player_stand_play_list.Add(rsp_9)
                player_stand_play_list.Add(rsp_hs)
            End If
        Else
            If hour = 10 Then
                player_stand_play_list.Add(rsp_10)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 11 Then
                player_stand_play_list.Add(rsp_11)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 12 Then
                player_stand_play_list.Add(rsp_12)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 13 Then
                player_stand_play_list.Add(rsp_13)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 14 Then
                player_stand_play_list.Add(rsp_14)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 15 Then
                player_stand_play_list.Add(rsp_15)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 16 Then
                player_stand_play_list.Add(rsp_16)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 17 Then
                player_stand_play_list.Add(rsp_17)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 18 Then
                player_stand_play_list.Add(rsp_18)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 19 Then
                player_stand_play_list.Add(rsp_19)
                player_stand_play_list.Add(rsp_hs)
            ElseIf hour = 20 Then
                player_stand_play_list.Add(rsp_20)
                player_stand_play_list.Add(rsp_hs)
            Else
                Dim two_simvol As Short = Mid(hour.ToString, 2, 1)
                If two_simvol = 1 Then
                    player_stand_play_list.Add(rsp_20)
                    player_stand_play_list.Add(rsp_1)
                    player_stand_play_list.Add(rsp_h)
                ElseIf two_simvol = 2 Then
                    player_stand_play_list.Add(rsp_20)
                    player_stand_play_list.Add(rsp_2)
                    player_stand_play_list.Add(rsp_ha)
                ElseIf two_simvol = 3 Then
                    player_stand_play_list.Add(rsp_20)
                    player_stand_play_list.Add(rsp_3)
                    player_stand_play_list.Add(rsp_ha)
                End If
            End If
        End If
    End Sub
    Private Sub diction_atp_minute()
        If minute.ToString.Length = 1 Then
            If minute = 0 Then
                player_stand_play_list.Add(rsp_0)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 1 Then
                player_stand_play_list.Add(rsp_1a)
                player_stand_play_list.Add(rsp_m)
            ElseIf minute = 2 Then
                player_stand_play_list.Add(rsp_2a)
                player_stand_play_list.Add(rsp_ma)
            ElseIf minute = 3 Then
                player_stand_play_list.Add(rsp_3)
                player_stand_play_list.Add(rsp_ma)
            ElseIf minute = 4 Then
                player_stand_play_list.Add(rsp_4)
                player_stand_play_list.Add(rsp_ma)
            ElseIf minute = 5 Then
                player_stand_play_list.Add(rsp_5)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 6 Then
                player_stand_play_list.Add(rsp_6)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 7 Then
                player_stand_play_list.Add(rsp_7)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 8 Then
                player_stand_play_list.Add(rsp_8)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 9 Then
                player_stand_play_list.Add(rsp_9)
                player_stand_play_list.Add(rsp_ms)
            End If
        Else
            If minute = 10 Then
                player_stand_play_list.Add(rsp_10)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 11 Then
                player_stand_play_list.Add(rsp_11)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 12 Then
                player_stand_play_list.Add(rsp_12)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 13 Then
                player_stand_play_list.Add(rsp_13)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 14 Then
                player_stand_play_list.Add(rsp_14)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 15 Then
                player_stand_play_list.Add(rsp_15)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 16 Then
                player_stand_play_list.Add(rsp_16)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 17 Then
                player_stand_play_list.Add(rsp_17)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 18 Then
                player_stand_play_list.Add(rsp_18)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 19 Then
                player_stand_play_list.Add(rsp_19)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 20 Then
                player_stand_play_list.Add(rsp_20)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 30 Then
                player_stand_play_list.Add(rsp_30)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 40 Then
                player_stand_play_list.Add(rsp_40)
                player_stand_play_list.Add(rsp_ms)
            ElseIf minute = 50 Then
                player_stand_play_list.Add(rsp_50)
                player_stand_play_list.Add(rsp_ms)
            Else
                Dim one_simvol As Short = Mid(minute.ToString, 1, 1)
                Dim two_simvol As Short = Mid(minute.ToString, 2, 1)
                If one_simvol = 2 Then
                    player_stand_play_list.Add(rsp_20)
                ElseIf one_simvol = 3 Then
                    player_stand_play_list.Add(rsp_30)
                ElseIf one_simvol = 4 Then
                    player_stand_play_list.Add(rsp_40)
                ElseIf one_simvol = 5 Then
                    player_stand_play_list.Add(rsp_50)
                End If
                If two_simvol = 1 Then
                    player_stand_play_list.Add(rsp_1a)
                    player_stand_play_list.Add(rsp_m)
                ElseIf two_simvol = 2 Then
                    player_stand_play_list.Add(rsp_2a)
                    player_stand_play_list.Add(rsp_ma)
                ElseIf two_simvol = 3 Then
                    player_stand_play_list.Add(rsp_3)
                    player_stand_play_list.Add(rsp_ma)
                ElseIf two_simvol = 4 Then
                    player_stand_play_list.Add(rsp_4)
                    player_stand_play_list.Add(rsp_ma)
                ElseIf two_simvol = 5 Then
                    player_stand_play_list.Add(rsp_5)
                    player_stand_play_list.Add(rsp_ms)
                ElseIf two_simvol = 6 Then
                    player_stand_play_list.Add(rsp_6)
                    player_stand_play_list.Add(rsp_ms)
                ElseIf two_simvol = 7 Then
                    player_stand_play_list.Add(rsp_7)
                    player_stand_play_list.Add(rsp_ms)
                ElseIf two_simvol = 8 Then
                    player_stand_play_list.Add(rsp_8)
                    player_stand_play_list.Add(rsp_ms)
                ElseIf two_simvol = 9 Then
                    player_stand_play_list.Add(rsp_9)
                    player_stand_play_list.Add(rsp_ms)
                End If
            End If
        End If
    End Sub
    Private Sub diction_atp_seconds(second As Short)
        If second = 0 Then
            player_stand_play_list.Add(rsp_0)
            player_stand_play_list.Add(rsp_s)
        ElseIf second = 10 Then
            player_stand_play_list.Add(rsp_20)
            player_stand_play_list.Add(rsp_s)
        ElseIf second = 20 Then
            player_stand_play_list.Add(rsp_20)
            player_stand_play_list.Add(rsp_s)
        ElseIf second = 30 Then
            player_stand_play_list.Add(rsp_30)
            player_stand_play_list.Add(rsp_s)
        ElseIf second = 40 Then
            player_stand_play_list.Add(rsp_40)
            player_stand_play_list.Add(rsp_s)
        ElseIf second = 50 Then
            player_stand_play_list.Add(rsp_50)
            player_stand_play_list.Add(rsp_s)
        End If
    End Sub
#End Region
    Private Sub ComboBox4_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox4.SelectedIndexChanged
        If ComboBox4.SelectedIndex = 0 Then
            TextBox1.Enabled = False
            TextBox3.Enabled = False
            TextBox2.Enabled = False
            TextBox4.Enabled = False
        Else
            TextBox1.Enabled = True
            TextBox3.Enabled = True
            TextBox2.Enabled = True
            TextBox4.Enabled = True
        End If
    End Sub
    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Timer.Show()
    End Sub
    Private Sub ТаймерToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ТаймерToolStripMenuItem.Click
        Timer.Show()
    End Sub
    Private Sub ContextMenuNotify_Opening(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuNotify.Opening
        If Button1.Text = "Активировать" Then
            ContextMenuNotify.Items.Item(2).Text = "Таймер (!)"
        Else
            ContextMenuNotify.Items.Item(2).Text = "Таймер"
        End If
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dictor_settings.ShowDialog()
    End Sub
    Private Sub ContextMenuNotify_Leaved(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles ContextMenuNotify.LostFocus
        ContextMenuNotify.Close()
    End Sub
    Private Sub TextBox1_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.Leave
        If TextBox1.Text = "" Then TextBox1.Text = 0
    End Sub
    Private Sub TextBox2_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.Leave
        If TextBox2.Text = "" Then TextBox2.Text = 0
    End Sub
    Private Sub TextBox3_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.Leave
        If TextBox3.Text = "" Then TextBox3.Text = 0
    End Sub
    Private Sub TextBox4_LostFocus(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.Leave
        If TextBox4.Text = "" Then TextBox4.Text = 0
    End Sub
    Private Sub TextBox1_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged
        If TextBox1.Text.Length > 1 Then
            If Mid(TextBox1.Text, 1, 1) = "0" Then TextBox1.Text = Mid(TextBox1.Text, 2)
            TextBox1.SelectionStart = TextBox1.Text.Length
        End If
    End Sub
    Private Sub TextBox2_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox2.TextChanged
        If TextBox2.Text.Length > 1 Then
            If Mid(TextBox2.Text, 1, 1) = "0" Then TextBox2.Text = Mid(TextBox2.Text, 2)
            TextBox2.SelectionStart = TextBox2.Text.Length
        End If
    End Sub
    Private Sub TextBox3_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox3.TextChanged
        If TextBox3.Text.Length > 1 Then
            If Mid(TextBox3.Text, 1, 1) = "0" Then TextBox3.Text = Mid(TextBox3.Text, 2)
            TextBox3.SelectionStart = TextBox3.Text.Length
        End If
    End Sub
    Private Sub TextBox4_TextChanged(ByVal sender As Object, ByVal e As System.EventArgs) Handles TextBox4.TextChanged
        If TextBox4.Text.Length > 1 Then
            If Mid(TextBox4.Text, 1, 1) = "0" Then TextBox4.Text = Mid(TextBox4.Text, 2)
            TextBox4.SelectionStart = TextBox4.Text.Length
        End If
    End Sub
End Class
