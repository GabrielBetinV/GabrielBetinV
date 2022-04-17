<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.TabControl1 = New System.Windows.Forms.TabControl()
        Me.TabPage1 = New System.Windows.Forms.TabPage()
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.ButtonBorrarBodegas = New System.Windows.Forms.Button()
        Me.ButtonEliminarProducto = New System.Windows.Forms.Button()
        Me.ButtonEditarProducto = New System.Windows.Forms.Button()
        Me.ButtonCrearProducto = New System.Windows.Forms.Button()
        Me.TextBoxContactoBodega = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.TextBoxDireccionBodega = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.TextBoxNmbreBodega = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBoxCodigoBodega = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.TextBoxFiltroBodegas = New System.Windows.Forms.TextBox()
        Me.DataGridBodegas = New System.Windows.Forms.DataGridView()
        Me.TabPage2 = New System.Windows.Forms.TabPage()
        Me.SplitContainer2 = New System.Windows.Forms.SplitContainer()
        Me.ButtonEliminarProd = New System.Windows.Forms.Button()
        Me.ButtonEditProd = New System.Windows.Forms.Button()
        Me.ButtonCreateProd = New System.Windows.Forms.Button()
        Me.ButtonLimpiarProducto = New System.Windows.Forms.Button()
        Me.TextBoxCostoProducto = New System.Windows.Forms.TextBox()
        Me.Label10 = New System.Windows.Forms.Label()
        Me.TextBoxSerialProducto = New System.Windows.Forms.TextBox()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.TextBoxDescripcionProducto = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.TextBoxCodigoProducto = New System.Windows.Forms.TextBox()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TextBoxFiltroProducto = New System.Windows.Forms.TextBox()
        Me.DataGridViewProductos = New System.Windows.Forms.DataGridView()
        Me.TabPage3 = New System.Windows.Forms.TabPage()
        Me.ButtonRetirar = New System.Windows.Forms.Button()
        Me.ButtonIngresar = New System.Windows.Forms.Button()
        Me.TextBoxCodPro = New System.Windows.Forms.TextBox()
        Me.TextBoxCantidad = New System.Windows.Forms.TextBox()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.DataGridViewInventario = New System.Windows.Forms.DataGridView()
        Me.TextBoxBodegaContInv = New System.Windows.Forms.TextBox()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.TextBoxBodegaDirInv = New System.Windows.Forms.TextBox()
        Me.Label13 = New System.Windows.Forms.Label()
        Me.TextBoxNombreBodegaInv = New System.Windows.Forms.TextBox()
        Me.Label12 = New System.Windows.Forms.Label()
        Me.ComboBoxBodega = New System.Windows.Forms.ComboBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TabControl1.SuspendLayout()
        Me.TabPage1.SuspendLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        CType(Me.DataGridBodegas, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage2.SuspendLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer2.Panel1.SuspendLayout()
        Me.SplitContainer2.Panel2.SuspendLayout()
        Me.SplitContainer2.SuspendLayout()
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TabPage3.SuspendLayout()
        CType(Me.DataGridViewInventario, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TabControl1
        '
        Me.TabControl1.Controls.Add(Me.TabPage1)
        Me.TabControl1.Controls.Add(Me.TabPage2)
        Me.TabControl1.Controls.Add(Me.TabPage3)
        Me.TabControl1.Location = New System.Drawing.Point(2, 1)
        Me.TabControl1.Name = "TabControl1"
        Me.TabControl1.SelectedIndex = 0
        Me.TabControl1.Size = New System.Drawing.Size(932, 482)
        Me.TabControl1.TabIndex = 0
        '
        'TabPage1
        '
        Me.TabPage1.Controls.Add(Me.SplitContainer1)
        Me.TabPage1.Location = New System.Drawing.Point(4, 24)
        Me.TabPage1.Name = "TabPage1"
        Me.TabPage1.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage1.Size = New System.Drawing.Size(924, 454)
        Me.TabPage1.TabIndex = 0
        Me.TabPage1.Text = "Bodegas"
        Me.TabPage1.UseVisualStyleBackColor = True
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer1.Name = "SplitContainer1"
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonBorrarBodegas)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEliminarProducto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonEditarProducto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.ButtonCrearProducto)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxContactoBodega)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label5)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxDireccionBodega)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label4)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxNmbreBodega)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label3)
        Me.SplitContainer1.Panel1.Controls.Add(Me.TextBoxCodigoBodega)
        Me.SplitContainer1.Panel1.Controls.Add(Me.Label2)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.Controls.Add(Me.Label6)
        Me.SplitContainer1.Panel2.Controls.Add(Me.TextBoxFiltroBodegas)
        Me.SplitContainer1.Panel2.Controls.Add(Me.DataGridBodegas)
        Me.SplitContainer1.Size = New System.Drawing.Size(918, 448)
        Me.SplitContainer1.SplitterDistance = 304
        Me.SplitContainer1.TabIndex = 0
        '
        'ButtonBorrarBodegas
        '
        Me.ButtonBorrarBodegas.Location = New System.Drawing.Point(174, 30)
        Me.ButtonBorrarBodegas.Name = "ButtonBorrarBodegas"
        Me.ButtonBorrarBodegas.Size = New System.Drawing.Size(75, 23)
        Me.ButtonBorrarBodegas.TabIndex = 11
        Me.ButtonBorrarBodegas.Text = "Limpiar"
        Me.ButtonBorrarBodegas.UseVisualStyleBackColor = True
        '
        'ButtonEliminarProducto
        '
        Me.ButtonEliminarProducto.Location = New System.Drawing.Point(25, 408)
        Me.ButtonEliminarProducto.Name = "ButtonEliminarProducto"
        Me.ButtonEliminarProducto.Size = New System.Drawing.Size(175, 23)
        Me.ButtonEliminarProducto.TabIndex = 10
        Me.ButtonEliminarProducto.Text = "Eliminar"
        Me.ButtonEliminarProducto.UseVisualStyleBackColor = True
        '
        'ButtonEditarProducto
        '
        Me.ButtonEditarProducto.Location = New System.Drawing.Point(125, 366)
        Me.ButtonEditarProducto.Name = "ButtonEditarProducto"
        Me.ButtonEditarProducto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditarProducto.TabIndex = 9
        Me.ButtonEditarProducto.Text = "Editar"
        Me.ButtonEditarProducto.UseVisualStyleBackColor = True
        '
        'ButtonCrearProducto
        '
        Me.ButtonCrearProducto.Location = New System.Drawing.Point(25, 366)
        Me.ButtonCrearProducto.Name = "ButtonCrearProducto"
        Me.ButtonCrearProducto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCrearProducto.TabIndex = 8
        Me.ButtonCrearProducto.Text = "Crear"
        Me.ButtonCrearProducto.UseVisualStyleBackColor = True
        '
        'TextBoxContactoBodega
        '
        Me.TextBoxContactoBodega.Location = New System.Drawing.Point(25, 305)
        Me.TextBoxContactoBodega.Name = "TextBoxContactoBodega"
        Me.TextBoxContactoBodega.Size = New System.Drawing.Size(163, 23)
        Me.TextBoxContactoBodega.TabIndex = 7
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(25, 269)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(56, 15)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "Contacto"
        '
        'TextBoxDireccionBodega
        '
        Me.TextBoxDireccionBodega.Location = New System.Drawing.Point(25, 227)
        Me.TextBoxDireccionBodega.Name = "TextBoxDireccionBodega"
        Me.TextBoxDireccionBodega.Size = New System.Drawing.Size(163, 23)
        Me.TextBoxDireccionBodega.TabIndex = 5
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(25, 191)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(57, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Direccion"
        '
        'TextBoxNmbreBodega
        '
        Me.TextBoxNmbreBodega.Location = New System.Drawing.Point(25, 146)
        Me.TextBoxNmbreBodega.Name = "TextBoxNmbreBodega"
        Me.TextBoxNmbreBodega.Size = New System.Drawing.Size(163, 23)
        Me.TextBoxNmbreBodega.TabIndex = 3
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(25, 110)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Nombre"
        '
        'TextBoxCodigoBodega
        '
        Me.TextBoxCodigoBodega.Location = New System.Drawing.Point(25, 66)
        Me.TextBoxCodigoBodega.Name = "TextBoxCodigoBodega"
        Me.TextBoxCodigoBodega.Size = New System.Drawing.Size(163, 23)
        Me.TextBoxCodigoBodega.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(25, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 15)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "Codigo"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(22, 29)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(108, 15)
        Me.Label6.TabIndex = 2
        Me.Label6.Text = "Filtro de busqueda:"
        '
        'TextBoxFiltroBodegas
        '
        Me.TextBoxFiltroBodegas.Location = New System.Drawing.Point(136, 26)
        Me.TextBoxFiltroBodegas.Name = "TextBoxFiltroBodegas"
        Me.TextBoxFiltroBodegas.Size = New System.Drawing.Size(444, 23)
        Me.TextBoxFiltroBodegas.TabIndex = 1
        '
        'DataGridBodegas
        '
        Me.DataGridBodegas.AllowUserToAddRows = False
        Me.DataGridBodegas.AllowUserToDeleteRows = False
        Me.DataGridBodegas.AllowUserToResizeColumns = False
        Me.DataGridBodegas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells
        Me.DataGridBodegas.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells
        Me.DataGridBodegas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridBodegas.Location = New System.Drawing.Point(3, 66)
        Me.DataGridBodegas.Name = "DataGridBodegas"
        Me.DataGridBodegas.RowTemplate.Height = 25
        Me.DataGridBodegas.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridBodegas.Size = New System.Drawing.Size(600, 378)
        Me.DataGridBodegas.TabIndex = 0
        '
        'TabPage2
        '
        Me.TabPage2.Controls.Add(Me.SplitContainer2)
        Me.TabPage2.Location = New System.Drawing.Point(4, 24)
        Me.TabPage2.Name = "TabPage2"
        Me.TabPage2.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage2.Size = New System.Drawing.Size(924, 454)
        Me.TabPage2.TabIndex = 1
        Me.TabPage2.Text = "Productos"
        Me.TabPage2.UseVisualStyleBackColor = True
        '
        'SplitContainer2
        '
        Me.SplitContainer2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer2.Location = New System.Drawing.Point(3, 3)
        Me.SplitContainer2.Name = "SplitContainer2"
        '
        'SplitContainer2.Panel1
        '
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonEliminarProd)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonEditProd)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonCreateProd)
        Me.SplitContainer2.Panel1.Controls.Add(Me.ButtonLimpiarProducto)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBoxCostoProducto)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label10)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBoxSerialProducto)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label9)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBoxDescripcionProducto)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label8)
        Me.SplitContainer2.Panel1.Controls.Add(Me.TextBoxCodigoProducto)
        Me.SplitContainer2.Panel1.Controls.Add(Me.Label7)
        '
        'SplitContainer2.Panel2
        '
        Me.SplitContainer2.Panel2.Controls.Add(Me.Label11)
        Me.SplitContainer2.Panel2.Controls.Add(Me.TextBoxFiltroProducto)
        Me.SplitContainer2.Panel2.Controls.Add(Me.DataGridViewProductos)
        Me.SplitContainer2.Size = New System.Drawing.Size(918, 448)
        Me.SplitContainer2.SplitterDistance = 304
        Me.SplitContainer2.TabIndex = 0
        '
        'ButtonEliminarProd
        '
        Me.ButtonEliminarProd.Location = New System.Drawing.Point(97, 415)
        Me.ButtonEliminarProd.Name = "ButtonEliminarProd"
        Me.ButtonEliminarProd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEliminarProd.TabIndex = 11
        Me.ButtonEliminarProd.Text = "Eliminar"
        Me.ButtonEliminarProd.UseVisualStyleBackColor = True
        '
        'ButtonEditProd
        '
        Me.ButtonEditProd.Location = New System.Drawing.Point(163, 370)
        Me.ButtonEditProd.Name = "ButtonEditProd"
        Me.ButtonEditProd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonEditProd.TabIndex = 10
        Me.ButtonEditProd.Text = "Editar"
        Me.ButtonEditProd.UseVisualStyleBackColor = True
        '
        'ButtonCreateProd
        '
        Me.ButtonCreateProd.Location = New System.Drawing.Point(29, 370)
        Me.ButtonCreateProd.Name = "ButtonCreateProd"
        Me.ButtonCreateProd.Size = New System.Drawing.Size(75, 23)
        Me.ButtonCreateProd.TabIndex = 9
        Me.ButtonCreateProd.Text = "Crear"
        Me.ButtonCreateProd.UseVisualStyleBackColor = True
        '
        'ButtonLimpiarProducto
        '
        Me.ButtonLimpiarProducto.Location = New System.Drawing.Point(163, 47)
        Me.ButtonLimpiarProducto.Name = "ButtonLimpiarProducto"
        Me.ButtonLimpiarProducto.Size = New System.Drawing.Size(75, 23)
        Me.ButtonLimpiarProducto.TabIndex = 8
        Me.ButtonLimpiarProducto.Text = "Limpiar"
        Me.ButtonLimpiarProducto.UseVisualStyleBackColor = True
        '
        'TextBoxCostoProducto
        '
        Me.TextBoxCostoProducto.Location = New System.Drawing.Point(29, 329)
        Me.TextBoxCostoProducto.Name = "TextBoxCostoProducto"
        Me.TextBoxCostoProducto.Size = New System.Drawing.Size(185, 23)
        Me.TextBoxCostoProducto.TabIndex = 7
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(29, 294)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(38, 15)
        Me.Label10.TabIndex = 6
        Me.Label10.Text = "Costo"
        '
        'TextBoxSerialProducto
        '
        Me.TextBoxSerialProducto.Location = New System.Drawing.Point(29, 242)
        Me.TextBoxSerialProducto.Name = "TextBoxSerialProducto"
        Me.TextBoxSerialProducto.Size = New System.Drawing.Size(185, 23)
        Me.TextBoxSerialProducto.TabIndex = 5
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.Location = New System.Drawing.Point(29, 207)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(35, 15)
        Me.Label9.TabIndex = 4
        Me.Label9.Text = "Serial"
        '
        'TextBoxDescripcionProducto
        '
        Me.TextBoxDescripcionProducto.Location = New System.Drawing.Point(29, 166)
        Me.TextBoxDescripcionProducto.Name = "TextBoxDescripcionProducto"
        Me.TextBoxDescripcionProducto.Size = New System.Drawing.Size(185, 23)
        Me.TextBoxDescripcionProducto.TabIndex = 3
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Location = New System.Drawing.Point(29, 131)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(69, 15)
        Me.Label8.TabIndex = 2
        Me.Label8.Text = "Descripcion"
        '
        'TextBoxCodigoProducto
        '
        Me.TextBoxCodigoProducto.Location = New System.Drawing.Point(29, 87)
        Me.TextBoxCodigoProducto.Name = "TextBoxCodigoProducto"
        Me.TextBoxCodigoProducto.Size = New System.Drawing.Size(185, 23)
        Me.TextBoxCodigoProducto.TabIndex = 1
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.Location = New System.Drawing.Point(29, 52)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(46, 15)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Codigo"
        '
        'Label11
        '
        Me.Label11.AutoSize = True
        Me.Label11.Location = New System.Drawing.Point(48, 47)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(108, 15)
        Me.Label11.TabIndex = 2
        Me.Label11.Text = "Filtro de busqueda:"
        '
        'TextBoxFiltroProducto
        '
        Me.TextBoxFiltroProducto.Location = New System.Drawing.Point(177, 44)
        Me.TextBoxFiltroProducto.Name = "TextBoxFiltroProducto"
        Me.TextBoxFiltroProducto.Size = New System.Drawing.Size(414, 23)
        Me.TextBoxFiltroProducto.TabIndex = 1
        '
        'DataGridViewProductos
        '
        Me.DataGridViewProductos.AllowUserToAddRows = False
        Me.DataGridViewProductos.AllowUserToDeleteRows = False
        Me.DataGridViewProductos.AllowUserToResizeColumns = False
        Me.DataGridViewProductos.AllowUserToResizeRows = False
        Me.DataGridViewProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells
        Me.DataGridViewProductos.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewProductos.Location = New System.Drawing.Point(22, 84)
        Me.DataGridViewProductos.Name = "DataGridViewProductos"
        Me.DataGridViewProductos.RowTemplate.Height = 25
        Me.DataGridViewProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewProductos.Size = New System.Drawing.Size(581, 345)
        Me.DataGridViewProductos.TabIndex = 0
        '
        'TabPage3
        '
        Me.TabPage3.Controls.Add(Me.ButtonRetirar)
        Me.TabPage3.Controls.Add(Me.ButtonIngresar)
        Me.TabPage3.Controls.Add(Me.TextBoxCodPro)
        Me.TabPage3.Controls.Add(Me.TextBoxCantidad)
        Me.TabPage3.Controls.Add(Me.Label16)
        Me.TabPage3.Controls.Add(Me.Label15)
        Me.TabPage3.Controls.Add(Me.DataGridViewInventario)
        Me.TabPage3.Controls.Add(Me.TextBoxBodegaContInv)
        Me.TabPage3.Controls.Add(Me.Label14)
        Me.TabPage3.Controls.Add(Me.TextBoxBodegaDirInv)
        Me.TabPage3.Controls.Add(Me.Label13)
        Me.TabPage3.Controls.Add(Me.TextBoxNombreBodegaInv)
        Me.TabPage3.Controls.Add(Me.Label12)
        Me.TabPage3.Controls.Add(Me.ComboBoxBodega)
        Me.TabPage3.Controls.Add(Me.Label1)
        Me.TabPage3.Location = New System.Drawing.Point(4, 24)
        Me.TabPage3.Name = "TabPage3"
        Me.TabPage3.Padding = New System.Windows.Forms.Padding(3)
        Me.TabPage3.Size = New System.Drawing.Size(924, 454)
        Me.TabPage3.TabIndex = 2
        Me.TabPage3.Text = "Inventario"
        Me.TabPage3.UseVisualStyleBackColor = True
        '
        'ButtonRetirar
        '
        Me.ButtonRetirar.Location = New System.Drawing.Point(770, 302)
        Me.ButtonRetirar.Name = "ButtonRetirar"
        Me.ButtonRetirar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonRetirar.TabIndex = 15
        Me.ButtonRetirar.Text = "Salida"
        Me.ButtonRetirar.UseVisualStyleBackColor = True
        '
        'ButtonIngresar
        '
        Me.ButtonIngresar.Location = New System.Drawing.Point(644, 302)
        Me.ButtonIngresar.Name = "ButtonIngresar"
        Me.ButtonIngresar.Size = New System.Drawing.Size(75, 23)
        Me.ButtonIngresar.TabIndex = 14
        Me.ButtonIngresar.Text = "Entrada"
        Me.ButtonIngresar.UseVisualStyleBackColor = True
        '
        'TextBoxCodPro
        '
        Me.TextBoxCodPro.Location = New System.Drawing.Point(691, 147)
        Me.TextBoxCodPro.Name = "TextBoxCodPro"
        Me.TextBoxCodPro.Size = New System.Drawing.Size(144, 23)
        Me.TextBoxCodPro.TabIndex = 13
        '
        'TextBoxCantidad
        '
        Me.TextBoxCantidad.Location = New System.Drawing.Point(695, 219)
        Me.TextBoxCantidad.Name = "TextBoxCantidad"
        Me.TextBoxCantidad.Size = New System.Drawing.Size(144, 23)
        Me.TextBoxCantidad.TabIndex = 12
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Location = New System.Drawing.Point(634, 222)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(55, 15)
        Me.Label16.TabIndex = 11
        Me.Label16.Text = "Cantidad"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Location = New System.Drawing.Point(634, 150)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(56, 15)
        Me.Label15.TabIndex = 9
        Me.Label15.Text = "Producto"
        '
        'DataGridViewInventario
        '
        Me.DataGridViewInventario.AllowUserToAddRows = False
        Me.DataGridViewInventario.AllowUserToDeleteRows = False
        Me.DataGridViewInventario.AllowUserToResizeColumns = False
        Me.DataGridViewInventario.AllowUserToResizeRows = False
        Me.DataGridViewInventario.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DataGridViewInventario.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells
        Me.DataGridViewInventario.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridViewInventario.Location = New System.Drawing.Point(36, 121)
        Me.DataGridViewInventario.Name = "DataGridViewInventario"
        Me.DataGridViewInventario.RowTemplate.Height = 25
        Me.DataGridViewInventario.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
        Me.DataGridViewInventario.Size = New System.Drawing.Size(562, 316)
        Me.DataGridViewInventario.TabIndex = 8
        '
        'TextBoxBodegaContInv
        '
        Me.TextBoxBodegaContInv.Location = New System.Drawing.Point(701, 35)
        Me.TextBoxBodegaContInv.Name = "TextBoxBodegaContInv"
        Me.TextBoxBodegaContInv.Size = New System.Drawing.Size(144, 23)
        Me.TextBoxBodegaContInv.TabIndex = 7
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Location = New System.Drawing.Point(644, 39)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(56, 15)
        Me.Label14.TabIndex = 6
        Me.Label14.Text = "Contacto"
        '
        'TextBoxBodegaDirInv
        '
        Me.TextBoxBodegaDirInv.Location = New System.Drawing.Point(474, 36)
        Me.TextBoxBodegaDirInv.Name = "TextBoxBodegaDirInv"
        Me.TextBoxBodegaDirInv.Size = New System.Drawing.Size(144, 23)
        Me.TextBoxBodegaDirInv.TabIndex = 5
        '
        'Label13
        '
        Me.Label13.AutoSize = True
        Me.Label13.Location = New System.Drawing.Point(417, 40)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(57, 15)
        Me.Label13.TabIndex = 4
        Me.Label13.Text = "Direccion"
        '
        'TextBoxNombreBodegaInv
        '
        Me.TextBoxNombreBodegaInv.Location = New System.Drawing.Point(254, 37)
        Me.TextBoxNombreBodegaInv.Name = "TextBoxNombreBodegaInv"
        Me.TextBoxNombreBodegaInv.Size = New System.Drawing.Size(144, 23)
        Me.TextBoxNombreBodegaInv.TabIndex = 3
        '
        'Label12
        '
        Me.Label12.AutoSize = True
        Me.Label12.Location = New System.Drawing.Point(197, 41)
        Me.Label12.Name = "Label12"
        Me.Label12.Size = New System.Drawing.Size(51, 15)
        Me.Label12.TabIndex = 2
        Me.Label12.Text = "Nombre"
        '
        'ComboBoxBodega
        '
        Me.ComboBoxBodega.FormattingEnabled = True
        Me.ComboBoxBodega.Location = New System.Drawing.Point(89, 37)
        Me.ComboBoxBodega.Name = "ComboBoxBodega"
        Me.ComboBoxBodega.Size = New System.Drawing.Size(94, 23)
        Me.ComboBoxBodega.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(36, 40)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(47, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Bodega"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ScrollBar
        Me.ClientSize = New System.Drawing.Size(932, 484)
        Me.Controls.Add(Me.TabControl1)
        Me.Name = "Form1"
        Me.Text = "Gestion de inventarios"
        Me.TabControl1.ResumeLayout(False)
        Me.TabPage1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        Me.SplitContainer1.Panel2.PerformLayout()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        CType(Me.DataGridBodegas, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage2.ResumeLayout(False)
        Me.SplitContainer2.Panel1.ResumeLayout(False)
        Me.SplitContainer2.Panel1.PerformLayout()
        Me.SplitContainer2.Panel2.ResumeLayout(False)
        Me.SplitContainer2.Panel2.PerformLayout()
        CType(Me.SplitContainer2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer2.ResumeLayout(False)
        CType(Me.DataGridViewProductos, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TabPage3.ResumeLayout(False)
        Me.TabPage3.PerformLayout()
        CType(Me.DataGridViewInventario, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TabControl1 As TabControl
    Friend WithEvents TabPage1 As TabPage
    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TabPage2 As TabPage
    Friend WithEvents SplitContainer2 As SplitContainer
    Friend WithEvents TextBoxContactoBodega As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents TextBoxDireccionBodega As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents TextBoxNmbreBodega As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBoxCodigoBodega As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonEliminarProducto As Button
    Friend WithEvents ButtonEditarProducto As Button
    Friend WithEvents ButtonCrearProducto As Button
    Friend WithEvents DataGridBodegas As DataGridView
    Friend WithEvents Label6 As Label
    Friend WithEvents TextBoxFiltroBodegas As TextBox
    Friend WithEvents ButtonBorrarBodegas As Button
    Friend WithEvents TextBoxSerialProducto As TextBox
    Friend WithEvents Label9 As Label
    Friend WithEvents TextBoxDescripcionProducto As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents TextBoxCodigoProducto As TextBox
    Friend WithEvents Label7 As Label
    Friend WithEvents TextBoxFiltroProducto As TextBox
    Friend WithEvents DataGridViewProductos As DataGridView
    Friend WithEvents ButtonEliminarProd As Button
    Friend WithEvents ButtonEditProd As Button
    Friend WithEvents ButtonCreateProd As Button
    Friend WithEvents ButtonLimpiarProducto As Button
    Friend WithEvents TextBoxCostoProducto As TextBox
    Friend WithEvents Label10 As Label
    Friend WithEvents Label11 As Label
    Friend WithEvents TabPage3 As TabPage
    Friend WithEvents ComboBoxBodega As ComboBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxNombreBodegaInv As TextBox
    Friend WithEvents Label12 As Label
    Friend WithEvents TextBoxBodegaContInv As TextBox
    Friend WithEvents Label14 As Label
    Friend WithEvents TextBoxBodegaDirInv As TextBox
    Friend WithEvents Label13 As Label
    Friend WithEvents DataGridViewInventario As DataGridView
    Friend WithEvents ButtonRetirar As Button
    Friend WithEvents ButtonIngresar As Button
    Friend WithEvents TextBoxCodPro As TextBox
    Friend WithEvents TextBoxCantidad As TextBox
    Friend WithEvents Label16 As Label
    Friend WithEvents Label15 As Label
End Class
