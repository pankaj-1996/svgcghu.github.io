Imports System.Data.OleDb
Imports System.IO
Imports System.Security.Cryptography
Imports System.Text
Public Class Teacher_New_Entry
    Dim rdr As OleDbDataReader = Nothing
    Dim dtable As DataTable
    Dim con As OleDbConnection = Nothing
    Dim adp As OleDbDataAdapter
    Dim ds As DataSet
    Dim cmd As OleDbCommand = Nothing
    Dim dt As New DataTable
    Dim gender As String
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\college.accdb;Persist Security Info=False;"
    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmarried.SelectedIndexChanged

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub

    Private Sub ComboBox2_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbgender.SelectedIndexChanged

    End Sub

    Private Sub TextBox11_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            If Len(Trim(txtname.Text)) = 0 Then
                MessageBox.Show("Please enter Teacher Name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Focus()
                Exit Sub
            End If
            If Len(Trim(txtfather.Text)) = 0 Then
                MessageBox.Show("Please enter Teacher Father name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfather.Focus()
                Exit Sub
            End If
            If Len(Trim(dtpdob.Text)) = 0 Then
                MessageBox.Show("Please enter teacher date of birth", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                dtpdob.Focus()
                Exit Sub
            End If
            If Len(Trim(rtxtpermanent.Text)) = 0 Then
                MessageBox.Show("Please enter permanent address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rtxtpermanent.Focus()
                Exit Sub
            End If
            If Len(Trim(rtxtlocal.Text)) = 0 Then
                MessageBox.Show("Please enter local address", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                rtxtlocal.Focus()
                Exit Sub
            End If
            If Len(Trim(txtcontact.Text)) = 0 Then
                MessageBox.Show("Please enter contact number", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtcontact.Focus()
                Exit Sub
            End If
            If Len(Trim(txtexperience.Text)) = 0 Then
                MessageBox.Show("Please enter teacher experience", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtexperience.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbmarried.Text)) = 0 Then
                MessageBox.Show("Please enter teacher married status", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbmarried.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbgender.Text)) = 0 Then
                MessageBox.Show("Please enter student gender", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbgender.Focus()
                Exit Sub
            End If
            If Len(Trim(txtqualification.Text)) = 0 Then
                MessageBox.Show("Please enter the teacher's qualification", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtqualification.Focus()
                Exit Sub
            End If

            If Len(Trim(txtbasic.Text)) = 0 Then
                MessageBox.Show("Please enter basic salary", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtbasic.Focus()
                Exit Sub
            End If
            If Len(Trim(txtda.Text)) = 0 Then
                MessageBox.Show("Please enter DA", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtda.Focus()
                Exit Sub
            End If
            If Len(Trim(txthra.Text)) = 0 Then
                MessageBox.Show("Please enter HRA", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txthra.Focus()
                Exit Sub
            End If
            If Len(Trim(txtgross.Text)) = 0 Then
                MessageBox.Show("Please enter GROSS PAY", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtgross.Focus()
                Exit Sub
            End If
            If Len(Trim(txtdiction.Text)) = 0 Then
                MessageBox.Show("Please enter TEACHER OTHER DICTION", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtdiction.Focus()
                Exit Sub
            End If
            If Len(Trim(txtpf.Text)) = 0 Then
                MessageBox.Show("Please enter PF", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtpf.Focus()
                Exit Sub
            End If
            If Len(Trim(txttotal.Text)) = 0 Then
                MessageBox.Show("Please enter TOTAL SALARY", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txttotal.Focus()
                Exit Sub
            End If

            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "INSERT INTO tnerentry VALUES('" & txtname.Text & "','" & dtpdob.Text & "','" & txtqualification.Text & "','" & txtexperience.Text & "','" & rtxtpermanent.Text & "','" & rtxtlocal.Text & "','" & txtcontact.Text & "','" & txtfather.Text & "','" & cmbmarried.Text & "','" & txtbasic.Text & "','" & txtda.Text & "','" & txthra.Text & "','" & txtgross.Text & "','" & txtdiction.Text & "','" & txtpf.Text & "','" & txttotal.Text & "','" & cmbgender.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", "Teacher record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

    End Sub

    Private Sub btnreset_Click(sender As Object, e As EventArgs) Handles btnreset.Click
        txtname.Text = " "
        txtcontact.Text = "  "
        dtpdob.Text = "  "
        txtqualification.Text = "  "
        txtfather.Text = "  "
        txtexperience.Text = "  "
        txtbasic.Text = "  "
        txttotal.Text = "  "
        rtxtpermanent.Text = "  "
        rtxtlocal.Text = "  "
        txtda.Text = "  "
        cmbgender.Text = "  "
        cmbmarried.Text = "  "
        txthra.Text = "  "
        txtgross.Text = "  "
        txtdiction.Text = "  "
        txtpf.Text = "  "

    End Sub

    Private Sub btnexit_Click(sender As Object, e As EventArgs) Handles btnexit.Click
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub txtcontact_validating(sender As Object, e As EventArgs) Handles txtcontact.Validating

        If (txtcontact.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtcontact.Focus()
        End If
    End Sub

    Private Sub Teacher_New_Entry_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

 
    Private Sub Label8_Click_1(sender As Object, e As EventArgs) Handles Label8.Click
       
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim basic, da, hra, pf, netpay, gross, total As Integer
        basic = Val(txtbasic.Text)
        da = Val(txtda.Text)
        hra = Val(txthra.Text)
        netpay = Val(txtdiction.Text)
        pf = basic + (basic * (da / 100) + basic * (hra / 100))
        gross = basic * (12 / 100)
        total = pf - (netpay + gross)
        txtpf.Text = pf
        txtgross.Text = gross
        txttotal.Text = total
    End Sub
End Class