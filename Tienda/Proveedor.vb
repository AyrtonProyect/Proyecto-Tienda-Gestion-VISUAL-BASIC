Public Class Proveedor
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs)
        Me.Close()
    End Sub

    Public Sub visibles()
        etiqueta_nombre.Visible = True
        etiqueta_ruc.Visible = True
        etiqueta_web.Visible = True
        etiqueta_email.Visible = True
        etiqueta_direccion.Visible = True
        etiqueta_observacion.Visible = True
        etiqueta_telefono.Visible = True
    End Sub
    Public Sub invisibles()
        etiqueta_nombre.Visible = False
        etiqueta_web.Visible = False
        etiqueta_ruc.Visible = False
        etiqueta_email.Visible = False
        etiqueta_direccion.Visible = False

        etiqueta_observacion.Visible = False
        etiqueta_telefono.Visible = False
    End Sub
    Public Sub habilitar_etiquetas()
        etiqueta_nombre.Enabled = True
        etiqueta_web.Enabled = True
        etiqueta_ruc.Enabled = True
        etiqueta_email.Enabled = True
        etiqueta_direccion.Enabled = True
        etiqueta_observacion.Enabled = True
        etiqueta_telefono.Enabled = True
    End Sub
    Public Sub deshabilitar_etiquetas()
        etiqueta_nombre.Enabled = False
        etiqueta_web.Enabled = False
        etiqueta_ruc.Enabled = False
        etiqueta_email.Enabled = False
        etiqueta_direccion.Enabled = False
        etiqueta_observacion.Enabled = False
        etiqueta_telefono.Enabled = False
    End Sub
    Public Sub combo_departamento()
        Dim rs As DataTable = conexion.consulta("select dep_id, dep_nombre from departamento ORDER BY dep_id ")
        cmb_departamento.DataSource = rs
        cmb_departamento.DisplayMember = "dep_nombre"
        cmb_departamento.ValueMember = "dep_id"

    End Sub
    Private Sub cmb_departamento_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_departamento.SelectedIndexChanged
        Dim cod As Integer = Val(cmb_departamento.SelectedValue.ToString)
        Dim rs As DataTable = conexion.consulta("SELECT ciu_id, ciu_nombre FROM ciudad where Departamento_dep_id= " & cod)

        cmb_ciudad.DataSource = rs
        cmb_ciudad.DisplayMember = "ciu_nombre"
        cmb_ciudad.ValueMember = "ciu_id"

    End Sub

    Private Sub activo_CheckedChanged(sender As Object, e As EventArgs) Handles activo.CheckedChanged
        If activo.Checked = True Then
            activo.Text = "ACTIVO"
        Else
            activo.Text = "INACTIVO"
        End If
    End Sub

    Public Sub limpiar()
        txt_direccion.Text = ""
        txt_mail.Text = ""
        txt_nombre.Text = ""
        txt_ruc.Text = ""
        txt_telefono.Text = ""
        txt_web.Text = ""
        cmb_ciudad.Text = ""
        cmb_departamento.Text = ""
        txt_observacion.Text = ""
    End Sub
    Public Sub habilitar()

        txt_nombre.Enabled = True
        txt_direccion.Enabled = True
        txt_mail.Enabled = True

        txt_ruc.Enabled = True
        activo.Enabled = True
        txt_telefono.Enabled = True
        txt_web.Enabled = True
        cmb_ciudad.Enabled = True
        cmb_departamento.Enabled = True
        txt_observacion.Enabled = True
    End Sub
    Public Sub deshabilitar()
        activo.Enabled = False
        txt_id.Enabled = False
        txt_direccion.Enabled = False
        txt_mail.Enabled = False
        txt_nombre.Enabled = False
        txt_ruc.Enabled = False
        txt_telefono.Enabled = False
        txt_web.Enabled = False
        cmb_ciudad.Enabled = False
        cmb_departamento.Enabled = False
        txt_observacion.Enabled = False
    End Sub

    Private Sub Proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitar()
        cargar()

    End Sub
    Public Sub cargar_codigo()
        Dim dt As DataTable = conexion.consulta("SELECT IFNULL(MAX(	prov_id),0)+1 AS ultimo FROM proveedor ")
        If dt.Rows.Count > 0 Then
            txt_id.Text = dt.Rows(0)("ultimo")


        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    
        habilitar()
        combo_departamento()
        limpiar()
        visibles()
        habilitar_etiquetas()
        cargar_codigo()
        txt_nombre.Focus()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If txt_nombre.Text = "" Then
            txt_nombre.Focus()
        ElseIf txt_ruc.Text = "" Then
            txt_ruc.Focus()
        ElseIf txt_telefono.Text = "" Then
            txt_telefono.Focus()
        ElseIf txt_direccion.Text = "" Then
            txt_direccion.Focus()
        ElseIf txt_web.Text = "" Then
            txt_web.Focus()
        ElseIf txt_mail.Text = "" Then
            txt_mail.Focus()
        Else


            Dim query As String = "INSERT INTO proveedor(prov_id, Ciudad_ciu_id, prov_nombre, prov_direccion, prov_telefono, prov_pag_web, prov_email, prov_estado, prov_observacion, prov_ruc)" & _
 "VALUES ('" & txt_id.Text & "', '" & cmb_ciudad.SelectedValue & "', '" & txt_nombre.Text & "', '" & txt_direccion.Text & "','" & txt_telefono.Text & "','" & txt_web.Text & "','" & txt_mail.Text & "','" & activo.Text & "','" & txt_observacion.Text & "','" & txt_ruc.Text & "');"
            If conexion.executarsql(query) Then

                cargar()
                limpiar()
                deshabilitar_etiquetas()
                visibles()
            Else

            End If
        End If

    End Sub
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_nombre.Text = "" Then
            txt_nombre.Focus()
        ElseIf txt_ruc.Text = "" Then
            txt_ruc.Focus()
        ElseIf txt_telefono.Text = "" Then
            txt_telefono.Focus()
        ElseIf txt_direccion.Text = "" Then
            txt_direccion.Focus()
        ElseIf txt_web.Text = "" Then
            txt_web.Focus()
        ElseIf txt_mail.Text = "" Then
            txt_mail.Focus()
        Else
            Dim query As String = "Update proveedor SET  prov_nombre='" & txt_nombre.Text & "', Ciudad_ciu_id='" & _
           cmb_ciudad.SelectedValue & "', prov_direccion='" & txt_direccion.Text & "', prov_telefono='" & _
           txt_telefono.Text & "', prov_pag_web='" & txt_web.Text & "', prov_email='" & txt_mail.Text & "', prov_estado='" & activo.Text & "', prov_observacion='" & txt_observacion.Text & "', prov_ruc='" & txt_ruc.Text & "' WHERE prov_id='" & txt_id.Text & "'"

            If conexion.executarsql(query) Then

                cargar()
                limpiar()
                deshabilitar_etiquetas()
                visibles()

            Else
                MsgBox("NO SE HA MODIFICADO", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_id.Text = "" Then
            MsgBox("Introducir id")
        Else

            Dim query As String = "DELETE FROM proveedor WHERE prov_id='" & txt_id.Text & "'"
            If conexion.executarsql(query) Then
                'cargar()
                limpiar()

            Else
                MsgBox("Registro no eliminado", MsgBoxStyle.Critical)
            End If

        End If

    End Sub
    Public Sub cargar()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta(" select a.prov_id,a.prov_email,a.prov_pag_web,a.prov_nombre, a.prov_direccion, a.prov_estado, a.prov_telefono, a.prov_ruc, a.prov_observacion,b.ciu_nombre, dep_nombre from ciudad b, proveedor a, departamento c where b.ciu_id=a.Ciudad_ciu_id and b.Departamento_dep_id=c.dep_id ")

        tabla.DataSource = tablas

    End Sub


    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
        activo.Text = SelectRow.Cells("Estado").Value.ToString()
        txt_web.Text = SelectRow.Cells("pag").Value.ToString()
        txt_ruc.Text = SelectRow.Cells("ruc").Value.ToString()
        txt_telefono.Text = SelectRow.Cells("telefono").Value.ToString()
        txt_id.Text = SelectRow.Cells(0).Value.ToString()
        txt_direccion.Text = SelectRow.Cells("direccion").Value.ToString()
        txt_nombre.Text = SelectRow.Cells(1).Value.ToString()
        txt_observacion.Text = SelectRow.Cells("observacion").Value.ToString()
        txt_mail.Text = SelectRow.Cells("mail").Value.ToString()
        cmb_departamento.Text = SelectRow.Cells("Departamento").Value.ToString()
        cmb_ciudad.Text = SelectRow.Cells("Ciudad").Value.ToString()
        habilitar()

        Dim rs2 As DataTable = conexion.consulta("SELECT ciu_nombre,ciu_id from ciudad where ciu_nombre='" & cmb_ciudad.Text & "'")

        If rs2.Rows.Count > 0 Then
            cmb_ciudad.DataSource = rs2
            cmb_ciudad.Text = rs2.Rows(0)("ciu_nombre")
            cmb_ciudad.ValueMember = "ciu_id"
        Else

        End If
    End Sub

  

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged

        Dim dt As DataTable = conexion.consulta(" select a.prov_id,a.prov_email,a.prov_pag_web,a.prov_nombre, a.prov_direccion, a.prov_estado, a.prov_telefono, a.prov_ruc, a.prov_observacion,b.ciu_nombre, dep_nombre from ciudad b, proveedor a, departamento c where b.ciu_id=a.Ciudad_ciu_id and b.Departamento_dep_id=c.dep_id ")

        Dim objDataView As New DataView(dt)
        tabla.DataSource = Nothing
        If txt_buscar.Text <> "" Then
            objDataView.RowFilter = "prov_nombre LIKE '%" & txt_buscar.Text & "%'"
            If objDataView.ToTable.Rows.Count > 0 Then
                tabla.DataSource = objDataView.ToTable
            End If
        End If

    End Sub


    Private Sub btnCerrar_Click_1(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_ruc.Focus()
        End If

    End Sub
    Private Sub txt_ruc_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_ruc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_telefono.Focus()
        End If
        If InStr(1, "0123456789-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_direccion.Focus()
        End If
        If InStr(1, "0123456789()+" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txt_direccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_direccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_web.Focus()
        End If
    End Sub
    Private Sub txt_web_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_web.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_mail.Focus()
        End If
    End Sub
    Private Sub txt_mail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_observacion.Focus()
        End If

    End Sub
    Private Sub txt_observacion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_observacion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmb_departamento.Focus()
        End If

    End Sub
    Private Sub cmb_departamento_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_departamento.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmb_ciudad.Focus()
        End If
       
    End Sub
    Private Sub cmb_ciudad_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles cmb_ciudad.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            activo.Focus()
        End If

    End Sub
  
    Private Sub txt_telefono_TextChanged(sender As Object, e As EventArgs) Handles txt_telefono.TextChanged
        etiqueta_telefono.Visible = False
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        etiqueta_nombre.Visible = False
    End Sub

    Private Sub txt_ruc_TextChanged(sender As Object, e As EventArgs) Handles txt_ruc.TextChanged
        etiqueta_ruc.Visible = False
    End Sub

    Private Sub txt_direccion_TextChanged(sender As Object, e As EventArgs) Handles txt_direccion.TextChanged
        etiqueta_direccion.Visible = False
    End Sub

    Private Sub txt_web_TextChanged(sender As Object, e As EventArgs) Handles txt_web.TextChanged
        etiqueta_web.Visible = False
    End Sub

    Private Sub txt_mail_TextChanged(sender As Object, e As EventArgs) Handles txt_mail.TextChanged
        etiqueta_email.Visible = False
    End Sub

    Private Sub txt_observacion_TextChanged(sender As Object, e As EventArgs) Handles txt_observacion.TextChanged
        etiqueta_observacion.Visible = False
    End Sub
End Class