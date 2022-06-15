using System;

namespace laba4s2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Airplane airplane = new(1300.5, 1, 180);
            Helicopter helicopter = new(10550.5, 3.5, "for passangers");
            Car car = new(2.500, 2.5, "Volkswagen");
            Train train = new(500, 5.5, 9);
            airplane.Move();
            car.Move();
            train.Move();
            helicopter.Move();
        }
        
    }
}
