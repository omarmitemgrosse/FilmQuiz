Public Class frmQuestion1
    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles btnAnswer3.CheckedChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        If btnAnswer1.Checked Then
            playerScore = playerScore + 1

        End If
        frmQuestion2.Show()
        Me.Hide()
    End Sub
End Class