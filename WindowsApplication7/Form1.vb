Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim str As String
        str = "Вами выбрано:" & vbCrLf
        If CheckBox1.Checked Then
            str = str & "Руль" & vbCrLf
        End If
        If CheckBox2.Checked Then
            str = str & "Дека" & vbCrLf
        End If
        If CheckBox3.Checked Then
            str = str & "Вилка" & vbCrLf
        End If
        If CheckBox4.Checked Then
            str = str & "Колеса" & vbCrLf
        End If
        If CheckBox5.Checked Then
            str = str & "Грипсы" & vbCrLf
        End If
        If CheckBox6.Checked Then
            str = str & "Рулевая" & vbCrLf
        End If
        If CheckBox7.Checked Then
            str = str & "Хомут" & vbCrLf
        End If
        If CheckBox8.Checked Then
            str = str & "Шкурка" & vbCrLf
        End If
        MessageBox.Show(str)
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim str As String
        str = "Вами выбрано:" & vbCrLf
        If CheckBox9.Checked Then
            str = str & "Blunt" & vbCrLf
        End If
        If CheckBox10.Checked Then
            str = str & "Apex" & vbCrLf
        End If
        If CheckBox11.Checked Then
            str = str & "Lucky" & vbCrLf
        End If
        If CheckBox12.Checked Then
            str = str & "Proto" & vbCrLf
        End If
        If CheckBox13.Checked Then
            str = str & "TilT" & vbCrLf
        End If
        If CheckBox14.Checked Then
            str = str & "Ethic" & vbCrLf
        End If
        MessageBox.Show(str)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        MessageBox.Show("Ваши веденные данные сохранены")
        Application.Exit()
    End Sub
End Class
