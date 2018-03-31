<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requerido por el Diseñador de Windows Forms
    Private components As System.ComponentModel.IContainer

    'NOTA: el Diseñador de Windows Forms necesita el siguiente procedimiento
    'Se puede modificar usando el Diseñador de Windows Forms.  
    'No lo modifique con el editor de código.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BackgroundWorker1 = New System.ComponentModel.BackgroundWorker()
        Me.GridProc = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proc = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bot_Env_Key = New System.Windows.Forms.Button()
        Me.T_Enviar = New System.Windows.Forms.TextBox()
        Me.T_ID = New System.Windows.Forms.TextBox()
        Me.B_CargarProcesos = New System.Windows.Forms.Button()
        CType(Me.GridProc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridProc
        '
        Me.GridProc.AllowUserToDeleteRows = False
        Me.GridProc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridProc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GridProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Proc, Me.Nombre})
        Me.GridProc.Location = New System.Drawing.Point(12, 118)
        Me.GridProc.Name = "GridProc"
        Me.GridProc.ReadOnly = True
        Me.GridProc.Size = New System.Drawing.Size(611, 367)
        Me.GridProc.TabIndex = 0
        '
        'Id
        '
        Me.Id.Frozen = True
        Me.Id.HeaderText = "Id"
        Me.Id.Name = "Id"
        Me.Id.ReadOnly = True
        '
        'Proc
        '
        Me.Proc.Frozen = True
        Me.Proc.HeaderText = "Proc"
        Me.Proc.Name = "Proc"
        Me.Proc.ReadOnly = True
        '
        'Nombre
        '
        Me.Nombre.Frozen = True
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        '
        'Bot_Env_Key
        '
        Me.Bot_Env_Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Env_Key.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Env_Key.Location = New System.Drawing.Point(422, 91)
        Me.Bot_Env_Key.Name = "Bot_Env_Key"
        Me.Bot_Env_Key.Size = New System.Drawing.Size(91, 21)
        Me.Bot_Env_Key.TabIndex = 17
        Me.Bot_Env_Key.Text = "A Serv"
        Me.Bot_Env_Key.UseVisualStyleBackColor = True
        '
        'T_Enviar
        '
        Me.T_Enviar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_Enviar.Location = New System.Drawing.Point(158, 91)
        Me.T_Enviar.Name = "T_Enviar"
        Me.T_Enviar.Size = New System.Drawing.Size(258, 20)
        Me.T_Enviar.TabIndex = 16
        '
        'T_ID
        '
        Me.T_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_ID.Location = New System.Drawing.Point(12, 91)
        Me.T_ID.Name = "T_ID"
        Me.T_ID.Size = New System.Drawing.Size(140, 20)
        Me.T_ID.TabIndex = 18
        '
        'B_CargarProcesos
        '
        Me.B_CargarProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_CargarProcesos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B_CargarProcesos.Location = New System.Drawing.Point(12, 12)
        Me.B_CargarProcesos.Name = "B_CargarProcesos"
        Me.B_CargarProcesos.Size = New System.Drawing.Size(91, 21)
        Me.B_CargarProcesos.TabIndex = 19
        Me.B_CargarProcesos.Text = "Cargar"
        Me.B_CargarProcesos.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(836, 505)
        Me.Controls.Add(Me.B_CargarProcesos)
        Me.Controls.Add(Me.T_ID)
        Me.Controls.Add(Me.Bot_Env_Key)
        Me.Controls.Add(Me.T_Enviar)
        Me.Controls.Add(Me.GridProc)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.GridProc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BackgroundWorker1 As System.ComponentModel.BackgroundWorker
    Friend WithEvents GridProc As DataGridView
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Proc As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents Bot_Env_Key As Button
    Friend WithEvents T_Enviar As TextBox
    Friend WithEvents T_ID As TextBox
    Friend WithEvents B_CargarProcesos As Button
End Class
