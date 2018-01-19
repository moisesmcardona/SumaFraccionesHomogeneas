Public Class Verify

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles BackButton.Click
        Dim ae As New AddExersices1
        Form1.ElementHost1.Child = ae
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles CloseButton.Click
        Form1.Close()
    End Sub

    Public Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.Windows.RoutedEventArgs) Handles ViewResultsButton.Click
        Process.Start("Results.txt")
    End Sub
End Class
