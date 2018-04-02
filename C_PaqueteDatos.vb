Public Class C_PaqueteDatos
    Dim _Paquete As String
    Structure S_Paquete
        Public Longitud As Integer
        Public Secuencia As Integer
        Public TipoDato As String
        Public PaqueteDatos As String
    End Structure
    Dim Est_Paquete As S_Paquete
    Public Function Control(Paquete As String) As Integer
        _Paquete = Paquete


    End Function

    Private Function ControlLongitud(Paquete As String) As Integer
        Dim Longitud As Integer = Paquete.Length


    End Function
End Class
