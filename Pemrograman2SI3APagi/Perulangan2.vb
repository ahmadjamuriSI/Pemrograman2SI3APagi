Public Class Perulangan2

    Private Sub bNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bNext.Click
        ListBox1.Items.Clear()
        For I = 1 To 5
            ListBox1.Items.Add("For Next : " & I)
        Next
    End Sub

    Private Sub bWhile_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bWhile.Click
        ListBox1.Items.Clear()
        Dim i As Integer = 0
        Do While i <= 5
            ListBox1.Items.Add("Do While : " & i)
            i = i + 1
        Loop
    End Sub

    Private Sub bUntil_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles bUntil.Click
        ListBox1.Items.Clear()
        Dim i As Integer = 0
        Do Until i > 5
            ListBox1.Items.Add("Do Until : " & i)
            i = i + 1
        Loop
    End Sub
End Class