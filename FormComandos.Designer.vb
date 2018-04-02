<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormComandos
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
        Me.GridProc = New System.Windows.Forms.DataGridView()
        Me.Id = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Proceso = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Nombre = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.Bot_Env_Key = New System.Windows.Forms.Button()
        Me.T_Enviar = New System.Windows.Forms.TextBox()
        Me.T_ID = New System.Windows.Forms.TextBox()
        Me.B_CargarProcesos = New System.Windows.Forms.Button()
        Me.T_Ejecutar = New System.Windows.Forms.TextBox()
        Me.Bot_Ejecutar = New System.Windows.Forms.Button()
        Me.Bot_Escuchar = New System.Windows.Forms.Button()
        Me.TePuerto = New System.Windows.Forms.TextBox()
        Me.TeIP = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GridProc, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridProc
        '
        Me.GridProc.AllowUserToDeleteRows = False
        Me.GridProc.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.GridProc.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.[Single]
        Me.GridProc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.GridProc.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.Id, Me.Proceso, Me.Nombre})
        Me.GridProc.Location = New System.Drawing.Point(12, 145)
        Me.GridProc.Name = "GridProc"
        Me.GridProc.ReadOnly = True
        Me.GridProc.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect
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
        'Proceso
        '
        Me.Proceso.Frozen = True
        Me.Proceso.HeaderText = "Proceso"
        Me.Proceso.Name = "Proceso"
        Me.Proceso.ReadOnly = True
        Me.Proceso.Width = 200
        '
        'Nombre
        '
        Me.Nombre.Frozen = True
        Me.Nombre.HeaderText = "Nombre"
        Me.Nombre.Name = "Nombre"
        Me.Nombre.ReadOnly = True
        Me.Nombre.Width = 300
        '
        'Bot_Env_Key
        '
        Me.Bot_Env_Key.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Env_Key.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Env_Key.Location = New System.Drawing.Point(505, 116)
        Me.Bot_Env_Key.Name = "Bot_Env_Key"
        Me.Bot_Env_Key.Size = New System.Drawing.Size(118, 21)
        Me.Bot_Env_Key.TabIndex = 17
        Me.Bot_Env_Key.Text = "Enviar a Proceso"
        Me.Bot_Env_Key.UseVisualStyleBackColor = True
        '
        'T_Enviar
        '
        Me.T_Enviar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_Enviar.Location = New System.Drawing.Point(158, 116)
        Me.T_Enviar.Name = "T_Enviar"
        Me.T_Enviar.Size = New System.Drawing.Size(341, 20)
        Me.T_Enviar.TabIndex = 16
        '
        'T_ID
        '
        Me.T_ID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_ID.Location = New System.Drawing.Point(12, 116)
        Me.T_ID.Name = "T_ID"
        Me.T_ID.Size = New System.Drawing.Size(140, 20)
        Me.T_ID.TabIndex = 18
        '
        'B_CargarProcesos
        '
        Me.B_CargarProcesos.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.B_CargarProcesos.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.B_CargarProcesos.Location = New System.Drawing.Point(12, 88)
        Me.B_CargarProcesos.Name = "B_CargarProcesos"
        Me.B_CargarProcesos.Size = New System.Drawing.Size(140, 21)
        Me.B_CargarProcesos.TabIndex = 19
        Me.B_CargarProcesos.Text = "Cargar Procesos"
        Me.B_CargarProcesos.UseVisualStyleBackColor = True
        '
        'T_Ejecutar
        '
        Me.T_Ejecutar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.T_Ejecutar.Location = New System.Drawing.Point(158, 90)
        Me.T_Ejecutar.Name = "T_Ejecutar"
        Me.T_Ejecutar.Size = New System.Drawing.Size(341, 20)
        Me.T_Ejecutar.TabIndex = 20
        '
        'Bot_Ejecutar
        '
        Me.Bot_Ejecutar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Ejecutar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Ejecutar.Location = New System.Drawing.Point(505, 88)
        Me.Bot_Ejecutar.Name = "Bot_Ejecutar"
        Me.Bot_Ejecutar.Size = New System.Drawing.Size(118, 21)
        Me.Bot_Ejecutar.TabIndex = 21
        Me.Bot_Ejecutar.Text = "Ejecutar Comando"
        Me.Bot_Ejecutar.UseVisualStyleBackColor = True
        '
        'Bot_Escuchar
        '
        Me.Bot_Escuchar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Bot_Escuchar.ForeColor = System.Drawing.SystemColors.ControlLightLight
        Me.Bot_Escuchar.Location = New System.Drawing.Point(505, 61)
        Me.Bot_Escuchar.Name = "Bot_Escuchar"
        Me.Bot_Escuchar.Size = New System.Drawing.Size(118, 21)
        Me.Bot_Escuchar.TabIndex = 22
        Me.Bot_Escuchar.Text = "Escuchar"
        Me.Bot_Escuchar.UseVisualStyleBackColor = True
        '
        'TePuerto
        '
        Me.TePuerto.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TePuerto.Location = New System.Drawing.Point(406, 64)
        Me.TePuerto.Name = "TePuerto"
        Me.TePuerto.Size = New System.Drawing.Size(93, 20)
        Me.TePuerto.TabIndex = 23
        '
        'TeIP
        '
        Me.TeIP.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.TeIP.Location = New System.Drawing.Point(158, 64)
        Me.TeIP.Name = "TeIP"
        Me.TeIP.Size = New System.Drawing.Size(242, 20)
        Me.TeIP.TabIndex = 24
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(403, 48)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(38, 13)
        Me.Label1.TabIndex = 25
        Me.Label1.Text = "Puerto"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(155, 48)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(46, 13)
        Me.Label2.TabIndex = 26
        Me.Label2.Text = "IP Local"
        '
        'FormComandos
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(635, 524)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TeIP)
        Me.Controls.Add(Me.TePuerto)
        Me.Controls.Add(Me.Bot_Escuchar)
        Me.Controls.Add(Me.Bot_Ejecutar)
        Me.Controls.Add(Me.T_Ejecutar)
        Me.Controls.Add(Me.B_CargarProcesos)
        Me.Controls.Add(Me.T_ID)
        Me.Controls.Add(Me.Bot_Env_Key)
        Me.Controls.Add(Me.T_Enviar)
        Me.Controls.Add(Me.GridProc)
        Me.Name = "FormComandos"
        Me.Text = "Comandos"
        CType(Me.GridProc, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridProc As DataGridView
    Friend WithEvents Bot_Env_Key As Button
    Friend WithEvents T_Enviar As TextBox
    Friend WithEvents T_ID As TextBox
    Friend WithEvents B_CargarProcesos As Button
    Friend WithEvents Id As DataGridViewTextBoxColumn
    Friend WithEvents Proceso As DataGridViewTextBoxColumn
    Friend WithEvents Nombre As DataGridViewTextBoxColumn
    Friend WithEvents T_Ejecutar As TextBox
    Friend WithEvents Bot_Ejecutar As Button
    Friend WithEvents Bot_Escuchar As Button
    Friend WithEvents TePuerto As TextBox
    Friend WithEvents TeIP As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
