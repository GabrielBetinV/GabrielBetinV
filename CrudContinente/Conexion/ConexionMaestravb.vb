Imports System.Data
Imports System.Data.SqlClient
Imports System.Configuration




Module ConexionMaestravb

    Public conexion As New SqlConnection("Server=DESKTOP-T66SHUD;Database=DatabaseContinente;Trusted_Connection=True; MultipleActiveResultSets=True;")



    Sub Abrir_Conexion()

        If conexion.State = 0 Then
            conexion.Open()

        End If

    End Sub


    Sub Cerrar_Conexion()

        If conexion.State = 1 Then
            conexion.Close()

        End If

    End Sub









End Module
