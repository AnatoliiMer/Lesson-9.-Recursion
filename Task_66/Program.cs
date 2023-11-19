Console.Write("Введите значение M: ");
    int m = Convert.ToInt32(Console.ReadLine());
    Console.Write("Введите значение N: ");
    int n = Convert.ToInt32(Console.ReadLine());
    int sum = CalculateSumOfNaturalNumbers(m, n);
    Console.WriteLine($"Сумма натуральных чисел от {m} до {n} равна {sum}");
  
    int CalculateSumOfNaturalNumbers(int current, int end)
  {
    if (current > end)
    {
      return 0;
    }
    return current + CalculateSumOfNaturalNumbers(current + 1, end);
  }
