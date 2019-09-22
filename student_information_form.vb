Imports System.Data.OleDb
Public Class student_information_form
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim cc As Integer
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\college.accdb;Persist Security Info=False;"
#Region "CLEARALL"
    Private Sub clearall()
        CMBCOURSE.Text = ""
        CMBCATEGORY.Text = "   "
        CMBID.Text = "  "
        CMBID.Items.Clear()
        RTXTPERMANENT.Text = "  "
        RTXTLOCAL.Text = "  "
        ''      DTPDOB.Text = "  "
        TXTNAME.Text = ""
        TXTCONTACT.Text = ""
        TXTFATHER.Text = "  "
        TXTEMAIL.Text = "  "
        TXTROLLNO.Text = "  "
        NUDGRADUATION.Text = "  "
        NUD10.Text = "  "
        NUD12.Text = "  "
        CMBYEAR.Text = "  "
        CMBACADEMIC.Text = "  "
        CMBID.Refresh()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select  student_id From studentinfo", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                CMBID.Items().Add(dr("student_id"))
            End While
        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub
#End Region


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If CMBID.Text = "" Then
            MsgBox("Select student_id from student ID field", MsgBoxStyle.Information, "Edit student_id")
        Else
            Try
                con = New OleDbConnection(cs)
                con.Open()
                str = "Update studentinfo Set Contact_No = '" & TXTCONTACT.Text & "',Local_Address = '" & RTXTLOCAL.Text & "' where student_id ='" & CMBID.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Record updated Successfully.", MsgBoxStyle.Information, "Update Registration")
            Catch
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        con.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim choice As Integer
        choice = MsgBox("Are you sure you want to remove the record :", MsgBoxStyle.OkCancel)
        If (choice = 1) Then
            Try
                con = New OleDbConnection(cs)
                con.Open()
                cmd = New OleDbCommand("Delete  * From studentinfo where student_id = '" & CMBID.Text & "'", con)
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

    Private Sub student_information_form_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("select student_id From studentinfo", con)
            dr = cmd.ExecuteReader

            While dr.Read()
                CMBID.Items().Add(dr("student_id"))

            End While

        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        con.Close()
    End Sub

    Private Sub ComboBox5_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CMBID.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select * From studentinfo where student_id = '" & CMBID.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                TXTNAME.Text = dr("Name")
                RTXTPERMANENT.Text = dr("Permanent_Address")
                RTXTLOCAL.Text = dr("Local_Address")
                TXTCONTACT.Text = dr("Contact_No")
                NUD10.Text = dr("Percentage_10")
                NUD12.Text = dr("+2")
                NUDGRADUATION.Text = dr("Graduation")
                CMBCOURSE.Text = dr("Course")
                TXTROLLNO.Text = dr("Roll_No")
                TXTFATHER.Text = dr("Father_Name")
                CMBCATEGORY.Text = dr("Category")
                CMBYEAR.Text = dr("Year/Sem")
                CMBACADEMIC.Text = dr("Academic_Year")
                TXTEMAIL.Text = dr("E-mail")
                DTPDOB.Text = dr("DOB")
            End While
        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        studentfee.Show()
        Me.Hide()
    End Sub

    Private Sub TXTCONTACT_validating(sender As Object, e As EventArgs) Handles TXTCONTACT.Validating
        If (TXTCONTACT.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            TXTCONTACT.Focus()
        End If
    End Sub


    Private Sub txtemail_validating(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles TXTEMAIL.Validating

        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If TXTEMAIL.Text.Length > 0 Then
            If Not rEMail.IsMatch(TXTEMAIL.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                TXTEMAIL.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

End Class