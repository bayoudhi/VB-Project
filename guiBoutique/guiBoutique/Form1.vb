Imports System.Data.OleDb
Public Class Form1

    Dim connection As New OleDbConnection("Provider='Microsoft.Jet.OLEDB.4.0';Data Source='Stock.mdb'")

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Try
            connection.Open()

        Catch ex As Exception
            MsgBox(ex.Message)
        End Try

    End Sub


End Class
