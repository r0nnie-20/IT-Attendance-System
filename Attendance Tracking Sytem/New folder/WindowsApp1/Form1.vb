Imports System.Data.OleDb
Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Call LoadTables()


    End Sub

    Private Sub LoadTables()
        sqlquery.Connection = sqlconn
        OpenCon()
        Try

            sqlquery.CommandText = "SELECT * FROM tblStudentInfo "
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

    Private Sub BtnInsert_Click(sender As Object, e As EventArgs) Handles btnInsert.Click


        sqlquery.Connection = sqlconn
        OpenCon()

        Try

            sqlquery.CommandText = "INSERT INTO tblStudentInfo(studentID,firstName,middleName,lastName,program,gender,yearLevel) VALUES('" & tbsid.Text & "', '" & tbfname.Text & "', '" & tbmname.Text & "', '" & tblname.Text & "' , '" & tbprogram.Text & "', '" & tbgender.Text & "','" & tbyearlevel.Text & "')"
            sqlquery.ExecuteNonQuery()
            MessageBox.Show("Successfully Registered")

        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

        sqlconn.Close()


        Call LoadTables()

        tbsid.Clear()
        tbfname.Clear()
        tbmname.Clear()
        tblname.Clear()
        tbprogram.Clear()








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






            DataGridView1.DataSource = dt
            sqlconn.Close()



        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        sqlconn.Close()


    End Sub



    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Call searchTable()

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        sqlquery.Connection = sqlconn
        OpenCon()

        Try
            sqlquery.CommandText = "UPDATE tblStudentInfo SET studentID = '" & tbsid.Text & "', firstName = '" & tbfname.Text & "', middleName = '" & tbmname.Text & "', lastName = '" & tblname.Text & "', program = '" & tbprogram.Text & "' WHERE studentID = '" & TextBox1.Text & "'"
            sqlquery.ExecuteNonQuery()

            MessageBox.Show("Updated Record")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try
        sqlconn.Close()

        Call LoadTables()

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click

        sqlquery.Connection = sqlconn
        OpenCon()
        Try
            sqlquery.CommandText = "DELETE * FROM tblStudentInfo WHERE studentID = '" & TextBox1.Text & "'"
            sqlquery.ExecuteNonQuery()

            MessageBox.Show("Record Deleted")
        Catch ex As Exception
            MessageBox.Show(ex.ToString)

        End Try

        sqlconn.Close()


        Call LoadTables()



    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then
            Call searchTable()
            e.Handled = True
            TextBox1.Text = ""

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
        Me.Hide()

    End Sub

   
End Class
