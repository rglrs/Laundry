<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ViewTransaction
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
        Me.dgheader = New System.Windows.Forms.DataGridView()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.dgdetail = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dgheader, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgheader
        '
        Me.dgheader.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgheader.Location = New System.Drawing.Point(13, 33)
        Me.dgheader.Name = "dgheader"
        Me.dgheader.Size = New System.Drawing.Size(642, 215)
        Me.dgheader.TabIndex = 112
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(143, 33)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(198, 29)
        Me.Label4.TabIndex = 111
        Me.Label4.Text = "View Transaction"
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(497, 78)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 31)
        Me.Button8.TabIndex = 110
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'tbCari
        '
        Me.tbCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCari.Location = New System.Drawing.Point(586, 80)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(189, 26)
        Me.tbCari.TabIndex = 109
        '
        'dgdetail
        '
        Me.dgdetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgdetail.Location = New System.Drawing.Point(13, 23)
        Me.dgdetail.Name = "dgdetail"
        Me.dgdetail.Size = New System.Drawing.Size(642, 215)
        Me.dgdetail.TabIndex = 126
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dgheader)
        Me.GroupBox1.Location = New System.Drawing.Point(135, 121)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(661, 269)
        Me.GroupBox1.TabIndex = 127
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Header Deposite"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dgdetail)
        Me.GroupBox2.Location = New System.Drawing.Point(135, 413)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(661, 244)
        Me.GroupBox2.TabIndex = 128
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Detail Deposite"
        '
        'ViewTransaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 751)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "ViewTransaction"
        Me.Text = "ViewTransaction"
        CType(Me.dgheader, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.dgdetail, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgheader As DataGridView
    Friend WithEvents Label4 As Label
    Friend WithEvents Button8 As Button
    Friend WithEvents tbCari As TextBox
    Friend WithEvents dgdetail As DataGridView
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
End Class
