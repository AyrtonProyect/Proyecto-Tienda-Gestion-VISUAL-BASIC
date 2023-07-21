Public Class ListaProducto

    Private Sub ListaProducto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar()

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

    Private Sub tabla_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellContentClick
   
    End Sub

    Private Sub tabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles tabla.CellClick

        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = tabla.Rows(index)
        cod_producto = SelectRow.Cells("Codigo").Value.ToString()


        Me.Close()

    End Sub

    Private Sub txt_buscar_TextChanged(sender As Object, e As EventArgs) Handles txt_buscar.TextChanged
        cargar()

    End Sub
End Class