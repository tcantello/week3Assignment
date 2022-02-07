using System;

namespace Week3Assignment
{
    public class Car
    {
        public string make;
        public string model;
        public int speed;
        public int speedDiff;
        public int demerits;
        public string licStatus;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the speed limit: ");
            int SpeedLimit = Convert.ToInt32(Console.ReadLine());

            var car = new Car();
            Console.WriteLine("Enter the make of the vehicle: ");
            car.make = Console.ReadLine();
            Console.WriteLine("Enter the model of the vehicle: ");
            car.model = Console.ReadLine();
            Console.WriteLine("Enter the speed of the vehicle: ");
            car.speed = Convert.ToInt32(Console.ReadLine());

            car.demerits = (car.speed - SpeedLimit) / 5;

            if(car.demerits < 1)
            {
                car.licStatus = "Ok";
            }
            else if (car.demerits >= 10)
            {
                car.licStatus = "<LICENSE SUSPENDED>";
            }
            else
            {
                car.licStatus = " ";
            }

            var car1 = new Car();
            Console.WriteLine("Enter the make of the vehicle: ");
            car1.make = Console.ReadLine();
            Console.WriteLine("Enter the model of the vehicle: ");
            car1.model = Console.ReadLine();
            Console.WriteLine("Enter the speed of the vehicle: ");
            car1.speed = Convert.ToInt32(Console.ReadLine());

            car1.demerits = (car1.speed - SpeedLimit) / 5; 

            if (car1.demerits < 1)
            {
                car1.licStatus = "Ok";
            }
            else if (car1.demerits >= 10)
            {
                car1.licStatus = "<LICENSE SUSPENDED>";
            }
            else
            {
                car1.licStatus = " ";
            }

            var car2 = new Car();
            Console.WriteLine("Enter the make of the vehicle: ");
            car2.make = Console.ReadLine();
            Console.WriteLine("Enter the model of the vehicle: ");
            car2.model = Console.ReadLine();
            Console.WriteLine("Enter the speed of the vehicle: ");
            car2.speed = Convert.ToInt32(Console.ReadLine());

            car2.demerits = (car2.speed - SpeedLimit) / 5;

            if (car2.demerits < 1)
            {
                car2.licStatus = "Ok";
            }
            else if (car2.demerits >= 10)
            {
                car2.licStatus = "<LICENSE SUSPENDED>";
            }
            else
            {
                car2.licStatus = " ";
            }
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Speed Limit: " + SpeedLimit + "mph");
            Console.WriteLine();
            Console.WriteLine(car.make + " " + car.model + " " + car.speed + " mph: " + car.demerits + " demerits " + car.licStatus);
            Console.WriteLine(car1.make + " " + car1.model + " " + car1.speed + " mph: " + car1.demerits + " demerits " + car1.licStatus);
            Console.WriteLine(car2.make + " " + car2.model + " " + car2.speed + " mph: " + car2.demerits + " demerits " + car2.licStatus);
        }
    }
}