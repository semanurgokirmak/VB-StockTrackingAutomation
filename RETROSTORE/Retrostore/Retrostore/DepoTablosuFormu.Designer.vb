<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DepoTablosuFormu
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
        Me.ListeleBtn = New System.Windows.Forms.Button()
        Me.GuncelleBtn = New System.Windows.Forms.Button()
        Me.DgvDepo = New System.Windows.Forms.DataGridView()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.TbxUrunID = New System.Windows.Forms.TextBox()
        Me.TbxUrunAdedi = New System.Windows.Forms.TextBox()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DgvDepo, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(83, 16)
        Me.Label2.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(74, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Ürün ID"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(59, 65)
        Me.Label3.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(102, 20)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Ürün Adedi"
        '
        'ListeleBtn
        '
        Me.ListeleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.ListeleBtn.ForeColor = System.Drawing.Color.Black
        Me.ListeleBtn.Location = New System.Drawing.Point(228, 399)
        Me.ListeleBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.ListeleBtn.Name = "ListeleBtn"
        Me.ListeleBtn.Size = New System.Drawing.Size(209, 66)
        Me.ListeleBtn.TabIndex = 24
        Me.ListeleBtn.Text = "Listele"
        Me.ListeleBtn.UseVisualStyleBackColor = False
        '
        'GuncelleBtn
        '
        Me.GuncelleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.GuncelleBtn.ForeColor = System.Drawing.Color.Black
        Me.GuncelleBtn.Location = New System.Drawing.Point(228, 325)
        Me.GuncelleBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.GuncelleBtn.Name = "GuncelleBtn"
        Me.GuncelleBtn.Size = New System.Drawing.Size(209, 66)
        Me.GuncelleBtn.TabIndex = 23
        Me.GuncelleBtn.Text = "Güncelle"
        Me.GuncelleBtn.UseVisualStyleBackColor = False
        '
        'DgvDepo
        '
        Me.DgvDepo.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.DgvDepo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DgvDepo.Location = New System.Drawing.Point(2, 110)
        Me.DgvDepo.Margin = New System.Windows.Forms.Padding(4)
        Me.DgvDepo.Name = "DgvDepo"
        Me.DgvDepo.RowHeadersWidth = 51
        Me.DgvDepo.RowTemplate.Height = 24
        Me.DgvDepo.Size = New System.Drawing.Size(425, 192)
        Me.DgvDepo.TabIndex = 21
        '
        'KaydetBtn
        '
        Me.KaydetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.KaydetBtn.ForeColor = System.Drawing.Color.Black
        Me.KaydetBtn.Location = New System.Drawing.Point(2, 325)
        Me.KaydetBtn.Margin = New System.Windows.Forms.Padding(4)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(209, 66)
        Me.KaydetBtn.TabIndex = 19
        Me.KaydetBtn.Text = "Kaydet"
        Me.KaydetBtn.UseVisualStyleBackColor = False
        '
        'TbxUrunID
        '
        Me.TbxUrunID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxUrunID.Location = New System.Drawing.Point(165, 13)
        Me.TbxUrunID.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxUrunID.Name = "TbxUrunID"
        Me.TbxUrunID.Size = New System.Drawing.Size(136, 27)
        Me.TbxUrunID.TabIndex = 27
        '
        'TbxUrunAdedi
        '
        Me.TbxUrunAdedi.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxUrunAdedi.Location = New System.Drawing.Point(165, 66)
        Me.TbxUrunAdedi.Margin = New System.Windows.Forms.Padding(4)
        Me.TbxUrunAdedi.Name = "TbxUrunAdedi"
        Me.TbxUrunAdedi.Size = New System.Drawing.Size(136, 27)
        Me.TbxUrunAdedi.TabIndex = 28
        '
        'AraBtn
        '
        Me.AraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AraBtn.ForeColor = System.Drawing.Color.Black
        Me.AraBtn.Location = New System.Drawing.Point(-2, 399)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(209, 61)
        Me.AraBtn.TabIndex = 29
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.UseVisualStyleBackColor = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(474, 394)
        Me.Button1.Margin = New System.Windows.Forms.Padding(4)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(156, 66)
        Me.Button1.TabIndex = 30
        Me.Button1.Text = "Satış Bilgileri Tablosuna Geç"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'DepoTablosuFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(632, 467)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.AraBtn)
        Me.Controls.Add(Me.TbxUrunAdedi)
        Me.Controls.Add(Me.TbxUrunID)
        Me.Controls.Add(Me.ListeleBtn)
        Me.Controls.Add(Me.GuncelleBtn)
        Me.Controls.Add(Me.DgvDepo)
        Me.Controls.Add(Me.KaydetBtn)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "DepoTablosuFormu"
        Me.Text = "Depo Tablosu Formu"
        CType(Me.DgvDepo, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents ListeleBtn As Button
    Friend WithEvents GuncelleBtn As Button
    Friend WithEvents DgvDepo As DataGridView
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents TbxUrunID As TextBox
    Friend WithEvents TbxUrunAdedi As TextBox
    Friend WithEvents AraBtn As Button
    Friend WithEvents Button1 As Button
End Class
