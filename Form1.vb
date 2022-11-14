Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim connection As SqlConnection = New SqlConnection("Data Source = laptop-ldl7jela; database = DB_M-Banking; Integrated Security = True")

        Dim command As SqlCommand = New SqlCommand("SELECT * FROM TB_User WHERE IdUser = '" + tbUsername.Text + "' AND Password = '" + tbPassword.Text + "'", connection)

        Dim Name As SqlCommand = New SqlCommand("SELECT Name FROM TB_User WHERE IdUser = '" + tbUsername.Text + "' AND Password = '" + tbPassword.Text + "'", connection)

        Dim pin As SqlCommand = New SqlCommand("SELECT PIN FROM TB_User WHERE IdUser = '" + tbUsername.Text + "' AND Password = '" + tbPassword.Text + "'", connection)

        Dim saldo As SqlCommand = New SqlCommand("SELECT Saldo FROM TB_Rekening, TB_User WHERE TB_User.NoRekening = TB_Rekening.NoRekening", connection)

        Dim noRek As SqlCommand = New SqlCommand("SELECT NoRekening FROM TB_User WHERE IdUser = '" + tbUsername.Text + "' AND Password = '" + tbPassword.Text + "'", connection)



        Dim transaksi As SqlCommand = New SqlCommand("INSERT INTO TB_Transaksi () VALUE () ", connection)









        Dim adapter As SqlDataAdapter = New SqlDataAdapter(command)

        Dim table As DataTable = New DataTable()

        adapter.Fill(table)

        'KALO MAU KOMEN PAKE TANDA PETIK 1
        If table.Rows.Count() <= 0 Then


            MessageBox.Show("MAAF, Username atau Password yang anda masukan tidak terdaftar.
Silahkan untuk Login kembali dengan benar.
Terima kasih.", "UNTAR", MessageBoxButtons.OK, MessageBoxIcon.Error)



        Else
            connection.Open()
            Username1 = Convert.ToString(Name.ExecuteScalar())
            Pin1 = Convert.ToString(pin.ExecuteScalar())
            Saldo1 = Convert.ToInt32(saldo.ExecuteScalar())
            NoRek1 = Convert.ToString(noRek.ExecuteScalar())


            Form8.Label2.Text = Username1

            Form8.Show()
            Me.Close()

        End If




    End Sub


    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If tbPassword.UseSystemPasswordChar = True Then

            tbPassword.UseSystemPasswordChar = False
            Label3.Text = "Hide"
            CheckBox1.BackColor = Color.DarkOrange
        Else
            tbPassword.UseSystemPasswordChar = True
            Label3.Text = "Show"
            CheckBox1.BackColor = Color.White
        End If
    End Sub

    Private Sub PictureBox2_Click(sender As Object, e As EventArgs) Handles PictureBox2.Click

    End Sub
End Class
