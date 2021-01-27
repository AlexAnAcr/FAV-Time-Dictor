<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
    Inherits System.Windows.Forms.Form

    'Форма переопределяет dispose для очистки списка компонентов.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Является обязательной для конструктора форм Windows Forms
    Private components As System.ComponentModel.IContainer

    'Примечание: следующая процедура является обязательной для конструктора форм Windows Forms
    'Для ее изменения используйте конструктор форм Windows Form.  
    'Не изменяйте ее в редакторе исходного кода.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.NotifyIcon = New System.Windows.Forms.NotifyIcon(Me.components)
        Me.ContextMenuNotify = New System.Windows.Forms.ContextMenuStrip(Me.components)
        Me.ДеактивироватьToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ОткрытьОкноНастроекToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ТаймерToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ВыйтиToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.ComboBox1 = New System.Windows.Forms.ComboBox()
        Me.CheckBox2 = New System.Windows.Forms.CheckBox()
        Me.ComboBox2 = New System.Windows.Forms.ComboBox()
        Me.CheckBox3 = New System.Windows.Forms.CheckBox()
        Me.ComboBox3 = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Clock_Timer = New System.Windows.Forms.Timer(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Clock_Start = New System.Windows.Forms.Timer(Me.components)
        Me.ComboBox4 = New System.Windows.Forms.ComboBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.CheckBox4 = New System.Windows.Forms.CheckBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.CheckBox5 = New System.Windows.Forms.CheckBox()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Start_copy = New System.ComponentModel.BackgroundWorker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Wait_timer_diction = New System.Windows.Forms.Timer(Me.components)
        Me.ContextMenuNotify.SuspendLayout()
        Me.SuspendLayout()
        '
        'NotifyIcon
        '
        Me.NotifyIcon.BalloonTipTitle = "Диктор времени"
        Me.NotifyIcon.ContextMenuStrip = Me.ContextMenuNotify
        Me.NotifyIcon.Icon = CType(resources.GetObject("NotifyIcon.Icon"), System.Drawing.Icon)
        Me.NotifyIcon.Text = "Диктор времени"
        Me.NotifyIcon.Visible = True
        '
        'ContextMenuNotify
        '
        Me.ContextMenuNotify.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ДеактивироватьToolStripMenuItem, Me.ОткрытьОкноНастроекToolStripMenuItem, Me.ТаймерToolStripMenuItem, Me.ВыйтиToolStripMenuItem})
        Me.ContextMenuNotify.Name = "ContextMenuNotify"
        Me.ContextMenuNotify.ShowImageMargin = False
        Me.ContextMenuNotify.Size = New System.Drawing.Size(192, 92)
        '
        'ДеактивироватьToolStripMenuItem
        '
        Me.ДеактивироватьToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ДеактивироватьToolStripMenuItem.Name = "ДеактивироватьToolStripMenuItem"
        Me.ДеактивироватьToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ДеактивироватьToolStripMenuItem.Text = "Активировать"
        '
        'ОткрытьОкноНастроекToolStripMenuItem
        '
        Me.ОткрытьОкноНастроекToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ОткрытьОкноНастроекToolStripMenuItem.Name = "ОткрытьОкноНастроекToolStripMenuItem"
        Me.ОткрытьОкноНастроекToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ОткрытьОкноНастроекToolStripMenuItem.Text = "Открыть окно настроек"
        '
        'ТаймерToolStripMenuItem
        '
        Me.ТаймерToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ТаймерToolStripMenuItem.Name = "ТаймерToolStripMenuItem"
        Me.ТаймерToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ТаймерToolStripMenuItem.Text = "Таймер"
        '
        'ВыйтиToolStripMenuItem
        '
        Me.ВыйтиToolStripMenuItem.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.ВыйтиToolStripMenuItem.Name = "ВыйтиToolStripMenuItem"
        Me.ВыйтиToolStripMenuItem.Size = New System.Drawing.Size(191, 22)
        Me.ВыйтиToolStripMenuItem.Text = "Выйти"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(27, 29)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(146, 17)
        Me.CheckBox1.TabIndex = 1
        Me.CheckBox1.Text = "Озвучивать часы"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'ComboBox1
        '
        Me.ComboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox1.Enabled = False
        Me.ComboBox1.FormattingEnabled = True
        Me.ComboBox1.Items.AddRange(New Object() {"каждый час", "каждые 2 часа", "каждые 5 часов"})
        Me.ComboBox1.Location = New System.Drawing.Point(203, 27)
        Me.ComboBox1.Name = "ComboBox1"
        Me.ComboBox1.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox1.TabIndex = 2
        '
        'CheckBox2
        '
        Me.CheckBox2.AutoSize = True
        Me.CheckBox2.Location = New System.Drawing.Point(27, 56)
        Me.CheckBox2.Name = "CheckBox2"
        Me.CheckBox2.Size = New System.Drawing.Size(162, 17)
        Me.CheckBox2.TabIndex = 3
        Me.CheckBox2.Text = "Озвучивать минуты"
        Me.CheckBox2.UseVisualStyleBackColor = True
        '
        'ComboBox2
        '
        Me.ComboBox2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox2.Enabled = False
        Me.ComboBox2.FormattingEnabled = True
        Me.ComboBox2.Items.AddRange(New Object() {"каждую минуту", "каждые 2 минуты", "каждые 5 минут", "каждые 10 минут", "каждые 20 минут", "каждые 30 минут"})
        Me.ComboBox2.Location = New System.Drawing.Point(203, 54)
        Me.ComboBox2.Name = "ComboBox2"
        Me.ComboBox2.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox2.TabIndex = 4
        '
        'CheckBox3
        '
        Me.CheckBox3.AutoSize = True
        Me.CheckBox3.Location = New System.Drawing.Point(27, 81)
        Me.CheckBox3.Name = "CheckBox3"
        Me.CheckBox3.Size = New System.Drawing.Size(170, 17)
        Me.CheckBox3.TabIndex = 5
        Me.CheckBox3.Text = "Озвучивать секунды"
        Me.CheckBox3.UseVisualStyleBackColor = True
        '
        'ComboBox3
        '
        Me.ComboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox3.Enabled = False
        Me.ComboBox3.FormattingEnabled = True
        Me.ComboBox3.Items.AddRange(New Object() {"каждые 10 секунд", "каждые 20 секунд", "каждые 30 секунд"})
        Me.ComboBox3.Location = New System.Drawing.Point(203, 79)
        Me.ComboBox3.Name = "ComboBox3"
        Me.ComboBox3.Size = New System.Drawing.Size(179, 21)
        Me.ComboBox3.TabIndex = 6
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(87, 13)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Настройка:"
        '
        'Clock_Timer
        '
        Me.Clock_Timer.Interval = 1000
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.Enabled = False
        Me.Button1.Location = New System.Drawing.Point(248, 192)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(142, 23)
        Me.Button1.TabIndex = 8
        Me.Button1.Text = "Активировать"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Clock_Start
        '
        '
        'ComboBox4
        '
        Me.ComboBox4.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.ComboBox4.FormattingEnabled = True
        Me.ComboBox4.Items.AddRange(New Object() {"Озвучивать время постоянно", "Озвучивать время с ЧЧ:ММ по ЧЧ:ММ"})
        Me.ComboBox4.Location = New System.Drawing.Point(27, 115)
        Me.ComboBox4.Name = "ComboBox4"
        Me.ComboBox4.Size = New System.Drawing.Size(288, 21)
        Me.ComboBox4.TabIndex = 9
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(24, 145)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(23, 13)
        Me.Label2.TabIndex = 10
        Me.Label2.Text = "С:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(24, 171)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(31, 13)
        Me.Label3.TabIndex = 11
        Me.Label3.Text = "ПО:"
        '
        'TextBox1
        '
        Me.TextBox1.Enabled = False
        Me.TextBox1.Location = New System.Drawing.Point(106, 142)
        Me.TextBox1.MaxLength = 2
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(30, 20)
        Me.TextBox1.TabIndex = 12
        Me.TextBox1.Text = "0"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(61, 145)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Час:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(61, 171)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 16
        Me.Label5.Text = "Час:"
        '
        'TextBox3
        '
        Me.TextBox3.Enabled = False
        Me.TextBox3.Location = New System.Drawing.Point(106, 168)
        Me.TextBox3.MaxLength = 2
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(30, 20)
        Me.TextBox3.TabIndex = 15
        Me.TextBox3.Text = "0"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(142, 145)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 13)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Минута:"
        '
        'TextBox2
        '
        Me.TextBox2.Enabled = False
        Me.TextBox2.Location = New System.Drawing.Point(211, 142)
        Me.TextBox2.MaxLength = 2
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(30, 20)
        Me.TextBox2.TabIndex = 17
        Me.TextBox2.Text = "0"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(142, 171)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(63, 13)
        Me.Label7.TabIndex = 20
        Me.Label7.Text = "Минута:"
        '
        'TextBox4
        '
        Me.TextBox4.Enabled = False
        Me.TextBox4.Location = New System.Drawing.Point(211, 168)
        Me.TextBox4.MaxLength = 2
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(30, 20)
        Me.TextBox4.TabIndex = 19
        Me.TextBox4.Text = "0"
        '
        'Button2
        '
        Me.Button2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Left), System.Windows.Forms.AnchorStyles)
        Me.Button2.Location = New System.Drawing.Point(48, 192)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(88, 23)
        Me.Button2.TabIndex = 21
        Me.Button2.Text = "Таймер"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'CheckBox4
        '
        Me.CheckBox4.AutoSize = True
        Me.CheckBox4.Checked = True
        Me.CheckBox4.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox4.Location = New System.Drawing.Point(268, 145)
        Me.CheckBox4.Name = "CheckBox4"
        Me.CheckBox4.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox4.TabIndex = 22
        Me.CheckBox4.Text = "Вступление 1"
        Me.ToolTip1.SetToolTip(Me.CheckBox4, "Если этот пункт выбран, то перед сообщением времени будет проиграна вступительная" &
        " музыка.")
        Me.CheckBox4.UseVisualStyleBackColor = True
        '
        'CheckBox5
        '
        Me.CheckBox5.AutoSize = True
        Me.CheckBox5.Checked = True
        Me.CheckBox5.CheckState = System.Windows.Forms.CheckState.Checked
        Me.CheckBox5.Location = New System.Drawing.Point(268, 167)
        Me.CheckBox5.Name = "CheckBox5"
        Me.CheckBox5.Size = New System.Drawing.Size(122, 17)
        Me.CheckBox5.TabIndex = 23
        Me.CheckBox5.Text = "Вступление 2"
        Me.ToolTip1.SetToolTip(Me.CheckBox5, "Если этот пункт выбран, то перед сигналом срабатывания таймера будет проиграна вс" &
        "тупительная музыка.")
        Me.CheckBox5.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.BackgroundImage = CType(resources.GetObject("Button3.BackgroundImage"), System.Drawing.Image)
        Me.Button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Button3.FlatAppearance.BorderColor = System.Drawing.Color.Black
        Me.Button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray
        Me.Button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.Location = New System.Drawing.Point(2, 187)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(40, 38)
        Me.Button3.TabIndex = 24
        Me.ToolTip1.SetToolTip(Me.Button3, "Настройки программы.")
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Start_copy
        '
        '
        'Label8
        '
        Me.Label8.Font = New System.Drawing.Font("Lucida Console", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 9)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(378, 209)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Загрузка..."
        Me.Label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.ToolTip1.SetToolTip(Me.Label8, "Пожалуйста, подождите.")
        '
        'Wait_timer_diction
        '
        Me.Wait_timer_diction.Interval = 50
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(402, 227)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.CheckBox5)
        Me.Controls.Add(Me.CheckBox4)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.ComboBox4)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ComboBox3)
        Me.Controls.Add(Me.CheckBox3)
        Me.Controls.Add(Me.ComboBox2)
        Me.Controls.Add(Me.CheckBox2)
        Me.Controls.Add(Me.ComboBox1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Font = New System.Drawing.Font("Lucida Console", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(204, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(4, 3, 4, 3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Main"
        Me.Text = "Диктор времени 2.0"
        Me.ContextMenuNotify.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents NotifyIcon As System.Windows.Forms.NotifyIcon
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox1 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox2 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox2 As System.Windows.Forms.ComboBox
    Friend WithEvents CheckBox3 As System.Windows.Forms.CheckBox
    Friend WithEvents ComboBox3 As System.Windows.Forms.ComboBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ContextMenuNotify As System.Windows.Forms.ContextMenuStrip
    Friend WithEvents ДеактивироватьToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ОткрытьОкноНастроекToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ВыйтиToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Clock_Timer As System.Windows.Forms.Timer
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Clock_Start As System.Windows.Forms.Timer
    Friend WithEvents ComboBox4 As System.Windows.Forms.ComboBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox3 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents TextBox2 As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents ТаймерToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents CheckBox4 As System.Windows.Forms.CheckBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents CheckBox5 As System.Windows.Forms.CheckBox
    Friend WithEvents Button3 As Button
    Friend WithEvents Start_copy As System.ComponentModel.BackgroundWorker
    Friend WithEvents Label8 As Label
    Friend WithEvents Wait_timer_diction As Windows.Forms.Timer
End Class
