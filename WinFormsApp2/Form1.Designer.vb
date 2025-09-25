<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(disposing As Boolean)
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
        GroupBox1 = New GroupBox()
        RadioButton5 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton1 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        Button3 = New Button()
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = SystemColors.ActiveCaption
        GroupBox1.Controls.Add(RadioButton5)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(105, 79)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 307)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "العمليات الحسابية"
        ' 
        ' RadioButton5
        ' 
        RadioButton5.AutoSize = True
        RadioButton5.Font = New Font("Nirmala Text", 9F, FontStyle.Bold)
        RadioButton5.Location = New Point(60, 229)
        RadioButton5.Name = "RadioButton5"
        RadioButton5.Size = New Size(96, 24)
        RadioButton5.TabIndex = 4
        RadioButton5.TabStop = True
        RadioButton5.Text = "(*) الضرب"
        RadioButton5.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Font = New Font("Nirmala Text", 9F, FontStyle.Bold)
        RadioButton4.Location = New Point(60, 167)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(91, 24)
        RadioButton4.TabIndex = 3
        RadioButton4.Text = "(/) القسمة"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(605, -22)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(121, 24)
        RadioButton3.TabIndex = 2
        RadioButton3.TabStop = True
        RadioButton3.Text = "RadioButton3"
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Font = New Font("Nirmala Text", 9F, FontStyle.Bold)
        RadioButton2.Location = New Point(60, 108)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(88, 24)
        RadioButton2.TabIndex = 1
        RadioButton2.Text = "(-) الطرح"
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Font = New Font("Nirmala Text", 9F, FontStyle.Bold)
        RadioButton1.Location = New Point(60, 47)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(86, 24)
        RadioButton1.TabIndex = 0
        RadioButton1.TabStop = True
        RadioButton1.Text = "(+)الجمع"
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.Location = New Point(728, 334)
        Button1.Name = "Button1"
        Button1.Size = New Size(107, 62)
        Button1.TabIndex = 7
        Button1.Text = "تنفيذ العملة"
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Highlight
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.Location = New Point(560, 334)
        Button2.Name = "Button2"
        Button2.Size = New Size(114, 62)
        Button2.TabIndex = 8
        Button2.Text = "الة حاسبة متقدمة"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Button3
        ' 
        Button3.BackColor = SystemColors.Highlight
        Button3.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button3.Location = New Point(654, 419)
        Button3.Name = "Button3"
        Button3.Size = New Size(94, 47)
        Button3.TabIndex = 9
        Button3.Text = "الخروج"
        Button3.UseVisualStyleBackColor = False
        ' 
        ' Label1
        ' 
        Label1.BackColor = SystemColors.ActiveCaption
        Label1.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label1.Location = New Point(728, 81)
        Label1.Name = "Label1"
        Label1.Size = New Size(119, 32)
        Label1.TabIndex = 10
        Label1.Text = "ادخل العدد الاول "
        ' 
        ' Label2
        ' 
        Label2.BackColor = SystemColors.ActiveCaption
        Label2.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label2.Location = New Point(728, 140)
        Label2.Name = "Label2"
        Label2.Size = New Size(119, 32)
        Label2.TabIndex = 11
        Label2.Text = "ادخل العدد الثاني"
        ' 
        ' Label3
        ' 
        Label3.BackColor = SystemColors.ActiveCaption
        Label3.Font = New Font("Segoe UI Black", 9F, FontStyle.Bold)
        Label3.Location = New Point(728, 202)
        Label3.Name = "Label3"
        Label3.Size = New Size(119, 32)
        Label3.TabIndex = 12
        Label3.Text = "        النتيجة"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(630, 79)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(92, 27)
        TextBox1.TabIndex = 13
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(630, 138)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(92, 27)
        TextBox2.TabIndex = 14
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(630, 200)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(92, 27)
        TextBox3.TabIndex = 15
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = SystemColors.AppWorkspace
        ClientSize = New Size(885, 588)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        Controls.Add(Button3)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Name = "Form1"
        Text = "الة حاسبة"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Button3 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents RadioButton5 As RadioButton

End Class
