Public Class Form1
    Private _dbAccess As DataAccessClient

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles Me.Load
        _dbAccess = New DataAccessClient("DESKTOP-RSPABI0", "prueba", "fernando", "050584")
    End Sub
    Private Sub btnRead_Click(sender As Object, e As EventArgs) Handles btnRead.Click
        lstShowRegisters.DataSource = _dbAccess.ReadAllRows()
    End Sub

    Private Sub btnAction_Click(sender As Object, e As EventArgs) Handles btnAction.Click
        Dim rowsModified As Integer
        Dim gestoresData As GestoresBD

        If rdbInsert.Checked = True Then
            rowsModified = _dbAccess.InsertRow(txtName.Text, CInt(txtLaunch.Text), txtDeveloper.Text)
            If rowsModified > 0 Then
                MessageBox.Show("Registro insertado")
            End If
        End If

        If rdbModify.Checked = True Then
                gestoresData = New GestoresBD(CInt(txtId.Text), txtName.Text, CInt(txtLaunch.Text), txtDeveloper.Text)
                rowsModified = _dbAccess.RowModify(gestoresData)
                If rowsModified > 0 Then
                    MessageBox.Show("Registro insertado")
                End If

            End If
    End Sub
End Class
