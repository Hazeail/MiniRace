using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRace
{
    class Program
    {
        static void Main(string[] args)
        {
            // массив машин
            Car[] cars =
            {
                new Car("Audi", 5),
                new Car("BMW", 2),
                new Car("Toyota", 7),
                new Car("Hyndai", 1),
                new Car("Kia", 3)
            };

            // инифиализация переменных
            int finish = 100;
            int round = 1;
            Random random = new Random();
            string[] winner = new string[cars.Length];
            bool finishTime = false;
            int winnerIndex = 0;
            int scrollRating = 1;

            // логика гонки
            Console.WriteLine("\t== Старт гонки! ==");
            while (!finishTime)
            {
                Console.WriteLine($"\n\t== Ход {round++} ==\n");

                for (int i = 0; i < cars.Length; i++)
                {
                    if (cars[i].position < finish)
                    {
                        // случайное действие
                        int findRandom = random.Next(1, 3);
                        int accelerateRandom = random.Next(0, 8);
                        int decelerateRandom = random.Next(0, 4);
                        // вырианты случайного действия
                        if (findRandom == 1)
                            cars[i].Accelerate(accelerateRandom);
                        else
                            cars[i].Decelerate(decelerateRandom);

                        // передвижение и печать статуса машин
                        cars[i].Move();
                        cars[i].PrintStatus();

                        // логика сбора данных о гонке
                        if (cars[i].position >= finish)
                        {
                            winner[winnerIndex] = cars[i].name;
                            winnerIndex++;
                        }
                        // логика завершения
                        if (winner[winner.Length - 1] != null)
                        {
                            Console.WriteLine($"\n\tПобедитель гонки: {winner[0]}!");

                            for (int j = 0; j < winner.Length; j++)
                            {
                                Console.WriteLine($"{scrollRating++} место занял {winner[j]}");
                            }
                            finishTime = true;
                            break;
                        }
                        else // пропуск хода уже доехавшей машины
                        {
                            continue;
                        }
                    }
                }
            }
        }
    }
}
