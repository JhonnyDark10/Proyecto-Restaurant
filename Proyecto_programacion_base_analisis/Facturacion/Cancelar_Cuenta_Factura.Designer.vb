<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Cancelar_Cuenta_Factura
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Cancelar_Cuenta_Factura))
        Me.txt_f = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_fecha = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.txt_nombre_ = New System.Windows.Forms.TextBox()
        Me.txt_apellido_ = New System.Windows.Forms.TextBox()
        Me.txt_direccion_ = New System.Windows.Forms.TextBox()
        Me.txt_telefono_ = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.txt_empresa = New System.Windows.Forms.TextBox()
        Me.txt_ruc = New System.Windows.Forms.TextBox()
        Me.dgv_imprimir = New System.Windows.Forms.DataGridView()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.txt_subtotal = New System.Windows.Forms.TextBox()
        Me.txt_descuento = New System.Windows.Forms.TextBox()
        Me.txt_recargo = New System.Windows.Forms.TextBox()
        Me.txt_iva = New System.Windows.Forms.TextBox()
        Me.txt_total = New System.Windows.Forms.TextBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Label19 = New System.Windows.Forms.Label()
        Me.txt_cedula_ = New System.Windows.Forms.TextBox()
        Me.btn_cancelar_cuenta = New System.Windows.Forms.Button()
        Me.txt_numero_tarjeta = New System.Windows.Forms.TextBox()
        Me.txt_nombretarjeta_ = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.txt_dueño_tarjeta = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.dgv_imprimir, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_f
        '
        Me.txt_f.Location = New System.Drawing.Point(103, 113)
        Me.txt_f.Name = "txt_f"
        Me.txt_f.Size = New System.Drawing.Size(60, 20)
        Me.txt_f.TabIndex = 63
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(9, 114)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(81, 19)
        Me.Label1.TabIndex = 62
        Me.Label1.Text = "Nº Factura"
        '
        'txt_fecha
        '
        Me.txt_fecha.Location = New System.Drawing.Point(131, 20)
        Me.txt_fecha.Name = "txt_fecha"
        Me.txt_fecha.Size = New System.Drawing.Size(155, 20)
        Me.txt_fecha.TabIndex = 65
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(53, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 19)
        Me.Label3.TabIndex = 64
        Me.Label3.Text = "Fecha"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.Black
        Me.Label4.Location = New System.Drawing.Point(53, 73)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(63, 19)
        Me.Label4.TabIndex = 66
        Me.Label4.Text = "Nombre"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.Black
        Me.Label5.Location = New System.Drawing.Point(53, 101)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(64, 19)
        Me.Label5.TabIndex = 67
        Me.Label5.Text = "Apellido"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.Black
        Me.Label6.Location = New System.Drawing.Point(348, 73)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(73, 19)
        Me.Label6.TabIndex = 68
        Me.Label6.Text = "Direccion"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Black
        Me.Label7.Location = New System.Drawing.Point(349, 100)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(67, 19)
        Me.Label7.TabIndex = 69
        Me.Label7.Text = "Telefono"
        '
        'txt_nombre_
        '
        Me.txt_nombre_.Location = New System.Drawing.Point(131, 74)
        Me.txt_nombre_.Name = "txt_nombre_"
        Me.txt_nombre_.Size = New System.Drawing.Size(155, 20)
        Me.txt_nombre_.TabIndex = 70
        '
        'txt_apellido_
        '
        Me.txt_apellido_.Location = New System.Drawing.Point(131, 102)
        Me.txt_apellido_.Name = "txt_apellido_"
        Me.txt_apellido_.Size = New System.Drawing.Size(155, 20)
        Me.txt_apellido_.TabIndex = 71
        '
        'txt_direccion_
        '
        Me.txt_direccion_.Location = New System.Drawing.Point(423, 72)
        Me.txt_direccion_.Name = "txt_direccion_"
        Me.txt_direccion_.Size = New System.Drawing.Size(160, 20)
        Me.txt_direccion_.TabIndex = 72
        '
        'txt_telefono_
        '
        Me.txt_telefono_.Location = New System.Drawing.Point(423, 99)
        Me.txt_telefono_.Name = "txt_telefono_"
        Me.txt_telefono_.Size = New System.Drawing.Size(160, 20)
        Me.txt_telefono_.TabIndex = 73
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.Black
        Me.Label8.Location = New System.Drawing.Point(349, 44)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(51, 19)
        Me.Label8.TabIndex = 74
        Me.Label8.Text = "R.U.C"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label9.ForeColor = System.Drawing.Color.Black
        Me.Label9.Location = New System.Drawing.Point(349, 19)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(68, 19)
        Me.Label9.TabIndex = 75
        Me.Label9.Text = "Empresa"
        '
        'txt_empresa
        '
        Me.txt_empresa.Location = New System.Drawing.Point(423, 18)
        Me.txt_empresa.Name = "txt_empresa"
        Me.txt_empresa.Size = New System.Drawing.Size(160, 20)
        Me.txt_empresa.TabIndex = 76
        '
        'txt_ruc
        '
        Me.txt_ruc.Location = New System.Drawing.Point(423, 42)
        Me.txt_ruc.Name = "txt_ruc"
        Me.txt_ruc.Size = New System.Drawing.Size(160, 20)
        Me.txt_ruc.TabIndex = 77
        '
        'dgv_imprimir
        '
        Me.dgv_imprimir.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_imprimir.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_imprimir.Location = New System.Drawing.Point(12, 293)
        Me.dgv_imprimir.Name = "dgv_imprimir"
        Me.dgv_imprimir.Size = New System.Drawing.Size(320, 309)
        Me.dgv_imprimir.TabIndex = 84
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label13.ForeColor = System.Drawing.Color.Black
        Me.Label13.Location = New System.Drawing.Point(64, 267)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(160, 19)
        Me.Label13.TabIndex = 85
        Me.Label13.Text = "Productos Consumidos"
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.Black
        Me.Label14.Location = New System.Drawing.Point(22, 25)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(64, 19)
        Me.Label14.TabIndex = 86
        Me.Label14.Text = "Subtotal"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.ForeColor = System.Drawing.Color.Black
        Me.Label15.Location = New System.Drawing.Point(22, 55)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(80, 19)
        Me.Label15.TabIndex = 87
        Me.Label15.Text = "Descuento"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.ForeColor = System.Drawing.Color.Black
        Me.Label16.Location = New System.Drawing.Point(22, 86)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(91, 19)
        Me.Label16.TabIndex = 88
        Me.Label16.Text = "Recargo TC"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.ForeColor = System.Drawing.Color.Black
        Me.Label17.Location = New System.Drawing.Point(22, 115)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(35, 19)
        Me.Label17.TabIndex = 89
        Me.Label17.Text = "IVA"
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.ForeColor = System.Drawing.Color.Black
        Me.Label18.Location = New System.Drawing.Point(22, 167)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(131, 19)
        Me.Label18.TabIndex = 90
        Me.Label18.Text = "TOTAL A PAGAR"
        '
        'txt_subtotal
        '
        Me.txt_subtotal.Location = New System.Drawing.Point(178, 24)
        Me.txt_subtotal.Name = "txt_subtotal"
        Me.txt_subtotal.Size = New System.Drawing.Size(73, 20)
        Me.txt_subtotal.TabIndex = 91
        '
        'txt_descuento
        '
        Me.txt_descuento.Location = New System.Drawing.Point(178, 54)
        Me.txt_descuento.Name = "txt_descuento"
        Me.txt_descuento.Size = New System.Drawing.Size(73, 20)
        Me.txt_descuento.TabIndex = 92
        '
        'txt_recargo
        '
        Me.txt_recargo.Location = New System.Drawing.Point(178, 85)
        Me.txt_recargo.Name = "txt_recargo"
        Me.txt_recargo.Size = New System.Drawing.Size(73, 20)
        Me.txt_recargo.TabIndex = 93
        '
        'txt_iva
        '
        Me.txt_iva.Location = New System.Drawing.Point(179, 114)
        Me.txt_iva.Name = "txt_iva"
        Me.txt_iva.Size = New System.Drawing.Size(73, 20)
        Me.txt_iva.TabIndex = 94
        '
        'txt_total
        '
        Me.txt_total.Location = New System.Drawing.Point(179, 166)
        Me.txt_total.Name = "txt_total"
        Me.txt_total.Size = New System.Drawing.Size(73, 20)
        Me.txt_total.TabIndex = 95
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.txt_total)
        Me.GroupBox1.Controls.Add(Me.Label14)
        Me.GroupBox1.Controls.Add(Me.txt_iva)
        Me.GroupBox1.Controls.Add(Me.Label15)
        Me.GroupBox1.Controls.Add(Me.txt_recargo)
        Me.GroupBox1.Controls.Add(Me.Label16)
        Me.GroupBox1.Controls.Add(Me.txt_descuento)
        Me.GroupBox1.Controls.Add(Me.Label17)
        Me.GroupBox1.Controls.Add(Me.txt_subtotal)
        Me.GroupBox1.Controls.Add(Me.Label18)
        Me.GroupBox1.Location = New System.Drawing.Point(338, 397)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(263, 201)
        Me.GroupBox1.TabIndex = 96
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Desgloce Pago"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Label19)
        Me.GroupBox2.Controls.Add(Me.txt_cedula_)
        Me.GroupBox2.Controls.Add(Me.txt_telefono_)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txt_fecha)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label7)
        Me.GroupBox2.Controls.Add(Me.txt_nombre_)
        Me.GroupBox2.Controls.Add(Me.txt_ruc)
        Me.GroupBox2.Controls.Add(Me.txt_apellido_)
        Me.GroupBox2.Controls.Add(Me.txt_empresa)
        Me.GroupBox2.Controls.Add(Me.txt_direccion_)
        Me.GroupBox2.Controls.Add(Me.Label9)
        Me.GroupBox2.Controls.Add(Me.Label8)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 139)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(639, 125)
        Me.GroupBox2.TabIndex = 97
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Datos"
        '
        'Label19
        '
        Me.Label19.AutoSize = True
        Me.Label19.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label19.ForeColor = System.Drawing.Color.Black
        Me.Label19.Location = New System.Drawing.Point(53, 45)
        Me.Label19.Name = "Label19"
        Me.Label19.Size = New System.Drawing.Size(56, 19)
        Me.Label19.TabIndex = 78
        Me.Label19.Text = "Cedula"
        '
        'txt_cedula_
        '
        Me.txt_cedula_.Location = New System.Drawing.Point(131, 47)
        Me.txt_cedula_.Name = "txt_cedula_"
        Me.txt_cedula_.Size = New System.Drawing.Size(155, 20)
        Me.txt_cedula_.TabIndex = 79
        '
        'btn_cancelar_cuenta
        '
        Me.btn_cancelar_cuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cancelar_cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar_cuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_cuenta.ForeColor = System.Drawing.Color.Red
        Me.btn_cancelar_cuenta.Image = CType(resources.GetObject("btn_cancelar_cuenta.Image"), System.Drawing.Image)
        Me.btn_cancelar_cuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar_cuenta.Location = New System.Drawing.Point(270, 610)
        Me.btn_cancelar_cuenta.Name = "btn_cancelar_cuenta"
        Me.btn_cancelar_cuenta.Size = New System.Drawing.Size(142, 34)
        Me.btn_cancelar_cuenta.TabIndex = 99
        Me.btn_cancelar_cuenta.Text = "     IMPRIMIR"
        Me.btn_cancelar_cuenta.UseVisualStyleBackColor = True
        '
        'txt_numero_tarjeta
        '
        Me.txt_numero_tarjeta.Location = New System.Drawing.Point(91, 53)
        Me.txt_numero_tarjeta.Name = "txt_numero_tarjeta"
        Me.txt_numero_tarjeta.Size = New System.Drawing.Size(160, 20)
        Me.txt_numero_tarjeta.TabIndex = 82
        '
        'txt_nombretarjeta_
        '
        Me.txt_nombretarjeta_.Location = New System.Drawing.Point(91, 23)
        Me.txt_nombretarjeta_.Name = "txt_nombretarjeta_"
        Me.txt_nombretarjeta_.Size = New System.Drawing.Size(160, 20)
        Me.txt_nombretarjeta_.TabIndex = 81
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label12.ForeColor = System.Drawing.Color.Black
        Me.Label12.Location = New System.Drawing.Point(16, 87)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(67, 19)
        Me.Label12.TabIndex = 80
        Me.Label12.Text = "Dueño T"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.ForeColor = System.Drawing.Color.Black
        Me.Label11.Location = New System.Drawing.Point(10, 54)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(77, 19)
        Me.Label11.TabIndex = 79
        Me.Label11.Text = "Numero T"
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label10.ForeColor = System.Drawing.Color.Black
        Me.Label10.Location = New System.Drawing.Point(18, 24)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(57, 19)
        Me.Label10.TabIndex = 78
        Me.Label10.Text = "Tarjeta"
        '
        'txt_dueño_tarjeta
        '
        Me.txt_dueño_tarjeta.Location = New System.Drawing.Point(91, 86)
        Me.txt_dueño_tarjeta.Name = "txt_dueño_tarjeta"
        Me.txt_dueño_tarjeta.Size = New System.Drawing.Size(160, 20)
        Me.txt_dueño_tarjeta.TabIndex = 83
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.txt_dueño_tarjeta)
        Me.GroupBox3.Controls.Add(Me.Label10)
        Me.GroupBox3.Controls.Add(Me.Label11)
        Me.GroupBox3.Controls.Add(Me.Label12)
        Me.GroupBox3.Controls.Add(Me.txt_nombretarjeta_)
        Me.GroupBox3.Controls.Add(Me.txt_numero_tarjeta)
        Me.GroupBox3.Location = New System.Drawing.Point(338, 270)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(257, 121)
        Me.GroupBox3.TabIndex = 98
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Datos Tarjeta"
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(-4, 0)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(669, 96)
        Me.Label2.TabIndex = 100
        '
        'Cancelar_Cuenta_Factura
        '
        Me.AcceptButton = Me.btn_cancelar_cuenta
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(663, 656)
        Me.ControlBox = False
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.btn_cancelar_cuenta)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.txt_f)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label13)
        Me.Controls.Add(Me.dgv_imprimir)
        Me.Name = "Cancelar_Cuenta_Factura"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv_imprimir, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_f As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_fecha As System.Windows.Forms.TextBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label7 As System.Windows.Forms.Label
    Friend WithEvents txt_nombre_ As System.Windows.Forms.TextBox
    Friend WithEvents txt_apellido_ As System.Windows.Forms.TextBox
    Friend WithEvents txt_direccion_ As System.Windows.Forms.TextBox
    Friend WithEvents txt_telefono_ As System.Windows.Forms.TextBox
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents Label9 As System.Windows.Forms.Label
    Friend WithEvents txt_empresa As System.Windows.Forms.TextBox
    Friend WithEvents txt_ruc As System.Windows.Forms.TextBox
    Friend WithEvents dgv_imprimir As System.Windows.Forms.DataGridView
    Friend WithEvents Label13 As System.Windows.Forms.Label
    Friend WithEvents Label14 As System.Windows.Forms.Label
    Friend WithEvents Label15 As System.Windows.Forms.Label
    Friend WithEvents Label16 As System.Windows.Forms.Label
    Friend WithEvents Label17 As System.Windows.Forms.Label
    Friend WithEvents Label18 As System.Windows.Forms.Label
    Friend WithEvents txt_subtotal As System.Windows.Forms.TextBox
    Friend WithEvents txt_descuento As System.Windows.Forms.TextBox
    Friend WithEvents txt_recargo As System.Windows.Forms.TextBox
    Friend WithEvents txt_iva As System.Windows.Forms.TextBox
    Friend WithEvents txt_total As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_cancelar_cuenta As System.Windows.Forms.Button
    Friend WithEvents Label19 As System.Windows.Forms.Label
    Friend WithEvents txt_cedula_ As System.Windows.Forms.TextBox
    Friend WithEvents txt_numero_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents txt_nombretarjeta_ As System.Windows.Forms.TextBox
    Friend WithEvents Label12 As System.Windows.Forms.Label
    Friend WithEvents Label11 As System.Windows.Forms.Label
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents txt_dueño_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
End Class
