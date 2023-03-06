Imports System.Runtime.CompilerServices

Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        dormListBox.Items.Add("Allen Hall - 2,500.00")
        dormListBox.Items.Add("Pike Hall - 2,200.00")
        dormListBox.Items.Add("Farthing Hall - 2,100.00")
        dormListBox.Items.Add("UniversitySuites Hall - 2,800.00")
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Me.Close()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        dormLabel.Text = String.Empty
        mealPlanLabel.Text = String.Empty
        totalLabel.Text = String.Empty
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Select Case dormListBox.SelectedIndex
            Case -1
                MessageBox.Show("Select A Dormitory Please!")
        End Select

        Select Case dormListBox.SelectedIndex
            Case 0
                dormLabel.Text = Module1.Allen_Hall.ToString("c2")
            Case 1
                dormLabel.Text = Module1.Pike_Hall.ToString("c2")
            Case 2
                dormLabel.Text = Module1.Farthing_Hall.ToString("c2")
            Case 3
                dormLabel.Text = Module1.UniversitySuites.ToString("c2")
        End Select

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form2.Show()
    End Sub
End Class
