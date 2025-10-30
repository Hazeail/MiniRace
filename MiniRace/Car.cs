using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniRace
{
    class Car
    {
        public string name;
        public int speed; // текущяя скорость
        public int position; // текущяя позиция на трассе

        public Car(string name, int speed)
        {
            this.name = name;
            this.speed = speed;
        }
        public void Accelerate(int value)
        {
            speed += value;
        }
        public void Decelerate(int value)
        {
            if (value < speed)
            {
                speed -= value;
            }
            else
            {
                speed = 0;
            }
        }
        public void Move()
        {
            position += speed;
        }
        public void PrintStatus()
        {
            Console.WriteLine($"Машина: {name}, ее скорость: {speed} и позиция {position}");
        }
    }
}
