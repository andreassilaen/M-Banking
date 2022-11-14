Public Class Form8

    'Sub switchPanel(ByVal frm As Form)           -------- ini kalau pakai panel untuk masukin formnya ----------
    'Panel4.Controls.Clear()
    ' frm.TopLevel = False
    'Panel4.Controls.Add(frm)
    ' frm.Show()
    'End Sub




    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim frm3 As New Form3
        frm3.MdiParent = Me
        frm3.Dock = DockStyle.Fill
        frm3.FormBorderStyle = FormBorderStyle.None
        frm3.Show()


        Panel4.Dispose()





        'Panel4.Controls.Clear()
        'frm3.TopLevel = False
        'Panel4.Controls.Add(frm3)
        'frm3.Show()

        'frm3.Dock = DockStyle.Fill
        'switchPanel(frm3)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim frm5 As New Form5
        frm5.MdiParent = Me
        frm5.Dock = DockStyle.Fill
        frm5.Show()
        frm5.FormBorderStyle = FormBorderStyle.None


        Panel4.Dispose()



        'Panel4.Controls.Clear()
        'frm5.TopLevel = False
        'Panel4.Controls.Add(frm5)
        'frm5.Show()

        'frm5.Dock = DockStyle.Fill
        'switchPanel(frm5)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim frm6 As New Form6
        frm6.MdiParent = Me
        frm6.Dock = DockStyle.Fill
        frm6.Show()
        frm6.FormBorderStyle = FormBorderStyle.None


        Panel4.Dispose()



        ' Panel4.Controls.Clear()
        'frm6.TopLevel = False
        ' Panel4.Controls.Add(frm6)
        ' frm6.Show()

        'frm6.Dock = DockStyle.Fill
        'switchPanel(frm6)
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim frm2 As New Form2
        frm2.MdiParent = Me
        frm2.Dock = DockStyle.Fill
        frm2.Show()
        frm2.FormBorderStyle = FormBorderStyle.None
    End Sub


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form1.Show()
        Me.Close()
    End Sub

    Private Sub Form8_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub PictureBox7_Click(sender As Object, e As EventArgs) Handles PictureBox7.Click

    End Sub

    Private Sub PictureBox6_Click(sender As Object, e As EventArgs) Handles PictureBox6.Click

    End Sub

    Private Sub PictureBox3_Click(sender As Object, e As EventArgs)

    End Sub

    ' ' *+*+*+*+*+*+*+*++*+*+*+**+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+**+*+*+*+*+*+*++**+*+*+*+*+*+*+*++*+*+*+**+*+*+*+*+*+*+*+*+*+
    ' DIBAWAH INI UNUTK HOVER TOMBOL BUTTON secara MANUAL *+*+*+*+*+*+*+*++*+*+*+**+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+**+*+*+*+*+*+*++*
    ' *+*+*+*+*+*+*+*++*+*+*+**+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+*+**+*+*+*+*+*+*++**+*+*+*+*+*+*+*++*+*+*+**+*+*+*+*+*+*+*+*+*+
    Private Sub Button2_MouseHover(sender As Object, e As EventArgs) Handles Button2.MouseHover
        Button2.BackColor = Color.Black

    End Sub

    Private Sub Button2_MouseLeave(sender As Object, e As EventArgs) Handles Button2.MouseLeave
        Button2.BackColor = Color.FromArgb(0, 0, 70)
    End Sub

    Private Sub Button3_MouseHover(sender As Object, e As EventArgs) Handles Button3.MouseHover
        Button3.BackColor = Color.Black

    End Sub

    Private Sub Button3_MouseLeave(sender As Object, e As EventArgs) Handles Button3.MouseLeave
        Button3.BackColor = Color.FromArgb(0, 0, 70)
    End Sub
    Private Sub Button4_MouseHover(sender As Object, e As EventArgs) Handles Button4.MouseHover
        Button4.BackColor = Color.Black

    End Sub

    Private Sub Button4_MouseLeave(sender As Object, e As EventArgs) Handles Button4.MouseLeave
        Button4.BackColor = Color.FromArgb(0, 0, 70)
    End Sub



End Class