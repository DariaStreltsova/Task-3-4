using System;

namespace generalization
{
    class Double : IBase<double>
    {
        public double RandomValue()
        {
            Random rnd = new Random();
            return rnd.NextDouble();
        }
        public double UserValue()
        {
            return double.Parse(Console.ReadLine());
        }
    }
}