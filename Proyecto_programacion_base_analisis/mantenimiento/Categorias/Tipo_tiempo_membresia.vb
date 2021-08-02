Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration

Public Class Tipo_tiempo_membresia

    Private Sub Tipo_tiempo_membresia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
        btn_añadir_t_m.Enabled = False
        gbo_Datos_tipo_t_m.Enabled = False

        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "select DESCRIPCION from TIPO_TIEMPO_MEMBRESIA"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dg_tipo_t_m.DataSource = dt
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub
    

    Private Sub btn_volver_t_m_Click(sender As Object, e As EventArgs) Handles btn_volver_t_m.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub txt_ingreso_nombre_t_m_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_ingreso_nombre_t_m.KeyPress
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

    Private Sub btn_nuevo_tm_Click(sender As Object, e As EventArgs) Handles btn_nuevo_tm.Click

        btn_añadir_t_m.Enabled = True
        gbo_Datos_tipo_t_m.Enabled = True
        txt_ingreso_nombre_t_m.Focus()

    End Sub

    Private Sub btn_añadir_t_m_Click(sender As Object, e As EventArgs) Handles btn_añadir_t_m.Click
        Dim sql As String
        If (txt_ingreso_nombre_t_m.Text = "") Then
            MsgBox(" Debe llenar los Campos Obligatorios ")
        Else
            Try
                sql = "INSERT INTO TIPO_TIEMPO_MEMBRESIA(DESCRIPCION, ESTADO_T_M) VALUES ("
                sql = sql & "'" & Trim(txt_ingreso_nombre_t_m.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MsgBox(" CATEGORIA ALMACENADA")
                txt_ingreso_nombre_t_m.Text = ""
                btn_añadir_t_m.Enabled = False
                gbo_Datos_tipo_t_m.Enabled = False
                llenar_data_grip()
            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub
End Class