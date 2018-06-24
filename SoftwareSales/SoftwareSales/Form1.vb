Public Class SoftwareSales

    Dim lvl3 As Integer = 0
    Dim onSite As Integer = 0
    Dim cloud As Integer = 0
    Dim CoSL As Integer = 0

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        Try
            ' Clear user input fields
            lblCOF.Text = ""
            lblCoSL.Text = ""
            CoSL = 0
            btnYearly.Checked = False
            btnOneTimePurchase.Checked = False
            chkCloudBackup.Checked = False
            chkLevel3.Checked = False
            chkOnSite.Checked = False
        Catch ex As Exception
            MessageBox.Show("An unknown error occured, error")
        End Try
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        ' Check for which radio button if any is checked
        If btnYearly.Checked Then
            CoSL = 5000
        ElseIf btnOneTimePurchase.Checked Then
            CoSL = 20000
        End If

        ' If statements for each check box
        If chkLevel3.Checked Then
            lvl3 = 3500
        Else
            lvl3 = 0
        End If
        If chkOnSite.Checked Then
            onSite = 2000
        Else
            onSite = 0
        End If
        If chkCloudBackup.Checked Then
            cloud = 300
        Else
            cloud = 0
        End If

        ' Try catch statment for actual calculations cause why not
        ' variables declaired above in this project to incerase readability :)
        Try
            ' Push values to labels
            lblCOF.Text = (lvl3 + onSite + cloud).ToString("C")
            lblCoSL.Text = CoSL.ToString("C")

        Catch ex As Exception
            MessageBox.Show("An unknown error occured, error")
        End Try

    End Sub
End Class
