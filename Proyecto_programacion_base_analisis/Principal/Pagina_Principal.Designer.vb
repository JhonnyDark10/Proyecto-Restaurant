<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pagina_Principal
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Pagina_Principal))
        Me.Menu_principal = New System.Windows.Forms.MenuStrip()
        Me.REGISTROS = New System.Windows.Forms.ToolStripMenuItem()
        Me.Empleados = New System.Windows.Forms.ToolStripMenuItem()
        Me.Clientes = New System.Windows.Forms.ToolStripMenuItem()
        Me.Proveedores = New System.Windows.Forms.ToolStripMenuItem()
        Me.Platos = New System.Windows.Forms.ToolStripMenuItem()
        Me.PEDIDOS = New System.Windows.Forms.ToolStripMenuItem()
        Me.IngresoPedidosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.FACTURACIONES = New System.Windows.Forms.ToolStripMenuItem()
        Me.DetallesToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MANTENIMIENTO = New System.Windows.Forms.ToolStripMenuItem()
        Me.Editar = New System.Windows.Forms.ToolStripMenuItem()
        Me.Clientes_E = New System.Windows.Forms.ToolStripMenuItem()
        Me.Empleados_E = New System.Windows.Forms.ToolStripMenuItem()
        Me.Proveedores_E = New System.Windows.Forms.ToolStripMenuItem()
        Me.Platos_E = New System.Windows.Forms.ToolStripMenuItem()
        Me.CuentaU_E = New System.Windows.Forms.ToolStripMenuItem()
        Me.Membresias_E = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriaT = New System.Windows.Forms.ToolStripMenuItem()
        Me.CategoriasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoEmpleadoToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoPlatosToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoTarjetasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoTiempoMembresiaToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoPedidoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MesasToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.TipoPagoToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.REPORTES = New System.Windows.Forms.ToolStripMenuItem()
        Me.ClientesToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.EmpleadosToolStripMenuItem1 = New System.Windows.Forms.ToolStripMenuItem()
        Me.SALIR = New System.Windows.Forms.ToolStripMenuItem()
        Me.Label_ingreso_principal = New System.Windows.Forms.Label()
        Me.txt_princpal_acceso_ususario = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_cerrar_secion = New System.Windows.Forms.Button()
        Me.MonthCalendar1 = New System.Windows.Forms.MonthCalendar()
        Me.Menu_principal.SuspendLayout()
        Me.SuspendLayout()
        '
        'Menu_principal
        '
        Me.Menu_principal.AutoSize = False
        Me.Menu_principal.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Menu_principal.BackgroundImage = CType(resources.GetObject("Menu_principal.BackgroundImage"), System.Drawing.Image)
        Me.Menu_principal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.Menu_principal.Dock = System.Windows.Forms.DockStyle.None
        Me.Menu_principal.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Menu_principal.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.REGISTROS, Me.PEDIDOS, Me.FACTURACIONES, Me.MANTENIMIENTO, Me.REPORTES, Me.SALIR})
        Me.Menu_principal.Location = New System.Drawing.Point(-1, 101)
        Me.Menu_principal.Name = "Menu_principal"
        Me.Menu_principal.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional
        Me.Menu_principal.Size = New System.Drawing.Size(922, 43)
        Me.Menu_principal.TabIndex = 0
        Me.Menu_principal.Text = "MenuStrip1"
        '
        'REGISTROS
        '
        Me.REGISTROS.BackColor = System.Drawing.Color.Transparent
        Me.REGISTROS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Empleados, Me.Clientes, Me.Proveedores, Me.Platos})
        Me.REGISTROS.ForeColor = System.Drawing.Color.Black
        Me.REGISTROS.Image = CType(resources.GetObject("REGISTROS.Image"), System.Drawing.Image)
        Me.REGISTROS.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.REGISTROS.Name = "REGISTROS"
        Me.REGISTROS.Size = New System.Drawing.Size(151, 39)
        Me.REGISTROS.Text = "REGISTROS"
        '
        'Empleados
        '
        Me.Empleados.BackColor = System.Drawing.Color.Transparent
        Me.Empleados.ForeColor = System.Drawing.Color.Black
        Me.Empleados.Name = "Empleados"
        Me.Empleados.Size = New System.Drawing.Size(182, 26)
        Me.Empleados.Text = "Empleados"
        '
        'Clientes
        '
        Me.Clientes.BackColor = System.Drawing.Color.Transparent
        Me.Clientes.ForeColor = System.Drawing.Color.Black
        Me.Clientes.Name = "Clientes"
        Me.Clientes.Size = New System.Drawing.Size(182, 26)
        Me.Clientes.Text = "Clientes"
        '
        'Proveedores
        '
        Me.Proveedores.ForeColor = System.Drawing.Color.Black
        Me.Proveedores.Name = "Proveedores"
        Me.Proveedores.Size = New System.Drawing.Size(182, 26)
        Me.Proveedores.Text = "Proveedores"
        '
        'Platos
        '
        Me.Platos.ForeColor = System.Drawing.Color.Black
        Me.Platos.Name = "Platos"
        Me.Platos.Size = New System.Drawing.Size(182, 26)
        Me.Platos.Text = "Platos"
        '
        'PEDIDOS
        '
        Me.PEDIDOS.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.IngresoPedidosToolStripMenuItem})
        Me.PEDIDOS.ForeColor = System.Drawing.Color.Black
        Me.PEDIDOS.Image = CType(resources.GetObject("PEDIDOS.Image"), System.Drawing.Image)
        Me.PEDIDOS.Name = "PEDIDOS"
        Me.PEDIDOS.Size = New System.Drawing.Size(124, 39)
        Me.PEDIDOS.Text = "PEDIDOS"
        '
        'IngresoPedidosToolStripMenuItem
        '
        Me.IngresoPedidosToolStripMenuItem.Name = "IngresoPedidosToolStripMenuItem"
        Me.IngresoPedidosToolStripMenuItem.Size = New System.Drawing.Size(199, 26)
        Me.IngresoPedidosToolStripMenuItem.Text = "Ingreso Orden"
        '
        'FACTURACIONES
        '
        Me.FACTURACIONES.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DetallesToolStripMenuItem})
        Me.FACTURACIONES.ForeColor = System.Drawing.Color.Black
        Me.FACTURACIONES.Image = CType(resources.GetObject("FACTURACIONES.Image"), System.Drawing.Image)
        Me.FACTURACIONES.Name = "FACTURACIONES"
        Me.FACTURACIONES.Size = New System.Drawing.Size(140, 39)
        Me.FACTURACIONES.Text = "FACTURAS"
        '
        'DetallesToolStripMenuItem
        '
        Me.DetallesToolStripMenuItem.Name = "DetallesToolStripMenuItem"
        Me.DetallesToolStripMenuItem.Size = New System.Drawing.Size(212, 26)
        Me.DetallesToolStripMenuItem.Text = "Cancelar Orden"
        '
        'MANTENIMIENTO
        '
        Me.MANTENIMIENTO.BackColor = System.Drawing.Color.Transparent
        Me.MANTENIMIENTO.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Editar, Me.CategoriaT})
        Me.MANTENIMIENTO.ForeColor = System.Drawing.Color.Black
        Me.MANTENIMIENTO.Image = CType(resources.GetObject("MANTENIMIENTO.Image"), System.Drawing.Image)
        Me.MANTENIMIENTO.Name = "MANTENIMIENTO"
        Me.MANTENIMIENTO.Size = New System.Drawing.Size(210, 39)
        Me.MANTENIMIENTO.Text = "MANTENIMIENTO"
        Me.MANTENIMIENTO.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        '
        'Editar
        '
        Me.Editar.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.Clientes_E, Me.Empleados_E, Me.Proveedores_E, Me.Platos_E, Me.CuentaU_E, Me.Membresias_E})
        Me.Editar.Name = "Editar"
        Me.Editar.Size = New System.Drawing.Size(170, 26)
        Me.Editar.Text = "Editar"
        '
        'Clientes_E
        '
        Me.Clientes_E.Name = "Clientes_E"
        Me.Clientes_E.Size = New System.Drawing.Size(208, 26)
        Me.Clientes_E.Text = "Clientes"
        '
        'Empleados_E
        '
        Me.Empleados_E.Name = "Empleados_E"
        Me.Empleados_E.Size = New System.Drawing.Size(208, 26)
        Me.Empleados_E.Text = "Empleados"
        '
        'Proveedores_E
        '
        Me.Proveedores_E.Name = "Proveedores_E"
        Me.Proveedores_E.Size = New System.Drawing.Size(208, 26)
        Me.Proveedores_E.Text = "Proveedores"
        '
        'Platos_E
        '
        Me.Platos_E.Name = "Platos_E"
        Me.Platos_E.Size = New System.Drawing.Size(208, 26)
        Me.Platos_E.Text = "Platos"
        '
        'CuentaU_E
        '
        Me.CuentaU_E.Name = "CuentaU_E"
        Me.CuentaU_E.Size = New System.Drawing.Size(208, 26)
        Me.CuentaU_E.Text = "Cuenta Usuario"
        '
        'Membresias_E
        '
        Me.Membresias_E.Name = "Membresias_E"
        Me.Membresias_E.Size = New System.Drawing.Size(208, 26)
        Me.Membresias_E.Text = "Membresias"
        '
        'CategoriaT
        '
        Me.CategoriaT.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CategoriasToolStripMenuItem, Me.TipoEmpleadoToolStripMenuItem1, Me.TipoPlatosToolStripMenuItem, Me.TipoTarjetasToolStripMenuItem, Me.TipoTiempoMembresiaToolStripMenuItem, Me.TipoPedidoToolStripMenuItem, Me.MesasToolStripMenuItem, Me.TipoPagoToolStripMenuItem})
        Me.CategoriaT.Name = "CategoriaT"
        Me.CategoriaT.Size = New System.Drawing.Size(170, 26)
        Me.CategoriaT.Text = "Categorias"
        '
        'CategoriasToolStripMenuItem
        '
        Me.CategoriasToolStripMenuItem.Name = "CategoriasToolStripMenuItem"
        Me.CategoriasToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.CategoriasToolStripMenuItem.Text = "Tipo Cliente"
        '
        'TipoEmpleadoToolStripMenuItem1
        '
        Me.TipoEmpleadoToolStripMenuItem1.Name = "TipoEmpleadoToolStripMenuItem1"
        Me.TipoEmpleadoToolStripMenuItem1.Size = New System.Drawing.Size(282, 26)
        Me.TipoEmpleadoToolStripMenuItem1.Text = "Tipo Empleado"
        '
        'TipoPlatosToolStripMenuItem
        '
        Me.TipoPlatosToolStripMenuItem.Name = "TipoPlatosToolStripMenuItem"
        Me.TipoPlatosToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.TipoPlatosToolStripMenuItem.Text = "Tipo Platos"
        '
        'TipoTarjetasToolStripMenuItem
        '
        Me.TipoTarjetasToolStripMenuItem.Name = "TipoTarjetasToolStripMenuItem"
        Me.TipoTarjetasToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.TipoTarjetasToolStripMenuItem.Text = "Tipo Tarjetas"
        '
        'TipoTiempoMembresiaToolStripMenuItem
        '
        Me.TipoTiempoMembresiaToolStripMenuItem.Name = "TipoTiempoMembresiaToolStripMenuItem"
        Me.TipoTiempoMembresiaToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.TipoTiempoMembresiaToolStripMenuItem.Text = "Tipo Tiempo Membresia"
        '
        'TipoPedidoToolStripMenuItem
        '
        Me.TipoPedidoToolStripMenuItem.Name = "TipoPedidoToolStripMenuItem"
        Me.TipoPedidoToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.TipoPedidoToolStripMenuItem.Text = "Tipo Pedido"
        '
        'MesasToolStripMenuItem
        '
        Me.MesasToolStripMenuItem.Name = "MesasToolStripMenuItem"
        Me.MesasToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.MesasToolStripMenuItem.Text = "Mesas"
        '
        'TipoPagoToolStripMenuItem
        '
        Me.TipoPagoToolStripMenuItem.Name = "TipoPagoToolStripMenuItem"
        Me.TipoPagoToolStripMenuItem.Size = New System.Drawing.Size(282, 26)
        Me.TipoPagoToolStripMenuItem.Text = "Tipo Pago"
        '
        'REPORTES
        '
        Me.REPORTES.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ClientesToolStripMenuItem1, Me.EmpleadosToolStripMenuItem1})
        Me.REPORTES.ForeColor = System.Drawing.Color.Black
        Me.REPORTES.Image = CType(resources.GetObject("REPORTES.Image"), System.Drawing.Image)
        Me.REPORTES.Name = "REPORTES"
        Me.REPORTES.Size = New System.Drawing.Size(142, 39)
        Me.REPORTES.Text = "REPORTES"
        '
        'ClientesToolStripMenuItem1
        '
        Me.ClientesToolStripMenuItem1.Name = "ClientesToolStripMenuItem1"
        Me.ClientesToolStripMenuItem1.Size = New System.Drawing.Size(170, 26)
        Me.ClientesToolStripMenuItem1.Text = "Clientes"
        '
        'EmpleadosToolStripMenuItem1
        '
        Me.EmpleadosToolStripMenuItem1.Name = "EmpleadosToolStripMenuItem1"
        Me.EmpleadosToolStripMenuItem1.Size = New System.Drawing.Size(170, 26)
        Me.EmpleadosToolStripMenuItem1.Text = "Empleados"
        '
        'SALIR
        '
        Me.SALIR.ForeColor = System.Drawing.Color.Black
        Me.SALIR.Image = CType(resources.GetObject("SALIR.Image"), System.Drawing.Image)
        Me.SALIR.Name = "SALIR"
        Me.SALIR.Size = New System.Drawing.Size(95, 39)
        Me.SALIR.Text = "SALIR"
        '
        'Label_ingreso_principal
        '
        Me.Label_ingreso_principal.AutoSize = True
        Me.Label_ingreso_principal.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label_ingreso_principal.ForeColor = System.Drawing.Color.Red
        Me.Label_ingreso_principal.Location = New System.Drawing.Point(449, 647)
        Me.Label_ingreso_principal.Name = "Label_ingreso_principal"
        Me.Label_ingreso_principal.Size = New System.Drawing.Size(0, 19)
        Me.Label_ingreso_principal.TabIndex = 5
        '
        'txt_princpal_acceso_ususario
        '
        Me.txt_princpal_acceso_ususario.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.txt_princpal_acceso_ususario.CausesValidation = False
        Me.txt_princpal_acceso_ususario.Enabled = False
        Me.txt_princpal_acceso_ususario.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_princpal_acceso_ususario.ForeColor = System.Drawing.Color.Red
        Me.txt_princpal_acceso_ususario.Location = New System.Drawing.Point(391, 649)
        Me.txt_princpal_acceso_ususario.Multiline = True
        Me.txt_princpal_acceso_ususario.Name = "txt_princpal_acceso_ususario"
        Me.txt_princpal_acceso_ususario.Size = New System.Drawing.Size(135, 19)
        Me.txt_princpal_acceso_ususario.TabIndex = 8
        Me.txt_princpal_acceso_ususario.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(289, 648)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(101, 19)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "     USUARIO"
        '
        'btn_cerrar_secion
        '
        Me.btn_cerrar_secion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cerrar_secion.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cerrar_secion.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cerrar_secion.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.btn_cerrar_secion.Location = New System.Drawing.Point(520, 647)
        Me.btn_cerrar_secion.Name = "btn_cerrar_secion"
        Me.btn_cerrar_secion.Size = New System.Drawing.Size(118, 24)
        Me.btn_cerrar_secion.TabIndex = 13
        Me.btn_cerrar_secion.Text = "Cerrar Secion"
        Me.btn_cerrar_secion.UseVisualStyleBackColor = True
        '
        'MonthCalendar1
        '
        Me.MonthCalendar1.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.MonthCalendar1.Location = New System.Drawing.Point(748, 260)
        Me.MonthCalendar1.Name = "MonthCalendar1"
        Me.MonthCalendar1.TabIndex = 37
        '
        'Pagina_Principal
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.ClientSize = New System.Drawing.Size(922, 670)
        Me.ControlBox = False
        Me.Controls.Add(Me.MonthCalendar1)
        Me.Controls.Add(Me.btn_cerrar_secion)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.txt_princpal_acceso_ususario)
        Me.Controls.Add(Me.Label_ingreso_principal)
        Me.Controls.Add(Me.Menu_principal)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.Menu_principal
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Pagina_Principal"
        Me.Opacity = 0.85R
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Menu_principal.ResumeLayout(False)
        Me.Menu_principal.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Menu_principal As System.Windows.Forms.MenuStrip
    Friend WithEvents REGISTROS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Clientes As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Proveedores As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents PEDIDOS As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents IngresoPedidosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents FACTURACIONES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MANTENIMIENTO As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Editar As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents DetallesToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriaT As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents REPORTES As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents ClientesToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents EmpleadosToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Empleados As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Platos As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Clientes_E As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Empleados_E As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Proveedores_E As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CategoriasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents SALIR As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Platos_E As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoEmpleadoToolStripMenuItem1 As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoPlatosToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoTarjetasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Label_ingreso_principal As System.Windows.Forms.Label
    Friend WithEvents txt_princpal_acceso_ususario As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_cerrar_secion As System.Windows.Forms.Button
    Friend WithEvents MonthCalendar1 As System.Windows.Forms.MonthCalendar
    Friend WithEvents TipoTiempoMembresiaToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoPedidoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents MesasToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents TipoPagoToolStripMenuItem As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents CuentaU_E As System.Windows.Forms.ToolStripMenuItem
    Friend WithEvents Membresias_E As System.Windows.Forms.ToolStripMenuItem

End Class
