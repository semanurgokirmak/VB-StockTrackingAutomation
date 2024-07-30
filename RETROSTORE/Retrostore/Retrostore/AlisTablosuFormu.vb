Imports System.Data.SqlClient

Public Class AlisTablosuFormu
    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection(SqlBaglantiCumlesi())
        Dim dsv As New DataSet
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        ' Boş alan kontrolü
        If TbxUrunID.Text <> "" AndAlso TbxToptanciID.Text <> "" AndAlso TxtAlisMiktr.Text <> "" AndAlso TbxAlisFyt.Text <> "" Then
            komut.CommandText = "INSERT INTO Alis_Tablosu (Urun_ID, Toptanci_ID, Alis_Miktari, Alis_Fiyati) VALUES (@UrunID, @ToptanciID, @AlisMiktari, @AlisFiyati)"

            komut.Parameters.AddWithValue("@UrunID", TbxUrunID.Text)
            komut.Parameters.AddWithValue("@ToptanciID", TbxToptanciID.Text)
            komut.Parameters.AddWithValue("@AlisMiktari", TxtAlisMiktr.Text)
            komut.Parameters.AddWithValue("@AlisFiyati", TbxAlisFyt.Text)

            Try
                komut.ExecuteNonQuery()
                MessageBox.Show("Başarıyla kaydedildi.")
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try

            ' Verileri çek ve DataGridView'e doldur
            Dim sorgu = "SELECT * FROM Alis_Tablosu"
            komut.CommandText = sorgu
            Dim adaptor = New SqlDataAdapter(komut)
            adaptor.Fill(dsv, "retrostore")
            AlisDgv.DataSource = dsv.Tables("retrostore")

            ' Form alanlarını temizle
            TbxUrunID.Text = ""
            TbxToptanciID.Text = ""
            TxtAlisMiktr.Text = ""
            TbxAlisFyt.Text = ""
        Else
            MessageBox.Show("Lütfen tüm alanları doldurunuz.")
        End If

        baglanti.Close()
    End Sub






    Private Sub GuncelleBtn_Click(sender As Object, e As EventArgs) Handles GuncelleBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = SqlBaglantiCumlesi()
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        ' Boş alan kontrolü
        If TxtAlisMiktr.Text <> "" AndAlso TbxAlisFyt.Text <> "" Then
            komut.CommandText = "UPDATE Alis_Tablosu SET Toptanci_ID = @ToptanciID, Alis_Miktari = @AlisMiktari, Alis_Fiyati = @AlisFiyati WHERE Urun_ID = @UrunID"

            komut.Parameters.AddWithValue("@AlisMiktari", TxtAlisMiktr.Text)
            komut.Parameters.AddWithValue("@AlisFiyati", TbxAlisFyt.Text)

            Try
                komut.ExecuteNonQuery()
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try

            ' Verileri çek ve DataGridView'e doldur
            Dim sorgu = "SELECT * FROM Alis_Tablosu"
            komut.CommandText = sorgu
            Dim adaptor = New SqlDataAdapter(komut)
            adaptor.Fill(dsv, "retrostore")
            AlisDgv.DataSource = dsv.Tables("retrostore")

            ' Form alanlarını temizle

            TxtAlisMiktr.Text = ""
            TbxAlisFyt.Text = ""
        Else
            MessageBox.Show("Lütfen tüm alanları doldurunuz.")
        End If

        baglanti.Close()
    End Sub




    'Private Sub AraBtn_Click(sender As Object, e As EventArgs) Handles AraBtn.Click
    '    Dim baglanti As SqlConnection = New SqlConnection
    '    Dim dsv As New DataSet
    '    baglanti.ConnectionString = SqlBaglantiCumlesi()
    '    baglanti.Open()
    '    Dim komut As SqlCommand = New SqlCommand
    '    komut.Connection = baglanti

    '    ' Boş alan kontrolü
    '    If TbxUrunID.Text <> "" Then
    '        komut.CommandText = "SELECT * FROM Alis_Tablosu WHERE Urun_ID = @UrunID"
    '        komut.Parameters.AddWithValue("@UrunID", TbxUrunID.Text)

    '        Try
    '            Dim adaptor = New SqlDataAdapter(komut)
    '            adaptor.Fill(dsv, "retrostore")
    '            AlisDgv.DataSource = dsv.Tables("retrostore")

    '            ' Eğer arama sonucu bulunamadıysa
    '            If dsv.Tables("retrostore").Rows.Count = 0 Then
    '                MessageBox.Show("Aranan ürün ID'si bulunamadı.")
    '            End If
    '        Catch ex As SqlException
    '            MessageBox.Show("Hata: " & ex.Message)
    '            Return
    '        End Try
    '    Else
    '        MessageBox.Show("Lütfen ürün ID'sini giriniz.")
    '    End If

    '    baglanti.Close()
    'End Sub


    Private Sub ListeleBtn_Click(sender As Object, e As EventArgs) Handles ListeleBtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=localhost;Initial Catalog=retrostore;User ID=sa;Password=1234"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from Alis_Tablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "retrostore")
        AlisDgv.DataSource = dsv.Tables("retrostore")
        Connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        ToptanciTablosuFormu.Show()
        Me.Close()
    End Sub
End Class