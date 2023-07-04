// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] numbers = new double[4];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int a = 0; a < numbers.Length; a++)
{
  if (numbers[a] > max)
  {
    max = numbers[a];
  }
  if (numbers[a] < min)
  {
    min = numbers[a];
  }
}

Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива, равна: {max - min}");

void FillArrayRandomNumbers(double[] numbers)
{
 for(int i = 0; i < numbers.Length; i++)
 {
    numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 100;
 }
}

void PrintArray(double[] numbers)
{
  for(int i = 0; i < numbers.Length; i++)
  {
  Console.Write("[" + string.Join(", ", numbers) + "]");
  break;
  }
  Console.WriteLine();
}
