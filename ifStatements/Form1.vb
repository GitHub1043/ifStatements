Public Class Form1
    Dim intScore As Integer = 10

    Private Sub btnGuess_Click(sender As Object, e As EventArgs) Handles btnGuess.Click
        Const SECRET As Integer = 42
        Dim intGuess As Integer

        intGuess = Val(txtGuess.Text)

        ' Decision Time!!!

        If (intGuess = SECRET) Then
            MessageBox.Show("Correct!", "Guess Result")
        End If

        If (intGuess <> SECRET) Then
            ' <> Not equal
            MessageBox.Show("Incorrect!", "Guess Result")
            intScore = intScore - 1
        End If

        If (intGuess < SECRET) Then
            ' < less than
            MessageBox.Show("Guess Higher!", "Guess Result")
        End If

        If (intGuess > SECRET) Then
            ' > more than
            MessageBox.Show("Guess Lower!", "Guess Result")
        End If

        If (intGuess <= 0) Then
            ' <= less than or equal
            ' or "at most 0"
            MessageBox.Show("Out Of Range", "Error")
        End If

        If (intGuess >= 101) Then
            ' >= greater than or equal
            ' or "at least 101"
            MessageBox.Show("Out Of Range", "Error")
        End If

        MessageBox.Show("Score: " & intScore)

        If (intScore <= 0) Then
            MessageBox.Show("You LOSE!!!")
            btnGuess.Visible = False

        End If

    End Sub
End Class
