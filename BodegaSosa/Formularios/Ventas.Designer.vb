<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Ventas
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
        Me.DGVenta = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txtTotal = New System.Windows.Forms.TextBox()
        Me.txtImp = New System.Windows.Forms.TextBox()
        Me.txtTipoComp = New System.Windows.Forms.ComboBox()
        Me.txtNumComp = New System.Windows.Forms.TextBox()
        Me.btnNuevo = New System.Windows.Forms.Button()
        Me.btnRegistrar = New System.Windows.Forms.Button()
        Me.BtnModificar = New System.Windows.Forms.Button()
        Me.btnEliminar = New System.Windows.Forms.Button()
        Me.lblCodigo = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txtCliente = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txtSerieComp = New System.Windows.Forms.TextBox()
        Me.DateTimePicker1 = New System.Windows.Forms.DateTimePicker()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txtBuscar = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        CType(Me.DGVenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGVenta
        '
        Me.DGVenta.AllowUserToAddRows = False
        Me.DGVenta.AllowUserToDeleteRows = False
        Me.DGVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVenta.Location = New System.Drawing.Point(12, 321)
        Me.DGVenta.Name = "DGVenta"
        Me.DGVenta.ReadOnly = True
        Me.DGVenta.Size = New System.Drawing.Size(889, 279)
        Me.DGVenta.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(89, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(40, 13)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Código"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(89, 163)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(61, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Tipo_Comp"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(374, 82)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(62, 13)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Num_Comp"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(384, 122)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(37, 13)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Fecha"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(384, 157)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(50, 13)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "Impuesto"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(384, 193)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(31, 13)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Total"
        '
        'txtTotal
        '
        Me.txtTotal.Location = New System.Drawing.Point(475, 187)
        Me.txtTotal.Name = "txtTotal"
        Me.txtTotal.Size = New System.Drawing.Size(100, 20)
        Me.txtTotal.TabIndex = 12
        '
        'txtImp
        '
        Me.txtImp.Location = New System.Drawing.Point(475, 151)
        Me.txtImp.Name = "txtImp"
        Me.txtImp.Size = New System.Drawing.Size(100, 20)
        Me.txtImp.TabIndex = 11
        '
        'txtTipoComp
        '
        Me.txtTipoComp.FormattingEnabled = True
        Me.txtTipoComp.Items.AddRange(New Object() {"Boleta", "Factura"})
        Me.txtTipoComp.Location = New System.Drawing.Point(190, 163)
        Me.txtTipoComp.Name = "txtTipoComp"
        Me.txtTipoComp.Size = New System.Drawing.Size(100, 21)
        Me.txtTipoComp.TabIndex = 13
        '
        'txtNumComp
        '
        Me.txtNumComp.Location = New System.Drawing.Point(475, 82)
        Me.txtNumComp.Name = "txtNumComp"
        Me.txtNumComp.Size = New System.Drawing.Size(100, 20)
        Me.txtNumComp.TabIndex = 14
        '
        'btnNuevo
        '
        Me.btnNuevo.Location = New System.Drawing.Point(741, 71)
        Me.btnNuevo.Name = "btnNuevo"
        Me.btnNuevo.Size = New System.Drawing.Size(75, 23)
        Me.btnNuevo.TabIndex = 16
        Me.btnNuevo.Text = "Nuevo"
        Me.btnNuevo.UseVisualStyleBackColor = True
        '
        'btnRegistrar
        '
        Me.btnRegistrar.Location = New System.Drawing.Point(741, 106)
        Me.btnRegistrar.Name = "btnRegistrar"
        Me.btnRegistrar.Size = New System.Drawing.Size(75, 23)
        Me.btnRegistrar.TabIndex = 17
        Me.btnRegistrar.Text = "Registro"
        Me.btnRegistrar.UseVisualStyleBackColor = True
        '
        'BtnModificar
        '
        Me.BtnModificar.Location = New System.Drawing.Point(741, 139)
        Me.BtnModificar.Name = "BtnModificar"
        Me.BtnModificar.Size = New System.Drawing.Size(75, 23)
        Me.BtnModificar.TabIndex = 18
        Me.BtnModificar.Text = "Modificar"
        Me.BtnModificar.UseVisualStyleBackColor = True
        '
        'btnEliminar
        '
        Me.btnEliminar.Location = New System.Drawing.Point(741, 175)
        Me.btnEliminar.Name = "btnEliminar"
        Me.btnEliminar.Size = New System.Drawing.Size(75, 23)
        Me.btnEliminar.TabIndex = 19
        Me.btnEliminar.Text = "Eliminar"
        Me.btnEliminar.UseVisualStyleBackColor = True
        '
        'lblCodigo
        '
        Me.lblCodigo.AutoSize = True
        Me.lblCodigo.Location = New System.Drawing.Point(187, 82)
        Me.lblCodigo.Name = "lblCodigo"
        Me.lblCodigo.Size = New System.Drawing.Size(31, 13)
        Me.lblCodigo.TabIndex = 21
        Me.lblCodigo.Text = "0000"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(89, 121)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 13)
        Me.Label7.TabIndex = 22
        Me.Label7.Text = "Persona"
        '
        'txtCliente
        '
        Me.txtCliente.Location = New System.Drawing.Point(190, 116)
        Me.txtCliente.Name = "txtCliente"
        Me.txtCliente.Size = New System.Drawing.Size(100, 20)
        Me.txtCliente.TabIndex = 24
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(89, 211)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(64, 13)
        Me.Label9.TabIndex = 28
        Me.Label9.Text = "Serie_Comp"
        '
        'txtSerieComp
        '
        Me.txtSerieComp.Location = New System.Drawing.Point(190, 211)
        Me.txtSerieComp.Name = "txtSerieComp"
        Me.txtSerieComp.Size = New System.Drawing.Size(100, 20)
        Me.txtSerieComp.TabIndex = 29
        '
        'DateTimePicker1
        '
        Me.DateTimePicker1.Location = New System.Drawing.Point(475, 115)
        Me.DateTimePicker1.Name = "DateTimePicker1"
        Me.DateTimePicker1.Size = New System.Drawing.Size(200, 20)
        Me.DateTimePicker1.TabIndex = 30
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(227, 278)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(40, 13)
        Me.Label8.TabIndex = 31
        Me.Label8.Text = "Buscar"
        '
        'txtBuscar
        '
        Me.txtBuscar.Location = New System.Drawing.Point(292, 275)
        Me.txtBuscar.Name = "txtBuscar"
        Me.txtBuscar.Size = New System.Drawing.Size(283, 20)
        Me.txtBuscar.TabIndex = 32
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(600, 272)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 33
        Me.Button1.Text = "Buscar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Ventas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(916, 612)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.txtBuscar)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.DateTimePicker1)
        Me.Controls.Add(Me.txtSerieComp)
        Me.Controls.Add(Me.Label9)
        Me.Controls.Add(Me.txtCliente)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.lblCodigo)
        Me.Controls.Add(Me.btnEliminar)
        Me.Controls.Add(Me.BtnModificar)
        Me.Controls.Add(Me.btnRegistrar)
        Me.Controls.Add(Me.btnNuevo)
        Me.Controls.Add(Me.txtNumComp)
        Me.Controls.Add(Me.txtTipoComp)
        Me.Controls.Add(Me.txtTotal)
        Me.Controls.Add(Me.txtImp)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.DGVenta)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Ventas"
        Me.Text = "Ventas"
        CType(Me.DGVenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGVenta As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents txtTotal As TextBox
    Friend WithEvents txtImp As TextBox
    Friend WithEvents txtTipoComp As ComboBox
    Friend WithEvents txtNumComp As TextBox
    Friend WithEvents btnNuevo As Button
    Friend WithEvents btnRegistrar As Button
    Friend WithEvents BtnModificar As Button
    Friend WithEvents btnEliminar As Button
    Friend WithEvents lblCodigo As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents txtCliente As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents txtSerieComp As TextBox
    Friend WithEvents DateTimePicker1 As DateTimePicker
    Friend WithEvents Label8 As Label
    Friend WithEvents txtBuscar As TextBox
    Friend WithEvents Button1 As Button
End Class