Public Class IUsers
    Dim mainForm As MainForm

    Sub New(main As MainForm)

        ' Cet appel est requis par le concepteur.
        InitializeComponent()
        ' Ajoutez une initialisation quelconque après l'appel InitializeComponent().
        mainForm = main
        DetailsButton.Enabled = False
        DeleteButton.Enabled = False
        ModifyButton.Enabled = False
    End Sub

    Private Sub IUsers_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        DGVUsers.DataSource = EntityUser.getInstance().getUsers()
        DGVUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect
    End Sub

    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click
        'Test''ewqfdgasdifsf"
        'Test''ewqfdgasdifsf"
    End Sub
End Class
