Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Imports System.IO
Public Class Registra_Mesas_Pedido

    Private Sub btn_mesa1_Click(sender As Object, e As EventArgs) Handles btn_mesa1.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 1

    End Sub
    Public Sub pedido()
        Orden_Pedido.txt_tipo_orden_o.Text = cbo_categoria_pedido.Text
        Orden_Pedido.txt_codigo_tipo_mes.Text = Val(cbo_categoria_pedido.SelectedValue)
        Orden_Pedido.Show()
        Close()
        Dispose()
    End Sub
    Private Sub btn_mesa2_Click(sender As Object, e As EventArgs) Handles btn_mesa2.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 2
    End Sub

    Private Sub btn_mesa3_Click(sender As Object, e As EventArgs) Handles btn_mesa3.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 3
    End Sub

    Private Sub btn_mesa4_Click(sender As Object, e As EventArgs) Handles btn_mesa4.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 4
    End Sub

    Private Sub btn_mesa5_Click(sender As Object, e As EventArgs) Handles btn_mesa5.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 5
    End Sub

    Private Sub btn_mesa6_Click(sender As Object, e As EventArgs) Handles btn_mesa6.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 6
    End Sub

    Private Sub btn_mesa7_Click(sender As Object, e As EventArgs) Handles btn_mesa7.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 7
    End Sub

    Private Sub btn_mesa8_Click(sender As Object, e As EventArgs) Handles btn_mesa8.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 8
    End Sub

    Private Sub btn_mesa9_Click(sender As Object, e As EventArgs) Handles btn_mesa9.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 9
    End Sub

    Private Sub btn_mesa10_Click(sender As Object, e As EventArgs) Handles btn_mesa10.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 10
    End Sub

    Private Sub btn_mesa11_Click(sender As Object, e As EventArgs) Handles btn_mesa11.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 11
    End Sub

    Private Sub btn_mesa12_Click(sender As Object, e As EventArgs) Handles btn_mesa12.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 12
    End Sub

    Private Sub btn_mesa13_Click(sender As Object, e As EventArgs) Handles btn_mesa13.Click
        pedido()
        Orden_Pedido.txt_numero_mesa_o.Text = 13
    End Sub

    Private Sub mesas_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Opacity = 85%
        Pagina_Principal.Enabled = False
        gbo_ordenllevar.Enabled = False
        gbo_ordenmesa.Enabled = False
        llenar_tipo_orden()
        rrecorrer_pedido()
    End Sub

    Private Sub rrecorrer_pedido()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT NUMERO_MESA, ESTADO_O from ORDEN"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            If dr.HasRows Then
                While dr.Read

                    If (dr("NUMERO_MESA") = 1) And (dr("ESTADO_O") = "A") Then
                        btn_mesa1.Enabled = False
                        btn_mesa1.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 2) And (dr("ESTADO_O") = "A") Then
                        btn_mesa2.Enabled = False
                        btn_mesa2.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 3) And (dr("ESTADO_O") = "A") Then
                        btn_mesa3.Enabled = False
                        btn_mesa3.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 4) And (dr("ESTADO_O") = "A") Then
                        btn_mesa4.Enabled = False
                        btn_mesa4.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 5) And (dr("ESTADO_O") = "A") Then
                        btn_mesa5.Enabled = False
                        btn_mesa5.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 6) And (dr("ESTADO_O") = "A") Then
                        btn_mesa6.Enabled = False
                        btn_mesa6.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 7) And (dr("ESTADO_O") = "A") Then
                        btn_mesa7.Enabled = False
                        btn_mesa7.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 8) And (dr("ESTADO_O") = "A") Then
                        btn_mesa8.Enabled = False
                        btn_mesa8.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 9) And (dr("ESTADO_O") = "A") Then
                        btn_mesa9.Enabled = False
                        btn_mesa9.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 10) And (dr("ESTADO_O") = "A") Then
                        btn_mesa10.Enabled = False
                        btn_mesa10.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 11) And (dr("ESTADO_O") = "A") Then
                        btn_mesa11.Enabled = False
                        btn_mesa11.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 12) And (dr("ESTADO_O") = "A") Then
                        btn_mesa12.Enabled = False
                        btn_mesa12.BackColor = Color.Red
                    ElseIf (dr("NUMERO_MESA") = 1) Or (dr("NUMERO_MESA") = 2) Or (dr("NUMERO_MESA") = 3) Or (dr("NUMERO_MESA") = 4) Or (dr("NUMERO_MESA") = 5) Or (dr("NUMERO_MESA") = 6) Or (dr("NUMERO_MESA") = 7) Or (dr("NUMERO_MESA") = 8) Or (dr("NUMERO_MESA") = 9) Or (dr("NUMERO_MESA") = 10) Or (dr("NUMERO_MESA") = 11) Or (dr("NUMERO_MESA") = 12) And (dr("ESTADO_O") = "I") Then
                        btn_mesa12.Enabled = True
                        btn_mesa12.BackColor = Color.White
                    End If
                End While
            End If
            dr.Close()
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub


    Private Sub llenar_tipo_orden()
        Dim sql As String
        Dim dr As SqlDataReader
        Try
            sql = "SELECT *from TIPO_ORDEN"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_categoria_pedido.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub btn_volver_pedido_Click(sender As Object, e As EventArgs) Handles btn_volver_pedido.Click
        Pagina_Principal.Opacity = 100%
        Pagina_Principal.Enabled = True
        Close()
        Dispose()
    End Sub


    Public Sub cbo_categoria_pedido_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_categoria_pedido.SelectedIndexChanged
        If (cbo_categoria_pedido.Text = "LLEVAR") Then
            gbo_ordenllevar.Enabled = True
            gbo_ordenmesa.Enabled = False
        ElseIf (cbo_categoria_pedido.Text = "MESA") Then
            gbo_ordenmesa.Enabled = True
            gbo_ordenllevar.Enabled = False
        End If
    End Sub
End Class