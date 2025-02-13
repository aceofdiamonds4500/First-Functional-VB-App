''' <summary>
''' 
''' </summary>

Public Class Form1
	Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
		Label3.Visible = False
	End Sub

	Private Sub btnOne(sender As Object, e As EventArgs) Handles Button1.Click
		Label3.Text = "Un"
		Label3.Visible = True
	End Sub

	Private Sub btnTwo(sender As Object, e As EventArgs) Handles Button2.Click
		Label3.Text = "Deux"
		Label3.Visible = True
	End Sub

	Private Sub btnThree(sender As Object, e As EventArgs) Handles Button3.Click
		Label3.Text = "Trois"
		Label3.Visible = True
	End Sub

	Private Sub btnFour(sender As Object, e As EventArgs) Handles Button4.Click
		Label3.Text = "Quatre"
		Label3.Visible = True
	End Sub

	Private Sub btnFive(sender As Object, e As EventArgs) Handles Button5.Click
		Label3.Text = "Cinq"
		Label3.Visible = True
	End Sub
	Private Sub lblFrench(sender As Object, e As EventArgs) Handles Label3.Click
		Label3.Visible = False
	End Sub

	Private Sub btnExit(sender As Object, e As EventArgs) Handles Button6.Click

	End Sub
End Class
