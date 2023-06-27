// Задайте массив вещественных чисел. Найдите разницу 
// между максимальным и минимальным элементов массива.

// [3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

double[] array = new double[4];
double max = 0;
double min = 0;

for (int i = 0; i < array.Length; i++)
{
  array[i] = Math.Round(new Random().NextDouble()*100,2);

  if(max < array[i])
  {
    max = array[i];
  }
  else
  {
    min = array[i];
  }
}

Console.WriteLine("[" + string.Join(", ", array) + "]");
Console.WriteLine($"Максимальный элемент массива: {max}");
Console.WriteLine($"Минимальный элемент массива: {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементом массива, равна: {max - min}");

