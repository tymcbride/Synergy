Public Class Form1

    Dim GCID_Store As String
    Dim GCID_Till As String
    Dim GCID_Invoice As String
    Dim GCID_Month As String
    Dim GCID_Day As String
    Dim GCID_Year As String
    Dim GCID_Old As String
    Dim GCID_Password As String

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please enter a valid Bitdefender serial number.")
            Exit Sub
        End If
        If TextBox2.Text = "" Then
            If RadioButton2.Checked = False Then
                MsgBox("Please enter a valid Acronis serial number.")
                Exit Sub
            End If
        End If
        If TextBox3.Text.Length = 15 = False Then
            MsgBox("Uh oh, the GCID doesn't look like it's been entered correctly. Please make sure that it is in the 'SSSYYMMDDTTIIII' format where S - Store, Y - Year, M - Month, D - Day, T - Till and I - Invoice. For best results, simply copy and paste the GCID from the key portal.")
            Exit Sub
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
        If RadioButton1.Checked = True Then
            'GSHM Setup
            RichTextBox1.Text = "Bitdefender Serial Number: " + TextBox1.Text + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs" + vbNewLine + vbNewLine + "Acronis Serial Number: " + TextBox2.Text + vbNewLine + "Acronis Password: " + GCID_Password
        ElseIf RadioButton2.Checked = True Then
            'Ultimate Setup
            RichTextBox1.Text = "Bitdefender Serial Number: " + TextBox1.Text + vbNewLine + "Bitdefender Password: " + GCID_Password + "Gs"
        End If

        On Error GoTo 3
        'Save File
        RichTextBox1.SaveFile(My.Settings.FolderLocation + "\" + GCID_Store + "-" + GCID_Till + "-" + GCID_Invoice + ".txt", RichTextBoxStreamType.PlainText)

        Exit Sub

1:      MsgBox("uh oh, an error has occured. Please check that all of the information entered is accurate and try again.")
        Exit Sub

2:      MsgBox("Uh oh, an error has occured when creating the text file. Please check that all of the information entered is accurate and try again. If the issue persists, try restarting the app.")
        Exit Sub

3:      MsgBox("Uh oh, an error has occured when saving the file. Please check that the path exists by clicking the 'Open File Location' button, and that there is not already a file with this GCID in that location.")
        Exit Sub
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        On Error GoTo 1
        Process.Start(My.Settings.FolderLocation)
        Exit Sub
1:
        MsgBox("Uh oh, an error has occured. Please check that the path exists and is correct.")
        Exit Sub
    End Sub

    Private Sub RadioButton1_Click(sender As Object, e As EventArgs) Handles RadioButton1.Click
        TextBox2.Enabled = True
    End Sub

    Private Sub RadioButton2_Click(sender As Object, e As EventArgs) Handles RadioButton2.Click
        TextBox2.Enabled = False
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Button1.ContextMenu = ContextMenu1
        Button2.ContextMenu = ContextMenu1
    End Sub

    Private Sub MenuItem1_Click(sender As Object, e As EventArgs) Handles MenuItem1.Click
        Form2.Show()
    End Sub
End Class
