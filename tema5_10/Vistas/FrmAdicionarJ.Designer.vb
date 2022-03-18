<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FrmAdicionarJ
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
        Me.TituloFormulario = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNombre = New System.Windows.Forms.TextBox()
        Me.txtDorsal = New System.Windows.Forms.TextBox()
        Me.txtSueldo = New System.Windows.Forms.TextBox()
        Me.chkLicenciaEnVigor = New System.Windows.Forms.CheckBox()
        Me.btnAceptar = New System.Windows.Forms.Button()
        Me.btnCancelar = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'TituloFormulario
        '
        Me.TituloFormulario.AutoSize = True
        Me.TituloFormulario.Font = New System.Drawing.Font("Segoe UI", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.TituloFormulario.Location = New System.Drawing.Point(57, 19)
        Me.TituloFormulario.Name = "TituloFormulario"
        Me.TituloFormulario.Size = New System.Drawing.Size(164, 30)
        Me.TituloFormulario.TabIndex = 0
        Me.TituloFormulario.Text = "TituloFormulario"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(45, 72)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(51, 15)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Nombre"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(45, 99)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(40, 15)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Dorsal"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(46, 128)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(96, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Licencia en vigor"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(45, 157)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(43, 15)
        Me.Label4.TabIndex = 4
        Me.Label4.Text = "Sueldo"
        '
        'txtNombre
        '
        Me.txtNombre.Location = New System.Drawing.Point(175, 69)
        Me.txtNombre.Name = "txtNombre"
        Me.txtNombre.Size = New System.Drawing.Size(100, 23)
        Me.txtNombre.TabIndex = 5
        '
        'txtDorsal
        '
        Me.txtDorsal.Location = New System.Drawing.Point(175, 99)
        Me.txtDorsal.Name = "txtDorsal"
        Me.txtDorsal.Size = New System.Drawing.Size(100, 23)
        Me.txtDorsal.TabIndex = 6
        '
        'txtSueldo
        '
        Me.txtSueldo.Location = New System.Drawing.Point(175, 149)
        Me.txtSueldo.Name = "txtSueldo"
        Me.txtSueldo.Size = New System.Drawing.Size(100, 23)
        Me.txtSueldo.TabIndex = 7
        '
        'chkLicenciaEnVigor
        '
        Me.chkLicenciaEnVigor.AutoSize = True
        Me.chkLicenciaEnVigor.Location = New System.Drawing.Point(216, 128)
        Me.chkLicenciaEnVigor.Name = "chkLicenciaEnVigor"
        Me.chkLicenciaEnVigor.Size = New System.Drawing.Size(35, 19)
        Me.chkLicenciaEnVigor.TabIndex = 8
        Me.chkLicenciaEnVigor.Text = "Si"
        Me.chkLicenciaEnVigor.UseVisualStyleBackColor = True
        '
        'btnAceptar
        '
        Me.btnAceptar.Location = New System.Drawing.Point(45, 213)
        Me.btnAceptar.Name = "btnAceptar"
        Me.btnAceptar.Size = New System.Drawing.Size(75, 23)
        Me.btnAceptar.TabIndex = 9
        Me.btnAceptar.Text = "Aceptar"
        Me.btnAceptar.UseVisualStyleBackColor = True
        '
        'btnCancelar
        '
        Me.btnCancelar.Location = New System.Drawing.Point(200, 213)
        Me.btnCancelar.Name = "btnCancelar"
        Me.btnCancelar.Size = New System.Drawing.Size(75, 23)
        Me.btnCancelar.TabIndex = 10
        Me.btnCancelar.Text = "Cancelar"
        Me.btnCancelar.UseVisualStyleBackColor = True
        '
        'FrmAdicionarJ
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(331, 267)
        Me.Controls.Add(Me.btnCancelar)
        Me.Controls.Add(Me.btnAceptar)
        Me.Controls.Add(Me.chkLicenciaEnVigor)
        Me.Controls.Add(Me.txtSueldo)
        Me.Controls.Add(Me.txtDorsal)
        Me.Controls.Add(Me.txtNombre)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.TituloFormulario)
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "FrmAdicionarJ"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "FrmAdicionarJ"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TituloFormulario As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents txtNombre As TextBox
    Friend WithEvents txtDorsal As TextBox
    Friend WithEvents txtSueldo As TextBox
    Friend WithEvents chkLicenciaEnVigor As CheckBox
    Friend WithEvents btnAceptar As Button
    Friend WithEvents btnCancelar As Button
End Class
