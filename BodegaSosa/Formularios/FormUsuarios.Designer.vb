<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormUsuarios
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
        Dim ReportDataSource1 As Microsoft.Reporting.WinForms.ReportDataSource = New Microsoft.Reporting.WinForms.ReportDataSource()
        Me.ReportViewer1 = New Microsoft.Reporting.WinForms.ReportViewer()
        Me.DataUsuarios = New AplicacionVB.DataUsuarios()
        Me.SPGetListarUsuariosBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.SP_Get_Listar_UsuariosTableAdapter = New AplicacionVB.DataUsuariosTableAdapters.SP_Get_Listar_UsuariosTableAdapter()
        CType(Me.DataUsuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.SPGetListarUsuariosBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ReportViewer1
        '
        Me.ReportViewer1.Dock = System.Windows.Forms.DockStyle.Fill
        ReportDataSource1.Name = "TableUsuarios"
        ReportDataSource1.Value = Me.SPGetListarUsuariosBindingSource
        Me.ReportViewer1.LocalReport.DataSources.Add(ReportDataSource1)
        Me.ReportViewer1.LocalReport.ReportEmbeddedResource = "AplicacionVB.ReportUsuarios.rdlc"
        Me.ReportViewer1.Location = New System.Drawing.Point(0, 0)
        Me.ReportViewer1.Name = "ReportViewer1"
        Me.ReportViewer1.ServerReport.BearerToken = Nothing
        Me.ReportViewer1.Size = New System.Drawing.Size(800, 450)
        Me.ReportViewer1.TabIndex = 0
        '
        'DataUsuarios
        '
        Me.DataUsuarios.DataSetName = "DataUsuarios"
        Me.DataUsuarios.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'SPGetListarUsuariosBindingSource
        '
        Me.SPGetListarUsuariosBindingSource.DataMember = "SP_Get_Listar_Usuarios"
        Me.SPGetListarUsuariosBindingSource.DataSource = Me.DataUsuarios
        '
        'SP_Get_Listar_UsuariosTableAdapter
        '
        Me.SP_Get_Listar_UsuariosTableAdapter.ClearBeforeFill = True
        '
        'FormUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ReportViewer1)
        Me.Name = "FormUsuarios"
        Me.Text = "FormUsuarios"
        CType(Me.DataUsuarios, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.SPGetListarUsuariosBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ReportViewer1 As Microsoft.Reporting.WinForms.ReportViewer
    Friend WithEvents DataUsuarios As DataUsuarios
    Friend WithEvents SPGetListarUsuariosBindingSource As BindingSource
    Friend WithEvents SP_Get_Listar_UsuariosTableAdapter As DataUsuariosTableAdapters.SP_Get_Listar_UsuariosTableAdapter
End Class
