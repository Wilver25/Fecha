Public Class Form1

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Fecha" ' nombre del formular que aparece en la parte superior
        cmbmes.Items.Add("Noviembre") 'aqui agregamos 2 items para saber como se hace a codigo
        cmbmes.Items.Add("Diciembre")
    End Sub

    Public Sub validacion() 'creamos un desarrollo a parte para la validacion
        If Not (cmbano.Text <> "Año") And Not (cmbdia.Text <> "Día") And Not (cmbmes.Text <> "Mes") Then
            'negamos la diferencia de cada combobox con el texto original
            'para  que la fecha no se muestre sola con el titulo del texto
            MsgBox("Error" & vbNewLine & "No a seleccionado ningun dato", MsgBoxStyle.Critical) 'mensaje de error

            'volvemos a poner el texto para que parezca que se a reiniciado
            cmbano.Text = "Año"
            cmbmes.Text = "Mes"
            cmbdia.Text = "Día"

            'por si un combobox no se cumple muestra otro mensaje
        ElseIf Not (cmbano.Text <> "Año") Or Not (cmbmes.Text <> "Mes") Or Not (cmbdia.Text <> "Día") Then

            'texto del mensaje
            MsgBox("Error" & vbNewLine & "Tiene que seleccionar un dato de cada lista", MsgBoxStyle.Critical)
            cmbano.Text = "Año"
            cmbmes.Text = "Mes"
            cmbdia.Text = "Día"
        End If
    End Sub


    Private Sub btnsalir_Click(sender As Object, e As EventArgs) Handles btnsalir.Click
        prueba.Show() 'llama a otro formulario
    End Sub

    Private Sub btnlimpiar_Click(sender As Object, e As EventArgs) Handles btnlimpiar.Click
        'reinicia todos los valores y limpia el textbox
        txtfecha.Clear()
        cmbano.Text = "Año"
        cmbmes.Text = "Mes"
        cmbdia.Text = "Día"
    End Sub

    Private Sub btnmostrar_Click(sender As Object, e As EventArgs) Handles btnmostrar.Click
        'variables utilizadas
        Dim dia, mes, año, fecha As String
        dia = cmbdia.Text
        año = cmbano.Text
        mes = cmbmes.Text

        Call validacion() 'llamada de la funcion validacion

        'select case para margen de error en el mes
        'en esta parte introduje los meses con nombre y no con numeros
        'entonces en este select case le damos a cada nombre el numeros que tiene para poder
        'mostrar mejor la fecha
        Select Case mes
            Case "Mes"
                mes = 0
            Case "Enero"
                mes = 1
            Case "Febrero"
                mes = 2
            Case "Marzo"
                mes = 3
            Case "Abril"
                mes = 4
            Case "Mayo"
                mes = 5
            Case "Junio"
                mes = 6
            Case "Julio"
                mes = 7
            Case "Agosto"
                mes = 8
            Case "Septiembre"
                mes = 9
            Case "Octubre"
                mes = 10
            Case "Noviembre"
                mes = 11
            Case "Diciembre"
                mes = 12
        End Select

        'En este select tomando los valores
        'damos la respuesta
        Select Case mes
            Case 0  'si el valor es cero limpia el txtbox
                txtfecha.Clear()
            Case 10 To 12 'si el valor esta entre octubre y diciembre

                'en este if usamos una negacion que si el usuario no seleccionaba
                'algun combobox no realizara la operacion hasta que todos los datos esten correctos
                If Not (año = "Año") Then
                    fecha = "" & año & "/" & mes & "/" & dia & ""
                    txtfecha.Text = fecha
                ElseIf Not (dia = "Día") Then
                    fecha = "" & año & "/" & mes & "/" & dia & ""
                    txtfecha.Text = fecha
                Else
                    txtfecha.Clear()
                End If
            Case 1 To 9

                'en este if es lo mismo que en el if anterior
                If Not (año = "Año") Then
                    fecha = "" & año & "/0" & mes & "/" & dia & ""
                    txtfecha.Text = fecha
                ElseIf Not (dia = "Día") Then
                    fecha = "" & año & "/0" & mes & "/" & dia & ""
                    txtfecha.Text = fecha
                Else
                    txtfecha.Clear()
                End If
        End Select

        'select case para margen de error en el año
        'se limpia todo y no se desarrolla hasta que se cumplan todos los requisitos
        Select Case año
            Case "Año"
                txtfecha.Clear()
        End Select

        'select case para margen de error en el dia
        'se limpia todo y no se desarrolla hasta que se cumplan todos los requisitos
        Select Case dia
            Case "Día"
                txtfecha.Clear()
        End Select
    End Sub

    Private Sub cmbmes_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbmes.SelectedIndexChanged
        'variables utilizadas
        Dim dia, mes, año As String
        Dim i, j As Integer
        dia = cmbdia.Text
        año = cmbano.Text
        mes = cmbmes.Text

        'en este if jugamos con los meses y lso dias
        'primero todos los meses que tengan 30 dias estan aqui el if principal
        'mediante un for para crear los items
        If (mes = "Enero") Or (mes = "Año") Or (mes = "Marzo") Or (mes = "Mayo") Or (mes = "julio") Or (mes = "Octubre") Or (mes = "Diciembre") Then
            cmbdia.Items.Clear()
            For i = 0 To 30
                j += 1
                cmbdia.Items.Add(j)
            Next

            'en esta parte ya que febrero es el unico con 28 dias mediante un for tambien
        ElseIf (mes = "Febrero") Then
            cmbdia.Items.Clear()
            For i = 0 To 27
                j += 1
                cmbdia.Items.Add(j)
            Next

            'en el else introducimos todos los meses que consta de 30 dias
            'utilizando un select case para su operacion y un for
        Else
            Select Case mes
                Case "Abril"
                    cmbdia.Items.Clear()
                    For i = 0 To 29
                        j += 1
                        cmbdia.Items.Add(j)
                    Next
                Case "Junio"
                    cmbdia.Items.Clear()
                    For i = 0 To 29
                        j += 1
                        cmbdia.Items.Add(j)
                    Next
                Case "Septiembre"
                    cmbdia.Items.Clear()
                    For i = 0 To 29
                        j += 1
                        cmbdia.Items.Add(j)
                    Next
                Case "Noviembre"
                    cmbdia.Items.Clear()
                    For i = 0 To 29
                        j += 1
                        cmbdia.Items.Add(j)
                    Next
            End Select
        End If
    End Sub

    Private Sub cmbano_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbano.SelectedIndexChanged
        'variables utilizadas
        Dim dia, mes, año As String
        Dim i, j As Integer
        dia = cmbdia.Text
        año = cmbano.Text
        mes = cmbmes.Text

        'En esta parte utilizamos otro if-else
        'con la diferencia que este if representa a los años bisiestos
        If (año = "1992") Or (año = "1996") Or (año = "2000") Or (año = "2004") Or (año = "2008") Or (año = "2012") Or (año = "2016") Or (año = "2020") Then

            'select case para el mes de febrero que consta de 29 dias para el año bisiesto
            Select Case mes
                Case "Febrero"
                    cmbdia.Items.Clear()
                    For i = 0 To 28
                        j += 1
                        cmbdia.Items.Add(j)
                    Next
            End Select

            'parte del else
        Else

            'select case para años normales
            'se volvio a poner este codigo porque sino febrero quedaria como 29 dias  para todos los años depsues
            'por esta razon se volvio a reproducir el código
            Select Case mes
                Case "Febrero"
                    cmbdia.Items.Clear()
                    For i = 0 To 27
                        j += 1
                        cmbdia.Items.Add(j)
                    Next
            End Select
        End If
    End Sub
End Class

REM NOTA: 1- Cada mes tiene los dias exacto de acuerdo al calendario
'         2- En los años bisiestos estan: 1992, 1996, 2000, 2004, 2008, 2012, 2016 y 2020
'         3- Para poder el dia 29 de febrero del año bisiesto seleccione una fecha bisiesta
'               con la diferencia que en el primer intento no saldrá debido a que toma el primer valor del if febrero
'               asi que en la segunda ocasion podrá visualizar el dia 29 de febrero.