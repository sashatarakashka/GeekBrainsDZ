Console.WriteLine("Введите два числа ");
string text = Console.ReadLine();
int a = Convert.ToInt32(text);
string _text2 = Console.ReadLine();
int b = Convert.ToInt32(_text2);
if (a>b)
{
    Console.WriteLine(a);
    Console.Write("Наибольшее число");
}
if (b>a)
{
    Console.WriteLine(b);
    Console.Write("Наибольшее число");
}
  Console.ReadKey();