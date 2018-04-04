Public Class C_PaqueteDatos
    Dim _Paquete As String
    Structure S_Paquete
        Public Longitud As Integer
        Public Secuencia As Integer
        Public TipoDato As String
        Public PaqueteDatos As String
        Public MensajeError As String
    End Structure
    Dim Est_Paquete As S_Paquete
    Public Function Control(Paquete As String) As Integer
        _Paquete = Paquete
        Est_Paquete.Longitud = ExtraerLongitud(Paquete)
        If Est_Paquete.Longitud = -1 Then
            Debug.Print(Est_Paquete.MensajeError)
        End If
        Est_Paquete.Secuencia = ExtraerSecuencia(Paquete)
    End Function
    Private Function ExtraerLongitud(Paquete As String) As Integer
        Dim LongitudPaquete As Integer = Paquete.Length
        Dim Longitud As Integer
        Dim Resultado As Integer = -1
        Longitud = C_Textos.ExtraerNumero(Paquete, ">(", ")", 0, 5)
        If Longitud = -1 Then
            'revisamos algun error en la extraccion de la longitud
            Est_Paquete.MensajeError = C_Textos.MensajeError
            Return Resultado
        Else
            'revisamos que la longitud coincida
            If Longitud <> LongitudPaquete Then
                Est_Paquete.MensajeError = "Longitud de paquete incorrecta"
                Return Resultado
            Else
                'longitud correcta
                Resultado = Longitud
                Return Resultado
            End If
        End If
    End Function
    Private Function ExtraerSecuencia(Paquete As String) As Integer
        Dim Resultado As Integer
        Resultado = C_Textos.ExtraerNumero(Paquete, "[", "]", 6, 9)
        Return Resultado
    End Function

End Class
