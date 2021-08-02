Imports System.Data.SqlClient

Public Class Orden_Pedido
    Dim x_1 As Integer
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable

   
    Private Sub Orden_Pedido_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_tiempo_pedido_o.Text = "HH:MM:SS"
        txt_usuario_empleado.Text = Acceso_Sistema.txt_usuario_acceso.Text
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
        desactivar()

        Dim VAR As String = Pagina_Principal.txt_princpal_acceso_ususario.Text

        sql = "SELECT DNI_EMPLEADOS,USUARIO,CONTRASEÑA FROM EMPLEADOS"
        Dim com As New SqlCommand(sql, mycon)
        dr = com.ExecuteReader
        If dr.HasRows Then
            While dr.Read
                If (dr("USUARIO") = VAR) Then
                    txt_usuario_empleado.Text = dr("DNI_EMPLEADOS")
                End If
            End While
        End If
        dr.Close()



    End Sub





    Private Sub desactivar()
        gbo_datos_cliente.Enabled = False
        GroupBox6.Enabled = False
        GroupBox1.Enabled = False
        btn_detalle_pedido_o.Enabled = False
        btn_limpiar_orden.Enabled = False
    End Sub
    Private Sub btn_guardar_pedido_Click(sender As Object, e As EventArgs) Handles btn_cancelar_pedido_o.Click
        Registra_Mesas_Pedido.Show()
        Close()
        Dispose()
    End Sub

    Private Sub btn_bebidas_o_Click(sender As Object, e As EventArgs) Handles btn_bebidas_o.Click
        dg_bebidas_orden.DataSource = "" : dg_bebidas_orden.DataMember = ""
        Dim dt2 As New DataTable
        Try
            sql = "SELECT CODIGO_PLATOS,FOTO_P from PLATOS P INNER JOIN CATEGORIA_PLATOS CP ON P.FK_ID_CATEGORIA_PLATOS = CP.ID_CATEGORIA_PLATOS WHERE CP.DESCRIPCION = 'BEBIDAS'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt2.Load(dr)
            dg_bebidas_orden.DataSource = dt2
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub

    Private Sub btn_postres_o_Click(sender As Object, e As EventArgs) Handles btn_postres_o.Click
        dg_bebidas_orden.DataSource = "" : dg_bebidas_orden.DataMember = ""
        Dim dt1 As New DataTable
        Try
            sql = "SELECT CODIGO_PLATOS, FOTO_P from PLATOS P INNER JOIN CATEGORIA_PLATOS CP ON P.FK_ID_CATEGORIA_PLATOS = CP.ID_CATEGORIA_PLATOS WHERE CP.DESCRIPCION = 'POSTRES'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt1.Load(dr)
            dg_bebidas_orden.DataSource = dt1

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub

    Private Sub btn_primero_o_Click(sender As Object, e As EventArgs) Handles btn_primero_o.Click
        dg_bebidas_orden.DataSource = "" : dg_bebidas_orden.DataMember = ""
        Dim dt3 As New DataTable
        Try
            sql = "SELECT CODIGO_PLATOS, FOTO_P from PLATOS P INNER JOIN CATEGORIA_PLATOS CP ON P.FK_ID_CATEGORIA_PLATOS = CP.ID_CATEGORIA_PLATOS WHERE CP.DESCRIPCION = 'PRIMERO'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt3.Load(dr)
            dg_bebidas_orden.DataSource = dt3

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub

    Private Sub btn_segundo_o_Click(sender As Object, e As EventArgs) Handles btn_segundo_o.Click
        dg_bebidas_orden.DataSource = "" : dg_bebidas_orden.DataMember = ""
        Dim dt4 As New DataTable
        Try
            sql = "SELECT CODIGO_PLATOS, FOTO_P from PLATOS P INNER JOIN CATEGORIA_PLATOS CP ON P.FK_ID_CATEGORIA_PLATOS = CP.ID_CATEGORIA_PLATOS WHERE CP.DESCRIPCION = 'SEGUNDO'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt4.Load(dr)
            dg_bebidas_orden.DataSource = dt4

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub


    Private Sub btn_buscar_producto_Click(sender As Object, e As EventArgs) Handles btn_buscar_producto.Click
        Dim dr1 As SqlDataReader
        Try
            sql = "SELECT CODIGO_PLATOS, PRECIO, NOMBRE from PLATOS P WHERE P.CODIGO_PLATOS ='" & txt_codigo.Text & "'"
            Dim com1 As New SqlCommand(sql, mycon)
            dr1 = com1.ExecuteReader
            If dr1.HasRows Then
                While dr1.Read
                    txt_precio.Text = dr1("PRECIO")
                    txt_Descripción.Text = dr1("NOMBRE")
                End While
            End If
            dr1.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try
    End Sub

    Private Sub btn_añadir_producto_o_Click(sender As Object, e As EventArgs) Handles btn_añadir_producto_o.Click
        Try
            If txt_codigo.Text <> "" And Val(txt_cantp.Text) > 0 Then
                dg_orden_d.Rows.Add(CDbl(txt_cantp.Text), txt_Descripción.Text, CDbl(txt_precio.Text), 0, 1, CDbl(txt_codigo.Text))
                MultiplicarDatos()
                subtotal()
                txt_codigo.Text = ""
                txt_cantp.Text = ""
                txt_Descripción.Text = ""
                txt_precio.Text = ""
                txt_codigo.Focus()
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Dim cantidad_p As Integer = 0
    Dim precio_p As Integer = 2
    Dim total_p1 As Integer = 3
    Sub MultiplicarDatos()
        Try
            If dg_orden_d.RowCount > 0 Then
                For fila = 0 To dg_orden_d.RowCount - 1
                    dg_orden_d.Rows(fila).Cells(total_p1).Value = Format(dg_orden_d.Rows(fila).Cells(cantidad_p).Value * (dg_orden_d.Rows(fila).Cells(precio_p).Value), "##,##0.00")

                Next
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Sub subtotal()
        Dim sub_t As Double
        Try
            If dg_orden_d.RowCount > 0 Then
                For fila = 0 To dg_orden_d.RowCount - 1
                    sub_t = sub_t + dg_orden_d.Rows(fila).Cells(total_p1).Value
                Next
            End If
            txt_subtotal_pedido_o.Text = Format(sub_t, "##,##0.00")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Private Sub btn_eliminar_Click(sender As Object, e As EventArgs) Handles btn_eliminar.Click
        Dim accion_p As Integer = 4
        Try
            Dim fila As Integer
            Dim valor As String
            If dg_orden_d.RowCount > 0 Then
                fila = dg_orden_d.Rows.Count - 1
                valor = dg_orden_d(accion_p, fila).Value
                If valor = 1 Then
                    dg_orden_d.Rows.RemoveAt(fila)
                End If
            End If
            subtotal()
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Sub limpiar_articulo()
        txt_codigo.Text = ""
        txt_cantp.Text = ""
        txt_Descripción.Text = ""
        txt_precio.Text = ""
        dg_bebidas_orden.DataSource = "" : dg_bebidas_orden.DataMember = ""
        dg_orden_d.DataSource = "" : dg_orden_d.DataMember = ""
        txt_subtotal_pedido_o.Text = ""
        txt_fecha_pedido_o.Text = ""
        txt_hora_pedido_o.Text = ""
        txt_tiempo_pedido_o.Text = ""
    End Sub
    Private Sub btn_limpiar_orden_Click(sender As Object, e As EventArgs) Handles btn_limpiar_orden.Click
        limpiar_articulo()
    End Sub



    Private Sub btn_detalle_pedido_o_Click(sender As Object, e As EventArgs) Handles btn_detalle_pedido_o.Click
        Dim msg, title As String
        Dim response As MsgBoxResult
        msg = "Realmente desea Grabar ?"
        title = "SISTEMA"
        response = MsgBox(msg, MsgBoxStyle.DefaultButton2 Or MsgBoxStyle.Question Or MsgBoxStyle.YesNo, title)
        If response = MsgBoxResult.No Then

            'ElseIf (txt_numero_pedido_o.Text = "" And txt_fecha_pedido_o.Text = "") Then
            '    MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)

        Else
            Try
                sql = "INSERT INTO ORDEN(FK_ID_EMPLEADO, FK_ID_TIPO_ORD, SUBTOTAL, NUMERO_MESA, FECHA_PEDIDO, HORA_PEDIDO, TIEMPO_ENTREGA, ESTADO_O) VALUES ("
                sql = sql & Val(txt_usuario_empleado.Text) & ", "
                sql = sql & Val(txt_codigo_tipo_mes.Text) & ", "
                sql = sql & Trim(Str(CDbl(txt_subtotal_pedido_o.Text))) & ", "
                sql = sql & Val(txt_numero_mesa_o.Text) & ", "
                sql = sql & "'" & Trim(txt_fecha_pedido_o.Text) & "', "
                sql = sql & "'" & Trim(txt_hora_pedido_o.Text) & "', "
                sql = sql & "'" & Trim(txt_tiempo_pedido_o.Text) & "', "
                sql = sql & "'A')"
                Dim com7 As New SqlCommand(sql, mycon)
                Dim x1 As Integer
                x1 = com7.ExecuteNonQuery

                ' codigo para guardar en la tabla intermedia de pedidos a platos
                Dim codigo As Integer
                '----PARA OBTENER EL ULTIMO ID DEL PEDIDO ALMACENADO-------
                sql = "SELECT MAX(ID_ORDEN_P) as id_codigo_c FROM ORDEN "
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
                Dim nomb_producto As Integer = 5
                Dim asig As Integer
                Dim c_p As Integer = 0
                Dim asig_1 As Integer

                If dg_orden_d.RowCount > 0 Then
                    For fila = 0 To dg_orden_d.RowCount - 1

                        asig = dg_orden_d.Rows(fila).Cells(nomb_producto).Value
                        asig_1 = dg_orden_d.Rows(fila).Cells(c_p).Value
                        sql = "INSERT INTO ORDEN_DETALLE(FK_ID_ORDEN, FK_COD_PLATOS,CANTIDAD_P, ESTADO_D_O) VALUES ("
                        sql = sql & codigo & ", "
                        sql = sql & asig & ","
                        sql = sql & asig_1 & ","
                        sql = sql & "'A')"
                        Dim com9 As New SqlCommand(sql, mycon)
                        Dim x3 As Integer
                        x3 = com9.ExecuteNonQuery
                    Next
                End If
                MsgBox("PEDIDO ALMACENADO CORRECTAMENTE")
                VALIDAR_ESTADO_MESAS()
                Registra_Mesas_Pedido.Show()
                Me.Close()
            Catch ex As Exception
                MsgBox("no se a podido guardar los datos" & ex.Message)
            End Try
        End If
    End Sub

    Private Sub btn_habilita_botones_Click(sender As Object, e As EventArgs) Handles btn_habilita_botones.Click
        txt_tiempo_pedido_o.Text = "HH:MM:SS"
        Dim codigo_1 As Integer = 0
        habilitar()

        ''----PARA OBTENER EL ULTIMO ID DEL PEDIDO ALMACENADO-------
        sql = "SELECT MAX(ID_ORDEN_P)  as id_codigo FROM ORDEN "
        Dim re_1 As SqlDataReader
        Dim con As New SqlCommand(sql, mycon)
        Dim dt_11 As New DataTable
        re_1 = con.ExecuteReader()
        dt_11.Load(re_1)
        If dt_11.Rows.Count > 0 Then
            codigo_1 = codigo_1 + dt_11.Rows(0)("id_codigo")
        Else
            codigo_1 = 1
        End If
        re_1.Close()
        txt_numero_pedido_o.Text = codigo_1
        '-----------------------------------------------------
    End Sub

    Private Sub btn_entrada_o_Click(sender As Object, e As EventArgs) Handles btn_entrada_o.Click
        dg_bebidas_orden.DataSource = "" : dg_bebidas_orden.DataMember = ""
        Dim dt21 As New DataTable
        Try
            sql = "SELECT CODIGO_PLATOS,FOTO_P from PLATOS P INNER JOIN CATEGORIA_PLATOS CP ON P.FK_ID_CATEGORIA_PLATOS = CP.ID_CATEGORIA_PLATOS WHERE CP.DESCRIPCION = 'ENTRADA'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt21.Load(dr)
            dg_bebidas_orden.DataSource = dt21
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub

    Private Sub habilitar()
        gbo_datos_cliente.Enabled = True
        GroupBox6.Enabled = True
        GroupBox1.Enabled = True
        btn_detalle_pedido_o.Enabled = True
        btn_limpiar_orden.Enabled = True
    End Sub


    Public Sub VALIDAR_ESTADO_MESAS()

        If txt_numero_mesa_o.Text = 1 Then
            Registra_Mesas_Pedido.btn_mesa1.Enabled = False
            Registra_Mesas_Pedido.btn_mesa1.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 2 Then
            Registra_Mesas_Pedido.btn_mesa2.Enabled = False
            Registra_Mesas_Pedido.btn_mesa2.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 3 Then
            Registra_Mesas_Pedido.btn_mesa3.Enabled = False
            Registra_Mesas_Pedido.btn_mesa3.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 4 Then
            Registra_Mesas_Pedido.btn_mesa4.Enabled = False
            Registra_Mesas_Pedido.btn_mesa4.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 5 Then
            Registra_Mesas_Pedido.btn_mesa5.Enabled = False
            Registra_Mesas_Pedido.btn_mesa5.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 6 Then
            Registra_Mesas_Pedido.btn_mesa6.Enabled = False
            Registra_Mesas_Pedido.btn_mesa6.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 7 Then
            Registra_Mesas_Pedido.btn_mesa7.Enabled = False
            Registra_Mesas_Pedido.btn_mesa7.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 8 Then
            Registra_Mesas_Pedido.btn_mesa8.Enabled = False
            Registra_Mesas_Pedido.btn_mesa8.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 9 Then
            Registra_Mesas_Pedido.btn_mesa9.Enabled = False
            Registra_Mesas_Pedido.btn_mesa9.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 10 Then
            Registra_Mesas_Pedido.btn_mesa10.Enabled = False
            Registra_Mesas_Pedido.btn_mesa10.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 11 Then
            Registra_Mesas_Pedido.btn_mesa11.Enabled = False
            Registra_Mesas_Pedido.btn_mesa11.BackColor = Color.Red
        ElseIf txt_numero_mesa_o.Text = 12 Then
            Registra_Mesas_Pedido.btn_mesa12.Enabled = False
            Registra_Mesas_Pedido.btn_mesa12.BackColor = Color.Red
        End If

    End Sub
End Class