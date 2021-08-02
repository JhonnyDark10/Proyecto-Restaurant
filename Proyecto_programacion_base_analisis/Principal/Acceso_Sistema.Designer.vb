<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Acceso_Sistema
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Acceso_Sistema))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txt_usuario_acceso = New System.Windows.Forms.TextBox()
        Me.txt_contraseña_acceso = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.picture_box_imagen_acesso = New System.Windows.Forms.PictureBox()
        Me.BTN_ACEPTAR_INICIO = New System.Windows.Forms.Button()
        Me.BTN_CANCELAR_INICIO = New System.Windows.Forms.Button()
        Me.PictureBox_ayuda_acesso = New System.Windows.Forms.PictureBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.ToolTip1 = New System.Windows.Forms.ToolTip(Me.components)
        CType(Me.picture_box_imagen_acesso, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox_ayuda_acesso, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Image = CType(resources.GetObject("Label1.Image"), System.Drawing.Image)
        Me.Label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label1.Location = New System.Drawing.Point(32, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(101, 19)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "     USUARIO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Image = CType(resources.GetObject("Label2.Image"), System.Drawing.Image)
        Me.Label2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label2.Location = New System.Drawing.Point(32, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(139, 19)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "     CONTRASEÑA"
        Me.Label2.UseWaitCursor = True
        '
        'txt_usuario_acceso
        '
        Me.txt_usuario_acceso.Cursor = System.Windows.Forms.Cursors.Default
        Me.txt_usuario_acceso.ImeMode = System.Windows.Forms.ImeMode.NoControl
        Me.txt_usuario_acceso.Location = New System.Drawing.Point(181, 29)
        Me.txt_usuario_acceso.MaxLength = 20
        Me.txt_usuario_acceso.Name = "txt_usuario_acceso"
        Me.txt_usuario_acceso.Size = New System.Drawing.Size(155, 20)
        Me.txt_usuario_acceso.TabIndex = 2
        '
        'txt_contraseña_acceso
        '
        Me.txt_contraseña_acceso.Location = New System.Drawing.Point(181, 75)
        Me.txt_contraseña_acceso.MaxLength = 20
        Me.txt_contraseña_acceso.Name = "txt_contraseña_acceso"
        Me.txt_contraseña_acceso.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txt_contraseña_acceso.Size = New System.Drawing.Size(155, 20)
        Me.txt_contraseña_acceso.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Cursor = System.Windows.Forms.Cursors.WaitCursor
        Me.Label3.Font = New System.Drawing.Font("Sitka Small", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Location = New System.Drawing.Point(190, 21)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(246, 31)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "ACCESO AL SISTEMA"
        Me.Label3.UseWaitCursor = True
        '
        'picture_box_imagen_acesso
        '
        Me.picture_box_imagen_acesso.Image = CType(resources.GetObject("picture_box_imagen_acesso.Image"), System.Drawing.Image)
        Me.picture_box_imagen_acesso.Location = New System.Drawing.Point(42, 88)
        Me.picture_box_imagen_acesso.Name = "picture_box_imagen_acesso"
        Me.picture_box_imagen_acesso.Size = New System.Drawing.Size(131, 137)
        Me.picture_box_imagen_acesso.TabIndex = 5
        Me.picture_box_imagen_acesso.TabStop = False
        Me.picture_box_imagen_acesso.UseWaitCursor = True
        '
        'BTN_ACEPTAR_INICIO
        '
        Me.BTN_ACEPTAR_INICIO.BackColor = System.Drawing.Color.White
        Me.BTN_ACEPTAR_INICIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_ACEPTAR_INICIO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_ACEPTAR_INICIO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_ACEPTAR_INICIO.ForeColor = System.Drawing.Color.Red
        Me.BTN_ACEPTAR_INICIO.Image = CType(resources.GetObject("BTN_ACEPTAR_INICIO.Image"), System.Drawing.Image)
        Me.BTN_ACEPTAR_INICIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_ACEPTAR_INICIO.Location = New System.Drawing.Point(54, 19)
        Me.BTN_ACEPTAR_INICIO.Name = "BTN_ACEPTAR_INICIO"
        Me.BTN_ACEPTAR_INICIO.Size = New System.Drawing.Size(131, 39)
        Me.BTN_ACEPTAR_INICIO.TabIndex = 7
        Me.BTN_ACEPTAR_INICIO.Text = "       INGRESAR"
        Me.ToolTip1.SetToolTip(Me.BTN_ACEPTAR_INICIO, "Ingresar Al Sistema")
        Me.BTN_ACEPTAR_INICIO.UseVisualStyleBackColor = False
        '
        'BTN_CANCELAR_INICIO
        '
        Me.BTN_CANCELAR_INICIO.BackColor = System.Drawing.Color.White
        Me.BTN_CANCELAR_INICIO.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.BTN_CANCELAR_INICIO.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTN_CANCELAR_INICIO.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BTN_CANCELAR_INICIO.ForeColor = System.Drawing.Color.Red
        Me.BTN_CANCELAR_INICIO.Image = CType(resources.GetObject("BTN_CANCELAR_INICIO.Image"), System.Drawing.Image)
        Me.BTN_CANCELAR_INICIO.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.BTN_CANCELAR_INICIO.Location = New System.Drawing.Point(197, 19)
        Me.BTN_CANCELAR_INICIO.Name = "BTN_CANCELAR_INICIO"
        Me.BTN_CANCELAR_INICIO.Size = New System.Drawing.Size(125, 39)
        Me.BTN_CANCELAR_INICIO.TabIndex = 8
        Me.BTN_CANCELAR_INICIO.Text = "SALIR"
        Me.ToolTip1.SetToolTip(Me.BTN_CANCELAR_INICIO, "Salir De La Aplicacion")
        Me.BTN_CANCELAR_INICIO.UseVisualStyleBackColor = False
        '
        'PictureBox_ayuda_acesso
        '
        Me.PictureBox_ayuda_acesso.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox_ayuda_acesso.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox_ayuda_acesso.Cursor = System.Windows.Forms.Cursors.Hand
        Me.PictureBox_ayuda_acesso.Image = CType(resources.GetObject("PictureBox_ayuda_acesso.Image"), System.Drawing.Image)
        Me.PictureBox_ayuda_acesso.Location = New System.Drawing.Point(544, 12)
        Me.PictureBox_ayuda_acesso.Name = "PictureBox_ayuda_acesso"
        Me.PictureBox_ayuda_acesso.Size = New System.Drawing.Size(52, 51)
        Me.PictureBox_ayuda_acesso.TabIndex = 9
        Me.PictureBox_ayuda_acesso.TabStop = False
        Me.ToolTip1.SetToolTip(Me.PictureBox_ayuda_acesso, "AYUDA")
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Label5)
        Me.GroupBox1.Controls.Add(Me.Label4)
        Me.GroupBox1.Controls.Add(Me.txt_contraseña_acceso)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txt_usuario_acceso)
        Me.GroupBox1.Location = New System.Drawing.Point(179, 69)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(376, 119)
        Me.GroupBox1.TabIndex = 10
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Ingreso"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Red
        Me.Label5.Location = New System.Drawing.Point(343, 27)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(15, 20)
        Me.Label5.TabIndex = 5
        Me.Label5.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label5, "Campo Obligatorio")
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Red
        Me.Label4.Location = New System.Drawing.Point(343, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(15, 20)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "*"
        Me.ToolTip1.SetToolTip(Me.Label4, "Campo Obligatorio")
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.BTN_CANCELAR_INICIO)
        Me.GroupBox2.Controls.Add(Me.BTN_ACEPTAR_INICIO)
        Me.GroupBox2.Location = New System.Drawing.Point(180, 194)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(375, 74)
        Me.GroupBox2.TabIndex = 11
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Botones"
        '
        'ToolTip1
        '
        Me.ToolTip1.AutoPopDelay = 5000
        Me.ToolTip1.InitialDelay = 100
        Me.ToolTip1.ReshowDelay = 100
        '
        'Acceso_Sistema
        '
        Me.AcceptButton = Me.BTN_ACEPTAR_INICIO
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(618, 296)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.PictureBox_ayuda_acesso)
        Me.Controls.Add(Me.picture_box_imagen_acesso)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Acceso_Sistema"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.TopMost = True
        CType(Me.picture_box_imagen_acesso, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox_ayuda_acesso, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txt_usuario_acceso As System.Windows.Forms.TextBox
    Friend WithEvents txt_contraseña_acceso As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents picture_box_imagen_acesso As System.Windows.Forms.PictureBox
    Friend WithEvents BTN_ACEPTAR_INICIO As System.Windows.Forms.Button
    Friend WithEvents BTN_CANCELAR_INICIO As System.Windows.Forms.Button
    Friend WithEvents PictureBox_ayuda_acesso As System.Windows.Forms.PictureBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents ToolTip1 As System.Windows.Forms.ToolTip
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
End Class
