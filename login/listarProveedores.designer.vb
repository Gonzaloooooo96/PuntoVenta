<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class listarProveedores
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listarProveedores))
        Me.DGTabla = New System.Windows.Forms.DataGridView()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.boton_ListarT = New System.Windows.Forms.Button()
        Me.boton_Listar = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtRut = New System.Windows.Forms.TextBox()
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'DGTabla
        '
        Me.DGTabla.AllowUserToAddRows = False
        Me.DGTabla.AllowUserToDeleteRows = False
        Me.DGTabla.BackgroundColor = System.Drawing.SystemColors.ControlLightLight
        Me.DGTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTabla.Location = New System.Drawing.Point(28, 202)
        Me.DGTabla.Name = "DGTabla"
        Me.DGTabla.ReadOnly = True
        Me.DGTabla.Size = New System.Drawing.Size(862, 209)
        Me.DGTabla.TabIndex = 0
        '
        'txtNombre
        '
        Me.txtNombre.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtNombre.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtNombre.Location = New System.Drawing.Point(200, 125)
        Me.txtNombre.Multiline = True
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(140, 30)
        Me.txtNombre.TabIndex = 4
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.Button2.Location = New System.Drawing.Point(790, 417)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(100, 37)
        Me.Button2.TabIndex = 40
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label6.Location = New System.Drawing.Point(345, 174)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(228, 23)
        Me.Label6.TabIndex = 41
        Me.Label6.Text = "DETALLE DE PROVEEDORES"
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(921, 103)
        Me.Panel1.TabIndex = 42
        '
        'boton_ListarT
        '
        Me.boton_ListarT.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.boton_ListarT.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton_ListarT.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_ListarT.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.boton_ListarT.Location = New System.Drawing.Point(790, 120)
        Me.boton_ListarT.Name = "boton_ListarT"
        Me.boton_ListarT.Size = New System.Drawing.Size(100, 37)
        Me.boton_ListarT.TabIndex = 43
        Me.boton_ListarT.Text = "Listar todo"
        Me.boton_ListarT.UseVisualStyleBackColor = False
        '
        'boton_Listar
        '
        Me.boton_Listar.BackColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.boton_Listar.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.boton_Listar.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.boton_Listar.ForeColor = System.Drawing.Color.FromArgb(CType(CType(243, Byte), Integer), CType(CType(243, Byte), Integer), CType(CType(244, Byte), Integer))
        Me.boton_Listar.Location = New System.Drawing.Point(666, 120)
        Me.boton_Listar.Name = "boton_Listar"
        Me.boton_Listar.Size = New System.Drawing.Size(100, 37)
        Me.boton_Listar.TabIndex = 44
        Me.boton_Listar.Text = "Listar"
        Me.boton_Listar.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label3.Location = New System.Drawing.Point(24, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(170, 23)
        Me.Label3.TabIndex = 45
        Me.Label3.Text = "Nombre del proveedor:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(345, 128)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(145, 23)
        Me.Label1.TabIndex = 46
        Me.Label1.Text = "RUT del proveedor:"
        '
        'txtRut
        '
        Me.txtRut.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtRut.ForeColor = System.Drawing.Color.FromArgb(CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.txtRut.Location = New System.Drawing.Point(496, 125)
        Me.txtRut.Multiline = True
        Me.txtRut.Name = "txtRut"
        Me.txtRut.Size = New System.Drawing.Size(140, 30)
        Me.txtRut.TabIndex = 47
        '
        'listarProveedores
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlLightLight
        Me.ClientSize = New System.Drawing.Size(921, 460)
        Me.Controls.Add(Me.txtRut)
        Me.Controls.Add(Me.boton_Listar)
        Me.Controls.Add(Me.boton_ListarT)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.DGTabla)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label1)
        Me.Name = "listarProveedores"
        Me.Text = "Form1"
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents DGTabla As DataGridView
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents Button2 As Button
    Friend WithEvents Label6 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents boton_ListarT As Button
    Friend WithEvents boton_Listar As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents txtRut As TextBox
End Class
