Imports MySql.Data.MySqlClient

Public Class EntityUser
    ReadOnly connection As New MySqlConnection(Connexion.getInstance().connectionString)
    Shared instance As EntityUser = Nothing

    Public Shared Function getInstance() As EntityUser
        If IsNothing(instance) Then
            instance = New EntityUser()
        End If
        Return instance
    End Function

    Public Function getUsers() As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select matricule, statut from utilisateur"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("utilisateur")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersByMatricule(matricule As Integer) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select matricule, statut from utilisateur where matricule = {matricule}"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("utilisateur")
        table.Load(reader)
        connection.Close()
        Return table
    End Function

    Public Function getUsersByStatut(statut As String) As DataTable
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select matricule, statut from utilisateur where upper(statut) like upper('{statut}')"
        connection.Open()
        Dim reader = command.ExecuteReader()
        Dim table As New DataTable("utilisateur")
        table.Load(reader)
        connection.Close()
        Return table
    End Function


    Public Function verifUser(matricule As Integer, password As String) As Boolean

        Dim verif = False
        Try
            Dim passwordHashed = ModelUsers.getInstance().encryptPassword(password)
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select count(*) from utilisateur where matricule = {matricule} and password LIKE '{passwordHashed}'"
            connection.Open()
            Dim result = command.ExecuteScalar()

            If (result = 1) Then
                ModelUsers.getInstance.connectUser(matricule)
                verif = True

            Else
                verif = False
            End If

            connection.Close()
        Catch ex As Exception
            MsgBox("Can't load Web page" & vbCrLf & ex.Message)
        End Try

        Return verif
    End Function

    Public Function getUserStatut() As String
        Dim command As New MySqlCommand
        command.Connection = connection
        command.CommandText = $"Select statut from utilisateur where connected = 1"
        connection.Open()
        Dim statut As String = command.ExecuteScalar()
        connection.Close()
        Return statut
    End Function

End Class
