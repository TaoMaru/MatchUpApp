﻿' Project Name: Match Up!
' Developer: Maria Jackson
' Date: Aril 22, 2023
' Purpose: This app uses a Match-To-Sample task design to foster learning of semantic meaning
''          of basic English words. Two mode types are available: printed and spoken word. 
''          In Printed Word Mode: printed words such as car, tree, etc. are presented one at a time
''          and four images are presented. When the correct match is selected, a green check appears.
''          When an incorrect image is selected, the program moves on to the next word.
''          In Spoken Word Mode: the same basic words are presesnted audibly and the same process follows.
''          There are two task sizes: short version consists of 5 words. Long version consists of 10 words.
''          At the end of the series, the total number of correct words is presented.
''          
Public Class frmMatchUp
    Private Sub frmMatchUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
        MaximizeBox = False
        MinimizeBox = False
        ResetForm()
        GetWords()
        CreateIconsList()
    End Sub

    'program variables:
    Private _strWordList(9) As String 'holds target words 
    Private Const _cintShortTask As Integer = 5 'length of a short task, 5 words
    Private Const _cintLongTask As Integer = 10 'length of a long task, 10 words
    Private readyForNext As Boolean = False

    'picture/icons:
    Private _strIconsList(9) As String 'Holds icons
    Private Sub CreateIconsList()
        'populates icon file path lists by getting the current directory and combining file names
        Dim charsToTrim() As Char = {"\", "D", "e", "b", "u", "g"} 'used to remove excess from file path
        Dim iconDir As String = IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.Trim(charsToTrim))
        _strIconsList(0) = IO.Path.Combine(iconDir, "samplePNGs\bike-sport-travel-svgrepo-com.png")
        _strIconsList(1) = IO.Path.Combine(iconDir, "samplePNGs\book-closed-svgrepo-com.png")
        _strIconsList(2) = IO.Path.Combine(iconDir, "samplePNGs\car-svgrepo-com.png")
        _strIconsList(3) = IO.Path.Combine(iconDir, "samplePNGs\cat-5-svgrepo-com.png")
        _strIconsList(4) = IO.Path.Combine(iconDir, "samplePNGs\clock-svgrepo-com.png")
        _strIconsList(5) = IO.Path.Combine(iconDir, "samplePNGs\sitting-dog-svgrepo-com.png")
        _strIconsList(6) = IO.Path.Combine(iconDir, "samplePNGs\fish-svgrepo-com.png")
        _strIconsList(7) = IO.Path.Combine(iconDir, "samplePNGs\house-svgrepo-com.png")
        _strIconsList(8) = IO.Path.Combine(iconDir, "samplePNGs\phone-svgrepo-com.png")
        _strIconsList(9) = IO.Path.Combine(iconDir, "samplePNGs\tree-svgrepo-com.png")
        Dim intIconIndex As Integer
        'For intIconIndex = 0 To (_strIconsList.Length() - 1)
        'MsgBox(_strIconsList(intIconIndex), vbOKOnly, "icon path")
        'Next
    End Sub

    Private Sub ResetForm()
        'resets form to load state: hide btns and containers that are used in match tasks
        btnOK.Visible = False
        grpIcons.Visible = False
        picCorrect.Visible = False
        btnStart.Enabled = False
        lblSampleWord.Visible = False
        grpTaskSize.Visible = False
        ShowLogo() 'show the app logo
    End Sub

    Private Sub HideLogo()
        'hides the 2 pic Boxes that comprise the logo
        picHead.Visible = False
        picMind.Visible = False
    End Sub

    Private Sub ShowLogo()
        'shows the 2 pic Boxes that comprises the logo
        picHead.Visible = True
        picMind.Visible = True
    End Sub


    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub

    Private Sub cboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMode.SelectedIndexChanged
        lblInstructions.Visible = False
        grpTaskSize.Visible = True
        rdoShort.Checked = True
        btnStart.Enabled = True
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        ' Begins task: hides app title, logo, start & exit btns, cboMode, & grpTaskSize
        ' Shows series of words & icon groups
        lblHeading.Visible = False
        grpTaskSize.Visible = False
        cboMode.Visible = False
        btnStart.Visible = False
        btnExit.Visible = False
        btnOK.Visible = True
        HideLogo()
        'temp variables:
        Dim intNumTasks As Integer = 5
        Dim intCurrTask As Integer
        'show word
        'For intCurrTask = 0 To (intNumTasks - 1)
        'ShowWord(intCurrTask)
        'Next
        'determine game type:
        If cboMode.SelectedIndex = 0 And rdoShort.Checked = True Then
            PlayShortTask()
        Else
            'PlayLongTask()
        End If
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'shows grpIcon to present the image options to the user
        'hides btnOk
        btnOK.Visible = False
        ShowIconOptions()
        readyForNext = False
    End Sub

    'Event btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click

    Private Sub ShowIconOptions()
        grpIcons.Visible = True
        lblInstructions.Text = ""
        lblInstructions.Visible = True
    End Sub

    Private Sub GetWords()
        'get the list of target words & populate _strWordList with contents
        Dim trimChars() As Char = {"\", "D", "e", "b", "u", "g"} 'used to remove excess from file path
        Dim currDir As String = IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.Trim(trimChars))
        'Without Trim, currDir includes <MatchUpApp\bin\Debug> - with Trim, removes <bin\Debug>
        Dim filePath As String = IO.Path.Combine(currDir, "targetWords.txt") 'read file
        'MsgBox(currDir, vbOKOnly, "currdir")
        'MsgBox(filePath, vbOKOnly, "path")
        Dim textReader As IO.StreamReader
        Dim intIndex As Integer = 0

        Try
            textReader = IO.File.OpenText(filePath)
            Do While textReader.Peek <> -1
                _strWordList(intIndex) = textReader.ReadLine()
                intIndex += 1
            Loop
        Catch ex As Exception
            MsgBox("We had trouble reading the file. Please try again.", vbOKOnly, "File Read Error")
            Reset()
        End Try
    End Sub

    Private Sub ShowWord(ByVal taskNum As Integer, ByVal wordArray As String())
        'shows next word in the task series
        lblSampleWord.Text = wordArray(taskNum)
        lblSampleWord.Visible = True
        ' MsgBox(wordArray(taskNum), vbOKOnly, "task word")
    End Sub

    Private Sub PlayShortTask()
        'get 5 words from list
        Dim strShortList As String() = GetShortList()
        'Present word series:
        Dim intCurrWordIndex As Integer = 0
        readyForNext = True
        Do While intCurrWordIndex <= (strShortList.Length() - 1)
            ShowWord(intCurrWordIndex, strShortList)
            SetIconsToPicBoxes(intCurrWordIndex)
            btnOK.Visible = True
            btnOK.Enabled = True
            intCurrWordIndex += 1
        Loop
    End Sub

    Private Function GetShortList() As String()
        ' creates short word list from original list
        Dim strShortWordList(4) As String
        Dim intWordIndex As Integer
        For intWordIndex = 0 To (strShortWordList.Length() - 1)
            strShortWordList(intWordIndex) = _strWordList(intWordIndex)
            '(strShortWordList(intWordIndex), vbOKOnly, "word")
        Next
        Return strShortWordList
    End Function

    Private Sub SetIconsToPicBoxes(ByVal intCurrSample As Integer)
        ' populates the picture boxes with icons
        Dim currSampleImage As Image = Image.FromFile(_strIconsList(intCurrSample))
        Dim intI As Integer = intCurrSample
        picOption1.BackgroundImage = currSampleImage
        picOption1.SizeMode = PictureBoxSizeMode.StretchImage
        If (intI + 1) < _strIconsList.Length() Then
            picOption2.BackgroundImage = Image.FromFile(_strIconsList(intI + 1))
            picOption2.SizeMode = PictureBoxSizeMode.StretchImage
        Else
            intI = 0
            picOption2.BackgroundImage = Image.FromFile(_strIconsList(intI))
            picOption2.SizeMode = PictureBoxSizeMode.StretchImage
            If (intI + 2) < _strIconsList.Length() Then
                picOption3.BackgroundImage = Image.FromFile(_strIconsList(intI + 2))
                picOption3.SizeMode = PictureBoxSizeMode.StretchImage
            Else
                intI = 0
                picOption3.BackgroundImage = Image.FromFile(_strIconsList(intI))
                picOption3.SizeMode = PictureBoxSizeMode.StretchImage
                If (intI + 3) < _strIconsList.Length() Then
                    picOption4.BackgroundImage = Image.FromFile(_strIconsList(intI + 3))
                    picOption4.SizeMode = PictureBoxSizeMode.StretchImage
                Else
                    intI = 0
                    picOption4.BackgroundImage = Image.FromFile(_strIconsList(intI))
                    picOption4.SizeMode = PictureBoxSizeMode.StretchImage
                End If
            End If
        End If
    End Sub

    Private Sub picOption1_Click(sender As Object, e As EventArgs) Handles picOption1.Click
        ' decides of is correct icon
        readyForNext = True
        lblInstructions.Text = "option 1"
    End Sub

    Private Sub picOption2_Click(sender As Object, e As EventArgs) Handles picOption2.Click
        ' decides of is correct icon
        readyForNext = True
        lblInstructions.Text = "option 2"
    End Sub

    Private Sub picOption3_Click(sender As Object, e As EventArgs) Handles picOption3.Click
        ' decides of is correct icon
        readyForNext = True
        lblInstructions.Text = "option 3"
    End Sub

    Private Sub picOption4_Click(sender As Object, e As EventArgs) Handles picOption4.Click
        ' decides of is correct icon
        readyForNext = True
        lblInstructions.Text = "option 4"
    End Sub
End Class
