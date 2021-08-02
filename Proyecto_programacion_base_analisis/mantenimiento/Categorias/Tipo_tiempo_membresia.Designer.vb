<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_tiempo_membresia
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
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_tiempo_membresia))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg_tipo_t_m = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_volver_t_m = New System.Windows.Forms.Button()
        Me.btn_añadir_t_m = New System.Windows.Forms.Button()
        Me.btn_nuevo_tm = New System.Windows.Forms.Button()
        Me.gbo_Datos_tipo_t_m = New System.Windows.Forms.GroupBox()
        Me.txt_ingreso_nombre_t_m = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_tipo_t_m, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbo_Datos_tipo_t_m.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_tipo_t_m)
        Me.GroupBox2.Location = New System.Drawing.Point(316, 87)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 328)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categorias Ingresadas"
        '
        'dg_tipo_t_m
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dg_tipo_t_m.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_tipo_t_m.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_tipo_t_m.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_tipo_t_m.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_tipo_t_m.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_t_m.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_tipo_t_m.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tipo_t_m.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_tipo_t_m.Location = New System.Drawing.Point(22, 38)
        Me.dg_tipo_t_m.Name = "dg_tipo_t_m"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_t_m.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_tipo_t_m.RowHeadersWidth = 50
        Me.dg_tipo_t_m.Size = New System.Drawing.Size(194, 270)
        Me.dg_tipo_t_m.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_volver_t_m)
        Me.GroupBox1.Controls.Add(Me.btn_añadir_t_m)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo_tm)
        Me.GroupBox1.Location = New System.Drawing.Point(17, 192)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 223)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Botones"
        '
        'btn_volver_t_m
        '
        Me.btn_volver_t_m.BackColor = System.Drawing.Color.White
        Me.btn_volver_t_m.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_t_m.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_t_m.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_t_m.Image = CType(resources.GetObject("btn_volver_t_m.Image"), System.Drawing.Image)
        Me.btn_volver_t_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_t_m.Location = New System.Drawing.Point(65, 162)
        Me.btn_volver_t_m.Name = "btn_volver_t_m"
        Me.btn_volver_t_m.Size = New System.Drawing.Size(126, 35)
        Me.btn_volver_t_m.TabIndex = 36
        Me.btn_volver_t_m.Text = "   VOLVER"
        Me.btn_volver_t_m.UseVisualStyleBackColor = False
        '
        'btn_añadir_t_m
        '
        Me.btn_añadir_t_m.BackColor = System.Drawing.Color.White
        Me.btn_añadir_t_m.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir_t_m.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_t_m.Image = CType(resources.GetObject("btn_añadir_t_m.Image"), System.Drawing.Image)
        Me.btn_añadir_t_m.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_añadir_t_m.Location = New System.Drawing.Point(65, 27)
        Me.btn_añadir_t_m.Name = "btn_añadir_t_m"
        Me.btn_añadir_t_m.Size = New System.Drawing.Size(126, 39)
        Me.btn_añadir_t_m.TabIndex = 34
        Me.btn_añadir_t_m.Text = "   AÑADIR"
        Me.btn_añadir_t_m.UseVisualStyleBackColor = False
        '
        'btn_nuevo_tm
        '
        Me.btn_nuevo_tm.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_tm.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_tm.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_tm.Image = CType(resources.GetObject("btn_nuevo_tm.Image"), System.Drawing.Image)
        Me.btn_nuevo_tm.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_tm.Location = New System.Drawing.Point(65, 93)
        Me.btn_nuevo_tm.Name = "btn_nuevo_tm"
        Me.btn_nuevo_tm.Size = New System.Drawing.Size(126, 39)
        Me.btn_nuevo_tm.TabIndex = 37
        Me.btn_nuevo_tm.Text = "   NUEVO"
        Me.btn_nuevo_tm.UseVisualStyleBackColor = False
        '
        'gbo_Datos_tipo_t_m
        '
        Me.gbo_Datos_tipo_t_m.Controls.Add(Me.txt_ingreso_nombre_t_m)
        Me.gbo_Datos_tipo_t_m.Controls.Add(Me.Label1)
        Me.gbo_Datos_tipo_t_m.Location = New System.Drawing.Point(17, 81)
        Me.gbo_Datos_tipo_t_m.Name = "gbo_Datos_tipo_t_m"
        Me.gbo_Datos_tipo_t_m.Size = New System.Drawing.Size(260, 105)
        Me.gbo_Datos_tipo_t_m.TabIndex = 42
        Me.gbo_Datos_tipo_t_m.TabStop = False
        Me.gbo_Datos_tipo_t_m.Text = "Datos"
        '
        'txt_ingreso_nombre_t_m
        '
        Me.txt_ingreso_nombre_t_m.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ingreso_nombre_t_m.Location = New System.Drawing.Point(27, 66)
        Me.txt_ingreso_nombre_t_m.MaxLength = 20
        Me.txt_ingreso_nombre_t_m.Name = "txt_ingreso_nombre_t_m"
        Me.txt_ingreso_nombre_t_m.Size = New System.Drawing.Size(164, 20)
        Me.txt_ingreso_nombre_t_m.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(142, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Ingresar Modalidad"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(163, 18)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(242, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "      Tipo Tiempo Membresia"
        '
        'Tipo_tiempo_membresia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(595, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_Datos_tipo_t_m)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Tipo_tiempo_membresia"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo_tiempo_membresia"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg_tipo_t_m, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbo_Datos_tipo_t_m.ResumeLayout(False)
        Me.gbo_Datos_tipo_t_m.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_tipo_t_m As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_volver_t_m As System.Windows.Forms.Button
    Friend WithEvents btn_añadir_t_m As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_tm As System.Windows.Forms.Button
    Friend WithEvents gbo_Datos_tipo_t_m As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ingreso_nombre_t_m As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
