<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Inscription
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
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.cacher2 = New FontAwesome.Sharp.IconButton()
        Me.cacher = New FontAwesome.Sharp.IconButton()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconButton3 = New FontAwesome.Sharp.IconButton()
        Me.IconButton2 = New FontAwesome.Sharp.IconButton()
        Me.erreur = New System.Windows.Forms.Label()
        Me.sexe = New System.Windows.Forms.ComboBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.initialiser = New System.Windows.Forms.Button()
        Me.enregistrer = New System.Windows.Forms.Button()
        Me.mdp2 = New System.Windows.Forms.TextBox()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.mdp = New System.Windows.Forms.TextBox()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.naissance = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.Email = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.Panel6.SuspendLayout()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel7.SuspendLayout()
        Me.SuspendLayout()
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.cacher2)
        Me.Panel6.Controls.Add(Me.cacher)
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Controls.Add(Me.IconButton3)
        Me.Panel6.Controls.Add(Me.IconButton2)
        Me.Panel6.Controls.Add(Me.erreur)
        Me.Panel6.Controls.Add(Me.sexe)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.initialiser)
        Me.Panel6.Controls.Add(Me.enregistrer)
        Me.Panel6.Controls.Add(Me.mdp2)
        Me.Panel6.Controls.Add(Me.Panel5)
        Me.Panel6.Controls.Add(Me.IconPictureBox5)
        Me.Panel6.Controls.Add(Me.mdp)
        Me.Panel6.Controls.Add(Me.IconPictureBox4)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.naissance)
        Me.Panel6.Controls.Add(Me.Email)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.IconPictureBox1)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Nom)
        Me.Panel6.Controls.Add(Me.IconPictureBox3)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.IconPictureBox2)
        Me.Panel6.Location = New System.Drawing.Point(53, 31)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(610, 707)
        Me.Panel6.TabIndex = 29
        '
        'cacher2
        '
        Me.cacher2.FlatAppearance.BorderSize = 0
        Me.cacher2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cacher2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.cacher2.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.cacher2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cacher2.IconSize = 30
        Me.cacher2.Location = New System.Drawing.Point(444, 467)
        Me.cacher2.Name = "cacher2"
        Me.cacher2.Size = New System.Drawing.Size(28, 30)
        Me.cacher2.TabIndex = 58
        Me.cacher2.UseVisualStyleBackColor = True
        Me.cacher2.Visible = False
        '
        'cacher
        '
        Me.cacher.FlatAppearance.BorderSize = 0
        Me.cacher.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.cacher.IconChar = FontAwesome.Sharp.IconChar.EyeSlash
        Me.cacher.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.cacher.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.cacher.IconSize = 30
        Me.cacher.Location = New System.Drawing.Point(444, 403)
        Me.cacher.Name = "cacher"
        Me.cacher.Size = New System.Drawing.Size(28, 30)
        Me.cacher.TabIndex = 57
        Me.cacher.UseVisualStyleBackColor = True
        Me.cacher.Visible = False
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(113, 441)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(359, 1)
        Me.Panel3.TabIndex = 56
        '
        'IconButton3
        '
        Me.IconButton3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconButton3.FlatAppearance.BorderSize = 0
        Me.IconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton3.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IconButton3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconButton3.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.IconButton3.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconButton3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton3.IconSize = 30
        Me.IconButton3.Location = New System.Drawing.Point(443, 464)
        Me.IconButton3.Name = "IconButton3"
        Me.IconButton3.Size = New System.Drawing.Size(29, 32)
        Me.IconButton3.TabIndex = 55
        Me.IconButton3.UseVisualStyleBackColor = False
        '
        'IconButton2
        '
        Me.IconButton2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconButton2.FlatAppearance.BorderSize = 0
        Me.IconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.IconButton2.Font = New System.Drawing.Font("Segoe UI", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.IconButton2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconButton2.IconChar = FontAwesome.Sharp.IconChar.Eye
        Me.IconButton2.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconButton2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconButton2.IconSize = 30
        Me.IconButton2.Location = New System.Drawing.Point(443, 403)
        Me.IconButton2.Name = "IconButton2"
        Me.IconButton2.Size = New System.Drawing.Size(29, 32)
        Me.IconButton2.TabIndex = 54
        Me.IconButton2.UseVisualStyleBackColor = False
        '
        'erreur
        '
        Me.erreur.AutoSize = True
        Me.erreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.erreur.ForeColor = System.Drawing.Color.Red
        Me.erreur.Location = New System.Drawing.Point(113, 523)
        Me.erreur.Name = "erreur"
        Me.erreur.Size = New System.Drawing.Size(277, 22)
        Me.erreur.TabIndex = 52
        Me.erreur.Text = "Veuillez Entrez les champs requis"
        Me.erreur.Visible = False
        '
        'sexe
        '
        Me.sexe.FormattingEnabled = True
        Me.sexe.Items.AddRange(New Object() {"Masculin", "Feminin", "Autre"})
        Me.sexe.Location = New System.Drawing.Point(236, 257)
        Me.sexe.Name = "sexe"
        Me.sexe.Size = New System.Drawing.Size(236, 28)
        Me.sexe.TabIndex = 51
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(163, 261)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(45, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Sexe"
        '
        'initialiser
        '
        Me.initialiser.BackColor = System.Drawing.Color.Red
        Me.initialiser.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.initialiser.FlatAppearance.BorderSize = 0
        Me.initialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.initialiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.initialiser.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.initialiser.Location = New System.Drawing.Point(100, 575)
        Me.initialiser.Name = "initialiser"
        Me.initialiser.Size = New System.Drawing.Size(199, 54)
        Me.initialiser.TabIndex = 48
        Me.initialiser.Text = "initialiser"
        Me.initialiser.UseVisualStyleBackColor = False
        '
        'enregistrer
        '
        Me.enregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.enregistrer.FlatAppearance.BorderSize = 0
        Me.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.enregistrer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.enregistrer.Location = New System.Drawing.Point(305, 575)
        Me.enregistrer.Name = "enregistrer"
        Me.enregistrer.Size = New System.Drawing.Size(200, 54)
        Me.enregistrer.TabIndex = 47
        Me.enregistrer.Text = "Enregistrer"
        Me.enregistrer.UseVisualStyleBackColor = False
        '
        'mdp2
        '
        Me.mdp2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mdp2.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mdp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mdp2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.mdp2.Location = New System.Drawing.Point(148, 464)
        Me.mdp2.Name = "mdp2"
        Me.mdp2.PlaceholderText = "Confimation Mot de Passe"
        Me.mdp2.Size = New System.Drawing.Size(324, 21)
        Me.mdp2.TabIndex = 46
        Me.mdp2.UseSystemPasswordChar = True
        '
        'Panel5
        '
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel5.Location = New System.Drawing.Point(113, 502)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(359, 1)
        Me.Panel5.TabIndex = 45
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt
        Me.IconPictureBox5.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox5.IconSize = 25
        Me.IconPictureBox5.Location = New System.Drawing.Point(113, 464)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox5.TabIndex = 44
        Me.IconPictureBox5.TabStop = False
        '
        'mdp
        '
        Me.mdp.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mdp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mdp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.mdp.Location = New System.Drawing.Point(148, 403)
        Me.mdp.Name = "mdp"
        Me.mdp.PlaceholderText = "Mot de Passe"
        Me.mdp.Size = New System.Drawing.Size(324, 21)
        Me.mdp.TabIndex = 43
        Me.mdp.UseSystemPasswordChar = True
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt
        Me.IconPictureBox4.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 25
        Me.IconPictureBox4.Location = New System.Drawing.Point(113, 403)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox4.TabIndex = 41
        Me.IconPictureBox4.TabStop = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(113, 304)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(147, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Date de naissance"
        '
        'naissance
        '
        Me.naissance.Checked = True
        Me.naissance.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.naissance.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.naissance.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.naissance.Location = New System.Drawing.Point(113, 336)
        Me.naissance.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.naissance.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.naissance.Name = "naissance"
        Me.naissance.Size = New System.Drawing.Size(359, 43)
        Me.naissance.TabIndex = 39
        Me.naissance.Value = New Date(2022, 4, 1, 11, 46, 16, 0)
        '
        'Email
        '
        Me.Email.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Email.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Email.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Email.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Email.Location = New System.Drawing.Point(148, 182)
        Me.Email.Multiline = True
        Me.Email.Name = "Email"
        Me.Email.PlaceholderText = "Email"
        Me.Email.Size = New System.Drawing.Size(324, 32)
        Me.Email.TabIndex = 38
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel1.Location = New System.Drawing.Point(113, 220)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(359, 1)
        Me.Panel1.TabIndex = 37
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Envelope
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 25
        Me.IconPictureBox1.Location = New System.Drawing.Point(113, 182)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox1.TabIndex = 36
        Me.IconPictureBox1.TabStop = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 25.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label1.ForeColor = System.Drawing.Color.Silver
        Me.Label1.Location = New System.Drawing.Point(139, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(310, 51)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "INSCRIPTION"
        '
        'Nom
        '
        Me.Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Nom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Nom.Location = New System.Drawing.Point(148, 121)
        Me.Nom.Multiline = True
        Me.Nom.Name = "Nom"
        Me.Nom.PlaceholderText = "Nom utilisateur"
        Me.Nom.Size = New System.Drawing.Size(324, 32)
        Me.Nom.TabIndex = 33
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.MarsDouble
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 25
        Me.IconPictureBox3.Location = New System.Drawing.Point(113, 257)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox3.TabIndex = 31
        Me.IconPictureBox3.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(113, 159)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 1)
        Me.Panel2.TabIndex = 30
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 25
        Me.IconPictureBox2.Location = New System.Drawing.Point(113, 121)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox2.TabIndex = 29
        Me.IconPictureBox2.TabStop = False
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ListView1)
        Me.Panel7.Location = New System.Drawing.Point(699, 31)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(798, 707)
        Me.Panel7.TabIndex = 30
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView1.ForeColor = System.Drawing.SystemColors.Menu
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(798, 704)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom utilisateur"
        Me.ColumnHeader1.Width = 200
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Email"
        Me.ColumnHeader2.Width = 200
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Sexe"
        Me.ColumnHeader3.Width = 200
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Date de naissance"
        Me.ColumnHeader4.Width = 200
        '
        'Inscription
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1509, 771)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Inscription"
        Me.Text = "Inscription"
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel7.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel6 As Panel
    Friend WithEvents enregistrer As Button
    Friend WithEvents mdp2 As TextBox
    Friend WithEvents Panel5 As Panel
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents mdp As TextBox
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label2 As Label
    Friend WithEvents naissance As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents Email As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Nom As TextBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel7 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents initialiser As Button
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents sexe As ComboBox
    Friend WithEvents Label3 As Label
    Friend WithEvents erreur As Label
    Friend WithEvents IconButton3 As FontAwesome.Sharp.IconButton
    Friend WithEvents IconButton2 As FontAwesome.Sharp.IconButton
    Friend WithEvents Panel3 As Panel
    Friend WithEvents cacher2 As FontAwesome.Sharp.IconButton
    Friend WithEvents cacher As FontAwesome.Sharp.IconButton
End Class
