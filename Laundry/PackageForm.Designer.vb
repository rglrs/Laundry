<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PackageForm
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
        Me.cbservice = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dgpackage = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.numtotal = New System.Windows.Forms.NumericUpDown()
        Me.numunit = New System.Windows.Forms.NumericUpDown()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbbutton = New System.Windows.Forms.GroupBox()
        Me.Button11 = New System.Windows.Forms.Button()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.Button10 = New System.Windows.Forms.Button()
        Me.gbform = New System.Windows.Forms.GroupBox()
        CType(Me.dgpackage, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numtotal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numunit, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbbutton.SuspendLayout()
        Me.gbform.SuspendLayout()
        Me.SuspendLayout()
        '
        'Button12
        '
        Me.Button12.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button12.Location = New System.Drawing.Point(404, 93)
        Me.Button12.Name = "Button12"
        Me.Button12.Size = New System.Drawing.Size(92, 41)
        Me.Button12.TabIndex = 96
        Me.Button12.Text = "Cancel"
        Me.Button12.UseVisualStyleBackColor = False
        '
        'Button13
        '
        Me.Button13.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button13.Location = New System.Drawing.Point(404, 36)
        Me.Button13.Name = "Button13"
        Me.Button13.Size = New System.Drawing.Size(92, 41)
        Me.Button13.TabIndex = 95
        Me.Button13.Text = "Save"
        Me.Button13.UseVisualStyleBackColor = False
        '
        'cbservice
        '
        Me.cbservice.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbservice.FormattingEnabled = True
        Me.cbservice.Location = New System.Drawing.Point(123, 36)
        Me.cbservice.Name = "cbservice"
        Me.cbservice.Size = New System.Drawing.Size(248, 28)
        Me.cbservice.TabIndex = 83
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(10, 68)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(88, 24)
        Me.Label10.TabIndex = 82
        Me.Label10.Text = "Total Unit"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(10, 36)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 24)
        Me.Label5.TabIndex = 73
        Me.Label5.Text = "Service"
        '
        'dgpackage
        '
        Me.dgpackage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgpackage.Location = New System.Drawing.Point(144, 123)
        Me.dgpackage.Name = "dgpackage"
        Me.dgpackage.Size = New System.Drawing.Size(627, 215)
        Me.dgpackage.TabIndex = 71
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(200, 57)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(200, 29)
        Me.Label4.TabIndex = 70
        Me.Label4.Text = "Manage Package"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(493, 80)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 31)
        Me.Button8.TabIndex = 69
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'tbCari
        '
        Me.tbCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCari.Location = New System.Drawing.Point(582, 82)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(189, 26)
        Me.tbCari.TabIndex = 68
        '
        'numtotal
        '
        Me.numtotal.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numtotal.Location = New System.Drawing.Point(123, 70)
        Me.numtotal.Name = "numtotal"
        Me.numtotal.Size = New System.Drawing.Size(248, 26)
        Me.numtotal.TabIndex = 97
        '
        'numunit
        '
        Me.numunit.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numunit.Location = New System.Drawing.Point(123, 102)
        Me.numunit.Maximum = New Decimal(New Integer() {100000, 0, 0, 0})
        Me.numunit.Name = "numunit"
        Me.numunit.Size = New System.Drawing.Size(248, 26)
        Me.numunit.TabIndex = 99
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(10, 100)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(42, 24)
        Me.Label3.TabIndex = 98
        Me.Label3.Text = "Unit"
        '
        'gbbutton
        '
        Me.gbbutton.Controls.Add(Me.Button11)
        Me.gbbutton.Controls.Add(Me.Button9)
        Me.gbbutton.Controls.Add(Me.Button10)
        Me.gbbutton.Location = New System.Drawing.Point(293, 570)
        Me.gbbutton.Name = "gbbutton"
        Me.gbbutton.Size = New System.Drawing.Size(349, 77)
        Me.gbbutton.TabIndex = 106
        Me.gbbutton.TabStop = False
        Me.gbbutton.Text = "GroupBox1"
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
        'gbform
        '
        Me.gbform.Controls.Add(Me.cbservice)
        Me.gbform.Controls.Add(Me.numunit)
        Me.gbform.Controls.Add(Me.Label3)
        Me.gbform.Controls.Add(Me.Label5)
        Me.gbform.Controls.Add(Me.numtotal)
        Me.gbform.Controls.Add(Me.Button12)
        Me.gbform.Controls.Add(Me.Label10)
        Me.gbform.Controls.Add(Me.Button13)
        Me.gbform.Location = New System.Drawing.Point(205, 358)
        Me.gbform.Name = "gbform"
        Me.gbform.Size = New System.Drawing.Size(502, 172)
        Me.gbform.TabIndex = 107
        Me.gbform.TabStop = False
        Me.gbform.Text = "GroupBox1"
        '
        'PackageForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 751)
        Me.Controls.Add(Me.gbbutton)
        Me.Controls.Add(Me.dgpackage)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.gbform)
        Me.Name = "PackageForm"
        Me.Text = "PackageForm"
        CType(Me.dgpackage, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numtotal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numunit, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbbutton.ResumeLayout(False)
        Me.gbform.ResumeLayout(False)
        Me.gbform.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Button12 As Button
    Friend WithEvents Button13 As Button
    Friend WithEvents cbservice As ComboBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents dgpackage As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents tbCari As TextBox
    Friend WithEvents numtotal As NumericUpDown
    Friend WithEvents numunit As NumericUpDown
    Friend WithEvents Label3 As Label
    Friend WithEvents gbbutton As GroupBox
    Friend WithEvents Button11 As Button
    Friend WithEvents Button9 As Button
    Friend WithEvents Button10 As Button
    Friend WithEvents gbform As GroupBox
End Class
