Imports System.Data.SqlClient
Public Class Ingresa_Cuenta_Usuario



    Private Sub cuentaUsuario_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Me.txt_ususario_cuenta.Focus()
        txt_xdefecto_cedula.Text = Ingreso_Empleados.txt_cedula_empleado_i.Text
        txt_xdefecto_nombre.Text = Ingreso_Empleados.txt_nombre_empleados_i.Text

        Ingreso_Empleados.Enabled = False
        Ingreso_Empleados.Opacity = 85%

        llenar_data_g_cuenta()
    End Sub

    Private Sub llenar_data_g_cuenta()

        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "SELECT USUARIO FROM EMPLEADOS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dg_cuentas_usuarios.DataSource = dt
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub
    Private Sub btn_empleados_volver_cuenta_i_Click(sender As Object, e As EventArgs) Handles btn_empleados_volver_cuenta_i.Click
        Ingreso_Empleados.Enabled = True
        Ingreso_Empleados.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_empleados_cuenta_crear_i_Click(sender As Object, e As EventArgs) Handles btn_empleados_cuenta_crear_i.Click

        If txt_ususario_cuenta.Text = "" Or txt_usuario_contraseña.Text = "" Then
            MsgBox("No Ahy Datos Ingresados")
        Else
            Ingreso_Empleados.gbo_ususario_visible.Visible = True
            Ingreso_Empleados.txt_usuario_contraseña_e.Text = txt_usuario_contraseña.Text
            Ingreso_Empleados.txt_usuario_cuenta_e.Text = txt_ususario_cuenta.Text
            Ingreso_Empleados.Enabled = True
            Ingreso_Empleados.Opacity = 100%
            MsgBox("Datos Para Cuenta Aceptados")
            Close()
            Dispose()
        End If
    End Sub
End Class