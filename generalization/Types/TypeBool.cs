using System;

namespace generalization
{
    class Bool : IBase<bool>
    {
        public bool RandomValue()
        {
            Random rnd = new Random();
            bool[] _bool = new bool[2]{true, false};
            return _bool[rnd.Next(0, 2)];
        }
        public bool UserValue()
        {
            bool a = bool.Parse(Console.ReadLine());
            return a;
        }
    }
}