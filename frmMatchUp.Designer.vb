<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMatchUp
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.grpTaskSize = New System.Windows.Forms.GroupBox()
        Me.rdoLong = New System.Windows.Forms.RadioButton()
        Me.rdoShort = New System.Windows.Forms.RadioButton()
        Me.cboMode = New System.Windows.Forms.ComboBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.grpIcons = New System.Windows.Forms.GroupBox()
        Me.picOption4 = New System.Windows.Forms.PictureBox()
        Me.picOption3 = New System.Windows.Forms.PictureBox()
        Me.picOption2 = New System.Windows.Forms.PictureBox()
        Me.picOption1 = New System.Windows.Forms.PictureBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.lblSampleWord = New System.Windows.Forms.Label()
        Me.btnOK = New System.Windows.Forms.Button()
        Me.picCorrect = New System.Windows.Forms.PictureBox()
        Me.picMind = New System.Windows.Forms.PictureBox()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.lblTotalCorrect = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.grpTaskSize.SuspendLayout()
        Me.grpIcons.SuspendLayout()
        CType(Me.picOption4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOption3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOption2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOption1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCorrect, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.BackColor = System.Drawing.Color.Transparent
        Me.lblHeading.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(359, 16)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(372, 90)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Match Up!"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpTaskSize
        '
        Me.grpTaskSize.BackColor = System.Drawing.Color.Transparent
        Me.grpTaskSize.Controls.Add(Me.rdoLong)
        Me.grpTaskSize.Controls.Add(Me.rdoShort)
        Me.grpTaskSize.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpTaskSize.Location = New System.Drawing.Point(380, 338)
        Me.grpTaskSize.Name = "grpTaskSize"
        Me.grpTaskSize.Size = New System.Drawing.Size(330, 125)
        Me.grpTaskSize.TabIndex = 3
        Me.grpTaskSize.TabStop = False
        Me.grpTaskSize.Text = "Choose a Task Size:"
        '
        'rdoLong
        '
        Me.rdoLong.BackColor = System.Drawing.Color.Transparent
        Me.rdoLong.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoLong.Location = New System.Drawing.Point(79, 80)
        Me.rdoLong.Name = "rdoLong"
        Me.rdoLong.Size = New System.Drawing.Size(184, 40)
        Me.rdoLong.TabIndex = 1
        Me.rdoLong.TabStop = True
        Me.rdoLong.Text = "10 Words"
        Me.rdoLong.UseVisualStyleBackColor = False
        '
        'rdoShort
        '
        Me.rdoShort.BackColor = System.Drawing.Color.Transparent
        Me.rdoShort.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rdoShort.Location = New System.Drawing.Point(79, 34)
        Me.rdoShort.Name = "rdoShort"
        Me.rdoShort.Size = New System.Drawing.Size(184, 40)
        Me.rdoShort.TabIndex = 0
        Me.rdoShort.TabStop = True
        Me.rdoShort.Text = "5 Words"
        Me.rdoShort.UseVisualStyleBackColor = False
        '
        'cboMode
        '
        Me.cboMode.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboMode.FormattingEnabled = True
        Me.cboMode.Items.AddRange(New Object() {"Printed Word Match", "Spoken Word Match"})
        Me.cboMode.Location = New System.Drawing.Point(361, 231)
        Me.cboMode.Name = "cboMode"
        Me.cboMode.Size = New System.Drawing.Size(369, 41)
        Me.cboMode.TabIndex = 4
        Me.cboMode.Text = "Select Mode:"
        '
        'lblInstructions
        '
        Me.lblInstructions.BackColor = System.Drawing.Color.Transparent
        Me.lblInstructions.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblInstructions.Location = New System.Drawing.Point(199, 161)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(693, 67)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = "Please choose a Match Up Mode to begin!"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'grpIcons
        '
        Me.grpIcons.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.grpIcons.Controls.Add(Me.picOption4)
        Me.grpIcons.Controls.Add(Me.picOption3)
        Me.grpIcons.Controls.Add(Me.picOption2)
        Me.grpIcons.Controls.Add(Me.picOption1)
        Me.grpIcons.Location = New System.Drawing.Point(24, 315)
        Me.grpIcons.Name = "grpIcons"
        Me.grpIcons.Size = New System.Drawing.Size(1044, 294)
        Me.grpIcons.TabIndex = 6
        Me.grpIcons.TabStop = False
        '
        'picOption4
        '
        Me.picOption4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picOption4.Location = New System.Drawing.Point(807, 80)
        Me.picOption4.Name = "picOption4"
        Me.picOption4.Size = New System.Drawing.Size(217, 153)
        Me.picOption4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOption4.TabIndex = 3
        Me.picOption4.TabStop = False
        '
        'picOption3
        '
        Me.picOption3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picOption3.Location = New System.Drawing.Point(545, 80)
        Me.picOption3.Name = "picOption3"
        Me.picOption3.Size = New System.Drawing.Size(217, 153)
        Me.picOption3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOption3.TabIndex = 2
        Me.picOption3.TabStop = False
        '
        'picOption2
        '
        Me.picOption2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picOption2.Location = New System.Drawing.Point(283, 80)
        Me.picOption2.Name = "picOption2"
        Me.picOption2.Size = New System.Drawing.Size(217, 153)
        Me.picOption2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOption2.TabIndex = 1
        Me.picOption2.TabStop = False
        '
        'picOption1
        '
        Me.picOption1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picOption1.Location = New System.Drawing.Point(21, 80)
        Me.picOption1.Name = "picOption1"
        Me.picOption1.Size = New System.Drawing.Size(217, 153)
        Me.picOption1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picOption1.TabIndex = 0
        Me.picOption1.TabStop = False
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(590, 585)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 63)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.LightGoldenrodYellow
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.Location = New System.Drawing.Point(349, 585)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(152, 63)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'lblSampleWord
        '
        Me.lblSampleWord.BackColor = System.Drawing.Color.Transparent
        Me.lblSampleWord.Font = New System.Drawing.Font("Georgia", 26.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSampleWord.Location = New System.Drawing.Point(427, 81)
        Me.lblSampleWord.Name = "lblSampleWord"
        Me.lblSampleWord.Size = New System.Drawing.Size(237, 83)
        Me.lblSampleWord.TabIndex = 7
        Me.lblSampleWord.Text = "SAMPLE"
        Me.lblSampleWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'btnOK
        '
        Me.btnOK.BackColor = System.Drawing.Color.Yellow
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Font = New System.Drawing.Font("Rockwell", 16.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOK.Location = New System.Drawing.Point(459, 261)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(173, 91)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = False
        '
        'picCorrect
        '
        Me.picCorrect.BackColor = System.Drawing.Color.Transparent
        Me.picCorrect.Image = Global.MatchUpApp.My.Resources.Resources.check_svgrepo_com
        Me.picCorrect.Location = New System.Drawing.Point(722, 107)
        Me.picCorrect.Name = "picCorrect"
        Me.picCorrect.Size = New System.Drawing.Size(144, 157)
        Me.picCorrect.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picCorrect.TabIndex = 8
        Me.picCorrect.TabStop = False
        '
        'picMind
        '
        Me.picMind.BackColor = System.Drawing.Color.Black
        Me.picMind.Image = Global.MatchUpApp.My.Resources.Resources.mind_map_svgrepo_com
        Me.picMind.Location = New System.Drawing.Point(55, 16)
        Me.picMind.Name = "picMind"
        Me.picMind.Size = New System.Drawing.Size(97, 88)
        Me.picMind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picMind.TabIndex = 2
        Me.picMind.TabStop = False
        '
        'picHead
        '
        Me.picHead.Image = Global.MatchUpApp.My.Resources.Resources.head_svgrepo_com
        Me.picHead.Location = New System.Drawing.Point(-1, 0)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(236, 190)
        Me.picHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picHead.TabIndex = 1
        Me.picHead.TabStop = False
        '
        'lblTotalCorrect
        '
        Me.lblTotalCorrect.Font = New System.Drawing.Font("Rockwell", 24.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTotalCorrect.Location = New System.Drawing.Point(13, 275)
        Me.lblTotalCorrect.Name = "lblTotalCorrect"
        Me.lblTotalCorrect.Size = New System.Drawing.Size(1065, 232)
        Me.lblTotalCorrect.TabIndex = 12
        Me.lblTotalCorrect.Text = "Nice Work! XX/XX"
        Me.lblTotalCorrect.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Timer1
        '
        Me.Timer1.Interval = 500
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(-1, 539)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(51, 17)
        Me.lblTimer.TabIndex = 13
        Me.lblTimer.Text = "Label1"
        Me.lblTimer.Visible = False
        '
        'frmMatchUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1090, 660)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.lblTotalCorrect)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.picCorrect)
        Me.Controls.Add(Me.lblSampleWord)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.cboMode)
        Me.Controls.Add(Me.grpTaskSize)
        Me.Controls.Add(Me.picMind)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.grpIcons)
        Me.Name = "frmMatchUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Match Up!"
        Me.grpTaskSize.ResumeLayout(False)
        Me.grpIcons.ResumeLayout(False)
        CType(Me.picOption4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOption3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOption2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOption1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCorrect, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents picHead As PictureBox
    Friend WithEvents picMind As PictureBox
    Friend WithEvents grpTaskSize As GroupBox
    Friend WithEvents cboMode As ComboBox
    Friend WithEvents lblInstructions As Label
    Friend WithEvents rdoLong As RadioButton
    Friend WithEvents rdoShort As RadioButton
    Friend WithEvents grpIcons As GroupBox
    Friend WithEvents lblSampleWord As Label
    Friend WithEvents picOption4 As PictureBox
    Friend WithEvents picOption3 As PictureBox
    Friend WithEvents picOption2 As PictureBox
    Friend WithEvents picOption1 As PictureBox
    Friend WithEvents picCorrect As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents btnOK As Button
    Friend WithEvents lblTotalCorrect As Label
    Friend WithEvents Timer1 As Timer
    Friend WithEvents lblTimer As Label
End Class
