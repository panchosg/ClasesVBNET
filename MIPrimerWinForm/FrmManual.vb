Option Explicit On
Option Strict On
Public Class FrmManual : Inherits Form

    Friend WithEvents Button1 As Button

    Public Sub New()
        Text = "Ventana Manual"
        Name = "frmManual"
        ClientSize = New Size(300, 50)
        StartPosition = FormStartPosition.CenterScreen
    End Sub

    Private Sub InitializeComponent()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(347, 142)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 23)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Button1"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'FrmManual
        '
        Me.ClientSize = New System.Drawing.Size(689, 353)
        Me.Controls.Add(Me.Button1)
        Me.Name = "FrmManual"
        Me.ResumeLayout(False)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub FrmManual_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
