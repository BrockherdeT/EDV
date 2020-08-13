<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmMitgliedNeuanlage
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
        Me.btnAdd = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.cmbSparte = New System.Windows.Forms.ComboBox()
        Me.cmbKlasse = New System.Windows.Forms.ComboBox()
        Me.dtpGeburt = New System.Windows.Forms.DateTimePicker()
        Me.calEintritt = New System.Windows.Forms.MonthCalendar()
        Me.txtName = New System.Windows.Forms.TextBox()
        Me.lblName = New System.Windows.Forms.Label()
        Me.lblGeburt = New System.Windows.Forms.Label()
        Me.lblEintritt = New System.Windows.Forms.Label()
        Me.lblKlasse = New System.Windows.Forms.Label()
        Me.lblSparte = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnAdd
        '
        Me.btnAdd.BackColor = System.Drawing.SystemColors.Control
        Me.btnAdd.Location = New System.Drawing.Point(193, 586)
        Me.btnAdd.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnAdd.Name = "btnAdd"
        Me.btnAdd.Size = New System.Drawing.Size(124, 60)
        Me.btnAdd.TabIndex = 0
        Me.btnAdd.Text = "Anlegen"
        Me.btnAdd.UseVisualStyleBackColor = False
        '
        'btnQuit
        '
        Me.btnQuit.BackColor = System.Drawing.SystemColors.Control
        Me.btnQuit.Location = New System.Drawing.Point(410, 586)
        Me.btnQuit.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(124, 60)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "Abbrechen"
        Me.btnQuit.UseVisualStyleBackColor = False
        '
        'cmbSparte
        '
        Me.cmbSparte.FormattingEnabled = True
        Me.cmbSparte.Location = New System.Drawing.Point(193, 521)
        Me.cmbSparte.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbSparte.Name = "cmbSparte"
        Me.cmbSparte.Size = New System.Drawing.Size(341, 37)
        Me.cmbSparte.TabIndex = 2
        '
        'cmbKlasse
        '
        Me.cmbKlasse.FormattingEnabled = True
        Me.cmbKlasse.Location = New System.Drawing.Point(193, 455)
        Me.cmbKlasse.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.cmbKlasse.Name = "cmbKlasse"
        Me.cmbKlasse.Size = New System.Drawing.Size(341, 37)
        Me.cmbKlasse.TabIndex = 3
        '
        'dtpGeburt
        '
        Me.dtpGeburt.Location = New System.Drawing.Point(193, 115)
        Me.dtpGeburt.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.dtpGeburt.Name = "dtpGeburt"
        Me.dtpGeburt.Size = New System.Drawing.Size(341, 35)
        Me.dtpGeburt.TabIndex = 4
        '
        'calEintritt
        '
        Me.calEintritt.Location = New System.Drawing.Point(193, 176)
        Me.calEintritt.Margin = New System.Windows.Forms.Padding(7, 9, 7, 9)
        Me.calEintritt.Name = "calEintritt"
        Me.calEintritt.TabIndex = 5
        '
        'txtName
        '
        Me.txtName.Location = New System.Drawing.Point(193, 56)
        Me.txtName.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtName.Name = "txtName"
        Me.txtName.Size = New System.Drawing.Size(341, 35)
        Me.txtName.TabIndex = 6
        '
        'lblName
        '
        Me.lblName.AutoSize = True
        Me.lblName.Location = New System.Drawing.Point(27, 62)
        Me.lblName.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblName.Name = "lblName"
        Me.lblName.Size = New System.Drawing.Size(65, 29)
        Me.lblName.TabIndex = 7
        Me.lblName.Text = "Name"
        '
        'lblGeburt
        '
        Me.lblGeburt.AutoSize = True
        Me.lblGeburt.Location = New System.Drawing.Point(25, 121)
        Me.lblGeburt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblGeburt.Name = "lblGeburt"
        Me.lblGeburt.Size = New System.Drawing.Size(73, 29)
        Me.lblGeburt.TabIndex = 8
        Me.lblGeburt.Text = "Geburt"
        '
        'lblEintritt
        '
        Me.lblEintritt.AutoSize = True
        Me.lblEintritt.Location = New System.Drawing.Point(25, 176)
        Me.lblEintritt.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblEintritt.Name = "lblEintritt"
        Me.lblEintritt.Size = New System.Drawing.Size(67, 29)
        Me.lblEintritt.TabIndex = 9
        Me.lblEintritt.Text = "Eintritt"
        '
        'lblKlasse
        '
        Me.lblKlasse.AutoSize = True
        Me.lblKlasse.Location = New System.Drawing.Point(25, 458)
        Me.lblKlasse.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblKlasse.Name = "lblKlasse"
        Me.lblKlasse.Size = New System.Drawing.Size(141, 29)
        Me.lblKlasse.TabIndex = 10
        Me.lblKlasse.Text = "Beitragsklasse"
        '
        'lblSparte
        '
        Me.lblSparte.AutoSize = True
        Me.lblSparte.Location = New System.Drawing.Point(27, 524)
        Me.lblSparte.Margin = New System.Windows.Forms.Padding(2, 0, 2, 0)
        Me.lblSparte.Name = "lblSparte"
        Me.lblSparte.Size = New System.Drawing.Size(71, 29)
        Me.lblSparte.TabIndex = 11
        Me.lblSparte.Text = "Sparte"
        '
        'frmMitgliedNeuanlage
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(11.0!, 29.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.AliceBlue
        Me.ClientSize = New System.Drawing.Size(606, 658)
        Me.Controls.Add(Me.lblSparte)
        Me.Controls.Add(Me.lblKlasse)
        Me.Controls.Add(Me.lblEintritt)
        Me.Controls.Add(Me.lblGeburt)
        Me.Controls.Add(Me.lblName)
        Me.Controls.Add(Me.txtName)
        Me.Controls.Add(Me.calEintritt)
        Me.Controls.Add(Me.dtpGeburt)
        Me.Controls.Add(Me.cmbKlasse)
        Me.Controls.Add(Me.cmbSparte)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnAdd)
        Me.Font = New System.Drawing.Font("Arial Narrow", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "frmMitgliedNeuanlage"
        Me.Text = "Neuanlage"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnAdd As Button
    Friend WithEvents btnQuit As Button
    Friend WithEvents cmbSparte As ComboBox
    Friend WithEvents cmbKlasse As ComboBox
    Friend WithEvents dtpGeburt As DateTimePicker
    Friend WithEvents calEintritt As MonthCalendar
    Friend WithEvents txtName As TextBox
    Friend WithEvents lblName As Label
    Friend WithEvents lblGeburt As Label
    Friend WithEvents lblEintritt As Label
    Friend WithEvents lblKlasse As Label
    Friend WithEvents lblSparte As Label
End Class
