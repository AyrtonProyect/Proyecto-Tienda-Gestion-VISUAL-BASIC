Public Class ListaProveedor

    Private Sub ListaProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()

    End Sub
    Public Sub cargar()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta(" select prov_id, prov_nombre,prov_ruc from  proveedor ")

        tabla.DataSource = tablas
        Dim objDataView As New DataView(tablas)
        If txt_buscar.Text <> "" Then
            Select Case ComboBusca.Text
                Case "Nombre"
                    If txt_buscar.Text <> "" Then
                        objDataView.RowFilter = "prov_nombre LIKE '%" & txt_buscar.Text & "%'"
                        If objDataView.ToTable.Rows.Count > 0 Then
                            tabla.DataSource = objDataView.ToTable
                        End If
                    End If

            End Select
        End If

    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        cargar()

    End Sub

    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
    
        cod_proveedor = SelectRow.Cells(0).Value.ToString()
        Me.Close()


    End Sub

    Private Sub tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellContentClick

    End Sub
End Class