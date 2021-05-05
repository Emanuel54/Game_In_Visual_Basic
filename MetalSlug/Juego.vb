Public Class Juego

    Private posicionX As Integer
    Private posicionY As Integer


    Dim cayendo As Boolean = False
    Private derechaContador As Byte = 1
    Private izquierdaContador As Byte = 1
    Private saltoContador As Byte = 1
    Private agachoContador As Byte = 1
    Private movimiento As Byte
    Dim contador As Byte = 1
    Dim contadorIzquierda As Byte = 1
    Private movimientoEnemigo As Byte = 1
    Private velocidadEnemigo As Integer
    Dim tiempo As Byte
    ' Dim prueba2 As New PictureBox
    '  Private movimientoEnemigo As Integer
    Dim posicionXEnemigo As Integer = 521
    Dim posicionYEnemigo As Integer = 128

    Dim posicionXEnemigo1 As Integer = 571
    Dim posicionYEnemigo1 As Integer = 128

    Dim posicionXEnemigo2 As Integer = 621
    Dim posicionYEnemigo2 As Integer = 128

    Dim posicionXEnemigo3 As Integer = 671
    Dim posicionYEnemigo3 As Integer = 128

    Dim posicionXEnemigo4 As Integer = 721
    Dim posicionYEnemigo4 As Integer = 128

    Dim posicionXEnemigo5 As Integer = 771
    Dim posicionYEnemigo5 As Integer = 128

    Dim posicionXEnemigo6 As Integer = 821
    Dim posicionYEnemigo6 As Integer = 128

    Dim posicionXEnemigoIzquierda As Integer = 0
    Dim posicionYEnemigoIzquierda As Integer = 128


    Dim posicionXEnemigoIzquierda1 As Integer = 0
    Dim posicionYEnemigoIzquierda1 As Integer = 128

    Dim posicionXEnemigoIzquierda2 As Integer = 0
    Dim posicionYEnemigoIzquierda2 As Integer = 128

    Dim posicionXEnemigoIzquierda3 As Integer = 0
    Dim posicionYEnemigoIzquierda3 As Integer = 128

    Dim posicionXEnemigoIzquierda4 As Integer = 0
    Dim posicionYEnemigoIzquierda4 As Integer = 128


    Dim posicionXEnemigoIzquierda5 As Integer = 0
    Dim posicionYEnemigoIzquierda5 As Integer = 128


    Dim posicionXEnemigoIzquierda6 As Integer = -24
    Dim posicionYEnemigoIzquierda6 As Integer = 128


    Dim posicionXEnemigoCayendo As Integer = 374
    Dim posicionYEnemigoCayendo As Integer = 3

    Dim posicionXEnemigoCayendoIzquierda As Integer = 200
    Dim posicionYEnemigoCayendoIzquierda As Integer = 3


    Dim posicionXEnemigoCayendoIzquierda2 As Integer = 129
    Dim posicionYEnemigoCayendoIzquierda2 As Integer = 3


    Dim posicionXEnemigoCayendoIzquierda3 As Integer = 55
    Dim posicionYEnemigoCayendoIzquierda3 As Integer = 3



    Dim contadorCayendo As Byte = 1

    Private velocidadPersonaje As Byte
    Private velocidadDisparo As Byte

    Private velocidadPersonajeIzquierda As Byte
    Private velocidadDisparoIzquierda As Byte
    '   Dim enemigo As New PictureBox


    ' Private enemigosCantidad = 10
    'Private enemigos(enemigosCantidad) As PictureBox

    '  Dim i As Integer





    Private Sub Juego_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        posicionX = 243
        posicionY = 128
        tiempo = 40
        Label1.Text = tiempo
        '  posicionXEnemigo = 529
        ' posicionYEnemigo = 130
        personajePrincipal.Location = New Point(posicionX, posicionY)

        ' enemigo.Location = New Point(posicionXEnemigo, posicionYEnemigo)

        timerDuracion.Enabled = True
        timerEnemigo.Enabled = True
        '    timerEnemigo.Interval = 100


        timerEnemigo.Start()
        timerEnemigoIzquierda.Start()
        timerCayendo.Start()
        ' timerPersonaje.Enabled = True
        timerBala.Start()
        Timer1.Start()
        CargarBala()
        CargarBalaIzquierda()


        My.Computer.Audio.Play(My.Resources.Metal_slug_misión_2_música_de_fondo, AudioPlayMode.Background)


    End Sub



    Private Sub Juego_KeyDown(sender As Object, e As KeyEventArgs) Handles Me.KeyDown
        If e.KeyCode = Keys.Right Then
            movimiento = 1
            timerPersonaje.Start()
        End If

        If e.KeyCode = Keys.Left Then
            movimiento = 2
            timerPersonaje.Start()
        End If

        If e.KeyCode = Keys.Up Then
            movimiento = 3
            'timerPersonaje.Start()
            timerSalto.Start()
        End If


        If e.KeyCode = Keys.Down Then
            movimiento = 4
            ' timerPersonaje.Start()
            timerAgacho.Start()
        End If


        If e.KeyCode = Keys.KeyCode And balaPic.Visible = False Then
            movimiento = 5
        End If

        If movimiento = 1 And e.KeyCode = Keys.Space And balaPic.Visible = False Then
            movimiento = 5

            timerPersonaje.Start()

            balaPic.Left = personajePrincipal.Left + 70 + (personajePrincipal.Width / 2) - (personajePrincipal.Height / 2)
            balaPic.Top = personajePrincipal.Top + (personajePrincipal.Height - personajePrincipal.Width) / 2


            '      balaPic.Left += personajePrincipal.Left
            balaPic.Visible = True
            '     balaPic.Left = personajePrincipal.Left + (personajePrincipal.Width / 2) - (personajePrincipal.Width / 2)
            '   timerBala.Start()



        End If




        If movimiento = 2 And e.KeyCode = Keys.Space Then
            movimiento = 6
            timerPersonaje.Start()

            balaIzquierda.Left = personajePrincipal.Left - 30 + (personajePrincipal.Width / 2) - (personajePrincipal.Height / 2)
            balaIzquierda.Top = personajePrincipal.Top + (personajePrincipal.Height - personajePrincipal.Width) / 2

            balaIzquierda.Visible = True
        End If





    End Sub

    Private Sub timerPersonaje_Tick(sender As Object, e As EventArgs) Handles timerPersonaje.Tick
        If movimiento = 1 Then
            posicionX = posicionX + 15
            Select Case derechaContador
                Case 1
                    personajePrincipal.Image = My.Resources.Corre1
                    derechaContador += 1
                Case 2
                    personajePrincipal.Image = My.Resources.Corre2
                    derechaContador += 1
                Case 3
                    personajePrincipal.Image = My.Resources.Corre3
                    derechaContador += 1
                Case 4
                    personajePrincipal.Image = My.Resources.Corre4
                    derechaContador += 1
                Case 5
                    personajePrincipal.Image = My.Resources.Corre5
                    derechaContador += 1
                Case 6
                    personajePrincipal.Image = My.Resources.Corre6
                    derechaContador += 1
                Case 7
                    personajePrincipal.Image = My.Resources.Corre7
                    derechaContador += 1
                Case 8
                    personajePrincipal.Image = My.Resources.Corre8
                    derechaContador += 1
                Case 9
                    personajePrincipal.Image = My.Resources.Corre9
                    derechaContador = 1
            End Select
            timerPersonaje.Stop()




        End If




        If personajePrincipal.Bounds.IntersectsWith(bordeDerecha.Bounds) Then
            'personajePrincipal.Dispose()
            posicionX = 3

            personajePrincipal.Location = New Point(posicionX, posicionY)

            ' MsgBox("choque")
            movimiento = 1

        End If



        If movimiento = 2 Then
            posicionX = posicionX - 15

            Select Case izquierdaContador
                Case 1
                    personajePrincipal.Image = My.Resources.Izquierda1
                    izquierdaContador += 1
                Case 2
                    personajePrincipal.Image = My.Resources.Izquierda2
                    izquierdaContador += 1
                Case 3
                    personajePrincipal.Image = My.Resources.Izquierda31
                    izquierdaContador += 1                    '
                Case 4
                    personajePrincipal.Image = My.Resources.Izquierda4
                    izquierdaContador += 1
                Case 5
                    personajePrincipal.Image = My.Resources.Izquierda5
                    izquierdaContador += 1
                Case 6
                    personajePrincipal.Image = My.Resources.Izquierda6
                    izquierdaContador += 1
                Case 7
                    personajePrincipal.Image = My.Resources.Izquierda7
                    izquierdaContador += 1
                Case 8
                    personajePrincipal.Image = My.Resources.Izquierda81
                    izquierdaContador += 1
                Case 9
                    personajePrincipal.Image = My.Resources.Izquierda9
                    izquierdaContador += 1
                Case 10
                    personajePrincipal.Image = My.Resources.Izquierda10
                    izquierdaContador = 1

            End Select
            timerPersonaje.Stop()
        End If

        If personajePrincipal.Bounds.IntersectsWith(bordeIzquieda.Bounds) Then
            posicionX = 521
            personajePrincipal.Location = New Point(posicionX, posicionY)
            movimiento = 2
        End If






        If movimiento = 5 Then
            personajePrincipal.Image = My.Resources.Disparo
            My.Computer.Audio.Play(My.Resources.Disparo1, AudioPlayMode.Background)
            ' personajePrincipal.Image = My.Resources.Corre1
            ' DispararBala()
            '      timerPersonaje.Stop()
            timerPersonaje.Stop()
        End If


        If movimiento = 6 Then
            personajePrincipal.Image = My.Resources.DisparoIzquierda
            My.Computer.Audio.Play(My.Resources.Disparo1, AudioPlayMode.Background)
            timerPersonaje.Stop()
        End If

        personajePrincipal.SetBounds(posicionX, posicionY, personajePrincipal.Width, personajePrincipal.Height)
    End Sub

    Private Sub timerSalto_Tick(sender As Object, e As EventArgs) Handles timerSalto.Tick
        If movimiento = 3 Then

            personajePrincipal.Image = My.Resources.Corre2

            Select Case saltoContador

                Case 1
                    personajePrincipal.Image = My.Resources.Corre3
                    saltoContador += 1
                Case 2
                    personajePrincipal.Image = My.Resources.Salto1
                    saltoContador += 1
                    'posicionY = posicionY - 15
                Case 3
                    personajePrincipal.Image = My.Resources.Salto2
                    saltoContador += 1
                    'posicionY = posicionY + 2
                Case 4
                    personajePrincipal.Image = My.Resources.Salto3
                    saltoContador += 1
                   ' posicionY = posicionY + 2
                Case 5
                    personajePrincipal.Image = My.Resources.Salto4
                    saltoContador += 1
                    'posicionY = posicionY + 2
                Case 6
                    personajePrincipal.Image = My.Resources.Salto5
                    saltoContador += 1
                    'posicionY = posicionY + 2
                Case 7
                    personajePrincipal.Image = My.Resources.Salto6
                    saltoContador = 1

                    personajePrincipal.Image = My.Resources.Corre1
                    timerSalto.Stop()
                    'posicionY = posicionY + 2

            End Select


            '      personajePrincipal.SetBounds(posicionX, posicionY, personajePrincipal.Width, personajePrincipal.Height)
        End If

    End Sub

    Private Sub timerAgacho_Tick(sender As Object, e As EventArgs) Handles timerAgacho.Tick
        If movimiento = 4 Then
            personajePrincipal.Image = My.Resources.Corre1

            Select Case agachoContador
                Case 1
                    personajePrincipal.Image = My.Resources.Agacho1
                    agachoContador += 1
                Case 2
                    personajePrincipal.Image = My.Resources.Agacho2
                    agachoContador += 1
                Case 3
                    personajePrincipal.Image = My.Resources.Agacho3
                    agachoContador = 1
                    timerAgacho.Stop()
            End Select
        End If
    End Sub

    Private Sub timerEnemigo_Tick(sender As Object, e As EventArgs) Handles timerEnemigo.Tick






        MoverEnemigo()

        MoverEnemigo1()

        MoverEnemigo2()

        MoverEnemigo5()
        MoverEnemigo6()

        For Each ctrlEnemigo In Me.Controls
            If TypeOf ctrlEnemigo Is PictureBox AndAlso ctrlEnemigo.Name = "Enemigo" Then
                If ctrlEnemigo.Bounds.IntersectsWith(balaPic.Bounds) And balaPic.Visible = True Then
                    ctrlEnemigo.Dispose()
                    Me.Controls.Remove(ctrlEnemigo)
                    balaPic.Visible = False
                End If

                If ctrlEnemigo.Bounds.IntersectsWith(personajePrincipal.Bounds) Then
                    '  MsgBox("Perdiste")
                    Me.Controls.Remove(personajePrincipal)
                    personajePrincipal.Dispose()
                    My.Computer.Audio.Play(My.Resources._113_game_over, AudioPlayMode.Background)
                    timerPersonaje.Stop()
                End If
            End If
        Next

        'MoverEnemigo)

        'Timer1.Start()


        ' MoverEnemigo()



        '  timerEnemigo.Stop()




    End Sub



    Private Sub timerBala_Tick(sender As Object, e As EventArgs) Handles timerBala.Tick



        DispararBala()
        DispararBalaIzquierda()

        '   For Each ctrlBala In Me.Controls
        '  ctrlBala.Left += 5

        ' If TypeOf ctrlBala Is PictureBox AndAlso ctrlBala.Name = "Bala" Then

        '       End If
        '        Next


        '  timerBala.Stop()
    End Sub


    Private Sub DispararBala()

        If balaPic.Visible = True Then
            balaPic.Left += velocidadDisparo
        End If


        If balaPic.Bounds.IntersectsWith(bordeDerecha.Bounds) Then
            balaPic.Visible = False
            '  balaPic.Dispose()

        End If


        If balaPic.Bounds.IntersectsWith(bordeDerecha.Bounds) Or balaPic.Bounds.IntersectsWith(enemigo.Bounds) Then


        End If


    End Sub



    Private Sub CargarBala()
        velocidadDisparo = 6
        velocidadPersonaje = 3
        balaPic.Visible = False
    End Sub



    Private Sub CargarBalaIzquierda()
        velocidadDisparoIzquierda = 6
        velocidadPersonaje = 3
        balaIzquierda.Visible = False

    End Sub


    Private Sub DispararBalaIzquierda()

        If balaIzquierda.Visible = True Then
            balaIzquierda.Left -= velocidadDisparoIzquierda
        End If

    End Sub








    Private Sub MoverEnemigo()
        '        enemigo.Location = New Point(posicionXEnemigo, posicionYEnemigo)
        enemigo.Size = New Size(38, 64)
        enemigo.SizeMode = PictureBoxSizeMode.CenterImage
        enemigo.BackColor = Color.Transparent
        enemigo.Name = "Enemigo"

        '  Randomize()
        '   posicionX = Int((634 * Rnd()))
        Select Case contador
            Case 1
                enemigo.Image = My.Resources.Enemigo1
                contador += 1
                '
                posicionXEnemigo = posicionXEnemigo - 3
            Case 2
                enemigo.Image = My.Resources.Enemigo2
                contador += 1
                posicionXEnemigo = posicionXEnemigo - 3
            Case 3
                enemigo.Image = My.Resources.Enemigo3
                contador += 1
                posicionXEnemigo = posicionXEnemigo - 3
            Case 4
                enemigo.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo = posicionXEnemigo - 3
            Case 5
                enemigo.Image = My.Resources.Enemigo5
                contador += 1
                posicionXEnemigo = posicionXEnemigo - 3
            Case 6
                enemigo.Image = My.Resources.Enemigo6
                contador += 1
                posicionXEnemigo = posicionXEnemigo - 3
            Case 7
                enemigo.Image = My.Resources.Enemigo7
                contador += 1
                posicionXEnemigo = posicionXEnemigo - 3
            Case 8
                enemigo.Image = My.Resources.Enemigo8
                contador += 1
                posicionXEnemigo = posicionXEnemigo - 3
            Case 9
                enemigo.Image = My.Resources.Enemigo9
                contador = 1
                posicionXEnemigo = posicionXEnemigo - 3
        End Select
        '  timerEnemigo.Stop()


        enemigo.SetBounds(posicionXEnemigo, posicionYEnemigo, enemigo.Width, enemigo.Height)

        'Me.Controls.Add(enemigo)
        'Me.Controls.Add(enemigo)
        enemigo.BringToFront()

    End Sub







    Private Sub timerDuracion_Tick(sender As Object, e As EventArgs) Handles timerDuracion.Tick
        tiempo = tiempo - 1
        Label1.Text = tiempo

        If tiempo = 0 Then
            timerEnemigo.Enabled = False
            timerDuracion.Enabled = False
        End If




    End Sub


    Private Sub MoverEnemigo1()
        '        enemigo.Location = New Point(posicionXEnemigo, posicionYEnemigo)
        enemigo1.Size = New Size(38, 64)
        enemigo1.SizeMode = PictureBoxSizeMode.CenterImage
        enemigo1.BackColor = Color.Transparent
        enemigo1.Name = "Enemigo"

        '  Randomize()
        '   posicionX = Int((634 * Rnd()))
        Select Case contador
            Case 1
                enemigo1.Image = My.Resources.Enemigo1
                contador += 1
                '
                posicionXEnemigo1 = posicionXEnemigo1 - 3
            Case 2
                enemigo1.Image = My.Resources.Enemigo2
                contador += 1
                posicionXEnemigo1 = posicionXEnemigo1 - 3
            Case 3
                enemigo1.Image = My.Resources.Enemigo3
                contador += 1
                posicionXEnemigo1 = posicionXEnemigo1 - 3
            Case 4
                enemigo1.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo1 = posicionXEnemigo1 - 3
            Case 5
                enemigo1.Image = My.Resources.Enemigo5
                contador += 1
                posicionXEnemigo1 = posicionXEnemigo1 - 3
            Case 6
                enemigo1.Image = My.Resources.Enemigo6
                contador += 1
                posicionXEnemigo1 = posicionXEnemigo1 - 3
            Case 7
                enemigo1.Image = My.Resources.Enemigo7
                contador += 1
                posicionXEnemigo1 = posicionXEnemigo1 - 3
            Case 8
                enemigo1.Image = My.Resources.Enemigo8
                contador += 1
                posicionXEnemigo1 = posicionXEnemigo1 - 3
            Case 9
                enemigo1.Image = My.Resources.Enemigo9
                contador = 1
                posicionXEnemigo1 = posicionXEnemigo1 - 3
        End Select
        '  timerenemigo1.Stop()


        enemigo1.SetBounds(posicionXEnemigo1, posicionYEnemigo1, enemigo1.Width, enemigo1.Height)

        'Me.Controls.Add(enemigo1)
        'Me.Controls.Add(enemigo1)
        enemigo1.BringToFront()

    End Sub



    Private Sub MoverEnemigo2()
        '        enemigo.Location = New Point(posicionXEnemigo, posicionYEnemigo)
        enemigo2.Size = New Size(38, 64)
        enemigo2.SizeMode = PictureBoxSizeMode.CenterImage
        enemigo2.BackColor = Color.Transparent
        enemigo2.Name = "Enemigo"

        '  Randomize()
        '   posicionX = Int((634 * Rnd()))
        Select Case contador
            Case 1
                enemigo2.Image = My.Resources.Enemigo2
                contador += 1
                '
                posicionXEnemigo2 = posicionXEnemigo2 - 3
            Case 2
                enemigo2.Image = My.Resources.Enemigo2
                contador += 1
                posicionXEnemigo2 = posicionXEnemigo2 - 3
            Case 3
                enemigo2.Image = My.Resources.Enemigo3
                contador += 1
                posicionXEnemigo2 = posicionXEnemigo2 - 3
            Case 4
                enemigo2.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo2 = posicionXEnemigo2 - 3
            Case 5
                enemigo2.Image = My.Resources.Enemigo5
                contador += 1
                posicionXEnemigo2 = posicionXEnemigo2 - 3
            Case 6
                enemigo2.Image = My.Resources.Enemigo6
                contador += 1
                posicionXEnemigo2 = posicionXEnemigo2 - 3
            Case 7
                enemigo2.Image = My.Resources.Enemigo7
                contador += 1
                posicionXEnemigo2 = posicionXEnemigo2 - 3
            Case 8
                enemigo2.Image = My.Resources.Enemigo8
                contador += 1
                posicionXEnemigo2 = posicionXEnemigo2 - 3
            Case 9
                enemigo2.Image = My.Resources.Enemigo9
                contador = 1
                posicionXEnemigo2 = posicionXEnemigo2 - 3
        End Select
        '  timerenemigo2.Stop()


        enemigo2.SetBounds(posicionXEnemigo2, posicionYEnemigo2, enemigo2.Width, enemigo2.Height)

        'Me.Controls.Add(enemigo2)
        'Me.Controls.Add(enemigo2)
        enemigo2.BringToFront()

    End Sub



    Private Sub MoverEnemigo3()
        '        enemigo.Location = New Point(posicionXEnemigo, posicionYEnemigo)
        enemigo3.Size = New Size(38, 64)
        enemigo3.SizeMode = PictureBoxSizeMode.CenterImage
        enemigo3.BackColor = Color.Transparent
        enemigo3.Name = "Enemigo"

        '  Randomize()
        '   posicionX = Int((634 * Rnd()))
        Select Case contador
            Case 1
                enemigo3.Image = My.Resources.Enemigo3
                contador += 1
                '
                posicionXEnemigo3 = posicionXEnemigo3 - 3
            Case 2
                enemigo3.Image = My.Resources.Enemigo2
                contador += 1
                posicionXEnemigo3 = posicionXEnemigo3 - 3
            Case 3
                enemigo3.Image = My.Resources.Enemigo3
                contador += 1
                posicionXEnemigo3 = posicionXEnemigo3 - 3
            Case 4
                enemigo3.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo3 = posicionXEnemigo3 - 3
            Case 5
                enemigo3.Image = My.Resources.Enemigo5
                contador += 1
                posicionXEnemigo3 = posicionXEnemigo3 - 3
            Case 6
                enemigo3.Image = My.Resources.Enemigo6
                contador += 1
                posicionXEnemigo3 = posicionXEnemigo3 - 3
            Case 7
                enemigo3.Image = My.Resources.Enemigo7
                contador += 1
                posicionXEnemigo3 = posicionXEnemigo3 - 3
            Case 8
                enemigo3.Image = My.Resources.Enemigo8
                contador += 1
                posicionXEnemigo3 = posicionXEnemigo3 - 3
            Case 9
                enemigo3.Image = My.Resources.Enemigo9
                contador = 1
                posicionXEnemigo3 = posicionXEnemigo3 - 3
        End Select
        '  timerenemigo3.Stop()


        enemigo3.SetBounds(posicionXEnemigo3, posicionYEnemigo3, enemigo3.Width, enemigo3.Height)

        'Me.Controls.Add(enemigo3)
        'Me.Controls.Add(enemigo3)
        enemigo3.BringToFront()

    End Sub



    Private Sub MoverEnemigo4()
        '        enemigo.Location = New Point(posicionXEnemigo, posicionYEnemigo)

        enemigo4.Size = New Size(38, 64)
        enemigo4.SizeMode = PictureBoxSizeMode.CenterImage
        enemigo4.BackColor = Color.Transparent
        enemigo4.Name = "Enemigo"

        '  Randomize()
        '   posicionX = Int((634 * Rnd()))
        Select Case contador
            Case 1
                enemigo4.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo4 = posicionXEnemigo4 - 3
            Case 2
                enemigo4.Image = My.Resources.Enemigo2
                contador += 1
                posicionXEnemigo4 = posicionXEnemigo4 - 3
            Case 3
                enemigo4.Image = My.Resources.Enemigo3
                contador += 1
                posicionXEnemigo4 = posicionXEnemigo4 - 3
            Case 4
                enemigo4.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo4 = posicionXEnemigo4 - 3
            Case 5
                enemigo4.Image = My.Resources.Enemigo5
                contador += 1
                posicionXEnemigo4 = posicionXEnemigo4 - 3
            Case 6
                enemigo4.Image = My.Resources.Enemigo6
                contador += 1
                posicionXEnemigo4 = posicionXEnemigo4 - 3
            Case 7
                enemigo4.Image = My.Resources.Enemigo7
                contador += 1
                posicionXEnemigo4 = posicionXEnemigo4 - 3
            Case 8
                enemigo4.Image = My.Resources.Enemigo8
                contador += 1
                posicionXEnemigo4 = posicionXEnemigo4 - 3
            Case 9
                enemigo4.Image = My.Resources.Enemigo9
                contador = 1
                posicionXEnemigo4 = posicionXEnemigo4 - 3
        End Select
        '  timerenemigo4.Stop()





        enemigo4.SetBounds(posicionXEnemigo4, posicionYEnemigo4, enemigo4.Width, enemigo4.Height)

        'Me.Controls.Add(enemigo4)
        'Me.Controls.Add(enemigo4)
        enemigo4.BringToFront()

    End Sub


    Private Sub MoverEnemigo5()
        '        enemigo.Location = New Point(posicionXEnemigo, posicionYEnemigo)

        enemigo5.Size = New Size(38, 64)
        enemigo5.SizeMode = PictureBoxSizeMode.CenterImage
        enemigo5.BackColor = Color.Transparent
        enemigo5.Name = "Enemigo"

        '  Randomize()
        '   posicionX = Int((634 * Rnd()))
        Select Case contador
            Case 1
                enemigo5.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo5 = posicionXEnemigo5 - 3
            Case 2
                enemigo5.Image = My.Resources.Enemigo2
                contador += 1
                posicionXEnemigo5 = posicionXEnemigo5 - 3
            Case 3
                enemigo5.Image = My.Resources.Enemigo3
                contador += 1
                posicionXEnemigo5 = posicionXEnemigo5 - 3
            Case 4
                enemigo5.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo5 = posicionXEnemigo5 - 3
            Case 5
                enemigo5.Image = My.Resources.Enemigo5
                contador += 1
                posicionXEnemigo5 = posicionXEnemigo5 - 3
            Case 6
                enemigo5.Image = My.Resources.Enemigo6
                contador += 1
                posicionXEnemigo5 = posicionXEnemigo5 - 3
            Case 7
                enemigo5.Image = My.Resources.Enemigo7
                contador += 1
                posicionXEnemigo5 = posicionXEnemigo5 - 3
            Case 8
                enemigo5.Image = My.Resources.Enemigo8
                contador += 1
                posicionXEnemigo5 = posicionXEnemigo5 - 3
            Case 9
                enemigo5.Image = My.Resources.Enemigo9
                contador = 1
                posicionXEnemigo5 = posicionXEnemigo5 - 3
        End Select
        '  timerenemigo4.Stop()





        enemigo5.SetBounds(posicionXEnemigo5, posicionXEnemigo5, enemigo5.Width, enemigo5.Height)

        'Me.Controls.Add(enemigo4)
        'Me.Controls.Add(enemigo4)
        enemigo5.BringToFront()

    End Sub

    Private Sub MoverEnemigo6()
        '        enemigo.Location = New Point(posicionXEnemigo, posicionYEnemigo)

        enemigo6.Size = New Size(38, 64)
        enemigo6.SizeMode = PictureBoxSizeMode.CenterImage
        enemigo6.BackColor = Color.Transparent
        enemigo6.Name = "Enemigo"

        '  Randomize()
        '   posicionX = Int((634 * Rnd()))
        Select Case contador
            Case 1
                enemigo6.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo6 = posicionXEnemigo6 - 3
            Case 2
                enemigo6.Image = My.Resources.Enemigo2
                contador += 1
                posicionXEnemigo6 = posicionXEnemigo6 - 3
            Case 3
                enemigo6.Image = My.Resources.Enemigo3
                contador += 1
                posicionXEnemigo6 = posicionXEnemigo6 - 3
            Case 4
                enemigo6.Image = My.Resources.Enemigo4
                contador += 1
                '
                posicionXEnemigo6 = posicionXEnemigo6 - 3
            Case 5
                enemigo6.Image = My.Resources.Enemigo5
                contador += 1
                posicionXEnemigo6 = posicionXEnemigo6 - 3
            Case 6
                enemigo6.Image = My.Resources.Enemigo6
                contador += 1
                posicionXEnemigo6 = posicionXEnemigo6 - 3
            Case 7
                enemigo6.Image = My.Resources.Enemigo7
                contador += 1
                posicionXEnemigo6 = posicionXEnemigo6 - 3
            Case 8
                enemigo6.Image = My.Resources.Enemigo8
                contador += 1
                posicionXEnemigo6 = posicionXEnemigo6 - 3
            Case 9
                enemigo6.Image = My.Resources.Enemigo9
                contador = 1
                posicionXEnemigo6 = posicionXEnemigo6 - 3
        End Select
        '  timerenemigo4.Stop()





        enemigo6.SetBounds(posicionXEnemigo6, posicionXEnemigo6, enemigo6.Width, enemigo6.Height)

        'Me.Controls.Add(enemigo4)
        'Me.Controls.Add(enemigo4)
        enemigo6.BringToFront()

    End Sub




    Private Sub MoverEnemigoIzquierda()
        enemigoIzquierda.Visible = True
        enemigoIzquierda.Size = New Size(38, 64)
        enemigoIzquierda.SizeMode = PictureBoxSizeMode.CenterImage
        enemigoIzquierda.BackColor = Color.Transparent
        enemigoIzquierda.Name = "Enemigo"

        '  Randomize()
        '   posicionX = Int((634 * Rnd()))
        Select Case contadorIzquierda
            Case 1
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda
                contadorIzquierda += 1
                '
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
            Case 2
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda2
                contadorIzquierda += 1
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
            Case 3
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda3
                contadorIzquierda += 1
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
            Case 4
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda4
                contadorIzquierda += 1
                '
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
            Case 5
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda5
                contadorIzquierda += 1
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
            Case 6
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda6
                contadorIzquierda += 1
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
            Case 7
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda7
                contadorIzquierda += 1
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
            Case 8
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda8
                contadorIzquierda += 1
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
            Case 9
                enemigoIzquierda.Image = My.Resources.EnemigoIzquierda9
                contadorIzquierda = 1
                posicionXEnemigoIzquierda = posicionXEnemigoIzquierda + 3
        End Select
        '  timerenemigoIzquierda.Stop()





        enemigoIzquierda.SetBounds(posicionXEnemigoIzquierda, posicionYEnemigoIzquierda, enemigoIzquierda.Width, enemigoIzquierda.Height)

        'Me.Controls.Add(enemigoIzquierda)
        'Me.Controls.Add(enemigoIzquierda)
        enemigoIzquierda.BringToFront()

    End Sub

    Private Sub MoverEnemigoIzquierda1()

        If posicionXEnemigoIzquierda > 50 Then



            enemigoIzquierda1.Visible = True
            enemigoIzquierda1.Size = New Size(38, 64)
            enemigoIzquierda1.SizeMode = PictureBoxSizeMode.CenterImage
            enemigoIzquierda1.BackColor = Color.Transparent
            enemigoIzquierda1.Name = "Enemigo"

            '  Randomize()
            '   posicionX = Int((634 * Rnd()))
            Select Case contadorIzquierda
                Case 1
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
                Case 2
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda2
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
                Case 3
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda3
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
                Case 4
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda4
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
                Case 5
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda5
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
                Case 6
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
                Case 7
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda7
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
                Case 8
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda8
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
                Case 9
                    enemigoIzquierda1.Image = My.Resources.EnemigoIzquierda9
                    contadorIzquierda = 1
                    posicionXEnemigoIzquierda1 = posicionXEnemigoIzquierda1 + 3
            End Select
            '  timerenemigoIzquierda.Stop()





            enemigoIzquierda1.SetBounds(posicionXEnemigoIzquierda1, posicionYEnemigoIzquierda1, enemigoIzquierda1.Width, enemigoIzquierda1.Height)

            'Me.Controls.Add(enemigoIzquierda)
            'Me.Controls.Add(enemigoIzquierda)
            enemigoIzquierda1.BringToFront()
        End If
    End Sub

    Private Sub MoverEnemigoIzquierda2()

        If posicionXEnemigoIzquierda1 > 50 Then



            enemigoIzquierda2.Visible = True
            enemigoIzquierda2.Size = New Size(38, 64)
            enemigoIzquierda2.SizeMode = PictureBoxSizeMode.CenterImage
            enemigoIzquierda2.BackColor = Color.Transparent
            enemigoIzquierda2.Name = "Enemigo"

            '  Randomize()
            '   posicionX = Int((634 * Rnd()))
            Select Case contadorIzquierda
                Case 1
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
                Case 2
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda2
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
                Case 3
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda3
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
                Case 4
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda4
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
                Case 5
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda5
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
                Case 6
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
                Case 7
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda7
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
                Case 8
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda8
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
                Case 9
                    enemigoIzquierda2.Image = My.Resources.EnemigoIzquierda9
                    contadorIzquierda = 1
                    posicionXEnemigoIzquierda2 = posicionXEnemigoIzquierda2 + 3
            End Select
            '  timerenemigoIzquierda.Stop()





            enemigoIzquierda2.SetBounds(posicionXEnemigoIzquierda2, posicionYEnemigoIzquierda2, enemigoIzquierda2.Width, enemigoIzquierda2.Height)

            'Me.Controls.Add(enemigoIzquierda)
            'Me.Controls.Add(enemigoIzquierda)
            enemigoIzquierda2.BringToFront()
        End If
    End Sub

    Private Sub MoverEnemigoIzquierda3()

        If posicionXEnemigoIzquierda2 > 50 Then



            enemigoIzquierda3.Visible = True
            enemigoIzquierda3.Size = New Size(38, 64)
            enemigoIzquierda3.SizeMode = PictureBoxSizeMode.CenterImage
            enemigoIzquierda3.BackColor = Color.Transparent
            enemigoIzquierda3.Name = "Enemigo"

            '  Randomize()
            '   posicionX = Int((634 * Rnd()))
            Select Case contadorIzquierda
                Case 1
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
                Case 2
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda3
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
                Case 3
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda3
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
                Case 4
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda4
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
                Case 5
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda5
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
                Case 6
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
                Case 7
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda7
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
                Case 8
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda8
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
                Case 9
                    enemigoIzquierda3.Image = My.Resources.EnemigoIzquierda9
                    contadorIzquierda = 1
                    posicionXEnemigoIzquierda3 = posicionXEnemigoIzquierda3 + 3
            End Select
            '  timerenemigoIzquierda.Stop()





            enemigoIzquierda3.SetBounds(posicionXEnemigoIzquierda3, posicionYEnemigoIzquierda3, enemigoIzquierda3.Width, enemigoIzquierda3.Height)

            'Me.Controls.Add(enemigoIzquierda)
            'Me.Controls.Add(enemigoIzquierda)
            enemigoIzquierda3.BringToFront()
        End If
    End Sub





    Private Sub MoverEnemigoIzquierda4()

        If posicionXEnemigoIzquierda3 > 50 Then



            enemigoIzquierda4.Visible = True
            enemigoIzquierda4.Size = New Size(38, 64)
            enemigoIzquierda4.SizeMode = PictureBoxSizeMode.CenterImage
            enemigoIzquierda4.BackColor = Color.Transparent
            enemigoIzquierda4.Name = "Enemigo"

            '  Randomize()
            '   posicionX = Int((634 * Rnd()))
            Select Case contadorIzquierda
                Case 1
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
                Case 2
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda4
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
                Case 3
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda4
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
                Case 4
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda4
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
                Case 5
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda5
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
                Case 6
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
                Case 7
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda7
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
                Case 8
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda8
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
                Case 9
                    enemigoIzquierda4.Image = My.Resources.EnemigoIzquierda9
                    contadorIzquierda = 1
                    posicionXEnemigoIzquierda4 = posicionXEnemigoIzquierda4 + 3
            End Select
            '  timerenemigoIzquierda.Stop()





            enemigoIzquierda4.SetBounds(posicionXEnemigoIzquierda4, posicionYEnemigoIzquierda4, enemigoIzquierda4.Width, enemigoIzquierda4.Height)

            'Me.Controls.Add(enemigoIzquierda)
            'Me.Controls.Add(enemigoIzquierda)
            enemigoIzquierda4.BringToFront()
        End If
    End Sub


    Private Sub MoverEnemigoIzquierda5()

        If posicionXEnemigoIzquierda4 > 50 Then



            enemigoIzquierda5.Visible = True
            enemigoIzquierda5.Size = New Size(38, 64)
            enemigoIzquierda5.SizeMode = PictureBoxSizeMode.CenterImage
            enemigoIzquierda5.BackColor = Color.Transparent
            enemigoIzquierda5.Name = "Enemigo"

            '  Randomize()
            '   posicionX = Int((634 * Rnd()))
            Select Case contadorIzquierda
                Case 1
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
                Case 2
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda5
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
                Case 3
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda5
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
                Case 4
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda4
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
                Case 5
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda5
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
                Case 6
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
                Case 7
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda7
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
                Case 8
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda8
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
                Case 9
                    enemigoIzquierda5.Image = My.Resources.EnemigoIzquierda9
                    contadorIzquierda = 1
                    posicionXEnemigoIzquierda5 = posicionXEnemigoIzquierda5 + 3
            End Select
            '  timerenemigoIzquierda.Stop()





            enemigoIzquierda5.SetBounds(posicionXEnemigoIzquierda5, posicionYEnemigoIzquierda5, enemigoIzquierda5.Width, enemigoIzquierda5.Height)

            'Me.Controls.Add(enemigoIzquierda)
            'Me.Controls.Add(enemigoIzquierda)
            enemigoIzquierda5.BringToFront()
        End If
    End Sub


    Private Sub MoverEnemigoIzquierda6()

        If posicionXEnemigoIzquierda5 > 50 Then



            enemigoIzquierda6.Visible = True
            enemigoIzquierda6.Size = New Size(38, 64)
            enemigoIzquierda6.SizeMode = PictureBoxSizeMode.CenterImage
            enemigoIzquierda6.BackColor = Color.Transparent
            enemigoIzquierda6.Name = "Enemigo"

            '  Randomize()
            '   posicionX = Int((634 * Rnd()))
            Select Case contadorIzquierda
                Case 1
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
                Case 2
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
                Case 3
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
                Case 4
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda4
                    contadorIzquierda += 1
                    '
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
                Case 5
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
                Case 6
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda6
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
                Case 7
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda7
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
                Case 8
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda8
                    contadorIzquierda += 1
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
                Case 9
                    enemigoIzquierda6.Image = My.Resources.EnemigoIzquierda9
                    contadorIzquierda = 1
                    posicionXEnemigoIzquierda6 = posicionXEnemigoIzquierda6 + 3
            End Select
            '  timerenemigoIzquierda.Stop()





            enemigoIzquierda6.SetBounds(posicionXEnemigoIzquierda6, posicionYEnemigoIzquierda6, enemigoIzquierda6.Width, enemigoIzquierda6.Height)

            'Me.Controls.Add(enemigoIzquierda)
            'Me.Controls.Add(enemigoIzquierda)
            enemigoIzquierda6.BringToFront()
        End If
    End Sub




    Private Sub timerEnemigoIzquierda_Tick(sender As Object, e As EventArgs) Handles timerEnemigoIzquierda.Tick
        MoverEnemigoIzquierda()

        '   MoverEnemigoIzquierda1()

        '   MoverEnemigoIzquierda2()}
        MoverEnemigoIzquierda1()


        MoverEnemigoIzquierda2()


        MoverEnemigoIzquierda4()


        For Each ctrlEnemigo In Me.Controls
            If TypeOf ctrlEnemigo Is PictureBox AndAlso ctrlEnemigo.Name = "Enemigo" Then
                If ctrlEnemigo.Bounds.IntersectsWith(balaIzquierda.Bounds) And balaIzquierda.Visible = True Then
                    ctrlEnemigo.Dispose()
                    Me.Controls.Remove(ctrlEnemigo)
                    balaIzquierda.Visible = False
                End If

            End If
        Next
    End Sub

    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick


        MoverEnemigo3()

        MoverEnemigo4()

        MoverEnemigoIzquierda3()
        MoverEnemigoIzquierda5()
        MoverEnemigoIzquierda6()






        For Each ctrlEnemigo In Me.Controls
            If TypeOf ctrlEnemigo Is PictureBox AndAlso ctrlEnemigo.Name = "Enemigo" Then
                If ctrlEnemigo.Bounds.IntersectsWith(balaPic.Bounds) And balaPic.Visible = True Then
                    ctrlEnemigo.Dispose()
                    Me.Controls.Remove(ctrlEnemigo)
                    balaPic.Visible = False
                End If


            End If
        Next

    End Sub


    Private Sub EnemigoAire()
        enemigoCayendo.Visible = True
        enemigoCayendo.Size = New Size(38, 64)
        enemigoCayendo.SizeMode = PictureBoxSizeMode.CenterImage
        enemigoCayendo.BackColor = Color.Transparent
        enemigoCayendo.Name = "Enemigo"


        If cayendo = False Then

            posicionYEnemigoCayendo = posicionYEnemigoCayendo + 20

            If enemigoCayendo.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                cayendo = True
            End If
        End If


        If cayendo Then
            Select Case contadorCayendo
                Case 1
                    enemigoCayendo.Image = My.Resources.Enemigo1
                    contadorCayendo += 1
                    '
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 2
                    enemigoCayendo.Image = My.Resources.Enemigo2
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 3
                    enemigoCayendo.Image = My.Resources.Enemigo3
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 4
                    enemigoCayendo.Image = My.Resources.Enemigo4
                    contadorCayendo += 1
                    '
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 5
                    enemigoCayendo.Image = My.Resources.Enemigo5
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 6
                    enemigoCayendo.Image = My.Resources.Enemigo6
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 7
                    enemigoCayendo.Image = My.Resources.Enemigo7
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 8
                    enemigoCayendo.Image = My.Resources.Enemigo8
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 9
                    enemigoCayendo.Image = My.Resources.Enemigo9
                    contadorCayendo = 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
            End Select
        End If

        enemigoCayendo.SetBounds(posicionXEnemigoCayendo, posicionYEnemigoCayendo, enemigoCayendo.Width, enemigoCayendo.Height)

        enemigoCayendo.BringToFront()


    End Sub

    Private Sub EnemigoAire2()
        enemigoCayendo1.Visible = True
        enemigoCayendo1.Size = New Size(38, 64)
        enemigoCayendo1.SizeMode = PictureBoxSizeMode.CenterImage
        enemigoCayendo1.BackColor = Color.Transparent
        enemigoCayendo1.Name = "Enemigo"


        If cayendo = False Then

            posicionYEnemigoCayendo = posicionYEnemigoCayendo + 20

            If enemigoCayendo.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                cayendo = True
            End If
        End If


        If cayendo Then
            Select Case contadorCayendo
                Case 1
                    enemigoCayendo.Image = My.Resources.Enemigo1
                    contadorCayendo += 1
                    '
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 2
                    enemigoCayendo.Image = My.Resources.Enemigo2
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 3
                    enemigoCayendo.Image = My.Resources.Enemigo3
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 4
                    enemigoCayendo.Image = My.Resources.Enemigo4
                    contadorCayendo += 1
                    '
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 5
                    enemigoCayendo.Image = My.Resources.Enemigo5
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 6
                    enemigoCayendo.Image = My.Resources.Enemigo6
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 7
                    enemigoCayendo.Image = My.Resources.Enemigo7
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 8
                    enemigoCayendo.Image = My.Resources.Enemigo8
                    contadorCayendo += 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
                Case 9
                    enemigoCayendo.Image = My.Resources.Enemigo9
                    contadorCayendo = 1
                    posicionXEnemigoCayendo = posicionXEnemigoCayendo - 3
            End Select
        End If

        enemigoCayendo.SetBounds(posicionXEnemigoCayendo, posicionYEnemigoCayendo, enemigoCayendo.Width, enemigoCayendo.Height)

        enemigoCayendo.BringToFront()


    End Sub


    Private Sub EnemigoAireIzquierda()
        enemigoCayendoIzquierda.Visible = True
        enemigoCayendoIzquierda.Size = New Size(38, 64)
        enemigoCayendoIzquierda.SizeMode = PictureBoxSizeMode.CenterImage
        enemigoCayendoIzquierda.BackColor = Color.Transparent
        enemigoCayendoIzquierda.Name = "Enemigo"


        If cayendo = False Then

            posicionYEnemigoCayendoIzquierda = posicionYEnemigoCayendoIzquierda + 20

            If enemigoCayendoIzquierda.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                cayendo = True
            End If
        End If


        If cayendo Then
            Select Case contadorCayendo
                Case 1
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda
                    contadorCayendo += 1
                    '
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
                Case 2
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda2
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
                Case 3
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda3
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
                Case 4
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda4
                    contadorCayendo += 1
                    '
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
                Case 5
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda5
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
                Case 6
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda6
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
                Case 7
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda7
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
                Case 8
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda8
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
                Case 9
                    enemigoCayendoIzquierda.Image = My.Resources.EnemigoIzquierda9
                    contadorCayendo = 1
                    posicionXEnemigoCayendoIzquierda = posicionXEnemigoCayendoIzquierda + 3
            End Select
        End If

        enemigoCayendoIzquierda.SetBounds(posicionXEnemigoCayendoIzquierda, posicionYEnemigoCayendoIzquierda, enemigoCayendoIzquierda.Width, enemigoCayendoIzquierda.Height)

        enemigoCayendoIzquierda.BringToFront()
    End Sub

    Private Sub EnemigoAireIzquierda2()
        enemigoCayendoIzquierda2.Visible = True
        enemigoCayendoIzquierda2.Size = New Size(38, 64)
        enemigoCayendoIzquierda2.SizeMode = PictureBoxSizeMode.CenterImage
        enemigoCayendoIzquierda2.BackColor = Color.Transparent
        enemigoCayendoIzquierda2.Name = "Enemigo"


        If cayendo = False Then

            posicionYEnemigoCayendoIzquierda2 = posicionYEnemigoCayendoIzquierda2 + 20

            If enemigoCayendoIzquierda2.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                cayendo = True
            End If
        End If


        If cayendo Then
            Select Case contadorCayendo
                Case 1
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda
                    contadorCayendo += 1
                    '
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
                Case 2
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda2
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
                Case 3
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda3
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
                Case 4
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda4
                    contadorCayendo += 1
                    '
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
                Case 5
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda5
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
                Case 6
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda6
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
                Case 7
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda7
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
                Case 8
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda8
                    contadorCayendo += 1
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
                Case 9
                    enemigoCayendoIzquierda2.Image = My.Resources.EnemigoIzquierda9
                    contadorCayendo = 1
                    posicionXEnemigoCayendoIzquierda2 = posicionXEnemigoCayendoIzquierda2 + 3
            End Select
        End If

        enemigoCayendoIzquierda2.SetBounds(posicionXEnemigoCayendoIzquierda2, posicionYEnemigoCayendoIzquierda2, enemigoCayendoIzquierda2.Width, enemigoCayendoIzquierda2.Height)

        enemigoCayendoIzquierda2.BringToFront()
    End Sub
    Private Sub EnemigoAireIzquierda3()
        enemigoCayendoIzquierda3.Visible = True
        enemigoCayendoIzquierda3.Size = New Size(38, 64)
        enemigoCayendoIzquierda3.SizeMode = PictureBoxSizeMode.CenterImage
        enemigoCayendoIzquierda3.BackColor = Color.Transparent
        enemigoCayendoIzquierda3.Name = "Enemigo"


        If cayendo = False Then

            posicionYenemigoCayendoIzquierda3 = posicionYenemigoCayendoIzquierda3 + 20

            If enemigoCayendoIzquierda3.Bounds.IntersectsWith(PictureBox1.Bounds) Then
                cayendo = True
            End If
        End If


        If cayendo Then
            Select Case contadorCayendo
                Case 1
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda
                    contadorCayendo += 1
                    '
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
                Case 2
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda2
                    contadorCayendo += 1
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
                Case 3
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda3
                    contadorCayendo += 1
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
                Case 4
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda4
                    contadorCayendo += 1
                    '
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
                Case 5
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda5
                    contadorCayendo += 1
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
                Case 6
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda6
                    contadorCayendo += 1
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
                Case 7
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda7
                    contadorCayendo += 1
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
                Case 8
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda8
                    contadorCayendo += 1
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
                Case 9
                    enemigoCayendoIzquierda3.Image = My.Resources.EnemigoIzquierda9
                    contadorCayendo = 1
                    posicionXenemigoCayendoIzquierda3 = posicionXenemigoCayendoIzquierda3 + 3
            End Select
        End If

        enemigoCayendoIzquierda3.SetBounds(posicionXenemigoCayendoIzquierda3, posicionYenemigoCayendoIzquierda3, enemigoCayendoIzquierda3.Width, enemigoCayendoIzquierda3.Height)

        enemigoCayendoIzquierda3.BringToFront()
    End Sub

    Private Sub timerCayendo_Tick(sender As Object, e As EventArgs) Handles timerCayendo.Tick
        EnemigoAire()
        EnemigoAireIzquierda()
        EnemigoAireIzquierda2()
    End Sub
End Class