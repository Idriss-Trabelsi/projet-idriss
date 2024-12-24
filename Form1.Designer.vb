<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
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

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        txtnumero = New TextBox()
        Lblnumero = New Label()
        lblnom = New Label()
        Txtnom = New TextBox()
        Lblprenom = New Label()
        txtprenom = New TextBox()
        Lbldate = New Label()
        dtpDatenaissance = New DateTimePicker()
        grbsituationfamiliale = New GroupBox()
        rdbveuf = New RadioButton()
        rdbcelibataire = New RadioButton()
        rdbdivorcé = New RadioButton()
        rdbmarie = New RadioButton()
        Panel1 = New Panel()
        chkmaster = New CheckBox()
        chklicence = New CheckBox()
        btnnouveau = New Button()
        btnajouter = New Button()
        btnmodifier = New Button()
        btnsupprimer = New Button()
        btnquitter = New Button()
        grbsituationfamiliale.SuspendLayout()
        Panel1.SuspendLayout()
        SuspendLayout()
        ' 
        ' txtnumero
        ' 
        txtnumero.BackColor = Color.Maroon
        txtnumero.BorderStyle = BorderStyle.FixedSingle
        txtnumero.ForeColor = Color.White
        txtnumero.Location = New Point(143, 37)
        txtnumero.Multiline = True
        txtnumero.Name = "txtnumero"
        txtnumero.Size = New Size(200, 23)
        txtnumero.TabIndex = 0
        ' 
        ' Lblnumero
        ' 
        Lblnumero.AutoSize = True
        Lblnumero.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Lblnumero.ForeColor = Color.Maroon
        Lblnumero.Location = New Point(39, 37)
        Lblnumero.Name = "Lblnumero"
        Lblnumero.Size = New Size(86, 20)
        Lblnumero.TabIndex = 1
        Lblnumero.Text = "Numero : "
        ' 
        ' lblnom
        ' 
        lblnom.AutoSize = True
        lblnom.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        lblnom.ForeColor = Color.Maroon
        lblnom.Location = New Point(65, 100)
        lblnom.Name = "lblnom"
        lblnom.Size = New Size(60, 20)
        lblnom.TabIndex = 3
        lblnom.Text = "Nom : "
        ' 
        ' Txtnom
        ' 
        Txtnom.BackColor = Color.Maroon
        Txtnom.BorderStyle = BorderStyle.FixedSingle
        Txtnom.ForeColor = Color.White
        Txtnom.Location = New Point(143, 100)
        Txtnom.Multiline = True
        Txtnom.Name = "Txtnom"
        Txtnom.Size = New Size(200, 23)
        Txtnom.TabIndex = 2
        ' 
        ' Lblprenom
        ' 
        Lblprenom.AutoSize = True
        Lblprenom.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Lblprenom.ForeColor = Color.Maroon
        Lblprenom.Location = New Point(40, 162)
        Lblprenom.Name = "Lblprenom"
        Lblprenom.Size = New Size(85, 20)
        Lblprenom.TabIndex = 5
        Lblprenom.Text = "Prenom : "
        ' 
        ' txtprenom
        ' 
        txtprenom.BackColor = Color.Maroon
        txtprenom.BorderStyle = BorderStyle.FixedSingle
        txtprenom.ForeColor = Color.White
        txtprenom.Location = New Point(143, 162)
        txtprenom.Multiline = True
        txtprenom.Name = "txtprenom"
        txtprenom.Size = New Size(200, 23)
        txtprenom.TabIndex = 4
        ' 
        ' Lbldate
        ' 
        Lbldate.AutoSize = True
        Lbldate.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold Or FontStyle.Italic Or FontStyle.Underline, GraphicsUnit.Point, CByte(0))
        Lbldate.ForeColor = Color.Maroon
        Lbldate.Location = New Point(56, 221)
        Lbldate.Name = "Lbldate"
        Lbldate.Size = New Size(68, 20)
        Lbldate.TabIndex = 6
        Lbldate.Text = "Date  : "
        ' 
        ' dtpDatenaissance
        ' 
        dtpDatenaissance.CalendarForeColor = Color.White
        dtpDatenaissance.CalendarTitleBackColor = Color.Maroon
        dtpDatenaissance.Format = DateTimePickerFormat.Short
        dtpDatenaissance.Location = New Point(143, 218)
        dtpDatenaissance.Name = "dtpDatenaissance"
        dtpDatenaissance.Size = New Size(200, 23)
        dtpDatenaissance.TabIndex = 7
        ' 
        ' grbsituationfamiliale
        ' 
        grbsituationfamiliale.Controls.Add(rdbveuf)
        grbsituationfamiliale.Controls.Add(rdbcelibataire)
        grbsituationfamiliale.Controls.Add(rdbdivorcé)
        grbsituationfamiliale.Controls.Add(rdbmarie)
        grbsituationfamiliale.Location = New Point(40, 273)
        grbsituationfamiliale.Name = "grbsituationfamiliale"
        grbsituationfamiliale.Size = New Size(434, 62)
        grbsituationfamiliale.TabIndex = 8
        grbsituationfamiliale.TabStop = False
        grbsituationfamiliale.Text = "Situation familiale"
        ' 
        ' rdbveuf
        ' 
        rdbveuf.AutoSize = True
        rdbveuf.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdbveuf.ForeColor = Color.Maroon
        rdbveuf.Location = New Point(370, 22)
        rdbveuf.Name = "rdbveuf"
        rdbveuf.Size = New Size(53, 19)
        rdbveuf.TabIndex = 3
        rdbveuf.TabStop = True
        rdbveuf.Text = "Veuf"
        rdbveuf.UseVisualStyleBackColor = True
        ' 
        ' rdbcelibataire
        ' 
        rdbcelibataire.AutoSize = True
        rdbcelibataire.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdbcelibataire.ForeColor = Color.Maroon
        rdbcelibataire.Location = New Point(252, 22)
        rdbcelibataire.Name = "rdbcelibataire"
        rdbcelibataire.Size = New Size(95, 19)
        rdbcelibataire.TabIndex = 2
        rdbcelibataire.TabStop = True
        rdbcelibataire.Text = "Celibataire"
        rdbcelibataire.UseVisualStyleBackColor = True
        ' 
        ' rdbdivorcé
        ' 
        rdbdivorcé.AutoSize = True
        rdbdivorcé.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdbdivorcé.ForeColor = Color.Maroon
        rdbdivorcé.Location = New Point(134, 22)
        rdbdivorcé.Name = "rdbdivorcé"
        rdbdivorcé.Size = New Size(73, 19)
        rdbdivorcé.TabIndex = 1
        rdbdivorcé.TabStop = True
        rdbdivorcé.Text = "Divorcé"
        rdbdivorcé.UseVisualStyleBackColor = True
        ' 
        ' rdbmarie
        ' 
        rdbmarie.AutoSize = True
        rdbmarie.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        rdbmarie.ForeColor = Color.Maroon
        rdbmarie.Location = New Point(16, 22)
        rdbmarie.Name = "rdbmarie"
        rdbmarie.Size = New Size(62, 19)
        rdbmarie.TabIndex = 0
        rdbmarie.TabStop = True
        rdbmarie.Text = "Mariè"
        rdbmarie.UseVisualStyleBackColor = True
        ' 
        ' Panel1
        ' 
        Panel1.Controls.Add(chkmaster)
        Panel1.Controls.Add(chklicence)
        Panel1.Location = New Point(40, 356)
        Panel1.Name = "Panel1"
        Panel1.Size = New Size(423, 42)
        Panel1.TabIndex = 9
        ' 
        ' chkmaster
        ' 
        chkmaster.AutoSize = True
        chkmaster.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chkmaster.ForeColor = Color.Maroon
        chkmaster.Location = New Point(191, 13)
        chkmaster.Name = "chkmaster"
        chkmaster.Size = New Size(70, 19)
        chkmaster.TabIndex = 1
        chkmaster.Text = "Master"
        chkmaster.UseVisualStyleBackColor = True
        ' 
        ' chklicence
        ' 
        chklicence.AutoSize = True
        chklicence.Font = New Font("Microsoft Sans Serif", 9F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        chklicence.ForeColor = Color.Maroon
        chklicence.Location = New Point(16, 13)
        chklicence.Name = "chklicence"
        chklicence.Size = New Size(76, 19)
        chklicence.TabIndex = 0
        chklicence.Text = "Licence"
        chklicence.UseVisualStyleBackColor = True
        ' 
        ' btnnouveau
        ' 
        btnnouveau.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnnouveau.ForeColor = Color.Maroon
        btnnouveau.Location = New Point(12, 450)
        btnnouveau.Name = "btnnouveau"
        btnnouveau.Size = New Size(121, 31)
        btnnouveau.TabIndex = 10
        btnnouveau.Text = "Nouveau"
        btnnouveau.UseVisualStyleBackColor = True
        ' 
        ' btnajouter
        ' 
        btnajouter.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnajouter.ForeColor = Color.Maroon
        btnajouter.Location = New Point(139, 450)
        btnajouter.Name = "btnajouter"
        btnajouter.Size = New Size(121, 31)
        btnajouter.TabIndex = 11
        btnajouter.Text = "Ajouter"
        btnajouter.UseVisualStyleBackColor = True
        ' 
        ' btnmodifier
        ' 
        btnmodifier.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnmodifier.ForeColor = Color.Maroon
        btnmodifier.Location = New Point(266, 450)
        btnmodifier.Name = "btnmodifier"
        btnmodifier.Size = New Size(121, 31)
        btnmodifier.TabIndex = 12
        btnmodifier.Text = "Modifier"
        btnmodifier.UseVisualStyleBackColor = True
        ' 
        ' btnsupprimer
        ' 
        btnsupprimer.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnsupprimer.ForeColor = Color.Maroon
        btnsupprimer.Location = New Point(393, 450)
        btnsupprimer.Name = "btnsupprimer"
        btnsupprimer.Size = New Size(121, 31)
        btnsupprimer.TabIndex = 13
        btnsupprimer.Text = "Supprimer"
        btnsupprimer.UseVisualStyleBackColor = True
        ' 
        ' btnquitter
        ' 
        btnquitter.Font = New Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        btnquitter.ForeColor = Color.Maroon
        btnquitter.Location = New Point(520, 450)
        btnquitter.Name = "btnquitter"
        btnquitter.Size = New Size(121, 31)
        btnquitter.TabIndex = 14
        btnquitter.Text = "Quitter"
        btnquitter.UseVisualStyleBackColor = True
        ' 
        ' Form1
        ' 
        AutoScaleDimensions = New SizeF(7F, 15F)
        AutoScaleMode = AutoScaleMode.Font
        BackColor = Color.FromArgb(CByte(255), CByte(255), CByte(192))
        ClientSize = New Size(800, 506)
        Controls.Add(btnquitter)
        Controls.Add(btnsupprimer)
        Controls.Add(btnmodifier)
        Controls.Add(btnajouter)
        Controls.Add(btnnouveau)
        Controls.Add(Panel1)
        Controls.Add(grbsituationfamiliale)
        Controls.Add(dtpDatenaissance)
        Controls.Add(Lbldate)
        Controls.Add(Lblprenom)
        Controls.Add(txtprenom)
        Controls.Add(lblnom)
        Controls.Add(Txtnom)
        Controls.Add(Lblnumero)
        Controls.Add(txtnumero)
        Name = "Form1"
        Text = "SaisiedesEtudiant"
        grbsituationfamiliale.ResumeLayout(False)
        grbsituationfamiliale.PerformLayout()
        Panel1.ResumeLayout(False)
        Panel1.PerformLayout()
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents txtnumero As TextBox
    Friend WithEvents Lblnumero As Label
    Friend WithEvents lblnom As Label
    Friend WithEvents Txtnom As TextBox
    Friend WithEvents Lblprenom As Label
    Friend WithEvents txtprenom As TextBox
    Friend WithEvents Lbldate As Label
    Friend WithEvents dtpDatenaissance As DateTimePicker
    Friend WithEvents grbsituationfamiliale As GroupBox
    Friend WithEvents rdbdivorcé As RadioButton
    Friend WithEvents rdbmarie As RadioButton
    Friend WithEvents rdbveuf As RadioButton
    Friend WithEvents rdbcelibataire As RadioButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents chklicence As CheckBox
    Friend WithEvents chkmaster As CheckBox
    Friend WithEvents btnnouveau As Button
    Friend WithEvents btnajouter As Button
    Friend WithEvents btnmodifier As Button
    Friend WithEvents btnsupprimer As Button
    Friend WithEvents btnquitter As Button

End Class
