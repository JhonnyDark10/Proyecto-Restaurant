<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Orden
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_Orden))
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.dg_tipo_ORDEN = New System.Windows.Forms.DataGridView()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btn_volver_tipo_orden = New System.Windows.Forms.Button()
        Me.btn_añadir_tipo_orden = New System.Windows.Forms.Button()
        Me.btn_nuevo_tipo_orden = New System.Windows.Forms.Button()
        Me.gbo_Datos_tipo_orden = New System.Windows.Forms.GroupBox()
        Me.txt_ingreso_nombre_orden = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox2.SuspendLayout()
        CType(Me.dg_tipo_ORDEN, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.GroupBox1.SuspendLayout()
        Me.gbo_Datos_tipo_orden.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_tipo_ORDEN)
        Me.GroupBox2.Location = New System.Drawing.Point(330, 101)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 328)
        Me.GroupBox2.TabIndex = 44
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categorias Ingresadas"
        '
        'dg_tipo_ORDEN
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dg_tipo_ORDEN.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_tipo_ORDEN.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_tipo_ORDEN.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_tipo_ORDEN.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_tipo_ORDEN.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_ORDEN.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_tipo_ORDEN.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tipo_ORDEN.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_tipo_ORDEN.Location = New System.Drawing.Point(22, 38)
        Me.dg_tipo_ORDEN.Name = "dg_tipo_ORDEN"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_ORDEN.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_tipo_ORDEN.RowHeadersWidth = 50
        Me.dg_tipo_ORDEN.Size = New System.Drawing.Size(194, 270)
        Me.dg_tipo_ORDEN.TabIndex = 33
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_volver_tipo_orden)
        Me.GroupBox1.Controls.Add(Me.btn_añadir_tipo_orden)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo_tipo_orden)
        Me.GroupBox1.Location = New System.Drawing.Point(31, 206)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 223)
        Me.GroupBox1.TabIndex = 43
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Botones"
        '
        'btn_volver_tipo_orden
        '
        Me.btn_volver_tipo_orden.BackColor = System.Drawing.Color.White
        Me.btn_volver_tipo_orden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_tipo_orden.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_tipo_orden.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_tipo_orden.Image = CType(resources.GetObject("btn_volver_tipo_orden.Image"), System.Drawing.Image)
        Me.btn_volver_tipo_orden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_tipo_orden.Location = New System.Drawing.Point(65, 162)
        Me.btn_volver_tipo_orden.Name = "btn_volver_tipo_orden"
        Me.btn_volver_tipo_orden.Size = New System.Drawing.Size(126, 35)
        Me.btn_volver_tipo_orden.TabIndex = 36
        Me.btn_volver_tipo_orden.Text = "   VOLVER"
        Me.btn_volver_tipo_orden.UseVisualStyleBackColor = False
        '
        'btn_añadir_tipo_orden
        '
        Me.btn_añadir_tipo_orden.BackColor = System.Drawing.Color.White
        Me.btn_añadir_tipo_orden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir_tipo_orden.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_tipo_orden.Image = CType(resources.GetObject("btn_añadir_tipo_orden.Image"), System.Drawing.Image)
        Me.btn_añadir_tipo_orden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_añadir_tipo_orden.Location = New System.Drawing.Point(65, 27)
        Me.btn_añadir_tipo_orden.Name = "btn_añadir_tipo_orden"
        Me.btn_añadir_tipo_orden.Size = New System.Drawing.Size(126, 39)
        Me.btn_añadir_tipo_orden.TabIndex = 34
        Me.btn_añadir_tipo_orden.Text = "   AÑADIR"
        Me.btn_añadir_tipo_orden.UseVisualStyleBackColor = False
        '
        'btn_nuevo_tipo_orden
        '
        Me.btn_nuevo_tipo_orden.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_tipo_orden.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_tipo_orden.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_tipo_orden.Image = CType(resources.GetObject("btn_nuevo_tipo_orden.Image"), System.Drawing.Image)
        Me.btn_nuevo_tipo_orden.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_tipo_orden.Location = New System.Drawing.Point(65, 93)
        Me.btn_nuevo_tipo_orden.Name = "btn_nuevo_tipo_orden"
        Me.btn_nuevo_tipo_orden.Size = New System.Drawing.Size(126, 39)
        Me.btn_nuevo_tipo_orden.TabIndex = 37
        Me.btn_nuevo_tipo_orden.Text = "   NUEVO"
        Me.btn_nuevo_tipo_orden.UseVisualStyleBackColor = False
        '
        'gbo_Datos_tipo_orden
        '
        Me.gbo_Datos_tipo_orden.Controls.Add(Me.txt_ingreso_nombre_orden)
        Me.gbo_Datos_tipo_orden.Controls.Add(Me.Label1)
        Me.gbo_Datos_tipo_orden.Location = New System.Drawing.Point(31, 95)
        Me.gbo_Datos_tipo_orden.Name = "gbo_Datos_tipo_orden"
        Me.gbo_Datos_tipo_orden.Size = New System.Drawing.Size(260, 105)
        Me.gbo_Datos_tipo_orden.TabIndex = 42
        Me.gbo_Datos_tipo_orden.TabStop = False
        Me.gbo_Datos_tipo_orden.Text = "Datos"
        '
        'txt_ingreso_nombre_orden
        '
        Me.txt_ingreso_nombre_orden.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ingreso_nombre_orden.Location = New System.Drawing.Point(27, 66)
        Me.txt_ingreso_nombre_orden.MaxLength = 20
        Me.txt_ingreso_nombre_orden.Name = "txt_ingreso_nombre_orden"
        Me.txt_ingreso_nombre_orden.Size = New System.Drawing.Size(211, 20)
        Me.txt_ingreso_nombre_orden.TabIndex = 32
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(6, 29)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 19)
        Me.Label1.TabIndex = 31
        Me.Label1.Text = "Ingresar Nombre"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(177, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(222, 22)
        Me.Label3.TabIndex = 41
        Me.Label3.Text = "      Tipo Orden Categoria"
        '
        'Tipo_Orden
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(595, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_Datos_tipo_orden)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Tipo_Orden"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo_Orden"
        Me.GroupBox2.ResumeLayout(False)
        CType(Me.dg_tipo_ORDEN, System.ComponentModel.ISupportInitialize).EndInit()
        Me.GroupBox1.ResumeLayout(False)
        Me.gbo_Datos_tipo_orden.ResumeLayout(False)
        Me.gbo_Datos_tipo_orden.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_tipo_ORDEN As System.Windows.Forms.DataGridView
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_volver_tipo_orden As System.Windows.Forms.Button
    Friend WithEvents btn_añadir_tipo_orden As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_tipo_orden As System.Windows.Forms.Button
    Friend WithEvents gbo_Datos_tipo_orden As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ingreso_nombre_orden As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
