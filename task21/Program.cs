
Console.WriteLine("Введите координаты первой точки");

Console.Write("X1: ");
int x1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y1: ");
int y1 = Convert.ToInt32(Console.ReadLine());

Console.Write("Z1: ");
int z1= Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки");

Console.Write("X2: ");
int x2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Y2: ");
int y2 = Convert.ToInt32(Console.ReadLine());

Console.Write("Z2: ");
int z2 = Convert.ToInt32(Console.ReadLine());


double Distance(int x1, int y1, int z1, int x2, int y2, int z2)
{
    return Math.Sqrt(
        Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2) + Math.Pow(z2 - z1, 2)
    );

}

double distance = Math.Round(Distance(x1, y1, z1, x2, y2, z2), 2);
Console.WriteLine(distance);

