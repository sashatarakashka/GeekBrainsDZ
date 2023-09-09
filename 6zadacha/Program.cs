Console.WriteLine("Введите число");
string text = Console.ReadLine();
int x = Convert.ToInt32(text);
if(x%2==0)
{
    Console.WriteLine("Число четное");
}
else
{
    Console.WriteLine("Число нечетное");
}
Console.ReadKey();