Imports System.Data
Imports System.Data.SqlClient
Imports System.Globalization
Public Class Form5


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl1.SelectTab(1)
        Label4.Text = NoRek1 'biar keluar No.rekeningnya kalo mau transfer lagi 
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl1.SelectTab(0)
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl1.SelectTab(2)
        Label13.Text = NoRek1 'biar keluar No.rekeningnya kalo mau transfer lagi 
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click

        'tbJmlUang.Enabled = False ' kalo tbJmlUang.Text ga di isi / input bisa kebaca

        If String.IsNullOrEmpty(tbJmlUang.Text) Then

            If tbNoRek.Text = "" Or tbJmlUang.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        ElseIf tbJmlUang.TextLength > 0 Then
            Dim jmlUangInteger As Double = tbJmlUang.Text


            If tbNoRek.TextLength > 0 And tbJmlUang.TextLength > 0 And jmlUangInteger >= 10000 And jmlUangInteger <= saldo Then
                jmlUangInteger = FormatNumber(tbJmlUang.Text)
                Dim rupiah As Decimal
                rupiah = Decimal.Parse(jmlUangInteger)

                Dim mesBox As Object = MessageBox.Show(("Kirim ke: " + tbNoRek.Text + vbCrLf + "Jumlah: " + rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))), "M-transfer",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Question)



                Select Case mesBox 'bisa juga pakai IF !!!!!

                    Case Windows.Forms.DialogResult.OK

                        NomorRekening = tbNoRek.Text

                        Form7.Show()





                        Form7.TextBox2.Text = Form7.TextBox2.Text + vbCrLf + "" + vbCrLf +
                    "-----------" + Format(DateTime.Now, "hh:mm / dd-MMM-yyyy") + "-----------" + vbCrLf +
                    "Transfer: Antar Rekening" + vbCrLf + "Dari: " + MyRekening + vbCrLf +
                    "Ke: " + NomorRekening + vbCrLf +
                    rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")) +
                    vbCrLf + "=================================="

                        tbJmlUang2.Text = tbJmlUang2.Text + "==================================" + vbCrLf






                        Saldo1 = Saldo1 - jmlUangInteger

                    Case Windows.Forms.DialogResult.Cancel
                        TabControl1.SelectTab(1)
                End Select

            ElseIf tbNoRek.TextLength > 0 And tbJmlUang.TextLength > 0 And jmlUangInteger > saldo Then
                MessageBox.Show("Maaf, Saldo anda tidak mencukupi jumlah uang yang akan ditransaksi.
silahkan untuk mengisi ulang jumlah uang yang akan diproses atau melakukan Top Up Saldo", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf tbNoRek.TextLength > 0 And tbJmlUang.TextLength > 0 And jmlUangInteger < 10000 Then
                MessageBox.Show("Maaf, jumlah uang tidak memnuhi syarat transaksi transfer. 
Minimal jumlah uang: 10,000 untuk bisa melakukan transaksi transfer", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)



            ElseIf tbNoRek.Text = "" Or tbJmlUang.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If






        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        'tbJmlUang.Enabled = False ' kalo tbJmlUang.Text ga di isi / input bisa kebaca

        If String.IsNullOrEmpty(tbJmlUang2.Text) Then

            If cbBank.SelectedIndex = "" Or tbJmlUang2.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        ElseIf tbJmlUang2.TextLength > 0 Then
            Dim jmlUangInteger2 As Double = tbJmlUang2.Text


            If cbBank.SelectedItem = "Bank 1" Or cbBank.SelectedItem = "Bank 2" Or cbBank.SelectedItem = "Bank 3" And tbJmlUang2.TextLength > 0 And jmlUangInteger2 >= 10000 And jmlUangInteger2 <= saldo Then
                jmlUangInteger2 = FormatNumber(tbJmlUang2.Text)
                Dim rupiah As Decimal
                rupiah = Decimal.Parse(jmlUangInteger2)

                Dim mesBox As Object = MessageBox.Show(("Kirim ke Bank: " + cbBank.SelectedItem + vbCrLf + "Jumlah: " + rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))), "M-transfer",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Question)



                Select Case mesBox 'bisa juga pakai IF !!!!!

                    Case Windows.Forms.DialogResult.OK

                        NamaBank = cbBank.SelectedItem

                        Form7.Show()




                        Form7.TextBox2.Text = Form7.TextBox2.Text + vbCrLf + "" + vbCrLf +
                    "-----------" + Format(DateTime.Now, "hh:mm / dd-MMM-yyyy") + "-----------" + vbCrLf +
                    "Transfer: Antar Bank" + vbCrLf + "Dari: " + MyRekening + vbCrLf +
                    "Ke Bank: " + cbBank.SelectedItem + vbCrLf +
                    rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")) +
                    vbCrLf + "=================================="

                        tbJmlUang2.Text = tbJmlUang2.Text + "==================================" + vbCrLf



                        saldo = saldo - jmlUangInteger2

                    Case Windows.Forms.DialogResult.Cancel
                        TabControl1.SelectTab(2)
                End Select

            ElseIf cbBank.SelectedItem = "Bank 1" Or cbBank.SelectedItem = "Bank 2" Or cbBank.SelectedItem = "Bank 3" And tbJmlUang2.TextLength > 0 And jmlUangInteger2 > saldo Then
                MessageBox.Show("Maaf, Saldo anda tidak mencukupi jumlah uang yang akan ditransaksi.
silahkan untuk mengisi ulang jumlah uang yang akan diproses atau melakukan Top Up Saldo", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf cbBank.SelectedItem = "Bank 1" Or cbBank.SelectedItem = "Bank 2" Or cbBank.SelectedItem = "Bank 3" And tbJmlUang2.TextLength > 0 And jmlUangInteger2 < 10000 Then
                MessageBox.Show("Maaf, jumlah uang tidak memnuhi syarat transaksi transfer. 
Minimal jumlah uang: 10,000 untuk bisa melakukan transaksi transfer", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)



            ElseIf cbBank.SelectedItem = "" Or tbJmlUang2.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If






        End If

    End Sub

    Private Sub BackToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles BackToolStripMenuItem.Click
        Form2.Show()
        Me.Close()
    End Sub
    '##############################################################################################################
    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub
End Class