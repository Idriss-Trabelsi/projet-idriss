Public Class Form1
    Public Class Etudiant
        Public Numero As Integer
        Public Nom As String
        Public Prenom As String
        Public Datedenaissance As Date
        Public Situationfamiliale As String
        Public Niveau As String
    End Class
    Dim listeetudiants As New List(Of Etudiant)()
    Private Sub FrmEtudiant_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub btnnouveau_Click(sender As Object, e As EventArgs) Handles btnnouveau.Click
        txtnumero.Clear()
        Txtnom.Clear()
        txtprenom.Clear()
        dtpDatenaissance.Value = Date.Now
        rdbmarie.Checked = False
        rdbdivorcé.Checked = False
        rdbcelibataire.Checked = False
        rdbveuf.Checked = False
        chklicence.Checked = False
        chkmaster.Checked = False
    End Sub

    Private Sub btnajouter_Click(sender As Object, e As EventArgs) Handles btnajouter.Click
        If txtnumero.Text = "" Or Txtnom.Text = "" Or txtprenom.Text = "" Then
            MessageBox.Show("veuillez remplir tous les champs .", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim numero As Integer = CInt(txtnumero.Text)
        For Each etudiant As Etudiant In listeetudiants
            If etudiant.Numero = numero Then
                MessageBox.Show("un etudiant avec ce numéron existe déja . ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Return
            End If
        Next
        Dim nouveletudiant As New Etudiant()
        nouveletudiant.Numero = CInt(txtnumero.Text)
        nouveletudiant.Nom = Txtnom.Text
        nouveletudiant.Prenom = txtprenom.Text
        nouveletudiant.Datedenaissance = dtpDatenaissance.Value
        If rdbmarie.Checked Then
            nouveletudiant.Situationfamiliale = "Marié"
        ElseIf rdbdivorcé.Checked Then
            nouveletudiant.Situationfamiliale = "Divorcé"
        ElseIf rdbcelibataire.Checked Then
            nouveletudiant.Situationfamiliale = "Celibataire"
        ElseIf rdbveuf.Checked Then
            nouveletudiant.Situationfamiliale = "Veuf"
        End If
        If chklicence.Checked Then
            nouveletudiant.Niveau = "Licence"
        ElseIf chkmaster.Checked Then
            nouveletudiant.Niveau = "Master"
        End If
        listeetudiants.Add(nouveletudiant)
        MessageBox.Show("Etudiant ajouté avec succés . ")
        btnnouveau.PerformClick()
    End Sub

    Private Sub btnmodifier_Click(sender As Object, e As EventArgs) Handles btnmodifier.Click
        If txtnumero.Text = "" Then
            MessageBox.Show("veuillez entrer un numero d'etudiant.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim numero As Integer = CInt(txtnumero.Text)
        Dim etudianttrouve As Etudiant = Nothing
        For Each etudiant As Etudiant In listeetudiants
            If etudiant.Numero = numero Then
                etudianttrouve = etudiant
                Exit For
            End If
        Next
        If etudianttrouve IsNot Nothing Then
            etudianttrouve.Nom = Txtnom.Text
            etudianttrouve.Prenom = txtprenom.Text
            etudianttrouve.Datedenaissance = dtpDatenaissance.Value
            If rdbmarie.Checked Then
                etudianttrouve.Situationfamiliale = "Marié"
            ElseIf rdbdivorcé.Checked Then
                etudianttrouve.Situationfamiliale = "Divorcé"
            ElseIf rdbcelibataire.Checked Then
                etudianttrouve.Situationfamiliale = "Celibataire"
            ElseIf rdbveuf.Checked Then
                etudianttrouve.Situationfamiliale = "Veuf"
            End If
            If chklicence.Checked Then
                etudianttrouve.Niveau = "Licence"
            ElseIf chkmaster.Checked Then
                etudianttrouve.Niveau = "Master"
            End If
            MessageBox.Show("Etudiant modifié avec succés ")
        Else
            MessageBox.Show("Etudiant introuvable")

        End If
    End Sub

    Private Sub btnsupprimer_Click(sender As Object, e As EventArgs) Handles btnsupprimer.Click
        If txtnumero.Text = "" Then
            MessageBox.Show("veuillez entrer un numero d'etudiant ", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)
            Return
        End If
        Dim numero As Integer = CInt(txtnumero.Text)
        Dim etudiantsupprime As Boolean = False
        For Each etudiant As Etudiant In listeetudiants
            If etudiant.Numero = numero Then
                listeetudiants.Remove(etudiant)
                etudiantsupprime = True
                Exit For
            End If
        Next
        If etudiantsupprime Then
            MessageBox.Show("Etudiant supprimé avec succés", "succés", MessageBoxButtons.OK, MessageBoxIcon.Information)
            btnnouveau.PerformClick()
        Else
            MessageBox.Show("Etudiant introuvable", "erreur", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
    End Sub

    Private Sub btnquitter_Click(sender As Object, e As EventArgs) Handles btnquitter.Click
        Me.Close()
    End Sub
End Class
