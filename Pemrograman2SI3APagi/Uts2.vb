Public Class Uts2
    Public hrgMakanan, porsiMkn, totBayar, bayar, kembalian As Integer
    
    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "GADO-GADO"
                txtHarga.Text = "Rp.15000"
                hrgMakanan = 15000
            Case "KAREDOK"
                txtHarga.Text = "Rp.12000"
                hrgMakanan = 12000
            Case "PECEL LELE"
                txtHarga.Text = "Rp.16000"
                hrgMakanan = 16000
            Case "AYAM GEPREK"
                txtHarga.Text = "Rp.20000"
                hrgMakanan = 20000
        End Select
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        porsiMkn = TextBox1.Text

        totBayar = hrgMakanan * porsiMkn
        TextBox2.Text = totBayar

    End Sub

    Private Sub btnBayar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnBayar.Click
        bayar = TextBox3.Text

        kembalian = bayar - totBayar

        TextBox4.Text = kembalian

    End Sub
End Class