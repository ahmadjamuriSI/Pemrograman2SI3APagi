Public Class Perulangan

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Close()
    End Sub


    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim teks As String
        Dim jumlah As Integer

        teks = txtText.Text
        jumlah = txtJumlah.Text

        For i = 1 To jumlah
            List1.Items.Add(teks)
        Next i
    End Sub

    Private Sub btnClear_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnClear.Click
        txtText.Text = ""
        txtJumlah.Text = ""
        List1.Items.Clear()
    End Sub

End Class