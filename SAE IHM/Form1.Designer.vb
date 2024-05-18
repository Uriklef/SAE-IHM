<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Me.btnQuitter = New System.Windows.Forms.Button()
        Me.LblChoisirNom = New System.Windows.Forms.Label()
        Me.ComboBoxNom = New System.Windows.Forms.ComboBox()
        Me.BtnTableauScore = New System.Windows.Forms.Button()
        Me.BtnLancerPartie = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnQuitter
        '
        Me.btnQuitter.Location = New System.Drawing.Point(25, 211)
        Me.btnQuitter.Name = "btnQuitter"
        Me.btnQuitter.Size = New System.Drawing.Size(136, 61)
        Me.btnQuitter.TabIndex = 0
        Me.btnQuitter.Text = "Quitter l'application"
        Me.btnQuitter.UseVisualStyleBackColor = True
        '
        'LblChoisirNom
        '
        Me.LblChoisirNom.AutoSize = True
        Me.LblChoisirNom.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblChoisirNom.Location = New System.Drawing.Point(22, 55)
        Me.LblChoisirNom.Name = "LblChoisirNom"
        Me.LblChoisirNom.Size = New System.Drawing.Size(158, 16)
        Me.LblChoisirNom.TabIndex = 1
        Me.LblChoisirNom.Text = "Saisissez votre nom : "
        '
        'ComboBoxNom
        '
        Me.ComboBoxNom.FormattingEnabled = True
        Me.ComboBoxNom.Location = New System.Drawing.Point(232, 55)
        Me.ComboBoxNom.Name = "ComboBoxNom"
        Me.ComboBoxNom.Size = New System.Drawing.Size(183, 21)
        Me.ComboBoxNom.TabIndex = 2
        '
        'BtnTableauScore
        '
        Me.BtnTableauScore.Location = New System.Drawing.Point(25, 114)
        Me.BtnTableauScore.Name = "BtnTableauScore"
        Me.BtnTableauScore.Size = New System.Drawing.Size(136, 61)
        Me.BtnTableauScore.TabIndex = 3
        Me.BtnTableauScore.Text = "Tableau des scores"
        Me.BtnTableauScore.UseVisualStyleBackColor = True
        '
        'BtnLancerPartie
        '
        Me.BtnLancerPartie.Location = New System.Drawing.Point(232, 146)
        Me.BtnLancerPartie.Name = "BtnLancerPartie"
        Me.BtnLancerPartie.Size = New System.Drawing.Size(183, 90)
        Me.BtnLancerPartie.TabIndex = 4
        Me.BtnLancerPartie.Text = "Lancer une nouvelle partie"
        Me.BtnLancerPartie.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(497, 327)
        Me.Controls.Add(Me.BtnLancerPartie)
        Me.Controls.Add(Me.BtnTableauScore)
        Me.Controls.Add(Me.ComboBoxNom)
        Me.Controls.Add(Me.LblChoisirNom)
        Me.Controls.Add(Me.btnQuitter)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnQuitter As Button
    Friend WithEvents LblChoisirNom As Label
    Friend WithEvents ComboBoxNom As ComboBox
    Friend WithEvents BtnTableauScore As Button
    Friend WithEvents BtnLancerPartie As Button
End Class
