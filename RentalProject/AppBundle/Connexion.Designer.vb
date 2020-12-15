<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Connexion
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.InterfacePanel = New System.Windows.Forms.Panel()
        Me.SuspendLayout()
        '
        'InterfacePanel
        '
        Me.InterfacePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.InterfacePanel.Location = New System.Drawing.Point(0, 0)
        Me.InterfacePanel.Name = "InterfacePanel"
        Me.InterfacePanel.Size = New System.Drawing.Size(410, 345)
        Me.InterfacePanel.TabIndex = 0
        '
        'Connexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(410, 345)
        Me.Controls.Add(Me.InterfacePanel)
        Me.Cursor = System.Windows.Forms.Cursors.Hand
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog
        Me.Name = "Connexion"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Connexion"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents InterfacePanel As Panel
End Class
