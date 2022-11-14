Imports System.Globalization
Public Class Form3
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If tbKodePin.Text = Pin1 Then
            Dim frm4 As New Form4
            frm4.MdiParent = Form8
            frm4.Dock = DockStyle.Fill
            frm4.FormBorderStyle = FormBorderStyle.None
            frm4.Show()
            'Form8.switchPanel(frm4)


            'Form4.Show()
            Form2.Close()
            Me.tbKodePin.Text.DefaultIfEmpty
            Me.Close()



            Dim rupiah As Decimal
            Dim saldoString As String = Module1.saldo
            rupiah = Decimal.Parse(" " + saldoString)


            frm4.Label2.Text = "--------" + Format(DateTime.Now, "HH:mm // dd-MMM-yyyy ") + "--------" + vbCrLf +
                            "No.Rekening: " + NoRek1 + vbCrLf + "Saldo: " +
                            Saldo1.ToString("C", CultureInfo.CreateSpecificCulture("id-ID")) + vbCrLf + 'udh termasuk Rp sama komanya(,00)
                            "------------------------------------"



        Else
            MessageBox.Show("MAAF, Kode PIN salah.", "M-Banking", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.tbKodePin.Text.DefaultIfEmpty
        Me.Close()

    End Sub

    Private Sub tbKodePin_TextChanged(sender As Object, e As EventArgs) Handles tbKodePin.TextChanged

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class