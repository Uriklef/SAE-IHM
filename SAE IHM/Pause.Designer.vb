<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pause
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
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.BtnReprendre = New System.Windows.Forms.Button()
        Me.labelMinuteur = New System.Windows.Forms.Label()
        Me.lblNbErreursRestantes = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Papyrus", 27.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(90, 24)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(197, 58)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "PAUSE"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(12, 115)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(144, 24)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Temps restant : "
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.Location = New System.Drawing.Point(12, 164)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(167, 24)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Erreurs restantes : "
        '
        'BtnReprendre
        '
        Me.BtnReprendre.Location = New System.Drawing.Point(89, 237)
        Me.BtnReprendre.Name = "BtnReprendre"
        Me.BtnReprendre.Size = New System.Drawing.Size(188, 69)
        Me.BtnReprendre.TabIndex = 4
        Me.BtnReprendre.Text = "Reprendre"
        Me.BtnReprendre.UseVisualStyleBackColor = True
        '
        'labelMinuteur
        '
        Me.labelMinuteur.AutoSize = True
        Me.labelMinuteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMinuteur.Location = New System.Drawing.Point(174, 115)
        Me.labelMinuteur.Name = "labelMinuteur"
        Me.labelMinuteur.Size = New System.Drawing.Size(49, 24)
        Me.labelMinuteur.TabIndex = 88
        Me.labelMinuteur.Text = "0:00"
        '
        'lblNbErreursRestantes
        '
        Me.lblNbErreursRestantes.AutoSize = True
        Me.lblNbErreursRestantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbErreursRestantes.Location = New System.Drawing.Point(185, 164)
        Me.lblNbErreursRestantes.Name = "lblNbErreursRestantes"
        Me.lblNbErreursRestantes.Size = New System.Drawing.Size(21, 24)
        Me.lblNbErreursRestantes.TabIndex = 90
        Me.lblNbErreursRestantes.Text = "0"
        '
        'Pause
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(370, 339)
        Me.Controls.Add(Me.lblNbErreursRestantes)
        Me.Controls.Add(Me.labelMinuteur)
        Me.Controls.Add(Me.BtnReprendre)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Pause"
        Me.Text = "Pause"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents BtnReprendre As Button
    Friend WithEvents labelMinuteur As Label
    Friend WithEvents lblNbErreursRestantes As Label
End Class
