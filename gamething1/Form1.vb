Public Class Form1

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click, Button2.Click 'When either button is clicked...

        'This displays all of the main game windows and moves them to a specific position to avoid overlap

        petphone.Show()
        petphone.Location = New Point(10, 10)
        textwindow.Show()
        textwindow.Location = New Point(10, 555)
        graphs.Show()
        graphs.Location = New Point(355, 10)
        Me.Close() 'Closes this launcher-esque window


    End Sub


End Class
