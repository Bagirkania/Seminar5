
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
int SumNechetIndex(int [] num)
{
    int count = 0;
    int sum = 0;
    for (int i = 0; i < num.Length; i++)
{
    if (num[i] % 2 == 0) count ++;
    if (i % 2 == 1) sum += num[i];  
}
return sum;
}
int [] numbers =  new int [5];
 FillArray(numbers);
 PrintArray(numbers);
Console.WriteLine("Сумма элементов на нечетных позициях : " + SumNechetIndex(numbers));
