<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Reportes
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.DGReportes = New System.Windows.Forms.DataGridView()
        CType(Me.DGReportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGReportes
        '
        Me.DGReportes.AllowUserToAddRows = False
        Me.DGReportes.AllowUserToDeleteRows = False
        Me.DGReportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGReportes.Location = New System.Drawing.Point(12, 131)
        Me.DGReportes.Name = "DGReportes"
        Me.DGReportes.ReadOnly = True
        Me.DGReportes.Size = New System.Drawing.Size(837, 250)
        Me.DGReportes.TabIndex = 0
        '
        'Reportes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(861, 612)
        Me.Controls.Add(Me.DGReportes)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Reportes"
        Me.Text = "Reportes"
        CType(Me.DGReportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DGReportes As DataGridView
End Class