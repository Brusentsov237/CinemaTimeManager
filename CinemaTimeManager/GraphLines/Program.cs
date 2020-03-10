using System;
using System.Collections.Generic;

namespace GraphLines
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Node> resultEnds = new List<Node>();

            Console.WriteLine("Введите длину рабочего дня кинотеатра в минутах:");
            int timeLeft = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество залов:");
            int hallsCount = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите количество фильмов:");
            int count = Convert.ToInt32(Console.ReadLine());
            var names = new string[count];
            var duration = new int[count];

            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Введите название и длительность сеанса №{i+1} в минутах.");
                names[i] = Console.ReadLine();
                duration[i] = Convert.ToInt32(Console.ReadLine());
            }

            
            

            CinemaTimeManager gl = new CinemaTimeManager(new Node( timeLeft, names, duration, "РАСПИСАНИЕ: \n", new List<string>()));
            gl.CreateShedules();
            gl.DisplayAnswer();
            resultEnds = gl.Sort();
            foreach( Node node in resultEnds)
            {

            }
        }
    }
}
