Imports System.Data.SqlClient


Public Class UrunlerTablosuFormu
    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection(SqlBaglantiCumlesi())
        Dim dsv As New DataSet
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        If TbxUrunAdi.Text <> "" AndAlso CbxKategori.SelectedIndex <> -1 Then
            komut.CommandText = "INSERT INTO Urunler_Tablosu (Urun_Adi, Urun_Aciklamasi, Urun_Kategori) VALUES (@UrunAdi, @UrunAciklamasi, @UrunKategori)"
            komut.Parameters.AddWithValue("@UrunAdi", TbxUrunAdi.Text)
            ' Ürün açıklaması boş bırakılabilir, bu yüzden boş olup olmadığını kontrol etmeye gerek yok.

            If TbxAciklama.Text <> "" Then
                komut.Parameters.AddWithValue("@UrunAciklamasi", TbxAciklama.Text)
            Else
                komut.Parameters.AddWithValue("@UrunAciklamasi", DBNull.Value)
            End If

            komut.Parameters.AddWithValue("@UrunKategori", CbxKategori.SelectedItem.ToString())

            Try
                komut.ExecuteNonQuery()
                MessageBox.Show("Ürün başarıyla kaydedildi.")
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try

            ' Verileri çek ve DataGridView'e doldur
            Dim sorgu = "SELECT * FROM Urunler_Tablosu"
            komut.CommandText = sorgu
            Dim adaptor = New SqlDataAdapter(komut)
            adaptor.Fill(dsv, "retrostore")
            UrunlerDGV.DataSource = dsv.Tables("retrostore")

            ' Form alanlarını temizle
            TbxUrunAdi.Text = ""
            TbxAciklama.Text = ""
            CbxKategori.SelectedIndex = -1
        Else
            MessageBox.Show("Lütfen tüm zorunlu alanları doldurunuz.")
        End If

        baglanti.Close()
    End Sub







    Private Sub UrunlerForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim baglanti As SqlConnection = New SqlConnection(SqlBaglantiCumlesi())
        Dim komut As SqlCommand = New SqlCommand("SELECT DISTINCT Urun_Kategori FROM Urunler_Tablosu", baglanti)

        Try
            baglanti.Open()
            Dim reader As SqlDataReader = komut.ExecuteReader()

            While reader.Read()
                CbxKategori.Items.Add(reader("Urun_Kategori").ToString())
            End While

            reader.Close()
        Catch ex As SqlException
            MessageBox.Show("Hata: " & ex.Message)
        Finally
            baglanti.Close()
        End Try
    End Sub











    Private Sub ListeleBtn_Click(sender As Object, e As EventArgs) Handles ListeleBtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=localhost;Initial Catalog=retrostore;User ID=sa;Password=1234"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from Urunler_Tablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "retrostore")
        UrunlerDGV.DataSource = dsv.Tables("retrostore")
        Connection.Close()
    End Sub

    Private Sub GuncelleBtn_Click(sender As Object, e As EventArgs) Handles GuncelleBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection(SqlBaglantiCumlesi())
        Dim dsv As New DataSet
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        If UrunlerDGV.SelectedRows.Count > 0 Then ' Seçili bir satır var mı kontrol et
            Dim urunId As Integer = Convert.ToInt32(UrunlerDGV.SelectedRows(0).Cells("Urun_ID").Value)

            If TbxUrunAdi.Text <> "" Then ' Ürün adı girilmiş mi kontrol et
                komut.CommandText = "UPDATE Urunler_Tablosu SET Urun_Adi = @UrunAdi, Urun_Aciklamasi = @UrunAciklamasi, Urun_Kategori = @UrunKategori WHERE Urun_ID = @UrunID"
                komut.Parameters.AddWithValue("@UrunAdi", TbxUrunAdi.Text)
                komut.Parameters.AddWithValue("@UrunAciklamasi", If(TbxAciklama.Text <> "", TbxAciklama.Text, DBNull.Value))
                komut.Parameters.AddWithValue("@UrunKategori", If(CbxKategori.SelectedIndex <> -1, CbxKategori.SelectedItem.ToString(), DBNull.Value))
                komut.Parameters.AddWithValue("@UrunID", urunId)

                Try
                    komut.ExecuteNonQuery()
                    MessageBox.Show("Ürün başarıyla güncellendi.")
                Catch ex As SqlException
                    MessageBox.Show("Hata: " & ex.Message)
                    Return
                End Try

                ' Verileri çek ve DataGridView'e doldur
                Dim sorgu = "SELECT * FROM Urunler_Tablosu"
                komut.CommandText = sorgu
                Dim adaptor = New SqlDataAdapter(komut)
                adaptor.Fill(dsv, "retrostore")
                UrunlerDGV.DataSource = dsv.Tables("retrostore")

                ' Form alanlarını temizle
                TbxUrunAdi.Text = ""
                TbxAciklama.Text = ""
                CbxKategori.SelectedIndex = -1
            Else
                MessageBox.Show("Lütfen ürün adını giriniz.")
            End If
        Else
            MessageBox.Show("Lütfen güncellemek için bir ürün seçiniz.")
        End If

        baglanti.Close()
    End Sub




    Private Sub AraBtn_Click(sender As Object, e As EventArgs) Handles AraBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = SqlBaglantiCumlesi()
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        ' Boş alan kontrolü
        If TbxUrunAdi.Text <> "" Then
            komut.CommandText = "SELECT * FROM Urunler_Tablosu WHERE Urun_Adi = @UrunAdi"
            komut.Parameters.AddWithValue("@UrunAdi", TbxUrunAdi.Text)

            Try
                Dim adaptor = New SqlDataAdapter(komut)
                adaptor.Fill(dsv, "retrostore")
                UrunlerDGV.DataSource = dsv.Tables("retrostore")

                ' Eğer arama sonucu bulunamadıysa
                If dsv.Tables("retrostore").Rows.Count = 0 Then
                    MessageBox.Show("Aranan ürün adı bulunamadı.")
                End If
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try
        Else
            MessageBox.Show("Lütfen ürün adını giriniz.")
        End If

        baglanti.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        AlisTablosuFormu.Show()
        Me.Close()
    End Sub
End Class