Option Explicit On
Imports System.Data.OleDb
Imports System.Data.SqlClient
Imports System.IO
Imports System.Text
Imports System.Security.Cryptography
Module Connect
    Public Function ConnexionBD(ByVal serveur As String, ByVal use As String, ByVal pass As String, ByVal BD As String) As SqlConnection
        Dim com As New SqlConnection("server= " & serveur & ";uid= " & use & ";password= " & pass & ";database=" & BD)
        com.Open()
        Return com
    End Function

    '------------------------Directive de lecture dans un fichier de configuration-------
    Public Declare Ansi Function GetPrivateProfileString Lib "kernel32" _
                    Alias "GetPrivateProfileStringA" (ByVal x As String, _
                    ByVal y As String, ByVal z As String, _
                    ByVal w As String, ByVal o As Integer, _
                    ByVal P As String) As Long

    '--------------declaration des methode d;acces au fichier de config 

    Public Declare Ansi Function WritePrivateProfileString Lib "kernel32" _
                       Alias "WritePrivateProfileStringA" (ByVal App_Section As String, _
                                                           ByVal App_Cle As String, _
                                                           ByVal App_Valeur As String, _
                                                           ByVal App_Path As String _
                                                          ) As Boolean

    '-----------------------------------fonction de lecture d'un champ Text
    Function LireChaine(ByVal Fichier_Ini As String, ByVal Section_Ini As String, ByVal Key_Ini As String) As String
        Dim X As Long
        Dim Ham_buffer As String
        Ham_buffer = Space(300)
        X = GetPrivateProfileString(Section_Ini, Key_Ini, "", Ham_buffer, Len(Ham_buffer), Fichier_Ini)
        LireChaine = Left(Trim(Left(Ham_buffer, 295)), Len(Trim(Left(Ham_buffer, 295))) - 1)
    End Function

    Public Sub WriteConfigurationFill(ByVal serveur As String, ByVal user As String, ByVal motpass As String, ByVal basedonne As String)
        Dim find As Boolean
        Try
            'Pour modifier ou non le chemin du fichier INI
            If Trim(serveur) <> "" Then
                find = WritePrivateProfileString("CONNECTION", "SERVEUR SQL", Trim(serveur), My.Application.Info.DirectoryPath & "\ConnectAPI.Ini")
                find = WritePrivateProfileString("CONNECTION", "UTILISATEUR SQL", Trim(user), My.Application.Info.DirectoryPath & "\ConnectAPI.Ini")
                find = WritePrivateProfileString("CONNECTION", "MOT DE PASSE SQL", Trim(motpass), My.Application.Info.DirectoryPath & "\ConnectAPI.Ini")
                find = WritePrivateProfileString("CONNECTION", "DATABASEURL", Trim(basedonne), My.Application.Info.DirectoryPath & "\ConnectAPI.Ini")
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub
    Public Function Base64Encode(ByVal Texte As String) As String
        Try
            Dim texteBytes As Byte() = Encoding.ASCII.GetBytes(Texte)
            If texteBytes.Length = 0 Then
                Return ""
            Else
                Return Convert.ToBase64String(texteBytes)
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
    Public Function Base64Decode(ByVal Texte As String) As String
        Try
            If Texte.Length = 0 Then
                Return ""
            Else
                Return Encoding.ASCII.GetString(Convert.FromBase64String(Texte))
            End If
        Catch ex As Exception
            Return ""
        End Try
    End Function
End Module
