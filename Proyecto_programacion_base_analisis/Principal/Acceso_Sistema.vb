Imports System.Data.SqlClient

Public Class Acceso_Sistema
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable

    Private Sub BTN_ACEPTAR_INICIO_Click(sender As Object, e As EventArgs) Handles BTN_ACEPTAR_INICIO.Click

        If txt_usuario_acceso.Text = "ADMINISTRADOR" And txt_contraseña_acceso.Text = "ADMINISTRADOR" Then
            Pagina_Principal.Opacity = 100%
            Pagina_Principal.Enabled = True
            ACTIVAR_M()
            Pagina_Principal.txt_princpal_acceso_ususario.Text = txt_usuario_acceso.Text
            MsgBox("ACCESO PERMITIDO COMO ADMINISTRADOR", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "SISTEMA")
            Me.Close()
            Exit Sub
        End If


        Dim ACCESO_C As Boolean
        Dim ACCESO_C1 As Boolean
        If (txt_usuario_acceso.Text = "" And txt_contraseña_acceso.Text = "") Or (txt_usuario_acceso.Text = "") Or (txt_contraseña_acceso.Text = "") Then
            MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try
                sql = "SELECT DNI_EMPLEADOS,USUARIO,CONTRASEÑA FROM EMPLEADOS E INNER JOIN ROLES_EMPLEADOS R ON R.ID_ROLES_EMPLEADOS = E.FK_ID_ROLES_EMPLEADOS  WHERE R.DESCRIPCION ='" & "CAJERO" & "'"
                Dim com As New SqlCommand(sql, mycon)
                dr = com.ExecuteReader
                If dr.HasRows Then
                    While dr.Read

                        If (dr("USUARIO") = Trim(txt_usuario_acceso.Text) And dr("CONTRASEÑA") = Trim(txt_contraseña_acceso.Text)) Then
                            ACCESO_C = 1
                        Else
                            ACCESO_C = 0
                        End If
                    End While
                End If
                dr.Close()

                If ACCESO_C = True Then
                    Pagina_Principal.Opacity = 100%
                    Pagina_Principal.Enabled = True
                    MsgBox("ACCESO PERMITIDO COMO CAJERO", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "SISTEMA")
                    permitir_menu()
                    Pagina_Principal.txt_princpal_acceso_ususario.Text = txt_usuario_acceso.Text
                    Me.Close()
                Else
                    '****************************
                    sql = "SELECT USUARIO,CONTRASEÑA FROM EMPLEADOS E INNER JOIN ROLES_EMPLEADOS R ON R.ID_ROLES_EMPLEADOS = E.FK_ID_ROLES_EMPLEADOS  WHERE R.DESCRIPCION ='" & "GERENTE" & "'"
                    Dim com11 As New SqlCommand(sql, mycon)
                    dr = com11.ExecuteReader
                    If dr.HasRows Then
                        While dr.Read
                            If (dr("USUARIO") = Trim(txt_usuario_acceso.Text) And dr("CONTRASEÑA") = Trim(txt_contraseña_acceso.Text)) Then
                                ACCESO_C1 = 1
                            Else
                                ACCESO_C1 = 0
                            End If
                        End While
                    End If
                    dr.Close()
                    '****************************
                    If ACCESO_C1 Then
                        Pagina_Principal.Opacity = 100%
                        Pagina_Principal.Enabled = True
                        MsgBox("ACCESO PERMITIDO COMO GERENTE", MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, "SISTEMA")
                        permitir_menu1()
                        Pagina_Principal.txt_princpal_acceso_ususario.Text = txt_usuario_acceso.Text
                        Me.Close()
                    Else
                        MessageBox.Show("ERROR EN EL ACCESO DATOS ERRONES", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
                        txt_usuario_acceso.Text = ""
                        txt_contraseña_acceso.Text = ""
                    End If
                  
                End If
            Catch ex As Exception
                MsgBox("Error al conectar con la BD " & ex.Message)
            End Try

        End If
    End Sub

    Private Sub ACTIVAR_M()
        Pagina_Principal.REPORTES.Enabled = True
        Pagina_Principal.REPORTES.Visible = True

        Pagina_Principal.CategoriaT.Enabled = True
        Pagina_Principal.CategoriaT.Visible = True
        Pagina_Principal.Clientes_E.Enabled = True
        Pagina_Principal.Clientes_E.Visible = True
        Pagina_Principal.Empleados_E.Enabled = True
        Pagina_Principal.Empleados_E.Visible = True
        Pagina_Principal.Proveedores_E.Enabled = True
        Pagina_Principal.Proveedores_E.Visible = True
        Pagina_Principal.Platos_E.Enabled = True
        Pagina_Principal.Platos_E.Visible = True
        Pagina_Principal.CuentaU_E.Enabled = True
        Pagina_Principal.CuentaU_E.Visible = True
        Pagina_Principal.Proveedores.Enabled = True
        Pagina_Principal.Proveedores.Visible = True
        Pagina_Principal.Platos.Enabled = True
        Pagina_Principal.Platos.Visible = True
        Pagina_Principal.Empleados.Enabled = True
        Pagina_Principal.Empleados.Visible = True

        '***************************************
        Pagina_Principal.REGISTROS.Enabled = True
        Pagina_Principal.REGISTROS.Visible = True

        Pagina_Principal.PEDIDOS.Enabled = True
        Pagina_Principal.PEDIDOS.Visible = True

        Pagina_Principal.FACTURACIONES.Enabled = True
        Pagina_Principal.FACTURACIONES.Visible = True

        Pagina_Principal.MANTENIMIENTO.Enabled = True
        Pagina_Principal.MANTENIMIENTO.Visible = True
    End Sub
        
    Private Sub permitir_menu()
        Pagina_Principal.REPORTES.Enabled = False
        Pagina_Principal.REPORTES.Visible = False
        Pagina_Principal.CategoriaT.Enabled = False
        Pagina_Principal.CategoriaT.Visible = False
        Pagina_Principal.Clientes_E.Enabled = False
        Pagina_Principal.Clientes_E.Visible = False
        Pagina_Principal.Empleados_E.Enabled = False
        Pagina_Principal.Empleados_E.Visible = False
        Pagina_Principal.Proveedores_E.Enabled = False
        Pagina_Principal.Proveedores_E.Visible = False
        Pagina_Principal.Platos_E.Enabled = False
        Pagina_Principal.Platos_E.Visible = False
        Pagina_Principal.CuentaU_E.Enabled = False
        Pagina_Principal.CuentaU_E.Visible = False
        Pagina_Principal.Proveedores.Enabled = False
        Pagina_Principal.Proveedores.Visible = False
        Pagina_Principal.Platos.Enabled = False
        Pagina_Principal.Platos.Visible = False
        Pagina_Principal.Empleados.Enabled = False
        Pagina_Principal.Empleados.Visible = False
        '***********************************
        Pagina_Principal.REGISTROS.Enabled = True
        Pagina_Principal.REGISTROS.Visible = True

        Pagina_Principal.REPORTES.Enabled = False
        Pagina_Principal.REPORTES.Visible = False

        Pagina_Principal.PEDIDOS.Enabled = True
        Pagina_Principal.PEDIDOS.Visible = True

        Pagina_Principal.FACTURACIONES.Enabled = True
        Pagina_Principal.FACTURACIONES.Visible = True

        Pagina_Principal.MANTENIMIENTO.Enabled = True
        Pagina_Principal.MANTENIMIENTO.Visible = True
    End Sub

    Private Sub permitir_menu1()
        Pagina_Principal.REGISTROS.Enabled = False
        Pagina_Principal.REGISTROS.Visible = False

        Pagina_Principal.REPORTES.Enabled = True
        Pagina_Principal.REPORTES.Visible = True

        Pagina_Principal.PEDIDOS.Enabled = False
        Pagina_Principal.PEDIDOS.Visible = False

        Pagina_Principal.FACTURACIONES.Enabled = False
        Pagina_Principal.FACTURACIONES.Visible = False

        Pagina_Principal.MANTENIMIENTO.Enabled = False
        Pagina_Principal.MANTENIMIENTO.Visible = False
    End Sub

    Private Sub BTN_CANCELAR_INICIO_Click(sender As Object, e As EventArgs) Handles BTN_CANCELAR_INICIO.Click
        Pagina_Principal.Enabled = True
        Dim msg, title As String
        Dim response As MsgBoxResult
        msg = "Realmente desea salir del Sistema?"   'Define mensaje.
        title = "SISTEMA"  'Define título.
        response = MsgBox(msg, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, title)
        If response = MsgBoxResult.Yes Then
            Pagina_Principal.Close()
            Me.Close()
        End If

    End Sub

    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox_ayuda_acesso.Click
        MessageBox.Show("Para poder acceder al sistema primero el administrador debio proporcionar un USUARIO y CONTRASEÑA.  Si no la recuerda dirijase al departamento de sistemas para arreglar el problema y pueda ingresar al sistema normalmente   @SALUDOS ADMINISTRADOR", "AYUDA", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Acceso_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Opacity = 85%
        Pagina_Principal.Enabled = False
        Pagina_Principal.Show()
        Me.txt_usuario_acceso.Focus()
    End Sub


End Class