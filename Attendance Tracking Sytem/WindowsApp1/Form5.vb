Public Class Form5
  
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        If txtUsername.Text = "admin" And txtPassword.Text = "admin" Then
            MsgBox("Login Success!")
            Form3.Show()
            Me.Hide()
        Else
            MsgBox("Login Failed, incorrect credentials")

        End If






    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtUsername.Clear()
        txtPassword.Clear()
    End Sub

End Class