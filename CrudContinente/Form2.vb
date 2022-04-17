Public Class Form2
    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub

    Private Sub ButtonIngresarUsuario_Click(sender As Object, e As EventArgs) Handles ButtonIngresarUsuario.Click




        If TextBoxUsuario.Text <> "" And TextBoxContraseña.Text <> "" Then



            Dim tUsuario = New Usuario()
            Dim infoUsuario As String



            infoUsuario = tUsuario.datosEmpleado(TextBoxUsuario.Text.ToString.ToUpper)





            If infoUsuario.Equals("vacio") Then

                MsgBox("El usuario no existe")

            Else


                Dim cadena As String() = infoUsuario.Split(",")


                If Trim(cadena(1)).Equals(TextBoxContraseña.Text.ToString.ToUpper) Then

                    Me.Hide()
                    Form1.Show()


                Else

                    MsgBox("La contraseña esta errada")



                End If



            End If






        Else



            MsgBox("Debe ingresar un usuario y una contraseña")


        End If









    End Sub
End Class