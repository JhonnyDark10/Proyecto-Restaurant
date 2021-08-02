<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_Empleados))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_nombre_empleados_i = New System.Windows.Forms.TextBox()
        Me.txt_apellidos_empleados_i = New System.Windows.Forms.TextBox()
        Me.txt_apellidos_empleados_i2 = New System.Windows.Forms.TextBox()
        Me.txt_direccion_empleado_i = New System.Windows.Forms.TextBox()
        Me.btn_guardar_empleado_i = New System.Windows.Forms.Button()
        Me.btn_volver_empleado_i = New System.Windows.Forms.Button()
        Me.gbo_empleados_i = New System.Windows.Forms.GroupBox()
        Me.gbo_ususario_visible = New System.Windows.Forms.GroupBox()
        Me.txt_usuario_cuenta_e = New System.Windows.Forms.TextBox()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_usuario_contraseña_e = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_empleado_i_crear_cuenta = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_telefono_empleado_i = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cedula_empleado_i = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO = New System.Windows.Forms.ComboBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_nuevo_plato = New System.Windows.Forms.Button()
        Me.gbo_botones_empleados = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbo_empleados_i.SuspendLayout()
        Me.gbo_ususario_visible.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbo_botones_empleados.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(136, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(308, 31)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "     REGISTRO EMPLEADOS"
        '
        'txt_nombre_empleados_i
        '
        Me.txt_nombre_empleados_i.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_empleados_i.Location = New System.Drawing.Point(171, 65)
        Me.txt_nombre_empleados_i.MaxLength = 20
        Me.txt_nombre_empleados_i.Name = "txt_nombre_empleados_i"
        Me.txt_nombre_empleados_i.Size = New System.Drawing.Size(219, 20)
        Me.txt_nombre_empleados_i.TabIndex = 3
        '
        'txt_apellidos_empleados_i
        '
        Me.txt_apellidos_empleados_i.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos_empleados_i.Location = New System.Drawing.Point(171, 106)
        Me.txt_apellidos_empleados_i.MaxLength = 20
        Me.txt_apellidos_empleados_i.Name = "txt_apellidos_empleados_i"
        Me.txt_apellidos_empleados_i.Size = New System.Drawing.Size(219, 20)
        Me.txt_apellidos_empleados_i.TabIndex = 4
        '
        'txt_apellidos_empleados_i2
        '
        Me.txt_apellidos_empleados_i2.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos_empleados_i2.Location = New System.Drawing.Point(171, 150)
        Me.txt_apellidos_empleados_i2.MaxLength = 20
        Me.txt_apellidos_empleados_i2.Name = "txt_apellidos_empleados_i2"
        Me.txt_apellidos_empleados_i2.Size = New System.Drawing.Size(219, 20)
        Me.txt_apellidos_empleados_i2.TabIndex = 5
        '
        'txt_direccion_empleado_i
        '
        Me.txt_direccion_empleado_i.Location = New System.Drawing.Point(171, 193)
        Me.txt_direccion_empleado_i.MaxLength = 20
        Me.txt_direccion_empleado_i.Name = "txt_direccion_empleado_i"
        Me.txt_direccion_empleado_i.Size = New System.Drawing.Size(219, 20)
        Me.txt_direccion_empleado_i.TabIndex = 6
        '
        'btn_guardar_empleado_i
        '
        Me.btn_guardar_empleado_i.BackColor = System.Drawing.Color.White
        Me.btn_guardar_empleado_i.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_guardar_empleado_i.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_empleado_i.ForeColor = System.Drawing.Color.Red
        Me.btn_guardar_empleado_i.Image = CType(resources.GetObject("btn_guardar_empleado_i.Image"), System.Drawing.Image)
        Me.btn_guardar_empleado_i.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar_empleado_i.Location = New System.Drawing.Point(186, 19)
        Me.btn_guardar_empleado_i.Name = "btn_guardar_empleado_i"
        Me.btn_guardar_empleado_i.Size = New System.Drawing.Size(125, 36)
        Me.btn_guardar_empleado_i.TabIndex = 9
        Me.btn_guardar_empleado_i.Text = "    GUARDAR"
        Me.ToolTip1.SetToolTip(Me.btn_guardar_empleado_i, "Guardar Empleado")
        Me.btn_guardar_empleado_i.UseVisualStyleBackColor = False
        '
        'btn_volver_empleado_i
        '
        Me.btn_volver_empleado_i.BackColor = System.Drawing.Color.White
        Me.btn_volver_empleado_i.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_empleado_i.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_empleado_i.ForeColor = System.Drawing.Color.Red
        Me.btn_volver_empleado_i.Image = CType(resources.GetObject("btn_volver_empleado_i.Image"), System.Drawing.Image)
        Me.btn_volver_empleado_i.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_empleado_i.Location = New System.Drawing.Point(332, 19)
        Me.btn_volver_empleado_i.Name = "btn_volver_empleado_i"
        Me.btn_volver_empleado_i.Size = New System.Drawing.Size(125, 36)
        Me.btn_volver_empleado_i.TabIndex = 10
        Me.btn_volver_empleado_i.Text = "VOLVER"
        Me.ToolTip1.SetToolTip(Me.btn_volver_empleado_i, "Volver A Pagina Principal")
        Me.btn_volver_empleado_i.UseVisualStyleBackColor = False
        '
        'gbo_empleados_i
        '
        Me.gbo_empleados_i.BackColor = System.Drawing.Color.White
        Me.gbo_empleados_i.Controls.Add(Me.gbo_ususario_visible)
        Me.gbo_empleados_i.Controls.Add(Me.GroupBox1)
        Me.gbo_empleados_i.Controls.Add(Me.Label14)
        Me.gbo_empleados_i.Controls.Add(Me.Label13)
        Me.gbo_empleados_i.Controls.Add(Me.Label12)
        Me.gbo_empleados_i.Controls.Add(Me.Label11)
        Me.gbo_empleados_i.Controls.Add(Me.Label10)
        Me.gbo_empleados_i.Controls.Add(Me.Label9)
        Me.gbo_empleados_i.Controls.Add(Me.txt_telefono_empleado_i)
        Me.gbo_empleados_i.Controls.Add(Me.Label8)
        Me.gbo_empleados_i.Controls.Add(Me.Label5)
        Me.gbo_empleados_i.Controls.Add(Me.Label4)
        Me.gbo_empleados_i.Controls.Add(Me.Label2)
        Me.gbo_empleados_i.Controls.Add(Me.Label1)
        Me.gbo_empleados_i.Controls.Add(Me.txt_cedula_empleado_i)
        Me.gbo_empleados_i.Controls.Add(Me.Label6)
        Me.gbo_empleados_i.Controls.Add(Me.txt_nombre_empleados_i)
        Me.gbo_empleados_i.Controls.Add(Me.txt_direccion_empleado_i)
        Me.gbo_empleados_i.Controls.Add(Me.txt_apellidos_empleados_i2)
        Me.gbo_empleados_i.Controls.Add(Me.txt_apellidos_empleados_i)
        Me.gbo_empleados_i.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.gbo_empleados_i.Location = New System.Drawing.Point(36, 104)
        Me.gbo_empleados_i.Name = "gbo_empleados_i"
        Me.gbo_empleados_i.Size = New System.Drawing.Size(485, 338)
        Me.gbo_empleados_i.TabIndex = 18
        Me.gbo_empleados_i.TabStop = False
        Me.gbo_empleados_i.Text = "Datos"
        '
        'gbo_ususario_visible
        '
        Me.gbo_ususario_visible.Controls.Add(Me.txt_usuario_cuenta_e)
        Me.gbo_ususario_visible.Controls.Add(Me.Label17)
        Me.gbo_ususario_visible.Controls.Add(Me.Label18)
        Me.gbo_ususario_visible.Controls.Add(Me.txt_usuario_contraseña_e)
        Me.gbo_ususario_visible.Location = New System.Drawing.Point(6, 257)
        Me.gbo_ususario_visible.Name = "gbo_ususario_visible"
        Me.gbo_ususario_visible.Size = New System.Drawing.Size(305, 75)
        Me.gbo_ususario_visible.TabIndex = 48
        Me.gbo_ususario_visible.TabStop = False
        Me.gbo_ususario_visible.Text = "Datos"
        '
        'txt_usuario_cuenta_e
        '
        Me.txt_usuario_cuenta_e.Location = New System.Drawing.Point(124, 18)
        Me.txt_usuario_cuenta_e.Name = "txt_usuario_cuenta_e"
        Me.txt_usuario_cuenta_e.ReadOnly = True
        Me.txt_usuario_cuenta_e.Size = New System.Drawing.Size(178, 20)
        Me.txt_usuario_cuenta_e.TabIndex = 12
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(25, 19)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(61, 19)
        Me.Label17.TabIndex = 8
        Me.Label17.Text = "Usuario"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(25, 42)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(86, 19)
        Me.Label18.TabIndex = 9
        Me.Label18.Text = "Contraseña"
        '
        'txt_usuario_contraseña_e
        '
        Me.txt_usuario_contraseña_e.Location = New System.Drawing.Point(124, 41)
        Me.txt_usuario_contraseña_e.Name = "txt_usuario_contraseña_e"
        Me.txt_usuario_contraseña_e.ReadOnly = True
        Me.txt_usuario_contraseña_e.Size = New System.Drawing.Size(178, 20)
        Me.txt_usuario_contraseña_e.TabIndex = 13
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_empleado_i_crear_cuenta)
        Me.GroupBox1.Location = New System.Drawing.Point(332, 269)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(146, 63)
        Me.GroupBox1.TabIndex = 47
        Me.GroupBox1.TabStop = False
        '
        'btn_empleado_i_crear_cuenta
        '
        Me.btn_empleado_i_crear_cuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_empleado_i_crear_cuenta.FlatAppearance.BorderSize = 0
        Me.btn_empleado_i_crear_cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_empleado_i_crear_cuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empleado_i_crear_cuenta.Image = CType(resources.GetObject("btn_empleado_i_crear_cuenta.Image"), System.Drawing.Image)
        Me.btn_empleado_i_crear_cuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_empleado_i_crear_cuenta.Location = New System.Drawing.Point(11, 11)
        Me.btn_empleado_i_crear_cuenta.Name = "btn_empleado_i_crear_cuenta"
        Me.btn_empleado_i_crear_cuenta.Size = New System.Drawing.Size(125, 47)
        Me.btn_empleado_i_crear_cuenta.TabIndex = 8
        Me.btn_empleado_i_crear_cuenta.Text = "CREAR CUENTA"
        Me.ToolTip1.SetToolTip(Me.btn_empleado_i_crear_cuenta, "Opcion Crear Cuenta De Usuario")
        Me.btn_empleado_i_crear_cuenta.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Red
        Me.Label14.Location = New System.Drawing.Point(396, 230)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(15, 20)
        Me.Label14.TabIndex = 46
        Me.Label14.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label14, "Campo Obligatorio")
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(396, 193)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 45
        Me.Label13.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label13, "Campo Obligatorio")
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Red
        Me.Label12.Location = New System.Drawing.Point(396, 148)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(15, 20)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label12, "Campo Obligatorio")
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(396, 104)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 43
        Me.Label11.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label11, "Campo Obligatorio")
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(396, 65)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label10, "Campo Obligatorio")
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(396, 29)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 41
        Me.Label9.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label9, "Campo Obligatorio")
        '
        'txt_telefono_empleado_i
        '
        Me.txt_telefono_empleado_i.Location = New System.Drawing.Point(171, 231)
        Me.txt_telefono_empleado_i.MaxLength = 10
        Me.txt_telefono_empleado_i.Name = "txt_telefono_empleado_i"
        Me.txt_telefono_empleado_i.Size = New System.Drawing.Size(219, 20)
        Me.txt_telefono_empleado_i.TabIndex = 7
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(73, 229)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 23
        Me.Label8.Text = "Telefono"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(73, 194)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(73, 19)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Direccion"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(73, 140)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(68, 38)
        Me.Label4.TabIndex = 21
        Me.Label4.Text = "Apellido " & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Materno"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(73, 94)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(64, 38)
        Me.Label2.TabIndex = 20
        Me.Label2.Text = "Apellido" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Paterno"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(73, 65)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 19)
        Me.Label1.TabIndex = 19
        Me.Label1.Text = "Nombres"
        '
        'txt_cedula_empleado_i
        '
        Me.txt_cedula_empleado_i.Location = New System.Drawing.Point(171, 29)
        Me.txt_cedula_empleado_i.MaxLength = 10
        Me.txt_cedula_empleado_i.Name = "txt_cedula_empleado_i"
        Me.txt_cedula_empleado_i.Size = New System.Drawing.Size(219, 20)
        Me.txt_cedula_empleado_i.TabIndex = 2
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(73, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(56, 19)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "Cedula"
        '
        'CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO
        '
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.DisplayMember = "DESCRIPCION"
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.FormattingEnabled = True
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Items.AddRange(New Object() {"PERSONAL DE ASEO", "CAJERO", "COCINERO", "MESERO"})
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Location = New System.Drawing.Point(236, 64)
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Name = "CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO"
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Size = New System.Drawing.Size(190, 21)
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.TabIndex = 1
        Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.ValueMember = "ID_ROLES_EMPLEADOS"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.Location = New System.Drawing.Point(40, 66)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(191, 19)
        Me.Label7.TabIndex = 36
        Me.Label7.Text = "ROLES DE EMPLEADOS"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(473, 2)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 125)
        Me.PictureBox1.TabIndex = 37
        Me.PictureBox1.TabStop = False
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
        Me.btn_nuevo_plato.ForeColor = System.Drawing.Color.Red
        Me.btn_nuevo_plato.Image = CType(resources.GetObject("btn_nuevo_plato.Image"), System.Drawing.Image)
        Me.btn_nuevo_plato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_plato.Location = New System.Drawing.Point(40, 19)
        Me.btn_nuevo_plato.Name = "btn_nuevo_plato"
        Me.btn_nuevo_plato.Size = New System.Drawing.Size(125, 36)
        Me.btn_nuevo_plato.TabIndex = 39
        Me.btn_nuevo_plato.Text = "    NUEVO"
        Me.ToolTip1.SetToolTip(Me.btn_nuevo_plato, "Registrar Nuevo Empleado")
        Me.btn_nuevo_plato.UseVisualStyleBackColor = False
        '
        'gbo_botones_empleados
        '
        Me.gbo_botones_empleados.Controls.Add(Me.btn_nuevo_plato)
        Me.gbo_botones_empleados.Controls.Add(Me.btn_volver_empleado_i)
        Me.gbo_botones_empleados.Controls.Add(Me.btn_guardar_empleado_i)
        Me.gbo_botones_empleados.Location = New System.Drawing.Point(36, 448)
        Me.gbo_botones_empleados.Name = "gbo_botones_empleados"
        Me.gbo_botones_empleados.Size = New System.Drawing.Size(485, 65)
        Me.gbo_botones_empleados.TabIndex = 40
        Me.gbo_botones_empleados.TabStop = False
        Me.gbo_botones_empleados.Text = "Botones"
        '
        'Ingreso_Empleados
        '
        Me.AcceptButton = Me.btn_guardar_empleado_i
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_volver_empleado_i
        Me.ClientSize = New System.Drawing.Size(594, 523)
        Me.Controls.Add(Me.gbo_botones_empleados)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO)
        Me.Controls.Add(Me.gbo_empleados_i)
        Me.Controls.Add(Me.Label3)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbo_empleados_i.ResumeLayout(False)
        Me.gbo_empleados_i.PerformLayout()
        Me.gbo_ususario_visible.ResumeLayout(False)
        Me.gbo_ususario_visible.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbo_botones_empleados.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_empleados_i As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellidos_empleados_i As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellidos_empleados_i2 As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_empleado_i As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar_empleado_i As System.Windows.Forms.Button
    Friend WithEvents btn_volver_empleado_i As System.Windows.Forms.Button
    Friend WithEvents gbo_empleados_i As System.Windows.Forms.GroupBox
    Friend WithEvents txt_cedula_empleado_i As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents btn_empleado_i_crear_cuenta As System.Windows.Forms.Button
    Friend WithEvents CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO As System.Windows.Forms.ComboBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_empleado_i As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_nuevo_plato As System.Windows.Forms.Button
    Friend WithEvents gbo_botones_empleados As System.Windows.Forms.GroupBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_ususario_visible As System.Windows.Forms.GroupBox
    Friend WithEvents txt_usuario_cuenta_e As System.Windows.Forms.TextBox
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario_contraseña_e As System.Windows.Forms.TextBox
End Class
