<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Perulangan2
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
        Me.ListBox1 = New System.Windows.Forms.ListBox
        Me.bNext = New System.Windows.Forms.Button
        Me.bUntil = New System.Windows.Forms.Button
        Me.bWhile = New System.Windows.Forms.Button
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(163, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PERULANGAN 2"
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(13, 57)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(313, 329)
        Me.ListBox1.TabIndex = 1
        '
        'bNext
        '
        Me.bNext.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bNext.Location = New System.Drawing.Point(332, 71)
        Me.bNext.Name = "bNext"
        Me.bNext.Size = New System.Drawing.Size(128, 56)
        Me.bNext.TabIndex = 2
        Me.bNext.Text = "For Next"
        Me.bNext.UseVisualStyleBackColor = True
        '
        'bUntil
        '
        Me.bUntil.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bUntil.Location = New System.Drawing.Point(332, 195)
        Me.bUntil.Name = "bUntil"
        Me.bUntil.Size = New System.Drawing.Size(128, 56)
        Me.bUntil.TabIndex = 3
        Me.bUntil.Text = "Do Until"
        Me.bUntil.UseVisualStyleBackColor = True
        '
        'bWhile
        '
        Me.bWhile.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.bWhile.Location = New System.Drawing.Point(332, 133)
        Me.bWhile.Name = "bWhile"
        Me.bWhile.Size = New System.Drawing.Size(128, 56)
        Me.bWhile.TabIndex = 4
        Me.bWhile.Text = "Do While"
        Me.bWhile.UseVisualStyleBackColor = True
        '
        'Perulangan2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(472, 428)
        Me.Controls.Add(Me.bWhile)
        Me.Controls.Add(Me.bUntil)
        Me.Controls.Add(Me.bNext)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Perulangan2"
        Me.Text = "Perulangan2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents ListBox1 As System.Windows.Forms.ListBox
    Friend WithEvents bNext As System.Windows.Forms.Button
    Friend WithEvents bUntil As System.Windows.Forms.Button
    Friend WithEvents bWhile As System.Windows.Forms.Button
End Class
