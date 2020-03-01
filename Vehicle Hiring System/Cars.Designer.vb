<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cars
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
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btninsert = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btnselect = New System.Windows.Forms.Button
        Me.btnsearch = New System.Windows.Forms.Button
        Me.txtsearch = New System.Windows.Forms.TextBox
        Me.lblsearch = New System.Windows.Forms.Label
        Me.btnlast = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnprevious = New System.Windows.Forms.Button
        Me.btnfirst = New System.Windows.Forms.Button
        Me.datagridviewcars = New System.Windows.Forms.DataGridView
        Me.txtdrvlisc = New System.Windows.Forms.TextBox
        Me.lblcarregno = New System.Windows.Forms.Label
        Me.txtcarseater = New System.Windows.Forms.TextBox
        Me.lblcarseater = New System.Windows.Forms.Label
        Me.txtcarmodel = New System.Windows.Forms.TextBox
        Me.lblcarmodel = New System.Windows.Forms.Label
        Me.txtcarid = New System.Windows.Forms.TextBox
        Me.lblcarid = New System.Windows.Forms.Label
        Me.lblcartitle = New System.Windows.Forms.Label
        Me.txtcarfuel = New System.Windows.Forms.TextBox
        Me.lblcarfuel = New System.Windows.Forms.Label
        Me.txtcarcolor = New System.Windows.Forms.TextBox
        Me.lblcarcolor = New System.Windows.Forms.Label
        CType(Me.datagridviewcars, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.Location = New System.Drawing.Point(204, 438)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(81, 35)
        Me.btndelete.TabIndex = 74
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnupdate.Location = New System.Drawing.Point(117, 438)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(81, 35)
        Me.btnupdate.TabIndex = 73
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btninsert.Location = New System.Drawing.Point(35, 438)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(81, 35)
        Me.btninsert.TabIndex = 72
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnreset.Location = New System.Drawing.Point(117, 378)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(81, 35)
        Me.btnreset.TabIndex = 71
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnselect
        '
        Me.btnselect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnselect.Location = New System.Drawing.Point(797, 435)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(79, 40)
        Me.btnselect.TabIndex = 70
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsearch.Location = New System.Drawing.Point(836, 86)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(97, 32)
        Me.btnsearch.TabIndex = 69
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtsearch
        '
        Me.txtsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtsearch.Location = New System.Drawing.Point(447, 90)
        Me.txtsearch.Name = "txtsearch"
        Me.txtsearch.Size = New System.Drawing.Size(383, 25)
        Me.txtsearch.TabIndex = 68
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(367, 94)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(74, 17)
        Me.lblsearch.TabIndex = 67
        Me.lblsearch.Text = "Enter Make"
        '
        'btnlast
        '
        Me.btnlast.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlast.Location = New System.Drawing.Point(699, 435)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(46, 40)
        Me.btnlast.TabIndex = 66
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnext.Location = New System.Drawing.Point(657, 435)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(46, 40)
        Me.btnnext.TabIndex = 65
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprevious
        '
        Me.btnprevious.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprevious.Location = New System.Drawing.Point(615, 435)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(46, 40)
        Me.btnprevious.TabIndex = 64
        Me.btnprevious.Text = "<"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnfirst.Location = New System.Drawing.Point(573, 435)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(46, 40)
        Me.btnfirst.TabIndex = 63
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'datagridviewcars
        '
        Me.datagridviewcars.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewcars.Location = New System.Drawing.Point(302, 125)
        Me.datagridviewcars.Name = "datagridviewcars"
        Me.datagridviewcars.Size = New System.Drawing.Size(678, 304)
        Me.datagridviewcars.TabIndex = 62
        '
        'txtdrvlisc
        '
        Me.txtdrvlisc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvlisc.Location = New System.Drawing.Point(129, 232)
        Me.txtdrvlisc.Name = "txtdrvlisc"
        Me.txtdrvlisc.Size = New System.Drawing.Size(135, 25)
        Me.txtdrvlisc.TabIndex = 61
        '
        'lblcarregno
        '
        Me.lblcarregno.AutoSize = True
        Me.lblcarregno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarregno.Location = New System.Drawing.Point(18, 234)
        Me.lblcarregno.Name = "lblcarregno"
        Me.lblcarregno.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcarregno.Size = New System.Drawing.Size(107, 17)
        Me.lblcarregno.TabIndex = 60
        Me.lblcarregno.Text = "Registeration no."
        '
        'txtcarseater
        '
        Me.txtcarseater.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarseater.Location = New System.Drawing.Point(129, 201)
        Me.txtcarseater.Name = "txtcarseater"
        Me.txtcarseater.Size = New System.Drawing.Size(135, 25)
        Me.txtcarseater.TabIndex = 59
        '
        'lblcarseater
        '
        Me.lblcarseater.AutoSize = True
        Me.lblcarseater.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarseater.Location = New System.Drawing.Point(78, 201)
        Me.lblcarseater.Name = "lblcarseater"
        Me.lblcarseater.Size = New System.Drawing.Size(45, 17)
        Me.lblcarseater.TabIndex = 58
        Me.lblcarseater.Text = "Seater"
        '
        'txtcarmodel
        '
        Me.txtcarmodel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarmodel.Location = New System.Drawing.Point(129, 170)
        Me.txtcarmodel.Name = "txtcarmodel"
        Me.txtcarmodel.Size = New System.Drawing.Size(135, 25)
        Me.txtcarmodel.TabIndex = 57
        '
        'lblcarmodel
        '
        Me.lblcarmodel.AutoSize = True
        Me.lblcarmodel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarmodel.Location = New System.Drawing.Point(79, 173)
        Me.lblcarmodel.Name = "lblcarmodel"
        Me.lblcarmodel.Size = New System.Drawing.Size(46, 17)
        Me.lblcarmodel.TabIndex = 56
        Me.lblcarmodel.Text = "Model"
        '
        'txtcarid
        '
        Me.txtcarid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarid.Location = New System.Drawing.Point(129, 138)
        Me.txtcarid.Name = "txtcarid"
        Me.txtcarid.Size = New System.Drawing.Size(135, 25)
        Me.txtcarid.TabIndex = 53
        '
        'lblcarid
        '
        Me.lblcarid.AutoSize = True
        Me.lblcarid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarid.Location = New System.Drawing.Point(79, 141)
        Me.lblcarid.Name = "lblcarid"
        Me.lblcarid.Size = New System.Drawing.Size(44, 17)
        Me.lblcarid.TabIndex = 52
        Me.lblcarid.Text = "Car ID"
        '
        'lblcartitle
        '
        Me.lblcartitle.AutoSize = True
        Me.lblcartitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcartitle.Location = New System.Drawing.Point(425, 27)
        Me.lblcartitle.Name = "lblcartitle"
        Me.lblcartitle.Size = New System.Drawing.Size(145, 37)
        Me.lblcartitle.TabIndex = 51
        Me.lblcartitle.Text = "Car Details"
        '
        'txtcarfuel
        '
        Me.txtcarfuel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarfuel.Location = New System.Drawing.Point(129, 263)
        Me.txtcarfuel.Name = "txtcarfuel"
        Me.txtcarfuel.Size = New System.Drawing.Size(135, 25)
        Me.txtcarfuel.TabIndex = 78
        '
        'lblcarfuel
        '
        Me.lblcarfuel.AutoSize = True
        Me.lblcarfuel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarfuel.Location = New System.Drawing.Point(60, 266)
        Me.lblcarfuel.Name = "lblcarfuel"
        Me.lblcarfuel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcarfuel.Size = New System.Drawing.Size(63, 17)
        Me.lblcarfuel.TabIndex = 77
        Me.lblcarfuel.Text = "Fuel Type"
        '
        'txtcarcolor
        '
        Me.txtcarcolor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarcolor.Location = New System.Drawing.Point(129, 294)
        Me.txtcarcolor.Name = "txtcarcolor"
        Me.txtcarcolor.Size = New System.Drawing.Size(135, 25)
        Me.txtcarcolor.TabIndex = 80
        '
        'lblcarcolor
        '
        Me.lblcarcolor.AutoSize = True
        Me.lblcarcolor.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarcolor.Location = New System.Drawing.Point(83, 297)
        Me.lblcarcolor.Name = "lblcarcolor"
        Me.lblcarcolor.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblcarcolor.Size = New System.Drawing.Size(40, 17)
        Me.lblcarcolor.TabIndex = 79
        Me.lblcarcolor.Text = "Color"
        '
        'Cars
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vehicle_Hiring_System.My.Resources.Resources.images__47_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1005, 499)
        Me.Controls.Add(Me.txtcarcolor)
        Me.Controls.Add(Me.lblcarcolor)
        Me.Controls.Add(Me.txtcarfuel)
        Me.Controls.Add(Me.lblcarfuel)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtsearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.datagridviewcars)
        Me.Controls.Add(Me.txtdrvlisc)
        Me.Controls.Add(Me.lblcarregno)
        Me.Controls.Add(Me.txtcarseater)
        Me.Controls.Add(Me.lblcarseater)
        Me.Controls.Add(Me.txtcarmodel)
        Me.Controls.Add(Me.lblcarmodel)
        Me.Controls.Add(Me.txtcarid)
        Me.Controls.Add(Me.lblcarid)
        Me.Controls.Add(Me.lblcartitle)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Cars"
        Me.Text = "Car Details"
        CType(Me.datagridviewcars, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnselect As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtsearch As System.Windows.Forms.TextBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnprevious As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents datagridviewcars As System.Windows.Forms.DataGridView
    Friend WithEvents txtdrvlisc As System.Windows.Forms.TextBox
    Friend WithEvents lblcarregno As System.Windows.Forms.Label
    Friend WithEvents txtcarseater As System.Windows.Forms.TextBox
    Friend WithEvents lblcarseater As System.Windows.Forms.Label
    Friend WithEvents txtcarmodel As System.Windows.Forms.TextBox
    Friend WithEvents lblcarmodel As System.Windows.Forms.Label
    Friend WithEvents txtcarid As System.Windows.Forms.TextBox
    Friend WithEvents lblcarid As System.Windows.Forms.Label
    Friend WithEvents lblcartitle As System.Windows.Forms.Label
    Friend WithEvents txtcarfuel As System.Windows.Forms.TextBox
    Friend WithEvents lblcarfuel As System.Windows.Forms.Label
    Friend WithEvents txtcarcolor As System.Windows.Forms.TextBox
    Friend WithEvents lblcarcolor As System.Windows.Forms.Label
End Class
