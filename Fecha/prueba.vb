Public Class prueba

    Private Sub prueba_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Label1.Text = "¿Esta seguro que desea salir?"
        Button1.Text = "Si"
        Button2.Text = "No"
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close() 'cierra este formulario
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        'cierra ambos formularios
        Me.Close()
        Form1.Close()
    End Sub
End Class