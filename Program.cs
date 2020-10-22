using System;

namespace calculadora_csharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();

      Console.WriteLine("Digite o primeiro valor: ");
      float num1 = float.Parse(Console.ReadLine());

      Console.WriteLine("Digite o segundo valor: ");
      float num2 = float.Parse(Console.ReadLine());

      Console.WriteLine("");

      float resultado = num1 + num2;
      Console.WriteLine($"O resultado da soma é: {num1 + num2}");
      Console.WriteLine($"O resultado da soma é: {resultado}");
      Console.WriteLine("O resultado da soma é: " + resultado);

    }
  }
}
