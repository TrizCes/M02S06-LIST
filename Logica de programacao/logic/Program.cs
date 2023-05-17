internal class Program
{
  private static void Main(string[] args)
  {
    List<int> numbers = new List<int>() { 1, 2, 3, -9 };
    List<int> newNumbers = new List<int>();
    for (int i = 0; i < numbers.Count; i++)
    {
      int number = numbers[i];
      newNumbers.Insert(0, number);
    }
    for (int j = 0; j < newNumbers.Count; j++)
    {
      System.Console.WriteLine(newNumbers[j]);
    }
  }
}
