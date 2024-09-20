<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class FrmPrincipal
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        BtnVacunas = New Button()
        BtnHistorial = New Button()
        BtnInventario = New Button()
        Btnsalir = New Button()
        SuspendLayout()
        ' 
        ' BtnVacunas
        ' 
        BtnVacunas.Location = New Point(63, 199)
        BtnVacunas.Name = "BtnVacunas"
        BtnVacunas.Size = New Size(113, 45)
        BtnVacunas.TabIndex = 0
        BtnVacunas.Text = "Solicitud de vacunas"
        BtnVacunas.UseVisualStyleBackColor = True
        ' 
        ' BtnHistorial
        ' 
        BtnHistorial.Location = New Point(62, 125)
        BtnHistorial.Name = "BtnHistorial"
        BtnHistorial.Size = New Size(114, 45)
        BtnHistorial.TabIndex = 1
        BtnHistorial.Text = "Historial"
        BtnHistorial.UseVisualStyleBackColor = True
        ' 
        ' BtnInventario
        ' 
        BtnInventario.Location = New Point(63, 276)
        BtnInventario.Name = "BtnInventario"
        BtnInventario.Size = New Size(114, 45)
        BtnInventario.TabIndex = 2
        BtnInventario.Text = "Inventario"
        BtnInventario.UseVisualStyleBackColor = True
        ' 
        ' Btnsalir
        ' 
        Btnsalir.Location = New Point(521, 359)
        Btnsalir.Name = "Btnsalir"
        Btnsalir.Size = New Size(114, 47)
        Btnsalir.TabIndex = 3
        Btnsalir.Text = "Salir"
        Btnsalir.UseVisualStyleBackColor = True
        ' 
        ' FrmPrincipal
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(668, 438)
        Controls.Add(Btnsalir)
        Controls.Add(BtnInventario)
        Controls.Add(BtnHistorial)
        Controls.Add(BtnVacunas)
        Name = "FrmPrincipal"
        Text = "Principal"
        ResumeLayout(False)
    End Sub

    Friend WithEvents BtnVacunas As Button
    Friend WithEvents BtnHistorial As Button
    Friend WithEvents BtnInventario As Button
    Friend WithEvents Btnsalir As Button

End Class
