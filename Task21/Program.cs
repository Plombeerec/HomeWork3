//Напишите программу, которая принимает на вход координаты двух точек 
//и находит расстояние между ними в 3D пространстве.
//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53


double FindCoord(double x1, double y1, double z1, double x2, double y2, double z2)
{
    double result = 0;
    
    double x = Math.Pow((x1 - x2) ,2);
    double y = Math.Pow((y1 - y2) ,2);
    double z = Math.Pow((z1 - z2) ,2);
    result = Math.Sqrt(x + y + z);
    return result;
}
Console.Write("Введите координаты точки А (x)");
int Xx1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А (y)");
int Xy1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки А (z)");
int Xz1 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B (x)");
int Xx2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B (y)");
int Xy2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите координаты точки B (z)");
int Xz2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(FindCoord(Xx1 , Xy1 , Xz1 , Xx2 , Xy2 , Xz2));