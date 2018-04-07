'Imports ClaseSocket
Imports ClasePaquete
Module Inicio
    Public C_PROCESO As C_Procesos = New C_Procesos
    Public C_PAQUETE As C_Paquete = New C_Paquete
    'Public C_SOCKET As C_Sockets = New C_Sockets
    Public Sub Main()

        C_PROCESO.CargarArray()
        C_PROCESO.CargarGrid(FormComandos.GridProc)
        'C_Ejecutar.Ejecutar("calc.exe")
        'Dim seba = C_Ejecutar.EjecutarResul("DaIR")
        'MsgBox(seba)

        Dim Paquete As String
        'Paquete = (">(036)[00](COMANDO)EXECUTE CALC.EXE<")

        Paquete = C_PAQUETE.ArmarPaquete("COMANDO", "CALC.EXE")
        Debug.Print(Paquete)


        If C_PAQUETE.Cargar(Paquete) = True Then

            Debug.Print(C_PAQUETE.Est_Paquete.Longitud)
            Debug.Print(C_PAQUETE.Est_Paquete.Secuencia)
            Debug.Print(C_PAQUETE.Est_Paquete.TipoDato)
            Debug.Print(C_PAQUETE.Est_Paquete.PaqueteDatos)
        End If
    End Sub
End Module
