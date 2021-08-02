Imports System.Data.SqlClient
Public Class Reporte_Empleados
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Private Sub reporteempleado_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
        llenar_combo()

    End Sub

    Private Sub llenar_combo()
        Try
            sql = "SELECT *from ROLES_EMPLEADOS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_tipo_empleado.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub btn_cancelar_cuenta_Click(sender As Object, e As EventArgs) Handles btn_cancelar_cuenta.Click
        MsgBox("ENVIADO A COLA DE IMPRESION......")
    End Sub

    Private Sub btn_volver_actualizaion_empleado_Click(sender As Object, e As EventArgs) Handles btn_volver_actualizaion_empleado.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_actualizar_empleado_Click(sender As Object, e As EventArgs) Handles btn_actualizar_empleado.Click
        If (cbo_tipo_empleado.Text = "CAJERO") Then
            sql = "SELECT *from VW_REPORTE_CAJEROS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            dgv_empleado.DataSource = d1
        Else
            sql = "SELECT *from  VW_REPORTE_OTROS WHERE [DESCRIPCION] = '" & cbo_tipo_empleado.Text & "'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            dgv_empleado.DataSource = d1
        End If
    End Sub
End Class