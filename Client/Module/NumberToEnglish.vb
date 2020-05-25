Module NumberToEnglish
    Public Function NumToWords(ByVal MyNumber As String)

        'Written by Philip Treacy
        'https://www.myonlinetraininghub.com/convert-numbers-currency-to-words-with-excel-vba
        'Feb 2014
        'Based on code from Microsoft http://support.microsoft.com/kb/213360
        'This code is not guaranteed to be error free.  No warranty is implied or expressed. Use at your own risk and carry out your own testing

        Dim Units As String
        Dim SubUnits As String
        Dim TempStr As String
        Dim DecimalPlace As Integer
        Dim Count As Integer
        Dim DecimalSeparator As String
        Dim UnitName As String
        Dim SubUnitName As String
        Dim SubUnitSingularName As String

        ' Change these as required **************************
        UnitName = "Peso" ' NOTE : This is singular
        SubUnitName = "Cents"  ' NOTE : This is plural
        SubUnitSingularName = "Cent"  ' NOTE : This is singular
        DecimalSeparator = "."
        ' ***************************************************


        Dim Place(9) As String
        Place(2) = " Thousand "
        Place(3) = " Million "
        Place(4) = " Billion "
        Place(5) = " Trillion "

        ' Convert MyNumber to STRING and TRIM white space
        MyNumber = Trim(CStr(MyNumber))

        'If MyNumber is blank then exit
        If MyNumber = "" Then

            NumToWords = ""

            Exit Function

        End If

        ' Find Position of decimal place, 0 if none.
        DecimalPlace = InStr(MyNumber, DecimalSeparator)


        ' Convert SubUnits and set MyNumber to Units amount.
        If DecimalPlace > 0 Then

            SubUnits = GetTens(Left(Mid(MyNumber, DecimalPlace + 1) & "00", 2))
            MyNumber = Trim(Left(MyNumber, DecimalPlace - 1))

        End If


        Count = 1
        Do While MyNumber <> ""

            TempStr = GetHundreds(Right(MyNumber, 3))

            If TempStr <> "" Then Units = TempStr & Place(Count) & Units

            If Len(MyNumber) > 3 Then

                MyNumber = Left(MyNumber, Len(MyNumber) - 3)

            Else

                MyNumber = ""

            End If

            Count = Count + 1

        Loop

        Select Case Units

            Case ""
                Units = "No " & UnitName & "s"

            Case "One"
                Units = "One " & UnitName

            Case Else
                Units = Units & " " & UnitName & "s"

        End Select

        Select Case SubUnits

            Case ""
                SubUnits = " Only"

            Case "One"
                SubUnits = " and One " & SubUnitSingularName & " Only"

            Case Else
                SubUnits = " and " & SubUnits & " " & SubUnitName & " Only"

        End Select


        NumToWords = Trim(Units & SubUnits)

    End Function


    ' Converts a number from 100-999 into text
    Public Function GetHundreds(ByVal MyNumber)

        Dim Result As String

        If Val(MyNumber) = 0 Then Exit Function

        MyNumber = Right("000" & MyNumber, 3)

        ' Convert the hundreds place.
        If Mid(MyNumber, 1, 1) <> "0" Then

            Result = GetDigit(Mid(MyNumber, 1, 1)) & " Hundred "

        End If


        ' Convert the tens and ones place.
        If Mid(MyNumber, 2, 1) <> "0" Then

            Result = Result & GetTens(Mid(MyNumber, 2))

        Else

            Result = Result & GetDigit(Mid(MyNumber, 3))

        End If

        GetHundreds = Result

    End Function

    ' Converts a number from 10 to 99 into text.
    Public Function GetTens(TensText)

        Dim Result As String

        Result = ""           ' Null out the temporary function value.

        If Val(Left(TensText, 1)) = 1 Then   ' If value between 10-19...

            Select Case Val(TensText)

                Case 10 : Result = "Ten"
                Case 11 : Result = "Eleven"
                Case 12 : Result = "Twelve"
                Case 13 : Result = "Thirteen"
                Case 14 : Result = "Fourteen"
                Case 15 : Result = "Fifteen"
                Case 16 : Result = "Sixteen"
                Case 17 : Result = "Seventeen"
                Case 18 : Result = "Eighteen"
                Case 19 : Result = "Nineteen"
                Case Else

            End Select

        Else                                 ' If value between 20-99...

            Select Case Val(Left(TensText, 1))

                Case 2 : Result = "Twenty "
                Case 3 : Result = "Thirty "
                Case 4 : Result = "Forty "
                Case 5 : Result = "Fifty "
                Case 6 : Result = "Sixty "
                Case 7 : Result = "Seventy "
                Case 8 : Result = "Eighty "
                Case 9 : Result = "Ninety "
                Case Else

            End Select

            Result = Result & GetDigit(Right(TensText, 1))   ' Retrieve ones place.

        End If

        GetTens = Result

    End Function

    ' Converts a number from 1 to 9 into text.
    Public Function GetDigit(Digit)

        Select Case Val(Digit)

            Case 1 : GetDigit = "One"
            Case 2 : GetDigit = "Two"
            Case 3 : GetDigit = "Three"
            Case 4 : GetDigit = "Four"
            Case 5 : GetDigit = "Five"
            Case 6 : GetDigit = "Six"
            Case 7 : GetDigit = "Seven"
            Case 8 : GetDigit = "Eight"
            Case 9 : GetDigit = "Nine"
            Case Else : GetDigit = ""

        End Select

    End Function
End Module
