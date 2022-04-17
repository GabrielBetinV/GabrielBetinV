Imports System.Data.SqlClient

Public Class Bodega


    'Variables

    Dim codigo As String
    Dim nombre As String
    Dim direccion As String
    Dim contacto As String
    Dim fechaCreacion As Date

    'Constructor
    Public Sub New(codigo As String, nombre As String, direccion As String, contacto As String, fechaCreacion As Date)
        Me.codigo = codigo
        Me.nombre = nombre
        Me.direccion = direccion
        Me.contacto = contacto
        Me.fechaCreacion = fechaCreacion
    End Sub

    Public Sub New()
    End Sub






    'Metdodo Crear
    Public Sub create_bodega()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("CREATE_BODEGA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@contacto", contacto)
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
            da = New SqlDataAdapter("READ_BODEGA", conexion)


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
            da = New SqlDataAdapter("READ_BODEGA_NOMBRE", conexion)
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


    Public Sub edit_bodega()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("EDIT_BODEGA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo", codigo)
            cmd.Parameters.AddWithValue("@nombre", nombre)
            cmd.Parameters.AddWithValue("@direccion", direccion)
            cmd.Parameters.AddWithValue("@contacto", contacto)
            cmd.Parameters.AddWithValue("@fechaCreacion", fechaCreacion)
            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try


    End Sub




    'Eliminar registros

    Public Sub delete_bodega()

        Dim cmd As New SqlCommand


        Try

            Abrir_Conexion()
            cmd = New SqlCommand("DELETE_BODEGA", conexion)
            cmd.CommandType = 4
            cmd.Parameters.AddWithValue("@codigo", codigo)

            cmd.ExecuteNonQuery()
            Cerrar_Conexion()

        Catch ex As Exception


        End Try


    End Sub '




    'Mostrar por codigo o nombre en el combobox'


    Sub comboBoxBodega(ByVal cb As ComboBox)

        'Creamos una variablepara recibir la respuesta'

        Dim respuesta As SqlDataReader

        'Creamos una variable para realizar la consulta'

        Dim consulta As SqlCommand



        Try

            Abrir_Conexion()

            'Guardamos la informacion en una variable'
            consulta = New SqlCommand("READ_BODEGA_NAME", conexion)
            respuesta = consulta.ExecuteReader

            While respuesta.Read
                cb.Items.Add(respuesta.Item("Codigo"))
            End While

            Cerrar_Conexion()

        Catch ex As Exception


        End Try

    End Sub



    'Metodo que devuelve un string con la informacion de la bodega'

    Function datosBodega(busq As String)


        'Creamos una variablepara recibir la respuesta'

        Dim respuesta As SqlDataReader

        'Creamos una variable para realizar la consulta'

        Dim consulta As SqlCommand


        Try

            Abrir_Conexion()

            'Guardamos la informacion en una variable'
            consulta = New SqlCommand("READ_BODEGA_NOMBRE", conexion)
            consulta.CommandType = 4
            consulta.Parameters.AddWithValue("@Busqueda", busq)
            respuesta = consulta.ExecuteReader

            Dim datos As String
            While respuesta.Read
                datos = respuesta.Item("Codigo") + "," + respuesta.Item("Nombre") + "," + respuesta.Item("Direccion") +
                "," + respuesta.Item("Contacto") + "," + respuesta.Item("Fecha de creacion")

            End While

            Return datos


            Cerrar_Conexion()

        Catch ex As Exception


        End Try



    End Function


End Class
