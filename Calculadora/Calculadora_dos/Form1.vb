Public Class Form1
    'VARIABLES QUE SE UTILIZAN PARA EL CORRECTO FUNCIONAMIENTO DE LA CALCULADORA.
    Dim operador1 As Double
    Dim operador2 As Double
    Dim operando As Char
    Dim total As Double
    Dim contador As Integer = 0
    Dim contadorSuma As Integer = 0
    Dim contadorResta As Integer = 0
    Dim contadorMulti As Integer = 0
    Dim contadorDiv As Integer = 0
    Dim boleano As Boolean = False

    'MODULO: BOTONES DE NUMEROS'
    Private Sub btn0_Click(sender As Object, e As EventArgs) Handles btn0.Click

        'Cofiguramos 0 para que funcione igual que la calculadora original de Windows
        'Si el display contiene una coma, el cero se va a ingresar, 
        'Si el display contiene un valor diferente de 0, el cero se va a ingresar,
        'Si el display tiene el valor 0, no se va a ingresar 
        If txtdisplay.Text.Contains(",") Or txtdisplay.Text <> "0" Then
            txtdisplay.Text &= "0"
        Else

        End If
    End Sub

    Private Sub btn1_Click(sender As Object, e As EventArgs) Handles btn1.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 1

    End Sub

    Private Sub btn2_Click(sender As Object, e As EventArgs) Handles btn2.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 2
    End Sub

    Private Sub btn3_Click(sender As Object, e As EventArgs) Handles btn3.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 3
    End Sub

    Private Sub btn4_Click(sender As Object, e As EventArgs) Handles btn4.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 4
    End Sub

    Private Sub btn5_Click(sender As Object, e As EventArgs) Handles btn5.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 5
    End Sub

    Private Sub btn6_Click(sender As Object, e As EventArgs) Handles btn6.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 6
    End Sub

    Private Sub btn7_Click(sender As Object, e As EventArgs) Handles btn7.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 7
    End Sub

    Private Sub btn8_Click(sender As Object, e As EventArgs) Handles btn8.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 8
    End Sub

    Private Sub btn9_Click(sender As Object, e As EventArgs) Handles btn9.Click
        inicio()
        txtdisplay.Text = txtdisplay.Text & 9
    End Sub
    'FIN DE MODULO: BOTONES DE NUMEROS'

    'MODULO: BOTONES DE OPERANDO'
    Private Sub Button16_Click(sender As Object, e As EventArgs) Handles Button16.Click
        txtdisplay.Text = "0"
    End Sub
    Private Sub btnrestar_Click(sender As Object, e As EventArgs) Handles btnrestar.Click
        'Los botones, restar, sumar, dividir y multiplicar buscan que no se haya tocado antes el boton
        'Si el contador del boton resta o cualquiera de los otros fuese tocado, se espera el proximo valor para seguir
        'Y lograr el calculo en cadena EJEMPLO 1-2-3
        operando = "-"
        If txtdisplay.Text IsNot "" And contadorResta = 0 Then
            operador1 = CDbl(txtdisplay.Text)
            lblmuestra.Text = CStr(operador1)
            lblmuestra.Text = lblmuestra.Text & "-"
            txtdisplay.Clear()
        Else
            operador1 -= CDbl(txtdisplay.Text)
            lblmuestra.Text = CStr(operador1) & "-"
            txtdisplay.Clear()
        End If

        contadorResta += 1
    End Sub

    Private Sub btnsumar_Click(sender As Object, e As EventArgs) Handles btnsumar.Click
        operando = "+"
        If txtdisplay.Text IsNot "" And contadorSuma = 0 Then
            operador1 = CDbl(txtdisplay.Text)
            lblmuestra.Text = CStr(operador1)
            lblmuestra.Text = lblmuestra.Text & "+"
            txtdisplay.Clear()
        Else
            operador1 += CDbl(txtdisplay.Text)
            lblmuestra.Text = CStr(operador1) & "+"
            txtdisplay.Clear()
        End If
        contadorSuma += 1
    End Sub

    Private Sub btnmultiplicar_Click(sender As Object, e As EventArgs) Handles btnmultiplicar.Click
        operando = "*"

        If txtdisplay.Text IsNot "" And contadorMulti = 0 Then
            operador1 = CDbl(txtdisplay.Text)
            lblmuestra.Text = CStr(operador1)
            lblmuestra.Text = lblmuestra.Text & "*"
            txtdisplay.Clear()
        Else
            operador1 *= CDbl(txtdisplay.Text)
            lblmuestra.Text = CStr(operador1) & "*"
            txtdisplay.Clear()

        End If

        contadorMulti += 1


    End Sub

    Private Sub btndividir_Click(sender As Object, e As EventArgs) Handles btndividir.Click
        operando = "/"
        If txtdisplay.Text IsNot "" And contadorDiv = 0 Then
            operador1 = CDbl(txtdisplay.Text)
            lblmuestra.Text = CStr(operador1)
            lblmuestra.Text = lblmuestra.Text & "/"
            txtdisplay.Clear()
        Else
            operador1 /= CDbl(txtdisplay.Text)
            lblmuestra.Text = CStr(operador1) & "/"
            txtdisplay.Clear()
        End If
        contadorDiv += 1
    End Sub

    Public Sub operacion()
        'Se utilizaa para guardar en la variable total, la suma, resta, multiplicacion o division
        'De los numeros que contenga operador1 y operador2.
        Select Case operando
            Case "+"
                total = operador1 + operador2
            Case "-"
                total = operador1 - operador2
            Case "*"
                total = operador1 * operador2
            Case "/"
                total = operador1 / operador2
        End Select
    End Sub

    Private Sub btnigual_Click(sender As Object, e As EventArgs) Handles btnigual.Click
        'Dentro de este boton la calculadora ejecuta los calculos que nosotros queremos realizar,
        'Haciendo uso del metodo "OPERACION()" para identificar cual es el operando y asi mostrar el resultado
        'De la cuenta a realizar.

        If contador = 0 Then
            operador2 = txtdisplay.Text
            lblmuestra.Text &= CStr(operador2)
            txtdisplay.Text = "0"

            operacion()
        Else
            lblmuestra.Text = total & operando & operador2

            Select Case operando
                Case "+"
                    total += operador2

                Case "-"
                    total -= operador2
                Case "*"
                    total *= operador2
                Case "/"
                    total /= operador2

            End Select
        End If

        txtdisplay.Text = CStr(total)



        contador += 1

    End Sub
    Private Sub inicio()
        'Este metodo setea el display al valor que se le concatena ejemplo: 
        'Si ingresamos el numero 1, el valor en el display quita el 0 inicial y le agrega 1.
        If txtdisplay.Text = "0" Then
            txtdisplay.Text = ""
        End If
    End Sub


    Private Sub btnborrartodo_Click(sender As Object, e As EventArgs) Handles btnborrartodo.Click
        'Setea los valores de las variables utilizadas en el programa a 0 o nothing en el caso de operador1, 2 y total.
        txtdisplay.Text = "0"
        lblmuestra.Text = ""
        operador1 = Nothing
        operador2 = Nothing
        operando = ""
        total = Nothing
        contador = 0
        contadorSuma = 0
        contadorResta = 0
        contadorMulti = 0
        contadorDiv = 0
    End Sub

    Private Sub btnComa_Click(sender As Object, e As EventArgs) Handles btnComa.Click
        'Busca si dentro del display hay una coma, si existe, entonces no deja ingresarla nuevamente.
        If txtdisplay.Text.Contains(",") Then
            Beep()
        Else
            txtdisplay.Text &= ","
        End If
    End Sub


    'Controladores de las opciones de Musica y reloj de la calculadora.
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'Ejecutar lo siguiente bien se ejecute el formulario'
        Player.Ctlcontrols.stop()
        lblHora.Text = TimeString()
    End Sub

    'MODULO: REPRODUCTOR'
    Private Sub btnStop_Click(sender As Object, e As EventArgs) Handles btnStop.Click
        Player.Ctlcontrols.stop()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Player.Ctlcontrols.play()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Player.Ctlcontrols.pause()
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        lblHora.Text = TimeString()
    End Sub

    Private Sub txtdisplay_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtdisplay.KeyPress
        If Not Char.IsNumber(e.KeyChar) AndAlso Not Char.IsControl(e.KeyChar) Then
            e.Handled = True
        End If
    End Sub

    Private Sub btnporcentaje_Click(sender As Object, e As EventArgs) Handles btnporcentaje.Click

        operador2 = CDbl(txtdisplay.Text)
        total = operador1 * (operador2 / 100)
        txtdisplay.Text = CStr(total)
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        txtdisplay.Text = CStr(CDbl(txtdisplay.Text) * -1)
    End Sub

    Private Sub btnCos_Click(sender As Object, e As EventArgs) Handles btnCos.Click
        If txtdisplay.Text IsNot "" Then
            operador1 = CDbl(txtdisplay.Text)

            If boleano = False Then
                lblmuestra.Text = "cosr(" & CStr(operador1) & ")"
                txtdisplay.Text = Math.Cos(operador1)
            Else
                lblmuestra.Text = "acosr(" & CStr(operador1) & ")"
                txtdisplay.Text = Math.Acos(operador1)
            End If

        End If
    End Sub

    'Calcular Seno, Coseno y Tangente y su inverso
    Private Sub btnSEN_Click(sender As Object, e As EventArgs) Handles btnSEN.Click
        If txtdisplay.Text IsNot "" Then
            operador1 = CDbl(txtdisplay.Text)
            If boleano = False Then
                lblmuestra.Text = "sinr(" & CStr(operador1) & ")"
                txtdisplay.Text = Math.Sin(operador1)
            Else
                lblmuestra.Text = "Asinr(" & CStr(operador1) & ")"
                txtdisplay.Text = Math.Asin(operador1)
            End If

        End If
    End Sub

    Private Sub btnTAN_Click(sender As Object, e As EventArgs) Handles btnTAN.Click
        If txtdisplay.Text IsNot "" Then
            operador1 = CDbl(txtdisplay.Text)

            If boleano = False Then
                lblmuestra.Text = "tanr(" & CStr(operador1) & ")"
                txtdisplay.Text = Math.Tan(operador1)
            Else
                lblmuestra.Text = "atanr(" & CStr(operador1) & ")"
                txtdisplay.Text = Math.Atan(operador1)
            End If
        End If
    End Sub

    Private Sub btnINV_Click(sender As Object, e As EventArgs) Handles btnINV.Click
        'Este boton maneja la variable boleano haciendo que los botones de sin, cos y tan 
        'Cambien de nombre a ASin, Acos, Atan.
        boleano = Not boleano

        If boleano Then
            btnSEN.Text = "ASIN"
            btnCos.Text = "ACOS"
            btnTAN.Text = "ATAN"
            boleano = boleano
        Else
            btnSEN.Text = "SIN"
            btnCos.Text = "COS"
            btnTAN.Text = "TAN"
        End If
    End Sub

    'CREADORES: 
    'ALUMNO: CEFERINO ARBURUA
    'ALUMNA: SASHA FERNANDEZ

End Class
