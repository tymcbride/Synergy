Imports Transitions

Public Class FluentSettings

    Private Sub FluentSettings_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        TextBox1.Text = My.Settings.FolderLocation
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Panel2.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.FromArgb(249, 249, 249))
        t.add(Panel1, "BackColor", Color.FromArgb(249, 249, 249))
        t.run()
        Timer1.Enabled = True
    End Sub

    Private Sub Label1_MouseDown(sender As Object, e As MouseEventArgs) Handles Label1.MouseDown, Panel2.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel1, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter, Panel2.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.White)
        t.add(Panel1, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave, Panel2.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.FromArgb(249, 249, 249))
        t.add(Panel1, "BackColor", Color.FromArgb(249, 249, 249))
        t.run()
    End Sub

    Private Sub Label1_MouseUp(sender As Object, e As MouseEventArgs) Handles Label1.MouseUp, Panel2.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.White)
        t.add(Panel1, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Timer1.Enabled = False
        FolderBrowserDialog1.ShowDialog()
        TextBox1.Text = FolderBrowserDialog1.SelectedPath
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel5, "BackColor", Color.FromArgb(249, 249, 249))
        t.add(Panel3, "BackColor", Color.FromArgb(249, 249, 249))
        t.run()
        Timer2.Enabled = True
    End Sub

    Private Sub Label2_MouseDown(sender As Object, e As MouseEventArgs) Handles Label2.MouseDown, Panel5.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel5, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel3, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter, Panel5.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel5, "BackColor", Color.White)
        t.add(Panel3, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave, Panel5.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel5, "BackColor", Color.FromArgb(249, 249, 249))
        t.add(Panel3, "BackColor", Color.FromArgb(249, 249, 249))
        t.run()
    End Sub

    Private Sub Label2_MouseUp(sender As Object, e As MouseEventArgs) Handles Label2.MouseUp, Panel5.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel5, "BackColor", Color.White)
        t.add(Panel3, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        My.Settings.FolderLocation = TextBox1.Text
        Me.Close()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click
        Process.Start("https://github.com/tymcbride/Synergy")
    End Sub
End Class