using System;
using Automobile;
namespace Project_3
{
    class Program
    {
        public static int Input()
        {
            string number = Console.ReadLine();
            if (!int.TryParse(number, out int x))
            {
                Console.WriteLine("Error, Try again");
                return Input();
            }
            else
            {
                if (x < 0)
                {
                    Console.WriteLine("Error, Try again");
                    return Input();
                }
                else return x;
            }
        }
        public static Park<Auto> CreatePark()
        {
            Console.WriteLine("Enter amount of cars:");
            int size = Input();
            Park<Auto> park = new Park<Auto>(size);
            for (int t = 0; t < size; t++)
            {
                Console.WriteLine("You need to enter max speed, weight, car number");
                park[t] = new Auto(Input(), Input(), Console.ReadLine());
                Console.Clear();
            }
            return park;

        }
        public static void GetInfo(Park<Auto> cars)
        {
            Console.WriteLine("Full sheet of information:\n");
            for (int i = 0; i < cars.Length; i++)
            {
                Console.WriteLine($"Auto {(i + 1).ToString()}: {cars[i].MaxSpeed}, {cars[i]._Weight.ToString()}, {cars[i].Car_number}");
            }
        }
        public static Park<Auto> ChangeInfo(Park<Auto> cars)
        {
            Console.WriteLine("Enter number of Auto: ");
            int index = Input() - 1;
            Console.WriteLine("Enter new info Max speed, Weight, Car number): ");
            cars[index].NewCar(Input(), Input(), Console.ReadLine());
            Console.Clear();
            Console.WriteLine("New info is: ");
            cars[index].SetInfo();
            return cars;
        }
        static int Main(string[] args)
        {
            Console.Title = ("С#");
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();
            while (true)
            {
                Park<Auto> cars = CreatePark();
                GetInfo(cars);
                Console.WriteLine("Would you like to change information\nChoose 0 for change");
                if (Input() == 0)
                {
                    while (true)
                    {
                        Console.Clear();
                        cars = ChangeInfo(cars);
                        Console.Clear();
                        GetInfo(cars);
                        Console.WriteLine("Do you want to continue?\nEnter yes if you want");
                        if (Console.ReadLine() == "yes") { continue; }
                        else { break; }
                    }
                }
                else
                {
                    Console.WriteLine("Are you sure?\nEnter yes if you are sure");
                    if (Console.ReadLine() == "yes")
                    {
                        Console.WriteLine("You decision has been made");
                    }
                    else
                    {
                        while (true)
                        {
                            Console.Clear();
                            cars = ChangeInfo(cars);
                            Console.Clear();
                            GetInfo(cars);
                            Console.WriteLine("Do you want to continue?\nEnter yes if you want");
                            if (Console.ReadLine() == "yes") { continue; }
                            else { break; }
                        }
                    }
                }
                Console.WriteLine("Do you want to stop the program?");
                if (Console.ReadLine() == "yes")
                {
                    Console.Clear();
                    return 666;
                }
            }
        }
    }
}
