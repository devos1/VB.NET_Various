<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.gbChangeText = New System.Windows.Forms.GroupBox()
        Me.lblTextChange = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn2 = New System.Windows.Forms.Button()
        Me.btn1 = New System.Windows.Forms.Button()
        Me.gbOpenForm = New System.Windows.Forms.GroupBox()
        Me.btnClose = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnOpen = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnQuestion = New System.Windows.Forms.Button()
        Me.btnExcla = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnInfo = New System.Windows.Forms.Button()
        Me.btnCritical = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btnTab = New System.Windows.Forms.Button()
        Me.btnStrip = New System.Windows.Forms.Button()
        Me.btnButton = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbChangeText.SuspendLayout()
        Me.gbOpenForm.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'gbChangeText
        '
        Me.gbChangeText.Controls.Add(Me.lblTextChange)
        Me.gbChangeText.Controls.Add(Me.Label1)
        Me.gbChangeText.Controls.Add(Me.btn2)
        Me.gbChangeText.Controls.Add(Me.btn1)
        Me.gbChangeText.Location = New System.Drawing.Point(13, 13)
        Me.gbChangeText.Name = "gbChangeText"
        Me.gbChangeText.Size = New System.Drawing.Size(139, 88)
        Me.gbChangeText.TabIndex = 0
        Me.gbChangeText.TabStop = False
        Me.gbChangeText.Text = "Changer texte"
        '
        'lblTextChange
        '
        Me.lblTextChange.Location = New System.Drawing.Point(6, 56)
        Me.lblTextChange.Name = "lblTextChange"
        Me.lblTextChange.Size = New System.Drawing.Size(126, 17)
        Me.lblTextChange.TabIndex = 3
        Me.lblTextChange.Text = "..."
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(3, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(0, 13)
        Me.Label1.TabIndex = 2
        '
        'btn2
        '
        Me.btn2.Location = New System.Drawing.Point(72, 19)
        Me.btn2.Name = "btn2"
        Me.btn2.Size = New System.Drawing.Size(60, 34)
        Me.btn2.TabIndex = 1
        Me.btn2.Text = "Bouton 2"
        Me.btn2.UseVisualStyleBackColor = True
        '
        'btn1
        '
        Me.btn1.Location = New System.Drawing.Point(6, 19)
        Me.btn1.Name = "btn1"
        Me.btn1.Size = New System.Drawing.Size(60, 34)
        Me.btn1.TabIndex = 0
        Me.btn1.Text = "Bouton 1"
        Me.btn1.UseVisualStyleBackColor = True
        '
        'gbOpenForm
        '
        Me.gbOpenForm.Controls.Add(Me.btnClose)
        Me.gbOpenForm.Controls.Add(Me.Label3)
        Me.gbOpenForm.Controls.Add(Me.btnOpen)
        Me.gbOpenForm.Location = New System.Drawing.Point(13, 107)
        Me.gbOpenForm.Name = "gbOpenForm"
        Me.gbOpenForm.Size = New System.Drawing.Size(139, 63)
        Me.gbOpenForm.TabIndex = 1
        Me.gbOpenForm.TabStop = False
        Me.gbOpenForm.Text = "Ouvrir formulaire"
        '
        'btnClose
        '
        Me.btnClose.Location = New System.Drawing.Point(72, 19)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(60, 34)
        Me.btnClose.TabIndex = 3
        Me.btnClose.Text = "Fermer"
        Me.btnClose.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(3, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(0, 13)
        Me.Label3.TabIndex = 2
        '
        'btnOpen
        '
        Me.btnOpen.Location = New System.Drawing.Point(6, 19)
        Me.btnOpen.Name = "btnOpen"
        Me.btnOpen.Size = New System.Drawing.Size(60, 34)
        Me.btnOpen.TabIndex = 0
        Me.btnOpen.Text = "Ouvrir"
        Me.btnOpen.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnQuestion)
        Me.GroupBox1.Controls.Add(Me.btnExcla)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.btnInfo)
        Me.GroupBox1.Controls.Add(Me.btnCritical)
        Me.GroupBox1.Location = New System.Drawing.Point(172, 13)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 88)
        Me.GroupBox1.TabIndex = 4
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Pop-up"
        '
        'btnQuestion
        '
        Me.btnQuestion.Location = New System.Drawing.Point(279, 19)
        Me.btnQuestion.Name = "btnQuestion"
        Me.btnQuestion.Size = New System.Drawing.Size(85, 34)
        Me.btnQuestion.TabIndex = 4
        Me.btnQuestion.Text = "Question"
        Me.btnQuestion.UseVisualStyleBackColor = True
        '
        'btnExcla
        '
        Me.btnExcla.Location = New System.Drawing.Point(188, 19)
        Me.btnExcla.Name = "btnExcla"
        Me.btnExcla.Size = New System.Drawing.Size(85, 34)
        Me.btnExcla.TabIndex = 3
        Me.btnExcla.Text = "Exclamation"
        Me.btnExcla.UseVisualStyleBackColor = True
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(3, 16)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(0, 13)
        Me.Label4.TabIndex = 2
        '
        'btnInfo
        '
        Me.btnInfo.Location = New System.Drawing.Point(97, 19)
        Me.btnInfo.Name = "btnInfo"
        Me.btnInfo.Size = New System.Drawing.Size(85, 34)
        Me.btnInfo.TabIndex = 1
        Me.btnInfo.Text = "Information"
        Me.btnInfo.UseVisualStyleBackColor = True
        '
        'btnCritical
        '
        Me.btnCritical.Location = New System.Drawing.Point(6, 19)
        Me.btnCritical.Name = "btnCritical"
        Me.btnCritical.Size = New System.Drawing.Size(85, 34)
        Me.btnCritical.TabIndex = 0
        Me.btnCritical.Text = "Critical"
        Me.btnCritical.UseVisualStyleBackColor = True
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnButton)
        Me.GroupBox2.Controls.Add(Me.btnStrip)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.btnTab)
        Me.GroupBox2.Location = New System.Drawing.Point(172, 107)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(370, 63)
        Me.GroupBox2.TabIndex = 4
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Différents menus"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(3, 16)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 2
        '
        'btnTab
        '
        Me.btnTab.Location = New System.Drawing.Point(11, 19)
        Me.btnTab.Name = "btnTab"
        Me.btnTab.Size = New System.Drawing.Size(112, 34)
        Me.btnTab.TabIndex = 0
        Me.btnTab.Text = "Onglets"
        Me.btnTab.UseVisualStyleBackColor = True
        '
        'btnStrip
        '
        Me.btnStrip.Location = New System.Drawing.Point(129, 19)
        Me.btnStrip.Name = "btnStrip"
        Me.btnStrip.Size = New System.Drawing.Size(112, 34)
        Me.btnStrip.TabIndex = 3
        Me.btnStrip.Text = "Strip"
        Me.btnStrip.UseVisualStyleBackColor = True
        '
        'btnButton
        '
        Me.btnButton.Location = New System.Drawing.Point(247, 19)
        Me.btnButton.Name = "btnButton"
        Me.btnButton.Size = New System.Drawing.Size(112, 34)
        Me.btnButton.TabIndex = 4
        Me.btnButton.Text = "Boutons"
        Me.btnButton.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.Test_01.My.Resources.Resources._Exit
        Me.PictureBox1.Location = New System.Drawing.Point(551, 334)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(58, 45)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 5
        Me.PictureBox1.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(604, 381)
        Me.ControlBox = False
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbOpenForm)
        Me.Controls.Add(Me.gbChangeText)
        Me.Name = "Form1"
        Me.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.ShowIcon = False
        Me.Text = "Test 01"
        Me.gbChangeText.ResumeLayout(False)
        Me.gbChangeText.PerformLayout()
        Me.gbOpenForm.ResumeLayout(False)
        Me.gbOpenForm.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbChangeText As System.Windows.Forms.GroupBox
    Friend WithEvents lblTextChange As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn2 As System.Windows.Forms.Button
    Friend WithEvents btn1 As System.Windows.Forms.Button
    Friend WithEvents gbOpenForm As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnOpen As System.Windows.Forms.Button
    Friend WithEvents btnClose As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btnQuestion As System.Windows.Forms.Button
    Friend WithEvents btnExcla As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btnInfo As System.Windows.Forms.Button
    Friend WithEvents btnCritical As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnButton As System.Windows.Forms.Button
    Friend WithEvents btnStrip As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btnTab As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox

End Class
