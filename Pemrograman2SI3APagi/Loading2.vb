Public Class Loading2

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        Static lctr As Integer

        'checking
        If lctr <= 100 Then
            ProgressBar1.Value = lctr
            lctr = lctr + 1
        Else
            'OptionButton.Show()
            Me.Hide()
            Close()
        End If
    End Sub

End Class