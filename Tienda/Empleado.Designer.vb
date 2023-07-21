<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Empleado))
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.fecha = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Apellido = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ci = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sueldo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Sexo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etiqueta_utilizado = New System.Windows.Forms.Label()
        Me.etiqueta_telefono = New System.Windows.Forms.Label()
        Me.etiqueta_direccion = New System.Windows.Forms.Label()
        Me.etiqueta_observacion = New System.Windows.Forms.Label()
        Me.etiqueta_sueldo = New System.Windows.Forms.Label()
        Me.etiqueta_email = New System.Windows.Forms.Label()
        Me.etiqueta_ci = New System.Windows.Forms.Label()
        Me.etiqueta_apellido = New System.Windows.Forms.Label()
        Me.etiqueta_nombre = New System.Windows.Forms.Label()
        Me.txt_fechanacimiento = New System.Windows.Forms.DateTimePicker()
        Me.cmb_sexo = New System.Windows.Forms.ComboBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.activo = New System.Windows.Forms.CheckBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.cmb_ciudad = New System.Windows.Forms.ComboBox()
        Me.cmb_departamento = New System.Windows.Forms.ComboBox()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.txt_sueldo = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_ci = New System.Windows.Forms.TextBox()
        Me.txt_apellido = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.txt_nombre = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ComboBusca = New System.Windows.Forms.ComboBox()
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
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
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.fecha, Me.Nombre, Me.Apellido, Me.ci, Me.Sueldo, Me.Departamento, Me.Observacion, Me.Telefono, Me.Ciudad, Me.direccion, Me.mail, Me.Estado, Me.Sexo})
        Me.tabla.EnableHeadersVisualStyles = False
        Me.tabla.GridColor = System.Drawing.Color.SteelBlue
        Me.tabla.Location = New System.Drawing.Point(48, 421)
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
        Me.tabla.Size = New System.Drawing.Size(890, 78)
        Me.tabla.TabIndex = 12
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "emp_id"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 63
        '
        'fecha
        '
        Me.fecha.DataPropertyName = "emp_fechanacimiento"
        Me.fecha.HeaderText = "fecha"
        Me.fecha.Name = "fecha"
        Me.fecha.ReadOnly = True
        Me.fecha.Visible = False
        Me.fecha.Width = 59
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "emp_nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 67
        '
        'Apellido
        '
        Me.Apellido.DataPropertyName = "emp_apellido"
        Me.Apellido.HeaderText = "Apellido"
        Me.Apellido.Name = "Apellido"
        Me.Apellido.ReadOnly = True
        Me.Apellido.Width = 67
        '
        'ci
        '
        Me.ci.DataPropertyName = "emp_ci"
        Me.ci.HeaderText = "Nro de C.I."
        Me.ci.Name = "ci"
        Me.ci.ReadOnly = True
        Me.ci.Width = 75
        '
        'Sueldo
        '
        Me.Sueldo.DataPropertyName = "emp_sueldo"
        Me.Sueldo.HeaderText = "Sueldo"
        Me.Sueldo.Name = "Sueldo"
        Me.Sueldo.ReadOnly = True
        Me.Sueldo.Width = 63
        '
        'Departamento
        '
        Me.Departamento.DataPropertyName = "dep_nombre"
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        Me.Departamento.Visible = False
        Me.Departamento.Width = 99
        '
        'Observacion
        '
        Me.Observacion.DataPropertyName = "emp_observacion"
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Visible = False
        Me.Observacion.Width = 92
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "emp_telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 72
        '
        'Ciudad
        '
        Me.Ciudad.DataPropertyName = "ciu_nombre"
        Me.Ciudad.HeaderText = "Ciudad"
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.ReadOnly = True
        Me.Ciudad.Width = 63
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "emp_direccion"
        Me.direccion.HeaderText = "Direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Width = 75
        '
        'mail
        '
        Me.mail.DataPropertyName = "emp_email"
        Me.mail.HeaderText = "Email"
        Me.mail.Name = "mail"
        Me.mail.ReadOnly = True
        Me.mail.Width = 55
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "emp_estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Visible = False
        Me.Estado.Width = 65
        '
        'Sexo
        '
        Me.Sexo.DataPropertyName = "emp_sexo"
        Me.Sexo.HeaderText = "Sexo"
        Me.Sexo.Name = "Sexo"
        Me.Sexo.ReadOnly = True
        Me.Sexo.Width = 54
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox1.Controls.Add(Me.etiqueta_utilizado)
        Me.GroupBox1.Controls.Add(Me.etiqueta_telefono)
        Me.GroupBox1.Controls.Add(Me.etiqueta_direccion)
        Me.GroupBox1.Controls.Add(Me.etiqueta_observacion)
        Me.GroupBox1.Controls.Add(Me.etiqueta_sueldo)
        Me.GroupBox1.Controls.Add(Me.etiqueta_email)
        Me.GroupBox1.Controls.Add(Me.etiqueta_ci)
        Me.GroupBox1.Controls.Add(Me.etiqueta_apellido)
        Me.GroupBox1.Controls.Add(Me.etiqueta_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_fechanacimiento)
        Me.GroupBox1.Controls.Add(Me.cmb_sexo)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
        Me.GroupBox1.Controls.Add(Me.Label13)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_mail)
        Me.GroupBox1.Controls.Add(Me.activo)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.cmb_ciudad)
        Me.GroupBox1.Controls.Add(Me.cmb_departamento)
        Me.GroupBox1.Controls.Add(Me.txt_observacion)
        Me.GroupBox1.Controls.Add(Me.txt_sueldo)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_ci)
        Me.GroupBox1.Controls.Add(Me.txt_apellido)
        Me.GroupBox1.Controls.Add(Me.Label6)
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Button2)
        Me.GroupBox1.Controls.Add(Me.Button4)
        Me.GroupBox1.Controls.Add(Me.Button3)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Button1)
        Me.GroupBox1.Controls.Add(Me.txt_nombre)
        Me.GroupBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.GroupBox1.Location = New System.Drawing.Point(54, 23)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(884, 280)
        Me.GroupBox1.TabIndex = 13
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'etiqueta_utilizado
        '
        Me.etiqueta_utilizado.AutoSize = True
        Me.etiqueta_utilizado.BackColor = System.Drawing.Color.White
        Me.etiqueta_utilizado.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_utilizado.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_utilizado.Location = New System.Drawing.Point(427, 31)
        Me.etiqueta_utilizado.Name = "etiqueta_utilizado"
        Me.etiqueta_utilizado.Size = New System.Drawing.Size(155, 17)
        Me.etiqueta_utilizado.TabIndex = 106
        Me.etiqueta_utilizado.Text = "C.I. ya ha sido Utilizado"
        Me.etiqueta_utilizado.Visible = False
        '
        'etiqueta_telefono
        '
        Me.etiqueta_telefono.AutoSize = True
        Me.etiqueta_telefono.BackColor = System.Drawing.Color.White
        Me.etiqueta_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_telefono.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_telefono.Location = New System.Drawing.Point(108, 146)
        Me.etiqueta_telefono.Name = "etiqueta_telefono"
        Me.etiqueta_telefono.Size = New System.Drawing.Size(160, 17)
        Me.etiqueta_telefono.TabIndex = 105
        Me.etiqueta_telefono.Text = "Favor Ingresar Telefono"
        '
        'etiqueta_direccion
        '
        Me.etiqueta_direccion.AutoSize = True
        Me.etiqueta_direccion.BackColor = System.Drawing.Color.White
        Me.etiqueta_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_direccion.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_direccion.Location = New System.Drawing.Point(109, 181)
        Me.etiqueta_direccion.Name = "etiqueta_direccion"
        Me.etiqueta_direccion.Size = New System.Drawing.Size(163, 17)
        Me.etiqueta_direccion.TabIndex = 104
        Me.etiqueta_direccion.Text = "Favor Ingresar Dirección"
        '
        'etiqueta_observacion
        '
        Me.etiqueta_observacion.AutoSize = True
        Me.etiqueta_observacion.BackColor = System.Drawing.Color.White
        Me.etiqueta_observacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_observacion.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_observacion.Location = New System.Drawing.Point(427, 181)
        Me.etiqueta_observacion.Name = "etiqueta_observacion"
        Me.etiqueta_observacion.Size = New System.Drawing.Size(184, 17)
        Me.etiqueta_observacion.TabIndex = 103
        Me.etiqueta_observacion.Text = "Favor Ingresar Observación"
        '
        'etiqueta_sueldo
        '
        Me.etiqueta_sueldo.AutoSize = True
        Me.etiqueta_sueldo.BackColor = System.Drawing.Color.White
        Me.etiqueta_sueldo.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_sueldo.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_sueldo.Location = New System.Drawing.Point(426, 109)
        Me.etiqueta_sueldo.Name = "etiqueta_sueldo"
        Me.etiqueta_sueldo.Size = New System.Drawing.Size(148, 17)
        Me.etiqueta_sueldo.TabIndex = 102
        Me.etiqueta_sueldo.Text = "Favor Ingresar Sueldo"
        '
        'etiqueta_email
        '
        Me.etiqueta_email.AutoSize = True
        Me.etiqueta_email.BackColor = System.Drawing.Color.White
        Me.etiqueta_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_email.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_email.Location = New System.Drawing.Point(426, 69)
        Me.etiqueta_email.Name = "etiqueta_email"
        Me.etiqueta_email.Size = New System.Drawing.Size(138, 17)
        Me.etiqueta_email.TabIndex = 101
        Me.etiqueta_email.Text = "Favor Ingresar Email"
        '
        'etiqueta_ci
        '
        Me.etiqueta_ci.AutoSize = True
        Me.etiqueta_ci.BackColor = System.Drawing.Color.White
        Me.etiqueta_ci.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_ci.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_ci.Location = New System.Drawing.Point(426, 30)
        Me.etiqueta_ci.Name = "etiqueta_ci"
        Me.etiqueta_ci.Size = New System.Drawing.Size(171, 17)
        Me.etiqueta_ci.TabIndex = 100
        Me.etiqueta_ci.Text = "Favor Ingresar Nro de C.I."
        '
        'etiqueta_apellido
        '
        Me.etiqueta_apellido.AutoSize = True
        Me.etiqueta_apellido.BackColor = System.Drawing.Color.White
        Me.etiqueta_apellido.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_apellido.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_apellido.Location = New System.Drawing.Point(109, 109)
        Me.etiqueta_apellido.Name = "etiqueta_apellido"
        Me.etiqueta_apellido.Size = New System.Drawing.Size(154, 17)
        Me.etiqueta_apellido.TabIndex = 99
        Me.etiqueta_apellido.Text = "Favor Ingresar Apellido"
        '
        'etiqueta_nombre
        '
        Me.etiqueta_nombre.AutoSize = True
        Me.etiqueta_nombre.BackColor = System.Drawing.Color.White
        Me.etiqueta_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_nombre.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_nombre.Location = New System.Drawing.Point(107, 71)
        Me.etiqueta_nombre.Name = "etiqueta_nombre"
        Me.etiqueta_nombre.Size = New System.Drawing.Size(154, 17)
        Me.etiqueta_nombre.TabIndex = 98
        Me.etiqueta_nombre.Text = "Favor Ingresar Nombre"
        '
        'txt_fechanacimiento
        '
        Me.txt_fechanacimiento.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fechanacimiento.Location = New System.Drawing.Point(418, 140)
        Me.txt_fechanacimiento.Name = "txt_fechanacimiento"
        Me.txt_fechanacimiento.Size = New System.Drawing.Size(134, 23)
        Me.txt_fechanacimiento.TabIndex = 41
        Me.txt_fechanacimiento.Value = New Date(2019, 9, 30, 0, 0, 0, 0)
        '
        'cmb_sexo
        '
        Me.cmb_sexo.FormattingEnabled = True
        Me.cmb_sexo.Items.AddRange(New Object() {"MASCULINO", "FEMENINO"})
        Me.cmb_sexo.Location = New System.Drawing.Point(737, 141)
        Me.cmb_sexo.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_sexo.Name = "cmb_sexo"
        Me.cmb_sexo.Size = New System.Drawing.Size(124, 25)
        Me.cmb_sexo.TabIndex = 39
        Me.cmb_sexo.Text = "Seleccione.."
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label15.Location = New System.Drawing.Point(329, 144)
        Me.Label15.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(84, 17)
        Me.Label15.TabIndex = 38
        Me.Label15.Text = "Fecha Nac.:"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label14.Location = New System.Drawing.Point(690, 145)
        Me.Label14.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(43, 17)
        Me.Label14.TabIndex = 37
        Me.Label14.Text = "Sexo:"
        '
        'txt_direccion
        '
        Me.txt_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_direccion.Location = New System.Drawing.Point(99, 177)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(177, 23)
        Me.txt_direccion.TabIndex = 36
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label13.Location = New System.Drawing.Point(24, 183)
        Me.Label13.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(71, 17)
        Me.Label13.TabIndex = 35
        Me.Label13.Text = "Dirección:"
        '
        'txt_id
        '
        Me.txt_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id.Location = New System.Drawing.Point(103, 34)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(75, 23)
        Me.txt_id.TabIndex = 34
        '
        'txt_mail
        '
        Me.txt_mail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_mail.Location = New System.Drawing.Point(418, 66)
        Me.txt_mail.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(198, 23)
        Me.txt_mail.TabIndex = 33
        '
        'activo
        '
        Me.activo.AutoSize = True
        Me.activo.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.activo.Location = New System.Drawing.Point(740, 107)
        Me.activo.Margin = New System.Windows.Forms.Padding(2)
        Me.activo.Name = "activo"
        Me.activo.Size = New System.Drawing.Size(90, 21)
        Me.activo.TabIndex = 32
        Me.activo.Text = "INACTIVO"
        Me.activo.UseVisualStyleBackColor = True
        '
        'txt_telefono
        '
        Me.txt_telefono.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_telefono.Location = New System.Drawing.Point(100, 144)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(176, 23)
        Me.txt_telefono.TabIndex = 31
        '
        'cmb_ciudad
        '
        Me.cmb_ciudad.FormattingEnabled = True
        Me.cmb_ciudad.Location = New System.Drawing.Point(737, 63)
        Me.cmb_ciudad.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_ciudad.Name = "cmb_ciudad"
        Me.cmb_ciudad.Size = New System.Drawing.Size(124, 25)
        Me.cmb_ciudad.TabIndex = 30
        Me.cmb_ciudad.Text = "Seleccione.."
        '
        'cmb_departamento
        '
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(737, 24)
        Me.cmb_departamento.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(124, 25)
        Me.cmb_departamento.TabIndex = 29
        Me.cmb_departamento.Text = "Seleccione.."
        '
        'txt_observacion
        '
        Me.txt_observacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_observacion.Location = New System.Drawing.Point(418, 177)
        Me.txt_observacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(198, 23)
        Me.txt_observacion.TabIndex = 28
        '
        'txt_sueldo
        '
        Me.txt_sueldo.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_sueldo.Location = New System.Drawing.Point(418, 105)
        Me.txt_sueldo.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_sueldo.Name = "txt_sueldo"
        Me.txt_sueldo.Size = New System.Drawing.Size(198, 23)
        Me.txt_sueldo.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label12.Location = New System.Drawing.Point(677, 110)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Estado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label11.Location = New System.Drawing.Point(321, 181)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Observación:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label10.Location = New System.Drawing.Point(677, 67)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ciudad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label9.Location = New System.Drawing.Point(631, 27)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Departamento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label8.Location = New System.Drawing.Point(356, 108)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(56, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "Sueldo:"
        '
        'txt_ci
        '
        Me.txt_ci.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ci.Location = New System.Drawing.Point(418, 27)
        Me.txt_ci.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ci.Name = "txt_ci"
        Me.txt_ci.Size = New System.Drawing.Size(198, 23)
        Me.txt_ci.TabIndex = 16
        '
        'txt_apellido
        '
        Me.txt_apellido.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_apellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido.Location = New System.Drawing.Point(100, 106)
        Me.txt_apellido.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_apellido.Name = "txt_apellido"
        Me.txt_apellido.Size = New System.Drawing.Size(176, 23)
        Me.txt_apellido.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label6.Location = New System.Drawing.Point(366, 69)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label5.Location = New System.Drawing.Point(353, 34)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(59, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Nro C.I.:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label4.Location = New System.Drawing.Point(27, 146)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Teléfono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label1.Location = New System.Drawing.Point(33, 108)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(62, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Apellido:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.Tienda.My.Resources.Resources.icons8_Edit_Property_50px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(487, 217)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(138, 53)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "        Editar"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Image = Global.Tienda.My.Resources.Resources.icons8_Trash_Can_50px_1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(657, 217)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(138, 53)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "        Eliminar"
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.Tienda.My.Resources.Resources.icons8_Plus_50px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(147, 217)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(129, 53)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "       Nuevo"
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label3.Location = New System.Drawing.Point(34, 69)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label2.Location = New System.Drawing.Point(40, 34)
        Me.Label2.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Código:"
        '
        'Button1
        '
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Button1.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button1.Image = Global.Tienda.My.Resources.Resources.icons8_Save_as_50px_2
        Me.Button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button1.Location = New System.Drawing.Point(304, 217)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(147, 53)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "          Guardar"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Location = New System.Drawing.Point(100, 67)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(176, 23)
        Me.txt_nombre.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Label7.Location = New System.Drawing.Point(53, 402)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(158, 17)
        Me.Label7.TabIndex = 15
        Me.Label7.Text = "Lista de los Empleados:"
        '
        'GroupBox2
        '
        Me.GroupBox2.Anchor = System.Windows.Forms.AnchorStyles.Top
        Me.GroupBox2.Controls.Add(Me.ComboBusca)
        Me.GroupBox2.Controls.Add(Me.txt_buscar)
        Me.GroupBox2.Controls.Add(Me.Label16)
        Me.GroupBox2.Controls.Add(Me.Label17)
        Me.GroupBox2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.GroupBox2.Location = New System.Drawing.Point(56, 314)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox2.Size = New System.Drawing.Size(882, 86)
        Me.GroupBox2.TabIndex = 82
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Buscar Empleados"
        '
        'ComboBusca
        '
        Me.ComboBusca.FormattingEnabled = True
        Me.ComboBusca.Items.AddRange(New Object() {"Nombre", "Apellido"})
        Me.ComboBusca.Location = New System.Drawing.Point(32, 38)
        Me.ComboBusca.Margin = New System.Windows.Forms.Padding(2)
        Me.ComboBusca.Name = "ComboBusca"
        Me.ComboBusca.Size = New System.Drawing.Size(161, 23)
        Me.ComboBusca.TabIndex = 19
        Me.ComboBusca.Text = "Nombre"
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(260, 40)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(141, 21)
        Me.txt_buscar.TabIndex = 2
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(33, 20)
        Me.Label16.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(182, 30)
        Me.Label16.TabIndex = 1
        Me.Label16.Text = "Seleccione el tipo de busqueda:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(261, 22)
        Me.Label17.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(153, 15)
        Me.Label17.TabIndex = 0
        Me.Label17.Text = "Escriba los datos a buscar:" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10)
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
        Me.btnCerrar.Location = New System.Drawing.Point(-4, -1)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(53, 53)
        Me.btnCerrar.TabIndex = 16
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Empleado
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(960, 510)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.tabla)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Empleado"
        Me.Text = "Empleado"
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabla As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents activo As System.Windows.Forms.CheckBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_departamento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_sueldo As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_ci As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents txt_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents cmb_sexo As System.Windows.Forms.ComboBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_fechanacimiento As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ComboBusca As System.Windows.Forms.ComboBox
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents etiqueta_telefono As System.Windows.Forms.Label
    Friend WithEvents etiqueta_direccion As System.Windows.Forms.Label
    Friend WithEvents etiqueta_observacion As System.Windows.Forms.Label
    Friend WithEvents etiqueta_sueldo As System.Windows.Forms.Label
    Friend WithEvents etiqueta_email As System.Windows.Forms.Label
    Friend WithEvents etiqueta_ci As System.Windows.Forms.Label
    Friend WithEvents etiqueta_apellido As System.Windows.Forms.Label
    Friend WithEvents etiqueta_nombre As System.Windows.Forms.Label
    Friend WithEvents etiqueta_utilizado As System.Windows.Forms.Label
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents fecha As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Apellido As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ci As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sueldo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ciudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Sexo As System.Windows.Forms.DataGridViewTextBoxColumn
End Class
