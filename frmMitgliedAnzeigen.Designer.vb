<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMitgliedAnzeigen
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
        Me.lblMgNr = New System.Windows.Forms.Label()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGeburt = New System.Windows.Forms.Label()
        Me.lblEintritt = New System.Windows.Forms.Label()
        Me.lblKlasse = New System.Windows.Forms.Label()
        Me.txtID = New System.Windows.Forms.TextBox()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.dtpGeburt = New System.Windows.Forms.DateTimePicker()
        Me.calEintritt = New System.Windows.Forms.MonthCalendar()
        Me.cmbKlasse = New System.Windows.Forms.ComboBox()
        Me.BtnQuit = New System.Windows.Forms.Button()
        Me.dgvSparten = New System.Windows.Forms.DataGridView()
        CType(Me.dgvSparten, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblMgNr
        '
        Me.lblMgNr.AutoSize = True
        Me.lblMgNr.Location = New System.Drawing.Point(12, 33)
        Me.lblMgNr.Name = "lblMgNr"
        Me.lblMgNr.Size = New System.Drawing.Size(62, 29)
        Me.lblMgNr.TabIndex = 0
        Me.lblMgNr.Text = "MgNr"
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(12, 85)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 29)
        Me.lblName.TabIndex = 1
        Me.lblName.Text = "Name"
        '
        'lblGeburt
        '
        Me.lblGeburt.AutoSize = True
        Me.lblGeburt.Location = New System.Drawing.Point(12, 144)
        Me.lblGeburt.Name = "lblGeburt"
        Me.lblGeburt.Size = New System.Drawing.Size(90, 29)
        Me.lblGeburt.TabIndex = 2
        Me.lblGeburt.Text = "Geboren"
        '
        'lblEintritt
        '
        Me.lblEintritt.AutoSize = True
        Me.lblEintritt.Location = New System.Drawing.Point(12, 208)
        Me.lblEintritt.Name = "lblEintritt"
        Me.lblEintritt.Size = New System.Drawing.Size(67, 29)
        Me.lblEintritt.TabIndex = 3
        Me.lblEintritt.Text = "Eintritt"
        '
        'lblKlasse
        '
        Me.lblKlasse.AutoSize = True
        Me.lblKlasse.Location = New System.Drawing.Point(12, 484)
        Me.lblKlasse.Name = "lblKlasse"
        Me.lblKlasse.Size = New System.Drawing.Size(141, 29)
        Me.lblKlasse.TabIndex = 4
        Me.lblKlasse.Text = "Beitragsklasse"
        '
        'txtID
        '
        Me.txtID.Enabled = False
        Me.txtID.Location = New System.Drawing.Point(170, 33)
        Me.txtID.Name = "txtID"
        Me.txtID.Size = New System.Drawing.Size(126, 35)
        Me.txtID.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(170, 85)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(326, 35)
        Me.txtName.TabIndex = 6
        '
        'dtpGeburt
        '
        Me.dtpGeburt.Location = New System.Drawing.Point(170, 144)
        Me.dtpGeburt.Name = "dtpGeburt"
        Me.dtpGeburt.Size = New System.Drawing.Size(326, 35)
        Me.dtpGeburt.TabIndex = 7
        '
        'calEintritt
        '
        Me.calEintritt.Location = New System.Drawing.Point(170, 208)
        Me.calEintritt.Name = "calEintritt"
        Me.calEintritt.TabIndex = 8
        '
        'cmbKlasse
        '
        Me.cmbKlasse.FormattingEnabled = True
        Me.cmbKlasse.Location = New System.Drawing.Point(170, 484)
        Me.cmbKlasse.Name = "cmbKlasse"
        Me.cmbKlasse.Size = New System.Drawing.Size(326, 37)
        Me.cmbKlasse.TabIndex = 9
        '
        'BtnQuit
        '
        Me.BtnQuit.BackColor = System.Drawing.SystemColors.Control
        Me.BtnQuit.Location = New System.Drawing.Point(811, 534)
        Me.BtnQuit.Name = "BtnQuit"
        Me.BtnQuit.Size = New System.Drawing.Size(168, 60)
        Me.BtnQuit.TabIndex = 10
        Me.BtnQuit.Text = "Schließen"
        Me.BtnQuit.UseVisualStyleBackColor = False
        '
        'dgvSparten
        '
        Me.dgvSparten.BackgroundColor = System.Drawing.SystemColors.Control
        Me.dgvSparten.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvSparten.Location = New System.Drawing.Point(530, 33)
        Me.dgvSparten.Name = "dgvSparten"
        Me.dgvSparten.RowHeadersWidth = 62
        Me.dgvSparten.RowTemplate.Height = 28
        Me.dgvSparten.Size = New System.Drawing.Size(449, 488)
        Me.dgvSparten.TabIndex = 11
        '
        'frmMitgliedAnzeigen
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(992, 606)
        Me.Controls.Add(Me.dgvSparten)
        Me.Controls.Add(Me.BtnQuit)
        Me.Controls.Add(Me.cmbKlasse)
        Me.Controls.Add(Me.calEintritt)
        Me.Controls.Add(Me.dtpGeburt)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.txtID)
        Me.Controls.Add(Me.lblKlasse)
        Me.Controls.Add(Me.lblEintritt)
        Me.Controls.Add(Me.lblGeburt)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.lblMgNr)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMitgliedAnzeigen"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Mitglied anzeigen"
        CType(Me.dgvSparten, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblMgNr As Label
    Friend WithEvents lblName As Label
    Friend WithEvents lblGeburt As Label
    Friend WithEvents lblEintritt As Label
    Friend WithEvents lblKlasse As Label
    Friend WithEvents txtID As TextBox
    Friend WithEvents txtName As TextBox
    Friend WithEvents dtpGeburt As DateTimePicker
    Friend WithEvents calEintritt As MonthCalendar
    Friend WithEvents cmbKlasse As ComboBox
    Friend WithEvents BtnQuit As Button
    Friend WithEvents dgvSparten As DataGridView
End Class
