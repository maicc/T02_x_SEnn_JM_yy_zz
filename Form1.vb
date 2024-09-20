Public Class FrmPrincipal

    Private Sub FrmPrincipal_Load(ByValsender As Object)



    End Sub


    Private Sub BtnVacunas_Click(sender As Object, e As EventArgs) Handles BtnVacunas.Click

    End Sub

    Private Sub BtnInventario_Click(sender As Object, e As EventArgs) Handles BtnInventario.Click
        Dim inventario As New FrmInventario()
        FrmInventario.Show()

        Me.Hide()
    End Sub

    Private Sub Btnsalir_Click(sender As Object, e As EventArgs) Handles Btnsalir.Click
        End
    End Sub
End Class
