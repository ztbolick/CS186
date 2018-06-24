Public Class frmWorkShop
    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        If lstPickAWorkshop.SelectedItem = "" And lstLocation.SelectedItem = "" Then
            MessageBox.Show("Please select a workshop and location before calculating your total")
        ElseIf lstPickAWorkshop.SelectedItem = "" Then
            MessageBox.Show("Please select a workshop before you calculate a total")
        ElseIf lstLocation.SelectedItem = "" Then
            MessageBox.Show("Please select a location before you calculate a total")
        Else
            ' Make some variables for calculations
            Dim WorkshopBase As Integer = 595
            Dim ListCostAddition As Integer = 0
            Dim Location As Integer = 0

            ' Select Case for Workshop
            Select Case lstPickAWorkshop.SelectedIndex
                Case 0
                    ListCostAddition = WorkshopBase
                Case 1
                    ListCostAddition = WorkshopBase + 100
                Case 2
                    ListCostAddition = WorkshopBase + 400
                Case 3
                    ListCostAddition = WorkshopBase + 700
                Case 4
                    ListCostAddition = WorkshopBase - 200
            End Select

            ' Select Case for Locations
            Select Case lstLocation.SelectedIndex
                Case 0
                    ListCostAddition += 285
                Case 1
                    ListCostAddition += 375
                Case 2
                    ListCostAddition += 330
                Case 3
                    ListCostAddition += 300
                Case 4
                    ListCostAddition += 276
                Case 5
                    ListCostAddition += 270
            End Select

            ' Type casting and adding to the last listbox
            ListBox3.Items.Add(ListCostAddition.ToString("C"))

        End If
    End Sub

    Private Sub btnCalculate_Click(sender As Object, e As EventArgs) Handles btnCalculate.Click
        'Make a variable for the cost and a counter
        Dim TotalCost As Integer = 0
        Dim iCnt As Integer

        For iCnt = 0 To Me.ListBox3.Items.Count - 1
            TotalCost += CInt(ListBox3.Items.Item(iCnt))
        Next iCnt

        ' Type casting and adding to the last listbox
        lblTotalCost.Text = TotalCost.ToString("C")
    End Sub

    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click

        lstLocation.ClearSelected()
        lstPickAWorkshop.ClearSelected()
        ListBox3.Items.Clear()
        lblTotalCost.Text = ""
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()
    End Sub
End Class
