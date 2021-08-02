<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Clientes
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_Clientes))
        Me.dgv_reportes = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.cbo_tipo = New System.Windows.Forms.ComboBox()
        Me.dtp_fecha = New System.Windows.Forms.DateTimePicker()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_actualizar_empleado = New System.Windows.Forms.Button()
        Me.btn_volver_actualizaion_empleado = New System.Windows.Forms.Button()
        Me.btn_cancelar_cuenta = New System.Windows.Forms.Button()
        CType(Me.dgv_reportes, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'dgv_reportes
        '
        Me.dgv_reportes.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_reportes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_reportes.Location = New System.Drawing.Point(12, 202)
        Me.dgv_reportes.Name = "dgv_reportes"
        Me.dgv_reportes.Size = New System.Drawing.Size(840, 314)
        Me.dgv_reportes.TabIndex = 40
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(51, 33)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(78, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "BUSCAR "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(292, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(198, 19)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "      REPORTES CLIENTES"
        '
        'cbo_tipo
        '
        Me.cbo_tipo.FormattingEnabled = True
        Me.cbo_tipo.Items.AddRange(New Object() {"CADUCADAS", "PROXIMAS A CADUCAR", "TIEMPO A RENOVAR"})
        Me.cbo_tipo.Location = New System.Drawing.Point(270, 30)
        Me.cbo_tipo.Name = "cbo_tipo"
        Me.cbo_tipo.Size = New System.Drawing.Size(210, 21)
        Me.cbo_tipo.TabIndex = 41
        '
        'dtp_fecha
        '
        Me.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtp_fecha.Location = New System.Drawing.Point(145, 31)
        Me.dtp_fecha.Name = "dtp_fecha"
        Me.dtp_fecha.Size = New System.Drawing.Size(98, 20)
        Me.dtp_fecha.TabIndex = 42
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_tipo)
        Me.GroupBox1.Controls.Add(Me.dtp_fecha)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 72)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(508, 99)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_actualizar_empleado)
        Me.GroupBox3.Controls.Add(Me.btn_volver_actualizaion_empleado)
        Me.GroupBox3.Location = New System.Drawing.Point(535, 72)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 99)
        Me.GroupBox3.TabIndex = 44
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Botones"
        '
        'btn_actualizar_empleado
        '
        Me.btn_actualizar_empleado.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_actualizar_empleado.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_actualizar_empleado.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_actualizar_empleado.ForeColor = System.Drawing.Color.Red
        Me.btn_actualizar_empleado.Image = CType(resources.GetObject("btn_actualizar_empleado.Image"), System.Drawing.Image)
        Me.btn_actualizar_empleado.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_actualizar_empleado.Location = New System.Drawing.Point(24, 33)
        Me.btn_actualizar_empleado.Name = "btn_actualizar_empleado"
        Me.btn_actualizar_empleado.Size = New System.Drawing.Size(116, 45)
        Me.btn_actualizar_empleado.TabIndex = 25
        Me.btn_actualizar_empleado.Text = "     BUSCAR"
        Me.btn_actualizar_empleado.UseVisualStyleBackColor = True
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
        Me.btn_volver_actualizaion_empleado.Location = New System.Drawing.Point(146, 33)
        Me.btn_volver_actualizaion_empleado.Name = "btn_volver_actualizaion_empleado"
        Me.btn_volver_actualizaion_empleado.Size = New System.Drawing.Size(116, 45)
        Me.btn_volver_actualizaion_empleado.TabIndex = 22
        Me.btn_volver_actualizaion_empleado.Text = "    VOLVER"
        Me.btn_volver_actualizaion_empleado.UseVisualStyleBackColor = True
        '
        'btn_cancelar_cuenta
        '
        Me.btn_cancelar_cuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cancelar_cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar_cuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_cuenta.ForeColor = System.Drawing.Color.Red
        Me.btn_cancelar_cuenta.Image = CType(resources.GetObject("btn_cancelar_cuenta.Image"), System.Drawing.Image)
        Me.btn_cancelar_cuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar_cuenta.Location = New System.Drawing.Point(710, 522)
        Me.btn_cancelar_cuenta.Name = "btn_cancelar_cuenta"
        Me.btn_cancelar_cuenta.Size = New System.Drawing.Size(142, 34)
        Me.btn_cancelar_cuenta.TabIndex = 100
        Me.btn_cancelar_cuenta.Text = "     IMPRIMIR"
        Me.btn_cancelar_cuenta.UseVisualStyleBackColor = True
        '
        'Reporte_Clientes
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(864, 562)
        Me.Controls.Add(Me.btn_cancelar_cuenta)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.dgv_reportes)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reporte_Clientes"
        Me.ShowInTaskbar = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv_reportes, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents dgv_reportes As System.Windows.Forms.DataGridView
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents cbo_tipo As System.Windows.Forms.ComboBox
    Friend WithEvents dtp_fecha As System.Windows.Forms.DateTimePicker
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_actualizar_empleado As System.Windows.Forms.Button
    Friend WithEvents btn_volver_actualizaion_empleado As System.Windows.Forms.Button
    Friend WithEvents btn_cancelar_cuenta As System.Windows.Forms.Button
End Class
