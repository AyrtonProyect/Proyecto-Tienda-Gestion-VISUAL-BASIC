<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Proveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Proveedor))
        Me.tabla = New System.Windows.Forms.DataGridView()
        Me.Codigo = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Departamento = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Observacion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Telefono = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Ciudad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ruc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.direccion = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.mail = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.pag = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Estado = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.etiqueta_ruc = New System.Windows.Forms.Label()
        Me.etiqueta_observacion = New System.Windows.Forms.Label()
        Me.etiqueta_web = New System.Windows.Forms.Label()
        Me.etiqueta_email = New System.Windows.Forms.Label()
        Me.etiqueta_telefono = New System.Windows.Forms.Label()
        Me.etiqueta_direccion = New System.Windows.Forms.Label()
        Me.etiqueta_nombre = New System.Windows.Forms.Label()
        Me.txt_id = New System.Windows.Forms.TextBox()
        Me.txt_mail = New System.Windows.Forms.TextBox()
        Me.activo = New System.Windows.Forms.CheckBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.cmb_ciudad = New System.Windows.Forms.ComboBox()
        Me.cmb_departamento = New System.Windows.Forms.ComboBox()
        Me.txt_observacion = New System.Windows.Forms.TextBox()
        Me.txt_ruc = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_web = New System.Windows.Forms.TextBox()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
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
        Me.txt_buscar = New System.Windows.Forms.TextBox()
        Me.btnCerrar = New System.Windows.Forms.Button()
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'tabla
        '
        Me.tabla.AllowUserToAddRows = False
        Me.tabla.AllowUserToDeleteRows = False
        Me.tabla.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.tabla.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.tabla.BackgroundColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.tabla.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None
        DataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter
        DataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.HotTrack
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Century Gothic", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.Color.White
        DataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.tabla.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle1
        Me.tabla.ColumnHeadersHeight = 30
        Me.tabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing
        Me.tabla.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Codigo, Me.Nombre, Me.Departamento, Me.Observacion, Me.Telefono, Me.Ciudad, Me.ruc, Me.direccion, Me.mail, Me.pag, Me.Estado})
        Me.tabla.EnableHeadersVisualStyles = False
        Me.tabla.GridColor = System.Drawing.Color.SteelBlue
        Me.tabla.Location = New System.Drawing.Point(42, 350)
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
        Me.tabla.Size = New System.Drawing.Size(581, 159)
        Me.tabla.TabIndex = 11
        '
        'Codigo
        '
        Me.Codigo.DataPropertyName = "prov_id"
        Me.Codigo.HeaderText = "Codigo"
        Me.Codigo.Name = "Codigo"
        Me.Codigo.ReadOnly = True
        Me.Codigo.Width = 75
        '
        'Nombre
        '
        Me.Nombre.DataPropertyName = "prov_nombre"
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 79
        '
        'Departamento
        '
        Me.Departamento.DataPropertyName = "dep_nombre"
        Me.Departamento.HeaderText = "Departamento"
        Me.Departamento.Name = "Departamento"
        Me.Departamento.ReadOnly = True
        Me.Departamento.Visible = False
        Me.Departamento.Width = 122
        '
        'Observacion
        '
        Me.Observacion.DataPropertyName = "prov_observacion"
        Me.Observacion.HeaderText = "Observacion"
        Me.Observacion.Name = "Observacion"
        Me.Observacion.ReadOnly = True
        Me.Observacion.Visible = False
        Me.Observacion.Width = 110
        '
        'Telefono
        '
        Me.Telefono.DataPropertyName = "prov_telefono"
        Me.Telefono.HeaderText = "Telefono"
        Me.Telefono.Name = "Telefono"
        Me.Telefono.ReadOnly = True
        Me.Telefono.Width = 82
        '
        'Ciudad
        '
        Me.Ciudad.DataPropertyName = "ciu_nombre"
        Me.Ciudad.HeaderText = "Ciudad"
        Me.Ciudad.Name = "Ciudad"
        Me.Ciudad.ReadOnly = True
        Me.Ciudad.Width = 74
        '
        'ruc
        '
        Me.ruc.DataPropertyName = "prov_ruc"
        Me.ruc.HeaderText = "ruc"
        Me.ruc.Name = "ruc"
        Me.ruc.ReadOnly = True
        Me.ruc.Visible = False
        Me.ruc.Width = 52
        '
        'direccion
        '
        Me.direccion.DataPropertyName = "prov_direccion"
        Me.direccion.HeaderText = "direccion"
        Me.direccion.Name = "direccion"
        Me.direccion.ReadOnly = True
        Me.direccion.Visible = False
        Me.direccion.Width = 90
        '
        'mail
        '
        Me.mail.DataPropertyName = "prov_email"
        Me.mail.HeaderText = "mail"
        Me.mail.Name = "mail"
        Me.mail.ReadOnly = True
        Me.mail.Visible = False
        Me.mail.Width = 58
        '
        'pag
        '
        Me.pag.DataPropertyName = "prov_pag_web"
        Me.pag.HeaderText = "pag"
        Me.pag.Name = "pag"
        Me.pag.ReadOnly = True
        Me.pag.Visible = False
        Me.pag.Width = 57
        '
        'Estado
        '
        Me.Estado.DataPropertyName = "prov_estado"
        Me.Estado.HeaderText = "Estado"
        Me.Estado.Name = "Estado"
        Me.Estado.ReadOnly = True
        Me.Estado.Width = 71
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.SystemColors.Control
        Me.Label7.Location = New System.Drawing.Point(47, 326)
        Me.Label7.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(169, 17)
        Me.Label7.TabIndex = 10
        Me.Label7.Text = "Lista de los Proveedores:"
        '
        'GroupBox1
        '
        Me.GroupBox1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GroupBox1.Controls.Add(Me.etiqueta_ruc)
        Me.GroupBox1.Controls.Add(Me.etiqueta_observacion)
        Me.GroupBox1.Controls.Add(Me.etiqueta_web)
        Me.GroupBox1.Controls.Add(Me.etiqueta_email)
        Me.GroupBox1.Controls.Add(Me.etiqueta_telefono)
        Me.GroupBox1.Controls.Add(Me.etiqueta_direccion)
        Me.GroupBox1.Controls.Add(Me.etiqueta_nombre)
        Me.GroupBox1.Controls.Add(Me.txt_id)
        Me.GroupBox1.Controls.Add(Me.txt_mail)
        Me.GroupBox1.Controls.Add(Me.activo)
        Me.GroupBox1.Controls.Add(Me.txt_telefono)
        Me.GroupBox1.Controls.Add(Me.cmb_ciudad)
        Me.GroupBox1.Controls.Add(Me.cmb_departamento)
        Me.GroupBox1.Controls.Add(Me.txt_observacion)
        Me.GroupBox1.Controls.Add(Me.txt_ruc)
        Me.GroupBox1.Controls.Add(Me.Label12)
        Me.GroupBox1.Controls.Add(Me.Label11)
        Me.GroupBox1.Controls.Add(Me.Label10)
        Me.GroupBox1.Controls.Add(Me.Label9)
        Me.GroupBox1.Controls.Add(Me.Label8)
        Me.GroupBox1.Controls.Add(Me.txt_web)
        Me.GroupBox1.Controls.Add(Me.txt_direccion)
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
        Me.GroupBox1.ForeColor = System.Drawing.SystemColors.Control
        Me.GroupBox1.Location = New System.Drawing.Point(42, 39)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(2)
        Me.GroupBox1.Size = New System.Drawing.Size(899, 270)
        Me.GroupBox1.TabIndex = 9
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Mantenimiento"
        '
        'etiqueta_ruc
        '
        Me.etiqueta_ruc.AutoSize = True
        Me.etiqueta_ruc.BackColor = System.Drawing.SystemColors.Control
        Me.etiqueta_ruc.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_ruc.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_ruc.Location = New System.Drawing.Point(105, 96)
        Me.etiqueta_ruc.Name = "etiqueta_ruc"
        Me.etiqueta_ruc.Size = New System.Drawing.Size(133, 17)
        Me.etiqueta_ruc.TabIndex = 106
        Me.etiqueta_ruc.Text = "Favor Ingresar RUC"
        '
        'etiqueta_observacion
        '
        Me.etiqueta_observacion.AutoSize = True
        Me.etiqueta_observacion.BackColor = System.Drawing.SystemColors.Control
        Me.etiqueta_observacion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_observacion.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_observacion.Location = New System.Drawing.Point(401, 164)
        Me.etiqueta_observacion.Name = "etiqueta_observacion"
        Me.etiqueta_observacion.Size = New System.Drawing.Size(144, 17)
        Me.etiqueta_observacion.TabIndex = 105
        Me.etiqueta_observacion.Text = "Ingresar Observacion"
        '
        'etiqueta_web
        '
        Me.etiqueta_web.AutoSize = True
        Me.etiqueta_web.BackColor = System.Drawing.SystemColors.Control
        Me.etiqueta_web.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_web.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_web.Location = New System.Drawing.Point(407, 93)
        Me.etiqueta_web.Name = "etiqueta_web"
        Me.etiqueta_web.Size = New System.Drawing.Size(161, 17)
        Me.etiqueta_web.TabIndex = 104
        Me.etiqueta_web.Text = "Favor Ingrese Pag. Web"
        '
        'etiqueta_email
        '
        Me.etiqueta_email.AutoSize = True
        Me.etiqueta_email.BackColor = System.Drawing.SystemColors.Control
        Me.etiqueta_email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_email.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_email.Location = New System.Drawing.Point(407, 130)
        Me.etiqueta_email.Name = "etiqueta_email"
        Me.etiqueta_email.Size = New System.Drawing.Size(138, 17)
        Me.etiqueta_email.TabIndex = 103
        Me.etiqueta_email.Text = "Favor Ingresar Email"
        '
        'etiqueta_telefono
        '
        Me.etiqueta_telefono.AutoSize = True
        Me.etiqueta_telefono.BackColor = System.Drawing.SystemColors.Control
        Me.etiqueta_telefono.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_telefono.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_telefono.Location = New System.Drawing.Point(105, 126)
        Me.etiqueta_telefono.Name = "etiqueta_telefono"
        Me.etiqueta_telefono.Size = New System.Drawing.Size(160, 17)
        Me.etiqueta_telefono.TabIndex = 101
        Me.etiqueta_telefono.Text = "Favor Ingresar Telefono"
        '
        'etiqueta_direccion
        '
        Me.etiqueta_direccion.AutoSize = True
        Me.etiqueta_direccion.BackColor = System.Drawing.SystemColors.Control
        Me.etiqueta_direccion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_direccion.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_direccion.Location = New System.Drawing.Point(398, 58)
        Me.etiqueta_direccion.Name = "etiqueta_direccion"
        Me.etiqueta_direccion.Size = New System.Drawing.Size(158, 17)
        Me.etiqueta_direccion.TabIndex = 100
        Me.etiqueta_direccion.Text = "Favor Ingrese Direccion"
        '
        'etiqueta_nombre
        '
        Me.etiqueta_nombre.AutoSize = True
        Me.etiqueta_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.etiqueta_nombre.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.2!)
        Me.etiqueta_nombre.ForeColor = System.Drawing.SystemColors.ButtonShadow
        Me.etiqueta_nombre.Location = New System.Drawing.Point(105, 61)
        Me.etiqueta_nombre.Name = "etiqueta_nombre"
        Me.etiqueta_nombre.Size = New System.Drawing.Size(154, 17)
        Me.etiqueta_nombre.TabIndex = 99
        Me.etiqueta_nombre.Text = "Favor Ingresar Nombre"
        '
        'txt_id
        '
        Me.txt_id.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_id.BackColor = System.Drawing.SystemColors.Control
        Me.txt_id.Location = New System.Drawing.Point(90, 27)
        Me.txt_id.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_id.Name = "txt_id"
        Me.txt_id.Size = New System.Drawing.Size(59, 23)
        Me.txt_id.TabIndex = 34
        '
        'txt_mail
        '
        Me.txt_mail.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_mail.BackColor = System.Drawing.SystemColors.Control
        Me.txt_mail.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_mail.Location = New System.Drawing.Point(394, 126)
        Me.txt_mail.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_mail.Name = "txt_mail"
        Me.txt_mail.Size = New System.Drawing.Size(187, 23)
        Me.txt_mail.TabIndex = 33
        '
        'activo
        '
        Me.activo.AutoSize = True
        Me.activo.Location = New System.Drawing.Point(717, 119)
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
        Me.txt_telefono.BackColor = System.Drawing.SystemColors.Control
        Me.txt_telefono.Location = New System.Drawing.Point(90, 123)
        Me.txt_telefono.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(181, 23)
        Me.txt_telefono.TabIndex = 31
        '
        'cmb_ciudad
        '
        Me.cmb_ciudad.FormattingEnabled = True
        Me.cmb_ciudad.Location = New System.Drawing.Point(717, 86)
        Me.cmb_ciudad.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_ciudad.Name = "cmb_ciudad"
        Me.cmb_ciudad.Size = New System.Drawing.Size(178, 25)
        Me.cmb_ciudad.TabIndex = 30
        Me.cmb_ciudad.Text = "Seleccione.."
        '
        'cmb_departamento
        '
        Me.cmb_departamento.FormattingEnabled = True
        Me.cmb_departamento.Location = New System.Drawing.Point(717, 53)
        Me.cmb_departamento.Margin = New System.Windows.Forms.Padding(2)
        Me.cmb_departamento.Name = "cmb_departamento"
        Me.cmb_departamento.Size = New System.Drawing.Size(178, 25)
        Me.cmb_departamento.TabIndex = 29
        Me.cmb_departamento.Text = "Seleccione.."
        '
        'txt_observacion
        '
        Me.txt_observacion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_observacion.BackColor = System.Drawing.SystemColors.Control
        Me.txt_observacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_observacion.Location = New System.Drawing.Point(394, 161)
        Me.txt_observacion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_observacion.Name = "txt_observacion"
        Me.txt_observacion.Size = New System.Drawing.Size(187, 23)
        Me.txt_observacion.TabIndex = 28
        '
        'txt_ruc
        '
        Me.txt_ruc.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_ruc.BackColor = System.Drawing.SystemColors.Control
        Me.txt_ruc.Location = New System.Drawing.Point(91, 93)
        Me.txt_ruc.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(180, 23)
        Me.txt_ruc.TabIndex = 24
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.ForeColor = System.Drawing.SystemColors.Control
        Me.Label12.Location = New System.Drawing.Point(659, 118)
        Me.Label12.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(56, 17)
        Me.Label12.TabIndex = 23
        Me.Label12.Text = "Estado:"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.ForeColor = System.Drawing.SystemColors.Control
        Me.Label11.Location = New System.Drawing.Point(298, 161)
        Me.Label11.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(92, 17)
        Me.Label11.TabIndex = 22
        Me.Label11.Text = "Observación:"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.ForeColor = System.Drawing.SystemColors.Control
        Me.Label10.Location = New System.Drawing.Point(658, 84)
        Me.Label10.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(56, 17)
        Me.Label10.TabIndex = 21
        Me.Label10.Text = "Ciudad:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.SystemColors.Control
        Me.Label9.Location = New System.Drawing.Point(611, 53)
        Me.Label9.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(102, 17)
        Me.Label9.TabIndex = 20
        Me.Label9.Text = "Departamento:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.SystemColors.Control
        Me.Label8.Location = New System.Drawing.Point(37, 90)
        Me.Label8.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(45, 17)
        Me.Label8.TabIndex = 19
        Me.Label8.Text = "RUC.:"
        '
        'txt_web
        '
        Me.txt_web.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_web.BackColor = System.Drawing.SystemColors.Control
        Me.txt_web.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_web.Location = New System.Drawing.Point(393, 92)
        Me.txt_web.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_web.Name = "txt_web"
        Me.txt_web.Size = New System.Drawing.Size(188, 23)
        Me.txt_web.TabIndex = 16
        '
        'txt_direccion
        '
        Me.txt_direccion.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_direccion.BackColor = System.Drawing.SystemColors.Control
        Me.txt_direccion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_direccion.Location = New System.Drawing.Point(392, 55)
        Me.txt_direccion.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(189, 23)
        Me.txt_direccion.TabIndex = 15
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.SystemColors.Control
        Me.Label6.Location = New System.Drawing.Point(344, 124)
        Me.Label6.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(46, 17)
        Me.Label6.TabIndex = 14
        Me.Label6.Text = "Email:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(304, 93)
        Me.Label5.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(89, 17)
        Me.Label5.TabIndex = 13
        Me.Label5.Text = "Página Web:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(14, 123)
        Me.Label4.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 17)
        Me.Label4.TabIndex = 12
        Me.Label4.Text = "Teléfono:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(322, 58)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 11
        Me.Label1.Text = "Dirección:"
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.ForeColor = System.Drawing.Color.Transparent
        Me.Button2.Image = Global.Tienda.My.Resources.Resources.icons8_Edit_Property_50px
        Me.Button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button2.Location = New System.Drawing.Point(458, 196)
        Me.Button2.Margin = New System.Windows.Forms.Padding(2)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(118, 57)
        Me.Button2.TabIndex = 7
        Me.Button2.Text = "Editar"
        Me.Button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Button4
        '
        Me.Button4.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button4.ForeColor = System.Drawing.Color.Transparent
        Me.Button4.Image = Global.Tienda.My.Resources.Resources.icons8_Trash_Can_50px_1
        Me.Button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button4.Location = New System.Drawing.Point(595, 196)
        Me.Button4.Margin = New System.Windows.Forms.Padding(2)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(118, 57)
        Me.Button4.TabIndex = 9
        Me.Button4.Text = "Eliminar"
        Me.Button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button4.UseVisualStyleBackColor = False
        '
        'Button3
        '
        Me.Button3.BackColor = System.Drawing.SystemColors.HotTrack
        Me.Button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button3.ForeColor = System.Drawing.Color.Transparent
        Me.Button3.Image = Global.Tienda.My.Resources.Resources.icons8_Plus_50px
        Me.Button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Button3.Location = New System.Drawing.Point(188, 196)
        Me.Button3.Margin = New System.Windows.Forms.Padding(2)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(118, 57)
        Me.Button3.TabIndex = 10
        Me.Button3.Text = "Nuevo"
        Me.Button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button3.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(20, 58)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Nombre:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(20, 26)
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
        Me.Button1.Location = New System.Drawing.Point(324, 196)
        Me.Button1.Margin = New System.Windows.Forms.Padding(2)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(118, 57)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Guardar"
        Me.Button1.TextAlign = System.Drawing.ContentAlignment.MiddleRight
        Me.Button1.UseVisualStyleBackColor = False
        '
        'txt_nombre
        '
        Me.txt_nombre.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.txt_nombre.BackColor = System.Drawing.SystemColors.Control
        Me.txt_nombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre.Location = New System.Drawing.Point(90, 59)
        Me.txt_nombre.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_nombre.Name = "txt_nombre"
        Me.txt_nombre.Size = New System.Drawing.Size(181, 23)
        Me.txt_nombre.TabIndex = 1
        '
        'txt_buscar
        '
        Me.txt_buscar.Location = New System.Drawing.Point(222, 326)
        Me.txt_buscar.Margin = New System.Windows.Forms.Padding(2)
        Me.txt_buscar.Name = "txt_buscar"
        Me.txt_buscar.Size = New System.Drawing.Size(148, 20)
        Me.txt_buscar.TabIndex = 2
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
        Me.btnCerrar.Location = New System.Drawing.Point(1, -3)
        Me.btnCerrar.Name = "btnCerrar"
        Me.btnCerrar.Size = New System.Drawing.Size(41, 49)
        Me.btnCerrar.TabIndex = 81
        Me.btnCerrar.UseVisualStyleBackColor = True
        '
        'Proveedor
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(66, Byte), Integer), CType(CType(91, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(966, 548)
        Me.Controls.Add(Me.btnCerrar)
        Me.Controls.Add(Me.txt_buscar)
        Me.Controls.Add(Me.tabla)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "Proveedor"
        Me.Text = "Proveedor"
        CType(Me.tabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents tabla As System.Windows.Forms.DataGridView
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_web As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
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
    Friend WithEvents txt_ruc As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents activo As System.Windows.Forms.CheckBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents cmb_ciudad As System.Windows.Forms.ComboBox
    Friend WithEvents cmb_departamento As System.Windows.Forms.ComboBox
    Friend WithEvents txt_observacion As System.Windows.Forms.TextBox
    Friend WithEvents txt_mail As System.Windows.Forms.TextBox
    Friend WithEvents txt_id As System.Windows.Forms.TextBox
    Friend WithEvents Codigo As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Nombre As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Departamento As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Observacion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Telefono As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Ciudad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ruc As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents direccion As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents mail As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents pag As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Estado As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents txt_buscar As System.Windows.Forms.TextBox
    Friend WithEvents btnCerrar As System.Windows.Forms.Button
    Friend WithEvents etiqueta_observacion As System.Windows.Forms.Label
    Friend WithEvents etiqueta_web As System.Windows.Forms.Label
    Friend WithEvents etiqueta_email As System.Windows.Forms.Label
    Friend WithEvents etiqueta_telefono As System.Windows.Forms.Label
    Friend WithEvents etiqueta_direccion As System.Windows.Forms.Label
    Friend WithEvents etiqueta_nombre As System.Windows.Forms.Label
    Friend WithEvents etiqueta_ruc As System.Windows.Forms.Label
End Class
