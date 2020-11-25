Imports MySql.Data.MySqlClient

Public Class EntityStats

    Dim connection As New MySqlConnection(MainForm.getInstance().connectionString)
    Shared instance As EntityStats = Nothing

    Public Shared Function getInstance() As EntityStats
        If IsNothing(instance) Then
            instance = New EntityStats()
        End If
        Return instance
    End Function

    Public Function getNbrEmprunt(jour As String) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"Select nbr_emprunt from statistique_journee where journee = " + jour
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("statistique")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

    Public Function AddStats(jour As String) As DataTable
        Try
            Dim command As New MySqlCommand
            command.Connection = connection
            command.CommandText = $"UPDATE statistique_journee SET nbr_emprunt = nbr_emprunt + 1 WHERE journee = " + jour
            connection.Open()
            Dim reader = command.ExecuteReader()
            Dim table As New DataTable("statistique")
            table.Load(reader)
            connection.Close()
            Return table
        Catch ex As Exception
            MessageBox.Show("Le chargement des données de la Base de Données a échoué:" + ex.Message)
        End Try
    End Function

















End Class
