Public Class IStatsMain


    Private g1, g2 As Graphics
    Private out As Integer

    Private Sub btDessiner_Click(sender As Object, e As EventArgs) Handles btDessiner.Click
        Me.GraphNbrLocation.Series("Location").Points.Clear()
        Me.GraphNbrLocation.Series("Location").Points.AddXY("Lundi", NbrLocationParJour(1))
        Me.GraphNbrLocation.Series("Location").Points.AddXY("Mardi", NbrLocationParJour(2))
        Me.GraphNbrLocation.Series("Location").Points.AddXY("Mercredi", NbrLocationParJour(3))
        Me.GraphNbrLocation.Series("Location").Points.AddXY("Jeudi", NbrLocationParJour(4))
        Me.GraphNbrLocation.Series("Location").Points.AddXY("Vendredi", NbrLocationParJour(5))

    End Sub

    Private Sub btGraph2_Click(sender As Object, e As EventArgs) Handles btGraph2.Click
        Dim nbr

        Dim item As DataTable = EntityEquipment.getInstance().getNbrEquipement()
        For Each it As DataRow In item.Rows
            nbr = Integer.Parse(it.Item(0))
        Next

        For i As Integer = 1 To nbr - 1

            Me.GraphEquip.Series("Locations").Points.AddXY(i, NbrLocationParEquipement(i))

        Next


    End Sub

    Private Sub IStatsMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        g1 = Me.CreateGraphics
        g2 = Me.CreateGraphics
    End Sub

    Private Function NbrLocationParJour(jour As Integer) As Integer

        Dim nbr As Integer

        Dim item As DataTable = EntityStats.getInstance().getNbrEmprunt(jour)
        For Each it As DataRow In item.Rows
            nbr = Integer.Parse(it.Item(0))
        Next

        Return nbr
    End Function

    Private Function NbrLocationParEquipement(Id As Integer) As Integer

        Dim nbr As Integer

        Dim item As DataTable = EntityEquipment.getInstance().getEquipmentNbrEmprunt(Id)
        For Each it As DataRow In item.Rows
            nbr = Integer.Parse(it.Item(0))
        Next

        Return nbr
    End Function




End Class
