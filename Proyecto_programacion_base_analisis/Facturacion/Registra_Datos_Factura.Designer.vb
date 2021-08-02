<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Registra_Datos_Factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Registra_Datos_Factura))
        Me.gbo_tipo_pago_f = New System.Windows.Forms.GroupBox()
        Me.cbo_tipopago = New System.Windows.Forms.ComboBox()
        Me.Label26 = New System.Windows.Forms.Label()
        Me.cbo_lista_nombre_tarjetas_f = New System.Windows.Forms.ComboBox()
        Me.txt_nombre_tc_f = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_numero_tc_f = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_categoria_mesa_f = New System.Windows.Forms.ComboBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_cedula_busca_f = New System.Windows.Forms.TextBox()
        Me.btn_nuevo_cliente_f = New System.Windows.Forms.Button()
        Me.btn_cedula_buscar_f = New System.Windows.Forms.Button()
        Me.btn_facturar_registro = New System.Windows.Forms.Button()
        Me.btn_registro_volver_f = New System.Windows.Forms.Button()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_nuevo_plato = New System.Windows.Forms.Button()
        Me.btn_ver_detalle_orden_f = New System.Windows.Forms.Button()
        Me.gbo_numero_mesa_f = New System.Windows.Forms.GroupBox()
        Me.gbo_cliente_f = New System.Windows.Forms.GroupBox()
        Me.txt_tipo_cliente_fact = New System.Windows.Forms.TextBox()
        Me.lbl_apellido_c_f = New System.Windows.Forms.Label()
        Me.lbl_nombre_c_f = New System.Windows.Forms.Label()
        Me.lbl_cedula_c_f = New System.Windows.Forms.Label()
        Me.lbl_telefono_c_f = New System.Windows.Forms.Label()
        Me.lbl_direccion_c_f = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.dg_ver_ordenes = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.txt_total_p_f = New System.Windows.Forms.TextBox()
        Me.txt_iva_f = New System.Windows.Forms.TextBox()
        Me.txt_recarga_f = New System.Windows.Forms.TextBox()
        Me.txt_descuento_f = New System.Windows.Forms.TextBox()
        Me.txt_subtotal_f = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.lbl_email_f = New System.Windows.Forms.Label()
        Me.lbl_direccion_f = New System.Windows.Forms.Label()
        Me.lbl_empresa_f = New System.Windows.Forms.Label()
        Me.lbl_telefono_f = New System.Windows.Forms.Label()
        Me.lbl_fecha_f = New System.Windows.Forms.Label()
        Me.lbl_ruc_f = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label25 = New System.Windows.Forms.Label()
        Me.gbo_tipo_pago_f.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbo_numero_mesa_f.SuspendLayout()
        Me.gbo_cliente_f.SuspendLayout()
        CType(Me.dg_ver_ordenes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbo_tipo_pago_f
        '
        Me.gbo_tipo_pago_f.Controls.Add(Me.cbo_tipopago)
        Me.gbo_tipo_pago_f.Controls.Add(Me.Label26)
        Me.gbo_tipo_pago_f.Controls.Add(Me.cbo_lista_nombre_tarjetas_f)
        Me.gbo_tipo_pago_f.Controls.Add(Me.txt_nombre_tc_f)
        Me.gbo_tipo_pago_f.Controls.Add(Me.Label5)
        Me.gbo_tipo_pago_f.Controls.Add(Me.Label6)
        Me.gbo_tipo_pago_f.Controls.Add(Me.Label7)
        Me.gbo_tipo_pago_f.Controls.Add(Me.txt_numero_tc_f)
        Me.gbo_tipo_pago_f.Location = New System.Drawing.Point(532, 186)
        Me.gbo_tipo_pago_f.Name = "gbo_tipo_pago_f"
        Me.gbo_tipo_pago_f.Size = New System.Drawing.Size(368, 170)
        Me.gbo_tipo_pago_f.TabIndex = 62
        Me.gbo_tipo_pago_f.TabStop = False
        Me.gbo_tipo_pago_f.Text = "Tipo De Pago"
        '
        'cbo_tipopago
        '
        Me.cbo_tipopago.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbo_tipopago.DisplayMember = "DESCRIPCION"
        Me.cbo_tipopago.FormattingEnabled = True
        Me.cbo_tipopago.Location = New System.Drawing.Point(177, 28)
        Me.cbo_tipopago.Name = "cbo_tipopago"
        Me.cbo_tipopago.Size = New System.Drawing.Size(160, 21)
        Me.cbo_tipopago.TabIndex = 101
        Me.cbo_tipopago.ValueMember = "ID_TIPO_PAGO"
        '
        'Label26
        '
        Me.Label26.AutoSize = True
        Me.Label26.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label26.ForeColor = System.Drawing.Color.Black
        Me.Label26.Location = New System.Drawing.Point(31, 30)
        Me.Label26.Name = "Label26"
        Me.Label26.Size = New System.Drawing.Size(71, 19)
        Me.Label26.TabIndex = 66
        Me.Label26.Text = "Tipo Pago"
        '
        'cbo_lista_nombre_tarjetas_f
        '
        Me.cbo_lista_nombre_tarjetas_f.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbo_lista_nombre_tarjetas_f.DisplayMember = "DESCRIPCION"
        Me.cbo_lista_nombre_tarjetas_f.FormattingEnabled = True
        Me.cbo_lista_nombre_tarjetas_f.Location = New System.Drawing.Point(177, 66)
        Me.cbo_lista_nombre_tarjetas_f.Name = "cbo_lista_nombre_tarjetas_f"
        Me.cbo_lista_nombre_tarjetas_f.Size = New System.Drawing.Size(160, 21)
        Me.cbo_lista_nombre_tarjetas_f.TabIndex = 65
        Me.cbo_lista_nombre_tarjetas_f.ValueMember = "ESTADO_T_T"
        '
        'txt_nombre_tc_f
        '
        Me.txt_nombre_tc_f.Location = New System.Drawing.Point(177, 100)
        Me.txt_nombre_tc_f.MaxLength = 20
        Me.txt_nombre_tc_f.Name = "txt_nombre_tc_f"
        Me.txt_nombre_tc_f.Size = New System.Drawing.Size(160, 20)
        Me.txt_nombre_tc_f.TabIndex = 63
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(29, 68)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(106, 19)
        Me.Label5.TabIndex = 52
        Me.Label5.Text = "Nombre Tarjeta"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(29, 101)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(104, 19)
        Me.Label6.TabIndex = 53
        Me.Label6.Text = "Nombre Dueño"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(29, 134)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(105, 19)
        Me.Label7.TabIndex = 54
        Me.Label7.Text = "Numero Tarjeta"
        '
        'txt_numero_tc_f
        '
        Me.txt_numero_tc_f.Location = New System.Drawing.Point(177, 133)
        Me.txt_numero_tc_f.MaxLength = 20
        Me.txt_numero_tc_f.Name = "txt_numero_tc_f"
        Me.txt_numero_tc_f.Size = New System.Drawing.Size(160, 20)
        Me.txt_numero_tc_f.TabIndex = 64
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(125, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 19)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "MESA"
        '
        'cbo_categoria_mesa_f
        '
        Me.cbo_categoria_mesa_f.DisplayMember = "DESCRIPCION"
        Me.cbo_categoria_mesa_f.FormattingEnabled = True
        Me.cbo_categoria_mesa_f.Location = New System.Drawing.Point(191, 19)
        Me.cbo_categoria_mesa_f.Name = "cbo_categoria_mesa_f"
        Me.cbo_categoria_mesa_f.Size = New System.Drawing.Size(70, 21)
        Me.cbo_categoria_mesa_f.TabIndex = 65
        Me.cbo_categoria_mesa_f.ValueMember = "ID_MESAS"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(8, 24)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(106, 19)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Cedula Verificar"
        '
        'txt_cedula_busca_f
        '
        Me.txt_cedula_busca_f.Location = New System.Drawing.Point(132, 23)
        Me.txt_cedula_busca_f.MaxLength = 10
        Me.txt_cedula_busca_f.Name = "txt_cedula_busca_f"
        Me.txt_cedula_busca_f.Size = New System.Drawing.Size(155, 20)
        Me.txt_cedula_busca_f.TabIndex = 67
        '
        'btn_nuevo_cliente_f
        '
        Me.btn_nuevo_cliente_f.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_cliente_f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_nuevo_cliente_f.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_cliente_f.ForeColor = System.Drawing.Color.Red
        Me.btn_nuevo_cliente_f.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_cliente_f.Location = New System.Drawing.Point(404, 132)
        Me.btn_nuevo_cliente_f.Name = "btn_nuevo_cliente_f"
        Me.btn_nuevo_cliente_f.Size = New System.Drawing.Size(36, 24)
        Me.btn_nuevo_cliente_f.TabIndex = 69
        Me.btn_nuevo_cliente_f.Text = "......"
        Me.ToolTip1.SetToolTip(Me.btn_nuevo_cliente_f, "Ir A Registrar Clientes")
        Me.btn_nuevo_cliente_f.UseVisualStyleBackColor = False
        '
        'btn_cedula_buscar_f
        '
        Me.btn_cedula_buscar_f.BackColor = System.Drawing.Color.White
        Me.btn_cedula_buscar_f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cedula_buscar_f.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cedula_buscar_f.ForeColor = System.Drawing.Color.Black
        Me.btn_cedula_buscar_f.Image = CType(resources.GetObject("btn_cedula_buscar_f.Image"), System.Drawing.Image)
        Me.btn_cedula_buscar_f.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cedula_buscar_f.Location = New System.Drawing.Point(293, 16)
        Me.btn_cedula_buscar_f.Name = "btn_cedula_buscar_f"
        Me.btn_cedula_buscar_f.Size = New System.Drawing.Size(36, 31)
        Me.btn_cedula_buscar_f.TabIndex = 71
        Me.btn_cedula_buscar_f.Text = "      "
        Me.ToolTip1.SetToolTip(Me.btn_cedula_buscar_f, "Buscar Cliente Registrados")
        Me.btn_cedula_buscar_f.UseVisualStyleBackColor = False
        '
        'btn_facturar_registro
        '
        Me.btn_facturar_registro.BackColor = System.Drawing.Color.White
        Me.btn_facturar_registro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_facturar_registro.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_facturar_registro.ForeColor = System.Drawing.Color.Black
        Me.btn_facturar_registro.Image = CType(resources.GetObject("btn_facturar_registro.Image"), System.Drawing.Image)
        Me.btn_facturar_registro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_facturar_registro.Location = New System.Drawing.Point(148, 17)
        Me.btn_facturar_registro.Name = "btn_facturar_registro"
        Me.btn_facturar_registro.Size = New System.Drawing.Size(140, 49)
        Me.btn_facturar_registro.TabIndex = 72
        Me.btn_facturar_registro.Text = "       FACTURAR"
        Me.ToolTip1.SetToolTip(Me.btn_facturar_registro, "Cancela Factura")
        Me.btn_facturar_registro.UseVisualStyleBackColor = False
        '
        'btn_registro_volver_f
        '
        Me.btn_registro_volver_f.BackColor = System.Drawing.Color.White
        Me.btn_registro_volver_f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_registro_volver_f.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_registro_volver_f.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_registro_volver_f.ForeColor = System.Drawing.Color.Black
        Me.btn_registro_volver_f.Image = CType(resources.GetObject("btn_registro_volver_f.Image"), System.Drawing.Image)
        Me.btn_registro_volver_f.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_registro_volver_f.Location = New System.Drawing.Point(294, 17)
        Me.btn_registro_volver_f.Name = "btn_registro_volver_f"
        Me.btn_registro_volver_f.Size = New System.Drawing.Size(121, 49)
        Me.btn_registro_volver_f.TabIndex = 73
        Me.btn_registro_volver_f.Text = "      VOLVER"
        Me.ToolTip1.SetToolTip(Me.btn_registro_volver_f, "Regresar Menu Principal")
        Me.btn_registro_volver_f.UseVisualStyleBackColor = False
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_nuevo_plato)
        Me.GroupBox2.Controls.Add(Me.btn_facturar_registro)
        Me.GroupBox2.Controls.Add(Me.btn_registro_volver_f)
        Me.GroupBox2.Location = New System.Drawing.Point(260, 580)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(425, 72)
        Me.GroupBox2.TabIndex = 74
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones"
        '
        'btn_nuevo_plato
        '
        Me.btn_nuevo_plato.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_plato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_nuevo_plato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_plato.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_nuevo_plato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_nuevo_plato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_nuevo_plato.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_plato.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo_plato.Image = CType(resources.GetObject("btn_nuevo_plato.Image"), System.Drawing.Image)
        Me.btn_nuevo_plato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_plato.Location = New System.Drawing.Point(18, 17)
        Me.btn_nuevo_plato.Name = "btn_nuevo_plato"
        Me.btn_nuevo_plato.Size = New System.Drawing.Size(125, 49)
        Me.btn_nuevo_plato.TabIndex = 83
        Me.btn_nuevo_plato.Text = "    LIMPIAR"
        Me.ToolTip1.SetToolTip(Me.btn_nuevo_plato, "Borra Los Campos")
        Me.btn_nuevo_plato.UseVisualStyleBackColor = False
        '
        'btn_ver_detalle_orden_f
        '
        Me.btn_ver_detalle_orden_f.BackColor = System.Drawing.Color.White
        Me.btn_ver_detalle_orden_f.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_ver_detalle_orden_f.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ver_detalle_orden_f.ForeColor = System.Drawing.Color.Black
        Me.btn_ver_detalle_orden_f.Image = CType(resources.GetObject("btn_ver_detalle_orden_f.Image"), System.Drawing.Image)
        Me.btn_ver_detalle_orden_f.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ver_detalle_orden_f.Location = New System.Drawing.Point(293, 15)
        Me.btn_ver_detalle_orden_f.Name = "btn_ver_detalle_orden_f"
        Me.btn_ver_detalle_orden_f.Size = New System.Drawing.Size(101, 31)
        Me.btn_ver_detalle_orden_f.TabIndex = 75
        Me.btn_ver_detalle_orden_f.Text = " Visualizar"
        Me.ToolTip1.SetToolTip(Me.btn_ver_detalle_orden_f, "Visualiza Lista De Pedidos")
        Me.btn_ver_detalle_orden_f.UseVisualStyleBackColor = False
        '
        'gbo_numero_mesa_f
        '
        Me.gbo_numero_mesa_f.Controls.Add(Me.btn_ver_detalle_orden_f)
        Me.gbo_numero_mesa_f.Controls.Add(Me.Label3)
        Me.gbo_numero_mesa_f.Controls.Add(Me.cbo_categoria_mesa_f)
        Me.gbo_numero_mesa_f.Location = New System.Drawing.Point(20, 362)
        Me.gbo_numero_mesa_f.Name = "gbo_numero_mesa_f"
        Me.gbo_numero_mesa_f.Size = New System.Drawing.Size(495, 56)
        Me.gbo_numero_mesa_f.TabIndex = 81
        Me.gbo_numero_mesa_f.TabStop = False
        Me.gbo_numero_mesa_f.Text = "Numero Orden"
        '
        'gbo_cliente_f
        '
        Me.gbo_cliente_f.Controls.Add(Me.txt_tipo_cliente_fact)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_apellido_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_nombre_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_cedula_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_telefono_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.lbl_direccion_c_f)
        Me.gbo_cliente_f.Controls.Add(Me.Label19)
        Me.gbo_cliente_f.Controls.Add(Me.Label8)
        Me.gbo_cliente_f.Controls.Add(Me.btn_cedula_buscar_f)
        Me.gbo_cliente_f.Controls.Add(Me.Label10)
        Me.gbo_cliente_f.Controls.Add(Me.Label4)
        Me.gbo_cliente_f.Controls.Add(Me.Label11)
        Me.gbo_cliente_f.Controls.Add(Me.txt_cedula_busca_f)
        Me.gbo_cliente_f.Controls.Add(Me.Label12)
        Me.gbo_cliente_f.Controls.Add(Me.btn_nuevo_cliente_f)
        Me.gbo_cliente_f.Controls.Add(Me.Label13)
        Me.gbo_cliente_f.Location = New System.Drawing.Point(20, 188)
        Me.gbo_cliente_f.Name = "gbo_cliente_f"
        Me.gbo_cliente_f.Size = New System.Drawing.Size(495, 168)
        Me.gbo_cliente_f.TabIndex = 82
        Me.gbo_cliente_f.TabStop = False
        Me.gbo_cliente_f.Text = "Informacion Cliente"
        '
        'txt_tipo_cliente_fact
        '
        Me.txt_tipo_cliente_fact.Location = New System.Drawing.Point(335, 23)
        Me.txt_tipo_cliente_fact.Name = "txt_tipo_cliente_fact"
        Me.txt_tipo_cliente_fact.ReadOnly = True
        Me.txt_tipo_cliente_fact.Size = New System.Drawing.Size(100, 20)
        Me.txt_tipo_cliente_fact.TabIndex = 89
        '
        'lbl_apellido_c_f
        '
        Me.lbl_apellido_c_f.AutoSize = True
        Me.lbl_apellido_c_f.Location = New System.Drawing.Point(100, 120)
        Me.lbl_apellido_c_f.Name = "lbl_apellido_c_f"
        Me.lbl_apellido_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_apellido_c_f.TabIndex = 88
        '
        'lbl_nombre_c_f
        '
        Me.lbl_nombre_c_f.AutoSize = True
        Me.lbl_nombre_c_f.Location = New System.Drawing.Point(100, 92)
        Me.lbl_nombre_c_f.Name = "lbl_nombre_c_f"
        Me.lbl_nombre_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_nombre_c_f.TabIndex = 87
        '
        'lbl_cedula_c_f
        '
        Me.lbl_cedula_c_f.AutoSize = True
        Me.lbl_cedula_c_f.Location = New System.Drawing.Point(100, 63)
        Me.lbl_cedula_c_f.Name = "lbl_cedula_c_f"
        Me.lbl_cedula_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_cedula_c_f.TabIndex = 86
        '
        'lbl_telefono_c_f
        '
        Me.lbl_telefono_c_f.AutoSize = True
        Me.lbl_telefono_c_f.Location = New System.Drawing.Point(329, 92)
        Me.lbl_telefono_c_f.Name = "lbl_telefono_c_f"
        Me.lbl_telefono_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_telefono_c_f.TabIndex = 85
        '
        'lbl_direccion_c_f
        '
        Me.lbl_direccion_c_f.AutoSize = True
        Me.lbl_direccion_c_f.Location = New System.Drawing.Point(329, 63)
        Me.lbl_direccion_c_f.Name = "lbl_direccion_c_f"
        Me.lbl_direccion_c_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_direccion_c_f.TabIndex = 84
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(10, 60)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(52, 19)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Cedula"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(334, 133)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 19)
        Me.Label8.TabIndex = 83
        Me.Label8.Text = "Nuevo"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(10, 88)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(60, 19)
        Me.Label10.TabIndex = 66
        Me.Label10.Text = "Nombre"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 116)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(60, 19)
        Me.Label11.TabIndex = 67
        Me.Label11.Text = "Apellido"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(249, 61)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 68
        Me.Label12.Text = "Direccion"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(250, 88)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(61, 19)
        Me.Label13.TabIndex = 69
        Me.Label13.Text = "Telefono"
        '
        'dg_ver_ordenes
        '
        Me.dg_ver_ordenes.AllowUserToAddRows = False
        Me.dg_ver_ordenes.BackgroundColor = System.Drawing.Color.White
        Me.dg_ver_ordenes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_ver_ordenes.GridColor = System.Drawing.Color.Silver
        Me.dg_ver_ordenes.Location = New System.Drawing.Point(69, 424)
        Me.dg_ver_ordenes.Name = "dg_ver_ordenes"
        Me.dg_ver_ordenes.Size = New System.Drawing.Size(345, 150)
        Me.dg_ver_ordenes.TabIndex = 83
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_total_p_f)
        Me.GroupBox1.Controls.Add(Me.txt_iva_f)
        Me.GroupBox1.Controls.Add(Me.txt_recarga_f)
        Me.GroupBox1.Controls.Add(Me.txt_descuento_f)
        Me.GroupBox1.Controls.Add(Me.txt_subtotal_f)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(616, 373)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(284, 201)
        Me.GroupBox1.TabIndex = 97
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desgloce Pago"
        '
        'txt_total_p_f
        '
        Me.txt_total_p_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_total_p_f.Location = New System.Drawing.Point(159, 162)
        Me.txt_total_p_f.Name = "txt_total_p_f"
        Me.txt_total_p_f.ReadOnly = True
        Me.txt_total_p_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_total_p_f.TabIndex = 95
        '
        'txt_iva_f
        '
        Me.txt_iva_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_iva_f.Location = New System.Drawing.Point(159, 125)
        Me.txt_iva_f.Name = "txt_iva_f"
        Me.txt_iva_f.ReadOnly = True
        Me.txt_iva_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_iva_f.TabIndex = 94
        '
        'txt_recarga_f
        '
        Me.txt_recarga_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_recarga_f.Location = New System.Drawing.Point(159, 90)
        Me.txt_recarga_f.Name = "txt_recarga_f"
        Me.txt_recarga_f.ReadOnly = True
        Me.txt_recarga_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_recarga_f.TabIndex = 93
        '
        'txt_descuento_f
        '
        Me.txt_descuento_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_descuento_f.Location = New System.Drawing.Point(159, 55)
        Me.txt_descuento_f.Name = "txt_descuento_f"
        Me.txt_descuento_f.ReadOnly = True
        Me.txt_descuento_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_descuento_f.TabIndex = 92
        '
        'txt_subtotal_f
        '
        Me.txt_subtotal_f.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txt_subtotal_f.Location = New System.Drawing.Point(159, 19)
        Me.txt_subtotal_f.Name = "txt_subtotal_f"
        Me.txt_subtotal_f.ReadOnly = True
        Me.txt_subtotal_f.Size = New System.Drawing.Size(93, 29)
        Me.txt_subtotal_f.TabIndex = 91
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(31, 27)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(59, 19)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Subtotal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(31, 60)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(73, 19)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Descuento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(29, 95)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(84, 19)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "Recargo TC"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(38, 130)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(66, 19)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "IVA 14%"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(13, 167)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(125, 19)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "TOTAL A PAGAR"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-3, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(936, 53)
        Me.Label2.TabIndex = 98
        '
        'GroupBox3
        '
        Me.GroupBox3.BackColor = System.Drawing.Color.White
        Me.GroupBox3.Controls.Add(Me.lbl_email_f)
        Me.GroupBox3.Controls.Add(Me.lbl_direccion_f)
        Me.GroupBox3.Controls.Add(Me.lbl_empresa_f)
        Me.GroupBox3.Controls.Add(Me.lbl_telefono_f)
        Me.GroupBox3.Controls.Add(Me.lbl_fecha_f)
        Me.GroupBox3.Controls.Add(Me.lbl_ruc_f)
        Me.GroupBox3.Controls.Add(Me.Label24)
        Me.GroupBox3.Controls.Add(Me.Label21)
        Me.GroupBox3.Controls.Add(Me.Label22)
        Me.GroupBox3.Controls.Add(Me.Label23)
        Me.GroupBox3.Controls.Add(Me.Label9)
        Me.GroupBox3.Controls.Add(Me.Label20)
        Me.GroupBox3.Location = New System.Drawing.Point(2, 62)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(931, 100)
        Me.GroupBox3.TabIndex = 99
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Empresa"
        '
        'lbl_email_f
        '
        Me.lbl_email_f.AutoSize = True
        Me.lbl_email_f.Location = New System.Drawing.Point(751, 73)
        Me.lbl_email_f.Name = "lbl_email_f"
        Me.lbl_email_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_email_f.TabIndex = 94
        '
        'lbl_direccion_f
        '
        Me.lbl_direccion_f.AutoSize = True
        Me.lbl_direccion_f.Location = New System.Drawing.Point(535, 68)
        Me.lbl_direccion_f.Name = "lbl_direccion_f"
        Me.lbl_direccion_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_direccion_f.TabIndex = 93
        '
        'lbl_empresa_f
        '
        Me.lbl_empresa_f.AutoSize = True
        Me.lbl_empresa_f.Location = New System.Drawing.Point(531, 26)
        Me.lbl_empresa_f.Name = "lbl_empresa_f"
        Me.lbl_empresa_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_empresa_f.TabIndex = 92
        '
        'lbl_telefono_f
        '
        Me.lbl_telefono_f.AutoSize = True
        Me.lbl_telefono_f.Location = New System.Drawing.Point(307, 68)
        Me.lbl_telefono_f.Name = "lbl_telefono_f"
        Me.lbl_telefono_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_telefono_f.TabIndex = 91
        '
        'lbl_fecha_f
        '
        Me.lbl_fecha_f.AutoSize = True
        Me.lbl_fecha_f.Location = New System.Drawing.Point(303, 26)
        Me.lbl_fecha_f.Name = "lbl_fecha_f"
        Me.lbl_fecha_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_fecha_f.TabIndex = 90
        '
        'lbl_ruc_f
        '
        Me.lbl_ruc_f.AutoSize = True
        Me.lbl_ruc_f.Location = New System.Drawing.Point(100, 71)
        Me.lbl_ruc_f.Name = "lbl_ruc_f"
        Me.lbl_ruc_f.Size = New System.Drawing.Size(0, 13)
        Me.lbl_ruc_f.TabIndex = 88
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Blue
        Me.Label24.Location = New System.Drawing.Point(683, 68)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(62, 19)
        Me.Label24.TabIndex = 87
        Me.Label24.Text = "EMAIL"
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Blue
        Me.Label21.Location = New System.Drawing.Point(418, 67)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(101, 19)
        Me.Label21.TabIndex = 81
        Me.Label21.Text = "DIRECCION"
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Blue
        Me.Label22.Location = New System.Drawing.Point(187, 67)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(94, 19)
        Me.Label22.TabIndex = 82
        Me.Label22.Text = "TELEFONO"
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Blue
        Me.Label23.Location = New System.Drawing.Point(14, 62)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(51, 19)
        Me.Label23.TabIndex = 85
        Me.Label23.Text = "R.U.C"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Blue
        Me.Label9.Location = New System.Drawing.Point(209, 26)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(62, 19)
        Me.Label9.TabIndex = 77
        Me.Label9.Text = "FECHA"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(418, 22)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(86, 19)
        Me.Label20.TabIndex = 79
        Me.Label20.Text = "EMPRESA"
        '
        'Label25
        '
        Me.Label25.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label25.Location = New System.Drawing.Point(-1, 663)
        Me.Label25.Name = "Label25"
        Me.Label25.Size = New System.Drawing.Size(936, 44)
        Me.Label25.TabIndex = 100
        '
        'Registra_Datos_Factura
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_registro_volver_f
        Me.ClientSize = New System.Drawing.Size(934, 692)
        Me.Controls.Add(Me.Label25)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dg_ver_ordenes)
        Me.Controls.Add(Me.gbo_cliente_f)
        Me.Controls.Add(Me.gbo_numero_mesa_f)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbo_tipo_pago_f)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Registra_Datos_Factura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbo_tipo_pago_f.ResumeLayout(False)
        Me.gbo_tipo_pago_f.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.gbo_numero_mesa_f.ResumeLayout(False)
        Me.gbo_numero_mesa_f.PerformLayout()
        Me.gbo_cliente_f.ResumeLayout(False)
        Me.gbo_cliente_f.PerformLayout()
        CType(Me.dg_ver_ordenes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents gbo_tipo_pago_f As System.Windows.Forms.GroupBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_categoria_mesa_f As System.Windows.Forms.ComboBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_busca_f As System.Windows.Forms.TextBox
    Friend WithEvents btn_nuevo_cliente_f As System.Windows.Forms.Button
    Friend WithEvents btn_cedula_buscar_f As System.Windows.Forms.Button
    Friend WithEvents btn_facturar_registro As System.Windows.Forms.Button
    Friend WithEvents btn_registro_volver_f As System.Windows.Forms.Button
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_ver_detalle_orden_f As System.Windows.Forms.Button
    Friend WithEvents cbo_lista_nombre_tarjetas_f As System.Windows.Forms.ComboBox
    Friend WithEvents txt_nombre_tc_f As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_numero_tc_f As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents gbo_numero_mesa_f As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_cliente_f As System.Windows.Forms.GroupBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents dg_ver_ordenes As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo_plato As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_total_p_f As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva_f As System.Windows.Forms.TextBox
    Friend WithEvents txt_recarga_f As System.Windows.Forms.TextBox
    Friend WithEvents txt_descuento_f As System.Windows.Forms.TextBox
    Friend WithEvents txt_subtotal_f As System.Windows.Forms.TextBox
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents lbl_ruc_f As System.Windows.Forms.Label
    Friend WithEvents lbl_email_f As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion_f As System.Windows.Forms.Label
    Friend WithEvents lbl_empresa_f As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono_f As System.Windows.Forms.Label
    Friend WithEvents lbl_fecha_f As System.Windows.Forms.Label
    Friend WithEvents lbl_apellido_c_f As System.Windows.Forms.Label
    Friend WithEvents lbl_nombre_c_f As System.Windows.Forms.Label
    Friend WithEvents lbl_cedula_c_f As System.Windows.Forms.Label
    Friend WithEvents lbl_telefono_c_f As System.Windows.Forms.Label
    Friend WithEvents lbl_direccion_c_f As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label25 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipopago As System.Windows.Forms.ComboBox
    Friend WithEvents Label26 As System.Windows.Forms.Label
    Friend WithEvents txt_tipo_cliente_fact As System.Windows.Forms.TextBox
End Class
