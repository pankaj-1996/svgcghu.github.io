Imports System.Data.OleDb
Public Class teachersalary
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim cc As Integer
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\college.accdb;Persist Security Info=False;"
    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        Dim basic, da, hra, pf, netpay, gross, total As Integer
        basic = Val(txtbasic.Text)
        da = Val(txtda.Text)
        hra = Val(txthra.Text)
        netpay = Val(txtnet.Text)
        pf = basic + (basic * (da / 100) + basic * (hra / 100))
        gross = basic * (12 / 100)
        total = pf - (netpay + gross)
        txtpf.Text = pf
        txtgross.Text = gross
        txttotal.Text = total
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        teacherinfo.Show()
        Me.Hide()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If cmbid.Text = "" Then
            MsgBox("Select teacher_id from teacher ID field", MsgBoxStyle.Information, "Edit teacher_id")
        Else
            Try
                con = New OleDbConnection(cs)
                con.Open()
                str = "Update tsalary Set Phone_No = '" & txtphone.Text & "',Basic_Salary = '" & txtbasic.Text & "',DA = '" & txtda.Text & "',HRA = '" & txthra.Text & "',PF = '" & txtpf.Text & "',Net_Pay = '" & txtnet.Text & "',Gross_Salary= '" & txtgross.Text & "',Total_Salary = '" & txttotal.Text & "' where teacher_id ='" & cmbid.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("teacher salary updated Successfully.", MsgBoxStyle.Information, "Update teacher salary")
            Catch
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        con.Close()
    End Sub

    Private Sub teachersalary_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("select teacher_id From tsalary", con)
            dr = cmd.ExecuteReader

            While dr.Read()
                cmbid.Items().Add(dr("teacher_id"))

            End While

        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim choice As Integer
        choice = MsgBox("Are you sure you want to remove the record", MsgBoxStyle.OkCancel)
        If (choice = 1) Then
            Try
                con = New OleDbConnection(cs)
                con.Open()
                cmd = New OleDbCommand("Delete  * From tsalary where teacher_id = '" & cmbid.Text & "'", con)
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
#Region "CLEARALL"
    Private Sub clearall()
        txtname.Text = ""
        txtphone.Text = "   "
        txtbasic.Text = "  "
        txtda.Text = "  "
        cmbid.Text = ""
        cmbid.Items.Clear()
        txthra.Text = ""
        txtpf.Text = "  "
        txtnet.Text = "  "
        txtgross.Text = "  "
        txttotal.Text = "  "
        cmbid.Refresh()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select  teacher_id From tsalary", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                cmbid.Items().Add(dr("teacher_id"))
            End While
        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub
#End Region

    Private Sub cmbid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbid.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select * From tsalary where teacher_id = '" & cmbid.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                txtname.Text = dr("Name")
                txtphone.Text = dr("phone_no")
                txtbasic.Text = dr("basic_salary")
                txtda.Text = dr("da")
                txthra.Text = dr("hra")
                txtpf.Text = dr("pf")
                txtnet.Text = dr("net_pay")
                txtgross.Text = dr("gross_salary")
                txttotal.Text = dr("total_salary")

            End While
        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If Len(Trim(cmbid.Text)) = 0 Then
                MessageBox.Show("Please enter teacher id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbid.Focus()
                Exit Sub
            End If
            If Len(Trim(txtname.Text)) = 0 Then
                MessageBox.Show("Please enter teacher name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Focus()
                Exit Sub
            End If
            If Len(Trim(txtphone.Text)) = 0 Then
                MessageBox.Show("Please enter teacher phone_no", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtphone.Focus()
                Exit Sub
            End If
            If Len(Trim(txtbasic.Text)) = 0 Then
                MessageBox.Show("Please enter teacher's basic salary", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
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
            If Len(Trim(txtnet.Text)) = 0 Then
                MessageBox.Show("Please enter NET PAY", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtnet.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "INSERT INTO tsalary VALUES('" & cmbid.Text & "','" & txtname.Text & "','" & txtphone.Text & "','" & txtbasic.Text & "','" & txtda.Text & "','" & txthra.Text & "','" & txtpf.Text & "','" & txtnet.Text & "','" & txtgross.Text & "','" & txttotal.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", " teacher salary Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub txtphone_validating(sender As Object, e As EventArgs) Handles txtphone.Validating
        If (txtphone.TextLength > 10) Then
            MessageBox.Show("Only 10 digits are allowed", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtphone.Focus()
        End If
    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click

    End Sub
End Class