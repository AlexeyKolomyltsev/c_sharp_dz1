// Показать четные числа от 1 до N
Console.Write("Put number N ");
int a = int.Parse(Console.ReadLine());
int count = 2;
Console.WriteLine($"Четные числа от 1 до {a}:");
while (count <= a)
{
    Console.Write(count + " ");
    count += 2;
}