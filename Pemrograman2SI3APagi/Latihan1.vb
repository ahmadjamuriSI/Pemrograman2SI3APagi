Public Class latihan1

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim NilaiPraktek As Double
        Dim NilaiHarian As Double
        Dim NilaiMID As Double
        Dim NilaiUN As Double
        Dim NilaiAkhir As Double

        NilaiPraktek = txtPraktek.Text
        NilaiPraktek = (NilaiPraktek * 20) / 100
        txtHasilPraktek.Text = NilaiPraktek

        NilaiHarian = txtHarian.Text
        NilaiHarian = (NilaiHarian * 15) / 100
        txtHasilHarian.Text = NilaiHarian

        NilaiMID = txtMID.Text
        NilaiMID = (NilaiMID * 30) / 100
        txtHasilMID.Text = NilaiMID

        NilaiUN = txtUN.Text
        NilaiUN = (NilaiUN * 35) / 100
        txtHasilUN.Text = NilaiUN

        NilaiAkhir = NilaiPraktek + NilaiHarian + NilaiMID + NilaiUN
        txtAkhir.Text = NilaiAkhir

    End Sub
End Class