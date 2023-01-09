Public Class Belanja

    Private Sub BtnUlang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUlang.Click
        txtNama.Text = ""
        txtHarga.Text = ""
        txtJumlah.Text = ""
        txtTotHarga.Text = ""
        txtTotBayar.Text = ""
        txtDiskon.Text = ""
        txtBonus.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim harga, jumlah As Integer
        Dim total, diskon, bayar As Double
        Dim bonus As String

        'Deklarasi Input Harga dan jumlah
        harga = txtHarga.Text
        jumlah = txtJumlah.Text

        'Perhitungan total Harga
        total = harga * jumlah

        'Penentuan Discount dan Bonus
        If total >= 500000 Then
            diskon = 0.2 * total
            bonus = "Tas Pinggang"
        ElseIf total >= 200000 Then
            diskon = 0.15 * total
            bonus = "Payung"
        ElseIf total >= 100000 Then
            diskon = 0.1 * total
            bonus = "Kaos"
        ElseIf total >= 50000 Then
            diskon = 0.05 * total
            bonus = "Pens"
        Else
            diskon = 0
            bonus = "Tidak Ada"
        End If

        'Perhitungan total Bayar
        bayar = total - diskon

        'Deklarasi keluaran total harga, diskon, total bayar, dan bonus
        txtBonus.Text = bonus
        txtDiskon.Text = diskon
        txtTotBayar.Text = bayar
        txtTotHarga.Text = total

    End Sub

    Private Sub BtnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnKeluar.Click

    End Sub
End Class