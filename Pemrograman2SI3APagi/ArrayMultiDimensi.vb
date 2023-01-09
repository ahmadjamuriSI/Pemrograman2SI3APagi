Public Class ArrayMultiDimensi

    Private Sub ArrayMultiDimensi_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Dim arr(4, 1) As String
        arr(0, 0) = "NIM"
        arr(0, 1) = "NAMA"
        arr(1, 0) = "JENIS KELAMIN"
        arr(1, 1) = "PRODI"
        arr(2, 0) = "LAKI-LAKI"
        arr(2, 1) = "PEREMPUAN"
        arr(3, 0) = "SI"
        arr(3, 1) = "TI"
        arr(4, 0) = "RPL"
        arr(4, 1) = "STA"
        ListView1.GridLines = True
        ListView1.View = View.Details


        For baris = 0 To 1
            For kolom = 0 To 1
                ListView1.Columns.Add(arr(baris, kolom), 100)
            Next kolom
        Next baris

        For baris = 2 To 2
            For kolom = 0 To 1
                cbKelamin.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 3 To 3
            For kolom = 0 To 1
                cbProdi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

        For baris = 4 To 4
            For kolom = 0 To 1
                cbProdi.Items.Add(arr(baris, kolom))
            Next kolom
        Next baris

    End Sub

    Private Sub btnProses_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnProses.Click
        Dim arr(4) As String
        arr(0) = txtNim.Text
        arr(1) = txtNama.Text
        arr(2) = cbKelamin.Text
        arr(3) = cbProdi.Text

        Dim listitem As ListViewItem
        listitem = New ListViewItem
        listitem = ListView1.Items.Add(arr(0))
        listitem.SubItems.Add(arr(1))
        listitem.SubItems.Add(arr(2))
        listitem.SubItems.Add(arr(3))
        txtNim.Text = txtNim.Text + 1
        txtNama.Text = ""
        cbKelamin.Text = ""
        cbProdi.Text = ""
        txtNama.Focus()
    End Sub

    Private Sub Label1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label1.Click

    End Sub

    Private Sub Label2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label2.Click

    End Sub

    Private Sub Label3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click

    End Sub

    Private Sub ListView1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ListView1.SelectedIndexChanged

    End Sub

    Private Sub txtNim_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNim.TextChanged

    End Sub

    Private Sub txtNama_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNama.TextChanged

    End Sub

    Private Sub cbKelamin_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbKelamin.SelectedIndexChanged

    End Sub

    Private Sub cbProdi_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles cbProdi.SelectedIndexChanged

    End Sub
End Class