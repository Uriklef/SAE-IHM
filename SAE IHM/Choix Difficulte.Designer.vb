<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Choix_Difficulte
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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.RadioButtonFacile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonMoyen = New System.Windows.Forms.RadioButton()
        Me.RadioButtonDifficile = New System.Windows.Forms.RadioButton()
        Me.RadioButtonExpert = New System.Windows.Forms.RadioButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.btnLancer = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.Panel1.SuspendLayout()
        Me.Panel2.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Snow
        Me.Label1.Font = New System.Drawing.Font("Impact", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Brown
        Me.Label1.Location = New System.Drawing.Point(6, 5)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(345, 60)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Choix Difficulté :"
        '
        'RadioButtonFacile
        '
        Me.RadioButtonFacile.AutoSize = True
        Me.RadioButtonFacile.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonFacile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonFacile.ForeColor = System.Drawing.Color.Lime
        Me.RadioButtonFacile.Location = New System.Drawing.Point(25, 35)
        Me.RadioButtonFacile.Name = "RadioButtonFacile"
        Me.RadioButtonFacile.Size = New System.Drawing.Size(155, 20)
        Me.RadioButtonFacile.TabIndex = 5
        Me.RadioButtonFacile.TabStop = True
        Me.RadioButtonFacile.Text = "Facile (25 minutes)"
        Me.RadioButtonFacile.UseVisualStyleBackColor = False
        '
        'RadioButtonMoyen
        '
        Me.RadioButtonMoyen.AutoSize = True
        Me.RadioButtonMoyen.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonMoyen.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonMoyen.ForeColor = System.Drawing.Color.Yellow
        Me.RadioButtonMoyen.Location = New System.Drawing.Point(25, 76)
        Me.RadioButtonMoyen.Name = "RadioButtonMoyen"
        Me.RadioButtonMoyen.Size = New System.Drawing.Size(162, 20)
        Me.RadioButtonMoyen.TabIndex = 6
        Me.RadioButtonMoyen.TabStop = True
        Me.RadioButtonMoyen.Text = "Normal (15 minutes)"
        Me.RadioButtonMoyen.UseVisualStyleBackColor = False
        '
        'RadioButtonDifficile
        '
        Me.RadioButtonDifficile.AutoSize = True
        Me.RadioButtonDifficile.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonDifficile.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonDifficile.ForeColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(128, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.RadioButtonDifficile.Location = New System.Drawing.Point(24, 121)
        Me.RadioButtonDifficile.Name = "RadioButtonDifficile"
        Me.RadioButtonDifficile.Size = New System.Drawing.Size(156, 20)
        Me.RadioButtonDifficile.TabIndex = 7
        Me.RadioButtonDifficile.TabStop = True
        Me.RadioButtonDifficile.Text = "Difficile (7 minutes)"
        Me.RadioButtonDifficile.UseVisualStyleBackColor = False
        '
        'RadioButtonExpert
        '
        Me.RadioButtonExpert.AutoSize = True
        Me.RadioButtonExpert.BackColor = System.Drawing.Color.Transparent
        Me.RadioButtonExpert.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButtonExpert.ForeColor = System.Drawing.Color.Red
        Me.RadioButtonExpert.Location = New System.Drawing.Point(25, 165)
        Me.RadioButtonExpert.Name = "RadioButtonExpert"
        Me.RadioButtonExpert.Size = New System.Drawing.Size(148, 20)
        Me.RadioButtonExpert.TabIndex = 8
        Me.RadioButtonExpert.TabStop = True
        Me.RadioButtonExpert.Text = "Expert (4 minutes)"
        Me.RadioButtonExpert.UseVisualStyleBackColor = False
        '
        'Panel1
        '
        Me.Panel1.AccessibleName = "test"
        Me.Panel1.BackColor = System.Drawing.Color.Black
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButtonExpert)
        Me.Panel1.Controls.Add(Me.RadioButtonFacile)
        Me.Panel1.Controls.Add(Me.RadioButtonDifficile)
        Me.Panel1.Controls.Add(Me.RadioButtonMoyen)
        Me.Panel1.Location = New System.Drawing.Point(104, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 220)
        Me.Panel1.TabIndex = 10
        '
        'btnLancer
        '
        Me.btnLancer.BackColor = System.Drawing.Color.Snow
        Me.btnLancer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLancer.Location = New System.Drawing.Point(127, 349)
        Me.btnLancer.Name = "btnLancer"
        Me.btnLancer.Size = New System.Drawing.Size(158, 67)
        Me.btnLancer.TabIndex = 11
        Me.btnLancer.Text = "LANCER LA PARTIE"
        Me.btnLancer.UseVisualStyleBackColor = False
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.Label1)
        Me.Panel2.Location = New System.Drawing.Point(38, 9)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(356, 72)
        Me.Panel2.TabIndex = 12
        '
        'Choix_Difficulte
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAE_IHM.My.Resources.Resources.fond
        Me.ClientSize = New System.Drawing.Size(424, 440)
        Me.Controls.Add(Me.btnLancer)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Choix_Difficulte"
        Me.Text = "Choix_Difficulte"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents RadioButtonFacile As RadioButton
    Friend WithEvents RadioButtonMoyen As RadioButton
    Friend WithEvents RadioButtonDifficile As RadioButton
    Friend WithEvents RadioButtonExpert As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLancer As Button
    Friend WithEvents Panel2 As Panel
End Class
