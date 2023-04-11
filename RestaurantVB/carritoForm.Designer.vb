<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class carritoForm
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim DataGridViewCellStyle3 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle1 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Dim DataGridViewCellStyle2 As System.Windows.Forms.DataGridViewCellStyle = New System.Windows.Forms.DataGridViewCellStyle()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.ID = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ID_PRODUCTO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.FOTO = New System.Windows.Forms.DataGridViewImageColumn()
        Me.DESCRIPCION = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.PRECIO = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CANTIDAD = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.RUTA = New System.Windows.Forms.DataGridViewTextBoxColumn()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AllowUserToAddRows = False
        Me.DataGridView1.AllowUserToDeleteRows = False
        Me.DataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridView1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.ColumnHeadersVisible = False
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.ID, Me.ID_PRODUCTO, Me.FOTO, Me.DESCRIPCION, Me.PRECIO, Me.CANTIDAD, Me.RUTA})
        DataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft
        DataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window
        DataGridViewCellStyle3.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        DataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText
        DataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlLight
        DataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.ControlDarkDark
        DataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.[False]
        Me.DataGridView1.DefaultCellStyle = DataGridViewCellStyle3
        Me.DataGridView1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.DataGridView1.Location = New System.Drawing.Point(0, 0)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.RowHeadersVisible = False
        Me.DataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridView1.Size = New System.Drawing.Size(800, 450)
        Me.DataGridView1.TabIndex = 1
        '
        'ID
        '
        Me.ID.DataPropertyName = "id"
        Me.ID.HeaderText = "ID"
        Me.ID.Name = "ID"
        Me.ID.Visible = False
        '
        'ID_PRODUCTO
        '
        Me.ID_PRODUCTO.DataPropertyName = "id_producto"
        Me.ID_PRODUCTO.HeaderText = "ID_PRODUCTO"
        Me.ID_PRODUCTO.Name = "ID_PRODUCTO"
        Me.ID_PRODUCTO.Visible = False
        '
        'FOTO
        '
        Me.FOTO.HeaderText = "FOTO"
        Me.FOTO.Name = "FOTO"
        '
        'DESCRIPCION
        '
        Me.DESCRIPCION.DataPropertyName = "descripcion"
        Me.DESCRIPCION.HeaderText = "DESCRIPCION"
        Me.DESCRIPCION.Name = "DESCRIPCION"
        Me.DESCRIPCION.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.DESCRIPCION.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'PRECIO
        '
        Me.PRECIO.DataPropertyName = "precio"
        DataGridViewCellStyle1.Format = "C2"
        DataGridViewCellStyle1.NullValue = "0"
        Me.PRECIO.DefaultCellStyle = DataGridViewCellStyle1
        Me.PRECIO.HeaderText = "PRECIO"
        Me.PRECIO.Name = "PRECIO"
        Me.PRECIO.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.PRECIO.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'CANTIDAD
        '
        Me.CANTIDAD.DataPropertyName = "cantidad"
        DataGridViewCellStyle2.Format = "N0"
        DataGridViewCellStyle2.NullValue = "0"
        Me.CANTIDAD.DefaultCellStyle = DataGridViewCellStyle2
        Me.CANTIDAD.HeaderText = "CANTIDAD"
        Me.CANTIDAD.Name = "CANTIDAD"
        Me.CANTIDAD.Resizable = System.Windows.Forms.DataGridViewTriState.[True]
        Me.CANTIDAD.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable
        '
        'RUTA
        '
        Me.RUTA.DataPropertyName = "ruta"
        Me.RUTA.HeaderText = "RUTA"
        Me.RUTA.Name = "RUTA"
        Me.RUTA.Visible = False
        '
        'carritoForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.ControlBox = False
        Me.Controls.Add(Me.DataGridView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "carritoForm"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DataGridView1 As DataGridView
    Friend WithEvents ID As DataGridViewTextBoxColumn
    Friend WithEvents ID_PRODUCTO As DataGridViewTextBoxColumn
    Friend WithEvents FOTO As DataGridViewImageColumn
    Friend WithEvents DESCRIPCION As DataGridViewTextBoxColumn
    Friend WithEvents PRECIO As DataGridViewTextBoxColumn
    Friend WithEvents CANTIDAD As DataGridViewTextBoxColumn
    Friend WithEvents RUTA As DataGridViewTextBoxColumn
End Class
