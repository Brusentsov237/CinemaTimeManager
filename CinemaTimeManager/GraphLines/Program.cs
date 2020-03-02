﻿using System;
using System.Collections.Generic;

namespace GraphLines
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите длину рабочего дня кинотеатра в минутах:");
            int timeLeft = Convert.ToInt32(Console.ReadLine());
            
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

            Console.WriteLine("Могут ли повторяться фильмы?(да/нет)");
            string answ = Console.ReadLine();
            bool allowReiteration = false;
            if(answ == "да")
            {
                allowReiteration = true;
            }
            

            CinemaTimeManager gl = new CinemaTimeManager(new Node( timeLeft, names, duration, "РАСПИСАНИЕ: \n", new List<string>()), allowReiteration);
            gl.CreateShedules();
            gl.DisplayAnswer();
        }
    }
}