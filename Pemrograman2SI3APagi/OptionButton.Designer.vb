<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class OptionButton
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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox
        Me.rbIga = New System.Windows.Forms.RadioButton
        Me.rbDaging = New System.Windows.Forms.RadioButton
        Me.rbAyam = New System.Windows.Forms.RadioButton
        Me.GroupBox2 = New System.Windows.Forms.GroupBox
        Me.rbJeruk = New System.Windows.Forms.RadioButton
        Me.rbTehManis = New System.Windows.Forms.RadioButton
        Me.rbTehManisHangat = New System.Windows.Forms.RadioButton
        Me.Label2 = New System.Windows.Forms.Label
        Me.Label3 = New System.Windows.Forms.Label
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(127, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(211, 24)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Menggunakan Option"
        '
        'GroupBox1
        '
        Me.GroupBox1.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox1.Controls.Add(Me.rbIga)
        Me.GroupBox1.Controls.Add(Me.rbDaging)
        Me.GroupBox1.Controls.Add(Me.rbAyam)
        Me.GroupBox1.Location = New System.Drawing.Point(13, 71)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(214, 167)
        Me.GroupBox1.TabIndex = 1
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "List Makanan"
        '
        'rbIga
        '
        Me.rbIga.AutoSize = True
        Me.rbIga.Location = New System.Drawing.Point(27, 128)
        Me.rbIga.Name = "rbIga"
        Me.rbIga.Size = New System.Drawing.Size(65, 17)
        Me.rbIga.TabIndex = 2
        Me.rbIga.TabStop = True
        Me.rbIga.Text = "Soto Iga"
        Me.rbIga.UseVisualStyleBackColor = True
        '
        'rbDaging
        '
        Me.rbDaging.AutoSize = True
        Me.rbDaging.Location = New System.Drawing.Point(27, 77)
        Me.rbDaging.Name = "rbDaging"
        Me.rbDaging.Size = New System.Drawing.Size(84, 17)
        Me.rbDaging.TabIndex = 1
        Me.rbDaging.TabStop = True
        Me.rbDaging.Text = "Soto Daging"
        Me.rbDaging.UseVisualStyleBackColor = True
        '
        'rbAyam
        '
        Me.rbAyam.AutoSize = True
        Me.rbAyam.Location = New System.Drawing.Point(27, 31)
        Me.rbAyam.Name = "rbAyam"
        Me.rbAyam.Size = New System.Drawing.Size(76, 17)
        Me.rbAyam.TabIndex = 0
        Me.rbAyam.TabStop = True
        Me.rbAyam.Text = "Soto Ayam"
        Me.rbAyam.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.BackColor = System.Drawing.Color.PaleTurquoise
        Me.GroupBox2.Controls.Add(Me.rbJeruk)
        Me.GroupBox2.Controls.Add(Me.rbTehManis)
        Me.GroupBox2.Controls.Add(Me.rbTehManisHangat)
        Me.GroupBox2.Location = New System.Drawing.Point(233, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(214, 167)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "List Minuman"
        '
        'rbJeruk
        '
        Me.rbJeruk.AutoSize = True
        Me.rbJeruk.Location = New System.Drawing.Point(26, 128)
        Me.rbJeruk.Name = "rbJeruk"
        Me.rbJeruk.Size = New System.Drawing.Size(66, 17)
        Me.rbJeruk.TabIndex = 2
        Me.rbJeruk.TabStop = True
        Me.rbJeruk.Text = "Es Jeruk"
        Me.rbJeruk.UseVisualStyleBackColor = True
        '
        'rbTehManis
        '
        Me.rbTehManis.AutoSize = True
        Me.rbTehManis.Location = New System.Drawing.Point(26, 77)
        Me.rbTehManis.Name = "rbTehManis"
        Me.rbTehManis.Size = New System.Drawing.Size(90, 17)
        Me.rbTehManis.TabIndex = 1
        Me.rbTehManis.TabStop = True
        Me.rbTehManis.Text = "Es Teh Manis"
        Me.rbTehManis.UseVisualStyleBackColor = True
        '
        'rbTehManisHangat
        '
        Me.rbTehManisHangat.AutoSize = True
        Me.rbTehManisHangat.Location = New System.Drawing.Point(26, 31)
        Me.rbTehManisHangat.Name = "rbTehManisHangat"
        Me.rbTehManisHangat.Size = New System.Drawing.Size(113, 17)
        Me.rbTehManisHangat.TabIndex = 0
        Me.rbTehManisHangat.TabStop = True
        Me.rbTehManisHangat.Text = "Teh Manis Hangat"
        Me.rbTehManisHangat.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 257)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 24)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Label 2"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 304)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(78, 24)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Label 3"
        '
        'OptionButton
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(650, 355)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "OptionButton"
        Me.Text = "OptionButton"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rbIga As System.Windows.Forms.RadioButton
    Friend WithEvents rbDaging As System.Windows.Forms.RadioButton
    Friend WithEvents rbAyam As System.Windows.Forms.RadioButton
    Friend WithEvents rbJeruk As System.Windows.Forms.RadioButton
    Friend WithEvents rbTehManis As System.Windows.Forms.RadioButton
    Friend WithEvents rbTehManisHangat As System.Windows.Forms.RadioButton
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
