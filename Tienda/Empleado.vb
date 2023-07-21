Public Class Empleado

    Private Sub Empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitar()
        cargar()
        deshabilitar_etiquetas()

    End Sub
    Public Sub limpiar()
        txt_apellido.Text = ""
        txt_direccion.Text = ""
        txt_mail.Text = ""
        txt_nombre.Text = ""
        txt_observacion.Text = ""
        txt_sueldo.Text = ""
        txt_telefono.Text = ""
        txt_ci.Text = ""
    End Sub
    Public Sub habilitar_etiquetas()
        etiqueta_nombre.Enabled = True
        etiqueta_apellido.Enabled = True
        etiqueta_ci.Enabled = True
        etiqueta_email.Enabled = True
        etiqueta_direccion.Enabled = True
        etiqueta_sueldo.Enabled = True
        etiqueta_observacion.Enabled = True
        etiqueta_telefono.Enabled = True
    End Sub
    Public Sub deshabilitar_etiquetas()
        etiqueta_nombre.Enabled = False
        etiqueta_apellido.Enabled = False
        etiqueta_ci.Enabled = False
        etiqueta_email.Enabled = False
        etiqueta_direccion.Enabled = False
        etiqueta_sueldo.Enabled = False
        etiqueta_observacion.Enabled = False
        etiqueta_telefono.Enabled = False
    End Sub
   
    Public Sub habilitar()
        txt_apellido.Enabled = True
        txt_direccion.Enabled = True
        txt_mail.Enabled = True
        txt_id.Enabled = False
        activo.Enabled = True
        txt_nombre.Enabled = True
        txt_observacion.Enabled = True
        txt_sueldo.Enabled = True
        txt_telefono.Enabled = True
        txt_ci.Enabled = True
        txt_fechanacimiento.Enabled = True
        cmb_ciudad.Enabled = True
        cmb_departamento.Enabled = True
        cmb_sexo.Enabled = True
    End Sub
    Public Sub deshabilitar()
        txt_apellido.Enabled = False
        txt_fechanacimiento.Enabled = False
        txt_direccion.Enabled = False
        txt_mail.Enabled = False
        txt_id.Enabled = False
        activo.Enabled = False
        txt_nombre.Enabled = False
        txt_observacion.Enabled = False
        txt_sueldo.Enabled = False
        txt_telefono.Enabled = False
        txt_ci.Enabled = False
        cmb_ciudad.Enabled = False
        cmb_departamento.Enabled = False
        cmb_sexo.Enabled = False
    End Sub
    Public Sub visibles()
        etiqueta_nombre.Visible = True
        etiqueta_apellido.Visible = True
        etiqueta_ci.Visible = True
        etiqueta_email.Visible = True
        etiqueta_direccion.Visible = True
        etiqueta_sueldo.Visible = True
        etiqueta_observacion.Visible = True
        etiqueta_telefono.Visible = True
    End Sub
    Public Sub invisibles()
        etiqueta_nombre.Visible = False
        etiqueta_apellido.Visible = False
        etiqueta_ci.Visible = False
        etiqueta_email.Visible = False
        etiqueta_direccion.Visible = False
        etiqueta_sueldo.Visible = False
        etiqueta_observacion.Visible = False
        etiqueta_telefono.Visible = False
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
    
        habilitar()
        combo_departamento()
        limpiar()
        visibles()
        habilitar_etiquetas()
        cargar_codigo()
        txt_nombre.Focus()
        habilitar()
     
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Private Sub txt_nombre_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_apellido.Focus()
        End If

    End Sub
    Private Sub txt_apellido_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_apellido.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_telefono.Focus()
        End If

    End Sub
    Private Sub txt_direccion_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_direccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_ci.Focus()
        End If

    End Sub

    Private Sub txt_telefono_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_telefono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_direccion.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
       
    End Sub


    

    Private Sub txt_ci_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ci.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_mail.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
       
    End Sub
    Private Sub txt_mail_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txt_mail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_sueldo.Focus()
        End If
    End Sub

   

    Private Sub txt_sueldo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_sueldo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_observacion.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_id.Text = "" Then
            MsgBox("Introducir id")
        Else
            If MsgBox("Estas seguro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim query As String = "DELETE FROM empleado WHERE emp_id='" & txt_id.Text & "'"
                If conexion.executarsql(query) Then
                    cargar()
                    limpiar()
                    deshabilitar()
                    deshabilitar_etiquetas()
                    visibles()


                Else
                    MsgBox("Registro no eliminado", MsgBoxStyle.Critical)
                End If
            End If
        End If

    End Sub
    Public Sub cargar_codigo()
        Dim dt As DataTable = conexion.consulta("SELECT IFNULL(MAX(	emp_id),0)+1 AS ultimo FROM empleado ")
        If dt.Rows.Count > 0 Then
            txt_id.Text = dt.Rows(0)("ultimo")


        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub

    Public Sub combo_departamento()
        'Dim valor As String
        Dim rs As DataTable = conexion.consulta("select dep_id, dep_nombre from departamento ORDER BY dep_id ")
        '("SELECT dep_id,dep_nombre FROM departamento WHERE CONCAT (dep_nombre,' ') LIKE '%" + valor + "%'")

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

  

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If txt_ci.Text <> "" Then
            Dim comparador As Integer
            Dim x As Integer
            Dim dt As DataTable = conexion.consulta("SELECT emp_ci As ultimo from empleado where emp_ci= " & txt_ci.Text)
            If dt.Rows.Count > 0 Then
                comparador = dt.Rows(0)("ultimo")
                x = Val(txt_ci.Text)
                If comparador = x Then
                    etiqueta_utilizado.Visible = True
                End If
            End If
        End If

        If txt_nombre.Text = "" Then
            txt_nombre.Focus()
        ElseIf txt_direccion.Text = "" Then
            txt_direccion.Focus()
        ElseIf txt_mail.Text = "" Then
            txt_mail.Focus()
        ElseIf txt_apellido.Text = "" Then
            txt_apellido.Focus()
        ElseIf txt_telefono.Text = "" Then
            txt_telefono.Focus()

        ElseIf txt_sueldo.Text = "" Then
            txt_sueldo.Focus()
        Else

            Dim query As String = "INSERT INTO empleado (emp_id, emp_nombre, emp_apellido, emp_ci, emp_sueldo, emp_direccion, emp_telefono, emp_fechanacimiento, emp_observacion, emp_email, emp_sexo, emp_estado, Ciudad_ciu_id)" & _
 "VALUES ('" & txt_id.Text & "', '" & txt_nombre.Text & "', '" & txt_apellido.Text & "', '" & txt_ci.Text & "','" & txt_sueldo.Text & "','" & txt_direccion.Text & "','" & txt_telefono.Text & "','" & txt_fechanacimiento.Text & "','" & txt_observacion.Text & "','" & txt_mail.Text & "','" & cmb_sexo.Text & "','" & activo.Text & "','" & cmb_ciudad.SelectedValue & "');"
            If conexion.executarsql(query) Then
                deshabilitar_etiquetas()
                deshabilitar()
                visibles()

                cargar()
                limpiar()

            Else

            End If
        End If

    End Sub
    Public Sub cargar()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta(" SELECT a.emp_fechanacimiento,a.emp_id, a.emp_nombre, a.emp_apellido, a.emp_ci, a.emp_sueldo, a.emp_direccion, a.emp_telefono,a.emp_observacion, a.emp_email, a.emp_sexo, a.emp_estado, b.ciu_nombre, c.dep_nombre FROM empleado a, ciudad b, departamento c where b.ciu_id=a.Ciudad_ciu_id and b.Departamento_dep_id=c.dep_id ")
        tabla.DataSource = tablas
        Dim objDataView As New DataView(tablas)
        If txt_buscar.Text <> "" Then
            Select Case ComboBusca.Text
                Case "Nombre"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "emp_nombre LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If
                Case "Apellido"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "emp_apellido LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If
            End Select
        End If
    End Sub
    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
        txt_fechanacimiento.Text = SelectRow.Cells("fecha").Value.ToString()

        activo.Text = SelectRow.Cells("Estado").Value.ToString()
        txt_apellido.Text = SelectRow.Cells("Apellido").Value.ToString()
        txt_telefono.Text = SelectRow.Cells("telefono").Value.ToString()
        txt_id.Text = SelectRow.Cells("Codigo").Value.ToString()
        txt_direccion.Text = SelectRow.Cells("direccion").Value.ToString()
        txt_nombre.Text = SelectRow.Cells(2).Value.ToString()
        txt_observacion.Text = SelectRow.Cells("observacion").Value.ToString()
        txt_mail.Text = SelectRow.Cells("mail").Value.ToString()
        cmb_departamento.Text = SelectRow.Cells("Departamento").Value.ToString()
        cmb_ciudad.Text = SelectRow.Cells("Ciudad").Value.ToString()
        txt_sueldo.Text = SelectRow.Cells("Sueldo").Value.ToString()
        txt_ci.Text = SelectRow.Cells("ci").Value.ToString()
        cmb_sexo.Text = SelectRow.Cells("Sexo").Value.ToString()
        invisibles()

        habilitar()

        Dim rs2 As DataTable = conexion.consulta("SELECT ciu_nombre,ciu_id from ciudad where ciu_nombre='" & cmb_ciudad.Text & "'")

        If rs2.Rows.Count > 0 Then
            cmb_ciudad.DataSource = rs2
            cmb_ciudad.Text = rs2.Rows(0)("ciu_nombre")
            cmb_ciudad.ValueMember = "ciu_id"
        Else

        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        If txt_ci.Text <> "" Then
            Dim comparador As Integer
            Dim x As Integer
            Dim dt As DataTable = conexion.consulta("SELECT emp_ci As ultimo from empleado where emp_ci= " & txt_ci.Text)
            If dt.Rows.Count > 0 Then
                comparador = dt.Rows(0)("ultimo")
                x = Val(txt_ci.Text)
                If comparador = x Then
                    etiqueta_utilizado.Visible = True
                End If
            End If
        End If
        If txt_nombre.Text = "" Then
            etiqueta_nombre.Visible = True
        ElseIf txt_direccion.Text = "" Then
            etiqueta_direccion.Visible = True
        ElseIf txt_mail.Text = "" Then
            etiqueta_email.Visible = True
        ElseIf txt_apellido.Text = "" Then
            etiqueta_apellido.Visible = True
        ElseIf txt_telefono.Text = "" Then
            etiqueta_telefono.Visible = True

        ElseIf txt_sueldo.Text = "" Then
            etiqueta_sueldo.Visible = True
        Else
            Dim query As String = "Update empleado SET  emp_nombre='" & txt_nombre.Text & "', emp_apellido='" & _
           txt_apellido.Text & "', emp_ci='" & txt_ci.Text & "', emp_sueldo='" & _
           txt_sueldo.Text & "', emp_direccion='" & txt_direccion.Text & "', emp_telefono='" & txt_telefono.Text & "', emp_fechanacimiento='" & txt_fechanacimiento.Text & "', emp_observacion='" & txt_observacion.Text & "', emp_email='" & txt_mail.Text & "', emp_sexo='" & cmb_sexo.Text & "', emp_estado='" & activo.Text & "', Ciudad_ciu_id='" & cmb_ciudad.SelectedValue & "' WHERE emp_id='" & txt_id.Text & "'"

            If conexion.executarsql(query) Then

                cargar()
                limpiar()
                deshabilitar_etiquetas()
                deshabilitar()
                visibles()



            Else
                MsgBox("NO SE HA MODIFICADO", MsgBoxStyle.Critical)
            End If
        End If

    End Sub

    Private Sub activo_CheckedChanged(sender As Object, e As EventArgs) Handles activo.CheckedChanged
        If activo.Checked = True Then
            activo.Text = "ACTIVO"
        Else
            activo.Text = "INACTIVO"
        End If
    End Sub

   

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        cargar()
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        etiqueta_nombre.Visible = False
    End Sub

    Private Sub txt_apellido_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged
        etiqueta_apellido.Visible = False
    End Sub

    Private Sub txt_telefono_TextChanged(sender As Object, e As EventArgs) Handles txt_telefono.TextChanged
        etiqueta_telefono.Visible = False
    End Sub

    Private Sub txt_direccion_TextChanged(sender As Object, e As EventArgs) Handles txt_direccion.TextChanged
        etiqueta_direccion.Visible = False
    End Sub

    Private Sub txt_mail_TextChanged(sender As Object, e As EventArgs) Handles txt_mail.TextChanged
        etiqueta_email.Visible = False
    End Sub
    Private Sub txt_sueldo_TextChanged(sender As Object, e As EventArgs) Handles txt_sueldo.TextChanged
        etiqueta_sueldo.Visible = False
    End Sub
    Private Sub txt_ci_TextChanged(sender As Object, e As EventArgs) Handles txt_ci.TextChanged
        etiqueta_ci.Visible = False
    End Sub
    
    Private Sub txt_observacion_TextChanged(sender As Object, e As EventArgs) Handles txt_observacion.TextChanged
        etiqueta_observacion.Visible = False
    End Sub
End Class