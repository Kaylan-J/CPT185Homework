<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTechFair
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
        Me.lblPhrase = New System.Windows.Forms.Label()
        Me.lblDate = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.lblRoom = New System.Windows.Forms.Label()
        Me.btnFairDetails = New System.Windows.Forms.Button()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.picFairPicture = New System.Windows.Forms.PictureBox()
        Me.lblLocation = New System.Windows.Forms.Label()
        CType(Me.picFairPicture, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblHeading
        '
        Me.lblHeading.AutoSize = True
        Me.lblHeading.Font = New System.Drawing.Font("Tahoma", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblHeading.Location = New System.Drawing.Point(25, 31)
        Me.lblHeading.Name = "lblHeading"
        Me.lblHeading.Size = New System.Drawing.Size(209, 35)
        Me.lblHeading.TabIndex = 0
        Me.lblHeading.Text = "Tech Job Fair"
        '
        'lblPhrase
        '
        Me.lblPhrase.AutoSize = True
        Me.lblPhrase.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblPhrase.Location = New System.Drawing.Point(49, 75)
        Me.lblPhrase.Name = "lblPhrase"
        Me.lblPhrase.Size = New System.Drawing.Size(174, 18)
        Me.lblPhrase.TabIndex = 1
        Me.lblPhrase.Text = "All Students are Welcome"
        '
        'lblDate
        '
        Me.lblDate.AutoSize = True
        Me.lblDate.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblDate.Location = New System.Drawing.Point(76, 218)
        Me.lblDate.Name = "lblDate"
        Me.lblDate.Size = New System.Drawing.Size(91, 18)
        Me.lblDate.TabIndex = 2
        Me.lblDate.Text = "May 2, 2016"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(-41, 112)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 13)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Label4"
        '
        'lblRoom
        '
        Me.lblRoom.AutoSize = True
        Me.lblRoom.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblRoom.Location = New System.Drawing.Point(76, 306)
        Me.lblRoom.Name = "lblRoom"
        Me.lblRoom.Size = New System.Drawing.Size(75, 18)
        Me.lblRoom.TabIndex = 4
        Me.lblRoom.Text = "Room 101"
        '
        'btnFairDetails
        '
        Me.btnFairDetails.Location = New System.Drawing.Point(52, 154)
        Me.btnFairDetails.Name = "btnFairDetails"
        Me.btnFairDetails.Size = New System.Drawing.Size(151, 33)
        Me.btnFairDetails.TabIndex = 5
        Me.btnFairDetails.Text = "View Job Fair Details"
        Me.btnFairDetails.UseVisualStyleBackColor = True
        '
        'btnExit
        '
        Me.btnExit.Location = New System.Drawing.Point(52, 405)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(151, 33)
        Me.btnExit.TabIndex = 6
        Me.btnExit.Text = "Exit Window"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'picFairPicture
        '
        Me.picFairPicture.Location = New System.Drawing.Point(240, 12)
        Me.picFairPicture.Name = "picFairPicture"
        Me.picFairPicture.Size = New System.Drawing.Size(189, 438)
        Me.picFairPicture.TabIndex = 7
        Me.picFairPicture.TabStop = False
        '
        'lblLocation
        '
        Me.lblLocation.AutoSize = True
        Me.lblLocation.Font = New System.Drawing.Font("Tahoma", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblLocation.Location = New System.Drawing.Point(49, 266)
        Me.lblLocation.Name = "lblLocation"
        Me.lblLocation.Size = New System.Drawing.Size(154, 18)
        Me.lblLocation.TabIndex = 8
        Me.lblLocation.Text = "Located in Lochlan Hall"
        '
        'frmTechFair
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(441, 480)
        Me.Controls.Add(Me.lblLocation)
        Me.Controls.Add(Me.picFairPicture)
        Me.Controls.Add(Me.btnExit)
        Me.Controls.Add(Me.btnFairDetails)
        Me.Controls.Add(Me.lblRoom)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.lblDate)
        Me.Controls.Add(Me.lblPhrase)
        Me.Controls.Add(Me.lblHeading)
        Me.Name = "frmTechFair"
        CType(Me.picFairPicture, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblHeading As Label
    Friend WithEvents lblPhrase As Label
    Friend WithEvents lblDate As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents lblRoom As Label
    Friend WithEvents btnFairDetails As Button
    Friend WithEvents btnExit As Button
    Friend WithEvents picFairPicture As PictureBox
    Friend WithEvents lblLocation As Label
End Class
