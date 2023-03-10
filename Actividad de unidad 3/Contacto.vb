Imports System
Imports System.Collections.Generic
Imports System.Diagnostics
Imports System.Globalization
Imports System.IO
Imports System.Linq
Imports System.Reflection
Imports System.Runtime.CompilerServices
Imports System.Security
Imports System.Text
Imports System.Threading.Tasks
Imports Microsoft.VisualBasic

Friend Class Contacto
    Inherits Persona
    Private telefono As String
    Private correo As String

    Public Property _Telefono() As String
        Get
            Return telefono
        End Get
        Set(value As String)
            telefono = value.Replace(" ", "").Replace("-", "")
        End Set
    End Property

    Public Property _Correo() As String
        Get
            Return correo
        End Get
        Set(value As String)
            correo = value
        End Set
    End Property

    Public Sub New()
        MyBase.New()
        telefono = String.Empty
        correo = String.Empty
    End Sub

    Public Sub New(nombre As String, fechaDenacimiento As DateTime, telefono As String)
        MyBase.New(nombre, fechaDenacimiento)
        Me.telefono = telefono
        Me.correo = correo
    End Sub

    Public Overrides Function ToString() As String
        Return MyBase.ToString() & " " & telefono & " " & correo
    End Function


End Class
