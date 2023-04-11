Public Class comboForm
    Dim da As OleDb.OleDbDataAdapter
    Dim ds As DataSet
    Public Categoria As String = ""
    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Poblar()
        da = New OleDb.OleDbDataAdapter("select ID,DESCRIPCION,PRECIO,FOTO from producto where categoria='" & Categoria & "'", Conexion)
        ds = New DataSet
        da.Fill(ds)
        If ds.Tables(0).Rows.Count > 0 Then
            DataGridView1.AutoGenerateColumns = False

            DataGridView1.DataSource = ds.Tables(0)

        Else
            DataGridView1.DataSource = Nothing
        End If


    End Sub

    Private Sub DataGridView1_VisibleChanged(sender As Object, e As EventArgs) Handles DataGridView1.VisibleChanged
        For Each fila As DataGridViewRow In DataGridView1.Rows
            da = New OleDb.OleDbDataAdapter("select * from producto where id=" & fila.Cells("ID").Value, Conexion)
            ds = New DataSet
            da.Fill(ds)

            If ds.Tables(0).Rows.Count > 0 Then
                fila.Cells("FOTO").Value = Image.FromFile(ds.Tables(0).Rows(0).Item("foto").ToString)
            End If
        Next
    End Sub

    Private Sub DataGridView1_CellEnter(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellEnter
        If DataGridView1.Rows.Count > 0 Then
            If DataGridView1.CurrentRow.Cells("CANTIDAD").Value IsNot Nothing Then
            Else

                DataGridView1.CurrentRow.Cells("CANTIDAD").Value = 1
            End If
        End If
    End Sub

    Private Sub comboForm_Load(sender As Object, e As EventArgs) Handles Me.Load
        Poblar()
    End Sub
End Class