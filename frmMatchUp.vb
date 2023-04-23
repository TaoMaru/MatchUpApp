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
''          
Public Class frmMatchUp
    Private Sub frmMatchUp_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Threading.Thread.Sleep(5000)
        MaximizeBox = False
        MinimizeBox = False
        ResetForm()
        GetWords()
    End Sub

    Private _strWordList(10) As String


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
        For intCurrTask = 0 To (intNumTasks - 1)
            ShowWord(intCurrTask)
        Next
    End Sub

    Private Sub btnOK_Click(sender As Object, e As EventArgs) Handles btnOK.Click
        'shows grpIcon to present the image options to the user
        'hides btnOk
        btnOK.Visible = False
        ShowIconOptions()
    End Sub

    Private Sub ShowIconOptions()
        grpIcons.Visible = True
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

    Private Sub ShowWord(ByVal taskNum As Integer)
        lblSampleWord.Text = _strWordList(taskNum)
        lblSampleWord.Visible = True
    End Sub
End Class
