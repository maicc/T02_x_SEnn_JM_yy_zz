<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmInventario
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        BtnVolver = New Button()
        lblVacunas = New Label()
        lblVacunasTot = New Label()
        lblAgregar = New Label()
        txtAgregar = New TextBox()
        BtnAgregar = New Button()
        SuspendLayout()
        ' 
        ' BtnVolver
        ' 
        BtnVolver.Location = New Point(538, 381)
        BtnVolver.Name = "BtnVolver"
        BtnVolver.Size = New Size(114, 47)
        BtnVolver.TabIndex = 5
        BtnVolver.Text = "Volver al menú"
        BtnVolver.UseVisualStyleBackColor = True
        ' 
        ' lblVacunas
        ' 
        lblVacunas.AutoSize = True
        lblVacunas.Font = New Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblVacunas.Location = New Point(28, 89)
        lblVacunas.Name = "lblVacunas"
        lblVacunas.Size = New Size(168, 30)
        lblVacunas.TabIndex = 6
        lblVacunas.Text = "Vacunas totales: "
        ' 
        ' lblVacunasTot
        ' 
        lblVacunasTot.AutoSize = True
        lblVacunasTot.Font = New Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblVacunasTot.Location = New Point(202, 93)
        lblVacunasTot.Name = "lblVacunasTot"
        lblVacunasTot.Size = New Size(22, 25)
        lblVacunasTot.TabIndex = 8
        lblVacunasTot.Text = "0"
        ' 
        ' lblAgregar
        ' 
        lblAgregar.AutoSize = True
        lblAgregar.Font = New Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, CByte(0))
        lblAgregar.Location = New Point(28, 204)
        lblAgregar.Name = "lblAgregar"
        lblAgregar.Size = New Size(126, 21)
        lblAgregar.TabIndex = 9
        lblAgregar.Text = "Agregar vacunas"
        ' 
        ' txtAgregar
        ' 
        txtAgregar.Location = New Point(160, 206)
        txtAgregar.Name = "txtAgregar"
        txtAgregar.Size = New Size(100, 23)
        txtAgregar.TabIndex = 10
        ' 
        ' BtnAgregar
        ' 
        BtnAgregar.Location = New Point(275, 206)
        BtnAgregar.Name = "BtnAgregar"
        BtnAgregar.Size = New Size(75, 23)
        BtnAgregar.TabIndex = 11
        BtnAgregar.Text = "Agregar"
        BtnAgregar.UseVisualStyleBackColor = True
        ' 
        ' FrmInventario
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(679, 450)
        Controls.Add(BtnAgregar)
        Controls.Add(txtAgregar)
        Controls.Add(lblAgregar)
        Controls.Add(lblVacunasTot)
        Controls.Add(lblVacunas)
        Controls.Add(BtnVolver)
        Name = "FrmInventario"
        Text = "Inventario"
        ResumeLayout(False)
        PerformLayout()
    End Sub
    Friend WithEvents BtnVolver As Button
    Friend WithEvents lblVacunas As Label
    Friend WithEvents lblVacunasTot As Label
    Friend WithEvents lblAgregar As Label
    Friend WithEvents txtAgregar As TextBox
    Friend WithEvents BtnAgregar As Button
End Class
