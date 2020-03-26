using System;
using System.Collections.Generic;
using System.Text;

namespace Automobile
{
    class Auto
    {
        private int Max_Speed;
        private int Weight;
        public string Car_number { get; set; }
        public Auto() : this(0, 0, "NaN") { }
        public Auto(int max_speed) : this(max_speed, 0, "NaN") { }
        public Auto(int MaxSpeed, int Weight) : this(MaxSpeed, Weight, "NaN") { }
        public Auto(int max_speed, int weight, /*string mark,*/ string car_number /*int engine_power*/)
        {
            Max_Speed = max_speed;
            Weight = weight;
            Car_number = car_number;
        }
        public int MaxSpeed
        {
            set
            {
                if (value <= 0)
                    Max_Speed = 0;
                else
                    Max_Speed = value;
            }
            get
            {
                return Max_Speed;
            }
        }
        public int _Weight
        {
            set
            {
                if (value <= 0)
                    Weight = 0;
                else
                    Weight = value;
            }
            get
            {
                return Weight;
            }
        }
        public void NewCar(int New_max_speed, int New_weight, string New_car_number)
        {
            Max_Speed = New_max_speed;
            Weight = New_weight;
            Car_number = New_car_number;
        }
        public void SetInfo()
        {
            Console.WriteLine($"Max Speed :{Max_Speed}\nWeight {Weight}\n Car number {Car_number}");
        }
    }
}