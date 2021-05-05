<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Juego
    Inherits System.Windows.Forms.Form

    'Form reemplaza a Dispose para limpiar la lista de componentes.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.personajePrincipal = New System.Windows.Forms.PictureBox()
        Me.timerPersonaje = New System.Windows.Forms.Timer(Me.components)
        Me.timerSalto = New System.Windows.Forms.Timer(Me.components)
        Me.timerAgacho = New System.Windows.Forms.Timer(Me.components)
        Me.timerEnemigo = New System.Windows.Forms.Timer(Me.components)
        Me.timerBala = New System.Windows.Forms.Timer(Me.components)
        Me.bordeDerecha = New System.Windows.Forms.PictureBox()
        Me.bordeIzquieda = New System.Windows.Forms.PictureBox()
        Me.balaPic = New System.Windows.Forms.PictureBox()
        Me.balaIzquierda = New System.Windows.Forms.PictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.timerDuracion = New System.Windows.Forms.Timer(Me.components)
        Me.enemigo = New System.Windows.Forms.PictureBox()
        Me.enemigo1 = New System.Windows.Forms.PictureBox()
        Me.enemigo2 = New System.Windows.Forms.PictureBox()
        Me.enemigo3 = New System.Windows.Forms.PictureBox()
        Me.enemigo4 = New System.Windows.Forms.PictureBox()
        Me.enemigo5 = New System.Windows.Forms.PictureBox()
        Me.enemigo6 = New System.Windows.Forms.PictureBox()
        Me.enemigoIzquierda = New System.Windows.Forms.PictureBox()
        Me.enemigoIzquierda1 = New System.Windows.Forms.PictureBox()
        Me.enemigoIzquierda5 = New System.Windows.Forms.PictureBox()
        Me.enemigoIzquierda4 = New System.Windows.Forms.PictureBox()
        Me.enemigoIzquierda3 = New System.Windows.Forms.PictureBox()
        Me.enemigoIzquierda2 = New System.Windows.Forms.PictureBox()
        Me.timerEnemigoIzquierda = New System.Windows.Forms.Timer(Me.components)
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.enemigoIzquierda6 = New System.Windows.Forms.PictureBox()
        Me.timerCayendo = New System.Windows.Forms.Timer(Me.components)
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.enemigoCayendo = New System.Windows.Forms.PictureBox()
        Me.enemigoCayendo1 = New System.Windows.Forms.PictureBox()
        Me.enemigoCayendo2 = New System.Windows.Forms.PictureBox()
        Me.enemigoCayendoIzquierda2 = New System.Windows.Forms.PictureBox()
        Me.enemigoCayendoIzquierda3 = New System.Windows.Forms.PictureBox()
        Me.enemigoCayendoIzquierda = New System.Windows.Forms.PictureBox()
        CType(Me.personajePrincipal, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bordeDerecha, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.bordeIzquieda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.balaPic, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.balaIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigo6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoIzquierda1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoIzquierda5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoIzquierda4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoIzquierda3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoIzquierda2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoIzquierda6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoCayendo, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoCayendo1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoCayendo2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoCayendoIzquierda2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoCayendoIzquierda3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.enemigoCayendoIzquierda, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'personajePrincipal
        '
        Me.personajePrincipal.BackColor = System.Drawing.Color.Transparent
        Me.personajePrincipal.Image = Global.MetalSlug.My.Resources.Resources.Corre1
        Me.personajePrincipal.Location = New System.Drawing.Point(260, 104)
        Me.personajePrincipal.Name = "personajePrincipal"
        Me.personajePrincipal.Size = New System.Drawing.Size(35, 79)
        Me.personajePrincipal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.personajePrincipal.TabIndex = 2
        Me.personajePrincipal.TabStop = False
        '
        'timerPersonaje
        '
        Me.timerPersonaje.Interval = 50
        '
        'timerSalto
        '
        Me.timerSalto.Interval = 150
        '
        'timerAgacho
        '
        '
        'timerEnemigo
        '
        Me.timerEnemigo.Interval = 50
        '
        'timerBala
        '
        Me.timerBala.Interval = 1
        '
        'bordeDerecha
        '
        Me.bordeDerecha.BackColor = System.Drawing.Color.Transparent
        Me.bordeDerecha.Location = New System.Drawing.Point(557, -10)
        Me.bordeDerecha.Name = "bordeDerecha"
        Me.bordeDerecha.Size = New System.Drawing.Size(10, 203)
        Me.bordeDerecha.TabIndex = 4
        Me.bordeDerecha.TabStop = False
        '
        'bordeIzquieda
        '
        Me.bordeIzquieda.BackColor = System.Drawing.Color.Transparent
        Me.bordeIzquieda.Location = New System.Drawing.Point(-9, -1)
        Me.bordeIzquieda.Name = "bordeIzquieda"
        Me.bordeIzquieda.Size = New System.Drawing.Size(10, 202)
        Me.bordeIzquieda.TabIndex = 5
        Me.bordeIzquieda.TabStop = False
        '
        'balaPic
        '
        Me.balaPic.BackColor = System.Drawing.Color.Transparent
        Me.balaPic.Image = Global.MetalSlug.My.Resources.Resources.Bala
        Me.balaPic.Location = New System.Drawing.Point(-1, 3)
        Me.balaPic.Name = "balaPic"
        Me.balaPic.Size = New System.Drawing.Size(14, 14)
        Me.balaPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.balaPic.TabIndex = 6
        Me.balaPic.TabStop = False
        Me.balaPic.Visible = False
        '
        'balaIzquierda
        '
        Me.balaIzquierda.BackColor = System.Drawing.Color.Transparent
        Me.balaIzquierda.Image = Global.MetalSlug.My.Resources.Resources.Bala_Izquierda
        Me.balaIzquierda.Location = New System.Drawing.Point(35, 3)
        Me.balaIzquierda.Name = "balaIzquierda"
        Me.balaIzquierda.Size = New System.Drawing.Size(14, 14)
        Me.balaIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage
        Me.balaIzquierda.TabIndex = 7
        Me.balaIzquierda.TabStop = False
        Me.balaIzquierda.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Gold
        Me.Label1.Location = New System.Drawing.Point(263, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 31)
        Me.Label1.TabIndex = 8
        Me.Label1.Text = "00"
        '
        'timerDuracion
        '
        Me.timerDuracion.Interval = 1000
        '
        'enemigo
        '
        Me.enemigo.BackColor = System.Drawing.Color.Transparent
        Me.enemigo.Image = Global.MetalSlug.My.Resources.Resources.Enemigo1
        Me.enemigo.Location = New System.Drawing.Point(521, 133)
        Me.enemigo.Name = "enemigo"
        Me.enemigo.Size = New System.Drawing.Size(36, 44)
        Me.enemigo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigo.TabIndex = 9
        Me.enemigo.TabStop = False
        '
        'enemigo1
        '
        Me.enemigo1.BackColor = System.Drawing.Color.Transparent
        Me.enemigo1.Image = Global.MetalSlug.My.Resources.Resources.Enemigo1
        Me.enemigo1.Location = New System.Drawing.Point(599, 119)
        Me.enemigo1.Name = "enemigo1"
        Me.enemigo1.Size = New System.Drawing.Size(38, 64)
        Me.enemigo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigo1.TabIndex = 10
        Me.enemigo1.TabStop = False
        '
        'enemigo2
        '
        Me.enemigo2.BackColor = System.Drawing.Color.Transparent
        Me.enemigo2.Image = Global.MetalSlug.My.Resources.Resources.Enemigo1
        Me.enemigo2.Location = New System.Drawing.Point(599, 119)
        Me.enemigo2.Name = "enemigo2"
        Me.enemigo2.Size = New System.Drawing.Size(36, 44)
        Me.enemigo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigo2.TabIndex = 11
        Me.enemigo2.TabStop = False
        '
        'enemigo3
        '
        Me.enemigo3.BackColor = System.Drawing.Color.Transparent
        Me.enemigo3.Image = Global.MetalSlug.My.Resources.Resources.Enemigo1
        Me.enemigo3.Location = New System.Drawing.Point(563, 133)
        Me.enemigo3.Name = "enemigo3"
        Me.enemigo3.Size = New System.Drawing.Size(36, 44)
        Me.enemigo3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigo3.TabIndex = 12
        Me.enemigo3.TabStop = False
        '
        'enemigo4
        '
        Me.enemigo4.BackColor = System.Drawing.Color.Transparent
        Me.enemigo4.Image = Global.MetalSlug.My.Resources.Resources.Enemigo1
        Me.enemigo4.Location = New System.Drawing.Point(599, 119)
        Me.enemigo4.Name = "enemigo4"
        Me.enemigo4.Size = New System.Drawing.Size(36, 44)
        Me.enemigo4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigo4.TabIndex = 13
        Me.enemigo4.TabStop = False
        '
        'enemigo5
        '
        Me.enemigo5.BackColor = System.Drawing.Color.Transparent
        Me.enemigo5.Image = Global.MetalSlug.My.Resources.Resources.Enemigo1
        Me.enemigo5.Location = New System.Drawing.Point(557, 139)
        Me.enemigo5.Name = "enemigo5"
        Me.enemigo5.Size = New System.Drawing.Size(36, 44)
        Me.enemigo5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigo5.TabIndex = 14
        Me.enemigo5.TabStop = False
        '
        'enemigo6
        '
        Me.enemigo6.BackColor = System.Drawing.Color.Transparent
        Me.enemigo6.Image = Global.MetalSlug.My.Resources.Resources.Enemigo1
        Me.enemigo6.Location = New System.Drawing.Point(521, 133)
        Me.enemigo6.Name = "enemigo6"
        Me.enemigo6.Size = New System.Drawing.Size(36, 44)
        Me.enemigo6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigo6.TabIndex = 15
        Me.enemigo6.TabStop = False
        '
        'enemigoIzquierda
        '
        Me.enemigoIzquierda.BackColor = System.Drawing.Color.Transparent
        Me.enemigoIzquierda.Image = Global.MetalSlug.My.Resources.Resources.EnemigoIzquierda
        Me.enemigoIzquierda.Location = New System.Drawing.Point(-1, 133)
        Me.enemigoIzquierda.Name = "enemigoIzquierda"
        Me.enemigoIzquierda.Size = New System.Drawing.Size(37, 44)
        Me.enemigoIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoIzquierda.TabIndex = 16
        Me.enemigoIzquierda.TabStop = False
        Me.enemigoIzquierda.Visible = False
        '
        'enemigoIzquierda1
        '
        Me.enemigoIzquierda1.BackColor = System.Drawing.Color.Transparent
        Me.enemigoIzquierda1.Image = Global.MetalSlug.My.Resources.Resources.EnemigoIzquierda
        Me.enemigoIzquierda1.Location = New System.Drawing.Point(-1, 133)
        Me.enemigoIzquierda1.Name = "enemigoIzquierda1"
        Me.enemigoIzquierda1.Size = New System.Drawing.Size(37, 44)
        Me.enemigoIzquierda1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoIzquierda1.TabIndex = 17
        Me.enemigoIzquierda1.TabStop = False
        Me.enemigoIzquierda1.Visible = False
        '
        'enemigoIzquierda5
        '
        Me.enemigoIzquierda5.BackColor = System.Drawing.Color.Transparent
        Me.enemigoIzquierda5.Image = Global.MetalSlug.My.Resources.Resources.EnemigoIzquierda
        Me.enemigoIzquierda5.Location = New System.Drawing.Point(-1, 133)
        Me.enemigoIzquierda5.Name = "enemigoIzquierda5"
        Me.enemigoIzquierda5.Size = New System.Drawing.Size(37, 44)
        Me.enemigoIzquierda5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoIzquierda5.TabIndex = 18
        Me.enemigoIzquierda5.TabStop = False
        Me.enemigoIzquierda5.Visible = False
        '
        'enemigoIzquierda4
        '
        Me.enemigoIzquierda4.BackColor = System.Drawing.Color.Transparent
        Me.enemigoIzquierda4.Image = Global.MetalSlug.My.Resources.Resources.EnemigoIzquierda
        Me.enemigoIzquierda4.Location = New System.Drawing.Point(-1, 133)
        Me.enemigoIzquierda4.Name = "enemigoIzquierda4"
        Me.enemigoIzquierda4.Size = New System.Drawing.Size(37, 44)
        Me.enemigoIzquierda4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoIzquierda4.TabIndex = 19
        Me.enemigoIzquierda4.TabStop = False
        Me.enemigoIzquierda4.Visible = False
        '
        'enemigoIzquierda3
        '
        Me.enemigoIzquierda3.BackColor = System.Drawing.Color.Transparent
        Me.enemigoIzquierda3.Image = Global.MetalSlug.My.Resources.Resources.EnemigoIzquierda
        Me.enemigoIzquierda3.Location = New System.Drawing.Point(714, 256)
        Me.enemigoIzquierda3.Name = "enemigoIzquierda3"
        Me.enemigoIzquierda3.Size = New System.Drawing.Size(37, 44)
        Me.enemigoIzquierda3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoIzquierda3.TabIndex = 20
        Me.enemigoIzquierda3.TabStop = False
        '
        'enemigoIzquierda2
        '
        Me.enemigoIzquierda2.BackColor = System.Drawing.Color.Transparent
        Me.enemigoIzquierda2.Image = Global.MetalSlug.My.Resources.Resources.EnemigoIzquierda
        Me.enemigoIzquierda2.Location = New System.Drawing.Point(-1, 133)
        Me.enemigoIzquierda2.Name = "enemigoIzquierda2"
        Me.enemigoIzquierda2.Size = New System.Drawing.Size(37, 44)
        Me.enemigoIzquierda2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoIzquierda2.TabIndex = 21
        Me.enemigoIzquierda2.TabStop = False
        Me.enemigoIzquierda2.Visible = False
        '
        'timerEnemigoIzquierda
        '
        Me.timerEnemigoIzquierda.Interval = 50
        '
        'Timer1
        '
        '
        'enemigoIzquierda6
        '
        Me.enemigoIzquierda6.BackColor = System.Drawing.Color.Transparent
        Me.enemigoIzquierda6.Image = Global.MetalSlug.My.Resources.Resources.EnemigoIzquierda
        Me.enemigoIzquierda6.Location = New System.Drawing.Point(-1, 133)
        Me.enemigoIzquierda6.Name = "enemigoIzquierda6"
        Me.enemigoIzquierda6.Size = New System.Drawing.Size(37, 44)
        Me.enemigoIzquierda6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoIzquierda6.TabIndex = 22
        Me.enemigoIzquierda6.TabStop = False
        Me.enemigoIzquierda6.Visible = False
        '
        'timerCayendo
        '
        Me.timerCayendo.Interval = 50
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox1.Location = New System.Drawing.Point(-1, 173)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(600, 10)
        Me.PictureBox1.TabIndex = 24
        Me.PictureBox1.TabStop = False
        '
        'enemigoCayendo
        '
        Me.enemigoCayendo.BackColor = System.Drawing.Color.Transparent
        Me.enemigoCayendo.Image = Global.MetalSlug.My.Resources.Resources.Cayendo
        Me.enemigoCayendo.Location = New System.Drawing.Point(315, -10)
        Me.enemigoCayendo.Name = "enemigoCayendo"
        Me.enemigoCayendo.Size = New System.Drawing.Size(47, 50)
        Me.enemigoCayendo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoCayendo.TabIndex = 27
        Me.enemigoCayendo.TabStop = False
        Me.enemigoCayendo.Visible = False
        '
        'enemigoCayendo1
        '
        Me.enemigoCayendo1.BackColor = System.Drawing.Color.Transparent
        Me.enemigoCayendo1.Image = Global.MetalSlug.My.Resources.Resources.Cayendo
        Me.enemigoCayendo1.Location = New System.Drawing.Point(363, -10)
        Me.enemigoCayendo1.Name = "enemigoCayendo1"
        Me.enemigoCayendo1.Size = New System.Drawing.Size(51, 50)
        Me.enemigoCayendo1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoCayendo1.TabIndex = 28
        Me.enemigoCayendo1.TabStop = False
        Me.enemigoCayendo1.Visible = False
        '
        'enemigoCayendo2
        '
        Me.enemigoCayendo2.BackColor = System.Drawing.Color.Transparent
        Me.enemigoCayendo2.Image = Global.MetalSlug.My.Resources.Resources.Cayendo
        Me.enemigoCayendo2.Location = New System.Drawing.Point(430, -10)
        Me.enemigoCayendo2.Name = "enemigoCayendo2"
        Me.enemigoCayendo2.Size = New System.Drawing.Size(51, 50)
        Me.enemigoCayendo2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoCayendo2.TabIndex = 29
        Me.enemigoCayendo2.TabStop = False
        Me.enemigoCayendo2.Visible = False
        '
        'enemigoCayendoIzquierda2
        '
        Me.enemigoCayendoIzquierda2.BackColor = System.Drawing.Color.Transparent
        Me.enemigoCayendoIzquierda2.Image = Global.MetalSlug.My.Resources.Resources.CayendoIzquierda
        Me.enemigoCayendoIzquierda2.Location = New System.Drawing.Point(129, -19)
        Me.enemigoCayendoIzquierda2.Name = "enemigoCayendoIzquierda2"
        Me.enemigoCayendoIzquierda2.Size = New System.Drawing.Size(47, 50)
        Me.enemigoCayendoIzquierda2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoCayendoIzquierda2.TabIndex = 30
        Me.enemigoCayendoIzquierda2.TabStop = False
        Me.enemigoCayendoIzquierda2.Visible = False
        '
        'enemigoCayendoIzquierda3
        '
        Me.enemigoCayendoIzquierda3.BackColor = System.Drawing.Color.Transparent
        Me.enemigoCayendoIzquierda3.Image = Global.MetalSlug.My.Resources.Resources.CayendoIzquierda
        Me.enemigoCayendoIzquierda3.Location = New System.Drawing.Point(55, -10)
        Me.enemigoCayendoIzquierda3.Name = "enemigoCayendoIzquierda3"
        Me.enemigoCayendoIzquierda3.Size = New System.Drawing.Size(47, 50)
        Me.enemigoCayendoIzquierda3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoCayendoIzquierda3.TabIndex = 31
        Me.enemigoCayendoIzquierda3.TabStop = False
        Me.enemigoCayendoIzquierda3.Visible = False
        '
        'enemigoCayendoIzquierda
        '
        Me.enemigoCayendoIzquierda.BackColor = System.Drawing.Color.Transparent
        Me.enemigoCayendoIzquierda.Image = Global.MetalSlug.My.Resources.Resources.CayendoIzquierda
        Me.enemigoCayendoIzquierda.Location = New System.Drawing.Point(200, -10)
        Me.enemigoCayendoIzquierda.Name = "enemigoCayendoIzquierda"
        Me.enemigoCayendoIzquierda.Size = New System.Drawing.Size(47, 50)
        Me.enemigoCayendoIzquierda.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.enemigoCayendoIzquierda.TabIndex = 32
        Me.enemigoCayendoIzquierda.TabStop = False
        Me.enemigoCayendoIzquierda.Visible = False
        '
        'Juego
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackgroundImage = Global.MetalSlug.My.Resources.Resources.MetalSlug_Mission1
        Me.ClientSize = New System.Drawing.Size(554, 195)
        Me.Controls.Add(Me.enemigoCayendoIzquierda3)
        Me.Controls.Add(Me.enemigoCayendoIzquierda2)
        Me.Controls.Add(Me.enemigoCayendo2)
        Me.Controls.Add(Me.enemigoIzquierda6)
        Me.Controls.Add(Me.enemigoIzquierda2)
        Me.Controls.Add(Me.enemigoIzquierda3)
        Me.Controls.Add(Me.enemigoIzquierda4)
        Me.Controls.Add(Me.enemigoIzquierda5)
        Me.Controls.Add(Me.enemigoIzquierda1)
        Me.Controls.Add(Me.enemigoIzquierda)
        Me.Controls.Add(Me.enemigo6)
        Me.Controls.Add(Me.enemigo5)
        Me.Controls.Add(Me.enemigo4)
        Me.Controls.Add(Me.enemigo3)
        Me.Controls.Add(Me.enemigo2)
        Me.Controls.Add(Me.enemigo1)
        Me.Controls.Add(Me.enemigo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.balaIzquierda)
        Me.Controls.Add(Me.balaPic)
        Me.Controls.Add(Me.bordeIzquieda)
        Me.Controls.Add(Me.bordeDerecha)
        Me.Controls.Add(Me.personajePrincipal)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.enemigoCayendo)
        Me.Controls.Add(Me.enemigoCayendo1)
        Me.Controls.Add(Me.enemigoCayendoIzquierda)
        Me.MaximizeBox = False
        Me.Name = "Juego"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Juego"
        CType(Me.personajePrincipal, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bordeDerecha, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.bordeIzquieda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.balaPic, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.balaIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigo6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoIzquierda1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoIzquierda5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoIzquierda4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoIzquierda3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoIzquierda2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoIzquierda6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoCayendo, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoCayendo1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoCayendo2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoCayendoIzquierda2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoCayendoIzquierda3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.enemigoCayendoIzquierda, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents personajePrincipal As PictureBox
    Friend WithEvents timerPersonaje As Timer
    Friend WithEvents timerSalto As Timer
    Friend WithEvents timerAgacho As Timer
    Friend WithEvents timerBala As Timer
    Friend WithEvents bordeDerecha As PictureBox
    Friend WithEvents bordeIzquieda As PictureBox
    Friend WithEvents balaPic As PictureBox
    Friend WithEvents balaIzquierda As PictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents timerDuracion As Timer
    Friend WithEvents enemigo As PictureBox
    Friend WithEvents enemigo1 As PictureBox
    Friend WithEvents enemigo2 As PictureBox
    Friend WithEvents enemigo3 As PictureBox
    Friend WithEvents enemigo4 As PictureBox
    Friend WithEvents enemigo5 As PictureBox
    Friend WithEvents enemigo6 As PictureBox
    Public WithEvents timerEnemigo As Timer
    Friend WithEvents enemigoIzquierda As PictureBox
    Friend WithEvents enemigoIzquierda1 As PictureBox
    Friend WithEvents enemigoIzquierda5 As PictureBox
    Friend WithEvents enemigoIzquierda4 As PictureBox
    Friend WithEvents enemigoIzquierda3 As PictureBox
    Friend WithEvents enemigoIzquierda2 As PictureBox
    Friend WithEvents timerEnemigoIzquierda As Timer
    Friend WithEvents Timer1 As Timer
    Friend WithEvents enemigoIzquierda6 As PictureBox
    Friend WithEvents timerCayendo As Timer
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents enemigoCayendo As PictureBox
    Friend WithEvents enemigoCayendo1 As PictureBox
    Friend WithEvents enemigoCayendo2 As PictureBox
    Friend WithEvents enemigoCayendoIzquierda2 As PictureBox
    Friend WithEvents enemigoCayendoIzquierda3 As PictureBox
    Friend WithEvents enemigoCayendoIzquierda As PictureBox
End Class
