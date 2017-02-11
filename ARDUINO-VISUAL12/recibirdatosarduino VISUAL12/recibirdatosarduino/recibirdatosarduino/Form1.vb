Public Class Form1

    Dim strBufferOut As String
    Dim strBufferIn As String
    Dim temp As Integer




    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Close()
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        strBufferOut = ""
        strBufferIn = ""
        'btnconectar.Enabled = False
        'btnEnviarDato.Enabled = False
        tmrtimer.Enabled = False
        Timer5.Start()
    End Sub

    Private Sub Tmrtimer_Tick(sender As Object, e As EventArgs) Handles tmrtimer.Tick
        strBufferIn = spPuertos.ReadExisting


        If strBufferIn <> "" Then
            txtBufferIn.Text = strBufferIn
            strBufferIn = ""
            spPuertos.DiscardInBuffer()
        End If




    End Sub

    Private Sub btnconectar_Click(sender As Object, e As EventArgs) Handles btnconectar.Click
        If btnconectar.Text = "CONECTAR" Then
            spPuertos.PortName = cbopuertos.text
            btnconectar.Text = "DESCONECTAR"
            btnEnviarDato.Enabled = True
            tmrtimer.Enabled = True
            spPuertos.Open()
        ElseIf btnconectar.Text = "DESCONECTAR" Then
            btnconectar.Text = "CONECTAR"
            btnEnviarDato.Enabled = False
            tmrtimer.Enabled = False
            spPuertos.Close()
        End If
    End Sub

    Private Sub btnenviarDato_Click(sender As Object, e As EventArgs) Handles btnEnviarDato.Click
        spPuertos.DiscardOutBuffer()
        strBufferOut = txtBufferOut.text
        spPuertos.Write(strBufferOut)
    End Sub


    Private Sub btnApagar_Click(sender As Object, e As EventArgs) Handles btnApagar.Click
        spPuertos.DiscardOutBuffer()
        strBufferOut = "a"
        spPuertos.Write(strBufferOut)

    End Sub
End Class
