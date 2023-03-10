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
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.dtpFecha = New System.Windows.Forms.DateTimePicker()
        Me.btnmostrar = New System.Windows.Forms.Button()
        Me.lblMostrar = New System.Windows.Forms.Label()
        Me.txtCorreo = New System.Windows.Forms.TextBox()
        Me.txttelefono = New System.Windows.Forms.TextBox()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.label5 = New System.Windows.Forms.Label()
        Me.label4 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.label2 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(179, 26)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(86, 20)
        Me.txtCantidad.TabIndex = 7
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(63, 29)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(110, 13)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Cantidad de personas"
        '
        'dtpFecha
        '
        Me.dtpFecha.Format = System.Windows.Forms.DateTimePickerFormat.[Short]
        Me.dtpFecha.Location = New System.Drawing.Point(177, 100)
        Me.dtpFecha.Name = "dtpFecha"
        Me.dtpFecha.Size = New System.Drawing.Size(172, 20)
        Me.dtpFecha.TabIndex = 22
        '
        'btnmostrar
        '
        Me.btnmostrar.Location = New System.Drawing.Point(431, 91)
        Me.btnmostrar.Name = "btnmostrar"
        Me.btnmostrar.Size = New System.Drawing.Size(108, 29)
        Me.btnmostrar.TabIndex = 21
        Me.btnmostrar.Text = "Mostrar"
        Me.btnmostrar.UseVisualStyleBackColor = True
        '
        'lblMostrar
        '
        Me.lblMostrar.Location = New System.Drawing.Point(126, 210)
        Me.lblMostrar.Name = "lblMostrar"
        Me.lblMostrar.Size = New System.Drawing.Size(497, 138)
        Me.lblMostrar.TabIndex = 20
        '
        'txtCorreo
        '
        Me.txtCorreo.Location = New System.Drawing.Point(177, 170)
        Me.txtCorreo.Name = "txtCorreo"
        Me.txtCorreo.Size = New System.Drawing.Size(86, 20)
        Me.txtCorreo.TabIndex = 19
        '
        'txttelefono
        '
        Me.txttelefono.Location = New System.Drawing.Point(177, 137)
        Me.txttelefono.Name = "txttelefono"
        Me.txttelefono.Size = New System.Drawing.Size(86, 20)
        Me.txttelefono.TabIndex = 18
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(177, 62)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(86, 20)
        Me.txtNombre.TabIndex = 17
        '
        'label5
        '
        Me.label5.AutoSize = True
        Me.label5.Location = New System.Drawing.Point(61, 177)
        Me.label5.Name = "label5"
        Me.label5.Size = New System.Drawing.Size(93, 13)
        Me.label5.TabIndex = 16
        Me.label5.Text = "Correo electronico"
        '
        'label4
        '
        Me.label4.AutoSize = True
        Me.label4.Location = New System.Drawing.Point(61, 140)
        Me.label4.Name = "label4"
        Me.label4.Size = New System.Drawing.Size(100, 13)
        Me.label4.TabIndex = 15
        Me.label4.Text = "Numero de telefono"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(61, 107)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(106, 13)
        Me.Label1.TabIndex = 14
        Me.Label1.Text = "Fecha de nacimiento"
        '
        'label2
        '
        Me.label2.AutoSize = True
        Me.label2.Location = New System.Drawing.Point(99, 64)
        Me.label2.Name = "label2"
        Me.label2.Size = New System.Drawing.Size(44, 13)
        Me.label2.TabIndex = 13
        Me.label2.Text = "Nombre"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.dtpFecha)
        Me.Controls.Add(Me.btnmostrar)
        Me.Controls.Add(Me.lblMostrar)
        Me.Controls.Add(Me.txtCorreo)
        Me.Controls.Add(Me.txttelefono)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.label5)
        Me.Controls.Add(Me.label4)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.label2)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label3)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Private WithEvents txtCantidad As TextBox
    Private WithEvents Label3 As Label
    Private WithEvents dtpFecha As DateTimePicker
    Private WithEvents btnmostrar As Button
    Private WithEvents lblMostrar As Label
    Private WithEvents txtCorreo As TextBox
    Private WithEvents txttelefono As TextBox
    Private WithEvents txtNombre As TextBox
    Private WithEvents label5 As Label
    Private WithEvents label4 As Label
    Private WithEvents Label1 As Label
    Private WithEvents label2 As Label
End Class
