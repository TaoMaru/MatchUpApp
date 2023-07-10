' Project Name: Match Up!
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
''Update: July 6, 2013 - Spoken Word Mode
''          
Public Class frmMatchUp
    Private Sub frmMatchUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'hides splash screen after 5 seconds, resets form, gets words and icons from file
        Threading.Thread.Sleep(5000)
        MaximizeBox = False
        MinimizeBox = False
        ResetForm()
        GetWords()
        GetAudio()
        CreateIconsList()
    End Sub

    'program variables:
    Private _strWordList(9) As String 'holds target words 
    Private intCurrWordSampleIndex As Integer 'the index of current word displayed
    Private _tskAllTaskItems As TaskItem() ' holds task items for short or long tasks
    Private _strShortIconList As String() 'holds icon paths as string in short match task
    Private intTotalCorrect As Integer = 0 'the total number correct matches
    Private intCurrWordIndex As Integer = 0 'the index of the current target word
    Private strAudioList(9) As String ' holds target word audio
    Private strAudioPathList(9) As String 'holds target word audio paths
    'sample words & file I/O:
    Private Sub GetWords()
        'get the list of target words & populate _strWordList with contents
        Dim trimChars() As Char = {"\", "D", "e", "b", "u", "g"} 'used to remove excess from file path
        Dim currDir As String = IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.Trim(trimChars))
        'Without Trim, currDir includes <MatchUpApp\bin\Debug> - with Trim, removes <bin\Debug>
        Dim filePath As String = IO.Path.Combine(currDir, "targetWords.txt") 'read file
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
            ResetForm()
        End Try
    End Sub

    Private Sub GetAudio()
        'get the audio files for the target words
        ReDim strAudioList(1)
        ReDim strAudioPathList(1)
        Dim charsToTrim() As Char = {"\", "D", "e", "b", "u", "g"} 'used to remove excess from file path
        Try
            Dim currDirectory As String = IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.Trim(charsToTrim))
            Dim audFilePath As String = currDirectory + "\sampleWAVs"
            Dim dir As IO.DirectoryInfo = New IO.DirectoryInfo(audFilePath)
            'grab filenames from audio directory:
            For Each audFile In dir.GetFiles()
                strAudioList(strAudioList.Length - 1) = audFile.Name
                strAudioPathList(strAudioPathList.Length - 1) = audFilePath + "\" + audFile.Name
                ReDim Preserve strAudioList(strAudioList.Length)
                ReDim Preserve strAudioPathList(strAudioPathList.Length)
            Next
        Catch ex As Exception
            MsgBox("We had trouble accessing the audio directory. Please try again.", vbOKOnly, "Audio Path Error")
            Reset()
            ResetForm()
        End Try

    End Sub

    'picture/icons:
    Private _strIconsList(9) As String 'Holds icons
    Private Sub CreateIconsList()
        'populates icon file path lists by getting the current directory and combining file names
        Try
            Dim charsToTrim() As Char = {"\", "D", "e", "b", "u", "g"} 'used to remove excess from file path
            Dim iconDir As String = IO.Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory.Trim(charsToTrim))
            _strIconsList(0) = IO.Path.Combine(iconDir, "smallSamplePNGs\bike.png")
            _strIconsList(1) = IO.Path.Combine(iconDir, "smallSamplePNGs\book.png")
            _strIconsList(2) = IO.Path.Combine(iconDir, "smallSamplePNGs\car.png")
            _strIconsList(3) = IO.Path.Combine(iconDir, "smallSamplePNGs\cat.png")
            _strIconsList(4) = IO.Path.Combine(iconDir, "smallSamplePNGs\clock.png")
            _strIconsList(5) = IO.Path.Combine(iconDir, "smallSamplePNGs\dog.png")
            _strIconsList(6) = IO.Path.Combine(iconDir, "smallSamplePNGs\fish.png")
            _strIconsList(7) = IO.Path.Combine(iconDir, "smallSamplePNGs\house.png")
            _strIconsList(8) = IO.Path.Combine(iconDir, "smallSamplePNGs\phone.png")
            _strIconsList(9) = IO.Path.Combine(iconDir, "smallSamplePNGs\tree.png")
        Catch pathTooLong As IO.PathTooLongException
            MsgBox("The icon png file paths are too long. Check the file directory and try again.",
                                                vbOKOnly, "Icon PNG File Path Too Long!")
            ResetForm()
        Catch argEx As ArgumentException
            MsgBox("An error occurred while trying to find the icon png directory. Please try again.",
                                                vbOKOnly, "Error Retrieving Icon PNG Directory!")
            ResetForm()
        Catch ex As Exception
            MsgBox("An error occurred while loading the sample icon pngs. Please try again.",
                                                vbOKOnly, "Error Loading Sample Icons!")
            ResetForm()
        End Try
    End Sub

    'check mark location settings:
    Private picOp1Location = New Point(60, 300) ' position at picOption 1
    Private picOp2Location = New Point(260, 300) ' position at picOption 2
    Private picOp3Location = New Point(470, 300) ' position at picOption 3
    Private picOp4Location = New Point(640, 300) ' position at picOption 4

    Private Sub ChangeCheckLocation(ByVal optionNum As Integer)
        'moves check mark location to the location of the corresponding picOption
        If optionNum = 1 Then
            picCorrect.Location = picOp1Location
        ElseIf optionNum = 2 Then
            picCorrect.Location = picOp2Location
        ElseIf optionNum = 3 Then
            picCorrect.Location = picOp3Location
        Else
            picCorrect.Location = picOp4Location
        End If
    End Sub

    'General procedures:
    Private Sub ResetForm()
        'resets form to load state: hide btns and containers that are used in match tasks
        btnOK.Visible = False
        btnNew.Visible = False
        HideIcons()
        HideCheck()
        btnStart.Visible = True
        btnStart.Enabled = False
        btnExit.Visible = True
        btnNext.Visible = False
        lblSampleWord.Visible = False
        grpTaskSize.Visible = False
        HideTotalCorrect() 'hide end label
        ShowLogo() 'show the app logo
        lblHeading.Visible = True
        lblInstructions.Visible = True
        cboMode.Text = "Select Match Up Mode:"
        cboMode.Visible = True
        'reset task variables to 0:
        intTotalCorrect = 0
        intCurrWordIndex = 0
        intCurrWordSampleIndex = 0
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

    'General form events:
    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        'closes program
        Close()
    End Sub

    Private Sub btnNew_Click(sender As Object, e As EventArgs) Handles btnNew.Click
        'resets form and all matching game options
        ResetForm()
    End Sub

    Private Sub cboMode_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cboMode.SelectedIndexChanged
        'handles selection of cboMode change
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

        'determine game type:
        If cboMode.SelectedIndex = 0 And rdoShort.Checked = True Then
            ' short printed word task
            PlayShortTask(intCurrWordIndex)
        ElseIf cboMode.SelectedIndex = 0 And rdoLong.Checked = True Then
            'long printed word task
            PlayLongTask(intCurrWordIndex)
        ElseIf cboMode.SelectedIndex = 1 And rdoShort.Checked = True Then
            'short spoken word task
            PlayShortAudioTask(intCurrWordIndex)
        ElseIf (cboMode.SelectedIndex = 1 And rdoLong.Checked = True) Then
            'long spoken word task
            PlayLongAudioTask(intCurrWordIndex)
        Else
            MsgBox("An error occurred. Please try again!", vbOKOnly, "Game Start Error")
            ResetForm()
        End If
    End Sub


    'Task Item class & task related actions:
    Private Class TaskItem
        'task item holds image and associated index during matching tasks
        Private taskImage As Image
        Private intIndex As Integer
        'constructor:
        Public Sub UpdateTaskItem(tImage As Image, intTIndex As Integer)
            taskImage = tImage
            intIndex = intTIndex
        End Sub
        'task obj methods:
        Public Function GetTaskImage()
            Return taskImage
        End Function
        Public Function GetTaskIndex()
            Return intIndex
        End Function

    End Class

    Private Sub PlaySampleAudio(ByVal sampleIndex As Integer)
        'plays the audio for current task's sample word
        My.Computer.Audio.Play(strAudioPathList(sampleIndex + 1), AudioPlayMode.Background)
    End Sub

    Private Sub ShortCreateTaskItems(ByVal intCurrSample As Integer)
        ' populates the picture boxes with icons for a short (5 item) task
        Try
            Dim currSampleImage As Image = Image.FromFile(_strShortIconList(intCurrSample))
            Dim intI As Integer = intCurrSample
            'picOption1.BackgroundImage = currSampleImage
            Dim picBox1 = New TaskItem()
            Dim picBox2 = New TaskItem()
            Dim picBox3 = New TaskItem()
            Dim picBox4 = New TaskItem()
            ReDim _tskAllTaskItems(3)
            'add task items to array:
            _tskAllTaskItems(0) = picBox1
            _tskAllTaskItems(1) = picBox2
            _tskAllTaskItems(2) = picBox3
            _tskAllTaskItems(3) = picBox4
            'set task item images
            picBox4.UpdateTaskItem(currSampleImage, (intI Mod _strShortIconList.Length()))
            currSampleImage = Image.FromFile(_strShortIconList(((intI + 1) Mod _strShortIconList.Length())))
            picBox2.UpdateTaskItem(currSampleImage, ((intI + 1) Mod _strShortIconList.Length()))
            currSampleImage = Image.FromFile(_strShortIconList(((intI + 2) Mod _strShortIconList.Length())))
            picBox3.UpdateTaskItem(currSampleImage, ((intI + 2) Mod _strShortIconList.Length()))
            currSampleImage = Image.FromFile(_strShortIconList(((intI + 3) Mod _strShortIconList.Length())))
            picBox1.UpdateTaskItem(currSampleImage, ((intI + 3) Mod _strShortIconList.Length()))
        Catch fileNotFound As IO.FileNotFoundException
            MsgBox("The icon file could not be located. Please try again.", vbOKOnly, "Icon File Not Found!")
            ResetForm()
        Catch outOfMem As OutOfMemoryException
            MsgBox("There may not be enough memory to load the icons. Please try again.", vbOKOnly,
                                                            "Not Enough Memory to Load Icons")
            ResetForm()
        Catch ex As Exception
            MsgBox("An error occurred when loading the icons on screen. Please try again.", vbOKOnly,
                                                            "Could Not Load Icons On Screen")
            ResetForm()
        End Try

    End Sub

    Private Sub LongCreateTaskItems(ByVal intCurrSample As Integer)
        ' populates the picture boxes with icons for a long (10 item) task
        Try
            Dim currSampleImage As Image = Image.FromFile(_strIconsList(intCurrSample))
            Dim intI As Integer = intCurrSample
            'picOption1.BackgroundImage = currSampleImage
            Dim picBox1 = New TaskItem()
            Dim picBox2 = New TaskItem()
            Dim picBox3 = New TaskItem()
            Dim picBox4 = New TaskItem()
            ReDim _tskAllTaskItems(3)
            'add task items to array:
            _tskAllTaskItems(0) = picBox1
            _tskAllTaskItems(1) = picBox2
            _tskAllTaskItems(2) = picBox3
            _tskAllTaskItems(3) = picBox4
            'set task item images
            picBox4.UpdateTaskItem(currSampleImage, (intI Mod _strIconsList.Length()))
            currSampleImage = Image.FromFile(_strIconsList(((intI + 1) Mod _strIconsList.Length())))
            picBox2.UpdateTaskItem(currSampleImage, ((intI + 1) Mod _strIconsList.Length()))
            currSampleImage = Image.FromFile(_strIconsList(((intI + 2) Mod _strIconsList.Length())))
            picBox3.UpdateTaskItem(currSampleImage, ((intI + 2) Mod _strIconsList.Length()))
            currSampleImage = Image.FromFile(_strIconsList(((intI + 3) Mod _strIconsList.Length())))
            picBox1.UpdateTaskItem(currSampleImage, ((intI + 3) Mod _strIconsList.Length()))
        Catch fileNotFound As IO.FileNotFoundException
            MsgBox("The icon file could not be located. Please try again.", vbOKOnly, "Icon File Not Found!")
            ResetForm()
        Catch outOfMem As OutOfMemoryException
            MsgBox("There may not be enough memory to load the icons. Please try again.", vbOKOnly,
                                                            "Not Enough Memory to Load Icons")
            ResetForm()
        Catch ex As Exception
            MsgBox("An error occurred when loading the icons on screen. Please try again.", vbOKOnly,
                                                            "Could Not Load Icons On Screen")
            ResetForm()
        End Try

    End Sub

    Dim usedNums() As Integer ' holds the randomized indices of task items
    Private Sub SetIconsByTaskItem()
        'sets background image of pic boxes by retrieving images from current task items
        'uses Rnd() * upperbound to generate random nums between 0 and the upperbound
        'uses ReDim to add randomized indices to usedNums array
        Dim intNewNum As Integer 'random generated number
        Dim intTally As Integer = 0 'number of nums stored so far
        Dim nextNum As Integer = 0 'starting index for random num array
        Dim done As Boolean = False 'indicates generating random nums status
        ReDim usedNums(0)
        'generate random nums to be used as indices
        While Not done
            intNewNum = Int(Rnd() * 4)
            If Not usedNums.Contains(intNewNum) Then
                ReDim Preserve usedNums(nextNum)
                usedNums(nextNum) = intNewNum
                nextNum += 1
                intTally += 1
                If usedNums.Length() = 4 Then
                    done = True
                End If
            End If
        End While
        'use random index order to populate picBoxes with task images:
        picOption1.BackgroundImage = _tskAllTaskItems(usedNums(0)).GetTaskImage()
        picOption2.BackgroundImage = _tskAllTaskItems(usedNums(1)).GetTaskImage()
        picOption3.BackgroundImage = _tskAllTaskItems(usedNums(2)).GetTaskImage()
        picOption4.BackgroundImage = _tskAllTaskItems(usedNums(3)).GetTaskImage()

    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'shows grpIcon to present the image options to the user
        'hides btnOk
        btnOK.Visible = False
        ShowIconOptions()
        HideCheck()
    End Sub

    Private Sub ShowIconOptions()
        'shows the icon pic boxes via grpIcons
        grpIcons.Visible = True
    End Sub

    Private Function DetermineCorrect(ByVal optionIndex As Integer, ByRef intWordIndex As Integer,
                                      ByVal taskIndexArray() As Integer) As Boolean
        'determines if selected icon is the correct choice (a match to the sample)
        Return _tskAllTaskItems(taskIndexArray(optionIndex)).GetTaskIndex() = intWordIndex
    End Function

    Private Sub AddToScore()
        'increments the current score of total correct
        intTotalCorrect += 1
    End Sub

    Private Sub HideTotalCorrect()
        'hides the total correct label
        lblTotalCorrect.Visible = False
    End Sub

    Private Sub ShowTotalCorrect()
        'shows the total correct label
        lblTotalCorrect.Visible = True
    End Sub

    Private Sub UpdateTotalCorrectLabel()
        ' edits the end screen message to include the total num correct selctions out of the series total
        Dim strTotalCorrectMessage = "Nice! {0}/{1}"
        If cboMode.SelectedIndex = 0 And rdoShort.Checked = True Then
            strTotalCorrectMessage = String.Format(strTotalCorrectMessage, intTotalCorrect, _strShortIconList.Length())
        ElseIf cboMode.SelectedIndex = 0 And rdoLong.Checked = True Then
            strTotalCorrectMessage = String.Format(strTotalCorrectMessage, intTotalCorrect, _strIconsList.Length())
        ElseIf cboMode.SelectedIndex = 1 And rdoShort.Checked = True Then
            strTotalCorrectMessage = String.Format(strTotalCorrectMessage, intTotalCorrect, _strShortIconList.Length())
        ElseIf cboMode.SelectedIndex = 1 And rdoLong.Checked = True Then
            strTotalCorrectMessage = String.Format(strTotalCorrectMessage, intTotalCorrect, _strIconsList.Length())
        End If
        lblTotalCorrect.Text = strTotalCorrectMessage
    End Sub

    Private Sub ShowEndOptions()
        'shows the exit and new btns after a task series ends
        btnExit.Visible = True
        btnNew.Visible = True
        btnNext.Visible = False
    End Sub

    Private Sub ShowWord(ByVal taskNum As Integer, ByVal wordArray As String())
        'shows next word in the task series
        lblSampleWord.Text = wordArray(taskNum)
        lblSampleWord.Visible = True
        ' MsgBox(wordArray(taskNum), vbOKOnly, "task word")
    End Sub

    Private strShortList As String()

    Private Sub PlayShortTask(ByRef intCurrWordIndex As Integer)
        'runs through the first 5 words in the word list
        strShortList = GetShortList() 'create a short version of the word list
        GetShortIconList() 'create short version of the icon list
        NextShortTask(intCurrWordIndex) 'play a task: show word, get selection, continue
    End Sub

    Private Sub PlayShortAudioTask(ByRef intCurrWordIndex As Integer)
        'runs through the first 5 words in the word list with audio
        strShortList = GetShortList()
        GetShortIconList()
        NextShortAudioTask(intCurrWordIndex)
    End Sub

    Private Sub PlayLongTask(ByRef intCurrWordIndex As Integer)
        'runs through all 10 words in the word list
        NextLongTask(intCurrWordIndex) 'play a task: show word, get selection, continue
    End Sub

    Private Sub PlayLongAudioTask(ByRef intCurrWordIndex As Integer)
        'runs through all 10 spoken words in audio/word sample list
        NextLongAudioTask(intCurrWordIndex)
    End Sub

    Private Sub NextShortTask(ByRef currWordIndex As Integer)
        'plays a word task: displays word, displays icon options, gets icon selection
        btnNext.Visible = False
        ShowWord(currWordIndex, strShortList) 'use short list to grab target word
        intCurrWordSampleIndex = currWordIndex 'update current target word index
        ShortCreateTaskItems(currWordIndex) ' create task items
        SetIconsByTaskItem() 'populate icons on screen as selection options
        'ready OK btn
        btnOK.Visible = True
        btnOK.Enabled = True
    End Sub

    Private Sub NextShortAudioTask(ByRef currWordIndex As Integer)
        'plays an audio word task: plays word audio, displays icon options, gets selection
        btnNext.Visible = False
        PlaySampleAudio(currWordIndex) 'use short list to play audio
        intCurrWordSampleIndex = currWordIndex 'update current target word index
        ShortCreateTaskItems(currWordIndex) ' create task items
        SetIconsByTaskItem() ' populate icons on screen
        btnOK.Visible = True
        btnOK.Enabled = True
    End Sub

    Private Sub NextLongTask(ByRef currWordIndex As Integer)
        'plays a word task in long task: displays word, displays icon option, gets icon selction
        btnNext.Visible = False
        ShowWord(currWordIndex, _strWordList) 'use long list to grab target word
        intCurrWordSampleIndex = currWordIndex 'update current target word index
        LongCreateTaskItems(currWordIndex) 'create task items
        SetIconsByTaskItem() 'populate icons on screen as selection options
        'ready OK btn
        btnOK.Visible = True
        btnOK.Enabled = True
    End Sub

    Private Sub NextLongAudioTask(ByRef currWordIndex As Integer)
        'plays long spoken word task: plays sample word audio, displays icon options, gets selection
        btnNext.Visible = False
        PlaySampleAudio(currWordIndex) ' use long word list to play sample audio
        intCurrWordSampleIndex = currWordIndex 'update current target word index
        LongCreateTaskItems(currWordIndex) 'create task items
        SetIconsByTaskItem() 'populate icons on screen
        btnOK.Visible = True
        btnOK.Enabled = True
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

    Private Sub GetShortIconList()
        'creates a short icon list from original icons list
        Dim intIndex As Integer
        ReDim _strShortIconList(4)
        For intIndex = 0 To _strShortIconList.Length() - 1
            _strShortIconList(intIndex) = _strIconsList(intIndex)
        Next
    End Sub

    Private Sub ShowCheck()
        'shows correct checkmark
        picCorrect.Visible = True
    End Sub

    Private Sub HideCheck()
        'hides checkmark
        picCorrect.Visible = False
    End Sub

    Private Sub HideIcons()
        'hides icon group
        grpIcons.Visible = False
    End Sub

    Private Sub WaitForNext()
        ' hides icons and next word
        HideIcons()
        btnNext.Visible = True
    End Sub

    Private Sub EndSeries()
        'shows the "end screen" for tasks: final score updated & displayed, new & exit btns displayed
        UpdateTotalCorrectLabel()
        ShowTotalCorrect()
        ShowEndOptions()
    End Sub

    Private Sub btnNext_Click(sender As Object, e As EventArgs) Handles btnNext.Click
        'determines current position in task series, shows next word or end results when done
        HideCheck()
        If cboMode.SelectedIndex = 0 And rdoShort.Checked = True Then
            'Playing printed mode short task
            If intCurrWordIndex < _strShortIconList.Length() Then
                NextShortTask(intCurrWordIndex)
            Else
                EndSeries()
            End If
        ElseIf cboMode.SelectedIndex = 0 And rdoLong.Checked = True Then
            'Playing printed mode long task
            If intCurrWordIndex < _strIconsList.Length() Then
                NextLongTask(intCurrWordIndex)
            Else
                EndSeries()
            End If
        ElseIf cboMode.SelectedIndex = 1 And rdoShort.Checked = True Then
            'Playing spoken mode short task
            If intCurrWordIndex < _strShortIconList.Length() Then
                NextShortAudioTask(intCurrWordIndex)
            Else
                EndSeries()
            End If
        ElseIf cboMode.SelectedIndex = 1 And rdoLong.Checked = True Then
            'Playing spoken mode long task
            If intCurrWordIndex < _strIconsList.Length() Then
                NextLongAudioTask(intCurrWordIndex)
            Else
                EndSeries()
            End If
        End If
    End Sub

    'Icon selection: 
    Private Sub picOption1_Click(sender As Object, e As EventArgs) Handles picOption1.Click
        ' decides of is correct icon & moves on to next task or ends
        If DetermineCorrect(0, intCurrWordSampleIndex, usedNums) Then
            'answer was correct, show check mark, increment score
            ChangeCheckLocation(1)
            ShowCheck()
            AddToScore()
        End If
        WaitForNext()
        intCurrWordIndex += 1
    End Sub

    Private Sub picOption2_Click(sender As Object, e As EventArgs) Handles picOption2.Click
        ' decides of is correct icon & moves on to next task or ends
        If DetermineCorrect(1, intCurrWordSampleIndex, usedNums) Then
            'answer was correct, show check mark, increment score
            ChangeCheckLocation(2)
            ShowCheck()
            AddToScore()
        End If
        WaitForNext()
        intCurrWordIndex += 1
    End Sub

    Private Sub picOption3_Click(sender As Object, e As EventArgs) Handles picOption3.Click
        ' decides of is correct icon & moves on to next task or ends
        If DetermineCorrect(2, intCurrWordSampleIndex, usedNums) Then
            'answer was correct, show check mark, increment score
            ChangeCheckLocation(3)
            ShowCheck()
            AddToScore()
        End If
        WaitForNext()
        intCurrWordIndex += 1
    End Sub

    Private Sub picOption4_Click(sender As Object, e As EventArgs) Handles picOption4.Click
        ' decides of is correct icon & moves on to next task or ends
        If DetermineCorrect(3, intCurrWordSampleIndex, usedNums) Then
            'answer was correct, show check mark, increment score
            ChangeCheckLocation(4)
            ShowCheck()
            AddToScore()
        End If
        WaitForNext()
        intCurrWordIndex += 1
    End Sub


    'visual events:
    Private Sub picOption1_MouseHover(sender As Object, e As EventArgs) Handles picOption1.MouseHover
        'adds 3D indented effect when mouse hovers over icon
        picOption1.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub picOption1_MouseLeave(sender As Object, e As EventArgs) Handles picOption1.MouseLeave
        'removes the 3D indented border effect when mouse leaves icon
        picOption1.BorderStyle = BorderStyle.None
    End Sub

    Private Sub picOption2_MouseHover(sender As Object, e As EventArgs) Handles picOption2.MouseHover
        'adds 3D indented effect when mouse hovers over icon
        picOption2.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub picOption2_MouseLeave(sender As Object, e As EventArgs) Handles picOption2.MouseLeave
        'removes the 3D indented border effect when mouse leaves icon
        picOption2.BorderStyle = BorderStyle.None
    End Sub

    Private Sub picOption3_MouseHover(sender As Object, e As EventArgs) Handles picOption3.MouseHover
        'adds 3D indented effect when mouse hovers over icon
        picOption3.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub picOption3_MouseLeave(sender As Object, e As EventArgs) Handles picOption3.MouseLeave
        'removes the 3D indented border effect when mouse leaves icon
        picOption3.BorderStyle = BorderStyle.None
    End Sub

    Private Sub picOption4_MouseHover(sender As Object, e As EventArgs) Handles picOption4.MouseHover
        'adds 3D indented effect when mouse hovers over icon
        picOption4.BorderStyle = BorderStyle.Fixed3D
    End Sub

    Private Sub picOption4_MouseLeave(sender As Object, e As EventArgs) Handles picOption4.MouseLeave
        'removes the 3D indented border effect when mouse leaves icon
        picOption4.BorderStyle = BorderStyle.None
    End Sub

End Class
