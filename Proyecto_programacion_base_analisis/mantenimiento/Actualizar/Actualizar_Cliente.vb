Imports System.Data.SqlClient
Imports System.IO
Public Class Actualizar_Cliente
    Dim sql As String
    Dim dr As SqlDataReader

    Private Sub actualizarcliente_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
        btn_actualizar_.Enabled = False
        btn_eliminar.Enabled = False
        gbo_datos_actualizar_cliente.Enabled = False
    End Sub

    Private Sub btn_volver_actualizaion_empleado_Click(sender As Object, e As EventArgs) Handles btn_volver_.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_actualizar_empleado_Click(sender As Object, e As EventArgs) Handles btn_actualizar_.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String
        If (txt_direccion.Text = "" Or txt_email_.Text = "" Or txt_telefono.Text = "") Then
            MsgBox("Debe Llenar los campos DIRECCION , TELEFONO, E-MAIL para actualizar ......")
        Else
            sql = "update CLIENTES set "
            sql = sql & "DIRECCION" & "=" & "'" & Trim(txt_direccion.Text) & "', "
            sql = sql & "EMAIL" & "=" & "'" & Trim(txt_email_.Text) & "', "
            sql = sql & "TELEFONO" & "=" & "'" & Trim(txt_telefono.Text) & "' where CEDULA" & "=" & txt_cedula.Text & ""
            Dim com1 As New SqlCommand(sql, mycon)
            dr_1 = com1.ExecuteReader
            dr_1.Close()
            MsgBox("  Editado......")
            txt_cedula.Text = ""
            txt_direccion.Text = ""
            txt_email_.Text = ""
            txt_telefono.Text = ""
            gbo_datos_actualizar_cliente.Enabled = False
            btn_actualizar_.Enabled = False
            btn_eliminar.Enabled = False
            rb_actualizar_d.Checked = False
            dgw_actualizar_cliente.DataSource = "" : dgw_actualizar_cliente.DataMember = ""
        End If

    End Sub

    Private Sub rb_actualizar_d_CheckedChanged(sender As Object, e As EventArgs) Handles rb_actualizar_d.CheckedChanged
        If (rb_actualizar_d.Checked = True) Then
            btn_actualizar_.Enabled = True
            gbo_datos_actualizar_cliente.Enabled = True
            btn_eliminar.Enabled = False
        End If
    End Sub

    Private Sub btn_cedula_buscar_act_p_Click(sender As Object, e As EventArgs) Handles btn_cedula_buscar_act_p.Click
        btn_eliminar.Enabled = True
        Dim dt1 As New DataTable
        Dim dr1 As SqlDataReader
        Try
            dgw_actualizar_cliente.DataSource = "" : dgw_actualizar_cliente.DataMember = ""
            sql = "SELECT  CEDULA,NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO,DIRECCION,TELEFONO,EMAIL,FECHA_NACIMIENTO from CLIENTES WHERE CEDULA ='" & txt_cedula.Text & "'" & "AND " & "ESTADO_C ='" & "A" & "'"
            Dim com4 As New SqlCommand(sql, mycon)
            dr1 = com4.ExecuteReader
            dt1.Load(dr1)
            dgw_actualizar_cliente.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try



    End Sub

    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String
        sql = "update CLIENTES set "
        sql = sql & "ESTADO_C" & "=" & "'" & "I" & "' " & " where CEDULA" & "= '" & txt_cedula.Text & "'"
        Dim com As New SqlCommand(sql, mycon)
        dr_1 = com.ExecuteReader
        dr_1.Close()
        MsgBox(" CLIENTE ELIMINADO......")
        txt_cedula.Text = ""
        txt_direccion.Text = ""
        txt_email_.Text = ""
        txt_telefono.Text = ""
        gbo_datos_actualizar_cliente.Enabled = False
        btn_actualizar_.Enabled = False
        btn_eliminar.Enabled = False
        rb_actualizar_d.Checked = False
        dgw_actualizar_cliente.DataSource = "" : dgw_actualizar_cliente.DataMember = ""
    End Sub
End Class