using System;
namespace generalization
{
    sealed class TwoDimensionalArray<T> : BaseClass<T>
    {
        private T[,] array;
        private int Length;
        private int Height;
        public TwoDimensionalArray(IBase<T> type, bool InputByUser = false) : base(type, InputByUser) { }
        protected override void RandomInput()
        {
            Random rnd = new Random();

            Length = rnd.Next(1, 10);
            Height = rnd.Next(1, 10);
            array = new T[Length, Height];

            for(int i = 0; i < Length; i ++)
            {
                for(int j = 0; j < Height; j ++)
                {
                    array[i, j] = type.RandomValue();
                }
            }
        }
    
        protected override void UserInput()
        {
            Console.WriteLine("Введите длину двумерного массива");
            Height = int.Parse(Console.ReadLine());
            Console.WriteLine("Введите высоту двумерного массива");
            Length = int.Parse(Console.ReadLine());
            array = new T[Length, Height];

            for(int i = 0; i < Length; i ++)
            {
                for(int j = 0; j < Height; j ++)
                {
                        if(typeof(T) == typeof(int))
                    {
                        Console.WriteLine("Введите int элемент");
                    }
                    if(typeof(T) == typeof(double))
                    {
                        Console.WriteLine("Введите double элемент");
                    }
                    if(typeof(T) == typeof(bool))
                    {
                        Console.WriteLine("Введите bool элемент");
                    }
                    if(typeof(T) == typeof(string))
                    {
                        Console.WriteLine("Введите string элемент");
                    }
                    array[i, j] = type.UserValue();
                }
            }
        }

        public override void Print(){
            for(int i = 0; i < Length; i ++){
                for(int j = 0; j < Height; j ++){
                    Console.Write(array[i, j] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}