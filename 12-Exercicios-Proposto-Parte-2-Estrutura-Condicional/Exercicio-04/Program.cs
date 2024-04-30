namespace Exercicio_04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
             *  Leia a hora inicial e a hora final de um jogo. A seguir calcule a duração do jogo, sabendo que o mesmo pode
                começar em um dia e terminar em outro, tendo uma duração mínima de 1 hora e máxima de 24 horas.
                Exemplos:
                Entrada:        Saída:
                16 2            O JOGO DUROU 10 HORA(S)
                Entrada:        Saída:
                0 0             O JOGO DUROU 24 HORA(S)
                Entrada:        Saída:
                2 16            O JOGO DUROU 14 HORA(S)
            */

            string[] valores = Console.ReadLine().Split(' ');
            int horaInicial = int.Parse(valores[0]);
            int horaFinal = int.Parse(valores[1]);

            int duracao;
            if (horaInicial < horaFinal)
            {
                duracao = horaFinal - horaInicial;
            }
            else
            {
                duracao = 24 - horaInicial + horaFinal;
            }

            Console.WriteLine("O JOGO DUROU " + duracao + " HORA(S)");
        }
    }
}
