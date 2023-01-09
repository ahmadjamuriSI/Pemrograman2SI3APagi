Public Class Kalkulator
    Private Sub Tambah_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Tambah.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 + angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub Kurang_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kurang.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 - angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub Bagi_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Bagi.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 / angka2
        TextBox3.Text = hasil
    End Sub

    Private Sub Kali_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Kali.Click
        Dim angka1, angka2, hasil As Double
        angka1 = Val(TextBox1.Text)
        angka2 = Val(TextBox2.Text)
        hasil = angka1 * angka2
        TextBox3.Text = hasil
    End Sub
End Class