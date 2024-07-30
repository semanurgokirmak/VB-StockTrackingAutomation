<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AlisTablosuFormu
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TxtAlisMiktr = New System.Windows.Forms.TextBox()
        Me.TbxAlisFyt = New System.Windows.Forms.TextBox()
        Me.DtpAlisTarihi = New System.Windows.Forms.DateTimePicker()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.AlisDgv = New System.Windows.Forms.DataGridView()
        Me.GuncelleBtn = New System.Windows.Forms.Button()
        Me.ListeleBtn = New System.Windows.Forms.Button()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.TbxUrunID = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TbxToptanciID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.AlisDgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(28, 123)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(101, 22)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Alış Tarihi"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(21, 181)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(108, 22)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "Alış Miktarı"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(21, 233)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(98, 22)
        Me.Label6.TabIndex = 5
        Me.Label6.Text = "Alış Fiyatı"
        '
        'TxtAlisMiktr
        '
        Me.TxtAlisMiktr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtAlisMiktr.Location = New System.Drawing.Point(164, 183)
        Me.TxtAlisMiktr.Name = "TxtAlisMiktr"
        Me.TxtAlisMiktr.Size = New System.Drawing.Size(140, 22)
        Me.TxtAlisMiktr.TabIndex = 9
        '
        'TbxAlisFyt
        '
        Me.TbxAlisFyt.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxAlisFyt.Location = New System.Drawing.Point(164, 235)
        Me.TbxAlisFyt.Name = "TbxAlisFyt"
        Me.TbxAlisFyt.Size = New System.Drawing.Size(140, 22)
        Me.TbxAlisFyt.TabIndex = 10
        '
        'DtpAlisTarihi
        '
        Me.DtpAlisTarihi.CalendarForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DtpAlisTarihi.CalendarMonthBackground = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DtpAlisTarihi.CalendarTitleBackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DtpAlisTarihi.CalendarTrailingForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DtpAlisTarihi.Location = New System.Drawing.Point(164, 123)
        Me.DtpAlisTarihi.Name = "DtpAlisTarihi"
        Me.DtpAlisTarihi.Size = New System.Drawing.Size(140, 22)
        Me.DtpAlisTarihi.TabIndex = 11
        '
        'KaydetBtn
        '
        Me.KaydetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KaydetBtn.Location = New System.Drawing.Point(329, 18)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(152, 53)
        Me.KaydetBtn.TabIndex = 12
        Me.KaydetBtn.Text = "Kaydet"
        Me.KaydetBtn.UseVisualStyleBackColor = False
        '
        'AlisDgv
        '
        Me.AlisDgv.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AlisDgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.AlisDgv.Location = New System.Drawing.Point(25, 284)
        Me.AlisDgv.Name = "AlisDgv"
        Me.AlisDgv.RowHeadersWidth = 51
        Me.AlisDgv.RowTemplate.Height = 24
        Me.AlisDgv.Size = New System.Drawing.Size(610, 150)
        Me.AlisDgv.TabIndex = 14
        '
        'GuncelleBtn
        '
        Me.GuncelleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GuncelleBtn.Location = New System.Drawing.Point(329, 157)
        Me.GuncelleBtn.Name = "GuncelleBtn"
        Me.GuncelleBtn.Size = New System.Drawing.Size(152, 45)
        Me.GuncelleBtn.TabIndex = 16
        Me.GuncelleBtn.Text = "Güncelle"
        Me.GuncelleBtn.UseVisualStyleBackColor = False
        '
        'ListeleBtn
        '
        Me.ListeleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListeleBtn.Location = New System.Drawing.Point(329, 90)
        Me.ListeleBtn.Name = "ListeleBtn"
        Me.ListeleBtn.Size = New System.Drawing.Size(152, 45)
        Me.ListeleBtn.TabIndex = 17
        Me.ListeleBtn.Text = "Listele"
        Me.ListeleBtn.UseVisualStyleBackColor = False
        '
        'AraBtn
        '
        Me.AraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AraBtn.Location = New System.Drawing.Point(329, 224)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(152, 45)
        Me.AraBtn.TabIndex = 18
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.UseVisualStyleBackColor = False
        '
        'TbxUrunID
        '
        Me.TbxUrunID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxUrunID.Location = New System.Drawing.Point(164, 26)
        Me.TbxUrunID.Name = "TbxUrunID"
        Me.TbxUrunID.Size = New System.Drawing.Size(140, 22)
        Me.TbxUrunID.TabIndex = 20
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(21, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 22)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Ürün ID"
        '
        'TbxToptanciID
        '
        Me.TbxToptanciID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxToptanciID.Location = New System.Drawing.Point(164, 71)
        Me.TbxToptanciID.Name = "TbxToptanciID"
        Me.TbxToptanciID.Size = New System.Drawing.Size(140, 22)
        Me.TbxToptanciID.TabIndex = 22
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(21, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 22)
        Me.Label2.TabIndex = 21
        Me.Label2.Text = "Toptancı ID"
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.Location = New System.Drawing.Point(487, 210)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(152, 68)
        Me.Button1.TabIndex = 23
        Me.Button1.Text = "Toptancı Bilgileri Tablosuna Geç"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'AlisTablosuFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(649, 446)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TbxToptanciID)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TbxUrunID)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AraBtn)
        Me.Controls.Add(Me.ListeleBtn)
        Me.Controls.Add(Me.GuncelleBtn)
        Me.Controls.Add(Me.AlisDgv)
        Me.Controls.Add(Me.KaydetBtn)
        Me.Controls.Add(Me.DtpAlisTarihi)
        Me.Controls.Add(Me.TbxAlisFyt)
        Me.Controls.Add(Me.TxtAlisMiktr)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Name = "AlisTablosuFormu"
        Me.Text = "Alış Tablosu Formu"
        CType(Me.AlisDgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents TxtAlisMiktr As TextBox
    Friend WithEvents TbxAlisFyt As TextBox
    Friend WithEvents DtpAlisTarihi As DateTimePicker
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents AlisDgv As DataGridView
    Friend WithEvents GuncelleBtn As Button
    Friend WithEvents ListeleBtn As Button
    Friend WithEvents AraBtn As Button
    Friend WithEvents TbxUrunID As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TbxToptanciID As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents Button1 As Button
End Class
