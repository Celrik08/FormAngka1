Public Class Form1

    Private Sub TextNilai1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNilai1.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau kontrol seperti Backspace atau Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka atau kontrol, batalkan input dengan menandai event sebagai sudah di-handle
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            TextNilai2.Focus()
        End If
    End Sub

    Private Sub TextNilai2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNilai2.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau kontrol seperti Backspace atau Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka atau kontrol, batalkan input dengan menandai event sebagai sudah di-handle
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            TextNilai3.Focus()
        End If
    End Sub

    Private Sub TextNilai3_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNilai3.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau kontrol seperti Backspace atau Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka atau kontrol, batalkan input dengan menandai event sebagai sudah di-handle
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            TextNilai4.Focus()
        End If
    End Sub

    Private Sub TextNilai4_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNilai4.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau kontrol seperti Backspace atau Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka atau kontrol, batalkan input dengan menandai event sebagai sudah di-handle
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            TextNilai5.Focus()
        End If
    End Sub

    Private Sub TextBox5_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNilai5.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau kontrol seperti Backspace atau Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka atau kontrol, batalkan input dengan menandai event sebagai sudah di-handle
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            TextNilai6.Focus()
        End If
    End Sub

    Private Sub TextNilai6_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNilai6.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau kontrol seperti Backspace atau Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka atau kontrol, batalkan input dengan menandai event sebagai sudah di-handle
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            TextNilai7.Focus()
        End If
    End Sub

    Private Sub TextBox7_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextNilai7.KeyPress
        ' Cek apakah karakter yang dimasukkan adalah angka atau kontrol seperti Backspace atau Delete
        If Not Char.IsDigit(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            ' Jika bukan angka atau kontrol, batalkan input dengan menandai event sebagai sudah di-handle
            e.Handled = True
        End If

        If e.KeyChar = ChrW(Keys.Enter) Then
            TextNilai7.Focus()
            e.Handled = True
            AngkaRandom()
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AngkaRandom()
    End Sub

    Private Sub AngkaRandom()
        ' Mengumpulkan nilai-nilai dari TextBox ke dalam array
        Dim values(6) As Integer ' Array dengan 7 elemen (indeks 0-6)

        If Integer.TryParse(TextNilai1.Text, values(0)) AndAlso
           Integer.TryParse(TextNilai2.Text, values(1)) AndAlso
           Integer.TryParse(TextNilai4.Text, values(2)) AndAlso
           Integer.TryParse(TextNilai3.Text, values(3)) AndAlso
           Integer.TryParse(TextNilai5.Text, values(4)) AndAlso
           Integer.TryParse(TextNilai6.Text, values(5)) AndAlso
           Integer.TryParse(TextNilai7.Text, values(6)) Then

            ' Mengurutkan array sesuai dengan pilihan ComboBox
            If ComboPilihan.SelectedIndex = 0 Then
                Array.Sort(values)
            ElseIf ComboPilihan.SelectedIndex = 1 Then
                Array.Sort(values, New Comparison(Of Integer)(Function(x, y) y.CompareTo(x)))
            End If

            ' Menetapkan nilai-nilai yang diurutkan kembali ke TextBox
            TextNilai8.Text = values(0).ToString()
            TextNilai9.Text = values(1).ToString()
            TextNilai10.Text = values(2).ToString()
            TextNilai11.Text = values(3).ToString()
            TextNilai12.Text = values(4).ToString()
            TextNilai13.Text = values(5).ToString()
            TextNilai14.Text = values(6).ToString()
        Else
            MessageBox.Show("Masukkan angka yang valid di semua TextBox.", "Kesalahan", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ' Inisialisasi ComboBox
        ComboPilihan.Items.Add("Terkecil ke Terbesar")
        ComboPilihan.Items.Add("Terbesar ke Terkecil")
        ComboPilihan.SelectedIndex = 0 ' Pilihan default
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        TextNilai1.Text = ""
        TextNilai2.Text = ""
        TextNilai3.Text = ""
        TextNilai4.Text = ""
        TextNilai5.Text = ""
        TextNilai6.Text = ""
        TextNilai7.Text = ""
        TextNilai8.Text = ""
        TextNilai9.Text = ""
        TextNilai10.Text = ""
        TextNilai11.Text = ""
        TextNilai12.Text = ""
        TextNilai13.Text = ""
        TextNilai14.Text = ""
    End Sub
End Class
