<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Connexion = New System.Windows.Forms.Button()
        Me.inscri = New System.Windows.Forms.Button()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.mdp = New System.Windows.Forms.TextBox()
        Me.CheckBox1 = New System.Windows.Forms.CheckBox()
        Me.erreur = New System.Windows.Forms.Label()
        Me.Guna2TaskBarProgress1 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.Guna2TaskBarProgress2 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'IconPictureBox1
        '
        Me.IconPictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.Users
        Me.IconPictureBox1.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox1.IconSize = 195
        Me.IconPictureBox1.Location = New System.Drawing.Point(156, 63)
        Me.IconPictureBox1.Name = "IconPictureBox1"
        Me.IconPictureBox1.Size = New System.Drawing.Size(255, 195)
        Me.IconPictureBox1.TabIndex = 0
        Me.IconPictureBox1.TabStop = False
        '
        'IconPictureBox2
        '
        Me.IconPictureBox2.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.UserAlt
        Me.IconPictureBox2.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox2.IconSize = 25
        Me.IconPictureBox2.Location = New System.Drawing.Point(68, 304)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox2.TabIndex = 2
        Me.IconPictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(68, 342)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 1)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(68, 431)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(359, 1)
        Me.Panel3.TabIndex = 5
        '
        'IconPictureBox3
        '
        Me.IconPictureBox3.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.IconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.UnlockAlt
        Me.IconPictureBox3.IconColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.IconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.IconPictureBox3.IconSize = 25
        Me.IconPictureBox3.Location = New System.Drawing.Point(68, 393)
        Me.IconPictureBox3.Name = "IconPictureBox3"
        Me.IconPictureBox3.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox3.TabIndex = 4
        Me.IconPictureBox3.TabStop = False
        '
        'Connexion
        '
        Me.Connexion.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Connexion.FlatAppearance.BorderSize = 0
        Me.Connexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.Connexion.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.Connexion.ForeColor = System.Drawing.Color.White
        Me.Connexion.Location = New System.Drawing.Point(68, 540)
        Me.Connexion.Name = "Connexion"
        Me.Connexion.Size = New System.Drawing.Size(180, 54)
        Me.Connexion.TabIndex = 6
        Me.Connexion.Text = "Connexion"
        Me.Connexion.UseVisualStyleBackColor = False
        '
        'inscri
        '
        Me.inscri.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.inscri.FlatAppearance.BorderColor = System.Drawing.Color.White
        Me.inscri.FlatAppearance.BorderSize = 0
        Me.inscri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inscri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inscri.ForeColor = System.Drawing.SystemColors.ButtonFace
        Me.inscri.Location = New System.Drawing.Point(254, 540)
        Me.inscri.Name = "inscri"
        Me.inscri.Size = New System.Drawing.Size(173, 54)
        Me.inscri.TabIndex = 7
        Me.inscri.Text = "Inscription"
        Me.inscri.UseVisualStyleBackColor = False
        '
        'Nom
        '
        Me.Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Nom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Nom.Location = New System.Drawing.Point(103, 304)
        Me.Nom.Name = "Nom"
        Me.Nom.PlaceholderText = "Nom utilisateur"
        Me.Nom.Size = New System.Drawing.Size(324, 21)
        Me.Nom.TabIndex = 8
        '
        'mdp
        '
        Me.mdp.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.mdp.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.mdp.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.mdp.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.mdp.Location = New System.Drawing.Point(103, 393)
        Me.mdp.Name = "mdp"
        Me.mdp.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.mdp.PlaceholderText = "Mot de Passe"
        Me.mdp.Size = New System.Drawing.Size(324, 21)
        Me.mdp.TabIndex = 9
        Me.mdp.UseSystemPasswordChar = True
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.CheckBox1.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.CheckBox1.Location = New System.Drawing.Point(68, 475)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(279, 26)
        Me.CheckBox1.TabIndex = 10
        Me.CheckBox1.Text = "Se memoriser du mot de passe"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'erreur
        '
        Me.erreur.AutoSize = True
        Me.erreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.erreur.ForeColor = System.Drawing.Color.Red
        Me.erreur.Location = New System.Drawing.Point(68, 249)
        Me.erreur.Name = "erreur"
        Me.erreur.Size = New System.Drawing.Size(381, 22)
        Me.erreur.TabIndex = 11
        Me.erreur.Text = "Nom utilisateur ou Mot de Passe est Incorrecte"
        Me.erreur.Visible = False
        '
        'Guna2TaskBarProgress1
        '
        Me.Guna2TaskBarProgress1.TargetForm = Nothing
        '
        'Guna2TaskBarProgress2
        '
        Me.Guna2TaskBarProgress2.TargetForm = Nothing
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(489, 636)
        Me.Controls.Add(Me.erreur)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.mdp)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.inscri)
        Me.Controls.Add(Me.Connexion)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.IconPictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IconPictureBox2)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.Cursor = System.Windows.Forms.Cursors.PanNE
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Name = "Form1"
        Me.Text = "Connexion"
        CType(Me.IconPictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.IconPictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents IconPictureBox1 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents IconPictureBox2 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Panel2 As Panel
    Friend WithEvents Panel3 As Panel
    Friend WithEvents IconPictureBox3 As FontAwesome.Sharp.IconPictureBox
    Friend WithEvents Connexion As Button
    Friend WithEvents inscri As Button
    Friend WithEvents Nom As TextBox
    Friend WithEvents mdp As TextBox
    Friend WithEvents CheckBox1 As CheckBox
    Friend WithEvents erreur As Label
    Friend WithEvents Guna2TaskBarProgress1 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Guna2TaskBarProgress2 As Guna.UI2.WinForms.Guna2TaskBarProgress
End Class
