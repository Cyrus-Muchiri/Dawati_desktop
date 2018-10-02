<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class questions
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
        Me.questionsFlowLayoutPanel = New System.Windows.Forms.FlowLayoutPanel()
        Me.SuspendLayout()
        '
        'questionsFlowLayoutPanel
        '
        Me.questionsFlowLayoutPanel.Location = New System.Drawing.Point(3, 2)
        Me.questionsFlowLayoutPanel.Name = "questionsFlowLayoutPanel"
        Me.questionsFlowLayoutPanel.Size = New System.Drawing.Size(1298, 572)
        Me.questionsFlowLayoutPanel.TabIndex = 0
        '
        'questions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1313, 635)
        Me.Controls.Add(Me.questionsFlowLayoutPanel)
        Me.Name = "questions"
        Me.Text = "questions"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents questionsFlowLayoutPanel As FlowLayoutPanel
End Class
