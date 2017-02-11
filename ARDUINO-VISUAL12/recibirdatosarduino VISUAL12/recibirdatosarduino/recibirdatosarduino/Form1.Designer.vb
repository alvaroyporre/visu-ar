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
        Me.components = New System.ComponentModel.Container()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.spPuertos = New System.IO.Ports.SerialPort(Me.components)
        Me.tmrtimer = New System.Windows.Forms.Timer(Me.components)
        Me.btnconectar = New System.Windows.Forms.Button()
        Me.btnEnviarDato = New System.Windows.Forms.Button()
        Me.Timer5 = New System.Windows.Forms.Timer(Me.components)
        Me.txtBufferIn = New System.Windows.Forms.TextBox()
        Me.cbopuertos = New System.Windows.Forms.ComboBox()
        Me.txtBufferOut = New System.Windows.Forms.TextBox()
        Me.btnInicio = New System.Windows.Forms.Button()
        Me.btnApagar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(89, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(270, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "VOLTÍMETRO"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(8, 62)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(130, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "SELECCIONAR PUERTO"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(378, 267)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(51, 20)
        Me.Button1.TabIndex = 5
        Me.Button1.Text = "EXIT"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'spPuertos
        '
        Me.spPuertos.PortName = "COM3"
        '
        'tmrtimer
        '
        Me.tmrtimer.Interval = 1000
        '
        'btnconectar
        '
        Me.btnconectar.Location = New System.Drawing.Point(11, 99)
        Me.btnconectar.Name = "btnconectar"
        Me.btnconectar.Size = New System.Drawing.Size(129, 22)
        Me.btnconectar.TabIndex = 6
        Me.btnconectar.Text = "CONECTAR"
        Me.btnconectar.UseVisualStyleBackColor = True
        '
        'btnEnviarDato
        '
        Me.btnEnviarDato.Location = New System.Drawing.Point(12, 152)
        Me.btnEnviarDato.Name = "btnEnviarDato"
        Me.btnEnviarDato.Size = New System.Drawing.Size(128, 20)
        Me.btnEnviarDato.TabIndex = 7
        Me.btnEnviarDato.Text = "ENVIAR DATO"
        Me.btnEnviarDato.UseVisualStyleBackColor = True
        '
        'Timer5
        '
        Me.Timer5.Interval = 1000
        '
        'txtBufferIn
        '
        Me.txtBufferIn.Location = New System.Drawing.Point(146, 102)
        Me.txtBufferIn.Name = "txtBufferIn"
        Me.txtBufferIn.Size = New System.Drawing.Size(486, 20)
        Me.txtBufferIn.TabIndex = 8
        '
        'cbopuertos
        '
        Me.cbopuertos.FormattingEnabled = True
        Me.cbopuertos.Location = New System.Drawing.Point(146, 62)
        Me.cbopuertos.Name = "cbopuertos"
        Me.cbopuertos.Size = New System.Drawing.Size(486, 21)
        Me.cbopuertos.TabIndex = 9
        Me.cbopuertos.Text = "COM3"
        '
        'txtBufferOut
        '
        Me.txtBufferOut.Location = New System.Drawing.Point(146, 155)
        Me.txtBufferOut.Name = "txtBufferOut"
        Me.txtBufferOut.Size = New System.Drawing.Size(485, 20)
        Me.txtBufferOut.TabIndex = 10
        '
        'btnInicio
        '
        Me.btnInicio.Location = New System.Drawing.Point(12, 198)
        Me.btnInicio.Name = "btnInicio"
        Me.btnInicio.Size = New System.Drawing.Size(128, 31)
        Me.btnInicio.TabIndex = 11
        Me.btnInicio.Text = "INICIO"
        Me.btnInicio.UseVisualStyleBackColor = True
        '
        'btnApagar
        '
        Me.btnApagar.Location = New System.Drawing.Point(205, 261)
        Me.btnApagar.Name = "btnApagar"
        Me.btnApagar.Size = New System.Drawing.Size(101, 26)
        Me.btnApagar.TabIndex = 12
        Me.btnApagar.Text = "APAGAR"
        Me.btnApagar.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(637, 158)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 20)
        Me.Label3.TabIndex = 13
        Me.Label3.Text = "txtBufferOut"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label4.Location = New System.Drawing.Point(638, 100)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(84, 20)
        Me.Label4.TabIndex = 14
        Me.Label4.Text = "txtBufferIn"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(128, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.Label5.Location = New System.Drawing.Point(638, 58)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(90, 20)
        Me.Label5.TabIndex = 15
        Me.Label5.Text = "cboPuertos"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 304)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.btnApagar)
        Me.Controls.Add(Me.btnInicio)
        Me.Controls.Add(Me.txtBufferOut)
        Me.Controls.Add(Me.cbopuertos)
        Me.Controls.Add(Me.txtBufferIn)
        Me.Controls.Add(Me.btnEnviarDato)
        Me.Controls.Add(Me.btnconectar)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents spPuertos As System.IO.Ports.SerialPort
    Friend WithEvents tmrtimer As System.Windows.Forms.Timer
    Friend WithEvents btnconectar As System.Windows.Forms.Button
    Friend WithEvents btnEnviarDato As System.Windows.Forms.Button
    Friend WithEvents Timer5 As System.Windows.Forms.Timer
    Friend WithEvents txtBufferIn As System.Windows.Forms.TextBox
    Friend WithEvents cbopuertos As System.Windows.Forms.ComboBox
    Friend WithEvents txtBufferOut As System.Windows.Forms.TextBox
    Friend WithEvents btnInicio As System.Windows.Forms.Button
    Friend WithEvents btnApagar As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label

End Class
