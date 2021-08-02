<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Ingreso_Platos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Ingreso_Platos))
        Me.gbo_ingreso_platos_datos = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_precio_platos_i = New System.Windows.Forms.TextBox()
        Me.txt_nombre_platos_i = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbo_ingresos_platos = New System.Windows.Forms.GroupBox()
        Me.cbo_platos_ingresos_categ = New System.Windows.Forms.ComboBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.btn_cargar_foto_ingreso_plato = New System.Windows.Forms.Button()
        Me.btn_guardar_plato_ingreso = New System.Windows.Forms.Button()
        Me.btn_volver_plato_ingreso = New System.Windows.Forms.Button()
        Me.ProgressBar1 = New System.Windows.Forms.ProgressBar()
        Me.btn_nuevo_platos = New System.Windows.Forms.Button()
        Me.gbo_botones_platos = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.Label7 = New System.Windows.Forms.Label()
        Me.gbo_imagen_platos = New System.Windows.Forms.GroupBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.gbo_ingreso_platos_datos.SuspendLayout()
        Me.gbo_ingresos_platos.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbo_botones_platos.SuspendLayout()
        Me.gbo_imagen_platos.SuspendLayout()
        Me.SuspendLayout()
        '
        'gbo_ingreso_platos_datos
        '
        Me.gbo_ingreso_platos_datos.Controls.Add(Me.Label5)
        Me.gbo_ingreso_platos_datos.Controls.Add(Me.Label6)
        Me.gbo_ingreso_platos_datos.Controls.Add(Me.Label1)
        Me.gbo_ingreso_platos_datos.Controls.Add(Me.Label2)
        Me.gbo_ingreso_platos_datos.Controls.Add(Me.txt_precio_platos_i)
        Me.gbo_ingreso_platos_datos.Controls.Add(Me.txt_nombre_platos_i)
        Me.gbo_ingreso_platos_datos.Location = New System.Drawing.Point(38, 228)
        Me.gbo_ingreso_platos_datos.Name = "gbo_ingreso_platos_datos"
        Me.gbo_ingreso_platos_datos.Size = New System.Drawing.Size(378, 130)
        Me.gbo_ingreso_platos_datos.TabIndex = 27
        Me.gbo_ingreso_platos_datos.TabStop = False
        Me.gbo_ingreso_platos_datos.Text = "Datos"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(229, 78)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 40
        Me.Label5.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label5, "Campo Obligatorio")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(336, 34)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 40
        Me.Label6.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label6, "Campo Obligatorio")
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(23, 35)
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
        Me.Label2.Location = New System.Drawing.Point(23, 79)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(51, 19)
        Me.Label2.TabIndex = 13
        Me.Label2.Text = "Precio"
        '
        'txt_precio_platos_i
        '
        Me.txt_precio_platos_i.Location = New System.Drawing.Point(124, 79)
        Me.txt_precio_platos_i.MaxLength = 5
        Me.txt_precio_platos_i.Name = "txt_precio_platos_i"
        Me.txt_precio_platos_i.Size = New System.Drawing.Size(99, 20)
        Me.txt_precio_platos_i.TabIndex = 20
        '
        'txt_nombre_platos_i
        '
        Me.txt_nombre_platos_i.Location = New System.Drawing.Point(124, 35)
        Me.txt_nombre_platos_i.MaxLength = 20
        Me.txt_nombre_platos_i.Name = "txt_nombre_platos_i"
        Me.txt_nombre_platos_i.Size = New System.Drawing.Size(206, 20)
        Me.txt_nombre_platos_i.TabIndex = 19
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(156, 20)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(260, 31)
        Me.Label3.TabIndex = 28
        Me.Label3.Text = "      REGISTRO PLATOS"
        '
        'gbo_ingresos_platos
        '
        Me.gbo_ingresos_platos.Controls.Add(Me.cbo_platos_ingresos_categ)
        Me.gbo_ingresos_platos.Controls.Add(Me.Label9)
        Me.gbo_ingresos_platos.Location = New System.Drawing.Point(38, 74)
        Me.gbo_ingresos_platos.Name = "gbo_ingresos_platos"
        Me.gbo_ingresos_platos.Size = New System.Drawing.Size(378, 139)
        Me.gbo_ingresos_platos.TabIndex = 29
        Me.gbo_ingresos_platos.TabStop = False
        Me.gbo_ingresos_platos.Text = "Categoria"
        '
        'cbo_platos_ingresos_categ
        '
        Me.cbo_platos_ingresos_categ.DisplayMember = "DESCRIPCION"
        Me.cbo_platos_ingresos_categ.FormattingEnabled = True
        Me.cbo_platos_ingresos_categ.Location = New System.Drawing.Point(124, 31)
        Me.cbo_platos_ingresos_categ.Name = "cbo_platos_ingresos_categ"
        Me.cbo_platos_ingresos_categ.Size = New System.Drawing.Size(196, 21)
        Me.cbo_platos_ingresos_categ.TabIndex = 19
        Me.cbo_platos_ingresos_categ.ValueMember = "ID_CATEGORIA_PLATOS"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(25, 30)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(71, 19)
        Me.Label9.TabIndex = 18
        Me.Label9.Text = "Opciones"
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.DodgerBlue
        Me.PictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.PictureBox1.Location = New System.Drawing.Point(46, 88)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(100, 100)
        Me.PictureBox1.TabIndex = 32
        Me.PictureBox1.TabStop = False
        '
        'btn_cargar_foto_ingreso_plato
        '
        Me.btn_cargar_foto_ingreso_plato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cargar_foto_ingreso_plato.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cargar_foto_ingreso_plato.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cargar_foto_ingreso_plato.Image = CType(resources.GetObject("btn_cargar_foto_ingreso_plato.Image"), System.Drawing.Image)
        Me.btn_cargar_foto_ingreso_plato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cargar_foto_ingreso_plato.Location = New System.Drawing.Point(32, 223)
        Me.btn_cargar_foto_ingreso_plato.Name = "btn_cargar_foto_ingreso_plato"
        Me.btn_cargar_foto_ingreso_plato.Size = New System.Drawing.Size(125, 36)
        Me.btn_cargar_foto_ingreso_plato.TabIndex = 34
        Me.btn_cargar_foto_ingreso_plato.Text = "    CARGAR"
        Me.ToolTip1.SetToolTip(Me.btn_cargar_foto_ingreso_plato, "Subir Imagen del Plato")
        Me.btn_cargar_foto_ingreso_plato.UseVisualStyleBackColor = True
        '
        'btn_guardar_plato_ingreso
        '
        Me.btn_guardar_plato_ingreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_guardar_plato_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_guardar_plato_ingreso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_plato_ingreso.Image = CType(resources.GetObject("btn_guardar_plato_ingreso.Image"), System.Drawing.Image)
        Me.btn_guardar_plato_ingreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar_plato_ingreso.Location = New System.Drawing.Point(172, 24)
        Me.btn_guardar_plato_ingreso.Name = "btn_guardar_plato_ingreso"
        Me.btn_guardar_plato_ingreso.Size = New System.Drawing.Size(125, 36)
        Me.btn_guardar_plato_ingreso.TabIndex = 35
        Me.btn_guardar_plato_ingreso.Text = "    GUARDAR"
        Me.ToolTip1.SetToolTip(Me.btn_guardar_plato_ingreso, "Guardar Nuevo Plato")
        Me.btn_guardar_plato_ingreso.UseVisualStyleBackColor = True
        '
        'btn_volver_plato_ingreso
        '
        Me.btn_volver_plato_ingreso.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_volver_plato_ingreso.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_plato_ingreso.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_volver_plato_ingreso.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_plato_ingreso.Image = CType(resources.GetObject("btn_volver_plato_ingreso.Image"), System.Drawing.Image)
        Me.btn_volver_plato_ingreso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_plato_ingreso.Location = New System.Drawing.Point(309, 22)
        Me.btn_volver_plato_ingreso.Name = "btn_volver_plato_ingreso"
        Me.btn_volver_plato_ingreso.Size = New System.Drawing.Size(125, 36)
        Me.btn_volver_plato_ingreso.TabIndex = 36
        Me.btn_volver_plato_ingreso.Text = "    VOLVER"
        Me.ToolTip1.SetToolTip(Me.btn_volver_plato_ingreso, "Regresar Pagina Principal")
        Me.btn_volver_plato_ingreso.UseVisualStyleBackColor = True
        '
        'ProgressBar1
        '
        Me.ProgressBar1.Enabled = False
        Me.ProgressBar1.Location = New System.Drawing.Point(36, 265)
        Me.ProgressBar1.MarqueeAnimationSpeed = 10
        Me.ProgressBar1.Name = "ProgressBar1"
        Me.ProgressBar1.Size = New System.Drawing.Size(125, 11)
        Me.ProgressBar1.TabIndex = 37
        '
        'btn_nuevo_platos
        '
        Me.btn_nuevo_platos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_nuevo_platos.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_nuevo_platos.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_nuevo_platos.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_platos.Image = CType(resources.GetObject("btn_nuevo_platos.Image"), System.Drawing.Image)
        Me.btn_nuevo_platos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_platos.Location = New System.Drawing.Point(34, 22)
        Me.btn_nuevo_platos.Name = "btn_nuevo_platos"
        Me.btn_nuevo_platos.Size = New System.Drawing.Size(125, 36)
        Me.btn_nuevo_platos.TabIndex = 38
        Me.btn_nuevo_platos.Text = "NUEVO"
        Me.ToolTip1.SetToolTip(Me.btn_nuevo_platos, "Nuevo Plato")
        Me.btn_nuevo_platos.UseVisualStyleBackColor = True
        '
        'gbo_botones_platos
        '
        Me.gbo_botones_platos.Controls.Add(Me.btn_volver_plato_ingreso)
        Me.gbo_botones_platos.Controls.Add(Me.btn_nuevo_platos)
        Me.gbo_botones_platos.Controls.Add(Me.btn_guardar_plato_ingreso)
        Me.gbo_botones_platos.Location = New System.Drawing.Point(67, 400)
        Me.gbo_botones_platos.Name = "gbo_botones_platos"
        Me.gbo_botones_platos.Size = New System.Drawing.Size(472, 72)
        Me.gbo_botones_platos.TabIndex = 39
        Me.gbo_botones_platos.TabStop = False
        Me.gbo_botones_platos.Text = "Botones"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Red
        Me.Label7.Location = New System.Drawing.Point(150, 29)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(15, 20)
        Me.Label7.TabIndex = 43
        Me.Label7.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label7, "Campo Obligatorio")
        '
        'gbo_imagen_platos
        '
        Me.gbo_imagen_platos.Controls.Add(Me.Label7)
        Me.gbo_imagen_platos.Controls.Add(Me.Label4)
        Me.gbo_imagen_platos.Controls.Add(Me.PictureBox1)
        Me.gbo_imagen_platos.Controls.Add(Me.ProgressBar1)
        Me.gbo_imagen_platos.Controls.Add(Me.btn_cargar_foto_ingreso_plato)
        Me.gbo_imagen_platos.Location = New System.Drawing.Point(440, 74)
        Me.gbo_imagen_platos.Name = "gbo_imagen_platos"
        Me.gbo_imagen_platos.Size = New System.Drawing.Size(180, 284)
        Me.gbo_imagen_platos.TabIndex = 42
        Me.gbo_imagen_platos.TabStop = False
        Me.gbo_imagen_platos.Text = "Imagen"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(41, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(105, 19)
        Me.Label4.TabIndex = 42
        Me.Label4.Text = "SUBIR FOTO"
        '
        'Ingreso_Platos
        '
        Me.AcceptButton = Me.btn_guardar_plato_ingreso
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_volver_plato_ingreso
        Me.ClientSize = New System.Drawing.Size(632, 484)
        Me.Controls.Add(Me.gbo_imagen_platos)
        Me.Controls.Add(Me.gbo_botones_platos)
        Me.Controls.Add(Me.gbo_ingresos_platos)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.gbo_ingreso_platos_datos)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Ingreso_Platos"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Registro_Platos"
        Me.gbo_ingreso_platos_datos.ResumeLayout(False)
        Me.gbo_ingreso_platos_datos.PerformLayout()
        Me.gbo_ingresos_platos.ResumeLayout(False)
        Me.gbo_ingresos_platos.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbo_botones_platos.ResumeLayout(False)
        Me.gbo_imagen_platos.ResumeLayout(False)
        Me.gbo_imagen_platos.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents gbo_ingreso_platos_datos As System.Windows.Forms.GroupBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_precio_platos_i As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombre_platos_i As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbo_ingresos_platos As System.Windows.Forms.GroupBox
    Friend WithEvents cbo_platos_ingresos_categ As System.Windows.Forms.ComboBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents btn_cargar_foto_ingreso_plato As System.Windows.Forms.Button
    Friend WithEvents btn_guardar_plato_ingreso As System.Windows.Forms.Button
    Friend WithEvents btn_volver_plato_ingreso As System.Windows.Forms.Button
    Friend WithEvents ProgressBar1 As System.Windows.Forms.ProgressBar
    Friend WithEvents btn_nuevo_platos As System.Windows.Forms.Button
    Friend WithEvents gbo_botones_platos As System.Windows.Forms.GroupBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbo_imagen_platos As System.Windows.Forms.GroupBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
