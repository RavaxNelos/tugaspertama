<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.label1 = New System.Windows.Forms.Label()
        Me.buttonNext = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtNama = New System.Windows.Forms.TextBox()
        Me.txtNPM = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'label1
        '
        Me.label1.AutoSize = True
        Me.label1.Font = New System.Drawing.Font("Segoe UI", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.label1.Location = New System.Drawing.Point(288, 128)
        Me.label1.Name = "label1"
        Me.label1.Size = New System.Drawing.Size(371, 54)
        Me.label1.TabIndex = 0
        Me.label1.Text = "PENILAIAN AKHIR"
        '
        'buttonNext
        '
        Me.buttonNext.BackColor = System.Drawing.Color.Lime
        Me.buttonNext.Location = New System.Drawing.Point(570, 324)
        Me.buttonNext.Name = "buttonNext"
        Me.buttonNext.Size = New System.Drawing.Size(89, 40)
        Me.buttonNext.TabIndex = 1
        Me.buttonNext.Text = "Next"
        Me.buttonNext.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(223, 206)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(57, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Nama"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(223, 259)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "NPM"
        '
        'txtNama
        '
        Me.txtNama.Location = New System.Drawing.Point(297, 206)
        Me.txtNama.Name = "txtNama"
        Me.txtNama.Size = New System.Drawing.Size(362, 22)
        Me.txtNama.TabIndex = 4
        '
        'txtNPM
        '
        Me.txtNPM.Location = New System.Drawing.Point(297, 259)
        Me.txtNPM.Name = "txtNPM"
        Me.txtNPM.Size = New System.Drawing.Size(362, 22)
        Me.txtNPM.TabIndex = 5
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AcceptButton = Me.buttonNext
        Me.ClientSize = New System.Drawing.Size(940, 478)
        Me.Controls.Add(Me.txtNPM)
        Me.Controls.Add(Me.txtNama)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.buttonNext)
        Me.Controls.Add(Me.label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents label1 As Label
    Friend WithEvents buttonNext As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtNama As TextBox
    Friend WithEvents txtNPM As TextBox
End Class
