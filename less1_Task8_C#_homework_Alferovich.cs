Console.WriteLine("Пожалуйста, введите число: ");
int num = Convert.ToInt32(Console.ReadLine());
int size = 1;
while (size <= num)
{
    if (size % 2 == 0)
{
    Console.WriteLine($"{size}");
}
size++;
}
