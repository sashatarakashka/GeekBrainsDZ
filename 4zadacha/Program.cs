Console.WriteLine("Введите три числа ");
string text = Console.ReadLine();
int a = Convert.ToInt32(text);
string _text2 = Console.ReadLine();
int b = Convert.ToInt32(_text2);
string _text3 = Console.ReadLine();
int c = Convert.ToInt32(_text3);
int max = a;

if (a > max) max = a ;
if (b > max) max = b;
if (c > max) max = c;

Console.Write("Большее число=");
Console.WriteLine(max);
  
  Console.ReadKey();