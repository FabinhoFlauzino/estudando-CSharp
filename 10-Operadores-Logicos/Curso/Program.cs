namespace Curso
{
    class Program
    {
        static void Main(string[] args)
        {
            bool cond1 = 4 != 5;
            bool cond2 = 3 < 2 && 4 != 5;

            bool cond3 = 4 != 5 || 4 > 5;

            bool cond4 = !(2 > 3) && (4 != 5);

            Console.WriteLine(cond1);//True
            Console.WriteLine(cond2);//False
            Console.WriteLine(cond3);//True
            Console.WriteLine(cond4);//True

            Console.WriteLine("----------------");

            //Entendendo a precedencia
            // ! tem precendencia em && ee || 
            // && tem precedencia em ||

            bool cond5 = 10 < 5; //false
            bool cond6 = cond1 || cond3 && cond2; //true -> Primeiro resolve o && e depois o ||

            Console.WriteLine(cond5);
            Console.WriteLine(cond6);
        }
    }
}
