Public Class Form1
    Dim iScore As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        'picFlappy default location is set
        picFlappy.Location = New Point(Me.Size.Width / 6, Me.Size.Height / 2)
        Timer1.Enabled = False
        Timer2.Enabled = False

    End Sub

    Sub flappyDrop()
        picFlappy.Top += 10
    End Sub

    Sub checkBottom()
        If picFlappy.Location.Y > Me.Height - picFlappy.Size.Height - 45 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            MsgBox("Game Over!")
        End If
    End Sub

    Sub checkTop()
        If picFlappy.Location.Y < 0 Then
            Timer1.Enabled = False
            Timer2.Enabled = False
            MsgBox("Game Over!")
        End If
    End Sub
    Sub detectCollision()
        If PictureBox1.Left < picFlappy.Left AndAlso picFlappy.Left < PictureBox1.Right Then
            If PictureBox1.Top < picFlappy.Top AndAlso picFlappy.Top < PictureBox1.Bottom Then
                Timer1.Enabled = False
                Timer2.Enabled = False
                MsgBox("Game Over!")
            End If
        End If
        If PictureBox2.Left < picFlappy.Left AndAlso picFlappy.Left < PictureBox2.Right Then
            If PictureBox2.Top < picFlappy.Top AndAlso picFlappy.Top < PictureBox2.Bottom Then
                Timer1.Enabled = False
                Timer2.Enabled = False
                MsgBox("Game Over!")
            End If
        End If
        If PictureBox3.Left < picFlappy.Left AndAlso picFlappy.Left < PictureBox3.Right Then
            If PictureBox3.Top < picFlappy.Top AndAlso picFlappy.Top < PictureBox3.Bottom Then
                Timer1.Enabled = False
                Timer2.Enabled = False
                MsgBox("Game Over!")
            End If
        End If
        If PictureBox4.Left < picFlappy.Left AndAlso picFlappy.Left < PictureBox4.Right Then
            If PictureBox4.Top < picFlappy.Top AndAlso picFlappy.Top < PictureBox4.Bottom Then
                Timer1.Enabled = False
                Timer2.Enabled = False
                MsgBox("Game Over!")
            End If
        End If
        If PictureBox5.Left < picFlappy.Left AndAlso picFlappy.Left < PictureBox5.Right Then
            If PictureBox5.Top < picFlappy.Top AndAlso picFlappy.Top < PictureBox5.Bottom Then
                Timer1.Enabled = False
                Timer2.Enabled = False
                MsgBox("Game Over!")
            End If
        End If
        If PictureBox6.Left < picFlappy.Left AndAlso picFlappy.Left < PictureBox6.Right Then
            If PictureBox6.Top < picFlappy.Top AndAlso picFlappy.Top < PictureBox6.Bottom Then
                Timer1.Enabled = False
                Timer2.Enabled = False
                MsgBox("Game Over!")
            End If
        End If

    End Sub

    Sub movBlock()
        If PictureBox1.Location.X < 0 Then
            PictureBox1.Location = New Point(Me.Width, PictureBox1.Location.Y)
            iScore = iScore + 1

        Else
            PictureBox1.Left -= 5
        End If
        If PictureBox2.Location.X < 0 Then
            PictureBox2.Location = New Point(Me.Width, PictureBox2.Location.Y)
        Else
            PictureBox2.Left -= 5
        End If
        If PictureBox3.Location.X < 0 Then
            PictureBox3.Location = New Point(Me.Width, PictureBox3.Location.Y)
            iScore = iScore + 1

        Else
            PictureBox3.Left -= 5
        End If
        If PictureBox4.Location.X < 0 Then
            PictureBox4.Location = New Point(Me.Width, PictureBox4.Location.Y)
        Else
            PictureBox4.Left -= 5
        End If
        If PictureBox5.Location.X < 0 Then
            PictureBox5.Location = New Point(Me.Width, PictureBox5.Location.Y)
        Else
            PictureBox5.Left -= 5
        End If
        If PictureBox6.Location.X < 0 Then
            PictureBox6.Location = New Point(Me.Width, PictureBox6.Location.Y)
            iScore = iScore + 1

        Else
            PictureBox6.Left -= 5
        End If
    End Sub

    Sub showScores()
        If Timer1.Enabled = False And Timer2.Enabled = False Then
            MsgBox("Your score is " & iScore)
            Me.Close()
        End If
    End Sub

    Sub speed()
        Select Case iScore
            Case 6
                Timer2.Interval = 35
            Case 12
                Timer2.Interval = 30
            Case 18
                Timer2.Interval = 25
            Case 24
                Timer2.Interval = 20
            Case 30
                Timer2.Interval = 15
            Case 36
                Timer2.Interval = 10
            Case 42
                Timer2.Interval = 5
            Case 48
                Timer2.Interval = 0
        End Select
    End Sub

    Private Sub Form1_KeyDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles MyBase.KeyDown
        If Timer1.Enabled = True And Timer2.Enabled = True Then
            If e.KeyValue = Keys.Space Then
                picFlappy.Top -= 50
            End If
        End If
        If e.KeyValue = Keys.Enter Then
            Timer1.Enabled = True
            Timer1.Interval = 70
            Timer2.Enabled = True
            Timer2.Interval = 35
            Label1.Visible = False
        End If
    End Sub


    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick
        flappyDrop()
        checkBottom()
        checkTop()
        detectCollision()
        showScores()
        speed()
    End Sub

    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        movBlock()
    End Sub
End Class
