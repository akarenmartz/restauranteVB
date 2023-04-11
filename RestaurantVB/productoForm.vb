Public Class productoForm
    Private Sub productoForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Poblar()
    End Sub


    Private Sub Poblar()
        Dim da As New OleDb.OleDbDataAdapter("select * from producto where descripcion like'%" & txtBuscar.Text & "%'", Conexion)
        Dim ds As New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.DataSource = ds.Tables(0)
        Else
            DataGridView1.DataSource = Nothing
        End If
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.Rows.Count > 0 Then
            txtID.Text = DataGridView1.CurrentRow.Cells("ID").Value
            txtPrecio.Text = DataGridView1.CurrentRow.Cells("PRECIO").Value.ToString
            txtDescripcion.Text = DataGridView1.CurrentRow.Cells("DESCRIPCION").Value.ToString
            cboTipo.Text = DataGridView1.CurrentRow.Cells("CATEGORIA").Value.ToString
            txtRuta.Text = DataGridView1.CurrentRow.Cells("FOTO").Value.ToString


            PictureBox1.Image = Image.FromFile(txtRuta.Text)
        End If
    End Sub

    Private Sub btnNuevo_Click(sender As Object, e As EventArgs) Handles btnNuevo.Click
        limpiar
    End Sub

    Private Sub Limpiar()
        txtID.Text = "0"
        txtDescripcion.Clear()
        txtPrecio.Clear()
        txtRuta.Clear()
        cboTipo.SelectedIndex = -1
        PictureBox1.Image = Nothing

        txtDescripcion.Focus()

    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        If txtID.Text = "0" Then
            Dim cmd As New OleDb.OleDbCommand("insert into producto(descripcion,precio,categoria,foto) values('" & txtDescripcion.Text & "','" & txtPrecio.Text & "','" & cboTipo.Text & "','" & txtRuta.Text & "')", Conexion)
            cmd.ExecuteNonQuery()

            Poblar()
        Else
            Dim cmd As New OleDb.OleDbCommand("update producto set descripcion='" & txtDescripcion.Text & "',precio='" & txtPrecio.Text & "',categoria='" & cboTipo.Text & "',foto='" & txtRuta.Text & "' where id=" & txtID.Text, Conexion)
            cmd.ExecuteNonQuery()

            Poblar()
        End If
    End Sub

    Private Sub btnEliminar_Click(sender As Object, e As EventArgs) Handles btnEliminar.Click
        Dim cmd As New OleDb.OleDbCommand("delete * from producto where id=" & txtID.Text, Conexion)
        cmd.ExecuteNonQuery()

        Poblar()
    End Sub

    Private Sub txtRuta_TextChanged(sender As Object, e As EventArgs) Handles txtRuta.TextChanged

    End Sub

    Private Sub txtRuta_Click(sender As Object, e As EventArgs) Handles txtRuta.Click
        OpenFileDialog1.InitialDirectory = (My.Computer.FileSystem.CurrentDirectory & "\Imagenes")
        OpenFileDialog1.Filter = "Archivos de Imagenes |*.jpg;*.jpeg;*.png;*.bmp"
        Dim result As DialogResult = OpenFileDialog1.ShowDialog()

        txtRuta.Text = OpenFileDialog1.FileName
        PictureBox1.Image = Image.FromFile(txtRuta.Text)
    End Sub

    Private Sub btnBuscar_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        Poblar()
    End Sub
End Class