Public Class listarEliminarUsuarios
    Dim obj As New Class1


    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        End
        Me.Close()

    End Sub

    Private Sub Boton_Listar_Click(sender As Object, e As EventArgs) Handles Boton_Listar.Click
        Dim Sql As String = "Select * from vendedor where estado = 0 and nombre_cuenta = '" & txtCodigo.Text & "'"

        obj.consulta(DGTabla, Sql)
    End Sub

    Private Sub Boton_Eliminar_Click(sender As Object, e As EventArgs) Handles Boton_Eliminar.Click
        Dim Sql As String = "Update vendedor Set estado = 1 where nombre_cuenta = '" & txtCodigo.Text & "'"

        obj.consulta(DGTabla, Sql)
        Dim Sql1 As String = "Select * from vendedor where estado = 0"
        obj.consulta(DGTabla, Sql1)

    End Sub

    Private Sub Boton_listarTodo_Click(sender As Object, e As EventArgs) Handles Boton_listarTodo.Click
        Dim Sql As String = "Select * from vendedor where estado = 0"

        obj.consulta(DGTabla, Sql)
    End Sub


    Private Sub DGTabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTabla.CellClick
        Dim i As Integer

        i = DGTabla.CurrentRow.Index
        txtCodigo.Text = DGTabla.Item(0, i).Value()





    End Sub

    Private Sub txtCodigo_TextChanged(sender As Object, e As EventArgs) Handles txtCodigo.TextChanged

    End Sub

    Private Sub Form1_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        menuPrincipal.Show()
    End Sub
End Class
