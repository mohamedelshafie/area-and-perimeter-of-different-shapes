Module Module1

    Sub Main()
        Console.WriteLine("perimeter of rectangle please click 1")
        Console.WriteLine("area of rectangle please click 2")
        Console.WriteLine("primeter of square please click 3")
        Console.WriteLine("area of square please click 4")
        Console.WriteLine("perimeter of triangle please click 5")
        Console.WriteLine("area of triangle please click 6")
        Console.WriteLine("cicumference of cicle please click 7")
        Console.WriteLine("area of cicle please click 8")

        Dim m As String
        m = Console.ReadLine
        Select Case m
            Case m = "1"
                Console.WriteLine("please enter lenth and width")
                Dim v, v1, v2 As Double
                v = Console.ReadLine
                v1 = Console.ReadLine
                v2 = (Val(v) + Val(v1)) * 2
                Console.WriteLine("the result:" & v2)
                Console.ReadKey()
            Case m = "2"
                Console.WriteLine("please enter lenth and width")
                Dim vv, v11, v22 As Double
                vv = Console.ReadLine
                v11 = Console.ReadLine
                v22 = (Val(vv) * Val(v11))
                Console.WriteLine("the result:" & v22)
                Console.ReadKey()
            Case m = "3"
                Console.WriteLine("please enter lenth")
                Dim w, w2 As Double
                w = Console.ReadLine
                w2 = (Val(w) * 4)
                Console.WriteLine("the result:" & w2)
                Console.ReadKey()
            Case m = "4"
                Console.WriteLine("please enter lenth")
                Dim ww, w22 As Double
                ww = Console.ReadLine
                w22 = (Val(ww) * Val(ww))
                Console.WriteLine("the result:" & w22)
                Console.ReadKey()
            Case m = "5"
                Console.WriteLine("please enter 3 sides of triangle")
                Dim e, e1, e2, e3 As Double
                e = Console.ReadLine
                e1 = Console.ReadLine
                e3 = Console.ReadLine
                e2 = Val(e) + Val(e1) + Val(e3)
                Console.WriteLine("the result:" & e2)
                Console.ReadKey()
            Case m = "6"
                Console.WriteLine("please enter base and height of triangle")
                Dim e, e1, e2 As Double
                e = Console.ReadLine
                e1 = Console.ReadLine
                e2 = 0.5 * (Val(e) * Val(e1))
                Console.WriteLine("the result:" & e2)
                Console.ReadKey()
            Case m = "7"
                Console.WriteLine("please enter radius of circle")
                Dim w, w2 As Double
                w = Console.ReadLine
                w2 = Val(w) * 2 * (22 / 7)
                Console.WriteLine("the result:" & w2)
                Console.ReadKey()
            Case m = "8"
                Console.WriteLine("please enter radius of circle")
                Dim w, w2 As Double
                w = Console.ReadLine
                w2 = (Val(w)) ^ 2 * (22 / 7)
                Console.WriteLine("the result:" & w2)
                Console.ReadKey()
        End Select
    End Sub
End Module
