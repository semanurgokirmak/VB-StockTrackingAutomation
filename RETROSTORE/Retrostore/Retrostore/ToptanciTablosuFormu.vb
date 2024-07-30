Imports System.Data.SqlClient
Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class ToptanciTablosuFormu
    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = SqlBaglantiCumlesi()
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        If TbxTopAdi.Text <> "" AndAlso TbxTopWeb.Text <> "" AndAlso TbxTopTel.Text <> "" Then
            komut.CommandText = "INSERT INTO Toptanci_Tablosu (Toptanci_Adi, Toptanci_WebSitesi, Toptanci_Tel) VALUES (@ToptanciAdi, @ToptanciWebSitesi, @ToptanciTel)"
            komut.Parameters.AddWithValue("@ToptanciAdi", TbxTopAdi.Text)
            komut.Parameters.AddWithValue("@ToptanciWebSitesi", TbxTopWeb.Text)
            komut.Parameters.AddWithValue("@ToptanciTel", TbxTopTel.Text)

            Try
                komut.ExecuteNonQuery()
                MessageBox.Show("Toptancı başarıyla kaydedildi.")
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try

            ' Verileri çek ve DataGridView'e doldur
            Dim sorgu = "SELECT * FROM Toptanci_Tablosu"
            komut.CommandText = sorgu
            Dim adaptor = New SqlDataAdapter(komut)
            adaptor.Fill(dsv, "retrostore")
            ToptanciDGV.DataSource = dsv.Tables("retrostore")

            ' Form alanlarını temizle
            TbxTopAdi.Text = ""
            TbxTopWeb.Text = ""
            TbxTopTel.Text = ""
        Else
            MessageBox.Show("Lütfen tüm alanları doldurunuz.")
        End If

        baglanti.Close()
    End Sub


    Private Sub GuncelleBtn_Click(sender As Object, e As EventArgs) Handles GuncelleBtn.Click
        If TbxTopAdi.Text = "" Then
            MessageBox.Show("Lütfen güncellenecek toptancının adını giriniz.")
            Return
        End If

        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = SqlBaglantiCumlesi()
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        Dim updateQuery As String = "UPDATE Toptanci_Tablosu SET"
        Dim updateValues As New List(Of String)

        If TbxTopWeb.Text <> "" Then
            updateValues.Add(" Toptanci_WebSitesi = @ToptanciWebSitesi")
            komut.Parameters.AddWithValue("@ToptanciWebSitesi", TbxTopWeb.Text)
        End If

        If TbxTopTel.Text <> "" Then
            updateValues.Add(" Toptanci_Tel = @ToptanciTel")
            komut.Parameters.AddWithValue("@ToptanciTel", TbxTopTel.Text)
        End If

        ' Güncellenecek sütunların hepsi boş değilse güncelleme işlemi yapılır
        If updateValues.Count > 0 Then
            updateQuery &= String.Join(",", updateValues)
            updateQuery &= " WHERE Toptanci_Adi = @ToptanciAdi"

            komut.CommandText = updateQuery
            komut.Parameters.AddWithValue("@ToptanciAdi", TbxTopAdi.Text)

            Try
                komut.ExecuteNonQuery()
                MessageBox.Show("Toptancı bilgileri başarıyla güncellendi.")
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try

            ' Verileri çek ve DataGridView'e doldur
            Dim sorgu = "SELECT * FROM Toptanci_Tablosu"
            komut.CommandText = sorgu
            Dim adaptor = New SqlDataAdapter(komut)
            adaptor.Fill(dsv, "retrostore")
            ToptanciDGV.DataSource = dsv.Tables("retrostore")

            ' Form alanlarını temizle
            TbxTopAdi.Text = ""
            TbxTopWeb.Text = ""
            TbxTopTel.Text = ""
        Else
            MessageBox.Show("Güncellenecek bir alan bulunamadı. En az bir alanı doldurunuz.")
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

        If TbxTopAdi.Text <> "" Then
            komut.CommandText = "SELECT * FROM Toptanci_Tablosu WHERE Toptanci_Adi LIKE @ToptanciAdi"
            komut.Parameters.AddWithValue("@ToptanciAdi", "%" & TbxTopAdi.Text & "%")

            Try
                Dim adaptor = New SqlDataAdapter(komut)
                adaptor.Fill(dsv, "toptancilar")
                ToptanciDGV.DataSource = dsv.Tables("toptancilar")

                ' Eğer arama sonucu bulunamadıysa
                If dsv.Tables("toptancilar").Rows.Count = 0 Then
                    MessageBox.Show("Aranan toptancı adı bulunamadı.")
                End If
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try
        Else
            MessageBox.Show("Lütfen toptancı adını giriniz.")
        End If

        baglanti.Close()
    End Sub


    Private Sub ListeleBtn_Click(sender As Object, e As EventArgs) Handles ListeleBtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=localhost;Initial Catalog=retrostore;User ID=sa;Password=1234"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from Toptanci_Tablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "retrostore")
        ToptanciDGV.DataSource = dsv.Tables("retrostore")
        Connection.Close()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        DepoTablosuFormu.Show()
        Me.Close()
    End Sub
End Class