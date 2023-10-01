Imports System.Data.SqlClient
Public Class MCOMMANDE
    Dim chaine = My.Application.Info.DirectoryPath & "\ConnectAPI.Ini"
    Dim SERVEURSQL = LireChaine(chaine, "CONNECTION", "SERVEUR SQL")
    Dim UTILISATEURSQL = LireChaine(chaine, "CONNECTION", "UTILISATEUR SQL")
    Dim MOTDEPASSESQL = LireChaine(chaine, "CONNECTION", "MOT DE PASSE SQL")
    Dim DATABASEURL = LireChaine(chaine, "CONNECTION", "DATABASEURL")
    Dim StrCon As SqlConnection
    Private Sub Facturation_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        StrCon = ConnexionBD(SERVEURSQL, UTILISATEURSQL, Base64Decode(MOTDEPASSESQL), DATABASEURL)
    End Sub
    Public Sub Auto_Completor(ByVal Do_Type As String)
        txtPiece.AutoCompleteCustomSource.Clear()
        Try
            StrCon.Close()
            StrCon.Open()
            Dim Query As String = "SELECT distinct DO_PIECE FROM F_DOCLIGNE WHERE DO_TYPE=" & Do_Type
            Dim MaCommande As New SqlCommand(Query, StrCon)
            Dim Lecture As SqlDataReader = MaCommande.ExecuteReader(CommandBehavior.CloseConnection)
            While Lecture.Read()
                txtPiece.AutoCompleteCustomSource.Add(Lecture("DO_PIECE").ToString)
            End While

        Catch ex As Exception
            MessageBox.Show(ex.Message, "Information chargement Auto Completor", MessageBoxButtons.OK)
        End Try
    End Sub
    Private Sub RadTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtNcommande.TextChanged
        If Do_Type <> "" And txtPiece.Text <> "" Then
            BtnMettreJour.Enabled = True
        End If
    End Sub

    Private Sub txtPiece_TextChangedClick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPiece.TextChanged
        If txtNcommande.Text <> "" Then
            BtnMettreJour.Enabled = True
        End If
    End Sub

    Private Sub txtTypePiece_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)
        If txtNcommande.Text <> "" Then
            BtnMettreJour.Enabled = True
        End If
    End Sub
    Dim Do_Type As String
    Private Sub BtnMettreJour_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnMettreJour.Click
        Try
            StrCon.Close()
            StrCon.Open()
            If Do_Type <> "" And txtNcommande.Text <> "" And txtPiece.Text <> "" Then
                Dim QueryVerification As String = "SELECT count(*) FROM  F_DOCENTETE WHERE DO_Piece='" & txtPiece.Text & "' AND DO_Type=" & Do_Type
                Dim CmdVerif As New SqlCommand(QueryVerification, StrCon)
                Dim Valeur As Object = CmdVerif.ExecuteScalar()
                If Valeur <> 0 Then
                    Dim QueryUPDATE As String = "UPDATE F_DOCLIGNE SET DL_PIECEBC='" & txtNcommande.Text & "' WHERE DO_TYPE = " & Do_Type & " AND DO_PIECE = '" & txtPiece.Text & "'"
                    Dim Command As New SqlCommand(QueryUPDATE, StrCon)
                    Command.ExecuteNonQuery()
                    Select Case Do_Type
                        Case "3"
                            MessageBox.Show("Mise à jour effectué avec Succès !!!" & vbCrLf & "Type de Pièce :Bon de Livraison " & vbCrLf & "N° de Pièce : " & txtPiece.Text & vbCrLf & "N° de la Commande : " & txtNcommande.Text, "Information de mise à Jour du N° Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case "6"
                            MessageBox.Show("Mise à jour effectué avec Succès !!!" & vbCrLf & "Type de Pièce : Facture " & vbCrLf & "N° de Pièce : " & txtPiece.Text & vbCrLf & "N° de la Commande : " & txtNcommande.Text, "Information de mise à Jour du N° Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case "7"
                            MessageBox.Show("Mise à jour effectué avec Succès !!!" & vbCrLf & "Type de Pièce : Facture Comptabilisé " & vbCrLf & "N° de Pièce : " & txtPiece.Text & vbCrLf & "N° de la Commande : " & txtNcommande.Text, "Information de mise à Jour du N° Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Case Else
                            'MessageBox.Show("Mise à jour effectué avec Succès !!!" & vbCrLf & "Type de Pièce : " & Do_Type & vbCrLf & "N° de Pièce : " & txtPiece.Text & vbCrLf & "N° de la Commande : " & txtNcommande.Text, "Information de mise à Jour du N° Commande", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End Select
                Else
                    MessageBox.Show("Vérifier le Type de Piece ou le Type de Document:)", "Information de mise à Jour du N° Commande", MessageBoxButtons.OK)
                End If
            Else
                MessageBox.Show("Veuillez  renseigner vos champs :)", "Information de mise à Jour du N° Commande", MessageBoxButtons.OK, MessageBoxIcon.Stop)
            End If
        Catch ex As Exception
            MessageBox.Show(ex.Message, "Information de mise à Jour du N° Commande", MessageBoxButtons.OK)
        End Try
    End Sub

    Private Sub FC_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles FC.Click
        Do_Type = 7
        txtPiece.Text = ""
        txtNcommande.Text = ""
        GB.Text = "Types des Documents [Ventes]        Type Pièce=" & Do_Type
        Auto_Completor(Do_Type)
    End Sub

    Private Sub BL_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BL.Click
        Do_Type = 3
        txtPiece.Text = ""
        txtNcommande.Text = ""
        GB.Text = "Types des Documents [Ventes]        Type Pièce=" & Do_Type
        Auto_Completor(Do_Type)
    End Sub

    Private Sub F_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles F.Click
        Do_Type = 6
        txtPiece.Text = ""
        txtNcommande.Text = ""
        GB.Text = "Types des Documents [Ventes]        Type Pièce=" & Do_Type
        Auto_Completor(Do_Type)
    End Sub
End Class
