Imports MySql.Data.MySqlClient
Public Class Departamento
    Public Sub visibles()
        etiqueta_nombre.Visible = True
        etiqueta_capital.Visible = True

    End Sub
    Public Sub invisibles()
        etiqueta_nombre.Visible = False
        etiqueta_capital.Visible = False

    End Sub
    Public Sub habilitar_etiquetas()
        etiqueta_nombre.Enabled = True
        etiqueta_capital.Enabled = True

    End Sub
    Public Sub deshabilitar_etiquetas()
        etiqueta_nombre.Enabled = False
        etiqueta_capital.Enabled = False

    End Sub
    Private Sub Departamento_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_tabla()
        deshabilitar()
    End Sub
    Public Sub habilitar()
        txt_nombre.Enabled = True
        txt_capital.Enabled = True
    End Sub
    Public Sub deshabilitar()
        txt_nombre.Enabled = False
        txt_id.Enabled = False
        txt_capital.Enabled = False
    End Sub
    Public Sub cargar_tabla()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta("select * from departamento ORDER BY dep_id")
        Dim objDataView As New DataView(tablas)
        tabla.DataSource = tablas
        If txt_buscar.Text <> "" Then
            objDataView.RowFilter = "dep_nombre LIKE '%" & txt_buscar.Text & "%'"
            If objDataView.ToTable.Rows.Count > 0 Then
                tabla.DataSource = objDataView.ToTable
            End If
        End If
    End Sub
   
    Public Sub limpiar()
        txt_nombre.Text = ""
        txt_id.Text = ""
        txt_capital.Text = ""
    End Sub

    Private Sub btn_nuevo_Click(sender As Object, e As EventArgs) Handles btn_nuevo.Click

        habilitar()
        limpiar()
        visibles()
        habilitar_etiquetas()
        cargar_codigo()
        txt_nombre.Focus()
    End Sub
    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
        txt_id.Text = SelectRow.Cells(0).Value.ToString()
        txt_nombre.Text = SelectRow.Cells(1).Value.ToString()
        txt_capital.Text = SelectRow.Cells(2).Value.ToString()
        habilitar()


    End Sub
    Private Sub btn_guardar_Click(sender As Object, e As EventArgs) Handles btn_guardar.Click
        If txt_nombre.Text = "" Then
            MsgBox("Ingresar Nombre")
        ElseIf txt_capital.Text = "" Then
            MsgBox("Ingrese Capital")
        Else
            Dim query As String = "INSERT INTO departamento ( dep_id,dep_nombre,dep_capital)" & _
          "VALUES ('" & txt_id.Text & "', '" & txt_nombre.Text & "','" & txt_capital.Text & "');"
            If conexion.executarsql(query) Then
                MsgBox("Guardado!", MsgBoxStyle.Information)
                cargar_tabla()
                limpiar()


            Else
                MsgBox("NO SE HA REGISTRADO", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Public Sub cargar_codigo()
        Dim dt As DataTable = conexion.consulta("SELECT IFNULL(MAX(dep_id),0)+1 AS ultimo FROM departamento ")
        If dt.Rows.Count > 0 Then
            txt_id.Text = dt.Rows(0)("ultimo")


        Else
            MsgBox("Fallo al generar codigo", MsgBoxStyle.Critical)

        End If

    End Sub


    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        If txt_id.Text = "" Then
            MsgBox("Introducir Id")
        Else
            If MsgBox("Estas seguro?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
                Dim query As String = "DELETE FROM departamento WHERE dep_id='" & txt_id.Text & "'"
                If conexion.executarsql(query) Then
                    cargar_tabla()
                    limpiar()

                Else
                    MsgBox("Registro no eliminado", MsgBoxStyle.Critical)
                End If
            End If
        End If
    End Sub

    Private Sub btn_modificar_Click(sender As Object, e As EventArgs) Handles btn_modificar.Click

        If txt_id.Text = "" Then
            MsgBox("Introducir el ID que desea modificar")
        ElseIf txt_nombre.Text = "" Then
            MsgBox("Introducir un Nombre")
        ElseIf txt_capital.Text = "" Then
            MsgBox("Introducir Capital")


        Else
            Dim query As String = "Update departamento SET  dep_nombre='" & txt_nombre.Text & "', dep_capital='" & txt_capital.Text & "' WHERE dep_id='" & txt_id.Text & "'"

            If conexion.executarsql(query) Then
                MsgBox("Exito!", MsgBoxStyle.Information)
                cargar_tabla()
                limpiar()
            Else
                MsgBox("NO SE HA MODIFICADO", MsgBoxStyle.Critical)
            End If
        End If

    End Sub
    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If e.KeyChar = ChrW(Keys.Enter) Then
            txt_capital.Focus()
        End If


    End Sub
    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        cargar_tabla()
    End Sub

    Private Sub txt_nombre_TextChanged(sender As Object, e As EventArgs) Handles txt_nombre.TextChanged
        etiqueta_nombre.Visible = False
    End Sub

    Private Sub txt_capital_TextChanged(sender As Object, e As EventArgs) Handles txt_capital.TextChanged
        etiqueta_capital.Visible = False
    End Sub
End Class
