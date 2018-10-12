<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class attemptReports
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
        Me.commentsTextLabel = New System.Windows.Forms.Label()
        Me.scoreLabel = New System.Windows.Forms.Label()
        Me.scoreTextLabel = New System.Windows.Forms.Label()
        Me.ExamTitleLabel = New System.Windows.Forms.Label()
        Me.questionsPanel = New System.Windows.Forms.Panel()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.mathsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.englishToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.biologyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.physicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.chemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ebooksMathsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ebookEngToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EbookBioToolStripMenuIte = New System.Windows.Forms.ToolStripMenuItem()
        Me.EbookPhyToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EbookChemToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttemptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'commentsTextLabel
        '
        Me.commentsTextLabel.AutoSize = True
        Me.commentsTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.commentsTextLabel.Location = New System.Drawing.Point(-118, 100)
        Me.commentsTextLabel.Name = "commentsTextLabel"
        Me.commentsTextLabel.Size = New System.Drawing.Size(66, 24)
        Me.commentsTextLabel.TabIndex = 17
        Me.commentsTextLabel.Text = "Label4"
        Me.commentsTextLabel.Visible = False
        '
        'scoreLabel
        '
        Me.scoreLabel.AutoSize = True
        Me.scoreLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreLabel.Location = New System.Drawing.Point(-66, 65)
        Me.scoreLabel.Name = "scoreLabel"
        Me.scoreLabel.Size = New System.Drawing.Size(49, 16)
        Me.scoreLabel.TabIndex = 16
        Me.scoreLabel.Text = "Label3"
        Me.scoreLabel.Visible = False
        '
        'scoreTextLabel
        '
        Me.scoreTextLabel.AutoSize = True
        Me.scoreTextLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.scoreTextLabel.Location = New System.Drawing.Point(-119, 21)
        Me.scoreTextLabel.Name = "scoreTextLabel"
        Me.scoreTextLabel.Size = New System.Drawing.Size(60, 24)
        Me.scoreTextLabel.TabIndex = 15
        Me.scoreTextLabel.Text = "Score"
        Me.scoreTextLabel.Visible = False
        '
        'ExamTitleLabel
        '
        Me.ExamTitleLabel.AutoSize = True
        Me.ExamTitleLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExamTitleLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ExamTitleLabel.Location = New System.Drawing.Point(261, 41)
        Me.ExamTitleLabel.Name = "ExamTitleLabel"
        Me.ExamTitleLabel.Size = New System.Drawing.Size(111, 37)
        Me.ExamTitleLabel.TabIndex = 11
        Me.ExamTitleLabel.Text = "Label1"
        '
        'questionsPanel
        '
        Me.questionsPanel.BackColor = System.Drawing.Color.Gainsboro
        Me.questionsPanel.Location = New System.Drawing.Point(268, 102)
        Me.questionsPanel.Name = "questionsPanel"
        Me.questionsPanel.Size = New System.Drawing.Size(1067, 557)
        Me.questionsPanel.TabIndex = 10
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem21, Me.VideosToolStripMenuItem, Me.EvaluationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1335, 24)
        Me.MenuStrip1.TabIndex = 18
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ProfileToolStripMenuItem, Me.LogOutToolStripMenuItem, Me.ExitToolStripMenuItem})
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(52, 20)
        Me.FileToolStripMenuItem.Text = "Home"
        '
        'ProfileToolStripMenuItem
        '
        Me.ProfileToolStripMenuItem.Name = "ProfileToolStripMenuItem"
        Me.ProfileToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ProfileToolStripMenuItem.Text = "Profile"
        '
        'LogOutToolStripMenuItem
        '
        Me.LogOutToolStripMenuItem.Name = "LogOutToolStripMenuItem"
        Me.LogOutToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.LogOutToolStripMenuItem.Text = "Log out"
        '
        'ExitToolStripMenuItem
        '
        Me.ExitToolStripMenuItem.Name = "ExitToolStripMenuItem"
        Me.ExitToolStripMenuItem.Size = New System.Drawing.Size(115, 22)
        Me.ExitToolStripMenuItem.Text = "Exit"
        '
        'ToolStripMenuItem21
        '
        Me.ToolStripMenuItem21.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.mathsToolStripMenuItem, Me.englishToolStripMenuItem, Me.biologyToolStripMenuItem, Me.physicsToolStripMenuItem, Me.chemToolStripMenuItem})
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem21.Text = "Videos"
        '
        'mathsToolStripMenuItem
        '
        Me.mathsToolStripMenuItem.Name = "mathsToolStripMenuItem"
        Me.mathsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.mathsToolStripMenuItem.Text = "Mathematics"
        '
        'englishToolStripMenuItem
        '
        Me.englishToolStripMenuItem.Name = "englishToolStripMenuItem"
        Me.englishToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.englishToolStripMenuItem.Text = "English"
        '
        'biologyToolStripMenuItem
        '
        Me.biologyToolStripMenuItem.Name = "biologyToolStripMenuItem"
        Me.biologyToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.biologyToolStripMenuItem.Text = "Biology"
        '
        'physicsToolStripMenuItem
        '
        Me.physicsToolStripMenuItem.Name = "physicsToolStripMenuItem"
        Me.physicsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.physicsToolStripMenuItem.Text = "Physics"
        '
        'chemToolStripMenuItem
        '
        Me.chemToolStripMenuItem.Name = "chemToolStripMenuItem"
        Me.chemToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.chemToolStripMenuItem.Text = "Chemistry"
        '
        'VideosToolStripMenuItem
        '
        Me.VideosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ebooksMathsToolStripMenuItem, Me.ebookEngToolStripMenuItem, Me.EbookBioToolStripMenuIte, Me.EbookPhyToolStripMenuItem, Me.EbookChemToolStripMenuItem})
        Me.VideosToolStripMenuItem.Name = "VideosToolStripMenuItem"
        Me.VideosToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.VideosToolStripMenuItem.Text = "Ebooks"
        '
        'ebooksMathsToolStripMenuItem
        '
        Me.ebooksMathsToolStripMenuItem.Name = "ebooksMathsToolStripMenuItem"
        Me.ebooksMathsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ebooksMathsToolStripMenuItem.Text = "Mathematics"
        '
        'ebookEngToolStripMenuItem
        '
        Me.ebookEngToolStripMenuItem.Name = "ebookEngToolStripMenuItem"
        Me.ebookEngToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.ebookEngToolStripMenuItem.Text = "English"
        '
        'EbookBioToolStripMenuIte
        '
        Me.EbookBioToolStripMenuIte.Name = "EbookBioToolStripMenuIte"
        Me.EbookBioToolStripMenuIte.Size = New System.Drawing.Size(143, 22)
        Me.EbookBioToolStripMenuIte.Text = "Biology"
        '
        'EbookPhyToolStripMenuItem
        '
        Me.EbookPhyToolStripMenuItem.Name = "EbookPhyToolStripMenuItem"
        Me.EbookPhyToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EbookPhyToolStripMenuItem.Text = "Physics"
        '
        'EbookChemToolStripMenuItem
        '
        Me.EbookChemToolStripMenuItem.Name = "EbookChemToolStripMenuItem"
        Me.EbookChemToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.EbookChemToolStripMenuItem.Text = "Chemistry"
        '
        'EvaluationsToolStripMenuItem
        '
        Me.EvaluationsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AttemptToolStripMenuItem, Me.ResultsToolStripMenuItem})
        Me.EvaluationsToolStripMenuItem.Name = "EvaluationsToolStripMenuItem"
        Me.EvaluationsToolStripMenuItem.Size = New System.Drawing.Size(79, 20)
        Me.EvaluationsToolStripMenuItem.Text = "Evaluations"
        '
        'AttemptToolStripMenuItem
        '
        Me.AttemptToolStripMenuItem.Name = "AttemptToolStripMenuItem"
        Me.AttemptToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.AttemptToolStripMenuItem.Text = "Attempt"
        '
        'ResultsToolStripMenuItem
        '
        Me.ResultsToolStripMenuItem.Name = "ResultsToolStripMenuItem"
        Me.ResultsToolStripMenuItem.Size = New System.Drawing.Size(118, 22)
        Me.ResultsToolStripMenuItem.Text = "Results"
        '
        'attemptReports
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1335, 660)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.commentsTextLabel)
        Me.Controls.Add(Me.scoreLabel)
        Me.Controls.Add(Me.scoreTextLabel)
        Me.Controls.Add(Me.ExamTitleLabel)
        Me.Controls.Add(Me.questionsPanel)
        Me.Name = "attemptReports"
        Me.Text = "attemptReports"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents commentsTextLabel As Label
    Friend WithEvents scoreLabel As Label
    Friend WithEvents scoreTextLabel As Label
    Friend WithEvents ExamTitleLabel As Label
    Friend WithEvents questionsPanel As Panel
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As ToolStripMenuItem
    Friend WithEvents mathsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents englishToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents biologyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents physicsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents chemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents VideosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ebooksMathsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ebookEngToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EbookBioToolStripMenuIte As ToolStripMenuItem
    Friend WithEvents EbookPhyToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EbookChemToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents EvaluationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttemptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As ToolStripMenuItem
End Class
