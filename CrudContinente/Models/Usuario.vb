Imports System.Data.SqlClient


Public Class Usuario



    Dim usuarios As String
    Dim contraseña As String

    Public Sub New()
    End Sub



    'Buscar Usuario'


    Function datosEmpleado(busq As String)


        'Creamos una variablepara recibir la respuesta'

        Dim respuesta As SqlDataReader

        'Creamos una variable para realizar la consulta'

        Dim consulta As SqlCommand


        Try

            Abrir_Conexion()

            'Guardamos la informacion en una variable'
            consulta = New SqlCommand("READ_USUARIO", conexion)
            consulta.CommandType = 4
            consulta.Parameters.AddWithValue("@Busqueda", busq)
            respuesta = consulta.ExecuteReader

            Dim datos As String
            Dim vacio As String
            vacio = "vacio"

            While respuesta.Read
                datos = respuesta.Item("Usuario") + "," + respuesta.Item("Contraseña")
            End While



            If datos <> "" Then

                Return datos

            Else

                Return vacio

            End If




            Cerrar_Conexion()

        Catch ex As Exception



        End Try



    End Function





End Class
