Imports System.Data.SqlClient

Public Class Registra_Datos_Factura
    Dim obtener_o As Integer
    Dim obtener_c As Integer
    Dim ESTADO As String = "A"
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dr1 As SqlDataReader
    Dim dt As New DataTable
    Private Sub btn_registro_volver_f_Click(sender As Object, e As EventArgs) Handles btn_registro_volver_f.Click
        Me.Close()
    End Sub


    Private Sub Registra_Datos_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        desactivar_()
        lbl_empresa_f.Text = "RESTAURANT-MIRAMAR"
        lbl_direccion_f.Text = "SALINAS-ANCONCITO"
        lbl_ruc_f.Text = "1232458364"
        lbl_email_f.Text = "rest_miramar@hotmail.com"
        lbl_telefono_f.Text = "1283945256"
        lbl_fecha_f.Text = DateTime.Now.ToString("dd/MM/yyyy")
        llenar_mesas()
        llenar_tipo_pago()
        llenar_tipo_tarjeta()
        cbo_lista_nombre_tarjetas_f.Text = ""
        formato()
    End Sub


    Private Sub formato()
        txt_descuento_f.Text = Format(0, "##,##0.00")
        txt_iva_f.Text = Format(0, "##,##0.00")
        txt_recarga_f.Text = Format(0, "##,##0.00")
        txt_total_p_f.Text = Format(0, "##,##0.00")
        txt_subtotal_f.Text = Format(0, "##,##0.00")

    End Sub
    Private Sub llenar_tipo_tarjeta()
        Try
            sql = "SELECT *FROM TIPO_TARJETA"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_lista_nombre_tarjetas_f.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub
    Private Sub llenar_tipo_pago()
        Try
            sql = "SELECT *FROM TIPO_PAGO"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_tipopago.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub llenar_mesas()
        Try
            sql = "SELECT *from MESAS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_categoria_mesa_f.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try

    End Sub

    Private Sub desactivar_()
        cbo_lista_nombre_tarjetas_f.Enabled = False
        txt_nombre_tc_f.Enabled = False
        txt_numero_tc_f.Enabled = False
    End Sub

 
    Dim codigo_cliente_asig As String
    Private Sub btn_cedula_buscar_f_Click(sender As Object, e As EventArgs) Handles btn_cedula_buscar_f.Click
        Dim dr1 As SqlDataReader
        Try
            sql = "SELECT FK_ID_TIPO_CLIENTE, DNI_CLIENTE, CEDULA,NOMBRE, APELLIDO_PATERNO,DIRECCION,TELEFONO,T_C.DESCRIPCION from CLIENTES C INNER JOIN TIPO_CLIENTE T_C ON C.FK_ID_TIPO_CLIENTE = T_C.ID_TIPO_CLIENTE WHERE C.CEDULA ='" & txt_cedula_busca_f.Text & "'"
            Dim com1 As New SqlCommand(Sql, mycon)
            dr1 = com1.ExecuteReader
            If dr1.HasRows Then
                While dr1.Read
                    obtener_c = dr1("DNI_CLIENTE")
                    codigo_cliente_asig = dr1("DESCRIPCION")
                    lbl_cedula_c_f.Text = dr1("CEDULA")
                    lbl_nombre_c_f.Text = dr1("NOMBRE")
                    lbl_apellido_c_f.Text = dr1("APELLIDO_PATERNO")
                    lbl_direccion_c_f.Text = dr1("DIRECCION")
                    lbl_telefono_c_f.Text = dr1("TELEFONO")
                End While
            Else
                MsgBox("CLIENTE NO SE ENCUENTRA REGISTRADO....Registre")
            End If
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
        txt_tipo_cliente_fact.Text = codigo_cliente_asig
    End Sub

    Private Sub btn_nuevo_cliente_f_Click(sender As Object, e As EventArgs) Handles btn_nuevo_cliente_f.Click
        Ingreso_Clientes.Show()
    End Sub

    Private Sub btn_ver_detalle_orden_f_Click(sender As Object, e As EventArgs) Handles btn_ver_detalle_orden_f.Click

        Dim M_O As Integer

        M_O = cbo_categoria_mesa_f.SelectedValue
        Try
            sql = "SELECT O.ID_ORDEN_P, O_D.CANTIDAD_P, P.NOMBRE, O.SUBTOTAL FROM ORDEN O INNER JOIN ORDEN_DETALLE O_D ON  O.ID_ORDEN_P = O_D.FK_ID_ORDEN INNER JOIN PLATOS P ON P.CODIGO_PLATOS = O_D.FK_COD_PLATOS WHERE O.NUMERO_MESA = " & M_O & "AND" & " " & "O.ESTADO_O = '" & ESTADO & "'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader

            If dr.HasRows Then
                While dr.Read
                    txt_subtotal_f.Text = dr("SUBTOTAL")
                    obtener_o = dr("ID_ORDEN_P")
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
        End Try

        Dim dt4 As New DataTable
        Try
            sql = "SELECT O_D.CANTIDAD_P, P.NOMBRE, P.PRECIO FROM ORDEN O INNER JOIN ORDEN_DETALLE O_D ON  O.ID_ORDEN_P = O_D.FK_ID_ORDEN INNER JOIN PLATOS P ON P.CODIGO_PLATOS = O_D.FK_COD_PLATOS WHERE O.NUMERO_MESA = " & M_O & "AND" & " " & "O.ESTADO_O = '" & ESTADO & "'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt4.Load(dr)
            dg_ver_ordenes.DataSource = dt4
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
        End Try


        If (txt_tipo_cliente_fact.Text = "PLATINIUM") Then
            txt_descuento_f.Text = Format((txt_subtotal_f.Text * (20 / 100)), "##,##0.00")
        ElseIf (txt_tipo_cliente_fact.Text = "VIP") Then
            txt_descuento_f.Text = Format((txt_subtotal_f.Text * (25 / 100)), "##,##0.00")
        ElseIf (txt_tipo_cliente_fact.Text = "CLASICO") Then
            txt_descuento_f.Text = Format(0, "##,##0.00")
        ElseIf (txt_tipo_cliente_fact.Text = "GOLD") Then
            txt_descuento_f.Text = Format((txt_subtotal_f.Text * (10 / 100)), "##,##0.00")
        ElseIf (txt_tipo_cliente_fact.Text = "ESPECIAL") Then
            txt_descuento_f.Text = Format((txt_subtotal_f.Text * (5 / 100)), "##,##0.00")
        End If

        txt_iva_f.Text = Format((txt_subtotal_f.Text * (14 / 100)), "##,##0.00")

        If cbo_tipopago.Text = "TARJETA DE CREDITO" And cbo_lista_nombre_tarjetas_f.Text = "DINERS CLUB" Then
            txt_recarga_f.Text = Format((txt_subtotal_f.Text * (5 / 100)), "##,##0.00")
        ElseIf cbo_tipopago.Text = "TARJETA DE CREDITO" And cbo_lista_nombre_tarjetas_f.Text = "AMERICAN EXPRESS" Then
            txt_recarga_f.Text = Format((txt_subtotal_f.Text * (6 / 100)), "##,##0.00")
        ElseIf cbo_tipopago.Text = "TARJETA DE CREDITO" And cbo_lista_nombre_tarjetas_f.Text = "VISA" Then
            txt_recarga_f.Text = Format((txt_subtotal_f.Text * (5.7 / 100)), "##,##0.00")
        ElseIf cbo_tipopago.Text = "TARJETA DE CREDITO" And cbo_lista_nombre_tarjetas_f.Text = "MASTERCARD" Then
            txt_recarga_f.Text = Format((txt_subtotal_f.Text * (6.5 / 100)), "##,##0.00")
        Else : cbo_tipopago.Text = "EFECTIVO"
            txt_recarga_f.Text = Format(0, "##,##0.00")
        End If

        txt_total_p_f.Text = Format((CDbl(txt_subtotal_f.Text) + CDbl(txt_iva_f.Text) + CDbl(txt_recarga_f.Text) - CDbl(txt_descuento_f.Text)), "##,##0.00")

    End Sub

    Private Sub cbo_categoria_mesa_f_Click(sender As Object, e As EventArgs) Handles cbo_categoria_mesa_f.Click
        dg_ver_ordenes.DataSource = "" : dg_ver_ordenes.DataMember = ""
    End Sub

    Private Sub txt_nombre_tc_f_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_tc_f.KeyPress
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

    Private Sub txt_cedula_busca_f_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula_busca_f.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_cedula_busca_f.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_busca_f.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_cedula_busca_f.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_busca_f.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_numero_tc_f_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_numero_tc_f.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_numero_tc_f.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_numero_tc_f.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_numero_tc_f.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_numero_tc_f.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub cbo_tipopago_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_tipopago.SelectedIndexChanged
        If cbo_tipopago.Text = "EFECTIVO" Then
            cbo_lista_nombre_tarjetas_f.Enabled = False
            txt_nombre_tc_f.Enabled = False
            txt_numero_tc_f.Enabled = False
        Else
            cbo_lista_nombre_tarjetas_f.Enabled = True
            txt_nombre_tc_f.Enabled = True
            txt_numero_tc_f.Enabled = True
        End If
    End Sub

    Private Sub btn_facturar_registro_Click(sender As Object, e As EventArgs) Handles btn_facturar_registro.Click

        Dim msg, title As String
        Dim response As MsgBoxResult
        msg = "Realmente desea facturar ?"
        title = "SISTEMA"
        response = MsgBox(msg, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, title)
        If response = MsgBoxResult.No Then

            'ElseIf (txt_numero_pedido_o.Text = "" And txt_fecha_pedido_o.Text = "") Then
            '    MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            Try
                sql = "INSERT INTO FACTURA(FK_CLIENTE, FK_ORDEN_FACT, FK_TIPO_PAGO, SUBTOTAL, DESCUENTO, RECARGO_T_C, IVA, TOTAL_PAGO, NOMBRE_TARJETA, NOMBRE_DUEÑO, NUMERO_TARJETA,FECHA_FACTURA,ESTADO_FACT) VALUES ("
                sql = sql & obtener_c & ", "
                sql = sql & obtener_o  & ", "
                sql = sql & Val(cbo_tipopago.SelectedValue) & ", "
                sql = sql & Trim(Str(CDbl(txt_subtotal_f.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_descuento_f.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_recarga_f.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_iva_f.Text))) & ", "
                sql = sql & Trim(Str(CDbl(txt_total_p_f.Text))) & ", "
                sql = sql & "'" & cbo_lista_nombre_tarjetas_f.Text & "', "
                sql = sql & "'" & txt_nombre_tc_f.Text & "', "
                sql = sql & "'" & txt_numero_tc_f.Text & "', "
                sql = sql & "'" & Trim(lbl_fecha_f.Text) & "', "
                sql = sql & "'A')"
                Dim com71 As New SqlCommand(sql, mycon)
                Dim x11 As Integer
                x11 = com71.ExecuteNonQuery
                MsgBox("FACTURA ALMACENADO CORRECTAMENTE")
                Cancelar_Cuenta_Factura.Show()
                PAGO.Show()
                rrecorrer_pedido()
                Me.Close()
            Catch ex As Exception
                MsgBox("no se a podido guardar los datos" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub rrecorrer_pedido()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "UPDATE ORDEN SET ESTADO_O = 'I' WHERE ID_ORDEN_P =" & obtener_o & ""
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub
End Class