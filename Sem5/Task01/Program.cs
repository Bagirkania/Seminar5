
void FillArray(int [] num )
{
 for (int i = 0; i < num.Length; i++)
{
    num[i] = new Random().Next(100 , 1000);
}
}
    
void PrintArray(int[] num )
{
for (int i = 0; i < num.Length; i++)
{
    Console.Write(num[i] + " ");  
}
    Console.WriteLine();
}
void PrintChet(int [] num)
{
    int count = 0;
    for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0)
    {
      count ++;

    }
}
Console.WriteLine("Количество Четных чисел в массиве : " + count);
}
int [] numbers =  new int [5];
 FillArray(numbers);
 PrintArray(numbers);
 PrintChet(numbers);