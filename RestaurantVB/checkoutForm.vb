Public Class checkoutForm
    Private Sub CheckouForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AbrirConexion()
        Poblar()


        lbFecha.Text = Now.ToString("hh:mm:ss tt")

        baseForm.LimpiaCompra()
    End Sub

    Public Sub Poblar()
        Dim da As New OleDb.OleDbDataAdapter("select id_producto,descripcion,cantidad,precio,(cantidad*precio) as subtotal from temp group by id_producto,descripcion,cantidad,precio", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)

        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)

            lbTotal.Text = baseForm.lbTOTAL.Text
        End If
    End Sub

    Private Sub btnImprimir_Click(sender As Object, e As EventArgs) Handles btnImprimir.Click
        btnImprimir.Visible = False
        Using bmp = New Bitmap(Me.Width, Me.Height)
            Me.DrawToBitmap(bmp, New Rectangle(0, 0, bmp.Width, bmp.Height))
            bmp.Save("screenshot.png")
            System.Diagnostics.Process.Start("MSPaint.exe", "screenshot.png")

        End Using
        btnImprimir.Visible = True
    End Sub
End Class