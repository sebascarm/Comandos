Imports ClaseSocket
Public Class C_Conexion
    Dim C_SOCKET As C_Sockets = New C_Sockets
    Public Sub Escuchar()
        Dim IP As String = FormComandos.TeIP.Text
        Dim Port As Integer = CInt(FormComandos.TePuerto.Text)

        C_SOCKET.Escuchar(IP, Port, 100, 100, "<")

    End Sub


End Class
