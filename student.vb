Imports System.Data.OleDb
Public Class student_information_form
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\college.accdb;Persist Security Info=False;"
    
    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub

    Private Sub RichTextBox1_TextChanged(sender As Object, e As EventArgs) Handles RichTextBox1.TextChanged

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged

    End Sub

    Private Sub ComboBox4_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox4.SelectedIndexChanged

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If Len(Trim(TextBox1.Text)) = 0 Then
            MessageBox.Show("Please Enter Student ID", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox1.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox2.Text)) = 0 Then
            MessageBox.Show("Please Enter Student name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox2.Focus()
            Exit Sub
        End If
        If Len(Trim(DateTimePicker1.Text)) = 0 Then
            MessageBox.Show("Please Enter DATE OF BIRTH", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            DateTimePicker1.Focus()
            Exit Sub
        End If
        If Len(Trim(RichTextBox1.Text)) = 0 Then
            MessageBox.Show("Please Enter PERMANENT ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RichTextBox1.Focus()
            Exit Sub
        End If
        If Len(Trim(RichTextBox2.Text)) = 0 Then
            MessageBox.Show("Please Enter LOCAL ADDRESS", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            RichTextBox2.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox3.Text)) = 0 Then
            MessageBox.Show("Please Enter CONTACT NUMBER", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
            Exit Sub
        End If
        If Len(Trim(NumericUpDown1.Text)) = 0 Then
            MessageBox.Show("Please Enter PERCENTAGE 10TH", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumericUpDown1.Focus()
            Exit Sub
        End If
        If Len(Trim(NumericUpDown2.Text)) = 0 Then
            MessageBox.Show("Please Enter PERCENTAGE 12TH", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumericUpDown2.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBox1.Text)) = 0 Then
            MessageBox.Show("Please Enter COURSE", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox1.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox4.Text)) = 0 Then
            MessageBox.Show("Please Enter ROLL NO", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox4.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox5.Text)) = 0 Then
            MessageBox.Show("Please Enter FATHER NAME", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox5.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBox2.Text)) = 0 Then
            MessageBox.Show("Please Enter CATEGORY", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox2.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBox3.Text)) = 0 Then
            MessageBox.Show("Please Enter YEAR/SEM", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox3.Focus()
            Exit Sub
        End If
        If Len(Trim(ComboBox4.Text)) = 0 Then
            MessageBox.Show("Please Enter ACADEMIC YEAR", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            ComboBox4.Focus()
            Exit Sub
        End If
        If Len(Trim(TextBox6.Text)) = 0 Then
            MessageBox.Show("Please Enter E-MAIL", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox6.Focus()
            Exit Sub
        End If
        If Len(Trim(NumericUpDown3.Text)) = 0 Then
            MessageBox.Show("Please Enter GRADUATION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            NumericUpDown3.Focus()
            Exit Sub
        End If
        Try
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "update studentinfo set Student_ID = '" & TextBox1.Text & "', Name='" & TextBox2.Text & "', DOB=" & DateTimePicker1.Text & "',Permanent_Address='" & RichTextBox1.Text & "',Local_Address='" & RichTextBox2.Text & "',Contact_No='" & TextBox3.Text & "',Percentage_10='" & NumericUpDown1.Text & "',+2='" & NumericUpDown2.Text & "',Graduation='" & NumericUpDown3.Text & "',Course='" & ComboBox1.Text & "',Roll_No='" & TextBox4.Text & "',Father_Name='" & TextBox5.Text & "',Category='" & ComboBox2.Text & "',Year/Sem='" & ComboBox3.Text & "',Academic_Year='" & ComboBox4.Text & "',E-mail='" & TextBox6.Text & "' "
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            MessageBox.Show("Successfully updated", "Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Button2.Enabled = False
            con.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

    End Sub

    Private Sub student_information_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
    End Sub

    
End Class