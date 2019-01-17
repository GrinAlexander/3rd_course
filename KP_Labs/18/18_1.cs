using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    class Film
    {
        public string Name {get; set;}
        public int Duration { get; set; }
        public string Genre { get; set; }

        public Film (string name, int duration, string genre)
        {
            Name = name;
            Duration = duration;
            Genre = genre;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            First();
            Second();
        }
        static void First()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("Задание 1:");
            try
            {
                List<long> list = new List<long> { 6, -15, 9, -9 };
                List<long> tempList = new List<long>();
                foreach (long item in list)
                {
                    tempList.Add(Math.Abs(item));
                }
                list.AddRange(tempList);

                Console.WriteLine("\nЗадание 1.1:");
                foreach (long item in list)
                {
                    Console.Write($"{item} ");
                }

                short sh = 228;
                list.Add((long)sh);
                Console.WriteLine("\nЗадание 1.2:");
                foreach (long item in list)
                {
                    Console.Write($"{item} ");
                }

                for (int i = 0; i < list.Count - 1; i++)
                {
                    if (list[i] > list[i + 1])
                    {
                        list.RemoveAt(i);
                    }
                }

                Console.WriteLine("\nЗадание 1.3:");
                foreach (long item in list)
                {
                    Console.Write($"{item} ");
                }
            }
            catch
            {

                Console.WriteLine("Ошибка!");
            }
            
            Console.ReadLine();
        }

        static void Second()
        {

            Console.WriteLine("-------------------");
            Console.WriteLine("Задание 2:");
            try
            {
                List<Film> films = new List<Film>();
                bool correctness = false;

                Console.WriteLine("Задание 2.1:");
                Console.Write("Количество фильмов: ");
                int n = 0, duration = 0;
                string name = null, genre = null;
                
                while (!correctness)
                { 
                    try
                    {
                        n = Convert.ToInt32(Console.ReadLine());
                        correctness = true;
                    }
                    catch
                    {
                        Console.WriteLine("Некорректное значение!");
                        correctness = false;
                        
                    }
                }

                correctness = false;
                for (int i = 0; i < n; i++)
                {
                    while (!correctness)
                    {
                        try
                        {
                            Console.Write("Название: ");
                            name = Console.ReadLine();
                            Console.Write("Длительность: ");
                            duration = Convert.ToInt32(Console.ReadLine());
                            Console.Write("Жанр: ");
                            genre = Console.ReadLine();
                            correctness = true;

                        }
                        catch
                        {

                            Console.WriteLine("Попробуй ещё раз!");
                            correctness = false;
                        }
                    }
                    films.Add(new Film(name, duration, genre));
                    correctness = false;
                }

                int minDuration = Int32.MaxValue, maxDuration = Int32.MinValue;
                foreach (Film film in films)
                {
                    if (film.Genre.ToLower() == "боевик")
                    {
                        if (film.Duration < minDuration)
                        {
                            minDuration = film.Duration;
                        }
                        if (film.Duration > maxDuration)
                        {
                            maxDuration = film.Duration;
                        }
                    }
                }

                films.Add(new Film("Война бесконечности", (maxDuration - minDuration) * 2, "Боевик"));
                Console.WriteLine($"Фильмов в списке: {films.Count}");
                foreach (Film film in films)
                {
                    Console.WriteLine($"\nНазвание: {film.Name} \nДлительность: {film.Duration} \nЖанр: {film.Genre}");
                }

            }
            catch
            {

                Console.WriteLine("Ошибка!");
            }
            Console.ReadLine();
        }
    }
}
