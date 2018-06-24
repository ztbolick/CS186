Public Class Form1
    ' Create arrays
    Dim pinMinimums() As Integer = {7, 5, 0, 0, 6, 3, 4}
    Dim pinMaximum() As Integer = {9, 7, 4, 9, 9, 6, 8}
    Dim pinElements(6) As String
    Dim pinIntegers(6) As Integer
    Dim indexCounter As Integer = 0

    Private Sub btnVerify_Click(sender As Object, e As EventArgs) Handles btnVerify.Click
        ' Place text elements into string array
        pinElements(0) = TextBox1.Text
        pinElements(1) = TextBox2.Text
        pinElements(2) = TextBox3.Text
        pinElements(3) = TextBox4.Text
        pinElements(4) = TextBox5.Text
        pinElements(5) = TextBox6.Text
        pinElements(6) = TextBox7.Text

        ' Cast pin elements to int and push to an int array
        For i As Integer = 0 To 6
            Dim pinAsNumber As Integer
            If Int32.TryParse(pinElements(i), pinAsNumber) Then
                pinIntegers(i) = pinAsNumber
            End If
        Next

        ' Test values and throw error
        For i As Integer = 0 To 6
            If pinMinimums(i) < pinIntegers(i) And pinIntegers(i) < pinMaximum(i) Then
                MessageBox.Show("The PIN is valid", "PIN Verified")
            Else
                MessageBox.Show("Enter a number between " + pinMinimums(i).ToString + " and " + pinMaximum(i).ToString, "Digit " + (i + 1).ToString)
                Exit For
            End If
        Next

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        TextBox1.Clear()
        TextBox2.Clear()
        TextBox3.Clear()
        TextBox4.Clear()
        TextBox5.Clear()
        TextBox6.Clear()
        TextBox7.Clear()
    End Sub
End Class
