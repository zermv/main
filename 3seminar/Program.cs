Console.WriteLine("Введите координату х первой точки");
int x1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y первой точки");
int y1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату х второй точки");
int x2 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите координату y второй точки");
int y2 = Convert.ToInt32(Console.ReadLine());


double d = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
//double x = Math.Pow((x2 - x1), 2);
//double y = Math.Pow((y2 - y1), 2);
//double d = Math.Sqrt(x+y);

Console.WriteLine("Длина отрезка равна " + (d));
