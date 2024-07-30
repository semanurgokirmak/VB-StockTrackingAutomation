Imports System.Data.SqlClient


Public Class SatislarTablosuFormu
    Private Sub KaydetBtn_Click(sender As Object, e As EventArgs) Handles KaydetBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = SqlBaglantiCumlesi()
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand

        komut.Connection = baglanti
        If TbxDepoID.Text & TxtSatisMiktr.Text & TbxSatisTutari.Text <> "" Then
            komut.CommandText = "INSERT INTO Satis_Tablosu (Depo_ID,Satis_Miktari,Satis_Fiyati) VALUES ('" & TbxDepoID.Text & "','" & TxtSatisMiktr.Text & "','" & TbxSatisTutari.Text & "')"

            komut.ExecuteNonQuery()
            Dim sorgu = "Select * from Satis_Tablosu"
            komut.Connection = baglanti
            Dim adaptor = New SqlDataAdapter(sorgu, baglanti)
            adaptor.Fill(dsv, "retrostore")
            SatisDGV.DataSource = dsv.Tables("retrostore")

            TbxDepoID.Text = ""
            TxtSatisMiktr.Text = ""

            TbxSatisTutari.Text = ""


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
        If TbxDepoID.Text <> "" AndAlso TxtSatisMiktr.Text <> "" AndAlso TbxSatisTutari.Text <> "" Then
            komut.CommandText = "UPDATE Satis_Tablosu SET Satis_Miktari = @SatisMiktari, Satis_Fiyati = @SatisTutari WHERE Depo_ID = @DepoID"
            komut.Parameters.AddWithValue("@DepoID", TbxDepoID.Text)
            komut.Parameters.AddWithValue("@SatisMiktari", TxtSatisMiktr.Text)
            komut.Parameters.AddWithValue("@SatisTutari", TbxSatisTutari.Text)

            Try
                komut.ExecuteNonQuery()
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
                Return
            End Try

            Dim sorgu = "Select * from Satis_Tablosu"
            komut.Connection = baglanti
            Dim adaptor = New SqlDataAdapter(sorgu, baglanti)
            adaptor.Fill(dsv, "retrostore")
            SatisDGV.DataSource = dsv.Tables("retrostore")

            TbxDepoID.Text = ""
            TxtSatisMiktr.Text = ""
            TbxSatisTutari.Text = ""
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
        If TbxDepoID.Text <> "" Then
            komut.CommandText = "SELECT * FROM Satis_Tablosu WHERE Depo_ID = @DepoID"
            komut.Parameters.AddWithValue("@DepoID", TbxDepoID.Text)

            Try
                Dim adaptor As New SqlDataAdapter(komut)
                adaptor.Fill(dsv, "retrostore")
                SatisDGV.DataSource = dsv.Tables("retrostore")
            Catch ex As SqlException
                MessageBox.Show("Hata: " & ex.Message)
            End Try

            TbxDepoID.Text = ""
            TxtSatisMiktr.Text = ""
            TbxSatisTutari.Text = ""
        Else
            MessageBox.Show("Lütfen bir Depo_ID girin.")
        End If
        baglanti.Close()
    End Sub

    Private Sub ListeleBtn_Click(sender As Object, e As EventArgs) Handles ListeleBtn.Click
        Dim baglanti As SqlConnection = New SqlConnection
        Dim dsv As New DataSet
        baglanti.ConnectionString = SqlBaglantiCumlesi()
        baglanti.Open()
        Dim komut As SqlCommand = New SqlCommand

        komut.Connection = baglanti
        komut.CommandText = "SELECT * FROM Satis_Tablosu"

        Try
            Dim adaptor As New SqlDataAdapter(komut)
            adaptor.Fill(dsv, "retrostore")
            SatisDGV.DataSource = dsv.Tables("retrostore")
        Catch ex As SqlException
            MessageBox.Show("Hata: " & ex.Message)
        End Try

        baglanti.Close()
    End Sub













End Class