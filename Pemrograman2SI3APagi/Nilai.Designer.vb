<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Nilai
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Judul = New System.Windows.Forms.Label
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.TxtAbsensi = New System.Windows.Forms.TextBox
        Me.TxtHasilAbs = New System.Windows.Forms.TextBox
        Me.TxtTugas = New System.Windows.Forms.TextBox
        Me.TxtHasilTugas = New System.Windows.Forms.TextBox
        Me.TxtUts = New System.Windows.Forms.TextBox
        Me.TxtHasilUts = New System.Windows.Forms.TextBox
        Me.TxtUas = New System.Windows.Forms.TextBox
        Me.TxtHasilUas = New System.Windows.Forms.TextBox
        Me.TxtNilaiAkhir = New System.Windows.Forms.TextBox
        Me.BtnHitung = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Judul
        '
        Me.Judul.AutoSize = True
        Me.Judul.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Underline), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Judul.Location = New System.Drawing.Point(97, 9)
        Me.Judul.Name = "Judul"
        Me.Judul.Size = New System.Drawing.Size(209, 25)
        Me.Judul.TabIndex = 0
        Me.Judul.Text = "INPUT DATA NILAI"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 80)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(132, 24)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nilai Absensi"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 123)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(115, 24)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nilai Tugas"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 166)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(97, 24)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nilai UTS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 210)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(98, 24)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Nilai UAS"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 256)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(105, 24)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Nilai Akhir"
        '
        'TxtAbsensi
        '
        Me.TxtAbsensi.Location = New System.Drawing.Point(234, 85)
        Me.TxtAbsensi.Name = "TxtAbsensi"
        Me.TxtAbsensi.Size = New System.Drawing.Size(76, 20)
        Me.TxtAbsensi.TabIndex = 6
        '
        'TxtHasilAbs
        '
        Me.TxtHasilAbs.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtHasilAbs.Location = New System.Drawing.Point(316, 85)
        Me.TxtHasilAbs.Name = "TxtHasilAbs"
        Me.TxtHasilAbs.Size = New System.Drawing.Size(76, 20)
        Me.TxtHasilAbs.TabIndex = 7
        '
        'TxtTugas
        '
        Me.TxtTugas.Location = New System.Drawing.Point(234, 127)
        Me.TxtTugas.Name = "TxtTugas"
        Me.TxtTugas.Size = New System.Drawing.Size(76, 20)
        Me.TxtTugas.TabIndex = 8
        '
        'TxtHasilTugas
        '
        Me.TxtHasilTugas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtHasilTugas.Location = New System.Drawing.Point(316, 127)
        Me.TxtHasilTugas.Name = "TxtHasilTugas"
        Me.TxtHasilTugas.Size = New System.Drawing.Size(76, 20)
        Me.TxtHasilTugas.TabIndex = 9
        '
        'TxtUts
        '
        Me.TxtUts.Location = New System.Drawing.Point(234, 170)
        Me.TxtUts.Name = "TxtUts"
        Me.TxtUts.Size = New System.Drawing.Size(76, 20)
        Me.TxtUts.TabIndex = 10
        '
        'TxtHasilUts
        '
        Me.TxtHasilUts.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtHasilUts.Location = New System.Drawing.Point(316, 170)
        Me.TxtHasilUts.Name = "TxtHasilUts"
        Me.TxtHasilUts.Size = New System.Drawing.Size(76, 20)
        Me.TxtHasilUts.TabIndex = 11
        '
        'TxtUas
        '
        Me.TxtUas.Location = New System.Drawing.Point(234, 210)
        Me.TxtUas.Name = "TxtUas"
        Me.TxtUas.Size = New System.Drawing.Size(76, 20)
        Me.TxtUas.TabIndex = 12
        '
        'TxtHasilUas
        '
        Me.TxtHasilUas.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtHasilUas.Location = New System.Drawing.Point(316, 210)
        Me.TxtHasilUas.Name = "TxtHasilUas"
        Me.TxtHasilUas.Size = New System.Drawing.Size(76, 20)
        Me.TxtHasilUas.TabIndex = 13
        '
        'TxtNilaiAkhir
        '
        Me.TxtNilaiAkhir.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.TxtNilaiAkhir.Location = New System.Drawing.Point(234, 256)
        Me.TxtNilaiAkhir.Name = "TxtNilaiAkhir"
        Me.TxtNilaiAkhir.Size = New System.Drawing.Size(158, 20)
        Me.TxtNilaiAkhir.TabIndex = 14
        '
        'BtnHitung
        '
        Me.BtnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnHitung.Location = New System.Drawing.Point(102, 299)
        Me.BtnHitung.Name = "BtnHitung"
        Me.BtnHitung.Size = New System.Drawing.Size(204, 35)
        Me.BtnHitung.TabIndex = 15
        Me.BtnHitung.Text = "HITUNG"
        Me.BtnHitung.UseVisualStyleBackColor = True
        '
        'Nilai
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Cyan
        Me.ClientSize = New System.Drawing.Size(404, 373)
        Me.Controls.Add(Me.BtnHitung)
        Me.Controls.Add(Me.TxtNilaiAkhir)
        Me.Controls.Add(Me.TxtHasilUas)
        Me.Controls.Add(Me.TxtUas)
        Me.Controls.Add(Me.TxtHasilUts)
        Me.Controls.Add(Me.TxtUts)
        Me.Controls.Add(Me.TxtHasilTugas)
        Me.Controls.Add(Me.TxtTugas)
        Me.Controls.Add(Me.TxtHasilAbs)
        Me.Controls.Add(Me.TxtAbsensi)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Judul)
        Me.Name = "Nilai"
        Me.Text = "Nilai"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Judul As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TxtAbsensi As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasilAbs As System.Windows.Forms.TextBox
    Friend WithEvents TxtTugas As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasilTugas As System.Windows.Forms.TextBox
    Friend WithEvents TxtUts As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasilUts As System.Windows.Forms.TextBox
    Friend WithEvents TxtUas As System.Windows.Forms.TextBox
    Friend WithEvents TxtHasilUas As System.Windows.Forms.TextBox
    Friend WithEvents TxtNilaiAkhir As System.Windows.Forms.TextBox
    Friend WithEvents BtnHitung As System.Windows.Forms.Button
End Class
