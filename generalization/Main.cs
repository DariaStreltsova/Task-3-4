using System;




namespace generalization
{
   class Program
   {
       static void Main(){
        Int intob = new Int();
        Double doubleob = new Double();
        Bool boolob = new Bool();
        String stringob = new String();

        IPrinter[] array = new IPrinter[8];

        Console.WriteLine("Введите тип заполнения массива. Введите true, если заполняете вручную, false - рандомно");
        bool UsIn = bool.Parse(Console.ReadLine()); 

        OneDimensionalArray<int> intar = new OneDimensionalArray<int>(intob, UsIn);
        array[0] = intar;
        OneDimensionalArray<double> doublear = new OneDimensionalArray<double>(doubleob, UsIn);
        array[1] = doublear;
        OneDimensionalArray<bool> boolar = new OneDimensionalArray<bool>(boolob, UsIn);
        array[2] = boolar;
        OneDimensionalArray<string> stringar = new OneDimensionalArray<string>(stringob, UsIn);
        array[3] = stringar;

        TwoDimensionalArray<int> intar2 = new TwoDimensionalArray<int>(intob, UsIn);
        array[4] = intar2;
        TwoDimensionalArray<double> doublear2 = new TwoDimensionalArray<double>(doubleob, UsIn);
        array[5] = doublear2;
        TwoDimensionalArray<bool> boolar2 = new TwoDimensionalArray<bool>(boolob, UsIn);
        array[6] = boolar2;
        TwoDimensionalArray<string> stringar2 = new TwoDimensionalArray<string>(stringob, UsIn);
        array[7] = stringar2;

        foreach(IPrinter i in array){
            Console.WriteLine($"{i.GetType()} массив: \n");
            i.Print();
            Console.WriteLine();
        }
            

       }
   }
}
