///Показать вторую цифру трёхзначного числа
Console.Write("Put number a ");
int a = int.Parse(Console.ReadLine());
if (a > 99 &&  a < 1000)
{
    Console.Write("Вторая цифра введенного трехзначного числа " + a / 10 % 10);
}
else Console.Write("Введенное число не трехзначеое");