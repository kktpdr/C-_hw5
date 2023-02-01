void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = new Random().Next(1,10);
        }
}
void PrintArray(int[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + " ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.Write("Print array size: ");
int size = int.Parse(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);

int sum = 0;

for (int a = 0; a < numbers.Length; a+=2)
{
    sum = sum + numbers[a];
}
Console.WriteLine($"{sum} sum of uncountable");