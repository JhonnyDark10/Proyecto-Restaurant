<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Proveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar_Proveedores))
        Me.btn_actualizar_proveedores = New System.Windows.Forms.Button()
        Me.dgv_proveedor = New System.Windows.Forms.DataGridView()
        Me.btn_volver_proveedores_actualizar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbo_datos_actualizar_proveedores = New System.Windows.Forms.GroupBox()
        Me.txt_telefono_proveedores_a = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_direccion_proveedores_a = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.gbo_dato_p_act = New System.Windows.Forms.GroupBox()
        Me.btn_cedula_buscar_act_p = New System.Windows.Forms.Button()
        Me.txt_cedula_act_p = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbo_botones_act = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar_prov = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_actualizar_datos_empleados = New System.Windows.Forms.RadioButton()
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbo_datos_actualizar_proveedores.SuspendLayout()
        Me.gbo_dato_p_act.SuspendLayout()
        Me.gbo_botones_act.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_actualizar_proveedores
        '
        Me.btn_actualizar_proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar_proveedores.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_actualizar_proveedores.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar_proveedores.ForeColor = System.Drawing.Color.Red
        Me.btn_actualizar_proveedores.Image = CType(resources.GetObject("btn_actualizar_proveedores.Image"), System.Drawing.Image)
        Me.btn_actualizar_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar_proveedores.Location = New System.Drawing.Point(25, 21)
        Me.btn_actualizar_proveedores.Name = "btn_actualizar_proveedores"
        Me.btn_actualizar_proveedores.Size = New System.Drawing.Size(142, 40)
        Me.btn_actualizar_proveedores.TabIndex = 32
        Me.btn_actualizar_proveedores.Text = "     ACTUALIZAR"
        Me.btn_actualizar_proveedores.UseVisualStyleBackColor = True
        '
        'dgv_proveedor
        '
        Me.dgv_proveedor.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_proveedor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_proveedor.Location = New System.Drawing.Point(12, 333)
        Me.dgv_proveedor.Name = "dgv_proveedor"
        Me.dgv_proveedor.Size = New System.Drawing.Size(725, 116)
        Me.dgv_proveedor.TabIndex = 30
        '
        'btn_volver_proveedores_actualizar
        '
        Me.btn_volver_proveedores_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_proveedores_actualizar.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_proveedores_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver_proveedores_actualizar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_proveedores_actualizar.ForeColor = System.Drawing.Color.Red
        Me.btn_volver_proveedores_actualizar.Image = CType(resources.GetObject("btn_volver_proveedores_actualizar.Image"), System.Drawing.Image)
        Me.btn_volver_proveedores_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_proveedores_actualizar.Location = New System.Drawing.Point(26, 117)
        Me.btn_volver_proveedores_actualizar.Name = "btn_volver_proveedores_actualizar"
        Me.btn_volver_proveedores_actualizar.Size = New System.Drawing.Size(141, 42)
        Me.btn_volver_proveedores_actualizar.TabIndex = 29
        Me.btn_volver_proveedores_actualizar.Text = "   VOLVER"
        Me.btn_volver_proveedores_actualizar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(222, 24)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(315, 22)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "      ACTUALIZAR PROVEEDORES"
        '
        'gbo_datos_actualizar_proveedores
        '
        Me.gbo_datos_actualizar_proveedores.Controls.Add(Me.txt_telefono_proveedores_a)
        Me.gbo_datos_actualizar_proveedores.Controls.Add(Me.Label4)
        Me.gbo_datos_actualizar_proveedores.Controls.Add(Me.txt_direccion_proveedores_a)
        Me.gbo_datos_actualizar_proveedores.Controls.Add(Me.Label5)
        Me.gbo_datos_actualizar_proveedores.Location = New System.Drawing.Point(25, 222)
        Me.gbo_datos_actualizar_proveedores.Name = "gbo_datos_actualizar_proveedores"
        Me.gbo_datos_actualizar_proveedores.Size = New System.Drawing.Size(450, 105)
        Me.gbo_datos_actualizar_proveedores.TabIndex = 27
        Me.gbo_datos_actualizar_proveedores.TabStop = False
        Me.gbo_datos_actualizar_proveedores.Text = "Actualizar Datos"
        '
        'txt_telefono_proveedores_a
        '
        Me.txt_telefono_proveedores_a.Location = New System.Drawing.Point(187, 62)
        Me.txt_telefono_proveedores_a.MaxLength = 20
        Me.txt_telefono_proveedores_a.Name = "txt_telefono_proveedores_a"
        Me.txt_telefono_proveedores_a.Size = New System.Drawing.Size(196, 20)
        Me.txt_telefono_proveedores_a.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(93, 20)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Direccion"
        '
        'txt_direccion_proveedores_a
        '
        Me.txt_direccion_proveedores_a.Location = New System.Drawing.Point(187, 20)
        Me.txt_direccion_proveedores_a.MaxLength = 20
        Me.txt_direccion_proveedores_a.Name = "txt_direccion_proveedores_a"
        Me.txt_direccion_proveedores_a.Size = New System.Drawing.Size(196, 20)
        Me.txt_direccion_proveedores_a.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(93, 63)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Telefono"
        '
        'gbo_dato_p_act
        '
        Me.gbo_dato_p_act.Controls.Add(Me.btn_cedula_buscar_act_p)
        Me.gbo_dato_p_act.Controls.Add(Me.txt_cedula_act_p)
        Me.gbo_dato_p_act.Controls.Add(Me.Label1)
        Me.gbo_dato_p_act.Location = New System.Drawing.Point(25, 59)
        Me.gbo_dato_p_act.Name = "gbo_dato_p_act"
        Me.gbo_dato_p_act.Size = New System.Drawing.Size(450, 88)
        Me.gbo_dato_p_act.TabIndex = 34
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
        'gbo_botones_act
        '
        Me.gbo_botones_act.Controls.Add(Me.btn_eliminar_prov)
        Me.gbo_botones_act.Controls.Add(Me.btn_volver_proveedores_actualizar)
        Me.gbo_botones_act.Controls.Add(Me.btn_actualizar_proveedores)
        Me.gbo_botones_act.Location = New System.Drawing.Point(527, 98)
        Me.gbo_botones_act.Name = "gbo_botones_act"
        Me.gbo_botones_act.Size = New System.Drawing.Size(186, 175)
        Me.gbo_botones_act.TabIndex = 35
        Me.gbo_botones_act.TabStop = False
        Me.gbo_botones_act.Text = "Botones"
        '
        'btn_eliminar_prov
        '
        Me.btn_eliminar_prov.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar_prov.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar_prov.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_prov.ForeColor = System.Drawing.Color.Red
        Me.btn_eliminar_prov.Image = CType(resources.GetObject("btn_eliminar_prov.Image"), System.Drawing.Image)
        Me.btn_eliminar_prov.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar_prov.Location = New System.Drawing.Point(25, 69)
        Me.btn_eliminar_prov.Name = "btn_eliminar_prov"
        Me.btn_eliminar_prov.Size = New System.Drawing.Size(142, 40)
        Me.btn_eliminar_prov.TabIndex = 36
        Me.btn_eliminar_prov.Text = "     ELIMINAR"
        Me.btn_eliminar_prov.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_actualizar_datos_empleados)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 57)
        Me.GroupBox1.TabIndex = 36
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones "
        '
        'rb_actualizar_datos_empleados
        '
        Me.rb_actualizar_datos_empleados.AutoSize = True
        Me.rb_actualizar_datos_empleados.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_actualizar_datos_empleados.Location = New System.Drawing.Point(125, 18)
        Me.rb_actualizar_datos_empleados.Name = "rb_actualizar_datos_empleados"
        Me.rb_actualizar_datos_empleados.Size = New System.Drawing.Size(186, 23)
        Me.rb_actualizar_datos_empleados.TabIndex = 26
        Me.rb_actualizar_datos_empleados.TabStop = True
        Me.rb_actualizar_datos_empleados.Text = "ACTUALIZAR DATOS"
        Me.rb_actualizar_datos_empleados.UseVisualStyleBackColor = True
        '
        'Actualizar_Proveedores
        '
        Me.AcceptButton = Me.btn_actualizar_proveedores
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_volver_proveedores_actualizar
        Me.ClientSize = New System.Drawing.Size(749, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_botones_act)
        Me.Controls.Add(Me.gbo_dato_p_act)
        Me.Controls.Add(Me.dgv_proveedor)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbo_datos_actualizar_proveedores)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Actualizar_Proveedores"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv_proveedor, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbo_datos_actualizar_proveedores.ResumeLayout(False)
        Me.gbo_datos_actualizar_proveedores.PerformLayout()
        Me.gbo_dato_p_act.ResumeLayout(False)
        Me.gbo_dato_p_act.PerformLayout()
        Me.gbo_botones_act.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_actualizar_proveedores As System.Windows.Forms.Button
    Friend WithEvents dgv_proveedor As System.Windows.Forms.DataGridView
    Friend WithEvents btn_volver_proveedores_actualizar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbo_datos_actualizar_proveedores As System.Windows.Forms.GroupBox
    Friend WithEvents txt_telefono_proveedores_a As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_proveedores_a As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents gbo_dato_p_act As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_botones_act As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar_prov As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_act_p As System.Windows.Forms.TextBox
    Friend WithEvents btn_cedula_buscar_act_p As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_actualizar_datos_empleados As System.Windows.Forms.RadioButton
End Class
