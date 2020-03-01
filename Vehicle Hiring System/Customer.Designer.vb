<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Customer
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
        Me.DataGridView1 = New System.Windows.Forms.DataGridView
        Me.lblcustname = New System.Windows.Forms.Label
        Me.txtcustname = New System.Windows.Forms.TextBox
        Me.lblcustadd = New System.Windows.Forms.Label
        Me.txtcustadd = New System.Windows.Forms.TextBox
        Me.lblcustno = New System.Windows.Forms.Label
        Me.txtcustno = New System.Windows.Forms.TextBox
        Me.lblcustemail = New System.Windows.Forms.Label
        Me.TextBox4 = New System.Windows.Forms.TextBox
        Me.Label5 = New System.Windows.Forms.Label
        Me.TextBox5 = New System.Windows.Forms.TextBox
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(630, 73)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(411, 417)
        Me.DataGridView1.TabIndex = 0
        '
        'lblcustname
        '
        Me.lblcustname.AutoSize = True
        Me.lblcustname.Location = New System.Drawing.Point(54, 51)
        Me.lblcustname.Name = "lblcustname"
        Me.lblcustname.Size = New System.Drawing.Size(35, 13)
        Me.lblcustname.TabIndex = 1
        Me.lblcustname.Text = "Name"
        '
        'txtcustname
        '
        Me.txtcustname.Location = New System.Drawing.Point(130, 48)
        Me.txtcustname.Name = "txtcustname"
        Me.txtcustname.Size = New System.Drawing.Size(219, 20)
        Me.txtcustname.TabIndex = 2
        '
        'lblcustadd
        '
        Me.lblcustadd.AutoSize = True
        Me.lblcustadd.Location = New System.Drawing.Point(54, 77)
        Me.lblcustadd.Name = "lblcustadd"
        Me.lblcustadd.Size = New System.Drawing.Size(45, 13)
        Me.lblcustadd.TabIndex = 1
        Me.lblcustadd.Text = "Address"
        '
        'txtcustadd
        '
        Me.txtcustadd.Location = New System.Drawing.Point(130, 77)
        Me.txtcustadd.Multiline = True
        Me.txtcustadd.Name = "txtcustadd"
        Me.txtcustadd.Size = New System.Drawing.Size(219, 76)
        Me.txtcustadd.TabIndex = 2
        '
        'lblcustno
        '
        Me.lblcustno.AutoSize = True
        Me.lblcustno.Location = New System.Drawing.Point(54, 167)
        Me.lblcustno.Name = "lblcustno"
        Me.lblcustno.Size = New System.Drawing.Size(64, 13)
        Me.lblcustno.TabIndex = 1
        Me.lblcustno.Text = "Contact No."
        '
        'txtcustno
        '
        Me.txtcustno.Location = New System.Drawing.Point(130, 164)
        Me.txtcustno.Name = "txtcustno"
        Me.txtcustno.Size = New System.Drawing.Size(146, 20)
        Me.txtcustno.TabIndex = 2
        '
        'lblcustemail
        '
        Me.lblcustemail.AutoSize = True
        Me.lblcustemail.Location = New System.Drawing.Point(54, 193)
        Me.lblcustemail.Name = "lblcustemail"
        Me.lblcustemail.Size = New System.Drawing.Size(72, 13)
        Me.lblcustemail.TabIndex = 1
        Me.lblcustemail.Text = "Email address"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(130, 190)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(100, 20)
        Me.TextBox4.TabIndex = 2
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(54, 219)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(39, 13)
        Me.Label5.TabIndex = 1
        Me.Label5.Text = "Label1"
        '
        'TextBox5
        '
        Me.TextBox5.Location = New System.Drawing.Point(130, 216)
        Me.TextBox5.Name = "TextBox5"
        Me.TextBox5.Size = New System.Drawing.Size(100, 20)
        Me.TextBox5.TabIndex = 2
        '
        'Customer
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1053, 502)
        Me.Controls.Add(Me.TextBox5)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.lblcustemail)
        Me.Controls.Add(Me.txtcustno)
        Me.Controls.Add(Me.lblcustno)
        Me.Controls.Add(Me.txtcustadd)
        Me.Controls.Add(Me.lblcustadd)
        Me.Controls.Add(Me.txtcustname)
        Me.Controls.Add(Me.lblcustname)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Customer"
        Me.Text = "Customer Information"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents lblcustname As System.Windows.Forms.Label
    Friend WithEvents txtcustname As System.Windows.Forms.TextBox
    Friend WithEvents lblcustadd As System.Windows.Forms.Label
    Friend WithEvents txtcustadd As System.Windows.Forms.TextBox
    Friend WithEvents lblcustno As System.Windows.Forms.Label
    Friend WithEvents txtcustno As System.Windows.Forms.TextBox
    Friend WithEvents lblcustemail As System.Windows.Forms.Label
    Friend WithEvents TextBox4 As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents TextBox5 As System.Windows.Forms.TextBox
End Class
