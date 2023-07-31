Public Class Form3

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then



            e.Handled = True
            TextBox1.Text = ""


        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then


            e.Handled = True
            TextBox1.Text = ""


        End If
    End Sub

    Private Sub loadTimeIns()
        sqlquery.Connection = sqlconn
        OpenCon()
        Try

            sqlquery.CommandText = "SELECT * FROM tblAttendees "
            adapter.SelectCommand = sqlquery
            dt.Clear()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            sqlconn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        sqlconn.Close()
    End Sub

    Private Sub loadTimeOuts()
        sqlquery.Connection = sqlconn
        OpenCon()
        Try

            sqlquery.CommandText = "SELECT * FROM tblLeavers "
            adapter.SelectCommand = sqlquery
            dt.Clear()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            sqlconn.Close()


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        sqlconn.Close()
    End Sub

    Private Sub searchTable(Optional ByVal q As String = "")
        sqlquery.Connection = sqlconn
        OpenCon()
        Try


            sqlquery.CommandText = "SELECT * FROM tblStudentInfo WHERE studentID = '" & TextBox1.Text & "'"
            adapter.SelectCommand = sqlquery
            dt.Clear()
            adapter.Fill(dt)


            For i As Integer = 0 To dt.Rows.Count - 1


            Next


            sqlconn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        sqlconn.Close()
    End Sub


   

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    

    Private Sub ComboBox1_MouseClick(sender As Object, e As MouseEventArgs) Handles ComboBox1.MouseClick
       
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Time In" Then
            TextBox1.Focus()
        Else
            TextBox2.Focus()
        End If
    End Sub

    
End Class