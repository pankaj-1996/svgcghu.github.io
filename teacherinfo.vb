Imports System.Data.OleDb
Public Class teacherinfo
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim cc As Integer
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\college.accdb;Persist Security Info=False;"
    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        teachersalary.Show()
        Me.Hide()
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Teacher_New_Entry.Show()
        Me.Hide()
    End Sub
#Region "CLEARALL"
    Private Sub clearall()
        ComboBox1.Text = ""
        ComboBox2.Text = "   "
        ComboBox3.Text = "  "
        ComboBox3.Items.Clear()
        RichTextBox1.Text = "  "
        RichTextBox2.Text = "  "
        ''    DateTimePicker1.Text = "  "
        TextBox2.Text = ""
        TextBox3.Text = ""
        TextBox5.Text = "  "
        TextBox6.Text = "  "
        TextBox1.Text = "  "
        TextBox7.Text = "  "
        ComboBox3.Refresh()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select  Teacher_id From teacherinfo", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                ComboBox3.Items().Add(dr("Teacher_id"))
            End While
        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub
#End Region

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If ComboBox3.Text = "" Then
            MsgBox("Select Teacher_id from Teacher ID field", MsgBoxStyle.Information, "Edit Teacher_id")
        Else
            Try
                con = New OleDbConnection(cs)
                con.Open()
                str = "Update teacherinfo Set Contact_No = '" & TextBox3.Text & "',Local_Address = '" & RichTextBox2.Text & "' where Teacher_id ='" & ComboBox3.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Record updated Successfully.", MsgBoxStyle.Information, "Update Registration")
            Catch
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        con.Close()
    End Sub


    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim choice As Integer
        choice = MsgBox("Are you sure you want to remove the record", MsgBoxStyle.OkCancel)
        If (choice = 1) Then
            Try

                con = New OleDbConnection(cs)
                con.Open()
                cmd = New OleDbCommand("Delete  * From teacherinfo where Teacher_id = '" & ComboBox3.Text & "'", con)
                dr = cmd.ExecuteReader

            Catch
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
            con.Close()
            clearall()

        Else
            Focus()
        End If
    End Sub

    Private Sub teacherinfo_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("select Teacher_id From teacherinfo", con)
            dr = cmd.ExecuteReader

            While dr.Read()
                ComboBox3.Items().Add(dr("Teacher_id"))

            End While

        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        con.Close()
    End Sub

    Private Sub ComboBox3_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox3.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select * From teacherinfo where Teacher_id = '" & ComboBox3.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                TextBox2.Text = dr("Name")
                TextBox1.Text = dr("father_name")
                TextBox3.Text = dr("Contact_No")
                TextBox5.Text = dr("E-mail")
                TextBox6.Text = dr("experience")
                TextBox7.Text = dr("Qualification")
                RichTextBox1.Text = dr("Permanent_Address")
                RichTextBox2.Text = dr("Local_Address")
                ComboBox1.Text = dr("Married Status")
                ComboBox2.Text = dr("Gender")
                DateTimePicker1.Text = dr("DOB")
            End While
        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        If ComboBox3.Text = "" Then
            MsgBox("Select Teacher_id from Teacher ID field", MsgBoxStyle.Information, "Edit Teacher_id")
        Else
            Try
                con = New OleDbConnection(cs)
                con.Open()
                str = "Select * from teacherinfo where Teacher_id= '" & ComboBox3.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Record show Successfully.", MsgBoxStyle.Information, "show record")
            Catch
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        con.Close()
    End Sub

    Private Sub TextBox3_validating(sender As Object, e As EventArgs) Handles TextBox3.Validating
        If (TextBox3.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TextBox3.Focus()
        End If
    End Sub

    Private Sub TextBox5_validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TextBox5.Validating

        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If TextBox5.Text.Length > 0 Then
            If Not rEMail.IsMatch(TextBox5.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                TextBox5.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub
End Class