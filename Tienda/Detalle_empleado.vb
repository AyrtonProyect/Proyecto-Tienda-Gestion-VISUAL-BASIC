Imports MySql.Data.MySqlClient
Public Class Detalle_empleado
    Private Sub cargar_grilla()
        Dim dt = New DataTable()
        Dim tablas As DataTable = conexion.consulta(" SELECT emp_id, emp_nombre, emp_apellido,emp_ci FROM empleado ")

        DataGridView1.DataSource = tablas
    End Sub
    Private Sub DataGridView1_CellClick(sender As System.Object, e As System.Windows.Forms.DataGridViewCellEventArgs) Handles DataGridView1.CellClick
        Dim index As Integer
        index = e.RowIndex
        Dim SelectRow As DataGridViewRow
        SelectRow = DataGridView1.Rows(index)
        Usuario.txt_empleado.Text = SelectRow.Cells("Codigo").Value.ToString()
        Usuario.txt_nombre.Text = SelectRow.Cells("Nombre").Value.ToString() & SelectRow.Cells("Apellido").Value.ToString()


        Close()

    End Sub
    Private Sub Detalle_empleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cargar_grilla()
    End Sub


End Class