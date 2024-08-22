<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class AddCustomerForm
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
        Me.tbalamat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.tbhp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Button9 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(198, 51)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(201, 33)
        Me.Label4.TabIndex = 112
        Me.Label4.Text = "Add Customer"
        '
        'tbalamat
        '
        Me.tbalamat.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbalamat.Location = New System.Drawing.Point(245, 214)
        Me.tbalamat.Multiline = True
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(253, 89)
        Me.tbalamat.TabIndex = 120
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(89, 214)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 119
        Me.Label9.Text = "Address"
        '
        'tbname
        '
        Me.tbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbname.Location = New System.Drawing.Point(245, 144)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(253, 29)
        Me.tbname.TabIndex = 118
        '
        'tbhp
        '
        Me.tbhp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbhp.Location = New System.Drawing.Point(245, 179)
        Me.tbhp.Name = "tbhp"
        Me.tbhp.Size = New System.Drawing.Size(253, 29)
        Me.tbhp.TabIndex = 117
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(89, 179)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 24)
        Me.Label7.TabIndex = 116
        Me.Label7.Text = "Handphone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(89, 144)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(147, 24)
        Me.Label8.TabIndex = 115
        Me.Label8.Text = "Customer Name"
        '
        'Button9
        '
        Me.Button9.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button9.Location = New System.Drawing.Point(407, 320)
        Me.Button9.Name = "Button9"
        Me.Button9.Size = New System.Drawing.Size(91, 36)
        Me.Button9.TabIndex = 133
        Me.Button9.Text = "Submit"
        Me.Button9.UseVisualStyleBackColor = False
        '
        'AddCustomerForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(625, 406)
        Me.Controls.Add(Me.Button9)
        Me.Controls.Add(Me.tbalamat)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.tbname)
        Me.Controls.Add(Me.tbhp)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Label4)
        Me.Name = "AddCustomerForm"
        Me.Text = "AddCustomerForm"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label4 As Label
    Friend WithEvents tbalamat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents tbname As TextBox
    Friend WithEvents tbhp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Button9 As Button
End Class
