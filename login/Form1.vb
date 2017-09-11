Imports MySql.Data.MySqlClient
Public Class Form1


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If String.IsNullOrEmpty(TextBox1.Text) Then
            MessageBox.Show("Porfavor, ingrese datos en el campo usuario")
            Return

        End If

        If String.IsNullOrEmpty(TextBox2.Text) Then
            MessageBox.Show("Porfavor, ingrese datos en el campo contraseña")

            Return
        End If

        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=localhost; Database=ventas; Uid=root; Pwd=ascent;"
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

        comando.CommandText = "SELECT * FROM vendedor WHERE nombre_cuenta='" + TextBox1.Text + "' AND pass_cuenta='" + TextBox2.Text + "'"

        Dim r As MySqlDataReader
        r = comando.ExecuteReader
        If r.HasRows <> False Then
            r.Read()

            TextBox1.Text = ""
            TextBox2.Text = ""

            While (Panel2.Height > 0)
                Panel2.Height -= 1
            End While
            Size = New Size(384, 392)
            Me.Hide()
            Form2.Show()

        Else
            Size = New Size(384, 490)
            While (Panel2.Height < 100)
                Panel2.Height += 1
            End While
        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        While (Panel2.Height > 0)
            Panel2.Height -= 1
        End While
        Size = New Size(384, 392)
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


End Class