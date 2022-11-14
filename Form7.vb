Public Class Form7
    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        frm5.TabControl1.SelectTab(1)                      '<<<<<<<<<<< ga bisa???
        Me.Close()

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged

    End Sub
End Class