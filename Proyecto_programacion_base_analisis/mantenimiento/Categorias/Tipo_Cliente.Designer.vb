<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Cliente
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_Cliente))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_ingreso_nombre_t_categoria = New System.Windows.Forms.TextBox()
        Me.dg_tipo_cliente = New System.Windows.Forms.DataGridView()
        Me.btn_añadir_tipo_categoria = New System.Windows.Forms.Button()
        Me.btn_volver_tipo_categoria_cli = New System.Windows.Forms.Button()
        Me.btn_nuevo_tipo_categoria = New System.Windows.Forms.Button()
        Me.gbo_Datos_tipo_categoria = New System.Windows.Forms.GroupBox()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        CType(Me.dg_tipo_cliente, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbo_Datos_tipo_categoria.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(175, 30)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(228, 22)
        Me.Label3.TabIndex = 30
        Me.Label3.Text = "      Tipo Cliente Categoria"
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
        'txt_ingreso_nombre_t_categoria
        '
        Me.txt_ingreso_nombre_t_categoria.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ingreso_nombre_t_categoria.Location = New System.Drawing.Point(27, 66)
        Me.txt_ingreso_nombre_t_categoria.MaxLength = 20
        Me.txt_ingreso_nombre_t_categoria.Name = "txt_ingreso_nombre_t_categoria"
        Me.txt_ingreso_nombre_t_categoria.Size = New System.Drawing.Size(211, 20)
        Me.txt_ingreso_nombre_t_categoria.TabIndex = 32
        '
        'dg_tipo_cliente
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dg_tipo_cliente.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_tipo_cliente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_tipo_cliente.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_tipo_cliente.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_tipo_cliente.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_cliente.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_tipo_cliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tipo_cliente.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_tipo_cliente.Location = New System.Drawing.Point(22, 38)
        Me.dg_tipo_cliente.Name = "dg_tipo_cliente"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_cliente.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_tipo_cliente.RowHeadersWidth = 50
        Me.dg_tipo_cliente.Size = New System.Drawing.Size(194, 270)
        Me.dg_tipo_cliente.TabIndex = 33
        '
        'btn_añadir_tipo_categoria
        '
        Me.btn_añadir_tipo_categoria.BackColor = System.Drawing.Color.White
        Me.btn_añadir_tipo_categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir_tipo_categoria.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_tipo_categoria.Image = CType(resources.GetObject("btn_añadir_tipo_categoria.Image"), System.Drawing.Image)
        Me.btn_añadir_tipo_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_añadir_tipo_categoria.Location = New System.Drawing.Point(65, 27)
        Me.btn_añadir_tipo_categoria.Name = "btn_añadir_tipo_categoria"
        Me.btn_añadir_tipo_categoria.Size = New System.Drawing.Size(126, 39)
        Me.btn_añadir_tipo_categoria.TabIndex = 34
        Me.btn_añadir_tipo_categoria.Text = "   AÑADIR"
        Me.btn_añadir_tipo_categoria.UseVisualStyleBackColor = False
        '
        'btn_volver_tipo_categoria_cli
        '
        Me.btn_volver_tipo_categoria_cli.BackColor = System.Drawing.Color.White
        Me.btn_volver_tipo_categoria_cli.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_volver_tipo_categoria_cli.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_tipo_categoria_cli.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_tipo_categoria_cli.Image = CType(resources.GetObject("btn_volver_tipo_categoria_cli.Image"), System.Drawing.Image)
        Me.btn_volver_tipo_categoria_cli.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_tipo_categoria_cli.Location = New System.Drawing.Point(65, 162)
        Me.btn_volver_tipo_categoria_cli.Name = "btn_volver_tipo_categoria_cli"
        Me.btn_volver_tipo_categoria_cli.Size = New System.Drawing.Size(126, 35)
        Me.btn_volver_tipo_categoria_cli.TabIndex = 36
        Me.btn_volver_tipo_categoria_cli.Text = "   VOLVER"
        Me.btn_volver_tipo_categoria_cli.UseVisualStyleBackColor = False
        '
        'btn_nuevo_tipo_categoria
        '
        Me.btn_nuevo_tipo_categoria.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_tipo_categoria.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_tipo_categoria.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_tipo_categoria.Image = CType(resources.GetObject("btn_nuevo_tipo_categoria.Image"), System.Drawing.Image)
        Me.btn_nuevo_tipo_categoria.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_tipo_categoria.Location = New System.Drawing.Point(65, 93)
        Me.btn_nuevo_tipo_categoria.Name = "btn_nuevo_tipo_categoria"
        Me.btn_nuevo_tipo_categoria.Size = New System.Drawing.Size(126, 39)
        Me.btn_nuevo_tipo_categoria.TabIndex = 37
        Me.btn_nuevo_tipo_categoria.Text = "   NUEVO"
        Me.btn_nuevo_tipo_categoria.UseVisualStyleBackColor = False
        '
        'gbo_Datos_tipo_categoria
        '
        Me.gbo_Datos_tipo_categoria.Controls.Add(Me.txt_ingreso_nombre_t_categoria)
        Me.gbo_Datos_tipo_categoria.Controls.Add(Me.Label1)
        Me.gbo_Datos_tipo_categoria.Location = New System.Drawing.Point(29, 93)
        Me.gbo_Datos_tipo_categoria.Name = "gbo_Datos_tipo_categoria"
        Me.gbo_Datos_tipo_categoria.Size = New System.Drawing.Size(260, 105)
        Me.gbo_Datos_tipo_categoria.TabIndex = 38
        Me.gbo_Datos_tipo_categoria.TabStop = False
        Me.gbo_Datos_tipo_categoria.Text = "Datos"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btn_volver_tipo_categoria_cli)
        Me.GroupBox1.Controls.Add(Me.btn_añadir_tipo_categoria)
        Me.GroupBox1.Controls.Add(Me.btn_nuevo_tipo_categoria)
        Me.GroupBox1.Location = New System.Drawing.Point(29, 204)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(260, 223)
        Me.GroupBox1.TabIndex = 39
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Botones"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.dg_tipo_cliente)
        Me.GroupBox2.Location = New System.Drawing.Point(328, 99)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(234, 328)
        Me.GroupBox2.TabIndex = 40
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Categorias Ingresadas"
        '
        'Tipo_Cliente
        '
        Me.AcceptButton = Me.btn_añadir_tipo_categoria
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.CancelButton = Me.btn_volver_tipo_categoria_cli
        Me.ClientSize = New System.Drawing.Size(595, 461)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.gbo_Datos_tipo_categoria)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tipo_Cliente"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        CType(Me.dg_tipo_cliente, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbo_Datos_tipo_categoria.ResumeLayout(False)
        Me.gbo_Datos_tipo_categoria.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_ingreso_nombre_t_categoria As System.Windows.Forms.TextBox
    Friend WithEvents dg_tipo_cliente As System.Windows.Forms.DataGridView
    Friend WithEvents btn_añadir_tipo_categoria As System.Windows.Forms.Button
    Friend WithEvents btn_volver_tipo_categoria_cli As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_tipo_categoria As System.Windows.Forms.Button
    Friend WithEvents gbo_Datos_tipo_categoria As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
End Class
