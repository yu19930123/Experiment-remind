Module Module1
    Public Function texttotime00(ByVal h As String, ByVal n As String)  '输入时、分，返回包含日期的时间型数据；
        Dim bl1 As Integer
        Dim bl2 As Integer
        Dim time As Date
        bl1 = Val(h)
        bl2 = Val(n)
        If (bl1 <= 24) Then
            If (bl2 <= 60) Then
                time = Today
                time = DateAdd("h", bl1, time)
                time = DateAdd("n", bl2, time)
                Return (time)
            Else
                MsgBox("输入错误")
            End If
        Else
            MsgBox("输入错误")
        End If
        Return (TimeValue("0:0:0"))
    End Function
    Public Function getminute00(ByVal indate As Date)  '返回一个值为 0 到 59 之间的文本，并用两位数表示
        Dim bl As String
        bl = Trim(Str(Minute(indate)))
        If Len(bl) = 1 Then
            bl = "0" + bl
        End If
        Return (bl)
    End Function
    Public Function timetotext00(ByVal t As Date) '返回时间分钟部分，且分钟为两位数
        Dim bl As String
        bl = Str(Hour(t)) + ":" + Str(getminute00(t))
        Return (bl)
    End Function

End Module
