<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Client
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
        Me.lblclititle = New System.Windows.Forms.Label
        Me.lblclid = New System.Windows.Forms.Label
        Me.txtcliid = New System.Windows.Forms.TextBox
        Me.txtcliname = New System.Windows.Forms.TextBox
        Me.lblclname = New System.Windows.Forms.Label
        Me.txtcliadd = New System.Windows.Forms.TextBox
        Me.lblcladd = New System.Windows.Forms.Label
        Me.txtclino = New System.Windows.Forms.TextBox
        Me.lblclno = New System.Windows.Forms.Label
        Me.txtcliemail = New System.Windows.Forms.TextBox
        Me.lblclemail = New System.Windows.Forms.Label
        Me.datagridviewclient = New System.Windows.Forms.DataGridView
        Me.btnfirst = New System.Windows.Forms.Button
        Me.btnprevious = New System.Windows.Forms.Button
        Me.btnnext = New System.Windows.Forms.Button
        Me.btnlast = New System.Windows.Forms.Button
        Me.lblsearch = New System.Windows.Forms.Label
        Me.txtclisearch = New System.Windows.Forms.TextBox
        Me.btnsearch = New System.Windows.Forms.Button
        Me.btnselect = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.btninsert = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btndelete = New System.Windows.Forms.Button
        CType(Me.datagridviewclient, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblclititle
        '
        Me.lblclititle.AutoSize = True
        Me.lblclititle.Font = New System.Drawing.Font("Segoe UI Light", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclititle.Location = New System.Drawing.Point(378, 22)
        Me.lblclititle.Name = "lblclititle"
        Me.lblclititle.Size = New System.Drawing.Size(210, 47)
        Me.lblclititle.TabIndex = 0
        Me.lblclititle.Text = "Client Details"
        '
        'lblclid
        '
        Me.lblclid.AutoSize = True
        Me.lblclid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclid.Location = New System.Drawing.Point(50, 155)
        Me.lblclid.Name = "lblclid"
        Me.lblclid.Size = New System.Drawing.Size(56, 17)
        Me.lblclid.TabIndex = 1
        Me.lblclid.Text = "Client ID"
        '
        'txtcliid
        '
        Me.txtcliid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliid.Location = New System.Drawing.Point(112, 152)
        Me.txtcliid.Name = "txtcliid"
        Me.txtcliid.Size = New System.Drawing.Size(135, 25)
        Me.txtcliid.TabIndex = 2
        '
        'txtcliname
        '
        Me.txtcliname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliname.Location = New System.Drawing.Point(112, 183)
        Me.txtcliname.Name = "txtcliname"
        Me.txtcliname.Size = New System.Drawing.Size(135, 25)
        Me.txtcliname.TabIndex = 4
        '
        'lblclname
        '
        Me.lblclname.AutoSize = True
        Me.lblclname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclname.Location = New System.Drawing.Point(63, 186)
        Me.lblclname.Name = "lblclname"
        Me.lblclname.Size = New System.Drawing.Size(43, 17)
        Me.lblclname.TabIndex = 3
        Me.lblclname.Text = "Name"
        '
        'txtcliadd
        '
        Me.txtcliadd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliadd.Location = New System.Drawing.Point(112, 214)
        Me.txtcliadd.Multiline = True
        Me.txtcliadd.Name = "txtcliadd"
        Me.txtcliadd.Size = New System.Drawing.Size(135, 64)
        Me.txtcliadd.TabIndex = 6
        '
        'lblcladd
        '
        Me.lblcladd.AutoSize = True
        Me.lblcladd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcladd.Location = New System.Drawing.Point(50, 217)
        Me.lblcladd.Name = "lblcladd"
        Me.lblcladd.Size = New System.Drawing.Size(56, 17)
        Me.lblcladd.TabIndex = 5
        Me.lblcladd.Text = "Address"
        '
        'txtclino
        '
        Me.txtclino.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclino.Location = New System.Drawing.Point(112, 284)
        Me.txtclino.Name = "txtclino"
        Me.txtclino.Size = New System.Drawing.Size(135, 25)
        Me.txtclino.TabIndex = 8
        '
        'lblclno
        '
        Me.lblclno.AutoSize = True
        Me.lblclno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclno.Location = New System.Drawing.Point(32, 287)
        Me.lblclno.Name = "lblclno"
        Me.lblclno.Size = New System.Drawing.Size(74, 17)
        Me.lblclno.TabIndex = 7
        Me.lblclno.Text = "Contact no."
        '
        'txtcliemail
        '
        Me.txtcliemail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliemail.Location = New System.Drawing.Point(112, 315)
        Me.txtcliemail.Name = "txtcliemail"
        Me.txtcliemail.Size = New System.Drawing.Size(135, 25)
        Me.txtcliemail.TabIndex = 10
        '
        'lblclemail
        '
        Me.lblclemail.AutoSize = True
        Me.lblclemail.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclemail.Location = New System.Drawing.Point(51, 318)
        Me.lblclemail.Name = "lblclemail"
        Me.lblclemail.Size = New System.Drawing.Size(55, 17)
        Me.lblclemail.TabIndex = 9
        Me.lblclemail.Text = "Email ID"
        '
        'datagridviewclient
        '
        Me.datagridviewclient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewclient.Location = New System.Drawing.Point(292, 132)
        Me.datagridviewclient.Name = "datagridviewclient"
        Me.datagridviewclient.Size = New System.Drawing.Size(620, 304)
        Me.datagridviewclient.TabIndex = 11
        '
        'btnfirst
        '
        Me.btnfirst.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnfirst.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnfirst.Location = New System.Drawing.Point(505, 442)
        Me.btnfirst.Name = "btnfirst"
        Me.btnfirst.Size = New System.Drawing.Size(46, 40)
        Me.btnfirst.TabIndex = 12
        Me.btnfirst.Text = "<<"
        Me.btnfirst.UseVisualStyleBackColor = True
        '
        'btnprevious
        '
        Me.btnprevious.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnprevious.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnprevious.Location = New System.Drawing.Point(547, 442)
        Me.btnprevious.Name = "btnprevious"
        Me.btnprevious.Size = New System.Drawing.Size(46, 40)
        Me.btnprevious.TabIndex = 13
        Me.btnprevious.Text = "<"
        Me.btnprevious.UseVisualStyleBackColor = True
        '
        'btnnext
        '
        Me.btnnext.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnnext.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnnext.Location = New System.Drawing.Point(589, 442)
        Me.btnnext.Name = "btnnext"
        Me.btnnext.Size = New System.Drawing.Size(46, 40)
        Me.btnnext.TabIndex = 14
        Me.btnnext.Text = ">"
        Me.btnnext.UseVisualStyleBackColor = True
        '
        'btnlast
        '
        Me.btnlast.Font = New System.Drawing.Font("Segoe UI", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnlast.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnlast.Location = New System.Drawing.Point(631, 442)
        Me.btnlast.Name = "btnlast"
        Me.btnlast.Size = New System.Drawing.Size(46, 40)
        Me.btnlast.TabIndex = 15
        Me.btnlast.Text = ">>"
        Me.btnlast.UseVisualStyleBackColor = True
        '
        'lblsearch
        '
        Me.lblsearch.AutoSize = True
        Me.lblsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblsearch.Location = New System.Drawing.Point(325, 103)
        Me.lblsearch.Name = "lblsearch"
        Me.lblsearch.Size = New System.Drawing.Size(74, 17)
        Me.lblsearch.TabIndex = 16
        Me.lblsearch.Text = "Enter name"
        '
        'txtclisearch
        '
        Me.txtclisearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclisearch.Location = New System.Drawing.Point(414, 100)
        Me.txtclisearch.Name = "txtclisearch"
        Me.txtclisearch.Size = New System.Drawing.Size(383, 25)
        Me.txtclisearch.TabIndex = 17
        '
        'btnsearch
        '
        Me.btnsearch.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnsearch.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnsearch.Location = New System.Drawing.Point(803, 96)
        Me.btnsearch.Name = "btnsearch"
        Me.btnsearch.Size = New System.Drawing.Size(97, 32)
        Me.btnsearch.TabIndex = 18
        Me.btnsearch.Text = "Search"
        Me.btnsearch.UseVisualStyleBackColor = True
        '
        'btnselect
        '
        Me.btnselect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnselect.Location = New System.Drawing.Point(729, 442)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(79, 40)
        Me.btnselect.TabIndex = 22
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnreset.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnreset.Location = New System.Drawing.Point(101, 392)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(81, 35)
        Me.btnreset.TabIndex = 23
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btninsert.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btninsert.Location = New System.Drawing.Point(19, 447)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(81, 35)
        Me.btninsert.TabIndex = 24
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnupdate.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnupdate.Location = New System.Drawing.Point(101, 447)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(81, 35)
        Me.btnupdate.TabIndex = 25
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btndelete
        '
        Me.btndelete.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndelete.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btndelete.Location = New System.Drawing.Point(188, 447)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(81, 35)
        Me.btndelete.TabIndex = 26
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'Client
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Vehicle_Hiring_System.My.Resources.Resources.images__45_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(950, 543)
        Me.Controls.Add(Me.btndelete)
        Me.Controls.Add(Me.btnupdate)
        Me.Controls.Add(Me.btninsert)
        Me.Controls.Add(Me.btnreset)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.btnsearch)
        Me.Controls.Add(Me.txtclisearch)
        Me.Controls.Add(Me.lblsearch)
        Me.Controls.Add(Me.btnlast)
        Me.Controls.Add(Me.btnnext)
        Me.Controls.Add(Me.btnprevious)
        Me.Controls.Add(Me.btnfirst)
        Me.Controls.Add(Me.datagridviewclient)
        Me.Controls.Add(Me.txtcliemail)
        Me.Controls.Add(Me.lblclemail)
        Me.Controls.Add(Me.txtclino)
        Me.Controls.Add(Me.lblclno)
        Me.Controls.Add(Me.txtcliadd)
        Me.Controls.Add(Me.lblcladd)
        Me.Controls.Add(Me.txtcliname)
        Me.Controls.Add(Me.lblclname)
        Me.Controls.Add(Me.txtcliid)
        Me.Controls.Add(Me.lblclid)
        Me.Controls.Add(Me.lblclititle)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ForeColor = System.Drawing.SystemColors.ControlText
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Client"
        Me.Text = "Client Details"
        CType(Me.datagridviewclient, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents lblclititle As System.Windows.Forms.Label
    Friend WithEvents lblclid As System.Windows.Forms.Label
    Friend WithEvents txtcliid As System.Windows.Forms.TextBox
    Friend WithEvents txtcliname As System.Windows.Forms.TextBox
    Friend WithEvents lblclname As System.Windows.Forms.Label
    Friend WithEvents txtcliadd As System.Windows.Forms.TextBox
    Friend WithEvents lblcladd As System.Windows.Forms.Label
    Friend WithEvents txtclino As System.Windows.Forms.TextBox
    Friend WithEvents lblclno As System.Windows.Forms.Label
    Friend WithEvents txtcliemail As System.Windows.Forms.TextBox
    Friend WithEvents lblclemail As System.Windows.Forms.Label
    Friend WithEvents datagridviewclient As System.Windows.Forms.DataGridView
    Friend WithEvents btnfirst As System.Windows.Forms.Button
    Friend WithEvents btnprevious As System.Windows.Forms.Button
    Friend WithEvents btnnext As System.Windows.Forms.Button
    Friend WithEvents btnlast As System.Windows.Forms.Button
    Friend WithEvents lblsearch As System.Windows.Forms.Label
    Friend WithEvents txtclisearch As System.Windows.Forms.TextBox
    Friend WithEvents btnsearch As System.Windows.Forms.Button
    Friend WithEvents btnselect As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
End Class
