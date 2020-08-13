<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSuche
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.cmbKlasse = New System.Windows.Forms.ComboBox()
        Me.lblKlasse = New System.Windows.Forms.Label()
        Me.dgvMitglieder = New System.Windows.Forms.DataGridView()
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.lblName = New System.Windows.Forms.Label()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.grpSortierung = New System.Windows.Forms.GroupBox()
        Me.radDESC = New System.Windows.Forms.RadioButton()
        Me.radASC = New System.Windows.Forms.RadioButton()
        CType(Me.dgvMitglieder, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.grpSortierung.SuspendLayout()
        Me.SuspendLayout()
        '
        'cmbKlasse
        '
        Me.cmbKlasse.FormattingEnabled = True
        Me.cmbKlasse.Location = New System.Drawing.Point(180, 9)
        Me.cmbKlasse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbKlasse.Name = "cmbKlasse"
        Me.cmbKlasse.Size = New System.Drawing.Size(259, 37)
        Me.cmbKlasse.TabIndex = 0
        '
        'lblKlasse
        '
        Me.lblKlasse.AutoSize = True
        Me.lblKlasse.Location = New System.Drawing.Point(6, 9)
        Me.lblKlasse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKlasse.Name = "lblKlasse"
        Me.lblKlasse.Size = New System.Drawing.Size(141, 29)
        Me.lblKlasse.TabIndex = 1
        Me.lblKlasse.Text = "Beitragsklasse"
        '
        'dgvMitglieder
        '
        Me.dgvMitglieder.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvMitglieder.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvMitglieder.Location = New System.Drawing.Point(9, 117)
        Me.dgvMitglieder.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dgvMitglieder.Name = "dgvMitglieder"
        Me.dgvMitglieder.RowHeadersWidth = 62
        Me.dgvMitglieder.Size = New System.Drawing.Size(600, 212)
        Me.dgvMitglieder.TabIndex = 2
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnAdd.Location = New System.Drawing.Point(11, 378)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(200, 62)
        Me.btnAdd.TabIndex = 3
        Me.btnAdd.Text = "Neues Mitglied "
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuit.Font = New System.Drawing.Font("Arial", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnQuit.Location = New System.Drawing.Point(409, 378)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(200, 62)
        Me.btnQuit.TabIndex = 4
        Me.btnQuit.Text = "Beenden"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(6, 66)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 29)
        Me.lblName.TabIndex = 5
        Me.lblName.Text = "Name"
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(180, 60)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(259, 35)
        Me.txtName.TabIndex = 6
        '
        'grpSortierung
        '
        Me.grpSortierung.Controls.Add(Me.radDESC)
        Me.grpSortierung.Controls.Add(Me.radASC)
        Me.grpSortierung.Location = New System.Drawing.Point(443, 4)
        Me.grpSortierung.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpSortierung.Name = "grpSortierung"
        Me.grpSortierung.Padding = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.grpSortierung.Size = New System.Drawing.Size(166, 91)
        Me.grpSortierung.TabIndex = 7
        Me.grpSortierung.TabStop = False
        '
        'radDESC
        '
        Me.radDESC.AutoSize = True
        Me.radDESC.Location = New System.Drawing.Point(13, 55)
        Me.radDESC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.radDESC.Name = "radDESC"
        Me.radDESC.Size = New System.Drawing.Size(134, 33)
        Me.radDESC.TabIndex = 1
        Me.radDESC.Text = "absteigend"
        Me.radDESC.UseVisualStyleBackColor = True
        '
        'radASC
        '
        Me.radASC.AutoSize = True
        Me.radASC.Checked = True
        Me.radASC.Location = New System.Drawing.Point(13, 25)
        Me.radASC.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.radASC.Name = "radASC"
        Me.radASC.Size = New System.Drawing.Size(140, 33)
        Me.radASC.TabIndex = 0
        Me.radASC.TabStop = True
        Me.radASC.Text = "aufsteigend"
        Me.radASC.UseVisualStyleBackColor = True
        '
        'frmSuche
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(630, 468)
        Me.Controls.Add(Me.grpSortierung)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAdd)
        Me.Controls.Add(Me.dgvMitglieder)
        Me.Controls.Add(Me.lblKlasse)
        Me.Controls.Add(Me.cmbKlasse)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(3, 5, 3, 5)
        Me.Name = "frmSuche"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Mitgliedssuche"
        CType(Me.dgvMitglieder, System.ComponentModel.ISupportInitialize).EndInit()
        Me.grpSortierung.ResumeLayout(False)
        Me.grpSortierung.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents cmbKlasse As ComboBox
    Friend WithEvents lblKlasse As Label
    Friend WithEvents dgvMitglieder As DataGridView
    Friend WithEvents btnAdd As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents lblName As Label
    Friend WithEvents txtName As TextBox
    Friend WithEvents grpSortierung As GroupBox
    Friend WithEvents radDESC As RadioButton
    Friend WithEvents radASC As RadioButton
End Class
