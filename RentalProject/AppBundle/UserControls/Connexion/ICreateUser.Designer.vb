<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class ICreateUser
    Inherits System.Windows.Forms.UserControl

    'UserControl remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.Label11 = New System.Windows.Forms.Label()
        Me.TBMatricule = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBPassword = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TBPasswordRepeat = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BTAnnuler = New System.Windows.Forms.Button()
        Me.BTCreer = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label11
        '
        Me.Label11.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label11.Location = New System.Drawing.Point(0, 25)
        Me.Label11.Name = "Label11"
        Me.Label11.Size = New System.Drawing.Size(410, 38)
        Me.Label11.TabIndex = 16
        Me.Label11.Text = "Créer un utilisateur"
        Me.Label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'TBMatricule
        '
        Me.TBMatricule.Location = New System.Drawing.Point(227, 88)
        Me.TBMatricule.MaxLength = 30
        Me.TBMatricule.Name = "TBMatricule"
        Me.TBMatricule.Size = New System.Drawing.Size(161, 20)
        Me.TBMatricule.TabIndex = 105
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(34, 89)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(65, 17)
        Me.Label1.TabIndex = 104
        Me.Label1.Text = "Matricule"
        '
        'TBPassword
        '
        Me.TBPassword.Location = New System.Drawing.Point(227, 134)
        Me.TBPassword.MaxLength = 30
        Me.TBPassword.Name = "TBPassword"
        Me.TBPassword.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPassword.Size = New System.Drawing.Size(161, 20)
        Me.TBPassword.TabIndex = 107
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(34, 135)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(93, 17)
        Me.Label2.TabIndex = 106
        Me.Label2.Text = "Mot de passe"
        '
        'TBPasswordRepeat
        '
        Me.TBPasswordRepeat.Location = New System.Drawing.Point(227, 182)
        Me.TBPasswordRepeat.MaxLength = 30
        Me.TBPasswordRepeat.Name = "TBPasswordRepeat"
        Me.TBPasswordRepeat.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.TBPasswordRepeat.Size = New System.Drawing.Size(161, 20)
        Me.TBPasswordRepeat.TabIndex = 109
        '
        'Label3
        '
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(35, 183)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(172, 20)
        Me.Label3.TabIndex = 108
        Me.Label3.Text = "Repetez le mot de passe"
        '
        'BTAnnuler
        '
        Me.BTAnnuler.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BTAnnuler.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTAnnuler.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTAnnuler.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTAnnuler.ForeColor = System.Drawing.Color.White
        Me.BTAnnuler.Location = New System.Drawing.Point(211, 267)
        Me.BTAnnuler.Margin = New System.Windows.Forms.Padding(0)
        Me.BTAnnuler.Name = "BTAnnuler"
        Me.BTAnnuler.Size = New System.Drawing.Size(126, 39)
        Me.BTAnnuler.TabIndex = 111
        Me.BTAnnuler.Text = "Annuler"
        Me.BTAnnuler.UseVisualStyleBackColor = False
        '
        'BTCreer
        '
        Me.BTCreer.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.BTCreer.Cursor = System.Windows.Forms.Cursors.Hand
        Me.BTCreer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BTCreer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!)
        Me.BTCreer.ForeColor = System.Drawing.Color.White
        Me.BTCreer.Location = New System.Drawing.Point(67, 267)
        Me.BTCreer.Margin = New System.Windows.Forms.Padding(0)
        Me.BTCreer.Name = "BTCreer"
        Me.BTCreer.Size = New System.Drawing.Size(126, 39)
        Me.BTCreer.TabIndex = 110
        Me.BTCreer.Text = "Créer compte"
        Me.BTCreer.UseVisualStyleBackColor = False
        '
        'IAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSize = True
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.BTAnnuler)
        Me.Controls.Add(Me.BTCreer)
        Me.Controls.Add(Me.TBPasswordRepeat)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.TBPassword)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TBMatricule)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Label11)
        Me.MinimumSize = New System.Drawing.Size(410, 345)
        Me.Name = "IAddUser"
        Me.Size = New System.Drawing.Size(413, 345)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label11 As Label
    Friend WithEvents TBMatricule As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents TBPassword As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents TBPasswordRepeat As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents BTAnnuler As Button
    Friend WithEvents BTCreer As Button
End Class
