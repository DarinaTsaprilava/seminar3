//Загуглить формулу - формула AB = Корень из (xb - xa)2 + (yb -ya)2
double xb = Convert.ToInt32(Console.ReadLine());
double xa = Convert.ToInt32(Console.ReadLine());
double yb = Convert.ToInt32(Console.ReadLine());
double ya = Convert.ToInt32(Console.ReadLine());
double result = Math.Sqrt(Math.Pow((xb - xa), 2) - Math.Pow((yb - ya), 2) );
Console.WriteLine(result);