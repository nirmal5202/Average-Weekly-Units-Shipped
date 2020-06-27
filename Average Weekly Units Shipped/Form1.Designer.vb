<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAverageWeeklyUnitsShipped
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtUnits = New System.Windows.Forms.TextBox()
        Me.lblDay = New System.Windows.Forms.Label()
        Me.lblAnswer = New System.Windows.Forms.Label()
        Me.txtGiantBox = New System.Windows.Forms.TextBox()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.SuspendLayout
        '
        'Label1
        '
        Me.Label1.Location = New System.Drawing.Point(70, 38)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(105, 46)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Units: "
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'txtUnits
        '
        Me.txtUnits.Location = New System.Drawing.Point(260, 46)
        Me.txtUnits.Name = "txtUnits"
        Me.txtUnits.Size = New System.Drawing.Size(105, 29)
        Me.txtUnits.TabIndex = 1
        Me.txtUnits.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'lblDay
        '
        Me.lblDay.Location = New System.Drawing.Point(442, 38)
        Me.lblDay.Name = "lblDay"
        Me.lblDay.Size = New System.Drawing.Size(105, 46)
        Me.lblDay.TabIndex = 2
        Me.lblDay.Text = "Day 1"
        Me.lblDay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblAnswer
        '
        Me.lblAnswer.BackColor = System.Drawing.Color.White
        Me.lblAnswer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAnswer.ForeColor = System.Drawing.Color.Black
        Me.lblAnswer.Location = New System.Drawing.Point(173, 448)
        Me.lblAnswer.Name = "lblAnswer"
        Me.lblAnswer.Size = New System.Drawing.Size(310, 45)
        Me.lblAnswer.TabIndex = 4
        '
        'txtGiantBox
        '
        Me.txtGiantBox.BackColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtGiantBox.ForeColor = System.Drawing.Color.White
        Me.txtGiantBox.Location = New System.Drawing.Point(138, 124)
        Me.txtGiantBox.Multiline = True
        Me.txtGiantBox.Name = "txtGiantBox"
        Me.txtGiantBox.ReadOnly = true
        Me.txtGiantBox.Size = New System.Drawing.Size(376, 268)
        Me.txtGiantBox.TabIndex = 3
        '
        'btnEnter
        '
        Me.btnEnter.BackColor = System.Drawing.Color.Black
        Me.btnEnter.Location = New System.Drawing.Point(90, 536)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(126, 63)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.btnEnter.UseVisualStyleBackColor = false
        '
        'btnReset
        '
        Me.btnReset.BackColor = System.Drawing.Color.Black
        Me.btnReset.Location = New System.Drawing.Point(271, 536)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(126, 63)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.btnReset.UseVisualStyleBackColor = false
        '
        'btnExit
        '
        Me.btnExit.BackColor = System.Drawing.Color.Black
        Me.btnExit.Location = New System.Drawing.Point(447, 536)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(126, 63)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.btnExit.UseVisualStyleBackColor = false
        '
        'frmAverageWeeklyUnitsShipped
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11!, 24!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32,Byte),Integer), CType(CType(32,Byte),Integer), CType(CType(32,Byte),Integer))
        Me.ClientSize = New System.Drawing.Size(655, 655)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.Controls.Add(Me.txtGiantBox)
        Me.Controls.Add(Me.lblAnswer)
        Me.Controls.Add(Me.lblDay)
        Me.Controls.Add(Me.txtUnits)
        Me.Controls.Add(Me.Label1)
        Me.ForeColor = System.Drawing.Color.White
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.MaximizeBox = false
        Me.MinimizeBox = false
        Me.Name = "frmAverageWeeklyUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Weekly Units Shipped"
        Me.ResumeLayout(false)
        Me.PerformLayout

End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents txtUnits As TextBox
    Friend WithEvents lblDay As Label
    Friend WithEvents lblAnswer As Label
    Friend WithEvents txtGiantBox As TextBox
    Friend WithEvents btnEnter As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnExit As Button


End Class
