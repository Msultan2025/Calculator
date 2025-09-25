Imports System.Windows

Public Class Form2
    Public i, z As Double


    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        i = Double.Parse(TextBox1.Text)
        z = Double.Parse(TextBox2.Text)
        If RadioButton1.Checked = True Then
            TextBox3.Text = (i Mod z).ToString
        End If
        If RadioButton2.Checked = True Then
            TextBox3.Text = (i ^ z).ToString
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = System.Math.Sqrt(i).ToString
        End If
        If RadioButton3.Checked = True Then
            TextBox3.Text = System.Math.Abs(i).ToString
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Me.Hide()
        Form1.Show()
    End Sub
End Class
