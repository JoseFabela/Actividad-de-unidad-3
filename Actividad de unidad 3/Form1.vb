Imports System
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Security
Imports System.Text
Imports System.Threading.Tasks
Imports System.Windows.Forms
Imports Microsoft.VisualBasic
Public Class Form1
    Private cantidadPersonas As Integer = 0
    Private RegistradosInt As Integer = 0
    Private arreglo As Contacto()

    Public Sub New()
        InitializeComponent()
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        If RegistradosInt < cantidadPersonas Then
            Dim nuevocontacto As New Contacto()
            nuevocontacto._FechaDenacimiento = dtpFecha.Value
            nuevocontacto._Nombre = txtNombre.Text
            nuevocontacto._Telefono = txttelefono.Text
            nuevocontacto._Correo = txtCorreo.Text
            arreglo(RegistradosInt) = nuevocontacto
            RegistradosInt += 1
            Dim nuevaLinea As String = nuevocontacto._Nombre & ", " & nuevocontacto.Edad.ToString() & ", " & nuevocontacto._Telefono.ToString() & ", " & nuevocontacto._Correo.ToString() & Environment.NewLine
            lblMostrar.Text = lblMostrar.Text & nuevaLinea
        Else
            Interaction.MsgBox("Ya se registraron todos")
        End If
    End Sub
    Private Sub TextBox_TextChanged(sender As Object, e As EventArgs) Handles txtCantidad.TextChanged
        Dim valor As Integer = Integer.Parse(txtCantidad.Text)
        cantidadPersonas = valor
        RegistradosInt = 0
        arreglo = New Contacto(cantidadPersonas) {}
    End Sub

End Class
