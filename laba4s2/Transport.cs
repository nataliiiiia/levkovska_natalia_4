using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba4s2
{
    interface ITransport
    {
        void Move();
        double Price { get; set; }
        double Time { get; set; }
        
    }
    public abstract class Flying_Object : ITransport
    {
        public double Price { get; set; }
        public double Time { get; set; }
        public string WhatUsesToFly { get; set; }
        public abstract void Move(); 
        
    }
    public class Airplane : Flying_Object
    {
        public override void Move() => Console.WriteLine($"Plane is flying\n" +
            $"The price of flight: {Price}\n" +
            $"The time of flight: {Time}\n" +
            $"Passangers with you: {NumberOfPassangers}\n");
        public int NumberOfPassangers { get; set; }
        public readonly new string WhatUsesToFly = "Wings";
        public Airplane(double Price, double Time, int NumberOfPassangers)
        {
            this.Price = Price;
            this.Time = Time;
            this.NumberOfPassangers = NumberOfPassangers;
        }
    }
    public class Helicopter : Flying_Object
    {
        public override void Move() => Console.WriteLine($"Helicopter is flying\n" +
            $"The price of flight: {Price}\n" +
            $"The time of flight: {Time}\n" +
            $"You are using helicopter {TypeOfHelicopter}\n");
        public string TypeOfHelicopter { get; set; }
        public readonly new string WhatUsesToFly = "Propeller";
        public Helicopter(double Price, double Time, string TypeOfHelicopter)
        {
            this.Price = Price;
            this.Time = Time;
            this.TypeOfHelicopter = TypeOfHelicopter;
            
        }
    }
    public class Car : ITransport
    {
        public void Move()
        {
            Console.WriteLine($"Car is moving\n" +
                $"The price of voyage: {Price}\n" +
                $"The time of voyage: {Time}\n" +
                $"The brand of car: {CarBrand}\n");
        }
        public double Price { get; set; }
        public double Time { get; set; }
        public string CarBrand { get; set; }
        public Car(double Price, double Time, string CarBrand)
        {
            this.CarBrand = CarBrand;
            this.Price = Price;
            this.Time = Time;
        }
    }
    public class Train : ITransport
    {
        public void Move()
        {
            Console.WriteLine($"Train is moving\n" +
                $"The price of voyage: {Price}\n" +
                $"The time of voyage: {Time}\n" +
                $"Number of carriages: {NumberOfCarriages}\n");
        }
        public double Price { get; set; }
        public double Time { get; set; }
        public int NumberOfCarriages { get; set; }
        public Train(double Price, double Time, int NumberOfCarriages)
        {
            this.NumberOfCarriages = NumberOfCarriages;
            this.Price = Price;
            this.Time = Time;
        }

    }
}
