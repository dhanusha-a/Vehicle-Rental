<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Driver
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
        Me.txtdrvsearch = New System.Windows.Forms.TextBox
        Me.lblsearch = New System.Windows.Forms.Label
        Me.btnlast = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnprevious = New System.Windows.Forms.Button
        Me.btnfirst = New System.Windows.Forms.Button
        Me.datagridviewdriver = New System.Windows.Forms.DataGridView
        Me.txtdrvlisc = New System.Windows.Forms.TextBox
        Me.lbldrvlisc = New System.Windows.Forms.Label
        Me.txtdrvno = New System.Windows.Forms.TextBox
        Me.lbldrvno = New System.Windows.Forms.Label
        Me.txtdrvadd = New System.Windows.Forms.TextBox
        Me.lbldrvadd = New System.Windows.Forms.Label
        Me.txtdrvname = New System.Windows.Forms.TextBox
        Me.lbldrvname = New System.Windows.Forms.Label
        Me.txtdrvid = New System.Windows.Forms.TextBox
        Me.lbldrvid = New System.Windows.Forms.Label
        Me.lbldrvtitle = New System.Windows.Forms.Label
        CType(Me.datagridviewdriver, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.Location = New System.Drawing.Point(210, 443)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(81, 35)
        Me.btndelete.TabIndex = 50
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnupdate.Location = New System.Drawing.Point(125, 443)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(81, 35)
        Me.btnupdate.TabIndex = 49
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btninsert.Location = New System.Drawing.Point(41, 443)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(81, 35)
        Me.btninsert.TabIndex = 48
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnreset.Location = New System.Drawing.Point(125, 383)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(81, 35)
        Me.btnreset.TabIndex = 47
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btnselect
        '
        Me.btnselect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnselect.Location = New System.Drawing.Point(750, 439)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(79, 40)
        Me.btnselect.TabIndex = 46
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsearch.Location = New System.Drawing.Point(824, 92)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(97, 32)
        Me.btnsearch.TabIndex = 45
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'txtdrvsearch
        '
        Me.txtdrvsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvsearch.Location = New System.Drawing.Point(435, 97)
        Me.txtdrvsearch.Name = "txtdrvsearch"
        Me.txtdrvsearch.Size = New System.Drawing.Size(383, 25)
        Me.txtdrvsearch.TabIndex = 44
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(355, 101)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(74, 17)
        Me.lblsearch.TabIndex = 43
        Me.lblsearch.Text = "Enter name"
        '
        'btnlast
        '
        Me.btnlast.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlast.Location = New System.Drawing.Point(652, 439)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(46, 40)
        Me.btnlast.TabIndex = 42
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnext.Location = New System.Drawing.Point(610, 439)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(46, 40)
        Me.btnnext.TabIndex = 41
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnprevious
        '
        Me.btnprevious.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprevious.Location = New System.Drawing.Point(568, 439)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(46, 40)
        Me.btnprevious.TabIndex = 40
        Me.btnprevious.Text = "<"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnfirst
        '
        Me.btnfirst.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnfirst.Location = New System.Drawing.Point(526, 439)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(46, 40)
        Me.btnfirst.TabIndex = 39
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'datagridviewdriver
        '
        Me.datagridviewdriver.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewdriver.Location = New System.Drawing.Point(313, 129)
        Me.datagridviewdriver.Name = "datagridviewdriver"
        Me.datagridviewdriver.Size = New System.Drawing.Size(620, 304)
        Me.datagridviewdriver.TabIndex = 38
        '
        'txtdrvlisc
        '
        Me.txtdrvlisc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvlisc.Location = New System.Drawing.Point(125, 310)
        Me.txtdrvlisc.Name = "txtdrvlisc"
        Me.txtdrvlisc.Size = New System.Drawing.Size(135, 25)
        Me.txtdrvlisc.TabIndex = 37
        '
        'lbldrvlisc
        '
        Me.lbldrvlisc.AutoSize = True
        Me.lbldrvlisc.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrvlisc.Location = New System.Drawing.Point(63, 313)
        Me.lbldrvlisc.Name = "lbldrvlisc"
        Me.lbldrvlisc.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lbldrvlisc.Size = New System.Drawing.Size(56, 17)
        Me.lbldrvlisc.TabIndex = 36
        Me.lbldrvlisc.Text = "Liscense"
        '
        'txtdrvno
        '
        Me.txtdrvno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvno.Location = New System.Drawing.Point(125, 279)
        Me.txtdrvno.Name = "txtdrvno"
        Me.txtdrvno.Size = New System.Drawing.Size(135, 25)
        Me.txtdrvno.TabIndex = 35
        '
        'lbldrvno
        '
        Me.lbldrvno.AutoSize = True
        Me.lbldrvno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrvno.Location = New System.Drawing.Point(45, 282)
        Me.lbldrvno.Name = "lbldrvno"
        Me.lbldrvno.Size = New System.Drawing.Size(74, 17)
        Me.lbldrvno.TabIndex = 34
        Me.lbldrvno.Text = "Contact no."
        '
        'txtdrvadd
        '
        Me.txtdrvadd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvadd.Location = New System.Drawing.Point(125, 209)
        Me.txtdrvadd.Multiline = True
        Me.txtdrvadd.Name = "txtdrvadd"
        Me.txtdrvadd.Size = New System.Drawing.Size(135, 64)
        Me.txtdrvadd.TabIndex = 33
        '
        'lbldrvadd
        '
        Me.lbldrvadd.AutoSize = True
        Me.lbldrvadd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrvadd.Location = New System.Drawing.Point(63, 212)
        Me.lbldrvadd.Name = "lbldrvadd"
        Me.lbldrvadd.Size = New System.Drawing.Size(56, 17)
        Me.lbldrvadd.TabIndex = 32
        Me.lbldrvadd.Text = "Address"
        '
        'txtdrvname
        '
        Me.txtdrvname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvname.Location = New System.Drawing.Point(125, 178)
        Me.txtdrvname.Name = "txtdrvname"
        Me.txtdrvname.Size = New System.Drawing.Size(135, 25)
        Me.txtdrvname.TabIndex = 31
        '
        'lbldrvname
        '
        Me.lbldrvname.AutoSize = True
        Me.lbldrvname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrvname.Location = New System.Drawing.Point(76, 181)
        Me.lbldrvname.Name = "lbldrvname"
        Me.lbldrvname.Size = New System.Drawing.Size(43, 17)
        Me.lbldrvname.TabIndex = 30
        Me.lbldrvname.Text = "Name"
        '
        'txtdrvid
        '
        Me.txtdrvid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvid.Location = New System.Drawing.Point(125, 147)
        Me.txtdrvid.Name = "txtdrvid"
        Me.txtdrvid.Size = New System.Drawing.Size(135, 25)
        Me.txtdrvid.TabIndex = 29
        '
        'lbldrvid
        '
        Me.lbldrvid.AutoSize = True
        Me.lbldrvid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrvid.Location = New System.Drawing.Point(60, 152)
        Me.lbldrvid.Name = "lbldrvid"
        Me.lbldrvid.Size = New System.Drawing.Size(59, 17)
        Me.lbldrvid.TabIndex = 28
        Me.lbldrvid.Text = "Driver ID"
        '
        'lbldrvtitle
        '
        Me.lbldrvtitle.AutoSize = True
        Me.lbldrvtitle.Font = New System.Drawing.Font("Segoe UI", 21.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrvtitle.Location = New System.Drawing.Point(385, 25)
        Me.lbldrvtitle.Name = "lbldrvtitle"
        Me.lbldrvtitle.Size = New System.Drawing.Size(187, 40)
        Me.lbldrvtitle.TabIndex = 27
        Me.lbldrvtitle.Text = "Driver Details"
        '
        'Driver
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Vehicle_Hiring_System.My.Resources.Resources.images__48_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(976, 510)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtdrvsearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.datagridviewdriver)
        Me.Controls.Add(Me.txtdrvlisc)
        Me.Controls.Add(Me.lbldrvlisc)
        Me.Controls.Add(Me.txtdrvno)
        Me.Controls.Add(Me.lbldrvno)
        Me.Controls.Add(Me.txtdrvadd)
        Me.Controls.Add(Me.lbldrvadd)
        Me.Controls.Add(Me.txtdrvname)
        Me.Controls.Add(Me.lbldrvname)
        Me.Controls.Add(Me.txtdrvid)
        Me.Controls.Add(Me.lbldrvid)
        Me.Controls.Add(Me.lbldrvtitle)
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Driver"
        Me.Text = "Driver Details"
        CType(Me.datagridviewdriver, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btnselect As System.Windows.Forms.Button
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents txtdrvsearch As System.Windows.Forms.TextBox
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnprevious As System.Windows.Forms.Button
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents datagridviewdriver As System.Windows.Forms.DataGridView
    Friend WithEvents txtdrvlisc As System.Windows.Forms.TextBox
    Friend WithEvents lbldrvlisc As System.Windows.Forms.Label
    Friend WithEvents txtdrvno As System.Windows.Forms.TextBox
    Friend WithEvents lbldrvno As System.Windows.Forms.Label
    Friend WithEvents txtdrvadd As System.Windows.Forms.TextBox
    Friend WithEvents lbldrvadd As System.Windows.Forms.Label
    Friend WithEvents txtdrvname As System.Windows.Forms.TextBox
    Friend WithEvents lbldrvname As System.Windows.Forms.Label
    Friend WithEvents txtdrvid As System.Windows.Forms.TextBox
    Friend WithEvents lbldrvid As System.Windows.Forms.Label
    Friend WithEvents lbldrvtitle As System.Windows.Forms.Label
End Class
