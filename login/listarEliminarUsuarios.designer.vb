<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class listarEliminarUsuarios
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(listarEliminarUsuarios))
        Me.Boton_Listar = New System.Windows.Forms.Button()
        Me.Boton_Eliminar = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.DGTabla = New System.Windows.Forms.DataGridView()
        Me.txtCodigo = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Boton_listarTodo = New System.Windows.Forms.Button()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Boton_Listar
        '
        Me.Boton_Listar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_Listar.Location = New System.Drawing.Point(370, 136)
        Me.Boton_Listar.Name = "Boton_Listar"
        Me.Boton_Listar.Size = New System.Drawing.Size(131, 45)
        Me.Boton_Listar.TabIndex = 0
        Me.Boton_Listar.Text = "Listar Usuario"
        Me.Boton_Listar.UseVisualStyleBackColor = True
        '
        'Boton_Eliminar
        '
        Me.Boton_Eliminar.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_Eliminar.Location = New System.Drawing.Point(693, 136)
        Me.Boton_Eliminar.Name = "Boton_Eliminar"
        Me.Boton_Eliminar.Size = New System.Drawing.Size(131, 45)
        Me.Boton_Eliminar.TabIndex = 1
        Me.Boton_Eliminar.Text = "Eliminar"
        Me.Boton_Eliminar.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(693, 404)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(131, 45)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Salir"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'DGTabla
        '
        Me.DGTabla.AllowUserToAddRows = False
        Me.DGTabla.AllowUserToDeleteRows = False
        Me.DGTabla.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGTabla.Location = New System.Drawing.Point(13, 212)
        Me.DGTabla.Name = "DGTabla"
        Me.DGTabla.ReadOnly = True
        Me.DGTabla.Size = New System.Drawing.Size(811, 170)
        Me.DGTabla.TabIndex = 4
        '
        'txtCodigo
        '
        Me.txtCodigo.Font = New System.Drawing.Font("Arial Narrow", 11.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtCodigo.Location = New System.Drawing.Point(30, 156)
        Me.txtCodigo.MaxLength = 10
        Me.txtCodigo.Name = "txtCodigo"
        Me.txtCodigo.Size = New System.Drawing.Size(157, 25)
        Me.txtCodigo.TabIndex = 5
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Arial Narrow", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(45, Byte), Integer), CType(CType(105, Byte), Integer), CType(CType(227, Byte), Integer))
        Me.Label1.Location = New System.Drawing.Point(74, 130)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(70, 23)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "Codigo:"
        '
        'Boton_listarTodo
        '
        Me.Boton_listarTodo.Font = New System.Drawing.Font("Arial Narrow", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Boton_listarTodo.Location = New System.Drawing.Point(534, 136)
        Me.Boton_listarTodo.Name = "Boton_listarTodo"
        Me.Boton_listarTodo.Size = New System.Drawing.Size(131, 45)
        Me.Boton_listarTodo.TabIndex = 11
        Me.Boton_listarTodo.Text = "Listar Todo"
        Me.Boton_listarTodo.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.BackgroundImage = CType(resources.GetObject("Panel1.BackgroundImage"), System.Drawing.Image)
        Me.Panel1.Dock = System.Windows.Forms.DockStyle.Top
        Me.Panel1.Location = New System.Drawing.Point(0, 0)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(850, 102)
        Me.Panel1.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(850, 461)
        Me.Controls.Add(Me.Boton_listarTodo)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtCodigo)
        Me.Controls.Add(Me.DGTabla)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Boton_Eliminar)
        Me.Controls.Add(Me.Boton_Listar)
        Me.Controls.Add(Me.Panel1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        CType(Me.DGTabla, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Boton_Listar As Button
    Friend WithEvents Boton_Eliminar As Button
    Friend WithEvents Button2 As Button
    Friend WithEvents DGTabla As DataGridView
    Friend WithEvents txtCodigo As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Boton_listarTodo As Button
    Friend WithEvents Panel1 As Panel
End Class
