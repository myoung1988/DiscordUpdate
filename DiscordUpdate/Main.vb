Public Class Main
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Me.Text = TextBox1.Text
        MessageBox.Show(Me, "Discord", "Once running, add it under User Settings > Game", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = Me.Text
    End Sub
End Class
