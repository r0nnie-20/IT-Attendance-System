<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.btnInsert = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.tbsid = New System.Windows.Forms.TextBox()
        Me.tbfname = New System.Windows.Forms.TextBox()
        Me.tbmname = New System.Windows.Forms.TextBox()
        Me.tblname = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.tbgender = New System.Windows.Forms.ComboBox()
        Me.tbprogram = New System.Windows.Forms.ComboBox()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnInsert
        '
        Me.btnInsert.ForeColor = System.Drawing.SystemColors.ControlText
        Me.btnInsert.Image = CType(resources.GetObject("btnInsert.Image"), System.Drawing.Image)
        Me.btnInsert.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.btnInsert.Location = New System.Drawing.Point(12, 398)
        Me.btnInsert.Name = "btnInsert"
        Me.btnInsert.Size = New System.Drawing.Size(85, 40)
        Me.btnInsert.TabIndex = 12
        Me.btnInsert.Text = "INSERT"
        Me.btnInsert.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnInsert.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.Location = New System.Drawing.Point(103, 398)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(85, 40)
        Me.Button2.TabIndex = 13
        Me.Button2.Text = "SEARCH"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = CType(resources.GetObject("Button3.Image"), System.Drawing.Image)
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.Location = New System.Drawing.Point(194, 398)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(85, 40)
        Me.Button3.TabIndex = 14
        Me.Button3.Text = "UPDATE"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Image = CType(resources.GetObject("Button4.Image"), System.Drawing.Image)
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.Location = New System.Drawing.Point(285, 398)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(85, 40)
        Me.Button4.TabIndex = 15
        Me.Button4.Text = "DELETE"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 87)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersWidth = 62
        Me.DataGridView1.Size = New System.Drawing.Size(632, 279)
        Me.DataGridView1.TabIndex = 4
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(12, 372)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(358, 20)
        Me.TextBox1.TabIndex = 5
        '
        'tbsid
        '
        Me.tbsid.Location = New System.Drawing.Point(12, 61)
        Me.tbsid.Name = "tbsid"
        Me.tbsid.Size = New System.Drawing.Size(100, 20)
        Me.tbsid.TabIndex = 6
        '
        'tbfname
        '
        Me.tbfname.Location = New System.Drawing.Point(118, 61)
        Me.tbfname.Name = "tbfname"
        Me.tbfname.Size = New System.Drawing.Size(100, 20)
        Me.tbfname.TabIndex = 7
        '
        'tbmname
        '
        Me.tbmname.Location = New System.Drawing.Point(224, 61)
        Me.tbmname.Name = "tbmname"
        Me.tbmname.Size = New System.Drawing.Size(100, 20)
        Me.tbmname.TabIndex = 8
        '
        'tblname
        '
        Me.tblname.Location = New System.Drawing.Point(330, 61)
        Me.tblname.Name = "tblname"
        Me.tblname.Size = New System.Drawing.Size(100, 20)
        Me.tblname.TabIndex = 9
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(29, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(57, 15)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "studentid"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(132, 32)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(67, 15)
        Me.Label2.TabIndex = 12
        Me.Label2.Text = "First Name"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(232, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(82, 15)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "Middle Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(344, 32)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(67, 15)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Last Name"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(433, 32)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Program/Course"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(469, 398)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(175, 40)
        Me.Button1.TabIndex = 16
        Me.Button1.Text = "VIEW TIME IN TIME OUT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(571, 32)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(48, 15)
        Me.Label6.TabIndex = 17
        Me.Label6.Text = "Gender"
        '
        'tbgender
        '
        Me.tbgender.FormattingEnabled = True
        Me.tbgender.Items.AddRange(New Object() {"MALE", "FEMALE"})
        Me.tbgender.Location = New System.Drawing.Point(545, 60)
        Me.tbgender.Name = "tbgender"
        Me.tbgender.Size = New System.Drawing.Size(99, 21)
        Me.tbgender.TabIndex = 11
        '
        'tbprogram
        '
        Me.tbprogram.FormattingEnabled = True
        Me.tbprogram.Items.AddRange(New Object() {"BSIT" & Global.Microsoft.VisualBasic.ChrW(9), "BSCS"})
        Me.tbprogram.Location = New System.Drawing.Point(436, 60)
        Me.tbprogram.Name = "tbprogram"
        Me.tbprogram.Size = New System.Drawing.Size(103, 21)
        Me.tbprogram.TabIndex = 10
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.SaddleBrown
        Me.ClientSize = New System.Drawing.Size(661, 450)
        Me.Controls.Add(Me.tbprogram)
        Me.Controls.Add(Me.tbgender)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.tblname)
        Me.Controls.Add(Me.tbmname)
        Me.Controls.Add(Me.tbfname)
        Me.Controls.Add(Me.tbsid)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.btnInsert)
        Me.Name = "Form1"
        Me.Text = "INFORMATION MANAGEMENT"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnInsert As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Button4 As Button
    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents tbsid As TextBox
    Friend WithEvents tbfname As TextBox
    Friend WithEvents tbmname As TextBox
    Friend WithEvents tblname As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents tbgender As System.Windows.Forms.ComboBox
    Friend WithEvents tbprogram As System.Windows.Forms.ComboBox
End Class
