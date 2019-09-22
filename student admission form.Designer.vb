<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class student_admission_form
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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.cmbacademic = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtname = New System.Windows.Forms.TextBox()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.nudtenth = New System.Windows.Forms.NumericUpDown()
        Me.nudplustwo = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.rtxtpermanent = New System.Windows.Forms.RichTextBox()
        Me.rtxtlocal = New System.Windows.Forms.RichTextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtcontact = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cmbcategory = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.txtemail = New System.Windows.Forms.TextBox()
        Me.cmbyear = New System.Windows.Forms.ComboBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txtrollno = New System.Windows.Forms.TextBox()
        Me.txtfather = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.dtpdob = New System.Windows.Forms.DateTimePicker()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txtfee = New System.Windows.Forms.TextBox()
        Me.txttuition = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.btnreset = New System.Windows.Forms.Button()
        Me.btnexit = New System.Windows.Forms.Button()
        Me.nudgraduation = New System.Windows.Forms.NumericUpDown()
        Me.cmbgender = New System.Windows.Forms.ComboBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.STUDENTNEWENTRYBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.txttotal = New System.Windows.Forms.TextBox()
        Me.Label19 = New System.Windows.Forms.Label()
        CType(Me.nudtenth, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.nudplustwo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.nudgraduation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.STUDENTNEWENTRYBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(14, 87)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(88, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Academic Year"
        '
        'cmbacademic
        '
        Me.cmbacademic.FormattingEnabled = True
        Me.cmbacademic.Items.AddRange(New Object() {"2014", "2015", "2016", "2017"})
        Me.cmbacademic.Location = New System.Drawing.Point(196, 84)
        Me.cmbacademic.Name = "cmbacademic"
        Me.cmbacademic.Size = New System.Drawing.Size(104, 23)
        Me.cmbacademic.TabIndex = 2
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(14, 130)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(38, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Name"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(14, 174)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(47, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Course"
        '
        'txtname
        '
        Me.txtname.Location = New System.Drawing.Point(196, 130)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(104, 22)
        Me.txtname.TabIndex = 5
        '
        'cmbcourse
        '
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Items.AddRange(New Object() {"BCA", "BBA", "B.Com", "B.sc", "BA", "PGDCA"})
        Me.cmbcourse.Location = New System.Drawing.Point(196, 174)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(104, 23)
        Me.cmbcourse.TabIndex = 6
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(14, 226)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(97, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Percentage 10th"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(330, 232)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(21, 15)
        Me.Label6.TabIndex = 8
        Me.Label6.Text = "+2"
        '
        'nudtenth
        '
        Me.nudtenth.Location = New System.Drawing.Point(196, 220)
        Me.nudtenth.Name = "nudtenth"
        Me.nudtenth.Size = New System.Drawing.Size(61, 22)
        Me.nudtenth.TabIndex = 9
        '
        'nudplustwo
        '
        Me.nudplustwo.Location = New System.Drawing.Point(404, 225)
        Me.nudplustwo.Name = "nudplustwo"
        Me.nudplustwo.Size = New System.Drawing.Size(62, 22)
        Me.nudplustwo.TabIndex = 10
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(14, 276)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(93, 15)
        Me.Label7.TabIndex = 11
        Me.Label7.Text = "Permanent Add."
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(14, 368)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(63, 15)
        Me.Label8.TabIndex = 12
        Me.Label8.Text = "Local Add."
        '
        'rtxtpermanent
        '
        Me.rtxtpermanent.Location = New System.Drawing.Point(196, 276)
        Me.rtxtpermanent.Name = "rtxtpermanent"
        Me.rtxtpermanent.Size = New System.Drawing.Size(324, 56)
        Me.rtxtpermanent.TabIndex = 14
        Me.rtxtpermanent.Text = ""
        '
        'rtxtlocal
        '
        Me.rtxtlocal.Location = New System.Drawing.Point(196, 368)
        Me.rtxtlocal.Name = "rtxtlocal"
        Me.rtxtlocal.Size = New System.Drawing.Size(324, 58)
        Me.rtxtlocal.TabIndex = 15
        Me.rtxtlocal.Text = ""
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(14, 457)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(70, 15)
        Me.Label9.TabIndex = 16
        Me.Label9.Text = "Contact No."
        '
        'txtcontact
        '
        Me.txtcontact.Location = New System.Drawing.Point(196, 457)
        Me.txtcontact.Name = "txtcontact"
        Me.txtcontact.Size = New System.Drawing.Size(104, 22)
        Me.txtcontact.TabIndex = 17
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(14, 508)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 15)
        Me.Label10.TabIndex = 18
        Me.Label10.Text = "Category"
        '
        'cmbcategory
        '
        Me.cmbcategory.FormattingEnabled = True
        Me.cmbcategory.Items.AddRange(New Object() {"General", "SC", "ST", "IRDP", "OBC"})
        Me.cmbcategory.Location = New System.Drawing.Point(196, 508)
        Me.cmbcategory.Name = "cmbcategory"
        Me.cmbcategory.Size = New System.Drawing.Size(104, 23)
        Me.cmbcategory.TabIndex = 19
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(330, 457)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(42, 15)
        Me.Label11.TabIndex = 21
        Me.Label11.Text = "E-mail"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(330, 510)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(60, 15)
        Me.Label12.TabIndex = 22
        Me.Label12.Text = "Year/Sem"
        '
        'txtemail
        '
        Me.txtemail.Location = New System.Drawing.Point(432, 457)
        Me.txtemail.Name = "txtemail"
        Me.txtemail.Size = New System.Drawing.Size(100, 22)
        Me.txtemail.TabIndex = 23
        '
        'cmbyear
        '
        Me.cmbyear.FormattingEnabled = True
        Me.cmbyear.Items.AddRange(New Object() {"1st Sem", "2nd Sem", "3rd Sem", "4th Sem", "5th Sem", "6th Sem"})
        Me.cmbyear.Location = New System.Drawing.Point(432, 510)
        Me.cmbyear.Name = "cmbyear"
        Me.cmbyear.Size = New System.Drawing.Size(100, 23)
        Me.cmbyear.TabIndex = 24
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(769, 83)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(48, 15)
        Me.Label13.TabIndex = 25
        Me.Label13.Text = "Roll No"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(769, 125)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(77, 15)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "Father Name"
        '
        'txtrollno
        '
        Me.txtrollno.Location = New System.Drawing.Point(929, 80)
        Me.txtrollno.Name = "txtrollno"
        Me.txtrollno.Size = New System.Drawing.Size(102, 22)
        Me.txtrollno.TabIndex = 27
        '
        'txtfather
        '
        Me.txtfather.Location = New System.Drawing.Point(929, 123)
        Me.txtfather.Name = "txtfather"
        Me.txtfather.Size = New System.Drawing.Size(102, 22)
        Me.txtfather.TabIndex = 28
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(769, 168)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(35, 15)
        Me.Label15.TabIndex = 29
        Me.Label15.Text = "DOB"
        '
        'dtpdob
        '
        Me.dtpdob.Location = New System.Drawing.Point(929, 168)
        Me.dtpdob.Name = "dtpdob"
        Me.dtpdob.Size = New System.Drawing.Size(143, 22)
        Me.dtpdob.TabIndex = 30
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(772, 221)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(68, 15)
        Me.Label16.TabIndex = 31
        Me.Label16.Text = "Graduation"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txtfee)
        Me.GroupBox2.Controls.Add(Me.txttuition)
        Me.GroupBox2.Controls.Add(Me.Label18)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.Location = New System.Drawing.Point(863, 280)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(233, 162)
        Me.GroupBox2.TabIndex = 33
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Fee Detail"
        '
        'txtfee
        '
        Me.txtfee.Location = New System.Drawing.Point(110, 118)
        Me.txtfee.Name = "txtfee"
        Me.txtfee.Size = New System.Drawing.Size(116, 22)
        Me.txtfee.TabIndex = 4
        '
        'txttuition
        '
        Me.txttuition.Location = New System.Drawing.Point(110, 39)
        Me.txttuition.Name = "txttuition"
        Me.txttuition.Size = New System.Drawing.Size(116, 22)
        Me.txttuition.TabIndex = 3
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(7, 122)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(69, 13)
        Me.Label18.TabIndex = 1
        Me.Label18.Text = "Fee Amount"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(7, 44)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(65, 13)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Tuition Fee"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(241, 628)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(132, 47)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Submit"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'btnreset
        '
        Me.btnreset.BackColor = System.Drawing.Color.Blue
        Me.btnreset.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.Color.White
        Me.btnreset.Location = New System.Drawing.Point(504, 628)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(129, 47)
        Me.btnreset.TabIndex = 7
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = False
        '
        'btnexit
        '
        Me.btnexit.BackColor = System.Drawing.Color.Blue
        Me.btnexit.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnexit.ForeColor = System.Drawing.Color.White
        Me.btnexit.Location = New System.Drawing.Point(772, 628)
        Me.btnexit.Name = "btnexit"
        Me.btnexit.Size = New System.Drawing.Size(126, 47)
        Me.btnexit.TabIndex = 8
        Me.btnexit.Text = "Exit"
        Me.btnexit.UseVisualStyleBackColor = False
        '
        'nudgraduation
        '
        Me.nudgraduation.Location = New System.Drawing.Point(929, 218)
        Me.nudgraduation.Name = "nudgraduation"
        Me.nudgraduation.Size = New System.Drawing.Size(103, 22)
        Me.nudgraduation.TabIndex = 34
        '
        'cmbgender
        '
        Me.cmbgender.FormattingEnabled = True
        Me.cmbgender.Items.AddRange(New Object() {"Male", "Female"})
        Me.cmbgender.Location = New System.Drawing.Point(196, 564)
        Me.cmbgender.Name = "cmbgender"
        Me.cmbgender.Size = New System.Drawing.Size(104, 23)
        Me.cmbgender.TabIndex = 35
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Location = New System.Drawing.Point(14, 572)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(47, 15)
        Me.Label20.TabIndex = 36
        Me.Label20.Text = "Gender"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Indigo
        Me.Label1.Location = New System.Drawing.Point(348, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(418, 43)
        Me.Label1.TabIndex = 37
        Me.Label1.Text = "STUDENT ADMISSION "
        '
        'txttotal
        '
        Me.txttotal.Location = New System.Drawing.Point(973, 478)
        Me.txttotal.Name = "txttotal"
        Me.txttotal.Size = New System.Drawing.Size(116, 22)
        Me.txttotal.TabIndex = 39
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(870, 480)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 15)
        Me.Label19.TabIndex = 38
        Me.Label19.Text = "Total Fee"
        '
        'student_admission_form
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Teal
        Me.ClientSize = New System.Drawing.Size(1147, 701)
        Me.Controls.Add(Me.txttotal)
        Me.Controls.Add(Me.Label19)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.cmbgender)
        Me.Controls.Add(Me.nudgraduation)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnexit)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.dtpdob)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.txtfather)
        Me.Controls.Add(Me.txtrollno)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.cmbyear)
        Me.Controls.Add(Me.txtemail)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.Label11)
        Me.Controls.Add(Me.cmbcategory)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.txtcontact)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.rtxtlocal)
        Me.Controls.Add(Me.rtxtpermanent)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.nudplustwo)
        Me.Controls.Add(Me.nudtenth)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbacademic)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Times New Roman", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.Color.Black
        Me.Name = "student_admission_form"
        Me.Text = "Student Admission Form"
        CType(Me.nudtenth, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.nudplustwo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.nudgraduation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.STUDENTNEWENTRYBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents cmbacademic As System.Windows.Forms.ComboBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtname As System.Windows.Forms.TextBox
    Friend WithEvents cmbcourse As System.Windows.Forms.ComboBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents nudtenth As System.Windows.Forms.NumericUpDown
    Friend WithEvents nudplustwo As System.Windows.Forms.NumericUpDown
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents rtxtpermanent As System.Windows.Forms.RichTextBox
    Friend WithEvents rtxtlocal As System.Windows.Forms.RichTextBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txtcontact As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cmbcategory As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents txtemail As System.Windows.Forms.TextBox
    Friend WithEvents cmbyear As System.Windows.Forms.ComboBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txtrollno As System.Windows.Forms.TextBox
    Friend WithEvents txtfather As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents dtpdob As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents txtfee As System.Windows.Forms.TextBox
    Friend WithEvents txttuition As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnexit As System.Windows.Forms.Button
    Friend WithEvents nudgraduation As System.Windows.Forms.NumericUpDown

    Friend WithEvents STUDENTNEWENTRYBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents cmbgender As System.Windows.Forms.ComboBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txttotal As System.Windows.Forms.TextBox
    Friend WithEvents Label19 As System.Windows.Forms.Label

End Class
