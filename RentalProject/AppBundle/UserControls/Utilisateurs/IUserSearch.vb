Imports System.Text.RegularExpressions

Public Class IUserSearch

    Dim user As IUsers
    Dim mainForm As MainForm

    Sub New(utilisateur As IUsers)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        user = utilisateur
        SearchButton.Enabled = False
        ByMatricule.Checked = True
    End Sub

    Private Sub IUserSearch_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVUsers.DataSource = EntityUser.getInstance().getUsers()
        DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    ''' <summary>
    ''' Fait la gestion des champs textes lorsq'un boutton radio différent
    ''' est sélectionné.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>

    Private Sub Radio_CheckedChanged(sender As Object, e As EventArgs) Handles ByStatut.CheckedChanged, ByMatricule.CheckedChanged
        TBMatricule.Text = ""
        CBStatut.Text = ""

        If ByMatricule.Checked Then
            TBMatricule.Enabled = True
            CBStatut.Enabled = False
        ElseIf ByStatut.Checked Then
            TBMatricule.Enabled = False
            CBStatut.Enabled = True
        End If
    End Sub

    ''' <summary>
    ''' Fait la gestion des valeurs entrées dans les champs textes.
    ''' </summary>
    ''' <param name="sender"></param>
    ''' <param name="e"></param>
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        SearchUsers()
    End Sub

    Private Sub SearchUsers()

        Dim matricule = Trim(TBMatricule.Text)

        If (matricule.Length > 0) And ByMatricule.Checked Then
            DGVUsers.DataSource = EntityUser.getInstance.getUsersByMatricule(matricule)
        ElseIf CBStatut.Text.Length > 0 And ByStatut.Checked Then
            DGVUsers.DataSource = EntityUser.getInstance.getUsersByStatut(CBStatut.Text)
        End If

        If DGVUsers.Rows.Count = 0 Then
            MessageBox.Show("Il n'y a aucun utilisateur de trouvée selon ces paramètres")
            DGVUsers.DataSource = EntityUser.getInstance().getUsers()
        End If

    End Sub

    Private Sub SearchBoxes_TextChanged(sender As Object, e As EventArgs) Handles TBMatricule.TextChanged, CBStatut.TextChanged
        Dim matricule = Trim(TBMatricule.Text)
        Dim statut = Trim(CBStatut.Text)

        If (matricule.Length > 0 Or (ByStatut.Checked And statut.Length > 0)) Then
            SearchButton.Enabled = True
        Else
            SearchButton.Enabled = False
        End If
    End Sub

    Private Sub BackButton_Click(sender As Object, e As EventArgs) Handles BackButton.Click
        Me.SendToBack()
    End Sub
End Class
