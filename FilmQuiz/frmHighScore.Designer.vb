<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmHighScore
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.lblCongratulations = New System.Windows.Forms.Label()
        Me.lstHighScore = New System.Windows.Forms.ListBox()
        Me.btnAgain = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'lblCongratulations
        '
        Me.lblCongratulations.AutoSize = True
        Me.lblCongratulations.Font = New System.Drawing.Font("Poplar Std", 24.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCongratulations.Location = New System.Drawing.Point(84, 54)
        Me.lblCongratulations.Name = "lblCongratulations"
        Me.lblCongratulations.Size = New System.Drawing.Size(627, 38)
        Me.lblCongratulations.TabIndex = 0
        Me.lblCongratulations.Text = "Congratulations Your Score Will Be Added To The  Hall Of  Fame"
        '
        'lstHighScore
        '
        Me.lstHighScore.FormattingEnabled = True
        Me.lstHighScore.Location = New System.Drawing.Point(91, 155)
        Me.lstHighScore.Name = "lstHighScore"
        Me.lstHighScore.Size = New System.Drawing.Size(120, 95)
        Me.lstHighScore.TabIndex = 1
        '
        'btnAgain
        '
        Me.btnAgain.Location = New System.Drawing.Point(613, 325)
        Me.btnAgain.Name = "btnAgain"
        Me.btnAgain.Size = New System.Drawing.Size(75, 23)
        Me.btnAgain.TabIndex = 2
        Me.btnAgain.Text = "Again"
        Me.btnAgain.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Location = New System.Drawing.Point(613, 372)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(75, 23)
        Me.btnQuit.TabIndex = 3
        Me.btnQuit.Text = "Quit"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'frmHighScore
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAgain)
        Me.Controls.Add(Me.lstHighScore)
        Me.Controls.Add(Me.lblCongratulations)
        Me.Name = "frmHighScore"
        Me.Text = "frmHighScore"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblCongratulations As Label
    Friend WithEvents lstHighScore As ListBox
    Friend WithEvents btnAgain As Button
    Friend WithEvents btnQuit As Button
End Class
