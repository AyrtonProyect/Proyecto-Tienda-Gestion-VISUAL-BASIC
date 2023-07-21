Public Class Login

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim dt As DataTable = conexion.consulta("select usu_id, usu_nombre,usu_tipo from usuario where usu_nombre='" & _
       txt_usuario.Text.Trim & "'and usu_contraseña='" & Encryptar(txt_clave.Text.Trim) & "'")
        If dt.Rows.Count > 0 Then
            cod_usuario = dt.Rows(0)("usu_id")
            nom_usuario = dt.Rows(0)("usu_nombre")
            MenuP.Show()
            Me.Hide()
        Else
            MsgBox("Usuario no registrado", MsgBoxStyle.Critical)

        End If

    End Sub

    Private Sub Login_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class