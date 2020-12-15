Imports MySql.Data.MySqlClient
Imports System.Text
Imports System.Threading.Tasks

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
                         ByVal password As String)
        Try
            Dim passwordHashed = encryptPassword(password)
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"insert into utilisateur (matricule, password)
                                    values({matricule}, '{passwordHashed}')"
            connection.Open()
            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("L'utilisateur à été ajouté avec succès.")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Sub

    Public Sub connectUser(ByVal matricule As Integer)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"update utilisateur set
                                    connected = 1 where matricule = {matricule}"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Sub

    Public Sub disconnectUser()
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            connection.Open()
            command.CommandText = $"update utilisateur set
                                    connected = 0"

            Dim result = command.ExecuteNonQuery()
            connection.Close()
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de l'ajout.")
        End Try
    End Sub

    Public Sub changeStatut(ByVal matricule As Integer, ByVal statut As String)
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"update utilisateur set statut = '{statut}'
                                    where matricule = {matricule}"
            connection.Open()
            Dim result = command.ExecuteNonQuery()
            connection.Close()
            MessageBox.Show("Le statut a été modifié avec succés")
        Catch ex As Exception
            MessageBox.Show("Une erreur s'est produite lors de la modification.")
        End Try
    End Sub

    Public Function encryptPassword(password As String)
        Dim bytes() As Byte = Encoding.UTF8.GetBytes(password)
        Dim hashOfBytes() As Byte = New System.Security.Cryptography.SHA1Managed().ComputeHash(bytes)
        Dim strHash As String = Convert.ToBase64String(hashOfBytes)

        Return strHash
    End Function

End Class
