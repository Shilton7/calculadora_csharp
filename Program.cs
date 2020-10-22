using System;

namespace calculadora_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Menu();
    }

    static void Menu()
    {
      Console.Clear();

      Console.WriteLine("Bem vindo a calculadora, o que deseja fazer ?");
      Console.WriteLine("");
      Console.WriteLine("1 - Soma");
      Console.WriteLine("2 - Subtração");
      Console.WriteLine("3 - Divisão");
      Console.WriteLine("4 - Multiplicação");
      Console.WriteLine("0 - Sair");

      Console.WriteLine("---------------");
      Console.WriteLine("Selecione uma opção:");

      int opcao = int.Parse(Console.ReadLine());

      switch (opcao)
      {
        case 1: Soma(); break;
        case 2: Substracao(); break;
        case 3: Divisao(); break;
        case 4: Multiplicacao(); break;
        case 0: Sair(); break;
        default: Menu(); break;
      }

    }

    static void Soma()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor: ");
      float num1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor: ");
      float num2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = num1 + num2;
      Console.WriteLine($"O resultado da soma é: {resultado}");

      Console.ReadKey();
      Menu();
    }

    static void Substracao()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor: ");
      float num1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor: ");
      float num2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = num1 - num2;
      Console.WriteLine($"O resultado da subtração é: {resultado}");

      Console.ReadKey();
      Menu();
    }

    static void Divisao()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor: ");
      float num1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor: ");
      float num2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = num1 / num2;
      Console.WriteLine($"O resultado da divisão é: {resultado}");

      Console.ReadKey();
      Menu();
    }

    static void Multiplicacao()
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor:");
      float num1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor:");
      float num2 = float.Parse(Console.ReadLine());

      float resultado = num1 * num2;
      Console.WriteLine($"O resultado da multiplicação é: {resultado}");

      Console.ReadKey();
      Menu();
    }

    static void Sair()
    {
      System.Environment.Exit(0);
    }
  }
}
