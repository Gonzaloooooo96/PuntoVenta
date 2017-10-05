Imports MySql.Data.MySqlClient
Public Class registroUsuarios


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=localhost; Database=ventas; Uid=proyecto; Pwd=Proyecto123;"
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MessageBox.Show("Lo sentimos, no se pudo autenticar al usuario debido a un problema en la conexión con la base de datos." & vbCr & vbCr & "                                     INFORMACIÓN  DEL ERROR:" & vbCr & vbCr & ex.Message, "Error al autenticar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        comando.CommandText = "SELECT * FROM vendedor WHERE nombre_cuenta='" + nombre_cuenta.Text + "'"

        'condición en caso de no haber conexión con la base de datos el programa no se caiga'
        If conexion.State = False Then


            'si no hay conexión ocurrirá lo siguiente'

        Else

            Dim r As MySqlDataReader
            r = comando.ExecuteReader

            If r.HasRows <> False Then

                MessageBox.Show("El nombre de cuenta " & nombre_cuenta.Text & " ya está en uso, porfavor ingrese otro nombre de usuario", "Error al crear nuevo usuario")


            Else

                comando = New MySqlCommand("INSERT INTO vendedor(nombre_cuenta,pass_cuenta,pregunta1,pregunta2,respuesta1,respuesta2)" & Chr(13) & "VALUES(@nombre_cuenta,@pass_cuenta,@pregunta1,@pregunta2,@respuesta1,@respuesta2)", conexion)
                comando.Parameters.AddWithValue("@nombre_cuenta", nombre_cuenta.Text)
                comando.Parameters.AddWithValue("@pass_cuenta", pass_cuenta.Text)
                comando.Parameters.AddWithValue("@pregunta1", pregunta1.Text)
                comando.Parameters.AddWithValue("@pregunta2", pregunta2.Text)
                comando.Parameters.AddWithValue("@respuesta1", respuesta1.Text)
                comando.Parameters.AddWithValue("@respuesta2", respuesta2.Text)
                conexion.Close()

                Try
                    conexion.ConnectionString = "Server=localhost; Database=ventas; Uid=proyecto; Pwd=Proyecto123;"
                    conexion.Open()
                    'MsgBox("Conectado")
                Catch ex As Exception
                    MessageBox.Show("Lo sentimos, no se pudo autenticar al usuario debido a un problema en la conexión con la base de datos." & vbCr & vbCr & "                                     INFORMACIÓN  DEL ERROR:" & vbCr & vbCr & ex.Message, "Error al autenticar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
                comando.ExecuteNonQuery()
                MsgBox("La cuenta " & nombre_cuenta.Text & " ha sido registrado exitosamente, gracias por registrate")
                Me.Close()
                login.Show()


            End If
        End If


    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        Button6.Text = "Ver contraseña"
        If pass_cuenta.PasswordChar = "*" Then
            pass_cuenta.PasswordChar = ""
            Button6.Text = "Ocultar"
        Else pass_cuenta.PasswordChar = "*"c
        End If

    End Sub

    Private Sub FormRegistro_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        login.Show()

    End Sub

    Private Sub FormRegistro_Load(sender As Object, e As EventArgs) Handles Me.Load
        pregunta1.SelectedIndex = 0
        pregunta2.SelectedIndex = 1
    End Sub

    Private Sub nombre_cuenta_TextChanged(sender As Object, e As EventArgs) Handles nombre_cuenta.TextChanged
        If String.IsNullOrEmpty(nombre_cuenta.Text) Or String.IsNullOrEmpty(pass_cuenta.Text) Or String.IsNullOrEmpty(respuesta1.Text) Or String.IsNullOrEmpty(respuesta2.Text) Then
            Label1.Visible = True
            Button1.Enabled = False
        Else
            Label1.Visible = False
            Button1.Enabled = True
        End If

        If String.IsNullOrEmpty(nombre_cuenta.Text) Or String.IsNullOrEmpty(pass_cuenta.Text) Then
            Label7.Visible = True
            pregunta1.Enabled = False
            pregunta2.Enabled = False
            respuesta1.Enabled = False
            respuesta2.Enabled = False
        Else
            Label7.Visible = False
            pregunta1.Enabled = True
            pregunta2.Enabled = True
            respuesta1.Enabled = True
            respuesta2.Enabled = True
        End If
    End Sub

    Private Sub pass_cuenta_TextChanged(sender As Object, e As EventArgs) Handles pass_cuenta.TextChanged
        If String.IsNullOrEmpty(pass_cuenta.Text) Or String.IsNullOrEmpty(nombre_cuenta.Text) Or String.IsNullOrEmpty(respuesta1.Text) Or String.IsNullOrEmpty(respuesta2.Text) Then
            Label1.Visible = True
            Button1.Enabled = False
        Else
            Label1.Visible = False
            Button1.Enabled = True
        End If

        If String.IsNullOrEmpty(pass_cuenta.Text) Then
            Button6.Visible = False
            Button6.Text = "Ver contraseña"
            pass_cuenta.PasswordChar = "*"
        Else
            Button6.Visible = True
        End If
        If String.IsNullOrEmpty(pass_cuenta.Text) Or String.IsNullOrEmpty(nombre_cuenta.Text) Then
            Label7.Visible = True
            pregunta1.Enabled = False
            pregunta2.Enabled = False
            respuesta1.Enabled = False
            respuesta2.Enabled = False
        Else
            Label7.Visible = False
            pregunta1.Enabled = True
            pregunta2.Enabled = True
            respuesta1.Enabled = True
            respuesta2.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub respuesta1_TextChanged(sender As Object, e As EventArgs) Handles respuesta1.TextChanged
        If String.IsNullOrEmpty(respuesta1.Text) Or String.IsNullOrEmpty(nombre_cuenta.Text) Or String.IsNullOrEmpty(pass_cuenta.Text) Or String.IsNullOrEmpty(respuesta2.Text) Then
            Label1.Visible = True
            Button1.Enabled = False
        Else
            Label1.Visible = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub respuesta2_TextChanged(sender As Object, e As EventArgs) Handles respuesta2.TextChanged
        If String.IsNullOrEmpty(respuesta2.Text) Or String.IsNullOrEmpty(nombre_cuenta.Text) Or String.IsNullOrEmpty(pass_cuenta.Text) Or String.IsNullOrEmpty(respuesta1.Text) Then
            Label1.Visible = True
            Button1.Enabled = False
        Else
            Label1.Visible = False
            Button1.Enabled = True
        End If
    End Sub

    Private Sub nombre_cuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles nombre_cuenta.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub pass_cuenta_KeyPress(sender As Object, e As KeyPressEventArgs) Handles pass_cuenta.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub respuesta1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles respuesta1.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub respuesta2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles respuesta2.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsDigit(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

End Class
