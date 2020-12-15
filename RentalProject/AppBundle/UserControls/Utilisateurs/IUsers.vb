Public Class IUsers
    Dim mainForm As MainForm

    Sub New(main As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainForm = main
        DeleteButton.Enabled = False
        ModifyButton.Enabled = False
    End Sub

    Private Sub IUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVUsers.DataSource = EntityUser.getInstance().getUsers()
        DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs)
        Dim user As New IUserSearch(Me)
        user.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(user)
        user.BringToFront()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs)
        If DGVUsers.Rows.Count <> 0 Then
            If MessageBox.Show("Êtes-vous sûr de vouloir effacer cet utilisateur?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
                Dim selectIndex As Integer = DGVUsers.SelectedCells(0).RowIndex
                Dim selectRow As DataGridViewRow = DGVUsers.Rows(selectIndex)
                Dim matricule As Integer = selectRow.Cells("matricule").Value

                ModelUsers.getInstance.deleteUserByMatricule(matricule)
                DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect

            End If
        Else
            DGVUsers.Select()
        End If
        DGVUsers.DataSource = EntityUser.getInstance().getUsers()
        DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub DGVUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsers.CellContentClick
        DeleteButton.Enabled = True
        ModifyButton.Enabled = True
    End Sub

    Private Sub ModifyButton_Click(sender As Object, e As EventArgs)
        If MessageBox.Show("Voulez-vous changer le statut de cet utilisateur?", "Attention", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) = DialogResult.Yes Then
            Dim selectIndex As Integer = DGVUsers.SelectedCells(0).RowIndex
            Dim selectRow As DataGridViewRow = DGVUsers.Rows(selectIndex)
            Dim matricule As Integer = selectRow.Cells("matricule").Value
            Dim statut As String = selectRow.Cells("statut").Value

            If (statut = "Utilisateur") Then
                ModelUsers.getInstance.changeStatut(matricule, "Administrateur")
            Else
                ModelUsers.getInstance.changeStatut(matricule, "Utilisateur")
            End If
        End If
        DGVUsers.DataSource = EntityUser.getInstance().getUsers()
        DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub
End Class
