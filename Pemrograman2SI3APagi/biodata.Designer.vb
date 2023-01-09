<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class biodata
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.Label4 = New System.Windows.Forms.Label
        Me.Label5 = New System.Windows.Forms.Label
        Me.Label6 = New System.Windows.Forms.Label
        Me.txtNpm = New System.Windows.Forms.TextBox
        Me.cbKelamin = New System.Windows.Forms.ComboBox
        Me.txtNama = New System.Windows.Forms.TextBox
        Me.cbJurusan = New System.Windows.Forms.ComboBox
        Me.cbSemester = New System.Windows.Forms.ComboBox
        Me.btnOk = New System.Windows.Forms.Button
        Me.btnKeluar = New System.Windows.Forms.Button
        Me.Label7 = New System.Windows.Forms.Label
        Me.Label8 = New System.Windows.Forms.Label
        Me.Label9 = New System.Windows.Forms.Label
        Me.Label10 = New System.Windows.Forms.Label
        Me.Label11 = New System.Windows.Forms.Label
        Me.Label12 = New System.Windows.Forms.Label
        Me.Label13 = New System.Windows.Forms.Label
        Me.Label14 = New System.Windows.Forms.Label
        Me.Label15 = New System.Windows.Forms.Label
        Me.Label16 = New System.Windows.Forms.Label
        Me.lblNpm = New System.Windows.Forms.Label
        Me.lblNama = New System.Windows.Forms.Label
        Me.lblKelamin = New System.Windows.Forms.Label
        Me.lblJurusan = New System.Windows.Forms.Label
        Me.lblSemester = New System.Windows.Forms.Label
        Me.Label17 = New System.Windows.Forms.Label
        Me.CheckBoxMembaca = New System.Windows.Forms.CheckBox
        Me.CheckBoxMusik = New System.Windows.Forms.CheckBox
        Me.CheckBoxOlahraga = New System.Windows.Forms.CheckBox
        Me.Label18 = New System.Windows.Forms.Label
        Me.Label19 = New System.Windows.Forms.Label
        Me.lblMembaca = New System.Windows.Forms.Label
        Me.lblMusik = New System.Windows.Forms.Label
        Me.lblOlahraga = New System.Windows.Forms.Label
        Me.Label20 = New System.Windows.Forms.Label
        Me.Label21 = New System.Windows.Forms.Label
        Me.Label22 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(132, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(253, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "MENAMPILKAN BIODATA"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 71)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Input NPM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 96)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Input Nama"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(119, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Jenis Kelamin"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 150)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Jurusan"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 177)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(86, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Semester"
        '
        'txtNpm
        '
        Me.txtNpm.Location = New System.Drawing.Point(302, 70)
        Me.txtNpm.Name = "txtNpm"
        Me.txtNpm.Size = New System.Drawing.Size(166, 20)
        Me.txtNpm.TabIndex = 6
        '
        'cbKelamin
        '
        Me.cbKelamin.FormattingEnabled = True
        Me.cbKelamin.Items.AddRange(New Object() {"Laki-laki", "Perempuan"})
        Me.cbKelamin.Location = New System.Drawing.Point(302, 122)
        Me.cbKelamin.Name = "cbKelamin"
        Me.cbKelamin.Size = New System.Drawing.Size(166, 21)
        Me.cbKelamin.TabIndex = 7
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(302, 96)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(166, 20)
        Me.txtNama.TabIndex = 8
        '
        'cbJurusan
        '
        Me.cbJurusan.FormattingEnabled = True
        Me.cbJurusan.Items.AddRange(New Object() {"SI", "TI", "AKUTANSI"})
        Me.cbJurusan.Location = New System.Drawing.Point(302, 149)
        Me.cbJurusan.Name = "cbJurusan"
        Me.cbJurusan.Size = New System.Drawing.Size(166, 21)
        Me.cbJurusan.TabIndex = 9
        '
        'cbSemester
        '
        Me.cbSemester.FormattingEnabled = True
        Me.cbSemester.Items.AddRange(New Object() {"1", "2", "3", "4", "5", "6", "7", "8"})
        Me.cbSemester.Location = New System.Drawing.Point(302, 176)
        Me.cbSemester.Name = "cbSemester"
        Me.cbSemester.Size = New System.Drawing.Size(166, 21)
        Me.cbSemester.TabIndex = 10
        '
        'btnOk
        '
        Me.btnOk.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOk.Location = New System.Drawing.Point(138, 243)
        Me.btnOk.Name = "btnOk"
        Me.btnOk.Size = New System.Drawing.Size(83, 33)
        Me.btnOk.TabIndex = 11
        Me.btnOk.Text = "OK"
        Me.btnOk.UseVisualStyleBackColor = True
        '
        'btnKeluar
        '
        Me.btnKeluar.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnKeluar.Location = New System.Drawing.Point(302, 243)
        Me.btnKeluar.Name = "btnKeluar"
        Me.btnKeluar.Size = New System.Drawing.Size(83, 33)
        Me.btnKeluar.TabIndex = 12
        Me.btnKeluar.Text = "Keluar"
        Me.btnKeluar.UseVisualStyleBackColor = True
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 291)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 20)
        Me.Label7.TabIndex = 13
        Me.Label7.Text = "NPM"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 325)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 20)
        Me.Label8.TabIndex = 14
        Me.Label8.Text = "NAMA"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 362)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(119, 20)
        Me.Label9.TabIndex = 15
        Me.Label9.Text = "Jenis Kelamin"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 396)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(73, 20)
        Me.Label10.TabIndex = 16
        Me.Label10.Text = "Jurusan"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(12, 434)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(86, 20)
        Me.Label11.TabIndex = 17
        Me.Label11.Text = "Semester"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(137, 291)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(14, 20)
        Me.Label12.TabIndex = 18
        Me.Label12.Text = ":"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(137, 325)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(14, 20)
        Me.Label13.TabIndex = 19
        Me.Label13.Text = ":"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(137, 376)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(14, 20)
        Me.Label14.TabIndex = 20
        Me.Label14.Text = ":"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(137, 396)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(14, 20)
        Me.Label15.TabIndex = 21
        Me.Label15.Text = ":"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(137, 434)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(14, 20)
        Me.Label16.TabIndex = 22
        Me.Label16.Text = ":"
        '
        'lblNpm
        '
        Me.lblNpm.AutoSize = True
        Me.lblNpm.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNpm.Location = New System.Drawing.Point(175, 291)
        Me.lblNpm.Name = "lblNpm"
        Me.lblNpm.Size = New System.Drawing.Size(19, 20)
        Me.lblNpm.TabIndex = 23
        Me.lblNpm.Text = "1"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(175, 325)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(19, 20)
        Me.lblNama.TabIndex = 24
        Me.lblNama.Text = "1"
        '
        'lblKelamin
        '
        Me.lblKelamin.AutoSize = True
        Me.lblKelamin.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblKelamin.Location = New System.Drawing.Point(175, 362)
        Me.lblKelamin.Name = "lblKelamin"
        Me.lblKelamin.Size = New System.Drawing.Size(19, 20)
        Me.lblKelamin.TabIndex = 25
        Me.lblKelamin.Text = "1"
        '
        'lblJurusan
        '
        Me.lblJurusan.AutoSize = True
        Me.lblJurusan.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblJurusan.Location = New System.Drawing.Point(175, 396)
        Me.lblJurusan.Name = "lblJurusan"
        Me.lblJurusan.Size = New System.Drawing.Size(19, 20)
        Me.lblJurusan.TabIndex = 26
        Me.lblJurusan.Text = "1"
        '
        'lblSemester
        '
        Me.lblSemester.AutoSize = True
        Me.lblSemester.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSemester.Location = New System.Drawing.Point(175, 434)
        Me.lblSemester.Name = "lblSemester"
        Me.lblSemester.Size = New System.Drawing.Size(19, 20)
        Me.lblSemester.TabIndex = 27
        Me.lblSemester.Text = "1"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(12, 207)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(46, 20)
        Me.Label17.TabIndex = 28
        Me.Label17.Text = "Hobi"
        '
        'CheckBoxMembaca
        '
        Me.CheckBoxMembaca.AutoSize = True
        Me.CheckBoxMembaca.Location = New System.Drawing.Point(302, 207)
        Me.CheckBoxMembaca.Name = "CheckBoxMembaca"
        Me.CheckBoxMembaca.Size = New System.Drawing.Size(75, 17)
        Me.CheckBoxMembaca.TabIndex = 29
        Me.CheckBoxMembaca.Text = "membaca,"
        Me.CheckBoxMembaca.UseVisualStyleBackColor = True
        '
        'CheckBoxMusik
        '
        Me.CheckBoxMusik.AutoSize = True
        Me.CheckBoxMusik.Location = New System.Drawing.Point(380, 207)
        Me.CheckBoxMusik.Name = "CheckBoxMusik"
        Me.CheckBoxMusik.Size = New System.Drawing.Size(57, 17)
        Me.CheckBoxMusik.TabIndex = 30
        Me.CheckBoxMusik.Text = "Musik,"
        Me.CheckBoxMusik.UseVisualStyleBackColor = True
        '
        'CheckBoxOlahraga
        '
        Me.CheckBoxOlahraga.AutoSize = True
        Me.CheckBoxOlahraga.Location = New System.Drawing.Point(440, 207)
        Me.CheckBoxOlahraga.Name = "CheckBoxOlahraga"
        Me.CheckBoxOlahraga.Size = New System.Drawing.Size(72, 17)
        Me.CheckBoxOlahraga.TabIndex = 31
        Me.CheckBoxOlahraga.Text = "Olahraga,"
        Me.CheckBoxOlahraga.UseVisualStyleBackColor = True
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(12, 454)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(46, 20)
        Me.Label18.TabIndex = 32
        Me.Label18.Text = "Hobi"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(137, 454)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(14, 20)
        Me.Label19.TabIndex = 33
        Me.Label19.Text = ":"
        '
        'lblMembaca
        '
        Me.lblMembaca.AutoSize = True
        Me.lblMembaca.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMembaca.Location = New System.Drawing.Point(206, 451)
        Me.lblMembaca.Name = "lblMembaca"
        Me.lblMembaca.Size = New System.Drawing.Size(95, 20)
        Me.lblMembaca.TabIndex = 34
        Me.lblMembaca.Text = "Label Hobi"
        '
        'lblMusik
        '
        Me.lblMusik.AutoSize = True
        Me.lblMusik.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblMusik.Location = New System.Drawing.Point(187, 471)
        Me.lblMusik.Name = "lblMusik"
        Me.lblMusik.Size = New System.Drawing.Size(0, 20)
        Me.lblMusik.TabIndex = 35
        '
        'lblOlahraga
        '
        Me.lblOlahraga.AutoSize = True
        Me.lblOlahraga.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlahraga.Location = New System.Drawing.Point(187, 491)
        Me.lblOlahraga.Name = "lblOlahraga"
        Me.lblOlahraga.Size = New System.Drawing.Size(0, 20)
        Me.lblOlahraga.TabIndex = 36
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(157, 451)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(19, 20)
        Me.Label20.TabIndex = 37
        Me.Label20.Text = "1"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.Location = New System.Drawing.Point(157, 471)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(0, 20)
        Me.Label21.TabIndex = 38
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.Location = New System.Drawing.Point(157, 491)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(0, 20)
        Me.Label22.TabIndex = 39
        '
        'biodata
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(529, 486)
        Me.Controls.Add(Me.Label22)
        Me.Controls.Add(Me.Label21)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.lblOlahraga)
        Me.Controls.Add(Me.lblMusik)
        Me.Controls.Add(Me.lblMembaca)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.CheckBoxOlahraga)
        Me.Controls.Add(Me.CheckBoxMusik)
        Me.Controls.Add(Me.CheckBoxMembaca)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.lblSemester)
        Me.Controls.Add(Me.lblJurusan)
        Me.Controls.Add(Me.lblKelamin)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.lblNpm)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.btnKeluar)
        Me.Controls.Add(Me.btnOk)
        Me.Controls.Add(Me.cbSemester)
        Me.Controls.Add(Me.cbJurusan)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.cbKelamin)
        Me.Controls.Add(Me.txtNpm)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "biodata"
        Me.Text = "biodata"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtNpm As System.Windows.Forms.TextBox
    Friend WithEvents cbKelamin As System.Windows.Forms.ComboBox
    Friend WithEvents txtNama As System.Windows.Forms.TextBox
    Friend WithEvents cbJurusan As System.Windows.Forms.ComboBox
    Friend WithEvents cbSemester As System.Windows.Forms.ComboBox
    Friend WithEvents btnOk As System.Windows.Forms.Button
    Friend WithEvents btnKeluar As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents lblNpm As System.Windows.Forms.Label
    Friend WithEvents lblNama As System.Windows.Forms.Label
    Friend WithEvents lblKelamin As System.Windows.Forms.Label
    Friend WithEvents lblJurusan As System.Windows.Forms.Label
    Friend WithEvents lblSemester As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents CheckBoxMembaca As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxMusik As System.Windows.Forms.CheckBox
    Friend WithEvents CheckBoxOlahraga As System.Windows.Forms.CheckBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents lblMembaca As System.Windows.Forms.Label
    Friend WithEvents lblMusik As System.Windows.Forms.Label
    Friend WithEvents lblOlahraga As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
End Class
