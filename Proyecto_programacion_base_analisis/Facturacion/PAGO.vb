Public Class PAGO

    Private Sub PAGO_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        txt_pago_caja.Text = Registra_Datos_Factura.txt_total_p_f.Text
    End Sub

    Private Sub btn_nuevo_plato_Click(sender As Object, e As EventArgs) Handles btn_nuevo_plato.Click
        If Val(txt_ingrese_caja.Text) < Val(txt_pago_caja.Text) Then
            MsgBox("monto insuficiente")
        Else
            Close()
        End If
    End Sub

    Private Sub txt_ingrese_caja_TextChanged(sender As Object, e As EventArgs) Handles txt_ingrese_caja.TextChanged
        txt_cambio_caja.Text = txt_ingrese_caja.Text - txt_pago_caja.Text
    End Sub
End Class