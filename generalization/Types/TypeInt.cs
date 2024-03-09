using System;

namespace generalization
{
    class Int : IBase<int>
    {
        public int RandomValue()
        {
            Random rnd = new Random();
            return rnd.Next(0, 255);
        }
        public int UserValue()
        {
            int a = int.Parse(Console.ReadLine());
            return a;
        }
    }
}