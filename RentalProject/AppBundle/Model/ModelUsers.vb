Imports MySql.Data.MySqlClient

Public Class ModelUsers

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As ModelUsers = Nothing


    Public Shared Function getInstance() As ModelUsers
        If IsNothing(instance) Then
            instance = New ModelUsers()
        End If
        Return instance
    End Function

    Public Sub deleteUserByMatricule(matricule As Integer)
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Delete from utilisateur where matricule = {matricule}"
        connection.Open()
        command.ExecuteNonQuery()
        connection.Close()
    End Sub

    Public Sub addUser(ByVal matricule As Integer,
                         ByVal statut As String,
                         ByVal password As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"insert into matricule
            values('{matricule}', '{password}, '{statut}')"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("L'utilisateur à été ajouté avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Sub

End Class
