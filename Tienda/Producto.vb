Public Class Producto
    Public Sub combo_marca()
        Dim rs As DataTable = conexion.consulta("select mar_id, mar_descripcion from marca")
        cmb_marca.DataSource = rs
        cmb_marca.DisplayMember = "mar_descripcion"
        cmb_marca.ValueMember = "mar_id"
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
     
        habilitar()
        combo_marca()
        limpiar()
        visibles()
        habilitar_etiquetas()
        cargar_codigo()
        txt_nombre.Focus()
    End Sub
    Public Sub limpiar()
        txt_descripcion.Text = ""
        txt_id.Text = ""
        txt_precio.Text = ""
        txt_nombre.Text = ""
        cmb_iva.Text = ""
        cmb_marca.Text = ""

    End Sub
    Public Sub habilitar()
        txt_descripcion.Enabled = True

        txt_precio.Enabled = True
        txt_nombre.Enabled = True
        cmb_iva.Enabled = True
        cmb_marca.Enabled = True
    End Sub
    Public Sub deshabilitar()
        txt_descripcion.Enabled = False
        txt_id.Enabled = False
        txt_precio.Enabled = False
        txt_nombre.Enabled = False
        cmb_iva.Enabled = False
        cmb_marca.Enabled = False
    End Sub
    Private Sub Producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitar()

        ' total()
        cargar()
    End Sub
    Public Sub desabilitar_etiquetas()
        etiqueta_nombre.Enabled = False
        etiqueta_descripcion.Enabled = False
        etiqueta_marca.Enabled = False
        etiqueta_precio.Enabled = False
    End Sub
    Public Sub habilitar_etiquetas()
        etiqueta_nombre.Enabled = True
        etiqueta_descripcion.Enabled = True
        etiqueta_marca.Enabled = True
        etiqueta_precio.Enabled = True
    End Sub
    Public Sub visibles()
        etiqueta_nombre.Visible = True
        etiqueta_descripcion.Visible = True
        etiqueta_marca.Visible = True
        etiqueta_precio.Visible = True
    End Sub
    Public Sub invisibles()
        etiqueta_nombre.Visible = False
        etiqueta_descripcion.Visible = False
        etiqueta_marca.Visible = False
        etiqueta_precio.Visible = False
    End Sub

    'MIRAR 000000000000000000000000000000000000000000
    Public Sub total()

        Dim dt As DataTable = conexion.consulta("SELECT SUM( stock_cantidadactual ) As ultimo FROM stock ")
        If dt.Rows.Count = "" Then
            txt_total.Text = 0

       ElseIf dt.Rows.Count > 0 Then
        txt_total.Text = dt.Rows(0)("ultimo")
        Else

            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)
        End If


    End Sub
    Public Sub cargar()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta(" select * from marca b, producto a, stock c where b.mar_id=a.Marca_mar_id and c.Producto_prod_id=a.prod_id ")
        tabla.DataSource = tablas
        Dim objDataView As New DataView(tablas)
        If txt_buscar.Text <> "" Then
            Select Case ComboBusca.Text
                Case "Nombre"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "prod_nombre LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If
                Case "Marca"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "mar_descripcion LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If
            End Select
        End If
    End Sub
    Public Sub cargar_codigo()
        Dim dt As DataTable = conexion.consulta("SELECT IFNULL(MAX(	prod_id),0)+1 AS ultimo FROM producto ")
        If dt.Rows.Count > 0 Then
            txt_id.Text = dt.Rows(0)("ultimo")


        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub
    Public Sub descripcioon()
        Dim dt As DataTable = conexion.consulta("SELECT prod_descripcion,prod_iva from producto where prod_id='" & txt_id.Text & "'")
        If dt.Rows.Count > 0 Then
            txt_descripcion.Text = dt.Rows(0)("prod_descripcion")
            cmb_iva.Text = dt.Rows(0)("prod_iva")

        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txt_nombre.Text = "" Then
            txt_nombre.Focus()
        ElseIf txt_descripcion.Text = "" Then
            txt_descripcion.Focus()
        ElseIf cmb_marca.Text = "" Then
            cmb_marca.Focus()
        ElseIf txt_precio.Text = "" Then

            txt_precio.Focus()

        Else

            Dim query As String = "INSERT INTO producto( 	prod_id,Marca_mar_id,prod_nombre,prod_descripcion,prod_preciocompra,prod_iva)" & _
            "VALUES ('" & txt_id.Text & "', '" & cmb_marca.SelectedValue & "', '" & txt_nombre.Text & "', '" & txt_descripcion.Text & "','" & txt_precio.Text & "','" & cmb_iva.Text & "');"
            If conexion.executarsql(query) Then

                cargar()

                deshabilitar()
            Else

            End If
            Dim n As Integer = 0
            Dim n1 As Integer = 0
            Dim n2 As Integer = 0
            Dim query2 As String = "INSERT INTO stock( Producto_prod_id, stock_cantidadmin, stock_cantidadmax, stock_cantidadactual )" & _
            "VALUES ('" & txt_id.Text & "', '" & n & "', '" & n1 & "', '" & n2 & "');"
            If conexion.executarsql(query2) Then
                limpiar()

                cargar()

            Else
            End If
        End If
    End Sub

    Private Sub cmb_iva_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_iva.SelectedIndexChanged

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_id.Text = "" Then
            MsgBox("Introducir id")
        Else

            Dim query As String = "DELETE FROM producto WHERE prod_id='" & txt_id.Text & "'"
            If conexion.executarsql(query) Then
                cargar()
                limpiar()

            Else
                MsgBox("Registro no eliminado", MsgBoxStyle.Critical)
            End If

        End If

    End Sub

    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
        txt_id.Text = SelectRow.Cells("Codigo").Value.ToString()
        cmb_marca.Text = SelectRow.Cells(1).Value.ToString()
        txt_nombre.Text = SelectRow.Cells("Nombre").Value.ToString()
        txt_precio.Text = SelectRow.Cells("Precio").Value.ToString()

        invisibles()

        habilitar()
        descripcioon()

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If txt_nombre.Text = "" Then
            txt_nombre.Focus()

        ElseIf txt_descripcion.Text = "" Then
            txt_descripcion.Focus()
        ElseIf cmb_marca.Text = "" Then
            cmb_marca.Focus()
        ElseIf txt_precio.Text = "" Then
            txt_precio.Focus()

        Else
            Dim query As String = "Update producto SET  prod_nombre='" & txt_nombre.Text & "', prod_descripcion='" & _
            txt_descripcion.Text & "', prod_preciocompra='" & txt_precio.Text & "', prod_iva='" & _
cmb_iva.Text & "' WHERE prod_id='" & txt_id.Text & "'"

            If conexion.executarsql(query) Then

                cargar()
                limpiar()
                deshabilitar()


            Else
                MsgBox("NO SE HA MODIFICADO", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        etiqueta_nombre.Visible = False
    End Sub


    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_descripcion.Focus()
        End If

    End Sub

    Private Sub txt_descripcion_TextChanged(sender As Object, e As EventArgs) Handles txt_descripcion.TextChanged
        etiqueta_descripcion.Visible = False
    End Sub
    Private Sub txt_descripcion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_descripcion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmb_marca.Focus()
        End If
    End Sub

    Private Sub cmb_marca_TextChanged(sender As Object, e As EventArgs) Handles cmb_marca.TextChanged
        etiqueta_marca.Visible = False
    End Sub
    Private Sub cmb_marca_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_marca.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_precio.Focus()
        End If
    End Sub

    Private Sub txt_precio_TextChanged(sender As Object, e As EventArgs) Handles txt_precio.TextChanged
        etiqueta_precio.Visible = False
    End Sub

    Private Sub txt_precio_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_precio.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmb_iva.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        cargar()

    End Sub

    'Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
    '    AbrirFormEnPanel(Of VistaProducto)()
    'End Sub
    Private Sub AbrirFormEnPanel(Of Miform As {Form, New})()
        Dim Formulario As Form
        Formulario = Me.Controls.OfType(Of Miform)().FirstOrDefault()
        If Formulario Is Nothing Then
            Formulario = New Miform
            Formulario.TopLevel = False
            Formulario.FormBorderStyle = FormBorderStyle.None
            Formulario.Dock = DockStyle.Fill
            Me.Controls.Add(Formulario)
            Me.Tag = Formulario
            Formulario.Show()
            Formulario.BringToFront()
        Else
            Formulario.BringToFront()



        End If

    End Sub


    Private Sub tabla_CellFormatting(sender As Object, e As DataGridViewCellFormattingEventArgs) Handles tabla.CellFormatting

        If Me.tabla.Columns(e.ColumnIndex).Name = "Stock" Then

            If e.Value IsNot Nothing Then

                If e.Value.[GetType]() <> GetType(System.DBNull) Then
                    'Stock mayor a 20
                    If Convert.ToInt32(e.Value) > 20 Then
                        e.CellStyle.BackColor = Color.Green
                        e.CellStyle.ForeColor = Color.White
                    End If
                    'Stock menor a 20
                    If Convert.ToInt32(e.Value) <= 20 Then
                        e.CellStyle.BackColor = Color.Orange
                        e.CellStyle.ForeColor = Color.White
                    End If

                    'Stock menor a 10
                    If Convert.ToInt32(e.Value) <= 10 Then
                        e.CellStyle.BackColor = Color.Red
                        e.CellStyle.ForeColor = Color.White
                    End If
                End If
            End If
        End If

        'If Me.tabla.Columns(e.ColumnIndex).Name = "Marca" Then

        '    If e.Value IsNot Nothing Then

        '        If e.Value.[GetType]() <> GetType(System.DBNull) Then

        '            If e.Value.ToString() = "iberica" Then
        '                e.CellStyle.ForeColor = Color.SeaGreen
        '            End If

        '            If e.Value.ToString() = "marcacola" Then
        '                e.CellStyle.ForeColor = Color.SteelBlue
        '            End If
        '        End If
        '    End If
        'End If
    End Sub




End Class
