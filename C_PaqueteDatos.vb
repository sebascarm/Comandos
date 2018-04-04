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
        Est_Paquete.Longitud = ExtraerLongitud(Paquete)
        Est_Paquete.Secuencia = ExtraerSecuencia(Paquete)
    End Function
    Private Function ExtraerLongitud(Paquete As String) As Integer
        Dim LongitudPaquete As Integer = Paquete.Length
        Dim Longitud As Integer
        Dim Resultado As Integer = -1
        Longitud = C_Textos.ExtraerNumero(Paquete, ">(", ")", 0, 5)
        If Longitud > -1 Then
            If Longitud = LongitudPaquete Then
                Resultado = Longitud
            End If
        End If
        Return Resultado
    End Function
    Private Function ExtraerSecuencia(Paquete As String) As Integer
        Dim Resultado As Integer
        Resultado = C_Textos.ExtraerNumero(Paquete, "[", "]", 6, 9)
        Return Resultado
    End Function

End Class
