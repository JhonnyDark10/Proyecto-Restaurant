Imports System.Data.SqlClient
Public Class Cancelar_Cuenta_Factura
    Dim dr As SqlDataReader
    Dim SQL As String
    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles btn_cancelar_cuenta.Click
        MsgBox("cuenta cancelada")
        Registra_Datos_Factura.Show()
        Close()
    End Sub


    Private Sub limpiar()
        Registra_Datos_Factura.cbo_categoria_mesa_f.Text = ""
        Registra_Datos_Factura.txt_cedula_busca_f.Text = ""
        Registra_Datos_Factura.cbo_lista_nombre_tarjetas_f.Text = ""
        Registra_Datos_Factura.txt_nombre_tc_f.Text = ""
        Registra_Datos_Factura.txt_numero_tc_f.Text = ""
    End Sub

    Private Sub Cancelar_Cuenta_Factura_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        llenar_factura()
        txt_empresa.Text = "RESTAURANT-MIRAMAR"
        txt_fecha.Text = "12/12/2012"
        txt_ruc.Text = "1232458364"

        Dim codigo_1 As Integer = 0
        ''----PARA OBTENER EL ULTIMO ID DEL PEDIDO ALMACENADO-------
        SQL = "SELECT (MAX(ID_FACTURA)) as id_codigo FROM FACTURA "
        Dim re_1 As SqlDataReader
        Dim con As New SqlCommand(Sql, mycon)
        Dim dt_11 As New DataTable
        re_1 = con.ExecuteReader()
        dt_11.Load(re_1)
        If dt_11.Rows.Count > 0 Then
            codigo_1 = dt_11.Rows(0)("id_codigo")
        End If
        re_1.Close()
        txt_f.Text = codigo_1
    End Sub

    Dim cantidad_p As Integer = 0
    Dim precio_p As Integer = 2
    Dim total_p1 As Integer = 3
   
    Private Sub llenar_factura()
        '----PARA OBTENER EL ULTIMO ID fac ALMACENADO-------
        Dim SQL As String
        Dim CODIGO As Integer
        SQL = "SELECT MAX(ID_FACTURA) as id_codigo_c FROM FACTURA"
        Dim re As SqlDataReader
        Dim con As New SqlCommand(Sql, mycon)
        Dim dt As New DataTable
        re = con.ExecuteReader()
        dt.Load(re)
        If dt.Rows.Count > 0 Then
            CODIGO = dt.Rows(0)("id_codigo_c")
        End If
        re.Close()
        '-----------------------------------------------------

        Dim dr111 As SqlDataReader
        Try
            SQL = "SELECT C.CEDULA, C.NOMBRE, C.APELLIDO_PATERNO +' '+C.APELLIDO_MATERNO AS APELLIDO, C.DIRECCION, C.TELEFONO, F.NOMBRE_TARJETA, F.NOMBRE_DUEÑO, F.NUMERO_TARJETA, F.SUBTOTAL, F.DESCUENTO, F.RECARGO_T_C, F.IVA, F.TOTAL_PAGO FROM FACTURA F INNER JOIN CLIENTES C ON C.DNI_CLIENTE = F.FK_CLIENTE WHERE F.ID_FACTURA ='" & CODIGO & "'"
            Dim com111 As New SqlCommand(SQL, mycon)
            dr111 = com111.ExecuteReader
            If dr111.HasRows Then
                While dr111.Read
                    txt_cedula_.Text = dr111("CEDULA")
                    txt_apellido_.Text = dr111("APELLIDO")
                    txt_nombre_.Text = dr111("NOMBRE")
                    txt_direccion_.Text = dr111("DIRECCION")
                    txt_telefono_.Text = dr111("TELEFONO")
                    txt_subtotal.Text = dr111("SUBTOTAL")
                    txt_descuento.Text = dr111("DESCUENTO")
                    txt_iva.Text = dr111("IVA")
                    txt_recargo.Text = dr111("RECARGO_T_C")
                    txt_total.Text = dr111("TOTAL_PAGO")
                    txt_dueño_tarjeta.Text = dr111("NOMBRE_DUEÑO")
                    txt_nombretarjeta_.Text = dr111("NOMBRE_TARJETA")
                    txt_numero_tarjeta.Text = dr111("NUMERO_TARJETA")
                End While
            Else
                MsgBox("NO SE ENCUENTRA ")
            End If
            dr111.Close()
        Catch ex As Exception
            MsgBox(ex.Message)
        Finally
        End Try


        Dim dt4 As New DataTable
        Try
            SQL = "SELECT  O_D.CANTIDAD_P , P.NOMBRE ,P.PRECIO FROM FACTURA F INNER JOIN  ORDEN O  ON  F.FK_ORDEN_FACT = O.ID_ORDEN_P INNER JOIN ORDEN_DETALLE O_D ON O_D.FK_ID_ORDEN = O.ID_ORDEN_P INNER JOIN PLATOS P ON P.CODIGO_PLATOS = O_D.FK_COD_PLATOS WHERE F.ID_FACTURA = '" & CODIGO & "'"
            Dim com As New SqlCommand(SQL, mycon)
            dr = com.ExecuteReader
            dt4.Load(dr)
            dgv_imprimir.DataSource = dt4
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
        End Try
    End Sub


End Class