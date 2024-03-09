Public Class GRADE_FORM

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles evaluate_btn.Click
        Dim math As Integer
        Dim science As Integer
        Dim english As Integer
        Dim grade As Double


        math = Val(math_txt_box.Text)
        science = Val(science_txt_box.Text)
        english = Val(english_txt_box.Text)

        grade = (math + science + english)
        grade = grade / 3

        If grade >= 90 Then
            MsgBox("A+")
        ElseIf grade >= 80 Then
            MsgBox("B+")
        ElseIf grade >= 75 Then
            MsgBox("C+")
        Else
            MsgBox("Failed")

        End If


    End Sub

    Private Sub Label2_Click(sender As Object, e As EventArgs) Handles Label2.Click

    End Sub

    Private Sub math_txt_box_TextChanged(sender As Object, e As EventArgs) Handles math_txt_box.TextChanged



    End Sub

    Private Sub science_txt_box_TextChanged(sender As Object, e As EventArgs) Handles science_txt_box.TextChanged


    End Sub

    Private Sub english_txt_box_TextChanged(sender As Object, e As EventArgs) Handles english_txt_box.TextChanged

    End Sub
End Class
