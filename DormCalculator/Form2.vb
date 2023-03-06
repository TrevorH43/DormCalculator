Public Class Form2







    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        mealPlanListBox.Items.Add("7 Meals - 1,560.00")
        mealPlanListBox.Items.Add("14 Meals - 2,095.00")
        mealPlanListBox.Items.Add("Unlimited Meals - 2,500.00")
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim MealPlans As Integer

        Select Case mealPlanListBox.SelectedIndex
            Case -1
                MessageBox.Show("Select A Meal Plan!")
        End Select
        Select Case mealPlanListBox.SelectedIndex
            Case 0
                mealPlanListBox.Text = Module1.Meal_Plan_7.ToString("c2")
                MealPlans = Module1.Meal_Plan_7.ToString("c2")
            Case 1
                mealPlanListBox.Text = Module1.Meal_Plan_14.ToString("c2")
                MealPlans = Module1.Meal_Plan_14.ToString("c2")
            Case 2
                mealPlanListBox.Text = Module1.Meal_Plan_Unlimited.ToString("c2")
                MealPlans = Module1.Meal_Plan_Unlimited.ToString("c2")
        End Select
        Form1.totalLabel.Text = (Form1.dormLabel.Text + Form1.mealPlanLabel.Text + MealPlans).ToString("c2")

        Me.Hide()
        Form1.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub
End Class