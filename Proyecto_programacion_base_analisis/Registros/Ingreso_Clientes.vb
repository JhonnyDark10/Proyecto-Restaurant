Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.IO
Public Class Ingreso_Clientes
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Private Sub IngresoClientes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_email_cliente.Text = "example@hotmail.com"
        txt_fecha_cliente.Text = DateTime.Now.ToString("dd/MM/yyyy")
        Pagina_Principal.Opacity = 85%
        Pagina_Principal.Enabled = False
        gbo_membresia_cliente.Enabled = False
        desactivar()
        llenar_combo_tipo_cliente()
        llenar_combo_tiempo_membresia()
    End Sub

    Private Sub llenar_combo_tiempo_membresia()
        Try
            sql = "SELECT *from TIPO_TIEMPO_MEMBRESIA"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_dias_año_cliente.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub


    Private Sub llenar_combo_tipo_cliente()
        Try
            sql = "SELECT *from TIPO_CLIENTE"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_categoria_cliente.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub desactivar()
        cbo_categoria_cliente.Enabled = False
        gbo_membresia_cliente.Enabled = False
        btn_guardar_cliente.Enabled = False
        gbo_datos_cliente.Enabled = False
    End Sub

    Private Sub BTN_VOLVER_CLIENTE_Click(sender As Object, e As EventArgs)
        Close()
        Dispose()
    End Sub



    Private Sub btn_volver_empleado_r_Click(sender As Object, e As EventArgs) Handles btn_volver_cliente.Click
        Pagina_Principal.Opacity = 100%
        Pagina_Principal.Enabled = True
        Close()
        Dispose()
    End Sub


    Private Sub btn_guardar_cliente_Click(sender As Object, e As EventArgs) Handles btn_guardar_cliente.Click

        Dim codigo As Integer
        If (txt_nombre_cliente.Text = "" And txt_apellido1_cliente.Text = "") Then
            MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            Try
                sql = "INSERT INTO CLIENTES(FK_ID_TIPO_CLIENTE, CEDULA, NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, DIRECCION, EMAIL, FECHA_NACIMIENTO, TELEFONO, ESTADO_C) VALUES ("
                sql = sql & Val(cbo_categoria_cliente.SelectedValue) & ", "
                sql = sql & Trim(txt_cedula_cliente.Text) & ", "
                sql = sql & "'" & Trim(txt_nombre_cliente.Text) & "', "
                sql = sql & "'" & Trim(txt_apellido1_cliente.Text) & "', "
                sql = sql & "'" & Trim(txt_apelldio2_cliente.Text) & "', "
                sql = sql & "'" & Trim(txt_direccion_cliente.Text) & "', "
                sql = sql & "'" & Trim(txt_email_cliente.Text) & "', "
                sql = sql & "'" & Trim(txt_fecha_cliente.Text) & "', "
                sql = sql & Trim(txt_telefono_cliente.Text) & ", "
                sql = sql & "'A" & "') "
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

                '----PARA OBTENER EL ULTIMO ID DEL CLIENTE ALMACENADO-------

                sql = "SELECT MAX(DNI_CLIENTE) as id_codigo_c FROM CLIENTES "
                Dim re As SqlDataReader
                Dim con As New SqlCommand(sql, mycon)

                Dim dt As New DataTable
                re = con.ExecuteReader()
                dt.Load(re)

                If dt.Rows.Count > 0 Then
                    codigo = dt.Rows(0)("id_codigo_c")
                End If
                re.Close()

                '-----------------------------------------------------

                If (txt_valor_pago_cliente.Text = "" And cbo_categoria_cliente.Text <> "CLASICO") Then
                    MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)

                Else
                    Try
                        sql = "INSERT INTO MEMBRESIA(FK_DNI_CLIENTES, FK_DNI_T_M, VALOR_PAGO, FECHA_APERTURA, FECHA_CADUCIDAD, FECHA_RENOVACION, ESTADO_M) VALUES ("
                        sql = sql & codigo & ", "
                        sql = sql & Val(cbo_dias_año_cliente.SelectedValue) & ", "
                        sql = sql & Val(txt_valor_pago_cliente.Text) & ", "
                        sql = sql & "'" & Trim(fecha_apertura_ingreso_c.Text) & "', "
                        sql = sql & "'" & Trim(txt_fecha_caducidad.Text) & "', "
                        sql = sql & "'" & Trim(txt_fecha_renovacion_cliente.Text) & "', "
                        sql = sql & "'A" & "')"
                        Dim com2 As New SqlCommand(sql, mycon)
                        Dim x_1 As Integer
                        x_1 = com2.ExecuteNonQuery

                    Catch ex As Exception
                        MsgBox("no se a podido guardar membresia" & ex.Message)
                    End Try
                End If
                MsgBox("CLIENTE ALMACENADO CORRECTAMENTE")
            Catch ex As Exception
                MsgBox("no se a podido guardar los datos cliente" & ex.Message)
            End Try
        End If
        txt_codigo_obtener.Text = codigo
        desactivar()
        limpiar()
    End Sub


    Private Sub btn_ir_factura_Click(sender As Object, e As EventArgs) Handles btn_ir_factura.Click
        Registra_Datos_Factura.Show()
        Me.Close()
        Registra_Datos_Factura.Enabled = True
        Registra_Datos_Factura.Opacity = 100%
    End Sub

    Private Sub btn_nuevo_cliente_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cliente.Click
        txt_email_cliente.Text = "example@hotmail.com"
        btn_guardar_cliente.Enabled = True
        gbo_datos_cliente.Enabled = True
        gbo_membresia_cliente.Enabled = False
        cbo_categoria_cliente.Enabled = True
        Me.txt_cedula_cliente.Focus()
    End Sub


    Private Sub limpiar()
        txt_cedula_cliente.Text = ""
        txt_nombre_cliente.Text = ""
        txt_apellido1_cliente.Text = ""
        txt_apelldio2_cliente.Text = ""
        txt_direccion_cliente.Text = ""
        txt_email_cliente.Text = "example@hotmail.com"
        txt_fecha_cliente.Text = ""
        txt_telefono_cliente.Text = ""
        cbo_categoria_cliente.Text = ""
        txt_valor_pago_cliente.Text = ""
        fecha_apertura_ingreso_c.Text = ""
        txt_numero_ingreso_c.Text = ""
        cbo_dias_año_cliente.Text = ""
        txt_fecha_caducidad.Text = ""
        txt_fecha_renovacion_cliente.Text = ""
    End Sub

    Private Sub txt_valor_pago_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_valor_pago_cliente.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_valor_pago_cliente.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_valor_pago_cliente.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_valor_pago_cliente.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_valor_pago_cliente.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_nombre_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_cliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_apellido1_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido1_cliente.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_apelldio2_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apelldio2_cliente.KeyPress

        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_cedula_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula_cliente.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_cedula_cliente.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_cliente.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_cedula_cliente.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_cliente.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_telefono_cliente_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono_cliente.KeyPress
        If InStr(1, "0123456789" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_telefono_cliente.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_cliente.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_telefono_cliente.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_cliente.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub


    Private Sub cbo_dias_año_cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_dias_año_cliente.SelectedIndexChanged
        Dim x As Integer
        If (cbo_dias_año_cliente.Text = "MES") Then
            x = 30 * Val(txt_numero_ingreso_c.Text)
        Else
            x = 365 * Val(txt_numero_ingreso_c.Text)
        End If

        Dim sig As Date = fecha_apertura_ingreso_c.Value.Date
        sig = Format(sig.AddDays(x), "dd/MM/yyyy")
        txt_fecha_caducidad.Text = sig

        Dim sig1 As Date = sig
        sig = Format(sig.AddDays(15), "dd/MM/yyyy")
        txt_fecha_renovacion_cliente.Text = sig
    End Sub

    Private Sub cbo_categoria_cliente_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_categoria_cliente.SelectedIndexChanged
        If (cbo_categoria_cliente.Text = "CLASICO") Then
            gbo_membresia_cliente.Enabled = False
        Else
            gbo_membresia_cliente.Enabled = True
        End If
    End Sub

    'Private Sub txt_cedula_cliente_TextChanged(sender As Object, e As EventArgs) Handles txt_cedula_cliente.TextChanged
    '    Try
    '        sql = "SELECT cedula from CLIENTES WHERE CEDULA ='" & txt_cedula_cliente.Text & "'"
    '        Dim com As New SqlCommand(sql, mycon)
    '        dr = com.ExecuteReader
    '        txt_cedula_cliente.BackColor = Color.Red
    '        dr.Close()

    '    Catch ex As Exception
    '        MsgBox("Error al conectar con la BD " & ex.Message)
    '    End Try
    'End Sub
End Class