Public Class Form1

    Dim scoringPoints As Integer
    Dim playerTurn As Boolean

    ' disable all buttons if one player win
    Public Function disableBoxes() As Integer
        buttonClick1.Enabled = False
        buttonClick2.Enabled = False
        buttonClick3.Enabled = False
        buttonClick4.Enabled = False
        buttonClick5.Enabled = False
        buttonClick6.Enabled = False
        buttonClick7.Enabled = False
        buttonClick8.Enabled = False
        buttonClick9.Enabled = False

        Return 0
    End Function

    ' player score board
    Public Function playersScoreBoard() As Integer

        ' player X winning conbination
        If (buttonClick1.Text = "X") And (buttonClick2.Text = "X") And (buttonClick3.Text = "X") Then
            buttonClick1.ForeColor = System.Drawing.Color.Green
            buttonClick2.ForeColor = System.Drawing.Color.Green
            buttonClick3.ForeColor = System.Drawing.Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player1ScoreLabel.Text
            player1ScoreLabel.Text = scoringPoints + 1

            MessageBox.Show("Player 1 winner the match")
            disableBoxes()

        ElseIf (buttonClick4.Text = "X") And (buttonClick5.Text = "X") And (buttonClick6.Text = "X") Then
            buttonClick4.ForeColor = Color.Green
            buttonClick5.ForeColor = Color.Green
            buttonClick6.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player1ScoreLabel.Text
            player1ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 1 winner the match")

        ElseIf (buttonClick7.Text = "X") And (buttonClick8.Text = "X") And (buttonClick9.Text = "X") Then
            buttonClick7.ForeColor = Color.Green
            buttonClick8.ForeColor = Color.Green
            buttonClick9.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player1ScoreLabel.Text
            player1ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 1 winner the match")

        ElseIf (buttonClick1.Text = "X") And (buttonClick4.Text = "X") And (buttonClick7.Text = "X") Then
            buttonClick1.ForeColor = Color.Green
            buttonClick4.ForeColor = Color.Green
            buttonClick7.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player1ScoreLabel.Text
            player1ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 1 winner the match")

        ElseIf (buttonClick2.Text = "X") And (buttonClick5.Text = "X") And (buttonClick8.Text = "X") Then
            buttonClick2.ForeColor = Color.Green
            buttonClick5.ForeColor = Color.Green
            buttonClick8.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player1ScoreLabel.Text
            player1ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 1 winner the match")


        ElseIf (buttonClick3.Text = "X") And (buttonClick6.Text = "X") And (buttonClick9.Text = "X") Then
            buttonClick3.ForeColor = Color.Green
            buttonClick6.ForeColor = Color.Green
            buttonClick9.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player1ScoreLabel.Text
            player1ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 1 winner the match")

        ElseIf (buttonClick3.Text = "X") And (buttonClick5.Text = "X") And (buttonClick7.Text = "X") Then
            buttonClick3.ForeColor = Color.Green
            buttonClick5.ForeColor = Color.Green
            buttonClick7.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player1ScoreLabel.Text
            player1ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 1 winner the match")

        ElseIf (buttonClick1.Text = "X") And (buttonClick5.Text = "X") And (buttonClick9.Text = "X") Then
            buttonClick1.ForeColor = Color.Green
            buttonClick5.ForeColor = Color.Green
            buttonClick9.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player1ScoreLabel.Text
            player1ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 1 winner the match")

        End If

        'player O winnenr combination
        If (buttonClick1.Text = "O") And (buttonClick2.Text = "O") And (buttonClick3.Text = "O") Then
            buttonClick1.ForeColor = Color.Green
            buttonClick2.ForeColor = Color.Green
            buttonClick3.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player2ScoreLabel.Text
            player2ScoreLabel.Text = scoringPoints + 1

            MessageBox.Show("Player 2 winner the match")
            disableBoxes()

        ElseIf (buttonClick4.Text = "O") And (buttonClick5.Text = "O") And (buttonClick6.Text = "O") Then
            buttonClick4.ForeColor = Color.Green
            buttonClick5.ForeColor = Color.Green
            buttonClick6.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player2ScoreLabel.Text
            player2ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 2 winner the match")

        ElseIf (buttonClick7.Text = "O") And (buttonClick8.Text = "O") And (buttonClick9.Text = "O") Then
            buttonClick7.ForeColor = Color.Green
            buttonClick8.ForeColor = Color.Green
            buttonClick9.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player2ScoreLabel.Text
            player2ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 2 winner the match")

        ElseIf (buttonClick1.Text = "O") And (buttonClick4.Text = "O") And (buttonClick7.Text = "O") Then
            buttonClick1.ForeColor = Color.Green
            buttonClick4.ForeColor = Color.Green
            buttonClick7.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player2ScoreLabel.Text
            player2ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 2 winner the match")

        ElseIf (buttonClick2.Text = "O") And (buttonClick5.Text = "O") And (buttonClick8.Text = "O") Then
            buttonClick2.ForeColor = Color.Green
            buttonClick5.ForeColor = Color.Green
            buttonClick8.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player2ScoreLabel.Text
            player2ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 2 winner the match")


        ElseIf (buttonClick3.Text = "O") And (buttonClick6.Text = "O") And (buttonClick9.Text = "O") Then
            buttonClick3.ForeColor = Color.Green
            buttonClick6.ForeColor = Color.Green
            buttonClick9.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player2ScoreLabel.Text
            player2ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 2 winner the match")

        ElseIf (buttonClick3.Text = "O") And (buttonClick5.Text = "O") And (buttonClick7.Text = "O") Then
            buttonClick3.ForeColor = Color.Green
            buttonClick5.ForeColor = Color.Green
            buttonClick7.ForeColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player2ScoreLabel.Text
            player2ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 2 winner the match")

        ElseIf (buttonClick1.Text = "O") And (buttonClick5.Text = "O") And (buttonClick9.Text = "O") Then
            buttonClick1.BackColor = Color.Green
            buttonClick5.BackColor = Color.Green
            buttonClick9.BackColor = Color.Green

            player1Label.ForeColor = Color.Black
            player2Label.ForeColor = Color.Black

            scoringPoints = player2ScoreLabel.Text
            player2ScoreLabel.Text = scoringPoints + 1

            disableBoxes()

            MessageBox.Show("Player 2 winner the match")

        End If

        Return 0
    End Function

    ' button clicker functionality
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles buttonClick5.Click
        If playerTurn = False Then
            buttonClick5.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick5.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black

        End If

        buttonClick5.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub newGameButton_Click(sender As Object, e As EventArgs) Handles newGameButton.Click
        buttonClick1.Text = ""
        buttonClick2.Text = ""
        buttonClick3.Text = ""
        buttonClick4.Text = ""
        buttonClick5.Text = ""
        buttonClick6.Text = ""
        buttonClick7.Text = ""
        buttonClick8.Text = ""
        buttonClick9.Text = ""

        buttonClick1.Enabled = True
        buttonClick2.Enabled = True
        buttonClick3.Enabled = True
        buttonClick4.Enabled = True
        buttonClick5.Enabled = True
        buttonClick6.Enabled = True
        buttonClick7.Enabled = True
        buttonClick8.Enabled = True
        buttonClick9.Enabled = True

        buttonClick1.ForeColor = Color.Black
        buttonClick2.ForeColor = Color.Black
        buttonClick3.ForeColor = Color.Black
        buttonClick4.ForeColor = Color.Black
        buttonClick5.ForeColor = Color.Black
        buttonClick6.ForeColor = Color.Black
        buttonClick7.ForeColor = Color.Black
        buttonClick8.ForeColor = Color.Black
        buttonClick9.ForeColor = Color.Black

        player1ScoreLabel.Text = "0"
        player2ScoreLabel.Text = "0"

        player1Label.ForeColor = Color.Green
        player2Label.ForeColor = Color.Black

        playerTurn = False


    End Sub

    Private Sub resetButton_Click(sender As Object, e As EventArgs) Handles resetButton.Click
        buttonClick1.Text = ""
        buttonClick2.Text = ""
        buttonClick3.Text = ""
        buttonClick4.Text = ""
        buttonClick5.Text = ""
        buttonClick6.Text = ""
        buttonClick7.Text = ""
        buttonClick8.Text = ""
        buttonClick9.Text = ""

        buttonClick1.Enabled = True
        buttonClick2.Enabled = True
        buttonClick3.Enabled = True
        buttonClick4.Enabled = True
        buttonClick5.Enabled = True
        buttonClick6.Enabled = True
        buttonClick7.Enabled = True
        buttonClick8.Enabled = True
        buttonClick9.Enabled = True

        buttonClick1.ForeColor = Color.Black
        buttonClick2.ForeColor = Color.Black
        buttonClick3.ForeColor = Color.Black
        buttonClick4.ForeColor = Color.Black
        buttonClick5.ForeColor = Color.Black
        buttonClick6.ForeColor = Color.Black
        buttonClick7.ForeColor = Color.Black
        buttonClick8.ForeColor = Color.Black
        buttonClick9.ForeColor = Color.Black

        player1Label.ForeColor = Color.Green
        player2Label.ForeColor = Color.Black

        playerTurn = False



    End Sub

    Private Sub exitButton_Click(sender As Object, e As EventArgs) Handles exitButton.Click
        Close()
    End Sub

    Private Sub buttonClick1_Click(sender As Object, e As EventArgs) Handles buttonClick1.Click
        If playerTurn = False Then
            buttonClick1.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick5.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black

        End If


        buttonClick1.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub buttonClick2_Click(sender As Object, e As EventArgs) Handles buttonClick2.Click
        If playerTurn = False Then
            buttonClick2.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick5.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black

        End If


        buttonClick2.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub buttonClick3_Click(sender As Object, e As EventArgs) Handles buttonClick3.Click
        If playerTurn = False Then
            buttonClick3.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick3.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black

        End If


        buttonClick3.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub buttonClick4_Click(sender As Object, e As EventArgs) Handles buttonClick4.Click
        If playerTurn = False Then
            buttonClick4.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick4.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black

        End If


        buttonClick4.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub buttonClick6_Click(sender As Object, e As EventArgs) Handles buttonClick6.Click
        If playerTurn = False Then
            buttonClick6.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick6.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black

        End If


        buttonClick6.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub buttonClick7_Click(sender As Object, e As EventArgs) Handles buttonClick7.Click
        If playerTurn = False Then
            buttonClick7.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick7.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black

        End If


        buttonClick7.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub buttonClick8_Click(sender As Object, e As EventArgs) Handles buttonClick8.Click
        If playerTurn = False Then
            buttonClick8.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick8.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black


        End If


        buttonClick8.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub buttonClick9_Click(sender As Object, e As EventArgs) Handles buttonClick9.Click
        If playerTurn = False Then
            buttonClick9.Text = "X"
            playerTurn = True
            player2Label.ForeColor = Color.Green
            player1Label.ForeColor = Color.Black

        Else
            buttonClick9.Text = "O"
            playerTurn = False
            player1Label.ForeColor = Color.Green
            player2Label.ForeColor = Color.Black

        End If

        buttonClick9.Enabled = False
        playersScoreBoard()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        disableBoxes()
    End Sub
End Class
