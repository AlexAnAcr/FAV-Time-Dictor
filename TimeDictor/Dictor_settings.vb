Public Class Dictor_settings
    Private Sub Dictor_settings_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        If Main.settings(0) = "default" Then
            RadioButton1.Checked = True
            TextBox1.Enabled = False
            Button1.Enabled = False
        Else
            RadioButton2.Checked = True
            TextBox1.Enabled = True
            Button1.Enabled = True
        End If
        If Main.settings(2) = "default" Then
            RadioButton4.Checked = True
            TextBox2.Enabled = False
            Button2.Enabled = False
        Else
            RadioButton3.Checked = True
            TextBox2.Enabled = True
            Button2.Enabled = True
        End If
        If My.Computer.FileSystem.FileExists(Main.settings(1)) Then
            TextBox1.Text = Main.settings(1)
        Else
            Main.settings(1) = ""
        End If
        If My.Computer.FileSystem.FileExists(Main.settings(3)) Then
            TextBox2.Text = Main.settings(3)
        Else
            Main.settings(3) = ""
        End If
        If Main.settings(4) = "stop" Then
            RadioButton6.Checked = True
            ComboBox1.Enabled = False
        ElseIf Main.settings(4) = "mute" Then
            RadioButton5.Checked = True
            ComboBox1.Enabled = True
        Else
            RadioButton7.Checked = True
            ComboBox1.Enabled = False
        End If
        If Main.settings(5) = 0 Then
            ComboBox1.SelectedIndex = 10
        ElseIf Main.settings(5) = 1 Then
            ComboBox1.SelectedIndex = 9
        ElseIf Main.settings(5) = 2 Then
            ComboBox1.SelectedIndex = 8
        ElseIf Main.settings(5) = 3 Then
            ComboBox1.SelectedIndex = 7
        ElseIf Main.settings(5) = 4 Then
            ComboBox1.SelectedIndex = 6
        ElseIf Main.settings(5) = 5 Then
            ComboBox1.SelectedIndex = 5
        ElseIf Main.settings(5) = 6 Then
            ComboBox1.SelectedIndex = 4
        ElseIf Main.settings(5) = 7 Then
            ComboBox1.SelectedIndex = 3
        ElseIf Main.settings(5) = 8 Then
            ComboBox1.SelectedIndex = 2
        ElseIf Main.settings(5) = 9 Then
            ComboBox1.SelectedIndex = 1
        ElseIf Main.settings(5) = 10 Then
            ComboBox1.SelectedIndex = 0
        Else
            Main.settings(5) = "5"
        End If
    End Sub
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Try
            If RadioButton1.Checked = True Then
                Main.settings(0) = "default"
            ElseIf RadioButton2.Checked = True Then
                Main.settings(0) = "my"
                If My.Computer.FileSystem.FileExists(TextBox1.Text) = False Then Error 1
                Main.settings(1) = TextBox1.Text
                Main.msp_it = Main.player_stand.newMedia(TextBox1.Text)
            End If
            If RadioButton4.Checked = True Then
                Main.settings(2) = "default"
            ElseIf RadioButton3.Checked = True Then
                Main.settings(2) = "my"
                If My.Computer.FileSystem.FileExists(TextBox2.Text) = False Then Error 1
                Main.settings(3) = TextBox2.Text
                Main.msp_e = Main.player_stand.newMedia(TextBox2.Text)
            End If
            If RadioButton6.Checked = True Then
                Main.settings(4) = "stop"
            ElseIf RadioButton5.Checked = True Then
                Main.settings(4) = "mute"
                Main.settings(5) = 10 - ComboBox1.SelectedIndex
            ElseIf RadioButton7.Checked = True Then
                Main.settings(4) = "no time"
            End If
            IO.File.WriteAllLines(Application.StartupPath & "/settings.dat", Main.settings)
            Me.Close()
        Catch
            MsgBox("Неверно заданы путь(и) файлов!",, "Ошибка")
        End Try
    End Sub
    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Enabled = False
            Button1.Enabled = False
        ElseIf RadioButton2.Checked = True Then
            TextBox1.Enabled = True
            Button1.Enabled = True
        End If
    End Sub
    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged
        If RadioButton1.Checked = True Then
            TextBox1.Enabled = False
            Button1.Enabled = False
        ElseIf RadioButton2.Checked = True Then
            TextBox1.Enabled = True
            Button1.Enabled = True
        End If
    End Sub
    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox2.Enabled = False
            Button2.Enabled = False
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Enabled = True
            Button2.Enabled = True
        End If
    End Sub
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged
        If RadioButton4.Checked = True Then
            TextBox2.Enabled = False
            Button2.Enabled = False
        ElseIf RadioButton3.Checked = True Then
            TextBox2.Enabled = True
            Button2.Enabled = True
        End If
    End Sub
    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged
        If RadioButton6.Checked = True Then
            ComboBox1.Enabled = False
        ElseIf RadioButton5.Checked = True Then
            ComboBox1.Enabled = True
        ElseIf RadioButton7.Checked = True Then
            ComboBox1.Enabled = False
        End If
    End Sub
    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged
        If RadioButton6.Checked = True Then
            ComboBox1.Enabled = False
        ElseIf RadioButton5.Checked = True Then
            ComboBox1.Enabled = True
        ElseIf RadioButton7.Checked = True Then
            ComboBox1.Enabled = False
        End If
    End Sub
    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged
        If RadioButton6.Checked = True Then
            ComboBox1.Enabled = False
        ElseIf RadioButton5.Checked = True Then
            ComboBox1.Enabled = True
        ElseIf RadioButton7.Checked = True Then
            ComboBox1.Enabled = False
        End If
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim result As DialogResult = OpenFile.ShowDialog
        If result = DialogResult.OK Then
            If My.Computer.FileSystem.GetFileInfo(OpenFile.FileName).Extension.ToLower = ".mp3" Then
                TextBox1.Text = OpenFile.FileName
            Else
                MsgBox("Неверное расширение файла!",, "Ошибка")
            End If
        End If
    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim result As DialogResult = OpenFile.ShowDialog
        If result = DialogResult.OK Then
            If My.Computer.FileSystem.GetFileInfo(OpenFile.FileName).Extension.ToLower = ".mp3" Then
                TextBox2.Text = OpenFile.FileName
            Else
                MsgBox("Неверное расширение файла!",, "Ошибка")
            End If
        End If
    End Sub
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MsgBox("Уровень: 10 = 100%; 5 = 50%." & Chr(10) & "Уровень: 10 - не снижать громкость; 0 - убрать звук полностью.",, "Справка")
    End Sub
End Class
