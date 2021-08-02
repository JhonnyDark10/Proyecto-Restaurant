<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualiza_Cuenta_U
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualiza_Cuenta_U))
        Me.gbo_botones_act = New System.Windows.Forms.GroupBox()
        Me.btn_volver = New System.Windows.Forms.Button()
        Me.btn_actualizar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_2 = New System.Windows.Forms.RadioButton()
        Me.rb_1 = New System.Windows.Forms.RadioButton()
        Me.gbo_dato_p_act = New System.Windows.Forms.GroupBox()
        Me.btn_cedula_buscar_act_p = New System.Windows.Forms.Button()
        Me.txt_cedula_act_p = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.dgv_cuenta = New System.Windows.Forms.DataGridView()
        Me.gbo_datos_actualizar = New System.Windows.Forms.GroupBox()
        Me.txt_contraseña = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_usuario = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbo_botones_act.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbo_dato_p_act.SuspendLayout()
        CType(Me.dgv_cuenta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbo_datos_actualizar.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbo_botones_act
        '
        Me.gbo_botones_act.Controls.Add(Me.btn_volver)
        Me.gbo_botones_act.Controls.Add(Me.btn_actualizar)
        Me.gbo_botones_act.Location = New System.Drawing.Point(530, 98)
        Me.gbo_botones_act.Name = "gbo_botones_act"
        Me.gbo_botones_act.Size = New System.Drawing.Size(186, 175)
        Me.gbo_botones_act.TabIndex = 38
        Me.gbo_botones_act.TabStop = False
        Me.gbo_botones_act.Text = "Botones"
        '
        'btn_volver
        '
        Me.btn_volver.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver.ForeColor = System.Drawing.Color.Red
        Me.btn_volver.Image = CType(resources.GetObject("btn_volver.Image"), System.Drawing.Image)
        Me.btn_volver.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver.Location = New System.Drawing.Point(26, 117)
        Me.btn_volver.Name = "btn_volver"
        Me.btn_volver.Size = New System.Drawing.Size(141, 42)
        Me.btn_volver.TabIndex = 29
        Me.btn_volver.Text = "   VOLVER"
        Me.btn_volver.UseVisualStyleBackColor = True
        '
        'btn_actualizar
        '
        Me.btn_actualizar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_actualizar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar.ForeColor = System.Drawing.Color.Red
        Me.btn_actualizar.Image = CType(resources.GetObject("btn_actualizar.Image"), System.Drawing.Image)
        Me.btn_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar.Location = New System.Drawing.Point(26, 54)
        Me.btn_actualizar.Name = "btn_actualizar"
        Me.btn_actualizar.Size = New System.Drawing.Size(142, 40)
        Me.btn_actualizar.TabIndex = 32
        Me.btn_actualizar.Text = "     ACTUALIZAR"
        Me.btn_actualizar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_2)
        Me.GroupBox1.Controls.Add(Me.rb_1)
        Me.GroupBox1.Location = New System.Drawing.Point(25, 159)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 57)
        Me.GroupBox1.TabIndex = 42
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones "
        '
        'rb_2
        '
        Me.rb_2.AutoSize = True
        Me.rb_2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_2.Location = New System.Drawing.Point(250, 19)
        Me.rb_2.Name = "rb_2"
        Me.rb_2.Size = New System.Drawing.Size(137, 23)
        Me.rb_2.TabIndex = 44
        Me.rb_2.TabStop = True
        Me.rb_2.Text = "CONTRASEÑA"
        Me.rb_2.UseVisualStyleBackColor = True
        '
        'rb_1
        '
        Me.rb_1.AutoSize = True
        Me.rb_1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_1.Location = New System.Drawing.Point(19, 19)
        Me.rb_1.Name = "rb_1"
        Me.rb_1.Size = New System.Drawing.Size(214, 23)
        Me.rb_1.TabIndex = 26
        Me.rb_1.TabStop = True
        Me.rb_1.Text = "USUARIO-CONTRASEÑA"
        Me.rb_1.UseVisualStyleBackColor = True
        '
        'gbo_dato_p_act
        '
        Me.gbo_dato_p_act.Controls.Add(Me.btn_cedula_buscar_act_p)
        Me.gbo_dato_p_act.Controls.Add(Me.txt_cedula_act_p)
        Me.gbo_dato_p_act.Controls.Add(Me.Label1)
        Me.gbo_dato_p_act.Location = New System.Drawing.Point(25, 59)
        Me.gbo_dato_p_act.Name = "gbo_dato_p_act"
        Me.gbo_dato_p_act.Size = New System.Drawing.Size(450, 88)
        Me.gbo_dato_p_act.TabIndex = 41
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
        Me.txt_cedula_act_p.MaxLength = 20
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
        'dgv_cuenta
        '
        Me.dgv_cuenta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_cuenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_cuenta.Location = New System.Drawing.Point(12, 333)
        Me.dgv_cuenta.Name = "dgv_cuenta"
        Me.dgv_cuenta.Size = New System.Drawing.Size(725, 116)
        Me.dgv_cuenta.TabIndex = 40
        '
        'gbo_datos_actualizar
        '
        Me.gbo_datos_actualizar.Controls.Add(Me.txt_contraseña)
        Me.gbo_datos_actualizar.Controls.Add(Me.Label4)
        Me.gbo_datos_actualizar.Controls.Add(Me.txt_usuario)
        Me.gbo_datos_actualizar.Controls.Add(Me.Label5)
        Me.gbo_datos_actualizar.Location = New System.Drawing.Point(25, 222)
        Me.gbo_datos_actualizar.Name = "gbo_datos_actualizar"
        Me.gbo_datos_actualizar.Size = New System.Drawing.Size(450, 105)
        Me.gbo_datos_actualizar.TabIndex = 39
        Me.gbo_datos_actualizar.TabStop = False
        Me.gbo_datos_actualizar.Text = "Actualizar Datos"
        '
        'txt_contraseña
        '
        Me.txt_contraseña.Location = New System.Drawing.Point(187, 62)
        Me.txt_contraseña.MaxLength = 20
        Me.txt_contraseña.Name = "txt_contraseña"
        Me.txt_contraseña.Size = New System.Drawing.Size(196, 20)
        Me.txt_contraseña.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(62, 21)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(81, 19)
        Me.Label4.TabIndex = 16
        Me.Label4.Text = "USUARIO"
        '
        'txt_usuario
        '
        Me.txt_usuario.Location = New System.Drawing.Point(187, 20)
        Me.txt_usuario.MaxLength = 20
        Me.txt_usuario.Name = "txt_usuario"
        Me.txt_usuario.Size = New System.Drawing.Size(196, 20)
        Me.txt_usuario.TabIndex = 18
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(62, 61)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(119, 19)
        Me.Label5.TabIndex = 17
        Me.Label5.Text = "CONTRASEÑA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(225, 22)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(337, 22)
        Me.Label3.TabIndex = 43
        Me.Label3.Text = "      ACTUALIZAR CUENTA USUARIO"
        '
        'Actualiza_Cuenta_U
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(749, 461)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_dato_p_act)
        Me.Controls.Add(Me.dgv_cuenta)
        Me.Controls.Add(Me.gbo_datos_actualizar)
        Me.Controls.Add(Me.gbo_botones_act)
        Me.Name = "Actualiza_Cuenta_U"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Actualiza_Cuenta_U"
        Me.gbo_botones_act.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbo_dato_p_act.ResumeLayout(False)
        Me.gbo_dato_p_act.PerformLayout()
        CType(Me.dgv_cuenta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbo_datos_actualizar.ResumeLayout(False)
        Me.gbo_datos_actualizar.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbo_botones_act As System.Windows.Forms.GroupBox
    Friend WithEvents btn_volver As System.Windows.Forms.Button
    Friend WithEvents btn_actualizar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_1 As System.Windows.Forms.RadioButton
    Friend WithEvents gbo_dato_p_act As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cedula_buscar_act_p As System.Windows.Forms.Button
    Friend WithEvents txt_cedula_act_p As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents dgv_cuenta As System.Windows.Forms.DataGridView
    Friend WithEvents gbo_datos_actualizar As System.Windows.Forms.GroupBox
    Friend WithEvents txt_contraseña As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents rb_2 As System.Windows.Forms.RadioButton
End Class
