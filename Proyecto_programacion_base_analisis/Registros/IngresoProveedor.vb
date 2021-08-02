Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Public Class IngresoProveedor

    Private Sub IngresoProveedor_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Pagina_Principal.Opacity = 85%
        Pagina_Principal.Enabled = False
        btn_guardar_proveedores.Enabled = False
        txt_email_proveedores.Text = "example@hotmail.com"
        gbo_proveedores.Enabled = False
    End Sub

    Private Sub txt_nombre_proveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre_proveedores.KeyPress
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

    Private Sub btn_guardar_proveedores_Click(sender As Object, e As EventArgs) Handles btn_guardar_proveedores.Click
       
        Dim sql As String
        If (txt_nombre_proveedores.Text = "" And
            txt_apellidos_proveedores.Text = "" And
            txt_apellido2_proveedores.Text = "" And
            txt_direccion_proveedores.Text = "" And
            txt_email_proveedores.Text = " ") Then
            MsgBox(" Debe llenar los Campos Obligatorios ")
        Else
            Try
                sql = "INSERT INTO PROVEEDORES(CEDULA,NOMBRE, APELLIDO_PATERNO, APELLIDO_MATERNO, DIRECCION, TELEFONO, EMAIL, ESTADO_P) VALUES ("
                sql = sql & "'" & Trim(txt_cedula_proveedor.Text) & "', "
                sql = sql & "'" & Trim(txt_nombre_proveedores.Text) & "', "
                sql = sql & "'" & Trim(txt_apellidos_proveedores.Text) & "', "
                sql = sql & "'" & Trim(txt_apellido2_proveedores.Text) & "', "
                sql = sql & "'" & Trim(txt_direccion_proveedores.Text) & "', "
                sql = sql & "'" & Trim(txt_telefono_proveedores.Text) & "', "
                sql = sql & "'" & Trim(txt_email_proveedores.Text) & "', "
                sql = sql & "'A" & "')"
                Dim com As New SqlCommand(sql, mycon)
                Dim x As Integer
                x = com.ExecuteNonQuery
                MsgBox(" PROVEEDOR ALMACENADO")
                btn_guardar_proveedores.Enabled = False
            Catch ex As Exception
                MsgBox(" NO SE A PODIDO ALMACENAR LOS DATOS" & ex.Message)
            End Try
        End If
        limpiar()
        gbo_proveedores.Enabled = False
    End Sub

    Private Sub limpiar()
        txt_cedula_proveedor.Text = ""
        txt_nombre_proveedores.Text = ""
        txt_apellidos_proveedores.Text = ""
        txt_apellido2_proveedores.Text = ""
        txt_direccion_proveedores.Text = ""
        txt_email_proveedores.Text = "example@hotmail.com"
        txt_telefono_proveedores.Text = ""
    End Sub
    Private Sub btn_volver_proveedores_Click(sender As Object, e As EventArgs) Handles btn_volver_proveedores.Click
        Pagina_Principal.Opacity = 100%
        Pagina_Principal.Enabled = True
        Close()
        Dispose()
    End Sub

    Private Sub txt_apellidos_proveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellidos_proveedores.KeyPress
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

    Private Sub btn_nuevo_proveedor_Click(sender As Object, e As EventArgs) Handles btn_nuevo_proveedor.Click
        btn_guardar_proveedores.Enabled = True
        gbo_proveedores.Enabled = True
        Me.txt_cedula_proveedor.Focus()
    End Sub

    Private Sub txt_apellido2_proveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_apellido2_proveedores.KeyPress
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

    Private Sub txt_telefono_proveedores_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_telefono_proveedores.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_telefono_proveedores.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_proveedores.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_telefono_proveedores.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_telefono_proveedores.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

    Private Sub txt_cedula_proveedor_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_cedula_proveedor.KeyPress
        If InStr(1, "0123456789.-" & Chr(8), e.KeyChar) = 0 Then
            e.KeyChar = CChar("")
        ElseIf e.KeyChar = "." Then
            If txt_cedula_proveedor.Text = "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_proveedor.Text, ".") <> 0 Then
                    e.KeyChar = CChar("")
                End If

            End If
        ElseIf e.KeyChar = "-" Then
            If txt_cedula_proveedor.Text <> "" Then
                e.KeyChar = CChar("")
            Else
                If InStr(txt_cedula_proveedor.Text, "-") <> 0 Then
                    e.KeyChar = CChar("")
                End If
            End If
        End If
    End Sub

End Class