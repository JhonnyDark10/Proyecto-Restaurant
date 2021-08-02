<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar_Cliente))
        Me.btn_actualizar_ = New System.Windows.Forms.Button()
        Me.dgw_actualizar_cliente = New System.Windows.Forms.DataGridView()
        Me.btn_volver_ = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbo_datos_actualizar_cliente = New System.Windows.Forms.GroupBox()
        Me.txt_telefono = New System.Windows.Forms.TextBox()
        Me.txt_email_ = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_direccion = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rb_actualizar_d = New System.Windows.Forms.RadioButton()
        Me.gbo_dato_p_act = New System.Windows.Forms.GroupBox()
        Me.btn_cedula_buscar_act_p = New System.Windows.Forms.Button()
        Me.txt_cedula = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.dgw_actualizar_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbo_datos_actualizar_cliente.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.gbo_dato_p_act.SuspendLayout()
        Me.SuspendLayout()
        '
        'btn_actualizar_
        '
        Me.btn_actualizar_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar_.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_actualizar_.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar_.ForeColor = System.Drawing.Color.Red
        Me.btn_actualizar_.Image = CType(resources.GetObject("btn_actualizar_.Image"), System.Drawing.Image)
        Me.btn_actualizar_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar_.Location = New System.Drawing.Point(25, 51)
        Me.btn_actualizar_.Name = "btn_actualizar_"
        Me.btn_actualizar_.Size = New System.Drawing.Size(152, 42)
        Me.btn_actualizar_.TabIndex = 33
        Me.btn_actualizar_.Text = "     ACTUALIZAR"
        Me.btn_actualizar_.UseVisualStyleBackColor = True
        '
        'dgw_actualizar_cliente
        '
        Me.dgw_actualizar_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgw_actualizar_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgw_actualizar_cliente.Location = New System.Drawing.Point(12, 353)
        Me.dgw_actualizar_cliente.Name = "dgw_actualizar_cliente"
        Me.dgw_actualizar_cliente.Size = New System.Drawing.Size(717, 96)
        Me.dgw_actualizar_cliente.TabIndex = 31
        '
        'btn_volver_
        '
        Me.btn_volver_.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver_.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_.ForeColor = System.Drawing.Color.Red
        Me.btn_volver_.Image = CType(resources.GetObject("btn_volver_.Image"), System.Drawing.Image)
        Me.btn_volver_.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_.Location = New System.Drawing.Point(25, 153)
        Me.btn_volver_.Name = "btn_volver_"
        Me.btn_volver_.Size = New System.Drawing.Size(152, 37)
        Me.btn_volver_.TabIndex = 30
        Me.btn_volver_.Text = "   VOLVER"
        Me.btn_volver_.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(236, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(265, 22)
        Me.Label3.TabIndex = 29
        Me.Label3.Text = "      ACTUALIZAR CLIENTES"
        '
        'gbo_datos_actualizar_cliente
        '
        Me.gbo_datos_actualizar_cliente.Controls.Add(Me.txt_telefono)
        Me.gbo_datos_actualizar_cliente.Controls.Add(Me.txt_email_)
        Me.gbo_datos_actualizar_cliente.Controls.Add(Me.Label6)
        Me.gbo_datos_actualizar_cliente.Controls.Add(Me.txt_direccion)
        Me.gbo_datos_actualizar_cliente.Controls.Add(Me.Label7)
        Me.gbo_datos_actualizar_cliente.Controls.Add(Me.Label8)
        Me.gbo_datos_actualizar_cliente.Location = New System.Drawing.Point(12, 216)
        Me.gbo_datos_actualizar_cliente.Name = "gbo_datos_actualizar_cliente"
        Me.gbo_datos_actualizar_cliente.Size = New System.Drawing.Size(450, 131)
        Me.gbo_datos_actualizar_cliente.TabIndex = 34
        Me.gbo_datos_actualizar_cliente.TabStop = False
        Me.gbo_datos_actualizar_cliente.Text = "Datos"
        '
        'txt_telefono
        '
        Me.txt_telefono.Location = New System.Drawing.Point(198, 101)
        Me.txt_telefono.MaxLength = 10
        Me.txt_telefono.Name = "txt_telefono"
        Me.txt_telefono.Size = New System.Drawing.Size(207, 20)
        Me.txt_telefono.TabIndex = 24
        '
        'txt_email_
        '
        Me.txt_email_.Location = New System.Drawing.Point(198, 61)
        Me.txt_email_.MaxLength = 20
        Me.txt_email_.Name = "txt_email_"
        Me.txt_email_.Size = New System.Drawing.Size(207, 20)
        Me.txt_email_.TabIndex = 23
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(8, 23)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(158, 19)
        Me.Label6.TabIndex = 15
        Me.Label6.Text = "Direccion Domiciliaria"
        '
        'txt_direccion
        '
        Me.txt_direccion.Location = New System.Drawing.Point(198, 22)
        Me.txt_direccion.MaxLength = 20
        Me.txt_direccion.Name = "txt_direccion"
        Me.txt_direccion.Size = New System.Drawing.Size(207, 20)
        Me.txt_direccion.TabIndex = 22
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(17, 61)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(47, 19)
        Me.Label7.TabIndex = 16
        Me.Label7.Text = "Email"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(17, 102)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(67, 19)
        Me.Label8.TabIndex = 17
        Me.Label8.Text = "Telefono"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btn_eliminar)
        Me.GroupBox2.Controls.Add(Me.btn_actualizar_)
        Me.GroupBox2.Controls.Add(Me.btn_volver_)
        Me.GroupBox2.Location = New System.Drawing.Point(529, 80)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(200, 225)
        Me.GroupBox2.TabIndex = 37
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Botones"
        '
        'btn_eliminar
        '
        Me.btn_eliminar.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_eliminar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_eliminar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_eliminar.ForeColor = System.Drawing.Color.Red
        Me.btn_eliminar.Image = CType(resources.GetObject("btn_eliminar.Image"), System.Drawing.Image)
        Me.btn_eliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_eliminar.Location = New System.Drawing.Point(25, 102)
        Me.btn_eliminar.Name = "btn_eliminar"
        Me.btn_eliminar.Size = New System.Drawing.Size(152, 40)
        Me.btn_eliminar.TabIndex = 38
        Me.btn_eliminar.Text = "     ELIMINAR"
        Me.btn_eliminar.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rb_actualizar_d)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 155)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(450, 57)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Opciones "
        '
        'rb_actualizar_d
        '
        Me.rb_actualizar_d.AutoSize = True
        Me.rb_actualizar_d.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_actualizar_d.Location = New System.Drawing.Point(125, 18)
        Me.rb_actualizar_d.Name = "rb_actualizar_d"
        Me.rb_actualizar_d.Size = New System.Drawing.Size(186, 23)
        Me.rb_actualizar_d.TabIndex = 26
        Me.rb_actualizar_d.TabStop = True
        Me.rb_actualizar_d.Text = "ACTUALIZAR DATOS"
        Me.rb_actualizar_d.UseVisualStyleBackColor = True
        '
        'gbo_dato_p_act
        '
        Me.gbo_dato_p_act.Controls.Add(Me.btn_cedula_buscar_act_p)
        Me.gbo_dato_p_act.Controls.Add(Me.txt_cedula)
        Me.gbo_dato_p_act.Controls.Add(Me.Label1)
        Me.gbo_dato_p_act.Location = New System.Drawing.Point(12, 55)
        Me.gbo_dato_p_act.Name = "gbo_dato_p_act"
        Me.gbo_dato_p_act.Size = New System.Drawing.Size(450, 88)
        Me.gbo_dato_p_act.TabIndex = 38
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
        'txt_cedula
        '
        Me.txt_cedula.Location = New System.Drawing.Point(106, 39)
        Me.txt_cedula.MaxLength = 10
        Me.txt_cedula.Name = "txt_cedula"
        Me.txt_cedula.Size = New System.Drawing.Size(146, 20)
        Me.txt_cedula.TabIndex = 36
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
        'Actualizar_Cliente
        '
        Me.AcceptButton = Me.btn_actualizar_
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_volver_
        Me.ClientSize = New System.Drawing.Size(749, 461)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_dato_p_act)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbo_datos_actualizar_cliente)
        Me.Controls.Add(Me.dgw_actualizar_cliente)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Actualizar_Cliente"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgw_actualizar_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbo_datos_actualizar_cliente.ResumeLayout(False)
        Me.gbo_datos_actualizar_cliente.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.gbo_dato_p_act.ResumeLayout(False)
        Me.gbo_dato_p_act.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_actualizar_ As System.Windows.Forms.Button
    Friend WithEvents dgw_actualizar_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents btn_volver_ As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbo_datos_actualizar_cliente As System.Windows.Forms.GroupBox
    Friend WithEvents txt_telefono As System.Windows.Forms.TextBox
    Friend WithEvents txt_email_ As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_actualizar_d As System.Windows.Forms.RadioButton
    Friend WithEvents gbo_dato_p_act As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cedula_buscar_act_p As System.Windows.Forms.Button
    Friend WithEvents txt_cedula As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
