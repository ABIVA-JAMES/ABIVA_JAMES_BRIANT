Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim VariableName As String = "HELLO"
        'Dim age As Integer = 20

        'Const MaxSize As Integer = 999

        'Dim StringVar As String
        'Dim IntVar As Integer
        'Dim BooleanVar As Boolean
        'Dim DecimalVar As Decimal

        'StringVar = "this is string"
        'IntVar = 345353
        'BooleanVar = False
        'DecimalVar = 34.565656

        ''WRITE COMPONENTS USING SINGLE '

        '' ARITHMETIC OPERATORS
        'age = age + 34
        'age = age - 16
        'age = age / 34
        'age = age * 20

        ''ASSIGNMENT OPERATORS
        'Dim FIRSTNAME As String
        'FIRSTNAME = "INSERTING VALUE USING EQUAL (=) ASSIGNEMENT OPERATORS"


        ''COMPARISON OPERATORS
        '' =
        'If (1 = 1) Then
        '    MsgBox("TRUE")
        'End If

        '' <> NOT EQUAL
        'If (45 <> 78) Then
        '    MsgBox("TRUE")
        'End If

        ''GREATER THAN
        'If (100 > 85) Then
        '    MsgBox("TRUE")
        'End If

        ''LESS THAN 
        'If (56 < 65) Then
        '    MsgBox("TRUE")
        'End If

        ''GREATER EQUAL
        'If (100 >= 99) Then
        '    MsgBox("TRUE")
        'End If

        ''LESSTHAN EQUAL
        'If (100 <= 101) Then
        '    MsgBox("TRUE")
        'End If

        ''LOGICAL OPERATOR
        ''AND
        'Dim price As Integer = 25
        'If price > 20 And price > 0 Then
        '    MsgBox("TRUE")
        'End If


        ''OR
        'If price < 10 Or price > 0 Then
        '    MsgBox(price < 10 Or price > 0)
        'End If


        'If age = 10 Then
        '    'TRUE
        '    MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10")
        'Else
        '    'FALSE 
        '    MessageBox.Show("ITS FALSE, AGE IS NOT EQUAL TO 10")
        'End If


        'If age = 10 Then
        '    If age > 9 Then
        '        'TRUE
        '        MessageBox.Show("ITS TRUE AGE IS EQUAL TO 10 & greater than 9")
        '        If age > 0 Then
        '            'TRUE
        '            MessageBox.Show("ITS TRUE age is greater than 0")
        '        End If
        '    End If

        'Else
        '    If age > 11 Then
        '        'FALSE
        '        MessageBox.Show("ITS FALSE, AGE IS NOT greater than TO 11")
        '    End If
        'End If

        'Dim grade As Char
        '    grade = "B"
        'Select Case grade
        '    Case "A"
        '        MessageBox.Show("Excellent")
        '    Case "B", "C"
        '        MessageBox.Show(" welldone")
        '    Case "D"
        '        MessageBox.Show("You passed")
        '    Case "F"
        '        MessageBox.Show("Better try Again")
        '    Case Else
        '        MessageBox.Show("Invalid Grade")
        'End Select





    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles EVALUATE_BTN.Click

        Dim AGE As Integer = Convert.ToDecimal(age_txtbox.Text)

        If AGE >= 100 Then
            MsgBox("DINOSAUR AGE")
        ElseIf AGE >= 90 Then
            MsgBox("CENTURY AGE")
        ElseIf AGE >= 80 Then
            MsgBox("GRAND FATHER AGE")
        ElseIf AGE >= 60 Then
            MsgBox("SENIOR CITEZEN")
        ElseIf AGE >= 45 Then
            MsgBox("MIDDLE AGE")
        ElseIf AGE >= 30 Then
            MsgBox("YOUNG")
        Else
            MsgBox("UNKNOWN AGE")







        End If

    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs) Handles TXTBOX_LBL.Click

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles age_txtbox.TextChanged

    End Sub
End Class
