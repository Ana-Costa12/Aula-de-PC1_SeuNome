using System;

namespace Aula_de_PC1_SeuNome
{
    class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string sobrenome;
            string Nomecompleto;

            Console.WriteLine("Escreva seu nome:");
            nome = Console.ReadLine();
            Console.WriteLine("Agora, escreva o seu sobrenome:");
            sobrenome = Console.ReadLine();
            Nomecompleto = $"{nome} {sobrenome}";
            Console.Clear();

            Console.WriteLine("Seja bem vindo(a): \n");
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"{Nomecompleto}\n");
            Console.ResetColor();
            Console.WriteLine("Seu nome catálogo é: \n");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine($"{sobrenome.ToUpper()},{nome}");
            Console.ResetColor();

        }
    }
}
