Public Class biodata
    Dim membaca, musik, olahraga As String

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        lblNpm.Text = txtNpm.Text
        lblNama.Text = txtNama.Text
        lblKelamin.Text = cbKelamin.Text
        lblJurusan.Text = cbJurusan.Text
        lblSemester.Text = cbSemester.Text
        lblMembaca.Text = "1" & membaca & vbCrLf & "2" & musik & vbCrLf & "3" & olahraga & vbCrLf
        


    End Sub

    Private Sub btnKeluar_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnKeluar.Click
        Close()
    End Sub

    Private Sub CheckBoxMembaca_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMembaca.CheckedChanged
        membaca = CheckBoxMembaca.Text
    End Sub

    Private Sub CheckBoxMusik_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxMusik.CheckedChanged
        musik = CheckBoxMusik.Text
    End Sub

    Private Sub CheckBoxOlahraga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBoxOlahraga.CheckedChanged
        olahraga = CheckBoxOlahraga.Text
    End Sub

    Private Sub biodata_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class