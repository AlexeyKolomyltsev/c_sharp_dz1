// Найти третью цифру числа или сообщить, что её нет
Console.Write("Введите число a ");
int a = int.Parse(Console.ReadLine());
int b = a, count = 0;
while (b > 0) /// подсчет длины числа а
{
    b = b / 10;
    count++;  
}

int n = 0;
if (count > 2)
{
    while (n < count - 3) ///отсекаем лишние цифры до тех пор, пока число не станет трехзначным
    {
        a = a / 10;
        n++;

    }
    a = a % 10; /// вытаскиваем третью цифру
    Console.WriteLine("Третья цифра числа а: " + a);
}
else Console.WriteLine("Число а имеет меньше трех знаков");