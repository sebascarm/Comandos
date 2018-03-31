Public Class C_Procesos
    Public Structure SProc
        Public Id As Integer
        Public Proc As String
        Public Nombre As String
    End Structure
    'Array de Procesos
    Dim ArrProcesos() As SProc

    Public Sub CargarArray()
        Dim Proc As Process
        Dim Elem As Integer = 0
        ArrProcesos = Nothing
        For Each Proc In Process.GetProcesses()
            If Not Proc Is Nothing Then
                ReDim Preserve ArrProcesos(Elem + 1)

                ArrProcesos(Elem).Id = Proc.Id
                ArrProcesos(Elem).Proc = Proc.ProcessName
                ArrProcesos(Elem).Nombre = Proc.MainWindowTitle
                Elem = Elem + 1
            End If
        Next
    End Sub
    Public Sub CargarGrid(Grid As DataGridView)
        Dim Fila As Integer = 0
        Grid.Rows.Add(ArrProcesos.Length - 1)
        For Each Proceso In ArrProcesos
            Grid(0, Fila).Value = ArrProcesos(Fila).Id
            Grid(1, Fila).Value = ArrProcesos(Fila).Proc
            Grid(2, Fila).Value = ArrProcesos(Fila).Nombre
            Fila = Fila + 1
        Next
    End Sub
    Public Sub EnviarTecla(Proceso As Integer, Tecla As String)
        AppActivate(Proceso)
        System.Windows.Forms.SendKeys.Send(Tecla)
    End Sub


End Class
