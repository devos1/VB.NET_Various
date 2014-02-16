'-------------------------------------------------------------------------------
'Date		    : 16.02.2014                                                    '             
'Auteur		    : Oscar	                                                     	'
'Nom			: Test_01                                                       '
'Description	: Programme pour tester différents contrôles VB.NET             '
'-------------------------------------------------------------------------------'

Public Class Form1

    'Procedure pour capturer le bouton actionné et qui change le texte du label en fonction
    Private Sub changeText(sender As Object, e As EventArgs) Handles btn1.Click, btn2.Click

        If sender.Equals(btn1) Then
            lblTextChange.Text = "Clic sur le bouton 1"
        ElseIf sender.Equals(btn2) Then
            lblTextChange.Text = "Clic sur le bouton 2"
        Else
            MsgBox("ERREUR...")
        End If

    End Sub

    'Procedure pour ouvrir form2
    Private Sub btnOpen_Click(sender As Object, e As EventArgs) Handles btnOpen.Click
        Form2.Show()
    End Sub

    'Procedure pour fermer form2
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Form2.Close()
    End Sub

    'Procedure pour afficher le pop-up en fonction du bouton pressé
    Private Sub showMsgBox(sender As Object, e As EventArgs) Handles btnCritical.Click, btnExcla.Click, btnInfo.Click, btnQuestion.Click
        If sender.Equals(btnCritical) Then
            MsgBox("Clic sur le bouton " & sender.text, MsgBoxStyle.Critical, "Pop-up " & sender.text)
        ElseIf sender.Equals(btnInfo) Then
            MsgBox("Clic sur le bouton " & sender.text, MsgBoxStyle.Information, "Pop-up " & sender.text)
        ElseIf sender.Equals(btnExcla) Then
            MsgBox("Clic sur le bouton " & sender.text, MsgBoxStyle.Exclamation, "Pop-up " & sender.text)
        ElseIf sender.Equals(btnQuestion) Then
            MsgBox("Clic sur le bouton " & sender.text, MsgBoxStyle.Question, "Pop-up " & sender.text)
        Else
            MsgBox("ERREUR...")
        End If
    End Sub

    'Procedure pour apppeler le formulaire avec menus en onglets
    Private Sub btnTab_Click(sender As Object, e As EventArgs) Handles btnTab.Click
        MenuTab.Show()
    End Sub

    'Procedure pour apppeler le formulaire avec menus strip (standard)
    Private Sub btnStrip_Click(sender As Object, e As EventArgs) Handles btnStrip.Click
        MenuStrip.Show()
    End Sub

    'Procedure pour apppeler le formulaire avec menus en boutons
    Private Sub btnButton_Click(sender As Object, e As EventArgs) Handles btnButton.Click
        MenuButton.Show()
    End Sub

    'Procedure pour apppeler le formulaire dialogResult pour demander si quitter ou pas
    Private Sub PictureBox1_Click(sender As Object, e As EventArgs) Handles PictureBox1.Click
        Dialog1.ShowDialog()
        If Dialog1.DialogResult = Windows.Forms.DialogResult.OK Then
            Me.Close()
        End If
    End Sub
End Class
