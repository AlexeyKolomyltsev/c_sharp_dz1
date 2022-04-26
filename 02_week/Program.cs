Console.WriteLine("Ввести день недели");
string day = Console.ReadLine();
if(day == "1")
{
    Console.WriteLine(day + " день недели понедельник");
}
else if(day == "2")
{
    Console.WriteLine(day + " день недели вторник");
}
else if(day == "3")
{
    Console.WriteLine(day + " день недели среда");
}
else if(day == "4")
{
    Console.WriteLine(day + " день недели четверг");
}
else if(day == "5")
{
    Console.WriteLine(day + " день недели пятница");
}
else if(day == "6")
{
    Console.WriteLine(day + " день недели суббота");
}
else if(day == "7")
{
    Console.WriteLine(day + " день недели воскресенье");
}
else
{
    Console.WriteLine("Нет такого дня недели");
}