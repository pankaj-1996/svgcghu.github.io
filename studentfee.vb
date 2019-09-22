Imports System.Data.OleDb
Public Class studentfee
    Dim con As OleDbConnection
    Dim cmd As OleDbCommand
    Dim dr As OleDbDataReader
    Dim str As String
    Dim cc As Integer
    Dim cs As String = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\college.accdb;Persist Security Info=False;"

    Private Sub Label4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub studentfee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            con = New OleDbConnection(cs)
            con.Open()

            cmd = New OleDbCommand("select Student_ID From sfees", con)
            dr = cmd.ExecuteReader

            While dr.Read()
                cmbid.Items().Add(dr("Student_ID"))

            End While

        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try

        con.Close()
    End Sub

    Private Sub TextBox4_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button1_Click_1(sender As Object, e As EventArgs) Handles Button1.Click
        If cmbid.Text = "" Then
            MsgBox("Select Student_ID from Student ID field", MsgBoxStyle.Information, "Edit Student_ID")
        Else
            Try
                con = New OleDbConnection(cs)
                con.Open()
                str = "Update sfees Set Tuition_Fee = '" & txttuition.Text & "',Fee_Amount = '" & cmbfee.Text & "',Total_Fee = '" & cmbtotal.Text & "' where Student_ID ='" & cmbid.Text & "'"
                cmd = New OleDbCommand(str, con)
                cmd.ExecuteNonQuery()
                MsgBox("Student Fee updated Successfully.", MsgBoxStyle.Information, "Update Student Fee")
            Catch
                MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End Try
        End If
        con.Close()
    End Sub
#Region "CLEARALL"
    Private Sub clearall()
        cmbacademic.Text = ""
        cmbcourse.Text = "   "
        cmbyear.Text = "  "
        cmbid.Text = "  "
        cmbid.Items.Clear()
        txtfather.Text = ""
        txttuition.Text = "  "
        cmbfee.Text = "  "
        cmbtotal.Text = "  "
        txtname.Text = "  "
        cmbid.Refresh()
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select  Student_ID From sfees", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                cmbid.Items().Add(dr("Student_ID"))
            End While
        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub
#End Region
    Private Sub Button6_Click_1(sender As Object, e As EventArgs) Handles Button6.Click
        Dim choice As Integer
        choice = MsgBox("Are you sure you want to remove the record", MsgBoxStyle.OkCancel)
        If (choice = 1) Then
            Try
                con = New OleDbConnection(cs)
                con.Open()
                cmd = New OleDbCommand("Delete  * From sfees where Student_ID = '" & cmbid.Text & "'", con)
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

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
      
    End Sub

    Private Sub cmbid_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbid.SelectedIndexChanged
        Try
            con = New OleDbConnection(cs)
            con.Open()
            cmd = New OleDbCommand("select * From sfees where Student_ID = '" & cmbid.Text & "'", con)
            dr = cmd.ExecuteReader
            While dr.Read()
                txtfather.Text = dr("Name")
                txtname.Text = dr("Father_name")
                cmbfee.Text = dr("Fee_Amount")
                cmbtotal.Text = dr("Total_Fee")
                cmbacademic.Text = dr("Academic_Year")
                cmbcourse.Text = dr("Course")
                cmbyear.Text = dr("Year/Sem")
                txttuition.Text = dr("Tuition_Fee")
            End While
        Catch
            MessageBox.Show(Err.Description, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
        con.Close()
    End Sub


    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click
        Dim a, b, c As Integer
        a = Val(txttuition.Text)
        b = Val(cmbfee.Text)
        c = a + b
        cmbtotal.Text = c
    End Sub

    Private Sub cmbtotal_click(sender As Object, e As EventArgs) Handles cmbtotal.TextChanged
       
    End Sub

    Private Sub Button5_Click_1(sender As Object, e As EventArgs) Handles Button5.Click
        Try
            If Len(Trim(cmbid.Text)) = 0 Then
                MessageBox.Show("Please enter student id", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbid.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbacademic.Text)) = 0 Then
                MessageBox.Show("Please enter academic year", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbacademic.Focus()
                Exit Sub
            End If
            If Len(Trim(txtname.Text)) = 0 Then
                MessageBox.Show("Please enter student name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtname.Focus()
                Exit Sub
            End If
            If Len(Trim(txtfather.Text)) = 0 Then
                MessageBox.Show("Please enter father name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txtfather.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbcourse.Text)) = 0 Then
                MessageBox.Show("Please enter course", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbcourse.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbyear.Text)) = 0 Then
                MessageBox.Show("Please enter year or sem", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbyear.Focus()
                Exit Sub
            End If
            If Len(Trim(txttuition.Text)) = 0 Then
                MessageBox.Show("Please enter tuition fee", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                txttuition.Focus()
                Exit Sub
            End If
            If Len(Trim(cmbfee.Text)) = 0 Then
                MessageBox.Show("Please enter fee amount", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                cmbfee.Focus()
                Exit Sub
            End If
            con = New OleDbConnection(cs)
            con.Open()
            Dim cb As String = "INSERT INTO sfees VALUES('" & cmbacademic.Text & "','" & txtname.Text & "','" & txtfather.Text & "','" & cmbcourse.Text & "','" & cmbyear.Text & "','" & cmbid.Text & "','" & txttuition.Text & "','" & cmbfee.Text & "','" & cmbtotal.Text & "')"
            cmd = New OleDbCommand(cb)
            cmd.Connection = con
            cmd.ExecuteNonQuery()
            con.Close()
            MessageBox.Show("Successfully saved", " teacher salary Record", MessageBoxButtons.OK, MessageBoxIcon.Information)
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button7_Click_1(sender As Object, e As EventArgs) Handles Button7.Click
        Form3.Show()
        Me.Hide()
    End Sub
End Class