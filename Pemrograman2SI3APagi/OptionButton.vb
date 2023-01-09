Public Class OptionButton

    Private Sub rbAyam_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbAyam.CheckedChanged
        Label2.Text = rbAyam.Text
    End Sub

    Private Sub rbDaging_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbDaging.CheckedChanged
        Label2.Text = rbDaging.Text
    End Sub

    Private Sub rbIga_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbIga.CheckedChanged
        Label2.Text = rbIga.Text
    End Sub

    Private Sub rbTehManisHangat_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTehManisHangat.CheckedChanged
        Label3.Text = rbTehManisHangat.Text
    End Sub

    Private Sub rbTehManis_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbTehManis.CheckedChanged
        Label3.Text = rbTehManis.Text
    End Sub

    Private Sub rbJeruk_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles rbJeruk.CheckedChanged
        Label3.Text = rbJeruk.Text
    End Sub

    
End Class