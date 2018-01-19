Public Class NameEnter

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles ContinueButton.Click
        Dim Exercises As New AddExersices1
        If My.Computer.FileSystem.FileExists("Results.txt") Then My.Computer.FileSystem.DeleteFile("Results.txt")
        Dim w As New System.IO.StreamWriter("Results.txt", True)
        If EnglishRB.IsChecked Then
            MsgBox(TextBox1.Text & ", Answer the following exercises")
            w.WriteLine("----------------------------------------------------")
            w.WriteLine("Name: " & TextBox1.Text)
            w.WriteLine("----------------------------------------------------")
            w.Close()
            Exercises.VerifyButton.Content = "Verify"
        Else
            MsgBox(TextBox1.Text & ", Conteste los siguientes ejercicios")
            w.WriteLine("----------------------------------------------------")
            w.WriteLine("Nombre: " & TextBox1.Text)
            w.WriteLine("----------------------------------------------------")
            w.Close()
            Exercises.VerifyButton.Content = "Verificar"
        End If
        Form1.ElementHost1.Child = Exercises
    End Sub

    Private Sub SpanishRB_Checked(sender As Object, e As Windows.RoutedEventArgs) Handles SpanishRB.Checked
        If SpanishRB.IsChecked Then
            Form1.Language = 1
            EnterNameLabel.Content = "Escriba su nombre:"
            ContinueButton.Content = "Continuar"
            ProgrammerName.Content = "Desarrollado por: Moisés Cardona"
        End If
    End Sub

    Private Sub EnglishRB_Checked(sender As Object, e As Windows.RoutedEventArgs) Handles EnglishRB.Checked
        If EnglishRB.IsChecked Then
            Form1.Language = 0
            EnterNameLabel.Content = "Enter your name:"
            ContinueButton.Content = "Continue"
            ProgrammerName.Content = "Developed by: Moisés Cardona"
        End If
    End Sub
End Class
