Imports System.Windows.Media

Public Class AddExersices1

    Public Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles VerifyButton.Click
        Dim v As New Verify
        Dim w As New IO.StreamWriter("Results.txt", True)
        Dim cg
        Dim cr
        Dim tg
        Dim tb
        Dim e011 As String
        Dim e012 As String
        Dim e021 As String
        Dim e022 As String
        Dim e031 As String
        Dim e032 As String
        Dim e041 As String
        Dim e042 As String
        Dim e051 As String
        Dim e052 As String
        Dim e061 As String
        Dim e062 As String
        Dim e071 As String
        Dim e072 As String
        Dim e081 As String
        Dim e082 As String
        Dim e091 As String
        Dim e092 As String
        Dim e101 As String
        Dim e102 As String
        Dim e111 As String
        Dim e112 As String
        Dim e121 As String
        Dim e122 As String
        Dim e131 As String
        Dim e132 As String
        Dim e141 As String
        Dim e142 As String
        Dim e151 As String
        Dim e152 As String
        e011 = 1 + 1
        e012 = 1
        e021 = 2 + 1
        e022 = 1
        e031 = 2 + 6
        e032 = 5
        e041 = 8 + 1
        e042 = 7
        e051 = 4 + 3
        e052 = 2
        e061 = 2 + 7
        e062 = 4
        e071 = 1 + 6
        e072 = 9
        e081 = 2 + 5
        e082 = 3
        e091 = 5 + 3
        e092 = 5
        e101 = 1 + 7
        e102 = 6
        e111 = 2 + 2
        e112 = 6
        e121 = 7 + 1
        e122 = 8
        e131 = 3 + 4
        e132 = 2
        e141 = 3 + 3
        e142 = 4
        e151 = 3 + 6
        e152 = 1
        cg = New SolidColorBrush(Colors.Green)
        cr = New SolidColorBrush(Colors.Red)
        If Form1.Language = 0 Then
            tg = "Correct"
            tb = "Incorrect"
            v.BackButton.Content = "Back"
            v.CloseButton.Content = "Close"
            v.ViewResultsButton.Content = "View Results"
        Else
            tg = "Correcto"
            tb = "Incorrecto"
            v.BackButton.Content = "Atrás"
            v.CloseButton.Content = "Cerrar"
            v.ViewResultsButton.Content = "Ver Resultados"
        End If
        If TextBox1.Text = e011 And TextBox2.Text = e012 Then
            v.TextBox1.Foreground = cg
            v.TextBox1.Text = tg
        Else
            v.TextBox1.Foreground = cr
            v.TextBox1.Text = tb
        End If
        If TextBox3.Text = e021 And TextBox4.Text = e022 Then
            v.TextBox2.Foreground = cg
            v.TextBox2.Text = tg
        Else
            v.TextBox2.Foreground = cr
            v.TextBox2.Text = tb
        End If
        If TextBox5.Text = e031 And TextBox6.Text = e032 Then
            v.TextBox3.Foreground = cg
            v.TextBox3.Text = tg
        Else
            v.TextBox3.Foreground = cr
            v.TextBox3.Text = tb
        End If
        If TextBox7.Text = e041 And TextBox8.Text = e042 Then
            v.TextBox4.Foreground = cg
            v.TextBox4.Text = tg
        Else
            v.TextBox4.Foreground = cr
            v.TextBox4.Text = tb
        End If
        If TextBox9.Text = e051 And TextBox10.Text = e052 Then
            v.TextBox5.Foreground = cg
            v.TextBox5.Text = tg
        Else
            v.TextBox5.Foreground = cr
            v.TextBox5.Text = tb
        End If
        If TextBox11.Text = e061 And TextBox12.Text = e062 Then
            v.TextBox6.Foreground = cg
            v.TextBox6.Text = tg
        Else
            v.TextBox6.Foreground = cr
            v.TextBox6.Text = tb
        End If
        If TextBox13.Text = e071 And TextBox14.Text = e072 Then
            v.TextBox7.Foreground = cg
            v.TextBox7.Text = tg
        Else
            v.TextBox7.Foreground = cr
            v.TextBox7.Text = tb
        End If
        If TextBox15.Text = e081 And TextBox16.Text = e082 Then
            v.TextBox8.Foreground = cg
            v.TextBox8.Text = tg
        Else
            v.TextBox8.Foreground = cr
            v.TextBox8.Text = tb
        End If
        If TextBox17.Text = e091 And TextBox18.Text = e092 Then
            v.TextBox9.Foreground = cg
            v.TextBox9.Text = tg
        Else
            v.TextBox9.Foreground = cr
            v.TextBox9.Text = tb
        End If
        If TextBox19.Text = e101 And TextBox20.Text = e102 Then
            v.TextBox10.Foreground = cg
            v.TextBox10.Text = tg
        Else
            v.TextBox10.Foreground = cr
            v.TextBox10.Text = tb
        End If
        If TextBox21.Text = e111 And TextBox22.Text = e112 Then
            v.TextBox11.Foreground = cg
            v.TextBox11.Text = tg
        Else
            v.TextBox11.Foreground = cr
            v.TextBox11.Text = tb
        End If
        If TextBox23.Text = e121 And TextBox24.Text = e122 Then
            v.TextBox12.Foreground = cg
            v.TextBox12.Text = tg
        Else
            v.TextBox12.Foreground = cr
            v.TextBox12.Text = tb
        End If
        If TextBox25.Text = e131 And TextBox26.Text = e132 Then
            v.TextBox13.Foreground = cg
            v.TextBox13.Text = tg
        Else
            v.TextBox13.Foreground = cr
            v.TextBox13.Text = tb
        End If
        If TextBox27.Text = e141 And TextBox28.Text = e142 Then
            v.TextBox14.Foreground = cg
            v.TextBox14.Text = tg
        Else
            v.TextBox14.Foreground = cr
            v.TextBox14.Text = tb
        End If
        If TextBox29.Text = e151 And TextBox30.Text = e152 Then
            v.TextBox15.Foreground = cg
            v.TextBox15.Text = tg
        Else
            v.TextBox15.Foreground = cr
            v.TextBox15.Text = tb
        End If
        w.WriteLine("1. " & TextBox1.Text & "/" & TextBox2.Text & " | " & v.TextBox1.Text)
        w.WriteLine("2. " & TextBox3.Text & "/" & TextBox4.Text & " | " & v.TextBox2.Text)
        w.WriteLine("3. " & TextBox5.Text & "/" & TextBox6.Text & " | " & v.TextBox3.Text)
        w.WriteLine("4. " & TextBox7.Text & "/" & TextBox8.Text & " | " & v.TextBox4.Text)
        w.WriteLine("5. " & TextBox9.Text & "/" & TextBox10.Text & " | " & v.TextBox5.Text)
        w.WriteLine("6. " & TextBox11.Text & "/" & TextBox12.Text & " | " & v.TextBox6.Text)
        w.WriteLine("7. " & TextBox13.Text & "/" & TextBox14.Text & " | " & v.TextBox7.Text)
        w.WriteLine("8. " & TextBox15.Text & "/" & TextBox16.Text & " | " & v.TextBox8.Text)
        w.WriteLine("9. " & TextBox17.Text & "/" & TextBox18.Text & " | " & v.TextBox9.Text)
        w.WriteLine("10. " & TextBox19.Text & "/" & TextBox20.Text & " | " & v.TextBox10.Text)
        w.WriteLine("11. " & TextBox21.Text & "/" & TextBox22.Text & " | " & v.TextBox11.Text)
        w.WriteLine("12. " & TextBox23.Text & "/" & TextBox24.Text & " | " & v.TextBox12.Text)
        w.WriteLine("13. " & TextBox25.Text & "/" & TextBox26.Text & " | " & v.TextBox13.Text)
        w.WriteLine("14. " & TextBox27.Text & "/" & TextBox28.Text & " | " & v.TextBox14.Text)
        w.WriteLine("15. " & TextBox29.Text & "/" & TextBox30.Text & " | " & v.TextBox15.Text)
        w.Close()
        Form1.ElementHost1.Child = v
    End Sub
End Class
