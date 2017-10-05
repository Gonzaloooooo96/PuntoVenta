Public Class listarProveedores
    Dim obj As New Class1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub DGTabla_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGTabla.CellClick
        Dim i As Integer
        i = DGTabla.CurrentRow.Index
        txtRut.Text = DGTabla.Item(0, i).Value()
        txtNombre.Text = DGTabla.Item(2, i).Value()


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()

    End Sub

    Private Sub boton_Listar_Click_1(sender As Object, e As EventArgs) Handles boton_Listar.Click
        Dim Sql As String = "Select * from proveedor where estado = 0 and rut = '" & txtRut.Text & "' or nombre_proveedor='" & txtNombre.Text & "'"
        obj.consulta(DGTabla, Sql)
    End Sub

    Private Sub boton_ListarT_Click_1(sender As Object, e As EventArgs) Handles boton_ListarT.Click
        txtNombre.Text = ""
        txtRut.Text = ""
        Dim Sql As String = "Select * from proveedor where estado = 0"

        obj.consulta(DGTabla, Sql)
    End Sub

End Class
