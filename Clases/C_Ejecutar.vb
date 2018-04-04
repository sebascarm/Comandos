Public Class C_Ejecutar
    'ejecucion con devolucion de datos
    Public Shared Function EjecutarResul(Proceso As String, Optional TimeOut As Integer = 5000) As String
        Try
            Dim My_Process As New Process()
            Dim My_Process_Info As New ProcessStartInfo()
            Dim Argumento As String
            Argumento = "/C " & Proceso & "/B"
            My_Process_Info.FileName = "CMD.EXE" ' Process filename
            My_Process_Info.Arguments = Argumento ' Process arguments
            My_Process_Info.CreateNoWindow = True ' Show or hide the process Window
            My_Process_Info.UseShellExecute = False ' Don't use system shell to execute the process
            My_Process_Info.RedirectStandardOutput = True '  Redirect (1) Output
            My_Process_Info.RedirectStandardError = True ' Redirect non (1) Output
            My_Process.EnableRaisingEvents = True ' Raise events
            My_Process.StartInfo = My_Process_Info



            My_Process.Start() ' Run the process NOW

            My_Process.WaitForExit(TimeOut)
            'My_Process.Kill()

            Dim ERRORLEVEL = My_Process.ExitCode ' Stores the ExitCode of the process
            If Not ERRORLEVEL = 0 Then
                Return "Exit Code: " & CStr(ERRORLEVEL) ' Returns the Exitcode if is not 0
            End If

            Dim Process_ErrorOutput As String = My_Process.StandardOutput.ReadToEnd() ' Stores the Error Output (If any)
            Dim Process_StandardOutput As String = My_Process.StandardOutput.ReadToEnd() ' Stores the Standard Output (If any)
            ' Return output by priority
            If Process_ErrorOutput IsNot Nothing Then Return Process_ErrorOutput ' Returns the ErrorOutput (if any)
            If Process_StandardOutput IsNot Nothing Then Return Process_StandardOutput ' Returns the StandardOutput (if any)
            'en caso que no devueba nada
            Return ""
        Catch ex As Exception
            'MsgBox(ex.Message)
            Return ex.Message ' Returns nothing if the process can't be found or started.
        End Try

    End Function
    'ejecucion simple
    Public Shared Sub Ejecutar(Proceso As String)
        Dim My_Process As New Process()
        Dim My_Process_Info As New ProcessStartInfo()
        Dim Argumento As String
        Argumento = "/C " & Proceso & "/B"

        My_Process_Info.FileName = "CMD.EXE" ' Process filename
        My_Process_Info.Arguments = Argumento ' Process arguments
        My_Process_Info.CreateNoWindow = True ' Show or hide the process Window
        My_Process_Info.UseShellExecute = False ' Don't use system shell to execute the process
        My_Process_Info.RedirectStandardOutput = False '  Redirect (1) Output
        My_Process_Info.RedirectStandardError = False ' Redirect non (1) Output
        My_Process.EnableRaisingEvents = False ' Raise events
        My_Process.StartInfo = My_Process_Info
        My_Process.Start() ' Run the process NOW

    End Sub
End Class
