<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form2
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
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

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form2))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TextBoxUsuario = New System.Windows.Forms.TextBox()
        Me.TextBoxContraseña = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.ButtonIngresarUsuario = New System.Windows.Forms.Button()
        Me.ButtonSalirUsuario = New System.Windows.Forms.Button()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(29, 46)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(50, 15)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Usuario:"
        '
        'TextBoxUsuario
        '
        Me.TextBoxUsuario.Location = New System.Drawing.Point(94, 43)
        Me.TextBoxUsuario.Name = "TextBoxUsuario"
        Me.TextBoxUsuario.Size = New System.Drawing.Size(174, 23)
        Me.TextBoxUsuario.TabIndex = 1
        '
        'TextBoxContraseña
        '
        Me.TextBoxContraseña.Location = New System.Drawing.Point(94, 97)
        Me.TextBoxContraseña.Name = "TextBoxContraseña"
        Me.TextBoxContraseña.Size = New System.Drawing.Size(174, 23)
        Me.TextBoxContraseña.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(9, 100)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(70, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Contraseña:"
        '
        'ButtonIngresarUsuario
        '
        Me.ButtonIngresarUsuario.Location = New System.Drawing.Point(60, 147)
        Me.ButtonIngresarUsuario.Name = "ButtonIngresarUsuario"
        Me.ButtonIngresarUsuario.Size = New System.Drawing.Size(132, 23)
        Me.ButtonIngresarUsuario.TabIndex = 4
        Me.ButtonIngresarUsuario.Text = "Ingresar"
        Me.ButtonIngresarUsuario.UseVisualStyleBackColor = True
        '
        'ButtonSalirUsuario
        '
        Me.ButtonSalirUsuario.Location = New System.Drawing.Point(234, 147)
        Me.ButtonSalirUsuario.Name = "ButtonSalirUsuario"
        Me.ButtonSalirUsuario.Size = New System.Drawing.Size(141, 23)
        Me.ButtonSalirUsuario.TabIndex = 5
        Me.ButtonSalirUsuario.Text = "Salir"
        Me.ButtonSalirUsuario.UseVisualStyleBackColor = True
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(288, 46)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(123, 58)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.PictureBox1.TabIndex = 6
        Me.PictureBox1.TabStop = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(435, 193)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.ButtonSalirUsuario)
        Me.Controls.Add(Me.ButtonIngresarUsuario)
        Me.Controls.Add(Me.TextBoxContraseña)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TextBoxUsuario)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form2"
        Me.Text = "Ingreso de usuarios"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TextBoxUsuario As TextBox
    Friend WithEvents TextBoxContraseña As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents ButtonIngresarUsuario As Button
    Friend WithEvents ButtonSalirUsuario As Button
    Friend WithEvents PictureBox1 As PictureBox
End Class
