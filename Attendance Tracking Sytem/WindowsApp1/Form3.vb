Imports System.Xml
Imports System.Data.OleDb
Imports System.Linq
Imports Microsoft.Office.core
Imports excel = Microsoft.Office.Interop.Excel
Imports ExcelAutoFormat = Microsoft.Office.Interop.Excel.XlRangeAutoFormat
Imports Microsoft.Office.Interop
Imports System.IO
Imports System.Xml.XPath
Imports System.Data




Public Class Form3

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then


            sqlquery.Connection = sqlconn
            OpenCon()

            Try
                sqlquery.CommandText = "UPDATE tblStudentInfo SET timeIn = '" & DateTime.Now.ToString & "' where studentID = '" & TextBox1.Text & "'"
                sqlquery.ExecuteNonQuery()

                lblStudent.Text = TextBox1.Text
                lblS.Text = DateTime.Now.ToString


            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
            sqlconn.Close()
            e.Handled = True


            Call LoadTable()

            TextBox1.Text = ""
            'Form4.Show()

        End If

    End Sub


    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress
        If e.KeyChar = Microsoft.VisualBasic.ChrW(Keys.Return) Then



            sqlquery.Connection = sqlconn
            OpenCon()

            Try
                sqlquery.CommandText = "UPDATE tblStudentInfo SET timeOut = '" & DateTime.Now.ToString & "' where studentID = '" & TextBox2.Text & "'"
                sqlquery.ExecuteNonQuery()
                lblStudent.Text = TextBox2.Text
                lblS.Text = DateTime.Now.ToString



            Catch ex As Exception
                MessageBox.Show(ex.ToString)

            End Try
            sqlconn.Close()
            e.Handled = True

            Call LoadTable()
            TextBox2.Text = ""

        End If
    End Sub



    Private Sub LoadTable()
        sqlquery.Connection = sqlconn
        OpenCon()
        Try

            sqlquery.CommandText = "SELECT * FROM tblStudentInfo"
            dt.Clear()
            adapter.Fill(dt)
            DataGridView1.DataSource = dt
            sqlconn.Close()


            DataGridView1.DataSource = dt


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


          


        Catch ex As Exception
            MessageBox.Show(ex.ToString)
        End Try
        sqlconn.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged
        If ComboBox1.SelectedItem = "Time In" Then
            TextBox1.Focus()
            Label6.Text = "Time In"


        Else
            TextBox2.Focus()
            Label6.Text = "Time Out"
        End If
    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form1.Show()
        Me.Hide()
    End Sub




    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnExport.Click



        Try
            btnExport.Text = "GENERATING REPORT..."
            btnExport.Enabled = False

            SaveFileDialog1.Filter = "Excel Document (*.xlsx3)|*.xlsx"
            If SaveFileDialog1.ShowDialog() = System.Windows.Forms.DialogResult.OK Then
                Dim xlApp As Microsoft.Office.Interop.Excel.Application
                Dim xlWorkBook As Microsoft.Office.Interop.Excel.Workbook
                Dim xlWorkSheet As Microsoft.Office.Interop.Excel.Worksheet
                Dim misValue As Object = System.Reflection.Missing.Value
                Dim i As Integer
                Dim j As Integer

                xlApp = New Microsoft.Office.Interop.Excel.Application
                xlWorkBook = xlApp.Workbooks.Add(misValue)
                xlWorkSheet = xlWorkBook.Sheets("sheet1")

                For i = 0 To DataGridView1.RowCount - 2
                    For j = 0 To DataGridView1.ColumnCount - 1
                        For k As Integer = 1 To DataGridView1.Columns.Count
                            xlWorkSheet.Cells(1, k) = DataGridView1.Columns(k - 1).HeaderText
                            xlWorkSheet.Cells(i + 2, j + 1) = DataGridView1(j, i).Value.ToString()
                        Next
                    Next
                Next

                xlWorkSheet.SaveAs(SaveFileDialog1.FileName)
                xlWorkBook.Close()
                xlApp.Quit()

                releaseObject(xlApp)
                releaseObject(xlWorkBook)
                releaseObject(xlWorkSheet)


                MsgBox("Successfully saved" & vbCrLf & "Files are saved at : " & SaveFileDialog1.FileName, MsgBoxStyle.Information)
                btnExport.Text = "GENERATE ATTENDANCE REPORT"
                btnExport.Enabled = True

            End If

        Catch ex As Exception
            MsgBox(ex.ToString())
        End Try

    End Sub


    Private Sub releaseObject(ByVal obj As Object)
        Try
            System.Runtime.InteropServices.Marshal.FinalReleaseComObject(obj)
            obj = Nothing
        Catch ex As Exception
            obj = Nothing
        Finally
            GC.Collect()
        End Try
    End Sub


    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
    End Sub

    Private Sub btnLoadTables_Click(sender As Object, e As EventArgs) Handles btnLoadTables.Click
        Call LoadTable()
    End Sub

  
   
End Class