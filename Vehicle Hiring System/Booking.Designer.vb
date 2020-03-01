<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Booking
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
        Me.Label1 = New System.Windows.Forms.Label
        Me.grpcli = New System.Windows.Forms.GroupBox
        Me.txtclino = New System.Windows.Forms.TextBox
        Me.lblclino = New System.Windows.Forms.Label
        Me.txtcliadd = New System.Windows.Forms.TextBox
        Me.lblcliadd = New System.Windows.Forms.Label
        Me.txtcliname = New System.Windows.Forms.TextBox
        Me.lblcliname = New System.Windows.Forms.Label
        Me.txtcliid = New System.Windows.Forms.TextBox
        Me.lblcliid = New System.Windows.Forms.Label
        Me.btnscliview = New System.Windows.Forms.Button
        Me.grpdrv = New System.Windows.Forms.GroupBox
        Me.txtdrvno = New System.Windows.Forms.TextBox
        Me.lbldrvno = New System.Windows.Forms.Label
        Me.btndrvview = New System.Windows.Forms.Button
        Me.txtdrvname = New System.Windows.Forms.TextBox
        Me.lbldrvname = New System.Windows.Forms.Label
        Me.grpcar = New System.Windows.Forms.GroupBox
        Me.txtbookfuel = New System.Windows.Forms.TextBox
        Me.lblbookfuel = New System.Windows.Forms.Label
        Me.btncarview = New System.Windows.Forms.Button
        Me.txtcarseater = New System.Windows.Forms.TextBox
        Me.lblcarseater = New System.Windows.Forms.Label
        Me.txtcarmake = New System.Windows.Forms.TextBox
        Me.lblcarmodel = New System.Windows.Forms.Label
        Me.txtcarid = New System.Windows.Forms.TextBox
        Me.lblcarid = New System.Windows.Forms.Label
        Me.btnbookdisp = New System.Windows.Forms.Button
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker
        Me.Label2 = New System.Windows.Forms.Label
        Me.txtbookno = New System.Windows.Forms.TextBox
        Me.lblbookdest = New System.Windows.Forms.Label
        Me.txtbookdest = New System.Windows.Forms.TextBox
        Me.lblbookdep = New System.Windows.Forms.Label
        Me.txtbookdep = New System.Windows.Forms.TextBox
        Me.lblbookarv = New System.Windows.Forms.Label
        Me.txtbookarv = New System.Windows.Forms.TextBox
        Me.lblbookdur = New System.Windows.Forms.Label
        Me.txtbookdur = New System.Windows.Forms.TextBox
        Me.lblbookpeople = New System.Windows.Forms.Label
        Me.txtbookpeople = New System.Windows.Forms.TextBox
        Me.lblrspkm = New System.Windows.Forms.Label
        Me.txtrspkm = New System.Windows.Forms.TextBox
        Me.lblbooktax = New System.Windows.Forms.Label
        Me.txtbooktax = New System.Windows.Forms.TextBox
        Me.lblbookremark = New System.Windows.Forms.Label
        Me.txtbookremark = New System.Windows.Forms.TextBox
        Me.lblbookdeposit = New System.Windows.Forms.Label
        Me.txtbookdeposit = New System.Windows.Forms.TextBox
        Me.lblbooktotal = New System.Windows.Forms.Label
        Me.grpbooking = New System.Windows.Forms.GroupBox
        Me.btndelete = New System.Windows.Forms.Button
        Me.btnupdate = New System.Windows.Forms.Button
        Me.btninsert = New System.Windows.Forms.Button
        Me.btnreset = New System.Windows.Forms.Button
        Me.txtbookdue = New System.Windows.Forms.TextBox
        Me.txtbooktotal = New System.Windows.Forms.TextBox
        Me.lblbookdue = New System.Windows.Forms.Label
        Me.grpcli.SuspendLayout()
        Me.grpdrv.SuspendLayout()
        Me.grpcar.SuspendLayout()
        Me.grpbooking.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(514, 56)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(182, 32)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Booking Details"
        '
        'grpcli
        '
        Me.grpcli.Controls.Add(Me.txtclino)
        Me.grpcli.Controls.Add(Me.lblclino)
        Me.grpcli.Controls.Add(Me.txtcliadd)
        Me.grpcli.Controls.Add(Me.lblcliadd)
        Me.grpcli.Controls.Add(Me.txtcliname)
        Me.grpcli.Controls.Add(Me.lblcliname)
        Me.grpcli.Controls.Add(Me.txtcliid)
        Me.grpcli.Controls.Add(Me.lblcliid)
        Me.grpcli.Controls.Add(Me.btnscliview)
        Me.grpcli.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpcli.Location = New System.Drawing.Point(106, 162)
        Me.grpcli.Name = "grpcli"
        Me.grpcli.Size = New System.Drawing.Size(247, 221)
        Me.grpcli.TabIndex = 1
        Me.grpcli.TabStop = False
        Me.grpcli.Text = "Client Details"
        '
        'txtclino
        '
        Me.txtclino.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtclino.Location = New System.Drawing.Point(100, 127)
        Me.txtclino.Name = "txtclino"
        Me.txtclino.Size = New System.Drawing.Size(109, 25)
        Me.txtclino.TabIndex = 8
        '
        'lblclino
        '
        Me.lblclino.AutoSize = True
        Me.lblclino.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblclino.Location = New System.Drawing.Point(17, 130)
        Me.lblclino.Name = "lblclino"
        Me.lblclino.Size = New System.Drawing.Size(77, 17)
        Me.lblclino.TabIndex = 7
        Me.lblclino.Text = "Contact No."
        '
        'txtcliadd
        '
        Me.txtcliadd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliadd.Location = New System.Drawing.Point(100, 84)
        Me.txtcliadd.Multiline = True
        Me.txtcliadd.Name = "txtcliadd"
        Me.txtcliadd.Size = New System.Drawing.Size(109, 37)
        Me.txtcliadd.TabIndex = 6
        '
        'lblcliadd
        '
        Me.lblcliadd.AutoSize = True
        Me.lblcliadd.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliadd.Location = New System.Drawing.Point(38, 87)
        Me.lblcliadd.Name = "lblcliadd"
        Me.lblcliadd.Size = New System.Drawing.Size(56, 17)
        Me.lblcliadd.TabIndex = 5
        Me.lblcliadd.Text = "Address"
        '
        'txtcliname
        '
        Me.txtcliname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliname.Location = New System.Drawing.Point(100, 58)
        Me.txtcliname.Name = "txtcliname"
        Me.txtcliname.Size = New System.Drawing.Size(109, 25)
        Me.txtcliname.TabIndex = 4
        '
        'lblcliname
        '
        Me.lblcliname.AutoSize = True
        Me.lblcliname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliname.Location = New System.Drawing.Point(51, 63)
        Me.lblcliname.Name = "lblcliname"
        Me.lblcliname.Size = New System.Drawing.Size(43, 17)
        Me.lblcliname.TabIndex = 3
        Me.lblcliname.Text = "Name"
        '
        'txtcliid
        '
        Me.txtcliid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcliid.Location = New System.Drawing.Point(100, 32)
        Me.txtcliid.Name = "txtcliid"
        Me.txtcliid.Size = New System.Drawing.Size(109, 25)
        Me.txtcliid.TabIndex = 2
        '
        'lblcliid
        '
        Me.lblcliid.AutoSize = True
        Me.lblcliid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcliid.Location = New System.Drawing.Point(38, 37)
        Me.lblcliid.Name = "lblcliid"
        Me.lblcliid.Size = New System.Drawing.Size(56, 17)
        Me.lblcliid.TabIndex = 1
        Me.lblcliid.Text = "Client ID"
        '
        'btnscliview
        '
        Me.btnscliview.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnscliview.Location = New System.Drawing.Point(73, 165)
        Me.btnscliview.Name = "btnscliview"
        Me.btnscliview.Size = New System.Drawing.Size(75, 39)
        Me.btnscliview.TabIndex = 0
        Me.btnscliview.Text = "View"
        Me.btnscliview.UseVisualStyleBackColor = True
        '
        'grpdrv
        '
        Me.grpdrv.Controls.Add(Me.txtdrvno)
        Me.grpdrv.Controls.Add(Me.lbldrvno)
        Me.grpdrv.Controls.Add(Me.btndrvview)
        Me.grpdrv.Controls.Add(Me.txtdrvname)
        Me.grpdrv.Controls.Add(Me.lbldrvname)
        Me.grpdrv.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpdrv.Location = New System.Drawing.Point(106, 411)
        Me.grpdrv.Name = "grpdrv"
        Me.grpdrv.Size = New System.Drawing.Size(247, 159)
        Me.grpdrv.TabIndex = 2
        Me.grpdrv.TabStop = False
        Me.grpdrv.Text = "Driver Details"
        '
        'txtdrvno
        '
        Me.txtdrvno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvno.Location = New System.Drawing.Point(100, 66)
        Me.txtdrvno.Name = "txtdrvno"
        Me.txtdrvno.Size = New System.Drawing.Size(100, 25)
        Me.txtdrvno.TabIndex = 11
        '
        'lbldrvno
        '
        Me.lbldrvno.AutoSize = True
        Me.lbldrvno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrvno.Location = New System.Drawing.Point(17, 66)
        Me.lbldrvno.Name = "lbldrvno"
        Me.lbldrvno.Size = New System.Drawing.Size(77, 17)
        Me.lbldrvno.TabIndex = 10
        Me.lbldrvno.Text = "Contact No."
        '
        'btndrvview
        '
        Me.btndrvview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btndrvview.Location = New System.Drawing.Point(73, 102)
        Me.btndrvview.Name = "btndrvview"
        Me.btndrvview.Size = New System.Drawing.Size(75, 39)
        Me.btndrvview.TabIndex = 9
        Me.btndrvview.Text = "View"
        Me.btndrvview.UseVisualStyleBackColor = True
        '
        'txtdrvname
        '
        Me.txtdrvname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtdrvname.Location = New System.Drawing.Point(100, 35)
        Me.txtdrvname.Name = "txtdrvname"
        Me.txtdrvname.Size = New System.Drawing.Size(100, 25)
        Me.txtdrvname.TabIndex = 6
        '
        'lbldrvname
        '
        Me.lbldrvname.AutoSize = True
        Me.lbldrvname.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lbldrvname.Location = New System.Drawing.Point(51, 38)
        Me.lbldrvname.Name = "lbldrvname"
        Me.lbldrvname.Size = New System.Drawing.Size(43, 17)
        Me.lbldrvname.TabIndex = 5
        Me.lbldrvname.Text = "Name"
        '
        'grpcar
        '
        Me.grpcar.Controls.Add(Me.txtbookfuel)
        Me.grpcar.Controls.Add(Me.lblbookfuel)
        Me.grpcar.Controls.Add(Me.btncarview)
        Me.grpcar.Controls.Add(Me.txtcarseater)
        Me.grpcar.Controls.Add(Me.lblcarseater)
        Me.grpcar.Controls.Add(Me.txtcarmake)
        Me.grpcar.Controls.Add(Me.lblcarmodel)
        Me.grpcar.Controls.Add(Me.txtcarid)
        Me.grpcar.Controls.Add(Me.lblcarid)
        Me.grpcar.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpcar.Location = New System.Drawing.Point(388, 167)
        Me.grpcar.Name = "grpcar"
        Me.grpcar.Size = New System.Drawing.Size(233, 216)
        Me.grpcar.TabIndex = 3
        Me.grpcar.TabStop = False
        Me.grpcar.Text = "Car Details"
        '
        'txtbookfuel
        '
        Me.txtbookfuel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookfuel.Location = New System.Drawing.Point(89, 118)
        Me.txtbookfuel.Name = "txtbookfuel"
        Me.txtbookfuel.Size = New System.Drawing.Size(100, 25)
        Me.txtbookfuel.TabIndex = 80
        '
        'lblbookfuel
        '
        Me.lblbookfuel.AutoSize = True
        Me.lblbookfuel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookfuel.Location = New System.Drawing.Point(20, 121)
        Me.lblbookfuel.Name = "lblbookfuel"
        Me.lblbookfuel.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.lblbookfuel.Size = New System.Drawing.Size(63, 17)
        Me.lblbookfuel.TabIndex = 79
        Me.lblbookfuel.Text = "Fuel Type"
        '
        'btncarview
        '
        Me.btncarview.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btncarview.Location = New System.Drawing.Point(77, 160)
        Me.btncarview.Name = "btncarview"
        Me.btncarview.Size = New System.Drawing.Size(78, 39)
        Me.btncarview.TabIndex = 9
        Me.btncarview.Text = "View"
        Me.btncarview.UseVisualStyleBackColor = True
        '
        'txtcarseater
        '
        Me.txtcarseater.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarseater.Location = New System.Drawing.Point(89, 86)
        Me.txtcarseater.Name = "txtcarseater"
        Me.txtcarseater.Size = New System.Drawing.Size(100, 25)
        Me.txtcarseater.TabIndex = 14
        '
        'lblcarseater
        '
        Me.lblcarseater.AutoSize = True
        Me.lblcarseater.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarseater.Location = New System.Drawing.Point(37, 89)
        Me.lblcarseater.Name = "lblcarseater"
        Me.lblcarseater.Size = New System.Drawing.Size(45, 17)
        Me.lblcarseater.TabIndex = 13
        Me.lblcarseater.Text = "Seater"
        '
        'txtcarmake
        '
        Me.txtcarmake.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarmake.Location = New System.Drawing.Point(89, 58)
        Me.txtcarmake.Name = "txtcarmake"
        Me.txtcarmake.Size = New System.Drawing.Size(100, 25)
        Me.txtcarmake.TabIndex = 12
        '
        'lblcarmodel
        '
        Me.lblcarmodel.AutoSize = True
        Me.lblcarmodel.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarmodel.Location = New System.Drawing.Point(37, 61)
        Me.lblcarmodel.Name = "lblcarmodel"
        Me.lblcarmodel.Size = New System.Drawing.Size(46, 17)
        Me.lblcarmodel.TabIndex = 11
        Me.lblcarmodel.Text = "Model"
        '
        'txtcarid
        '
        Me.txtcarid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtcarid.Location = New System.Drawing.Point(89, 28)
        Me.txtcarid.Name = "txtcarid"
        Me.txtcarid.Size = New System.Drawing.Size(100, 25)
        Me.txtcarid.TabIndex = 10
        '
        'lblcarid
        '
        Me.lblcarid.AutoSize = True
        Me.lblcarid.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblcarid.Location = New System.Drawing.Point(39, 32)
        Me.lblcarid.Name = "lblcarid"
        Me.lblcarid.Size = New System.Drawing.Size(44, 17)
        Me.lblcarid.TabIndex = 9
        Me.lblcarid.Text = "Car ID"
        '
        'btnbookdisp
        '
        Me.btnbookdisp.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnbookdisp.Location = New System.Drawing.Point(343, 222)
        Me.btnbookdisp.Name = "btnbookdisp"
        Me.btnbookdisp.Size = New System.Drawing.Size(93, 35)
        Me.btnbookdisp.TabIndex = 9
        Me.btnbookdisp.Text = "Display Bookings"
        Me.btnbookdisp.UseVisualStyleBackColor = True
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DateTimePicker1.Location = New System.Drawing.Point(934, 139)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 22)
        Me.DateTimePicker1.TabIndex = 5
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(65, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(80, 17)
        Me.Label2.TabIndex = 18
        Me.Label2.Text = "Booking No."
        '
        'txtbookno
        '
        Me.txtbookno.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookno.Location = New System.Drawing.Point(174, 27)
        Me.txtbookno.Name = "txtbookno"
        Me.txtbookno.Size = New System.Drawing.Size(129, 25)
        Me.txtbookno.TabIndex = 19
        '
        'lblbookdest
        '
        Me.lblbookdest.AutoSize = True
        Me.lblbookdest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookdest.Location = New System.Drawing.Point(71, 57)
        Me.lblbookdest.Name = "lblbookdest"
        Me.lblbookdest.Size = New System.Drawing.Size(73, 17)
        Me.lblbookdest.TabIndex = 20
        Me.lblbookdest.Text = "Destination"
        '
        'txtbookdest
        '
        Me.txtbookdest.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookdest.Location = New System.Drawing.Point(174, 53)
        Me.txtbookdest.Name = "txtbookdest"
        Me.txtbookdest.Size = New System.Drawing.Size(129, 25)
        Me.txtbookdest.TabIndex = 21
        '
        'lblbookdep
        '
        Me.lblbookdep.AutoSize = True
        Me.lblbookdep.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookdep.Location = New System.Drawing.Point(22, 82)
        Me.lblbookdep.Name = "lblbookdep"
        Me.lblbookdep.Size = New System.Drawing.Size(131, 17)
        Me.lblbookdep.TabIndex = 22
        Me.lblbookdep.Text = "Departure Date/Time"
        '
        'txtbookdep
        '
        Me.txtbookdep.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookdep.Location = New System.Drawing.Point(174, 79)
        Me.txtbookdep.Name = "txtbookdep"
        Me.txtbookdep.Size = New System.Drawing.Size(129, 25)
        Me.txtbookdep.TabIndex = 23
        '
        'lblbookarv
        '
        Me.lblbookarv.AutoSize = True
        Me.lblbookarv.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookarv.Location = New System.Drawing.Point(40, 108)
        Me.lblbookarv.Name = "lblbookarv"
        Me.lblbookarv.Size = New System.Drawing.Size(109, 17)
        Me.lblbookarv.TabIndex = 24
        Me.lblbookarv.Text = "Arrival Date/Time"
        '
        'txtbookarv
        '
        Me.txtbookarv.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookarv.Location = New System.Drawing.Point(174, 105)
        Me.txtbookarv.Name = "txtbookarv"
        Me.txtbookarv.Size = New System.Drawing.Size(129, 25)
        Me.txtbookarv.TabIndex = 25
        '
        'lblbookdur
        '
        Me.lblbookdur.AutoSize = True
        Me.lblbookdur.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookdur.Location = New System.Drawing.Point(35, 133)
        Me.lblbookdur.Name = "lblbookdur"
        Me.lblbookdur.Size = New System.Drawing.Size(117, 17)
        Me.lblbookdur.TabIndex = 26
        Me.lblbookdur.Text = "No. of Days/Hours"
        '
        'txtbookdur
        '
        Me.txtbookdur.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookdur.Location = New System.Drawing.Point(174, 131)
        Me.txtbookdur.Name = "txtbookdur"
        Me.txtbookdur.Size = New System.Drawing.Size(129, 25)
        Me.txtbookdur.TabIndex = 27
        '
        'lblbookpeople
        '
        Me.lblbookpeople.AutoSize = True
        Me.lblbookpeople.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookpeople.Location = New System.Drawing.Point(60, 160)
        Me.lblbookpeople.Name = "lblbookpeople"
        Me.lblbookpeople.Size = New System.Drawing.Size(90, 17)
        Me.lblbookpeople.TabIndex = 28
        Me.lblbookpeople.Text = "No. of people"
        '
        'txtbookpeople
        '
        Me.txtbookpeople.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookpeople.Location = New System.Drawing.Point(174, 157)
        Me.txtbookpeople.Name = "txtbookpeople"
        Me.txtbookpeople.Size = New System.Drawing.Size(129, 25)
        Me.txtbookpeople.TabIndex = 29
        '
        'lblrspkm
        '
        Me.lblrspkm.AutoSize = True
        Me.lblrspkm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblrspkm.Location = New System.Drawing.Point(85, 244)
        Me.lblrspkm.Name = "lblrspkm"
        Me.lblrspkm.Size = New System.Drawing.Size(52, 17)
        Me.lblrspkm.TabIndex = 30
        Me.lblrspkm.Text = "Rs./Km."
        '
        'txtrspkm
        '
        Me.txtrspkm.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtrspkm.Location = New System.Drawing.Point(174, 239)
        Me.txtrspkm.Name = "txtrspkm"
        Me.txtrspkm.Size = New System.Drawing.Size(129, 25)
        Me.txtrspkm.TabIndex = 31
        '
        'lblbooktax
        '
        Me.lblbooktax.AutoSize = True
        Me.lblbooktax.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbooktax.Location = New System.Drawing.Point(106, 268)
        Me.lblbooktax.Name = "lblbooktax"
        Me.lblbooktax.Size = New System.Drawing.Size(28, 17)
        Me.lblbooktax.TabIndex = 32
        Me.lblbooktax.Text = "Tax"
        '
        'txtbooktax
        '
        Me.txtbooktax.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbooktax.Location = New System.Drawing.Point(174, 265)
        Me.txtbooktax.Name = "txtbooktax"
        Me.txtbooktax.Size = New System.Drawing.Size(129, 25)
        Me.txtbooktax.TabIndex = 33
        '
        'lblbookremark
        '
        Me.lblbookremark.AutoSize = True
        Me.lblbookremark.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookremark.Location = New System.Drawing.Point(86, 186)
        Me.lblbookremark.Name = "lblbookremark"
        Me.lblbookremark.Size = New System.Drawing.Size(52, 17)
        Me.lblbookremark.TabIndex = 34
        Me.lblbookremark.Text = "Remark"
        '
        'txtbookremark
        '
        Me.txtbookremark.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookremark.Location = New System.Drawing.Point(174, 183)
        Me.txtbookremark.Multiline = True
        Me.txtbookremark.Name = "txtbookremark"
        Me.txtbookremark.Size = New System.Drawing.Size(129, 50)
        Me.txtbookremark.TabIndex = 35
        '
        'lblbookdeposit
        '
        Me.lblbookdeposit.AutoSize = True
        Me.lblbookdeposit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookdeposit.Location = New System.Drawing.Point(88, 322)
        Me.lblbookdeposit.Name = "lblbookdeposit"
        Me.lblbookdeposit.Size = New System.Drawing.Size(53, 17)
        Me.lblbookdeposit.TabIndex = 38
        Me.lblbookdeposit.Text = "Deposit"
        '
        'txtbookdeposit
        '
        Me.txtbookdeposit.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookdeposit.Location = New System.Drawing.Point(174, 317)
        Me.txtbookdeposit.Name = "txtbookdeposit"
        Me.txtbookdeposit.Size = New System.Drawing.Size(129, 25)
        Me.txtbookdeposit.TabIndex = 39
        '
        'lblbooktotal
        '
        Me.lblbooktotal.AutoSize = True
        Me.lblbooktotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbooktotal.Location = New System.Drawing.Point(100, 294)
        Me.lblbooktotal.Name = "lblbooktotal"
        Me.lblbooktotal.Size = New System.Drawing.Size(37, 17)
        Me.lblbooktotal.TabIndex = 40
        Me.lblbooktotal.Text = "Total"
        '
        'grpbooking
        '
        Me.grpbooking.Controls.Add(Me.btndelete)
        Me.grpbooking.Controls.Add(Me.btnupdate)
        Me.grpbooking.Controls.Add(Me.btninsert)
        Me.grpbooking.Controls.Add(Me.btnreset)
        Me.grpbooking.Controls.Add(Me.txtbookdue)
        Me.grpbooking.Controls.Add(Me.txtbooktotal)
        Me.grpbooking.Controls.Add(Me.btnbookdisp)
        Me.grpbooking.Controls.Add(Me.lblbookdue)
        Me.grpbooking.Controls.Add(Me.lblbooktotal)
        Me.grpbooking.Controls.Add(Me.txtbookdeposit)
        Me.grpbooking.Controls.Add(Me.lblbookdeposit)
        Me.grpbooking.Controls.Add(Me.txtbookremark)
        Me.grpbooking.Controls.Add(Me.lblbookremark)
        Me.grpbooking.Controls.Add(Me.txtbooktax)
        Me.grpbooking.Controls.Add(Me.lblbooktax)
        Me.grpbooking.Controls.Add(Me.txtrspkm)
        Me.grpbooking.Controls.Add(Me.lblrspkm)
        Me.grpbooking.Controls.Add(Me.txtbookpeople)
        Me.grpbooking.Controls.Add(Me.lblbookpeople)
        Me.grpbooking.Controls.Add(Me.txtbookdur)
        Me.grpbooking.Controls.Add(Me.lblbookdur)
        Me.grpbooking.Controls.Add(Me.txtbookarv)
        Me.grpbooking.Controls.Add(Me.lblbookarv)
        Me.grpbooking.Controls.Add(Me.txtbookdep)
        Me.grpbooking.Controls.Add(Me.lblbookdep)
        Me.grpbooking.Controls.Add(Me.txtbookdest)
        Me.grpbooking.Controls.Add(Me.lblbookdest)
        Me.grpbooking.Controls.Add(Me.txtbookno)
        Me.grpbooking.Controls.Add(Me.Label2)
        Me.grpbooking.Font = New System.Drawing.Font("Segoe UI", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.grpbooking.Location = New System.Drawing.Point(666, 167)
        Me.grpbooking.Name = "grpbooking"
        Me.grpbooking.Size = New System.Drawing.Size(474, 385)
        Me.grpbooking.TabIndex = 4
        Me.grpbooking.TabStop = False
        Me.grpbooking.Text = "Booking"
        '
        'btndelete
        '
        Me.btndelete.Location = New System.Drawing.Point(352, 155)
        Me.btndelete.Name = "btndelete"
        Me.btndelete.Size = New System.Drawing.Size(75, 27)
        Me.btndelete.TabIndex = 47
        Me.btndelete.Text = "Delete"
        Me.btndelete.UseVisualStyleBackColor = True
        '
        'btnupdate
        '
        Me.btnupdate.Location = New System.Drawing.Point(352, 103)
        Me.btnupdate.Name = "btnupdate"
        Me.btnupdate.Size = New System.Drawing.Size(75, 35)
        Me.btnupdate.TabIndex = 47
        Me.btnupdate.Text = "Update"
        Me.btnupdate.UseVisualStyleBackColor = True
        '
        'btninsert
        '
        Me.btninsert.Location = New System.Drawing.Point(352, 51)
        Me.btninsert.Name = "btninsert"
        Me.btninsert.Size = New System.Drawing.Size(75, 32)
        Me.btninsert.TabIndex = 47
        Me.btninsert.Text = "Insert"
        Me.btninsert.UseVisualStyleBackColor = True
        '
        'btnreset
        '
        Me.btnreset.Location = New System.Drawing.Point(352, 322)
        Me.btnreset.Name = "btnreset"
        Me.btnreset.Size = New System.Drawing.Size(75, 32)
        Me.btnreset.TabIndex = 47
        Me.btnreset.Text = "Reset"
        Me.btnreset.UseVisualStyleBackColor = True
        '
        'txtbookdue
        '
        Me.txtbookdue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbookdue.Location = New System.Drawing.Point(174, 343)
        Me.txtbookdue.Name = "txtbookdue"
        Me.txtbookdue.Size = New System.Drawing.Size(129, 25)
        Me.txtbookdue.TabIndex = 46
        '
        'txtbooktotal
        '
        Me.txtbooktotal.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtbooktotal.Location = New System.Drawing.Point(174, 291)
        Me.txtbooktotal.Name = "txtbooktotal"
        Me.txtbooktotal.Size = New System.Drawing.Size(129, 25)
        Me.txtbooktotal.TabIndex = 45
        '
        'lblbookdue
        '
        Me.lblbookdue.AutoSize = True
        Me.lblbookdue.Font = New System.Drawing.Font("Segoe UI", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblbookdue.Location = New System.Drawing.Point(104, 346)
        Me.lblbookdue.Name = "lblbookdue"
        Me.lblbookdue.Size = New System.Drawing.Size(31, 17)
        Me.lblbookdue.TabIndex = 44
        Me.lblbookdue.Text = "Due"
        '
        'Booking
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.Control
        Me.BackgroundImage = Global.Vehicle_Hiring_System.My.Resources.Resources.download__10_
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1220, 527)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.grpbooking)
        Me.Controls.Add(Me.grpcar)
        Me.Controls.Add(Me.grpdrv)
        Me.Controls.Add(Me.grpcli)
        Me.Controls.Add(Me.Label1)
        Me.Font = New System.Drawing.Font("Segoe UI", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Booking"
        Me.Text = "Booking Details"
        Me.grpcli.ResumeLayout(False)
        Me.grpcli.PerformLayout()
        Me.grpdrv.ResumeLayout(False)
        Me.grpdrv.PerformLayout()
        Me.grpcar.ResumeLayout(False)
        Me.grpcar.PerformLayout()
        Me.grpbooking.ResumeLayout(False)
        Me.grpbooking.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents grpcli As System.Windows.Forms.GroupBox
    Friend WithEvents grpdrv As System.Windows.Forms.GroupBox
    Friend WithEvents grpcar As System.Windows.Forms.GroupBox
    Friend WithEvents txtclino As System.Windows.Forms.TextBox
    Friend WithEvents lblclino As System.Windows.Forms.Label
    Friend WithEvents txtcliadd As System.Windows.Forms.TextBox
    Friend WithEvents lblcliadd As System.Windows.Forms.Label
    Friend WithEvents txtcliname As System.Windows.Forms.TextBox
    Friend WithEvents lblcliname As System.Windows.Forms.Label
    Friend WithEvents txtcliid As System.Windows.Forms.TextBox
    Friend WithEvents lblcliid As System.Windows.Forms.Label
    Friend WithEvents txtdrvno As System.Windows.Forms.TextBox
    Friend WithEvents lbldrvno As System.Windows.Forms.Label
    Friend WithEvents btndrvview As System.Windows.Forms.Button
    Friend WithEvents txtdrvname As System.Windows.Forms.TextBox
    Friend WithEvents lbldrvname As System.Windows.Forms.Label
    Friend WithEvents txtcarseater As System.Windows.Forms.TextBox
    Friend WithEvents lblcarseater As System.Windows.Forms.Label
    Friend WithEvents txtcarmake As System.Windows.Forms.TextBox
    Friend WithEvents lblcarmodel As System.Windows.Forms.Label
    Friend WithEvents txtcarid As System.Windows.Forms.TextBox
    Friend WithEvents lblcarid As System.Windows.Forms.Label
    Friend WithEvents btnbookdisp As System.Windows.Forms.Button
    Friend WithEvents DateTimePicker1 As System.Windows.Forms.DateTimePicker
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtbookno As System.Windows.Forms.TextBox
    Friend WithEvents lblbookdest As System.Windows.Forms.Label
    Friend WithEvents txtbookdest As System.Windows.Forms.TextBox
    Friend WithEvents lblbookdep As System.Windows.Forms.Label
    Friend WithEvents txtbookdep As System.Windows.Forms.TextBox
    Friend WithEvents lblbookarv As System.Windows.Forms.Label
    Friend WithEvents txtbookarv As System.Windows.Forms.TextBox
    Friend WithEvents lblbookdur As System.Windows.Forms.Label
    Friend WithEvents txtbookdur As System.Windows.Forms.TextBox
    Friend WithEvents lblbookpeople As System.Windows.Forms.Label
    Friend WithEvents txtbookpeople As System.Windows.Forms.TextBox
    Friend WithEvents lblrspkm As System.Windows.Forms.Label
    Friend WithEvents txtrspkm As System.Windows.Forms.TextBox
    Friend WithEvents lblbooktax As System.Windows.Forms.Label
    Friend WithEvents txtbooktax As System.Windows.Forms.TextBox
    Friend WithEvents lblbookremark As System.Windows.Forms.Label
    Friend WithEvents txtbookremark As System.Windows.Forms.TextBox
    Friend WithEvents lblbookdeposit As System.Windows.Forms.Label
    Friend WithEvents txtbookdeposit As System.Windows.Forms.TextBox
    Friend WithEvents lblbooktotal As System.Windows.Forms.Label
    Friend WithEvents grpbooking As System.Windows.Forms.GroupBox
    Friend WithEvents lblbookdue As System.Windows.Forms.Label
    Friend WithEvents btnscliview As System.Windows.Forms.Button
    Friend WithEvents btncarview As System.Windows.Forms.Button
    Friend WithEvents btndelete As System.Windows.Forms.Button
    Friend WithEvents btnupdate As System.Windows.Forms.Button
    Friend WithEvents btninsert As System.Windows.Forms.Button
    Friend WithEvents btnreset As System.Windows.Forms.Button
    Friend WithEvents txtbookdue As System.Windows.Forms.TextBox
    Friend WithEvents txtbooktotal As System.Windows.Forms.TextBox
    Friend WithEvents txtbookfuel As System.Windows.Forms.TextBox
    Friend WithEvents lblbookfuel As System.Windows.Forms.Label
End Class
