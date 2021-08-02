Imports System.Data.SqlClient
Public Class Reporte_Clientes

    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Private Sub reportes_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
    End Sub


    Private Sub btn_volver_actualizaion_empleado_Click(sender As Object, e As EventArgs) Handles btn_volver_actualizaion_empleado.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_actualizar_empleado_Click(sender As Object, e As EventArgs) Handles btn_actualizar_empleado.Click

        Try
            If (cbo_tipo.Text = "PROXIMAS A CADUCAR") Then
                sql = "SELECT *from VW_MEMBRESIAS_CADUCADAS where [CADUCIDAD] >'" & dtp_fecha.Text & "'"
                Dim com As New SqlCommand(sql, mycon)
                dr = com.ExecuteReader
                Dim d1 As New DataTable
                d1.Load(dr)
                dgv_reportes.DataSource = d1
            ElseIf (cbo_tipo.Text = "CADUCADAS") Then
                sql = "SELECT *from VW_MEMBRESIAS_CADUCADAS where [CADUCIDAD] <'" & dtp_fecha.Text & "'"
                Dim com As New SqlCommand(sql, mycon)
                dr = com.ExecuteReader
                Dim d1 As New DataTable
                d1.Load(dr)
                dgv_reportes.DataSource = d1
            ElseIf (cbo_tipo.Text = "TIEMPO A RENOVAR") Then
                sql = "SELECT *from VW_MEMBRESIAS_CADUCADAS where '" & dtp_fecha.Text & "'" & " BETWEEN " & "[CADUCIDAD] and [RENOVACION]"
                Dim com As New SqlCommand(sql, mycon)
                dr = com.ExecuteReader
                Dim d1 As New DataTable
                d1.Load(dr)
                dgv_reportes.DataSource = d1
            End If

        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try

    End Sub

    Private Sub btn_cancelar_cuenta_Click(sender As Object, e As EventArgs) Handles btn_cancelar_cuenta.Click
        MsgBox("ENVIADO A COLA DE IMPRESION .......")
    End Sub
End Class