Imports MySql.Data
Imports System.Text
Imports System.Security.Cryptography
Imports MySql.Data.Types
Imports MySql.Data.MySqlClient
Module conexion
    Public cod_usuario As Integer
    Public nom_usuario As String
    Public cod_producto As Integer
    Public cod_oden_compra As Integer
    Public cod_cliente As Integer
    Public cod_proveedor As Integer
    Public cod_pedido As Integer
    Public cod_empleado As Integer
    Public cod_presupuesto As Integer
    Public Function conexion_global() As Boolean
        Dim estado As Boolean = True
        Try
            Dim conexion As New MySqlConnectionStringBuilder()
            conexion.Server = "localhost"
            conexion.UserID = "root"
            conexion.Password = ""
            conexion.Database = "gestion"
            Dim con As New MySqlConnection(conexion.ToString())
            con.Open()
            MsgBox("La conexion se realizo")
        Catch ex As Exception
            estado = False
            MsgBox("No se pudo conectar " & ex.Message)
        End Try
        Return estado
    End Function

    Public Function consulta(ByVal comando As String) As DataTable

        Dim conexion As New MySqlConnectionStringBuilder()
        conexion.Server = "localhost"
        conexion.UserID = "root"
        conexion.Password = ""
        conexion.Database = "gestion"
        Dim con As New MySqlConnection(conexion.ToString())
        con.Open()
        Dim det = New DataTable()
        Dim ds As New DataSet
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando, con)
        da.Fill(det)
        con.Close()
        Return (det)
    End Function

    Function executarsql(ByVal comando As String) As Boolean
        Try

            Dim conexion As New MySqlConnectionStringBuilder()
            conexion.Server = "localhost"
            conexion.UserID = "root"
            conexion.Password = ""
            conexion.Database = "gestion"
            Dim con As New MySqlConnection(conexion.ToString())
            con.Open()
            Dim ejecute As MySqlCommand = New MySqlCommand(comando, con)
            If ejecute.ExecuteNonQuery = 0 Then

                con.Close()
                Return False
            Else
                con.Close()
                Return True
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
        Return False
    End Function

    Public Function Encryptar(ByVal Password As String) As String
        Dim a As Encoding = Encoding.UTF8
        Dim hmac As New HMACSHA256(a.GetBytes("secret"))
        Dim b As Byte() = hmac.ComputeHash(a.GetBytes(Password))
        Dim s As New StringBuilder
        For i As Integer = 0 To b.Length - 1
            s.Append(b(i).ToString("x2"))
        Next
        'Console.WriteLine("Output:{0}", s.ErrorToString())
        Return s.ToString

    End Function
  
End Module

