using System;

namespace generalization
{
    class String : IBase<string>
    {
        public string RandomValue()
        {
            Random rnd = new Random();
            string letters = "qwertyuiopasdfghjklzxcvbnmQWERTYUIOPASDFGHJKLZXCVBNM1234567890";
            string a = "";
            for(int i = 0; i < rnd.Next(0, 20); i ++)
            {
                a = a + letters[rnd.Next(0, letters.Length)];
            }
            return a;

        }
        public string UserValue()
        {
            return Console.ReadLine();
        }
    }
}