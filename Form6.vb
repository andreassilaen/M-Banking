Imports System.Globalization
Public Class Form6
    Private Sub Button5_Click(sender As Object, e As EventArgs)
        Form2.Show()
        Me.Close()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TabControl2.SelectTab(1)
        Label1.Text = MyRekening
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        TabControl2.SelectTab(2)
        Label7.Text = MyRekening
    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        TabControl2.SelectTab(3)
        Label13.Text = MyRekening
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        TabControl2.SelectTab(0)
    End Sub

    Private Sub Label13_Click(sender As Object, e As EventArgs) Handles Label13.Click

    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click

        If String.IsNullOrEmpty(tbJmlUang3.Text) Then

            If tbNoKredit.Text = "" Or tbJmlUang3.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        ElseIf tbJmlUang3.TextLength > 0 Then
            Dim jmlUangInteger As Double = tbJmlUang3.Text


            If tbNoKredit.TextLength > 0 And tbJmlUang3.TextLength > 0 And jmlUangInteger >= 10000 And jmlUangInteger <= saldo Then
                jmlUangInteger = FormatNumber(tbJmlUang3.Text)
                Dim rupiah As Decimal
                rupiah = Decimal.Parse(jmlUangInteger)

                Dim mesBox As Object = MessageBox.Show(("Kirim ke: " + tbNoKredit.Text + vbCrLf + "Jumlah: " + rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))), "M-transfer",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Question)



                Select Case mesBox 'bisa juga pakai IF !!!!!

                    Case Windows.Forms.DialogResult.OK

                        NomorKredit = tbNoKredit.Text

                        Form7.Show()




                        Form7.TextBox2.Text = Form7.TextBox2.Text + vbCrLf + "" + vbCrLf +
                    "-----------" + Format(DateTime.Now, "hh:mm / dd-MMM-yyyy") + "-----------" + vbCrLf +
                    "Payment: Kartu Kredit" + vbCrLf + "Dari: " + MyRekening + vbCrLf +
                    "Ke Bank: " + cbBank.SelectedItem + vbCrLf + "Ke: " + NomorKredit + vbCrLf +
                    rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")) +
                    vbCrLf + "=================================="

                        tbJmlUang3.Text = tbJmlUang3.Text + "==================================" + vbCrLf

                        saldo = saldo - jmlUangInteger

                    Case Windows.Forms.DialogResult.Cancel
                        TabControl2.SelectTab(1)
                End Select

            ElseIf tbNoKredit.TextLength > 0 And tbJmlUang3.TextLength > 0 And jmlUangInteger > saldo Then
                MessageBox.Show("Maaf, Saldo anda tidak mencukupi jumlah uang yang akan ditransaksi.
silahkan untuk mengisi ulang jumlah uang yang akan diproses atau melakukan Top Up Saldo", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf tbNoKredit.TextLength > 0 And tbJmlUang3.TextLength > 0 And jmlUangInteger < 10000 Then
                MessageBox.Show("Maaf, jumlah uang tidak memnuhi syarat transaksi transfer. 
Minimal jumlah uang: 10,000 untuk bisa melakukan transaksi transfer", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)



            ElseIf tbNoKredit.Text = "" Or tbJmlUang3.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If






        End If
    End Sub

    Private Sub Button10_Click(sender As Object, e As EventArgs) Handles Button10.Click
        If String.IsNullOrEmpty(tbJmlUang4.Text) Then

            If tbNoHP.Text = "" Or tbJmlUang4.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        ElseIf tbJmlUang4.TextLength > 0 Then
            Dim jmlUangInteger As Double = tbJmlUang4.Text


            If tbNoHP.TextLength > 0 And tbJmlUang4.TextLength > 0 And jmlUangInteger >= 10000 And jmlUangInteger <= saldo Then
                jmlUangInteger = FormatNumber(tbJmlUang4.Text)
                Dim rupiah As Decimal
                rupiah = Decimal.Parse(jmlUangInteger)

                Dim mesBox As Object = MessageBox.Show(("Kirim ke: " + tbNoHP.Text + vbCrLf + "Jumlah: " + rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))), "M-transfer",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Question)



                Select Case mesBox 'bisa juga pakai IF !!!!!

                    Case Windows.Forms.DialogResult.OK

                        NomorHP = tbNoHP.Text

                        Form7.Show()




                        Form7.TextBox2.Text = Form7.TextBox2.Text + vbCrLf + "" + vbCrLf +
                    "-----------" + Format(DateTime.Now, "hh:mm / dd-MMM-yyyy") + "-----------" + vbCrLf +
                    "Payment: Handphone" + vbCrLf + "Dari: " + MyRekening + vbCrLf +
                    "Opertaor: " + cbOperator.SelectedItem + vbCrLf + "Ke: " + NomorHP + vbCrLf +
                    rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")) +
                    vbCrLf + "=================================="

                        tbJmlUang4.Text = tbJmlUang4.Text + "==================================" + vbCrLf

                        saldo = saldo - jmlUangInteger

                    Case Windows.Forms.DialogResult.Cancel
                        TabControl2.SelectTab(1)
                End Select

            ElseIf tbNoHP.TextLength > 0 And tbJmlUang4.TextLength > 0 And jmlUangInteger > saldo Then
                MessageBox.Show("Maaf, Saldo anda tidak mencukupi jumlah uang yang akan ditransaksi.
silahkan untuk mengisi ulang jumlah uang yang akan diproses atau melakukan Top Up Saldo", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf tbNoHP.TextLength > 0 And tbJmlUang4.TextLength > 0 And jmlUangInteger < 10000 Then
                MessageBox.Show("Maaf, jumlah uang tidak memnuhi syarat transaksi transfer. 
Minimal jumlah uang: 10,000 untuk bisa melakukan transaksi transfer", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)



            ElseIf tbNoHP.Text = "" Or tbJmlUang4.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If






        End If
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        If String.IsNullOrEmpty(tbJmlUang5.Text) Then

            If tbNoBayar.Text = "" Or tbJmlUang5.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)
            End If


        ElseIf tbJmlUang5.TextLength > 0 Then
            Dim jmlUangInteger As Double = tbJmlUang5.Text


            If tbNoBayar.TextLength > 0 And tbJmlUang5.TextLength > 0 And jmlUangInteger >= 10000 And jmlUangInteger <= saldo Then
                jmlUangInteger = FormatNumber(tbJmlUang5.Text)
                Dim rupiah As Decimal
                rupiah = Decimal.Parse(jmlUangInteger)

                Dim mesBox As Object = MessageBox.Show(("Kirim ke: " + tbNoBayar.Text + vbCrLf + "Jumlah: " + rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID"))), "M-transfer",
                     MessageBoxButtons.OKCancel,
                     MessageBoxIcon.Question)



                Select Case mesBox 'bisa juga pakai IF !!!!!

                    Case Windows.Forms.DialogResult.OK

                        NomorBayar = tbNoBayar.Text

                        Form7.Show()




                        Form7.TextBox2.Text = Form7.TextBox2.Text + vbCrLf + "" + vbCrLf +
                    "-----------" + Format(DateTime.Now, "hh:mm / dd-MMM-yyyy") + "-----------" + vbCrLf +
                    "Payment: Publik/Utilitas" + vbCrLf + "Dari: " + MyRekening + vbCrLf +
                    "Perusahaan: " + cbPerusahaan.SelectedItem + vbCrLf + "Ke: " + NomorBayar + vbCrLf +
                    "Wilayah: " + cbWilayah.SelectedItem + vbCrLf +
                    rupiah.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")) +
                    vbCrLf + "=================================="

                        tbJmlUang5.Text = tbJmlUang5.Text + "==================================" + vbCrLf

                        saldo = saldo - jmlUangInteger

                    Case Windows.Forms.DialogResult.Cancel
                        TabControl2.SelectTab(1)
                End Select

            ElseIf tbNoBayar.TextLength > 0 And tbJmlUang5.TextLength > 0 And jmlUangInteger > saldo Then
                MessageBox.Show("Maaf, Saldo anda tidak mencukupi jumlah uang yang akan ditransaksi.
silahkan untuk mengisi ulang jumlah uang yang akan diproses atau melakukan Top Up Saldo", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            ElseIf tbNoBayar.TextLength > 0 And tbJmlUang5.TextLength > 0 And jmlUangInteger < 10000 Then
                MessageBox.Show("Maaf, jumlah uang tidak memnuhi syarat transaksi transfer. 
Minimal jumlah uang: 10,000 untuk bisa melakukan transaksi transfer", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)



            ElseIf tbNoBayar.Text = "" Or tbJmlUang5.Text = "" Then
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)

            Else
                MessageBox.Show("Data input tidak ada, silahkan input kembali", "M-transfer", MessageBoxButtons.OK, MessageBoxIcon.Error)


            End If






        End If
    End Sub
End Class