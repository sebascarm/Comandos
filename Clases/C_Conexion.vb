Imports ClaseSocket
Imports ClasePaquete
Public Class C_Conexion
    Dim Transmision As C_Sockets
    Dim Paquete As C_Paquete
    Dim Estado As Integer = 0
    Public Sub New()

    End Sub
    Public Sub Escuchar()
        Dim IP As String = FormComandos.TeIP.Text
        Dim Port As Integer = CInt(FormComandos.TePuerto.Text)
        'revisar si ya esta escuchando
        Transmision = New C_Sockets
        Paquete = New C_Paquete
        AddHandler Transmision.E_Estado, AddressOf CambioEstado
        AddHandler Transmision.E_Recepcion, AddressOf Recepcion
        Transmision.Escuchar(IP, Port, 100, 100, "<")

    End Sub
    Private Sub CambioEstado(ByVal Estado As Integer)
        Me.Estado = Estado
    End Sub
    Private Sub Recepcion(ByVal Datos As String)
        If Paquete.Cargar(Datos) Then

        Else
            Debug.Print(Paquete.Est_Paquete.MensajeError)
        End If
    End Sub
End Class
