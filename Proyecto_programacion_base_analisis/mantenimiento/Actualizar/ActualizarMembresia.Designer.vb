<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class ActualizarMembresia
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(ActualizarMembresia))
        Me.dgv_actualizar_ = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar_pL = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.btn_volver_plato_actualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.rb_actualizar_datos_empleados = New System.Windows.Forms.RadioButton()
        Me.gbo_dato_p_act = New System.Windows.Forms.GroupBox()
        Me.btn_cedula_buscar_act_p = New System.Windows.Forms.Button()
        Me.txt_cedula_act_p = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbo_categoria_cliente = New System.Windows.Forms.GroupBox()
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
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.dgv_actualizar_, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.gbo_dato_p_act.SuspendLayout()
        Me.gbo_categoria_cliente.SuspendLayout()
        Me.gbo_membresia_cliente.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_actualizar_
        '
        Me.dgv_actualizar_.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_actualizar_.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actualizar_.Location = New System.Drawing.Point(56, 407)
        Me.dgv_actualizar_.Name = "dgv_actualizar_"
        Me.dgv_actualizar_.Size = New System.Drawing.Size(658, 141)
        Me.dgv_actualizar_.TabIndex = 50
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_eliminar_pL)
        Me.GroupBox1.Controls.Add(Me.btn_actualizar)
        Me.GroupBox1.Controls.Add(Me.btn_volver_plato_actualizar)
        Me.GroupBox1.Location = New System.Drawing.Point(24, 224)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(351, 156)
        Me.GroupBox1.TabIndex = 52
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Botones"
        '
        'btn_eliminar_pL
        '
        Me.btn_eliminar_pL.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar_pL.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar_pL.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_pL.ForeColor = System.Drawing.Color.Red
        Me.btn_eliminar_pL.Image = CType(resources.GetObject("btn_eliminar_pL.Image"), System.Drawing.Image)
        Me.btn_eliminar_pL.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar_pL.Location = New System.Drawing.Point(181, 42)
        Me.btn_eliminar_pL.Name = "btn_eliminar_pL"
        Me.btn_eliminar_pL.Size = New System.Drawing.Size(147, 40)
        Me.btn_eliminar_pL.TabIndex = 52
        Me.btn_eliminar_pL.Text = "     ELIMINAR"
        Me.ToolTip1.SetToolTip(Me.btn_eliminar_pL, "Borra la membresia por CLASICO")
        Me.btn_eliminar_pL.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_actualizar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.Red
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(14, 43)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(147, 36)
        Me.btn_actualizar.TabIndex = 44
        Me.btn_actualizar.Text = "    ACTUALIZAR"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'btn_volver_plato_actualizar
        '
        Me.btn_volver_plato_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_volver_plato_actualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_plato_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver_plato_actualizar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_plato_actualizar.ForeColor = System.Drawing.Color.Red
        Me.btn_volver_plato_actualizar.Image = CType(resources.GetObject("btn_volver_plato_actualizar.Image"), System.Drawing.Image)
        Me.btn_volver_plato_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_plato_actualizar.Location = New System.Drawing.Point(102, 92)
        Me.btn_volver_plato_actualizar.Name = "btn_volver_plato_actualizar"
        Me.btn_volver_plato_actualizar.Size = New System.Drawing.Size(150, 36)
        Me.btn_volver_plato_actualizar.TabIndex = 45
        Me.btn_volver_plato_actualizar.Text = "    VOLVER"
        Me.btn_volver_plato_actualizar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(238, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(288, 22)
        Me.Label3.TabIndex = 53
        Me.Label3.Text = "      ACTUALIZAR MEMBRESIA"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.rb_actualizar_datos_empleados)
        Me.GroupBox2.Location = New System.Drawing.Point(24, 152)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(351, 57)
        Me.GroupBox2.TabIndex = 56
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Opciones "
        '
        'rb_actualizar_datos_empleados
        '
        Me.rb_actualizar_datos_empleados.AutoSize = True
        Me.rb_actualizar_datos_empleados.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_actualizar_datos_empleados.Location = New System.Drawing.Point(103, 19)
        Me.rb_actualizar_datos_empleados.Name = "rb_actualizar_datos_empleados"
        Me.rb_actualizar_datos_empleados.Size = New System.Drawing.Size(133, 23)
        Me.rb_actualizar_datos_empleados.TabIndex = 26
        Me.rb_actualizar_datos_empleados.TabStop = True
        Me.rb_actualizar_datos_empleados.Text = "ACTUALIZAR "
        Me.rb_actualizar_datos_empleados.UseVisualStyleBackColor = True
        '
        'gbo_dato_p_act
        '
        Me.gbo_dato_p_act.Controls.Add(Me.btn_cedula_buscar_act_p)
        Me.gbo_dato_p_act.Controls.Add(Me.txt_cedula_act_p)
        Me.gbo_dato_p_act.Controls.Add(Me.Label1)
        Me.gbo_dato_p_act.Location = New System.Drawing.Point(24, 59)
        Me.gbo_dato_p_act.Name = "gbo_dato_p_act"
        Me.gbo_dato_p_act.Size = New System.Drawing.Size(351, 88)
        Me.gbo_dato_p_act.TabIndex = 55
        Me.gbo_dato_p_act.TabStop = False
        Me.gbo_dato_p_act.Text = "Datos"
        '
        'btn_cedula_buscar_act_p
        '
        Me.btn_cedula_buscar_act_p.BackColor = System.Drawing.Color.White
        Me.btn_cedula_buscar_act_p.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cedula_buscar_act_p.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cedula_buscar_act_p.ForeColor = System.Drawing.Color.Black
        Me.btn_cedula_buscar_act_p.Image = CType(resources.GetObject("btn_cedula_buscar_act_p.Image"), System.Drawing.Image)
        Me.btn_cedula_buscar_act_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cedula_buscar_act_p.Location = New System.Drawing.Point(275, 32)
        Me.btn_cedula_buscar_act_p.Name = "btn_cedula_buscar_act_p"
        Me.btn_cedula_buscar_act_p.Size = New System.Drawing.Size(36, 31)
        Me.btn_cedula_buscar_act_p.TabIndex = 72
        Me.btn_cedula_buscar_act_p.Text = "      "
        Me.btn_cedula_buscar_act_p.UseVisualStyleBackColor = False
        '
        'txt_cedula_act_p
        '
        Me.txt_cedula_act_p.Location = New System.Drawing.Point(106, 39)
        Me.txt_cedula_act_p.MaxLength = 10
        Me.txt_cedula_act_p.Name = "txt_cedula_act_p"
        Me.txt_cedula_act_p.Size = New System.Drawing.Size(146, 20)
        Me.txt_cedula_act_p.TabIndex = 36
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(28, 16)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(60, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Buscar "
        '
        'gbo_categoria_cliente
        '
        Me.gbo_categoria_cliente.Controls.Add(Me.Label20)
        Me.gbo_categoria_cliente.Controls.Add(Me.gbo_membresia_cliente)
        Me.gbo_categoria_cliente.Controls.Add(Me.cbo_categoria_cliente)
        Me.gbo_categoria_cliente.Controls.Add(Me.Label9)
        Me.gbo_categoria_cliente.Location = New System.Drawing.Point(386, 59)
        Me.gbo_categoria_cliente.Name = "gbo_categoria_cliente"
        Me.gbo_categoria_cliente.Size = New System.Drawing.Size(351, 331)
        Me.gbo_categoria_cliente.TabIndex = 28
        Me.gbo_categoria_cliente.TabStop = False
        Me.gbo_categoria_cliente.Text = "Categoria"
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Red
        Me.Label20.Location = New System.Drawing.Point(260, 41)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(15, 20)
        Me.Label20.TabIndex = 40
        Me.Label20.Text = "*"
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
        '
        'txt_valor_pago_cliente
        '
        Me.txt_valor_pago_cliente.Location = New System.Drawing.Point(161, 28)
        Me.txt_valor_pago_cliente.MaxLength = 10
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
        Me.cbo_categoria_cliente.Location = New System.Drawing.Point(103, 42)
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
        Me.Label9.Location = New System.Drawing.Point(24, 42)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Opciones"
        '
        'ActualizarMembresia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 560)
        Me.Controls.Add(Me.gbo_categoria_cliente)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbo_dato_p_act)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_actualizar_)
        Me.Name = "ActualizarMembresia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "ActualizarMembresia"
        CType(Me.dgv_actualizar_, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.gbo_dato_p_act.ResumeLayout(False)
        Me.gbo_dato_p_act.PerformLayout()
        Me.gbo_categoria_cliente.ResumeLayout(False)
        Me.gbo_categoria_cliente.PerformLayout()
        Me.gbo_membresia_cliente.ResumeLayout(False)
        Me.gbo_membresia_cliente.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_actualizar_ As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar_pL As System.Windows.Forms.Button
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents btn_volver_plato_actualizar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_actualizar_datos_empleados As System.Windows.Forms.RadioButton
    Friend WithEvents gbo_dato_p_act As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cedula_buscar_act_p As System.Windows.Forms.Button
    Friend WithEvents txt_cedula_act_p As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents gbo_categoria_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents Label20 As System.Windows.Forms.Label
    Friend WithEvents gbo_membresia_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents txt_fecha_caducidad As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero_ingreso_c As System.Windows.Forms.TextBox
    Friend WithEvents fecha_apertura_ingreso_c As System.Windows.Forms.DateTimePicker
    Friend WithEvents cbo_dias_año_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label27 As System.Windows.Forms.Label
    Friend WithEvents Label24 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha_renovacion_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label23 As System.Windows.Forms.Label
    Friend WithEvents txt_valor_pago_cliente As System.Windows.Forms.TextBox
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents cbo_categoria_cliente As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
End Class
