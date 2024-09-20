Imports System.Windows.Forms.VisualStyles.VisualStyleElement

Public Class FrmInventario

    Private Sub BtnVolver_Click(sender As Object, e As EventArgs) Handles BtnVolver.Click
        Dim principal As New FrmPrincipal

        FrmPrincipal.Show()

        Me.Hide()
    End Sub
    Private Sub Btnsalir_Click(sender As Object, e As EventArgs)
        End
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles lblVacunas.Click, lblVacunas.Click

    End Sub



    Private Sub lblVacunasTot_Click(sender As Object, e As EventArgs) Handles lblVacunasTot.Click


    End Sub

    Private Sub lblVacunasTot_TextChanged(sender As Object, e As EventArgs) Handles lblVacunasTot.TextChanged


    End Sub

    Private Sub txtAgregar_TextChanged(sender As Object, e As EventArgs) Handles txtAgregar.TextChanged


    End Sub

    Private Sub BtnAgregar_Click(sender As Object, e As EventArgs) Handles BtnAgregar.Click

        'Cuando hagas las peticiones vas a tener que transformarlas de String a int para luego volver a tranformarla a String
        Dim contenido As String 'Este es la variable a la que hay que agregar las vacunas desde los otros controles
        Dim vacunasExistentes As Integer 'Este es de las vacunas que ya hay almacenada
        Dim vacunasNuevas As Integer 'Este es el que va a almacenar las vacunas que vienen del variable contenido (que es string) y con la que realizaremos el calculo



        contenido = txtAgregar.Text

        'Validar que el campo no este vacio
        If String.IsNullOrEmpty(txtAgregar.Text) Then
            MessageBox.Show("Este campo no puede estar vacío.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAgregar.Focus()
            Exit Sub
        End If

        'Validar que el campo sea numerico
        If IsNumeric(contenido) Then
            Dim number As Integer = CInt(contenido)
        Else
            MessageBox.Show("El valor ingresado no es un número válido.", "Error de validación", MessageBoxButtons.OK, MessageBoxIcon.Error)
            txtAgregar.Focus()
            Exit Sub
        End If


        vacunasNuevas = CInt(contenido) 'Cint es para transforma de String a int
        vacunasExistentes = CInt(lblVacunasTot.Text)

        vacunasExistentes = vacunasExistentes + vacunasNuevas 'Contador para almacenar las vacunas
        lblVacunasTot.Text = vacunasExistentes.ToString 'ToString es para devolverlo a String
        txtAgregar.Text = ""
    End Sub
End Class