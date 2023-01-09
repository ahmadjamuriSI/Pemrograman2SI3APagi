<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class latihan1
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
        Me.txtPraktek = New System.Windows.Forms.TextBox
        Me.txtHasilPraktek = New System.Windows.Forms.TextBox
        Me.txtHarian = New System.Windows.Forms.TextBox
        Me.txtHasilHarian = New System.Windows.Forms.TextBox
        Me.txtMID = New System.Windows.Forms.TextBox
        Me.txtHasilMID = New System.Windows.Forms.TextBox
        Me.txtUN = New System.Windows.Forms.TextBox
        Me.txtHasilUN = New System.Windows.Forms.TextBox
        Me.txtAkhir = New System.Windows.Forms.TextBox
        Me.btnHitung = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(133, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "INPUT NILAI"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 67)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(149, 20)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Nilai Praktek 20%"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 120)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(141, 20)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nilai Harian 15%"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(12, 170)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(121, 20)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Nilai MID 30%"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 228)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(113, 20)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Nilai UN 35%"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 293)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(89, 20)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nilai Akhir"
        '
        'txtPraktek
        '
        Me.txtPraktek.Location = New System.Drawing.Point(235, 69)
        Me.txtPraktek.Name = "txtPraktek"
        Me.txtPraktek.Size = New System.Drawing.Size(100, 20)
        Me.txtPraktek.TabIndex = 6
        '
        'txtHasilPraktek
        '
        Me.txtHasilPraktek.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilPraktek.Location = New System.Drawing.Point(341, 69)
        Me.txtHasilPraktek.Name = "txtHasilPraktek"
        Me.txtHasilPraktek.Size = New System.Drawing.Size(100, 20)
        Me.txtHasilPraktek.TabIndex = 7
        '
        'txtHarian
        '
        Me.txtHarian.Location = New System.Drawing.Point(235, 122)
        Me.txtHarian.Name = "txtHarian"
        Me.txtHarian.Size = New System.Drawing.Size(100, 20)
        Me.txtHarian.TabIndex = 8
        '
        'txtHasilHarian
        '
        Me.txtHasilHarian.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilHarian.Location = New System.Drawing.Point(341, 122)
        Me.txtHasilHarian.Name = "txtHasilHarian"
        Me.txtHasilHarian.Size = New System.Drawing.Size(100, 20)
        Me.txtHasilHarian.TabIndex = 9
        '
        'txtMID
        '
        Me.txtMID.Location = New System.Drawing.Point(235, 172)
        Me.txtMID.Name = "txtMID"
        Me.txtMID.Size = New System.Drawing.Size(100, 20)
        Me.txtMID.TabIndex = 10
        '
        'txtHasilMID
        '
        Me.txtHasilMID.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilMID.Location = New System.Drawing.Point(341, 172)
        Me.txtHasilMID.Name = "txtHasilMID"
        Me.txtHasilMID.Size = New System.Drawing.Size(100, 20)
        Me.txtHasilMID.TabIndex = 11
        '
        'txtUN
        '
        Me.txtUN.Location = New System.Drawing.Point(235, 228)
        Me.txtUN.Name = "txtUN"
        Me.txtUN.Size = New System.Drawing.Size(100, 20)
        Me.txtUN.TabIndex = 12
        '
        'txtHasilUN
        '
        Me.txtHasilUN.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.txtHasilUN.Location = New System.Drawing.Point(341, 228)
        Me.txtHasilUN.Name = "txtHasilUN"
        Me.txtHasilUN.Size = New System.Drawing.Size(100, 20)
        Me.txtHasilUN.TabIndex = 13
        '
        'txtAkhir
        '
        Me.txtAkhir.Location = New System.Drawing.Point(235, 295)
        Me.txtAkhir.Name = "txtAkhir"
        Me.txtAkhir.Size = New System.Drawing.Size(206, 20)
        Me.txtAkhir.TabIndex = 14
        '
        'btnHitung
        '
        Me.btnHitung.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnHitung.Location = New System.Drawing.Point(157, 352)
        Me.btnHitung.Name = "btnHitung"
        Me.btnHitung.Size = New System.Drawing.Size(157, 51)
        Me.btnHitung.TabIndex = 15
        Me.btnHitung.Text = "HITUNG"
        Me.btnHitung.UseVisualStyleBackColor = True
        '
        'latihan1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(478, 415)
        Me.Controls.Add(Me.btnHitung)
        Me.Controls.Add(Me.txtAkhir)
        Me.Controls.Add(Me.txtHasilUN)
        Me.Controls.Add(Me.txtUN)
        Me.Controls.Add(Me.txtHasilMID)
        Me.Controls.Add(Me.txtMID)
        Me.Controls.Add(Me.txtHasilHarian)
        Me.Controls.Add(Me.txtHarian)
        Me.Controls.Add(Me.txtHasilPraktek)
        Me.Controls.Add(Me.txtPraktek)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "latihan1"
        Me.Text = "latihan1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txtPraktek As System.Windows.Forms.TextBox
    Friend WithEvents txtHasilPraktek As System.Windows.Forms.TextBox
    Friend WithEvents txtHarian As System.Windows.Forms.TextBox
    Friend WithEvents txtHasilHarian As System.Windows.Forms.TextBox
    Friend WithEvents txtMID As System.Windows.Forms.TextBox
    Friend WithEvents txtHasilMID As System.Windows.Forms.TextBox
    Friend WithEvents txtUN As System.Windows.Forms.TextBox
    Friend WithEvents txtHasilUN As System.Windows.Forms.TextBox
    Friend WithEvents txtAkhir As System.Windows.Forms.TextBox
    Friend WithEvents btnHitung As System.Windows.Forms.Button
End Class
