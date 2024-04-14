namespace _04ConversaoImplicitaeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Conversão implícita e casting
            float x = 4.5f;
            double y = x;
            Console.WriteLine(y);//4.5

            double a;
            float b;

            //Usando casting para converter
            a = 5.1;
            b = (float)a;
            Console.WriteLine(b);//5.1

            //Outro exemplo
            int d;
            d = (int)a;//Aqui perdemos informação
            Console.WriteLine(d); //5

            //
            int e = 5;
            int f = 2;

            //após casting 2,5
            double resultado = (double)e / f;

            //resultado será 2, pois dividiu 2 numeros inteiros, para evitar esse erro devemos fazer o casting na divisão
            Console.WriteLine(resultado); 
        }
    }
}
