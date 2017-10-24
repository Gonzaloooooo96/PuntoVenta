Imports MySql.Data.MySqlClient
Public Class login


    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand
        Dim comando2 As MySqlCommand = New MySqlCommand

        comando.Connection = conexion
        comando2.Connection = conexion

        Try
            conexion.ConnectionString = "Server=localhost; Database=supermercado; Uid=root; Pwd=xhandwyh;"
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MessageBox.Show("Lo sentimos, no se pudo autenticar al usuario debido a un problema en la conexión con la base de datos." & vbCr & vbCr & "                                     INFORMACIÓN  DEL ERROR:" & vbCr & vbCr & ex.Message, "Error al autenticar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try
        comando2.CommandText = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = 'usuario'"
        'condición en caso de no haber conexión con la base de datos el programa no se caiga'
        If conexion.State = False Then

            'si no hay conexión ocurrirá lo siguiente'

        Else
            Dim r2 As MySqlDataReader
            r2 = comando2.ExecuteReader
            ' el siguiente if es para que no caiga en caso de que la tabla vendedor no exista ya que ejecuta la consulta comando2'
            If r2.HasRows <> False Then
                conexion.Close()
                Dim r As MySqlDataReader

                Try
                    conexion.ConnectionString = "Server=localhost; Database=supermercado; Uid=root; Pwd=xhandwyh;"
                    conexion.Open()
                    'MsgBox("Conectado")
                Catch ex As Exception
                    MessageBox.Show("Lo sentimos, no se pudo autenticar al usuario debido a un problema en la conexión con la base de datos." & vbCr & vbCr & "                                     INFORMACIÓN  DEL ERROR:" & vbCr & vbCr & ex.Message, "Error al autenticar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End Try
                comando.CommandText = "SELECT * FROM usuario WHERE cuenta_usuario='" + TextBox1.Text + "' AND contraseña='" + TextBox2.Text + "'"
                r = comando.ExecuteReader
                If r.HasRows <> False Then
                    r.Read()
                    MessageBox.Show("Bienvenido(a) " & TextBox1.Text & ", tu cuenta ha sido verificada exitosamente.", "Autenticación finalizada")
                    TextBox1.Text = ""
                    TextBox2.Text = ""

                    Me.Hide()
                    menuPrincipal.Show()

                Else
                    MessageBox.Show("Los datos ingresados son incorrectos, porfavor verifique los datos ingresados e intentelo nuevamente.", "                                                    Error en la autenticación", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
                End If
            Else
                MessageBox.Show("Lo sentimos, no se pudo autenticar al usuario debido a un problema en la conexión con la base de datos." & vbCr & vbCr & "                                     INFORMACIÓN  DEL ERROR:" & vbCr & vbCr & "No se encuentra la tabla vendedor en la Base de datos del sistema.", "Error al autenticar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
            End If

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=localhost; Database=supermercado; Uid=root; Pwd=xhandwyh;"
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            MessageBox.Show("Lo sentimos, hay un problema con la conexión con la base de datos." & vbCr & vbCr & "                                     INFORMACIÓN  DEL ERROR:" & vbCr & vbCr & ex.Message, "Error al autenticar usuario", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=localhost; Database=supermercado; Uid=root; Pwd=xhandwyh;"
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Lo sentimos, no se puede ingresar a la recuperación de contraseña de la cuenta debido a un problema en la conexión con la base de datos." & vbCr & vbCr & "                                     INFORMACIÓN  DEL ERROR:" & vbCr & vbCr & ex.Message, "Error conexión a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If conexion.State = False Then

        Else
            Me.Hide()

        End If
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim conexion As MySqlConnection = New MySqlConnection
        Dim comando As MySqlCommand = New MySqlCommand

        comando.Connection = conexion

        Try
            conexion.ConnectionString = "Server=localhost; Database=supermercado; Uid=root; Pwd=xhandwyh;"
            conexion.Open()
            'MsgBox("Conectado")
        Catch ex As Exception
            'MsgBox(ex.Message)
            MessageBox.Show("Lo sentimos, no se puede crear un nuevo usuario debido a un problema en la conexión con la base de datos." & vbCr & vbCr & "                                     INFORMACIÓN  DEL ERROR:" & vbCr & vbCr & ex.Message, "Error conexión a la base de datos", MessageBoxButtons.OK, MessageBoxIcon.Exclamation)
        End Try

        If conexion.State = False Then

        Else
            Me.Hide()

            registroUsuarios.Show()
        End If


    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click

        If TextBox2.PasswordChar = "*" Then

            TextBox2.PasswordChar = ""
            Button5.Text = "Ocultar"
        Else
            TextBox2.PasswordChar = "*"c
            Button5.Text = "Ver"
        End If

    End Sub

    Private Sub TextBox2_TextChanged(sender As Object, e As EventArgs) Handles TextBox2.TextChanged
        If String.IsNullOrEmpty(TextBox2.Text) Or String.IsNullOrEmpty(TextBox1.Text) Then
            Button2.Visible = True
            Button1.Visible = False
            Button1.Enabled = False
        Else
            Button2.Visible = False
            Button1.Visible = True
            Button1.Enabled = True
        End If
        If String.IsNullOrEmpty(TextBox2.Text) Then
            Button5.Visible = False
            TextBox2.PasswordChar = "*"c
            Button5.Text = "Ver"
        Else
            Button5.Visible = True
        End If

    End Sub

    Private Sub TextBox2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox2.KeyPress

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

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged
        If String.IsNullOrEmpty(TextBox1.Text) Or String.IsNullOrEmpty(TextBox2.Text) Then
            Button2.Visible = True
            Button1.Visible = False
            Button1.Enabled = False
        Else
            Button2.Visible = False
            Button1.Visible = True
            Button1.Enabled = True
        End If
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) 
        Me.Close()
    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles TextBox1.KeyPress

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

    Private Sub TextBox2_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox2.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

    Private Sub TextBox1_KeyDown(sender As Object, e As KeyEventArgs) Handles TextBox1.KeyDown
        If e.KeyCode = Keys.Enter Then
            Call Button1_Click(sender, e)
        End If
    End Sub

End Class