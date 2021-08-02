<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingresa_Cuenta_Usuario
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingresa_Cuenta_Usuario))
        Me.GroupBox1_proveedores = New System.Windows.Forms.GroupBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_ususario_cuenta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario_contraseña = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btn_empleados_cuenta_crear_i = New System.Windows.Forms.Button()
        Me.btn_empleados_volver_cuenta_i = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_xdefecto_nombre = New System.Windows.Forms.TextBox()
        Me.txt_xdefecto_cedula = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.dg_cuentas_usuarios = New System.Windows.Forms.DataGridView()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.GroupBox1_proveedores.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_cuentas_usuarios, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1_proveedores
        '
        Me.GroupBox1_proveedores.Controls.Add(Me.Label7)
        Me.GroupBox1_proveedores.Controls.Add(Me.Label6)
        Me.GroupBox1_proveedores.Controls.Add(Me.txt_ususario_cuenta)
        Me.GroupBox1_proveedores.Controls.Add(Me.Label1)
        Me.GroupBox1_proveedores.Controls.Add(Me.Label2)
        Me.GroupBox1_proveedores.Controls.Add(Me.txt_usuario_contraseña)
        Me.GroupBox1_proveedores.Location = New System.Drawing.Point(19, 216)
        Me.GroupBox1_proveedores.Name = "GroupBox1_proveedores"
        Me.GroupBox1_proveedores.Size = New System.Drawing.Size(361, 126)
        Me.GroupBox1_proveedores.TabIndex = 21
        Me.GroupBox1_proveedores.TabStop = False
        Me.GroupBox1_proveedores.Text = "Datos"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(322, 74)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 28
        Me.Label7.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label7, "Campo Obligatorio")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(322, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 28
        Me.Label6.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label6, "Campo Obligatorio")
        '
        'txt_ususario_cuenta
        '
        Me.txt_ususario_cuenta.Location = New System.Drawing.Point(138, 36)
        Me.txt_ususario_cuenta.MaxLength = 20
        Me.txt_ususario_cuenta.Name = "txt_ususario_cuenta"
        Me.txt_ususario_cuenta.Size = New System.Drawing.Size(178, 20)
        Me.txt_ususario_cuenta.TabIndex = 12
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(47, 36)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(61, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Usuario"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(39, 77)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(86, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Contraseña"
        '
        'txt_usuario_contraseña
        '
        Me.txt_usuario_contraseña.Location = New System.Drawing.Point(138, 76)
        Me.txt_usuario_contraseña.MaxLength = 20
        Me.txt_usuario_contraseña.Name = "txt_usuario_contraseña"
        Me.txt_usuario_contraseña.Size = New System.Drawing.Size(178, 20)
        Me.txt_usuario_contraseña.TabIndex = 13
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(185, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(374, 31)
        Me.Label3.TabIndex = 20
        Me.Label3.Text = "      REGISTRO CUENTA USUARIO"
        '
        'btn_empleados_cuenta_crear_i
        '
        Me.btn_empleados_cuenta_crear_i.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_empleados_cuenta_crear_i.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_empleados_cuenta_crear_i.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_empleados_cuenta_crear_i.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empleados_cuenta_crear_i.ForeColor = System.Drawing.Color.Red
        Me.btn_empleados_cuenta_crear_i.Image = CType(resources.GetObject("btn_empleados_cuenta_crear_i.Image"), System.Drawing.Image)
        Me.btn_empleados_cuenta_crear_i.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_empleados_cuenta_crear_i.Location = New System.Drawing.Point(98, 33)
        Me.btn_empleados_cuenta_crear_i.Name = "btn_empleados_cuenta_crear_i"
        Me.btn_empleados_cuenta_crear_i.Size = New System.Drawing.Size(121, 32)
        Me.btn_empleados_cuenta_crear_i.TabIndex = 23
        Me.btn_empleados_cuenta_crear_i.Text = "     ACEPTAR"
        Me.ToolTip1.SetToolTip(Me.btn_empleados_cuenta_crear_i, "Crea el Usuario al Empleado")
        Me.btn_empleados_cuenta_crear_i.UseVisualStyleBackColor = True
        '
        'btn_empleados_volver_cuenta_i
        '
        Me.btn_empleados_volver_cuenta_i.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_empleados_volver_cuenta_i.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_empleados_volver_cuenta_i.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_empleados_volver_cuenta_i.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_empleados_volver_cuenta_i.ForeColor = System.Drawing.Color.Red
        Me.btn_empleados_volver_cuenta_i.Image = CType(resources.GetObject("btn_empleados_volver_cuenta_i.Image"), System.Drawing.Image)
        Me.btn_empleados_volver_cuenta_i.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_empleados_volver_cuenta_i.Location = New System.Drawing.Point(225, 33)
        Me.btn_empleados_volver_cuenta_i.Name = "btn_empleados_volver_cuenta_i"
        Me.btn_empleados_volver_cuenta_i.Size = New System.Drawing.Size(116, 32)
        Me.btn_empleados_volver_cuenta_i.TabIndex = 24
        Me.btn_empleados_volver_cuenta_i.Text = "    VOLVER"
        Me.ToolTip1.SetToolTip(Me.btn_empleados_volver_cuenta_i, "Regresa a la Ventana Ingresa Empleado")
        Me.btn_empleados_volver_cuenta_i.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(6, 17)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(75, 59)
        Me.PictureBox1.TabIndex = 25
        Me.PictureBox1.TabStop = False
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_empleados_volver_cuenta_i)
        Me.GroupBox1.Controls.Add(Me.btn_empleados_cuenta_crear_i)
        Me.GroupBox1.Controls.Add(Me.PictureBox1)
        Me.GroupBox1.Location = New System.Drawing.Point(19, 362)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(361, 85)
        Me.GroupBox1.TabIndex = 26
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Botones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_xdefecto_nombre)
        Me.GroupBox2.Controls.Add(Me.txt_xdefecto_cedula)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Location = New System.Drawing.Point(19, 75)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(361, 126)
        Me.GroupBox2.TabIndex = 27
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Informacion"
        '
        'txt_xdefecto_nombre
        '
        Me.txt_xdefecto_nombre.Location = New System.Drawing.Point(138, 74)
        Me.txt_xdefecto_nombre.Name = "txt_xdefecto_nombre"
        Me.txt_xdefecto_nombre.ReadOnly = True
        Me.txt_xdefecto_nombre.Size = New System.Drawing.Size(178, 20)
        Me.txt_xdefecto_nombre.TabIndex = 13
        '
        'txt_xdefecto_cedula
        '
        Me.txt_xdefecto_cedula.Location = New System.Drawing.Point(138, 36)
        Me.txt_xdefecto_cedula.Name = "txt_xdefecto_cedula"
        Me.txt_xdefecto_cedula.ReadOnly = True
        Me.txt_xdefecto_cedula.Size = New System.Drawing.Size(178, 20)
        Me.txt_xdefecto_cedula.TabIndex = 12
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(39, 74)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 8
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(39, 35)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 19)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "Cedula"
        '
        'dg_cuentas_usuarios
        '
        Me.dg_cuentas_usuarios.BackgroundColor = System.Drawing.Color.White
        Me.dg_cuentas_usuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.dg_cuentas_usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_cuentas_usuarios.Location = New System.Drawing.Point(18, 33)
        Me.dg_cuentas_usuarios.Name = "dg_cuentas_usuarios"
        Me.dg_cuentas_usuarios.Size = New System.Drawing.Size(240, 319)
        Me.dg_cuentas_usuarios.TabIndex = 28
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.dg_cuentas_usuarios)
        Me.GroupBox3.Location = New System.Drawing.Point(441, 75)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(274, 363)
        Me.GroupBox3.TabIndex = 29
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Cuentas De Usuarios Creadas"
        '
        'Ingresa_Cuenta_Usuario
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(750, 459)
        Me.ControlBox = False
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox1_proveedores)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Ingresa_Cuenta_Usuario"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.GroupBox1_proveedores.ResumeLayout(False)
        Me.GroupBox1_proveedores.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.dg_cuentas_usuarios, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox1_proveedores As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ususario_cuenta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btn_empleados_cuenta_crear_i As System.Windows.Forms.Button
    Friend WithEvents btn_empleados_volver_cuenta_i As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_xdefecto_cedula As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_xdefecto_nombre As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents dg_cuentas_usuarios As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
End Class
