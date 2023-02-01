Console.Write("Print array size: ");
int size = Convert.ToInt32(Console.ReadLine());
int[] numbers = new int[size];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
int count = 0;

for (int a = 0; a < numbers.Length; a++)
if (numbers[a] % 2 == 0)
count++;

Console.WriteLine($" {count} countable");

void FillArrayRandomNumbers(int[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
    {
        numbers[i] = new Random().Next(100,1000);
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