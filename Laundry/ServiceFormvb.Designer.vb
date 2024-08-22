<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ServiceFormvb
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
        Me.Button12 = New System.Windows.Forms.Button()
        Me.Button13 = New System.Windows.Forms.Button()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.numdurasi = New System.Windows.Forms.NumericUpDown()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.cbkategori = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgservice = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.cbunit = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.numprice = New System.Windows.Forms.NumericUpDown()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.gbform = New System.Windows.Forms.GroupBox()
        Me.gbbutton = New System.Windows.Forms.GroupBox()
        CType(Me.numdurasi, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgservice, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numprice, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbform.SuspendLayout()
        Me.gbbutton.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(721, 116)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(92, 41)
        Me.Button12.TabIndex = 97
        Me.Button12.Text = "Cancel"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(611, 116)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(92, 41)
        Me.Button13.TabIndex = 96
        Me.Button13.Text = "Save"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'Button11
        '
        Me.Button11.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button11.Location = New System.Drawing.Point(240, 19)
        Me.Button11.Name = "Button11"
        Me.Button11.Size = New System.Drawing.Size(92, 41)
        Me.Button11.TabIndex = 95
        Me.Button11.Text = "Delete"
        Me.Button11.UseVisualStyleBackColor = False
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(127, 19)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(92, 41)
        Me.Button9.TabIndex = 94
        Me.Button9.Text = "Update"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'Button10
        '
        Me.Button10.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button10.Location = New System.Drawing.Point(17, 19)
        Me.Button10.Name = "Button10"
        Me.Button10.Size = New System.Drawing.Size(92, 41)
        Me.Button10.TabIndex = 93
        Me.Button10.Text = "Insert"
        Me.Button10.UseVisualStyleBackColor = False
        '
        'numdurasi
        '
        Me.numdurasi.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numdurasi.Location = New System.Drawing.Point(540, 62)
        Me.numdurasi.Name = "numdurasi"
        Me.numdurasi.Size = New System.Drawing.Size(248, 26)
        Me.numdurasi.TabIndex = 90
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(413, 65)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(111, 24)
        Me.Label13.TabIndex = 87
        Me.Label13.Text = "Est Duration"
        '
        'cbkategori
        '
        Me.cbkategori.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbkategori.FormattingEnabled = True
        Me.cbkategori.Location = New System.Drawing.Point(148, 60)
        Me.cbkategori.Name = "cbkategori"
        Me.cbkategori.Size = New System.Drawing.Size(248, 28)
        Me.cbkategori.TabIndex = 84
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(17, 60)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(85, 24)
        Me.Label10.TabIndex = 83
        Me.Label10.Text = "Category"
        '
        'tbname
        '
        Me.tbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbname.Location = New System.Drawing.Point(148, 25)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(248, 29)
        Me.tbname.TabIndex = 75
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(17, 28)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(129, 24)
        Me.Label5.TabIndex = 74
        Me.Label5.Text = "Service Name"
        '
        'dgservice
        '
        Me.dgservice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgservice.Location = New System.Drawing.Point(60, 126)
        Me.dgservice.Name = "dgservice"
        Me.dgservice.Size = New System.Drawing.Size(902, 215)
        Me.dgservice.TabIndex = 72
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(203, 44)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(187, 29)
        Me.Label4.TabIndex = 71
        Me.Label4.Text = "Manage Service"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(683, 83)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 31)
        Me.Button8.TabIndex = 70
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'tbCari
        '
        Me.tbCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCari.Location = New System.Drawing.Point(772, 85)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(189, 26)
        Me.tbCari.TabIndex = 69
        '
        'cbunit
        '
        Me.cbunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbunit.FormattingEnabled = True
        Me.cbunit.Location = New System.Drawing.Point(148, 94)
        Me.cbunit.Name = "cbunit"
        Me.cbunit.Size = New System.Drawing.Size(248, 28)
        Me.cbunit.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(17, 94)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Unit"
        '
        'numprice
        '
        Me.numprice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numprice.Location = New System.Drawing.Point(540, 30)
        Me.numprice.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numprice.Name = "numprice"
        Me.numprice.Size = New System.Drawing.Size(248, 26)
        Me.numprice.TabIndex = 101
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(413, 33)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 24)
        Me.Label7.TabIndex = 100
        Me.Label7.Text = "Price"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(801, 33)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(86, 24)
        Me.Label8.TabIndex = 102
        Me.Label8.Text = "/ Per Unit"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(801, 61)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(73, 24)
        Me.Label9.TabIndex = 103
        Me.Label9.Text = "Hour(s)"
        '
        'gbform
        '
        Me.gbform.Controls.Add(Me.Label9)
        Me.gbform.Controls.Add(Me.numprice)
        Me.gbform.Controls.Add(Me.Label8)
        Me.gbform.Controls.Add(Me.Label5)
        Me.gbform.Controls.Add(Me.tbname)
        Me.gbform.Controls.Add(Me.Label7)
        Me.gbform.Controls.Add(Me.Label10)
        Me.gbform.Controls.Add(Me.cbunit)
        Me.gbform.Controls.Add(Me.cbkategori)
        Me.gbform.Controls.Add(Me.Label3)
        Me.gbform.Controls.Add(Me.Label13)
        Me.gbform.Controls.Add(Me.Button12)
        Me.gbform.Controls.Add(Me.numdurasi)
        Me.gbform.Controls.Add(Me.Button13)
        Me.gbform.Location = New System.Drawing.Point(60, 387)
        Me.gbform.Name = "gbform"
        Me.gbform.Size = New System.Drawing.Size(901, 172)
        Me.gbform.TabIndex = 104
        Me.gbform.TabStop = False
        Me.gbform.Text = "GroupBox1"
        '
        'gbbutton
        '
        Me.gbbutton.Controls.Add(Me.Button11)
        Me.gbbutton.Controls.Add(Me.Button9)
        Me.gbbutton.Controls.Add(Me.Button10)
        Me.gbbutton.Location = New System.Drawing.Point(329, 582)
        Me.gbbutton.Name = "gbbutton"
        Me.gbbutton.Size = New System.Drawing.Size(349, 77)
        Me.gbbutton.TabIndex = 105
        Me.gbbutton.TabStop = False
        Me.gbbutton.Text = "GroupBox1"
        '
        'ServiceFormvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 751)
        Me.Controls.Add(Me.dgservice)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.gbform)
        Me.Controls.Add(Me.gbbutton)
        Me.Name = "ServiceFormvb"
        Me.Text = "ServiceFormvb"
        CType(Me.numdurasi, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgservice, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numprice, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbform.ResumeLayout(False)
        Me.gbform.PerformLayout()
        Me.gbbutton.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents numdurasi As NumericUpDown
    Friend WithEvents Label13 As Label
    Friend WithEvents cbkategori As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents tbname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents dgservice As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents tbCari As TextBox
    Friend WithEvents cbunit As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents numprice As NumericUpDown
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label9 As Label
    Friend WithEvents gbform As GroupBox
    Friend WithEvents gbbutton As GroupBox
End Class
