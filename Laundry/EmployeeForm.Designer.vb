<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class EmployeeForm
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
        Me.tbCari = New System.Windows.Forms.TextBox()
        Me.Button8 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.dgemploya = New System.Windows.Forms.DataGridView()
        Me.tbname = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.tbemail = New System.Windows.Forms.TextBox()
        Me.tbhp = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.tbalamat = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbtitle = New System.Windows.Forms.ComboBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.tbpas = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.numSalary = New System.Windows.Forms.NumericUpDown()
        Me.tbconfirm = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.btInserrt = New System.Windows.Forms.Button()
        Me.btUpdate = New System.Windows.Forms.Button()
        Me.btDelete = New System.Windows.Forms.Button()
        Me.btCancel = New System.Windows.Forms.Button()
        Me.btSave = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dtDate = New System.Windows.Forms.DateTimePicker()
        CType(Me.dgemploya, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.numSalary, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'tbCari
        '
        Me.tbCari.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbCari.Location = New System.Drawing.Point(664, 61)
        Me.tbCari.Name = "tbCari"
        Me.tbCari.Size = New System.Drawing.Size(189, 26)
        Me.tbCari.TabIndex = 30
        '
        'Button8
        '
        Me.Button8.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.Button8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button8.Location = New System.Drawing.Point(575, 59)
        Me.Button8.Name = "Button8"
        Me.Button8.Size = New System.Drawing.Size(83, 31)
        Me.Button8.TabIndex = 31
        Me.Button8.Text = "Search"
        Me.Button8.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(300, 23)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(158, 24)
        Me.Label4.TabIndex = 32
        Me.Label4.Text = "Manage Employa"
        '
        'dgemploya
        '
        Me.dgemploya.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgemploya.Location = New System.Drawing.Point(85, 102)
        Me.dgemploya.Name = "dgemploya"
        Me.dgemploya.Size = New System.Drawing.Size(768, 215)
        Me.dgemploya.TabIndex = 33
        '
        'tbname
        '
        Me.tbname.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbname.Location = New System.Drawing.Point(125, 18)
        Me.tbname.Name = "tbname"
        Me.tbname.Size = New System.Drawing.Size(248, 29)
        Me.tbname.TabIndex = 36
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(12, 21)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(61, 24)
        Me.Label5.TabIndex = 35
        Me.Label5.Text = "Name"
        '
        'tbemail
        '
        Me.tbemail.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbemail.Location = New System.Drawing.Point(125, 55)
        Me.tbemail.Name = "tbemail"
        Me.tbemail.Size = New System.Drawing.Size(248, 29)
        Me.tbemail.TabIndex = 41
        '
        'tbhp
        '
        Me.tbhp.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbhp.Location = New System.Drawing.Point(125, 90)
        Me.tbhp.Name = "tbhp"
        Me.tbhp.Size = New System.Drawing.Size(248, 29)
        Me.tbhp.TabIndex = 40
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(12, 93)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(111, 24)
        Me.Label7.TabIndex = 39
        Me.Label7.Text = "Handphone"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(12, 58)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(57, 24)
        Me.Label8.TabIndex = 38
        Me.Label8.Text = "Email"
        '
        'tbalamat
        '
        Me.tbalamat.Font = New System.Drawing.Font("Microsoft Tai Le", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbalamat.Location = New System.Drawing.Point(125, 125)
        Me.tbalamat.Multiline = True
        Me.tbalamat.Name = "tbalamat"
        Me.tbalamat.Size = New System.Drawing.Size(248, 92)
        Me.tbalamat.TabIndex = 43
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.Location = New System.Drawing.Point(12, 128)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(80, 24)
        Me.Label9.TabIndex = 42
        Me.Label9.Text = "Address"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.Location = New System.Drawing.Point(12, 227)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(110, 24)
        Me.Label10.TabIndex = 44
        Me.Label10.Text = "Date of Birth"
        '
        'cbtitle
        '
        Me.cbtitle.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cbtitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cbtitle.FormattingEnabled = True
        Me.cbtitle.Location = New System.Drawing.Point(519, 17)
        Me.cbtitle.Name = "cbtitle"
        Me.cbtitle.Size = New System.Drawing.Size(248, 28)
        Me.cbtitle.TabIndex = 47
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(392, 19)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(81, 24)
        Me.Label11.TabIndex = 46
        Me.Label11.Text = "Job Title"
        '
        'tbpas
        '
        Me.tbpas.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbpas.Location = New System.Drawing.Point(519, 90)
        Me.tbpas.Name = "tbpas"
        Me.tbpas.Size = New System.Drawing.Size(248, 29)
        Me.tbpas.TabIndex = 50
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.Location = New System.Drawing.Point(392, 93)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 24)
        Me.Label12.TabIndex = 49
        Me.Label12.Text = "Password"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(392, 58)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 24)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "Salary"
        '
        'numSalary
        '
        Me.numSalary.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.numSalary.Location = New System.Drawing.Point(519, 55)
        Me.numSalary.Maximum = New Decimal(New Integer() {15000000, 0, 0, 0})
        Me.numSalary.Name = "numSalary"
        Me.numSalary.Size = New System.Drawing.Size(248, 26)
        Me.numSalary.TabIndex = 51
        '
        'tbconfirm
        '
        Me.tbconfirm.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tbconfirm.Location = New System.Drawing.Point(519, 125)
        Me.tbconfirm.Name = "tbconfirm"
        Me.tbconfirm.Size = New System.Drawing.Size(248, 29)
        Me.tbconfirm.TabIndex = 53
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(392, 128)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(120, 24)
        Me.Label14.TabIndex = 52
        Me.Label14.Text = "Confirm Pass"
        '
        'btInserrt
        '
        Me.btInserrt.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btInserrt.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btInserrt.Location = New System.Drawing.Point(23, 19)
        Me.btInserrt.Name = "btInserrt"
        Me.btInserrt.Size = New System.Drawing.Size(92, 41)
        Me.btInserrt.TabIndex = 54
        Me.btInserrt.Text = "Insert"
        Me.btInserrt.UseVisualStyleBackColor = False
        '
        'btUpdate
        '
        Me.btUpdate.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btUpdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btUpdate.Location = New System.Drawing.Point(133, 19)
        Me.btUpdate.Name = "btUpdate"
        Me.btUpdate.Size = New System.Drawing.Size(92, 41)
        Me.btUpdate.TabIndex = 55
        Me.btUpdate.Text = "Update"
        Me.btUpdate.UseVisualStyleBackColor = False
        '
        'btDelete
        '
        Me.btDelete.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btDelete.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btDelete.Location = New System.Drawing.Point(246, 19)
        Me.btDelete.Name = "btDelete"
        Me.btDelete.Size = New System.Drawing.Size(92, 41)
        Me.btDelete.TabIndex = 56
        Me.btDelete.Text = "Delete"
        Me.btDelete.UseVisualStyleBackColor = False
        '
        'btCancel
        '
        Me.btCancel.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btCancel.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btCancel.Location = New System.Drawing.Point(617, 177)
        Me.btCancel.Name = "btCancel"
        Me.btCancel.Size = New System.Drawing.Size(92, 41)
        Me.btCancel.TabIndex = 58
        Me.btCancel.Text = "Cancel"
        Me.btCancel.UseVisualStyleBackColor = False
        '
        'btSave
        '
        Me.btSave.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btSave.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btSave.Location = New System.Drawing.Point(507, 177)
        Me.btSave.Name = "btSave"
        Me.btSave.Size = New System.Drawing.Size(92, 41)
        Me.btSave.TabIndex = 57
        Me.btSave.Text = "Save"
        Me.btSave.UseVisualStyleBackColor = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dtDate)
        Me.GroupBox1.Controls.Add(Me.btCancel)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.btSave)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.tbname)
        Me.GroupBox1.Controls.Add(Me.tbconfirm)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.numSalary)
        Me.GroupBox1.Controls.Add(Me.tbhp)
        Me.GroupBox1.Controls.Add(Me.tbpas)
        Me.GroupBox1.Controls.Add(Me.tbemail)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.tbalamat)
        Me.GroupBox1.Controls.Add(Me.cbtitle)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Location = New System.Drawing.Point(70, 330)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(783, 292)
        Me.GroupBox1.TabIndex = 59
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "gbform"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btDelete)
        Me.GroupBox2.Controls.Add(Me.btUpdate)
        Me.GroupBox2.Controls.Add(Me.btInserrt)
        Me.GroupBox2.Location = New System.Drawing.Point(466, 639)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(350, 78)
        Me.GroupBox2.TabIndex = 60
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "gbbutton"
        '
        'dtDate
        '
        Me.dtDate.CustomFormat = "dd MMM yyyy"
        Me.dtDate.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.dtDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom
        Me.dtDate.Location = New System.Drawing.Point(128, 223)
        Me.dtDate.Name = "dtDate"
        Me.dtDate.Size = New System.Drawing.Size(245, 29)
        Me.dtDate.TabIndex = 61
        '
        'EmployeeForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1006, 751)
        Me.Controls.Add(Me.dgemploya)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Button8)
        Me.Controls.Add(Me.tbCari)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox2)
        Me.Name = "EmployeeForm"
        Me.Text = "EmployeeForm"
        CType(Me.dgemploya, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.numSalary, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tbCari As TextBox
    Friend WithEvents Button8 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents dgemploya As DataGridView
    Friend WithEvents tbname As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents tbemail As TextBox
    Friend WithEvents tbhp As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents tbalamat As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents Label10 As Label
    Friend WithEvents cbtitle As ComboBox
    Friend WithEvents Label11 As Label
    Friend WithEvents tbpas As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents Label13 As Label
    Friend WithEvents numSalary As NumericUpDown
    Friend WithEvents tbconfirm As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents btInserrt As Button
    Friend WithEvents btUpdate As Button
    Friend WithEvents btDelete As Button
    Friend WithEvents btCancel As Button
    Friend WithEvents btSave As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents dtDate As DateTimePicker
End Class
