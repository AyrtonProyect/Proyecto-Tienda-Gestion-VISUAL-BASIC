Imports MySql.Data.MySqlClient
Public Class Usuario
    Dim estado2 As String
    Public Sub habilitar()
        txt_id.Enabled = True
        txt_nombre.Enabled = True
        txt_usuario.Enabled = True
        txt_clave.Enabled = True
        cmb_nivel.Enabled = True
        rbt_activo.Enabled = True
        rbt_inactivo.Enabled = True
    End Sub
    Public Sub deshabilitar()
        txt_id.Enabled = False
        txt_nombre.Enabled = False
        txt_usuario.Enabled = False
        txt_clave.Enabled = False
        cmb_nivel.Enabled = False
        rbt_activo.Enabled = False
        rbt_inactivo.Enabled = False
    End Sub
    Public Sub limpiar()


        txt_nombre.Text = ""
        txt_usuario.Text = ""
        txt_clave.Text = ""
        cmb_nivel.Text = ""
        rbt_activo.Checked = False
        rbt_inactivo.Checked = False
    End Sub
    Public Sub cargar_codigo()
        Dim dt As DataTable = conexion.consulta("SELECT IFNULL(MAX(usu_id),0)+1 AS ultimo FROM usuario")
        If dt.Rows.Count > 0 Then
            txt_id.Text = dt.Rows(0)("ultimo")


        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub
    Public Sub cargar()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta(" SELECT u.usu_id,u.usu_nombre,u.usu_estado,u.usu_tipo,e.emp_id FROM empleado e, usuario u where e.emp_id=u.Empleado_emp_id ")

        tabla.DataSource = tablas

    End Sub
    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
        txt_id.Text = SelectRow.Cells(1).Value.ToString()
        txt_usuario.Text = SelectRow.Cells(2).Value.ToString()
        txt_clave.Text = SelectRow.Cells(3).Value.ToString()
        cmb_nivel.Text = SelectRow.Cells("tipo").Value.ToString()
        txt_empleado.Text = SelectRow.Cells("empleado").Value.ToString()
        estado2 = SelectRow.Cells("estado").Value.ToString()

        If estado2 = "Activo" Then
            rbt_activo.Checked = True
        Else
            rbt_inactivo.Checked = True
        End If

        habilitar()

    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        cargar_codigo()
        habilitar()
        limpiar()
    End Sub
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        If rbt_activo.Checked = True Then
            estado2 = "Activo"
        ElseIf rbt_inactivo.Checked = True Then
            estado2 = "Inactivo"
        End If
        If txt_nombre.Text = "" Then
            txt_nombre.Focus()
        ElseIf txt_clave.Text = "" Then
            txt_clave.Focus()
        ElseIf cmb_nivel.Text = "" Then
            cmb_nivel.Focus()

        Else

            Dim query As String = "insert into usuario (usu_id,usu_nombre,usu_contraseña,usu_estado,usu_tipo,Empleado_emp_id)" & _
 "VALUES ('" & txt_id.Text & "', '" & txt_nombre.Text & "', '" & txt_clave.Text & "','" & estado2 & "', '" & cmb_nivel.Text & "','" & txt_id.Text & "');"
            If conexion.executarsql(query) Then
                MsgBox("Registro Guardado con Exito", MsgBoxStyle.Information)
                cargar()
            Else
                MsgBox("Registro no guardado", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        If rbt_activo.Checked = True Then
            estado2 = "Activo"
        ElseIf rbt_inactivo.Checked = True Then
            estado2 = "Inactivo"
        End If

        If txt_nombre.Text = "" Then
            txt_nombre.Focus()
        ElseIf txt_clave.Text = "" Then
            txt_clave.Focus()
        ElseIf cmb_nivel.Text = "" Then
            cmb_nivel.Focus()

        Else
            Dim query As String = "UPDATE usuario SET usu_nombre='" & txt_nombre.Text & "', usu_contraseña='" & _
           txt_clave.Text & "',usu_estado='" & estado2 & "',usu_tipo='" & cmb_nivel.Text & "',Empleado_emp_id='" & txt_id.Text & "' WHERE usu_id='" & txt_id.Text & "'"


            If conexion.executarsql(query) Then
                MsgBox("Registro Modificado con Exito", MsgBoxStyle.Information)
                cargar()
            Else
                MsgBox("Registro No Modificado", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        If txt_id.Text = "" Then
            MsgBox("Seleccionar los datos a eliminar")
        Else
            If MsgBox("Desea eliminar el registro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim query As String = "DELETE FROM usuario WHERE usu_id ='" & txt_id.Text & "'"
                If conexion.executarsql(query) Then
                    MsgBox("Registro eliminado con exito", MsgBoxStyle.Information)
                    cargar()
                    limpiar()
                Else
                    MsgBox("Registro no eliminado", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub



    Private Sub Usuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitar()
        cargar()
        rbt_activo.Checked = True
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim cliente As New Detalle_empleado
        cliente.FormBorderStyle = Windows.Forms.FormBorderStyle.FixedDialog
        cliente.ShowDialog()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class