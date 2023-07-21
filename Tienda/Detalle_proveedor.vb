Imports MySql.Data.MySqlClient
Public Class Detalle_proveedor
    Private Sub cargar_grilla()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta(" SELECT prov_id, prov_nombre, prov_ruc FROM proveedor ")

        DataGridView1.DataSource = tablas
    End Sub
    Private Sub Detalle_proveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub
    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = DataGridView1.Rows(index)
        Orden_Compra.txt_id_prov.Text = SelectRow.Cells("Codigo").Value.ToString()
        Orden_Compra.txt_nombre_prov.Text = SelectRow.Cells("Nombre").Value.ToString()
        Orden_Compra.txt_ruc_prov.Text = SelectRow.Cells("Ruc").Value.ToString()

        Close()

    End Sub
End Class