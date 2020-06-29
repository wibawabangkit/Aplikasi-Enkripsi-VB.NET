Public Class Caesar
    Protected Teks_Asli As String, Teks_Sandi As String, PanjangTeks As Long

    Private Sub btndeskripsi_Click(sender As Object, e As EventArgs) Handles btndeskripsi.Click
        Dim X As String = ""
        Dim XKALIMAT As String = ""
        For i = 1 To Len(chiper.Text)
            X = Mid(chiper.Text, i, i)
            X = Chr(Asc(X) - 3)
            XKALIMAT = XKALIMAT + X
        Next
        plain.Text = XKALIMAT

    End Sub

    Private Sub btnenkripsi_Click(sender As Object, e As EventArgs) Handles btnenkripsi.Click
        Dim x As String = ""
        Dim xkalimat As String = ""
        For i = 1 To Len(plain.Text)
            x = Mid(plain.Text, i, i)
            x = Chr(Asc(x) + 3)
            xkalimat = xkalimat + x
        Next
        chiper.Text = xkalimat
    End Sub

End Class