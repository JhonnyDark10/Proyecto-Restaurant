
Imports System.Data.SqlClient
Imports System.IO

Public Class Actualizar_Proveedores
    Dim sql As String
    Dim dr As SqlDataReader

    Private Sub actualizarproveedores_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        gbo_datos_actualizar_proveedores.Enabled = False
        btn_actualizar_proveedores.Enabled = False
        btn_eliminar_prov.Enabled = False
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
    End Sub

    Private Sub btn_volver_proveedores_actualizar_Click(sender As Object, e As EventArgs) Handles btn_volver_proveedores_actualizar.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_actualizar_proveedores_Click(sender As Object, e As EventArgs) Handles btn_actualizar_proveedores.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String
        If (txt_direccion_proveedores_a.Text = "" Or txt_telefono_proveedores_a.Text = "") Then
            MsgBox("Debe Llenar los campos DIRECCION , TELEFONO para actualizar ......")
        Else
            sql = "update PROVEEDORES set "
            sql = sql & "DIRECCION" & "=" & "'" & Trim(txt_direccion_proveedores_a.Text) & "', "
            sql = sql & "TELEFONO" & "=" & "'" & Trim(txt_telefono_proveedores_a.Text) & "' where CEDULA" & "='" & txt_cedula_act_p.Text & "'"
            Dim com12 As New SqlCommand(sql, mycon)
            dr_1 = com12.ExecuteReader
            dr_1.Close()
            MsgBox("  Editado......")
            txt_direccion_proveedores_a.Text = ""
            txt_telefono_proveedores_a.Text = ""
            dgv_proveedor.DataSource = "" : dgv_proveedor.DataMember = ""
            rb_actualizar_datos_empleados.Checked = False
            gbo_datos_actualizar_proveedores.Enabled = False
            btn_actualizar_proveedores.Enabled = False
            btn_eliminar_prov.Enabled = False
        End If
    End Sub

    Private Sub btn_cedula_buscar_act_p_Click(sender As Object, e As EventArgs) Handles btn_cedula_buscar_act_p.Click
        Dim dt1 As New DataTable
        Dim dr1 As SqlDataReader
        Try
            dgv_proveedor.DataSource = "" : dgv_proveedor.DataMember = ""
            sql = "SELECT  CEDULA,NOMBRE,APELLIDO_PATERNO,APELLIDO_MATERNO,DIRECCION,TELEFONO,EMAIL from PROVEEDORES WHERE CEDULA ='" & txt_cedula_act_p.Text & "'" & "AND " & "ESTADO_P ='" & "A" & "'"
            Dim com4 As New SqlCommand(sql, mycon)
            dr1 = com4.ExecuteReader
            dt1.Load(dr1)
            dgv_proveedor.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        btn_eliminar_prov.Enabled = True
    End Sub

    Private Sub btn_eliminar_prov_Click(sender As Object, e As EventArgs) Handles btn_eliminar_prov.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String
        sql = "update PROVEEDORES set "
        sql = sql & "ESTADO_P" & "=" & "'" & "I" & "' " & " where CEDULA" & "= '" & txt_cedula_act_p.Text & "'"
        Dim com As New SqlCommand(sql, mycon)
        dr_1 = com.ExecuteReader
        dr_1.Close()
        MsgBox(" PROVEEDOR ELIMINADO......")
        txt_direccion_proveedores_a.Text = ""
        txt_telefono_proveedores_a.Text = ""
        dgv_proveedor.DataSource = "" : dgv_proveedor.DataMember = ""
        rb_actualizar_datos_empleados.Checked = False
        gbo_datos_actualizar_proveedores.Enabled = False
        btn_actualizar_proveedores.Enabled = False
        btn_eliminar_prov.Enabled = False
    End Sub

    Private Sub rb_actualizar_datos_empleados_CheckedChanged(sender As Object, e As EventArgs) Handles rb_actualizar_datos_empleados.CheckedChanged
        If (rb_actualizar_datos_empleados.Checked = True) Then
            gbo_datos_actualizar_proveedores.Enabled = True
            btn_actualizar_proveedores.Enabled = True
            btn_eliminar_prov.Enabled = False
        End If
    End Sub
End Class