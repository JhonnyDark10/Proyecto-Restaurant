Imports System.Data.SqlClient
Imports System.IO
Public Class Actualizar_Empleado
    Dim sql As String
    Dim dr As SqlDataReader
    Private Sub actualizarempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        rb_actualizar_datos_empleados.Enabled = False
        btn_actualizar_empleado.Enabled = False
        btn_eliminar_empl.Enabled = False
        gbo_actualizar_empleados_datos.Enabled = False
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%

    End Sub

    Private Sub rb_actualizar_datos_empleados_CheckedChanged(sender As Object, e As EventArgs) Handles rb_actualizar_datos_empleados.CheckedChanged
        If (rb_actualizar_datos_empleados.Checked = True) Then
            gbo_actualizar_empleados_datos.Enabled = True
            btn_actualizar_empleado.Enabled = True
            btn_eliminar_empl.Enabled = False
        End If
    End Sub


    Private Sub btn_volver_actualizaion_empleado_Click(sender As Object, e As EventArgs) Handles btn_volver_actualizaion_empleado.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_actualizar_empleado_Click(sender As Object, e As EventArgs) Handles btn_actualizar_empleado.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String
        If (txt_direccion_empleados.Text = "" Or txt_telefono_empleados.Text = "") Then
            MsgBox("Debe Llenar los campos DIRECCION , TELEFONO para actualizar ......")
        Else
            sql = "update EMPLEADOS set "
            sql = sql & "DIRECCION" & "=" & "'" & Trim(txt_direccion_empleados.Text) & "', "
            sql = sql & "TELEFONO" & "=" & "'" & Trim(txt_telefono_empleados.Text) & "' where CEDULA" & "=" & txt_cedula_i_actu.Text & ""
            Dim com1 As New SqlCommand(sql, mycon)
            dr_1 = com1.ExecuteReader
            dr_1.Close()
            MsgBox("  Editado......")
            txt_direccion_empleados.Text = ""
            txt_cedula_i_actu.Text = ""
            txt_telefono_empleados.Text = ""
            gbo_actualizar_empleados_datos.Enabled = False
            btn_actualizar_empleado.Enabled = False
            rb_actualizar_datos_empleados.Checked = False
            dgv_empleado_a.DataSource = "" : dgv_empleado_a.DataMember = ""
        End If
    End Sub

    Private Sub btn_cedula_buscar_act_p_Click(sender As Object, e As EventArgs) Handles btn_cedula_buscar_act_p.Click

        btn_eliminar_empl.Enabled = True
        rb_actualizar_datos_empleados.Enabled = True

        Dim dt1 As New DataTable
        Dim dr1 As SqlDataReader
        Try
            dgv_empleado_a.DataSource = "" : dgv_empleado_a.DataMember = ""
            sql = "SELECT  CEDULA,NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO,DIRECCION,TELEFONO from EMPLEADOS WHERE CEDULA ='" & txt_cedula_i_actu.Text & "'" & "AND " & "ESTADO_E ='" & "A" & "'"
            Dim com4 As New SqlCommand(sql, mycon)
            dr1 = com4.ExecuteReader
            dt1.Load(dr1)
            dgv_empleado_a.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btn_eliminar_empl_Click(sender As Object, e As EventArgs) Handles btn_eliminar_empl.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String
        sql = "update EMPLEADOS set "
        sql = sql & "ESTADO_E" & "=" & "'" & "I" & "' " & " where CEDULA" & "= '" & txt_cedula_i_actu.Text & "'"
        Dim com As New SqlCommand(sql, mycon)
        dr_1 = com.ExecuteReader
        dr_1.Close()
        MsgBox(" EMPLEADO ELIMINADO......")
        txt_direccion_empleados.Text = ""
        txt_cedula_i_actu.Text = ""
        txt_telefono_empleados.Text = ""
        gbo_actualizar_empleados_datos.Enabled = False
        btn_actualizar_empleado.Enabled = False
        rb_actualizar_datos_empleados.Checked = False
        dgv_empleado_a.DataSource = "" : dgv_empleado_a.DataMember = ""
    End Sub
End Class