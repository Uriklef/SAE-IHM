﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form2
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
        Me.components = New System.ComponentModel.Container()
        Me.BtnAbandonner = New System.Windows.Forms.Button()
        Me.LblTimer = New System.Windows.Forms.Label()
        Me.LblNombreErreurs = New System.Windows.Forms.Label()
        Me.BtnIndice = New System.Windows.Forms.Button()
        Me.Timer = New System.Windows.Forms.Timer(Me.components)
        Me.labelMinuteur = New System.Windows.Forms.Label()
        Me.BtnTerminer = New System.Windows.Forms.Button()
        Me.lblNbErreursRestantes = New System.Windows.Forms.Label()
        Me.TableLayoutPanelQuadrillage = New System.Windows.Forms.TableLayoutPanel()
        Me.BtnCommencer = New System.Windows.Forms.Button()
        Me.BtnQuitter = New System.Windows.Forms.Button()
        Me.BtnPause = New System.Windows.Forms.Button()
        Me.lblNbFoisIndice = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.BtnCouperSon = New System.Windows.Forms.Button()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'BtnAbandonner
        '
        Me.BtnAbandonner.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAbandonner.Enabled = False
        Me.BtnAbandonner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAbandonner.Location = New System.Drawing.Point(528, 375)
        Me.BtnAbandonner.Name = "BtnAbandonner"
        Me.BtnAbandonner.Size = New System.Drawing.Size(118, 57)
        Me.BtnAbandonner.TabIndex = 81
        Me.BtnAbandonner.Text = "ABANDONNER"
        Me.BtnAbandonner.UseVisualStyleBackColor = False
        Me.BtnAbandonner.Visible = False
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.BackColor = System.Drawing.Color.Snow
        Me.LblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.ForeColor = System.Drawing.Color.Brown
        Me.LblTimer.Location = New System.Drawing.Point(503, 94)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(134, 20)
        Me.LblTimer.TabIndex = 82
        Me.LblTimer.Text = "Temps restant :"
        '
        'LblNombreErreurs
        '
        Me.LblNombreErreurs.AutoSize = True
        Me.LblNombreErreurs.BackColor = System.Drawing.Color.Snow
        Me.LblNombreErreurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreErreurs.ForeColor = System.Drawing.Color.Brown
        Me.LblNombreErreurs.Location = New System.Drawing.Point(503, 130)
        Me.LblNombreErreurs.Name = "LblNombreErreurs"
        Me.LblNombreErreurs.Size = New System.Drawing.Size(159, 20)
        Me.LblNombreErreurs.TabIndex = 83
        Me.LblNombreErreurs.Text = "Erreurs restantes :"
        '
        'BtnIndice
        '
        Me.BtnIndice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIndice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIndice.Location = New System.Drawing.Point(528, 289)
        Me.BtnIndice.Name = "BtnIndice"
        Me.BtnIndice.Size = New System.Drawing.Size(118, 57)
        Me.BtnIndice.TabIndex = 85
        Me.BtnIndice.Text = "INDICE       "
        Me.BtnIndice.UseVisualStyleBackColor = False
        '
        'Timer
        '
        '
        'labelMinuteur
        '
        Me.labelMinuteur.AutoSize = True
        Me.labelMinuteur.BackColor = System.Drawing.Color.Snow
        Me.labelMinuteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMinuteur.ForeColor = System.Drawing.Color.Brown
        Me.labelMinuteur.Location = New System.Drawing.Point(634, 90)
        Me.labelMinuteur.Name = "labelMinuteur"
        Me.labelMinuteur.Size = New System.Drawing.Size(49, 24)
        Me.labelMinuteur.TabIndex = 87
        Me.labelMinuteur.Text = "0:00"
        '
        'BtnTerminer
        '
        Me.BtnTerminer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTerminer.Location = New System.Drawing.Point(528, 202)
        Me.BtnTerminer.Name = "BtnTerminer"
        Me.BtnTerminer.Size = New System.Drawing.Size(118, 57)
        Me.BtnTerminer.TabIndex = 88
        Me.BtnTerminer.Text = "VALIDER"
        Me.BtnTerminer.UseVisualStyleBackColor = False
        '
        'lblNbErreursRestantes
        '
        Me.lblNbErreursRestantes.AutoSize = True
        Me.lblNbErreursRestantes.BackColor = System.Drawing.Color.Snow
        Me.lblNbErreursRestantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbErreursRestantes.ForeColor = System.Drawing.Color.Brown
        Me.lblNbErreursRestantes.Location = New System.Drawing.Point(662, 127)
        Me.lblNbErreursRestantes.Name = "lblNbErreursRestantes"
        Me.lblNbErreursRestantes.Size = New System.Drawing.Size(21, 24)
        Me.lblNbErreursRestantes.TabIndex = 89
        Me.lblNbErreursRestantes.Text = "0"
        '
        'TableLayoutPanelQuadrillage
        '
        Me.TableLayoutPanelQuadrillage.BackColor = System.Drawing.Color.Transparent
        Me.TableLayoutPanelQuadrillage.ColumnCount = 9
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.Enabled = False
        Me.TableLayoutPanelQuadrillage.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanelQuadrillage.Name = "TableLayoutPanelQuadrillage"
        Me.TableLayoutPanelQuadrillage.RowCount = 9
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.11111!))
        Me.TableLayoutPanelQuadrillage.Size = New System.Drawing.Size(452, 435)
        Me.TableLayoutPanelQuadrillage.TabIndex = 103
        '
        'BtnCommencer
        '
        Me.BtnCommencer.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCommencer.Location = New System.Drawing.Point(528, 202)
        Me.BtnCommencer.Name = "BtnCommencer"
        Me.BtnCommencer.Size = New System.Drawing.Size(118, 57)
        Me.BtnCommencer.TabIndex = 104
        Me.BtnCommencer.Text = "COMMENCER"
        Me.BtnCommencer.UseVisualStyleBackColor = False
        '
        'BtnQuitter
        '
        Me.BtnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnQuitter.Location = New System.Drawing.Point(528, 375)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(118, 57)
        Me.BtnQuitter.TabIndex = 105
        Me.BtnQuitter.Text = "QUITTER"
        Me.BtnQuitter.UseVisualStyleBackColor = False
        '
        'BtnPause
        '
        Me.BtnPause.BackColor = System.Drawing.Color.Snow
        Me.BtnPause.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnPause.Location = New System.Drawing.Point(613, 19)
        Me.BtnPause.Name = "BtnPause"
        Me.BtnPause.Size = New System.Drawing.Size(85, 45)
        Me.BtnPause.TabIndex = 106
        Me.BtnPause.Text = "PAUSE"
        Me.BtnPause.UseVisualStyleBackColor = False
        '
        'lblNbFoisIndice
        '
        Me.lblNbFoisIndice.AutoSize = True
        Me.lblNbFoisIndice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblNbFoisIndice.Location = New System.Drawing.Point(594, 311)
        Me.lblNbFoisIndice.Name = "lblNbFoisIndice"
        Me.lblNbFoisIndice.Size = New System.Drawing.Size(20, 13)
        Me.lblNbFoisIndice.TabIndex = 108
        Me.lblNbFoisIndice.Text = "X3"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Panel1.Controls.Add(Me.TableLayoutPanelQuadrillage)
        Me.Panel1.Location = New System.Drawing.Point(21, 27)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(452, 435)
        Me.Panel1.TabIndex = 109
        '
        'Panel2
        '
        Me.Panel2.BackColor = System.Drawing.Color.Snow
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Location = New System.Drawing.Point(498, 73)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(200, 100)
        Me.Panel2.TabIndex = 110
        '
        'BtnCouperSon
        '
        Me.BtnCouperSon.BackColor = System.Drawing.Color.Snow
        Me.BtnCouperSon.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCouperSon.Location = New System.Drawing.Point(498, 19)
        Me.BtnCouperSon.Name = "BtnCouperSon"
        Me.BtnCouperSon.Size = New System.Drawing.Size(109, 45)
        Me.BtnCouperSon.TabIndex = 111
        Me.BtnCouperSon.Text = "Couper/Remettre Le Son"
        Me.BtnCouperSon.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.SAE_IHM.My.Resources.Resources.fond
        Me.ClientSize = New System.Drawing.Size(710, 480)
        Me.Controls.Add(Me.BtnCouperSon)
        Me.Controls.Add(Me.lblNbFoisIndice)
        Me.Controls.Add(Me.BtnPause)
        Me.Controls.Add(Me.BtnCommencer)
        Me.Controls.Add(Me.lblNbErreursRestantes)
        Me.Controls.Add(Me.BtnTerminer)
        Me.Controls.Add(Me.labelMinuteur)
        Me.Controls.Add(Me.BtnIndice)
        Me.Controls.Add(Me.LblNombreErreurs)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.BtnAbandonner)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Panel2)
        Me.Name = "Form2"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Form1"
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents BtnAbandonner As Button
    Friend WithEvents LblTimer As Label
    Friend WithEvents LblNombreErreurs As Label
    Friend WithEvents BtnIndice As Button
    Friend WithEvents Timer As Timer
    Friend WithEvents labelMinuteur As Label
    Friend WithEvents BtnTerminer As Button
    Friend WithEvents lblNbErreursRestantes As Label
    Friend WithEvents TableLayoutPanelQuadrillage As TableLayoutPanel
    Friend WithEvents BtnCommencer As Button
    Friend WithEvents BtnQuitter As Button
    Friend WithEvents BtnPause As Button
    Friend WithEvents lblNbFoisIndice As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents BtnCouperSon As Button
End Class
