<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
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
        Label1 = New Label()
        Label2 = New Label()
        Label3 = New Label()
        TextBox1 = New TextBox()
        TextBox2 = New TextBox()
        TextBox3 = New TextBox()
        GroupBox1 = New GroupBox()
        RadioButton3 = New RadioButton()
        RadioButton2 = New RadioButton()
        RadioButton4 = New RadioButton()
        RadioButton1 = New RadioButton()
        Button1 = New Button()
        Button2 = New Button()
        GroupBox1.SuspendLayout()
        SuspendLayout()
        ' 
        ' Label1
        ' 
        Label1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label1.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label1.ForeColor = SystemColors.ActiveCaptionText
        Label1.Location = New Point(626, 93)
        Label1.Name = "Label1"
        Label1.Size = New Size(144, 25)
        Label1.TabIndex = 0
        Label1.Text = "ادخل العدد الاول"
        ' 
        ' Label2
        ' 
        Label2.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label2.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label2.ForeColor = SystemColors.ActiveCaptionText
        Label2.Location = New Point(626, 164)
        Label2.Name = "Label2"
        Label2.Size = New Size(144, 25)
        Label2.TabIndex = 1
        Label2.Text = "ادخل العدد الثاتي"
        ' 
        ' Label3
        ' 
        Label3.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        Label3.Font = New Font("Segoe UI Semibold", 10.2F, FontStyle.Bold)
        Label3.ForeColor = SystemColors.ActiveCaptionText
        Label3.Location = New Point(626, 232)
        Label3.Name = "Label3"
        Label3.Size = New Size(144, 25)
        Label3.TabIndex = 2
        Label3.Text = "     النتيجة"
        ' 
        ' TextBox1
        ' 
        TextBox1.Location = New Point(537, 93)
        TextBox1.Name = "TextBox1"
        TextBox1.Size = New Size(83, 27)
        TextBox1.TabIndex = 3
        ' 
        ' TextBox2
        ' 
        TextBox2.Location = New Point(537, 164)
        TextBox2.Name = "TextBox2"
        TextBox2.Size = New Size(83, 27)
        TextBox2.TabIndex = 4
        ' 
        ' TextBox3
        ' 
        TextBox3.Location = New Point(537, 230)
        TextBox3.Name = "TextBox3"
        TextBox3.Size = New Size(83, 27)
        TextBox3.TabIndex = 5
        ' 
        ' GroupBox1
        ' 
        GroupBox1.BackColor = Color.FromArgb(CByte(192), CByte(192), CByte(255))
        GroupBox1.Controls.Add(RadioButton3)
        GroupBox1.Controls.Add(RadioButton2)
        GroupBox1.Controls.Add(RadioButton4)
        GroupBox1.Controls.Add(RadioButton1)
        GroupBox1.Location = New Point(75, 56)
        GroupBox1.Name = "GroupBox1"
        GroupBox1.Size = New Size(250, 296)
        GroupBox1.TabIndex = 6
        GroupBox1.TabStop = False
        GroupBox1.Text = "العمليات الحسابية"
        ' 
        ' RadioButton3
        ' 
        RadioButton3.AutoSize = True
        RadioButton3.Location = New Point(69, 49)
        RadioButton3.Name = "RadioButton3"
        RadioButton3.Size = New Size(146, 24)
        RadioButton3.TabIndex = 9
        RadioButton3.TabStop = True
        RadioButton3.Text = "(%) باقي البقسمة "
        RadioButton3.UseVisualStyleBackColor = True
        ' 
        ' RadioButton2
        ' 
        RadioButton2.AutoSize = True
        RadioButton2.Location = New Point(69, 108)
        RadioButton2.Name = "RadioButton2"
        RadioButton2.Size = New Size(125, 24)
        RadioButton2.TabIndex = 8
        RadioButton2.TabStop = True
        RadioButton2.Text = "(^) الرفع لقوى "
        RadioButton2.UseVisualStyleBackColor = True
        ' 
        ' RadioButton4
        ' 
        RadioButton4.AutoSize = True
        RadioButton4.Location = New Point(69, 223)
        RadioButton4.Name = "RadioButton4"
        RadioButton4.Size = New Size(125, 24)
        RadioButton4.TabIndex = 10
        RadioButton4.TabStop = True
        RadioButton4.Text = "القيمة المطلقة"
        RadioButton4.UseVisualStyleBackColor = True
        ' 
        ' RadioButton1
        ' 
        RadioButton1.AutoSize = True
        RadioButton1.Location = New Point(69, 167)
        RadioButton1.Name = "RadioButton1"
        RadioButton1.Size = New Size(122, 24)
        RadioButton1.TabIndex = 7
        RadioButton1.TabStop = True
        RadioButton1.Text = "الجذر التربيعي "
        RadioButton1.UseVisualStyleBackColor = True
        ' 
        ' Button1
        ' 
        Button1.BackColor = SystemColors.Highlight
        Button1.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button1.ForeColor = SystemColors.ActiveCaptionText
        Button1.Location = New Point(626, 351)
        Button1.Name = "Button1"
        Button1.Size = New Size(118, 50)
        Button1.TabIndex = 11
        Button1.Text = "تنفيذ العملية "
        Button1.UseVisualStyleBackColor = False
        ' 
        ' Button2
        ' 
        Button2.BackColor = SystemColors.Highlight
        Button2.Font = New Font("Segoe UI", 9F, FontStyle.Bold)
        Button2.ForeColor = SystemColors.ActiveCaptionText
        Button2.Location = New Point(436, 351)
        Button2.Name = "Button2"
        Button2.Size = New Size(135, 51)
        Button2.TabIndex = 12
        Button2.Text = "الة حاسبة بسيطة"
        Button2.UseVisualStyleBackColor = False
        ' 
        ' Form2
        ' 
        AutoScaleDimensions = New SizeF(8F, 20F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.DarkGray
        ClientSize = New Size(800, 450)
        Controls.Add(Button2)
        Controls.Add(Button1)
        Controls.Add(GroupBox1)
        Controls.Add(TextBox3)
        Controls.Add(TextBox2)
        Controls.Add(TextBox1)
        Controls.Add(Label3)
        Controls.Add(Label2)
        Controls.Add(Label1)
        ForeColor = SystemColors.ActiveCaptionText
        Name = "Form2"
        Text = "الة حاسبة"
        GroupBox1.ResumeLayout(False)
        GroupBox1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents RadioButton1 As RadioButton
    Friend WithEvents RadioButton2 As RadioButton
    Friend WithEvents RadioButton3 As RadioButton
    Friend WithEvents RadioButton4 As RadioButton
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
End Class
