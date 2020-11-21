Imports System

Module Program

    Structure person
        Dim name, surname As String
        Dim age, school_number As Integer
        Dim alive As Boolean

    End Structure
    Sub print_functions()
        Console.WriteLine("1)  the_multiplication_tabletable")
        Console.WriteLine("2)  find_days_yourlife")
        Console.WriteLine("3)  purchase_price")
        Console.WriteLine("4)  find_root")
        Console.WriteLine("5)  bubble_sort")
        Console.WriteLine("6)  find_biggest_number_in_array")
        Console.WriteLine("7)  score_of_your_exams")
        Console.WriteLine("8)  calculate_taximetre")
        Console.WriteLine("9)  child_height")
        Console.WriteLine("10) arithmetic_mean")
        Console.WriteLine("11) vowels(sesli_harf)")
        Console.WriteLine("12) sessiz_harf")
        Console.WriteLine("13) reverse_word")
        Console.WriteLine("14) the_way_taken(alýnan yol)")
        Console.WriteLine("15) mood_three")
        Console.WriteLine("16) mood_five")
        Console.WriteLine("17) plus_three_loop")
        Console.WriteLine("18) fibonacci")
    End Sub
    Sub Swap(Of t)(ByRef d1 As t, ByRef d2 As t)
        Dim d = d2
        d2 = d1
        d1 = d
    End Sub
    Public Sub print_int_array(ByVal array() As Integer)
        For Each item As Integer In array
            Console.Write(item & " ")
        Next
    End Sub
    Function big_sort()
        Dim a, b, temp1 As Integer

        Console.WriteLine("()how many number :")
        Dim count As Integer = Int(Console.ReadLine())
        count -= 1

        Dim array(count) As Integer
        For a = 0 To count
            array(a) = Int(Console.ReadLine())
        Next

        For a = 0 To count - 1
            For b = 0 To count - a - 1
                If array(b) > array(b + 1) Then
                    Swap(Of Integer)(array(b), array(b + 1))
                    'temp1 = array(b)
                    'array(b) = array(b + 1)
                    'array(b + 1) = temp1
                End If
            Next
        Next


        Return array(count)
        Console.ReadKey()
    End Function

    Sub bubble_sort()
        Dim a, b, temp1 As Integer

        Console.WriteLine("(bubble sort)how many number :")
        Dim count As Integer = Int(Console.ReadLine())
        count -= 1

        Dim array(count) As Integer
        For a = 0 To count
            array(a) = Int(Console.ReadLine())
        Next


        For a = 0 To count - 1
            For b = 0 To count - a - 1
                If array(b) > array(b + 1) Then
                    Swap(Of Integer)(array(b), array(b + 1))
                    'temp1 = array(b)
                    'array(b) = array(b + 1)
                    'array(b + 1) = temp1
                End If
            Next
        Next
        print_int_array(array)
        Console.ReadKey()
    End Sub

    Sub find_root()
        Dim a, b, c, delta, first_root, second_root As Integer

        Console.WriteLine("(roots)ax^2 + bx + c")
        Console.WriteLine("a : ")
        a = Int(Console.ReadLine())
        Console.WriteLine("b :")
        b = Int(Console.ReadLine())
        Console.WriteLine("c :")
        c = Int(Console.ReadLine())
        delta = b * b - 4 * a * c
        first_root = (-b + Math.Sqrt(delta)) / 2 * a
        second_root = (-b - Math.Sqrt(delta)) / 2 * a
        Console.WriteLine("first root  : " & first_root)
        Console.WriteLine("second root : " & second_root)

        Console.ReadKey()
    End Sub


    Sub purchase_price()
        Console.WriteLine("what is the label price :")
        Dim price As Double
        price = Int(Console.ReadLine())
        price += price * (8 / 100)
        price += price * (20 / 100)
        Console.WriteLine("Final price is :" & price)
        Console.ReadKey()
    End Sub

    Sub the_multiplication_tabletable()

        For x = 1 To 10
            For y = 1 To 10
                Console.Write("  " & (x * y))
            Next

            Console.WriteLine("..")
        Next
        Console.ReadKey()

    End Sub
    Sub find_biggest()
        Dim big_number As Integer
        big_number = big_sort()
        Console.WriteLine("Biggest number is : " & big_number)
        Console.ReadKey()
    End Sub

    Sub score()
        Dim vize, final, odev, total As Integer

        Console.WriteLine("vize not:")
        vize = Int(Console.ReadLine())
        Console.WriteLine("ödev not:")
        odev = Int(Console.ReadLine())
        Console.WriteLine("final not:")
        final = Int(Console.ReadLine())

        total = (vize * 3 / 10) + (odev * 2 / 10) + (final * 5 / 10)

        If (total >= 90 And total <= 100) Then
            Console.WriteLine("Notunuz : " & total & " A")
        End If
        If (total >= 70 And total <= 89) Then
            Console.WriteLine("Notunuz : " & total & " B")
        End If
        If (total >= 50 And total <= 69) Then
            Console.WriteLine("Notunuz : " & total & " C")
        End If
        If (total >= 30 And total <= 49) Then
            Console.WriteLine("Notunuz : " & total & " D")
        End If
        If (total >= 0 And total <= 29) Then
            Console.WriteLine("Notunuz : " & total & " E")
        End If
        Console.ReadKey()
    End Sub
    Sub calculate_taximetre()
        Dim distance, price As Double
        Console.WriteLine("taximetre km :")
        distance = Int(Console.ReadLine())
        price = 5 + (distance * 3 / 4)
        Console.WriteLine("coast is : " & price)
        Console.ReadKey()
    End Sub
    Sub find_days_yourlife()

        Dim year, month, day, this_year, this_month, this_day, years, days As Integer
        Dim total_day As Integer

        Console.WriteLine("write them all with integer")
        Console.WriteLine("how many day you lived?")
        Console.WriteLine("what is the year you are in : ")
        this_year = Int(Console.ReadLine())
        Console.WriteLine("month : ")
        this_month = Int(Console.ReadLine())
        Console.WriteLine("day  : ")
        this_day = Int(Console.ReadLine())

        Console.WriteLine("your birth year : ")
        year = Int(Console.ReadLine())
        Console.WriteLine("your birth month : ")
        month = Int(Console.ReadLine())
        Console.WriteLine("your birth day : ")
        day = Int(Console.ReadLine())

        years = this_year - year - 1
        years *= 365
        this_month *= 30

        month = 12 - month
        days = 30 - days

        total_day = years + this_month + this_day + month + days
        Console.WriteLine("Your life = " & total_day & " days")
        Console.ReadKey()
    End Sub

    Sub child_height()
        Dim gender As Char
        Dim size As Double
        Dim size_kid(13) As Double
        Dim j As Integer
        Console.WriteLine("How tall you are in future?")
        Console.WriteLine("Gender : ")
        gender = Console.ReadLine()

        If gender = "e" Or gender = "k" Then

            Console.WriteLine("7 years old your height :")
            size = Int(Console.ReadLine())
            Console.WriteLine("age    height")

            If gender = "e" Then

                For j = 7 To 20 Step 1
                    If j < 19 Then
                        size_kid(j - 7) = size
                        size += size * 3 / 100
                    Else
                        size_kid(j - 7) = size
                    End If
                Next

            End If

            If gender = "k" Then

                For j = 7 To 20 Step 1

                    If j < 15 Then

                        size_kid(j - 7) = size
                        size += size * 5 / 100
                    Else
                        size_kid(j - 7) = size
                    End If

                Next

            End If

            j = 7
            For Each x As Double In size_kid

                Console.WriteLine(j & ":  " & x)
                j += 1

            Next

            System.Console.ReadKey()

        Else
            Console.WriteLine(" wrong or missing value.")
        End If
        Console.ReadKey()
    End Sub

    Sub arithmetic_mean()
        Console.WriteLine("arithmetic mean. ")
        Console.WriteLine("how many numbers will be entered ?")
        Dim count As Integer = System.Console.ReadLine()

        Dim number_array(count) As Integer
        Dim total As Double = 0

        For i = 0 To count - 1 Step 1

            number_array(i) = System.Console.ReadLine()
        Next

        For Each item As Integer In number_array
            total += item
        Next

        total /= count
        Console.WriteLine("arithmetic mean is :" & total)
        Console.ReadKey()
    End Sub

    Sub vowels()
        Console.WriteLine("Vowels(sesli harf)")
        Console.WriteLine("Word is(string) : ")
        Dim char_array As Char() = System.Console.ReadLine()

        For Each item As Char In char_array
            If (item = "a" Or item = "e" Or item = "ý" Or item = "i" Or item = "o" Or item = "ö" Or item = "u" Or item = "ü") Then
                Console.WriteLine(item)
            End If
        Next
        Console.ReadKey()
    End Sub
    Sub sessiz_harf()
        Console.WriteLine("(sessiz harfler)")
        Console.WriteLine("Word is(string) : ")
        Dim char_array As Char() = System.Console.ReadLine()
        Dim silent_letters() As Char = {"b", "c", "ç", "d", "f", "g", "ð", "h", "j", "k", "l", "m", "n", "p", "r", "s", "þ", "t", "v", "y", "z", "x", "q"}

        For Each item As Char In char_array
            For Each x As Char In silent_letters
                If item = x Then
                    Console.WriteLine(item)
                End If
            Next
        Next
        Console.ReadKey()
    End Sub
    Sub reverse_word()
        Console.WriteLine("reverse the word.")
        Console.WriteLine("Word is : ")
        Dim your_array As Char() = System.Console.ReadLine()
        Dim count As Integer = your_array.Length()
        Dim reverse_array(count) As Char

        For i = 0 To count - 1 Step 1
            reverse_array(i) = your_array(count - i - 1)
        Next

        Console.WriteLine(reverse_array)
        Console.ReadKey()
    End Sub
    Sub the_way_taken()
        Console.WriteLine("taken way is:")
        Dim distance As Double = System.Console.ReadLine()
        For i = 0 To 9 Step 1

            Console.WriteLine(i + 1 & ".saat: " & distance)
            distance = (distance / 2) + 10

        Next
        Console.ReadKey()
    End Sub
    Sub mood_three()
        Console.WriteLine("number is :")
        Dim number As Double = System.Console.ReadLine()
        If number Mod 3 = 0 Then
            Console.WriteLine("mod 3 of number is equal to " & number Mod 3)
        Else
            Console.WriteLine("mod 3 of number is not equal to 0.Mod 3 is" & number Mod 3)
        End If
        Console.ReadKey()
    End Sub
    Sub mood_five()
        Console.WriteLine("number is :")
        Dim number As Double = System.Console.ReadLine()
        If number Mod 5 = 0 Then
            Console.WriteLine("mod 5 of number is equal to " & number Mod 5)
        Else
            Console.WriteLine("mod 5 of number is not equal to 0.Mod 5 is" & number Mod 5)
        End If
        Console.ReadKey()
    End Sub
    Sub plus_three_loop()

        For i = 0 To 1000 Step 3
            Console.WriteLine(i / 3 & ".:" & i)
        Next
        Console.ReadKey()
    End Sub
    Sub fibonacci()
        Console.WriteLine("fibonacci:")
        Dim first_num, second_num, third_num As Integer
        first_num = 0
        second_num = 1

        For i = 0 To 19
            third_num = first_num + second_num
            first_num = second_num
            second_num = third_num
            Console.WriteLine(i + 1 & ".: " & third_num)
        Next
        Console.ReadKey()
    End Sub
    Sub switch_func(ByRef select_number As Integer)
        Console.Clear()
        Select Case select_number
            Case Is = 1
                the_multiplication_tabletable()
            Case Is = 2
                find_days_yourlife()
            Case Is = 3
                purchase_price()
            Case Is = 4
                find_root()
            Case Is = 5
                bubble_sort()
            Case Is = 6
                find_biggest()
            Case Is = 7
                score()
            Case Is = 8
                calculate_taximetre()
            Case Is = 9
                child_height()
            Case Is = 10
                arithmetic_mean()
            Case Is = 11
                vowels()
            Case Is = 12
                sessiz_harf()
            Case Is = 13
                reverse_word()
            Case Is = 14
                the_way_taken()
            Case Is = 15
                mood_three()
            Case Is = 16
                mood_five()
            Case Is = 17
                plus_three_loop()
            Case Is = 18
                fibonacci()
        End Select


    End Sub
    Sub Main(args As String())

        'the_multiplication_tabletable()
        'find_days_yourlife()
        'purchase_price()
        'find_root()
        'bubble_sort()
        'find_biggest()
        'score()
        'calculate_taximetre()
        'child_height()
        'arithmetic_mean()
        'vowels()               'sesli harf
        'sessiz_harf()          'sessiz harf
        'reverse_word()
        'the_way_taken()
        'mood_three()
        'mood_five()
        'plus_three_loop()
        'fibonacci()

        Dim a As Integer
        For i = 0 To 10000 Step 1
            print_functions()
            Console.WriteLine("Whých functýon would you lýke to choose ?( 1 to 18)")
            a = Int(Console.ReadLine())
            switch_func(a)
            Console.WriteLine("ýf u lýke to contýnue ")
            Console.Clear()
        Next


        Console.ReadKey()
    End Sub
End Module
