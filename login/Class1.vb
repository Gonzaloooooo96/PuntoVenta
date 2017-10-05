Imports MySql.Data.MySqlClient
Public Class Class1
    Dim con As New MySqlConnection("Server=127.0.0.1;Port=3306;Database=ventas;Uid=proyecto;password=Proyecto123;")

    Sub consulta(ByVal Tabla As DataGridView, ByVal Sql As String)
        Try
            Dim DA As New MySqlDataAdapter(Sql, con)
            Dim DT As New DataTable

            DA.Fill(DT)
            Tabla.DataSource = DT

        Catch ex As Exception
            MsgBox("No se pudo realizar la consulta por: " & ex.Message)
        End Try

        con.Close()
    End Sub

    Sub operaciones(ByVal Tabla As DataGridView, ByVal Sql As String)
        con.Open()

        Try
            Dim cmd As New MySqlCommand(Sql, con)
            cmd.ExecuteNonQuery()
        Catch ex As Exception
            MsgBox("no se pudo realizar la conexion: " & ex.Message)
        End Try
        con.Close()
    End Sub

End Class
