<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_Clientes))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.txt_nombre_cliente = New System.Windows.Forms.TextBox()
        Me.txt_apellido1_cliente = New System.Windows.Forms.TextBox()
        Me.txt_apelldio2_cliente = New System.Windows.Forms.TextBox()
        Me.txt_direccion_cliente = New System.Windows.Forms.TextBox()
        Me.txt_email_cliente = New System.Windows.Forms.TextBox()
        Me.txt_telefono_cliente = New System.Windows.Forms.TextBox()
        Me.gbo_datos_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_fecha_cliente = New System.Windows.Forms.DateTimePicker()
        Me.Label22 = New System.Windows.Forms.Label()
        Me.txt_cedula_cliente = New System.Windows.Forms.TextBox()
        Me.Label21 = New System.Windows.Forms.Label()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.gbo_categoria_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_codigo_obtener = New System.Windows.Forms.TextBox()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.gbo_membresia_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_fecha_caducidad = New System.Windows.Forms.TextBox()
        Me.txt_numero_ingreso_c = New System.Windows.Forms.TextBox()
        Me.fecha_apertura_ingreso_c = New System.Windows.Forms.DateTimePicker()
        Me.cbo_dias_año_cliente = New System.Windows.Forms.ComboBox()
        Me.Label27 = New System.Windows.Forms.Label()
        Me.Label24 = New System.Windows.Forms.Label()
        Me.txt_fecha_renovacion_cliente = New System.Windows.Forms.TextBox()
        Me.Label23 = New System.Windows.Forms.Label()
        Me.txt_valor_pago_cliente = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.cbo_categoria_cliente = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.btn_guardar_cliente = New System.Windows.Forms.Button()
        Me.btn_volver_cliente = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_ir_factura = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.btn_nuevo_cliente = New System.Windows.Forms.Button()
        Me.Botones = New System.Windows.Forms.GroupBox()
        Me.gbo_datos_cliente.SuspendLayout()
        Me.gbo_categoria_cliente.SuspendLayout()
        Me.gbo_membresia_cliente.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Botones.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(262, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(280, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "     REGISTRO CLIENTES"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(5, 183)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(6, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(120, 19)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "Apellido Paterno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(6, 96)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(127, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Apellido Materno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(7, 54)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre "
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(6, 222)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(47, 19)
        Me.Label6.TabIndex = 16
        Me.Label6.Text = "Email"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(6, 263)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 17
        Me.Label7.Text = "Telefono"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(6, 302)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(129, 19)
        Me.Label8.TabIndex = 18
        Me.Label8.Text = "Fecha Nacimiento"
        '
        'txt_nombre_cliente
        '
        Me.txt_nombre_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_cliente.Location = New System.Drawing.Point(164, 52)
        Me.txt_nombre_cliente.MaxLength = 20
        Me.txt_nombre_cliente.Name = "txt_nombre_cliente"
        Me.txt_nombre_cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_nombre_cliente.TabIndex = 2
        '
        'txt_apellido1_cliente
        '
        Me.txt_apellido1_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido1_cliente.Location = New System.Drawing.Point(164, 96)
        Me.txt_apellido1_cliente.MaxLength = 20
        Me.txt_apellido1_cliente.Name = "txt_apellido1_cliente"
        Me.txt_apellido1_cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_apellido1_cliente.TabIndex = 3
        '
        'txt_apelldio2_cliente
        '
        Me.txt_apelldio2_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apelldio2_cliente.Location = New System.Drawing.Point(164, 140)
        Me.txt_apelldio2_cliente.MaxLength = 20
        Me.txt_apelldio2_cliente.Name = "txt_apelldio2_cliente"
        Me.txt_apelldio2_cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_apelldio2_cliente.TabIndex = 4
        '
        'txt_direccion_cliente
        '
        Me.txt_direccion_cliente.Location = New System.Drawing.Point(164, 183)
        Me.txt_direccion_cliente.MaxLength = 20
        Me.txt_direccion_cliente.Name = "txt_direccion_cliente"
        Me.txt_direccion_cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_direccion_cliente.TabIndex = 5
        '
        'txt_email_cliente
        '
        Me.txt_email_cliente.Location = New System.Drawing.Point(164, 224)
        Me.txt_email_cliente.MaxLength = 20
        Me.txt_email_cliente.Name = "txt_email_cliente"
        Me.txt_email_cliente.Size = New System.Drawing.Size(176, 20)
        Me.txt_email_cliente.TabIndex = 6
        '
        'txt_telefono_cliente
        '
        Me.txt_telefono_cliente.Location = New System.Drawing.Point(164, 263)
        Me.txt_telefono_cliente.MaxLength = 10
        Me.txt_telefono_cliente.Name = "txt_telefono_cliente"
        Me.txt_telefono_cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_telefono_cliente.TabIndex = 7
        '
        'gbo_datos_cliente
        '
        Me.gbo_datos_cliente.Controls.Add(Me.txt_fecha_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label22)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_cedula_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label21)
        Me.gbo_datos_cliente.Controls.Add(Me.Label19)
        Me.gbo_datos_cliente.Controls.Add(Me.Label18)
        Me.gbo_datos_cliente.Controls.Add(Me.Label17)
        Me.gbo_datos_cliente.Controls.Add(Me.Label16)
        Me.gbo_datos_cliente.Controls.Add(Me.Label15)
        Me.gbo_datos_cliente.Controls.Add(Me.Label14)
        Me.gbo_datos_cliente.Controls.Add(Me.Label1)
        Me.gbo_datos_cliente.Controls.Add(Me.Label2)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_telefono_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label4)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_email_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label5)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_direccion_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label6)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_apelldio2_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label7)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_apellido1_cliente)
        Me.gbo_datos_cliente.Controls.Add(Me.Label8)
        Me.gbo_datos_cliente.Controls.Add(Me.txt_nombre_cliente)
        Me.gbo_datos_cliente.Location = New System.Drawing.Point(12, 75)
        Me.gbo_datos_cliente.Name = "gbo_datos_cliente"
        Me.gbo_datos_cliente.Size = New System.Drawing.Size(398, 331)
        Me.gbo_datos_cliente.TabIndex = 26
        Me.gbo_datos_cliente.TabStop = False
        Me.gbo_datos_cliente.Text = "Datos"
        '
        'txt_fecha_cliente
        '
        Me.txt_fecha_cliente.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.txt_fecha_cliente.Location = New System.Drawing.Point(164, 300)
        Me.txt_fecha_cliente.Name = "txt_fecha_cliente"
        Me.txt_fecha_cliente.Size = New System.Drawing.Size(106, 20)
        Me.txt_fecha_cliente.TabIndex = 42
        Me.txt_fecha_cliente.Value = New Date(2016, 8, 24, 0, 0, 0, 0)
        '
        'Label22
        '
        Me.Label22.AutoSize = True
        Me.Label22.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label22.ForeColor = System.Drawing.Color.Red
        Me.Label22.Location = New System.Drawing.Point(376, 16)
        Me.Label22.Name = "Label22"
        Me.Label22.Size = New System.Drawing.Size(15, 20)
        Me.Label22.TabIndex = 41
        Me.Label22.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label22, "Campo Obligatorio")
        '
        'txt_cedula_cliente
        '
        Me.txt_cedula_cliente.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cedula_cliente.Location = New System.Drawing.Point(164, 16)
        Me.txt_cedula_cliente.MaxLength = 10
        Me.txt_cedula_cliente.Name = "txt_cedula_cliente"
        Me.txt_cedula_cliente.Size = New System.Drawing.Size(206, 20)
        Me.txt_cedula_cliente.TabIndex = 1
        '
        'Label21
        '
        Me.Label21.AutoSize = True
        Me.Label21.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label21.ForeColor = System.Drawing.Color.Black
        Me.Label21.Location = New System.Drawing.Point(7, 19)
        Me.Label21.Name = "Label21"
        Me.Label21.Size = New System.Drawing.Size(56, 19)
        Me.Label21.TabIndex = 32
        Me.Label21.Text = "Cedula"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Red
        Me.Label19.Image = CType(resources.GetObject("Label19.Image"), System.Drawing.Image)
        Me.Label19.Location = New System.Drawing.Point(288, 302)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(33, 20)
        Me.Label19.TabIndex = 31
        Me.Label19.Text = "      "
        Me.ToolTip1.SetToolTip(Me.Label19, "Ingresar Fecha Formato Dia/Mes/Año")
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Red
        Me.Label18.Location = New System.Drawing.Point(343, 224)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(15, 20)
        Me.Label18.TabIndex = 30
        Me.Label18.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label18, "Campo Obligatorio")
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Red
        Me.Label17.Location = New System.Drawing.Point(376, 181)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(15, 20)
        Me.Label17.TabIndex = 29
        Me.Label17.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label17, "Campo Obligatorio")
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Red
        Me.Label16.Location = New System.Drawing.Point(376, 138)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(15, 20)
        Me.Label16.TabIndex = 28
        Me.Label16.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label16, "Campo Obligatorio")
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Red
        Me.Label15.Location = New System.Drawing.Point(376, 95)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(15, 20)
        Me.Label15.TabIndex = 27
        Me.Label15.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label15, "Campo Obligatorio")
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(376, 52)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 20)
        Me.Label14.TabIndex = 26
        Me.Label14.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label14, "Campo Obligatorio")
        '
        'gbo_categoria_cliente
        '
        Me.gbo_categoria_cliente.Controls.Add(Me.txt_codigo_obtener)
        Me.gbo_categoria_cliente.Controls.Add(Me.Label20)
        Me.gbo_categoria_cliente.Controls.Add(Me.gbo_membresia_cliente)
        Me.gbo_categoria_cliente.Controls.Add(Me.cbo_categoria_cliente)
        Me.gbo_categoria_cliente.Controls.Add(Me.Label9)
        Me.gbo_categoria_cliente.Location = New System.Drawing.Point(416, 75)
        Me.gbo_categoria_cliente.Name = "gbo_categoria_cliente"
        Me.gbo_categoria_cliente.Size = New System.Drawing.Size(351, 331)
        Me.gbo_categoria_cliente.TabIndex = 27
        Me.gbo_categoria_cliente.TabStop = False
        Me.gbo_categoria_cliente.Text = "Categoria"
        '
        'txt_codigo_obtener
        '
        Me.txt_codigo_obtener.Location = New System.Drawing.Point(20, 78)
        Me.txt_codigo_obtener.Name = "txt_codigo_obtener"
        Me.txt_codigo_obtener.Size = New System.Drawing.Size(73, 20)
        Me.txt_codigo_obtener.TabIndex = 41
        Me.txt_codigo_obtener.Visible = False
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(239, 19)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 20)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label20, "Campo Obligatorio")
        '
        'gbo_membresia_cliente
        '
        Me.gbo_membresia_cliente.Controls.Add(Me.txt_fecha_caducidad)
        Me.gbo_membresia_cliente.Controls.Add(Me.txt_numero_ingreso_c)
        Me.gbo_membresia_cliente.Controls.Add(Me.fecha_apertura_ingreso_c)
        Me.gbo_membresia_cliente.Controls.Add(Me.cbo_dias_año_cliente)
        Me.gbo_membresia_cliente.Controls.Add(Me.Label27)
        Me.gbo_membresia_cliente.Controls.Add(Me.Label24)
        Me.gbo_membresia_cliente.Controls.Add(Me.txt_fecha_renovacion_cliente)
        Me.gbo_membresia_cliente.Controls.Add(Me.Label23)
        Me.gbo_membresia_cliente.Controls.Add(Me.txt_valor_pago_cliente)
        Me.gbo_membresia_cliente.Controls.Add(Me.Label13)
        Me.gbo_membresia_cliente.Controls.Add(Me.Label12)
        Me.gbo_membresia_cliente.Controls.Add(Me.Label11)
        Me.gbo_membresia_cliente.Controls.Add(Me.Label10)
        Me.gbo_membresia_cliente.Location = New System.Drawing.Point(20, 104)
        Me.gbo_membresia_cliente.Name = "gbo_membresia_cliente"
        Me.gbo_membresia_cliente.Size = New System.Drawing.Size(308, 217)
        Me.gbo_membresia_cliente.TabIndex = 20
        Me.gbo_membresia_cliente.TabStop = False
        Me.gbo_membresia_cliente.Text = "Membresia"
        '
        'txt_fecha_caducidad
        '
        Me.txt_fecha_caducidad.Location = New System.Drawing.Point(162, 134)
        Me.txt_fecha_caducidad.Name = "txt_fecha_caducidad"
        Me.txt_fecha_caducidad.ReadOnly = True
        Me.txt_fecha_caducidad.Size = New System.Drawing.Size(80, 20)
        Me.txt_fecha_caducidad.TabIndex = 48
        '
        'txt_numero_ingreso_c
        '
        Me.txt_numero_ingreso_c.Location = New System.Drawing.Point(162, 98)
        Me.txt_numero_ingreso_c.MaxLength = 2
        Me.txt_numero_ingreso_c.Name = "txt_numero_ingreso_c"
        Me.txt_numero_ingreso_c.Size = New System.Drawing.Size(48, 20)
        Me.txt_numero_ingreso_c.TabIndex = 12
        Me.txt_numero_ingreso_c.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'fecha_apertura_ingreso_c
        '
        Me.fecha_apertura_ingreso_c.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.fecha_apertura_ingreso_c.Location = New System.Drawing.Point(160, 61)
        Me.fecha_apertura_ingreso_c.Name = "fecha_apertura_ingreso_c"
        Me.fecha_apertura_ingreso_c.Size = New System.Drawing.Size(106, 20)
        Me.fecha_apertura_ingreso_c.TabIndex = 11
        Me.fecha_apertura_ingreso_c.Value = New Date(2016, 8, 24, 0, 0, 0, 0)
        '
        'cbo_dias_año_cliente
        '
        Me.cbo_dias_año_cliente.DisplayMember = "DESCRIPCION"
        Me.cbo_dias_año_cliente.FormattingEnabled = True
        Me.cbo_dias_año_cliente.Location = New System.Drawing.Point(216, 97)
        Me.cbo_dias_año_cliente.Name = "cbo_dias_año_cliente"
        Me.cbo_dias_año_cliente.Size = New System.Drawing.Size(50, 21)
        Me.cbo_dias_año_cliente.TabIndex = 13
        Me.ToolTip1.SetToolTip(Me.cbo_dias_año_cliente, "Escoger Tiempo De Duracion")
        Me.cbo_dias_año_cliente.ValueMember = "ID_T_M"
        '
        'Label27
        '
        Me.Label27.AutoSize = True
        Me.Label27.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label27.ForeColor = System.Drawing.Color.Black
        Me.Label27.Location = New System.Drawing.Point(16, 99)
        Me.Label27.Name = "Label27"
        Me.Label27.Size = New System.Drawing.Size(140, 19)
        Me.Label27.TabIndex = 47
        Me.Label27.Text = "Tiempo Membresia"
        '
        'Label24
        '
        Me.Label24.AutoSize = True
        Me.Label24.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label24.ForeColor = System.Drawing.Color.Red
        Me.Label24.Image = CType(resources.GetObject("Label24.Image"), System.Drawing.Image)
        Me.Label24.Location = New System.Drawing.Point(269, 61)
        Me.Label24.Name = "Label24"
        Me.Label24.Size = New System.Drawing.Size(33, 20)
        Me.Label24.TabIndex = 42
        Me.Label24.Text = "      "
        Me.ToolTip1.SetToolTip(Me.Label24, "Ingresar Fecha Formato Dia/Mes/Año")
        '
        'txt_fecha_renovacion_cliente
        '
        Me.txt_fecha_renovacion_cliente.Location = New System.Drawing.Point(162, 169)
        Me.txt_fecha_renovacion_cliente.Name = "txt_fecha_renovacion_cliente"
        Me.txt_fecha_renovacion_cliente.ReadOnly = True
        Me.txt_fecha_renovacion_cliente.Size = New System.Drawing.Size(80, 20)
        Me.txt_fecha_renovacion_cliente.TabIndex = 15
        '
        'Label23
        '
        Me.Label23.AutoSize = True
        Me.Label23.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label23.ForeColor = System.Drawing.Color.Red
        Me.Label23.Location = New System.Drawing.Point(240, 28)
        Me.Label23.Name = "Label23"
        Me.Label23.Size = New System.Drawing.Size(15, 20)
        Me.Label23.TabIndex = 41
        Me.Label23.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label23, "Campo Obligatorio")
        '
        'txt_valor_pago_cliente
        '
        Me.txt_valor_pago_cliente.Location = New System.Drawing.Point(161, 28)
        Me.txt_valor_pago_cliente.MaxLength = 6
        Me.txt_valor_pago_cliente.Name = "txt_valor_pago_cliente"
        Me.txt_valor_pago_cliente.Size = New System.Drawing.Size(73, 20)
        Me.txt_valor_pago_cliente.TabIndex = 10
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(19, 172)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(132, 19)
        Me.Label13.TabIndex = 20
        Me.Label13.Text = "Fecha Renovacion"
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(18, 135)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(123, 19)
        Me.Label12.TabIndex = 19
        Me.Label12.Text = "Fecha Caducidad"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(17, 61)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(112, 19)
        Me.Label11.TabIndex = 18
        Me.Label11.Text = "Fecha Apertura"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(17, 29)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(82, 19)
        Me.Label10.TabIndex = 17
        Me.Label10.Text = "Valor Pago"
        '
        'cbo_categoria_cliente
        '
        Me.cbo_categoria_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.cbo_categoria_cliente.DisplayMember = "DESCRIPCION"
        Me.cbo_categoria_cliente.FormattingEnabled = True
        Me.cbo_categoria_cliente.Location = New System.Drawing.Point(85, 18)
        Me.cbo_categoria_cliente.Name = "cbo_categoria_cliente"
        Me.cbo_categoria_cliente.Size = New System.Drawing.Size(151, 21)
        Me.cbo_categoria_cliente.TabIndex = 9
        Me.cbo_categoria_cliente.ValueMember = "ID_TIPO_CLIENTE"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(6, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Opciones"
        '
        'btn_guardar_cliente
        '
        Me.btn_guardar_cliente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_guardar_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar_cliente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_cliente.ForeColor = System.Drawing.Color.Red
        Me.btn_guardar_cliente.Image = CType(resources.GetObject("btn_guardar_cliente.Image"), System.Drawing.Image)
        Me.btn_guardar_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar_cliente.Location = New System.Drawing.Point(155, 16)
        Me.btn_guardar_cliente.Name = "btn_guardar_cliente"
        Me.btn_guardar_cliente.Size = New System.Drawing.Size(125, 36)
        Me.btn_guardar_cliente.TabIndex = 17
        Me.btn_guardar_cliente.Text = "    GUARDAR"
        Me.ToolTip1.SetToolTip(Me.btn_guardar_cliente, "Guardar Cliente")
        Me.btn_guardar_cliente.UseVisualStyleBackColor = True
        '
        'btn_volver_cliente
        '
        Me.btn_volver_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_cliente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver_cliente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_cliente.ForeColor = System.Drawing.Color.Red
        Me.btn_volver_cliente.Image = CType(resources.GetObject("btn_volver_cliente.Image"), System.Drawing.Image)
        Me.btn_volver_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_cliente.Location = New System.Drawing.Point(286, 16)
        Me.btn_volver_cliente.Name = "btn_volver_cliente"
        Me.btn_volver_cliente.Size = New System.Drawing.Size(125, 36)
        Me.btn_volver_cliente.TabIndex = 18
        Me.btn_volver_cliente.Text = "VOLVER"
        Me.ToolTip1.SetToolTip(Me.btn_volver_cliente, "Volver A Pantalla Pincipal")
        Me.btn_volver_cliente.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.BackgroundImage = CType(resources.GetObject("PictureBox1.BackgroundImage"), System.Drawing.Image)
        Me.PictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.PictureBox1.Location = New System.Drawing.Point(683, 6)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(104, 105)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btn_ir_factura
        '
        Me.btn_ir_factura.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_ir_factura.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_ir_factura.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_ir_factura.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_ir_factura.Image = CType(resources.GetObject("btn_ir_factura.Image"), System.Drawing.Image)
        Me.btn_ir_factura.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_ir_factura.Location = New System.Drawing.Point(652, 428)
        Me.btn_ir_factura.Name = "btn_ir_factura"
        Me.btn_ir_factura.Size = New System.Drawing.Size(125, 36)
        Me.btn_ir_factura.TabIndex = 33
        Me.btn_ir_factura.Text = "Ir Factura"
        Me.ToolTip1.SetToolTip(Me.btn_ir_factura, "Regresar a Facturacion")
        Me.btn_ir_factura.UseVisualStyleBackColor = True
        '
        'btn_nuevo_cliente
        '
        Me.btn_nuevo_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_cliente.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_nuevo_cliente.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo_cliente.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_cliente.ForeColor = System.Drawing.Color.Red
        Me.btn_nuevo_cliente.Image = CType(resources.GetObject("btn_nuevo_cliente.Image"), System.Drawing.Image)
        Me.btn_nuevo_cliente.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_cliente.Location = New System.Drawing.Point(23, 16)
        Me.btn_nuevo_cliente.Name = "btn_nuevo_cliente"
        Me.btn_nuevo_cliente.Size = New System.Drawing.Size(125, 36)
        Me.btn_nuevo_cliente.TabIndex = 16
        Me.btn_nuevo_cliente.Text = "NUEVO"
        Me.ToolTip1.SetToolTip(Me.btn_nuevo_cliente, "Nuevo Cliente")
        Me.btn_nuevo_cliente.UseVisualStyleBackColor = True
        '
        'Botones
        '
        Me.Botones.Controls.Add(Me.btn_volver_cliente)
        Me.Botones.Controls.Add(Me.btn_nuevo_cliente)
        Me.Botones.Controls.Add(Me.btn_guardar_cliente)
        Me.Botones.Location = New System.Drawing.Point(195, 424)
        Me.Botones.Name = "Botones"
        Me.Botones.Size = New System.Drawing.Size(434, 58)
        Me.Botones.TabIndex = 34
        Me.Botones.TabStop = False
        Me.Botones.Text = "Botones"
        '
        'Ingreso_Clientes
        '
        Me.AcceptButton = Me.btn_guardar_cliente
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom
        Me.CancelButton = Me.btn_volver_cliente
        Me.ClientSize = New System.Drawing.Size(789, 494)
        Me.Controls.Add(Me.Botones)
        Me.Controls.Add(Me.btn_ir_factura)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbo_categoria_cliente)
        Me.Controls.Add(Me.gbo_datos_cliente)
        Me.Controls.Add(Me.Label3)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_Clientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Ingrese Cliente"
        Me.gbo_datos_cliente.ResumeLayout(False)
        Me.gbo_datos_cliente.PerformLayout()
        Me.gbo_categoria_cliente.ResumeLayout(False)
        Me.gbo_categoria_cliente.PerformLayout()
        Me.gbo_membresia_cliente.ResumeLayout(False)
        Me.gbo_membresia_cliente.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Botones.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido1_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_apelldio2_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_email_cliente As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono_cliente As System.Windows.Forms.TextBox
    Friend WithEvents gbo_datos_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_categoria_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_membresia_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents txt_valor_pago_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbo_categoria_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents btn_guardar_cliente As System.Windows.Forms.Button
    Friend WithEvents btn_volver_cliente As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_ir_factura As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents btn_nuevo_cliente As System.Windows.Forms.Button
    Friend WithEvents Label22 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label21 As System.Windows.Forms.Label
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_renovacion_cliente As System.Windows.Forms.TextBox
    Friend WithEvents cbo_dias_año_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents fecha_apertura_ingreso_c As System.Windows.Forms.DateTimePicker
    Friend WithEvents txt_numero_ingreso_c As System.Windows.Forms.TextBox
    Friend WithEvents txt_fecha_caducidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_codigo_obtener As System.Windows.Forms.TextBox
    Friend WithEvents Botones As System.Windows.Forms.GroupBox
    Friend WithEvents txt_fecha_cliente As System.Windows.Forms.DateTimePicker
End Class
