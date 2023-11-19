Console.Write("Введите значение M: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите значение N: ");
int n = Convert.ToInt32(Console.ReadLine());
PrintEvenNaturalNumbers(m, n);

void PrintEvenNaturalNumbers(int current, int end)
{
  if (current > end)
  {
    return;
  }
  if (current % 2 == 0)
  {
    Console.Write($"{current}");
    if (current + 2 <= end && current != end - 1)
    {
      Console.Write(", ");
    }
  }
  PrintEvenNaturalNumbers(current + 1, end);
}
