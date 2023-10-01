Imports System.Windows.Forms

Public Class MenuPrincipal
    Dim chaine = My.Application.Info.DirectoryPath & "\ConnectAPI.Ini"
    Dim SERVEURSQL = LireChaine(chaine, "CONNECTION", "SERVEUR SQL")
    Dim UTILISATEURSQL = LireChaine(chaine, "CONNECTION", "UTILISATEUR SQL")
    Dim MOTDEPASSESQL = LireChaine(chaine, "CONNECTION", "MOT DE PASSE SQL")
    Dim DATABASEURL = LireChaine(chaine, "CONNECTION", "DATABASEURL")
    Private Sub ExitToolsStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles ExitToolStripMenuItem.Click
        Global.System.Windows.Forms.Application.Exit()
    End Sub

    Private Sub CutToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles CutToolStripMenuItem.Click
        With MCOMMANDE
            .MdiParent = Me
            .Show()
        End With
    End Sub
    Private Sub StatusBarToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs) Handles StatusBarToolStripMenuItem.Click
        Me.StatusStrip.Visible = Me.StatusBarToolStripMenuItem.Checked
    End Sub

    Private Sub CascadeToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.Cascade)
    End Sub

    Private Sub TileVerticleToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileVertical)
    End Sub

    Private Sub TileHorizontalToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.TileHorizontal)
    End Sub

    Private Sub ArrangeIconsToolStripMenuItem_Click(ByVal sender As Object, ByVal e As EventArgs)
        Me.LayoutMdi(MdiLayout.ArrangeIcons)
    End Sub

    Public Sub NwMenuConfig_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles NwMenuConfig.Click
        With Frm_FichierConfiguration
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub AboutToolStripMenuItem_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles AboutToolStripMenuItem.Click
        With About
            .MdiParent = Me
            .Show()
        End With
    End Sub

    Private Sub MenuPrincipal_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Load
        If chaine = "" And SERVEURSQL = "" And UTILISATEURSQL = "" Then
            With Frm_FichierConfiguration
                .MdiParent = Me
                .Show()
            End With
        End If
    End Sub
End Class
