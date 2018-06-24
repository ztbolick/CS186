Imports System.IO

Public Class EmployeeData2
    Private fileName As String
    Private fileNum As Integer
    Private hasAFile As Boolean
    Private RecordNumberIndex As Integer = 0
    Private recordPosition As Integer = 0

    Private Sub frmEmployeeData_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        fileName = InputBox("Enter the name of your employee file.", "Input Needed", "temp")

        If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\" + fileName + ".txt") Then
            hasAFile = True
        Else
            hasAFile = False
        End If

        While hasAFile = False
            MessageBox.Show("You need to enter the name of your employee file!")
            fileName = InputBox("Enter the name of your employee file.", "Input Needed", "myemployeefile")
        End While
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblFirstName.Text = ""
        lblMiddleName.Text = ""
        lblLastName.Text = ""
        lblEmployeeNumber.Text = ""
        lblDepartment.Text = ""
        lblTelephone.Text = ""
        lblExtension.Text = ""
        lblEmail.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnSaveRecord_Click(sender As Object, e As EventArgs) Handles btnSaveRecord.Click
        ' Counter at the top
        RecordNumberIndex += 1

        ' Index for array
        If RecordNumberIndex > 1 Then
            recordPosition += 8
        End If

        'create filestream
        Dim reader As New StreamReader(fileName + ".txt")

        ' loop to add spaces for each record list
        For i As Integer = 0 To recordPosition
            If i < recordPosition Then
                reader.ReadLine()
            End If
        Next i

        ' check from eof and if it isn't push the lines to the labels
        If reader.EndOfStream = True Then
            MessageBox.Show("end of file")
        Else
            If RecordNumberIndex > 0 Then
                lblRecordName.Text = RecordNumberIndex
            Else
                lblRecordName.Text = ""
            End If
            lblFirstName.Text = reader.ReadLine & vbCrLf
            lblMiddleName.Text = reader.ReadLine & vbCrLf
            lblLastName.Text = reader.ReadLine & vbCrLf
            lblEmployeeNumber.Text = reader.ReadLine & vbCrLf
            lblDepartment.Text = reader.ReadLine & vbCrLf
            lblTelephone.Text = reader.ReadLine & vbCrLf
            lblExtension.Text = reader.ReadLine & vbCrLf
            lblEmail.Text = reader.ReadLine & vbCrLf
        End If
        reader.Close()
    End Sub
End Class
