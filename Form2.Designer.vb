<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.LOGINACCOUNTBindingSource4 = New System.Windows.Forms.BindingSource(Me.components)
        Me.txtpassword = New System.Windows.Forms.TextBox()
        Me.LOGINACCOUNTBindingSource5 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOGINACCOUNTBindingSource2 = New System.Windows.Forms.BindingSource(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.LOGINACCOUNTBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOGINACCOUNTBindingSource1 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOGINACCOUNTBindingSource3 = New System.Windows.Forms.BindingSource(Me.components)
        Me.LOGINACCOUNTBindingSource6 = New System.Windows.Forms.BindingSource(Me.components)
        Me.cmbusername = New System.Windows.Forms.ComboBox()
        CType(Me.LOGINACCOUNTBindingSource4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINACCOUNTBindingSource5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINACCOUNTBindingSource2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINACCOUNTBindingSource1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINACCOUNTBindingSource3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LOGINACCOUNTBindingSource6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 26.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Blue
        Me.Label1.Location = New System.Drawing.Point(274, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(128, 41)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "LOGIN"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(23, 73)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(100, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "&Username"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(23, 142)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "&Password"
        '
        'txtpassword
        '
        Me.txtpassword.Location = New System.Drawing.Point(451, 142)
        Me.txtpassword.Name = "txtpassword"
        Me.txtpassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtpassword.Size = New System.Drawing.Size(100, 20)
        Me.txtpassword.TabIndex = 4
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Blue
        Me.Button1.BackgroundImage = CType(resources.GetObject("Button1.BackgroundImage"), System.Drawing.Image)
        Me.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button1.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.ForeColor = System.Drawing.Color.White
        Me.Button1.Location = New System.Drawing.Point(131, 260)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(120, 44)
        Me.Button1.TabIndex = 5
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Blue
        Me.Button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Button2.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Image = CType(resources.GetObject("Button2.Image"), System.Drawing.Image)
        Me.Button2.Location = New System.Drawing.Point(439, 260)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(112, 44)
        Me.Button2.TabIndex = 6
        Me.Button2.UseVisualStyleBackColor = False
        '
        'cmbusername
        '
        Me.cmbusername.FormattingEnabled = True
        Me.cmbusername.Items.AddRange(New Object() {"pankajsharma", "ashishgautam", "rahulsharma", "admin"})
        Me.cmbusername.Location = New System.Drawing.Point(451, 78)
        Me.cmbusername.Name = "cmbusername"
        Me.cmbusername.Size = New System.Drawing.Size(100, 21)
        Me.cmbusername.TabIndex = 7
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(666, 328)
        Me.Controls.Add(Me.cmbusername)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtpassword)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Name = "Form2"
        Me.Text = "Login Form"
        CType(Me.LOGINACCOUNTBindingSource4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINACCOUNTBindingSource5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINACCOUNTBindingSource2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINACCOUNTBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINACCOUNTBindingSource1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINACCOUNTBindingSource3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LOGINACCOUNTBindingSource6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txtpassword As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button

    Friend WithEvents LOGINACCOUNTBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents LOGINACCOUNTBindingSource2 As System.Windows.Forms.BindingSource
    Friend WithEvents LOGINACCOUNTBindingSource1 As System.Windows.Forms.BindingSource

    Friend WithEvents LOGINACCOUNTBindingSource3 As System.Windows.Forms.BindingSource

    Friend WithEvents LOGINACCOUNTBindingSource4 As System.Windows.Forms.BindingSource
    Friend WithEvents LOGINACCOUNTBindingSource5 As System.Windows.Forms.BindingSource
    Friend WithEvents LOGINACCOUNTBindingSource6 As System.Windows.Forms.BindingSource
    Friend WithEvents cmbusername As System.Windows.Forms.ComboBox
End Class
