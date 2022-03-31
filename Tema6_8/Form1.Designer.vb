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
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.btnRead = New System.Windows.Forms.Button()
        Me.lstShowRegisters = New System.Windows.Forms.ListBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.btnAction = New System.Windows.Forms.Button()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.rdbInsert = New System.Windows.Forms.RadioButton()
        Me.rdbModify = New System.Windows.Forms.RadioButton()
        Me.rdbDelete = New System.Windows.Forms.RadioButton()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.txtDeveloper = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtLaunch = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtId = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.btnRead)
        Me.GroupBox1.Controls.Add(Me.lstShowRegisters)
        Me.GroupBox1.Location = New System.Drawing.Point(36, 79)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(269, 243)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Leer Registros"
        '
        'btnRead
        '
        Me.btnRead.Location = New System.Drawing.Point(86, 176)
        Me.btnRead.Name = "btnRead"
        Me.btnRead.Size = New System.Drawing.Size(75, 23)
        Me.btnRead.TabIndex = 1
        Me.btnRead.Text = "Leer"
        Me.btnRead.UseVisualStyleBackColor = True
        '
        'lstShowRegisters
        '
        Me.lstShowRegisters.FormattingEnabled = True
        Me.lstShowRegisters.HorizontalScrollbar = True
        Me.lstShowRegisters.ItemHeight = 15
        Me.lstShowRegisters.Location = New System.Drawing.Point(18, 31)
        Me.lstShowRegisters.Name = "lstShowRegisters"
        Me.lstShowRegisters.Size = New System.Drawing.Size(216, 109)
        Me.lstShowRegisters.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Segoe UI", 18.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.Location = New System.Drawing.Point(99, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(553, 32)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Manipulación de BBDD en modo desconectado"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.btnAction)
        Me.GroupBox2.Controls.Add(Me.GroupBox3)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.txtDeveloper)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtLaunch)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtName)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.txtId)
        Me.GroupBox2.Location = New System.Drawing.Point(421, 71)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(298, 315)
        Me.GroupBox2.TabIndex = 2
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Editar registros tabla"
        '
        'btnAction
        '
        Me.btnAction.Location = New System.Drawing.Point(102, 269)
        Me.btnAction.Name = "btnAction"
        Me.btnAction.Size = New System.Drawing.Size(75, 23)
        Me.btnAction.TabIndex = 9
        Me.btnAction.Text = "Ejecutar"
        Me.btnAction.UseVisualStyleBackColor = True
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.rdbInsert)
        Me.GroupBox3.Controls.Add(Me.rdbModify)
        Me.GroupBox3.Controls.Add(Me.rdbDelete)
        Me.GroupBox3.Location = New System.Drawing.Point(32, 184)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(246, 67)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Acciones"
        '
        'rdbInsert
        '
        Me.rdbInsert.AutoSize = True
        Me.rdbInsert.Location = New System.Drawing.Point(163, 30)
        Me.rdbInsert.Name = "rdbInsert"
        Me.rdbInsert.Size = New System.Drawing.Size(64, 19)
        Me.rdbInsert.TabIndex = 2
        Me.rdbInsert.TabStop = True
        Me.rdbInsert.Text = "Insertar"
        Me.rdbInsert.UseVisualStyleBackColor = True
        '
        'rdbModify
        '
        Me.rdbModify.AutoSize = True
        Me.rdbModify.Location = New System.Drawing.Point(81, 30)
        Me.rdbModify.Name = "rdbModify"
        Me.rdbModify.Size = New System.Drawing.Size(76, 19)
        Me.rdbModify.TabIndex = 1
        Me.rdbModify.TabStop = True
        Me.rdbModify.Text = "Modificar"
        Me.rdbModify.UseVisualStyleBackColor = True
        '
        'rdbDelete
        '
        Me.rdbDelete.AutoSize = True
        Me.rdbDelete.Location = New System.Drawing.Point(20, 30)
        Me.rdbDelete.Name = "rdbDelete"
        Me.rdbDelete.Size = New System.Drawing.Size(57, 19)
        Me.rdbDelete.TabIndex = 0
        Me.rdbDelete.TabStop = True
        Me.rdbDelete.Text = "Borrar"
        Me.rdbDelete.UseVisualStyleBackColor = True
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(32, 148)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(77, 15)
        Me.Label5.TabIndex = 7
        Me.Label5.Text = "Desarrollador"
        '
        'txtDeveloper
        '
        Me.txtDeveloper.Location = New System.Drawing.Point(113, 145)
        Me.txtDeveloper.Name = "txtDeveloper"
        Me.txtDeveloper.Size = New System.Drawing.Size(100, 23)
        Me.txtDeveloper.TabIndex = 6
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(32, 109)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(75, 15)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "Lanzamiento"
        '
        'txtLaunch
        '
        Me.txtLaunch.Location = New System.Drawing.Point(113, 106)
        Me.txtLaunch.Name = "txtLaunch"
        Me.txtLaunch.Size = New System.Drawing.Size(100, 23)
        Me.txtLaunch.TabIndex = 4
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(32, 71)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(51, 15)
        Me.Label3.TabIndex = 3
        Me.Label3.Text = "Nombre"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(113, 68)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(100, 23)
        Me.txtName.TabIndex = 2
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(32, 30)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(17, 15)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Id"
        '
        'txtId
        '
        Me.txtId.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(128, Byte), Integer))
        Me.txtId.Location = New System.Drawing.Point(113, 30)
        Me.txtId.Name = "txtId"
        Me.txtId.Size = New System.Drawing.Size(100, 23)
        Me.txtId.TabIndex = 0
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 15.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(999, 453)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.GroupBox1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents btnRead As Button
    Friend WithEvents lstShowRegisters As ListBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents rdbInsert As RadioButton
    Friend WithEvents rdbModify As RadioButton
    Friend WithEvents rdbDelete As RadioButton
    Friend WithEvents Label5 As Label
    Friend WithEvents txtDeveloper As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents txtLaunch As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtId As TextBox
    Friend WithEvents btnAction As Button
End Class
