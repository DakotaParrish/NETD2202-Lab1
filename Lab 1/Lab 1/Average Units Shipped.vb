'Name: Dakota Parrish
'Student Number: 100764512
'Program Name: Average Units Shipped
'Date: May 28, 2020
'Description: This program allows the entry of a unit number for each day numbered 1 to 7 and adds it to a running total. Once the days reaches to 7 days, 
'it will Then take the total and divides it by 7 to find out the average units shipper per day and displays it to the user. You can exit the program any time
'by hitting the exit button and you can also reset the program by hitting the reset button. 

Option Strict On

Public Class frmAvgUnitsShipped
    Dim days(6) As Integer 'Declare days as an array with 6 elements.
    Dim currentDayUnits As Integer = 0 'Declare the current day units being shipped as an integer and set it as 0. This will be the element used in 'days(6).
    Dim avgTotal As Double 'Declare the average total as a double.
    Dim runningTotal As Integer 'Declare the running total as an integer.

    'Whenever the user clicks on the enter button, it will perform two purposes. It will 1. Add their number for 'units' and
    'add it to a running total after it has been validated, and 2 once the 'Days' hits 7, it will then take the running total and divide it by 7
    'to display the average total.
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        'If the current day is less than 7.
        If currentDayUnits < 7 Then
            'First, checks if the units entered number is a whole number.
            If Integer.TryParse(txtInput.Text, days(currentDayUnits)) Then

                'Checks to see if number entered is within the range of 0-5000.
                If days(currentDayUnits) >= 0 And days(currentDayUnits) <= 5000 Then

                    'The unit number entered is within the range.
                    'The number entered for units is appended to the input display textbox.
                    txtInputDisplay.Text &= days(currentDayUnits) & vbCrLf
                    'Clears the text box for input.
                    txtInput.Clear()
                    'Sets focus on the input text box so the user can type in another number.
                    txtInput.Focus()
                    'Adds the units entered to the running total.
                    runningTotal += days(currentDayUnits)
                    'Since the element used in the 'days(6)' array is 'currentDayUnits' we use it for the day counter and add one to it.
                    currentDayUnits = currentDayUnits + 1
                    'Changes the label to display and keep track of the day number for the user as they are entering units.
                    lblDays.Text = "Day " & (currentDayUnits + 1)

                    'If the day number is equal to 7.
                    If currentDayUnits = 7 Then
                        'Set the text for the days label to say 'Day 7'
                        lblDays.Text = "Day 7"
                        'Sets the ReadOnly property of the input textbox to true so the user can not enter any more numbers.
                        txtInput.ReadOnly = True
                        'Sets the Enabled property of the enter button to false so the user can't hit the enter button anymore.
                        btnEnter.Enabled = False
                        'Calculates the average total by taking the running total and dividing it by 7.
                        avgTotal = runningTotal / 7
                        'Displays the average units per day and rounds it to 2 decimal places.
                        lblAverageUnitsDisplay.Text = "Average per day:" & CStr(Math.Round(avgTotal, 2))
                    End If
                Else
                    'The unit numbered entered is NOT within the range.
                    MessageBox.Show("The number entered must be between the range of 0-5000!")
                    'Focuses the input text box for re-entry.
                    txtInput.Focus()
                End If
            Else
                'The number entered was not a whole number!
                MessageBox.Show("The number entered must be a whole number.")
                'Focuses the input text box for re-entry.
                txtInput.Focus()
            End If
        End If
    End Sub
    'Whenever the user clicks on the reset button, it essentially resets the form and clears all text boxes and labels as well as sets the variables
    'and totals back to 0 to match the state of the form as it was once opened.
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        'Clears the input display textbox.
        txtInputDisplay.Clear()
        'Clears the input text box.
        txtInput.Clear()
        'Clears the total average label.
        lblAverageUnitsDisplay.Text = ""
        'Re-enables the enter button.
        btnEnter.Enabled = True
        'Sets the label for days to say Day 1.
        lblDays.Text = "Day 1"
        'Re-enables the input text box.
        txtInput.ReadOnly = False
        'Clears the currentDayUnits value and sets it back to 0.
        currentDayUnits = 0
        'Clears the running total value and sets it back to 0.
        runningTotal = 0
        'Sets the focus on the input text box for re-entry.
        txtInput.Focus()
    End Sub
    '''Whenever the user clicks on the exit button, it will gracefully close the form.
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'Closes the form.
        Application.Exit()
    End Sub
End Class
