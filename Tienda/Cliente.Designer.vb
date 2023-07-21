<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cliente
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cliente))
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ruc = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etiqueta_telefono = New System.Windows.Forms.Label()
        Me.etiqueta_ciudad = New System.Windows.Forms.Label()
        Me.etiqueta_departamento = New System.Windows.Forms.Label()
        Me.etiqueta_sexo = New System.Windows.Forms.Label()
        Me.etiqueta_direccion = New System.Windows.Forms.Label()
        Me.etiqueta_email = New System.Windows.Forms.Label()
        Me.etiqueta_ruc = New System.Windows.Forms.Label()
        Me.etiqueta_cedula = New System.Windows.Forms.Label()
        Me.etiqueta_apellido = New System.Windows.Forms.Label()
        Me.etiqueta_nombre = New System.Windows.Forms.Label()
        Me.cmb_ciu = New System.Windows.Forms.ComboBox()
        Me.cmb_dep = New System.Windows.Forms.ComboBox()
        Me.btn_modificar = New System.Windows.Forms.Button()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.btn_nuevo = New System.Windows.Forms.Button()
        Me.btn_guardar = New System.Windows.Forms.Button()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.cmb_sexo = New System.Windows.Forms.ComboBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id_dep = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUC = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Email = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nro_CI = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBusca = New System.Windows.Forms.ComboBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(329, 110)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 17)
        Me.Label9.TabIndex = 74
        Me.Label9.Text = "Direccion:"
        '
        'txt_direccion
        '
        Me.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_direccion.Location = New System.Drawing.Point(408, 108)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(186, 23)
        Me.txt_direccion.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(16, 176)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(41, 17)
        Me.Label8.TabIndex = 72
        Me.Label8.Text = "RUC:"
        '
        'txt_ruc
        '
        Me.txt_ruc.Location = New System.Drawing.Point(82, 174)
        Me.txt_ruc.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(232, 23)
        Me.txt_ruc.TabIndex = 71
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(15, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 70
        Me.Label3.Text = "Codigo:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(15, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(62, 17)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Nombre:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(15, 102)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 68
        Me.Label1.Text = "Apellido:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(15, 134)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(56, 17)
        Me.Label4.TabIndex = 67
        Me.Label4.Text = "Cedula:"
        '
        'txt_mail
        '
        Me.txt_mail.Location = New System.Drawing.Point(408, 65)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(179, 23)
        Me.txt_mail.TabIndex = 66
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(701, 144)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(179, 23)
        Me.txt_telefono.TabIndex = 65
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(354, 151)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(43, 17)
        Me.Label7.TabIndex = 64
        Me.Label7.Text = "Sexo:"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(354, 70)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(627, 147)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(68, 17)
        Me.Label5.TabIndex = 62
        Me.Label5.Text = "Telefono:"
        '
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(82, 132)
        Me.txt_cedula.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(232, 23)
        Me.txt_cedula.TabIndex = 61
        '
        'txt_apellido
        '
        Me.txt_apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido.Location = New System.Drawing.Point(82, 97)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(232, 23)
        Me.txt_apellido.TabIndex = 60
        '
        'txt_nombre
        '
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Location = New System.Drawing.Point(82, 62)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(232, 23)
        Me.txt_nombre.TabIndex = 59
        '
        'txt_id
        '
        Me.txt_id.Location = New System.Drawing.Point(83, 25)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(4)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(84, 23)
        Me.txt_id.TabIndex = 58
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.etiqueta_telefono)
        Me.GroupBox1.Controls.Add(Me.etiqueta_ciudad)
        Me.GroupBox1.Controls.Add(Me.etiqueta_departamento)
        Me.GroupBox1.Controls.Add(Me.etiqueta_sexo)
        Me.GroupBox1.Controls.Add(Me.etiqueta_direccion)
        Me.GroupBox1.Controls.Add(Me.etiqueta_email)
        Me.GroupBox1.Controls.Add(Me.etiqueta_ruc)
        Me.GroupBox1.Controls.Add(Me.etiqueta_cedula)
        Me.GroupBox1.Controls.Add(Me.etiqueta_apellido)
        Me.GroupBox1.Controls.Add(Me.etiqueta_nombre)
        Me.GroupBox1.Controls.Add(Me.cmb_ciu)
        Me.GroupBox1.Controls.Add(Me.cmb_dep)
        Me.GroupBox1.Controls.Add(Me.btn_modificar)
        Me.GroupBox1.Controls.Add(Me.btn_eliminar)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo)
        Me.GroupBox1.Controls.Add(Me.btn_guardar)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.txt_cedula)
        Me.GroupBox1.Controls.Add(Me.cmb_sexo)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label7)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.txt_mail)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_ruc)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(47, 23)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(896, 269)
        Me.GroupBox1.TabIndex = 76
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'etiqueta_telefono
        '
        Me.etiqueta_telefono.AutoSize = True
        Me.etiqueta_telefono.BackColor = System.Drawing.Color.White
        Me.etiqueta_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_telefono.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_telefono.Location = New System.Drawing.Point(720, 147)
        Me.etiqueta_telefono.Name = "etiqueta_telefono"
        Me.etiqueta_telefono.Size = New System.Drawing.Size(160, 17)
        Me.etiqueta_telefono.TabIndex = 97
        Me.etiqueta_telefono.Text = "Favor Ingresar Telefono"
        '
        'etiqueta_ciudad
        '
        Me.etiqueta_ciudad.AutoSize = True
        Me.etiqueta_ciudad.BackColor = System.Drawing.Color.White
        Me.etiqueta_ciudad.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_ciudad.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_ciudad.Location = New System.Drawing.Point(707, 108)
        Me.etiqueta_ciudad.Name = "etiqueta_ciudad"
        Me.etiqueta_ciudad.Size = New System.Drawing.Size(86, 17)
        Me.etiqueta_ciudad.TabIndex = 96
        Me.etiqueta_ciudad.Text = "Seleccionar "
        '
        'etiqueta_departamento
        '
        Me.etiqueta_departamento.AutoSize = True
        Me.etiqueta_departamento.BackColor = System.Drawing.Color.White
        Me.etiqueta_departamento.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_departamento.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_departamento.Location = New System.Drawing.Point(707, 67)
        Me.etiqueta_departamento.Name = "etiqueta_departamento"
        Me.etiqueta_departamento.Size = New System.Drawing.Size(86, 17)
        Me.etiqueta_departamento.TabIndex = 95
        Me.etiqueta_departamento.Text = "Seleccionar "
        '
        'etiqueta_sexo
        '
        Me.etiqueta_sexo.AutoSize = True
        Me.etiqueta_sexo.BackColor = System.Drawing.Color.White
        Me.etiqueta_sexo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_sexo.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_sexo.Location = New System.Drawing.Point(431, 154)
        Me.etiqueta_sexo.Name = "etiqueta_sexo"
        Me.etiqueta_sexo.Size = New System.Drawing.Size(137, 17)
        Me.etiqueta_sexo.TabIndex = 94
        Me.etiqueta_sexo.Text = "Seleccionar un Sexo"
        '
        'etiqueta_direccion
        '
        Me.etiqueta_direccion.AutoSize = True
        Me.etiqueta_direccion.BackColor = System.Drawing.Color.White
        Me.etiqueta_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_direccion.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_direccion.Location = New System.Drawing.Point(424, 111)
        Me.etiqueta_direccion.Name = "etiqueta_direccion"
        Me.etiqueta_direccion.Size = New System.Drawing.Size(163, 17)
        Me.etiqueta_direccion.TabIndex = 93
        Me.etiqueta_direccion.Text = "Favor Ingresar Direccion"
        '
        'etiqueta_email
        '
        Me.etiqueta_email.AutoSize = True
        Me.etiqueta_email.BackColor = System.Drawing.Color.White
        Me.etiqueta_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_email.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_email.Location = New System.Drawing.Point(431, 67)
        Me.etiqueta_email.Name = "etiqueta_email"
        Me.etiqueta_email.Size = New System.Drawing.Size(142, 17)
        Me.etiqueta_email.TabIndex = 92
        Me.etiqueta_email.Text = " Favor Ingresar Email"
        '
        'etiqueta_ruc
        '
        Me.etiqueta_ruc.AutoSize = True
        Me.etiqueta_ruc.BackColor = System.Drawing.Color.White
        Me.etiqueta_ruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_ruc.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_ruc.Location = New System.Drawing.Point(103, 176)
        Me.etiqueta_ruc.Name = "etiqueta_ruc"
        Me.etiqueta_ruc.Size = New System.Drawing.Size(184, 17)
        Me.etiqueta_ruc.TabIndex = 91
        Me.etiqueta_ruc.Text = " Favor Ingresar Nro de RUC"
        '
        'etiqueta_cedula
        '
        Me.etiqueta_cedula.AutoSize = True
        Me.etiqueta_cedula.BackColor = System.Drawing.Color.White
        Me.etiqueta_cedula.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_cedula.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_cedula.Location = New System.Drawing.Point(140, 135)
        Me.etiqueta_cedula.Name = "etiqueta_cedula"
        Me.etiqueta_cedula.Size = New System.Drawing.Size(128, 17)
        Me.etiqueta_cedula.TabIndex = 90
        Me.etiqueta_cedula.Text = " Favor Ingresar C.I."
        '
        'etiqueta_apellido
        '
        Me.etiqueta_apellido.AutoSize = True
        Me.etiqueta_apellido.BackColor = System.Drawing.Color.White
        Me.etiqueta_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_apellido.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_apellido.Location = New System.Drawing.Point(109, 100)
        Me.etiqueta_apellido.Name = "etiqueta_apellido"
        Me.etiqueta_apellido.Size = New System.Drawing.Size(178, 17)
        Me.etiqueta_apellido.TabIndex = 89
        Me.etiqueta_apellido.Text = " Favor Ingresar un Apellido"
        '
        'etiqueta_nombre
        '
        Me.etiqueta_nombre.AutoSize = True
        Me.etiqueta_nombre.BackColor = System.Drawing.Color.White
        Me.etiqueta_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_nombre.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_nombre.Location = New System.Drawing.Point(109, 65)
        Me.etiqueta_nombre.Name = "etiqueta_nombre"
        Me.etiqueta_nombre.Size = New System.Drawing.Size(178, 17)
        Me.etiqueta_nombre.TabIndex = 88
        Me.etiqueta_nombre.Text = " Favor Ingresar un Nombre"
        '
        'cmb_ciu
        '
        Me.cmb_ciu.FormattingEnabled = True
        Me.cmb_ciu.Location = New System.Drawing.Point(701, 105)
        Me.cmb_ciu.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_ciu.Name = "cmb_ciu"
        Me.cmb_ciu.Size = New System.Drawing.Size(179, 25)
        Me.cmb_ciu.TabIndex = 87
        '
        'cmb_dep
        '
        Me.cmb_dep.FormattingEnabled = True
        Me.cmb_dep.Location = New System.Drawing.Point(701, 65)
        Me.cmb_dep.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_dep.Name = "cmb_dep"
        Me.cmb_dep.Size = New System.Drawing.Size(179, 25)
        Me.cmb_dep.TabIndex = 86
        '
        'btn_modificar
        '
        Me.btn_modificar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_modificar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_modificar.Image = Global.Tienda.My.Resources.Resources.icons8_Edit_Property_50px
        Me.btn_modificar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_modificar.Location = New System.Drawing.Point(449, 212)
        Me.btn_modificar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_modificar.Name = "btn_modificar"
        Me.btn_modificar.Size = New System.Drawing.Size(124, 52)
        Me.btn_modificar.TabIndex = 83
        Me.btn_modificar.Text = "        Editar"
        Me.btn_modificar.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Transparent
        Me.btn_eliminar.Image = Global.Tienda.My.Resources.Resources.icons8_Trash_Can_50px_1
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(610, 212)
        Me.btn_eliminar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(121, 52)
        Me.btn_eliminar.TabIndex = 84
        Me.btn_eliminar.Text = "         Eliminar"
        Me.btn_eliminar.UseVisualStyleBackColor = False
        '
        'btn_nuevo
        '
        Me.btn_nuevo.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_nuevo.ForeColor = System.Drawing.Color.Transparent
        Me.btn_nuevo.Image = Global.Tienda.My.Resources.Resources.icons8_Add_User_Male_50px_2
        Me.btn_nuevo.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo.Location = New System.Drawing.Point(112, 212)
        Me.btn_nuevo.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_nuevo.Name = "btn_nuevo"
        Me.btn_nuevo.Size = New System.Drawing.Size(124, 52)
        Me.btn_nuevo.TabIndex = 85
        Me.btn_nuevo.Text = "       Nuevo"
        Me.btn_nuevo.UseVisualStyleBackColor = False
        '
        'btn_guardar
        '
        Me.btn_guardar.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btn_guardar.BackColor = System.Drawing.SystemColors.HotTrack
        Me.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btn_guardar.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.btn_guardar.Image = Global.Tienda.My.Resources.Resources.icons8_Save_as_50px_2
        Me.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar.Location = New System.Drawing.Point(293, 212)
        Me.btn_guardar.Margin = New System.Windows.Forms.Padding(2)
        Me.btn_guardar.Name = "btn_guardar"
        Me.btn_guardar.Size = New System.Drawing.Size(137, 52)
        Me.btn_guardar.TabIndex = 82
        Me.btn_guardar.Text = "           Guardar"
        Me.btn_guardar.UseVisualStyleBackColor = False
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(639, 108)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Ciudad:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(593, 65)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(102, 17)
        Me.Label11.TabIndex = 78
        Me.Label11.Text = "Departamento:"
        '
        'cmb_sexo
        '
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cmb_sexo.Location = New System.Drawing.Point(408, 151)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(179, 25)
        Me.cmb_sexo.TabIndex = 77
        '
        'Label10
        '
        Me.Label10.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(50, 378)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(138, 17)
        Me.Label10.TabIndex = 77
        Me.Label10.Text = "Lista de los Clientes:"
        '
        'tabla
        '
        Me.tabla.AllowUserToAddRows = False
        Me.tabla.AllowUserToDeleteRows = False
        Me.tabla.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.tabla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tabla.ColumnHeadersHeight = 30
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.id_dep, Me.id, Me.Nombre, Me.Apellido, Me.Direccion, Me.Sexo, Me.Telefono, Me.RUC, Me.Email, Me.Nro_CI, Me.Ciudad})
        Me.tabla.EnableHeadersVisualStyles = False
        Me.tabla.GridColor = System.Drawing.Color.SteelBlue
        Me.tabla.Location = New System.Drawing.Point(46, 397)
        Me.tabla.Margin = New System.Windows.Forms.Padding(2)
        Me.tabla.Name = "tabla"
        Me.tabla.ReadOnly = True
        Me.tabla.RightToLeft = System.Windows.Forms.RightToLeft.No
        Me.tabla.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Microsoft Sans Serif", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.Info
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.InactiveCaption
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla.RowHeadersDefaultCellStyle = DataGridViewCellStyle2
        DataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Century Gothic", 7.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SteelBlue
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White
        Me.tabla.RowsDefaultCellStyle = DataGridViewCellStyle3
        Me.tabla.RowTemplate.Height = 24
        Me.tabla.Size = New System.Drawing.Size(897, 124)
        Me.tabla.TabIndex = 78
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "cli_id"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 63
        '
        'id_dep
        '
        Me.id_dep.DataPropertyName = "Departamento_dep_id"
        Me.id_dep.HeaderText = "id_dep"
        Me.id_dep.Name = "id_dep"
        Me.id_dep.ReadOnly = True
        Me.id_dep.Visible = False
        Me.id_dep.Width = 64
        '
        'id
        '
        Me.id.DataPropertyName = "ciu_id"
        Me.id.HeaderText = "id"
        Me.id.Name = "id"
        Me.id.ReadOnly = True
        Me.id.Visible = False
        Me.id.Width = 40
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "cli_nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 67
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "cli_apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 67
        '
        'Direccion
        '
        Me.Direccion.DataPropertyName = "cli_direccion"
        Me.Direccion.HeaderText = "Direccion"
        Me.Direccion.Name = "Direccion"
        Me.Direccion.ReadOnly = True
        Me.Direccion.Width = 75
        '
        'Sexo
        '
        Me.Sexo.DataPropertyName = "cli_sexo"
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        Me.Sexo.Width = 54
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "cli_telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 72
        '
        'RUC
        '
        Me.RUC.DataPropertyName = "cli_ruc"
        Me.RUC.HeaderText = "RUC"
        Me.RUC.Name = "RUC"
        Me.RUC.ReadOnly = True
        Me.RUC.Width = 53
        '
        'Email
        '
        Me.Email.DataPropertyName = "cli_email"
        Me.Email.HeaderText = "Email"
        Me.Email.Name = "Email"
        Me.Email.ReadOnly = True
        Me.Email.Width = 55
        '
        'Nro_CI
        '
        Me.Nro_CI.DataPropertyName = "cli_ci"
        Me.Nro_CI.HeaderText = "Nro C.I."
        Me.Nro_CI.Name = "Nro_CI"
        Me.Nro_CI.ReadOnly = True
        Me.Nro_CI.Width = 47
        '
        'Ciudad
        '
        Me.Ciudad.DataPropertyName = "ciu_nombre"
        Me.Ciudad.HeaderText = "Ciudad"
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.ReadOnly = True
        Me.Ciudad.Width = 63
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.ComboBusca)
        Me.GroupBox2.Controls.Add(Me.txt_buscar)
        Me.GroupBox2.Controls.Add(Me.Label13)
        Me.GroupBox2.Controls.Add(Me.Label14)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(46, 291)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(897, 87)
        Me.GroupBox2.TabIndex = 80
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Clientes"
        '
        'ComboBusca
        '
        Me.ComboBusca.FormattingEnabled = True
        Me.ComboBusca.Items.AddRange(New Object() {"Nombre", "Apellido"})
        Me.ComboBusca.Location = New System.Drawing.Point(35, 38)
        Me.ComboBusca.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBusca.Name = "ComboBusca"
        Me.ComboBusca.Size = New System.Drawing.Size(186, 23)
        Me.ComboBusca.TabIndex = 19
        Me.ComboBusca.Text = "Nombre"
        '
        'txt_buscar
        '
        Me.txt_buscar.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_buscar.Location = New System.Drawing.Point(263, 40)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(166, 21)
        Me.txt_buscar.TabIndex = 2
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.Location = New System.Drawing.Point(33, 20)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(182, 30)
        Me.Label13.TabIndex = 1
        Me.Label13.Text = "Seleccione el tipo de busqueda:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.Location = New System.Drawing.Point(261, 22)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(153, 15)
        Me.Label14.TabIndex = 0
        Me.Label14.Text = "Escriba los datos a buscar:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label15
        '
        Me.Label15.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label15.AutoSize = True
        Me.Label15.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(76, 524)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(122, 18)
        Me.Label15.TabIndex = 81
        Me.Label15.Text = "Total de Clientes:"
        '
        'txt_total
        '
        Me.txt_total.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_total.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total.Location = New System.Drawing.Point(203, 525)
        Me.txt_total.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(38, 21)
        Me.txt_total.TabIndex = 82
        '
        'btnCerrar
        '
        Me.btnCerrar.FlatAppearance.BorderSize = 0
        Me.btnCerrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.CornflowerBlue
        Me.btnCerrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue
        Me.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnCerrar.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnCerrar.ForeColor = System.Drawing.Color.Silver
        Me.btnCerrar.Image = CType(resources.GetObject("btnCerrar.Image"), System.Drawing.Image)
        Me.btnCerrar.Location = New System.Drawing.Point(-2, -2)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(51, 43)
        Me.btnCerrar.TabIndex = 79
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.Color.Transparent
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(775, 212)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(116, 52)
        Me.Button1.TabIndex = 98
        Me.Button1.Text = "   REPORTE"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Cliente
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(974, 556)
        Me.Controls.Add(Me.txt_total)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.Label10)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Cliente"
        Me.Text = "Form2"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents cmb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents btn_modificar As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo As System.Windows.Forms.Button
    Friend WithEvents btn_guardar As System.Windows.Forms.Button
    Friend WithEvents cmb_dep As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_ciu As System.Windows.Forms.ComboBox
    Friend WithEvents tabla As System.Windows.Forms.DataGridView
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id_dep As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents id As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents RUC As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Email As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nro_CI As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ciudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBusca As System.Windows.Forms.ComboBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents etiqueta_nombre As System.Windows.Forms.Label
    Friend WithEvents etiqueta_ruc As System.Windows.Forms.Label
    Friend WithEvents etiqueta_cedula As System.Windows.Forms.Label
    Friend WithEvents etiqueta_apellido As System.Windows.Forms.Label
    Friend WithEvents etiqueta_telefono As System.Windows.Forms.Label
    Friend WithEvents etiqueta_ciudad As System.Windows.Forms.Label
    Friend WithEvents etiqueta_departamento As System.Windows.Forms.Label
    Friend WithEvents etiqueta_sexo As System.Windows.Forms.Label
    Friend WithEvents etiqueta_direccion As System.Windows.Forms.Label
    Friend WithEvents etiqueta_email As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents Button1 As System.Windows.Forms.Button
End Class
