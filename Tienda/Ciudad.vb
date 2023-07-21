Imports MySql.Data.MySqlClient
Public Class Ciudad

    Public Sub habilitar()
        txt_nombre.Enabled = True
        cmb_dep.Enabled = True
    End Sub
    Public Sub deshabilitar()
        txt_nombre.Enabled = False
        txt_id.Enabled = False
        cmb_dep.Enabled = False
    End Sub
    Public Sub combo_departamento()
        'Dim valor As String
        Dim rs As DataTable = conexion.consulta("select dep_id, dep_nombre from departamento")
        '("SELECT dep_id,dep_nombre FROM departamento WHERE CONCAT (dep_nombre,' ') LIKE '%" + valor + "%'")

        cmb_dep.DataSource = rs
        cmb_dep.DisplayMember = "dep_nombre"
        cmb_dep.ValueMember = "dep_id"
    End Sub
  
    Public Sub cargar_tabla()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta("select * from departamento d, ciudad c where d.dep_id=c.Departamento_dep_id")
        tabla.DataSource = tablas
        etiqueta_nombre.Visible = True
        Dim objDataView As New DataView(tablas)
        If txt_buscar.Text <> "" Then
            Select Case ComboBusca.Text
                Case "Nombre"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "ciu_nombre LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If
                Case "Departamento"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "dep_nombre LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If
            End Select
        End If
    End Sub
    Public Sub CargarCodigo()
        Dim rs As DataTable = conexion.consulta("SELECT IFNULL(MAX(ciu_id),0)+1 AS ultimo FROM ciudad")
        txt_id.Text = rs.ToString
    End Sub
    Public Sub limpiar()
        txt_nombre.Text = ""
        txt_id.Text = ""
        cmb_dep.Text = ""
    End Sub
    Public Sub cargar_codigo()
        Dim dt As DataTable = conexion.consulta("SELECT IFNULL(MAX(ciu_id),0)+1 AS ultimo FROM ciudad ")
        If dt.Rows.Count > 0 Then
            txt_id.Text = dt.Rows(0)("ultimo")


        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
        txt_id.Text = SelectRow.Cells("Codigo").Value.ToString()
        cmb_dep.Text = SelectRow.Cells("Departamento").Value.ToString()
        txt_nombre.Text = SelectRow.Cells("Nombre").Value.ToString()

        habilitar()
        Dim rs2 As DataTable = conexion.consulta("SELECT dep_nombre,dep_id from departamento where dep_nombre='" & cmb_dep.Text & "'")

        If rs2.Rows.Count > 0 Then
            cmb_dep.DataSource = rs2
            cmb_dep.Text = rs2.Rows(0)("dep_nombre")
            cmb_dep.ValueMember = "dep_id"
        Else

        End If

        etiqueta_nombre.Visible = False
    End Sub
  

    Private Sub Ciudad_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_tabla()
        deshabilitar()

    End Sub
    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            cmb_dep.Focus()
        End If

    End Sub
    Private Sub cmb_dep_KeyPress(sender As Object, e As KeyPressEventArgs) Handles cmb_dep.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            btn_guardar.Focus()
        End If

    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click
     
        habilitar()
        combo_departamento()
        limpiar()
        etiqueta_nombre.Visible = True
        etiqueta_nombre.Enabled = True
        cargar_codigo()
        txt_nombre.Focus()

    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_id.Text = "" Then
            txt_id.Focus()

        ElseIf txt_nombre.Text = "" Then
            txt_nombre.Focus()
            etiqueta_nombre.Visible = True

        ElseIf cmb_dep.Text = "" Then
            cmb_dep.Focus()

        Else
            etiqueta_nombre.Visible = False
            Dim query As String = "INSERT INTO ciudad( 	ciu_id,ciu_nombre,Departamento_dep_id)" & _
            "VALUES ('" & txt_id.Text & "', '" & txt_nombre.Text & "', '" & cmb_dep.SelectedValue & "');"
            If conexion.executarsql(query) Then
                MsgBox("Guardado!", MsgBoxStyle.Information)
                cargar_tabla()
                limpiar()
                etiqueta_nombre.Enabled = False
                etiqueta_nombre.Visible = True

            Else
                MsgBox("NO SE HA REGISTRADO", MsgBoxStyle.Critical)
            End If
        End If
    End Sub
    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click
  
        If txt_nombre.Text = "" Then

            etiqueta_nombre.Visible = True
        ElseIf cmb_dep.Text = "" Then
            MsgBox("Seleccione un Departamento")


        Else
            etiqueta_nombre.Visible = False
            Dim query As String = "Update ciudad SET  ciu_nombre='" & txt_nombre.Text & "', Departamento_dep_id='" & cmb_dep.SelectedValue & "' WHERE ciu_id='" & txt_id.Text & "'"

            If conexion.executarsql(query) Then

                cargar_tabla()
                limpiar()
                etiqueta_nombre.Enabled = False
                etiqueta_nombre.Visible = True
            Else

            End If
        End If
    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If txt_id.Text = "" Then
            MsgBox("Introducir Id")
        Else
            If MsgBox("Estas seguro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim query As String = "DELETE FROM ciudad WHERE ciu_id='" & txt_id.Text & "'"
                If conexion.executarsql(query) Then
                    cargar_tabla()
                    limpiar()
                    etiqueta_nombre.Enabled = False
                    etiqueta_nombre.Visible = True
                Else
                    MsgBox("Registro no eliminado", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

   

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        cargar_tabla()
    End Sub



    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        etiqueta_nombre.Visible = False
    End Sub
End Class