Imports System.Text.RegularExpressions

Public Class Form1

    Public Property Genderr As String
    'removing aouto focus from the first text box
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ActiveControl = lblStdRegNumber
    End Sub
    'setting backcolor at run time when receving focus on the text boxes
    Private Sub txtStdREGnumber_GotFocus(sender As Object, e As EventArgs) Handles txtStdREGnumber.GotFocus,
        txtYearofStudy.GotFocus, txtEmail.GotFocus, txtFullNames.GotFocus, txtMobileContact.GotFocus
        Dim ctrl As Control = sender
        ctrl.BackColor = Color.Aqua
    End Sub

    'setting backcolor at run time when focus is removed on the text boxes
    Private Sub txtStdREGnumber_LostFocus(sender As Object, e As EventArgs) Handles txtStdREGnumber.LostFocus,
        txtYearofStudy.LostFocus, txtFullNames.LostFocus, txtEmail.LostFocus, txtMobileContact.LostFocus
        Dim ctrl As Control = sender
        ctrl.BackColor = Color.White

    End Sub

    'restricting the name text box to take characters only
    Private Sub txtFullNames_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtFullNames.KeyPress
        If Not Char.IsNumber(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub
    'outputing the content of the name text box

    Sub Main(ByVal args As String())

            Dim email As String = "support@tutlane.com"

            Dim result = Regex.IsMatch(email, "^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$")

            Console.Write("Is valid: {0} ", result)

            Console.ReadLine()

        End Sub

    Private Sub btnSubmit_Click(sender As Object, e As EventArgs) Handles btnSubmit.Click

        If rbtFemale.Checked = True Then
            Genderr = " Female "
        Else
            Genderr = " Male "
        End If
        'Dim i As Integer = 0

        For i = 0 To chkHobbies.CheckedItems.Count - 1

        Next


        MsgBox(("**********************************" + vbNewLine +
            "Data captured Successfully" + vbNewLine + "**********************************" + vbNewLine +
            "Student Number: " + txtStdREGnumber.Text + vbNewLine + "Full Name: " + txtFullNames.Text.ToUpper + vbNewLine +
            "Gender: " + Genderr & vbNewLine & "Year: " & txtYearofStudy.Text & vbNewLine & "Contact: " _
            & _txtMobileContact.Text & vbNewLine & "Email: " & txtEmail.Text & vbNewLine & "Hobbies: " _
            & chkHobbies.CheckedItems(0) & ", " & chkHobbies.CheckedItems(1)
))
    End Sub


    Private Sub txtYearofStudy_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txtYearofStudy.KeyPress
        If IsNumeric(e.KeyChar) = False Then
            e.Handled = True
        End If
    End Sub

    Private Sub txtStdREGnumber_MaskInputRejected(sender As Object, e As MaskInputRejectedEventArgs) Handles _
        txtStdREGnumber.MaskInputRejected

    End Sub

    Private Sub CheckedListBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles chkHobbies.SelectedIndexChanged

    End Sub

    Private Sub grbStudentDetails_Enter(sender As Object, e As EventArgs) Handles grbStudentDetails.Enter

    End Sub

End Class
