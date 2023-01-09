Public Class Nilai

    Private Sub BtnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnHitung.Click
        Dim NilaiAbs As Double
        Dim NilaiTugas As Double
        Dim NilaiUTS As Double
        Dim NilaiUAS As Double
        Dim NilaiAkhir As Double

        NilaiAbs = TxtAbsensi.Text
        NilaiAbs = (NilaiAbs * 10) / 100
        TxtHasilAbs.Text = NilaiAbs

        NilaiTugas = TxtTugas.Text
        NilaiTugas = (NilaiTugas * 20) / 100
        TxtHasilTugas.Text = NilaiTugas

        NilaiUTS = TxtUts.Text
        NilaiUTS = (NilaiUTS * 30) / 100
        TxtHasilUts.Text = NilaiUTS

        NilaiUAS = TxtUas.Text
        NilaiUAS = (NilaiUAS * 40) / 100
        TxtHasilUas.Text = NilaiUAS

        NilaiAkhir = NilaiAbs + NilaiTugas + NilaiUTS + NilaiUAS
        TxtNilaiAkhir.Text = NilaiAkhir
    End Sub
End Class