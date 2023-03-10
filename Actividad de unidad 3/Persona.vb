Imports System

Friend Class Persona
    Protected nombre As String
    Protected fechaDenacimiento? As DateTime
    Public Property _Nombre() As String
        Get
            Return nombre
        End Get
        Set(ByVal value As String)
            nombre = value
        End Set
    End Property
    Public Property _FechaDenacimiento() As DateTime?
        Get
            Return fechaDenacimiento
        End Get
        Set(ByVal value As DateTime?)
            fechaDenacimiento = value
        End Set
    End Property
    Public ReadOnly Property Edad() As Integer
        Get
            Dim Edad_ As Integer
            Edad_ = (DateTime.Now.Year - fechaDenacimiento.Value.Year)
            Return Edad_
        End Get
    End Property
    Public Sub New()
        nombre = ""
        fechaDenacimiento = Nothing
    End Sub
    Public Sub New(ByVal nombre_ As String, ByVal FechaDenacimento As DateTime?)
        Me.nombre = nombre_
        Me.fechaDenacimiento = FechaDenacimento
    End Sub

    Public Overrides Function ToString() As String
        Return nombre.ToUpper() & " " & Edad
    End Function

End Class
