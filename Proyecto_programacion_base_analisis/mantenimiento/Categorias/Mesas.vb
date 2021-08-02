Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Public Class Mesas

    Private Sub Mesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
        gbo_datos_mesas.Enabled = False
        btn_añadir_mesas.Enabled = False

        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "SELECT DESCRIPCION from MESAS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dg_tipo_mesas.DataSource = dt
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub


    Private Sub btn_volver_mesas_Click(sender As Object, e As EventArgs) Handles btn_volver_mesas.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_nuevo_mesas_Click(sender As Object, e As EventArgs) Handles btn_nuevo_mesas.Click
        gbo_datos_mesas.Enabled = True
        btn_añadir_mesas.Enabled = True

        txt_ingresa_mesas.Focus()
    End Sub

    Private Sub btn_añadir_mesas_Click(sender As Object, e As EventArgs) Handles btn_añadir_mesas.Click
        Dim sql As String
        If (txt_ingresa_mesas.Text = "") Then
            MsgBox(" Debe llenar los Campos Obligatorios ")
        Else
            Try
                sql = "INSERT INTO MESAS(DESCRIPCION, ESTADO_M) VALUES ("
                sql = sql & "'" & Trim(txt_ingresa_mesas.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MsgBox(" CATEGORIA ALMACENADA")
                txt_ingresa_mesas.Text = ""
                btn_añadir_mesas.Enabled = False
                gbo_datos_mesas.Enabled = False
                llenar_data_grip()
            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub

End Class