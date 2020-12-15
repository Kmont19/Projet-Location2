Public Class IConnexion
    Private Sub BTConnexion_Click(sender As Object, e As EventArgs) Handles BTConnexion.Click

        Dim matricule, password

        matricule = Trim(TBMatricule.Text)
        password = Trim(TBPassword.Text)

        If (matricule.Length > 0 And password.Length > 0) Then
            Dim verif As Boolean = EntityUser.getInstance.verifUser(matricule, password)

            If (verif = True) Then
                Dim main = New MainForm()
                main.Show()
                Connexion.Close()
            Else
                MessageBox.Show("Les données de connexion sont incorrects, veuillez essayer à nouveau.", "Error de connexion")
            End If
        Else
            MessageBox.Show("Vous devez remplir tous les champs", "Attention")
        End If

    End Sub

    Private Sub BTCreer_Click(sender As Object, e As EventArgs) Handles BTCreer.Click
        Dim addUser As New ICreateUser()
        addUser.Dock = DockStyle.Fill
        Connexion.InterfacePanel.Controls.Add(addUser)
        addUser.BringToFront()
    End Sub
End Class
