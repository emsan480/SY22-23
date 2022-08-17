Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        displaypicturebox.Image = flightpicturebox.Image
        labelname.Text = "MW 18014"
        labellegs.Text = "12,500 kg"
        labelheight.Text = "90 km"
    End Sub

    Private Sub firstflightpicture_Click(sender As Object, e As EventArgs) Handles displaypicturebox.Click

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles bigrocketpicturebox.Click

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles bigrocketbutton.Click
        displaypicturebox.Image = bigrocketpicturebox.Image
        labelname.Text = "apollo 11"
        labellegs.Text = "43.000 kg"
        labelheight.Text = "the moon"
    End Sub

    Private Sub sattelitebutton_Click(sender As Object, e As EventArgs) Handles sattelitebutton.Click
        displaypicturebox.Image = sattelitepiturebox.Image
        labelname.Text = "explorer 1"
        labellegs.Text = "13.97 kg"
        labelheight.Text = "2,550 km"
    End Sub

    Private Sub roverbutton_Click(sender As Object, e As EventArgs) Handles roverbutton.Click
        displaypicturebox.Image = roverpicturebox.Image
        labelname.Text = "mars pathfinder"
        labellegs.Text = "890 kg"
        labelheight.Text = "mars"
    End Sub

    Private Sub voyager1button_Click(sender As Object, e As EventArgs) Handles voyager1button.Click
        displaypicturebox.Image = voyagerpicturebox.Image
        labelname.Text = "voyager 1"
        labellegs.Text = "825.5 kg"
        labelheight.Text = "constantly moving"
    End Sub
End Class
