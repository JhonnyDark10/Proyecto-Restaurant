Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Public Class Tipo_Empleado

    Private Sub tipoempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
        gbo_datos_categoria_e.Enabled = False
        btn_añadir_tipo_categoria_e.Enabled = False

        llenar_data_grip()
    End Sub

    Private Sub llenar_data_grip()
        Dim sql As String
        Dim dr As SqlDataReader
        Dim dt As New DataTable
        Try
            sql = "SELECT DESCRIPCION from ROLES_EMPLEADOS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            dt.Load(dr)
            dg_tipo_empleado.DataSource = dt
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        Finally
            '  MsgBox("No se puede.....!!!")
        End Try
    End Sub
    Private Sub btn_volver_tipo_categoria_Click(sender As Object, e As EventArgs) Handles btn_volver_tipo_categoria_e.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_nuevo_tipo_categoria_e_Click(sender As Object, e As EventArgs) Handles btn_nuevo_tipo_categoria_e.Click
        gbo_datos_categoria_e.Enabled = True
        btn_añadir_tipo_categoria_e.Enabled = True

        txt_empleado_categoria.Focus()

    End Sub

    Private Sub TextBox1_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_empleado_categoria.KeyPress
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

    Private Sub btn_añadir_tipo_categoria_e_Click(sender As Object, e As EventArgs) Handles btn_añadir_tipo_categoria_e.Click
        Dim sql As String
        If (txt_empleado_categoria.Text = "") Then
            MsgBox(" Debe llenar los Campos Obligatorios ")
        Else
            Try
                sql = "INSERT INTO ROLES_EMPLEADOS(DESCRIPCION, ESTADO_R_E) VALUES ("
                sql = sql & "'" & Trim(txt_empleado_categoria.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MsgBox(" CATEGORIA ALMACENADA")
                txt_empleado_categoria.Text = ""
                btn_añadir_tipo_categoria_e.Enabled = False
                gbo_datos_categoria_e.Enabled = False
                llenar_data_grip()
            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
    End Sub
End Class