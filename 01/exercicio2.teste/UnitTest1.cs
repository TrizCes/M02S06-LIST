using exercicio1;

namespace exercicio2.teste;


public class Tests
{
  [SetUp]
  public void Setup()
  {
  }

  [Test]
  public void TestSoma()
  {
    List<int> testSoma = new List<int>() { 4, 5, 6, 7, 8, -5, -6, -7, -8 };
    int result = Soma.SumList(testSoma);
    int rightResult = 4;
    Assert.AreEqual(result, rightResult);
  }
}