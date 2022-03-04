<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.dgv = New System.Windows.Forms.DataGridView()
        Me.txtid = New System.Windows.Forms.RichTextBox()
        Me.txtLname = New System.Windows.Forms.RichTextBox()
        Me.txtname = New System.Windows.Forms.RichTextBox()
        Me.lblname = New System.Windows.Forms.Label()
        Me.lbllastname = New System.Windows.Forms.Label()
        Me.lblid = New System.Windows.Forms.Label()
        Me.cmbcourse = New System.Windows.Forms.ComboBox()
        Me.lblcourse = New System.Windows.Forms.Label()
        Me.txtage = New System.Windows.Forms.RichTextBox()
        Me.lblage = New System.Windows.Forms.Label()
        Me.btnadd = New System.Windows.Forms.Button()
        Me.btnupdate = New System.Windows.Forms.Button()
        Me.btndel = New System.Windows.Forms.Button()
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'dgv
        '
        Me.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv.Location = New System.Drawing.Point(191, 22)
        Me.dgv.Name = "dgv"
        Me.dgv.Size = New System.Drawing.Size(540, 209)
        Me.dgv.TabIndex = 0
        '
        'txtid
        '
        Me.txtid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtid.Location = New System.Drawing.Point(80, 47)
        Me.txtid.Name = "txtid"
        Me.txtid.Size = New System.Drawing.Size(105, 23)
        Me.txtid.TabIndex = 1
        Me.txtid.Text = ""
        '
        'txtLname
        '
        Me.txtLname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtLname.Location = New System.Drawing.Point(80, 115)
        Me.txtLname.Name = "txtLname"
        Me.txtLname.Size = New System.Drawing.Size(105, 23)
        Me.txtLname.TabIndex = 2
        Me.txtLname.Text = ""
        '
        'txtname
        '
        Me.txtname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtname.Location = New System.Drawing.Point(80, 76)
        Me.txtname.Name = "txtname"
        Me.txtname.Size = New System.Drawing.Size(105, 23)
        Me.txtname.TabIndex = 3
        Me.txtname.Text = ""
        '
        'lblname
        '
        Me.lblname.AutoSize = True
        Me.lblname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblname.Location = New System.Drawing.Point(23, 79)
        Me.lblname.Name = "lblname"
        Me.lblname.Size = New System.Drawing.Size(48, 16)
        Me.lblname.TabIndex = 4
        Me.lblname.Text = "Name"
        '
        'lbllastname
        '
        Me.lbllastname.AutoSize = True
        Me.lbllastname.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbllastname.Location = New System.Drawing.Point(13, 115)
        Me.lbllastname.Name = "lbllastname"
        Me.lbllastname.Size = New System.Drawing.Size(61, 16)
        Me.lbllastname.TabIndex = 5
        Me.lbllastname.Text = "L-Name"
        '
        'lblid
        '
        Me.lblid.AutoSize = True
        Me.lblid.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblid.Location = New System.Drawing.Point(23, 50)
        Me.lblid.Name = "lblid"
        Me.lblid.Size = New System.Drawing.Size(22, 16)
        Me.lblid.TabIndex = 6
        Me.lblid.Text = "ID"
        '
        'cmbcourse
        '
        Me.cmbcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbcourse.FormattingEnabled = True
        Me.cmbcourse.Location = New System.Drawing.Point(80, 181)
        Me.cmbcourse.Name = "cmbcourse"
        Me.cmbcourse.Size = New System.Drawing.Size(105, 24)
        Me.cmbcourse.TabIndex = 7
        '
        'lblcourse
        '
        Me.lblcourse.AutoSize = True
        Me.lblcourse.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcourse.Location = New System.Drawing.Point(15, 184)
        Me.lblcourse.Name = "lblcourse"
        Me.lblcourse.Size = New System.Drawing.Size(56, 16)
        Me.lblcourse.TabIndex = 8
        Me.lblcourse.Text = "Course"
        '
        'txtage
        '
        Me.txtage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtage.Location = New System.Drawing.Point(80, 144)
        Me.txtage.Name = "txtage"
        Me.txtage.Size = New System.Drawing.Size(105, 23)
        Me.txtage.TabIndex = 9
        Me.txtage.Text = ""
        '
        'lblage
        '
        Me.lblage.AutoSize = True
        Me.lblage.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblage.Location = New System.Drawing.Point(23, 147)
        Me.lblage.Name = "lblage"
        Me.lblage.Size = New System.Drawing.Size(35, 16)
        Me.lblage.TabIndex = 10
        Me.lblage.Text = "Age"
        '
        'btnadd
        '
        Me.btnadd.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnadd.Location = New System.Drawing.Point(12, 282)
        Me.btnadd.Name = "btnadd"
        Me.btnadd.Size = New System.Drawing.Size(95, 33)
        Me.btnadd.TabIndex = 11
        Me.btnadd.Text = "Add"
        Me.btnadd.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.Location = New System.Drawing.Point(149, 282)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(95, 33)
        Me.btnupdate.TabIndex = 12
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndel
        '
        Me.btndel.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndel.Location = New System.Drawing.Point(290, 282)
        Me.btndel.Name = "btndel"
        Me.btndel.Size = New System.Drawing.Size(95, 33)
        Me.btndel.TabIndex = 13
        Me.btndel.Text = "Delete"
        Me.btndel.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Red
        Me.ClientSize = New System.Drawing.Size(743, 327)
        Me.Controls.Add(Me.btndel)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btnadd)
        Me.Controls.Add(Me.lblage)
        Me.Controls.Add(Me.txtage)
        Me.Controls.Add(Me.lblcourse)
        Me.Controls.Add(Me.cmbcourse)
        Me.Controls.Add(Me.lblid)
        Me.Controls.Add(Me.lbllastname)
        Me.Controls.Add(Me.lblname)
        Me.Controls.Add(Me.txtname)
        Me.Controls.Add(Me.txtLname)
        Me.Controls.Add(Me.txtid)
        Me.Controls.Add(Me.dgv)
        Me.Name = "Form1"
        Me.Text = "Database (MS Access)"
        CType(Me.dgv, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents dgv As DataGridView
    Friend WithEvents txtid As RichTextBox
    Friend WithEvents txtLname As RichTextBox
    Friend WithEvents txtname As RichTextBox
    Friend WithEvents lblname As Label
    Friend WithEvents lbllastname As Label
    Friend WithEvents lblid As Label
    Friend WithEvents lblcourse As Label
    Friend WithEvents txtage As RichTextBox
    Friend WithEvents lblage As Label
    Friend WithEvents btnadd As Button
    Public WithEvents cmbcourse As ComboBox
    Friend WithEvents btnupdate As Button
    Friend WithEvents btndel As Button
End Class
