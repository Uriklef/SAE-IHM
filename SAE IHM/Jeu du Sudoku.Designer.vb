<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
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
        Me.SuspendLayout()
        '
        'BtnAbandonner
        '
        Me.BtnAbandonner.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnAbandonner.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnAbandonner.Location = New System.Drawing.Point(691, 406)
        Me.BtnAbandonner.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnAbandonner.Name = "BtnAbandonner"
        Me.BtnAbandonner.Size = New System.Drawing.Size(157, 70)
        Me.BtnAbandonner.TabIndex = 81
        Me.BtnAbandonner.Text = "ABANDONNER"
        Me.BtnAbandonner.UseVisualStyleBackColor = False
        '
        'LblTimer
        '
        Me.LblTimer.AutoSize = True
        Me.LblTimer.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblTimer.Location = New System.Drawing.Point(652, 58)
        Me.LblTimer.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblTimer.Name = "LblTimer"
        Me.LblTimer.Size = New System.Drawing.Size(163, 25)
        Me.LblTimer.TabIndex = 82
        Me.LblTimer.Text = "Temps restant :"
        '
        'LblNombreErreurs
        '
        Me.LblNombreErreurs.AutoSize = True
        Me.LblNombreErreurs.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LblNombreErreurs.Location = New System.Drawing.Point(652, 102)
        Me.LblNombreErreurs.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.LblNombreErreurs.Name = "LblNombreErreurs"
        Me.LblNombreErreurs.Size = New System.Drawing.Size(190, 25)
        Me.LblNombreErreurs.TabIndex = 83
        Me.LblNombreErreurs.Text = "Erreurs restantes :"
        '
        'BtnIndice
        '
        Me.BtnIndice.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnIndice.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnIndice.Location = New System.Drawing.Point(691, 296)
        Me.BtnIndice.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnIndice.Name = "BtnIndice"
        Me.BtnIndice.Size = New System.Drawing.Size(157, 70)
        Me.BtnIndice.TabIndex = 85
        Me.BtnIndice.Text = "INDICE"
        Me.BtnIndice.UseVisualStyleBackColor = False
        '
        'Timer
        '
        '
        'labelMinuteur
        '
        Me.labelMinuteur.AutoSize = True
        Me.labelMinuteur.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.labelMinuteur.Location = New System.Drawing.Point(827, 53)
        Me.labelMinuteur.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.labelMinuteur.Name = "labelMinuteur"
        Me.labelMinuteur.Size = New System.Drawing.Size(62, 29)
        Me.labelMinuteur.TabIndex = 87
        Me.labelMinuteur.Text = "0:00"
        '
        'BtnTerminer
        '
        Me.BtnTerminer.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.BtnTerminer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnTerminer.Location = New System.Drawing.Point(691, 193)
        Me.BtnTerminer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnTerminer.Name = "BtnTerminer"
        Me.BtnTerminer.Size = New System.Drawing.Size(157, 70)
        Me.BtnTerminer.TabIndex = 88
        Me.BtnTerminer.Text = "VALIDER"
        Me.BtnTerminer.UseVisualStyleBackColor = False
        '
        'lblNbErreursRestantes
        '
        Me.lblNbErreursRestantes.AutoSize = True
        Me.lblNbErreursRestantes.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblNbErreursRestantes.Location = New System.Drawing.Point(864, 98)
        Me.lblNbErreursRestantes.Margin = New System.Windows.Forms.Padding(4, 0, 4, 0)
        Me.lblNbErreursRestantes.Name = "lblNbErreursRestantes"
        Me.lblNbErreursRestantes.Size = New System.Drawing.Size(27, 29)
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
        Me.TableLayoutPanelQuadrillage.Location = New System.Drawing.Point(28, 33)
        Me.TableLayoutPanelQuadrillage.Margin = New System.Windows.Forms.Padding(4)
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
        Me.TableLayoutPanelQuadrillage.Size = New System.Drawing.Size(603, 535)
        Me.TableLayoutPanelQuadrillage.TabIndex = 103
        '
        'BtnCommencer
        '
        Me.BtnCommencer.BackColor = System.Drawing.Color.PaleGreen
        Me.BtnCommencer.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnCommencer.Location = New System.Drawing.Point(691, 193)
        Me.BtnCommencer.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnCommencer.Name = "BtnCommencer"
        Me.BtnCommencer.Size = New System.Drawing.Size(157, 70)
        Me.BtnCommencer.TabIndex = 104
        Me.BtnCommencer.Text = "COMMENCER"
        Me.BtnCommencer.UseVisualStyleBackColor = False
        '
        'BtnQuitter
        '
        Me.BtnQuitter.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.BtnQuitter.FlatStyle = System.Windows.Forms.FlatStyle.Popup
        Me.BtnQuitter.Location = New System.Drawing.Point(691, 406)
        Me.BtnQuitter.Margin = New System.Windows.Forms.Padding(4)
        Me.BtnQuitter.Name = "BtnQuitter"
        Me.BtnQuitter.Size = New System.Drawing.Size(157, 70)
        Me.BtnQuitter.TabIndex = 105
        Me.BtnQuitter.Text = "QUITTER"
        Me.BtnQuitter.UseVisualStyleBackColor = False
        '
        'Form2
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(947, 583)
        Me.Controls.Add(Me.BtnQuitter)
        Me.Controls.Add(Me.BtnCommencer)
        Me.Controls.Add(Me.TableLayoutPanelQuadrillage)
        Me.Controls.Add(Me.lblNbErreursRestantes)
        Me.Controls.Add(Me.BtnTerminer)
        Me.Controls.Add(Me.labelMinuteur)
        Me.Controls.Add(Me.BtnIndice)
        Me.Controls.Add(Me.LblNombreErreurs)
        Me.Controls.Add(Me.LblTimer)
        Me.Controls.Add(Me.BtnAbandonner)
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form2"
        Me.Text = "Form1"
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
End Class
