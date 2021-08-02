<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Mesas
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Mesas))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_añadir_mesas = New System.Windows.Forms.Button()
        Me.btn_nuevo_mesas = New System.Windows.Forms.Button()
        Me.btn_volver_mesas = New System.Windows.Forms.Button()
        Me.gbo_datos_mesas = New System.Windows.Forms.GroupBox()
        Me.txt_ingresa_mesas = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_tipo_mesas = New System.Windows.Forms.DataGridView()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox3.SuspendLayout()
        Me.gbo_datos_mesas.SuspendLayout()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_tipo_mesas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_añadir_mesas)
        Me.GroupBox3.Controls.Add(Me.btn_nuevo_mesas)
        Me.GroupBox3.Controls.Add(Me.btn_volver_mesas)
        Me.GroupBox3.Location = New System.Drawing.Point(28, 192)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 210)
        Me.GroupBox3.TabIndex = 51
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Botones"
        '
        'btn_añadir_mesas
        '
        Me.btn_añadir_mesas.BackColor = System.Drawing.Color.White
        Me.btn_añadir_mesas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir_mesas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_mesas.Image = CType(resources.GetObject("btn_añadir_mesas.Image"), System.Drawing.Image)
        Me.btn_añadir_mesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_añadir_mesas.Location = New System.Drawing.Point(48, 19)
        Me.btn_añadir_mesas.Name = "btn_añadir_mesas"
        Me.btn_añadir_mesas.Size = New System.Drawing.Size(126, 39)
        Me.btn_añadir_mesas.TabIndex = 44
        Me.btn_añadir_mesas.Text = "   AÑADIR"
        Me.btn_añadir_mesas.UseVisualStyleBackColor = False
        '
        'btn_nuevo_mesas
        '
        Me.btn_nuevo_mesas.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_mesas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_mesas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_mesas.Image = CType(resources.GetObject("btn_nuevo_mesas.Image"), System.Drawing.Image)
        Me.btn_nuevo_mesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_mesas.Location = New System.Drawing.Point(48, 89)
        Me.btn_nuevo_mesas.Name = "btn_nuevo_mesas"
        Me.btn_nuevo_mesas.Size = New System.Drawing.Size(126, 39)
        Me.btn_nuevo_mesas.TabIndex = 45
        Me.btn_nuevo_mesas.Text = "   NUEVO"
        Me.btn_nuevo_mesas.UseVisualStyleBackColor = False
        '
        'btn_volver_mesas
        '
        Me.btn_volver_mesas.BackColor = System.Drawing.Color.White
        Me.btn_volver_mesas.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_mesas.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_mesas.Image = CType(resources.GetObject("btn_volver_mesas.Image"), System.Drawing.Image)
        Me.btn_volver_mesas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_mesas.Location = New System.Drawing.Point(48, 155)
        Me.btn_volver_mesas.Name = "btn_volver_mesas"
        Me.btn_volver_mesas.Size = New System.Drawing.Size(126, 36)
        Me.btn_volver_mesas.TabIndex = 43
        Me.btn_volver_mesas.Text = "   VOLVER"
        Me.btn_volver_mesas.UseVisualStyleBackColor = False
        '
        'gbo_datos_mesas
        '
        Me.gbo_datos_mesas.Controls.Add(Me.txt_ingresa_mesas)
        Me.gbo_datos_mesas.Controls.Add(Me.Label1)
        Me.gbo_datos_mesas.Location = New System.Drawing.Point(25, 82)
        Me.gbo_datos_mesas.Name = "gbo_datos_mesas"
        Me.gbo_datos_mesas.Size = New System.Drawing.Size(242, 100)
        Me.gbo_datos_mesas.TabIndex = 50
        Me.gbo_datos_mesas.TabStop = False
        Me.gbo_datos_mesas.Text = "Datos"
        '
        'txt_ingresa_mesas
        '
        Me.txt_ingresa_mesas.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ingresa_mesas.Location = New System.Drawing.Point(45, 59)
        Me.txt_ingresa_mesas.MaxLength = 10
        Me.txt_ingresa_mesas.Name = "txt_ingresa_mesas"
        Me.txt_ingresa_mesas.Size = New System.Drawing.Size(177, 20)
        Me.txt_ingresa_mesas.TabIndex = 39
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(21, 26)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(66, 19)
        Me.Label1.TabIndex = 38
        Me.Label1.Text = "Ingresar"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg_tipo_mesas)
        Me.GroupBox1.Location = New System.Drawing.Point(343, 82)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 320)
        Me.GroupBox1.TabIndex = 49
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categorias Ingresadas"
        '
        'dg_tipo_mesas
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dg_tipo_mesas.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_tipo_mesas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_tipo_mesas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_tipo_mesas.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_tipo_mesas.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_mesas.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_tipo_mesas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tipo_mesas.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_tipo_mesas.Location = New System.Drawing.Point(16, 25)
        Me.dg_tipo_mesas.Name = "dg_tipo_mesas"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_mesas.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_tipo_mesas.RowHeadersWidth = 50
        Me.dg_tipo_mesas.Size = New System.Drawing.Size(194, 270)
        Me.dg_tipo_mesas.TabIndex = 34
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(249, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(93, 22)
        Me.Label3.TabIndex = 48
        Me.Label3.Text = "      Mesas"
        '
        'Mesas
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(595, 461)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbo_datos_mesas)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Mesas"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mesas"
        Me.GroupBox3.ResumeLayout(False)
        Me.gbo_datos_mesas.ResumeLayout(False)
        Me.gbo_datos_mesas.PerformLayout()
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_tipo_mesas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_añadir_mesas As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_mesas As System.Windows.Forms.Button
    Friend WithEvents btn_volver_mesas As System.Windows.Forms.Button
    Friend WithEvents gbo_datos_mesas As System.Windows.Forms.GroupBox
    Friend WithEvents txt_ingresa_mesas As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_tipo_mesas As System.Windows.Forms.DataGridView
    Friend WithEvents Label3 As System.Windows.Forms.Label
End Class
