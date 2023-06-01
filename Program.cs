using System;
using System.Globalization;



namespace salario
{

    class Program
    {
        static void Main(String[] args)
        {
            int salariofixo;
            double valorHora, salario;

           
            valorHora = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            salario = valorHora;

            Console.WriteLine("salariofixo = " + valorHora);














        }
    }
}