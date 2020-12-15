Public Class Connexion

    Shared instance As Connexion = Nothing
    'Public connectionString = "Server='localhost';Database='projetsession';Uid='root';Pwd='';Port=3308;"
    '1659462
    Public connectionString = "Server='projectcegep2020tr.hopto.org';Database='projetsession';charset=utf8;Uid='root';Pwd='root';port=3306;"
    Public Shared Function getInstance() As Connexion
        If IsNothing(instance) Then
            instance = New Connexion()
        End If
        Return instance
    End Function

    Private Sub Connexion_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.CenterToScreen()
        Dim connexion As New IConnexion With {
            .Dock = DockStyle.Fill
        }
        InterfacePanel.Controls.Add(connexion)
        connexion.BringToFront()
    End Sub
End Class