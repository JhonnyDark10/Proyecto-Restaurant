Imports System.Data.SqlClient
Imports System.IO
Public Class Actualizar_Plato
    Dim sql As String
    Dim dr As SqlDataReader
    Dim dt As New DataTable
    'Dim a As New OpenFileDialog
    Private Sub actualizarplato_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Enabled = False
        Pagina_Principal.Opacity = 85%
        gbo_actualizar_platos_datos.Enabled = False
        btn_guardar_plato_actualizar.Enabled = False
        btn_eliminar_pL.Enabled = False
        llenar_combo_tipo_plato()
    End Sub


    Private Sub llenar_combo_tipo_plato()
        Try
            sql = "SELECT *FROM CATEGORIA_PLATOS"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            cbo_platos_actualizar_categ.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub
   

    Private Sub cbo_actualizar_platos_t_Click(sender As Object, e As EventArgs)
        gbo_actualizar_platos_datos.Enabled = True
        btn_guardar_plato_actualizar.Enabled = True
    End Sub


    Private Sub btn_volver_plato_actualizar_Click(sender As Object, e As EventArgs) Handles btn_volver_plato_actualizar.Click
        Pagina_Principal.Enabled = True
        Pagina_Principal.Opacity = 100%
        Close()
        Dispose()
    End Sub

    Private Sub btn_guardar_plato_actualizar_Click(sender As Object, e As EventArgs) Handles btn_guardar_plato_actualizar.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String
        If (txt_nombre_platos_a.Text = "" Or txt_precio_platos_a.Text = "") Then
            MsgBox("Debe Llenar los campos NOMBRE, PRECIO para actualizar ......")
        Else
            sql = "update PLATOS set "
            sql = sql & "NOMBRE" & "=" & "'" & Trim(txt_nombre_platos_a.Text) & "', "
            sql = sql & "PRECIO" & "=" & "'" & Trim(txt_precio_platos_a.Text) & "'" & " where CODIGO_PLATOS" & "=" & txt_codigo.Text & ""
            Dim com As New SqlCommand(sql, mycon)
            'com.Parameters.Add(New SqlClient.SqlParameter("@FOTO_P", SqlDbType.Image)).Value = IO.File.ReadAllBytes(a.FileName)
            'sql = sql & "FOTO_P" & "=" & "@FOTO"
            dr_1 = com.ExecuteReader
            dr_1.Close()
            MsgBox("  Editado......")
            txt_codigo.Text = ""
            txt_nombre_platos_a.Text = ""
            txt_precio_platos_a.Text = ""
            rb_actualizar_datos_empleados.Checked = False
            btn_guardar_plato_actualizar.Enabled = False
            btn_eliminar_pL.Enabled = False
            LLENAR_VISUALIZA_ACTUALIZA()
            dgv_llenar_tipo_platos.DataSource = "" : dgv_llenar_tipo_platos.DataMember = ""
        End If
    End Sub

    Private Sub LLENAR_VISUALIZA_ACTUALIZA()

        Try
            sql = "SELECT CODIGO_PLATOS,NOMBRE,PRECIO,FOTO_P FROM PLATOS WHERE FK_ID_CATEGORIA_PLATOS = " & Val(cbo_platos_actualizar_categ.SelectedValue) & "" & " AND " & "ESTADO_P ='" & "A" & "'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d31 As New DataTable
            d31.Load(dr)
            dgv_actualizar_platos.DataSource = d31
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try


    End Sub
    Private Sub cbo_platos_actualizar_categ_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cbo_platos_actualizar_categ.SelectedIndexChanged
        dgv_actualizar_platos.DataSource = "" : dgv_actualizar_platos.DataMember = ""
        llenar_dgv_()
    End Sub

    Private Sub llenar_dgv_()
        Try
            sql = "SELECT CODIGO_PLATOS,NOMBRE FROM PLATOS WHERE FK_ID_CATEGORIA_PLATOS = " & Val(cbo_platos_actualizar_categ.SelectedValue) & "" & " AND " & "ESTADO_P ='" & "A" & "'"
            Dim com As New SqlCommand(sql, mycon)
            dr = com.ExecuteReader
            Dim d1 As New DataTable
            d1.Load(dr)
            dgv_llenar_tipo_platos.DataSource = d1
        Catch ex As Exception
            MsgBox("Error al conectar con la BD " & ex.Message)
        End Try
    End Sub

    Private Sub txt_codigo_TextChanged(sender As Object, e As EventArgs) Handles txt_codigo.TextChanged

        btn_eliminar_pL.Enabled = True

    End Sub

    Private Sub btn_eliminar_pL_Click(sender As Object, e As EventArgs) Handles btn_eliminar_pL.Click
        Dim dr_1 As SqlDataReader
        Dim sql As String
        sql = "update PLATOS set "
        sql = sql & "ESTADO_P" & "=" & "'" & "I" & "' " & " where CODIGO_PLATOS" & "= '" & txt_codigo.Text & "'"
        Dim com As New SqlCommand(sql, mycon)
        dr_1 = com.ExecuteReader
        dr_1.Close()
        MsgBox(" PLATO ELIMINADO......")
        LLENAR_VISUALIZA_ACTUALIZA()
        txt_codigo.Text = ""
        txt_nombre_platos_a.Text = ""
        txt_precio_platos_a.Text = ""
        rb_actualizar_datos_empleados.Checked = False
        btn_guardar_plato_actualizar.Enabled = False
        btn_eliminar_pL.Enabled = False
        LLENAR_VISUALIZA_ACTUALIZA()
        dgv_llenar_tipo_platos.DataSource = "" : dgv_llenar_tipo_platos.DataMember = ""
    End Sub

    'Private Sub btn_cargar_foto_ingreso_plato_Click(sender As Object, e As EventArgs) Handles btn_cargar_foto_ingreso_plato.Click
    '    Dim picl As String
    '    a.Filter = Nothing
    '    picl = a.FileName
    '    a.ShowDialog()
    '    PictureBox1.Image = Image.FromFile(a.FileName)
    'End Sub

    Private Sub rb_actualizar_datos_empleados_CheckedChanged(sender As Object, e As EventArgs) Handles rb_actualizar_datos_empleados.CheckedChanged
        If (rb_actualizar_datos_empleados.Checked = True) Then
            gbo_actualizar_platos_datos.Enabled = True
            btn_guardar_plato_actualizar.Enabled = True
            btn_eliminar_pL.Enabled = False
        End If
    End Sub
End Class