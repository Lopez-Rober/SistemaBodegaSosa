<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormSetUsuarios
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
        Me.components = New System.ComponentModel.Container()
        Dim ReportDataSource3 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.SPGetBuscarUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.DataSetUsuarios = New AplicacionVB.DataSetUsuarios()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.SP_Get_BuscarUsuariosTableAdapter = New AplicacionVB.DataSetUsuariosTableAdapters.SP_Get_BuscarUsuariosTableAdapter()
        Me.txtParametro = New System.Windows.Forms.TextBox()
        Me.btnParametro = New System.Windows.Forms.Button()
        CType(Me.SPGetBuscarUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataSetUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'SPGetBuscarUsuariosBindingSource
        '
        Me.SPGetBuscarUsuariosBindingSource.DataMember = "SP_Get_BuscarUsuarios"
        Me.SPGetBuscarUsuariosBindingSource.DataSource = Me.DataSetUsuarios
        '
        'DataSetUsuarios
        '
        Me.DataSetUsuarios.DataSetName = "DataSetUsuarios"
        Me.DataSetUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource3.Name = "TableSetUsuarios"
        ReportDataSource3.Value = Me.SPGetBuscarUsuariosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource3)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionVB.ReportSetUsuarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'SP_Get_BuscarUsuariosTableAdapter
        '
        Me.SP_Get_BuscarUsuariosTableAdapter.ClearBeforeFill = True
        '
        'txtParametro
        '
        Me.txtParametro.Location = New System.Drawing.Point(35, 44)
        Me.txtParametro.Name = "txtParametro"
        Me.txtParametro.Size = New System.Drawing.Size(100, 20)
        Me.txtParametro.TabIndex = 1
        '
        'btnParametro
        '
        Me.btnParametro.Location = New System.Drawing.Point(141, 42)
        Me.btnParametro.Name = "btnParametro"
        Me.btnParametro.Size = New System.Drawing.Size(112, 23)
        Me.btnParametro.TabIndex = 2
        Me.btnParametro.Text = "Enviar Parametro"
        Me.btnParametro.UseVisualStyleBackColor = True
        '
        'FormSetUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.btnParametro)
        Me.Controls.Add(Me.txtParametro)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormSetUsuarios"
        Me.Text = "FormSetUsuarios"
        CType(Me.SPGetBuscarUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataSetUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents SPGetBuscarUsuariosBindingSource As BindingSource
    Friend WithEvents DataSetUsuarios As DataSetUsuarios
    Friend WithEvents SP_Get_BuscarUsuariosTableAdapter As DataSetUsuariosTableAdapters.SP_Get_BuscarUsuariosTableAdapter
    Friend WithEvents txtParametro As TextBox
    Friend WithEvents btnParametro As Button
End Class
