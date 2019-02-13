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
        'Previous Setting Load
        If My.Settings.CallUpgrade = True Then
            My.Settings.Upgrade()
            My.Settings.CallUpgrade = False
        End If

        Label9.Text = My.Settings.TitleText
        TextBox5.Text = My.Settings.FolderLocation

        Label34.Text = My.Settings.Recent1_G
        Label36.Text = My.Settings.Recent1_B
        Label35.Text = My.Settings.Recent1_A
        Label39.Text = My.Settings.Recent2_G
        Label37.Text = My.Settings.Recent2_B
        Label38.Text = My.Settings.Recent2_A
        Label42.Text = My.Settings.Recent3_G
        Label40.Text = My.Settings.Recent3_B
        Label41.Text = My.Settings.Recent3_A
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click, Panel2.Click, PictureBox4.Click
        Panel17.Visible = False
        Panel30.Visible = False
        Label30.SendToBack()
        Panel17.SendToBack()
        KeyType = "G"
        PictureBox4.BackgroundImage = My.Resources.Sidebar_Member_White
        PictureBox5.BackgroundImage = My.Resources.Sidebar_Ultimate_Grey
        PictureBox6.BackgroundImage = My.Resources.Sidebar_Settings_Grey
        PictureBox10.BackgroundImage = My.Resources.Sidebar_Recent_Grey
        TextBox2.Enabled = True
        TextBox2.BackColor = Color.White
        Panel12.BackColor = Color.White
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Label1, "ForeColor", Color.White)
        t.add(Label2, "ForeColor", Color.FromArgb(112, 110, 113))
        t.add(Label7, "ForeColor", Color.FromArgb(112, 110, 113))
        t.add(Label17, "ForeColor", Color.FromArgb(112, 110, 113))
        t.run()
    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click, Panel3.Click, PictureBox5.Click
        Panel17.Visible = False
        Panel30.Visible = False
        Label30.SendToBack()
        Panel17.SendToBack()
        KeyType = "U"
        PictureBox4.BackgroundImage = My.Resources.Sidebar_Member_Grey
        PictureBox5.BackgroundImage = My.Resources.Sidebar_Ultimate_White
        PictureBox6.BackgroundImage = My.Resources.Sidebar_Settings_Grey
        PictureBox10.BackgroundImage = My.Resources.Sidebar_Recent_Grey
        TextBox2.Enabled = False
        TextBox2.BackColor = Color.FromArgb(240, 240, 240)
        Panel12.BackColor = Color.FromArgb(240, 240, 240)
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Label2, "ForeColor", Color.White)
        t.add(Label1, "ForeColor", Color.FromArgb(112, 110, 113))
        t.add(Label7, "ForeColor", Color.FromArgb(112, 110, 113))
        t.add(Label17, "ForeColor", Color.FromArgb(112, 110, 113))
        t.run()
    End Sub

    Private Sub Label1_MouseEnter(sender As Object, e As EventArgs) Handles Label1.MouseEnter, Panel2.MouseEnter, PictureBox4.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.FromArgb(90, 90, 90))
        t.add(Panel5, "BackColor", Color.FromArgb(90, 90, 90))
        t.run()
    End Sub

    Private Sub Label1_MouseLeave(sender As Object, e As EventArgs) Handles Label1.MouseLeave, Panel2.MouseLeave, PictureBox4.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel2, "BackColor", Color.FromArgb(64, 64, 66))
        t.add(Panel5, "BackColor", Color.FromArgb(64, 64, 66))
        t.run()
    End Sub

    Private Sub Label2_MouseEnter(sender As Object, e As EventArgs) Handles Label2.MouseEnter, Panel3.MouseEnter, PictureBox5.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel3, "BackColor", Color.FromArgb(90, 90, 90))
        t.add(Panel6, "BackColor", Color.FromArgb(90, 90, 90))
        t.run()
    End Sub

    Private Sub Label2_MouseLeave(sender As Object, e As EventArgs) Handles Label2.MouseLeave, Panel3.MouseLeave, PictureBox5.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel3, "BackColor", Color.FromArgb(64, 64, 66))
        t.add(Panel6, "BackColor", Color.FromArgb(64, 64, 66))
        t.run()
    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click, Panel14.Click, PictureBox6.Click
        Panel17.Visible = True
        Panel17.BringToFront()
        Panel30.Visible = False
        Panel30.SendToBack()
        PictureBox4.BackgroundImage = My.Resources.Sidebar_Member_Grey
        PictureBox5.BackgroundImage = My.Resources.Sidebar_Ultimate_Grey
        PictureBox6.BackgroundImage = My.Resources.Sidebar_Settings_White
        PictureBox10.BackgroundImage = My.Resources.Sidebar_Recent_Grey
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Label7, "ForeColor", Color.White)
        t.add(Label2, "ForeColor", Color.FromArgb(112, 110, 113))
        t.add(Label1, "ForeColor", Color.FromArgb(112, 110, 113))
        t.add(Label17, "ForeColor", Color.FromArgb(112, 110, 113))
        t.run()
    End Sub

    Private Sub Label7_MouseEnter(sender As Object, e As EventArgs) Handles Label7.MouseEnter, Panel14.MouseEnter, PictureBox6.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel14, "BackColor", Color.FromArgb(90, 90, 90))
        t.add(Panel15, "BackColor", Color.FromArgb(90, 90, 90))
        t.run()
    End Sub

    Private Sub Label7_MouseLeave(sender As Object, e As EventArgs) Handles Label7.MouseLeave, Panel14.MouseLeave, PictureBox6.MouseLeave
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
        TextBox1.BackColor = Color.FromArgb(200, 230, 201)
        TextBox2.BackColor = Color.FromArgb(200, 230, 201)
        TextBox3.BackColor = Color.FromArgb(200, 230, 201)
        Panel7.BackColor = Color.FromArgb(200, 230, 201)
        Panel10.BackColor = Color.FromArgb(200, 230, 201)
        Panel12.BackColor = Color.FromArgb(200, 230, 201)
        Label6.Location = New Point(26, 13)
        Label6.Text = "File Saved Successfully"

        'Recent Files
        My.Settings.Recent3_G = My.Settings.Recent2_G
        My.Settings.Recent3_B = My.Settings.Recent2_B
        My.Settings.Recent3_A = My.Settings.Recent2_A
        My.Settings.Recent2_G = My.Settings.Recent1_G
        My.Settings.Recent2_B = My.Settings.Recent1_B
        My.Settings.Recent2_A = My.Settings.Recent1_A
        My.Settings.Recent1_G = TextBox3.Text
        My.Settings.Recent1_B = TextBox1.Text
        If KeyType = "U" Then
            My.Settings.Recent1_A = "N/A"
        Else
            My.Settings.Recent1_A = TextBox2.Text
        End If
        Label34.Text = My.Settings.Recent1_G
        Label36.Text = My.Settings.Recent1_B
        Label35.Text = My.Settings.Recent1_A
        Label39.Text = My.Settings.Recent2_G
        Label37.Text = My.Settings.Recent2_B
        Label38.Text = My.Settings.Recent2_A
        Label42.Text = My.Settings.Recent3_G
        Label40.Text = My.Settings.Recent3_B
        Label41.Text = My.Settings.Recent3_A

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
        t.add(Panel13, "BackColor", Color.FromArgb(251, 252, 252))
        t.add(Panel16, "BackColor", Color.FromArgb(251, 252, 252))
        t.run()
    End Sub

    Private Sub Label6_MouseUp(sender As Object, e As MouseEventArgs) Handles Panel13.MouseUp, Label6.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel13, "BackColor", Color.White)
        t.add(Panel16, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        TextBox1.BackColor = Color.White
        TextBox2.BackColor = Color.White
        TextBox3.BackColor = Color.White
        Panel7.BackColor = Color.White
        Panel10.BackColor = Color.White
        Panel12.BackColor = Color.White
        TextBox1.Text = ""
        TextBox2.Text = ""
        TextBox3.Text = ""
        Label6.Location = New Point(43, 13)
        Label6.Text = "Generate and Save"
        TextBox3.Focus()
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

    Private Sub Label10_Click(sender As Object, e As EventArgs) Handles Label10.Click, Panel21.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel21, "BackColor", Color.FromArgb(251, 252, 252))
        t.add(Panel20, "BackColor", Color.FromArgb(251, 252, 252))
        t.run()
        Timer2.Enabled = True
    End Sub

    Private Sub Label10_MouseDown(sender As Object, e As MouseEventArgs) Handles Label10.MouseDown, Panel21.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel21, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel20, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label10_MouseEnter(sender As Object, e As EventArgs) Handles Label10.MouseEnter, Panel21.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel21, "BackColor", Color.White)
        t.add(Panel20, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label10_MouseLeave(sender As Object, e As EventArgs) Handles Label10.MouseLeave, Panel21.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel21, "BackColor", Color.FromArgb(251, 252, 252))
        t.add(Panel20, "BackColor", Color.FromArgb(251, 252, 252))
        t.run()
    End Sub

    Private Sub Label10_MouseUp(sender As Object, e As MouseEventArgs) Handles Label10.MouseUp, Panel21.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel21, "BackColor", Color.White)
        t.add(Panel20, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label8_MouseDown(sender As Object, e As MouseEventArgs) Handles Label8.MouseDown, Panel19.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel19, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel18, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label8_MouseEnter(sender As Object, e As EventArgs) Handles Label8.MouseEnter, Panel19.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel19, "BackColor", Color.White)
        t.add(Panel18, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label8_MouseLeave(sender As Object, e As EventArgs) Handles Label8.MouseLeave, Panel19.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel19, "BackColor", Color.FromArgb(251, 252, 252))
        t.add(Panel18, "BackColor", Color.FromArgb(251, 252, 252))
        t.run()
    End Sub

    Private Sub Label8_MouseUp(sender As Object, e As MouseEventArgs) Handles Label8.MouseUp, Panel19.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel19, "BackColor", Color.White)
        t.add(Panel18, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Timer2_Tick(sender As Object, e As EventArgs) Handles Timer2.Tick
        Timer2.Enabled = False
        FolderBrowserDialog1.ShowDialog()
        If FolderBrowserDialog1.SelectedPath = "" = False Then
            TextBox5.Text = FolderBrowserDialog1.SelectedPath
        End If
    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click, Panel19.Click
        My.Settings.FolderLocation = TextBox5.Text
        My.Settings.Save()
        Panel23.BackColor = Color.FromArgb(200, 230, 201)
        TextBox5.BackColor = Color.FromArgb(200, 230, 201)
        Timer4.Enabled = True
    End Sub

    Private Sub Timer4_Tick(sender As Object, e As EventArgs) Handles Timer4.Tick
        Panel23.BackColor = Color.White
        TextBox5.BackColor = Color.White
        Timer4.Enabled = False
    End Sub

    Private Sub Panel7_Click(sender As Object, e As EventArgs) Handles Panel7.Click
        TextBox3.Focus()
    End Sub

    Private Sub Panel10_Click(sender As Object, e As EventArgs) Handles Panel10.Click
        TextBox1.Focus()
    End Sub

    Private Sub Panel12_Click(sender As Object, e As EventArgs) Handles Panel12.Click
        TextBox2.Focus()
    End Sub

    Private Sub Label18_Click(sender As Object, e As EventArgs) Handles Label18.Click, Panel28.Click, PictureBox11.Click
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel28, "BackColor", Color.FromArgb(64, 64, 66))
        t.add(Panel29, "BackColor", Color.FromArgb(64, 64, 66))
        t.run()
        Process.Start("https://benefitsportal.gscanada.info/")
    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click, Panel26.Click, PictureBox10.Click
        Panel30.Visible = True
        Panel30.BringToFront()
        Panel17.Visible = False
        Panel17.SendToBack()
        PictureBox4.BackgroundImage = My.Resources.Sidebar_Member_Grey
        PictureBox5.BackgroundImage = My.Resources.Sidebar_Ultimate_Grey
        PictureBox6.BackgroundImage = My.Resources.Sidebar_Settings_Grey
        PictureBox10.BackgroundImage = My.Resources.Sidebar_Recent_White
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Label17, "ForeColor", Color.White)
        t.add(Label2, "ForeColor", Color.FromArgb(112, 110, 113))
        t.add(Label1, "ForeColor", Color.FromArgb(112, 110, 113))
        t.add(Label7, "ForeColor", Color.FromArgb(112, 110, 113))
        t.run()
    End Sub

    Private Sub Label18_MouseEnter(sender As Object, e As EventArgs) Handles Label18.MouseEnter, Panel28.MouseEnter, PictureBox11.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel28, "BackColor", Color.FromArgb(90, 90, 90))
        t.add(Panel29, "BackColor", Color.FromArgb(90, 90, 90))
        t.run()
    End Sub

    Private Sub Label17_MouseEnter(sender As Object, e As EventArgs) Handles Label17.MouseEnter, Panel26.MouseEnter, PictureBox10.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel26, "BackColor", Color.FromArgb(90, 90, 90))
        t.add(Panel27, "BackColor", Color.FromArgb(90, 90, 90))
        t.run()
    End Sub

    Private Sub Label18_MouseLeave(sender As Object, e As EventArgs) Handles Label18.MouseLeave, Panel28.MouseLeave, PictureBox11.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel28, "BackColor", Color.FromArgb(64, 64, 66))
        t.add(Panel29, "BackColor", Color.FromArgb(64, 64, 66))
        t.run()
    End Sub

    Private Sub Label17_MouseLeave(sender As Object, e As EventArgs) Handles Label17.MouseLeave, Panel26.MouseLeave, PictureBox10.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel26, "BackColor", Color.FromArgb(64, 64, 66))
        t.add(Panel27, "BackColor", Color.FromArgb(64, 64, 66))
        t.run()
    End Sub

    Private Sub Label20_Click(sender As Object, e As EventArgs) Handles Label20.Click, Panel31.Click, Panel32.Click
        If My.Settings.Recent1_G = "N/A" Then
            MsgBox("There is no information here to resave a file.")
        Else
            'Store
            GCID_Old = My.Settings.Recent1_G
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

            If My.Settings.Recent1_A = "N/A" = False Then
                'GSHM Setup
                RichTextBox1.Text = "Bitdefender Serial Number: " + My.Settings.Recent1_B + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs" + vbNewLine + vbNewLine + "Acronis Serial Number: " + My.Settings.Recent1_A + vbNewLine + "Acronis Password: " + GCID_Password
            Else
                'Ultimate Setup
                RichTextBox1.Text = "Bitdefender Serial Number: " + My.Settings.Recent1_B + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs"
            End If

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
            Label20.Text = "File Saved Successfully"
            Timer5.Enabled = True
        End If
    End Sub

    Private Sub Label20_MouseDown(sender As Object, e As MouseEventArgs) Handles Label20.MouseDown, Panel32.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel32, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel31, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label20_MouseEnter(sender As Object, e As EventArgs) Handles Label20.MouseEnter, Panel32.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel32, "BackColor", Color.White)
        t.add(Panel31, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label20_MouseLeave(sender As Object, e As EventArgs) Handles Label20.MouseLeave, Panel32.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel32, "BackColor", Color.FromArgb(251, 252, 252))
        t.add(Panel31, "BackColor", Color.FromArgb(251, 252, 252))
        t.run()
    End Sub

    Private Sub Label20_MouseUp(sender As Object, e As MouseEventArgs) Handles Label20.MouseUp, Panel32.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel32, "BackColor", Color.White)
        t.add(Panel31, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub


    Private Sub Label21_MouseDown(sender As Object, e As MouseEventArgs) Handles Label21.MouseDown, Panel34.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel34, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel33, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label21_MouseEnter(sender As Object, e As EventArgs) Handles Label21.MouseEnter, Panel34.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel34, "BackColor", Color.White)
        t.add(Panel33, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label21_MouseLeave(sender As Object, e As EventArgs) Handles Label21.MouseLeave, Panel34.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel34, "BackColor", Color.FromArgb(251, 252, 252))
        t.add(Panel33, "BackColor", Color.FromArgb(251, 252, 252))
        t.run()
    End Sub

    Private Sub Label21_MouseUp(sender As Object, e As MouseEventArgs) Handles Label21.MouseUp, Panel34.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel34, "BackColor", Color.White)
        t.add(Panel33, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label29_MouseDown(sender As Object, e As MouseEventArgs) Handles Label29.MouseDown, Panel36.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel36, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel35, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label29_MouseEnter(sender As Object, e As EventArgs) Handles Label29.MouseEnter, Panel36.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel36, "BackColor", Color.White)
        t.add(Panel35, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label29_MouseLeave(sender As Object, e As EventArgs) Handles Label29.MouseLeave, Panel36.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel36, "BackColor", Color.FromArgb(251, 252, 252))
        t.add(Panel35, "BackColor", Color.FromArgb(251, 252, 252))
        t.run()
    End Sub

    Private Sub Label29_MouseUp(sender As Object, e As MouseEventArgs) Handles Label29.MouseUp, Panel36.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel36, "BackColor", Color.White)
        t.add(Panel35, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label21_Click(sender As Object, e As EventArgs) Handles Label21.Click, Panel33.Click, Panel34.Click
        If My.Settings.Recent1_G = "N/A" Then
            MsgBox("There is no information here to resave a file.")
        Else
            'Store
            GCID_Old = My.Settings.Recent2_G
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

            If My.Settings.Recent2_A = "N/A" = False Then
                'GSHM Setup
                RichTextBox1.Text = "Bitdefender Serial Number: " + My.Settings.Recent2_B + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs" + vbNewLine + vbNewLine + "Acronis Serial Number: " + My.Settings.Recent2_A + vbNewLine + "Acronis Password: " + GCID_Password
            Else
                'Ultimate Setup
                RichTextBox1.Text = "Bitdefender Serial Number: " + My.Settings.Recent2_B + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs"
            End If

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
            Label21.Text = "File Saved Successfully"
            Timer5.Enabled = True
        End If
    End Sub

    Private Sub Label29_Click(sender As Object, e As EventArgs) Handles Label29.Click, Panel35.Click, Panel36.Click
        If My.Settings.Recent1_G = "N/A" Then
            MsgBox("There is no information here to resave a file.")
        Else
            'Store
            GCID_Old = My.Settings.Recent3_G
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

            If My.Settings.Recent3_A = "N/A" = False Then
                'GSHM Setup
                RichTextBox1.Text = "Bitdefender Serial Number: " + My.Settings.Recent3_B + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs" + vbNewLine + vbNewLine + "Acronis Serial Number: " + My.Settings.Recent3_A + vbNewLine + "Acronis Password: " + GCID_Password
            Else
                'Ultimate Setup
                RichTextBox1.Text = "Bitdefender Serial Number: " + My.Settings.Recent3_B + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs"
            End If

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
            Label29.Text = "File Saved Successfully"
            Timer5.Enabled = True
        End If
    End Sub

    Private Sub Timer5_Tick(sender As Object, e As EventArgs) Handles Timer5.Tick
        Label20.Text = "Re-Save to Default Folder"
        Label21.Text = "Re-Save to Default Folder"
        Label29.Text = "Re-Save to Default Folder"
        Timer5.Enabled = False
    End Sub

    Private Sub Label14_Click(sender As Object, e As EventArgs) Handles Label14.Click
        Process.Start("https://github.com/tymcbride/Synergy")
    End Sub

    Private Sub Label44_MouseDown(sender As Object, e As MouseEventArgs) Handles Label44.MouseDown, Panel39.MouseDown
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel39, "BackColor", Color.FromArgb(200, 200, 200))
        t.add(Panel38, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label44_MouseEnter(sender As Object, e As EventArgs) Handles Label44.MouseEnter, Panel39.MouseEnter
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel39, "BackColor", Color.White)
        t.add(Panel38, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label44_MouseLeave(sender As Object, e As EventArgs) Handles Label44.MouseLeave, Panel39.MouseLeave
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel39, "BackColor", Color.FromArgb(251, 252, 252))
        t.add(Panel38, "BackColor", Color.FromArgb(251, 252, 252))
        t.run()
    End Sub

    Private Sub Label44_MouseUp(sender As Object, e As MouseEventArgs) Handles Label44.MouseUp, Panel39.MouseUp
        Dim t As New Transition(New TransitionType_EaseInEaseOut(100))
        t.add(Panel39, "BackColor", Color.White)
        t.add(Panel38, "BackColor", Color.FromArgb(204, 204, 204))
        t.run()
    End Sub

    Private Sub Label44_Click(sender As Object, e As EventArgs) Handles Label44.Click, Panel39.Click, Panel38.Click
        My.Settings.Recent1_A = "N/A"
        My.Settings.Recent1_B = "N/A"
        My.Settings.Recent1_G = "N/A"
        My.Settings.Recent2_A = "N/A"
        My.Settings.Recent2_B = "N/A"
        My.Settings.Recent2_G = "N/A"
        My.Settings.Recent3_A = "N/A"
        My.Settings.Recent3_B = "N/A"
        My.Settings.Recent3_G = "N/A"

        Label34.Text = My.Settings.Recent1_G
        Label36.Text = My.Settings.Recent1_B
        Label35.Text = My.Settings.Recent1_A
        Label39.Text = My.Settings.Recent2_G
        Label37.Text = My.Settings.Recent2_B
        Label38.Text = My.Settings.Recent2_A
        Label42.Text = My.Settings.Recent3_G
        Label40.Text = My.Settings.Recent3_B
        Label41.Text = My.Settings.Recent3_A

        My.Settings.Save()
    End Sub
End Class