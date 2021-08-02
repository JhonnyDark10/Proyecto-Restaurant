Imports System.Data
Imports System.Data.SqlClient
Imports System.Data.OleDb
Imports System.Configuration
Public Class Pagina_Principal
    Private Sub EmpleadosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Empleados.Click

        Ingreso_Empleados.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Clientes.Click
        Ingreso_Clientes.Show()
        Ingreso_Clientes.btn_ir_factura.Visible = False
    End Sub

    Private Sub ProveedoresToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Proveedores.Click
        IngresoProveedor.Show()

    End Sub

    Private Sub PlatosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles Platos.Click
        Ingreso_Platos.Show()

    End Sub

    Private Sub IngresoPedidosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles IngresoPedidosToolStripMenuItem.Click
        Registra_Mesas_Pedido.Show()

    End Sub

    Private Sub DetallesToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles DetallesToolStripMenuItem.Click
        Registra_Datos_Factura.Show()

    End Sub

 

    Private Sub ClientesToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Clientes_E.Click
        Actualizar_Cliente.Show()

    End Sub

    Private Sub EmpleadosToolStripMenuItem3_Click(sender As Object, e As EventArgs) Handles Empleados_E.Click
        Actualizar_Empleado.Show()

    End Sub

    Private Sub ProveedoresToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Proveedores_E.Click
        Actualizar_Proveedores.Show()

    End Sub

    Private Sub PlatosToolStripMenuItem2_Click(sender As Object, e As EventArgs) Handles Platos_E.Click
        Actualizar_Plato.Show()

    End Sub

    Private Sub SALIRToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles SALIR.Click
        Acceso_Sistema.Show()
    End Sub


    Private Sub CategoriasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CategoriasToolStripMenuItem.Click
        Tipo_Cliente.Show()

    End Sub

    Private Sub TipoEmpleadoToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles TipoEmpleadoToolStripMenuItem1.Click
        Tipo_Empleado.Show()

    End Sub

    Private Sub TipoPlatosToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoPlatosToolStripMenuItem.Click
        Tipo_Platos.Show()

    End Sub

    Private Sub TipoTarjetasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoTarjetasToolStripMenuItem.Click
        Tipo_Tarjeta.Show()

    End Sub

    Private Sub ClientesToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles ClientesToolStripMenuItem1.Click
        Reporte_Clientes.Show()

    End Sub

    Private Sub EmpleadosToolStripMenuItem1_Click(sender As Object, e As EventArgs) Handles EmpleadosToolStripMenuItem1.Click
        Reporte_Empleados.Show()

    End Sub


    Private Sub txt_cerrar_secion_Click(sender As Object, e As EventArgs)
        txt_princpal_acceso_ususario.Text = ""
        Acceso_Sistema.Show()

    End Sub


    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles btn_cerrar_secion.Click
        txt_princpal_acceso_ususario.Text = ""
        Acceso_Sistema.Show()
    End Sub

    Private Sub Pagina_Principal_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Acceso_Sistema.Show()
    End Sub

    Private Sub TipoTiempoMembresiaToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoTiempoMembresiaToolStripMenuItem.Click
        Tipo_tiempo_membresia.Show()
    End Sub

    Private Sub TipoPedidoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoPedidoToolStripMenuItem.Click
        Tipo_Orden.Show()

    End Sub

    Private Sub MesasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles MesasToolStripMenuItem.Click
        Mesas.Show()
    End Sub

    Private Sub TipoPagoToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles TipoPagoToolStripMenuItem.Click
        Tipo_Pago.Show()

    End Sub

    Private Sub CuentaUsuarioToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CuentaU_E.Click
        Acceso_Sistema.Show()
    End Sub

    Private Sub MembresiasToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles Membresias_E.Click
        ActualizarMembresia.Show()

    End Sub
End Class
