int m = 0;
Console.Write("Введите количество чисел: ");
int.TryParse(Console.ReadLine(), out m);

int[] array = new int[m];
for (int i = 0; i < m; i++)
{
  
  Console.Write($"Введите {i+1} число : ");
  array[i] = int.Parse(Console.ReadLine());
  
}

void PrintArray(int[] arr)
{
  for (int i = 0; i < m; i++)
  {
      
    Console.Write($"{arr[i]} ");
       
  }
}
PrintArray(array);

int CountPositiveNumbers (int [] array)
{
  int count = 0;
  for (int i = 0; i < array.Length; i++)
  {
    if (array[i]>0) count+=1;
  }
  return count;
}
Console.WriteLine($"-> {CountPositiveNumbers(array)}");
