﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class gestion_voiture
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader5 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader6 = New System.Windows.Forms.ColumnHeader()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.autre_ = New System.Windows.Forms.TextBox()
        Me.autre = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.citroen = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.peugeot = New Guna.UI2.WinForms.Guna2RadioButton()
        Me.place = New System.Windows.Forms.TextBox()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconPictureBox4 = New FontAwesome.Sharp.IconPictureBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.sortie = New Guna.UI2.WinForms.Guna2DateTimePicker()
        Me.erreur = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.initialiser = New System.Windows.Forms.Button()
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
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'Panel7
        '
        Me.Panel7.Controls.Add(Me.ListView1)
        Me.Panel7.Location = New System.Drawing.Point(672, 18)
        Me.Panel7.Name = "Panel7"
        Me.Panel7.Size = New System.Drawing.Size(893, 707)
        Me.Panel7.TabIndex = 32
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.Gray
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4, Me.ColumnHeader5, Me.ColumnHeader6})
        Me.ListView1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.ListView1.FullRowSelect = True
        Me.ListView1.Location = New System.Drawing.Point(0, 0)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(893, 727)
        Me.ListView1.TabIndex = 0
        Me.ListView1.UseCompatibleStateImageBehavior = False
        Me.ListView1.View = System.Windows.Forms.View.Details
        '
        'ColumnHeader1
        '
        Me.ColumnHeader1.Text = "Nom Chauffeur"
        Me.ColumnHeader1.Width = 150
        '
        'ColumnHeader2
        '
        Me.ColumnHeader2.Text = "Immatriculation"
        Me.ColumnHeader2.Width = 150
        '
        'ColumnHeader3
        '
        Me.ColumnHeader3.Text = "Nombre de place"
        Me.ColumnHeader3.Width = 150
        '
        'ColumnHeader4
        '
        Me.ColumnHeader4.Text = "Marque"
        Me.ColumnHeader4.Width = 150
        '
        'ColumnHeader5
        '
        Me.ColumnHeader5.Text = "Date entree"
        Me.ColumnHeader5.Width = 150
        '
        'ColumnHeader6
        '
        Me.ColumnHeader6.Text = "Date de sortie"
        Me.ColumnHeader6.Width = 150
        '
        'Panel6
        '
        Me.Panel6.Controls.Add(Me.Button2)
        Me.Panel6.Controls.Add(Me.autre_)
        Me.Panel6.Controls.Add(Me.autre)
        Me.Panel6.Controls.Add(Me.citroen)
        Me.Panel6.Controls.Add(Me.peugeot)
        Me.Panel6.Controls.Add(Me.place)
        Me.Panel6.Controls.Add(Me.Panel3)
        Me.Panel6.Controls.Add(Me.IconPictureBox4)
        Me.Panel6.Controls.Add(Me.Button1)
        Me.Panel6.Controls.Add(Me.Label4)
        Me.Panel6.Controls.Add(Me.sortie)
        Me.Panel6.Controls.Add(Me.erreur)
        Me.Panel6.Controls.Add(Me.Label3)
        Me.Panel6.Controls.Add(Me.initialiser)
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
        Me.Panel6.Location = New System.Drawing.Point(28, 18)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(608, 727)
        Me.Panel6.TabIndex = 31
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.Red
        Me.Button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button2.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight
        Me.Button2.Location = New System.Drawing.Point(3, 3)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(136, 41)
        Me.Button2.TabIndex = 64
        Me.Button2.Text = "Deconnexion"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'autre_
        '
        Me.autre_.Location = New System.Drawing.Point(209, 361)
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
        Me.autre.Location = New System.Drawing.Point(410, 320)
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
        Me.citroen.Location = New System.Drawing.Point(320, 320)
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
        Me.peugeot.Location = New System.Drawing.Point(230, 320)
        Me.peugeot.Name = "peugeot"
        Me.peugeot.Size = New System.Drawing.Size(84, 24)
        Me.peugeot.TabIndex = 60
        Me.peugeot.Text = "Peugeot"
        Me.peugeot.UncheckedState.BorderColor = System.Drawing.Color.FromArgb(CType(CType(125, Byte), Integer), CType(CType(137, Byte), Integer), CType(CType(149, Byte), Integer))
        Me.peugeot.UncheckedState.BorderThickness = 2
        Me.peugeot.UncheckedState.FillColor = System.Drawing.Color.Transparent
        Me.peugeot.UncheckedState.InnerColor = System.Drawing.Color.Transparent
        '
        'place
        '
        Me.place.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.place.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.place.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.place.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.place.Location = New System.Drawing.Point(149, 249)
        Me.place.Multiline = True
        Me.place.Name = "place"
        Me.place.PlaceholderText = "Nombre de place"
        Me.place.Size = New System.Drawing.Size(324, 32)
        Me.place.TabIndex = 58
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(114, 287)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(359, 1)
        Me.Panel3.TabIndex = 57
        '
        'IconPictureBox4
        '
        Me.IconPictureBox4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.PeopleArrows
        Me.IconPictureBox4.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox4.IconSize = 25
        Me.IconPictureBox4.Location = New System.Drawing.Point(114, 249)
        Me.IconPictureBox4.Name = "IconPictureBox4"
        Me.IconPictureBox4.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox4.TabIndex = 56
        Me.IconPictureBox4.TabStop = False
        '
        'Button1
        '
        Me.Button1.BackColor = System.Drawing.Color.Orange
        Me.Button1.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.Button1.FlatAppearance.BorderSize = 0
        Me.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Button1.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.Button1.Location = New System.Drawing.Point(410, 653)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(172, 54)
        Me.Button1.TabIndex = 55
        Me.Button1.Text = "Modifier"
        Me.Button1.UseVisualStyleBackColor = False
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Label4.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Label4.ForeColor = System.Drawing.SystemColors.ControlDark
        Me.Label4.Location = New System.Drawing.Point(113, 497)
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
        Me.sortie.Location = New System.Drawing.Point(113, 529)
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
        Me.erreur.Location = New System.Drawing.Point(113, 603)
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
        Me.Label3.Location = New System.Drawing.Point(143, 320)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(64, 18)
        Me.Label3.TabIndex = 50
        Me.Label3.Text = "Marque"
        '
        'initialiser
        '
        Me.initialiser.BackColor = System.Drawing.Color.Red
        Me.initialiser.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.initialiser.FlatAppearance.BorderSize = 0
        Me.initialiser.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.initialiser.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.initialiser.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.initialiser.Location = New System.Drawing.Point(46, 653)
        Me.initialiser.Name = "initialiser"
        Me.initialiser.Size = New System.Drawing.Size(161, 54)
        Me.initialiser.TabIndex = 48
        Me.initialiser.Text = "Supprimer"
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
        Me.enregistrer.Location = New System.Drawing.Point(222, 653)
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
        Me.Label2.Location = New System.Drawing.Point(113, 398)
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
        Me.entree.Location = New System.Drawing.Point(113, 430)
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
        Me.Label1.Location = New System.Drawing.Point(138, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(334, 51)
        Me.Label1.TabIndex = 35
        Me.Label1.Text = "Gestion Voiture"
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
        Me.IconPictureBox3.Location = New System.Drawing.Point(114, 320)
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
        'gestion_voiture
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1599, 798)
        Me.Controls.Add(Me.Panel7)
        Me.Controls.Add(Me.Panel6)
        Me.Name = "gestion_voiture"
        Me.Text = "gestion_voiture"
        Me.Panel7.ResumeLayout(False)
        Me.Panel6.ResumeLayout(False)
        Me.Panel6.PerformLayout()
        CType(Me.IconPictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Panel7 As Panel
    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents Panel6 As Panel
    Friend WithEvents erreur As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents initialiser As Button
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
    Friend WithEvents ColumnHeader5 As ColumnHeader
    Friend WithEvents ColumnHeader6 As ColumnHeader
    Friend WithEvents Button1 As Button
    Friend WithEvents Label4 As Label
    Friend WithEvents sortie As Guna.UI2.WinForms.Guna2DateTimePicker
    Friend WithEvents place As TextBox
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconPictureBox4 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents autre_ As TextBox
    Friend WithEvents autre As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents citroen As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents peugeot As Guna.UI2.WinForms.Guna2RadioButton
    Friend WithEvents Button2 As Button
End Class
