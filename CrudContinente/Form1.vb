Imports System.Data.SqlClient


Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        Dim tBodegas = New Bodega()
        DataGridBodegas.DataSource = tBodegas.mostrar()
        tBodegas.comboBoxBodega(ComboBoxBodega)


        Dim tProductos = New Producto()
        DataGridViewProductos.DataSource = tProductos.mostrar()





    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBodegas.CellContentClick




    End Sub

    Private Sub TextBoxDireccionBodega_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub ButtonBuscarProducto_Click(sender As Object, e As EventArgs)


        If TextBoxCodigoBodega.Text <> "" And TextBoxNmbreBodega.Text = "" And TextBoxDireccionBodega.Text = "" And TextBoxContactoBodega.Text = "" Then


            Dim tBodegas = New Bodega()
            DataGridBodegas.DataSource = tBodegas.mostrarInd(TextBoxCodigoBodega.Text.ToString)




        ElseIf TextBoxCodigoBodega.Text = "" And TextBoxNmbreBodega.Text <> "" And TextBoxDireccionBodega.Text = "" And TextBoxContactoBodega.Text = "" Then

            Dim tBodegas = New Bodega()
            DataGridBodegas.DataSource = tBodegas.mostrarInd(TextBoxNmbreBodega.Text.ToString)

        Else
            MsgBox("Debe llenar todos los campos")

        End If



    End Sub

    Private Sub ButtonCrearProducto_Click(sender As Object, e As EventArgs) Handles ButtonCrearProducto.Click


        If TextBoxCodigoBodega.Text <> "" And TextBoxNmbreBodega.Text <> "" And TextBoxDireccionBodega.Text <> "" And TextBoxContactoBodega.Text <> "" Then

            Dim nBodega As Bodega
            Dim fecha As Date

            fecha = Date.Now

            nBodega = New Bodega(TextBoxCodigoBodega.Text.ToString, TextBoxNmbreBodega.Text.ToString, TextBoxDireccionBodega.Text.ToString, TextBoxContactoBodega.Text.ToString, fecha)
            nBodega.create_bodega()
            MsgBox("Bodega creada")
            Dim tBodegas = New Bodega()
            DataGridBodegas.DataSource = tBodegas.mostrar()





            TextBoxCodigoBodega.Text = ""
            TextBoxNmbreBodega.Text = ""
            TextBoxDireccionBodega.Text = ""
            TextBoxContactoBodega.Text = ""
            ButtonCrearProducto.Enabled = True


        Else

            MsgBox("Debe llenar todos los campos")


        End If


    End Sub

    Private Sub Form1_Click(sender As Object, e As EventArgs) Handles Me.Click

    End Sub

    Private Sub TabPage1_Click(sender As Object, e As EventArgs) Handles TabPage1.Click

    End Sub

    Private Sub TabPage1_DpiChangedAfterParent(sender As Object, e As EventArgs) Handles TabPage1.DpiChangedAfterParent

    End Sub

    Private Sub TextBoxFiltroBodegas_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFiltroBodegas.TextChanged


        Dim tBodegas = New Bodega()
        DataGridBodegas.DataSource = tBodegas.mostrarInd(TextBoxFiltroBodegas.Text.ToString)



    End Sub

    Private Sub DataGridBodegas_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridBodegas.CellContentDoubleClick


        Try

            TextBoxCodigoBodega.Text = DataGridBodegas.SelectedCells.Item(0).Value
            TextBoxNmbreBodega.Text = DataGridBodegas.SelectedCells.Item(1).Value
            TextBoxDireccionBodega.Text = DataGridBodegas.SelectedCells.Item(2).Value
            TextBoxContactoBodega.Text = DataGridBodegas.SelectedCells.Item(3).Value
            ButtonCrearProducto.Enabled = False

        Catch ex As Exception

        End Try



    End Sub

    Private Sub ButtonBorrarBodegas_Click(sender As Object, e As EventArgs) Handles ButtonBorrarBodegas.Click

        TextBoxCodigoBodega.Text = ""
        TextBoxNmbreBodega.Text = ""
        TextBoxDireccionBodega.Text = ""
        TextBoxContactoBodega.Text = ""
        ButtonCrearProducto.Enabled = True

    End Sub

    Private Sub ButtonEditarProducto_Click(sender As Object, e As EventArgs) Handles ButtonEditarProducto.Click


        If TextBoxCodigoBodega.Text <> "" And TextBoxNmbreBodega.Text <> "" And TextBoxDireccionBodega.Text <> "" And TextBoxContactoBodega.Text <> "" Then

            Dim nBodega As Bodega
            Dim fecha As Date

            fecha = Date.Now

            nBodega = New Bodega(TextBoxCodigoBodega.Text.ToString, TextBoxNmbreBodega.Text.ToString, TextBoxDireccionBodega.Text.ToString, TextBoxContactoBodega.Text.ToString, fecha)
            nBodega.edit_bodega()
            MsgBox("Bodega editada")
            Dim tBodegas = New Bodega()
            DataGridBodegas.DataSource = tBodegas.mostrar()

            TextBoxCodigoBodega.Text = ""
            TextBoxNmbreBodega.Text = ""
            TextBoxDireccionBodega.Text = ""
            TextBoxContactoBodega.Text = ""
            ButtonCrearProducto.Enabled = True


        Else

            MsgBox("Debe llenar todos los campos")


        End If




    End Sub

    Private Sub ButtonEliminarProducto_Click(sender As Object, e As EventArgs) Handles ButtonEliminarProducto.Click

        If TextBoxCodigoBodega.Text <> "" And TextBoxNmbreBodega.Text <> "" And TextBoxDireccionBodega.Text <> "" And TextBoxContactoBodega.Text <> "" Then

            Dim nBodega As Bodega
            Dim fecha As Date

            fecha = Date.Now

            nBodega = New Bodega(TextBoxCodigoBodega.Text.ToString, TextBoxNmbreBodega.Text.ToString, TextBoxDireccionBodega.Text.ToString, TextBoxContactoBodega.Text.ToString, fecha)
            nBodega.delete_bodega()
            MsgBox("Bodega eliminada")
            Dim tBodegas = New Bodega()
            DataGridBodegas.DataSource = tBodegas.mostrar()

            TextBoxCodigoBodega.Text = ""
            TextBoxNmbreBodega.Text = ""
            TextBoxDireccionBodega.Text = ""
            TextBoxContactoBodega.Text = ""
            ButtonCrearProducto.Enabled = True


        Else

            MsgBox("Debe llenar todos los campos")


        End If


    End Sub

    Private Sub ButtonCreateProd_Click(sender As Object, e As EventArgs) Handles ButtonCreateProd.Click



        If TextBoxCodigoProducto.Text <> "" And TextBoxDescripcionProducto.Text <> "" And TextBoxSerialProducto.Text <> "" And TextBoxCostoProducto.Text <> "" Then

            Dim nProduto As Producto
            Dim fecha As Date

            fecha = Date.Now

            nProduto = New Producto(TextBoxCodigoProducto.Text.ToString, TextBoxCostoProducto.Text.ToString, TextBoxDescripcionProducto.Text.ToString, TextBoxSerialProducto.Text.ToString, fecha)
            nProduto.create_producto()
            MsgBox("Producto Creado")
            Dim tProductos = New Producto()
            DataGridViewProductos.DataSource = tProductos.mostrar()

            TextBoxCodigoProducto.Text = ""
            TextBoxDescripcionProducto.Text = ""
            TextBoxSerialProducto.Text = ""
            TextBoxCostoProducto.Text = ""
            ButtonCreateProd.Enabled = True


        Else

            MsgBox("Debe llenar todos los campos")


        End If


    End Sub

    Private Sub TextBoxFiltroProducto_TextChanged(sender As Object, e As EventArgs) Handles TextBoxFiltroProducto.TextChanged



        Dim tProductos = New Producto()
        DataGridViewProductos.DataSource = tProductos.mostrarInd(TextBoxFiltroProducto.Text.ToString)



    End Sub

    Private Sub DataGridViewProductos_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductos.CellContentClick

    End Sub

    Private Sub DataGridViewProductos_CellContentDoubleClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewProductos.CellContentDoubleClick



        Try

            TextBoxCodigoProducto.Text = DataGridViewProductos.SelectedCells.Item(0).Value
            TextBoxDescripcionProducto.Text = DataGridViewProductos.SelectedCells.Item(2).Value
            TextBoxSerialProducto.Text = DataGridViewProductos.SelectedCells.Item(3).Value
            TextBoxCostoProducto.Text = DataGridViewProductos.SelectedCells.Item(1).Value
            ButtonCreateProd.Enabled = False

        Catch ex As Exception

        End Try



    End Sub

    Private Sub ButtonLimpiarProducto_Click(sender As Object, e As EventArgs) Handles ButtonLimpiarProducto.Click
        TextBoxCodigoProducto.Text = ""
        TextBoxDescripcionProducto.Text = ""
        TextBoxSerialProducto.Text = ""
        TextBoxCostoProducto.Text = ""
        ButtonCreateProd.Enabled = True
    End Sub

    Private Sub ButtonEditProd_Click(sender As Object, e As EventArgs) Handles ButtonEditProd.Click



        If TextBoxCodigoProducto.Text <> "" And TextBoxDescripcionProducto.Text <> "" And TextBoxSerialProducto.Text <> "" And TextBoxCostoProducto.Text <> "" Then

            Dim nProduto As Producto
            Dim fecha As Date

            fecha = Date.Now

            nProduto = New Producto(TextBoxCodigoProducto.Text.ToString, TextBoxCostoProducto.Text.ToString, TextBoxDescripcionProducto.Text.ToString, TextBoxSerialProducto.Text.ToString, fecha)
            nProduto.edit_producto()
            MsgBox("Producto Editado")
            Dim tProductos = New Producto()
            DataGridViewProductos.DataSource = tProductos.mostrar()

            TextBoxCodigoProducto.Text = ""
            TextBoxDescripcionProducto.Text = ""
            TextBoxSerialProducto.Text = ""
            TextBoxCostoProducto.Text = ""
            ButtonCreateProd.Enabled = True


        Else

            MsgBox("Debe llenar todos los campos")


        End If



    End Sub

    Private Sub ButtonEliminarProd_Click(sender As Object, e As EventArgs) Handles ButtonEliminarProd.Click



        If TextBoxCodigoProducto.Text <> "" And TextBoxDescripcionProducto.Text <> "" And TextBoxSerialProducto.Text <> "" And TextBoxCostoProducto.Text <> "" Then

            Dim nProduto As Producto
            Dim fecha As Date

            fecha = Date.Now

            nProduto = New Producto(TextBoxCodigoProducto.Text.ToString, TextBoxCostoProducto.Text.ToString, TextBoxDescripcionProducto.Text.ToString, TextBoxSerialProducto.Text.ToString, fecha)
            nProduto.delete_producto()
            MsgBox("Producto Eliminado")
            Dim tProductos = New Producto()
            DataGridViewProductos.DataSource = tProductos.mostrar()

            TextBoxCodigoProducto.Text = ""
            TextBoxDescripcionProducto.Text = ""
            TextBoxSerialProducto.Text = ""
            TextBoxCostoProducto.Text = ""
            ButtonCreateProd.Enabled = True


        Else

            MsgBox("Debe llenar todos los campos")


        End If



    End Sub

    Private Sub TabPage3_Click(sender As Object, e As EventArgs) Handles TabPage3.Click






    End Sub

    Private Sub Label1_Click_1(sender As Object, e As EventArgs)

    End Sub

    Private Sub Label16_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged_1(sender As Object, e As EventArgs) Handles TextBoxNombreBodegaInv.TextChanged

    End Sub

    Private Sub ComboBoxBodega_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBoxBodega.SelectedIndexChanged


        Dim tBodegas = New Bodega()
        Dim infoBodega As String
        infoBodega = tBodegas.datosBodega(ComboBoxBodega.Text.ToString)
        Dim cadena As String() = infoBodega.Split(",")
        TextBoxNombreBodegaInv.Text = cadena(1)
        TextBoxBodegaDirInv.Text = cadena(2)
        TextBoxBodegaContInv.Text = cadena(3)

        Dim tKardex = New Kardex()
        DataGridViewInventario.DataSource = tKardex.mostrarInd(ComboBoxBodega.Text.ToString)


    End Sub

    Private Sub ComboBoxBodega_Click(sender As Object, e As EventArgs) Handles ComboBoxBodega.Click

    End Sub

    Private Sub Form1_AutoSizeChanged(sender As Object, e As EventArgs) Handles Me.AutoSizeChanged




    End Sub

    Private Sub DataGridViewInventario_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridViewInventario.CellContentClick

    End Sub

    Private Sub ButtonIngresar_Click(sender As Object, e As EventArgs) Handles ButtonIngresar.Click


        If ComboBoxBodega.Text <> "" And TextBoxCodPro.Text <> "" Then

            Dim nueKardex = New Kardex()
            Dim idBodega As Integer
            Dim idProducto As Integer
            idBodega = nueKardex.buscarIdBodega(ComboBoxBodega.Text)
            idProducto = nueKardex.buscarIdProducto(TextBoxCodPro.Text.ToString)


            Dim idkardex As Integer

            idkardex = nueKardex.buscarIdkardex(idBodega, idProducto)



            If idkardex = 0 Then


                Dim nKardex = New Kardex("Entrada", idBodega, idProducto, Convert.ToInt16(TextBoxCantidad.Text.ToString))
                nKardex.create_kardex()
                MsgBox("Entrada realizada")
                Dim tKardex = New Kardex()
                DataGridViewInventario.DataSource = tKardex.mostrarInd(ComboBoxBodega.Text.ToString)




            Else

                Dim nuevaKardex = New Kardex()
                Dim existencia As Integer
                existencia = nuevaKardex.buscarCantkardex(idkardex)
                Dim nuevaExistencia As Integer
                nuevaExistencia = existencia + Convert.ToInt16(TextBoxCantidad.Text.ToString)



                Dim nKardex = New Kardex("Entrada", idBodega, idProducto, nuevaExistencia)
                nKardex.edit_kardex()
                MsgBox("Cantidad Modificada")
                Dim tKardex = New Kardex()
                DataGridViewInventario.DataSource = tKardex.mostrarInd(ComboBoxBodega.Text.ToString)


            End If






        Else

            MsgBox("Debe llenar todos los campos")


        End If




    End Sub

    Private Sub ButtonRetirar_Click(sender As Object, e As EventArgs) Handles ButtonRetirar.Click



        If ComboBoxBodega.Text <> "" And TextBoxCodPro.Text <> "" Then

            Dim nueKardex = New Kardex()
            Dim idBodega As Integer
            Dim idProducto As Integer
            idBodega = nueKardex.buscarIdBodega(ComboBoxBodega.Text)
            idProducto = nueKardex.buscarIdProducto(TextBoxCodPro.Text.ToString)


            Dim idkardex As Integer

            idkardex = nueKardex.buscarIdkardex(idBodega, idProducto)



            If idkardex = 0 Then


                MsgBox("No hay Existencia de este producto en la bodega" + ComboBoxBodega.Text)



            Else

                Dim nuevaKardex = New Kardex()
                Dim existencia As Integer
                existencia = nuevaKardex.buscarCantkardex(idkardex)
                Dim nuevaExistencia As Integer
                nuevaExistencia = existencia - Convert.ToInt16(TextBoxCantidad.Text.ToString)



                Dim nKardex = New Kardex("Entrada", idBodega, idProducto, nuevaExistencia)
                nKardex.edit_kardex()
                MsgBox("Cantidad Modificada")
                Dim tKardex = New Kardex()
                DataGridViewInventario.DataSource = tKardex.mostrarInd(ComboBoxBodega.Text.ToString)


            End If






        Else

            MsgBox("Debe llenar todos los campos")


        End If




    End Sub


End Class
