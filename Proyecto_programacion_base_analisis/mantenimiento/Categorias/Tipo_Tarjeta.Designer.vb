<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Tarjeta
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_Tarjeta))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_añadir_tipo_categoria_tarjeta = New System.Windows.Forms.Button()
        Me.btn_nuevo_tipo_categoria_tarjeta = New System.Windows.Forms.Button()
        Me.btn_volver_tipo_categoria_tarjeta = New System.Windows.Forms.Button()
        Me.gbo_datos_tarjetas = New System.Windows.Forms.GroupBox()
        Me.txt_ingresa_tipo_tarjeta = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_tipo_tarjeta = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.gbo_datos_tarjetas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_tipo_tarjeta, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_añadir_tipo_categoria_tarjeta)
        Me.GroupBox3.Controls.Add(Me.btn_nuevo_tipo_categoria_tarjeta)
        Me.GroupBox3.Controls.Add(Me.btn_volver_tipo_categoria_tarjeta)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 207)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 210)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Botones"
        '
        'btn_añadir_tipo_categoria_tarjeta
        '
        Me.btn_añadir_tipo_categoria_tarjeta.BackColor = System.Drawing.Color.White
        Me.btn_añadir_tipo_categoria_tarjeta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir_tipo_categoria_tarjeta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_tipo_categoria_tarjeta.Image = CType(resources.GetObject("btn_añadir_tipo_categoria_tarjeta.Image"), System.Drawing.Image)
        Me.btn_añadir_tipo_categoria_tarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_añadir_tipo_categoria_tarjeta.Location = New System.Drawing.Point(48, 19)
        Me.btn_añadir_tipo_categoria_tarjeta.Name = "btn_añadir_tipo_categoria_tarjeta"
        Me.btn_añadir_tipo_categoria_tarjeta.Size = New System.Drawing.Size(126, 39)
        Me.btn_añadir_tipo_categoria_tarjeta.TabIndex = 44
        Me.btn_añadir_tipo_categoria_tarjeta.Text = "   AÑADIR"
        Me.btn_añadir_tipo_categoria_tarjeta.UseVisualStyleBackColor = False
        '
        'btn_nuevo_tipo_categoria_tarjeta
        '
        Me.btn_nuevo_tipo_categoria_tarjeta.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_tipo_categoria_tarjeta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_tipo_categoria_tarjeta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_tipo_categoria_tarjeta.Image = CType(resources.GetObject("btn_nuevo_tipo_categoria_tarjeta.Image"), System.Drawing.Image)
        Me.btn_nuevo_tipo_categoria_tarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_tipo_categoria_tarjeta.Location = New System.Drawing.Point(48, 86)
        Me.btn_nuevo_tipo_categoria_tarjeta.Name = "btn_nuevo_tipo_categoria_tarjeta"
        Me.btn_nuevo_tipo_categoria_tarjeta.Size = New System.Drawing.Size(126, 39)
        Me.btn_nuevo_tipo_categoria_tarjeta.TabIndex = 45
        Me.btn_nuevo_tipo_categoria_tarjeta.Text = "   NUEVO"
        Me.btn_nuevo_tipo_categoria_tarjeta.UseVisualStyleBackColor = False
        '
        'btn_volver_tipo_categoria_tarjeta
        '
        Me.btn_volver_tipo_categoria_tarjeta.BackColor = System.Drawing.Color.White
        Me.btn_volver_tipo_categoria_tarjeta.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_tipo_categoria_tarjeta.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_tipo_categoria_tarjeta.Image = CType(resources.GetObject("btn_volver_tipo_categoria_tarjeta.Image"), System.Drawing.Image)
        Me.btn_volver_tipo_categoria_tarjeta.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_tipo_categoria_tarjeta.Location = New System.Drawing.Point(48, 155)
        Me.btn_volver_tipo_categoria_tarjeta.Name = "btn_volver_tipo_categoria_tarjeta"
        Me.btn_volver_tipo_categoria_tarjeta.Size = New System.Drawing.Size(126, 36)
        Me.btn_volver_tipo_categoria_tarjeta.TabIndex = 43
        Me.btn_volver_tipo_categoria_tarjeta.Text = "   VOLVER"
        Me.btn_volver_tipo_categoria_tarjeta.UseVisualStyleBackColor = False
        '
        'gbo_datos_tarjetas
        '
        Me.gbo_datos_tarjetas.Controls.Add(Me.txt_ingresa_tipo_tarjeta)
        Me.gbo_datos_tarjetas.Controls.Add(Me.Label1)
        Me.gbo_datos_tarjetas.Location = New System.Drawing.Point(25, 97)
        Me.gbo_datos_tarjetas.Name = "gbo_datos_tarjetas"
        Me.gbo_datos_tarjetas.Size = New System.Drawing.Size(242, 100)
        Me.gbo_datos_tarjetas.TabIndex = 50
        Me.gbo_datos_tarjetas.TabStop = False
        Me.gbo_datos_tarjetas.Text = "Datos"
        '
        'txt_ingresa_tipo_tarjeta
        '
        Me.txt_ingresa_tipo_tarjeta.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ingresa_tipo_tarjeta.Location = New System.Drawing.Point(45, 59)
        Me.txt_ingresa_tipo_tarjeta.MaxLength = 20
        Me.txt_ingresa_tipo_tarjeta.Name = "txt_ingresa_tipo_tarjeta"
        Me.txt_ingresa_tipo_tarjeta.Size = New System.Drawing.Size(177, 20)
        Me.txt_ingresa_tipo_tarjeta.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(124, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Ingresar Nombre"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg_tipo_tarjeta)
        Me.GroupBox1.Location = New System.Drawing.Point(343, 97)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 320)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categorias Ingresadas"
        '
        'dg_tipo_tarjeta
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dg_tipo_tarjeta.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_tipo_tarjeta.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_tipo_tarjeta.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_tipo_tarjeta.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_tipo_tarjeta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_tarjeta.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_tipo_tarjeta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tipo_tarjeta.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_tipo_tarjeta.Location = New System.Drawing.Point(16, 25)
        Me.dg_tipo_tarjeta.Name = "dg_tipo_tarjeta"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_tarjeta.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_tipo_tarjeta.RowHeadersWidth = 50
        Me.dg_tipo_tarjeta.Size = New System.Drawing.Size(194, 270)
        Me.dg_tipo_tarjeta.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(190, 44)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(210, 22)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "      Tipo Tarjeta Credito"
        '
        'Tipo_Tarjeta
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(595, 461)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbo_datos_tarjetas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Tipo_Tarjeta"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo_Tarjeta"
        Me.GroupBox3.ResumeLayout(False)
        Me.gbo_datos_tarjetas.ResumeLayout(False)
        Me.gbo_datos_tarjetas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_tipo_tarjeta, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_añadir_tipo_categoria_tarjeta As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_tipo_categoria_tarjeta As System.Windows.Forms.Button
    Friend WithEvents btn_volver_tipo_categoria_tarjeta As System.Windows.Forms.Button
    Friend WithEvents gbo_datos_tarjetas As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ingresa_tipo_tarjeta As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_tipo_tarjeta As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
