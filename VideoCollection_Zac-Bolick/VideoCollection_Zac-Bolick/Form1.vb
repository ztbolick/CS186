Imports System.IO

Public Class frmMain

    ' Init Variables'
    Public fileName As String = "Videos.txt"
    Public hasAFile As Boolean
    Private fileNum As Integer
    Private RecordNumberIndex As Integer = 0
    Private recordPosition As Integer = 0

    Public Structure myRecords
        Dim VideoName As String
        Dim YearProduced As String
        Dim RunningTime As String
        Dim Rating As String
    End Structure

    Private myRecord As myRecords


    'Basic Subs'
    Private Sub ExitToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExitToolStripMenuItem.Click
        Me.Close()
    End Sub

    Private Sub ClearText()
        txtRating.Text = ""
        txtRunningTime.Text = ""
        txtVideoName.Text = ""
        txtYearProduced.Text = ""
    End Sub

    Private Sub AboutToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles AboutToolStripMenuItem.Click
        MessageBox.Show("About", "VideoCollection Collection Version 1.1")
    End Sub

    Private Sub setFeilds()
        myRecord.VideoName = txtVideoName.Text
        myRecord.YearProduced = txtYearProduced.Text
        myRecord.RunningTime = txtRunningTime.Text
        myRecord.Rating = txtRating.Text
    End Sub

    Private Sub DisplayRecord(ByVal feild As myRecords)
        txtVideoName.Text = myRecord.VideoName
        txtYearProduced.Text = myRecord.YearProduced
        txtRunningTime.Text = myRecord.RunningTime
        txtRating.Text = myRecord.Rating
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        DisplayRecord(myRecord)
    End Sub


    'Save Sub'
    Private Sub SaveRecordToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SaveRecordToolStripMenuItem.Click
        If System.IO.File.Exists(My.Application.Info.DirectoryPath + "\" + fileName) Then
            hasAFile = True
        Else
            hasAFile = False
        End If

        Dim exportedFile As System.IO.StreamWriter
        exportedFile = My.Computer.FileSystem.OpenTextFileWriter(fileName, hasAFile)

        setFeilds()

        exportedFile.WriteLine(myRecord.VideoName)
        exportedFile.WriteLine(myRecord.YearProduced)
        exportedFile.WriteLine(myRecord.RunningTime)
        exportedFile.WriteLine(myRecord.Rating)


        exportedFile.Close()
        ClearText()
    End Sub

    Private Sub SearchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SearchToolStripMenuItem.Click
        Dim searchString As String = InputBox("Enter the name of the video", "Search")

        ' check for input
        If searchString.Length = 0 Then
            MessageBox.Show("Dude you need enter something for me to search for...come on.")
            Exit Sub
        End If

        'create filestream
        Dim reader As New StreamReader(fileName)

        If SearchRecords(reader, searchString) Then
            DisplayRecord(myRecord)
        Else
            MessageBox.Show("Not Present")
            ClearText()
        End If

        reader.Close()
    End Sub

    'Search Records'
    Private Function SearchRecords(ByVal reader As StreamReader, ByVal searchString As String)

        RecordNumberIndex = 0
        Do Until reader.EndOfStream
            RecordNumberIndex += 4
            myRecord.VideoName = reader.ReadLine
            myRecord.YearProduced = reader.ReadLine
            myRecord.RunningTime = reader.ReadLine
            myRecord.Rating = reader.ReadLine

            If myRecord.VideoName.Equals(searchString) Then
                Return True
                Exit Do
            End If
        Loop

        Return False
    End Function


    Private Sub pdPrint_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles pdPrint.PrintPage
        Dim leading As Integer = 0
        Dim rowStart As Integer = 100
        e.Graphics.DrawString("Video List", New Font("Courier New", 18, FontStyle.Bold), Brushes.Black, 150, 10)
        e.Graphics.DrawString("Date and Time: " & Now.ToString(), New Font("Courier New", 10, FontStyle.Bold), Brushes.Black, 10, 50)
        e.Graphics.DrawString(String.Format("{0, 15} {1,15} {2,15} {3,15}", "Video Name", "Year Produced", "Running Time", "Rating"), New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 10, 80)

        Dim font1 As New Font("arial", 16, FontStyle.Regular)

        Dim reader As New StreamReader(fileName)
        Do Until reader.EndOfStream
            txtVideoName.Text = reader.ReadLine
            txtYearProduced.Text = reader.ReadLine
            txtRunningTime.Text = reader.ReadLine
            txtRating.Text = reader.ReadLine
            e.Graphics.DrawString(String.Format("{0, 15} {1,15} {2,15} {3,15}", txtVideoName.Text, txtYearProduced.Text, txtRunningTime.Text, txtRating.Text), New Font("Courier New", 12, FontStyle.Bold), Brushes.Black, 10, rowStart + leading)
            leading += 12

        Loop

    End Sub

    Private Sub ReportToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ReportToolStripMenuItem.Click
        pdPrint.Print()
    End Sub

End Class