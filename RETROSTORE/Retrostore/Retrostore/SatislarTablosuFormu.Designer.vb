<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class SatislarTablosuFormu
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
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TxtSatisMiktr = New System.Windows.Forms.TextBox()
        Me.TbxSatisTutari = New System.Windows.Forms.TextBox()
        Me.AraBtn = New System.Windows.Forms.Button()
        Me.ListeleBtn = New System.Windows.Forms.Button()
        Me.GuncelleBtn = New System.Windows.Forms.Button()
        Me.SatisDGV = New System.Windows.Forms.DataGridView()
        Me.KaydetBtn = New System.Windows.Forms.Button()
        Me.TbxDepoID = New System.Windows.Forms.TextBox()
        CType(Me.SatisDGV, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(148, 24)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(78, 20)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Depo ID"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(138, 72)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(115, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Satış Miktarı"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(138, 126)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(104, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Satış Fiyatı"
        '
        'TxtSatisMiktr
        '
        Me.TxtSatisMiktr.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TxtSatisMiktr.Location = New System.Drawing.Point(276, 72)
        Me.TxtSatisMiktr.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TxtSatisMiktr.Name = "TxtSatisMiktr"
        Me.TxtSatisMiktr.Size = New System.Drawing.Size(158, 24)
        Me.TxtSatisMiktr.TabIndex = 8
        '
        'TbxSatisTutari
        '
        Me.TbxSatisTutari.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxSatisTutari.Location = New System.Drawing.Point(276, 126)
        Me.TbxSatisTutari.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TbxSatisTutari.Name = "TbxSatisTutari"
        Me.TbxSatisTutari.Size = New System.Drawing.Size(158, 24)
        Me.TbxSatisTutari.TabIndex = 9
        '
        'AraBtn
        '
        Me.AraBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.AraBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.AraBtn.ForeColor = System.Drawing.Color.Black
        Me.AraBtn.Location = New System.Drawing.Point(288, 239)
        Me.AraBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.AraBtn.Name = "AraBtn"
        Me.AraBtn.Size = New System.Drawing.Size(103, 50)
        Me.AraBtn.TabIndex = 25
        Me.AraBtn.Text = "Ara"
        Me.AraBtn.UseVisualStyleBackColor = False
        '
        'ListeleBtn
        '
        Me.ListeleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.ListeleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ListeleBtn.ForeColor = System.Drawing.Color.Black
        Me.ListeleBtn.Location = New System.Drawing.Point(161, 239)
        Me.ListeleBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.ListeleBtn.Name = "ListeleBtn"
        Me.ListeleBtn.Size = New System.Drawing.Size(103, 50)
        Me.ListeleBtn.TabIndex = 24
        Me.ListeleBtn.Text = "Listele"
        Me.ListeleBtn.UseVisualStyleBackColor = False
        '
        'GuncelleBtn
        '
        Me.GuncelleBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.GuncelleBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.GuncelleBtn.ForeColor = System.Drawing.Color.Black
        Me.GuncelleBtn.Location = New System.Drawing.Point(288, 169)
        Me.GuncelleBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GuncelleBtn.Name = "GuncelleBtn"
        Me.GuncelleBtn.Size = New System.Drawing.Size(103, 55)
        Me.GuncelleBtn.TabIndex = 23
        Me.GuncelleBtn.Text = "Güncelle"
        Me.GuncelleBtn.UseVisualStyleBackColor = False
        '
        'SatisDGV
        '
        Me.SatisDGV.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.SatisDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.SatisDGV.Location = New System.Drawing.Point(17, 301)
        Me.SatisDGV.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.SatisDGV.Name = "SatisDGV"
        Me.SatisDGV.RowHeadersWidth = 51
        Me.SatisDGV.RowTemplate.Height = 24
        Me.SatisDGV.Size = New System.Drawing.Size(561, 192)
        Me.SatisDGV.TabIndex = 21
        '
        'KaydetBtn
        '
        Me.KaydetBtn.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.KaydetBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.KaydetBtn.ForeColor = System.Drawing.Color.Black
        Me.KaydetBtn.Location = New System.Drawing.Point(161, 169)
        Me.KaydetBtn.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.KaydetBtn.Name = "KaydetBtn"
        Me.KaydetBtn.Size = New System.Drawing.Size(103, 55)
        Me.KaydetBtn.TabIndex = 19
        Me.KaydetBtn.Text = "Kaydet"
        Me.KaydetBtn.UseVisualStyleBackColor = False
        '
        'TbxDepoID
        '
        Me.TbxDepoID.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.TbxDepoID.Location = New System.Drawing.Point(276, 24)
        Me.TbxDepoID.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.TbxDepoID.Name = "TbxDepoID"
        Me.TbxDepoID.Size = New System.Drawing.Size(158, 24)
        Me.TbxDepoID.TabIndex = 7
        '
        'SatislarTablosuFormu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 18.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(580, 506)
        Me.Controls.Add(Me.AraBtn)
        Me.Controls.Add(Me.ListeleBtn)
        Me.Controls.Add(Me.GuncelleBtn)
        Me.Controls.Add(Me.SatisDGV)
        Me.Controls.Add(Me.KaydetBtn)
        Me.Controls.Add(Me.TbxSatisTutari)
        Me.Controls.Add(Me.TxtSatisMiktr)
        Me.Controls.Add(Me.TbxDepoID)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label2)
        Me.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(162, Byte))
        Me.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "SatislarTablosuFormu"
        Me.Text = "Satışlar Tablosu Formu"
        CType(Me.SatisDGV, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents TxtSatisMiktr As TextBox
    Friend WithEvents TbxSatisTutari As TextBox
    Friend WithEvents AraBtn As Button
    Friend WithEvents ListeleBtn As Button
    Friend WithEvents GuncelleBtn As Button
    Friend WithEvents SatisDGV As DataGridView
    Friend WithEvents KaydetBtn As Button
    Friend WithEvents TbxDepoID As TextBox
End Class
