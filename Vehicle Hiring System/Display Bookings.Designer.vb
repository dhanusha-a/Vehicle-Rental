<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Display_Bookings
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
        Me.datagridviewbooking = New System.Windows.Forms.DataGridView
        Me.lblbookdttitle = New System.Windows.Forms.Label
        Me.btnselect = New System.Windows.Forms.Button
        CType(Me.datagridviewbooking, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'datagridviewbooking
        '
        Me.datagridviewbooking.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.datagridviewbooking.Location = New System.Drawing.Point(12, 63)
        Me.datagridviewbooking.Name = "datagridviewbooking"
        Me.datagridviewbooking.Size = New System.Drawing.Size(1086, 342)
        Me.datagridviewbooking.TabIndex = 0
        '
        'lblbookdttitle
        '
        Me.lblbookdttitle.AutoSize = True
        Me.lblbookdttitle.Font = New System.Drawing.Font("Segoe UI", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookdttitle.Location = New System.Drawing.Point(456, 23)
        Me.lblbookdttitle.Name = "lblbookdttitle"
        Me.lblbookdttitle.Size = New System.Drawing.Size(203, 37)
        Me.lblbookdttitle.TabIndex = 1
        Me.lblbookdttitle.Text = "Booking Details"
        '
        'btnselect
        '
        Me.btnselect.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnselect.Location = New System.Drawing.Point(541, 439)
        Me.btnselect.Name = "btnselect"
        Me.btnselect.Size = New System.Drawing.Size(81, 33)
        Me.btnselect.TabIndex = 2
        Me.btnselect.Text = "Select"
        Me.btnselect.UseVisualStyleBackColor = True
        '
        'Display_Bookings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Vehicle_Hiring_System.My.Resources.Resources.images__45_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1110, 503)
        Me.Controls.Add(Me.btnselect)
        Me.Controls.Add(Me.lblbookdttitle)
        Me.Controls.Add(Me.datagridviewbooking)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Display_Bookings"
        Me.Text = "Display_Bookings"
        CType(Me.datagridviewbooking, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents datagridviewbooking As System.Windows.Forms.DataGridView
    Friend WithEvents lblbookdttitle As System.Windows.Forms.Label
    Friend WithEvents btnselect As System.Windows.Forms.Button
End Class
