Imports System.Data.SqlClient
Imports System.IO
Public Class Actualiza_Cuenta_U
    Dim sql As String
    Dim dr As SqlDataReader
    Private Sub Actualiza_Cuenta_U_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbo_datos_actualizar.Enabled = False
        btn_actualizar.Enabled = False

        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
    End Sub

    Private Sub btn_cedula_buscar_act_p_Click(sender As Object, e As EventArgs) Handles btn_cedula_buscar_act_p.Click

        Dim dt1 As New DataTable
        Dim dr1 As SqlDataReader
        Try
            dgv_cuenta.DataSource = "" : dgv_cuenta.DataMember = ""
            sql = "SELECT  E.CEDULA,E.NOMBRE,E.APELLIDO_PATERNO,E.APELLIDO_MATERNO, E.USUARIO,E.CONTRASEÑA from EMPLEADOS E INNER JOIN ROLES_EMPLEADOS R_E ON E.FK_ID_ROLES_EMPLEADOS = R_E.ID_ROLES_EMPLEADOS WHERE CEDULA ='" & txt_cedula_act_p.Text & "'" & "AND " & "ESTADO_E ='" & "A" & "'" & "AND " & "R_E.DESCRIPCION ='" & "CAJERO" & "'"
            Dim com4 As New SqlCommand(sql, mycon)
            dr1 = com4.ExecuteReader
            dt1.Load(dr1)
            dgv_cuenta.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

   
    Private Sub btn_volver_Click(sender As Object, e As EventArgs) Handles btn_volver.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub rb_1_CheckedChanged(sender As Object, e As EventArgs) Handles rb_1.CheckedChanged
        If (rb_1.Checked = True) Then
            gbo_datos_actualizar.Enabled = True
            btn_actualizar.Enabled = True

        End If
    End Sub

    Private Sub rb_2_CheckedChanged(sender As Object, e As EventArgs) Handles rb_2.CheckedChanged
        If (rb_2.Checked = True) Then
            gbo_datos_actualizar.Enabled = True
            txt_contraseña.Enabled = True
            txt_usuario.Enabled = False
            btn_actualizar.Enabled = True

        End If
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String

        If (rb_1.Checked = True) Then
            sql = "update EMPLEADOS set "
            sql = sql & "USUARIO" & "=" & "'" & Trim(txt_usuario.Text) & "', "
            sql = sql & "CONTRASEÑA" & "=" & "'" & Trim(txt_contraseña.Text) & "' where CEDULA" & "=" & txt_cedula_act_p.Text & ""
            Dim com1 As New SqlCommand(sql, mycon)
            dr_1 = com1.ExecuteReader
            dr_1.Close()
            MsgBox("  Editado......")
            txt_cedula_act_p.Text = ""
            txt_contraseña.Text = ""
            txt_usuario.Text = ""
            gbo_datos_actualizar.Enabled = False
            btn_actualizar.Enabled = False
            rb_1.Checked = False
            rb_2.Checked = False
            dgv_cuenta.DataSource = "" : dgv_cuenta.DataMember = ""
        ElseIf (rb_2.Checked = True) Then
            sql = "update EMPLEADOS set "
            sql = sql & "CONTRASEÑA" & "=" & "'" & Trim(txt_contraseña.Text) & "' where CEDULA" & "=" & txt_cedula_act_p.Text & ""
            Dim com1 As New SqlCommand(sql, mycon)
            dr_1 = com1.ExecuteReader
            dr_1.Close()
            MsgBox("  Editado......")
            txt_cedula_act_p.Text = ""
            txt_contraseña.Text = ""
            txt_usuario.Text = ""
            gbo_datos_actualizar.Enabled = False
            btn_actualizar.Enabled = False
            rb_1.Checked = False
            rb_2.Checked = False
            dgv_cuenta.DataSource = "" : dgv_cuenta.DataMember = ""
        End If

    End Sub
End Class