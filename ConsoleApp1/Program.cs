using System;


namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            ///TODO
            ///segundo commit
            ///
            string nombre = "Jesús";
            string apellidoPaterno = "Jiménez";
            string apellidoMaterno = "Rendón";
            double edad = 27.60;
            int a = 5;
            int b = 4;
            int c = 2;
            int d = (a + b) * c;
            double radius = 2.50;
            double area = Math.PI * radius * radius;
            
            Console.WriteLine($"HOLA {nombre} {apellidoPaterno} {apellidoMaterno} edad {edad.ToString("F2")}");
            // EJEMPLOS CON CADENAS
            string greeting = "      Hello World!       ";
            Console.WriteLine($"[{greeting}]");

            string trimmedGreeting = greeting.TrimStart();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.TrimEnd();
            Console.WriteLine($"[{trimmedGreeting}]");

            trimmedGreeting = greeting.Trim();
            Console.WriteLine($"[{trimmedGreeting}]");

            // TRABAJO CON CADENAS CONTAINS
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));
            //BUSQUEDAS 
            Console.WriteLine(songLyrics.StartsWith("You"));
            Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hellow"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));
            //int d = b + a / b * c;
            Console.WriteLine(d);

            byte max = byte.MaxValue;
            byte min = byte.MinValue;
            byte maximed = 255;
            Console.WriteLine($"The range of integers is {min} to {max}");
            Console.WriteLine(maximed);
            Console.WriteLine(area);
            Console.ReadLine();

        }
    }
}
