Public Class IUsers
    Dim mainForm As MainForm

    Sub New(main As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainForm = main
        DeleteButton.Enabled = False
    End Sub

    Private Sub IUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVUsers.DataSource = EntityUser.getInstance().getUsers()
        DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        Dim user As New IUserSearch(Me)
        user.Dock = DockStyle.Fill
        mainForm.InterfacePanel.Controls.Add(user)
        user.BringToFront()
    End Sub

    Private Sub DeleteButton_Click(sender As Object, e As EventArgs) Handles DeleteButton.Click
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
    End Sub

    Private Sub AddButton_Click(sender As Object, e As EventArgs) Handles AddButton.Click

    End Sub

    Private Sub DGVUsers_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DGVUsers.CellContentClick
        DeleteButton.Enabled = True
    End Sub
End Class
