Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Public Class Tipo_Tarjeta

    Private Sub tipotarjeta_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
        gbo_datos_tarjetas.Enabled = False
        btn_añadir_tipo_categoria_tarjeta.Enabled = False

        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "SELECT DESCRIPCION from TIPO_TARJETA"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dg_tipo_tarjeta.DataSource = dt
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub
    Private Sub btn_volver_tipo_categoria_tarjeta_Click(sender As Object, e As EventArgs) Handles btn_volver_tipo_categoria_tarjeta.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_nuevo_tipo_categoria_tarjeta_Click(sender As Object, e As EventArgs) Handles btn_nuevo_tipo_categoria_tarjeta.Click
        gbo_datos_tarjetas.Enabled = True
        btn_añadir_tipo_categoria_tarjeta.Enabled = True

        txt_ingresa_tipo_tarjeta.Focus()

    End Sub

    Private Sub btn_añadir_tipo_categoria_tarjeta_Click(sender As Object, e As EventArgs) Handles btn_añadir_tipo_categoria_tarjeta.Click
        Dim sql As String
        If (txt_ingresa_tipo_tarjeta.Text = "") Then
            MsgBox(" Debe llenar los Campos Obligatorios ")
        Else
            Try
                sql = "INSERT INTO TIPO_TARJETA(DESCRIPCION, ESTADO_T_T) VALUES ("
                sql = sql & "'" & Trim(txt_ingresa_tipo_tarjeta.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MsgBox(" CATEGORIA ALMACENADA")
                txt_ingresa_tipo_tarjeta.Text = ""
                btn_añadir_tipo_categoria_tarjeta.Enabled = False
                gbo_datos_tarjetas.Enabled = False
                llenar_data_grip()
            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If


    End Sub
End Class