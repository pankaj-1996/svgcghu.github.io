<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_information_form
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
        Me.CMBID = New System.Windows.Forms.ComboBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.NUDGRADUATION = New System.Windows.Forms.NumericUpDown()
        Me.TXTEMAIL = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.CMBACADEMIC = New System.Windows.Forms.ComboBox()
        Me.CMBYEAR = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.CMBCATEGORY = New System.Windows.Forms.ComboBox()
        Me.TXTFATHER = New System.Windows.Forms.TextBox()
        Me.TXTROLLNO = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.CMBCOURSE = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.NUD12 = New System.Windows.Forms.NumericUpDown()
        Me.NUD10 = New System.Windows.Forms.NumericUpDown()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TXTCONTACT = New System.Windows.Forms.TextBox()
        Me.RTXTLOCAL = New System.Windows.Forms.RichTextBox()
        Me.RTXTPERMANENT = New System.Windows.Forms.RichTextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.DTPDOB = New System.Windows.Forms.DateTimePicker()
        Me.TXTNAME = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.LinkLabel1 = New System.Windows.Forms.LinkLabel()
        CType(Me.NUDGRADUATION, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD12, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.NUD10, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'CMBID
        '
        Me.CMBID.FormattingEnabled = True
        Me.CMBID.Location = New System.Drawing.Point(211, 75)
        Me.CMBID.Name = "CMBID"
        Me.CMBID.Size = New System.Drawing.Size(77, 21)
        Me.CMBID.TabIndex = 72
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(688, 491)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 37)
        Me.Button1.TabIndex = 36
        Me.Button1.Text = "&DELETE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(335, 491)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(106, 37)
        Me.Button2.TabIndex = 38
        Me.Button2.Text = "&UPDATE"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button6
        '
        Me.Button6.BackColor = System.Drawing.Color.DarkRed
        Me.Button6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.ForeColor = System.Drawing.Color.White
        Me.Button6.Location = New System.Drawing.Point(513, 575)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(119, 38)
        Me.Button6.TabIndex = 45
        Me.Button6.Text = "&EXIT"
        Me.Button6.UseVisualStyleBackColor = False
        '
        'NUDGRADUATION
        '
        Me.NUDGRADUATION.Location = New System.Drawing.Point(836, 315)
        Me.NUDGRADUATION.Name = "NUDGRADUATION"
        Me.NUDGRADUATION.Size = New System.Drawing.Size(77, 20)
        Me.NUDGRADUATION.TabIndex = 71
        '
        'TXTEMAIL
        '
        Me.TXTEMAIL.Location = New System.Drawing.Point(836, 247)
        Me.TXTEMAIL.Name = "TXTEMAIL"
        Me.TXTEMAIL.Size = New System.Drawing.Size(77, 20)
        Me.TXTEMAIL.TabIndex = 70
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(688, 320)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(68, 15)
        Me.Label17.TabIndex = 69
        Me.Label17.Text = "Graduation"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(685, 252)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(42, 15)
        Me.Label16.TabIndex = 68
        Me.Label16.Text = "E-mail"
        '
        'CMBACADEMIC
        '
        Me.CMBACADEMIC.FormattingEnabled = True
        Me.CMBACADEMIC.Items.AddRange(New Object() {"2014", "2015", "2016", "2017"})
        Me.CMBACADEMIC.Location = New System.Drawing.Point(836, 212)
        Me.CMBACADEMIC.Name = "CMBACADEMIC"
        Me.CMBACADEMIC.Size = New System.Drawing.Size(77, 21)
        Me.CMBACADEMIC.TabIndex = 67
        '
        'CMBYEAR
        '
        Me.CMBYEAR.FormattingEnabled = True
        Me.CMBYEAR.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "3rd Sem", "4th Sem", "5th Sem", "6th Sem"})
        Me.CMBYEAR.Location = New System.Drawing.Point(836, 178)
        Me.CMBYEAR.Name = "CMBYEAR"
        Me.CMBYEAR.Size = New System.Drawing.Size(77, 21)
        Me.CMBYEAR.TabIndex = 66
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(685, 214)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(88, 15)
        Me.Label15.TabIndex = 65
        Me.Label15.Text = "Academic Year"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(685, 182)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(60, 15)
        Me.Label14.TabIndex = 64
        Me.Label14.Text = "Year/Sem"
        '
        'CMBCATEGORY
        '
        Me.CMBCATEGORY.FormattingEnabled = True
        Me.CMBCATEGORY.Items.AddRange(New Object() {"General", "SC", "ST", "OBC", "IRDP"})
        Me.CMBCATEGORY.Location = New System.Drawing.Point(836, 145)
        Me.CMBCATEGORY.Name = "CMBCATEGORY"
        Me.CMBCATEGORY.Size = New System.Drawing.Size(77, 21)
        Me.CMBCATEGORY.TabIndex = 63
        '
        'TXTFATHER
        '
        Me.TXTFATHER.Location = New System.Drawing.Point(836, 110)
        Me.TXTFATHER.Name = "TXTFATHER"
        Me.TXTFATHER.Size = New System.Drawing.Size(77, 20)
        Me.TXTFATHER.TabIndex = 62
        '
        'TXTROLLNO
        '
        Me.TXTROLLNO.Location = New System.Drawing.Point(836, 76)
        Me.TXTROLLNO.Name = "TXTROLLNO"
        Me.TXTROLLNO.Size = New System.Drawing.Size(77, 20)
        Me.TXTROLLNO.TabIndex = 61
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(685, 151)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 15)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Category"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(685, 117)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(77, 15)
        Me.Label12.TabIndex = 59
        Me.Label12.Text = "Father Name"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(685, 83)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(48, 15)
        Me.Label11.TabIndex = 58
        Me.Label11.Text = "Roll No"
        '
        'CMBCOURSE
        '
        Me.CMBCOURSE.FormattingEnabled = True
        Me.CMBCOURSE.Items.AddRange(New Object() {"BCA", "BBA", "Bsc", "BA", "B.Com"})
        Me.CMBCOURSE.Location = New System.Drawing.Point(210, 396)
        Me.CMBCOURSE.Name = "CMBCOURSE"
        Me.CMBCOURSE.Size = New System.Drawing.Size(72, 21)
        Me.CMBCOURSE.TabIndex = 57
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(65, 402)
        Me.Label10.Name = "Label10"
        Me.Label10.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.Label10.Size = New System.Drawing.Size(47, 15)
        Me.Label10.TabIndex = 56
        Me.Label10.Text = "Course"
        '
        'NUD12
        '
        Me.NUD12.Location = New System.Drawing.Point(398, 358)
        Me.NUD12.Name = "NUD12"
        Me.NUD12.Size = New System.Drawing.Size(71, 20)
        Me.NUD12.TabIndex = 55
        '
        'NUD10
        '
        Me.NUD10.Location = New System.Drawing.Point(210, 358)
        Me.NUD10.Name = "NUD10"
        Me.NUD10.Size = New System.Drawing.Size(72, 20)
        Me.NUD10.TabIndex = 54
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(332, 365)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(21, 15)
        Me.Label9.TabIndex = 53
        Me.Label9.Text = "+2"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(65, 363)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(97, 15)
        Me.Label8.TabIndex = 52
        Me.Label8.Text = "Percentage 10th"
        '
        'TXTCONTACT
        '
        Me.TXTCONTACT.Location = New System.Drawing.Point(210, 318)
        Me.TXTCONTACT.Name = "TXTCONTACT"
        Me.TXTCONTACT.Size = New System.Drawing.Size(72, 20)
        Me.TXTCONTACT.TabIndex = 51
        '
        'RTXTLOCAL
        '
        Me.RTXTLOCAL.Location = New System.Drawing.Point(210, 250)
        Me.RTXTLOCAL.Name = "RTXTLOCAL"
        Me.RTXTLOCAL.Size = New System.Drawing.Size(183, 44)
        Me.RTXTLOCAL.TabIndex = 50
        Me.RTXTLOCAL.Text = ""
        '
        'RTXTPERMANENT
        '
        Me.RTXTPERMANENT.Location = New System.Drawing.Point(210, 183)
        Me.RTXTPERMANENT.Name = "RTXTPERMANENT"
        Me.RTXTPERMANENT.Size = New System.Drawing.Size(183, 47)
        Me.RTXTPERMANENT.TabIndex = 49
        Me.RTXTPERMANENT.Text = ""
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(65, 323)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 15)
        Me.Label7.TabIndex = 48
        Me.Label7.Text = "Contact No"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(65, 250)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(63, 15)
        Me.Label6.TabIndex = 47
        Me.Label6.Text = "Local Add."
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(65, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(93, 15)
        Me.Label5.TabIndex = 46
        Me.Label5.Text = "Permanent Add."
        '
        'DTPDOB
        '
        Me.DTPDOB.Location = New System.Drawing.Point(210, 146)
        Me.DTPDOB.Name = "DTPDOB"
        Me.DTPDOB.Size = New System.Drawing.Size(116, 20)
        Me.DTPDOB.TabIndex = 44
        '
        'TXTNAME
        '
        Me.TXTNAME.Location = New System.Drawing.Point(211, 111)
        Me.TXTNAME.Name = "TXTNAME"
        Me.TXTNAME.Size = New System.Drawing.Size(72, 20)
        Me.TXTNAME.TabIndex = 42
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(65, 151)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(35, 15)
        Me.Label4.TabIndex = 39
        Me.Label4.Text = "DOB"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(66, 116)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "Name"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(66, 82)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(65, 15)
        Me.Label2.TabIndex = 35
        Me.Label2.Text = "Student ID"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 36.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.DarkBlue
        Me.Label1.Location = New System.Drawing.Point(271, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(598, 54)
        Me.Label1.TabIndex = 34
        Me.Label1.Text = "STUDENT INFORMATION"
        '
        'LinkLabel1
        '
        Me.LinkLabel1.AutoSize = True
        Me.LinkLabel1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LinkLabel1.ForeColor = System.Drawing.Color.MidnightBlue
        Me.LinkLabel1.LinkColor = System.Drawing.Color.DarkMagenta
        Me.LinkLabel1.Location = New System.Drawing.Point(895, 594)
        Me.LinkLabel1.Name = "LinkLabel1"
        Me.LinkLabel1.Size = New System.Drawing.Size(142, 19)
        Me.LinkLabel1.TabIndex = 73
        Me.LinkLabel1.TabStop = True
        Me.LinkLabel1.Text = "Student Fee Record"
        '
        'student_information_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1067, 634)
        Me.Controls.Add(Me.LinkLabel1)
        Me.Controls.Add(Me.CMBID)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.NUDGRADUATION)
        Me.Controls.Add(Me.TXTEMAIL)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.CMBACADEMIC)
        Me.Controls.Add(Me.CMBYEAR)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.CMBCATEGORY)
        Me.Controls.Add(Me.TXTFATHER)
        Me.Controls.Add(Me.TXTROLLNO)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.CMBCOURSE)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.NUD12)
        Me.Controls.Add(Me.NUD10)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TXTCONTACT)
        Me.Controls.Add(Me.RTXTLOCAL)
        Me.Controls.Add(Me.RTXTPERMANENT)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.DTPDOB)
        Me.Controls.Add(Me.TXTNAME)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "student_information_form"
        Me.Text = "student_information_form"
        CType(Me.NUDGRADUATION, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD12, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.NUD10, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents CMBID As System.Windows.Forms.ComboBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents NUDGRADUATION As System.Windows.Forms.NumericUpDown
    Friend WithEvents TXTEMAIL As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents CMBACADEMIC As System.Windows.Forms.ComboBox
    Friend WithEvents CMBYEAR As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents CMBCATEGORY As System.Windows.Forms.ComboBox
    Friend WithEvents TXTFATHER As System.Windows.Forms.TextBox
    Friend WithEvents TXTROLLNO As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents CMBCOURSE As System.Windows.Forms.ComboBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents NUD12 As System.Windows.Forms.NumericUpDown
    Friend WithEvents NUD10 As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents TXTCONTACT As System.Windows.Forms.TextBox
    Friend WithEvents RTXTLOCAL As System.Windows.Forms.RichTextBox
    Friend WithEvents RTXTPERMANENT As System.Windows.Forms.RichTextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents DTPDOB As System.Windows.Forms.DateTimePicker
    Friend WithEvents TXTNAME As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents LinkLabel1 As System.Windows.Forms.LinkLabel
End Class
