Public Class carritoForm
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As DataSet

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Public Sub Poblar()
        da = New OleDb.OleDbDataAdapter("select ID,ID_PRODUCTO,DESCRIPCION,PRECIO,CANTIDAD,RUTA from temp", Conexion)
        ds = New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = False

            DataGridView1.DataSource = ds.Tables(0)

        Else
            DataGridView1.DataSource = Nothing
        End If


    End Sub

    Private Sub carritoForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Poblar()
    End Sub

    Private Sub carritoForm_VisibleChanged(sender As Object, e As EventArgs) Handles Me.VisibleChanged
        For Each fila As DataGridViewRow In DataGridView1.Rows
            da = New OleDb.OleDbDataAdapter("select * from temp where id_producto=" & fila.Cells("ID_producto").Value, Conexion)
            ds = New DataSet
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                fila.Cells("FOTO").Value = Image.FromFile(ds.Tables(0).Rows(0).Item("RUTA").ToString)
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellEndEdit(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEndEdit
        If DataGridView1.Rows.Count > 0 Then
            If DataGridView1.CurrentRow.Cells("CANTIDAD").Value IsNot Nothing Then
                Dim cmd As New OleDb.OleDbCommand("update temp set cantidad='" & DataGridView1.CurrentCell.Value & "' where id=" & DataGridView1.CurrentRow.Cells("ID").Value, Conexion)
                cmd.ExecuteNonQuery()

            End If

            baseForm.CalculaTotal()
        End If
    End Sub
End Class