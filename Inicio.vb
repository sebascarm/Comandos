'Imports ClaseSocket
Module Inicio
    Public C_PROCESO As C_Procesos = New C_Procesos
    Public C_PAQUETE As C_PaqueteDatos = New C_PaqueteDatos
    'Public C_SOCKET As C_Sockets = New C_Sockets
    Public Sub Main()

        C_PROCESO.CargarArray()
        C_PROCESO.CargarGrid(FormComandos.GridProc)
        C_PAQUETE.Control(">(001)[01](COMANDO)EXECUTE CALC.EXE<")
    End Sub
End Module
