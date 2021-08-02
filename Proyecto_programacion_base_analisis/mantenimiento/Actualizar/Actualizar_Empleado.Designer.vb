<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Empleado
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar_Empleado))
        Me.gbo_actualizar_empleados_datos = New System.Windows.Forms.GroupBox()
        Me.txt_telefono_empleados = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_direccion_empleados = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btn_volver_actualizaion_empleado = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dgv_empleado_a = New System.Windows.Forms.DataGridView()
        Me.btn_actualizar_empleado = New System.Windows.Forms.Button()
        Me.rb_actualizar_datos_empleados = New System.Windows.Forms.RadioButton()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar_empl = New System.Windows.Forms.Button()
        Me.gbo_dato_p_act = New System.Windows.Forms.GroupBox()
        Me.btn_cedula_buscar_act_p = New System.Windows.Forms.Button()
        Me.txt_cedula_i_actu = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.gbo_actualizar_empleados_datos.SuspendLayout()
        CType(Me.dgv_empleado_a, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.gbo_dato_p_act.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbo_actualizar_empleados_datos
        '
        Me.gbo_actualizar_empleados_datos.Controls.Add(Me.txt_telefono_empleados)
        Me.gbo_actualizar_empleados_datos.Controls.Add(Me.Label4)
        Me.gbo_actualizar_empleados_datos.Controls.Add(Me.txt_direccion_empleados)
        Me.gbo_actualizar_empleados_datos.Controls.Add(Me.Label5)
        Me.gbo_actualizar_empleados_datos.Location = New System.Drawing.Point(34, 259)
        Me.gbo_actualizar_empleados_datos.Name = "gbo_actualizar_empleados_datos"
        Me.gbo_actualizar_empleados_datos.Size = New System.Drawing.Size(652, 62)
        Me.gbo_actualizar_empleados_datos.TabIndex = 16
        Me.gbo_actualizar_empleados_datos.TabStop = False
        Me.gbo_actualizar_empleados_datos.Text = "Datos"
        '
        'txt_telefono_empleados
        '
        Me.txt_telefono_empleados.Location = New System.Drawing.Point(442, 26)
        Me.txt_telefono_empleados.MaxLength = 20
        Me.txt_telefono_empleados.Name = "txt_telefono_empleados"
        Me.txt_telefono_empleados.Size = New System.Drawing.Size(204, 20)
        Me.txt_telefono_empleados.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(27, 25)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "Direccion"
        '
        'txt_direccion_empleados
        '
        Me.txt_direccion_empleados.Location = New System.Drawing.Point(124, 24)
        Me.txt_direccion_empleados.MaxLength = 20
        Me.txt_direccion_empleados.Name = "txt_direccion_empleados"
        Me.txt_direccion_empleados.Size = New System.Drawing.Size(204, 20)
        Me.txt_direccion_empleados.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(345, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(67, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "Telefono"
        '
        'btn_volver_actualizaion_empleado
        '
        Me.btn_volver_actualizaion_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_actualizaion_empleado.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_actualizaion_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver_actualizaion_empleado.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_actualizaion_empleado.ForeColor = System.Drawing.Color.Red
        Me.btn_volver_actualizaion_empleado.Image = CType(resources.GetObject("btn_volver_actualizaion_empleado.Image"), System.Drawing.Image)
        Me.btn_volver_actualizaion_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_actualizaion_empleado.Location = New System.Drawing.Point(27, 131)
        Me.btn_volver_actualizaion_empleado.Name = "btn_volver_actualizaion_empleado"
        Me.btn_volver_actualizaion_empleado.Size = New System.Drawing.Size(158, 42)
        Me.btn_volver_actualizaion_empleado.TabIndex = 22
        Me.btn_volver_actualizaion_empleado.Text = "   VOLVER"
        Me.btn_volver_actualizaion_empleado.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(232, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(284, 22)
        Me.Label3.TabIndex = 17
        Me.Label3.Text = "     ACTUALIZAR EMPLEADOS"
        '
        'dgv_empleado_a
        '
        Me.dgv_empleado_a.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_empleado_a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleado_a.Location = New System.Drawing.Point(12, 327)
        Me.dgv_empleado_a.Name = "dgv_empleado_a"
        Me.dgv_empleado_a.Size = New System.Drawing.Size(707, 145)
        Me.dgv_empleado_a.TabIndex = 23
        '
        'btn_actualizar_empleado
        '
        Me.btn_actualizar_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_actualizar_empleado.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar_empleado.ForeColor = System.Drawing.Color.Red
        Me.btn_actualizar_empleado.Image = CType(resources.GetObject("btn_actualizar_empleado.Image"), System.Drawing.Image)
        Me.btn_actualizar_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar_empleado.Location = New System.Drawing.Point(27, 33)
        Me.btn_actualizar_empleado.Name = "btn_actualizar_empleado"
        Me.btn_actualizar_empleado.Size = New System.Drawing.Size(158, 45)
        Me.btn_actualizar_empleado.TabIndex = 25
        Me.btn_actualizar_empleado.Text = "     ACTUALIZAR"
        Me.btn_actualizar_empleado.UseVisualStyleBackColor = True
        '
        'rb_actualizar_datos_empleados
        '
        Me.rb_actualizar_datos_empleados.AutoSize = True
        Me.rb_actualizar_datos_empleados.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_actualizar_datos_empleados.Location = New System.Drawing.Point(93, 15)
        Me.rb_actualizar_datos_empleados.Name = "rb_actualizar_datos_empleados"
        Me.rb_actualizar_datos_empleados.Size = New System.Drawing.Size(186, 23)
        Me.rb_actualizar_datos_empleados.TabIndex = 26
        Me.rb_actualizar_datos_empleados.TabStop = True
        Me.rb_actualizar_datos_empleados.Text = "ACTUALIZAR DATOS"
        Me.rb_actualizar_datos_empleados.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_actualizar_datos_empleados)
        Me.GroupBox1.Location = New System.Drawing.Point(34, 164)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(370, 57)
        Me.GroupBox1.TabIndex = 29
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones "
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_eliminar_empl)
        Me.GroupBox3.Controls.Add(Me.btn_actualizar_empleado)
        Me.GroupBox3.Controls.Add(Me.btn_volver_actualizaion_empleado)
        Me.GroupBox3.Location = New System.Drawing.Point(489, 61)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(191, 192)
        Me.GroupBox3.TabIndex = 31
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Botones"
        '
        'btn_eliminar_empl
        '
        Me.btn_eliminar_empl.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar_empl.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar_empl.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar_empl.ForeColor = System.Drawing.Color.Red
        Me.btn_eliminar_empl.Image = CType(resources.GetObject("btn_eliminar_empl.Image"), System.Drawing.Image)
        Me.btn_eliminar_empl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar_empl.Location = New System.Drawing.Point(27, 84)
        Me.btn_eliminar_empl.Name = "btn_eliminar_empl"
        Me.btn_eliminar_empl.Size = New System.Drawing.Size(158, 40)
        Me.btn_eliminar_empl.TabIndex = 37
        Me.btn_eliminar_empl.Text = "     ELIMINAR"
        Me.btn_eliminar_empl.UseVisualStyleBackColor = True
        '
        'gbo_dato_p_act
        '
        Me.gbo_dato_p_act.Controls.Add(Me.btn_cedula_buscar_act_p)
        Me.gbo_dato_p_act.Controls.Add(Me.txt_cedula_i_actu)
        Me.gbo_dato_p_act.Controls.Add(Me.Label1)
        Me.gbo_dato_p_act.Location = New System.Drawing.Point(34, 70)
        Me.gbo_dato_p_act.Name = "gbo_dato_p_act"
        Me.gbo_dato_p_act.Size = New System.Drawing.Size(370, 88)
        Me.gbo_dato_p_act.TabIndex = 35
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
        Me.btn_cedula_buscar_act_p.Location = New System.Drawing.Point(275, 35)
        Me.btn_cedula_buscar_act_p.Name = "btn_cedula_buscar_act_p"
        Me.btn_cedula_buscar_act_p.Size = New System.Drawing.Size(36, 31)
        Me.btn_cedula_buscar_act_p.TabIndex = 73
        Me.btn_cedula_buscar_act_p.Text = "      "
        Me.btn_cedula_buscar_act_p.UseVisualStyleBackColor = False
        '
        'txt_cedula_i_actu
        '
        Me.txt_cedula_i_actu.Location = New System.Drawing.Point(124, 42)
        Me.txt_cedula_i_actu.MaxLength = 10
        Me.txt_cedula_i_actu.Name = "txt_cedula_i_actu"
        Me.txt_cedula_i_actu.Size = New System.Drawing.Size(133, 20)
        Me.txt_cedula_i_actu.TabIndex = 34
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(6, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(111, 19)
        Me.Label1.TabIndex = 33
        Me.Label1.Text = "Ingrese Cedula"
        '
        'Actualizar_Empleado
        '
        Me.AcceptButton = Me.btn_actualizar_empleado
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_volver_actualizaion_empleado
        Me.ClientSize = New System.Drawing.Size(749, 484)
        Me.Controls.Add(Me.gbo_dato_p_act)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_empleado_a)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbo_actualizar_empleados_datos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Actualizar_Empleado"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualizar Empleado"
        Me.gbo_actualizar_empleados_datos.ResumeLayout(False)
        Me.gbo_actualizar_empleados_datos.PerformLayout()
        CType(Me.dgv_empleado_a, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.gbo_dato_p_act.ResumeLayout(False)
        Me.gbo_dato_p_act.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbo_actualizar_empleados_datos As System.Windows.Forms.GroupBox
    Friend WithEvents btn_volver_actualizaion_empleado As System.Windows.Forms.Button
    Friend WithEvents txt_telefono_empleados As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_empleados As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents dgv_empleado_a As System.Windows.Forms.DataGridView
    Friend WithEvents btn_actualizar_empleado As System.Windows.Forms.Button
    Friend WithEvents rb_actualizar_datos_empleados As System.Windows.Forms.RadioButton
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents gbo_dato_p_act As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_i_actu As System.Windows.Forms.TextBox
    Friend WithEvents btn_cedula_buscar_act_p As System.Windows.Forms.Button
    Friend WithEvents btn_eliminar_empl As System.Windows.Forms.Button
End Class
