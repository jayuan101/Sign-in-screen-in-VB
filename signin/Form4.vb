Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.Data
Public Class Form4

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim connection As New SqlClient.SqlConnection
        Dim command As New SqlClient.SqlCommand
        Dim adaptor As New SqlClient.SqlDataAdapter
        Dim dataset As New DataSet
        connection.ConnectionString = ("Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Class.CST\Downloads\Database.mdf;Integrated Security=True;Connect Timeout=30")
        command.CommandText = "UPDATE Accounts SET Password='" & Txtpass.Text & "';"
        connection.Open()
        command.Connection = connection
        adaptor.SelectCommand = command
        adaptor.Fill(dataset, "Passwaord")

        MsgBox("Password Changed Successfully", MsgBoxStyle.Information, "Done!")
        Form1.Show()

    End Sub
End Class
