﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Tipo_Platos
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Tipo_Platos))
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.txt_ingresa_tipo_plato = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.dg_tipo_plato = New System.Windows.Forms.DataGridView()
        Me.gbo_datos_platos = New System.Windows.Forms.GroupBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.btn_añadir_tipo_categoria_p = New System.Windows.Forms.Button()
        Me.btn_nuevo_tipo_categoria_p = New System.Windows.Forms.Button()
        Me.btn_volver_tipo_categoria_p = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        CType(Me.dg_tipo_plato, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.gbo_datos_platos.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'txt_ingresa_tipo_plato
        '
        Me.txt_ingresa_tipo_plato.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper
        Me.txt_ingresa_tipo_plato.Location = New System.Drawing.Point(45, 59)
        Me.txt_ingresa_tipo_plato.MaxLength = 20
        Me.txt_ingresa_tipo_plato.Name = "txt_ingresa_tipo_plato"
        Me.txt_ingresa_tipo_plato.Size = New System.Drawing.Size(177, 20)
        Me.txt_ingresa_tipo_plato.TabIndex = 39
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
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Red
        Me.Label3.Image = CType(resources.GetObject("Label3.Image"), System.Drawing.Image)
        Me.Label3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.Label3.Location = New System.Drawing.Point(192, 33)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(221, 22)
        Me.Label3.TabIndex = 37
        Me.Label3.Text = "      Tipo Platos Categoria"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.dg_tipo_plato)
        Me.GroupBox1.Location = New System.Drawing.Point(345, 86)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(226, 320)
        Me.GroupBox1.TabIndex = 45
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Categorias Ingresadas"
        '
        'dg_tipo_plato
        '
        DataGridViewCellStyle1.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText
        Me.dg_tipo_plato.AlternatingRowsDefaultCellStyle = DataGridViewCellStyle1
        Me.dg_tipo_plato.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.dg_tipo_plato.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.dg_tipo_plato.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.dg_tipo_plato.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Sunken
        DataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer))
        DataGridViewCellStyle2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_plato.ColumnHeadersDefaultCellStyle = DataGridViewCellStyle2
        Me.dg_tipo_plato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dg_tipo_plato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.dg_tipo_plato.Location = New System.Drawing.Point(16, 25)
        Me.dg_tipo_plato.Name = "dg_tipo_plato"
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[True]
        Me.dg_tipo_plato.RowHeadersDefaultCellStyle = DataGridViewCellStyle3
        Me.dg_tipo_plato.RowHeadersWidth = 50
        Me.dg_tipo_plato.Size = New System.Drawing.Size(194, 270)
        Me.dg_tipo_plato.TabIndex = 34
        '
        'gbo_datos_platos
        '
        Me.gbo_datos_platos.Controls.Add(Me.txt_ingresa_tipo_plato)
        Me.gbo_datos_platos.Controls.Add(Me.Label1)
        Me.gbo_datos_platos.Location = New System.Drawing.Point(27, 86)
        Me.gbo_datos_platos.Name = "gbo_datos_platos"
        Me.gbo_datos_platos.Size = New System.Drawing.Size(242, 100)
        Me.gbo_datos_platos.TabIndex = 46
        Me.gbo_datos_platos.TabStop = False
        Me.gbo_datos_platos.Text = "Datos"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.btn_añadir_tipo_categoria_p)
        Me.GroupBox3.Controls.Add(Me.btn_nuevo_tipo_categoria_p)
        Me.GroupBox3.Controls.Add(Me.btn_volver_tipo_categoria_p)
        Me.GroupBox3.Location = New System.Drawing.Point(30, 196)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(239, 210)
        Me.GroupBox3.TabIndex = 47
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Botones"
        '
        'btn_añadir_tipo_categoria_p
        '
        Me.btn_añadir_tipo_categoria_p.BackColor = System.Drawing.Color.White
        Me.btn_añadir_tipo_categoria_p.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_añadir_tipo_categoria_p.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_añadir_tipo_categoria_p.Image = CType(resources.GetObject("btn_añadir_tipo_categoria_p.Image"), System.Drawing.Image)
        Me.btn_añadir_tipo_categoria_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_añadir_tipo_categoria_p.Location = New System.Drawing.Point(48, 19)
        Me.btn_añadir_tipo_categoria_p.Name = "btn_añadir_tipo_categoria_p"
        Me.btn_añadir_tipo_categoria_p.Size = New System.Drawing.Size(126, 39)
        Me.btn_añadir_tipo_categoria_p.TabIndex = 44
        Me.btn_añadir_tipo_categoria_p.Text = "   AÑADIR"
        Me.btn_añadir_tipo_categoria_p.UseVisualStyleBackColor = False
        '
        'btn_nuevo_tipo_categoria_p
        '
        Me.btn_nuevo_tipo_categoria_p.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_tipo_categoria_p.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_tipo_categoria_p.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_tipo_categoria_p.Image = CType(resources.GetObject("btn_nuevo_tipo_categoria_p.Image"), System.Drawing.Image)
        Me.btn_nuevo_tipo_categoria_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_tipo_categoria_p.Location = New System.Drawing.Point(48, 84)
        Me.btn_nuevo_tipo_categoria_p.Name = "btn_nuevo_tipo_categoria_p"
        Me.btn_nuevo_tipo_categoria_p.Size = New System.Drawing.Size(126, 39)
        Me.btn_nuevo_tipo_categoria_p.TabIndex = 45
        Me.btn_nuevo_tipo_categoria_p.Text = "   NUEVO"
        Me.btn_nuevo_tipo_categoria_p.UseVisualStyleBackColor = False
        '
        'btn_volver_tipo_categoria_p
        '
        Me.btn_volver_tipo_categoria_p.BackColor = System.Drawing.Color.White
        Me.btn_volver_tipo_categoria_p.DialogResult = System.Windows.Forms.DialogResult.Cancel
        Me.btn_volver_tipo_categoria_p.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_volver_tipo_categoria_p.Image = CType(resources.GetObject("btn_volver_tipo_categoria_p.Image"), System.Drawing.Image)
        Me.btn_volver_tipo_categoria_p.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_volver_tipo_categoria_p.Location = New System.Drawing.Point(48, 155)
        Me.btn_volver_tipo_categoria_p.Name = "btn_volver_tipo_categoria_p"
        Me.btn_volver_tipo_categoria_p.Size = New System.Drawing.Size(126, 36)
        Me.btn_volver_tipo_categoria_p.TabIndex = 43
        Me.btn_volver_tipo_categoria_p.Text = "   VOLVER"
        Me.btn_volver_tipo_categoria_p.UseVisualStyleBackColor = False
        '
        'Tipo_Platos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(595, 461)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.gbo_datos_platos)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Tipo_Platos"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tipo_Platos"
        Me.GroupBox1.ResumeLayout(False)
        CType(Me.dg_tipo_plato, System.ComponentModel.ISupportInitialize).EndInit()
        Me.gbo_datos_platos.ResumeLayout(False)
        Me.gbo_datos_platos.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txt_ingresa_tipo_plato As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents dg_tipo_plato As System.Windows.Forms.DataGridView
    Friend WithEvents gbo_datos_platos As System.Windows.Forms.GroupBox
    Friend WithEvents GroupBox3 As System.Windows.Forms.GroupBox
    Friend WithEvents btn_añadir_tipo_categoria_p As System.Windows.Forms.Button
    Friend WithEvents btn_nuevo_tipo_categoria_p As System.Windows.Forms.Button
    Friend WithEvents btn_volver_tipo_categoria_p As System.Windows.Forms.Button
End Class
