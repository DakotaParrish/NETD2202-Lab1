<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAvgUnitsShipped
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
        Me.lblAverageUnitsDisplay = New System.Windows.Forms.Label()
        Me.txtInputDisplay = New System.Windows.Forms.TextBox()
        Me.lblDays = New System.Windows.Forms.Label()
        Me.txtInput = New System.Windows.Forms.TextBox()
        Me.lblUnits = New System.Windows.Forms.Label()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.btnReset = New System.Windows.Forms.Button()
        Me.btnEnter = New System.Windows.Forms.Button()
        Me.AverageUnitsShippedToolTip = New System.Windows.Forms.ToolTip(Me.components)
        Me.SuspendLayout()
        '
        'lblAverageUnitsDisplay
        '
        Me.lblAverageUnitsDisplay.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.lblAverageUnitsDisplay.Location = New System.Drawing.Point(46, 173)
        Me.lblAverageUnitsDisplay.Name = "lblAverageUnitsDisplay"
        Me.lblAverageUnitsDisplay.Size = New System.Drawing.Size(177, 23)
        Me.lblAverageUnitsDisplay.TabIndex = 4
        Me.lblAverageUnitsDisplay.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.lblAverageUnitsDisplay, "Displays the average units shipped per day once all 7 days have been entered")
        '
        'txtInputDisplay
        '
        Me.txtInputDisplay.Location = New System.Drawing.Point(46, 49)
        Me.txtInputDisplay.Multiline = True
        Me.txtInputDisplay.Name = "txtInputDisplay"
        Me.txtInputDisplay.ReadOnly = True
        Me.txtInputDisplay.Size = New System.Drawing.Size(174, 121)
        Me.txtInputDisplay.TabIndex = 3
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.txtInputDisplay, "Displays the units shipped for each day.")
        '
        'lblDays
        '
        Me.lblDays.Location = New System.Drawing.Point(165, 21)
        Me.lblDays.Name = "lblDays"
        Me.lblDays.Size = New System.Drawing.Size(80, 23)
        Me.lblDays.TabIndex = 2
        Me.lblDays.Text = "Day 1"
        '
        'txtInput
        '
        Me.txtInput.Location = New System.Drawing.Point(103, 22)
        Me.txtInput.Name = "txtInput"
        Me.txtInput.Size = New System.Drawing.Size(56, 20)
        Me.txtInput.TabIndex = 1
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.txtInput, "Type the units shipped for each day")
        '
        'lblUnits
        '
        Me.lblUnits.Location = New System.Drawing.Point(43, 21)
        Me.lblUnits.Name = "lblUnits"
        Me.lblUnits.Size = New System.Drawing.Size(64, 21)
        Me.lblUnits.TabIndex = 0
        Me.lblUnits.Text = "Units:"
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(176, 213)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(69, 28)
        Me.btnExit.TabIndex = 7
        Me.btnExit.Text = "E&xit"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnExit, "Closes the program")
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'btnReset
        '
        Me.btnReset.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btnReset.Location = New System.Drawing.Point(89, 213)
        Me.btnReset.Name = "btnReset"
        Me.btnReset.Size = New System.Drawing.Size(80, 28)
        Me.btnReset.TabIndex = 6
        Me.btnReset.Text = "&Reset"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnReset, "Clears all text boxes and the output label's text.")
        Me.btnReset.UseVisualStyleBackColor = True
        '
        'btnEnter
        '
        Me.btnEnter.Location = New System.Drawing.Point(12, 213)
        Me.btnEnter.Name = "btnEnter"
        Me.btnEnter.Size = New System.Drawing.Size(71, 28)
        Me.btnEnter.TabIndex = 5
        Me.btnEnter.Text = "&Enter"
        Me.AverageUnitsShippedToolTip.SetToolTip(Me.btnEnter, "Enters the units shipped into the ")
        Me.btnEnter.UseVisualStyleBackColor = True
        '
        'frmAvgUnitsShipped
        '
        Me.AcceptButton = Me.btnEnter
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.CancelButton = Me.btnReset
        Me.ClientSize = New System.Drawing.Size(294, 261)
        Me.Controls.Add(Me.lblAverageUnitsDisplay)
        Me.Controls.Add(Me.txtInputDisplay)
        Me.Controls.Add(Me.lblDays)
        Me.Controls.Add(Me.txtInput)
        Me.Controls.Add(Me.lblUnits)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnReset)
        Me.Controls.Add(Me.btnEnter)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(310, 300)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(310, 300)
        Me.Name = "frmAvgUnitsShipped"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Average Units Shipped"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblAverageUnitsDisplay As Label
    Friend WithEvents txtInputDisplay As TextBox
    Friend WithEvents lblDays As Label
    Friend WithEvents txtInput As TextBox
    Friend WithEvents lblUnits As Label
    Friend WithEvents btnExit As Button
    Friend WithEvents btnReset As Button
    Friend WithEvents btnEnter As Button
    Friend WithEvents AverageUnitsShippedToolTip As ToolTip
End Class
