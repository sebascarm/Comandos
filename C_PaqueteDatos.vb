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

    Private Function ControlLongitud(Paquete As String) As Boolean
        Dim Resultado As Boolean = False
        Dim LongitudPaquete As Integer = Paquete.Length
        Dim T_LongitudControl As String
        Dim LongitudControl As Integer
        T_LongitudControl = C_Textos.BuscarTexto(Paquete, ">(", ")", 0, 5)
        If T_LongitudControl <> "" Then
            If IsNumeric(T_LongitudControl) Then ' control si es numero
                LongitudControl = CInt(T_LongitudControl)
                If LongitudControl = LongitudPaquete Then
                    'longitud correcta
                    Est_Paquete.Longitud = LongitudControl
                    Return True
                Else
                    'longitud incorrecta
                    Return False
                End If
            Else
                'logitud no es numerica
                Return False
            End If
        Else
            'logitud incorrecta devuelto vacio
            Return False
        End If
    End Function
End Class
