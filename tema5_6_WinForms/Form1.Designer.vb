<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.txtUsuario = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.rdbMoto = New System.Windows.Forms.RadioButton()
        Me.rdbCamion = New System.Windows.Forms.RadioButton()
        Me.rdbCoche = New System.Windows.Forms.RadioButton()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtMatricula = New System.Windows.Forms.TextBox()
        Me.cmbPieza = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtCantidad = New System.Windows.Forms.TextBox()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnSalir = New System.Windows.Forms.Button()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'txtUsuario
        '
        Me.txtUsuario.Location = New System.Drawing.Point(134, 55)
        Me.txtUsuario.Name = "txtUsuario"
        Me.txtUsuario.Size = New System.Drawing.Size(242, 23)
        Me.txtUsuario.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(21, 58)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(107, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre del dueño"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.rdbMoto)
        Me.GroupBox1.Controls.Add(Me.rdbCamion)
        Me.GroupBox1.Controls.Add(Me.rdbCoche)
        Me.GroupBox1.Location = New System.Drawing.Point(134, 117)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(116, 105)
        Me.GroupBox1.TabIndex = 2
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Tipo de vehículo"
        '
        'rdbMoto
        '
        Me.rdbMoto.AutoSize = True
        Me.rdbMoto.Location = New System.Drawing.Point(6, 72)
        Me.rdbMoto.Name = "rdbMoto"
        Me.rdbMoto.Size = New System.Drawing.Size(54, 19)
        Me.rdbMoto.TabIndex = 2
        Me.rdbMoto.TabStop = True
        Me.rdbMoto.Text = "Moto"
        Me.rdbMoto.UseVisualStyleBackColor = True
        '
        'rdbCamion
        '
        Me.rdbCamion.AutoSize = True
        Me.rdbCamion.Location = New System.Drawing.Point(6, 22)
        Me.rdbCamion.Name = "rdbCamion"
        Me.rdbCamion.Size = New System.Drawing.Size(67, 19)
        Me.rdbCamion.TabIndex = 1
        Me.rdbCamion.TabStop = True
        Me.rdbCamion.Text = "Camión"
        Me.rdbCamion.UseVisualStyleBackColor = True
        '
        'rdbCoche
        '
        Me.rdbCoche.AutoSize = True
        Me.rdbCoche.Location = New System.Drawing.Point(6, 47)
        Me.rdbCoche.Name = "rdbCoche"
        Me.rdbCoche.Size = New System.Drawing.Size(59, 19)
        Me.rdbCoche.TabIndex = 0
        Me.rdbCoche.TabStop = True
        Me.rdbCoche.Text = "Coche"
        Me.rdbCoche.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(21, 91)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(105, 15)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Matrícula vehículo"
        '
        'txtMatricula
        '
        Me.txtMatricula.Location = New System.Drawing.Point(134, 88)
        Me.txtMatricula.Name = "txtMatricula"
        Me.txtMatricula.Size = New System.Drawing.Size(242, 23)
        Me.txtMatricula.TabIndex = 3
        '
        'cmbPieza
        '
        Me.cmbPieza.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbPieza.FormattingEnabled = True
        Me.cmbPieza.Location = New System.Drawing.Point(134, 228)
        Me.cmbPieza.Name = "cmbPieza"
        Me.cmbPieza.Size = New System.Drawing.Size(121, 23)
        Me.cmbPieza.TabIndex = 5
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(92, 231)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(34, 15)
        Me.Label3.TabIndex = 6
        Me.Label3.Text = "Pieza"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(272, 231)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(55, 15)
        Me.Label4.TabIndex = 7
        Me.Label4.Text = "Cantidad"
        '
        'txtCantidad
        '
        Me.txtCantidad.Location = New System.Drawing.Point(333, 228)
        Me.txtCantidad.Name = "txtCantidad"
        Me.txtCantidad.Size = New System.Drawing.Size(43, 23)
        Me.txtCantidad.TabIndex = 8
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Font = New System.Drawing.Font("Segoe UI", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Label5.Location = New System.Drawing.Point(49, 9)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(316, 30)
        Me.Label5.TabIndex = 9
        Me.Label5.Text = "FORMULARIO DE REPARACIÓN"
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(119, 299)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 10
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnSalir
        '
        Me.btnSalir.Location = New System.Drawing.Point(252, 299)
        Me.btnSalir.Name = "btnSalir"
        Me.btnSalir.Size = New System.Drawing.Size(75, 23)
        Me.btnSalir.TabIndex = 11
        Me.btnSalir.Text = "Salir"
        Me.btnSalir.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(430, 395)
        Me.Controls.Add(Me.btnSalir)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.txtCantidad)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.cmbPieza)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.txtMatricula)
        Me.Controls.Add(Me.GroupBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtUsuario)
        Me.Name = "Form1"
        Me.Text = "Formulario de reparación"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents txtUsuario As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents rdbMoto As RadioButton
    Friend WithEvents rdbCamion As RadioButton
    Friend WithEvents rdbCoche As RadioButton
    Friend WithEvents Label2 As Label
    Friend WithEvents txtMatricula As TextBox
    Friend WithEvents cmbPieza As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtCantidad As TextBox
    Friend WithEvents Label5 As Label
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnSalir As Button
End Class
