<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ebookViewer
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ebookViewer))
        Me.ebookPlayListBox = New System.Windows.Forms.ListBox()
        Me.playMetroButton = New MetroFramework.Controls.MetroButton()
        Me.exitMetroButton = New MetroFramework.Controls.MetroButton()
        Me.ebookLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ebookAxAcroPDF = New AxAcroPDFLib.AxAcroPDF()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ProfileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LogOutToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ExitToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem21 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem22 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem23 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem24 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem25 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem26 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem27 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem28 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem29 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem30 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem31 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem32 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem33 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem34 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem35 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem36 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem37 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem38 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem39 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem40 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem41 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem42 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem43 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem44 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem45 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem46 = New System.Windows.Forms.ToolStripMenuItem()
        Me.VideosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MathematicsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form1ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form2ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form3ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.Form4ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem16 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem17 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem18 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem19 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem20 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem6 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem7 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem8 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem9 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem10 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem11 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem12 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem13 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem14 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem15 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem2 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem3 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem4 = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripMenuItem5 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EvaluationsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.AttemptToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ResultsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        CType(Me.ebookAxAcroPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ebookPlayListBox
        '
        Me.ebookPlayListBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ebookPlayListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ebookPlayListBox.FormattingEnabled = True
        Me.ebookPlayListBox.ItemHeight = 25
        Me.ebookPlayListBox.Location = New System.Drawing.Point(922, 92)
        Me.ebookPlayListBox.Name = "ebookPlayListBox"
        Me.ebookPlayListBox.Size = New System.Drawing.Size(317, 279)
        Me.ebookPlayListBox.TabIndex = 1
        '
        'playMetroButton
        '
        Me.playMetroButton.Highlight = True
        Me.playMetroButton.Location = New System.Drawing.Point(1157, 396)
        Me.playMetroButton.Name = "playMetroButton"
        Me.playMetroButton.Size = New System.Drawing.Size(82, 44)
        Me.playMetroButton.TabIndex = 2
        Me.playMetroButton.Text = "View"
        Me.playMetroButton.UseSelectable = True
        '
        'exitMetroButton
        '
        Me.exitMetroButton.Location = New System.Drawing.Point(1127, 599)
        Me.exitMetroButton.Name = "exitMetroButton"
        Me.exitMetroButton.Size = New System.Drawing.Size(103, 41)
        Me.exitMetroButton.TabIndex = 3
        Me.exitMetroButton.Text = "Exit"
        Me.exitMetroButton.UseSelectable = True
        '
        'ebookLabel
        '
        Me.ebookLabel.AutoSize = True
        Me.ebookLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ebookLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ebookLabel.Location = New System.Drawing.Point(398, 52)
        Me.ebookLabel.Name = "ebookLabel"
        Me.ebookLabel.Size = New System.Drawing.Size(95, 31)
        Me.ebookLabel.TabIndex = 4
        Me.ebookLabel.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(976, 52)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(165, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Related Books"
        '
        'ebookAxAcroPDF
        '
        Me.ebookAxAcroPDF.Enabled = True
        Me.ebookAxAcroPDF.Location = New System.Drawing.Point(12, 92)
        Me.ebookAxAcroPDF.Name = "ebookAxAcroPDF"
        Me.ebookAxAcroPDF.OcxState = CType(resources.GetObject("ebookAxAcroPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ebookAxAcroPDF.Size = New System.Drawing.Size(831, 571)
        Me.ebookAxAcroPDF.TabIndex = 6
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.ToolStripMenuItem21, Me.VideosToolStripMenuItem, Me.EvaluationsToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(1300, 24)
        Me.MenuStrip1.TabIndex = 7
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
        Me.ToolStripMenuItem21.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem22, Me.ToolStripMenuItem27, Me.ToolStripMenuItem32, Me.ToolStripMenuItem37, Me.ToolStripMenuItem42})
        Me.ToolStripMenuItem21.Name = "ToolStripMenuItem21"
        Me.ToolStripMenuItem21.Size = New System.Drawing.Size(54, 20)
        Me.ToolStripMenuItem21.Text = "Videos"
        '
        'ToolStripMenuItem22
        '
        Me.ToolStripMenuItem22.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem23, Me.ToolStripMenuItem24, Me.ToolStripMenuItem25, Me.ToolStripMenuItem26})
        Me.ToolStripMenuItem22.Name = "ToolStripMenuItem22"
        Me.ToolStripMenuItem22.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem22.Text = "Mathematics"
        '
        'ToolStripMenuItem23
        '
        Me.ToolStripMenuItem23.Name = "ToolStripMenuItem23"
        Me.ToolStripMenuItem23.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem23.Text = "Form 1"
        '
        'ToolStripMenuItem24
        '
        Me.ToolStripMenuItem24.Name = "ToolStripMenuItem24"
        Me.ToolStripMenuItem24.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem24.Text = "Form 2"
        '
        'ToolStripMenuItem25
        '
        Me.ToolStripMenuItem25.Name = "ToolStripMenuItem25"
        Me.ToolStripMenuItem25.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem25.Text = "Form 3"
        '
        'ToolStripMenuItem26
        '
        Me.ToolStripMenuItem26.Name = "ToolStripMenuItem26"
        Me.ToolStripMenuItem26.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem26.Text = "Form 4"
        '
        'ToolStripMenuItem27
        '
        Me.ToolStripMenuItem27.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem28, Me.ToolStripMenuItem29, Me.ToolStripMenuItem30, Me.ToolStripMenuItem31})
        Me.ToolStripMenuItem27.Name = "ToolStripMenuItem27"
        Me.ToolStripMenuItem27.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem27.Text = "English"
        '
        'ToolStripMenuItem28
        '
        Me.ToolStripMenuItem28.Name = "ToolStripMenuItem28"
        Me.ToolStripMenuItem28.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem28.Text = "Form 1"
        '
        'ToolStripMenuItem29
        '
        Me.ToolStripMenuItem29.Name = "ToolStripMenuItem29"
        Me.ToolStripMenuItem29.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem29.Text = "Form 2"
        '
        'ToolStripMenuItem30
        '
        Me.ToolStripMenuItem30.Name = "ToolStripMenuItem30"
        Me.ToolStripMenuItem30.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem30.Text = "Form 3"
        '
        'ToolStripMenuItem31
        '
        Me.ToolStripMenuItem31.Name = "ToolStripMenuItem31"
        Me.ToolStripMenuItem31.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem31.Text = "Form 4"
        '
        'ToolStripMenuItem32
        '
        Me.ToolStripMenuItem32.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem33, Me.ToolStripMenuItem34, Me.ToolStripMenuItem35, Me.ToolStripMenuItem36})
        Me.ToolStripMenuItem32.Name = "ToolStripMenuItem32"
        Me.ToolStripMenuItem32.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem32.Text = "Biology"
        '
        'ToolStripMenuItem33
        '
        Me.ToolStripMenuItem33.Name = "ToolStripMenuItem33"
        Me.ToolStripMenuItem33.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem33.Text = "Form 1"
        '
        'ToolStripMenuItem34
        '
        Me.ToolStripMenuItem34.Name = "ToolStripMenuItem34"
        Me.ToolStripMenuItem34.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem34.Text = "Form 2"
        '
        'ToolStripMenuItem35
        '
        Me.ToolStripMenuItem35.Name = "ToolStripMenuItem35"
        Me.ToolStripMenuItem35.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem35.Text = "Form 3"
        '
        'ToolStripMenuItem36
        '
        Me.ToolStripMenuItem36.Name = "ToolStripMenuItem36"
        Me.ToolStripMenuItem36.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem36.Text = "Form 4"
        '
        'ToolStripMenuItem37
        '
        Me.ToolStripMenuItem37.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem38, Me.ToolStripMenuItem39, Me.ToolStripMenuItem40, Me.ToolStripMenuItem41})
        Me.ToolStripMenuItem37.Name = "ToolStripMenuItem37"
        Me.ToolStripMenuItem37.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem37.Text = "Physics"
        '
        'ToolStripMenuItem38
        '
        Me.ToolStripMenuItem38.Name = "ToolStripMenuItem38"
        Me.ToolStripMenuItem38.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem38.Text = "Form 1"
        '
        'ToolStripMenuItem39
        '
        Me.ToolStripMenuItem39.Name = "ToolStripMenuItem39"
        Me.ToolStripMenuItem39.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem39.Text = "Form 2"
        '
        'ToolStripMenuItem40
        '
        Me.ToolStripMenuItem40.Name = "ToolStripMenuItem40"
        Me.ToolStripMenuItem40.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem40.Text = "Form 3"
        '
        'ToolStripMenuItem41
        '
        Me.ToolStripMenuItem41.Name = "ToolStripMenuItem41"
        Me.ToolStripMenuItem41.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem41.Text = "Form 4"
        '
        'ToolStripMenuItem42
        '
        Me.ToolStripMenuItem42.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem43, Me.ToolStripMenuItem44, Me.ToolStripMenuItem45, Me.ToolStripMenuItem46})
        Me.ToolStripMenuItem42.Name = "ToolStripMenuItem42"
        Me.ToolStripMenuItem42.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem42.Text = "Chemistry"
        '
        'ToolStripMenuItem43
        '
        Me.ToolStripMenuItem43.Name = "ToolStripMenuItem43"
        Me.ToolStripMenuItem43.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem43.Text = "Form 1"
        '
        'ToolStripMenuItem44
        '
        Me.ToolStripMenuItem44.Name = "ToolStripMenuItem44"
        Me.ToolStripMenuItem44.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem44.Text = "Form 2"
        '
        'ToolStripMenuItem45
        '
        Me.ToolStripMenuItem45.Name = "ToolStripMenuItem45"
        Me.ToolStripMenuItem45.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem45.Text = "Form 3"
        '
        'ToolStripMenuItem46
        '
        Me.ToolStripMenuItem46.Name = "ToolStripMenuItem46"
        Me.ToolStripMenuItem46.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem46.Text = "Form 4"
        '
        'VideosToolStripMenuItem
        '
        Me.VideosToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.MathematicsToolStripMenuItem, Me.ToolStripMenuItem16, Me.ToolStripMenuItem6, Me.ToolStripMenuItem11, Me.ToolStripMenuItem1})
        Me.VideosToolStripMenuItem.Name = "VideosToolStripMenuItem"
        Me.VideosToolStripMenuItem.Size = New System.Drawing.Size(57, 20)
        Me.VideosToolStripMenuItem.Text = "Ebooks"
        '
        'MathematicsToolStripMenuItem
        '
        Me.MathematicsToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Form1ToolStripMenuItem1, Me.Form2ToolStripMenuItem1, Me.Form3ToolStripMenuItem1, Me.Form4ToolStripMenuItem1})
        Me.MathematicsToolStripMenuItem.Name = "MathematicsToolStripMenuItem"
        Me.MathematicsToolStripMenuItem.Size = New System.Drawing.Size(143, 22)
        Me.MathematicsToolStripMenuItem.Text = "Mathematics"
        '
        'Form1ToolStripMenuItem1
        '
        Me.Form1ToolStripMenuItem1.Name = "Form1ToolStripMenuItem1"
        Me.Form1ToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.Form1ToolStripMenuItem1.Text = "Form 1"
        '
        'Form2ToolStripMenuItem1
        '
        Me.Form2ToolStripMenuItem1.Name = "Form2ToolStripMenuItem1"
        Me.Form2ToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.Form2ToolStripMenuItem1.Text = "Form 2"
        '
        'Form3ToolStripMenuItem1
        '
        Me.Form3ToolStripMenuItem1.Name = "Form3ToolStripMenuItem1"
        Me.Form3ToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.Form3ToolStripMenuItem1.Text = "Form 3"
        '
        'Form4ToolStripMenuItem1
        '
        Me.Form4ToolStripMenuItem1.Name = "Form4ToolStripMenuItem1"
        Me.Form4ToolStripMenuItem1.Size = New System.Drawing.Size(111, 22)
        Me.Form4ToolStripMenuItem1.Text = "Form 4"
        '
        'ToolStripMenuItem16
        '
        Me.ToolStripMenuItem16.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem17, Me.ToolStripMenuItem18, Me.ToolStripMenuItem19, Me.ToolStripMenuItem20})
        Me.ToolStripMenuItem16.Name = "ToolStripMenuItem16"
        Me.ToolStripMenuItem16.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem16.Text = "English"
        '
        'ToolStripMenuItem17
        '
        Me.ToolStripMenuItem17.Name = "ToolStripMenuItem17"
        Me.ToolStripMenuItem17.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem17.Text = "Form 1"
        '
        'ToolStripMenuItem18
        '
        Me.ToolStripMenuItem18.Name = "ToolStripMenuItem18"
        Me.ToolStripMenuItem18.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem18.Text = "Form 2"
        '
        'ToolStripMenuItem19
        '
        Me.ToolStripMenuItem19.Name = "ToolStripMenuItem19"
        Me.ToolStripMenuItem19.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem19.Text = "Form 3"
        '
        'ToolStripMenuItem20
        '
        Me.ToolStripMenuItem20.Name = "ToolStripMenuItem20"
        Me.ToolStripMenuItem20.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem20.Text = "Form 4"
        '
        'ToolStripMenuItem6
        '
        Me.ToolStripMenuItem6.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem7, Me.ToolStripMenuItem8, Me.ToolStripMenuItem9, Me.ToolStripMenuItem10})
        Me.ToolStripMenuItem6.Name = "ToolStripMenuItem6"
        Me.ToolStripMenuItem6.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem6.Text = "Biology"
        '
        'ToolStripMenuItem7
        '
        Me.ToolStripMenuItem7.Name = "ToolStripMenuItem7"
        Me.ToolStripMenuItem7.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem7.Text = "Form 1"
        '
        'ToolStripMenuItem8
        '
        Me.ToolStripMenuItem8.Name = "ToolStripMenuItem8"
        Me.ToolStripMenuItem8.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem8.Text = "Form 2"
        '
        'ToolStripMenuItem9
        '
        Me.ToolStripMenuItem9.Name = "ToolStripMenuItem9"
        Me.ToolStripMenuItem9.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem9.Text = "Form 3"
        '
        'ToolStripMenuItem10
        '
        Me.ToolStripMenuItem10.Name = "ToolStripMenuItem10"
        Me.ToolStripMenuItem10.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem10.Text = "Form 4"
        '
        'ToolStripMenuItem11
        '
        Me.ToolStripMenuItem11.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem12, Me.ToolStripMenuItem13, Me.ToolStripMenuItem14, Me.ToolStripMenuItem15})
        Me.ToolStripMenuItem11.Name = "ToolStripMenuItem11"
        Me.ToolStripMenuItem11.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem11.Text = "Physics"
        '
        'ToolStripMenuItem12
        '
        Me.ToolStripMenuItem12.Name = "ToolStripMenuItem12"
        Me.ToolStripMenuItem12.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem12.Text = "Form 1"
        '
        'ToolStripMenuItem13
        '
        Me.ToolStripMenuItem13.Name = "ToolStripMenuItem13"
        Me.ToolStripMenuItem13.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem13.Text = "Form 2"
        '
        'ToolStripMenuItem14
        '
        Me.ToolStripMenuItem14.Name = "ToolStripMenuItem14"
        Me.ToolStripMenuItem14.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem14.Text = "Form 3"
        '
        'ToolStripMenuItem15
        '
        Me.ToolStripMenuItem15.Name = "ToolStripMenuItem15"
        Me.ToolStripMenuItem15.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem15.Text = "Form 4"
        '
        'ToolStripMenuItem1
        '
        Me.ToolStripMenuItem1.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripMenuItem2, Me.ToolStripMenuItem3, Me.ToolStripMenuItem4, Me.ToolStripMenuItem5})
        Me.ToolStripMenuItem1.Name = "ToolStripMenuItem1"
        Me.ToolStripMenuItem1.Size = New System.Drawing.Size(143, 22)
        Me.ToolStripMenuItem1.Text = "Chemistry"
        '
        'ToolStripMenuItem2
        '
        Me.ToolStripMenuItem2.Name = "ToolStripMenuItem2"
        Me.ToolStripMenuItem2.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem2.Text = "Form 1"
        '
        'ToolStripMenuItem3
        '
        Me.ToolStripMenuItem3.Name = "ToolStripMenuItem3"
        Me.ToolStripMenuItem3.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem3.Text = "Form 2"
        '
        'ToolStripMenuItem4
        '
        Me.ToolStripMenuItem4.Name = "ToolStripMenuItem4"
        Me.ToolStripMenuItem4.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem4.Text = "Form 3"
        '
        'ToolStripMenuItem5
        '
        Me.ToolStripMenuItem5.Name = "ToolStripMenuItem5"
        Me.ToolStripMenuItem5.Size = New System.Drawing.Size(111, 22)
        Me.ToolStripMenuItem5.Text = "Form 4"
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
        'ebookViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1300, 675)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Controls.Add(Me.ebookAxAcroPDF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ebookLabel)
        Me.Controls.Add(Me.exitMetroButton)
        Me.Controls.Add(Me.playMetroButton)
        Me.Controls.Add(Me.ebookPlayListBox)
        Me.Name = "ebookViewer"
        Me.Text = "Ebook Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ebookAxAcroPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ebookPlayListBox As ListBox
    Friend WithEvents playMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents exitMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents ebookLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ebookAxAcroPDF As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ProfileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LogOutToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ExitToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem21 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem22 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem23 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem24 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem25 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem26 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem27 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem28 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem29 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem30 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem31 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem32 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem33 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem34 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem35 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem36 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem37 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem38 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem39 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem40 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem41 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem42 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem43 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem44 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem45 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem46 As ToolStripMenuItem
    Friend WithEvents VideosToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents MathematicsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents Form1ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Form2ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Form3ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents Form4ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem16 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem17 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem18 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem19 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem20 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem6 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem7 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem8 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem9 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem10 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem11 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem12 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem13 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem14 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem15 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem1 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem2 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem3 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem4 As ToolStripMenuItem
    Friend WithEvents ToolStripMenuItem5 As ToolStripMenuItem
    Friend WithEvents EvaluationsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents AttemptToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ResultsToolStripMenuItem As ToolStripMenuItem
End Class
