Imports System.Drawing.Text

Public Class Form1
    Dim x, y As Double



    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        x = Double.Parse(TextBox1.Text)
        y = Double.Parse(TextBox2.Text)
        If RadioButton1.Checked = True Then
            TextBox3.Text = (x + y).ToString
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = (x - y).ToString
        End If
        If RadioButton5.Checked = True Then
            TextBox3.Text = (x * y).ToString
        End If
        If RadioButton4.Checked = True Then
            TextBox3.Text = (x / y).ToString
        End If

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As EventArgs) Handles Button2.Click
        Me.Hide()
        Form2.Show()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

    End Sub
End Class
