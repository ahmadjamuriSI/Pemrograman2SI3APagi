Public Class Uts1
    Dim harga, jumlah, bayaru As Integer
    Dim total, diskon, bayar, totBayar, bayars As Double

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        'Dim harga, jumlah As Integer
        'Dim total, diskon, bayar, totBayar As Double

        'Deklarasi Input Harga dan jumlah
        harga = txtHarga.Text
        jumlah = txtJumlah.Text

        'Perhitungan total Harga
        total = harga * jumlah

        'Penentuan Discount dan Bonus
        If total >= 700000 Then
            diskon = 0.4 * total
        ElseIf total >= 400000 Then
            diskon = 0.3 * total
        ElseIf total >= 200000 Then
            diskon = 0.2 * total
        ElseIf total >= 50000 Then
            diskon = 0.1 * total
        Else
            diskon = 0
        End If

        'Perhitungan total Bayar
        bayar = total - diskon

        'Deklarasi keluaran total harga, diskon, total bayar, dan bonus
        txtDiskon.Text = diskon
        txtTotBayar.Text = bayar
        txtTotHarga.Text = total

    End Sub

    Private Sub btnUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUlang.Click
        txtNama.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
        txtTotHarga.Text = ""
        txtTotBayar.Text = ""
        txtDiskon.Text = ""
        txtBayar.Text = ""
        txtKembalian.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        'Deklarasi Input Harga dan jumlah
        bayaru = txtBayar.Text
        bayars = bayar - bayaru
        txtKembalian.Text = bayars
    End Sub
End Class