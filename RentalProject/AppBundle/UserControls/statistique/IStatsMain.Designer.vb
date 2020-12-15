<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IStatsMain
    Inherits System.Windows.Forms.UserControl

    'UserControl overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim ChartArea1 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend1 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series1 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Dim ChartArea2 As System.Windows.Forms.DataVisualization.Charting.ChartArea = New System.Windows.Forms.DataVisualization.Charting.ChartArea()
        Dim Legend2 As System.Windows.Forms.DataVisualization.Charting.Legend = New System.Windows.Forms.DataVisualization.Charting.Legend()
        Dim Series2 As System.Windows.Forms.DataVisualization.Charting.Series = New System.Windows.Forms.DataVisualization.Charting.Series()
        Me.btDessiner = New System.Windows.Forms.Button()
        Me.GraphNbrLocation = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.GraphEquip = New System.Windows.Forms.DataVisualization.Charting.Chart()
        Me.btGraph2 = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        CType(Me.GraphNbrLocation, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GraphEquip, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btDessiner
        '
        Me.btDessiner.Location = New System.Drawing.Point(180, 444)
        Me.btDessiner.Name = "btDessiner"
        Me.btDessiner.Size = New System.Drawing.Size(156, 47)
        Me.btDessiner.TabIndex = 0
        Me.btDessiner.Text = "Dessiner le graphique"
        Me.btDessiner.UseVisualStyleBackColor = True
        '
        'GraphNbrLocation
        '
        ChartArea1.Name = "ChartArea1"
        Me.GraphNbrLocation.ChartAreas.Add(ChartArea1)
        Legend1.Name = "Legend1"
        Me.GraphNbrLocation.Legends.Add(Legend1)
        Me.GraphNbrLocation.Location = New System.Drawing.Point(34, 63)
        Me.GraphNbrLocation.Name = "GraphNbrLocation"
        Series1.BorderColor = System.Drawing.Color.Red
        Series1.ChartArea = "ChartArea1"
        Series1.Legend = "Legend1"
        Series1.Name = "Location"
        Me.GraphNbrLocation.Series.Add(Series1)
        Me.GraphNbrLocation.Size = New System.Drawing.Size(437, 375)
        Me.GraphNbrLocation.TabIndex = 1
        Me.GraphNbrLocation.Text = "Chart1"
        '
        'GraphEquip
        '
        ChartArea2.Name = "ChartArea1"
        Me.GraphEquip.ChartAreas.Add(ChartArea2)
        Legend2.Name = "Legend1"
        Me.GraphEquip.Legends.Add(Legend2)
        Me.GraphEquip.Location = New System.Drawing.Point(536, 63)
        Me.GraphEquip.Name = "GraphEquip"
        Series2.BorderColor = System.Drawing.Color.Lime
        Series2.ChartArea = "ChartArea1"
        Series2.Legend = "Legend1"
        Series2.Name = "Locations"
        Me.GraphEquip.Series.Add(Series2)
        Me.GraphEquip.Size = New System.Drawing.Size(437, 375)
        Me.GraphEquip.TabIndex = 2
        Me.GraphEquip.Text = "Chart1"
        '
        'btGraph2
        '
        Me.btGraph2.Location = New System.Drawing.Point(693, 444)
        Me.btGraph2.Name = "btGraph2"
        Me.btGraph2.Size = New System.Drawing.Size(156, 47)
        Me.btGraph2.TabIndex = 3
        Me.btGraph2.Text = "Dessiner le graphique"
        Me.btGraph2.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(567, 22)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(377, 25)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Nombre de locations par Équipements"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(97, 22)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(305, 25)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "Nombre de locations par Jours"
        '
        'IStatsMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btGraph2)
        Me.Controls.Add(Me.GraphEquip)
        Me.Controls.Add(Me.GraphNbrLocation)
        Me.Controls.Add(Me.btDessiner)
        Me.Name = "IStatsMain"
        Me.Size = New System.Drawing.Size(1004, 542)
        CType(Me.GraphNbrLocation, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GraphEquip, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btDessiner As Button
    Friend WithEvents GraphNbrLocation As DataVisualization.Charting.Chart
    Friend WithEvents GraphEquip As DataVisualization.Charting.Chart
    Friend WithEvents btGraph2 As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
End Class
