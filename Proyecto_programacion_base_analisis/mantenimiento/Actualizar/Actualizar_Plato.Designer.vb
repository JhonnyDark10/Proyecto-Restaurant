<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Actualizar_Plato
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Actualizar_Plato))
        Me.btn_volver_plato_actualizar = New System.Windows.Forms.Button()
        Me.btn_guardar_plato_actualizar = New System.Windows.Forms.Button()
        Me.gbo_actualizar_platos = New System.Windows.Forms.GroupBox()
        Me.cbo_platos_actualizar_categ = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbo_actualizar_platos_datos = New System.Windows.Forms.GroupBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_precio_platos_a = New System.Windows.Forms.TextBox()
        Me.txt_nombre_platos_a = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btn_cargar_foto_ingreso_plato = New System.Windows.Forms.Button()
        Me.dgv_actualizar_platos = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_eliminar_pL = New System.Windows.Forms.Button()
        Me.dgv_llenar_tipo_platos = New System.Windows.Forms.DataGridView()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.txt_codigo = New System.Windows.Forms.TextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rb_actualizar_datos_empleados = New System.Windows.Forms.RadioButton()
        Me.gbo_actualizar_platos.SuspendLayout()
        Me.gbo_actualizar_platos_datos.SuspendLayout()
        CType(Me.dgv_actualizar_platos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dgv_llenar_tipo_platos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox2.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
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
        Me.btn_volver_plato_actualizar.Location = New System.Drawing.Point(11, 113)
        Me.btn_volver_plato_actualizar.Name = "btn_volver_plato_actualizar"
        Me.btn_volver_plato_actualizar.Size = New System.Drawing.Size(150, 36)
        Me.btn_volver_plato_actualizar.TabIndex = 45
        Me.btn_volver_plato_actualizar.Text = "    VOLVER"
        Me.btn_volver_plato_actualizar.UseVisualStyleBackColor = True
        '
        'btn_guardar_plato_actualizar
        '
        Me.btn_guardar_plato_actualizar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_guardar_plato_actualizar.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar_plato_actualizar.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_plato_actualizar.ForeColor = System.Drawing.Color.Red
        Me.btn_guardar_plato_actualizar.Image = CType(resources.GetObject("btn_guardar_plato_actualizar.Image"), System.Drawing.Image)
        Me.btn_guardar_plato_actualizar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar_plato_actualizar.Location = New System.Drawing.Point(14, 25)
        Me.btn_guardar_plato_actualizar.Name = "btn_guardar_plato_actualizar"
        Me.btn_guardar_plato_actualizar.Size = New System.Drawing.Size(147, 36)
        Me.btn_guardar_plato_actualizar.TabIndex = 44
        Me.btn_guardar_plato_actualizar.Text = "    ACTUALIZAR"
        Me.btn_guardar_plato_actualizar.UseVisualStyleBackColor = True
        '
        'gbo_actualizar_platos
        '
        Me.gbo_actualizar_platos.Controls.Add(Me.cbo_platos_actualizar_categ)
        Me.gbo_actualizar_platos.Controls.Add(Me.Label9)
        Me.gbo_actualizar_platos.Location = New System.Drawing.Point(12, 64)
        Me.gbo_actualizar_platos.Name = "gbo_actualizar_platos"
        Me.gbo_actualizar_platos.Size = New System.Drawing.Size(301, 54)
        Me.gbo_actualizar_platos.TabIndex = 40
        Me.gbo_actualizar_platos.TabStop = False
        Me.gbo_actualizar_platos.Text = "Categoria"
        '
        'cbo_platos_actualizar_categ
        '
        Me.cbo_platos_actualizar_categ.DisplayMember = "DESCRIPCION"
        Me.cbo_platos_actualizar_categ.FormattingEnabled = True
        Me.cbo_platos_actualizar_categ.Items.AddRange(New Object() {"Entrada", "Primero", "Segundo", "Postre", "Bebida"})
        Me.cbo_platos_actualizar_categ.Location = New System.Drawing.Point(116, 19)
        Me.cbo_platos_actualizar_categ.Name = "cbo_platos_actualizar_categ"
        Me.cbo_platos_actualizar_categ.Size = New System.Drawing.Size(181, 21)
        Me.cbo_platos_actualizar_categ.TabIndex = 19
        Me.cbo_platos_actualizar_categ.ValueMember = "ID_CATEGORIA_PLATOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(17, 18)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Opciones"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(273, 11)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(253, 22)
        Me.Label3.TabIndex = 39
        Me.Label3.Text = "        ACTUALIZAR PLATOS"
        '
        'gbo_actualizar_platos_datos
        '
        Me.gbo_actualizar_platos_datos.Controls.Add(Me.Label1)
        Me.gbo_actualizar_platos_datos.Controls.Add(Me.Label2)
        Me.gbo_actualizar_platos_datos.Controls.Add(Me.txt_precio_platos_a)
        Me.gbo_actualizar_platos_datos.Controls.Add(Me.txt_nombre_platos_a)
        Me.gbo_actualizar_platos_datos.Location = New System.Drawing.Point(273, 243)
        Me.gbo_actualizar_platos_datos.Name = "gbo_actualizar_platos_datos"
        Me.gbo_actualizar_platos_datos.Size = New System.Drawing.Size(269, 104)
        Me.gbo_actualizar_platos_datos.TabIndex = 38
        Me.gbo_actualizar_platos_datos.TabStop = False
        Me.gbo_actualizar_platos_datos.Text = "Datos Actualizar"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(25, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(67, 19)
        Me.Label1.TabIndex = 12
        Me.Label1.Text = "Nombre "
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(25, 74)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Precio"
        '
        'txt_precio_platos_a
        '
        Me.txt_precio_platos_a.Location = New System.Drawing.Point(97, 74)
        Me.txt_precio_platos_a.MaxLength = 10
        Me.txt_precio_platos_a.Name = "txt_precio_platos_a"
        Me.txt_precio_platos_a.Size = New System.Drawing.Size(116, 20)
        Me.txt_precio_platos_a.TabIndex = 20
        '
        'txt_nombre_platos_a
        '
        Me.txt_nombre_platos_a.Location = New System.Drawing.Point(97, 30)
        Me.txt_nombre_platos_a.MaxLength = 20
        Me.txt_nombre_platos_a.Name = "txt_nombre_platos_a"
        Me.txt_nombre_platos_a.Size = New System.Drawing.Size(160, 20)
        Me.txt_nombre_platos_a.TabIndex = 19
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(561, 310)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(39, 19)
        Me.Label4.TabIndex = 55
        Me.Label4.Text = "Foto"
        Me.Label4.Visible = False
        '
        'btn_cargar_foto_ingreso_plato
        '
        Me.btn_cargar_foto_ingreso_plato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cargar_foto_ingreso_plato.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cargar_foto_ingreso_plato.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargar_foto_ingreso_plato.Image = CType(resources.GetObject("btn_cargar_foto_ingreso_plato.Image"), System.Drawing.Image)
        Me.btn_cargar_foto_ingreso_plato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cargar_foto_ingreso_plato.Location = New System.Drawing.Point(612, 301)
        Me.btn_cargar_foto_ingreso_plato.Name = "btn_cargar_foto_ingreso_plato"
        Me.btn_cargar_foto_ingreso_plato.Size = New System.Drawing.Size(125, 36)
        Me.btn_cargar_foto_ingreso_plato.TabIndex = 54
        Me.btn_cargar_foto_ingreso_plato.Text = "    CARGAR"
        Me.btn_cargar_foto_ingreso_plato.UseVisualStyleBackColor = True
        Me.btn_cargar_foto_ingreso_plato.Visible = False
        '
        'dgv_actualizar_platos
        '
        Me.dgv_actualizar_platos.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_actualizar_platos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_actualizar_platos.Location = New System.Drawing.Point(56, 362)
        Me.dgv_actualizar_platos.Name = "dgv_actualizar_platos"
        Me.dgv_actualizar_platos.Size = New System.Drawing.Size(486, 110)
        Me.dgv_actualizar_platos.TabIndex = 49
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_eliminar_pL)
        Me.GroupBox1.Controls.Add(Me.btn_guardar_plato_actualizar)
        Me.GroupBox1.Controls.Add(Me.btn_volver_plato_actualizar)
        Me.GroupBox1.Location = New System.Drawing.Point(565, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(174, 175)
        Me.GroupBox1.TabIndex = 51
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
        Me.btn_eliminar_pL.Location = New System.Drawing.Point(14, 67)
        Me.btn_eliminar_pL.Name = "btn_eliminar_pL"
        Me.btn_eliminar_pL.Size = New System.Drawing.Size(147, 40)
        Me.btn_eliminar_pL.TabIndex = 52
        Me.btn_eliminar_pL.Text = "     ELIMINAR"
        Me.btn_eliminar_pL.UseVisualStyleBackColor = True
        '
        'dgv_llenar_tipo_platos
        '
        Me.dgv_llenar_tipo_platos.BackgroundColor = System.Drawing.Color.White
        Me.dgv_llenar_tipo_platos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_llenar_tipo_platos.Location = New System.Drawing.Point(12, 134)
        Me.dgv_llenar_tipo_platos.Name = "dgv_llenar_tipo_platos"
        Me.dgv_llenar_tipo_platos.Size = New System.Drawing.Size(244, 213)
        Me.dgv_llenar_tipo_platos.TabIndex = 52
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.txt_codigo)
        Me.GroupBox2.Location = New System.Drawing.Point(347, 64)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(91, 70)
        Me.GroupBox2.TabIndex = 53
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Digite Codigo"
        '
        'txt_codigo
        '
        Me.txt_codigo.Location = New System.Drawing.Point(23, 33)
        Me.txt_codigo.MaxLength = 5
        Me.txt_codigo.Name = "txt_codigo"
        Me.txt_codigo.Size = New System.Drawing.Size(60, 20)
        Me.txt_codigo.TabIndex = 19
        '
        'PictureBox1
        '
        Me.PictureBox1.Location = New System.Drawing.Point(633, 343)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 129)
        Me.PictureBox1.TabIndex = 54
        Me.PictureBox1.TabStop = False
        Me.PictureBox1.Visible = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rb_actualizar_datos_empleados)
        Me.GroupBox3.Location = New System.Drawing.Point(273, 159)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(269, 57)
        Me.GroupBox3.TabIndex = 56
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Opciones "
        '
        'rb_actualizar_datos_empleados
        '
        Me.rb_actualizar_datos_empleados.AutoSize = True
        Me.rb_actualizar_datos_empleados.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.rb_actualizar_datos_empleados.Location = New System.Drawing.Point(48, 19)
        Me.rb_actualizar_datos_empleados.Name = "rb_actualizar_datos_empleados"
        Me.rb_actualizar_datos_empleados.Size = New System.Drawing.Size(186, 23)
        Me.rb_actualizar_datos_empleados.TabIndex = 26
        Me.rb_actualizar_datos_empleados.TabStop = True
        Me.rb_actualizar_datos_empleados.Text = "ACTUALIZAR DATOS"
        Me.rb_actualizar_datos_empleados.UseVisualStyleBackColor = True
        '
        'Actualizar_Plato
        '
        Me.AcceptButton = Me.btn_guardar_plato_actualizar
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.btn_volver_plato_actualizar
        Me.ClientSize = New System.Drawing.Size(749, 484)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.btn_cargar_foto_ingreso_plato)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.gbo_actualizar_platos_datos)
        Me.Controls.Add(Me.dgv_llenar_tipo_platos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_actualizar_platos)
        Me.Controls.Add(Me.gbo_actualizar_platos)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Actualizar_Plato"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbo_actualizar_platos.ResumeLayout(False)
        Me.gbo_actualizar_platos.PerformLayout()
        Me.gbo_actualizar_platos_datos.ResumeLayout(False)
        Me.gbo_actualizar_platos_datos.PerformLayout()
        CType(Me.dgv_actualizar_platos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dgv_llenar_tipo_platos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btn_volver_plato_actualizar As System.Windows.Forms.Button
    Friend WithEvents btn_guardar_plato_actualizar As System.Windows.Forms.Button
    Friend WithEvents gbo_actualizar_platos As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_platos_actualizar_categ As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbo_actualizar_platos_datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_platos_a As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_platos_a As System.Windows.Forms.TextBox
    Friend WithEvents dgv_actualizar_platos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_eliminar_pL As System.Windows.Forms.Button
    Friend WithEvents dgv_llenar_tipo_platos As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents txt_codigo As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents btn_cargar_foto_ingreso_plato As System.Windows.Forms.Button
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents rb_actualizar_datos_empleados As System.Windows.Forms.RadioButton
End Class
