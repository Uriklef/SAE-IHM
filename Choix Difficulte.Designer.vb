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
        Me.RadioButton20Minutes = New System.Windows.Forms.RadioButton()
        Me.RadioButton15Minutes = New System.Windows.Forms.RadioButton()
        Me.RadioButton7Minutes = New System.Windows.Forms.RadioButton()
        Me.RadioButton4Minutes = New System.Windows.Forms.RadioButton()
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
        'RadioButton20Minutes
        '
        Me.RadioButton20Minutes.AutoSize = True
        Me.RadioButton20Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton20Minutes.Location = New System.Drawing.Point(52, 29)
        Me.RadioButton20Minutes.Name = "RadioButton20Minutes"
        Me.RadioButton20Minutes.Size = New System.Drawing.Size(98, 20)
        Me.RadioButton20Minutes.TabIndex = 5
        Me.RadioButton20Minutes.TabStop = True
        Me.RadioButton20Minutes.Text = "25 minutes"
        Me.RadioButton20Minutes.UseVisualStyleBackColor = True
        '
        'RadioButton15Minutes
        '
        Me.RadioButton15Minutes.AutoSize = True
        Me.RadioButton15Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton15Minutes.Location = New System.Drawing.Point(52, 66)
        Me.RadioButton15Minutes.Name = "RadioButton15Minutes"
        Me.RadioButton15Minutes.Size = New System.Drawing.Size(98, 20)
        Me.RadioButton15Minutes.TabIndex = 6
        Me.RadioButton15Minutes.TabStop = True
        Me.RadioButton15Minutes.Text = "15 minutes"
        Me.RadioButton15Minutes.UseVisualStyleBackColor = True
        '
        'RadioButton7Minutes
        '
        Me.RadioButton7Minutes.AutoSize = True
        Me.RadioButton7Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton7Minutes.Location = New System.Drawing.Point(52, 105)
        Me.RadioButton7Minutes.Name = "RadioButton7Minutes"
        Me.RadioButton7Minutes.Size = New System.Drawing.Size(90, 20)
        Me.RadioButton7Minutes.TabIndex = 7
        Me.RadioButton7Minutes.TabStop = True
        Me.RadioButton7Minutes.Text = "7 minutes"
        Me.RadioButton7Minutes.UseVisualStyleBackColor = True
        '
        'RadioButton4Minutes
        '
        Me.RadioButton4Minutes.AutoSize = True
        Me.RadioButton4Minutes.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.RadioButton4Minutes.Location = New System.Drawing.Point(52, 147)
        Me.RadioButton4Minutes.Name = "RadioButton4Minutes"
        Me.RadioButton4Minutes.Size = New System.Drawing.Size(90, 20)
        Me.RadioButton4Minutes.TabIndex = 8
        Me.RadioButton4Minutes.TabStop = True
        Me.RadioButton4Minutes.Text = "4 minutes"
        Me.RadioButton4Minutes.UseVisualStyleBackColor = True
        '
        'Panel1
        '
        Me.Panel1.AccessibleName = "test"
        Me.Panel1.BackColor = System.Drawing.Color.Snow
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.RadioButton4Minutes)
        Me.Panel1.Controls.Add(Me.RadioButton20Minutes)
        Me.Panel1.Controls.Add(Me.RadioButton7Minutes)
        Me.Panel1.Controls.Add(Me.RadioButton15Minutes)
        Me.Panel1.Location = New System.Drawing.Point(104, 96)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(207, 199)
        Me.Panel1.TabIndex = 10
        '
        'btnLancer
        '
        Me.btnLancer.BackColor = System.Drawing.Color.Snow
        Me.btnLancer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.btnLancer.Location = New System.Drawing.Point(127, 312)
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
        Me.BackgroundImage = Global.SAE_IHM.My.Resources.Resources._1000_F_808390035_jPKb4fKJgcbTKKcLW292kakHfsgEqKGq1
        Me.ClientSize = New System.Drawing.Size(424, 391)
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
    Friend WithEvents RadioButton20Minutes As RadioButton
    Friend WithEvents RadioButton15Minutes As RadioButton
    Friend WithEvents RadioButton7Minutes As RadioButton
    Friend WithEvents RadioButton4Minutes As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents btnLancer As Button
    Friend WithEvents Panel2 As Panel
End Class
