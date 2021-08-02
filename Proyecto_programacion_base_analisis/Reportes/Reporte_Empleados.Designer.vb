<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Reporte_Empleados
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Reporte_Empleados))
        Me.cbo_tipo_empleado = New System.Windows.Forms.ComboBox()
        Me.dgv_empleado = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.btn_cancelar_cuenta = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_actualizar_empleado = New System.Windows.Forms.Button()
        Me.btn_volver_actualizaion_empleado = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        CType(Me.dgv_empleado, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox3.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'cbo_tipo_empleado
        '
        Me.cbo_tipo_empleado.DisplayMember = "DESCRIPCION"
        Me.cbo_tipo_empleado.FormattingEnabled = True
        Me.cbo_tipo_empleado.Location = New System.Drawing.Point(188, 39)
        Me.cbo_tipo_empleado.Name = "cbo_tipo_empleado"
        Me.cbo_tipo_empleado.Size = New System.Drawing.Size(137, 21)
        Me.cbo_tipo_empleado.TabIndex = 49
        '
        'dgv_empleado
        '
        Me.dgv_empleado.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dgv_empleado.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgv_empleado.Location = New System.Drawing.Point(11, 202)
        Me.dgv_empleado.Name = "dgv_empleado"
        Me.dgv_empleado.Size = New System.Drawing.Size(841, 323)
        Me.dgv_empleado.TabIndex = 46
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(345, 9)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 19)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "      REPORTE EMPLEADOS"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(30, 39)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(140, 19)
        Me.Label1.TabIndex = 50
        Me.Label1.Text = "TIPO EMPLEADO"
        '
        'btn_cancelar_cuenta
        '
        Me.btn_cancelar_cuenta.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_cancelar_cuenta.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btn_cancelar_cuenta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_cancelar_cuenta.ForeColor = System.Drawing.Color.Red
        Me.btn_cancelar_cuenta.Image = CType(resources.GetObject("btn_cancelar_cuenta.Image"), System.Drawing.Image)
        Me.btn_cancelar_cuenta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_cancelar_cuenta.Location = New System.Drawing.Point(710, 539)
        Me.btn_cancelar_cuenta.Name = "btn_cancelar_cuenta"
        Me.btn_cancelar_cuenta.Size = New System.Drawing.Size(142, 34)
        Me.btn_cancelar_cuenta.TabIndex = 101
        Me.btn_cancelar_cuenta.Text = "     IMPRIMIR"
        Me.btn_cancelar_cuenta.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_actualizar_empleado)
        Me.GroupBox3.Controls.Add(Me.btn_volver_actualizaion_empleado)
        Me.GroupBox3.Location = New System.Drawing.Point(494, 57)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(268, 99)
        Me.GroupBox3.TabIndex = 102
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
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.cbo_tipo_empleado)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(123, 63)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(348, 93)
        Me.GroupBox1.TabIndex = 103
        Me.GroupBox1.TabStop = False
        '
        'Reporte_Empleados
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(864, 585)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.btn_cancelar_cuenta)
        Me.Controls.Add(Me.dgv_empleado)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Reporte_Empleados"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dgv_empleado, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cbo_tipo_empleado As System.Windows.Forms.ComboBox
    Friend WithEvents dgv_empleado As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents btn_cancelar_cuenta As System.Windows.Forms.Button
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_actualizar_empleado As System.Windows.Forms.Button
    Friend WithEvents btn_volver_actualizaion_empleado As System.Windows.Forms.Button
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
End Class
