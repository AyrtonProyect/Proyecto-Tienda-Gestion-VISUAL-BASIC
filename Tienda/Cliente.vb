Imports MySql.Data.MySqlClient
Public Class Cliente
    Public Sub combo_departamento()
        'Dim valor As String
        Dim rs As DataTable = conexion.consulta("select dep_id, dep_nombre from departamento ORDER BY dep_id ")
        '("SELECT dep_id,dep_nombre FROM departamento WHERE CONCAT (dep_nombre,' ') LIKE '%" + valor + "%'")

        cmb_dep.DataSource = rs
        cmb_dep.DisplayMember = "dep_nombre"
        cmb_dep.ValueMember = "dep_id"

    End Sub
  
    Private Sub cmb_dep_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_dep.SelectedIndexChanged
            Dim cod As Integer = Val(cmb_dep.SelectedValue.ToString)
            Dim rs As DataTable = conexion.consulta("SELECT ciu_id, ciu_nombre FROM ciudad where Departamento_dep_id= " & cod)

            cmb_ciu.DataSource = rs
            cmb_ciu.DisplayMember = "ciu_nombre"
        cmb_ciu.ValueMember = "ciu_id"

        etiqueta_departamento.Visible = False
    End Sub
    

    Public Sub limpiar()
        txt_id.Text = ""
        txt_nombre.Text = ""
        txt_apellido.Text = ""
        txt_cedula.Text = ""
        txt_ruc.Text = ""
        txt_telefono.Text = ""
        txt_direccion.Text = ""
        txt_mail.Text = ""
        cmb_sexo.Text = ""
        cmb_dep.Text = ""
        cmb_ciu.Text = ""

    End Sub
    Public Sub habilitar()
        txt_nombre.Enabled = True
        txt_apellido.Enabled = True
        txt_cedula.Enabled = True
        txt_ruc.Enabled = True
        txt_telefono.Enabled = True
        txt_direccion.Enabled = True
        txt_mail.Enabled = True

        cmb_sexo.Enabled = True
        cmb_dep.Enabled = True
        cmb_ciu.Enabled = True
    End Sub
    Public Sub deshabilitar()
        txt_id.Enabled = False

        txt_nombre.Enabled = False
        txt_apellido.Enabled = False
        txt_cedula.Enabled = False
        txt_ruc.Enabled = False
        txt_telefono.Enabled = False
        txt_direccion.Enabled = False
        txt_mail.Enabled = False
        cmb_sexo.Enabled = False
        cmb_dep.Enabled = False
        cmb_ciu.Enabled = False
    End Sub
    Private Sub Cliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        deshabilitar()
        cargar_tabla()
        total()
        txt_total.Enabled = False
        desabilitar_etiquetas()

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
        habilitar()
        combo_departamento()
        limpiar()
        visibles()
        habilitar_etiquetas()
        cargar_codigo()
        txt_nombre.Focus()

    End Sub


    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
    Public Sub cargar_codigo()
        Dim dt As DataTable = conexion.consulta("SELECT IFNULL(MAX(cli_id),0)+1 AS ultimo FROM cliente ")
        If dt.Rows.Count > 0 Then
            txt_id.Text = dt.Rows(0)("ultimo")


        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub
    Public Sub total()
        Dim dt As DataTable = conexion.consulta("SELECT count(*) AS ultimo from cliente ")
        If dt.Rows.Count > 0 Then
            txt_total.Text = dt.Rows(0)("ultimo")


        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub
    Public Sub cargar_tabla()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta("select a.cli_id, a.cli_nombre,a.ciu_id,a.cli_apellido, a.cli_sexo, a.cli_direccion, a.cli_email, a.cli_telefono, a.cli_ruc, a.cli_ci,Departamento_dep_id, b.ciu_nombre, c.dep_nombre from cliente a, ciudad b, departamento c where a.ciu_id=b.ciu_id and b.Departamento_dep_id=c.dep_id")
        tabla.DataSource = tablas
        Dim objDataView As New DataView(tablas)
        If txt_buscar.Text <> "" Then
            Select Case ComboBusca.Text
                Case "Nombre"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "cli_nombre LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If
                Case "Apellido"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "cli_apellido LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If
            End Select
        End If
    End Sub
  
    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        Dim index As Integer
        Dim id_de As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
        txt_id.Text = SelectRow.Cells(0).Value.ToString()
        txt_nombre.Text = SelectRow.Cells(1).Value.ToString()
        txt_apellido.Text = SelectRow.Cells("Apellido").Value.ToString()
        txt_cedula.Text = SelectRow.Cells(9).Value.ToString()
        txt_ruc.Text = SelectRow.Cells(8).Value.ToString()
        txt_telefono.Text = SelectRow.Cells("Telefono").Value.ToString()
        txt_direccion.Text = SelectRow.Cells("Direccion").Value.ToString()
        txt_mail.Text = SelectRow.Cells(6).Value.ToString()
        cmb_sexo.Text = SelectRow.Cells(4).Value.ToString()
        id_de = SelectRow.Cells("id_dep").Value.ToString()
        combo_departamento()
        Dim rs As DataTable = conexion.consulta("SELECT ciu_id, ciu_nombre FROM ciudad where Departamento_dep_id = " & id_de)

        cmb_ciu.DataSource = rs
        cmb_ciu.DisplayMember = "ciu_nombre"
        cmb_ciu.ValueMember = "ciu_id"

        habilitar()
        invisibles()

    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_cedula.Text <> "" Then
            Dim comparador As Integer
            Dim x As Integer
            Dim dt As DataTable = conexion.consulta("SELECT cli_ci As ultimo from cliente where cli_ci= " & txt_cedula.Text)
            If dt.Rows.Count > 0 Then
                comparador = dt.Rows(0)("ultimo")
                x = Val(txt_cedula.Text)
                If comparador = x Then
                    etiqueta_cedula.Visible = True
                End If
            End If
        End If
        If txt_nombre.Text = "" Then
            etiqueta_nombre.Visible = True

        ElseIf txt_apellido.Text = "" Then
            etiqueta_apellido.Visible = True
        ElseIf txt_cedula.Text = "" Then
            etiqueta_cedula.Visible = True
        ElseIf txt_ruc.Text = "" Then
            etiqueta_ruc.Visible = True
        ElseIf txt_telefono.Text = "" Then
            etiqueta_telefono.Visible = True
        ElseIf txt_direccion.Text = "" Then
            etiqueta_direccion.Visible = True
        ElseIf txt_mail.Text = "" Then
            etiqueta_email.Visible = True
        ElseIf cmb_sexo.Text = "" Then
            etiqueta_sexo.Visible = True
        ElseIf cmb_dep.Text = "" Then
            etiqueta_departamento.Visible = True
        ElseIf cmb_ciu.Text = "" Then
            etiqueta_ciudad.Visible = True
        Else
            Dim query As String = "INSERT INTO cliente ( cli_id,ciu_id,cli_nombre,cli_apellido,cli_sexo,cli_direccion,cli_email,cli_telefono,cli_ruc,cli_ci)" & _
          "VALUES ('" & txt_id.Text & "','" & cmb_ciu.SelectedValue & "', '" & txt_nombre.Text & "','" & txt_apellido.Text & "','" & cmb_sexo.Text & "','" & txt_direccion.Text & "','" & txt_mail.Text & "','" & txt_telefono.Text & "','" & txt_ruc.Text & "','" & txt_cedula.Text & "');"
            If conexion.executarsql(query) Then
                desabilitar_etiquetas()
                cargar_tabla()
                limpiar()
                deshabilitar()
                visibles()
                total()

        End If
        End If

    End Sub



    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
        If txt_nombre.Text = "" Then
            etiqueta_nombre.Visible = True

        ElseIf txt_apellido.Text = "" Then
            etiqueta_apellido.Visible = True
        ElseIf txt_cedula.Text = "" Then
            etiqueta_cedula.Visible = True
        ElseIf txt_ruc.Text = "" Then
            etiqueta_ruc.Visible = True
        ElseIf txt_telefono.Text = "" Then
            etiqueta_telefono.Visible = True
        ElseIf txt_direccion.Text = "" Then
            etiqueta_direccion.Visible = True
        ElseIf txt_mail.Text = "" Then
            etiqueta_email.Visible = True
        ElseIf cmb_sexo.Text = "" Then
            etiqueta_sexo.Visible = True
        ElseIf cmb_dep.Text = "" Then
            etiqueta_departamento.Visible = True
        ElseIf cmb_ciu.Text = "" Then
            etiqueta_ciudad.Visible = True
        Else
            Dim query As String = "Update cliente SET ciu_id='" & cmb_ciu.SelectedValue & "', cli_nombre='" & txt_nombre.Text & "', cli_apellido='" & txt_apellido.Text & "',cli_sexo='" & cmb_sexo.Text & "',cli_direccion='" & txt_direccion.Text & "',cli_email='" & txt_mail.Text & "',cli_telefono='" & txt_telefono.Text & "',cli_ruc='" & txt_ruc.Text & "',cli_ci='" & txt_cedula.Text & "' WHERE cli_id='" & txt_id.Text & "'"

            If conexion.executarsql(query) Then
                MsgBox("REGISTRO MODIFICADO CON EXITO!", MsgBoxStyle.Information)
                cargar_tabla()
                limpiar()
                deshabilitar()
                visibles()


            Else
                MsgBox("NO SE HA MODIFICADO", MsgBoxStyle.Critical)
            End If
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If txt_id.Text = "" Then
            MsgBox("Introducir Id")
        Else
            If MsgBox("ESTA SEGURO DE ELIMINAR?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim query As String = "DELETE FROM cliente WHERE cli_id='" & txt_id.Text & "'"
                If conexion.executarsql(query) Then
                    desabilitar_etiquetas()
                    cargar_tabla()
                    limpiar()
                    deshabilitar()
                    visibles()
                    total()

                Else

                End If
            End If
        End If
    End Sub


    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Label15_Click(sender As Object, e As EventArgs) Handles etiqueta_nombre.Click
        etiqueta_nombre.Visible = False
        txt_nombre.Focus()

    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_apellido.Focus()
        End If

    End Sub
    Private Sub txt_apellido_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_cedula.Focus()
        End If

    End Sub


    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        etiqueta_nombre.Visible = False
    End Sub

    Private Sub txt_cedula_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_ruc.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub

    Private Sub txt_ruc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ruc.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_mail.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub
    Private Sub txt_mail_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_mail.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_direccion.Focus()
        End If
       
    End Sub
    Private Sub txt_direccion_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_direccion.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmb_sexo.Focus()
        End If
    End Sub
    Private Sub cmb_dep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_dep.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmb_ciu.Focus()
        End If
    End Sub
    Private Sub cmb_ciu_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_ciu.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_telefono.Focus()
        End If
    End Sub
    Private Sub cmb_sexo_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_sexo.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmb_dep.Focus()
        End If
    End Sub
    Private Sub txt_telefono_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_guardar.Focus()
        End If
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = ""
        End If
    End Sub


    Public Sub visibles()
        etiqueta_nombre.Visible = True
        etiqueta_apellido.Visible = True
        etiqueta_cedula.Visible = True
        etiqueta_email.Visible = True
        etiqueta_direccion.Visible = True
        etiqueta_sexo.Visible = True
        etiqueta_departamento.Visible = True
        etiqueta_ciudad.Visible = True
        etiqueta_ruc.Visible = True
        etiqueta_telefono.Visible = True
    End Sub
    Public Sub invisibles()
        etiqueta_nombre.Visible = False
        etiqueta_apellido.Visible = False
        etiqueta_cedula.Visible = False
        etiqueta_email.Visible = False
        etiqueta_direccion.Visible = False
        etiqueta_sexo.Visible = False
        etiqueta_departamento.Visible = False
        etiqueta_ciudad.Visible = False
        etiqueta_ruc.Visible = False
        etiqueta_telefono.Visible = False
    End Sub

   

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        cargar_tabla()

    End Sub
    Public Sub habilitar_etiquetas()
        etiqueta_nombre.Enabled = True
        etiqueta_apellido.Enabled = True
        etiqueta_cedula.Enabled = True
        etiqueta_email.Enabled = True
        etiqueta_direccion.Enabled = True
        etiqueta_sexo.Enabled = True
        etiqueta_departamento.Enabled = True
        etiqueta_ciudad.Enabled = True
        etiqueta_ruc.Enabled = True
        etiqueta_telefono.Enabled = True
    End Sub
    Public Sub desabilitar_etiquetas()
        etiqueta_nombre.Enabled = False
        etiqueta_apellido.Enabled = False
        etiqueta_cedula.Enabled = False
        etiqueta_email.Enabled = False
        etiqueta_direccion.Enabled = False
        etiqueta_sexo.Enabled = False
        etiqueta_departamento.Enabled = False
        etiqueta_ciudad.Enabled = False
        etiqueta_ruc.Enabled = False
        etiqueta_telefono.Enabled = False
    End Sub

    Private Sub txt_cedula_TextChanged(sender As Object, e As EventArgs) Handles txt_cedula.TextChanged
        etiqueta_cedula.Visible = False
    End Sub

    Private Sub txt_apellido_TextChanged(sender As Object, e As EventArgs) Handles txt_apellido.TextChanged
        etiqueta_apellido.Visible = False
    End Sub

    Private Sub txt_ruc_TextChanged(sender As Object, e As EventArgs) Handles txt_ruc.TextChanged
        etiqueta_ruc.Visible = False
    End Sub

    Private Sub txt_mail_TextChanged(sender As Object, e As EventArgs) Handles txt_mail.TextChanged
        etiqueta_email.Visible = False
    End Sub

    Private Sub txt_direccion_TextChanged(sender As Object, e As EventArgs) Handles txt_direccion.TextChanged
        etiqueta_direccion.Visible = False
    End Sub

    Private Sub txt_telefono_TextChanged(sender As Object, e As EventArgs) Handles txt_telefono.TextChanged
        etiqueta_telefono.Visible = False
    End Sub

    Private Sub cmb_sexo_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_sexo.SelectedIndexChanged
        etiqueta_sexo.Visible = False
    End Sub

    Private Sub cmb_ciu_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmb_ciu.SelectedIndexChanged
        etiqueta_ciudad.Visible = False
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'Reporte_Cliente.Show()
    End Sub
End Class