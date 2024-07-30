Imports System.Data.SqlClient

Public Class DepoTablosuFormu
    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = "Data Source=localhost;Initial Catalog=retrostore;User ID=sa;Password=1234"
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti


        If TbxUrunID.Text <> "" AndAlso TbxUrunAdedi.Text <> "" Then
            komut.CommandText = "INSERT INTO Depo_Tablosu (Urun_ID, Urun_Adeti) VALUES (@UrunID, @UrunAdeti)"
            komut.Parameters.AddWithValue("@UrunID", TbxUrunID.Text)
            komut.Parameters.AddWithValue("@UrunAdeti", TbxUrunAdedi.Text)

            Try
                komut.ExecuteNonQuery()

            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try


            Dim sorgu = "Select * from Depo_Tablosu"
            komut.CommandText = sorgu
            Dim adaptor = New SqlDataAdapter(komut)
            adaptor.Fill(dsv, "retrostore")
            DgvDepo.DataSource = dsv.Tables("retrostore")

            TbxUrunID.Text = ""
            TbxUrunAdedi.Text = ""
        Else
            MessageBox.Show("Lütfen tüm alanları doldurunuz")

        End If
        baglanti.Close()
    End Sub

    Private Sub GuncelleBtn_Click(sender As Object, e As EventArgs) Handles GuncelleBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = "Data Source=localhost;Initial Catalog=retrostore;User ID=sa;Password=1234"
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        If TbxUrunID.Text <> "" AndAlso TbxUrunAdedi.Text <> "" Then
            komut.CommandText = "UPDATE Depo_Tablosu SET Urun_Adeti = @UrunAdeti WHERE Urun_ID = @UrunID"
            komut.Parameters.AddWithValue("@UrunID", TbxUrunID.Text)
            komut.Parameters.AddWithValue("@UrunAdeti", TbxUrunAdedi.Text)

            Try
                komut.ExecuteNonQuery()
            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try

            Dim sorgu = "SELECT * FROM Depo_Tablosu"
            komut.CommandText = sorgu
            Dim adaptor = New SqlDataAdapter(komut)
            adaptor.Fill(dsv, "retrostore")
            DgvDepo.DataSource = dsv.Tables("retrostore")

            TbxUrunID.Text = ""
            TbxUrunAdedi.Text = ""
        Else
            MessageBox.Show("Lütfen tüm alanları doldurunuz")
        End If

        baglanti.Close()
    End Sub



    Private Sub AraBtn_Click(sender As Object, e As EventArgs) Handles AraBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = "Data Source=localhost;Initial Catalog=retrostore;User ID=sa;Password=1234"
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand
        komut.Connection = baglanti

        If TbxUrunID.Text <> "" Then
            komut.CommandText = "SELECT * FROM Depo_Tablosu WHERE Urun_ID = @UrunID"
            komut.Parameters.AddWithValue("@UrunID", TbxUrunID.Text)

            Try
                Dim adaptor = New SqlDataAdapter(komut)
                adaptor.Fill(dsv, "retrostore")
                DgvDepo.DataSource = dsv.Tables("retrostore")

                ' Eğer arama sonucu bulunamadıysa
                If dsv.Tables("retrostore").Rows.Count = 0 Then
                    MessageBox.Show("Aranan ürün ID'si bulunamadı.")
                End If
            Catch ex As Exception
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try
        Else
            MessageBox.Show("Lütfen ürün ID'sini giriniz.")
        End If

        baglanti.Close()
    End Sub


    Private Sub ListeleBtn_Click(sender As Object, e As EventArgs) Handles ListeleBtn.Click
        Dim Connection As New SqlConnection
        Dim dsv As New DataSet
        Connection.ConnectionString = "Data Source=localhost;Initial Catalog=retrostore;User ID=sa;Password=1234"
        Connection.Open()
        Dim SQLcommand As New SqlCommand
        Dim sorgu = "Select * from Depo_Tablosu"
        SQLcommand.Connection = Connection
        Dim adaptor = New SqlDataAdapter(sorgu, Connection)
        adaptor.Fill(dsv, "retrostore")
        DgvDepo.DataSource = dsv.Tables("retrostore")
        Connection.Close()
    End Sub

    Private Sub btnVazgec_Click(sender As Object, e As EventArgs)
        Me.Close()

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        SatislarTablosuFormu.Show()
        Me.Close()
    End Sub
End Class