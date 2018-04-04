Public Class C_Textos
    Public Shared Mensaje As String
    Public Shared Function ExtraerNumero(Paquete As String, Inicio As String, Final As String, Optional PosInicio As Integer = -1, Optional PosFin As Integer = -1) As Integer
        Dim ValorTexto As String
        Dim Resultado As Integer = -1
        ValorTexto = ExtraerTexto(Paquete, Inicio, Final, PosInicio, PosFin)
        If ValorTexto <> "" Then
            If IsNumeric(ValorTexto) Then
                Resultado = CInt(ValorTexto)
                Return Resultado
            End If
        End If
        Return Resultado
    End Function
    'CLASE SHARED - NO REQUIERE INSTANCIAR PARA USAR LOS METODOS
    Public Shared Function ExtraerTexto(Paquete As String, Inicio As String, Final As String, Optional PosInicio As Integer = -1, Optional PosFin As Integer = -1) As String
        Dim Ini As Integer
        Dim Fin As Integer
        Dim IniTexto As Integer
        Dim LongTexto As Integer
        Dim Resultado As String = ""
        Ini = Paquete.IndexOf(Inicio) 'obtenemos el inicio que debe ser 0 // -1 es no encontrado, otro valor seria desfazado
        If Ini > -1 Then 'inicio encontrado
            If (PosInicio > -1) And (PosInicio <> Ini) Then 'inicio especifico declarado no encontrado
                Mensaje = "Inicio desfazado"
                Resultado = ""
                Return Resultado
                'Exit Function
            End If
            'inicio encontrado, pos inicial no declarada o en la posicion especificada. buscamos el final
            Fin = Paquete.IndexOf(Final, Ini) 'revisar cuando el final aparece antes del incio
            If Fin > -1 Then 'final encontrado
                If (PosFin > -1) And (PosFin <> Fin) Then 'fin especifico declarado no encontrado
                    Mensaje = "Final desfazado"
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
                Mensaje = "Final no encontrado"
                Resultado = ""
                Return Resultado
            End If
        Else
            'Inicio no encontrado
            Mensaje = "Inicio no encontrado"
            Resultado = ""
            Return Resultado
        End If
    End Function


End Class
