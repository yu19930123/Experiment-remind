<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意:  以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.hourinput = New System.Windows.Forms.TextBox()
        Me.minuteinput = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.NumericUpDown2 = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'hourinput
        '
        Me.hourinput.Location = New System.Drawing.Point(35, 37)
        Me.hourinput.Name = "hourinput"
        Me.hourinput.Size = New System.Drawing.Size(32, 21)
        Me.hourinput.TabIndex = 0
        '
        'minuteinput
        '
        Me.minuteinput.Location = New System.Drawing.Point(94, 37)
        Me.minuteinput.Name = "minuteinput"
        Me.minuteinput.Size = New System.Drawing.Size(32, 21)
        Me.minuteinput.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label1.Location = New System.Drawing.Point(73, 37)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(11, 19)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = ":"
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Increment = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Location = New System.Drawing.Point(132, 37)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10000, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(51, 21)
        Me.NumericUpDown1.TabIndex = 4
        Me.NumericUpDown1.Value = New Decimal(New Integer() {10, 0, 0, 0})
        '
        'Label2
        '
        Me.Label2.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label2.Location = New System.Drawing.Point(189, 37)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 19)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "分钟"
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 96)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal
        Me.TextBox1.Size = New System.Drawing.Size(215, 208)
        Me.TextBox1.TabIndex = 6
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(230, 37)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(41, 21)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "添加"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Timer1
        '
        Me.Timer1.Interval = 1000
        '
        'NumericUpDown2
        '
        Me.NumericUpDown2.Location = New System.Drawing.Point(346, 37)
        Me.NumericUpDown2.Name = "NumericUpDown2"
        Me.NumericUpDown2.Size = New System.Drawing.Size(32, 21)
        Me.NumericUpDown2.TabIndex = 8
        Me.NumericUpDown2.Value = New Decimal(New Integer() {2, 0, 0, 0})
        '
        'Label3
        '
        Me.Label3.AutoEllipsis = True
        Me.Label3.Font = New System.Drawing.Font("宋体", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.Label3.Location = New System.Drawing.Point(277, 37)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(63, 21)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "提前提醒"
        '
        'Button2
        '
        Me.Button2.Location = New System.Drawing.Point(310, 106)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(55, 51)
        Me.Button2.TabIndex = 10
        Me.Button2.Text = "Button2"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(431, 316)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.NumericUpDown2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.NumericUpDown1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.minuteinput)
        Me.Controls.Add(Me.hourinput)
        Me.Name = "Form1"
        Me.Text = "实验提醒"
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NumericUpDown2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents hourinput As System.Windows.Forms.TextBox
    Friend WithEvents minuteinput As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend quyangshijian(0) As Date
    Friend quyangshijiantext(0) As String
    Friend kaishishijian As Date
    Friend fanyingshijian As Integer


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        kaishishijian = texttotime00(hourinput.Text, minuteinput.Text)
        fanyingshijian = 0
    End Sub

    'Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
    '   If e = vbCr Then
    '      TextBox2.Focus()
    '     Return ()
    '        End If
    'End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles minuteinput.TextChanged
        kaishishijian = texttotime00(hourinput.Text, minuteinput.Text)
        TextBox1.Text = timetotext00(kaishishijian) + "    开始" + vbCrLf
        fanyingshijian = 0
    End Sub

    Private Sub hourinput_TextChanged(sender As Object, e As EventArgs) Handles hourinput.TextChanged
        kaishishijian = texttotime00(hourinput.Text, minuteinput.Text)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim daishijian As Date
        Dim daishijiantext As String
        Dim shijianjiange As Integer
        shijianjiange = Val(NumericUpDown1.Value)
        fanyingshijian = fanyingshijian + shijianjiange
        daishijian = DateAdd(DateInterval.Minute, fanyingshijian, kaishishijian)
        daishijiantext = timetotext00(daishijian)
        TextBox1.Text = TextBox1.Text + daishijiantext + "    " + Str(fanyingshijian) + "分钟" + vbCrLf
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Dim tixingshijian As String
        If Second(Now()) = 0 Then
            tixingshijian = timetotext00(DateAdd(DateInterval.Minute, -NumericUpDown2.Value, Now()))
            If InStr(TextBox1.Text, tixingshijian) <> 0 Then
                MsgBox("取样")
            End If
        End If
    End Sub
    Friend WithEvents NumericUpDown2 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        MsgBox("取样")
    End Sub
End Class
