<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class GestionCamion
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
        Me.Panel7 = New System.Windows.Forms.Panel()
        Me.lista = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.decon = New FontAwesome.Sharp.IconButton()
        Me.tonnage = New System.Windows.Forms.TextBox()
        Me.menu = New FontAwesome.Sharp.IconButton()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.IconPictureBox5 = New FontAwesome.Sharp.IconPictureBox()
        Me.autre_ = New System.Windows.Forms.TextBox()
        Me.autre = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.citroen = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.peugeot = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.modifier = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sortie = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.erreur = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.supprimer = New System.Windows.Forms.Button()
        Me.enregistrer = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.entree = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.matricule = New System.Windows.Forms.TextBox()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel7.SuspendLayout()
        Me.Panel6.SuspendLayout()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.lista)
        Me.Panel7.Location = New System.Drawing.Point(666, 12)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(1617, 845)
        Me.Panel7.TabIndex = 34
        '
        'lista
        '
        Me.lista.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.lista.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.lista.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.lista.ForeColor = System.Drawing.SystemColors.Menu
        Me.lista.FullRowSelect = True
        Me.lista.Location = New System.Drawing.Point(0, 3)
        Me.lista.Name = "lista"
        Me.lista.Size = New System.Drawing.Size(1008, 799)
        Me.lista.TabIndex = 0
        Me.lista.UseCompatibleStateImageBehavior = False
        Me.lista.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom Chauffeur"
        Me.ColumnHeader1.Width = 170
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Immatriculation"
        Me.ColumnHeader2.Width = 170
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Tonnage"
        Me.ColumnHeader3.Width = 170
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Marque"
        Me.ColumnHeader4.Width = 170
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date entree"
        Me.ColumnHeader5.Width = 170
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date de sortie"
        Me.ColumnHeader6.Width = 170
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.decon)
        Me.Panel6.Controls.Add(Me.tonnage)
        Me.Panel6.Controls.Add(Me.menu)
        Me.Panel6.Controls.Add(Me.Panel4)
        Me.Panel6.Controls.Add(Me.IconPictureBox5)
        Me.Panel6.Controls.Add(Me.autre_)
        Me.Panel6.Controls.Add(Me.autre)
        Me.Panel6.Controls.Add(Me.citroen)
        Me.Panel6.Controls.Add(Me.peugeot)
        Me.Panel6.Controls.Add(Me.modifier)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.sortie)
        Me.Panel6.Controls.Add(Me.erreur)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.supprimer)
        Me.Panel6.Controls.Add(Me.enregistrer)
        Me.Panel6.Controls.Add(Me.Label2)
        Me.Panel6.Controls.Add(Me.entree)
        Me.Panel6.Controls.Add(Me.matricule)
        Me.Panel6.Controls.Add(Me.Panel1)
        Me.Panel6.Controls.Add(Me.IconPictureBox1)
        Me.Panel6.Controls.Add(Me.Label1)
        Me.Panel6.Controls.Add(Me.Nom)
        Me.Panel6.Controls.Add(Me.IconPictureBox3)
        Me.Panel6.Controls.Add(Me.Panel2)
        Me.Panel6.Controls.Add(Me.IconPictureBox2)
        Me.Panel6.Location = New System.Drawing.Point(22, 12)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(1765, 802)
        Me.Panel6.TabIndex = 33
        '
        'decon
        '
        Me.decon.BackColor = System.Drawing.Color.Red
        Me.decon.FlatAppearance.BorderSize = 0
        Me.decon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.decon.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.decon.IconColor = System.Drawing.Color.Black
        Me.decon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.decon.Location = New System.Drawing.Point(51, 0)
        Me.decon.Name = "decon"
        Me.decon.Size = New System.Drawing.Size(39, 39)
        Me.decon.TabIndex = 66
        Me.decon.UseVisualStyleBackColor = False
        '
        'tonnage
        '
        Me.tonnage.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.tonnage.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tonnage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.tonnage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.tonnage.Location = New System.Drawing.Point(148, 254)
        Me.tonnage.Multiline = True
        Me.tonnage.Name = "tonnage"
        Me.tonnage.PlaceholderText = "Tonnage"
        Me.tonnage.Size = New System.Drawing.Size(324, 32)
        Me.tonnage.TabIndex = 67
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
        Me.menu.Location = New System.Drawing.Point(3, 0)
        Me.menu.Name = "menu"
        Me.menu.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.menu.Size = New System.Drawing.Size(39, 39)
        Me.menu.TabIndex = 65
        Me.menu.UseVisualStyleBackColor = False
        '
        'Panel4
        '
        Me.Panel4.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel4.Location = New System.Drawing.Point(113, 292)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(359, 1)
        Me.Panel4.TabIndex = 66
        '
        'IconPictureBox5
        '
        Me.IconPictureBox5.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.Weight
        Me.IconPictureBox5.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox5.IconSize = 25
        Me.IconPictureBox5.Location = New System.Drawing.Point(113, 254)
        Me.IconPictureBox5.Name = "IconPictureBox5"
        Me.IconPictureBox5.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox5.TabIndex = 65
        Me.IconPictureBox5.TabStop = False
        '
        'autre_
        '
        Me.autre_.Location = New System.Drawing.Point(207, 389)
        Me.autre_.Name = "autre_"
        Me.autre_.PlaceholderText = "Autre"
        Me.autre_.Size = New System.Drawing.Size(159, 27)
        Me.autre_.TabIndex = 63
        '
        'autre
        '
        Me.autre.AutoSize = True
        Me.autre.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.autre.CheckedState.BorderThickness = 0
        Me.autre.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.autre.CheckedState.InnerColor = System.Drawing.Color.White
        Me.autre.CheckedState.InnerOffset = -4
        Me.autre.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.autre.Location = New System.Drawing.Point(406, 341)
        Me.autre.Name = "autre"
        Me.autre.Size = New System.Drawing.Size(66, 24)
        Me.autre.TabIndex = 62
        Me.autre.Text = "Autre"
        Me.autre.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.autre.UncheckedState.BorderThickness = 2
        Me.autre.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.autre.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'citroen
        '
        Me.citroen.AutoSize = True
        Me.citroen.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.citroen.CheckedState.BorderThickness = 0
        Me.citroen.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.citroen.CheckedState.InnerColor = System.Drawing.Color.White
        Me.citroen.CheckedState.InnerOffset = -4
        Me.citroen.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.citroen.Location = New System.Drawing.Point(316, 341)
        Me.citroen.Name = "citroen"
        Me.citroen.Size = New System.Drawing.Size(78, 24)
        Me.citroen.TabIndex = 61
        Me.citroen.Text = "Citroen"
        Me.citroen.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.citroen.UncheckedState.BorderThickness = 2
        Me.citroen.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.citroen.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'peugeot
        '
        Me.peugeot.AutoSize = True
        Me.peugeot.CheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.peugeot.CheckedState.BorderThickness = 0
        Me.peugeot.CheckedState.FillColor = System.Drawing.Color.FromArgb(CType(CType(94, Byte), Integer), CType(CType(148, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.peugeot.CheckedState.InnerColor = System.Drawing.Color.White
        Me.peugeot.CheckedState.InnerOffset = -4
        Me.peugeot.ForeColor = System.Drawing.SystemColors.ActiveBorder
        Me.peugeot.Location = New System.Drawing.Point(226, 341)
        Me.peugeot.Name = "peugeot"
        Me.peugeot.Size = New System.Drawing.Size(84, 24)
        Me.peugeot.TabIndex = 60
        Me.peugeot.Text = "Peugeot"
        Me.peugeot.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.peugeot.UncheckedState.BorderThickness = 2
        Me.peugeot.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.peugeot.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'modifier
        '
        Me.modifier.BackColor = System.Drawing.Color.Orange
        Me.modifier.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.modifier.FlatAppearance.BorderSize = 0
        Me.modifier.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.modifier.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.modifier.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.modifier.Location = New System.Drawing.Point(410, 700)
        Me.modifier.Name = "modifier"
        Me.modifier.Size = New System.Drawing.Size(172, 54)
        Me.modifier.TabIndex = 55
        Me.modifier.Text = "Modifier"
        Me.modifier.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(113, 544)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(114, 18)
        Me.Label4.TabIndex = 54
        Me.Label4.Text = "Date de sortie"
        '
        'sortie
        '
        Me.sortie.Checked = True
        Me.sortie.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.sortie.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.sortie.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.sortie.Location = New System.Drawing.Point(113, 587)
        Me.sortie.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.sortie.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.sortie.Name = "sortie"
        Me.sortie.Size = New System.Drawing.Size(359, 43)
        Me.sortie.TabIndex = 53
        Me.sortie.Value = New Date(2022, 4, 1, 11, 46, 16, 0)
        '
        'erreur
        '
        Me.erreur.AutoSize = True
        Me.erreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.erreur.ForeColor = System.Drawing.Color.Red
        Me.erreur.Location = New System.Drawing.Point(113, 654)
        Me.erreur.Name = "erreur"
        Me.erreur.Size = New System.Drawing.Size(277, 22)
        Me.erreur.TabIndex = 52
        Me.erreur.Text = "Veuillez Entrez les champs requis"
        Me.erreur.Visible = False
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label3.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label3.Location = New System.Drawing.Point(139, 341)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Marque"
        '
        'supprimer
        '
        Me.supprimer.BackColor = System.Drawing.Color.Red
        Me.supprimer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.supprimer.FlatAppearance.BorderSize = 0
        Me.supprimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.supprimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.supprimer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.supprimer.Location = New System.Drawing.Point(46, 700)
        Me.supprimer.Name = "supprimer"
        Me.supprimer.Size = New System.Drawing.Size(161, 54)
        Me.supprimer.TabIndex = 48
        Me.supprimer.Text = "Supprimer"
        Me.supprimer.UseVisualStyleBackColor = False
        '
        'enregistrer
        '
        Me.enregistrer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.enregistrer.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.enregistrer.FlatAppearance.BorderSize = 0
        Me.enregistrer.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.enregistrer.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.enregistrer.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.enregistrer.Location = New System.Drawing.Point(222, 700)
        Me.enregistrer.Name = "enregistrer"
        Me.enregistrer.Size = New System.Drawing.Size(172, 54)
        Me.enregistrer.TabIndex = 47
        Me.enregistrer.Text = "Enregistrer"
        Me.enregistrer.UseVisualStyleBackColor = False
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label2.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label2.Location = New System.Drawing.Point(112, 447)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(95, 18)
        Me.Label2.TabIndex = 40
        Me.Label2.Text = "Date entree"
        '
        'entree
        '
        Me.entree.Checked = True
        Me.entree.FillColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.entree.Font = New System.Drawing.Font("Segoe UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.entree.Format = System.Windows.Forms.DateTimePickerFormat.[Long]
        Me.entree.Location = New System.Drawing.Point(113, 482)
        Me.entree.MaxDate = New Date(9998, 12, 31, 0, 0, 0, 0)
        Me.entree.MinDate = New Date(1753, 1, 1, 0, 0, 0, 0)
        Me.entree.Name = "entree"
        Me.entree.Size = New System.Drawing.Size(359, 43)
        Me.entree.TabIndex = 39
        Me.entree.Value = New Date(2022, 4, 1, 11, 46, 16, 0)
        '
        'matricule
        '
        Me.matricule.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.matricule.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.matricule.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.matricule.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.matricule.Location = New System.Drawing.Point(148, 182)
        Me.matricule.Multiline = True
        Me.matricule.Name = "matricule"
        Me.matricule.PlaceholderText = "Immatriculation"
        Me.matricule.Size = New System.Drawing.Size(324, 32)
        Me.matricule.TabIndex = 38
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
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.IdCard
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
        Me.Label1.Location = New System.Drawing.Point(112, 47)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(368, 51)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Gestion Camions"
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
        Me.Nom.PlaceholderText = "Nom Chauffeur"
        Me.Nom.Size = New System.Drawing.Size(324, 32)
        Me.Nom.TabIndex = 33
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Car
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 25
        Me.IconPictureBox3.Location = New System.Drawing.Point(110, 341)
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
        'GestionCamion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None
        Me.ClientSize = New System.Drawing.Size(1686, 840)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "GestionCamion"
        Me.ShowIcon = False
        Me.Text = "GestionCamion"
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.IconPictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents lista As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents autre_ As TextBox
    Friend WithEvents autre As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents citroen As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents peugeot As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents modifier As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents sortie As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents erreur As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents supprimer As Button
    Friend WithEvents enregistrer As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents entree As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents matricule As TextBox
    Friend WithEvents Panel1 As Panel
    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Nom As TextBox
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents tonnage As TextBox
    Friend WithEvents Panel4 As Panel
    Friend WithEvents IconPictureBox5 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents decon As FontAwesome.Sharp.IconButton
    Friend WithEvents menu As FontAwesome.Sharp.IconButton
End Class
