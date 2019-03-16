<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class welcomeForm
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
        Me.exitMetroButton = New MetroFramework.Controls.MetroButton()
        Me.signInMetroTile = New MetroFramework.Controls.MetroTile()
        Me.mainPictureBox = New System.Windows.Forms.PictureBox()
        Me.welcomeLabel = New System.Windows.Forms.Label()
        CType(Me.mainPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'exitMetroButton
        '
        Me.exitMetroButton.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.exitMetroButton.Location = New System.Drawing.Point(1584, 700)
        Me.exitMetroButton.Margin = New System.Windows.Forms.Padding(4)
        Me.exitMetroButton.Name = "exitMetroButton"
        Me.exitMetroButton.Size = New System.Drawing.Size(100, 54)
        Me.exitMetroButton.TabIndex = 3
        Me.exitMetroButton.Text = "&Exit"
        Me.exitMetroButton.UseSelectable = True
        '
        'signInMetroTile
        '
        Me.signInMetroTile.ActiveControl = Nothing
        Me.signInMetroTile.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.signInMetroTile.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(153, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.signInMetroTile.Location = New System.Drawing.Point(1533, 158)
        Me.signInMetroTile.Margin = New System.Windows.Forms.Padding(4)
        Me.signInMetroTile.Name = "signInMetroTile"
        Me.signInMetroTile.Size = New System.Drawing.Size(186, 115)
        Me.signInMetroTile.Style = MetroFramework.MetroColorStyle.Purple
        Me.signInMetroTile.TabIndex = 12
        Me.signInMetroTile.Text = "SIGN IN"
        Me.signInMetroTile.TileTextFontWeight = MetroFramework.MetroTileTextWeight.Regular
        Me.signInMetroTile.UseCustomBackColor = True
        Me.signInMetroTile.UseSelectable = True
        '
        'mainPictureBox
        '
        Me.mainPictureBox.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.mainPictureBox.Location = New System.Drawing.Point(28, 158)
        Me.mainPictureBox.Margin = New System.Windows.Forms.Padding(4)
        Me.mainPictureBox.Name = "mainPictureBox"
        Me.mainPictureBox.Size = New System.Drawing.Size(1481, 630)
        Me.mainPictureBox.TabIndex = 13
        Me.mainPictureBox.TabStop = False
        '
        'welcomeLabel
        '
        Me.welcomeLabel.AutoSize = True
        Me.welcomeLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 36.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.welcomeLabel.Location = New System.Drawing.Point(413, 52)
        Me.welcomeLabel.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.welcomeLabel.Name = "welcomeLabel"
        Me.welcomeLabel.Size = New System.Drawing.Size(214, 69)
        Me.welcomeLabel.TabIndex = 14
        Me.welcomeLabel.Text = "Label1"
        '
        'welcomeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.ClientSize = New System.Drawing.Size(1732, 870)
        Me.Controls.Add(Me.welcomeLabel)
        Me.Controls.Add(Me.mainPictureBox)
        Me.Controls.Add(Me.signInMetroTile)
        Me.Controls.Add(Me.exitMetroButton)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "welcomeForm"
        Me.Text = "Dawati"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.mainPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents exitMetroButton As MetroFramework.Controls.MetroButton
    Friend WithEvents signInMetroTile As MetroFramework.Controls.MetroTile
    Friend WithEvents mainPictureBox As PictureBox
    Friend WithEvents welcomeLabel As Label
End Class
