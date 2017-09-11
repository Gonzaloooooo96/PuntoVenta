Imports MySql.Data.MySqlClient
Public Class Form3

    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=localhost; Database=prueba; Uid=root; Pwd=hola123;"
            MsgBox("Conectado")

        Catch ex As Exception
            MsgBox(ex.Message)

        End Try

        comando.CommandText = "SELECT * FROM usuario"
        Dim dt As DataTable = New DataTable
        Dim da As MySqlDataAdapter = New MySqlDataAdapter(comando)

        da.Fill(dt)
        DataGridView1.DataSource = dt

        conexion.Close()



    End Sub
End Class