namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;
            bool c1 = a < 10;
            bool c2 = a < 20;
            bool c3 = a > 10;
            bool c4 = a > 5;
            Console.WriteLine(c1); //False
            Console.WriteLine(c2); //True
            Console.WriteLine(c3); //False  
            Console.WriteLine(c4); //True
            Console.WriteLine("------------");
            bool c5 = a <= 10;
            bool c6 = a >= 10;
            bool c7 = a == 10;
            bool c8 = a != 10;
            Console.WriteLine(c5); //True
            Console.WriteLine(c6); //True
            Console.WriteLine(c7); //True
            Console.WriteLine(c8); //False 
        }
    }
}
