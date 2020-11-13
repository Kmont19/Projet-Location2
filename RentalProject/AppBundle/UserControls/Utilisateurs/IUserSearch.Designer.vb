<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class IUserSearch
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
        Me.Label13 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.CBStatut = New System.Windows.Forms.ComboBox()
        Me.ByStatut = New System.Windows.Forms.RadioButton()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TBMatricule = New System.Windows.Forms.TextBox()
        Me.ByMatricule = New System.Windows.Forms.RadioButton()
        Me.BackButton = New System.Windows.Forms.Button()
        Me.DGVUsers = New System.Windows.Forms.DataGridView()
        Me.SearchButton = New System.Windows.Forms.Button()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.Panel2.SuspendLayout()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel4.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label13
        '
        Me.Label13.Dock = System.Windows.Forms.DockStyle.Top
        Me.Label13.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.0!)
        Me.Label13.Location = New System.Drawing.Point(0, 0)
        Me.Label13.Name = "Label13"
        Me.Label13.Size = New System.Drawing.Size(586, 50)
        Me.Label13.TabIndex = 24
        Me.Label13.Text = "Recherche - Utilisateurs"
        Me.Label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel2
        '
        Me.Panel2.Controls.Add(Me.CBStatut)
        Me.Panel2.Controls.Add(Me.ByStatut)
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Controls.Add(Me.TBMatricule)
        Me.Panel2.Controls.Add(Me.ByMatricule)
        Me.Panel2.Dock = System.Windows.Forms.DockStyle.Left
        Me.Panel2.Location = New System.Drawing.Point(0, 50)
        Me.Panel2.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(205, 390)
        Me.Panel2.TabIndex = 26
        '
        'CBStatut
        '
        Me.CBStatut.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.CBStatut.Enabled = False
        Me.CBStatut.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.CBStatut.FormattingEnabled = True
        Me.CBStatut.Items.AddRange(New Object() {"Étudiant", "Professeur", "Technicien", "Administration"})
        Me.CBStatut.Location = New System.Drawing.Point(25, 226)
        Me.CBStatut.Name = "CBStatut"
        Me.CBStatut.Size = New System.Drawing.Size(162, 21)
        Me.CBStatut.TabIndex = 18
        '
        'ByStatut
        '
        Me.ByStatut.AutoSize = True
        Me.ByStatut.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByStatut.Location = New System.Drawing.Point(25, 200)
        Me.ByStatut.Margin = New System.Windows.Forms.Padding(2)
        Me.ByStatut.Name = "ByStatut"
        Me.ByStatut.Size = New System.Drawing.Size(63, 21)
        Me.ByStatut.TabIndex = 17
        Me.ByStatut.TabStop = True
        Me.ByStatut.Text = "Statut"
        Me.ByStatut.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 11.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(9, 85)
        Me.Label1.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(122, 18)
        Me.Label1.TabIndex = 13
        Me.Label1.Text = "Rechercher par..."
        '
        'TBMatricule
        '
        Me.TBMatricule.Enabled = False
        Me.TBMatricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TBMatricule.Location = New System.Drawing.Point(25, 149)
        Me.TBMatricule.Margin = New System.Windows.Forms.Padding(2)
        Me.TBMatricule.Name = "TBMatricule"
        Me.TBMatricule.Size = New System.Drawing.Size(164, 21)
        Me.TBMatricule.TabIndex = 12
        '
        'ByMatricule
        '
        Me.ByMatricule.AutoSize = True
        Me.ByMatricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ByMatricule.Location = New System.Drawing.Point(25, 115)
        Me.ByMatricule.Margin = New System.Windows.Forms.Padding(2)
        Me.ByMatricule.Name = "ByMatricule"
        Me.ByMatricule.Size = New System.Drawing.Size(83, 21)
        Me.ByMatricule.TabIndex = 11
        Me.ByMatricule.TabStop = True
        Me.ByMatricule.Text = "Matricule"
        Me.ByMatricule.UseVisualStyleBackColor = True
        '
        'BackButton
        '
        Me.BackButton.FlatAppearance.BorderSize = 0
        Me.BackButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(103, Byte), Integer), CType(CType(184, Byte), Integer), CType(CType(206, Byte), Integer))
        Me.BackButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.BackButton.Image = Global.RentalProject.My.Resources.Resources.baseline_backward_black_18dp_4x
        Me.BackButton.Location = New System.Drawing.Point(0, 0)
        Me.BackButton.Margin = New System.Windows.Forms.Padding(2)
        Me.BackButton.Name = "BackButton"
        Me.BackButton.Size = New System.Drawing.Size(70, 50)
        Me.BackButton.TabIndex = 28
        Me.BackButton.UseVisualStyleBackColor = True
        '
        'DGVUsers
        '
        Me.DGVUsers.AllowUserToAddRows = False
        Me.DGVUsers.AllowUserToDeleteRows = False
        Me.DGVUsers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill
        Me.DGVUsers.BackgroundColor = System.Drawing.Color.White
        Me.DGVUsers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DGVUsers.Location = New System.Drawing.Point(205, 50)
        Me.DGVUsers.Name = "DGVUsers"
        Me.DGVUsers.ReadOnly = True
        Me.DGVUsers.RowHeadersWidth = 51
        Me.DGVUsers.Size = New System.Drawing.Size(381, 341)
        Me.DGVUsers.TabIndex = 25
        '
        'SearchButton
        '
        Me.SearchButton.BackColor = System.Drawing.Color.FromArgb(CType(CType(96, Byte), Integer), CType(CType(125, Byte), Integer), CType(CType(139, Byte), Integer))
        Me.SearchButton.Dock = System.Windows.Forms.DockStyle.Right
        Me.SearchButton.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.SearchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(CType(CType(67, Byte), Integer), CType(CType(87, Byte), Integer), CType(CType(96, Byte), Integer))
        Me.SearchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.SearchButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SearchButton.ForeColor = System.Drawing.Color.White
        Me.SearchButton.Image = Global.RentalProject.My.Resources.Resources.baseline_search_white_18dp
        Me.SearchButton.Location = New System.Drawing.Point(287, 0)
        Me.SearchButton.Margin = New System.Windows.Forms.Padding(2)
        Me.SearchButton.Name = "SearchButton"
        Me.SearchButton.Size = New System.Drawing.Size(94, 51)
        Me.SearchButton.TabIndex = 9
        Me.SearchButton.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.SearchButton)
        Me.Panel4.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.Panel4.Location = New System.Drawing.Point(205, 389)
        Me.Panel4.Margin = New System.Windows.Forms.Padding(2)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(381, 51)
        Me.Panel4.TabIndex = 27
        '
        'IUserSearch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(187, Byte), Integer), CType(CType(222, Byte), Integer), CType(CType(251, Byte), Integer))
        Me.Controls.Add(Me.BackButton)
        Me.Controls.Add(Me.Panel4)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.DGVUsers)
        Me.Controls.Add(Me.Label13)
        Me.MinimumSize = New System.Drawing.Size(586, 440)
        Me.Name = "IUserSearch"
        Me.Size = New System.Drawing.Size(586, 440)
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DGVUsers, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel4.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label13 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents CBStatut As ComboBox
    Friend WithEvents ByStatut As RadioButton
    Friend WithEvents Label1 As Label
    Friend WithEvents TBMatricule As TextBox
    Friend WithEvents ByMatricule As RadioButton
    Friend WithEvents BackButton As Button
    Friend WithEvents DGVUsers As DataGridView
    Friend WithEvents SearchButton As Button
    Friend WithEvents Panel4 As Panel
End Class
