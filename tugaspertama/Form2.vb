Public Class Form2

    'Constructor biasa
    Public Sub New()
        InitializeComponent()
    End Sub

    'Constructor untuk menerima Nama dan NPM dari Form1
    Public Sub New(nama As String, npm As String)
        InitializeComponent()

        tbxNama.Text = nama
        tbxNPM.Text = npm
    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Dim uts, uas, praktikum, nilaiAkhir As Double

    Private Sub buttonHitung_Click(sender As Object, e As EventArgs) Handles buttonHitung.Click

        uts = CDbl(tbxNilaiUTS.Text)
        uas = CDbl(tbxNilaiUAS.Text)
        praktikum = CDbl(tbxNilaiPraktikum.Text)

        nilaiAkhir = (0.3 * uts) + (0.3 * uas) + (0.4 * praktikum)

        tbxNilaiAkhir.Text = nilaiAkhir.ToString()

    End Sub

    Private Sub buttonReset_Click(sender As Object, e As EventArgs) Handles buttonReset.Click

        tbxNilaiUTS.Text = "0"
        tbxNilaiUAS.Text = "0"
        tbxNilaiPraktikum.Text = "0"
        tbxNilaiAkhir.Text = "0"

    End Sub

End Class