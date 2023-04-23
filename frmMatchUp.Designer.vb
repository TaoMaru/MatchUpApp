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
        Me.lblHeading = New System.Windows.Forms.Label()
        Me.picHead = New System.Windows.Forms.PictureBox()
        Me.picMind = New System.Windows.Forms.PictureBox()
        Me.grpTaskSize = New System.Windows.Forms.GroupBox()
        Me.cboMode = New System.Windows.Forms.ComboBox()
        Me.lblInstructions = New System.Windows.Forms.Label()
        Me.rdoShort = New System.Windows.Forms.RadioButton()
        Me.rdoLong = New System.Windows.Forms.RadioButton()
        Me.grpIcons = New System.Windows.Forms.GroupBox()
        Me.lblSampleWord = New System.Windows.Forms.Label()
        Me.picOption1 = New System.Windows.Forms.PictureBox()
        Me.picOption2 = New System.Windows.Forms.PictureBox()
        Me.picOption3 = New System.Windows.Forms.PictureBox()
        Me.picOption4 = New System.Windows.Forms.PictureBox()
        Me.picCorrect = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnOK = New System.Windows.Forms.Button()
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMind, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpTaskSize.SuspendLayout()
        Me.grpIcons.SuspendLayout()
        CType(Me.picOption1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOption2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOption3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picOption4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picCorrect, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.Location = New System.Drawing.Point(366, 32)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(358, 72)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Match Up!"
        Me.lblHeading.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picHead
        '
        Me.picHead.Location = New System.Drawing.Point(-1, 0)
        Me.picHead.Name = "picHead"
        Me.picHead.Size = New System.Drawing.Size(236, 190)
        Me.picHead.TabIndex = 1
        Me.picHead.TabStop = False
        '
        'picMind
        '
        Me.picMind.BackColor = System.Drawing.Color.Black
        Me.picMind.Location = New System.Drawing.Point(70, 244)
        Me.picMind.Name = "picMind"
        Me.picMind.Size = New System.Drawing.Size(97, 88)
        Me.picMind.TabIndex = 2
        Me.picMind.TabStop = False
        '
        'grpTaskSize
        '
        Me.grpTaskSize.Controls.Add(Me.rdoLong)
        Me.grpTaskSize.Controls.Add(Me.rdoShort)
        Me.grpTaskSize.Location = New System.Drawing.Point(391, 338)
        Me.grpTaskSize.Name = "grpTaskSize"
        Me.grpTaskSize.Size = New System.Drawing.Size(330, 125)
        Me.grpTaskSize.TabIndex = 3
        Me.grpTaskSize.TabStop = False
        Me.grpTaskSize.Text = "Choose a Task Size:"
        '
        'cboMode
        '
        Me.cboMode.FormattingEnabled = True
        Me.cboMode.Items.AddRange(New Object() {"Printed Word Match", "Spoken Word Match"})
        Me.cboMode.Location = New System.Drawing.Point(489, 231)
        Me.cboMode.Name = "cboMode"
        Me.cboMode.Size = New System.Drawing.Size(121, 24)
        Me.cboMode.TabIndex = 4
        Me.cboMode.Text = "Select Mode:"
        '
        'lblInstructions
        '
        Me.lblInstructions.Location = New System.Drawing.Point(262, 161)
        Me.lblInstructions.Name = "lblInstructions"
        Me.lblInstructions.Size = New System.Drawing.Size(566, 67)
        Me.lblInstructions.TabIndex = 5
        Me.lblInstructions.Text = "Please choos a Match Up Mode to begin!"
        Me.lblInstructions.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'rdoShort
        '
        Me.rdoShort.Location = New System.Drawing.Point(63, 34)
        Me.rdoShort.Name = "rdoShort"
        Me.rdoShort.Size = New System.Drawing.Size(184, 40)
        Me.rdoShort.TabIndex = 0
        Me.rdoShort.TabStop = True
        Me.rdoShort.Text = "RadioButton1"
        Me.rdoShort.UseVisualStyleBackColor = True
        '
        'rdoLong
        '
        Me.rdoLong.Location = New System.Drawing.Point(63, 80)
        Me.rdoLong.Name = "rdoLong"
        Me.rdoLong.Size = New System.Drawing.Size(184, 40)
        Me.rdoLong.TabIndex = 1
        Me.rdoLong.TabStop = True
        Me.rdoLong.Text = "RadioButton2"
        Me.rdoLong.UseVisualStyleBackColor = True
        '
        'grpIcons
        '
        Me.grpIcons.Controls.Add(Me.picOption4)
        Me.grpIcons.Controls.Add(Me.picOption3)
        Me.grpIcons.Controls.Add(Me.picOption2)
        Me.grpIcons.Controls.Add(Me.picOption1)
        Me.grpIcons.Location = New System.Drawing.Point(24, 338)
        Me.grpIcons.Name = "grpIcons"
        Me.grpIcons.Size = New System.Drawing.Size(1044, 294)
        Me.grpIcons.TabIndex = 6
        Me.grpIcons.TabStop = False
        '
        'lblSampleWord
        '
        Me.lblSampleWord.Location = New System.Drawing.Point(427, 81)
        Me.lblSampleWord.Name = "lblSampleWord"
        Me.lblSampleWord.Size = New System.Drawing.Size(237, 83)
        Me.lblSampleWord.TabIndex = 7
        Me.lblSampleWord.Text = "SAMPLE"
        Me.lblSampleWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'picOption1
        '
        Me.picOption1.Location = New System.Drawing.Point(21, 80)
        Me.picOption1.Name = "picOption1"
        Me.picOption1.Size = New System.Drawing.Size(217, 153)
        Me.picOption1.TabIndex = 0
        Me.picOption1.TabStop = False
        '
        'picOption2
        '
        Me.picOption2.Location = New System.Drawing.Point(283, 80)
        Me.picOption2.Name = "picOption2"
        Me.picOption2.Size = New System.Drawing.Size(217, 153)
        Me.picOption2.TabIndex = 1
        Me.picOption2.TabStop = False
        '
        'picOption3
        '
        Me.picOption3.Location = New System.Drawing.Point(545, 80)
        Me.picOption3.Name = "picOption3"
        Me.picOption3.Size = New System.Drawing.Size(217, 153)
        Me.picOption3.TabIndex = 2
        Me.picOption3.TabStop = False
        '
        'picOption4
        '
        Me.picOption4.Location = New System.Drawing.Point(807, 80)
        Me.picOption4.Name = "picOption4"
        Me.picOption4.Size = New System.Drawing.Size(217, 153)
        Me.picOption4.TabIndex = 3
        Me.picOption4.TabStop = False
        '
        'picCorrect
        '
        Me.picCorrect.Location = New System.Drawing.Point(722, 140)
        Me.picCorrect.Name = "picCorrect"
        Me.picCorrect.Size = New System.Drawing.Size(158, 124)
        Me.picCorrect.TabIndex = 8
        Me.picCorrect.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Location = New System.Drawing.Point(286, 231)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(152, 63)
        Me.btnStart.TabIndex = 9
        Me.btnStart.Text = "Start!"
        Me.btnStart.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnExit.Location = New System.Drawing.Point(651, 231)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(152, 63)
        Me.btnExit.TabIndex = 10
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnOK
        '
        Me.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnOK.Location = New System.Drawing.Point(459, 261)
        Me.btnOK.Name = "btnOK"
        Me.btnOK.Size = New System.Drawing.Size(173, 91)
        Me.btnOK.TabIndex = 11
        Me.btnOK.Text = "OK"
        Me.btnOK.UseVisualStyleBackColor = True
        '
        'frmMatchUp
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(1090, 644)
        Me.Controls.Add(Me.btnOK)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.picCorrect)
        Me.Controls.Add(Me.lblSampleWord)
        Me.Controls.Add(Me.lblInstructions)
        Me.Controls.Add(Me.cboMode)
        Me.Controls.Add(Me.grpTaskSize)
        Me.Controls.Add(Me.picMind)
        Me.Controls.Add(Me.picHead)
        Me.Controls.Add(Me.lblHeading)
        Me.Controls.Add(Me.grpIcons)
        Me.Name = "frmMatchUp"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Match Up!"
        CType(Me.picHead, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMind, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpTaskSize.ResumeLayout(False)
        Me.grpIcons.ResumeLayout(False)
        CType(Me.picOption1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOption2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOption3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picOption4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picCorrect, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

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
End Class
