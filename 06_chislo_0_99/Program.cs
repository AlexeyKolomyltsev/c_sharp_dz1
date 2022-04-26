///Дано число из отрезка [10, 99]. Показать наибольшую цифру числа
Console.Write("Put number a 10 - 99 ");
int a = int.Parse(Console.ReadLine());
int a1 = a / 10;
int a2 = a % 10;
if(a1 > a2) Console.Write(a1);
else Console.Write(a2);