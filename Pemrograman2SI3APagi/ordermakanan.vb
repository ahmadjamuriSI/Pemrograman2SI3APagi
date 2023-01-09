Public Class ordermakanan
    Public hrgMakanan, hrgMinuman As Integer

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged
        Select Case ComboBox1.Text
            Case "Nasi Uduk"
                Label3.Text = "Rp.5000"
                hrgMakanan = 5000
            Case "Bakso"
                Label3.Text = "Rp.12000"
                hrgMakanan = 12000
            Case "Mie Ayam"
                Label3.Text = "Rp.10000"
                hrgMakanan = 10000
        End Select
    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox2.SelectedIndexChanged
        Select Case ComboBox2.Text
            Case "Es Jeruk"
                Label4.Text = "Rp.5000"
                hrgMinuman = 5000
            Case "Jus Alpukat"
                Label4.Text = "Rp.10000"
                hrgMinuman = 12000
            Case "Teh Manis"
                Label4.Text = "Rp.7000"
                hrgMinuman = 10000
        End Select
    End Sub

    Public Sub New()

        ' This call is required by the Windows Form Designer.
        InitializeComponent()

        ' Add any initialization after the InitializeComponent() call.
        ComboBox2.Visible = False
        Label5.Visible = False

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Enabled = False Then
            ComboBox2.Visible = False
        End If
        If CheckBox1.Enabled = True Then
            ComboBox2.Visible = True
            Label5.Visible = True
        End If
    End Sub

    Private Sub btnHitung_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnHitung.Click
        Dim porsiMkn, porsiMnm, jumlah As Integer

        porsiMkn = TextBox1.Text
        porsiMnm = TextBox2.Text
        jumlah = (hrgMakanan * porsiMkn) + (hrgMinuman * porsiMnm)
        Label8.Text = "Rp. " & jumlah.ToString
    End Sub
End Class