<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionUtilisateur
    Inherits System.Windows.Forms.Form

    'Form remplace la méthode Dispose pour nettoyer la liste des composants.
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.modifier = New System.Windows.Forms.Button()
        Me.erreur = New System.Windows.Forms.Label()
        Me.supprimer = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.sexe = New System.Windows.Forms.ComboBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.naissance = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.menu = New FontAwesome.Sharp.IconButton()
        Me.decon = New FontAwesome.Sharp.IconButton()
        Me.Panel6.SuspendLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView1.ForeColor = System.Drawing.SystemColors.Menu
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(782, 42)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1070, 741)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom"
        Me.ColumnHeader1.Width = 300
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Email"
        Me.ColumnHeader2.Width = 300
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sexe"
        Me.ColumnHeader3.Width = 300
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date de naissance"
        Me.ColumnHeader4.Width = 300
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.modifier)
        Me.Panel6.Controls.Add(Me.erreur)
        Me.Panel6.Controls.Add(Me.supprimer)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.sexe)
        Me.Panel6.Controls.Add(Me.IconPictureBox2)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.IconPictureBox3)
        Me.Panel6.Controls.Add(Me.Nom)
        Me.Panel6.Controls.Add(Me.IconPictureBox1)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.Email)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.naissance)
        Me.Panel6.Location = New System.Drawing.Point(105, 42)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(608, 764)
        Me.Panel6.TabIndex = 67
        '
        'modifier
        '
        Me.modifier.BackColor = System.Drawing.Color.Orange
        Me.modifier.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.modifier.FlatAppearance.BorderSize = 0
        Me.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.modifier.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.modifier.Location = New System.Drawing.Point(309, 594)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(172, 54)
        Me.modifier.TabIndex = 55
        Me.modifier.Text = "Modifier"
        Me.modifier.UseVisualStyleBackColor = False
        '
        'erreur
        '
        Me.erreur.AutoSize = True
        Me.erreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.erreur.ForeColor = System.Drawing.Color.Red
        Me.erreur.Location = New System.Drawing.Point(132, 469)
        Me.erreur.Name = "erreur"
        Me.erreur.Size = New System.Drawing.Size(277, 22)
        Me.erreur.TabIndex = 52
        Me.erreur.Text = "Veuillez Entrez les champs requis"
        Me.erreur.Visible = False
        '
        'supprimer
        '
        Me.supprimer.BackColor = System.Drawing.Color.Red
        Me.supprimer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.supprimer.FlatAppearance.BorderSize = 0
        Me.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.supprimer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.supprimer.Location = New System.Drawing.Point(141, 594)
        Me.supprimer.Name = "supprimer"
        Me.supprimer.Size = New System.Drawing.Size(161, 54)
        Me.supprimer.TabIndex = 48
        Me.supprimer.Text = "Supprimer"
        Me.supprimer.UseVisualStyleBackColor = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(114, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(394, 51)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Gestion Utilisateur"
        '
        'sexe
        '
        Me.sexe.FormattingEnabled = True
        Me.sexe.Items.AddRange(New Object() {"Masculin", "Feminin", "Autre"})
        Me.sexe.Location = New System.Drawing.Point(255, 277)
        Me.sexe.Name = "sexe"
        Me.sexe.Size = New System.Drawing.Size(236, 28)
        Me.sexe.TabIndex = 83
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 25
        Me.IconPictureBox2.Location = New System.Drawing.Point(132, 141)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox2.TabIndex = 68
        Me.IconPictureBox2.TabStop = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(182, 281)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 82
        Me.Label3.Text = "Sexe"
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(132, 179)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 1)
        Me.Panel2.TabIndex = 69
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MarsDouble
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 25
        Me.IconPictureBox3.Location = New System.Drawing.Point(132, 277)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox3.TabIndex = 70
        Me.IconPictureBox3.TabStop = False
        '
        'Nom
        '
        Me.Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Nom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Nom.Location = New System.Drawing.Point(167, 141)
        Me.Nom.Multiline = True
        Me.Nom.Name = "Nom"
        Me.Nom.PlaceholderText = "Nom utilisateur"
        Me.Nom.Size = New System.Drawing.Size(324, 32)
        Me.Nom.TabIndex = 71
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 25
        Me.IconPictureBox1.Location = New System.Drawing.Point(132, 202)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 72
        Me.IconPictureBox1.TabStop = False
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(132, 240)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 1)
        Me.Panel1.TabIndex = 73
        '
        'Email
        '
        Me.Email.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Email.Location = New System.Drawing.Point(167, 202)
        Me.Email.Multiline = True
        Me.Email.Name = "Email"
        Me.Email.PlaceholderText = "Email"
        Me.Email.Size = New System.Drawing.Size(324, 32)
        Me.Email.TabIndex = 74
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(132, 324)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 76
        Me.Label2.Text = "Date de naissance"
        '
        'naissance
        '
        Me.naissance.Checked = True
        Me.naissance.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.naissance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.naissance.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.naissance.Location = New System.Drawing.Point(132, 356)
        Me.naissance.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.naissance.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.naissance.Name = "naissance"
        Me.naissance.Size = New System.Drawing.Size(359, 43)
        Me.naissance.TabIndex = 75
        Me.naissance.Value = New Date(2022, 4, 1, 11, 46, 16, 0)
        '
        'menu
        '
        Me.menu.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.menu.FlatAppearance.BorderSize = 0
        Me.menu.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.menu.IconChar = FontAwesome.Sharp.IconChar.ArrowLeft
        Me.menu.IconColor = System.Drawing.Color.Black
        Me.menu.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.menu.IconSize = 25
        Me.menu.Location = New System.Drawing.Point(12, 21)
        Me.menu.Name = "menu"
        Me.menu.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.menu.Size = New System.Drawing.Size(39, 39)
        Me.menu.TabIndex = 65
        Me.menu.UseVisualStyleBackColor = False
        '
        'decon
        '
        Me.decon.BackColor = System.Drawing.Color.Red
        Me.decon.FlatAppearance.BorderSize = 0
        Me.decon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.decon.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.decon.IconColor = System.Drawing.Color.Black
        Me.decon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.decon.Location = New System.Drawing.Point(60, 21)
        Me.decon.Name = "decon"
        Me.decon.Size = New System.Drawing.Size(39, 39)
        Me.decon.TabIndex = 66
        Me.decon.UseVisualStyleBackColor = False
        '
        'GestionUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1864, 834)
        Me.Controls.Add(Me.Panel6)
        Me.Controls.Add(Me.decon)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.ListView1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "GestionUtilisateur"
        Me.Text = "GestionUtilisateur"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents modifier As Button
    Friend WithEvents erreur As Label
    Friend WithEvents supprimer As Button
    Friend WithEvents Label1 As Label
    Friend WithEvents menu As FontAwesome.Sharp.IconButton
    Friend WithEvents decon As FontAwesome.Sharp.IconButton
    Friend WithEvents sexe As ComboBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Nom As TextBox
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Email As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents naissance As Guna.UI2.WinForms.Guna2DateTimePicker
End Class
