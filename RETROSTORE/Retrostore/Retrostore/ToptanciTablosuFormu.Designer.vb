<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ToptanciTablosuFormu
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TbxTopAdi = New System.Windows.Forms.TextBox()
        Me.TbxTopWeb = New System.Windows.Forms.TextBox()
        Me.TbxTopTel = New System.Windows.Forms.TextBox()
        Me.ToptanciDGV = New System.Windows.Forms.DataGridView()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.ListeleBtn = New System.Windows.Forms.Button()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.GuncelleBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.ToptanciDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(12, 14)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(114, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Toptancı Adı"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(8, 69)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Toptancı Websitesi"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(8, 119)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(149, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Toptancı Telefon"
        '
        'TbxTopAdi
        '
        Me.TbxTopAdi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxTopAdi.Location = New System.Drawing.Point(193, 12)
        Me.TbxTopAdi.Name = "TbxTopAdi"
        Me.TbxTopAdi.Size = New System.Drawing.Size(149, 22)
        Me.TbxTopAdi.TabIndex = 6
        '
        'TbxTopWeb
        '
        Me.TbxTopWeb.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxTopWeb.Location = New System.Drawing.Point(193, 69)
        Me.TbxTopWeb.Name = "TbxTopWeb"
        Me.TbxTopWeb.Size = New System.Drawing.Size(149, 22)
        Me.TbxTopWeb.TabIndex = 7
        '
        'TbxTopTel
        '
        Me.TbxTopTel.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxTopTel.Location = New System.Drawing.Point(193, 124)
        Me.TbxTopTel.Name = "TbxTopTel"
        Me.TbxTopTel.Size = New System.Drawing.Size(149, 22)
        Me.TbxTopTel.TabIndex = 8
        '
        'ToptanciDGV
        '
        Me.ToptanciDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ToptanciDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.ToptanciDGV.Location = New System.Drawing.Point(12, 174)
        Me.ToptanciDGV.Name = "ToptanciDGV"
        Me.ToptanciDGV.RowHeadersWidth = 51
        Me.ToptanciDGV.RowTemplate.Height = 24
        Me.ToptanciDGV.Size = New System.Drawing.Size(554, 162)
        Me.ToptanciDGV.TabIndex = 21
        '
        'KaydetBtn
        '
        Me.KaydetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KaydetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.KaydetBtn.Location = New System.Drawing.Point(360, 21)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(146, 52)
        Me.KaydetBtn.TabIndex = 19
        Me.KaydetBtn.Text = "Kaydet"
        Me.KaydetBtn.UseVisualStyleBackColor = False
        '
        'ListeleBtn
        '
        Me.ListeleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListeleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListeleBtn.Location = New System.Drawing.Point(358, 103)
        Me.ListeleBtn.Name = "ListeleBtn"
        Me.ListeleBtn.Size = New System.Drawing.Size(146, 52)
        Me.ListeleBtn.TabIndex = 24
        Me.ListeleBtn.Text = "Listele"
        Me.ListeleBtn.UseVisualStyleBackColor = False
        '
        'AraBtn
        '
        Me.AraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AraBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AraBtn.Location = New System.Drawing.Point(530, 105)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(153, 52)
        Me.AraBtn.TabIndex = 25
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.UseVisualStyleBackColor = False
        '
        'GuncelleBtn
        '
        Me.GuncelleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GuncelleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GuncelleBtn.Location = New System.Drawing.Point(530, 23)
        Me.GuncelleBtn.Name = "GuncelleBtn"
        Me.GuncelleBtn.Size = New System.Drawing.Size(153, 52)
        Me.GuncelleBtn.TabIndex = 23
        Me.GuncelleBtn.Text = "Güncelle"
        Me.GuncelleBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Button1.Location = New System.Drawing.Point(579, 213)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(104, 92)
        Me.Button1.TabIndex = 26
        Me.Button1.Text = "Depo Bilgileri Tablosuna Geç"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'ToptanciTablosuFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(695, 360)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AraBtn)
        Me.Controls.Add(Me.ListeleBtn)
        Me.Controls.Add(Me.GuncelleBtn)
        Me.Controls.Add(Me.ToptanciDGV)
        Me.Controls.Add(Me.KaydetBtn)
        Me.Controls.Add(Me.TbxTopTel)
        Me.Controls.Add(Me.TbxTopWeb)
        Me.Controls.Add(Me.TbxTopAdi)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Name = "ToptanciTablosuFormu"
        Me.Text = "Toptancı Tablosu Formu"
        CType(Me.ToptanciDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents TbxTopAdi As TextBox
    Friend WithEvents TbxTopWeb As TextBox
    Friend WithEvents TbxTopTel As TextBox
    Friend WithEvents ToptanciDGV As DataGridView
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents ListeleBtn As Button
    Friend WithEvents AraBtn As Button
    Friend WithEvents GuncelleBtn As Button
    Friend WithEvents Button1 As Button
End Class
