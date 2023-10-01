Imports System.IO
Imports System.Net.NetworkInformation
Imports System.Security.Cryptography
Public Class Frm_FichierConfiguration
    Dim chaine = My.Application.Info.DirectoryPath & "\ConnectAPI.Ini"
    Dim SERVEURSQL = LireChaine(chaine, "CONNECTION", "SERVEUR SQL")
    Dim UTILISATEURSQL = LireChaine(chaine, "CONNECTION", "UTILISATEUR SQL")
    Dim MOTDEPASSESQL = LireChaine(chaine, "CONNECTION", "MOT DE PASSE SQL")
    Dim DATABASEURL = LireChaine(chaine, "CONNECTION", "DATABASEURL")
    Private Sub RadButton1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSave.Click
        Try
            If txtServeurSql.Text <> "" And txtuserSql.Text <> "" And txtPasswordSql.Text <> "" And txtBDSql.Text <> "" Then
                WriteConfigurationFill(txtServeurSql.Text, txtuserSql.Text, Base64Encode(txtPasswordSql.Text), txtBDSql.Text)
                MsgBox("Modification Terminée!", MsgBoxStyle.Information, "Modification Fichier Ini")
            End If
        Catch ex As Exception
        End Try
    End Sub

    Private Sub BtnFermer_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnFermer.Click
        Me.Close()
    End Sub

    Private Sub BtnTestConnexion_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnTestConnexion.Click
        Try
            If txtServeurSql.Text <> "" And txtuserSql.Text <> "" And txtPasswordSql.Text <> "" And txtBDSql.Text <> "" Then
                If ConnexionBD(txtServeurSql.Text, txtuserSql.Text, txtPasswordSql.Text, txtBDSql.Text).State = ConnectionState.Open Then
                    MessageBox.Show("Connexion effectué avec Succèss !!!", "Test de Connexion au Serveur", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            Else
                MessageBox.Show("Veuillez Rensigner vos Champs...", "Test de Connexion au Serveur", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show("Echéc de Connexion au Serveur Erreur Systèm : " & ex.Message, "Test de Connexion au Serveur", MessageBoxButtons.OK, MessageBoxIcon.Error)
        End Try
    End Sub

    Private Sub Frm_FichierConfiguration_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtServeurSql.Text = SERVEURSQL
        txtuserSql.Text = UTILISATEURSQL
        txtPasswordSql.Text = Base64Decode(MOTDEPASSESQL)
        txtBDSql.Text = DATABASEURL
    End Sub
End Class