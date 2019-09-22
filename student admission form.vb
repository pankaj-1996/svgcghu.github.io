Imports System.Data.OleDb
Public Class student_admission_form
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\college.accdb;Persist Security Info=False;"
  

  
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbacademic.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    

    Private Sub Button3_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnexit.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As Object, ByVal e As EventArgs) Handles btnreset.Click
        txtname.Text = " "
        txtcontact.Text = "  "
        txtemail.Text = "  "
        txtrollno.Text = "  "
        txtfather.Text = "  "
        txttuition.Text = "  "
        txtfee.Text = "  "
        txttotal.Text = "  "
        rtxtpermanent.Text = "  "
        rtxtlocal.Text = "  "
        cmbacademic.Text = "  "
        cmbcourse.Text = "  "
        cmbcategory.Text = "  "
        cmbyear.Text = "  "
        cmbgender.Text = "  "
        nudplustwo.TextAlign = "  "
        nudgraduation.TextAlign = "  "
        nudtenth.TextAlign = "  "
    End Sub

    Private Sub Button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles Button1.Click
        Try
            If Len(Trim(cmbacademic.Text)) = 0 Then
                MessageBox.Show("Please enter Academic year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbacademic.Focus()
                Exit Sub
            End If
            If Len(Trim(txtname.Text)) = 0 Then
                MessageBox.Show("Please enter student name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbcourse.Text)) = 0 Then
                MessageBox.Show("Please enter student course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbcourse.Focus()
                Exit Sub
            End If
            If Len(Trim(nudtenth.Text)) = 0 Then
                MessageBox.Show("Please enter 10th percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                nudtenth.Focus()
                Exit Sub
            End If
            If Len(Trim(nudplustwo.Text)) = 0 Then
                MessageBox.Show("Please enter 12th percentage", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                nudplustwo.Focus()
                Exit Sub
            End If
            If Len(Trim(rtxtpermanent.Text)) = 0 Then
                MessageBox.Show("Please enter student permanent address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rtxtpermanent.Focus()
                Exit Sub
            End If
            If Len(Trim(rtxtlocal.Text)) = 0 Then
                MessageBox.Show("Please enter student local address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rtxtlocal.Focus()
                Exit Sub
            End If
            If Len(Trim(txtcontact.Text)) = 0 Then
                MessageBox.Show("Please enter student contact number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcontact.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbgender.Text)) = 0 Then
                MessageBox.Show("Please enter student contact number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbgender.Focus()
                Exit Sub
            End If
            If Len(Trim(txtemail.Text)) = 0 Then
                MessageBox.Show("Please enter student e-mail id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtemail.Focus()
                Exit Sub
            End If
          
            If Len(Trim(cmbcategory.Text)) = 0 Then
                MessageBox.Show("Please enter student category", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbcategory.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbyear.Text)) = 0 Then
                MessageBox.Show("Please enter student year or sem", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbyear.Focus()
                Exit Sub
            End If
            If Len(Trim(txtrollno.Text)) = 0 Then
                MessageBox.Show("Please enter student roll no", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtrollno.Focus()
                Exit Sub
            End If
            If Len(Trim(txtfather.Text)) = 0 Then
                MessageBox.Show("Please enter student father name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfather.Focus()
                Exit Sub
            End If
            If Len(Trim(dtpdob.Text)) = 0 Then
                MessageBox.Show("Please enter student date of birth", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpdob.Focus()
                Exit Sub
            End If
            If Len(Trim(nudgraduation.Text)) = 0 Then
                MessageBox.Show("Please enter student graduation", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                nudgraduation.Focus()
                Exit Sub
            End If
            If Len(Trim(txttuition.Text)) = 0 Then
                MessageBox.Show("Please enter student tuition fee", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txttuition.Focus()
                Exit Sub
            End If
            If Len(Trim(txtfee.Text)) = 0 Then
                MessageBox.Show("Please enter student fee amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfee.Focus()
                Exit Sub
            End If
            If Len(Trim(txttotal.Text)) = 0 Then
                MessageBox.Show("Please enter total fee amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txttotal.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "INSERT INTO sadmission VALUES('" & cmbacademic.Text & "','" & txtrollno.Text & "','" & txtname.Text & "','" & txtfather.Text & "','" & cmbgender.Text & "','" & dtpdob.Text & "','" & nudtenth.Text & "','" & nudplustwo.Text & "','" & nudgraduation.Text & "','" & rtxtpermanent.Text & "','" & rtxtlocal.Text & "','" & txtcontact.Text & "','" & cmbcourse.Text & "','" & cmbcategory.Text & "','" & txttuition.Text & "','" & txtfee.Text & "','" & txttotal.Text & "','" & txtemail.Text & "','" & cmbyear.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", " Student Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub student_admission_form_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged_1(sender As Object, e As EventArgs) Handles cmbgender.SelectedIndexChanged

    End Sub

    Private Sub txttotal_click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label9_click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub txtcontact_VALIDATING(sender As Object, e As EventArgs) Handles txtcontact.Validating
        If (txtcontact.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcontact.Focus()
        End If
    End Sub

    Private Sub txtemail_VALIDATING(ByVal sender As System.Object, ByVal e As System.ComponentModel.CancelEventArgs) Handles txtemail.Validating

        Dim rEMail As New System.Text.RegularExpressions.Regex("^[a-zA-Z][\w\.-]{2,28}[a-zA-Z0-9]@[a-zA-Z0-9][\w\.-]*[a-zA-Z0-9]\.[a-zA-Z][a-zA-Z\.]*[a-zA-Z]$")
        If txtemail.Text.Length > 0 Then
            If Not rEMail.IsMatch(txtemail.Text) Then
                MessageBox.Show("invalid email address", "Error", MessageBoxButtons.OK, MessageBoxIcon.[Error])
                txtemail.SelectAll()
                e.Cancel = True
            End If
        End If
    End Sub

    Private Sub txtcontact_TextChanged(sender As Object, e As EventArgs) Handles txtcontact.TextChanged

    End Sub

    Private Sub txttotal_TextChanged(sender As Object, e As EventArgs) Handles txttotal.TextChanged

    End Sub

    Private Sub Label19_Click_1(sender As Object, e As EventArgs) Handles Label19.Click
        Dim a, b, c As Integer
        a = Val(txttuition.Text)
        b = Val(txtfee.Text)
        c = a + b
        txttotal.Text = c
    End Sub
End Class