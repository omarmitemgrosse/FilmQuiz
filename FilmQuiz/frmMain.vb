Public Class frmMain
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txtName.TextChanged

    End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click
        Application.Exit()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click

        playerScore = 0
        If (txtName.Text = " ") Then
            MsgBox("Please Enter Your Name")
        Else

            playerName = txtName.Text
            frmQuestion1.Show()
            frmQuestion1.init()
            txtName.Text = ""
            Me.Hide()
        End If

    End Sub
End Class
