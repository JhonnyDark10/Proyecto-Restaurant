<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Orden_Pedido
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Orden_Pedido))
        Me.btn_cancelar_pedido_o = New System.Windows.Forms.Button()
        Me.gbo_datos_cliente = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.txt_codigo_tipo_mes = New System.Windows.Forms.TextBox()
        Me.txt_hora_pedido_o = New System.Windows.Forms.DateTimePicker()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_tipo_orden_o = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_numero_mesa_o = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_tiempo_pedido_o = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.dg_orden_d = New System.Windows.Forms.DataGridView()
        Me.Cantidad = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Producto = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Precio_u = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Total_p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.p = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.codigo_producto_v = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_entrada_o = New System.Windows.Forms.Button()
        Me.btn_segundo_o = New System.Windows.Forms.Button()
        Me.btn_bebidas_o = New System.Windows.Forms.Button()
        Me.btn_postres_o = New System.Windows.Forms.Button()
        Me.btn_primero_o = New System.Windows.Forms.Button()
        Me.dg_bebidas_orden = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_numero_pedido_o = New System.Windows.Forms.TextBox()
        Me.btn_añadir_producto_o = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.btn_detalle_pedido_o = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox4 = New System.Windows.Forms.GroupBox()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.btn_habilita_botones = New System.Windows.Forms.Button()
        Me.txt_fecha_pedido_o = New System.Windows.Forms.DateTimePicker()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.GroupBox5 = New System.Windows.Forms.GroupBox()
        Me.btn_limpiar_orden = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.txt_subtotal_pedido_o = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.GroupBox6 = New System.Windows.Forms.GroupBox()
        Me.OpcionOrden = New System.Windows.Forms.GroupBox()
        Me.btn_buscar_producto = New System.Windows.Forms.Button()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_cantp = New System.Windows.Forms.TextBox()
        Me.txt_Descripción = New System.Windows.Forms.TextBox()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.txt_precio = New System.Windows.Forms.TextBox()
        Me.txt_usuario_empleado = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbo_datos_cliente.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        CType(Me.dg_orden_d, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_bebidas_orden, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox4.SuspendLayout()
        Me.GroupBox5.SuspendLayout()
        Me.GroupBox6.SuspendLayout()
        Me.OpcionOrden.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_cancelar_pedido_o
        '
        Me.btn_cancelar_pedido_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cancelar_pedido_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_cancelar_pedido_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar_pedido_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_pedido_o.Image = CType(resources.GetObject("btn_cancelar_pedido_o.Image"), System.Drawing.Image)
        Me.btn_cancelar_pedido_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar_pedido_o.Location = New System.Drawing.Point(295, 19)
        Me.btn_cancelar_pedido_o.Name = "btn_cancelar_pedido_o"
        Me.btn_cancelar_pedido_o.Size = New System.Drawing.Size(108, 50)
        Me.btn_cancelar_pedido_o.TabIndex = 47
        Me.btn_cancelar_pedido_o.Text = "      Cancela " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "     Pedido"
        Me.btn_cancelar_pedido_o.UseVisualStyleBackColor = True
        '
        'gbo_datos_cliente
        '
        Me.gbo_datos_cliente.Controls.Add(Me.GroupBox3)
        Me.gbo_datos_cliente.Controls.Add(Me.dg_orden_d)
        Me.gbo_datos_cliente.Location = New System.Drawing.Point(12, 100)
        Me.gbo_datos_cliente.Name = "gbo_datos_cliente"
        Me.gbo_datos_cliente.Size = New System.Drawing.Size(459, 449)
        Me.gbo_datos_cliente.TabIndex = 49
        Me.gbo_datos_cliente.TabStop = False
        Me.gbo_datos_cliente.Text = "Lista Orden"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_codigo_tipo_mes)
        Me.GroupBox3.Controls.Add(Me.txt_hora_pedido_o)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.txt_tipo_orden_o)
        Me.GroupBox3.Controls.Add(Me.Label4)
        Me.GroupBox3.Controls.Add(Me.txt_numero_mesa_o)
        Me.GroupBox3.Controls.Add(Me.Label8)
        Me.GroupBox3.Controls.Add(Me.Label1)
        Me.GroupBox3.Controls.Add(Me.txt_tiempo_pedido_o)
        Me.GroupBox3.Controls.Add(Me.Label5)
        Me.GroupBox3.Controls.Add(Me.Label7)
        Me.GroupBox3.Location = New System.Drawing.Point(11, 15)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(442, 112)
        Me.GroupBox3.TabIndex = 67
        Me.GroupBox3.TabStop = False
        '
        'txt_codigo_tipo_mes
        '
        Me.txt_codigo_tipo_mes.Location = New System.Drawing.Point(169, 82)
        Me.txt_codigo_tipo_mes.Name = "txt_codigo_tipo_mes"
        Me.txt_codigo_tipo_mes.ReadOnly = True
        Me.txt_codigo_tipo_mes.Size = New System.Drawing.Size(36, 20)
        Me.txt_codigo_tipo_mes.TabIndex = 74
        '
        'txt_hora_pedido_o
        '
        Me.txt_hora_pedido_o.CustomFormat = ""
        Me.txt_hora_pedido_o.Format = System.Windows.Forms.DateTimePickerFormat.Time
        Me.txt_hora_pedido_o.Location = New System.Drawing.Point(169, 12)
        Me.txt_hora_pedido_o.Name = "txt_hora_pedido_o"
        Me.txt_hora_pedido_o.Size = New System.Drawing.Size(67, 20)
        Me.txt_hora_pedido_o.TabIndex = 74
        Me.txt_hora_pedido_o.Value = New Date(2016, 9, 12, 22, 39, 29, 0)
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(242, 10)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 69
        Me.Label10.Text = "*"
        '
        'txt_tipo_orden_o
        '
        Me.txt_tipo_orden_o.Location = New System.Drawing.Point(209, 82)
        Me.txt_tipo_orden_o.Name = "txt_tipo_orden_o"
        Me.txt_tipo_orden_o.ReadOnly = True
        Me.txt_tipo_orden_o.Size = New System.Drawing.Size(106, 20)
        Me.txt_tipo_orden_o.TabIndex = 36
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(31, 55)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 33
        Me.Label4.Text = "Numero Mesa"
        '
        'txt_numero_mesa_o
        '
        Me.txt_numero_mesa_o.Location = New System.Drawing.Point(169, 56)
        Me.txt_numero_mesa_o.Name = "txt_numero_mesa_o"
        Me.txt_numero_mesa_o.ReadOnly = True
        Me.txt_numero_mesa_o.Size = New System.Drawing.Size(36, 20)
        Me.txt_numero_mesa_o.TabIndex = 34
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(242, 31)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 66
        Me.Label8.Text = "*"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(31, 81)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(85, 19)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Tipo Orden"
        '
        'txt_tiempo_pedido_o
        '
        Me.txt_tiempo_pedido_o.Location = New System.Drawing.Point(169, 33)
        Me.txt_tiempo_pedido_o.Name = "txt_tiempo_pedido_o"
        Me.txt_tiempo_pedido_o.Size = New System.Drawing.Size(67, 20)
        Me.txt_tiempo_pedido_o.TabIndex = 64
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(31, 10)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(111, 19)
        Me.Label5.TabIndex = 59
        Me.Label5.Text = "Hora de pedido"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(31, 31)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(136, 19)
        Me.Label7.TabIndex = 63
        Me.Label7.Text = "Tiempo de Entrega"
        '
        'dg_orden_d
        '
        Me.dg_orden_d.AllowUserToAddRows = False
        Me.dg_orden_d.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_orden_d.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_orden_d.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Cantidad, Me.Producto, Me.Precio_u, Me.Total_p, Me.p, Me.codigo_producto_v})
        Me.dg_orden_d.EnableHeadersVisualStyles = False
        Me.dg_orden_d.Location = New System.Drawing.Point(11, 133)
        Me.dg_orden_d.Name = "dg_orden_d"
        Me.dg_orden_d.Size = New System.Drawing.Size(442, 310)
        Me.dg_orden_d.TabIndex = 57
        '
        'Cantidad
        '
        Me.Cantidad.HeaderText = "Cantidad"
        Me.Cantidad.Name = "Cantidad"
        '
        'Producto
        '
        Me.Producto.HeaderText = "Producto"
        Me.Producto.Name = "Producto"
        '
        'Precio_u
        '
        Me.Precio_u.HeaderText = "Precio_u"
        Me.Precio_u.Name = "Precio_u"
        '
        'Total_p
        '
        Me.Total_p.HeaderText = "Total_p"
        Me.Total_p.Name = "Total_p"
        '
        'p
        '
        Me.p.HeaderText = "p"
        Me.p.Name = "p"
        Me.p.Visible = False
        '
        'codigo_producto_v
        '
        Me.codigo_producto_v.HeaderText = "codigo_producto_v"
        Me.codigo_producto_v.Name = "codigo_producto_v"
        Me.codigo_producto_v.Visible = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.GroupBox2)
        Me.GroupBox1.Controls.Add(Me.dg_bebidas_orden)
        Me.GroupBox1.Location = New System.Drawing.Point(697, 33)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(250, 411)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Escoger Tipo"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_entrada_o)
        Me.GroupBox2.Controls.Add(Me.btn_segundo_o)
        Me.GroupBox2.Controls.Add(Me.btn_bebidas_o)
        Me.GroupBox2.Controls.Add(Me.btn_postres_o)
        Me.GroupBox2.Controls.Add(Me.btn_primero_o)
        Me.GroupBox2.Location = New System.Drawing.Point(13, 21)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(225, 111)
        Me.GroupBox2.TabIndex = 58
        Me.GroupBox2.TabStop = False
        '
        'btn_entrada_o
        '
        Me.btn_entrada_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_entrada_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_entrada_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_entrada_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_entrada_o.ForeColor = System.Drawing.Color.Blue
        Me.btn_entrada_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_entrada_o.Location = New System.Drawing.Point(62, 78)
        Me.btn_entrada_o.Name = "btn_entrada_o"
        Me.btn_entrada_o.Size = New System.Drawing.Size(99, 27)
        Me.btn_entrada_o.TabIndex = 58
        Me.btn_entrada_o.Text = "ENTRADA"
        Me.ToolTip1.SetToolTip(Me.btn_entrada_o, "Escoger Segundo Plato")
        Me.btn_entrada_o.UseVisualStyleBackColor = True
        '
        'btn_segundo_o
        '
        Me.btn_segundo_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_segundo_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_segundo_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_segundo_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_segundo_o.ForeColor = System.Drawing.Color.Blue
        Me.btn_segundo_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_segundo_o.Location = New System.Drawing.Point(120, 46)
        Me.btn_segundo_o.Name = "btn_segundo_o"
        Me.btn_segundo_o.Size = New System.Drawing.Size(99, 27)
        Me.btn_segundo_o.TabIndex = 57
        Me.btn_segundo_o.Text = "SEGUNDO"
        Me.ToolTip1.SetToolTip(Me.btn_segundo_o, "Escoger Segundo Plato")
        Me.btn_segundo_o.UseVisualStyleBackColor = True
        '
        'btn_bebidas_o
        '
        Me.btn_bebidas_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_bebidas_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_bebidas_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_bebidas_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_bebidas_o.ForeColor = System.Drawing.Color.Blue
        Me.btn_bebidas_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_bebidas_o.Location = New System.Drawing.Point(6, 15)
        Me.btn_bebidas_o.Name = "btn_bebidas_o"
        Me.btn_bebidas_o.Size = New System.Drawing.Size(108, 26)
        Me.btn_bebidas_o.TabIndex = 57
        Me.btn_bebidas_o.Text = "BEBIDAS"
        Me.ToolTip1.SetToolTip(Me.btn_bebidas_o, "Escoger Tipo De Bebidas")
        Me.btn_bebidas_o.UseVisualStyleBackColor = True
        '
        'btn_postres_o
        '
        Me.btn_postres_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_postres_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_postres_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_postres_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_postres_o.ForeColor = System.Drawing.Color.Blue
        Me.btn_postres_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_postres_o.Location = New System.Drawing.Point(120, 15)
        Me.btn_postres_o.Name = "btn_postres_o"
        Me.btn_postres_o.Size = New System.Drawing.Size(99, 26)
        Me.btn_postres_o.TabIndex = 57
        Me.btn_postres_o.Text = "POSTRES"
        Me.ToolTip1.SetToolTip(Me.btn_postres_o, "Escoger Postres")
        Me.btn_postres_o.UseVisualStyleBackColor = True
        '
        'btn_primero_o
        '
        Me.btn_primero_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_primero_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_primero_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_primero_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_primero_o.ForeColor = System.Drawing.Color.Blue
        Me.btn_primero_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_primero_o.Location = New System.Drawing.Point(6, 47)
        Me.btn_primero_o.Name = "btn_primero_o"
        Me.btn_primero_o.Size = New System.Drawing.Size(108, 26)
        Me.btn_primero_o.TabIndex = 57
        Me.btn_primero_o.Text = "PRIMERO"
        Me.ToolTip1.SetToolTip(Me.btn_primero_o, "Escoger Primer Plato")
        Me.btn_primero_o.UseVisualStyleBackColor = True
        '
        'dg_bebidas_orden
        '
        Me.dg_bebidas_orden.AllowUserToAddRows = False
        Me.dg_bebidas_orden.AllowUserToDeleteRows = False
        Me.dg_bebidas_orden.AllowUserToResizeColumns = False
        Me.dg_bebidas_orden.AllowUserToResizeRows = False
        Me.dg_bebidas_orden.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.dg_bebidas_orden.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_bebidas_orden.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_bebidas_orden.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_bebidas_orden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_bebidas_orden.Location = New System.Drawing.Point(13, 138)
        Me.dg_bebidas_orden.Name = "dg_bebidas_orden"
        Me.dg_bebidas_orden.ShowCellErrors = False
        Me.dg_bebidas_orden.ShowEditingIcon = False
        Me.dg_bebidas_orden.ShowRowErrors = False
        Me.dg_bebidas_orden.Size = New System.Drawing.Size(225, 260)
        Me.dg_bebidas_orden.TabIndex = 56
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(12, 12)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(131, 19)
        Me.Label2.TabIndex = 54
        Me.Label2.Text = "Numero de pedido"
        '
        'txt_numero_pedido_o
        '
        Me.txt_numero_pedido_o.Location = New System.Drawing.Point(149, 13)
        Me.txt_numero_pedido_o.Name = "txt_numero_pedido_o"
        Me.txt_numero_pedido_o.Size = New System.Drawing.Size(67, 20)
        Me.txt_numero_pedido_o.TabIndex = 55
        '
        'btn_añadir_producto_o
        '
        Me.btn_añadir_producto_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_añadir_producto_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir_producto_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_añadir_producto_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_producto_o.Image = CType(resources.GetObject("btn_añadir_producto_o.Image"), System.Drawing.Image)
        Me.btn_añadir_producto_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_añadir_producto_o.Location = New System.Drawing.Point(26, 24)
        Me.btn_añadir_producto_o.Name = "btn_añadir_producto_o"
        Me.btn_añadir_producto_o.Size = New System.Drawing.Size(128, 36)
        Me.btn_añadir_producto_o.TabIndex = 58
        Me.btn_añadir_producto_o.Text = "       AÑADIR"
        Me.ToolTip1.SetToolTip(Me.btn_añadir_producto_o, "Añade Producto a Consumir")
        Me.btn_añadir_producto_o.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(12, 35)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(117, 19)
        Me.Label6.TabIndex = 63
        Me.Label6.Text = "Fecha de pedido"
        '
        'btn_detalle_pedido_o
        '
        Me.btn_detalle_pedido_o.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_detalle_pedido_o.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_detalle_pedido_o.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_detalle_pedido_o.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_detalle_pedido_o.ForeColor = System.Drawing.Color.Black
        Me.btn_detalle_pedido_o.Image = CType(resources.GetObject("btn_detalle_pedido_o.Image"), System.Drawing.Image)
        Me.btn_detalle_pedido_o.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_detalle_pedido_o.Location = New System.Drawing.Point(48, 19)
        Me.btn_detalle_pedido_o.Name = "btn_detalle_pedido_o"
        Me.btn_detalle_pedido_o.Size = New System.Drawing.Size(114, 50)
        Me.btn_detalle_pedido_o.TabIndex = 65
        Me.btn_detalle_pedido_o.Text = "       Acepta         Pedido"
        Me.ToolTip1.SetToolTip(Me.btn_detalle_pedido_o, "Guardar Pedido")
        Me.btn_detalle_pedido_o.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(366, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(225, 31)
        Me.Label3.TabIndex = 66
        Me.Label3.Text = "      ORDEN PEDIDO"
        '
        'GroupBox4
        '
        Me.GroupBox4.Controls.Add(Me.Label11)
        Me.GroupBox4.Controls.Add(Me.btn_habilita_botones)
        Me.GroupBox4.Controls.Add(Me.txt_fecha_pedido_o)
        Me.GroupBox4.Controls.Add(Me.Label9)
        Me.GroupBox4.Controls.Add(Me.Label2)
        Me.GroupBox4.Controls.Add(Me.txt_numero_pedido_o)
        Me.GroupBox4.Controls.Add(Me.Label6)
        Me.GroupBox4.Location = New System.Drawing.Point(12, 33)
        Me.GroupBox4.Name = "GroupBox4"
        Me.GroupBox4.Size = New System.Drawing.Size(302, 61)
        Me.GroupBox4.TabIndex = 67
        Me.GroupBox4.TabStop = False
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(248, 14)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 74
        Me.Label11.Text = "*"
        '
        'btn_habilita_botones
        '
        Me.btn_habilita_botones.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_habilita_botones.Image = CType(resources.GetObject("btn_habilita_botones.Image"), System.Drawing.Image)
        Me.btn_habilita_botones.Location = New System.Drawing.Point(222, 13)
        Me.btn_habilita_botones.Name = "btn_habilita_botones"
        Me.btn_habilita_botones.Size = New System.Drawing.Size(20, 20)
        Me.btn_habilita_botones.TabIndex = 74
        Me.ToolTip1.SetToolTip(Me.btn_habilita_botones, "Debe Asignar Numero De Pedido ")
        Me.btn_habilita_botones.UseVisualStyleBackColor = True
        '
        'txt_fecha_pedido_o
        '
        Me.txt_fecha_pedido_o.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_pedido_o.Location = New System.Drawing.Point(149, 35)
        Me.txt_fecha_pedido_o.Name = "txt_fecha_pedido_o"
        Me.txt_fecha_pedido_o.Size = New System.Drawing.Size(93, 20)
        Me.txt_fecha_pedido_o.TabIndex = 74
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(248, 34)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 71
        Me.Label9.Text = "*"
        '
        'GroupBox5
        '
        Me.GroupBox5.Controls.Add(Me.btn_limpiar_orden)
        Me.GroupBox5.Controls.Add(Me.btn_cancelar_pedido_o)
        Me.GroupBox5.Controls.Add(Me.btn_detalle_pedido_o)
        Me.GroupBox5.Location = New System.Drawing.Point(477, 514)
        Me.GroupBox5.Name = "GroupBox5"
        Me.GroupBox5.Size = New System.Drawing.Size(420, 78)
        Me.GroupBox5.TabIndex = 68
        Me.GroupBox5.TabStop = False
        Me.GroupBox5.Text = "Botones"
        '
        'btn_limpiar_orden
        '
        Me.btn_limpiar_orden.BackColor = System.Drawing.Color.White
        Me.btn_limpiar_orden.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_limpiar_orden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_limpiar_orden.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_limpiar_orden.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_limpiar_orden.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_limpiar_orden.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_limpiar_orden.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_limpiar_orden.ForeColor = System.Drawing.Color.Black
        Me.btn_limpiar_orden.Image = CType(resources.GetObject("btn_limpiar_orden.Image"), System.Drawing.Image)
        Me.btn_limpiar_orden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_limpiar_orden.Location = New System.Drawing.Point(168, 20)
        Me.btn_limpiar_orden.Name = "btn_limpiar_orden"
        Me.btn_limpiar_orden.Size = New System.Drawing.Size(121, 49)
        Me.btn_limpiar_orden.TabIndex = 84
        Me.btn_limpiar_orden.Text = "      LIMPIAR"
        Me.btn_limpiar_orden.UseVisualStyleBackColor = False
        '
        'btn_eliminar
        '
        Me.btn_eliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(27, 72)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(127, 36)
        Me.btn_eliminar.TabIndex = 73
        Me.btn_eliminar.Text = "      ELIMINAR"
        Me.ToolTip1.SetToolTip(Me.btn_eliminar, "Añade Producto a Consumir")
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'txt_subtotal_pedido_o
        '
        Me.txt_subtotal_pedido_o.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal_pedido_o.Location = New System.Drawing.Point(372, 563)
        Me.txt_subtotal_pedido_o.Name = "txt_subtotal_pedido_o"
        Me.txt_subtotal_pedido_o.ReadOnly = True
        Me.txt_subtotal_pedido_o.Size = New System.Drawing.Size(93, 29)
        Me.txt_subtotal_pedido_o.TabIndex = 70
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(265, 573)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(92, 19)
        Me.Label12.TabIndex = 69
        Me.Label12.Text = "SUBTOTAL"
        '
        'GroupBox6
        '
        Me.GroupBox6.Controls.Add(Me.OpcionOrden)
        Me.GroupBox6.Controls.Add(Me.btn_buscar_producto)
        Me.GroupBox6.Controls.Add(Me.Label13)
        Me.GroupBox6.Controls.Add(Me.txt_codigo)
        Me.GroupBox6.Controls.Add(Me.Label20)
        Me.GroupBox6.Controls.Add(Me.Label19)
        Me.GroupBox6.Controls.Add(Me.txt_cantp)
        Me.GroupBox6.Controls.Add(Me.txt_Descripción)
        Me.GroupBox6.Controls.Add(Me.Label15)
        Me.GroupBox6.Controls.Add(Me.txt_precio)
        Me.GroupBox6.Location = New System.Drawing.Point(477, 100)
        Me.GroupBox6.Name = "GroupBox6"
        Me.GroupBox6.Size = New System.Drawing.Size(214, 344)
        Me.GroupBox6.TabIndex = 71
        Me.GroupBox6.TabStop = False
        Me.GroupBox6.Text = "Productos"
        '
        'OpcionOrden
        '
        Me.OpcionOrden.Controls.Add(Me.btn_eliminar)
        Me.OpcionOrden.Controls.Add(Me.btn_añadir_producto_o)
        Me.OpcionOrden.Location = New System.Drawing.Point(24, 181)
        Me.OpcionOrden.Name = "OpcionOrden"
        Me.OpcionOrden.Size = New System.Drawing.Size(174, 118)
        Me.OpcionOrden.TabIndex = 74
        Me.OpcionOrden.TabStop = False
        Me.OpcionOrden.Text = "Opcion Orden"
        '
        'btn_buscar_producto
        '
        Me.btn_buscar_producto.Image = CType(resources.GetObject("btn_buscar_producto.Image"), System.Drawing.Image)
        Me.btn_buscar_producto.Location = New System.Drawing.Point(168, 19)
        Me.btn_buscar_producto.Name = "btn_buscar_producto"
        Me.btn_buscar_producto.Size = New System.Drawing.Size(40, 30)
        Me.btn_buscar_producto.TabIndex = 72
        Me.btn_buscar_producto.UseVisualStyleBackColor = True
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(11, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(47, 15)
        Me.Label13.TabIndex = 60
        Me.Label13.Text = "Codigo "
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(108, 27)
        Me.txt_codigo.MaxLength = 10
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(54, 20)
        Me.txt_codigo.TabIndex = 59
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.Location = New System.Drawing.Point(36, 112)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(55, 15)
        Me.Label20.TabIndex = 30
        Me.Label20.Text = "Cantidad"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.Location = New System.Drawing.Point(11, 58)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(73, 15)
        Me.Label19.TabIndex = 30
        Me.Label19.Text = "Descripción:"
        '
        'txt_cantp
        '
        Me.txt_cantp.Location = New System.Drawing.Point(108, 109)
        Me.txt_cantp.MaxLength = 5
        Me.txt_cantp.Name = "txt_cantp"
        Me.txt_cantp.Size = New System.Drawing.Size(54, 20)
        Me.txt_cantp.TabIndex = 10
        '
        'txt_Descripción
        '
        Me.txt_Descripción.Location = New System.Drawing.Point(108, 53)
        Me.txt_Descripción.Name = "txt_Descripción"
        Me.txt_Descripción.ReadOnly = True
        Me.txt_Descripción.Size = New System.Drawing.Size(100, 20)
        Me.txt_Descripción.TabIndex = 29
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(59, 84)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(40, 15)
        Me.Label15.TabIndex = 28
        Me.Label15.Text = "Precio"
        '
        'txt_precio
        '
        Me.txt_precio.Location = New System.Drawing.Point(108, 81)
        Me.txt_precio.Name = "txt_precio"
        Me.txt_precio.ReadOnly = True
        Me.txt_precio.Size = New System.Drawing.Size(54, 20)
        Me.txt_precio.TabIndex = 27
        '
        'txt_usuario_empleado
        '
        Me.txt_usuario_empleado.Location = New System.Drawing.Point(892, 9)
        Me.txt_usuario_empleado.Name = "txt_usuario_empleado"
        Me.txt_usuario_empleado.Size = New System.Drawing.Size(55, 20)
        Me.txt_usuario_empleado.TabIndex = 72
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(805, 10)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(81, 19)
        Me.Label14.TabIndex = 73
        Me.Label14.Text = "USUARIO"
        '
        'Orden_Pedido
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(959, 651)
        Me.Controls.Add(Me.Label14)
        Me.Controls.Add(Me.txt_usuario_empleado)
        Me.Controls.Add(Me.GroupBox6)
        Me.Controls.Add(Me.txt_subtotal_pedido_o)
        Me.Controls.Add(Me.Label12)
        Me.Controls.Add(Me.GroupBox5)
        Me.Controls.Add(Me.GroupBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_datos_cliente)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Orden_Pedido"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbo_datos_cliente.ResumeLayout(False)
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        CType(Me.dg_orden_d, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg_bebidas_orden, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox4.ResumeLayout(False)
        Me.GroupBox4.PerformLayout()
        Me.GroupBox5.ResumeLayout(False)
        Me.GroupBox6.ResumeLayout(False)
        Me.GroupBox6.PerformLayout()
        Me.OpcionOrden.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_cancelar_pedido_o As System.Windows.Forms.Button
    Friend WithEvents gbo_datos_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo_orden_o As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_mesa_o As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_segundo_o As System.Windows.Forms.Button
    Friend WithEvents btn_primero_o As System.Windows.Forms.Button
    Friend WithEvents btn_postres_o As System.Windows.Forms.Button
    Friend WithEvents btn_bebidas_o As System.Windows.Forms.Button
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_pedido_o As System.Windows.Forms.TextBox
    Friend WithEvents dg_bebidas_orden As System.Windows.Forms.DataGridView
    Friend WithEvents dg_orden_d As System.Windows.Forms.DataGridView
    Friend WithEvents btn_añadir_producto_o As System.Windows.Forms.Button
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_detalle_pedido_o As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox4 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox5 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents txt_subtotal_pedido_o As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox6 As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_cantp As System.Windows.Forms.TextBox
    Friend WithEvents txt_Descripción As System.Windows.Forms.TextBox
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents txt_precio As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents btn_buscar_producto As System.Windows.Forms.Button
    Friend WithEvents OpcionOrden As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents btn_limpiar_orden As System.Windows.Forms.Button
    Friend WithEvents txt_usuario_empleado As System.Windows.Forms.TextBox
    Friend WithEvents Cantidad As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Producto As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Precio_u As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Total_p As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents p As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents codigo_producto_v As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents txt_hora_pedido_o As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_tiempo_pedido_o As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_pedido_o As System.Windows.Forms.DateTimePicker
    Friend WithEvents btn_habilita_botones As System.Windows.Forms.Button
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents btn_entrada_o As System.Windows.Forms.Button
    Friend WithEvents txt_codigo_tipo_mes As System.Windows.Forms.TextBox
End Class
