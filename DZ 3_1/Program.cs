// Задача 21: Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53


/*System.Console.WriteLine("Введите координаты x точки А: ");

int[] coordsA = new int[3];

coordsA[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты y точки A: ");

coordsA[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты z точки A: ");

coordsA[2] = Convert.ToInt32(Console.ReadLine());

int[] coordsB = new int[3];

System.Console.WriteLine("Введите координаты x точки B: ");

coordsB[0] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты y точки B: ");

coordsB[1] = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine("Введите координаты z точки B: ");

coordsB[2] = Convert.ToInt32(Console.ReadLine());

int distanceX = (int) Math.Pow(coordsB[0]-coordsA[0], 2);
int distanceY = (int) Math.Pow(coordsB[1]-coordsA[1], 2);
int distanceZ = (int) Math.Pow(coordsB[2]-coordsA[2], 2);

double Result = Math.Sqrt (distanceX+distanceY+distanceZ);

System.Console.WriteLine(Math.Round(Result,2));
*/

int x1 = Coordinate("x", "A");
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName)
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");
    return Convert.ToInt32(Console.ReadLine());
}

double Decision(double x1, double x2,
                double y1, double y2,
                double z1, double z2)
{
    return Math.Sqrt(Math.Pow((x2 - x1), 2) +
                     Math.Pow((y2 - y1), 2) +
                     Math.Pow((z2 - z1), 2));
}

double segmentLength = Math.Round(Decision(x1, x2, y1, y2, z1, z2), 2);

Console.WriteLine($"{segmentLength}");