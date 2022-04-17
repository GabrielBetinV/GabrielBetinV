Imports System.Data.SqlClient


Public Class Producto


    'variables'


    Dim codigo As String
    Dim costo As String
    Dim descripcion As String
    Dim serial As String
    Dim fechaCreacion As Date

    'constructor con parametros'

    Public Sub New(codigo As String, costo As String, descripcion As String, serial As String, fechaCreacion As Date)
        Me.codigo = codigo
        Me.costo = costo
        Me.descripcion = descripcion
        Me.serial = serial
        Me.fechaCreacion = fechaCreacion
    End Sub

    'Constructor vacio'

    Public Sub New()
    End Sub



    'Metdodo Crear
    Public Sub create_producto()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("CREATE_PRODUCTO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Parameters.AddWithValue("@costo", costo)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)
            cmd.Parameters.AddWithValue("@serial", serial)
            cmd.Parameters.AddWithValue("@fechaCreacion", fechaCreacion)
            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try


    End Sub




    'Funcion Mostrar'

    Function mostrar()

        'Creamos un objeto  datatable'

        Dim dt As New DataTable

        'Creamos un objeto SqlDataAdapter'

        Dim da As SqlDataAdapter


        Try

            Abrir_Conexion()

            'Guardamos la informacion en el objeto SqlDataAdapter'
            da = New SqlDataAdapter("READ_PRODUCTO", conexion)


            'Guardamos el objeto  da en el datatable para luego llenar la tabla del formulario'
            da.Fill(dt)

            Return dt


            Cerrar_Conexion()

        Catch ex As Exception


        End Try

    End Function




    'Mostrar por codigo o nombre'


    Function mostrarInd(busq As String)

        'Creamos un objeto  datatable'

        Dim dt As New DataTable

        'Creamos un objeto SqlDataAdapter'

        Dim da As SqlDataAdapter


        Try

            Abrir_Conexion()

            'Guardamos la informacion en el objeto SqlDataAdapter'
            da = New SqlDataAdapter("READ_PRODUCTO_CODIGO", conexion)
            da.SelectCommand.CommandType = 4
            da.SelectCommand.Parameters.AddWithValue("@Busqueda", busq)


            'Guardamos el objeto  da en el datatable para luego llenar la tabla del formulario'
            da.Fill(dt)

            Return dt


            Cerrar_Conexion()

        Catch ex As Exception


        End Try



    End Function



    'Actualizar datos'


    Public Sub edit_producto()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("EDIT_PRODUCTO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Parameters.AddWithValue("@costo", costo)
            cmd.Parameters.AddWithValue("@descripcion", descripcion)
            cmd.Parameters.AddWithValue("@serial", serial)
            cmd.Parameters.AddWithValue("@fechaCreacion", fechaCreacion)
            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try


    End Sub




    'Eliminar registros

    Public Sub delete_producto()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("DELETE_PRODUCTO", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo", codigo)

            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try


    End Sub '





    'Mostrar por codigo o nombre en el combobox'


    Sub comboBoxProducto(ByVal cb As ComboBox)

        'Creamos una variablepara recibir la respuesta'

        Dim respuesta As SqlDataReader

        'Creamos una variable para realizar la consulta'

        Dim consulta As SqlCommand



        Try

            Abrir_Conexion()

            'Guardamos la informacion en una variable'
            consulta = New SqlCommand("READ_PRODUCTO_NAME", conexion)
            respuesta = consulta.ExecuteReader

            While respuesta.Read
                cb.Items.Add(respuesta.Item("Codigo"))
            End While

            Cerrar_Conexion()

        Catch ex As Exception


        End Try

    End Sub

End Class
