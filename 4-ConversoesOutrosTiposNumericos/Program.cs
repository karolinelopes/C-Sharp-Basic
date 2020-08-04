using System;

namespace _4_ConversoesOutrosTiposNumericos
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Executando o projeto 4");

            double salario;
            salario = 1200.50;
            Console.WriteLine(salario);

            //O int suporta até 32 bits
            int salarioEmInteiro;
            salarioEmInteiro = (int)salario;
            Console.WriteLine(salarioEmInteiro);

            //O long é variável de 64 bits
            long idade = 1300000000000000000;
            Console.WriteLine(idade);

            //O shorte suporta até 16 bits
            short quantidadeProdutos = 15000;
            Console.WriteLine(quantidadeProdutos);

            float altura = 1.80f;
            Console.WriteLine(altura);

            Console.WriteLine(salarioEmInteiro);
        }
    }
}
