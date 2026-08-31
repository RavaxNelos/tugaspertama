<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.lblNama = New System.Windows.Forms.Label()
        Me.tbxNilaiUTS = New System.Windows.Forms.TextBox()
        Me.lblNPM = New System.Windows.Forms.Label()
        Me.tbxNilaiUAS = New System.Windows.Forms.TextBox()
        Me.tbxNilaiPraktikum = New System.Windows.Forms.TextBox()
        Me.Label = New System.Windows.Forms.Label()
        Me.buttonHitung = New System.Windows.Forms.Button()
        Me.buttonReset = New System.Windows.Forms.Button()
        Me.buttonBack = New System.Windows.Forms.Button()
        Me.tbxNilaiAkhir = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(12, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(68, 25)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Nama"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 59)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(59, 25)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "NPM"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label3.Location = New System.Drawing.Point(82, 103)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 20)
        Me.Label3.TabIndex = 2
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(77, 162)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 16)
        Me.Label4.TabIndex = 3
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(12, 98)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 25)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Nilai UTS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 137)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 25)
        Me.Label7.TabIndex = 6
        Me.Label7.Text = "Nilai UAS"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 178)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(155, 25)
        Me.Label8.TabIndex = 7
        Me.Label8.Text = "Nilai Praktikum"
        '
        'lblNama
        '
        Me.lblNama.AutoSize = True
        Me.lblNama.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNama.Location = New System.Drawing.Point(184, 27)
        Me.lblNama.Name = "lblNama"
        Me.lblNama.Size = New System.Drawing.Size(0, 25)
        Me.lblNama.TabIndex = 8
        Me.lblNama.TabStop = False
        '
        'tbxNilaiUTS
        '
        Me.tbxNilaiUTS.Location = New System.Drawing.Point(184, 102)
        Me.tbxNilaiUTS.Name = "tbxNilaiUTS"
        Me.tbxNilaiUTS.Size = New System.Drawing.Size(100, 22)
        Me.tbxNilaiUTS.TabIndex = 9
        Me.tbxNilaiUTS.Text = "0"
        Me.tbxNilaiUTS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'lblNPM
        '
        Me.lblNPM.AutoSize = True
        Me.lblNPM.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNPM.Location = New System.Drawing.Point(184, 65)
        Me.lblNPM.Name = "lblNPM"
        Me.lblNPM.Size = New System.Drawing.Size(0, 25)
        Me.lblNPM.TabIndex = 10
        Me.lblNPM.TabStop = False
        '
        'tbxNilaiUAS
        '
        Me.tbxNilaiUAS.Location = New System.Drawing.Point(184, 141)
        Me.tbxNilaiUAS.Name = "tbxNilaiUAS"
        Me.tbxNilaiUAS.Size = New System.Drawing.Size(100, 22)
        Me.tbxNilaiUAS.TabIndex = 11
        Me.tbxNilaiUAS.Text = "0"
        Me.tbxNilaiUAS.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'tbxNilaiPraktikum
        '
        Me.tbxNilaiPraktikum.Location = New System.Drawing.Point(184, 181)
        Me.tbxNilaiPraktikum.Name = "tbxNilaiPraktikum"
        Me.tbxNilaiPraktikum.Size = New System.Drawing.Size(100, 22)
        Me.tbxNilaiPraktikum.TabIndex = 12
        Me.tbxNilaiPraktikum.Text = "0"
        Me.tbxNilaiPraktikum.TextAlign = System.Windows.Forms.HorizontalAlignment.Right
        '
        'Label
        '
        Me.Label.AutoSize = True
        Me.Label.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Label.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label.Location = New System.Drawing.Point(17, 218)
        Me.Label.Name = "Label"
        Me.Label.Size = New System.Drawing.Size(406, 42)
        Me.Label.TabIndex = 13
        Me.Label.Text = "Rumus Nilai Akhir :" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "(0.3*Nilai UTS)+(0.3*Nilai UAS)+(0.4*Nilai Praktikum)"
        '
        'buttonHitung
        '
        Me.buttonHitung.BackColor = System.Drawing.Color.LightSkyBlue
        Me.buttonHitung.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.buttonHitung.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.buttonHitung.ForeColor = System.Drawing.Color.Red
        Me.buttonHitung.Location = New System.Drawing.Point(17, 285)
        Me.buttonHitung.Name = "buttonHitung"
        Me.buttonHitung.Size = New System.Drawing.Size(252, 47)
        Me.buttonHitung.TabIndex = 14
        Me.buttonHitung.Text = "Hitung"
        Me.buttonHitung.UseVisualStyleBackColor = False
        '
        'buttonReset
        '
        Me.buttonReset.BackColor = System.Drawing.Color.LightCoral
        Me.buttonReset.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.buttonReset.ForeColor = System.Drawing.Color.White
        Me.buttonReset.Location = New System.Drawing.Point(285, 285)
        Me.buttonReset.Name = "buttonReset"
        Me.buttonReset.Size = New System.Drawing.Size(252, 47)
        Me.buttonReset.TabIndex = 16
        Me.buttonReset.Text = "Reset"
        Me.buttonReset.UseVisualStyleBackColor = False
        '
        'buttonBack
        '
        Me.buttonBack.BackColor = System.Drawing.Color.LightGray
        Me.buttonBack.Cursor = System.Windows.Forms.Cursors.IBeam
        Me.buttonBack.ForeColor = System.Drawing.Color.Black
        Me.buttonBack.Location = New System.Drawing.Point(468, 22)
        Me.buttonBack.Name = "buttonBack"
        Me.buttonBack.Size = New System.Drawing.Size(85, 30)
        Me.buttonBack.TabIndex = 17
        Me.buttonBack.Text = "Back"
        Me.buttonBack.UseVisualStyleBackColor = False
        '
        'tbxNilaiAkhir
        '
        Me.tbxNilaiAkhir.Font = New System.Drawing.Font("Microsoft Sans Serif", 72.0!)
        Me.tbxNilaiAkhir.Location = New System.Drawing.Point(17, 338)
        Me.tbxNilaiAkhir.Name = "tbxNilaiAkhir"
        Me.tbxNilaiAkhir.ReadOnly = True
        Me.tbxNilaiAkhir.Size = New System.Drawing.Size(520, 143)
        Me.tbxNilaiAkhir.TabIndex = 15
        Me.tbxNilaiAkhir.Text = "0"
        Me.tbxNilaiAkhir.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(570, 500)
        Me.Controls.Add(Me.tbxNilaiAkhir)
        Me.Controls.Add(Me.buttonBack)
        Me.Controls.Add(Me.buttonReset)
        Me.Controls.Add(Me.buttonHitung)
        Me.Controls.Add(Me.Label)
        Me.Controls.Add(Me.tbxNilaiPraktikum)
        Me.Controls.Add(Me.tbxNilaiUAS)
        Me.Controls.Add(Me.lblNPM)
        Me.Controls.Add(Me.tbxNilaiUTS)
        Me.Controls.Add(Me.lblNama)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Form2"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents lblNama As Label
    Friend WithEvents tbxNilaiUTS As TextBox
    Friend WithEvents lblNPM As Label
    Friend WithEvents tbxNilaiUAS As TextBox
    Friend WithEvents tbxNilaiPraktikum As TextBox
    Friend WithEvents Label As Label
    Friend WithEvents buttonHitung As Button
    Friend WithEvents buttonReset As Button
    Friend WithEvents buttonBack As Button
    Friend WithEvents tbxNilaiAkhir As TextBox
End Class
