Public Class Form1


   
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        If login.Text = "admin" And mdp.Text = "admin" Then



            Form2.ShowDialog()

        Else : MsgBox("Mot de passe incorrecte")
        End If


    End Sub
End Class
