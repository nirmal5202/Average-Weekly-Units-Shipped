'Name: Nirmal Patel
'SID: 100767993
'File Name: Average Weekly Units Shipped
'Submitted to Austin Garrod
'Date: 30th May 2020

Public Class frmAverageWeeklyUnitsShipped

    'Declarations
    Dim unitsInput(6) As Integer    'unitInput is declared as an integer and is given an array 6
    Dim averageUnits As Double      'averageUnits is declared as a double
    Dim changeOfNum As Integer      'changeOfNum is declared as an integer

    ''' <summary>
    ''' When pressed btnEnter
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnEnter_Click(sender As Object, e As EventArgs) Handles btnEnter.Click

        txtUnits.SelectAll()        'select all content in txtUnit textbox
        txtUnits.Focus()        'focus on txtUnits textbox
        If Not IsNumeric(Me.txtUnits.Text) Then     'if input is not a number
            MsgBox("Please enter a numeric value for Units")    'message
            txtUnits.SelectAll()        'select all content in txtUnit textbox
            txtUnits.Focus()        'focus on txtUnits textbox

        Else
            If Not Integer.TryParse(txtUnits.Text, unitsInput(changeOfNum)) Then    'if user input is not a whole number
                MsgBox("Input must be a whole number")     'message
                txtUnits.SelectAll()        'select all content in txtUnit textbox
                txtUnits.Focus()        'focus on txtUnits textbox


            Else
                If Not unitsInput(changeOfNum) > 0 And unitsInput(changeOfNum) < 5000 Then
                    MsgBox("Please enter a valid number between 0 and 5000")       'message
                    txtUnits.SelectAll()        'select all content in txtUnit textbox
                    txtUnits.Focus()        'focus on txtUnits textbox
                Else

                    txtGiantBox.Text += txtUnits.Text + vbCrLf      'print user input in txtGiantBox textbox
                    txtUnits.Clear()    'clear all content in txtUnits textbox
                    changeOfNum += 1    'increase 1 num
                    lblDay.Text = "Day " + Convert.ToString(changeOfNum + 1)    'reset lblDay to Day 1
                End If

            End If

        End If

        'process (magical formula)
        averageUnits = unitsInput.Average

        'output
        lblAnswer.Text = "Average per day: " + Convert.ToString(Math.Round((averageUnits), 2))

        txtUnits.SelectAll()
        txtUnits.Focus()

    End Sub

    ''' <summary>
    ''' when prssed btnExit
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Me.Close()  'exit the app
    End Sub

    ''' <summary>
    ''' when pressed btnReset
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub btnReset_Click(sender As Object, e As EventArgs) Handles btnReset.Click
        lblAnswer.Text = ""     'in short, it will clear the content in lblAnswer
        lblDay.Text = "Day 1"       'reset lblDay text to Day 1 after all
        txtUnits.Clear()    'clear all content in txtUnits textbox
        txtUnits.Focus()        'focus on txtUnits textbox
    End Sub
End Class