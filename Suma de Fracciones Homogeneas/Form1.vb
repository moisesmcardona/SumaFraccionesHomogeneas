Public Class Form1
    Public Language As Integer = 0
    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim UserName As New NameEnter
        ElementHost1.Child = UserName
    End Sub
End Class
