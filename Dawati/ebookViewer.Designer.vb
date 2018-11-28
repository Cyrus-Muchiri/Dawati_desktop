<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ebookViewer
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ebookViewer))
        Me.ebookPlayListBox = New System.Windows.Forms.ListBox()
        Me.playMetroButton = New MetroFramework.Controls.MetroButton()
        Me.exitMetroButton = New MetroFramework.Controls.MetroButton()
        Me.ebookLabel = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ebookAxAcroPDF = New AxAcroPDFLib.AxAcroPDF()
        Me.readsLabel = New System.Windows.Forms.Label()
        Me.readsCounterLabel = New System.Windows.Forms.Label()
        CType(Me.ebookAxAcroPDF, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ebookPlayListBox
        '
        Me.ebookPlayListBox.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.ebookPlayListBox.BackColor = System.Drawing.SystemColors.ControlLight
        Me.ebookPlayListBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ebookPlayListBox.FormattingEnabled = True
        Me.ebookPlayListBox.ItemHeight = 30
        Me.ebookPlayListBox.Location = New System.Drawing.Point(1351, 123)
        Me.ebookPlayListBox.Margin = New System.Windows.Forms.Padding(4)
        Me.ebookPlayListBox.Name = "ebookPlayListBox"
        Me.ebookPlayListBox.Size = New System.Drawing.Size(476, 334)
        Me.ebookPlayListBox.TabIndex = 1
        '
        'playMetroButton
        '
        Me.playMetroButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.playMetroButton.Highlight = True
        Me.playMetroButton.Location = New System.Drawing.Point(1690, 475)
        Me.playMetroButton.Margin = New System.Windows.Forms.Padding(4)
        Me.playMetroButton.Name = "playMetroButton"
        Me.playMetroButton.Size = New System.Drawing.Size(137, 54)
        Me.playMetroButton.TabIndex = 2
        Me.playMetroButton.Text = "View"
        Me.playMetroButton.UseSelectable = True
        '
        'exitMetroButton
        '
        Me.exitMetroButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitMetroButton.Location = New System.Drawing.Point(1677, 766)
        Me.exitMetroButton.Margin = New System.Windows.Forms.Padding(4)
        Me.exitMetroButton.Name = "exitMetroButton"
        Me.exitMetroButton.Size = New System.Drawing.Size(137, 50)
        Me.exitMetroButton.TabIndex = 3
        Me.exitMetroButton.Text = "Exit"
        Me.exitMetroButton.UseSelectable = True
        '
        'ebookLabel
        '
        Me.ebookLabel.AutoSize = True
        Me.ebookLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ebookLabel.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.ebookLabel.Location = New System.Drawing.Point(525, 34)
        Me.ebookLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.ebookLabel.Name = "ebookLabel"
        Me.ebookLabel.Size = New System.Drawing.Size(120, 39)
        Me.ebookLabel.TabIndex = 4
        Me.ebookLabel.Text = "Label1"
        '
        'Label1
        '
        Me.Label1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(161, Byte), Integer), CType(CType(154, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(1400, 42)
        Me.Label1.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(204, 31)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "Related Books"
        '
        'ebookAxAcroPDF
        '
        Me.ebookAxAcroPDF.Enabled = True
        Me.ebookAxAcroPDF.Location = New System.Drawing.Point(12, 92)
        Me.ebookAxAcroPDF.Margin = New System.Windows.Forms.Padding(4)
        Me.ebookAxAcroPDF.Name = "ebookAxAcroPDF"
        Me.ebookAxAcroPDF.OcxState = CType(resources.GetObject("ebookAxAcroPDF.OcxState"), System.Windows.Forms.AxHost.State)
        Me.ebookAxAcroPDF.Size = New System.Drawing.Size(998, 797)
        Me.ebookAxAcroPDF.TabIndex = 6
        '
        'readsLabel
        '
        Me.readsLabel.AutoSize = True
        Me.readsLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readsLabel.Location = New System.Drawing.Point(1432, 584)
        Me.readsLabel.Name = "readsLabel"
        Me.readsLabel.Size = New System.Drawing.Size(57, 20)
        Me.readsLabel.TabIndex = 7
        Me.readsLabel.Text = "Reads"
        '
        'readsCounterLabel
        '
        Me.readsCounterLabel.AutoSize = True
        Me.readsCounterLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.readsCounterLabel.Location = New System.Drawing.Point(1377, 584)
        Me.readsCounterLabel.Name = "readsCounterLabel"
        Me.readsCounterLabel.Size = New System.Drawing.Size(0, 20)
        Me.readsCounterLabel.TabIndex = 8
        '
        'ebookViewer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1831, 922)
        Me.ControlBox = False
        Me.Controls.Add(Me.readsCounterLabel)
        Me.Controls.Add(Me.readsLabel)
        Me.Controls.Add(Me.ebookAxAcroPDF)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.ebookLabel)
        Me.Controls.Add(Me.exitMetroButton)
        Me.Controls.Add(Me.playMetroButton)
        Me.Controls.Add(Me.ebookPlayListBox)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "ebookViewer"
        Me.Text = "Ebook Viewer"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.ebookAxAcroPDF, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents ebookPlayListBox As ListBox
    Friend WithEvents playMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents exitMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents ebookLabel As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents ebookAxAcroPDF As AxAcroPDFLib.AxAcroPDF
    Friend WithEvents readsLabel As Label
    Friend WithEvents readsCounterLabel As Label
End Class
