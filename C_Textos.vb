Public Class C_Textos
    Public Mensaje As String
    Public Function BuscarTexto(Paquete As String, Inicio As String, Final As String, Optional PosInicio As Integer = -1, Optional PosFin As Integer = -1) As String
        Dim Ini As Integer
        Dim Fin As Integer
        Dim LongIni As Integer

        Dim LongTexto As String
        Dim Valor As Integer
        Dim Resultado As String = ""
        Ini = Paquete.IndexOf(Inicio) 'obtenemos el inicio que debe ser 0 // -1 es no encontrado, otro valor seria desfazado
        If Ini > -1 Then 'inicio encontrado
            If (PosInicio > -1) And (PosInicio <> Ini) Then 'inicio especifico declarado no encontrado
                Mensaje = "Inicio desfazado"
                Resultado = ""
                Exit Function
            End If
            'inicio encontrado, pos inicial no declarada o en la posicion especificada. buscamos el final
            Fin = Paquete.IndexOf(Final, Ini) 'revisar cuando el final aparece antes del incio
            If Fin > -1 Then 'final encontrado
                If (PosFin > -1) And (PosFin <> Fin) Then 'fin especifico declarado no encontrado
                    Mensaje = "Final desfazado"
                    Resultado = ""
                    Exit Function
                End If
                'devolver valor
                LongIni = Inicio.Length
                'continuar
                Resultado = Paquete.Substring()
            Else
                'Final no encontrado
                Mensaje = "Final no encontrado"
                Resultado = ""
            End If
        Else
            'Inicio no encontrado
            Mensaje = "Inicio no encontrado"
            Resultado = ""
        End If



    End Function


End Class
