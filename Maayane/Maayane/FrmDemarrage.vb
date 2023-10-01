Public Class FrmDemarrage
    Dim chaine = My.Application.Info.DirectoryPath & "\ConnectAPI.Ini"
    Dim SERVEURSQL = LireChaine(chaine, "CONNECTION", "SERVEUR SQL")
    Dim UTILISATEURSQL = LireChaine(chaine, "CONNECTION", "UTILISATEUR SQL")
    Dim MOTDEPASSESQL = LireChaine(chaine, "CONNECTION", "MOT DE PASSE SQL")
    Private Sub Timer3_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer3.Tick
        Timer2.Enabled = True
    End Sub
    Private Sub Timer2_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer2.Tick
        If ProgressBar1.Value1 < 100 Then
            ProgressBar1.Value1 = ProgressBar1.Value1 + 1
        End If
        If ProgressBar1.Value1 > 0 And ProgressBar1.Value1 < 20 Then
            Label1.Text = "Detection des Parametres De Connexion"
        End If
        If ProgressBar1.Value1 > 20 And ProgressBar1.Value1 < 40 Then
            Label1.Text = ""
        End If
        If ProgressBar1.Value1 > 40 And ProgressBar1.Value1 < 70 Then
            Label1.Text = "Mise a Jour des Fichiers"
        End If
        If ProgressBar1.Value1 > 70 And ProgressBar1.Value1 < 90 Then
            Label1.Text = "Connexion au Serveur"
        End If
        If ProgressBar1.Value1 > 90 And ProgressBar1.Value1 <= 100 Then
            Label4.Text = "Chargement des encours ..."
        End If
        If ProgressBar1.Value1 > 95 And ProgressBar1.Value1 <= 100 Then
            Label3.Text = "Patienter Quelques Secondes SVP..."
        End If
        Label2.Text = ProgressBar1.Value1 & " %"
        If ProgressBar1.Value1 = 100 Then
            Timer2.Stop()
            With MenuPrincipal
                If System.IO.File.Exists(My.Application.Info.DirectoryPath & "\ConnectAPI.Ini") = True And SERVEURSQL <> "" And UTILISATEURSQL <> "" And MOTDEPASSESQL <> "" Then
                    .Show()
                    Me.Close()
                Else
                    .EditMenu.Enabled = False
                    .NwMenuConfig_Click(sender, e)
                    .Show()
                    Me.Close()
                End If
            End With
        End If
    End Sub
End Class
