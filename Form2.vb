Imports System.Data.OleDb
Public Class Form2

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
    End Sub
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)
    End Sub
    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles txtpassword.TextChanged
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Len(Trim(cmbusername.Text)) = 0 Then
            MessageBox.Show("Please enter user name", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            cmbusername.Focus()
            Exit Sub
        End If
        If Len(Trim(txtpassword.Text)) = 0 Then
            MessageBox.Show("Please enter password", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtpassword.Focus()
            Exit Sub
        End If
        Try
            Dim myConnection As OleDbConnection
            myConnection = New OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\college.accdb;Persist Security Info=False;")
            Dim myCommand As OleDbCommand
            myCommand = New OleDbCommand("SELECT login.Username,Password FROM login where login.Username=login.Username and login.Username = @Username and Password = @Password", myConnection)

            Dim uName As New OleDbParameter("@Username", SqlDbType.VarChar)
            Dim uPassword As New OleDbParameter("@Password", SqlDbType.VarChar)
            uName.Value = cmbusername.Text
            uPassword.Value = txtpassword.Text
            myCommand.Parameters.Add(uName)

            myCommand.Parameters.Add(uPassword)

            myCommand.Connection.Open()
            Dim myReader As OleDbDataReader = myCommand.ExecuteReader(CommandBehavior.CloseConnection)

            Dim Login As Object = 0

            If myReader.HasRows Then

                myReader.Read()

                Login = myReader(Login)

            End If

            If Login = Nothing Then

                MsgBox("Login is Failed...Try again !", MsgBoxStyle.Critical, "Login Denied")
                txtpassword.Clear()
            Else
                Me.Hide()
                Form3.Show()
            End If
            myCommand.Dispose()
            myConnection.Close()
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim response As MsgBoxResult
        response = MsgBox("Do you want to close form??", MsgBoxStyle.Question + MsgBoxStyle.YesNo, "confirm")
        If response = MsgBoxResult.Yes Then
            Me.Dispose()
        ElseIf response = MsgBoxResult.No Then
            Exit Sub
        End If

    End Sub

    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class