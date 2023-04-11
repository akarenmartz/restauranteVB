Public Class baseForm
    Private Sub btnCombos_Click(sender As Object, e As EventArgs) Handles btnCombos.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        comboForm.MdiParent = Me
        PanelPrincipal.Controls.Add(comboForm)
        comboForm.Categoria = "COMBOS"
        comboForm.Show()

        comboForm.WindowState = FormWindowState.Maximized

        lbOpcion.Text = "Combos"
    End Sub

    Private Sub baseForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()

        LimpiaCompra()

        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        comboForm.MdiParent = Me
        PanelPrincipal.Controls.Add(comboForm)
        comboForm.Categoria = "COMBOS"
        comboForm.Show()

        comboForm.WindowState = FormWindowState.Maximized

        lbOpcion.Text = "Combos"

    End Sub

    Private Sub baseForm_Resize(sender As Object, e As EventArgs) Handles Me.Resize
        comboForm.WindowState = FormWindowState.Normal : comboForm.WindowState = FormWindowState.Maximized
    End Sub

    Private Sub btnAdmin_Click(sender As Object, e As EventArgs) Handles btnAdmin.Click
        mainForm.Show()
    End Sub

    Private Sub btnComidas_Click(sender As Object, e As EventArgs) Handles btnComidas.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        comboForm.MdiParent = Me
        PanelPrincipal.Controls.Add(comboForm)
        comboForm.Categoria = "COMIDAS"
        comboForm.Show()

        comboForm.WindowState = FormWindowState.Maximized

        lbOpcion.Text = "Comidas"
    End Sub

    Public Sub CalculaTotal()
        Dim da As New OleDb.OleDbDataAdapter("select * from temp", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)

        lbTOTAL.Text = "0"
        If ds.Tables(0).Rows.Count > 0 Then
            For Each fila In ds.Tables(0).Rows
                lbTOTAL.Text = CDbl(lbTOTAL.Text) + (fila("cantidad") * fila("precio"))
            Next
        End If

        lbTOTAL.Text = Format(lbTOTAL.Text, "standard")
    End Sub

    Private Sub btnBebidas_Click(sender As Object, e As EventArgs) Handles btnBebidas.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        comboForm.MdiParent = Me
        PanelPrincipal.Controls.Add(comboForm)
        comboForm.Categoria = "BEBIDAS"
        comboForm.Show()

        comboForm.WindowState = FormWindowState.Maximized

        lbOpcion.Text = "Bebidas"
    End Sub

    Private Sub btnPostres_Click(sender As Object, e As EventArgs) Handles btnPostres.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        comboForm.MdiParent = Me
        PanelPrincipal.Controls.Add(comboForm)
        comboForm.Categoria = "POSTRES"
        comboForm.Show()

        comboForm.WindowState = FormWindowState.Maximized

        lbOpcion.Text = "Postres"
    End Sub

    Private Sub btnCarrito_Click(sender As Object, e As EventArgs) Handles btnCarrito.Click
        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        carritoForm.MdiParent = Me
        PanelPrincipal.Controls.Add(carritoForm)
        carritoForm.Show()
        carritoForm.WindowState = FormWindowState.Maximized

        lbOpcion.Text = "Carrito"
    End Sub

    Public Sub LimpiaCompra()
        Dim cmd As New OleDb.OleDbCommand("delete * from temp", Conexion)
        cmd.ExecuteNonQuery()

        lbTOTAL.Text = "0"
    End Sub

    Private Sub btnCompletar_Click(sender As Object, e As EventArgs) Handles btnCompletar.Click
        If MessageBox.Show("¿Completar este pedido?", "Atención", MessageBoxButtons.YesNo, MessageBoxIcon.Question) = DialogResult.Yes Then
            Dim Recibo As Integer = "1"
            Dim MiFecha As Date = Today.Date

            Dim da As New OleDb.OleDbDataAdapter("select IIf(MAX(ID) Is Null, 0, MAX(ID)) AS ID from ventas ", Conexion)
            Dim ds As New DataSet
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                Recibo = CInt(ds.Tables(0).Rows(0).Item("ID")) + 1
            End If

            Dim cmd As New OleDb.OleDbCommand("insert into ventas(id_venta,fecha) values('" & Recibo & "','" & MiFecha & "')", Conexion)
            cmd.ExecuteNonQuery()

            For Each fila As DataGridViewRow In carritoForm.DataGridView1.Rows
                cmd = New OleDb.OleDbCommand("insert into venta_detalle(id_venta,id_producto,descripcion,cantidad,precio) values('" & Recibo & "','" & fila.Cells("id_producto").Value & "','" & fila.Cells("descripcion").Value & "','" & fila.Cells("cantidad").Value & "','" & fila.Cells("precio").Value & "')", Conexion)
                cmd.ExecuteNonQuery()
            Next



            My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


            checkoutForm.MdiParent = Me
            PanelPrincipal.Controls.Add(checkoutForm)
            checkoutForm.Show()
            checkoutForm.lbPedido.Text = Recibo

            checkoutForm.WindowState = FormWindowState.Maximized

            lbOpcion.Text = "Pedido"
        End If
    End Sub

    Private Sub btnAgregar_Click(sender As Object, e As EventArgs) Handles btnAgregar.Click
        For Each frm As Form In My.Application.OpenForms

            If frm.Name = "comboForm" Then
                For Each fila As DataGridViewRow In comboForm.DataGridView1.Rows

                    If fila.Cells("SELECCIONAR").Value = True Then
                        Dim cmd As New OleDb.OleDbCommand("insert into temp(id_producto,descripcion,cantidad,precio,ruta) values('" & fila.Cells("ID").Value & "','" & fila.Cells("DESCRIPCION").Value & "','" & fila.Cells("CANTIDAD").Value & "','" & fila.Cells("PRECIO").Value & "','" & fila.Cells("RUTA").Value.ToString & "')", Conexion)
                        cmd.ExecuteNonQuery()
                    End If
                Next

                comboForm.Close()
                Exit For
            End If

        Next

        CalculaTotal()

        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())

        carritoForm.MdiParent = Me
        PanelPrincipal.Controls.Add(carritoForm)
        carritoForm.Show()
        carritoForm.WindowState = FormWindowState.Normal
        carritoForm.WindowState = FormWindowState.Maximized

        lbOpcion.Text = "Carrito"
    End Sub

    Private Sub btnRemover_Click(sender As Object, e As EventArgs) Handles btnRemover.Click
        If carritoForm.DataGridView1.Rows.Count > 0 Then
            Dim cmd As New OleDb.OleDbCommand("delete * from temp where id=" & carritoForm.DataGridView1.CurrentRow.Cells("ID").Value, Conexion)
            cmd.ExecuteNonQuery()

            carritoForm.DataGridView1.Rows.Remove(carritoForm.DataGridView1.CurrentRow)
        End If

        CalculaTotal()
    End Sub

    Private Sub tnNuevaOrden_Click(sender As Object, e As EventArgs) Handles tnNuevaOrden.Click
        LimpiaCompra()

        My.Application.OpenForms.Cast(Of Form)().Except({Me}).ToList().ForEach(Sub(form) form.Close())


        comboForm.MdiParent = Me
        PanelPrincipal.Controls.Add(comboForm)
        comboForm.Categoria = "COMBOS"
        comboForm.Show()

        comboForm.WindowState = FormWindowState.Maximized

        lbOpcion.Text = "Combos"
    End Sub
End Class
