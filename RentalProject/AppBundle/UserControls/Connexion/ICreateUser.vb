Public Class ICreateUser

    Private Sub BTCreer_Click(sender As Object, e As EventArgs) Handles BTCreer.Click
        Dim matricule, password, passwordRep

        matricule = Trim(TBMatricule.Text)
        password = Trim(TBPassword.Text)
        passwordRep = Trim(TBPasswordRepeat.Text)

        If (matricule.Length > 0 And password.Length > 0) Then
            If (IsNumeric(matricule)) Then
                If (password = passwordRep) Then
                    ModelUsers.getInstance.addUser(matricule, password)
                    Dim connect As New IConnexion()
                    connect.Dock = DockStyle.Fill
                    Connexion.InterfacePanel.Controls.Add(connect)
                    connect.BringToFront()
                Else
                    MessageBox.Show("Les mots de passes ne sont pas les mêmes", "Attention")
                    TBPassword.Text = ""
                    TBPasswordRepeat.Text = ""
                End If
            Else
                MessageBox.Show("La matricule doit être numérique", "Attention")
            End If

        Else
            MessageBox.Show("Vous devez remplir tous les champs", "Attention")
        End If
    End Sub

    Private Sub BTAnnuler_Click(sender As Object, e As EventArgs) Handles BTAnnuler.Click
        Dim connect As New IConnexion()
        connect.Dock = DockStyle.Fill
        Connexion.InterfacePanel.Controls.Add(connect)
        connect.BringToFront()
    End Sub
End Class
