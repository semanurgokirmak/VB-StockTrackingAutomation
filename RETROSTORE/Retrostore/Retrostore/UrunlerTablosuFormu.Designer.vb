<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class UrunlerTablosuFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbxAciklama = New System.Windows.Forms.TextBox()
        Me.CbxKategori = New System.Windows.Forms.ComboBox()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.ListeleBtn = New System.Windows.Forms.Button()
        Me.GuncelleBtn = New System.Windows.Forms.Button()
        Me.UrunlerDGV = New System.Windows.Forms.DataGridView()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.TbxUrunAdi = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.UrunlerDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(2, 88)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(146, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ürün Açıklaması"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(2, 182)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(125, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Ürün Kategori"
        '
        'TbxAciklama
        '
        Me.TbxAciklama.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxAciklama.Location = New System.Drawing.Point(171, 73)
        Me.TbxAciklama.Multiline = True
        Me.TbxAciklama.Name = "TbxAciklama"
        Me.TbxAciklama.Size = New System.Drawing.Size(169, 65)
        Me.TbxAciklama.TabIndex = 7
        '
        'CbxKategori
        '
        Me.CbxKategori.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.CbxKategori.FormattingEnabled = True
        Me.CbxKategori.Location = New System.Drawing.Point(171, 184)
        Me.CbxKategori.Name = "CbxKategori"
        Me.CbxKategori.Size = New System.Drawing.Size(169, 24)
        Me.CbxKategori.TabIndex = 8
        '
        'AraBtn
        '
        Me.AraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AraBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AraBtn.Location = New System.Drawing.Point(260, 252)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(115, 58)
        Me.AraBtn.TabIndex = 25
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.UseVisualStyleBackColor = False
        '
        'ListeleBtn
        '
        Me.ListeleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListeleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListeleBtn.Location = New System.Drawing.Point(381, 252)
        Me.ListeleBtn.Name = "ListeleBtn"
        Me.ListeleBtn.Size = New System.Drawing.Size(106, 58)
        Me.ListeleBtn.TabIndex = 24
        Me.ListeleBtn.Text = "Listele"
        Me.ListeleBtn.UseVisualStyleBackColor = False
        '
        'GuncelleBtn
        '
        Me.GuncelleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GuncelleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GuncelleBtn.Location = New System.Drawing.Point(139, 252)
        Me.GuncelleBtn.Name = "GuncelleBtn"
        Me.GuncelleBtn.Size = New System.Drawing.Size(115, 58)
        Me.GuncelleBtn.TabIndex = 23
        Me.GuncelleBtn.Text = "Güncelle"
        Me.GuncelleBtn.UseVisualStyleBackColor = False
        '
        'UrunlerDGV
        '
        Me.UrunlerDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.UrunlerDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.UrunlerDGV.Location = New System.Drawing.Point(359, 24)
        Me.UrunlerDGV.Name = "UrunlerDGV"
        Me.UrunlerDGV.RowHeadersWidth = 51
        Me.UrunlerDGV.RowTemplate.Height = 24
        Me.UrunlerDGV.Size = New System.Drawing.Size(379, 209)
        Me.UrunlerDGV.TabIndex = 21
        '
        'KaydetBtn
        '
        Me.KaydetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KaydetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.KaydetBtn.Location = New System.Drawing.Point(12, 252)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(121, 58)
        Me.KaydetBtn.TabIndex = 19
        Me.KaydetBtn.Text = "Kaydet"
        Me.KaydetBtn.UseVisualStyleBackColor = False
        '
        'TbxUrunAdi
        '
        Me.TbxUrunAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxUrunAdi.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.TbxUrunAdi.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxUrunAdi.Location = New System.Drawing.Point(171, 24)
        Me.TbxUrunAdi.Name = "TbxUrunAdi"
        Me.TbxUrunAdi.Size = New System.Drawing.Size(169, 27)
        Me.TbxUrunAdi.TabIndex = 27
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(13, 27)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(82, 20)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "Ürün Adı"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(610, 245)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 73)
        Me.Button1.TabIndex = 28
        Me.Button1.Text = "Alış Bilgileri Tablosuna Geç"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'UrunlerTablosuFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(739, 322)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbxUrunAdi)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AraBtn)
        Me.Controls.Add(Me.ListeleBtn)
        Me.Controls.Add(Me.GuncelleBtn)
        Me.Controls.Add(Me.UrunlerDGV)
        Me.Controls.Add(Me.KaydetBtn)
        Me.Controls.Add(Me.CbxKategori)
        Me.Controls.Add(Me.TbxAciklama)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Name = "UrunlerTablosuFormu"
        Me.Text = "Ürünler Tablosu Formu"
        CType(Me.UrunlerDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbxAciklama As TextBox
    Friend WithEvents CbxKategori As ComboBox
    Friend WithEvents AraBtn As Button
    Friend WithEvents ListeleBtn As Button
    Friend WithEvents GuncelleBtn As Button
    Friend WithEvents UrunlerDGV As DataGridView
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents TbxUrunAdi As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button1 As Button
End Class
