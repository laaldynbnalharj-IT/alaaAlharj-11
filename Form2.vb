Public Class Form1
    Private Sub DataToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DataToolStripMenuItem.Click
        Label1.Text = DateString
        Timer1.Enabled = False
    End Sub

    Private Sub TimeToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TimeToolStripMenuItem.Click
        Label1.Text = TimeString
        Timer1.Enabled = True
    End Sub

    Private Sub NowToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles NowToolStripMenuItem.Click
        Label1.Text = Now.ToString
        Timer1.Enabled = False
    End Sub

    Private Sub HourToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles HourToolStripMenuItem.Click
        Label1.Text = Hour(Now).ToString
        Timer1.Enabled = False
    End Sub

    Private Sub MinuteToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MinuteToolStripMenuItem.Click
        Label1.Text = Minute(Now).ToString
        Timer1.Enabled = False
    End Sub

    Private Sub SecondToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SecondToolStripMenuItem.Click
        Label1.Text = Second(Now).ToString
        Timer1.Enabled = False
    End Sub

    Private Sub MonthToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MonthToolStripMenuItem.Click
        Label1.Text = Month(Now).ToString()
        Timer1.Enabled = False
    End Sub

    Private Sub YearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles YearToolStripMenuItem.Click
        Label1.Text = Year(Now).ToString()
        Timer1.Enabled = False
    End Sub

    Private Sub WeekdayToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles WeekdayToolStripMenuItem.Click
        Label1.Text = Weekday(Now).ToString()
        Timer1.Enabled = False
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label1.Text = TimeString
    End Sub
End Class
