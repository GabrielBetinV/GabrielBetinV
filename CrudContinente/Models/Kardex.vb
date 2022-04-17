Imports System.Data.SqlClient

Public Class Kardex

    Dim movimiento As String
    Dim id_bodega As Integer
    Dim id_producto As Integer
    Dim cantidad As Integer

    Public Sub New(movimiento As String, id_bodega As Integer, id_producto As Integer, cantidad As Integer)
        Me.movimiento = movimiento
        Me.id_bodega = id_bodega
        Me.id_producto = id_producto
        Me.cantidad = cantidad
    End Sub

    Public Sub New()
    End Sub




    Function mostrarInd(busq As String)

        'Creamos un objeto  datatable'

        Dim dt As New DataTable

        'Creamos un objeto SqlDataAdapter'

        Dim da As SqlDataAdapter


        Try

            Abrir_Conexion()

            'Guardamos la informacion en el objeto SqlDataAdapter'
            da = New SqlDataAdapter("READ_KARDEX_BODEGA", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", busq)


            'Guardamos el objeto  da en el datatable para luego llenar la tabla del formulario'
            da.Fill(dt)

            Return dt


            Cerrar_Conexion()

        Catch ex As Exception


        End Try



    End Function




    'Metdodo Crear
    Public Sub create_kardex()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("CREATE_KARDEX", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@tipo", movimiento)
            cmd.Parameters.AddWithValue("@id_bodega", id_bodega)
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try


    End Sub



    Function buscarIdBodega(busq As String)

        'Creamos una variablepara recibir la respuesta'

        Dim respuesta As SqlDataReader

        'Creamos una variable para realizar la consulta'

        Dim consulta As SqlCommand



        Try

            Abrir_Conexion()

            'Guardamos la informacion en una variable'
            consulta = New SqlCommand("READ_BODEGA_ID", conexion)
            consulta.CommandType = 4
            consulta.Parameters.AddWithValue("@Busqueda", busq)
            respuesta = consulta.ExecuteReader

            Dim datos As Integer
            While respuesta.Read
                datos = respuesta.Item("id")
            End While

            Return datos

            Cerrar_Conexion()

        Catch ex As Exception


        End Try

    End Function

    Function buscarIdProducto(busq As String)

        'Creamos una variablepara recibir la respuesta'

        Dim respuesta As SqlDataReader

        'Creamos una variable para realizar la consulta'

        Dim consulta As SqlCommand



        Try

            Abrir_Conexion()

            'Guardamos la informacion en una variable'
            consulta = New SqlCommand("READ_PRODUCTO_ID", conexion)
            consulta.CommandType = 4
            consulta.Parameters.AddWithValue("@Busqueda", busq)
            respuesta = consulta.ExecuteReader

            Dim datos As Integer
            While respuesta.Read
                datos = respuesta.Item("id")
            End While

            Return datos

            Cerrar_Conexion()

        Catch ex As Exception


        End Try

    End Function





    Function buscarIdkardex(bod As String, pro As String)

        'Creamos una variablepara recibir la respuesta'

        Dim respuesta As SqlDataReader

        'Creamos una variable para realizar la consulta'

        Dim consulta As SqlCommand



        Try

            Abrir_Conexion()

            'Guardamos la informacion en una variable'
            consulta = New SqlCommand("READ_BODEGA_PRODUCTO", conexion)
            consulta.CommandType = 4
            consulta.Parameters.AddWithValue("@Bodega", bod)
            consulta.Parameters.AddWithValue("@Producto", pro)
            respuesta = consulta.ExecuteReader

            Dim datos As Integer
            While respuesta.Read
                datos = respuesta.Item("id")
            End While

            Return datos

            Cerrar_Conexion()

        Catch ex As Exception


        End Try

    End Function


    Public Sub edit_kardex()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("EDIT_KARDEX", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@tipo", movimiento)
            cmd.Parameters.AddWithValue("@id_bodega", id_bodega)
            cmd.Parameters.AddWithValue("@id_producto", id_producto)
            cmd.Parameters.AddWithValue("@cantidad", cantidad)
            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try


    End Sub



    Function buscarCantkardex(id As String)

        'Creamos una variablepara recibir la respuesta'

        Dim respuesta As SqlDataReader

        'Creamos una variable para realizar la consulta'

        Dim consulta As SqlCommand



        Try

            Abrir_Conexion()

            'Guardamos la informacion en una variable'
            consulta = New SqlCommand("READ_KARDEX_ID_CANTIDAD", conexion)
            consulta.CommandType = 4
            consulta.Parameters.AddWithValue("@Busqueda", id)

            respuesta = consulta.ExecuteReader

            Dim datos As Integer
            While respuesta.Read
                datos = respuesta.Item("Cantidad")
            End While

            Return datos

            Cerrar_Conexion()

        Catch ex As Exception


        End Try

    End Function

End Class
