'Imports ClaseSocket
Module Inicio
    Public C_PROCESO As C_Procesos = New C_Procesos
    'Public C_SOCKET As C_Sockets = New C_Sockets
    Public Sub Main()

        C_PROCESO.CargarArray()
        C_PROCESO.CargarGrid(FormComandos.GridProc)

    End Sub
End Module
