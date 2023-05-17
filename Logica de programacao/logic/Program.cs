internal class Program
{
  private static void Main(string[] args)
  {
    List<int> numbers = new List<int>() { 1, 7, 3, -9 };
    List<int> newNumbers = new List<int>();

    Console.WriteLine("Inverter ordem da lista de numeros");
    Console.Write("Lista original: ");
    for (int j = 0; j < numbers.Count; j++)
    {
      System.Console.Write(numbers[j] + ", ");
    }

    for (int i = 0; i < numbers.Count; i++)
    {
      int number = numbers[i];
      newNumbers.Insert(0, number);
    }

    Console.Write("\nNova ordem: ");
    for (int j = 0; j < newNumbers.Count; j++)
    {
      System.Console.Write(newNumbers[j] + ", ");
    }

    Console.WriteLine("\n\nOrdenando lista de numeros:");
    Console.Write("Lista original: ");
    for (int j = 0; j < numbers.Count; j++)
    {
      System.Console.Write(numbers[j] + ", ");
    }

    for (int i = 0; i < numbers.Count; i++)
    {
      int less = numbers[i];
      int bigger;
      for (int j = i; j < numbers.Count; j++)
      {
        if (numbers[i] > numbers[j])
        {
          less = numbers[j];
          bigger = numbers[i];
          numbers[i] = less;
          numbers[j] = bigger;
        }
      }
    }
    Console.Write("\nLista ordenada: ");
    for (int j = 0; j < numbers.Count; j++)
    {
      System.Console.Write(numbers[j] + ", ");
    }

  }
}
