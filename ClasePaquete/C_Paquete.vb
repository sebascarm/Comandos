Public Class C_Paquete
    Dim _Paquete As String
    Dim _SecuenciaRec As Integer = 0
    Dim _SecuenciaEnv As Integer = 0
    Dim _ComandosValidos() As String = {"COMANDO", "COMANDO_RET", "VALOR", "LOG", "LOGCOLOR", "ARCHIVO", "OBJETO", "GENERAL"}
    Structure S_Paquete
        Dim Longitud As Integer
        Dim Secuencia As Integer
        Dim TipoDato As String
        Dim PaqueteDatos As String
        Dim Paquete_Part1 As String 'se usa en caso de comandos compuestos
        Dim Paquete_Part2 As String 'se usa en caso de comandos compuestos
        Dim Paquete_Part3 As String 'se usa en caso de comandos compuestos
        Dim Paquete_Part4 As String 'se usa en caso de comandos compuestos
        Dim MensajeError As String
    End Structure
    Public Est_Paquete As S_Paquete
    Public Function ArmarPaquete(TipoDato As String, PaqueteDato As String) As String
        Dim L_Longitud As Integer
        Dim LongTexto As String
        Dim TipoPermitido As Boolean = False
        Dim SecTexto As String
        Dim PaqueteInicial As String
        Dim PaqueteParcial As String
        Dim PaqueteFinal As String = ""
        'revisamos que el tipo de datos sea un tipo permitio
        For Each Tipo In _ComandosValidos
            If Tipo = TipoDato Then
                'El tipo esta permitido
                TipoPermitido = True
                Exit For
            End If
        Next
        'si el tipo esta permitido continuamos
        If TipoPermitido = False Then
            Est_Paquete.MensajeError = "El tipo de dato no esta permitido: " & TipoDato
            Return PaqueteFinal
        Else
            SecTexto = C_Textos.NumeroaTexto(_SecuenciaEnv, 2)
            PaqueteParcial = "[" & SecTexto & "]" & "(" & TipoDato & ")" & PaqueteDato & "<"
            L_Longitud = PaqueteParcial.Length + 6 '6 es de la misma longitud
            LongTexto = C_Textos.NumeroaTexto(L_Longitud, 3)
            PaqueteInicial = ">(" & LongTexto & ")"
            PaqueteFinal = PaqueteInicial & PaqueteParcial
            'incrementar secuencia para el proximo paquete
            _SecuenciaEnv = IncrementarSecuencia(_SecuenciaEnv, 1000)
            Return PaqueteFinal
        End If


    End Function
    Public Function Cargar(Paquete As String) As Boolean
        _Paquete = Paquete
        'Extraer y controla la longitud
        Est_Paquete.Longitud = ControlLongitud(Paquete)
        If Est_Paquete.Longitud = -1 Then
            'Debug.Print(Est_Paquete.MensajeError)
            Return False
        Else
            'Longitud correcta
            'Extraer y controlar secuencia
            Est_Paquete.Secuencia = ControlSecuencia(Paquete)
            If Est_Paquete.Secuencia = -1 Then
                'Debug.Print(Est_Paquete.MensajeError)
                Return False
            Else
                'Secuencia correcta
                'Extraer y controlar el tipo de datos
                Est_Paquete.TipoDato = ControlTipoDato(Paquete)
                If Est_Paquete.TipoDato = "" Then
                    'Debug.Print(Est_Paquete.MensajeError)
                    Return False
                Else
                    'Tipo de dato correcto
                    'extraer el paquete de datos
                    Est_Paquete.PaqueteDatos = ControlPaqueteDato(Paquete, Est_Paquete.TipoDato)
                    If Est_Paquete.PaqueteDatos = "" Then
                        'Debug.Print(Est_Paquete.MensajeError)
                        Return False
                    Else
                        'todo correcto
                        Return True
                    End If
                End If
            End If
        End If
    End Function
    Private Function ControlLongitud(Paquete As String) As Integer
        Dim LongitudPaquete As Integer = Paquete.Length
        Dim Longitud As Integer
        Dim Resultado As Integer = -1
        Longitud = C_Textos.ExtraerNumero(Paquete, ">(", ")", 0, 5)
        If Longitud = -1 Then
            'revisamos algun error en la extraccion de la longitud
            Est_Paquete.MensajeError = "Logitud: " & C_Textos.MensajeError
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
    Private Function ControlTipoDato(Paquete As String) As String
        Dim TipoDato As String
        Dim Resultado As String = ""
        TipoDato = C_Textos.ExtraerTexto(Paquete, "(", ")", 10)
        If TipoDato = "" Then
            'revisamos algun error en la extraccion de la longitud
            Est_Paquete.MensajeError = "Tipo de dato: " & C_Textos.MensajeError
            Return Resultado
        Else
            'revisamos que el tipo de datos sea un tipo permitio
            For Each TipoPermitido In _ComandosValidos
                If TipoPermitido = TipoDato Then
                    'El tipo esta permitido
                    Resultado = TipoDato
                    Return Resultado
                End If
            Next
            ' no se encontro en los tipos de dato permitido
            Est_Paquete.MensajeError = "Tipo de dato no permitido: " & TipoDato
            Return Resultado
        End If
    End Function
    Private Function ControlSecuencia(Paquete As String) As Integer
        Dim Secuencia As Integer
        Dim Resultado As Integer = -1
        Secuencia = C_Textos.ExtraerNumero(Paquete, "[", "]", 6, 9)
        If Secuencia = -1 Then
            'revisamos algun error en la extraccion de la longitud
            Est_Paquete.MensajeError = "Secuencia: " & C_Textos.MensajeError
            Return Resultado
        Else
            'revisamos que la secuencia coincida
            If Secuencia <> _SecuenciaRec Then
                Est_Paquete.MensajeError = "Secuencia de paquete incorrecta"
                Return Resultado
            Else
                'secuencia correcta
                Resultado = Secuencia
                'incrementamos la proxima secuencia para el proximo control
                _SecuenciaRec = IncrementarSecuencia(_SecuenciaRec, 100)
                'devolvemos la secuencia actual
                Return Resultado
            End If
        End If
        Return Resultado
    End Function
    Private Function ControlPaqueteDato(Paquete As String, TipoDato As String) As String
        Dim PaqueteDato As String
        Dim Resultado As String = ""
        Dim Inicio As Integer
        Inicio = 11 + Est_Paquete.TipoDato.Length '11 es la longitud fija 
        PaqueteDato = C_Textos.ExtraerTexto(Paquete, ")", "<", Inicio)
        If PaqueteDato = "" Then
            'revisamos algun error en la extraccion de la longitud
            Est_Paquete.MensajeError = "Paquete de datos: " & C_Textos.MensajeError
            Return Resultado
        Else
            'Controlamos segun tipo de dato LOS QUE SON ESPECIALES
            Select Case TipoDato
                Case "VALOR"
                    'Debemos controlar que exista el =
                    Dim Parametro As String
                    Dim Valor As String
                    Parametro = C_Textos.ExtraerTexto(Paquete, ")", "=", 11)
                    If Parametro = "" Then
                        'revisamos algun error en la extraccion del parametro
                        Est_Paquete.MensajeError = "Parametro: " & C_Textos.MensajeError
                        Return Resultado
                    Else
                        'parametro correcto
                        Valor = C_Textos.ExtraerTexto(Paquete, "=", "<", 12)
                        If Valor = "" Then
                            Est_Paquete.MensajeError = "Valor: " & C_Textos.MensajeError
                            Return Resultado
                        End If
                        'por lo visto esta correcto almacenamos los valores y el resultado del paquete
                        Resultado = PaqueteDato
                        Est_Paquete.Paquete_Part1 = Parametro
                        Est_Paquete.Paquete_Part2 = Valor
                        Return Resultado
                    End If

                Case "LOGCOLOR"
                    Dim Texto1 As String
                    Dim Color1 As String
                    Dim Texto2 As String
                    Dim Color2 As String
                    'Dim Inicio As Integer
                    'El texto 1 es obligatorio, los demas no
                    Texto1 = C_Textos.ExtraerTexto(PaqueteDato, "'", "'", 0)
                    If Texto1 = "" Then
                        Est_Paquete.MensajeError = "Log Color: " & C_Textos.MensajeError
                        Return Resultado
                    Else
                        Inicio = Texto1.Length
                        Color1 = C_Textos.ExtraerTexto(PaqueteDato, "'", "'", Inicio)
                        Inicio = Inicio + Color1.Length
                        Texto2 = C_Textos.ExtraerTexto(PaqueteDato, "'", "'", Inicio)
                        Inicio = Inicio + Texto2.Length
                        Color2 = C_Textos.ExtraerTexto(PaqueteDato, "'", "'", Inicio)
                        'revisar como funciono hasta aca
                        'devolver los valores
                        Resultado = PaqueteDato
                        Est_Paquete.Paquete_Part1 = Texto1
                        Est_Paquete.Paquete_Part2 = Color1
                        Est_Paquete.Paquete_Part3 = Texto2
                        Est_Paquete.Paquete_Part4 = Color2
                        Return Resultado
                    End If
                Case "ARCHIVO", "OBJETO" 'son identicos
                    Dim Nombre As String 'En Archivo es NOMBRE DE ARCHIVO, En Objeto Es Nombre de Objeto
                    Dim ParteB As String 'En Archivo son los DATOS, en Objeto es el Parametro ej: Click
                    'Dim Inicio As Integer
                    Nombre = C_Textos.ExtraerTexto(PaqueteDato, "'", "'", 0) 'revisar q funcione
                    If Nombre = "" Then
                        'revisamos algun error en la extraccion del parametro
                        Est_Paquete.MensajeError = "Archivo/Objeto: " & C_Textos.MensajeError
                        Return Resultado
                    Else
                        'nombre correcto, buscar los datos
                        Inicio = Nombre.Length
                        ParteB = C_Textos.ExtraerTexto(PaqueteDato, "'", "'", Inicio)
                        If ParteB = "" Then
                            Est_Paquete.MensajeError = "Datos/Evento: " & C_Textos.MensajeError
                            Return Resultado
                        End If
                        'por lo visto esta correcto almacenamos los valores y el resultado del paquete
                        Resultado = PaqueteDato
                        Est_Paquete.Paquete_Part1 = Nombre
                        Est_Paquete.Paquete_Part2 = ParteB
                        Return Resultado
                    End If
                Case Else
                    Resultado = PaqueteDato
                    Return Resultado
            End Select
        End If
    End Function
    Private Function IncrementarSecuencia(Secuencia As Integer, Limite As Integer) As Integer
        'secuencias de 0 a 99
        Secuencia = Secuencia + 1
        If Secuencia >= Limite Then
            Secuencia = 0
        End If
        Return Secuencia
    End Function
End Class
