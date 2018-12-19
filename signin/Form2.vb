Public Class Form2
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'REGISTER BUTTON
        My.Settings.username = TextBox1.Text
        My.Settings.password = TextBox2.Text
        My.Settings.Save()
        MsgBox("Account Created!")
        Me.Hide()
        Form1.Show()
        'REGISTER BUTTON
    End Sub

End Class