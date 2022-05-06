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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.IconPictureBox1 = New FontAwesome.Sharp.IconPictureBox()
        Me.IconPictureBox2 = New FontAwesome.Sharp.IconPictureBox()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.IconPictureBox3 = New FontAwesome.Sharp.IconPictureBox()
        Me.Connexion = New System.Windows.Forms.Button()
        Me.Nom = New System.Windows.Forms.TextBox()
        Me.mdp = New System.Windows.Forms.TextBox()
        Me.affichage = New System.Windows.Forms.CheckBox()
        Me.erreur = New System.Windows.Forms.Label()
        Me.Guna2TaskBarProgress1 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.Guna2TaskBarProgress2 = New Guna.UI2.WinForms.Guna2TaskBarProgress(Me.components)
        Me.inscri = New System.Windows.Forms.Button()
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
        Me.IconPictureBox2.Location = New System.Drawing.Point(68, 271)
        Me.IconPictureBox2.Name = "IconPictureBox2"
        Me.IconPictureBox2.Size = New System.Drawing.Size(25, 25)
        Me.IconPictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.IconPictureBox2.TabIndex = 2
        Me.IconPictureBox2.TabStop = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(68, 309)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(359, 1)
        Me.Panel2.TabIndex = 3
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Panel3.Location = New System.Drawing.Point(68, 398)
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
        Me.IconPictureBox3.Location = New System.Drawing.Point(68, 360)
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
        Me.Connexion.Location = New System.Drawing.Point(67, 519)
        Me.Connexion.Name = "Connexion"
        Me.Connexion.Size = New System.Drawing.Size(177, 54)
        Me.Connexion.TabIndex = 6
        Me.Connexion.Text = "Connexion"
        Me.Connexion.UseVisualStyleBackColor = False
        '
        'Nom
        '
        Me.Nom.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.Nom.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.Nom.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point)
        Me.Nom.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.Nom.Location = New System.Drawing.Point(103, 271)
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
        Me.mdp.Location = New System.Drawing.Point(103, 360)
        Me.mdp.Name = "mdp"
        Me.mdp.PlaceholderText = "Mot de Passe"
        Me.mdp.Size = New System.Drawing.Size(324, 21)
        Me.mdp.TabIndex = 9
        Me.mdp.UseSystemPasswordChar = True
        '
        'affichage
        '
        Me.affichage.AutoSize = True
        Me.affichage.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.affichage.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(117, Byte), Integer), CType(CType(214, Byte), Integer))
        Me.affichage.Location = New System.Drawing.Point(68, 444)
        Me.affichage.Name = "affichage"
        Me.affichage.Size = New System.Drawing.Size(224, 26)
        Me.affichage.TabIndex = 10
        Me.affichage.Text = "Afficher le mot de passe"
        Me.affichage.UseVisualStyleBackColor = True
        '
        'erreur
        '
        Me.erreur.AutoSize = True
        Me.erreur.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.erreur.ForeColor = System.Drawing.Color.Red
        Me.erreur.Location = New System.Drawing.Point(68, 221)
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
        'inscri
        '
        Me.inscri.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.inscri.FlatAppearance.BorderSize = 0
        Me.inscri.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.inscri.Font = New System.Drawing.Font("Microsoft Sans Serif", 10.8!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point)
        Me.inscri.ForeColor = System.Drawing.Color.White
        Me.inscri.Location = New System.Drawing.Point(250, 519)
        Me.inscri.Name = "inscri"
        Me.inscri.Size = New System.Drawing.Size(177, 54)
        Me.inscri.TabIndex = 13
        Me.inscri.Text = "Inscription"
        Me.inscri.UseVisualStyleBackColor = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(489, 636)
        Me.Controls.Add(Me.inscri)
        Me.Controls.Add(Me.erreur)
        Me.Controls.Add(Me.affichage)
        Me.Controls.Add(Me.mdp)
        Me.Controls.Add(Me.Nom)
        Me.Controls.Add(Me.Connexion)
        Me.Controls.Add(Me.Panel3)
        Me.Controls.Add(Me.IconPictureBox3)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.IconPictureBox2)
        Me.Controls.Add(Me.IconPictureBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.MdiChildrenMinimizedAnchorBottom = False
        Me.MinimizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
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
    Friend WithEvents Nom As TextBox
    Friend WithEvents mdp As TextBox
    Friend WithEvents affichage As CheckBox
    Friend WithEvents erreur As Label
    Friend WithEvents Guna2TaskBarProgress1 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents Guna2TaskBarProgress2 As Guna.UI2.WinForms.Guna2TaskBarProgress
    Friend WithEvents inscri As Button
End Class
