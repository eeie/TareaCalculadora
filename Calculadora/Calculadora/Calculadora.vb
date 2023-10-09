Public Class Calculadora
    Dim num1 As Double
    Dim num2 As Double
    Dim operacion As String
    Dim resultado As Double

    Private Sub btnNumero_Click(sender As Object, e As EventArgs) Handles btn0.Click, btn1.Click, btn2.Click, btn3.Click, btn4.Click, btn5.Click, btn6.Click, btn7.Click, btn8.Click, btn9.Click
        Dim btn As Button = DirectCast(sender, Button)
        txtPantalla.Text &= btn.Text
        'Mostramos en el txtPantalla los numeros que se digiten 
    End Sub

    Private Sub btnPunto_Click(sender As Object, e As EventArgs) Handles btnPunto.Click
        If Not txtPantalla.Text.Contains(".") Then
            txtPantalla.Text &= "."
        End If
        'utilizamos este metodo para poder digitar numeros con decimales 
    End Sub

    Private Sub btnCalcular_Click(sender As Object, e As EventArgs) Handles btnCalcular.Click
        Dim cadena = txtPantalla.Text.Trim()
        Dim elementosCadena() As String = cadena.Split(New Char() {" "}, StringSplitOptions.RemoveEmptyEntries)

        If elementosCadena.Length = 3 Then
            num1 = Val(elementosCadena(0))
            operacion = elementosCadena(1)
            num2 = Val(elementosCadena(2))
            realizarOperacion()
            MsgBox("El resultado de la operacion " + txtPantalla.Text + " es de: " + CStr(resultado))
        End If
        'este proceso se encarga de verificar si la ecuacion ingresada es valida, verificando que en el array hayan 3 valores; los 2 numeros y el operador matematico 
    End Sub

    Private Sub btnSuma_Click(sender As Object, e As EventArgs) Handles btnSuma.Click
        num1 = Val(txtPantalla.Text)
        txtPantalla.Text &= " + "
        operacion = "+"
    End Sub

    Private Sub btnResta_Click(sender As Object, e As EventArgs) Handles btnResta.Click
        num1 = Val(txtPantalla.Text)
        txtPantalla.Text &= " - "
        operacion = "-"
    End Sub

    Private Sub btnMultiplicacion_Click(sender As Object, e As EventArgs) Handles btnMultiplicacion.Click
        num1 = Val(txtPantalla.Text)
        txtPantalla.Text &= " x "
        operacion = "*"
    End Sub

    Private Sub btnDivision_Click(sender As Object, e As EventArgs) Handles btnDivision.Click
        num1 = Val(txtPantalla.Text)
        txtPantalla.Text &= " ÷ "
        operacion = "/"
    End Sub
    'en los procesos anteriores, se encarga de realizar las operaciones matematicas, cuando el usuario ingresa el operador, este lo reconoce y lo sustituye por un operador valido que pueda ejecutar el algoritmo

    Private Sub btnElevado_Click(sender As Object, e As EventArgs) Handles btnElevado.Click
        num1 = Val(txtPantalla.Text)
        txtPantalla.Text = (num1 * num1).ToString()
    End Sub

    Private Sub btnBorrarTodo_Click(sender As Object, e As EventArgs) Handles btnBorrarTodo.Click
        txtPantalla.Clear()
    End Sub
    'en los procesos anteriores, se encarga de realizar las operaciones matematicas, cuando el usuario ingresa el operador, este lo reconoce y lo sustituye por un operador valido que pueda ejecutar el algoritmo

    Private Sub btnBorrarDigito_Click(sender As Object, e As EventArgs) Handles btnBorrarDigito.Click
        If txtPantalla.Text.Length > 0 Then
            txtPantalla.Text = txtPantalla.Text.Substring(0, txtPantalla.Text.Length - 1)
        End If
        'este proceso funciona para borrar un digito a la vez y no limpiar por completo el txtPantalla
    End Sub

    Private Sub realizarOperacion()
        Select Case operacion
            Case "+"
                resultado = num1 + num2

            Case "-"
                resultado = num1 - num2

            Case "x"
                resultado = num1 * num2

            Case "÷"
                If num2 <> 0 Then
                    resultado = num1 / num2
                Else
                    MsgBox("Error: No se puede dividir por cero.")

                End If

        End Select
        'ingresamos los operadores que contiene la parte grafica de la calculdora, y los sustituimos por los operadores validos en la parte logica
    End Sub

    Private Sub btnMinimizar_Click(sender As Object, e As EventArgs) Handles btnMinimizar.Click
        Me.WindowState = FormWindowState.Minimized
    End Sub

    Private Sub btnCerrar_Click(sender As Object, e As EventArgs) Handles btnCerrar.Click
        Me.Close()
    End Sub
End Class

