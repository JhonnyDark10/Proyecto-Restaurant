<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class PAGO
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(PAGO))
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txt_ingrese_caja = New System.Windows.Forms.TextBox()
        Me.txt_pago_caja = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txt_cambio_caja = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.btn_nuevo_plato = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label20 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(34, 89)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(112, 19)
        Me.Label3.TabIndex = 65
        Me.Label3.Text = "Ingrese Efetivo"
        '
        'txt_ingrese_caja
        '
        Me.txt_ingrese_caja.Location = New System.Drawing.Point(218, 90)
        Me.txt_ingrese_caja.MaxLength = 10
        Me.txt_ingrese_caja.Name = "txt_ingrese_caja"
        Me.txt_ingrese_caja.Size = New System.Drawing.Size(100, 20)
        Me.txt_ingrese_caja.TabIndex = 66
        '
        'txt_pago_caja
        '
        Me.txt_pago_caja.Location = New System.Drawing.Point(218, 61)
        Me.txt_pago_caja.Name = "txt_pago_caja"
        Me.txt_pago_caja.Size = New System.Drawing.Size(100, 20)
        Me.txt_pago_caja.TabIndex = 68
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Black
        Me.Label1.Location = New System.Drawing.Point(35, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(98, 19)
        Me.Label1.TabIndex = 67
        Me.Label1.Text = "Total a Pagar"
        '
        'txt_cambio_caja
        '
        Me.txt_cambio_caja.Location = New System.Drawing.Point(218, 125)
        Me.txt_cambio_caja.Name = "txt_cambio_caja"
        Me.txt_cambio_caja.Size = New System.Drawing.Size(100, 20)
        Me.txt_cambio_caja.TabIndex = 70
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.Black
        Me.Label2.Location = New System.Drawing.Point(36, 124)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(60, 19)
        Me.Label2.TabIndex = 69
        Me.Label2.Text = "Cambio"
        '
        'btn_nuevo_plato
        '
        Me.btn_nuevo_plato.BackColor = System.Drawing.Color.White
        Me.btn_nuevo_plato.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.btn_nuevo_plato.Cursor = System.Windows.Forms.Cursors.Hand
        Me.btn_nuevo_plato.FlatAppearance.BorderColor = System.Drawing.Color.Red
        Me.btn_nuevo_plato.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White
        Me.btn_nuevo_plato.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.btn_nuevo_plato.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btn_nuevo_plato.ForeColor = System.Drawing.Color.Black
        Me.btn_nuevo_plato.Image = CType(resources.GetObject("btn_nuevo_plato.Image"), System.Drawing.Image)
        Me.btn_nuevo_plato.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btn_nuevo_plato.Location = New System.Drawing.Point(99, 162)
        Me.btn_nuevo_plato.Name = "btn_nuevo_plato"
        Me.btn_nuevo_plato.Size = New System.Drawing.Size(141, 37)
        Me.btn_nuevo_plato.TabIndex = 84
        Me.btn_nuevo_plato.Text = "   ACEPTAR"
        Me.btn_nuevo_plato.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(-3, -4)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(361, 24)
        Me.Label4.TabIndex = 99
        '
        'Label20
        '
        Me.Label20.AutoSize = True
        Me.Label20.Font = New System.Drawing.Font("Times New Roman", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label20.ForeColor = System.Drawing.Color.Blue
        Me.Label20.Location = New System.Drawing.Point(147, 20)
        Me.Label20.Name = "Label20"
        Me.Label20.Size = New System.Drawing.Size(50, 19)
        Me.Label20.TabIndex = 100
        Me.Label20.Text = "CAJA"
        '
        'PAGO
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.White
        Me.ClientSize = New System.Drawing.Size(338, 213)
        Me.Controls.Add(Me.Label20)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.btn_nuevo_plato)
        Me.Controls.Add(Me.txt_cambio_caja)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txt_pago_caja)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txt_ingrese_caja)
        Me.Controls.Add(Me.Label3)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "PAGO"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "PAGO"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents txt_ingrese_caja As System.Windows.Forms.TextBox
    Friend WithEvents txt_pago_caja As System.Windows.Forms.TextBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txt_cambio_caja As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents btn_nuevo_plato As System.Windows.Forms.Button
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label20 As System.Windows.Forms.Label
End Class
