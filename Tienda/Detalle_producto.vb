Public Class Detalle_producto
    Private Sub cargar_grilla()
        Dim cod As Integer = Val(Orden_Compra.txt_id_prov.Text.ToString)
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta(" SELECT prod_id, prod_nombre, prod_descripcion,prod_preciocompra,prod_iva,prod_id_prov FROM producto where prod_id_prov= " & cod)

        DataGridView1.DataSource = tablas
    End Sub
    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = DataGridView1.Rows(index)
        Orden_Compra.txt_id_prod.Text = SelectRow.Cells("Codigo").Value.ToString()
        Orden_Compra.txt_nombre_prod.Text = SelectRow.Cells("Nombre").Value.ToString() & SelectRow.Cells("descripcion").Value.ToString()
        If SelectRow.Cells("iva").Value.ToString() = 5 Then
            Orden_Compra.txt_iva.Text = SelectRow.Cells("iva").Value.ToString()
        ElseIf SelectRow.Cells("iva").Value.ToString() = 10 Then
            Orden_Compra.txt_iva.Text = SelectRow.Cells("iva").Value.ToString()

        End If

        Orden_Compra.txt_precio_prod.Text = SelectRow.Cells("precio").Value.ToString()

        Close()

    End Sub
    Private Sub Detalle_producto_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub
End Class