using System;

namespace deligatePractice
{
    public delegate int AddDeligate(int x, int y);
    class Program
    {
        public static int AddNum(int a ,int b)
        {
            return a + b;
        }

        public static string SayHello(string name)
        {
            return "Hello " + name;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(AddNum(1, 2));
            Console.WriteLine(SayHello("Akansha"));
        }
    }
}
