Public Class textwindow



    Private Sub textwindow_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit() 'Closes all windows at once
    End Sub

    Public Sub Displaytext(ByVal text As String)
        TextBox1.Text = TextBox1.Text & vbCrLf & text 'This adds a linebreak (vbCrLf) and the new text
        TextBox1.SelectionStart = TextBox1.Text.Length
        TextBox1.ScrollToCaret() 'These two commands scroll the textbox down to the last line
    End Sub
End Class