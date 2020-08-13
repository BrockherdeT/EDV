Public Class frmMitgliedNeuanlage
    Private Sub btnQuit_Click(sender As Object, e As EventArgs) Handles btnQuit.Click

        If vbYes = MessageBox.Show("Sind Sie sicher?", "Abbrechen",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question) Then

            Me.Dispose()
        End If


    End Sub

    Private Sub frmMitgliedNeuanlage_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Dim dbsKlasse As New clsDatabase
        Dim dbsSparte As New clsDatabase


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
        End If


        If Not dbsSparte.readData("SELECT * FROM tblSparten") Then
            Stop
        Else
            ' Angezeigter Wert
            cmbSparte.DisplayMember = "pkySparte"
            ' Zurückzugebende ID
            cmbSparte.ValueMember = "pkySparte"
            ' Datenübergabe
            cmbSparte.DataSource = dbsSparte.getTable
            ' Nur gültige Werte, keien freie Eingabe zulassen
            cmbSparte.DropDownStyle = ComboBoxStyle.DropDownList
        End If
    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click

        'Feldprüfungen

        'Ist der Name mit mindestens 2 Zeichen gefüllt und enthält vorne und hinten keine Leerzeichen?
        If txtName.Text.Trim.Length < 2 Then

            MessageBox.Show("Der Name ist zu kurz", "Eingabeprüfung",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Ist das Geburtsdatum frühestens heute?
        If dtpGeburt.Value > Now() Then

            MessageBox.Show("Anmeldung ist erst ab Geburt möglich", "Eingabeprüfung",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        'Ist das Eintrittsdatum mindestens so groß wie das Geburtstdatum?

        If calEintritt.SelectionStart.ToShortDateString < dtpGeburt.Value.ToShortDateString Then

            MessageBox.Show("Eintritt erst ab Geburt möglich", "Eingabeprüfung",
            MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If

        Dim dbsMitglieder As New clsDatabase
        Dim datMitglieder As New DataTable

        If Not dbsMitglieder.readData("Select * FROM tblMitglieder WHERE false ") Then
            Stop
        Else

            'Übernahme der Struktur und anlegen einer Leerzeile
            datMitglieder = dbsMitglieder.getTable
            datMitglieder.Rows.Add()

            'Werte aus dem Formular in den DatenTable schreiben
            datMitglieder.Rows(0).Item("txtName") = txtName.Text
            datMitglieder.Rows(0).Item("datGeburt") = dtpGeburt.Value.ToShortDateString
            datMitglieder.Rows(0).Item("datEintritt") = calEintritt.SelectionStart.ToShortDateString
            datMitglieder.Rows(0).Item("fkyBeitragsklasse") = cmbKlasse.SelectedValue

            'Speichern
            dbsMitglieder.saveTable(datMitglieder)

        End If

        'Sparte speichern, wenn Beitragsklasse nicht passiv

        If cmbKlasse.SelectedValue <> 3 Then

            Dim dbsMitgliedID As New clsDatabase
            Dim dbsMGSparten As New clsDatabase
            Dim datMGSparten As New DataTable

            If Not dbsMitgliedID.readData("SELECT MAX(pkyMitglied) AS ID FROM tblMitglieder") Then
                Stop
            Else
                'Die ID steht nun in dbsMitgliedID.getTable.Rows(0).Item("ID)
                If Not dbsMGSparten.readData("SELECT * FROM tblMitgliederSparten WHERE false") Then
                    Stop
                Else
                    'Übernahme der Struktur und anlegen einer Leerzeile
                    datMGSparten = dbsMGSparten.getTable
                    datMGSparten.Rows.Add()

                    'Übernahme der Werte
                    datMGSparten.Rows(0).Item("fkyMitglied") = dbsMitgliedID.getTable.Rows(0).Item("ID")
                    datMGSparten.Rows(0).Item("fkySparte") = cmbSparte.SelectedValue

                    'Speichern
                    dbsMGSparten.saveTable(datMGSparten)

                End If
            End If

        End If

        'Schließen
        Me.Dispose()

    End Sub
End Class