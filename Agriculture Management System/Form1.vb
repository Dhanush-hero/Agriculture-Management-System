Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class Form1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Configure ProgressBar
        ProgressBar1.Style = ProgressBarStyle.Continuous
        ProgressBar1.Minimum = 0
        ProgressBar1.Maximum = 100
        ProgressBar1.Value = 0 ' Start at 0
        Me.DoubleBuffered = True

        ' Start the timer for smooth increment
        Timer1.Interval = 10 ' Adjust speed as needed
        Timer1.Start()
        Me.WindowState = FormWindowState.Maximized
        Me.FormBorderStyle = FormBorderStyle.Sizable
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        ' Increment the ProgressBar value
        If ProgressBar1.Value < ProgressBar1.Maximum Then
            ProgressBar1.Value += 1
        Else
            ' When ProgressBar reaches 100, stop the timer
            Timer1.Stop()

            ' Optionally, transition to the next form (e.g., Login Form)
            Me.Hide()
            Dim loginForm As New Form2
            loginForm.Show()
        End If
    End Sub

    Private Sub ProgressBar1_Click(sender As Object, e As EventArgs) Handles ProgressBar1.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs)

    End Sub
End Class

