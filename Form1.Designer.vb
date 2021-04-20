<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnsubmit1 = New System.Windows.Forms.Button()
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.txtBox1 = New System.Windows.Forms.TextBox()
        Me.btnSubmit2 = New System.Windows.Forms.Button()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.btnSubmit3 = New System.Windows.Forms.Button()
        Me.lblText3 = New System.Windows.Forms.Label()
        Me.txtBox2 = New System.Windows.Forms.TextBox()
        Me.btnSubmit4 = New System.Windows.Forms.Button()
        Me.lblText4 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnsubmit1
        '
        Me.btnsubmit1.Location = New System.Drawing.Point(49, 72)
        Me.btnsubmit1.Name = "btnsubmit1"
        Me.btnsubmit1.Size = New System.Drawing.Size(112, 34)
        Me.btnsubmit1.TabIndex = 0
        Me.btnsubmit1.Text = "Button1"
        Me.btnsubmit1.UseVisualStyleBackColor = True
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Location = New System.Drawing.Point(289, 81)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(63, 25)
        Me.lblText1.TabIndex = 1
        Me.lblText1.Text = "Label1"
        '
        'txtBox1
        '
        Me.txtBox1.Location = New System.Drawing.Point(49, 186)
        Me.txtBox1.Name = "txtBox1"
        Me.txtBox1.Size = New System.Drawing.Size(150, 31)
        Me.txtBox1.TabIndex = 2
        '
        'btnSubmit2
        '
        Me.btnSubmit2.Location = New System.Drawing.Point(308, 186)
        Me.btnSubmit2.Name = "btnSubmit2"
        Me.btnSubmit2.Size = New System.Drawing.Size(112, 34)
        Me.btnSubmit2.TabIndex = 3
        Me.btnSubmit2.Text = "Button2"
        Me.btnSubmit2.UseVisualStyleBackColor = True
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Location = New System.Drawing.Point(571, 186)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(63, 25)
        Me.lblText2.TabIndex = 4
        Me.lblText2.Text = "Label2"
        '
        'btnSubmit3
        '
        Me.btnSubmit3.Location = New System.Drawing.Point(49, 286)
        Me.btnSubmit3.Name = "btnSubmit3"
        Me.btnSubmit3.Size = New System.Drawing.Size(112, 34)
        Me.btnSubmit3.TabIndex = 5
        Me.btnSubmit3.Text = "Button3"
        Me.btnSubmit3.UseVisualStyleBackColor = True
        '
        'lblText3
        '
        Me.lblText3.AutoSize = True
        Me.lblText3.Location = New System.Drawing.Point(289, 286)
        Me.lblText3.Name = "lblText3"
        Me.lblText3.Size = New System.Drawing.Size(63, 25)
        Me.lblText3.TabIndex = 6
        Me.lblText3.Text = "Label3"
        '
        'txtBox2
        '
        Me.txtBox2.Location = New System.Drawing.Point(49, 385)
        Me.txtBox2.Name = "txtBox2"
        Me.txtBox2.Size = New System.Drawing.Size(150, 31)
        Me.txtBox2.TabIndex = 7
        '
        'btnSubmit4
        '
        Me.btnSubmit4.Location = New System.Drawing.Point(356, 385)
        Me.btnSubmit4.Name = "btnSubmit4"
        Me.btnSubmit4.Size = New System.Drawing.Size(112, 34)
        Me.btnSubmit4.TabIndex = 8
        Me.btnSubmit4.Text = "Button4"
        Me.btnSubmit4.UseVisualStyleBackColor = True
        '
        'lblText4
        '
        Me.lblText4.AutoSize = True
        Me.lblText4.Location = New System.Drawing.Point(539, 385)
        Me.lblText4.Name = "lblText4"
        Me.lblText4.Size = New System.Drawing.Size(63, 25)
        Me.lblText4.TabIndex = 9
        Me.lblText4.Text = "Label4"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(10.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(913, 450)
        Me.Controls.Add(Me.lblText4)
        Me.Controls.Add(Me.btnSubmit4)
        Me.Controls.Add(Me.txtBox2)
        Me.Controls.Add(Me.lblText3)
        Me.Controls.Add(Me.btnSubmit3)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.btnSubmit2)
        Me.Controls.Add(Me.txtBox1)
        Me.Controls.Add(Me.lblText1)
        Me.Controls.Add(Me.btnsubmit1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnsubmit1 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents lblText2 As Label
    Friend WithEvents btnSubmit3 As Button
    Friend WithEvents lblText3 As Label
    Friend WithEvents txtBox2 As TextBox
    Friend WithEvents btnSubmit4 As Button
    Friend WithEvents lblText4 As Label
    Friend WithEvents lblText1 As Label
    Friend WithEvents btnSubmit2 As Button
    Friend WithEvents txtBox1 As TextBox
End Class
