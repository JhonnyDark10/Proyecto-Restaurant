Imports System.Data.SqlClient
Imports System.IO
Public Class ActualizarMembresia
    Dim sql As String
    Dim dr As SqlDataReader
    Private Sub ActualizarMembresia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        btn_actualizar.Enabled = False
        btn_actualizar.Enabled = False
        gbo_categoria_cliente.Enabled = False
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


    Private Sub btn_cedula_buscar_act_p_Click(sender As Object, e As EventArgs) Handles btn_cedula_buscar_act_p.Click
        Dim dt1 As New DataTable
        Dim dr1 As SqlDataReader
        Try
            dgv_actualizar_.DataSource = "" : dgv_actualizar_.DataMember = ""
            sql = "SELECT  C.CEDULA,C.NOMBRE,C.APELLIDO_PATERNO,TC.DESCRIPCION from CLIENTES C INNER JOIN TIPO_CLIENTE TC ON C.FK_ID_TIPO_CLIENTE = TC.ID_TIPO_CLIENTE WHERE C.CEDULA ='" & txt_cedula_act_p.Text & "'" & "AND " & "C.ESTADO_C ='" & "A" & "'"
            Dim com4 As New SqlCommand(Sql, mycon)
            dr1 = com4.ExecuteReader
            dt1.Load(dr1)
            dgv_actualizar_.DataSource = dt1
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        btn_eliminar_pL.Enabled = True

    End Sub

    Private Sub rb_actualizar_datos_empleados_CheckedChanged(sender As Object, e As EventArgs) Handles rb_actualizar_datos_empleados.CheckedChanged
        If (rb_actualizar_datos_empleados.Checked = True) Then
            gbo_categoria_cliente.Enabled = True
            btn_eliminar_pL.Enabled = False
            btn_actualizar.Enabled = True

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

    Private Sub btn_volver_plato_actualizar_Click(sender As Object, e As EventArgs) Handles btn_volver_plato_actualizar.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_actualizar_Click(sender As Object, e As EventArgs) Handles btn_actualizar.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String

        sql = "update CLIENTES set "
        sql = sql & "FK_ID_TIPO_CLIENTE" & "=" & Val(cbo_categoria_cliente.SelectedValue) & " where CEDULA" & "='" & txt_cedula_act_p.Text & "'"
        Dim com12 As New SqlCommand(sql, mycon)
        dr_1 = com12.ExecuteReader
        dr_1.Close()

        Dim codigo1 As Integer = DEVOLVER()

        Dim dr_11 As SqlDataReader
        sql = "update MEMBRESIA set "
        sql = sql & "ESTADO_M" & "=" & "'I'" & " where FK_DNI_CLIENTES" & "='" & codigo1 & "'"
        Dim com121 As New SqlCommand(sql, mycon)
        dr_11 = com121.ExecuteReader
        dr_11.Close()


                sql = "INSERT INTO MEMBRESIA(FK_DNI_CLIENTES, FK_DNI_T_M, VALOR_PAGO, FECHA_APERTURA, FECHA_CADUCIDAD, FECHA_RENOVACION, ESTADO_M) VALUES ("
                sql = sql & codigo1 & ", "
                sql = sql & Val(cbo_dias_año_cliente.SelectedValue) & ", "
                sql = sql & Val(txt_valor_pago_cliente.Text) & ", "
                sql = sql & "'" & Trim(fecha_apertura_ingreso_c.Text) & "', "
                sql = sql & "'" & Trim(txt_fecha_caducidad.Text) & "', "
                sql = sql & "'" & Trim(txt_fecha_renovacion_cliente.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com21 As New SqlCommand(sql, mycon)
                Dim x_1 As Integer
                x_1 = com21.ExecuteNonQuery
        MsgBox("MEMBRESIA ACTUALIZADA")
    End Sub


    Function DEVOLVER()
        sql = "SELECT DNI_CLIENTE as id_codigo_c FROM CLIENTES WHERE CEDULA" & "='" & txt_cedula_act_p.Text & "'"
        Dim re As SqlDataReader
        Dim con As New SqlCommand(sql, mycon)
        Dim codigo As Integer
        Dim dt1 As New DataTable
        re = con.ExecuteReader()
        dt1.Load(re)
        If dt1.Rows.Count > 0 Then
            codigo = dt1.Rows(0)("id_codigo_c")
        End If
        re.Close()
        Return codigo
    End Function
    Private Sub btn_eliminar_pL_Click(sender As Object, e As EventArgs) Handles btn_eliminar_pL.Click

        Dim dr_1 As SqlDataReader
        Dim sql As String

        sql = "update CLIENTES set "
        sql = sql & "FK_ID_TIPO_CLIENTE" & "=" & Val(cbo_categoria_cliente.SelectedValue) & " where CEDULA" & "='" & txt_cedula_act_p.Text & "'"
        Dim com12 As New SqlCommand(sql, mycon)
        dr_1 = com12.ExecuteReader
        dr_1.Close()

        Dim codigo1 As Integer = DEVOLVER()
        Dim dr_11 As SqlDataReader
        sql = "update MEMBRESIA set "
        sql = sql & "ESTADO_M" & "=" & "'I'" & " where FK_DNI_CLIENTES" & "='" & codigo1 & "'"
        Dim com121 As New SqlCommand(sql, mycon)
        dr_11 = com121.ExecuteReader
        dr_11.Close()
        MsgBox("MEMBRESIA SUSTITUIDA POR LA CATEGORIA CLASICO")
    End Sub
End Class