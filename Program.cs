using System;

namespace reajuste_salario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double sal, reaj;
            Console.WriteLine("informe o seu salario");
            sal = double.Parse(Console.ReadLine());
            if (sal <= 200)
            {
                Console.WriteLine("não recebe reajuste");
            }
            else
            {
                if (sal <= 400)
                {
                    reaj = sal * 1.2;
                    Console.WriteLine("o seu reajuste é de {0}", reaj);
                }
                else
                {
                    if ((sal > 400) || (sal <= 600))
                    {

                        reaj = sal * 1.3;
                        Console.WriteLine("o seu reajuste é de {0}", reaj);
                    }
                    else
                    {
                        reaj = sal * 1.4;
                        Console.WriteLine("os seu reajuste é de {0}", reaj);
                    }
                }
            }
        }
    }
    
}