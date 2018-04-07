Public Class C_Textos
    Public Shared MensajeError As String
    Public Shared Function ExtraerNumero(Paquete As String, Inicio As String, Final As String, Optional PosInicio As Integer = 0, Optional PosFin As Integer = 0) As Integer
        Dim ValorTexto As String
        Dim Resultado As Integer = -1
        Dim intTMP As Integer
        ValorTexto = ExtraerTexto(Paquete, Inicio, Final, PosInicio, PosFin)
        If ValorTexto <> "" Then
            If Integer.TryParse(ValorTexto, intTMP) = True Then
                Resultado = CInt(ValorTexto)
                Return Resultado
            Else
                MensajeError = "Extraer Numero: No Numerico"
                Return Resultado
            End If
        End If
        Return Resultado
    End Function
    'CLASE SHARED - NO REQUIERE INSTANCIAR PARA USAR LOS METODOS
    Public Shared Function ExtraerTexto(Paquete As String, Inicio As String, Final As String, Optional PosInicio As Integer = 0, Optional PosFin As Integer = 0) As String
        Dim Ini As Integer
        Dim Fin As Integer
        Dim IniTexto As Integer
        Dim LongTexto As Integer
        Dim Resultado As String = ""
        Ini = Paquete.IndexOf(Inicio, PosInicio) 'obtenemos el inicio que debe ser 0 // -1 es no encontrado, otro valor seria desfazado
        If Ini > -1 Then 'inicio encontrado
            If (PosInicio > -1) And (PosInicio <> Ini) Then 'inicio especifico declarado no encontrado
                MensajeError = "Inicio desfazado"
                Resultado = ""
                Return Resultado
                'Exit Function
            End If
            'inicio encontrado, pos inicial no declarada o en la posicion especificada. buscamos el final
            Fin = Paquete.IndexOf(Final, Ini + 1) 'revisar cuando el final aparece antes del incio
            If Fin > -1 Then 'final encontrado
                If (PosFin > 0) And (PosFin <> Fin) Then 'fin especifico declarado no encontrado
                    MensajeError = "Final desfazado"
                    Resultado = ""
                    Return Resultado
                    'Exit Function
                End If
                'devolver valor
                IniTexto = Ini + Inicio.Length
                LongTexto = Fin - IniTexto 'revsar
                Resultado = Paquete.Substring(IniTexto, LongTexto)
                Return Resultado
            Else
                'Final no encontrado
                MensajeError = "Final no encontrado"
                Resultado = ""
                Return Resultado
            End If
        Else
            'Inicio no encontrado
            MensajeError = "Inicio no encontrado"
            Resultado = ""
            Return Resultado
        End If
    End Function
    Public Shared Function NumeroaTexto(Numero As Integer, Digitos As Integer) As String
        Dim Resultado As String
        Dim Valor As String
        Dim LongNumero As Integer
        Dim DigPendiente As Integer
        Dim Relleno As String = ""
        Dim I As Integer
        Valor = CStr(Numero)
        LongNumero = Valor.Length
        DigPendiente = Digitos - LongNumero
        For I = 1 To DigPendiente
            Relleno = Relleno + "0"
        Next
        Resultado = Relleno & Valor
        Return Resultado
    End Function

End Class
