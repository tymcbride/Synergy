Imports Transitions

Public Class FluentForm

    Dim GCID_Store As String
    Dim GCID_Till As String
    Dim GCID_Invoice As String
    Dim GCID_Month As String
    Dim GCID_Day As String
    Dim GCID_Year As String
    Dim GCID_Old As String
    Dim GCID_Password As String
    Dim KeyType As String = "G"
    Dim FlashTimerSender As String
    Dim FlashTimerCount As Integer = 0

    Private Sub FluentForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label9.Text = My.Settings.TitleText
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Panel2.Click
        KeyType = "G"
        TextBox2.Enabled = True
        Panel12.BackColor = Color.White
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Label1, "ForeColor", Color.White)
        t.add(Label2, "ForeColor", Color.FromArgb(112, 110, 113))
        t.run()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Panel3.Click
        KeyType = "U"
        TextBox2.Enabled = False
        Panel12.BackColor = Color.FromArgb(240, 240, 240)
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Label2, "ForeColor", Color.White)
        t.add(Label1, "ForeColor", Color.FromArgb(112, 110, 113))
        t.run()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter, Panel2.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.FromArgb(90, 90, 90))
        t.add(Panel5, "BackColor", Color.FromArgb(90, 90, 90))
        t.run()
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave, Panel2.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.FromArgb(64, 64, 66))
        t.add(Panel5, "BackColor", Color.FromArgb(64, 64, 66))
        t.run()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter, Panel3.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel3, "BackColor", Color.FromArgb(90, 90, 90))
        t.add(Panel6, "BackColor", Color.FromArgb(90, 90, 90))
        t.run()
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave, Panel3.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel3, "BackColor", Color.FromArgb(64, 64, 66))
        t.add(Panel6, "BackColor", Color.FromArgb(64, 64, 66))
        t.run()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Panel14.Click
        FluentSettings.Show()
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter, Panel14.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel14, "BackColor", Color.FromArgb(90, 90, 90))
        t.add(Panel15, "BackColor", Color.FromArgb(90, 90, 90))
        t.run()
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave, Panel14.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel14, "BackColor", Color.FromArgb(64, 64, 66))
        t.add(Panel15, "BackColor", Color.FromArgb(64, 64, 66))
        t.run()
    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Panel13.Click, Label6.Click
        If TextBox3.Text.Length = 15 = False Then
            FlashTimerSender = "gcid"
            FlashTimerA.Enabled = True
            Exit Sub
        End If
        If TextBox1.TextLength < 5 Then
            FlashTimerSender = "bitdefender"
            FlashTimerA.Enabled = True
            Exit Sub
        End If
        If TextBox2.TextLength < 15 Then
            If TextBox2.Enabled = True Then
                FlashTimerSender = "acronis"
                FlashTimerA.Enabled = True
                Exit Sub
            End If
        End If

        On Error GoTo 1
        'Store
        GCID_Old = TextBox3.Text
        GCID_Store = "0" + GCID_Old.Substring(0, 3)

        'Till
        GCID_Till = GCID_Old.Remove(0, 9)
        GCID_Till = "0" + GCID_Till.Substring(0, 2)

        'Invoice
        GCID_Invoice = GCID_Old.Remove(0, 11)

        'Month
        GCID_Month = GCID_Old.Remove(0, 5)
        GCID_Month = GCID_Month.Substring(0, 2)

        'Day
        GCID_Day = GCID_Old.Remove(0, 7)
        GCID_Day = GCID_Day.Substring(0, 2)

        'Year
        GCID_Year = GCID_Old.Remove(0, 3)
        GCID_Year = GCID_Year.Substring(0, 2)

        'Generate Password
        GCID_Password = GCID_Store + GCID_Till + GCID_Invoice + GCID_Month + GCID_Day + GCID_Year

        On Error GoTo 2
        If KeyType = "G" Then
            'GSHM Setup
            RichTextBox1.Text = "Bitdefender Serial Number: " + TextBox1.Text + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs" + vbNewLine + vbNewLine + "Acronis Serial Number: " + TextBox2.Text + vbNewLine + "Acronis Password: " + GCID_Password
        ElseIf KeyType = "U" Then
            'Ultimate Setup
            RichTextBox1.Text = "Bitdefender Serial Number: " + TextBox1.Text + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs"
        End If

        On Error GoTo 3
        'Save File
        If System.IO.File.Exists(My.Settings.FolderLocation + "\" + GCID_Store + "-" + GCID_Till + "-" + GCID_Invoice + ".txt") Then
            Dim result As Integer = MessageBox.Show("A file with this GCID already exists. Do you wish to over-write it?", "GCID Info File Already Exists", MessageBoxButtons.YesNo)
            If result = DialogResult.No Then
                Exit Sub
            ElseIf result = DialogResult.Yes Then

            End If
        End If
        RichTextBox1.SaveFile(My.Settings.FolderLocation + "\" + GCID_Store + "-" + GCID_Till + "-" + GCID_Invoice + ".txt", RichTextBoxStreamType.PlainText)
        RichTextBox1.Text = ""
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label6.Location = New Point(26, 13)
        Label6.Text = "File Saved Successfully"
        TextBox3.Focus()
        Timer1.Enabled = True
        Exit Sub

1:      MsgBox("An error has occured. Please check that all of the information entered is accurate and try again.")
        Exit Sub

2:      MsgBox("An error has occured when creating the text file. Please check that all of the information entered is accurate and try again. If the issue persists, try restarting the app.")
        Exit Sub

3:      MsgBox("An error has occured when saving the file. Please check that the path exists by clicking the 'Open File Location' button, and that there is not already a file with this GCID in that location.")
        Exit Sub
    End Sub

    Private Sub Label6_MouseDown(sender As Object, e As MouseEventArgs) Handles Panel13.MouseDown, Label6.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel13, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel16, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label6_MouseEnter(sender As Object, e As EventArgs) Handles Panel13.MouseEnter, Label6.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel13, "BackColor", Color.White)
        t.add(Panel16, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label6_MouseLeave(sender As Object, e As EventArgs) Handles Panel13.MouseLeave, Label6.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel13, "BackColor", Color.FromArgb(249, 249, 249))
        t.add(Panel16, "BackColor", Color.FromArgb(249, 249, 249))
        t.run()
    End Sub

    Private Sub Label6_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel13.MouseUp, Label6.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel13, "BackColor", Color.White)
        t.add(Panel16, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        Label6.Location = New Point(43, 13)
        Label6.Text = "Generate and Save"
        Timer1.Enabled = False
    End Sub

    Private Sub FlashTimerA_Tick(sender As Object, e As EventArgs) Handles FlashTimerA.Tick
        If FlashTimerCount = 0 Then
            If FlashTimerSender = "bitdefender" Then
                Panel10.BackColor = Color.FromArgb(255, 205, 210)
                TextBox1.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 1
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            ElseIf FlashTimerSender = "gcid" Then
                Panel7.BackColor = Color.FromArgb(255, 205, 210)
                TextBox3.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 1
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            ElseIf FlashTimerSender = "acronis" Then
                Panel12.BackColor = Color.FromArgb(255, 205, 210)
                TextBox2.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 1
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            End If
            Exit Sub
        ElseIf FlashTimerCount = 2 Then
            If FlashTimerSender = "bitdefender" Then
                Panel10.BackColor = Color.FromArgb(255, 205, 210)
                TextBox1.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 3
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            ElseIf FlashTimerSender = "gcid" Then
                Panel7.BackColor = Color.FromArgb(255, 205, 210)
                TextBox3.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 3
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            ElseIf FlashTimerSender = "acronis" Then
                Panel12.BackColor = Color.FromArgb(255, 205, 210)
                TextBox2.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 3
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            End If
            Exit Sub
        ElseIf FlashTimerCount = 4 Then
            If FlashTimerSender = "bitdefender" Then
                Panel10.BackColor = Color.FromArgb(255, 205, 210)
                TextBox1.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 5
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            ElseIf FlashTimerSender = "gcid" Then
                Panel7.BackColor = Color.FromArgb(255, 205, 210)
                TextBox3.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 5
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            ElseIf FlashTimerSender = "acronis" Then
                Panel12.BackColor = Color.FromArgb(255, 205, 210)
                TextBox2.BackColor = Color.FromArgb(255, 205, 210)
                FlashTimerCount = 5
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = True
            End If
            Exit Sub
        End If
    End Sub

    Private Sub FlashTimerB_Tick(sender As Object, e As EventArgs) Handles FlashTimerB.Tick
        If FlashTimerCount = 1 Then
            If FlashTimerSender = "bitdefender" Then
                Panel10.BackColor = Color.White
                TextBox1.BackColor = Color.White
                FlashTimerCount = 2
                FlashTimerA.Enabled = True
                FlashTimerB.Enabled = False
            ElseIf FlashTimerSender = "gcid" Then
                Panel7.BackColor = Color.White
                TextBox3.BackColor = Color.White
                FlashTimerCount = 2
                FlashTimerA.Enabled = True
                FlashTimerB.Enabled = False
            ElseIf FlashTimerSender = "acronis" Then
                Panel12.BackColor = Color.White
                TextBox2.BackColor = Color.White
                FlashTimerCount = 2
                FlashTimerA.Enabled = True
                FlashTimerB.Enabled = False
            End If
            Exit Sub
        ElseIf FlashTimerCount = 3 Then
            If FlashTimerSender = "bitdefender" Then
                Panel10.BackColor = Color.White
                TextBox1.BackColor = Color.White
                FlashTimerCount = 4
                FlashTimerA.Enabled = True
                FlashTimerB.Enabled = False
            ElseIf FlashTimerSender = "gcid" Then
                Panel7.BackColor = Color.White
                TextBox3.BackColor = Color.White
                FlashTimerCount = 4
                FlashTimerA.Enabled = True
                FlashTimerB.Enabled = False
            ElseIf FlashTimerSender = "acronis" Then
                Panel12.BackColor = Color.White
                TextBox2.BackColor = Color.White
                FlashTimerCount = 4
                FlashTimerA.Enabled = True
                FlashTimerB.Enabled = False
            End If
            Exit Sub
        ElseIf FlashTimerCount = 5 Then
            If FlashTimerSender = "bitdefender" Then
                Panel10.BackColor = Color.White
                TextBox1.BackColor = Color.White
                FlashTimerCount = 0
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = False
            ElseIf FlashTimerSender = "gcid" Then
                Panel7.BackColor = Color.White
                TextBox3.BackColor = Color.White
                FlashTimerCount = 0
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = False
            ElseIf FlashTimerSender = "acronis" Then
                Panel12.BackColor = Color.White
                TextBox2.BackColor = Color.White
                FlashTimerCount = 0
                FlashTimerA.Enabled = False
                FlashTimerB.Enabled = False
            End If
            Exit Sub
        End If
    End Sub

    Private Sub Label9_DoubleClick(sender As Object, e As EventArgs) Handles Label9.DoubleClick
        TextBox4.Text = My.Settings.TitleText
        TextBox4.Visible = True
        TextBox4.BringToFront()
        TextBox4.Focus()
        TextBox4.SelectAll()
    End Sub

    Private Sub TextBox4_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox4.KeyDown
        If e.KeyCode = Keys.Enter Then
            My.Settings.TitleText = TextBox4.Text
            TextBox4.Visible = False
            TextBox4.SendToBack()
            Label9.Text = My.Settings.TitleText
            My.Settings.Save()
        End If
    End Sub
End Class