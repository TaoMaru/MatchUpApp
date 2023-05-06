<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSplash
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
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblCopyright = New System.Windows.Forms.Label()
        Me.lblVersion = New System.Windows.Forms.Label()
        Me.lblAuthor = New System.Windows.Forms.Label()
        Me.picLogoMind = New System.Windows.Forms.PictureBox()
        Me.picLogoHead = New System.Windows.Forms.PictureBox()
        CType(Me.picLogoMind, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picLogoHead, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblTitle
        '
        Me.lblTitle.Font = New System.Drawing.Font("Rockwell", 22.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(266, 168)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(228, 64)
        Me.lblTitle.TabIndex = 1
        Me.lblTitle.Text = "Match Up!"
        Me.lblTitle.TextAlign = System.Drawing.ContentAlignment.BottomLeft
        '
        'lblCopyright
        '
        Me.lblCopyright.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCopyright.Location = New System.Drawing.Point(281, 307)
        Me.lblCopyright.Name = "lblCopyright"
        Me.lblCopyright.Size = New System.Drawing.Size(205, 26)
        Me.lblCopyright.TabIndex = 2
        Me.lblCopyright.Text = "Label1"
        '
        'lblVersion
        '
        Me.lblVersion.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblVersion.Location = New System.Drawing.Point(281, 246)
        Me.lblVersion.Name = "lblVersion"
        Me.lblVersion.Size = New System.Drawing.Size(205, 26)
        Me.lblVersion.TabIndex = 3
        Me.lblVersion.Text = "Label1"
        '
        'lblAuthor
        '
        Me.lblAuthor.Font = New System.Drawing.Font("Calibri", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblAuthor.Location = New System.Drawing.Point(281, 276)
        Me.lblAuthor.Name = "lblAuthor"
        Me.lblAuthor.Size = New System.Drawing.Size(205, 26)
        Me.lblAuthor.TabIndex = 4
        Me.lblAuthor.Text = "Label1"
        '
        'picLogoMind
        '
        Me.picLogoMind.BackColor = System.Drawing.Color.Black
        Me.picLogoMind.Image = Global.MatchUpApp.My.Resources.Resources.mind_map_spin
        Me.picLogoMind.Location = New System.Drawing.Point(86, 55)
        Me.picLogoMind.Name = "picLogoMind"
        Me.picLogoMind.Size = New System.Drawing.Size(97, 80)
        Me.picLogoMind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoMind.TabIndex = 5
        Me.picLogoMind.TabStop = False
        '
        'picLogoHead
        '
        Me.picLogoHead.Image = Global.MatchUpApp.My.Resources.Resources.head_svgrepo_com
        Me.picLogoHead.Location = New System.Drawing.Point(23, 32)
        Me.picLogoHead.Name = "picLogoHead"
        Me.picLogoHead.Size = New System.Drawing.Size(237, 200)
        Me.picLogoHead.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.picLogoHead.TabIndex = 0
        Me.picLogoHead.TabStop = False
        '
        'frmSplash
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.PaleTurquoise
        Me.ClientSize = New System.Drawing.Size(498, 348)
        Me.ControlBox = False
        Me.Controls.Add(Me.picLogoMind)
        Me.Controls.Add(Me.lblAuthor)
        Me.Controls.Add(Me.lblVersion)
        Me.Controls.Add(Me.lblCopyright)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.picLogoHead)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "frmSplash"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.picLogoMind, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picLogoHead, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents picLogoHead As PictureBox
    Friend WithEvents lblTitle As Label
    Friend WithEvents lblCopyright As Label
    Friend WithEvents lblVersion As Label
    Friend WithEvents lblAuthor As Label
    Friend WithEvents picLogoMind As PictureBox
End Class
