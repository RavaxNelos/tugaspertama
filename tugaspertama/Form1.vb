Public Class Form1
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles label1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub buttonNext_Click(sender As Object, e As EventArgs) Handles buttonNext.Click
        Dim nama As String = txtNama.Text
        Dim npm As String = txtNPM.Text

        Dim form2 As New Form2(nama, npm)
        form2.Show()

        Me.Hide()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub
End Class
