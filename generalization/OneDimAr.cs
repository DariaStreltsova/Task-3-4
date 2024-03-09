using System;


namespace generalization
{
    sealed class OneDimensionalArray<T> : BaseClass<T>
    {
        private T[] array;
        private int n;
        public OneDimensionalArray(IBase<T> type, bool InputByUser = false) : base(type, InputByUser) { }

        protected override void RandomInput(){
            Random rnd = new Random();
            n = rnd.Next(1, 10);
            array = new T[n];
            for(int i = 0; i < array.Length; i ++)
            {
                array[i] = type.RandomValue();
            }
        }
    
        protected override void UserInput(){
            Console.WriteLine("Введите количество элементов одномерного массива");
            int n = int.Parse(Console.ReadLine());

            array = new T[n];

            for(int i = 0; i < array.Length; i ++)
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
                array[i] = type.UserValue();
            }
        }
    
        public override void Print(){
            for(int i = 0; i < array.Length; i ++){
                Console.Write(array[i] + " ");
            }
        }
    }
}