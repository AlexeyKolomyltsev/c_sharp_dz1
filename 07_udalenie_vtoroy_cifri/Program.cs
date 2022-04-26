// Удалить вторую цифру трёхзначного числа
Console.Write("Введите число в диапазоне 100 - 999 ");
int a = int.Parse(Console.ReadLine());
if (a < 100 || a > 999)
{
    Console.WriteLine("Число должно быть в диапазоне 100 - 999");
}
else
{
    a = a / 100 * 10 + a % 10;
    Console.WriteLine("Число без второй цифры " + a);
}