<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class gestionUtilisateur
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
        Me.ListView1 = New System.Windows.Forms.ListView()
        Me.ColumnHeader1 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader2 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader3 = New System.Windows.Forms.ColumnHeader()
        Me.ColumnHeader4 = New System.Windows.Forms.ColumnHeader()
        Me.decon = New FontAwesome.Sharp.IconButton()
        Me.menu = New FontAwesome.Sharp.IconButton()
        Me.SuspendLayout()
        '
        'ListView1
        '
        Me.ListView1.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ListView1.Columns.AddRange(New System.Windows.Forms.ColumnHeader() {Me.ColumnHeader1, Me.ColumnHeader2, Me.ColumnHeader3, Me.ColumnHeader4})
        Me.ListView1.ForeColor = System.Drawing.SystemColors.Menu
        Me.ListView1.Location = New System.Drawing.Point(162, 42)
        Me.ListView1.Name = "ListView1"
        Me.ListView1.Size = New System.Drawing.Size(1179, 629)
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
        'decon
        '
        Me.decon.BackColor = System.Drawing.Color.Red
        Me.decon.FlatAppearance.BorderSize = 0
        Me.decon.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.decon.IconChar = FontAwesome.Sharp.IconChar.DoorOpen
        Me.decon.IconColor = System.Drawing.Color.Black
        Me.decon.IconFont = FontAwesome.Sharp.IconFont.[Auto]
        Me.decon.Location = New System.Drawing.Point(71, 22)
        Me.decon.Name = "decon"
        Me.decon.Size = New System.Drawing.Size(39, 39)
        Me.decon.TabIndex = 68
        Me.decon.UseVisualStyleBackColor = False
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
        Me.menu.Location = New System.Drawing.Point(23, 22)
        Me.menu.Name = "menu"
        Me.menu.Padding = New System.Windows.Forms.Padding(0, 4, 0, 0)
        Me.menu.Size = New System.Drawing.Size(39, 39)
        Me.menu.TabIndex = 67
        Me.menu.UseVisualStyleBackColor = False
        '
        'gestionUtilisateur
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(32, Byte), Integer), CType(CType(29, Byte), Integer), CType(CType(30, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(1423, 709)
        Me.Controls.Add(Me.decon)
        Me.Controls.Add(Me.menu)
        Me.Controls.Add(Me.ListView1)
        Me.Name = "gestionUtilisateur"
        Me.Text = "gestionUtilisateur"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents ListView1 As ListView
    Friend WithEvents ColumnHeader1 As ColumnHeader
    Friend WithEvents ColumnHeader2 As ColumnHeader
    Friend WithEvents ColumnHeader3 As ColumnHeader
    Friend WithEvents ColumnHeader4 As ColumnHeader
    Friend WithEvents decon As FontAwesome.Sharp.IconButton
    Friend WithEvents menu As FontAwesome.Sharp.IconButton
End Class
