Public Class frmEmployeeData
    Public fileName As String
    Public hasAFile As Boolean

    Private Sub frmEmployeeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileName = InputBox("Enter the name of your employee file.", "Enter File Name", "myemployeefile")
    End Sub
    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtFistName.Text = ""
        txtMiddleName.Text = ""
        txtLastName.Text = ""
        txtEmployeeNumber.Text = ""
        txtDepartment.Text = ""
        txtTelephone.Text = ""
        txtExtension.Text = ""
        txtEmail.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\" + fileName + ".txt") Then
            hasAFile = True
        Else
            hasAFile = False
        End If

        Dim exportedFile As System.IO.StreamWriter
        exportedFile = My.Computer.FileSystem.OpenTextFileWriter(fileName + ".txt", hasAFile)

        Dim required As Integer = 0
        If txtFistName.Text Is "" Then
            required += 1
            MessageBox.Show("Please enter a first name!")
        ElseIf txtLastName.Text Is "" Then
            required += 1
            MessageBox.Show("Please enter a last name!")
        ElseIf txtEmployeeNumber.Text Is "" Then
            required += 1
            MessageBox.Show("Please enter an employee number!")
        ElseIf txtDepartment.Text Is "" Then
            required += 1
            MessageBox.Show("Please enter a Department!")
        End If

        If required = 0 And fileName.Length > 0 Then
            exportedFile.WriteLine(txtFistName.Text)
            exportedFile.WriteLine(txtMiddleName.Text)
            exportedFile.WriteLine(txtLastName.Text)
            exportedFile.WriteLine(txtEmployeeNumber.Text)
            exportedFile.WriteLine(txtDepartment.Text)
            exportedFile.WriteLine(txtTelephone.Text)
            exportedFile.WriteLine(txtExtension.Text)
            exportedFile.WriteLine(txtEmail.Text)
        Else
            MessageBox.Show("You need a filename to save buddy. Reopen me and enter a filename!")
        End If

        exportedFile.Close()
    End Sub
End Class
