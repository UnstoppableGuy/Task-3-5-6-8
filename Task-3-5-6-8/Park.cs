using System;
using System.Collections.Generic;
using System.Text;

namespace Task_3_5_6_8
{
    class Park<T>
    {
        T[] autopark;
        public int Length { get; private set; }
        public Park(int amount)
        {

            autopark = new T[amount];
            Length = amount;
        }
        public T this[int index]
        {
            get
            {
                if (index >= 0 && index < Length)
                    return autopark[index];
                else
                    return autopark[0];
            }
            set
            {
                if (index >= 0 && index <= Length)
                    autopark[index] = value;
                else
                    Console.WriteLine("Error 404");
            }
        }
    }
}
