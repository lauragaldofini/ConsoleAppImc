using System;
using System.Diagnostics.Eventing.Reader;

class Program
{
    static void Main(string[] args)
    {
        string[] nomes = new string[5];
        double[] pesos = new double[5];
        double[] alturas = new double[5];
        double[] imcs = new double[5];
        int acimaPesoIdeal = 0;


        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Digite o nome da {i + 1}ª pessoa:");
            nomes[i] = Console.ReadLine();

            Console.WriteLine($"Digite o peso (em kg) da {i + 1}ª pessoa:");
            pesos[i] = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Digite a altura (em metros) da {i + 1}ª pessoa:");
            alturas[i] = Convert.ToDouble(Console.ReadLine());

            imcs[i] = pesos[i] / (alturas[i] * alturas[i]);
        }

        Console.WriteLine("\n Dados das pessoas e classificação do IMC");
        for (int i = 0; i < 5; i++)
        {
            Console.WriteLine($"Nome: {nomes[i]}");
            Console.WriteLine($"Peso: {pesos[i]} kg");
            Console.WriteLine($"Altura: {alturas[i]} m");
            Console.WriteLine($"IMC: {imcs[i]}");

        }
        Console.ReadKey();
        for (int i = 0; i <= 4; i++)
        {
            if ((pesos[i] / (alturas[i] * alturas[i])) < 18.5) { Console.WriteLine("Está abaixo do peso ideal"); }
            else if ((pesos[i] / (alturas[i] * alturas[i])) < 24.9) { Console.WriteLine("Está no peso ideal"); }
            else if ((pesos[i] / (alturas[i] * alturas[i])) < 34.9) { Console.WriteLine("Obesidade grau I"); acimaPesoIdeal++; }
            else if ((pesos[i] / (alturas[i] * alturas[i])) < 39.9) { Console.WriteLine("Obesidade grau II"); acimaPesoIdeal++; }
            else Console.WriteLine("Obesidade III (mórbida)"); acimaPesoIdeal++; }
    }
}
        