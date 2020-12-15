<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class IConnexion
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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

    'Requise par le Concepteur Windows Form
    Private components As System.ComponentModel.IContainer

    'REMARQUE : la procédure suivante est requise par le Concepteur Windows Form
    'Elle peut être modifiée à l'aide du Concepteur Windows Form.  
    'Ne la modifiez pas à l'aide de l'éditeur de code.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.BTCreer = New System.Windows.Forms.Button()
        Me.TBMatricule = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.BTConnexion = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'BTCreer
        '
        Me.BTCreer.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BTCreer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTCreer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTCreer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTCreer.ForeColor = System.Drawing.Color.White
        Me.BTCreer.Location = New System.Drawing.Point(210, 267)
        Me.BTCreer.Margin = New System.Windows.Forms.Padding(0)
        Me.BTCreer.Name = "BTCreer"
        Me.BTCreer.Size = New System.Drawing.Size(126, 39)
        Me.BTCreer.TabIndex = 5
        Me.BTCreer.Text = "Créer compte"
        Me.BTCreer.UseVisualStyleBackColor = False
        '
        'TBMatricule
        '
        Me.TBMatricule.Location = New System.Drawing.Point(191, 123)
        Me.TBMatricule.Name = "TBMatricule"
        Me.TBMatricule.Size = New System.Drawing.Size(145, 20)
        Me.TBMatricule.TabIndex = 0
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label1.Location = New System.Drawing.Point(85, 124)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(71, 17)
        Me.Label1.TabIndex = 1
        Me.Label1.Text = "Utilisateur"
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(191, 183)
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(145, 20)
        Me.TBPassword.TabIndex = 1
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.Label2.Location = New System.Drawing.Point(63, 184)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Mot de passe"
        '
        'BTConnexion
        '
        Me.BTConnexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BTConnexion.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTConnexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTConnexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTConnexion.ForeColor = System.Drawing.Color.White
        Me.BTConnexion.Location = New System.Drawing.Point(67, 267)
        Me.BTConnexion.Margin = New System.Windows.Forms.Padding(0)
        Me.BTConnexion.Name = "BTConnexion"
        Me.BTConnexion.Size = New System.Drawing.Size(126, 39)
        Me.BTConnexion.TabIndex = 2
        Me.BTConnexion.Text = "Se connecter"
        Me.BTConnexion.UseVisualStyleBackColor = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.Black
        Me.Label3.Location = New System.Drawing.Point(140, 47)
        Me.Label3.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label3.Name = "Label3"
        Me.Label3.Padding = New System.Windows.Forms.Padding(8, 6, 0, 3)
        Me.Label3.Size = New System.Drawing.Size(117, 40)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "CEGEP"
        '
        'IConnexion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.BTCreer)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBMatricule)
        Me.Controls.Add(Me.BTConnexion)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBPassword)
        Me.MinimumSize = New System.Drawing.Size(410, 345)
        Me.Name = "IConnexion"
        Me.Size = New System.Drawing.Size(410, 345)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents BTCreer As Button
    Friend WithEvents TBMatricule As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents BTConnexion As Button
    Friend WithEvents Label3 As Label
End Class
