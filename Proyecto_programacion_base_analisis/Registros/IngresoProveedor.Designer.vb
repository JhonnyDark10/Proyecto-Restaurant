<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IngresoProveedor
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(IngresoProveedor))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.gbo_proveedores = New System.Windows.Forms.GroupBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.txt_cedula_proveedor = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.txt_telefono_proveedores = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_apellido2_proveedores = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.txt_nombre_proveedores = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_email_proveedores = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txt_direccion_proveedores = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txt_apellidos_proveedores = New System.Windows.Forms.TextBox()
        Me.btn_guardar_proveedores = New System.Windows.Forms.Button()
        Me.btn_volver_proveedores = New System.Windows.Forms.Button()
        Me.btn_nuevo_proveedor = New System.Windows.Forms.Button()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        Me.gbo_botones_proveedores = New System.Windows.Forms.GroupBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.gbo_proveedores.SuspendLayout()
        Me.gbo_botones_proveedores.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(85, 16)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(348, 31)
        Me.Label3.TabIndex = 8
        Me.Label3.Text = "       REGISTRO PROVEEDORES"
        '
        'gbo_proveedores
        '
        Me.gbo_proveedores.Controls.Add(Me.Label13)
        Me.gbo_proveedores.Controls.Add(Me.txt_cedula_proveedor)
        Me.gbo_proveedores.Controls.Add(Me.Label14)
        Me.gbo_proveedores.Controls.Add(Me.Label11)
        Me.gbo_proveedores.Controls.Add(Me.txt_telefono_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label12)
        Me.gbo_proveedores.Controls.Add(Me.Label10)
        Me.gbo_proveedores.Controls.Add(Me.txt_apellido2_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label7)
        Me.gbo_proveedores.Controls.Add(Me.Label9)
        Me.gbo_proveedores.Controls.Add(Me.Label8)
        Me.gbo_proveedores.Controls.Add(Me.Label6)
        Me.gbo_proveedores.Controls.Add(Me.txt_nombre_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label1)
        Me.gbo_proveedores.Controls.Add(Me.Label2)
        Me.gbo_proveedores.Controls.Add(Me.txt_email_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label4)
        Me.gbo_proveedores.Controls.Add(Me.txt_direccion_proveedores)
        Me.gbo_proveedores.Controls.Add(Me.Label5)
        Me.gbo_proveedores.Controls.Add(Me.txt_apellidos_proveedores)
        Me.gbo_proveedores.Location = New System.Drawing.Point(73, 50)
        Me.gbo_proveedores.Name = "gbo_proveedores"
        Me.gbo_proveedores.Size = New System.Drawing.Size(417, 319)
        Me.gbo_proveedores.TabIndex = 19
        Me.gbo_proveedores.TabStop = False
        Me.gbo_proveedores.Text = "Datos"
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Red
        Me.Label13.Location = New System.Drawing.Point(366, 32)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(15, 20)
        Me.Label13.TabIndex = 48
        Me.Label13.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label13, "Campo Obligatorio")
        '
        'txt_cedula_proveedor
        '
        Me.txt_cedula_proveedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_cedula_proveedor.Location = New System.Drawing.Point(141, 31)
        Me.txt_cedula_proveedor.MaxLength = 10
        Me.txt_cedula_proveedor.Name = "txt_cedula_proveedor"
        Me.txt_cedula_proveedor.Size = New System.Drawing.Size(219, 20)
        Me.txt_cedula_proveedor.TabIndex = 46
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(33, 32)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 19)
        Me.Label14.TabIndex = 47
        Me.Label14.Text = "Cedula"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Red
        Me.Label11.Location = New System.Drawing.Point(366, 283)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(15, 20)
        Me.Label11.TabIndex = 45
        Me.Label11.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label11, "Campo Obligatorio")
        '
        'txt_telefono_proveedores
        '
        Me.txt_telefono_proveedores.Location = New System.Drawing.Point(141, 282)
        Me.txt_telefono_proveedores.MaxLength = 10
        Me.txt_telefono_proveedores.Name = "txt_telefono_proveedores"
        Me.txt_telefono_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_telefono_proveedores.TabIndex = 43
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(43, 283)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 44
        Me.Label12.Text = "Telefono"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Red
        Me.Label10.Location = New System.Drawing.Point(366, 157)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(15, 20)
        Me.Label10.TabIndex = 42
        Me.Label10.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label10, "Campo Obligatorio")
        '
        'txt_apellido2_proveedores
        '
        Me.txt_apellido2_proveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellido2_proveedores.Location = New System.Drawing.Point(141, 157)
        Me.txt_apellido2_proveedores.MaxLength = 20
        Me.txt_apellido2_proveedores.Name = "txt_apellido2_proveedores"
        Me.txt_apellido2_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_apellido2_proveedores.TabIndex = 4
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(7, 158)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(127, 19)
        Me.Label7.TabIndex = 40
        Me.Label7.Text = "Apellido Materno"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Red
        Me.Label9.Location = New System.Drawing.Point(366, 111)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(15, 20)
        Me.Label9.TabIndex = 39
        Me.Label9.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label9, "Campo Obligatorio")
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Red
        Me.Label8.Location = New System.Drawing.Point(366, 246)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(15, 20)
        Me.Label8.TabIndex = 35
        Me.Label8.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label8, "Campo Obligatorio")
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Red
        Me.Label6.Location = New System.Drawing.Point(366, 74)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(15, 20)
        Me.Label6.TabIndex = 35
        Me.Label6.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label6, "Campo Obligatorio")
        '
        'txt_nombre_proveedores
        '
        Me.txt_nombre_proveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_nombre_proveedores.Location = New System.Drawing.Point(141, 73)
        Me.txt_nombre_proveedores.MaxLength = 20
        Me.txt_nombre_proveedores.Name = "txt_nombre_proveedores"
        Me.txt_nombre_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_nombre_proveedores.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(33, 74)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(63, 19)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(7, 114)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(120, 19)
        Me.Label2.TabIndex = 9
        Me.Label2.Text = "Apellido Paterno"
        '
        'txt_email_proveedores
        '
        Me.txt_email_proveedores.Location = New System.Drawing.Point(141, 245)
        Me.txt_email_proveedores.MaxLength = 20
        Me.txt_email_proveedores.Name = "txt_email_proveedores"
        Me.txt_email_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_email_proveedores.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(33, 201)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(73, 19)
        Me.Label4.TabIndex = 10
        Me.Label4.Text = "Direccion"
        '
        'txt_direccion_proveedores
        '
        Me.txt_direccion_proveedores.Location = New System.Drawing.Point(141, 202)
        Me.txt_direccion_proveedores.MaxLength = 20
        Me.txt_direccion_proveedores.Name = "txt_direccion_proveedores"
        Me.txt_direccion_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_direccion_proveedores.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(43, 246)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(47, 19)
        Me.Label5.TabIndex = 11
        Me.Label5.Text = "Email"
        '
        'txt_apellidos_proveedores
        '
        Me.txt_apellidos_proveedores.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_apellidos_proveedores.Location = New System.Drawing.Point(141, 113)
        Me.txt_apellidos_proveedores.MaxLength = 20
        Me.txt_apellidos_proveedores.Name = "txt_apellidos_proveedores"
        Me.txt_apellidos_proveedores.Size = New System.Drawing.Size(219, 20)
        Me.txt_apellidos_proveedores.TabIndex = 3
        '
        'btn_guardar_proveedores
        '
        Me.btn_guardar_proveedores.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_guardar_proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_guardar_proveedores.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_guardar_proveedores.Image = CType(resources.GetObject("btn_guardar_proveedores.Image"), System.Drawing.Image)
        Me.btn_guardar_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_guardar_proveedores.Location = New System.Drawing.Point(155, 19)
        Me.btn_guardar_proveedores.Name = "btn_guardar_proveedores"
        Me.btn_guardar_proveedores.Size = New System.Drawing.Size(125, 36)
        Me.btn_guardar_proveedores.TabIndex = 7
        Me.btn_guardar_proveedores.Text = "    GUARDAR"
        Me.ToolTip1.SetToolTip(Me.btn_guardar_proveedores, "Guardar Proveedor")
        Me.btn_guardar_proveedores.UseVisualStyleBackColor = True
        '
        'btn_volver_proveedores
        '
        Me.btn_volver_proveedores.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_proveedores.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_proveedores.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_proveedores.Image = CType(resources.GetObject("btn_volver_proveedores.Image"), System.Drawing.Image)
        Me.btn_volver_proveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_proveedores.Location = New System.Drawing.Point(286, 19)
        Me.btn_volver_proveedores.Name = "btn_volver_proveedores"
        Me.btn_volver_proveedores.Size = New System.Drawing.Size(125, 36)
        Me.btn_volver_proveedores.TabIndex = 8
        Me.btn_volver_proveedores.Text = "VOLVER"
        Me.ToolTip1.SetToolTip(Me.btn_volver_proveedores, "Volver Pagina Principal")
        Me.btn_volver_proveedores.UseVisualStyleBackColor = True
        '
        'btn_nuevo_proveedor
        '
        Me.btn_nuevo_proveedor.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_nuevo_proveedor.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_proveedor.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_proveedor.Image = CType(resources.GetObject("btn_nuevo_proveedor.Image"), System.Drawing.Image)
        Me.btn_nuevo_proveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_proveedor.Location = New System.Drawing.Point(24, 19)
        Me.btn_nuevo_proveedor.Name = "btn_nuevo_proveedor"
        Me.btn_nuevo_proveedor.Size = New System.Drawing.Size(125, 36)
        Me.btn_nuevo_proveedor.TabIndex = 1
        Me.btn_nuevo_proveedor.Text = "    NUEVO"
        Me.ToolTip1.SetToolTip(Me.btn_nuevo_proveedor, "Ingrese Nuevo Proveedor")
        Me.btn_nuevo_proveedor.UseVisualStyleBackColor = True
        '
        'gbo_botones_proveedores
        '
        Me.gbo_botones_proveedores.Controls.Add(Me.btn_volver_proveedores)
        Me.gbo_botones_proveedores.Controls.Add(Me.btn_nuevo_proveedor)
        Me.gbo_botones_proveedores.Controls.Add(Me.btn_guardar_proveedores)
        Me.gbo_botones_proveedores.Location = New System.Drawing.Point(73, 387)
        Me.gbo_botones_proveedores.Name = "gbo_botones_proveedores"
        Me.gbo_botones_proveedores.Size = New System.Drawing.Size(417, 73)
        Me.gbo_botones_proveedores.TabIndex = 35
        Me.gbo_botones_proveedores.TabStop = False
        Me.gbo_botones_proveedores.Text = "Botones"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(459, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(109, 125)
        Me.PictureBox1.TabIndex = 38
        Me.PictureBox1.TabStop = False
        '
        'IngresoProveedor
        '
        Me.AcceptButton = Me.btn_guardar_proveedores
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.CancelButton = Me.btn_volver_proveedores
        Me.ClientSize = New System.Drawing.Size(584, 484)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.gbo_botones_proveedores)
        Me.Controls.Add(Me.gbo_proveedores)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "IngresoProveedor"
        Me.ShowIcon = False
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.gbo_proveedores.ResumeLayout(False)
        Me.gbo_proveedores.PerformLayout()
        Me.gbo_botones_proveedores.ResumeLayout(False)
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents gbo_proveedores As System.Windows.Forms.GroupBox
    Friend WithEvents txt_nombre_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_email_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txt_direccion_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents txt_apellidos_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents btn_guardar_proveedores As System.Windows.Forms.Button
    Friend WithEvents btn_volver_proveedores As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_proveedor As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents gbo_botones_proveedores As System.Windows.Forms.GroupBox
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_apellido2_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents txt_telefono_proveedores As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_proveedor As System.Windows.Forms.TextBox
    Friend WithEvents Label14 As System.Windows.Forms.Label
End Class
