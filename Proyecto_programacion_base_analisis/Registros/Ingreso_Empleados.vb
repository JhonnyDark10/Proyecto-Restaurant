Imports System.Data.SqlClient
Public Class Ingreso_Empleados

    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Private Sub btn_guardar_empleado_Click(sender As Object, e As EventArgs) Handles btn_guardar_empleado_i.Click

        If (txt_cedula_empleado_i.Text = "" Or txt_nombre_empleados_i.Text = "" Or txt_apellidos_empleados_i.Text = "" Or txt_apellidos_empleados_i2.Text = "" Or txt_direccion_empleado_i.Text = "" Or txt_telefono_empleado_i.Text = "") Then
            MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            Try
                sql = "INSERT INTO EMPLEADOS(FK_ID_ROLES_EMPLEADOS, CEDULA, NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, DIRECCION, TELEFONO, ESTADO_E, USUARIO, CONTRASEÑA) VALUES ("

                sql = sql & Val(CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.SelectedValue) & ", "
                sql = sql & Trim(txt_cedula_empleado_i.Text) & ", "
                sql = sql & "'" & Trim(txt_nombre_empleados_i.Text) & "', "
                sql = sql & "'" & Trim(txt_apellidos_empleados_i.Text) & "', "
                sql = sql & "'" & Trim(txt_apellidos_empleados_i2.Text) & "', "
                sql = sql & "'" & Trim(txt_direccion_empleado_i.Text) & "', "
                sql = sql & "'" & Trim(txt_telefono_empleado_i.Text) & "', "
                sql = sql & "'A" & "', "
                sql = sql & "'" & Trim(txt_usuario_cuenta_e.Text) & "', "
                sql = sql & "'" & Trim(txt_usuario_contraseña_e.Text) & "') "
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery

                MsgBox("EMPLEADO ALMACENADO CORRECTAMENTE")
            Catch ex As Exception
                MsgBox("no se a podido guardar los datos" & ex.Message)
            End Try
        End If

        desactivar()
        limpiar()

    End Sub

    Private Sub limpiar()
        txt_cedula_empleado_i.Text = ""
        txt_apellidos_empleados_i.Text = ""
        txt_apellidos_empleados_i2.Text = ""
        txt_direccion_empleado_i.Text = ""
        txt_nombre_empleados_i.Text = ""
        txt_telefono_empleado_i.Text = ""
        CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Text = ""
        txt_usuario_contraseña_e.Text = ""
        txt_usuario_cuenta_e.Text = ""
    End Sub
    Private Sub btn_volver_empleado_r_Click(sender As Object, e As EventArgs) Handles btn_volver_empleado_i.Click
        Pagina_Principal.Opacity = 100%
        Pagina_Principal.Enabled = True
        Close()
        Dispose()
    End Sub
    Private Sub CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO_SelectedIndexChanged(sender As Object, e As EventArgs) Handles CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.SelectedIndexChanged
        gbo_empleados_i.Enabled = True
        btn_guardar_empleado_i.Enabled = True
        If (CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Text = "CAJERO" Or CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Text = "GERENTE") Then
            btn_empleado_i_crear_cuenta.Enabled = True

        Else
            btn_empleado_i_crear_cuenta.Enabled = False
        End If
        Me.txt_cedula_empleado_i.Focus()
    End Sub

    Private Sub IngresoEmpleados_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Opacity = 85%
        Pagina_Principal.Enabled = False
        btn_empleado_i_crear_cuenta.Enabled = False
        gbo_ususario_visible.Visible = False
        desactivar()
        llenar_Roles_Empleados()

    End Sub

    Private Sub llenar_Roles_Empleados()
        Try
            sql = "SELECT *from ROLES_EMPLEADOS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try

    End Sub
    Private Sub desactivar()
        gbo_empleados_i.Enabled = False
        btn_guardar_empleado_i.Enabled = False
        CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Enabled = False
    End Sub

    Private Sub btn_empleado_i_crear_cuenta_Click(sender As Object, e As EventArgs) Handles btn_empleado_i_crear_cuenta.Click
        Ingresa_Cuenta_Usuario.Show()
    End Sub

    Private Sub btn_nuevo_plato_Click(sender As Object, e As EventArgs) Handles btn_nuevo_plato.Click

        gbo_ususario_visible.Enabled = False
        gbo_empleados_i.Enabled = True
        btn_guardar_empleado_i.Enabled = True
        CBO_TIPO_EMPLEADO_INGRESO_EMPLEADO.Enabled = True
    End Sub

    Private Sub txt_cedula_empleado_i_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula_empleado_i.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_cedula_empleado_i.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_empleado_i.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_cedula_empleado_i.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_empleado_i.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_telefono_empleado_i_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono_empleado_i.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_telefono_empleado_i.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_empleado_i.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_telefono_empleado_i.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_empleado_i.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_nombre_empleados_i_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_empleados_i.KeyPress
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

    Private Sub txt_apellidos_empleados_i_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidos_empleados_i.KeyPress
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

    Private Sub txt_apellidos_empleados_i2_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidos_empleados_i2.KeyPress
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


End Class