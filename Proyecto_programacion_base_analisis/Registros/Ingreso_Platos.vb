Imports System.Data.SqlClient
Imports System.IO

Public Class Ingreso_Platos
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    Dim a As New OpenFileDialog
    Private Sub btn_guardar_plato_ingreso_Click(sender As Object, e As EventArgs) Handles btn_guardar_plato_ingreso.Click

        If (txt_nombre_platos_i.Text = "" And txt_precio_platos_i.Text = "") Then
            MessageBox.Show("No Hay Ingresado Datos ......", "ACCESO", MessageBoxButtons.OK, MessageBoxIcon.Stop)
        Else
            Try

                sql = "INSERT INTO PLATOS(FK_ID_CATEGORIA_PLATOS, PRECIO, NOMBRE, ESTADO_P, FOTO_P) VALUES ("
                sql = sql & Val(cbo_platos_ingresos_categ.SelectedValue) & ", "
                sql = sql & txt_precio_platos_i.Text & ", "
                sql = sql & "'" & Trim(txt_nombre_platos_i.Text) & "', "
                sql = sql & "'A"
                sql = sql & "',@FOTO_P)"

                Dim com As New SqlCommand(sql, mycon)

                com.Parameters.Add(New SqlClient.SqlParameter("@FOTO_P", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)


                Dim x As Integer
                x = com.ExecuteNonQuery

                MsgBox("PLATO ALMACENADO CORRECTAMENTE")

            Catch ex As Exception
                MsgBox("no se a podido guardar los datos" & ex.Message)
            End Try
        End If

        btn_guardar_plato_ingreso.Enabled = False
        limpiar()
        PictureBox1.Image = Nothing
        desactivar()
    End Sub

    Private Sub llenar_combo_tipo_plato()
        Try
            sql = "SELECT *FROM CATEGORIA_PLATOS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_platos_ingresos_categ.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub limpiar()
        txt_nombre_platos_i.Text = " "
        txt_precio_platos_i.Text = " "
        cbo_platos_ingresos_categ.Text = " "
    End Sub

    Private Sub ingresoPlatos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Opacity = 85%
        Pagina_Principal.Enabled = False
        desactivar()
        llenar_combo_tipo_plato()
    End Sub



    Private Sub desactivar()
        btn_guardar_plato_ingreso.Enabled = False
        btn_cargar_foto_ingreso_plato.Enabled = False
        gbo_ingreso_platos_datos.Enabled = False
        gbo_ingresos_platos.Enabled = False
    End Sub
    Private Sub btn_volver_plato_ingreso_Click(sender As Object, e As EventArgs) Handles btn_volver_plato_ingreso.Click
        Pagina_Principal.Opacity = 100%
        Pagina_Principal.Enabled = True
        Close()
        Dispose()
    End Sub

    Private Sub btn_nuevo_platos_Click(sender As Object, e As EventArgs) Handles btn_nuevo_platos.Click
        btn_guardar_plato_ingreso.Enabled = True
        btn_cargar_foto_ingreso_plato.Enabled = True
        gbo_ingreso_platos_datos.Enabled = True
        gbo_ingresos_platos.Enabled = True
    End Sub

    Private Sub txt_nombre_platos_i_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_platos_i.KeyPress
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

    Private Sub txt_precio_platos_i_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_precio_platos_i.KeyPress
        If InStr(1, "0123456789." & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_precio_platos_i.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_precio_platos_i.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_precio_platos_i.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_precio_platos_i.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub


    Private Sub btn_cargar_foto_ingreso_plato_Click(sender As Object, e As EventArgs) Handles btn_cargar_foto_ingreso_plato.Click
        Dim picl As String
        a.Filter = Nothing
        picl = a.FileName
        a.ShowDialog()
        PictureBox1.Image = Image.FromFile(a.FileName)
    End Sub
End Class