<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class registroUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(registroUsuarios))
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.nombre_cuenta = New System.Windows.Forms.TextBox()
        Me.pass_cuenta = New System.Windows.Forms.TextBox()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label14 = New System.Windows.Forms.Label()
        Me.Label15 = New System.Windows.Forms.Label()
        Me.Label16 = New System.Windows.Forms.Label()
        Me.respuesta1 = New System.Windows.Forms.TextBox()
        Me.Label18 = New System.Windows.Forms.Label()
        Me.Label17 = New System.Windows.Forms.Label()
        Me.respuesta2 = New System.Windows.Forms.TextBox()
        Me.pregunta1 = New System.Windows.Forms.ComboBox()
        Me.pregunta2 = New System.Windows.Forms.ComboBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.CBtipousu = New System.Windows.Forms.ComboBox()
        Me.SuspendLayout()
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(879, 108)
        Me.Panel1.TabIndex = 0
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label2.Location = New System.Drawing.Point(290, 116)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(299, 25)
        Me.Label2.TabIndex = 0
        Me.Label2.Text = "PASO 1: DATOS PARA LA CUENTA"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(360, 185)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(171, 20)
        Me.Label3.TabIndex = 0
        Me.Label3.Text = "Ingrese un nombre de cuenta"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label4.Location = New System.Drawing.Point(621, 185)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(139, 20)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Ingrese una contraseña"
        '
        'nombre_cuenta
        '
        Me.nombre_cuenta.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.nombre_cuenta.Location = New System.Drawing.Point(355, 207)
        Me.nombre_cuenta.MaxLength = 10
        Me.nombre_cuenta.Name = "nombre_cuenta"
        Me.nombre_cuenta.Size = New System.Drawing.Size(176, 26)
        Me.nombre_cuenta.TabIndex = 2
        Me.nombre_cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'pass_cuenta
        '
        Me.pass_cuenta.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pass_cuenta.Location = New System.Drawing.Point(606, 207)
        Me.pass_cuenta.MaxLength = 10
        Me.pass_cuenta.Name = "pass_cuenta"
        Me.pass_cuenta.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.pass_cuenta.Size = New System.Drawing.Size(176, 26)
        Me.pass_cuenta.TabIndex = 3
        Me.pass_cuenta.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(788, 208)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(53, 26)
        Me.Button6.TabIndex = 0
        Me.Button6.TabStop = False
        Me.Button6.Text = "Ver Contraseña"
        Me.Button6.UseVisualStyleBackColor = True
        Me.Button6.Visible = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(197, 141)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(483, 20)
        Me.Label6.TabIndex = 23
        Me.Label6.Text = "Los datos que debe completar en este paso son necesarios para el ingreso al siste" & _
    "ma."
        '
        'Button1
        '
        Me.Button1.Enabled = False
        Me.Button1.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(673, 446)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(168, 45)
        Me.Button1.TabIndex = 7
        Me.Button1.Text = "Finalizar"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(33, 446)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(168, 45)
        Me.Button2.TabIndex = 8
        Me.Button2.Text = "Cancelar"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Label14
        '
        Me.Label14.AutoSize = True
        Me.Label14.Font = New System.Drawing.Font("Arial Narrow", 15.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label14.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label14.Location = New System.Drawing.Point(186, 248)
        Me.Label14.Name = "Label14"
        Me.Label14.Size = New System.Drawing.Size(533, 25)
        Me.Label14.TabIndex = 19
        Me.Label14.Text = "PASO 2: PREGUNTAS PARA RECUPERACIÓN DE CONTRASEÑA"
        '
        'Label15
        '
        Me.Label15.AutoSize = True
        Me.Label15.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label15.Location = New System.Drawing.Point(121, 315)
        Me.Label15.Name = "Label15"
        Me.Label15.Size = New System.Drawing.Size(258, 20)
        Me.Label15.TabIndex = 11
        Me.Label15.Text = "Seleccione la primera pregunta de seguridad"
        '
        'Label16
        '
        Me.Label16.AutoSize = True
        Me.Label16.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label16.Location = New System.Drawing.Point(140, 372)
        Me.Label16.Name = "Label16"
        Me.Label16.Size = New System.Drawing.Size(222, 20)
        Me.Label16.TabIndex = 13
        Me.Label16.Text = "Ingrese respuesta de primera pregunta"
        '
        'respuesta1
        '
        Me.respuesta1.Enabled = False
        Me.respuesta1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.respuesta1.Location = New System.Drawing.Point(100, 394)
        Me.respuesta1.MaxLength = 40
        Me.respuesta1.Name = "respuesta1"
        Me.respuesta1.Size = New System.Drawing.Size(299, 25)
        Me.respuesta1.TabIndex = 4
        '
        'Label18
        '
        Me.Label18.AutoSize = True
        Me.Label18.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label18.Location = New System.Drawing.Point(497, 315)
        Me.Label18.Name = "Label18"
        Me.Label18.Size = New System.Drawing.Size(263, 20)
        Me.Label18.TabIndex = 15
        Me.Label18.Text = "Seleccione la segunda pregunta de seguridad"
        '
        'Label17
        '
        Me.Label17.AutoSize = True
        Me.Label17.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label17.Location = New System.Drawing.Point(515, 372)
        Me.Label17.Name = "Label17"
        Me.Label17.Size = New System.Drawing.Size(227, 20)
        Me.Label17.TabIndex = 17
        Me.Label17.Text = "Ingrese respuesta de segunda pregunta"
        '
        'respuesta2
        '
        Me.respuesta2.Enabled = False
        Me.respuesta2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.respuesta2.Location = New System.Drawing.Point(480, 394)
        Me.respuesta2.MaxLength = 40
        Me.respuesta2.Name = "respuesta2"
        Me.respuesta2.Size = New System.Drawing.Size(299, 25)
        Me.respuesta2.TabIndex = 6
        '
        'pregunta1
        '
        Me.pregunta1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pregunta1.Enabled = False
        Me.pregunta1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pregunta1.FormattingEnabled = True
        Me.pregunta1.Items.AddRange(New Object() {"¿Cual es su ciudad natal?", "¿Cual es su comida preferida?", "¿Cual es su serie favorita?", "¿Cual es su mayor miedo?", "¿Cual es su bebida favorita?", "¿Cual es su película favorita?", "¿Cual es el nombre de su primera mascota?"})
        Me.pregunta1.Location = New System.Drawing.Point(100, 337)
        Me.pregunta1.Name = "pregunta1"
        Me.pregunta1.Size = New System.Drawing.Size(299, 28)
        Me.pregunta1.TabIndex = 3
        '
        'pregunta2
        '
        Me.pregunta2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.pregunta2.Enabled = False
        Me.pregunta2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.pregunta2.FormattingEnabled = True
        Me.pregunta2.Items.AddRange(New Object() {"¿Cual es su ciudad natal?", "¿Cual es su comida preferida?", "¿Cual es su serie favorita?", "¿Cual es su mayor miedo?", "¿Cual es su bebida favorita?", "¿Cual es su película favorita?", "¿Cual es el nombre de su primera mascota?"})
        Me.pregunta2.Location = New System.Drawing.Point(480, 337)
        Me.pregunta2.Name = "pregunta2"
        Me.pregunta2.Size = New System.Drawing.Size(299, 28)
        Me.pregunta2.TabIndex = 5
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label5.Location = New System.Drawing.Point(66, 273)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(742, 20)
        Me.Label5.TabIndex = 22
        Me.Label5.Text = "Debe elegir 2 preguntas e ingresar la respuesta de cada una, las respuestas le se" & _
    "rán solicitadas en caso de que olvide su contraseña."
        '
        'Label7
        '
        Me.Label7.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label7.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label7.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label7.ForeColor = System.Drawing.Color.Transparent
        Me.Label7.Location = New System.Drawing.Point(254, 293)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(370, 20)
        Me.Label7.TabIndex = 0
        Me.Label7.Text = "Para iniciar este paso debe llenar todos los campos del paso 1"
        Me.Label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Transparent
        Me.Label1.Location = New System.Drawing.Point(673, 492)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(168, 20)
        Me.Label1.TabIndex = 24
        Me.Label1.Text = "Debe completar paso 1 y 2"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(96, 185)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(170, 20)
        Me.Label8.TabIndex = 25
        Me.Label8.Text = "Seleccione un tipo de cuenta"
        '
        'CBtipousu
        '
        Me.CBtipousu.FormattingEnabled = True
        Me.CBtipousu.Location = New System.Drawing.Point(100, 213)
        Me.CBtipousu.Name = "CBtipousu"
        Me.CBtipousu.Size = New System.Drawing.Size(166, 21)
        Me.CBtipousu.TabIndex = 1
        '
        'registroUsuarios
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(879, 516)
        Me.Controls.Add(Me.CBtipousu)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.pregunta2)
        Me.Controls.Add(Me.pregunta1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.respuesta2)
        Me.Controls.Add(Me.Label17)
        Me.Controls.Add(Me.Label18)
        Me.Controls.Add(Me.respuesta1)
        Me.Controls.Add(Me.Label16)
        Me.Controls.Add(Me.Label15)
        Me.Controls.Add(Me.pass_cuenta)
        Me.Controls.Add(Me.nombre_cuenta)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label7)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label14)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "registroUsuarios"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "n"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents nombre_cuenta As TextBox
    Friend WithEvents pass_cuenta As TextBox
    Friend WithEvents Button6 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents Label14 As Label
    Friend WithEvents Label15 As Label
    Friend WithEvents Label16 As Label
    Friend WithEvents respuesta1 As TextBox
    Friend WithEvents Label18 As Label
    Friend WithEvents Label17 As Label
    Friend WithEvents respuesta2 As TextBox
    Friend WithEvents pregunta1 As ComboBox
    Friend WithEvents pregunta2 As ComboBox
    Friend WithEvents Label5 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents CBtipousu As System.Windows.Forms.ComboBox
End Class
