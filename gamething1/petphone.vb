Public Class petphone

    'Todo:
    'Set-up all number buttons to use the addtonumber sub-routine
    'Set-up the clear button to reset the value of phonenum to 0
    'Big task: set up the enter button to run a sub to check the number against a list (to be added) that will decide what to do/output in return


    Public phonenum As Integer

    Public Sub Addtonumber(ByVal num As Integer)

        'This sub will be used every time you press a number button. It simulates typing in a phone number by multiplying the
        'current phone number by 10 and adding the new number.

        'Limitations: Phone numbers cannot begin with 0 (0*10=0)

        phonenum *= 10
        phonenum += num
    End Sub



    Private Sub petphone_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        Application.Exit() 'Closes all windows at once
    End Sub
End Class