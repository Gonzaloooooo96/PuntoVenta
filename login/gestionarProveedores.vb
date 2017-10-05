Public Class gestionarProveedores
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        listarProveedores.Show()
    End Sub

    Private Sub gestionarProveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub gestionarProveedores_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        menuPrincipal.Show()
    End Sub
End Class