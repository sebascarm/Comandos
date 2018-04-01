Public Class FormComandos
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call Main()
    End Sub

    Private Sub GridProc_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProc.CellContentClick
        Dim Fila As Integer
        Dim ID As Integer
        Fila = GridProc.CurrentCell.RowIndex
        ID = GridProc(0, Fila).Value
        T_ID.Text = ID.ToString
    End Sub

    Private Sub GridProc_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles GridProc.CellClick
        Dim Fila As Integer
        Dim ID As Integer
        Fila = GridProc.CurrentCell.RowIndex
        ID = GridProc(0, Fila).Value
        T_ID.Text = ID.ToString
    End Sub

    Private Sub Bot_Env_Key_Click(sender As Object, e As EventArgs) Handles Bot_Env_Key.Click
        Dim ID_Proceso As Integer
        Dim Tecla As String
        ID_Proceso = CInt(T_ID.Text)
        Tecla = T_Enviar.Text
        C_PROCESO.EnviarTecla(ID_Proceso, Tecla)

    End Sub

    Private Sub B_CargarProcesos_Click(sender As Object, e As EventArgs) Handles B_CargarProcesos.Click
        C_PROCESO.CargarArray()
        C_PROCESO.CargarGrid(GridProc)
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles Label1.Click

    End Sub
End Class
