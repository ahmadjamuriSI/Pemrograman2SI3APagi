Public Class Latihan2

    Private Sub btnUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlang.Click
        txtNama.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
        txtTotHarga.Text = ""
        txtTotBayar.Text = ""
        txtDiskon.Text = ""
        txtBonus.Text = ""
        txtKupon.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus, kupon As String

        'Deklarasi Input Harga dan jumlah
        harga = txtHarga.Text
        jumlah = txtJumlah.Text

        'Perhitungan total Harga
        total = harga * jumlah

        'Penentuan Discount dan Bonus
        If total >= 700000 Then
            diskon = 0.3 * total
            bonus = "Baju Tidur"
            kupon = "22"
        ElseIf total >= 300000 Then
            diskon = 0.2 * total
            bonus = "Topi anak"
            kupon = "19"
        ElseIf total >= 200000 Then
            diskon = 0.1 * total
            bonus = "Kaos anak"
            kupon = "15"
        ElseIf total >= 100000 Then
            diskon = 0.05 * total
            bonus = "Sapu tangan"
            kupon = "5"
        Else
            diskon = 0
            bonus = "Tidak Ada"
            kupon = "0"
        End If

        'Perhitungan total Bayar
        bayar = total - diskon

        'Deklarasi keluaran total harga, diskon, total bayar, dan bonus
        txtBonus.Text = bonus
        txtKupon.Text = kupon
        txtDiskon.Text = diskon
        txtTotBayar.Text = bayar
        txtTotHarga.Text = total
    End Sub
End Class