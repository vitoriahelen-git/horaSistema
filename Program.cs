using System;

namespace horaSistema
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Data e Hora do sistema");
            DateTime datahora = DateTime.Now;
            Console.Write($"Nesse momento são exatamente: {datahora} ");

            
        }
    }
}
