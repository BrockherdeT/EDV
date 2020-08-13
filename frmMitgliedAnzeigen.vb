Public Class frmMitgliedAnzeigen

    Private dbsgMitglied As New clsDatabase
    Private datgMitglied As New DataTable
    Private dbsgSparten As New clsDatabase
    Private datgSparten As New DataTable

    Private Sub BtnQuit_Click(sender As Object, e As EventArgs) Handles BtnQuit.Click
        Me.Dispose()
    End Sub

    Private Sub frmMitgliedAnzeigen_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'Beitragsklasse laden
        Dim dbsKlasse As New clsDatabase

        If Not dbsKlasse.readData("SELECT * FROM tblBeitragsklassen") Then
            Stop
        Else
            ' Angezeigter Wert
            cmbKlasse.DisplayMember = "txtBezeichnung"
            ' Zurückzugebende ID
            cmbKlasse.ValueMember = "pkyBeitragsklasse"
            ' Datenübergabe
            cmbKlasse.DataSource = dbsKlasse.getTable
            ' Nur gültige Werte, keien freie Eingabe zulassen
            cmbKlasse.DropDownStyle = ComboBoxStyle.DropDownList
            'Laden der Beitragsklasse des aktuellen Mitglieds
            cmbKlasse.SelectedValue = datgMitglied.Rows(0).Item("fkyBeitragsklasse")
        End If
    End Sub

    Private Sub txtID_TextChanged(sender As Object, e As EventArgs) Handles txtID.TextChanged

        If Not dbsgMitglied.readData("SELECT * FROM qryMitglieder WHERE pkyMitglied=" & txtID.Text) Then
            Stop
        Else
            ' Datenübergabe
            datgMitglied = dbsgMitglied.getTable

            'Felder füllen
            txtName.Text = datgMitglied.Rows(0).Item("txtname")
            dtpGeburt.Text = datgMitglied.Rows(0).Item("datGeburt")
            calEintritt.SetDate(datgMitglied.Rows(0).Item("datEintritt"))

            'Sparten zum Mitglied
            If Not dbsgSparten.readData("SELECT * FROM qryMitgliederSparten WHERE fkyMitglied=" & txtID.Text) Then
                Stop
            Else
                'Datenübergabe: Merken im Table und Anzeigen im DGV
                datgSparten = dbsgSparten.getTable
                dgvSparten.DataSource = datgSparten

                'Aufhübschen
                dgvSparten.AllowUserToAddRows = False
                dgvSparten.ReadOnly = True
                dgvSparten.RowHeadersVisible = False

                dgvSparten.Columns("fkyMitglied").Visible = False
                dgvSparten.Columns("fkySparte").HeaderText = "Sparte"
                dgvSparten.Columns("datSparteneintritt").HeaderText = "Eintritt"
                dgvSparten.Columns("txtTelefon").HeaderText = "Telefon"
                dgvSparten.Columns("dblBudget").HeaderText = "Budget"
                dgvSparten.Columns("dblBudget").DefaultCellStyle.Format = "c"
                dgvSparten.Columns("AnzahlvonfkyMitglied").HeaderText = "Mitgliederanzahl"


                'Spaltenbreite
                dgvSparten.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells
                dgvSparten.AutoResizeColumns()

                'Rechtsbündig ausrichten
                dgvSparten.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight

            End If

        End If
    End Sub
End Class